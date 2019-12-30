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

namespace SabberStoneCore.CardSets.TavernBrawl
{
	public class TbCardsGen
	{
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK008h] Blood-Queen Lana'thel (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 43194
			// --------------------------------------------------------
			cards.Add("FB_LK008h", new CardDef(new Power
			{
				// TODO [FB_LK008h] Blood-Queen Lana'thel && Test: Blood-Queen Lana'thel_FB_LK008h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK_012h] Lord Marrowgar (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42447
			// --------------------------------------------------------
			cards.Add("FB_LK_012h", new CardDef(new Power
			{
				// TODO [FB_LK_012h] Lord Marrowgar && Test: Lord Marrowgar_FB_LK_012h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK_013h] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42876
			// --------------------------------------------------------
			cards.Add("FB_LK_013h", new CardDef(new Power
			{
				// TODO [FB_LK_013h] Professor Putricide && Test: Professor Putricide_FB_LK_013h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK_014h] Sindragosa (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 45627
			// --------------------------------------------------------
			cards.Add("FB_LK_014h", new CardDef(new Power
			{
				// TODO [FB_LK_014h] Sindragosa && Test: Sindragosa_FB_LK_014h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK_Raid_Hero] Supreme Lich King (*) - COST:0 [ATK:0/HP:400] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42457
			// --------------------------------------------------------
			cards.Add("FB_LK_Raid_Hero", new CardDef(new Power
			{
				// TODO [FB_LK_Raid_Hero] Supreme Lich King && Test: Supreme Lich King_FB_LK_Raid_Hero
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK_Raid_Hero_Battledamaged] Supreme Lich King (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42457
			// --------------------------------------------------------
			cards.Add("FB_LK_Raid_Hero_Battledamaged", new CardDef(new Power
			{
				// TODO [FB_LK_Raid_Hero_Battledamaged] Supreme Lich King && Test: Supreme Lich King_FB_LK_Raid_Hero_Battledamaged
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [FB_RagRaid_Hero] Big Bad Ragnaros (*) - COST:0 [ATK:0/HP:15000] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2660
			// --------------------------------------------------------
			cards.Add("FB_RagRaid_Hero", new CardDef(new Power
			{
				// TODO [FB_RagRaid_Hero] Big Bad Ragnaros && Test: Big Bad Ragnaros_FB_RagRaid_Hero
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [FB_SPT_AnnoyOPrime] Annoy-o-Tron Prime (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52653
			// --------------------------------------------------------
			cards.Add("FB_SPT_AnnoyOPrime", new CardDef(new Power
			{
				// TODO [FB_SPT_AnnoyOPrime] Annoy-o-Tron Prime && Test: Annoy-o-Tron Prime_FB_SPT_AnnoyOPrime
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [FB_Toki2] Infinite Toki (*) - COST:3 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: GILA_913, GILA_813, LOOTA_825
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48763
			// - HERO_DECK_ID = 1746
			// --------------------------------------------------------
			cards.Add("FB_Toki2", new CardDef(new[] {"GILA_913","GILA_813","LOOTA_825"}, new Power
			{
				// TODO [FB_Toki2] Infinite Toki && Test: Infinite Toki_FB_Toki2
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [FB_Toki_Hero] Toki, Time Tinker (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 50155
			// - HERO_DECK_ID = 1649
			// --------------------------------------------------------
			cards.Add("FB_Toki_Hero", new CardDef(new Power
			{
				// TODO [FB_Toki_Hero] Toki, Time Tinker && Test: Toki, Time Tinker_FB_Toki_Hero
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [HERO_FB_Juggernaut] Enemy Captain (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 479
			// --------------------------------------------------------
			cards.Add("HERO_FB_Juggernaut", new CardDef(new Power
			{
				// TODO [HERO_FB_Juggernaut] Enemy Captain && Test: Enemy Captain_HERO_FB_Juggernaut
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss1H_TB] White King (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40086
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss1H_TB", new CardDef(new Power
			{
				// TODO [KAR_a10_Boss1H_TB] White King && Test: White King_KAR_a10_Boss1H_TB
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss1H_TB22] White King (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40086
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss1H_TB22", new CardDef(new Power
			{
				// TODO [KAR_a10_Boss1H_TB22] White King && Test: White King_KAR_a10_Boss1H_TB22
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss2H_TB] Black King (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39801
			// - CANT_BE_FATIGUED = 1
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss2H_TB", new CardDef(new Power
			{
				// TODO [KAR_a10_Boss2H_TB] Black King && Test: Black King_KAR_a10_Boss2H_TB
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_207_BagOfSpells] Bag of Burgled Spells (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your spells summon a random minion of the same cost!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_HEALTH = 1
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_207_BagOfSpells", new CardDef(new Power
			{
				// TODO [TB_207_BagOfSpells] Bag of Burgled Spells && Test: Bag of Burgled Spells_TB_207_BagOfSpells
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_207_Cloneball] Cloneball! (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your deck is made of random Legendary minions, cloned four times!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_HEALTH = 1
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_207_Cloneball", new CardDef(new Power
			{
				// TODO [TB_207_Cloneball] Cloneball! && Test: Cloneball!_TB_207_Cloneball
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_207_ClonesAttack] When Clones Attack! (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Every minion you play will generate a 1/1 clone!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_HEALTH = 1
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_207_ClonesAttack", new CardDef(new Power
			{
				// TODO [TB_207_ClonesAttack] When Clones Attack! && Test: When Clones Attack!_TB_207_ClonesAttack
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_207_MaskedBall] The Masked Ball (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you summon a minion, give it "<b>Deathrattle:</b> Summon a minion that costs (2) less."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_HEALTH = 1
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_207_MaskedBall", new CardDef(new Power
			{
				// TODO [TB_207_MaskedBall] The Masked Ball && Test: The Masked Ball_TB_207_MaskedBall
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_207_Randomonium] Randomonium (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each turn your cards' cost are randomized!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_HEALTH = 1
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_207_Randomonium", new CardDef(new Power
			{
				// TODO [TB_207_Randomonium] Randomonium && Test: Randomonium_TB_207_Randomonium
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_207_TolBarad] Battle of Tol Barad (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Play a minion and get a random spell of the same cost, but for free!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_HEALTH = 1
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_207_TolBarad", new CardDef(new Power
			{
				// TODO [TB_207_TolBarad] Battle of Tol Barad && Test: Battle of Tol Barad_TB_207_TolBarad
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_207_TreasureCatacombs] Catacomb Treasures! (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Complete your quest to get an awesome treasure!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_HEALTH = 1
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_207_TreasureCatacombs", new CardDef(new Power
			{
				// TODO [TB_207_TreasureCatacombs] Catacomb Treasures! && Test: Catacomb Treasures!_TB_207_TreasureCatacombs
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_207_VoidSingularity] The Void Singularity (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your minions become crushed into a single powerful entity of light!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_HEALTH = 1
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_207_VoidSingularity", new CardDef(new Power
			{
				// TODO [TB_207_VoidSingularity] The Void Singularity && Test: The Void Singularity_TB_207_VoidSingularity
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_207_YellowBrick] Yellow-Brick Brawl (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Start the game with Dorothee!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_HEALTH = 1
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_207_YellowBrick", new CardDef(new Power
			{
				// TODO [TB_207_YellowBrick] Yellow-Brick Brawl && Test: Yellow-Brick Brawl_TB_207_YellowBrick
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [TB_BossRumble_001] Han'Cho (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_BossRumble_001", new CardDef(new Power
			{
				// TODO [TB_BossRumble_001] Han'Cho && Test: Han'Cho_TB_BossRumble_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [TB_BossRumble_002] Aya Blackpaw (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_BossRumble_002", new CardDef(new Power
			{
				// TODO [TB_BossRumble_002] Aya Blackpaw && Test: Aya Blackpaw_TB_BossRumble_002
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TB_BossRumble_003] Kazakus (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_BossRumble_003", new CardDef(new Power
			{
				// TODO [TB_BossRumble_003] Kazakus && Test: Kazakus_TB_BossRumble_003
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_BountyHunt_Azalina] Azalina Soulthief (*) - COST:0 [ATK:0/HP:50] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: [x]<i>Her children's safety
			//       is her top priority.
			//       At any cost.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48939
			// - HERO_DECK_ID = 1693
			// --------------------------------------------------------
			cards.Add("TB_BountyHunt_Azalina", new CardDef(new Power
			{
				// TODO [TB_BountyHunt_Azalina] Azalina Soulthief && Test: Azalina Soulthief_TB_BountyHunt_Azalina
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_BountyHunt_BloodWitch] Blood Witch Gretta (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Magic is powerful in her grove… but it comes at a cost.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48302
			// - HERO_DECK_ID = 1624
			// - 843 = 48399
			// --------------------------------------------------------
			cards.Add("TB_BountyHunt_BloodWitch", new CardDef(new Power
			{
				// TODO [TB_BountyHunt_BloodWitch] Blood Witch Gretta && Test: Blood Witch Gretta_TB_BountyHunt_BloodWitch
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_BountyHunt_Brushwood] Brushwood Centurion (*) - COST:0 [ATK:0/HP:60] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>This once-stalwart defender of the woods now sows chaos.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48597
			// - HERO_DECK_ID = 1655
			// --------------------------------------------------------
			cards.Add("TB_BountyHunt_Brushwood", new CardDef(new Power
			{
				// TODO [TB_BountyHunt_Brushwood] Brushwood Centurion && Test: Brushwood Centurion_TB_BountyHunt_Brushwood
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [TB_BountyHunt_Chupacabran] Chupacabran (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>It used to feed on local livestock. Now it hungers for more.</i>
			// --------------------------------------------------------
			// Entourage: GILA_BOSS_35t
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53410
			// - HERO_DECK_ID = 1629
			// - 843 = 48329
			// --------------------------------------------------------
			cards.Add("TB_BountyHunt_Chupacabran", new CardDef(new[] {"GILA_BOSS_35t"}, new Power
			{
				// TODO [TB_BountyHunt_Chupacabran] Chupacabran && Test: Chupacabran_TB_BountyHunt_Chupacabran
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [TB_BountyHunt_Experiment3C] Experiment 3C (*) - COST:0 [ATK:0/HP:60] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>It's a Murloc! It's a Dragon! It's... everything?</i>
			// --------------------------------------------------------
			// Entourage: GILA_BOSS_27t
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48270
			// - HERO_DECK_ID = 1621
			// - 843 = 48268
			// --------------------------------------------------------
			cards.Add("TB_BountyHunt_Experiment3C", new CardDef(new[] {"GILA_BOSS_27t"}, new Power
			{
				// TODO [TB_BountyHunt_Experiment3C] Experiment 3C && Test: Experiment 3C_TB_BountyHunt_Experiment3C
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_BountyHunt_Shudderwock] Shudderwock (*) - COST:0 [ATK:0/HP:50] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: [x]<i>And 'lo in uffish
			//       thought he stood, crying
			//       "Battle" in the wood.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48736
			// - HERO_DECK_ID = 1666
			// --------------------------------------------------------
			cards.Add("TB_BountyHunt_Shudderwock", new CardDef(new Power
			{
				// TODO [TB_BountyHunt_Shudderwock] Shudderwock && Test: Shudderwock_TB_BountyHunt_Shudderwock
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [TB_BountyHunt_Wharrgarbl] Wharrgarbl (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>The Witchwood's curse has not been kind to the local Murlocs.</i>
			// --------------------------------------------------------
			// Entourage: GILA_BOSS_37t
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48331
			// - HERO_DECK_ID = 1639
			// - 843 = 48330
			// --------------------------------------------------------
			cards.Add("TB_BountyHunt_Wharrgarbl", new CardDef(new[] {"GILA_BOSS_37t"}, new Power
			{
				// TODO [TB_BountyHunt_Wharrgarbl] Wharrgarbl && Test: Wharrgarbl_TB_BountyHunt_Wharrgarbl
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [TB_BountyHunt_Winslow] Winslow Tobtock (*) - COST:0 [ATK:0/HP:40] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>His tricks will leave you both in a daze.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 49001
			// - HERO_DECK_ID = 1699
			// --------------------------------------------------------
			cards.Add("TB_BountyHunt_Winslow", new CardDef(new Power
			{
				// TODO [TB_BountyHunt_Winslow] Winslow Tobtock && Test: Winslow Tobtock_TB_BountyHunt_Winslow
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_BountyHunter_Plaguemaster] Plaguemaster Rancel (*) - COST:0 [ATK:0/HP:40] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Dying to his touch is terrible. Living is even_worse.</i>
			// --------------------------------------------------------
			// Entourage: GILA_BOSS_68t
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 49683
			// - HERO_DECK_ID = 1769
			// --------------------------------------------------------
			cards.Add("TB_BountyHunter_Plaguemaster", new CardDef(new[] {"GILA_BOSS_68t"}, new Power
			{
				// TODO [TB_BountyHunter_Plaguemaster] Plaguemaster Rancel && Test: Plaguemaster Rancel_TB_BountyHunter_Plaguemaster
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_BuildaBoss_001] Catacomb Boss (*) - COST:0 [ATK:0/HP:80] 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_BuildaBoss_001", new CardDef(new Power
			{
				// TODO [TB_BuildaBoss_001] Catacomb Boss && Test: Catacomb Boss_TB_BuildaBoss_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_CoopHero_H_001] Coop Boss (*) - COST:0 [ATK:0/HP:100] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40221
			// --------------------------------------------------------
			cards.Add("TB_CoopHero_H_001", new CardDef(new Power
			{
				// TODO [TB_CoopHero_H_001] Coop Boss && Test: Coop Boss_TB_CoopHero_H_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [TB_DK_Anduin] Shadowreaper Anduin (*) - COST:8 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all minions with 5 or more_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - HERO_POWER = 45397
			// --------------------------------------------------------
			cards.Add("TB_DK_Anduin", new CardDef(new Power
			{
				// TODO [TB_DK_Anduin] Shadowreaper Anduin && Test: Shadowreaper Anduin_TB_DK_Anduin
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_DK_Garrosh] Scourgelord Garrosh (*) - COST:8 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: Equip a 4/3_Shadowmourne that also damages adjacent minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - HERO_POWER = 45585
			// --------------------------------------------------------
			cards.Add("TB_DK_Garrosh", new CardDef(new Power
			{
				// TODO [TB_DK_Garrosh] Scourgelord Garrosh && Test: Scourgelord Garrosh_TB_DK_Garrosh
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_DK_Guldan] Bloodreaver Gul'dan (*) - COST:10 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon all friendly Demons that_died_this_game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - HERO_POWER = 43181
			// --------------------------------------------------------
			cards.Add("TB_DK_Guldan", new CardDef(new Power
			{
				// TODO [TB_DK_Guldan] Bloodreaver Gul'dan && Test: Bloodreaver Gul'dan_TB_DK_Guldan
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TB_DK_Jaina] Frost Lich Jaina (*) - COST:9 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon a
			//       3/6 Water Elemental.
			//       Your Elementals have
			//       <b>Lifesteal</b> this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - HERO_POWER = 42944
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("TB_DK_Jaina", new CardDef(new Power
			{
				// TODO [TB_DK_Jaina] Frost Lich Jaina && Test: Frost Lich Jaina_TB_DK_Jaina
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [TB_DK_Malfurion] Malfurion the Pestilent (*) - COST:7 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Choose One -</b>
			//       Summon 2 <b>Poisonous</b>
			//       Spiders; or 2 Scarabs
			//       with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 43182
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("TB_DK_Malfurion", new CardDef(new Power
			{
				// TODO [TB_DK_Malfurion] Malfurion the Pestilent && Test: Malfurion the Pestilent_TB_DK_Malfurion
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [TB_DK_Rexxar] Deathstalker Rexxar (*) - COST:6 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 2 damage
			//       to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - HERO_POWER = 43183
			// --------------------------------------------------------
			cards.Add("TB_DK_Rexxar", new CardDef(new Power
			{
				// TODO [TB_DK_Rexxar] Deathstalker Rexxar && Test: Deathstalker Rexxar_TB_DK_Rexxar
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [TB_DK_Thrall] Thrall, Deathseer (*) - COST:5 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform your minions into random ones that cost (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - HERO_POWER = 42982
			// --------------------------------------------------------
			cards.Add("TB_DK_Thrall", new CardDef(new Power
			{
				// TODO [TB_DK_Thrall] Thrall, Deathseer && Test: Thrall, Deathseer_TB_DK_Thrall
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [TB_DK_Uther] Uther of the Ebon Blade (*) - COST:9 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip a 5/3 <b>Lifesteal</b> weapon.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - HERO_POWER = 43013
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("TB_DK_Uther", new CardDef(new Power
			{
				// TODO [TB_DK_Uther] Uther of the Ebon Blade && Test: Uther of the Ebon Blade_TB_DK_Uther
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [TB_DK_Valeera] Valeera the Hollow (*) - COST:9 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - HERO_POWER = 43188
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TB_DK_Valeera", new CardDef(new Power
			{
				// TODO [TB_DK_Valeera] Valeera the Hollow && Test: Valeera the Hollow_TB_DK_Valeera
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_EVILBRM_Atramedes] Atramedes (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>He eats E.V.I.L. for breakfast, but only if there’s nothing G.O.O.D. around.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2401
			// - HERO_DECK_ID = 2347
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Atramedes", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_Atramedes] Atramedes && Test: Atramedes_TB_EVILBRM_Atramedes
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_EVILBRM_BoomH] Dr. Boom (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57795
			// - HERO_DECK_ID = 2539
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_BoomH", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_BoomH] Dr. Boom && Test: Dr. Boom_TB_EVILBRM_BoomH
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [TB_EVILBRM_Garr] Garr (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>It’s gonna be a rocky road with no chance of marshmallows.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2325
			// - HERO_DECK_ID = 2348
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Garr", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_Garr] Garr && Test: Garr_TB_EVILBRM_Garr
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TB_EVILBRM_Geddon] Baron Geddon (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Whatever you do, never arm a Geddon.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2329
			// - HERO_DECK_ID = 2349
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Geddon", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_Geddon] Baron Geddon && Test: Baron Geddon_TB_EVILBRM_Geddon
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [TB_EVILBRM_HagathaH] Hagatha (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53294
			// - HERO_DECK_ID = 2542
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_HagathaH", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_HagathaH] Hagatha && Test: Hagatha_TB_EVILBRM_HagathaH
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [TB_EVILBRM_LazulH] Madame Lazul (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53289
			// - HERO_DECK_ID = 2540
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_LazulH", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_LazulH] Madame Lazul && Test: Madame Lazul_TB_EVILBRM_LazulH
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_EVILBRM_Nefarian] Nefarian (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Also goes by Victor Nefarius. He’s subtle like that.</i>
			// --------------------------------------------------------
			// Entourage: BRMA13_8, BRMA13_7, BRMA13_5, BRMA13_6
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2381
			// - HERO_DECK_ID = 2350
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Nefarian", new CardDef(new[] {"BRMA13_8","BRMA13_7","BRMA13_5","BRMA13_6"}, new Power
			{
				// TODO [TB_EVILBRM_Nefarian] Nefarian && Test: Nefarian_TB_EVILBRM_Nefarian
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [TB_EVILBRM_Omnotron01] Omnotron Defense System (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Programmed to delete all intruders!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2388
			// - HERO_DECK_ID = 2351
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Omnotron01", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_Omnotron01] Omnotron Defense System && Test: Omnotron Defense System_TB_EVILBRM_Omnotron01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_EVILBRM_Omokk] Highlord Omokk (*) - COST:0 [ATK:0/HP:15] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>He’ll show you a smashing time!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2338
			// - HERO_DECK_ID = 2352
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Omokk", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_Omokk] Highlord Omokk && Test: Highlord Omokk_TB_EVILBRM_Omokk
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_EVILBRM_Onyxia01] Onyxia (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57534
			// - HERO_DECK_ID = 2353
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Onyxia01", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_Onyxia01] Onyxia && Test: Onyxia_TB_EVILBRM_Onyxia01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_EVILBRM_RafaamH] Rafaam (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57696
			// - HERO_DECK_ID = 2543
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_RafaamH", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_RafaamH] Rafaam && Test: Rafaam_TB_EVILBRM_RafaamH
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TB_EVILBRM_Ragnaros01] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Excellent firelord and insect repeller.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2660
			// - HERO_DECK_ID = 2354
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Ragnaros01", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_Ragnaros01] Ragnaros the Firelord && Test: Ragnaros the Firelord_TB_EVILBRM_Ragnaros01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [TB_EVILBRM_TogwaggleH] King Togwaggle (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53291
			// - HERO_DECK_ID = 2541
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_TogwaggleH", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_TogwaggleH] King Togwaggle && Test: King Togwaggle_TB_EVILBRM_TogwaggleH
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TB_EVILBRM_Vaelastrasz] Vaelastrasz the Corrupt (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Too corrupt to care about your innocent little cards.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2358
			// - HERO_DECK_ID = 2567
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Vaelastrasz", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_Vaelastrasz] Vaelastrasz the Corrupt && Test: Vaelastrasz the Corrupt_TB_EVILBRM_Vaelastrasz
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_Firefest2_Ahune_H] Ahune The Frostlord (*) - COST:0 [ATK:0/HP:60] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46643
			// --------------------------------------------------------
			cards.Add("TB_Firefest2_Ahune_H", new CardDef(new Power
			{
				// TODO [TB_Firefest2_Ahune_H] Ahune The Frostlord && Test: Ahune The Frostlord_TB_Firefest2_Ahune_H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_Firefest2_Rag_H] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:60] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39009
			// --------------------------------------------------------
			cards.Add("TB_Firefest2_Rag_H", new CardDef(new Power
			{
				// TODO [TB_Firefest2_Rag_H] Ragnaros the Firelord && Test: Ragnaros the Firelord_TB_Firefest2_Rag_H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_FW_Rag] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:60] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2660
			// --------------------------------------------------------
			cards.Add("TB_FW_Rag", new CardDef(new Power
			{
				// TODO [TB_FW_Rag] Ragnaros the Firelord && Test: Ragnaros the Firelord_TB_FW_Rag
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H1] Headless Horseman (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H1", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_H1] Headless Horseman && Test: Headless Horseman_TB_HeadlessHorseman_H1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H1a] Headless Horseman (no head) (*) - COST:0 [ATK:0/HP:1] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H1a", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_H1a] Headless Horseman (no head) && Test: Headless Horseman (no head)_TB_HeadlessHorseman_H1a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H2] Stormwind Investigator (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_HeadlessHorseman_s001a, TB_HeadlessHorseman_s001c, TB_HeadlessHorseman_s001b
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H2", new CardDef(new[] {"TB_HeadlessHorseman_s001a","TB_HeadlessHorseman_s001c","TB_HeadlessHorseman_s001b"}, new Power
			{
				// TODO [TB_HeadlessHorseman_H2] Stormwind Investigator && Test: Stormwind Investigator_TB_HeadlessHorseman_H2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H2a] Stormwind Investigator Witch (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_HeadlessHorseman_s001a, TB_HeadlessHorseman_s001c, TB_HeadlessHorseman_s001b
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H2a", new CardDef(new[] {"TB_HeadlessHorseman_s001a","TB_HeadlessHorseman_s001c","TB_HeadlessHorseman_s001b"}, new Power
			{
				// TODO [TB_HeadlessHorseman_H2a] Stormwind Investigator Witch && Test: Stormwind Investigator Witch_TB_HeadlessHorseman_H2a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H2b] Stormwind Investigator Cat (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_HeadlessHorseman_s001a, TB_HeadlessHorseman_s001c, TB_HeadlessHorseman_s001b
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H2b", new CardDef(new[] {"TB_HeadlessHorseman_s001a","TB_HeadlessHorseman_s001c","TB_HeadlessHorseman_s001b"}, new Power
			{
				// TODO [TB_HeadlessHorseman_H2b] Stormwind Investigator Cat && Test: Stormwind Investigator Cat_TB_HeadlessHorseman_H2b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H2c] Stormwind Investigator Pirate (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_HeadlessHorseman_s001a, TB_HeadlessHorseman_s001c, TB_HeadlessHorseman_s001b
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H2c", new CardDef(new[] {"TB_HeadlessHorseman_s001a","TB_HeadlessHorseman_s001c","TB_HeadlessHorseman_s001b"}, new Power
			{
				// TODO [TB_HeadlessHorseman_H2c] Stormwind Investigator Pirate && Test: Stormwind Investigator Pirate_TB_HeadlessHorseman_H2c
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H2d] Stormwind Investigator Mummy (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_HeadlessHorseman_s001a, TB_HeadlessHorseman_s001c, TB_HeadlessHorseman_s001b
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H2d", new CardDef(new[] {"TB_HeadlessHorseman_s001a","TB_HeadlessHorseman_s001c","TB_HeadlessHorseman_s001b"}, new Power
			{
				// TODO [TB_HeadlessHorseman_H2d] Stormwind Investigator Mummy && Test: Stormwind Investigator Mummy_TB_HeadlessHorseman_H2d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [TB_Henchmania_George] George The Fallen (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46170
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_George", new CardDef(new Power
			{
				// TODO [TB_Henchmania_George] George The Fallen && Test: George The Fallen_TB_Henchmania_George
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_Henchmania_MrChu] Mr. Chu (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 55873
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_MrChu", new CardDef(new Power
			{
				// TODO [TB_Henchmania_MrChu] Mr. Chu && Test: Mr. Chu_TB_Henchmania_MrChu
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [TB_Henchmania_Myra] Myra Rotspring (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 55847
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_Myra", new CardDef(new Power
			{
				// TODO [TB_Henchmania_Myra] Myra Rotspring && Test: Myra Rotspring_TB_Henchmania_Myra
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_John_002h] King Togwaggle (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 52524
			// - HERO_DECK_ID = 1569
			// --------------------------------------------------------
			cards.Add("TB_John_002h", new CardDef(new Power
			{
				// TODO [TB_John_002h] King Togwaggle && Test: King Togwaggle_TB_John_002h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_KTRAF_H_1] Kel'Thuzad (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_H_1", new CardDef(new Power
			{
				// TODO [TB_KTRAF_H_1] Kel'Thuzad && Test: Kel'Thuzad_TB_KTRAF_H_1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_KTRAF_H_2] Rafaam (*) - COST:0 [ATK:0/HP:60] 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39236
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_H_2", new CardDef(new Power
			{
				// TODO [TB_KTRAF_H_2] Rafaam && Test: Rafaam_TB_KTRAF_H_2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [TB_LEAGUE_REVIVAL_BrannAIHero] Brann Bronzebeard (*) - COST:0 [ATK:0/HP:15] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: Last seen near the Un'Goro Crater.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 57862
			// - HERO_DECK_ID = 2600
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_BrannAIHero", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_BrannAIHero] Brann Bronzebeard && Test: Brann Bronzebeard_TB_LEAGUE_REVIVAL_BrannAIHero
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [TB_LEAGUE_REVIVAL_BrannHistory] Brann Bronzebeard (*) - COST:0 [ATK:0/HP:15] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: Work co-operatively with Brann to defeat King Krush, Untamed!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 57862
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_BrannHistory", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_BrannHistory] Brann Bronzebeard && Test: Brann Bronzebeard_TB_LEAGUE_REVIVAL_BrannHistory
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [TB_LEAGUE_REVIVAL_Elise] Elise the Enlightened (*) - COST:5 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 1123
			// - HERO_DECK_ID = 2602
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Elise", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Elise] Elise the Enlightened && Test: Elise the Enlightened_TB_LEAGUE_REVIVAL_Elise
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [TB_LEAGUE_REVIVAL_FinleyAIHero] Sir Finley (*) - COST:0 [ATK:0/HP:15] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 57862
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_FinleyAIHero", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_FinleyAIHero] Sir Finley && Test: Sir Finley_TB_LEAGUE_REVIVAL_FinleyAIHero
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [TB_LEAGUE_REVIVAL_FinleyHero] Sir Finley Mrrgglton (*) - COST:5 [ATK:0/HP:15] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: Last seen exploring the deserts of Tanaris.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_DECK_ID = 6
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_FinleyHero", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_FinleyHero] Sir Finley Mrrgglton && Test: Sir Finley Mrrgglton_TB_LEAGUE_REVIVAL_FinleyHero
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_LEAGUE_REVIVAL_FinleyHistory] Buried Finley (*) - COST:0 [ATK:0/HP:40] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Clear the Piles of Sand and damage Buried Finley to dig him up!
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 56785
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_FinleyHistory", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_FinleyHistory] Buried Finley && Test: Buried Finley_TB_LEAGUE_REVIVAL_FinleyHistory
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_LEAGUE_REVIVAL_FinleySandHero] Buried Finley (*) - COST:0 [ATK:0/HP:40] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - IMMUNE = 1
			// - HERO_POWER = 56785
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_FinleySandHero", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_FinleySandHero] Buried Finley && Test: Buried Finley_TB_LEAGUE_REVIVAL_FinleySandHero
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TB_LEAGUE_REVIVAL_RenoAIHero] Reno Jackson (*) - COST:0 [ATK:0/HP:15] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: Last seen "exploring" near the Dalaran Crater.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 57864
			// - HERO_DECK_ID = 2601
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_RenoAIHero", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_RenoAIHero] Reno Jackson && Test: Reno Jackson_TB_LEAGUE_REVIVAL_RenoAIHero
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TB_LEAGUE_REVIVAL_RenoHistory] Reno Jackson (*) - COST:0 [ATK:0/HP:15] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: Reno's out of control! Defeat him to bring him to his senses!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 57864
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_RenoHistory", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_RenoHistory] Reno Jackson && Test: Reno Jackson_TB_LEAGUE_REVIVAL_RenoHistory
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_LEAGUE_REVIVAL_TekahnAIHero] Dark Pharaoh Tekahn (*) - COST:0 [ATK:0/HP:15] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: A villain revealed!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 57866
			// - HERO_DECK_ID = 2604
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_TekahnAIHero", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_TekahnAIHero] Dark Pharaoh Tekahn && Test: Dark Pharaoh Tekahn_TB_LEAGUE_REVIVAL_TekahnAIHero
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [TB_LEAGUE_REVIVAL_Terraviss] Terraviss (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: A shadowy figure was spotted near the gates of Uldum.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 57859
			// - HERO_DECK_ID = 2603
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Terraviss", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Terraviss] Terraviss && Test: Terraviss_TB_LEAGUE_REVIVAL_Terraviss
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_MechWar_Boss1] Annoy-o-Tron (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			cards.Add("TB_MechWar_Boss1", new CardDef(new Power
			{
				// TODO [TB_MechWar_Boss1] Annoy-o-Tron && Test: Annoy-o-Tron_TB_MechWar_Boss1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_MechWar_Boss2] Boom Bot (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			cards.Add("TB_MechWar_Boss2", new CardDef(new Power
			{
				// TODO [TB_MechWar_Boss2] Boom Bot && Test: Boom Bot_TB_MechWar_Boss2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_SPT_Boss] City of Stormwind (*) - COST:0 [ATK:0/HP:1000] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39537
			// - HEALTH_DISPLAY = 1
			// - ENABLE_HEALTH_DISPLAY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_Boss", new CardDef(new Power
			{
				// TODO [TB_SPT_Boss] City of Stormwind && Test: City of Stormwind_TB_SPT_Boss
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_SPT_DPromo_Hero] Dark Wanderer (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42156
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromo_Hero", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromo_Hero] Dark Wanderer && Test: Dark Wanderer_TB_SPT_DPromo_Hero
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_SPT_DPromo_Hero2] The Cow King (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_POWER = 42156
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromo_Hero2", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromo_Hero2] The Cow King && Test: The Cow King_TB_SPT_DPromo_Hero2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_SPT_MTH_Boss] Decorated Stormwind (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39537
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Boss", new CardDef(new Power
			{
				// TODO [TB_SPT_MTH_Boss] Decorated Stormwind && Test: Decorated Stormwind_TB_SPT_MTH_Boss
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_SPT_MTH_Boss0] City of Stormwind (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39537
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Boss0", new CardDef(new Power
			{
				// TODO [TB_SPT_MTH_Boss0] City of Stormwind && Test: City of Stormwind_TB_SPT_MTH_Boss0
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_SPT_MTH_Boss2] Partytown Stormwind (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39537
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Boss2", new CardDef(new Power
			{
				// TODO [TB_SPT_MTH_Boss2] Partytown Stormwind && Test: Partytown Stormwind_TB_SPT_MTH_Boss2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_SPT_MTH_Boss3] Party Capital (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39537
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Boss3", new CardDef(new Power
			{
				// TODO [TB_SPT_MTH_Boss3] Party Capital && Test: Party Capital_TB_SPT_MTH_Boss3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [TB_TempleOutrun_Ammunae] Ammunae (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>He can teach you life lessons, but they're harsh ones.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57304
			// - HERO_DECK_ID = 2709
			// - HIDE_WATERMARK = 1
			// - 1205 = 10
			// - HEROIC_HERO_POWER = 59075
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Ammunae", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Ammunae] Ammunae && Test: Ammunae_TB_TempleOutrun_Ammunae
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_TempleOutrun_Battrund] Battrund (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Not all of Battrund's minions are mummies. Some_got_a_bad_wrap.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57232
			// - HERO_DECK_ID = 2698
			// - HIDE_WATERMARK = 1
			// - 1205 = 10
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Battrund", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Battrund] Battrund && Test: Battrund_TB_TempleOutrun_Battrund
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_TempleOutrun_BoomH] Dr. Boom (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57795
			// - HERO_DECK_ID = 2689
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_BoomH", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_BoomH] Dr. Boom && Test: Dr. Boom_TB_TempleOutrun_BoomH
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [TB_TempleOutrun_Brann] Brann Bronzebeard (*) - COST:0 [ATK:0/HP:15] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: [x]Riding on a dinosaur
			//       and looking for a fight, 
			//       Brann's ready to finish this.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57643
			// - MULTIPLE_CLASSES = 516
			// - HERO_DECK_ID = 2695
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Brann", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Brann] Brann Bronzebeard && Test: Brann Bronzebeard_TB_TempleOutrun_Brann
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_TempleOutrun_Colossus] Colossus of the Sun (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Sworn foe of anything that throws shade.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 59051
			// - HERO_DECK_ID = 2712
			// - HIDE_WATERMARK = 1
			// - 1203 = 10
			// - HEROIC_HERO_POWER = 59051
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Colossus", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Colossus] Colossus of the Sun && Test: Colossus of the Sun_TB_TempleOutrun_Colossus
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [TB_TempleOutrun_Elise] Elise Starseeker (*) - COST:0 [ATK:0/HP:15] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: [x]Whether she needs magic
			//       or a trusty machete, Elise 
			//       is ready to save Uldum.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57001
			// - MULTIPLE_CLASSES = 34
			// - HERO_DECK_ID = 2719
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Elise", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Elise] Elise Starseeker && Test: Elise Starseeker_TB_TempleOutrun_Elise
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [TB_TempleOutrun_Finley] Sir Finley (*) - COST:0 [ATK:0/HP:15] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: [x]Sir Finley rides into battle,
			//       ready to dispense justice 
			//       against his final foe.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57651
			// - MULTIPLE_CLASSES = 144
			// - HERO_DECK_ID = 2696
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Finley", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Finley] Sir Finley && Test: Sir Finley_TB_TempleOutrun_Finley
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [TB_TempleOutrun_Hagatha] Hagatha (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53294
			// - HERO_DECK_ID = 2692
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Hagatha", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Hagatha] Hagatha && Test: Hagatha_TB_TempleOutrun_Hagatha
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_TempleOutrun_HHnoHead] Headless Horseman (no head) (*) - COST:0 [ATK:0/HP:1] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <i>He's seen the battle in Uldum! Now he's here in this tomb!</i>
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_HHnoHead", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_HHnoHead] Headless Horseman (no head) && Test: Headless Horseman (no head)_TB_TempleOutrun_HHnoHead
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [TB_TempleOutrun_Ichabod] Ichabod the Cursed (*) - COST:0 [ATK:0/HP:20] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>He's reckless and infectious!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57233
			// - HERO_DECK_ID = 2714
			// - HIDE_WATERMARK = 1
			// - 1204 = 1
			// - HEROIC_HERO_POWER = 59049
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Ichabod", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Ichabod] Ichabod the Cursed && Test: Ichabod the Cursed_TB_TempleOutrun_Ichabod
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TB_TempleOutrun_Isiset] Isiset (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>She'll either spell your doom, or Twinspell it to show off!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57302
			// - HERO_DECK_ID = 2707
			// - HIDE_WATERMARK = 1
			// - 1205 = 10
			// - 1279 = 2511
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Isiset", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Isiset] Isiset && Test: Isiset_TB_TempleOutrun_Isiset
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_TempleOutrun_Jar] Totally Normal Jar (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>It's almost… TOO normal.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57276
			// - HERO_DECK_ID = 2702
			// - HIDE_WATERMARK = 1
			// - 1205 = 10
			// - 1279 = 2467
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Jar", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Jar] Totally Normal Jar && Test: Totally Normal Jar_TB_TempleOutrun_Jar
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [TB_TempleOutrun_Jythiros] Jythiros of Questions (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>[x]A riddle... within a
			//       mystery...in an enigma...
			//        with a funny head.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57289
			// - HERO_DECK_ID = 2711
			// - HIDE_WATERMARK = 1
			// - 1204 = 10
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Jythiros", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Jythiros] Jythiros of Questions && Test: Jythiros of Questions_TB_TempleOutrun_Jythiros
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [TB_TempleOutrun_Kasmut] Kasmut (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Can sniff out explorers and evildoers with ease.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57280
			// - HERO_DECK_ID = 2705
			// - HIDE_WATERMARK = 1
			// - 1204 = 10
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Kasmut", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Kasmut] Kasmut && Test: Kasmut_TB_TempleOutrun_Kasmut
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [TB_TempleOutrun_Kham] Kham (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Calm Kham down if you want to calmly down Kham.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57238
			// - HERO_DECK_ID = 2699
			// - HIDE_WATERMARK = 1
			// - 1204 = 10
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Kham", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Kham] Kham && Test: Kham_TB_TempleOutrun_Kham
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [TB_TempleOutrun_LazulH] Madame Lazul (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 59610
			// - HERO_DECK_ID = 2690
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_LazulH", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_LazulH] Madame Lazul && Test: Madame Lazul_TB_TempleOutrun_LazulH
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TB_TempleOutrun_LichBazhial] Lich Baz'hial (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Which league freezes faster? She must find out!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57281
			// - HERO_DECK_ID = 2701
			// - HIDE_WATERMARK = 1
			// - 1204 = 10
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_LichBazhial", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_LichBazhial] Lich Baz'hial && Test: Lich Baz'hial_TB_TempleOutrun_LichBazhial
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [TB_TempleOutrun_Octosari] Octosari (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>You can count on Octosari to keep the numbers balanced.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57311
			// - HERO_DECK_ID = 2704
			// - HIDE_WATERMARK = 1
			// - 1202 = 10
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Octosari", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Octosari] Octosari && Test: Octosari_TB_TempleOutrun_Octosari
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [TB_TempleOutrun_Pillager] Pillager Drasar (*) - COST:0 [ATK:0/HP:20] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>If she asks you about treasure, you don't have any!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57249
			// - HERO_DECK_ID = 2716
			// - HIDE_WATERMARK = 1
			// - 1205 = 10
			// - 1279 = 2435
			// - HEROIC_HERO_POWER = 59055
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Pillager", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Pillager] Pillager Drasar && Test: Pillager Drasar_TB_TempleOutrun_Pillager
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_TempleOutrun_RafaamH] Rafaam (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 59617
			// - HERO_DECK_ID = 2693
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_RafaamH", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_RafaamH] Rafaam && Test: Rafaam_TB_TempleOutrun_RafaamH
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TB_TempleOutrun_Rajh] Rajh (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>The Mighty Lord of the Sun shines brightest when_casting_spells.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57303
			// - HERO_DECK_ID = 2708
			// - HIDE_WATERMARK = 1
			// - 1205 = 10
			// - HEROIC_HERO_POWER = 59074
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Rajh", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Rajh] Rajh && Test: Rajh_TB_TempleOutrun_Rajh
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TB_TempleOutrun_Reno] Reno Jackson (*) - COST:0 [ATK:0/HP:15] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: [x]With a bag full of treasures 
			//       and a well-styled moustache,
			//        Reno is ready to take 
			//       Tekahn down!
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57648
			// - MULTIPLE_CLASSES = 72
			// - HERO_DECK_ID = 2717
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Reno", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Reno] Reno Jackson && Test: Reno Jackson_TB_TempleOutrun_Reno
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [TB_TempleOutrun_Setesh] Setesh (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Just your typical bad dog, destroying everything.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57305
			// - HERO_DECK_ID = 2710
			// - HIDE_WATERMARK = 1
			// - 1205 = 10
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Setesh", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Setesh] Setesh && Test: Setesh_TB_TempleOutrun_Setesh
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_TempleOutrun_Sothis] Sothis (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Titan security is very serious. Stone-faced, even.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57237
			// - HERO_DECK_ID = 2713
			// - HIDE_WATERMARK = 1
			// - 1205 = 10
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Sothis", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Sothis] Sothis && Test: Sothis_TB_TempleOutrun_Sothis
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [TB_TempleOutrun_TogwaggleH] King Togwaggle (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 59557
			// - HERO_DECK_ID = 2691
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_TogwaggleH", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_TogwaggleH] King Togwaggle && Test: King Togwaggle_TB_TempleOutrun_TogwaggleH
				InfoCardId = "TB_TempleOutrun_TogwaggleHPe",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [TB_TempleOutrun_Toomba] Ol' Toomba (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Ol' Toomba the treasure hunter isn't above copying_homework.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57245
			// - HERO_DECK_ID = 2715
			// - HIDE_WATERMARK = 1
			// - 1202 = 10
			// - HEROIC_HERO_POWER = 59054
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Toomba", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Toomba] Ol' Toomba && Test: Ol' Toomba_TB_TempleOutrun_Toomba
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [TB_TempleOutrun_TrapRoom] Trap Room (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Is it still a trap if everyone knows it's a trap?</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57273
			// - HERO_DECK_ID = 2700
			// - HIDE_WATERMARK = 1
			// - 1204 = 10
			// - HEROIC_HERO_POWER = 59064
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_TrapRoom", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_TrapRoom] Trap Room && Test: Trap Room_TB_TempleOutrun_TrapRoom
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [TB_TempleOutrun_Zafarr] Dark Ritualist Zafarr (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Believes his rituals are better than anyone else's.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57086
			// - HERO_DECK_ID = 2706
			// - HIDE_WATERMARK = 1
			// - 1204 = 10
			// - HEROIC_HERO_POWER = 59044
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Zafarr", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Zafarr] Dark Ritualist Zafarr && Test: Dark Ritualist Zafarr_TB_TempleOutrun_Zafarr
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TB_TempleOutrun_Zaraam] Zaraam (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <i>Zaraam grows in strength the more his minions suffer.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 57291
			// - HERO_DECK_ID = 2703
			// - HIDE_WATERMARK = 1
			// - 1204 = 1
			// - HEROIC_HERO_POWER = 59069
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Zaraam", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Zaraam] Zaraam && Test: Zaraam_TB_TempleOutrun_Zaraam
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TB_TempleOutrunHHorsema] Headless Horseman (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <i>He's seen the battle in Uldum! Now he's here in this tomb!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46914
			// - HERO_DECK_ID = 2723
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrunHHorsema", new CardDef(new Power
			{
				// TODO [TB_TempleOutrunHHorsema] Headless Horseman && Test: Headless Horseman_TB_TempleOutrunHHorsema
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [TB_Zombeast_H] Deathstalker Rexxar (*) - COST:6 [ATK:0/HP:30] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 2 damage
			//       to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 43183
			// --------------------------------------------------------
			cards.Add("TB_Zombeast_H", new CardDef(new Power
			{
				// TODO [TB_Zombeast_H] Deathstalker Rexxar && Test: Deathstalker Rexxar_TB_Zombeast_H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TBA01_1] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:60] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2660
			// --------------------------------------------------------
			cards.Add("TBA01_1", new CardDef(new Power
			{
				// TODO [TBA01_1] Ragnaros the Firelord && Test: Ragnaros the Firelord_TBA01_1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TBA01_4] Nefarian (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2653
			// --------------------------------------------------------
			cards.Add("TBA01_4", new CardDef(new Power
			{
				// TODO [TBA01_4] Nefarian && Test: Nefarian_TBA01_4
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HeroPowers(IDictionary<string, CardDef> cards)
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
			cards.Add("BRMA01_2H_2_TB", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [BRMA01_2H_2_TB] Pile On!!! && Test: Pile On!!!_BRMA01_2H_2_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMA02_2_2_TB", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [BRMA02_2_2_TB] Jeering Crowd && Test: Jeering Crowd_BRMA02_2_2_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMA06_2H_TB", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [BRMA06_2H_TB] The Majordomo && Test: The Majordomo_BRMA06_2H_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMA07_2_2_TB", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				// TODO [BRMA07_2_2_TB] ME SMASH && Test: ME SMASH_BRMA07_2_2_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMA09_2_TB", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [BRMA09_2_TB] Open the Gates && Test: Open the Gates_BRMA09_2_TB
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRMA11_2H_2_TB] Essence of the Red (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Each player draws 3 cards. Gain a Mana Crystal.
			// --------------------------------------------------------
			cards.Add("BRMA11_2H_2_TB", new CardDef(new Power
			{
				// TODO [BRMA11_2H_2_TB] Essence of the Red && Test: Essence of the Red_BRMA11_2H_2_TB
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRMA13_4_2_TB] Wild Magic (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Put a random spell from your opponent's class into your hand.
			// --------------------------------------------------------
			cards.Add("BRMA13_4_2_TB", new CardDef(new Power
			{
				// TODO [BRMA13_4_2_TB] Wild Magic && Test: Wild Magic_BRMA13_4_2_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMA14_10H_TB", new CardDef(new[] {"BRMA14_3","BRMA14_5","BRMA14_7","BRMA14_9"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [BRMA14_10H_TB] Activate! && Test: Activate!_BRMA14_10H_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMA17_5_TB", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [BRMA17_5_TB] Bone Minions && Test: Bone Minions_BRMA17_5_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("EX1_tk33_2_TB", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [EX1_tk33_2_TB] INFERNO! && Test: INFERNO!_EX1_tk33_2_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_LK005", new CardDef(new Power
			{
				// TODO [FB_LK005] Remorseless Winter && Test: Remorseless Winter_FB_LK005
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_LK007p", new CardDef(new Power
			{
				// TODO [FB_LK007p] Freezing Blast && Test: Freezing Blast_FB_LK007p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [FB_SPT_Annoyo_HP] Construct Annoy-o-Tron (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon an increasingly annoying Annoy-o-Tron.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("FB_SPT_Annoyo_HP", new CardDef(new Power
			{
				// TODO [FB_SPT_Annoyo_HP] Construct Annoy-o-Tron && Test: Construct Annoy-o-Tron_FB_SPT_Annoyo_HP
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [FB_SPT_Annoyo_HP_0] Construct Annoy-o-Tron (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon an 
			//       Annoy-o-Tron.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("FB_SPT_Annoyo_HP_0", new CardDef(new Power
			{
				// TODO [FB_SPT_Annoyo_HP_0] Construct Annoy-o-Tron && Test: Construct Annoy-o-Tron_FB_SPT_Annoyo_HP_0
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [FB_SPT_Annoyo_HP_1] Construct Annoy-o-Trons (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon two increasingly annoying Annoy-o-Trons.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("FB_SPT_Annoyo_HP_1", new CardDef(new Power
			{
				// TODO [FB_SPT_Annoyo_HP_1] Construct Annoy-o-Trons && Test: Construct Annoy-o-Trons_FB_SPT_Annoyo_HP_1
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------- HERO_POWER - MAGE
			// [FB_Toki2_Hero] Join Forces (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a card from your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki2_Hero", new CardDef(new Power
			{
				// TODO [FB_Toki2_Hero] Join Forces && Test: Join Forces_FB_Toki2_Hero
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [NAX11_02H_2_TB] Poison Cloud (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage to all enemy minions. If any die, summon a slime.
			// --------------------------------------------------------
			cards.Add("NAX11_02H_2_TB", new CardDef(new Power
			{
				// TODO [NAX11_02H_2_TB] Poison Cloud && Test: Poison Cloud_NAX11_02H_2_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("NAX12_02H_2_TB", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				// TODO [NAX12_02H_2_TB] Decimate && Test: Decimate_NAX12_02H_2_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("NAX3_02_TB", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				// TODO [NAX3_02_TB] Web Wrap && Test: Web Wrap_NAX3_02_TB
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [NAX8_02H_TB] Harvest (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw a card. Gain a Mana Crystal.
			// --------------------------------------------------------
			cards.Add("NAX8_02H_TB", new CardDef(new Power
			{
				// TODO [NAX8_02H_TB] Harvest && Test: Harvest_NAX8_02H_TB
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - ROGUE
			// [TB_BlingBrawl_Hero1p] Sharpen (*) - COST:2 
			// - Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Increase your weapon's attack by 1
			// --------------------------------------------------------
			cards.Add("TB_BlingBrawl_Hero1p", new CardDef(new Power
			{
				// TODO [TB_BlingBrawl_Hero1p] Sharpen && Test: Sharpen_TB_BlingBrawl_Hero1p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_BossBattle_KoboldHP] Magic Candle (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Find a Treasure!
			// --------------------------------------------------------
			// Entourage: LOOTA_819, LOOTA_821, LOOTA_835, LOOTA_842b, LOOTA_806, LOOTA_812, LOOTA_823, LOOTA_847, LOOTA_836, LOOTA_839, LOOTA_816, LOOTA_827, LOOTA_843, LOOTA_826, LOOT_998k, LOOTA_838
			// --------------------------------------------------------
			cards.Add("TB_BossBattle_KoboldHP", new CardDef(new[] {"LOOTA_819","LOOTA_821","LOOTA_835","LOOTA_842b","LOOTA_806","LOOTA_812","LOOTA_823","LOOTA_847","LOOTA_836","LOOTA_839","LOOTA_816","LOOTA_827","LOOTA_843","LOOTA_826","LOOT_998k","LOOTA_838"}, new Power
			{
				// TODO [TB_BossBattle_KoboldHP] Magic Candle && Test: Magic Candle_TB_BossBattle_KoboldHP
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_BossRumble_001hp", new CardDef(new Power
			{
				// TODO [TB_BossRumble_001hp] Smuggle && Test: Smuggle_TB_BossRumble_001hp
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_BossRumble_002hp", new CardDef(new Power
			{
				// TODO [TB_BossRumble_002hp] Construct Golem && Test: Construct Golem_TB_BossRumble_002hp
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_BossRumble_003hp", new CardDef(new Power
			{
				// TODO [TB_BossRumble_003hp] Brew Potion && Test: Brew Potion_TB_BossRumble_003hp
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_BountyHunt_Consume] Consume (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy a friendly minion, then draw 3 cards.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TB_BountyHunt_Consume", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [TB_BountyHunt_Consume] Consume && Test: Consume_TB_BountyHunt_Consume
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_BountyHunt_Hypnotize] Hypnotize (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Each player shuffles their
			//       hand into their deck and
			//       draws that many cards.
			// --------------------------------------------------------
			cards.Add("TB_BountyHunt_Hypnotize", new CardDef(new Power
			{
				// TODO [TB_BountyHunt_Hypnotize] Hypnotize && Test: Hypnotize_TB_BountyHunt_Hypnotize
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_BRMA01_2H_2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [TB_BRMA01_2H_2] Pile On!!! && Test: Pile On!!!_TB_BRMA01_2H_2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_BRMA10_3H] The Rookery (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give all Corrupted Eggs +1 Health, then summon one.
			// --------------------------------------------------------
			cards.Add("TB_BRMA10_3H", new CardDef(new Power
			{
				// TODO [TB_BRMA10_3H] The Rookery && Test: The Rookery_TB_BRMA10_3H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_BuildaBoss_404p] Toxic Fumes (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage to all minions.
			// --------------------------------------------------------
			cards.Add("TB_BuildaBoss_404p", new CardDef(new Power
			{
				// TODO [TB_BuildaBoss_404p] Toxic Fumes && Test: Toxic Fumes_TB_BuildaBoss_404p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_CheaterChess_Black] Castle (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Discover</b> a chess piece.
			// --------------------------------------------------------
			// Entourage: KAR_A10_01, KAR_A10_03, KAR_A10_06, KAR_A10_07, KAR_A10_10
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("TB_CheaterChess_Black", new CardDef(new[] {"KAR_A10_01","KAR_A10_03","KAR_A10_06","KAR_A10_07","KAR_A10_10"}, new Power
			{
				// TODO [TB_CheaterChess_Black] Castle && Test: Castle_TB_CheaterChess_Black
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_Chupacabran_HP] Bloodthirst (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a friendly minion +1/+1 and <b>Lifesteal</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TB_Chupacabran_HP", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [TB_Chupacabran_HP] Bloodthirst && Test: Bloodthirst_TB_Chupacabran_HP
				InfoCardId = "TB_Chupacabran_HP_E",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_CoopHero_HP_001] Madness (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Armies!!
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2379
			// --------------------------------------------------------
			cards.Add("TB_CoopHero_HP_001", new CardDef(new Power
			{
				// TODO [TB_CoopHero_HP_001] Madness && Test: Madness_TB_CoopHero_HP_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - ROGUE
			// [TB_DK_Valeera_HP] Death's Shadow (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       During your turn, add a 'Shadow Reflection' to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_DK_Valeera_HP", new CardDef(new Power
			{
				// TODO [TB_DK_Valeera_HP] Death's Shadow && Test: Death's Shadow_TB_DK_Valeera_HP
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [TB_EVILBRM_BoomHeroPower] Overmine (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Shuffle two Bombs
			//       into your opponent's
			//       deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_BoomHeroPower", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [TB_EVILBRM_BoomHeroPower] Overmine && Test: Overmine_TB_EVILBRM_BoomHeroPower
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_EVILBRM_OnyxiaHeroPower] Whelp Waves (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon one extra whelp each turn.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_OnyxiaHeroPower", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_OnyxiaHeroPower] Whelp Waves && Test: Whelp Waves_TB_EVILBRM_OnyxiaHeroPower
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_EVILBRM_RafaamHeroPower] Arch-Villainy (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Steal a card from your opponent's deck. If it's a minion, summon it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_RafaamHeroPower", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_RafaamHeroPower] Arch-Villainy && Test: Arch-Villainy_TB_EVILBRM_RafaamHeroPower
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_EVILBRM_RafaamHeroPower2] Master Schemer (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Discover</b> a card that was played this turn. Replay immediately with random targets.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_RafaamHeroPower2", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_RafaamHeroPower2] Master Schemer && Test: Master Schemer_TB_EVILBRM_RafaamHeroPower2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_FactionWar_Boss_Rag_0] Swat Fly (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $3 damage to random enemy, for now... @spelldmg
			// --------------------------------------------------------
			cards.Add("TB_FactionWar_Boss_Rag_0", new CardDef(new Power
			{
				// TODO [TB_FactionWar_Boss_Rag_0] Swat Fly && Test: Swat Fly_TB_FactionWar_Boss_Rag_0
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_Firefest2_Ahune_HP] Freezing Touch (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Deal $1 damage. If this kills a minion, summon a Frost Elemental. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 42944
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TB_Firefest2_Ahune_HP", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [TB_Firefest2_Ahune_HP] Freezing Touch && Test: Freezing Touch_TB_Firefest2_Ahune_HP
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_HeadlessHorseman_HP1] Slash (*) - COST:3 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 2 damage randomly split among all enemies.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_HP1", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_HP1] Slash && Test: Slash_TB_HeadlessHorseman_HP1
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_HeadlessHorseman_HP3", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_HP3] Conscript && Test: Conscript_TB_HeadlessHorseman_HP3
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_HeadlessHorseman_HP4", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_HP4] Witchcraft && Test: Witchcraft_TB_HeadlessHorseman_HP4
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_HeadlessHorseman_HP5", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_HP5] Sense Weakness && Test: Sense Weakness_TB_HeadlessHorseman_HP5
				InfoCardId = "TB_HeadlessHorseman_HP5e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_HeadlessHorseman_HP6] Mummification (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Give all your summoned minions <b>Reborn</b>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_HP6", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_HP6] Mummification && Test: Mummification_TB_HeadlessHorseman_HP6
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [TB_Henchmania_ChuH] Undermine (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Shuffle an Explosive into your opponent's deck.
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_ChuH", new CardDef(new Power
			{
				// TODO [TB_Henchmania_ChuH] Undermine && Test: Undermine_TB_Henchmania_ChuH
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - ROGUE
			// [TB_Henchmania_MyraH] Necrium Infusion (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Trigger a random friendly minion's <b>Deathrattle</b>.
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_MyraH", new CardDef(new Power
			{
				// TODO [TB_Henchmania_MyraH] Necrium Infusion && Test: Necrium Infusion_TB_Henchmania_MyraH
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_John_002p] Magic Candle (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Find a Treasure!
			// --------------------------------------------------------
			cards.Add("TB_John_002p", new CardDef(new Power
			{
				// TODO [TB_John_002p] Magic Candle && Test: Magic Candle_TB_John_002p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_KTRAF_HP_KT_3] Necromancy (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random Naxxramas minion to your hand.
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_HP_KT_3", new CardDef(new Power
			{
				// TODO [TB_KTRAF_HP_KT_3] Necromancy && Test: Necromancy_TB_KTRAF_HP_KT_3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_KTRAF_HP_RAF3] Staff, First Piece (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random rare card to your hand. It costs (2) less.
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_HP_RAF3", new CardDef(new Power
			{
				// TODO [TB_KTRAF_HP_RAF3] Staff, First Piece && Test: Staff, First Piece_TB_KTRAF_HP_RAF3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_KTRAF_HP_RAF4] Staff, Two Pieces (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random epic card to your hand. It costs (3) less.
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_HP_RAF4", new CardDef(new Power
			{
				// TODO [TB_KTRAF_HP_RAF4] Staff, Two Pieces && Test: Staff, Two Pieces_TB_KTRAF_HP_RAF4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_KTRAF_HP_RAF5] Staff of Origination (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random legendary minion to your hand. It costs (4) less.
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_HP_RAF5", new CardDef(new Power
			{
				// TODO [TB_KTRAF_HP_RAF5] Staff of Origination && Test: Staff of Origination_TB_KTRAF_HP_RAF5
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - HUNTER
			// [TB_LEAGUE_REVIVAL_BrannAIHp] Dino Buddies (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a random dinosaur.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - 858 = 48199
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_BrannAIHp", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_BrannAIHp] Dino Buddies && Test: Dino Buddies_TB_LEAGUE_REVIVAL_BrannAIHp
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_LEAGUE_REVIVAL_FinleySandHP] Shifting Sands (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Deal 1 damage to all minions. Summon a Pile of Sand.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_FinleySandHP", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_FinleySandHP] Shifting Sands && Test: Shifting Sands_TB_LEAGUE_REVIVAL_FinleySandHP
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------- HERO_POWER - MAGE
			// [TB_LEAGUE_REVIVAL_RenoAIHp] Gatling Wand (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Randomly deal @ damage. (Increases Each Turn!)
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 3
			// - AI_MUST_PLAY = 1
			// - 858 = 48199
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_RenoAIHp", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_RenoAIHp] Gatling Wand && Test: Gatling Wand_TB_LEAGUE_REVIVAL_RenoAIHp
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARLOCK
			// [TB_LEAGUE_REVIVAL_TekahnAIHp] EVIL Grasp (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random <b>Lackey</b> to your hand. All <b>Lackeys</b> are 4/4.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 5
			// - AI_MUST_PLAY = 1
			// - 858 = 48199
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_TekahnAIHp", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_TekahnAIHp] EVIL Grasp && Test: EVIL Grasp_TB_LEAGUE_REVIVAL_TekahnAIHp
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - ROGUE
			// [TB_LEAGUE_REVIVAL_TerravisHp] Well Equipped (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Equip a random weapon, if you already have one give it +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - 858 = 730
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_TerravisHp", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_TerravisHp] Well Equipped && Test: Well Equipped_TB_LEAGUE_REVIVAL_TerravisHp
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_LevelUp_001] Level Up! (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Level up all the spells in your hand and deck.
			// --------------------------------------------------------
			cards.Add("TB_LevelUp_001", new CardDef(new Power
			{
				// TODO [TB_LevelUp_001] Level Up! && Test: Level Up!_TB_LevelUp_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - DRUID
			// [TB_LOEA13_2] Ancient Power (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give each player a random card. It costs (0).
			// --------------------------------------------------------
			cards.Add("TB_LOEA13_2", new CardDef(new Power
			{
				// TODO [TB_LOEA13_2] Ancient Power && Test: Ancient Power_TB_LOEA13_2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_MammothParty_hp001] Decorate (*) - COST:10 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Create *{0}* |4(decoration, decorations) for the Tavern.
			//       Progress: {1}/25
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_hp001", new CardDef(new Power
			{
				// TODO [TB_MammothParty_hp001] Decorate && Test: Decorate_TB_MammothParty_hp001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_MammothParty_hp002] Pelt (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 3 damage to the Piñata.
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_hp002", new CardDef(new Power
			{
				// TODO [TB_MammothParty_hp002] Pelt && Test: Pelt_TB_MammothParty_hp002
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_MechWar_Boss1_HeroPower", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [TB_MechWar_Boss1_HeroPower] Hello! Hello! Hello! && Test: Hello! Hello! Hello!_TB_MechWar_Boss1_HeroPower
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_MechWar_Boss2_HeroPower] Boom Bot Jr. (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 2 damage randomly split among all enemies.
			// --------------------------------------------------------
			cards.Add("TB_MechWar_Boss2_HeroPower", new CardDef(new Power
			{
				// TODO [TB_MechWar_Boss2_HeroPower] Boom Bot Jr. && Test: Boom Bot Jr._TB_MechWar_Boss2_HeroPower
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_BossHeroPower", new CardDef(new Power
			{
				// TODO [TB_SPT_BossHeroPower] Barracks && Test: Barracks_TB_SPT_BossHeroPower
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_DPromoHP", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [TB_SPT_DPromoHP] Diabolical Powers && Test: Diabolical Powers_TB_SPT_DPromoHP
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_SPT_DPromoHP2] So Many... (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever a Hell Bovine Dies, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38981
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoHP2", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoHP2] So Many... && Test: So Many..._TB_SPT_DPromoHP2
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_MTH_BossHeroPower", new CardDef(new Power
			{
				// TODO [TB_SPT_MTH_BossHeroPower] Party Barracks && Test: Party Barracks_TB_SPT_MTH_BossHeroPower
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_TempleOutrun_Lazul_HP] Leap of Fate (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 1/1 copy of a <b>Deathrattle</b> minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Lazul_HP", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Lazul_HP] Leap of Fate && Test: Leap of Fate_TB_TempleOutrun_Lazul_HP
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_TempleOutrun_Lazul_HP3] Return Fateful (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a friendly <b>Deathrattle</b> minion that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Lazul_HP3", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Lazul_HP3] Return Fateful && Test: Return Fateful_TB_TempleOutrun_Lazul_HP3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_TempleOutrun_Toggwaggle_HP] Fool's Gold (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Reduce the cost of a random card in your hand to (0).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Toggwaggle_HP", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Toggwaggle_HP] Fool's Gold && Test: Fool's Gold_TB_TempleOutrun_Toggwaggle_HP
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TBA01_5] Wild Magic (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random spell from any class to your hand. It costs (0).
			// --------------------------------------------------------
			cards.Add("TBA01_5", new CardDef(new Power
			{
				// TODO [TBA01_5] Wild Magic && Test: Wild Magic_TBA01_5
				InfoCardId = "TBA01_5e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TBA01_6] Molten Rage (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 5/1 Magma Rager.
			// --------------------------------------------------------
			cards.Add("TBA01_6", new CardDef(new Power
			{
				// TODO [TBA01_6] Molten Rage && Test: Molten Rage_TBA01_6
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - ROGUE
			// [TP_Bling_HP2] Cash In (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy your weapon, gaining a random one.
			// --------------------------------------------------------
			cards.Add("TP_Bling_HP2", new CardDef(new Power
			{
				// TODO [TP_Bling_HP2] Cash In && Test: Cash In_TP_Bling_HP2
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void DeathknightNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ SPELL - DEATHKNIGHT
			// [FB_LK001] Soldiers of the Cold Dark (*) - COST:0 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Draw 4 cards.
			// --------------------------------------------------------
			cards.Add("FB_LK001", new CardDef(new Power
			{
				// TODO [FB_LK001] Soldiers of the Cold Dark && Test: Soldiers of the Cold Dark_FB_LK001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [FB_LK006] To My Aid Underling! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a different Frozen Throne boss.
			//        <i> You aren't worth the Lich King's time.</i>
			// --------------------------------------------------------
			cards.Add("FB_LK006", new CardDef(new Power
			{
				// TODO [FB_LK006] To My Aid Underling! && Test: To My Aid Underling!_FB_LK006
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [FB_Juggernaut_Druid_Ench] Opponent's Class: Druid Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent: Druid
			// --------------------------------------------------------
			// Entourage: CS2_017
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Druid_Ench", new CardDef(new[] {"CS2_017"}, new Power
			{
				// TODO [FB_Juggernaut_Druid_Ench] Opponent's Class: Druid Ench && Test: Opponent's Class: Druid Ench_FB_Juggernaut_Druid_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Juggernaut_Druid_Ench")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [FB_LK_Druid_Ench_copy] Next Hero: Druid Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Druid cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_017
			// --------------------------------------------------------
			cards.Add("FB_LK_Druid_Ench_copy", new CardDef(new[] {"CS2_017"}, new Power
			{
				// TODO [FB_LK_Druid_Ench_copy] Next Hero: Druid Ench Copy && Test: Next Hero: Druid Ench Copy_FB_LK_Druid_Ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK_Druid_Ench_copy")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [FB_TagTeam_Druid_Ench] Next Hero: Druid Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Druid cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_017
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Druid_Ench", new CardDef(new[] {"CS2_017"}, new Power
			{
				// TODO [FB_TagTeam_Druid_Ench] Next Hero: Druid Ench && Test: Next Hero: Druid Ench_FB_TagTeam_Druid_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_TagTeam_Druid_Ench")
			}));

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_AT_045] Aviana (*) - COST:9 [ATK:5/HP:5] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your minions cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_AT_045", new CardDef(new Power
			{
				// TODO [FB_Champs_AT_045] Aviana && Test: Aviana_FB_Champs_AT_045
				InfoCardId = "FB_Champs_AT_045eee",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_Champs_EX1_165", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_165] Druid of the Claw && Test: Druid of the Claw_FB_Champs_EX1_165
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_EX1_165t1] Druid of the Claw (*) - COST:5 [ATK:4/HP:4] 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_165t1", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_165t1] Druid of the Claw && Test: Druid of the Claw_FB_Champs_EX1_165t1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_EX1_165t2] Druid of the Claw (*) - COST:5 [ATK:4/HP:6] 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_165t2", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_165t2] Druid of the Claw && Test: Druid of the Claw_FB_Champs_EX1_165t2
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_Champs_EX1_166", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				// TODO [FB_Champs_EX1_166] Keeper of the Grove && Test: Keeper of the Grove_FB_Champs_EX1_166
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_EX1_tk9] Treant (*) - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: tb, Rarity: common
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_tk9", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_tk9] Treant && Test: Treant_FB_Champs_EX1_tk9
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_NEW1_008] Ancient of Lore (*) - COST:7 [ATK:5/HP:5] 
			// - Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Draw 2 cards; or Restore #5 Health.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_NEW1_008", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				// TODO [FB_Champs_NEW1_008] Ancient of Lore && Test: Ancient of Lore_FB_Champs_NEW1_008
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_Champs_OG_044a", new CardDef(new Power
			{
				// TODO [FB_Champs_OG_044a] Druid of the Claw && Test: Druid of the Claw_FB_Champs_OG_044a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_CS2_013] Wild Growth (*) - COST:2 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Gain an empty Mana Crystal.
			// --------------------------------------------------------
			cards.Add("FB_Champs_CS2_013", new CardDef(new Power
			{
				// TODO [FB_Champs_CS2_013] Wild Growth && Test: Wild Growth_FB_Champs_CS2_013
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_EX1_164] Nourish (*) - COST:5 
			// - Fac: neutral, Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Gain 2_Mana Crystals; or Draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_164", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_164] Nourish && Test: Nourish_FB_Champs_EX1_164
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_EX1_165a] Cat Form (*) - COST:5 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_165a", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_165a] Cat Form && Test: Cat Form_FB_Champs_EX1_165a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_EX1_165b] Bear Form (*) - COST:5 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_165b", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_165b] Bear Form && Test: Bear Form_FB_Champs_EX1_165b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_EX1_169] Innervate (*) - COST:0 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Gain 2 Mana Crystals this turn only.
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_169", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_169] Innervate && Test: Innervate_FB_Champs_EX1_169
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_Champs_EX1_571", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [FB_Champs_EX1_571] Force of Nature && Test: Force of Nature_FB_Champs_EX1_571
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_NEW1_008a] Ancient Teachings (*) - COST:7 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Draw two cards.
			// --------------------------------------------------------
			cards.Add("FB_Champs_NEW1_008a", new CardDef(new Power
			{
				// TODO [FB_Champs_NEW1_008a] Ancient Teachings && Test: Ancient Teachings_FB_Champs_NEW1_008a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_NEW1_008b] Ancient Secrets (*) - COST:7 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Restore 5 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_NEW1_008b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [FB_Champs_NEW1_008b] Ancient Secrets && Test: Ancient Secrets_FB_Champs_NEW1_008b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [FB_Juggernaut_Druid] Druid (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent is a Druid.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Druid", new CardDef(new Power
			{
				// TODO [FB_Juggernaut_Druid] Druid && Test: Druid_FB_Juggernaut_Druid
				InfoCardId = "FB_Juggernaut_Druid_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [FB_LK_Druid_copy] Druid (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Druid as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Druid_copy", new CardDef(new Power
			{
				// TODO [FB_LK_Druid_copy] Druid && Test: Druid_FB_LK_Druid_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_Carousel_SpawnDreadSteed] Summon Dreadsteeds (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Dreadsteeds
			// --------------------------------------------------------
			cards.Add("TB_Carousel_SpawnDreadSteed", new CardDef(new Power
			{
				// TODO [TB_Carousel_SpawnDreadSteed] Summon Dreadsteeds && Test: Summon Dreadsteeds_TB_Carousel_SpawnDreadSteed
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_ClassRandom_Druid] Second Class: Druid (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Druid cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Druid", new CardDef(new Power
			{
				// TODO [TB_ClassRandom_Druid] Second Class: Druid && Test: Second Class: Druid_TB_ClassRandom_Druid
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_EVILBRM_GarrSummon] Summon Firesworn (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon two 1/1 Saplings.
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_GarrSummon", new CardDef(new Power
			{
				// TODO [TB_EVILBRM_GarrSummon] Summon Firesworn && Test: Summon Firesworn_TB_EVILBRM_GarrSummon
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_LEAGUE_REVIVAL_Druid_01] Swarm (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: DAL_354, CS2_188, FP1_003, FP1_002, GVG_104, ICC_808, EX1_597, KAR_044, OG_313, AT_037, CFM_614, DAL_733, EX1_160, DAL_351, CS2_011, OG_195, DAL_256, ULD_134, ULD_137, ULD_712
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Druid_01", new CardDef(new[] {"DAL_354","CS2_188","FP1_003","FP1_002","GVG_104","ICC_808","EX1_597","KAR_044","OG_313","AT_037","CFM_614","DAL_733","EX1_160","DAL_351","CS2_011","OG_195","DAL_256","ULD_134","ULD_137","ULD_712"}, new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Druid_01] Swarm && Test: Swarm_TB_LEAGUE_REVIVAL_Druid_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_LEAGUE_REVIVAL_Druid_02] Recovery (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: DAL_544, CFM_120, CS2_117, LOOT_388, DAL_355, GIL_622, GVG_069, GIL_667, DAL_799, NEW1_008, DAL_357, DAL_350, DAL_733, CS2_007, KAR_075, GVG_033, ULD_135, ULD_273, ULD_208, ULD_196
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Druid_02", new CardDef(new[] {"DAL_544","CFM_120","CS2_117","LOOT_388","DAL_355","GIL_622","GVG_069","GIL_667","DAL_799","NEW1_008","DAL_357","DAL_350","DAL_733","CS2_007","KAR_075","GVG_033","ULD_135","ULD_273","ULD_208","ULD_196"}, new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Druid_02] Recovery && Test: Recovery_TB_LEAGUE_REVIVAL_Druid_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_LEAGUE_REVIVAL_Druid_03] Choices, Choices (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: AT_042, ICC_051, DAL_732, GIL_188, TRL_343, OG_044, EX1_165, EX1_178, CFM_308, DAL_350, CFM_602, AT_037, LOE_115, EX1_154, GVG_041, OG_195, ICC_832
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Druid_03", new CardDef(new[] {"AT_042","ICC_051","DAL_732","GIL_188","TRL_343","OG_044","EX1_165","EX1_178","CFM_308","DAL_350","CFM_602","AT_037","LOE_115","EX1_154","GVG_041","OG_195","ICC_832"}, new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Druid_03] Choices, Choices && Test: Choices, Choices_TB_LEAGUE_REVIVAL_Druid_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_LEAGUE_REVIVAL_Druid_04] All Bark (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: BOT_419, TRL_341, BOT_422, NEW1_008, EX1_178, EX1_573, BOT_523, GIL_663, BOT_420, AT_044, FP1_019, EX1_158, EX1_571, UNG_111, DAL_256, LOOT_392, ULD_137
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Druid_04", new CardDef(new[] {"BOT_419","TRL_341","BOT_422","NEW1_008","EX1_178","EX1_573","BOT_523","GIL_663","BOT_420","AT_044","FP1_019","EX1_158","EX1_571","UNG_111","DAL_256","LOOT_392","ULD_137"}, new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Druid_04] All Bark && Test: All Bark_TB_LEAGUE_REVIVAL_Druid_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_LEAGUE_REVIVAL_Druid_05] Nature's Wrath (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: EX1_012, EX1_284, AT_127, EX1_095, DAL_774, EX1_563, KAR_711, OG_134, EX1_161, AT_037, DAL_733, DAL_352, EX1_154, CS2_012, NEW1_007, EX1_173, DAL_256, ICC_085, ULD_138
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Druid_05", new CardDef(new[] {"EX1_012","EX1_284","AT_127","EX1_095","DAL_774","EX1_563","KAR_711","OG_134","EX1_161","AT_037","DAL_733","DAL_352","EX1_154","CS2_012","NEW1_007","EX1_173","DAL_256","ICC_085","ULD_138"}, new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Druid_05] Nature's Wrath && Test: Nature's Wrath_TB_LEAGUE_REVIVAL_Druid_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_LEAGUE_REVIVAL_Druid_06] Feral Bite (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TRL_223, TRL_240, AT_039, LOOT_048, EX1_116, TRL_241, TRL_243, LOOT_051, UNG_108, CS2_005, GIL_637, EX1_570, CS2_012, OG_047, LOOT_054
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Druid_06", new CardDef(new[] {"TRL_223","TRL_240","AT_039","LOOT_048","EX1_116","TRL_241","TRL_243","LOOT_051","UNG_108","CS2_005","GIL_637","EX1_570","CS2_012","OG_047","LOOT_054"}, new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Druid_06] Feral Bite && Test: Feral Bite_TB_LEAGUE_REVIVAL_Druid_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_LEAGUE_REVIVAL_Druid_07] Nurture and Grow (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: EX1_096, AT_038, EX1_050, LOOT_351, GVG_032, OG_202, GIL_833, EX1_284, NEW1_008, BRM_031, BOT_444, BOT_054, CFM_713, EX1_164, ICC_085, ULD_134, ULD_133, ULD_131
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Druid_07", new CardDef(new[] {"EX1_096","AT_038","EX1_050","LOOT_351","GVG_032","OG_202","GIL_833","EX1_284","NEW1_008","BRM_031","BOT_444","BOT_054","CFM_713","EX1_164","ICC_085","ULD_134","ULD_133","ULD_131"}, new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Druid_07] Nurture and Grow && Test: Nurture and Grow_TB_LEAGUE_REVIVAL_Druid_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_LEAGUE_REVIVAL_Druid_08] Roar! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: GIL_623, UNG_087, KAR_702, GVG_035, LOOT_153, GVG_080, UNG_086, TRL_232, TRL_550, BOT_423, UNG_099, TRL_542, UNG_852, GIL_571, TRL_244, TRL_255, ULD_190, ULD_177
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Druid_08", new CardDef(new[] {"GIL_623","UNG_087","KAR_702","GVG_035","LOOT_153","GVG_080","UNG_086","TRL_232","TRL_550","BOT_423","UNG_099","TRL_542","UNG_852","GIL_571","TRL_244","TRL_255","ULD_190","ULD_177"}, new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Druid_08] Roar! && Test: Roar!_TB_LEAGUE_REVIVAL_Druid_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_LEAGUE_REVIVAL_Druid_09] Protectors (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: UNG_072, EX1_093, ICC_466, ICC_807, FP1_012, GIL_623, LOOT_383, CFM_343, DAL_357, DAL_560, ICC_314, UNG_848, ICC_835, CS2_009, ICC_054, ULD_138, ULD_178, ULD_193
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Druid_09", new CardDef(new[] {"UNG_072","EX1_093","ICC_466","ICC_807","FP1_012","GIL_623","LOOT_383","CFM_343","DAL_357","DAL_560","ICC_314","UNG_848","ICC_835","CS2_009","ICC_054","ULD_138","ULD_178","ULD_193"}, new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Druid_09] Protectors && Test: Protectors_TB_LEAGUE_REVIVAL_Druid_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_LEAGUE_REVIVAL_Druid_10] Beasts and Buffs (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: KAR_300, LOOT_258, TRL_505, GIL_558, FP1_002, LOE_029, GIL_143, OG_313, LOE_050, UNG_075, AT_040, CFM_816, OG_048, CS2_009, EX1_155, UNG_103, TRL_254, GVG_041, ULD_188, ULD_292
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_Druid_10", new CardDef(new[] {"KAR_300","LOOT_258","TRL_505","GIL_558","FP1_002","LOE_029","GIL_143","OG_313","LOE_050","UNG_075","AT_040","CFM_816","OG_048","CS2_009","EX1_155","UNG_103","TRL_254","GVG_041","ULD_188","ULD_292"}, new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_Druid_10] Beasts and Buffs && Test: Beasts and Buffs_TB_LEAGUE_REVIVAL_Druid_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TB_TagTeam_Druid] Rumble in the Jungle (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Enter the jungle with giant beasts and darker things...
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Druid", new CardDef(new Power
			{
				// TODO [TB_TagTeam_Druid] Rumble in the Jungle && Test: Rumble in the Jungle_TB_TagTeam_Druid
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [FB_Juggernaut_Hunter_Ench] Opponent's Class: Hunter Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent: Hunter
			// --------------------------------------------------------
			// Entourage: DS1h_292
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Hunter_Ench", new CardDef(new[] {"DS1h_292"}, new Power
			{
				// TODO [FB_Juggernaut_Hunter_Ench] Opponent's Class: Hunter Ench && Test: Opponent's Class: Hunter Ench_FB_Juggernaut_Hunter_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Juggernaut_Hunter_Ench")
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [FB_LK_Hunter_Ench_copy] Next Hero: Hunter Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Hunter cards to your deck.
			// --------------------------------------------------------
			// Entourage: DS1h_292
			// --------------------------------------------------------
			cards.Add("FB_LK_Hunter_Ench_copy", new CardDef(new[] {"DS1h_292"}, new Power
			{
				// TODO [FB_LK_Hunter_Ench_copy] Next Hero: Hunter Ench Copy && Test: Next Hero: Hunter Ench Copy_FB_LK_Hunter_Ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK_Hunter_Ench_copy")
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [FB_TagTeam_Hunter_Ench] Next Hero: Hunter Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Hunter cards to your deck.
			// --------------------------------------------------------
			// Entourage: DS1h_292
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Hunter_Ench", new CardDef(new[] {"DS1h_292"}, new Power
			{
				// TODO [FB_TagTeam_Hunter_Ench] Next Hero: Hunter Ench && Test: Next Hero: Hunter Ench_FB_TagTeam_Hunter_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_TagTeam_Hunter_Ench")
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [TB_ZombeastEnch] Zombeast Enchant (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Craft a Zombeast (For free!)
			// --------------------------------------------------------
			cards.Add("TB_ZombeastEnch", new CardDef(new Power
			{
				// TODO [TB_ZombeastEnch] Zombeast Enchant && Test: Zombeast Enchant_TB_ZombeastEnch
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_ZombeastEnch")
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [FB_Champs_CS2_084] Hunter's Mark (*) - COST:1 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Change a minion's Health to 1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_CS2_084", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [FB_Champs_CS2_084] Hunter's Mark && Test: Hunter's Mark_FB_Champs_CS2_084
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [FB_Champs_LOOT_080] Lesser Emerald Spellstone (*) - COST:5 
			// - Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon two 3/3_Wolves. <i>(Play a <b>Secret</b> to upgrade.)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_LOOT_080", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [FB_Champs_LOOT_080] Lesser Emerald Spellstone && Test: Lesser Emerald Spellstone_FB_Champs_LOOT_080
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [FB_Champs_LOOT_080t2] Emerald Spellstone (*) - COST:5 
			// - Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon three 3/3_Wolves. <i>(Play a <b>Secret</b> to upgrade.)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_LOOT_080t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [FB_Champs_LOOT_080t2] Emerald Spellstone && Test: Emerald Spellstone_FB_Champs_LOOT_080t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [FB_Champs_LOOT_080t3] Greater Emerald Spellstone (*) - COST:5 
			// - Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon four 3/3_Wolves.
			// --------------------------------------------------------
			cards.Add("FB_Champs_LOOT_080t3", new CardDef(new Power
			{
				// TODO [FB_Champs_LOOT_080t3] Greater Emerald Spellstone && Test: Greater Emerald Spellstone_FB_Champs_LOOT_080t3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [FB_Juggernaut_Hunter] Hunter (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent is a Hunter.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Hunter", new CardDef(new Power
			{
				// TODO [FB_Juggernaut_Hunter] Hunter && Test: Hunter_FB_Juggernaut_Hunter
				InfoCardId = "FB_Juggernaut_Hunter_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [FB_LK_Hunter_copy] Hunter (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Hunter as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Hunter_copy", new CardDef(new Power
			{
				// TODO [FB_LK_Hunter_copy] Hunter && Test: Hunter_FB_LK_Hunter_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TB_ClassRandom_Hunter] Second Class: Hunter (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Hunter cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Hunter", new CardDef(new Power
			{
				// TODO [TB_ClassRandom_Hunter] Second Class: Hunter && Test: Second Class: Hunter_TB_ClassRandom_Hunter
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TB_TagTeam_Hunter] Unleash the Beasts (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Release a stampede of beasts while hunting for the Marsh Queen!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Hunter", new CardDef(new Power
			{
				// TODO [TB_TagTeam_Hunter] Unleash the Beasts && Test: Unleash the Beasts_TB_TagTeam_Hunter
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [FB_Juggernaut_Mage_Ench] Opponent's Class: Mage Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent: Mage
			// --------------------------------------------------------
			// Entourage: CS2_034
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Mage_Ench", new CardDef(new[] {"CS2_034"}, new Power
			{
				// TODO [FB_Juggernaut_Mage_Ench] Opponent's Class: Mage Ench && Test: Opponent's Class: Mage Ench_FB_Juggernaut_Mage_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Juggernaut_Mage_Ench")
			}));

			// ------------------------------------- ENCHANTMENT - MAGE
			// [FB_LK_Mage_Ench_copy] Next Hero: Mage Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Mage cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_034
			// --------------------------------------------------------
			cards.Add("FB_LK_Mage_Ench_copy", new CardDef(new[] {"CS2_034"}, new Power
			{
				// TODO [FB_LK_Mage_Ench_copy] Next Hero: Mage Ench Copy && Test: Next Hero: Mage Ench Copy_FB_LK_Mage_Ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK_Mage_Ench_copy")
			}));

			// ------------------------------------- ENCHANTMENT - MAGE
			// [FB_TagTeam_Mage_Ench] Next Hero: Mage Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Mage cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_034
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Mage_Ench", new CardDef(new[] {"CS2_034"}, new Power
			{
				// TODO [FB_TagTeam_Mage_Ench] Next Hero: Mage Ench && Test: Next Hero: Mage Ench_FB_TagTeam_Mage_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_TagTeam_Mage_Ench")
			}));

			// ------------------------------------- ENCHANTMENT - MAGE
			// [TagTeamIceBlock] Tag Team Ice Block (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your hero is <b>Immune</b> this turn.
			// --------------------------------------------------------
			cards.Add("TagTeamIceBlock", new CardDef(new Power
			{
				// TODO [TagTeamIceBlock] Tag Team Ice Block && Test: Tag Team Ice Block_TagTeamIceBlock
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TagTeamIceBlock")
			}));

			// ------------------------------------- ENCHANTMENT - MAGE
			// [TB_Iceblock] Ice Block_Immune (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your hero is <b>Immune</b> this turn.
			// --------------------------------------------------------
			cards.Add("TB_Iceblock", new CardDef(new Power
			{
				// TODO [TB_Iceblock] Ice Block_Immune && Test: Ice Block_Immune_TB_Iceblock
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Iceblock")
			}));

			// ------------------------------------------ MINION - MAGE
			// [FB_Champs_NEW1_012] Mana Wyrm (*) - COST:1 [ATK:1/HP:3] 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("FB_Champs_NEW1_012", new CardDef(new Power
			{
				// TODO [FB_Champs_NEW1_012] Mana Wyrm && Test: Mana Wyrm_FB_Champs_NEW1_012
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [FB_Toki_Boss_aggro] Withering Anomaly (*) - COST:1 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of each turn, deal damage equal to this minion's Attack to each Hero.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HERO_POWER = 48763
			// --------------------------------------------------------
			cards.Add("FB_Toki_Boss_aggro", new CardDef(new Power
			{
				// TODO [FB_Toki_Boss_aggro] Withering Anomaly && Test: Withering Anomaly_FB_Toki_Boss_aggro
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [FB_Toki_Boss_baby] Budding Anomaly (*) - COST:1 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of each turn, deal damage equal to this minion's Attack to characters opposite it.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HERO_POWER = 48763
			// --------------------------------------------------------
			cards.Add("FB_Toki_Boss_baby", new CardDef(new Power
			{
				// TODO [FB_Toki_Boss_baby] Budding Anomaly && Test: Budding Anomaly_FB_Toki_Boss_baby
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [FB_Toki_Boss_mental] Summoner Anomaly (*) - COST:1 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of each turn, summon two 2/3 Paradoxes.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HERO_POWER = 48763
			// --------------------------------------------------------
			// RefTag:
			// - BOSS = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_Boss_mental", new CardDef(new Power
			{
				// TODO [FB_Toki_Boss_mental] Summoner Anomaly && Test: Summoner Anomaly_FB_Toki_Boss_mental
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [FB_Toki_Boss_Poison] Deadly Anomaly (*) - COST:1 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Poisonous.</b> At end of each turn, deal damage equal to this minion's Attack to characters opposite it.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// - HERO_POWER = 48763
			// --------------------------------------------------------
			// RefTag:
			// - BOSS = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_Boss_Poison", new CardDef(new Power
			{
				// TODO [FB_Toki_Boss_Poison] Deadly Anomaly && Test: Deadly Anomaly_FB_Toki_Boss_Poison
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [FB_Toki_Boss_Shielded] Shield Anomaly (*) - COST:1 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of each turn, gain <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HERO_POWER = 48763
			// --------------------------------------------------------
			// RefTag:
			// - BOSS = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_Boss_Shielded", new CardDef(new Power
			{
				// TODO [FB_Toki_Boss_Shielded] Shield Anomaly && Test: Shield Anomaly_FB_Toki_Boss_Shielded
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [FB_Toki_Boss_spell] Bow Anomaly (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of each turn, deal damage equal to this minion's Attack to all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			// RefTag:
			// - BOSS = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_Boss_spell", new CardDef(new Power
			{
				// TODO [FB_Toki_Boss_spell] Bow Anomaly && Test: Bow Anomaly_FB_Toki_Boss_spell
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [FB_Toki_Boss_teen] Anomalous Rex (*) - COST:3 [ATK:6/HP:50] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Does TWO powers each turn!
			//       <b>Deathrattle</b>: You win!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - HERO_POWER = 48763
			// - BOSS = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_Boss_teen", new CardDef(new Power
			{
				// TODO [FB_Toki_Boss_teen] Anomalous Rex && Test: Anomalous Rex_FB_Toki_Boss_teen
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [FB_Juggernaut_Mage] Mage (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent is a Mage.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Mage", new CardDef(new Power
			{
				// TODO [FB_Juggernaut_Mage] Mage && Test: Mage_FB_Juggernaut_Mage
				InfoCardId = "FB_Juggernaut_Mage_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [FB_LK002] Relentless March (*) - COST:3 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Replace your deck with a fresh one.
			//       <i>Death does not feel fatigue</i>
			// --------------------------------------------------------
			cards.Add("FB_LK002", new CardDef(new Power
			{
				// TODO [FB_LK002] Relentless March && Test: Relentless March_FB_LK002
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [FB_LK_Mage_copy] Mage (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Mage as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Mage_copy", new CardDef(new Power
			{
				// TODO [FB_LK_Mage_copy] Mage && Test: Mage_FB_LK_Mage_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [FB_RagRaid_DeckRefresh] Unquenching Rage (*) - COST:3 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Replace your deck with a fresh one.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("FB_RagRaid_DeckRefresh", new CardDef(new Power
			{
				// TODO [FB_RagRaid_DeckRefresh] Unquenching Rage && Test: Unquenching Rage_FB_RagRaid_DeckRefresh
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [FB_RagRaid_DestroyEverything] BURRRRNNNN!!! (*) - COST:6 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Destroy All Minions
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 859
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("FB_RagRaid_DestroyEverything", new CardDef(new Power
			{
				// TODO [FB_RagRaid_DestroyEverything] BURRRRNNNN!!! && Test: BURRRRNNNN!!!_FB_RagRaid_DestroyEverything
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [FB_RagRaid_DoubleBlast] DIE, INSECTS! (*) - COST:4 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $8 damage to a random enemy. TWICE. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 864
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("FB_RagRaid_DoubleBlast", new CardDef(new Power
			{
				// TODO [FB_RagRaid_DoubleBlast] DIE, INSECTS! && Test: DIE, INSECTS!_FB_RagRaid_DoubleBlast
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [FB_RagRaid_Draw] Spreading Flames (*) - COST:0 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Draw 4 cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("FB_RagRaid_Draw", new CardDef(new Power
			{
				// TODO [FB_RagRaid_Draw] Spreading Flames && Test: Spreading Flames_FB_RagRaid_Draw
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TB_ClassRandom_Mage] Second Class: Mage (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Mage cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Mage", new CardDef(new Power
			{
				// TODO [TB_ClassRandom_Mage] Second Class: Mage && Test: Second Class: Mage_TB_ClassRandom_Mage
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TB_Firefest2_003] Celebrate Fire Festival (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give your minions +2/+2.
			// --------------------------------------------------------
			cards.Add("TB_Firefest2_003", new CardDef(new Power
			{
				// TODO [TB_Firefest2_003] Celebrate Fire Festival && Test: Celebrate Fire Festival_TB_Firefest2_003
				InfoCardId = "TB_Firefest2_003e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TB_Firefest2_004] CHILL! (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Freeze</b> <i>literally</i> everything. Add a "Frostbite" to your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// - 858 = 587
			// --------------------------------------------------------
			cards.Add("TB_Firefest2_004", new CardDef(new Power
			{
				// TODO [TB_Firefest2_004] CHILL! && Test: CHILL!_TB_Firefest2_004
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TB_Firefest2_005] Frostbite (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy all enemy minions.
			// --------------------------------------------------------
			cards.Add("TB_Firefest2_005", new CardDef(new Power
			{
				// TODO [TB_Firefest2_005] Frostbite && Test: Frostbite_TB_Firefest2_005
				InfoCardId = "TB_Firefest2_005e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TB_LevelUp_002] Fireblast (*) - COST:4 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Deal $6 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TB_LevelUp_002", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [TB_LevelUp_002] Fireblast && Test: Fireblast_TB_LevelUp_002
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TB_TagTeam_Mage] Elemental Secrets (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Guard your secrets and unleash elemental fury!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Mage", new CardDef(new Power
			{
				// TODO [TB_TagTeam_Mage] Elemental Secrets && Test: Elemental Secrets_TB_TagTeam_Mage
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TB_TempleOutrun_Bucket1] Empty Loot Box (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: BOT_288, AT_035, BOT_087, LOOT_026, ULD_286, DAL_719, CFM_660, BOT_559, LOOT_108, EX1_129, LOOT_211, EX1_050, EX1_007, EX1_105, CS2_023, BOT_103, CS2_077, GIL_691
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Bucket1", new CardDef(new[] {"BOT_288","AT_035","BOT_087","LOOT_026","ULD_286","DAL_719","CFM_660","BOT_559","LOOT_108","EX1_129","LOOT_211","EX1_050","EX1_007","EX1_105","CS2_023","BOT_103","CS2_077","GIL_691"}, new Power
			{
				// TODO [TB_TempleOutrun_Bucket1] Empty Loot Box && Test: Empty Loot Box_TB_TempleOutrun_Bucket1
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [FB_Juggernaut_Paladin_Ench] Opponent's Class: Paladin Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent: Paladin
			// --------------------------------------------------------
			// Entourage: CS2_101
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Paladin_Ench", new CardDef(new[] {"CS2_101"}, new Power
			{
				// TODO [FB_Juggernaut_Paladin_Ench] Opponent's Class: Paladin Ench && Test: Opponent's Class: Paladin Ench_FB_Juggernaut_Paladin_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Juggernaut_Paladin_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [FB_LK_Paladin_Ench_copy] Next Hero: Paladin Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Paladin cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_101
			// --------------------------------------------------------
			cards.Add("FB_LK_Paladin_Ench_copy", new CardDef(new[] {"CS2_101"}, new Power
			{
				// TODO [FB_LK_Paladin_Ench_copy] Next Hero: Paladin Ench Copy && Test: Next Hero: Paladin Ench Copy_FB_LK_Paladin_Ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK_Paladin_Ench_copy")
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [FB_TagTeam_Paladin_Ench] Next Hero: Paladin Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Paladin cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_101
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Paladin_Ench", new CardDef(new[] {"CS2_101"}, new Power
			{
				// TODO [FB_TagTeam_Paladin_Ench] Next Hero: Paladin Ench && Test: Next Hero: Paladin Ench_FB_TagTeam_Paladin_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_TagTeam_Paladin_Ench")
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [FB_Champs_EX1_619] Equality (*) - COST:2 
			// - Fac: neutral, Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: Change the Health of ALL minions to 1.
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_619", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_619] Equality && Test: Equality_FB_Champs_EX1_619
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [FB_Champs_LOOT_093] Call to Arms (*) - COST:4 
			// - Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Recruit</b> 3 minions that
			//        cost (2) or less.
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_LOOT_093", new CardDef(new Power
			{
				// TODO [FB_Champs_LOOT_093] Call to Arms && Test: Call to Arms_FB_Champs_LOOT_093
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [FB_Champs_LOOT_333] Level Up! (*) - COST:5 
			// - Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: Give your Silver Hand Recruits +2/+2 and_<b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 717 = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_LOOT_333", new CardDef(new Power
			{
				// TODO [FB_Champs_LOOT_333] Level Up! && Test: Level Up!_FB_Champs_LOOT_333
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [FB_Juggernaut_Paladin] Paladin (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent is a Paladin.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Paladin", new CardDef(new Power
			{
				// TODO [FB_Juggernaut_Paladin] Paladin && Test: Paladin_FB_Juggernaut_Paladin
				InfoCardId = "FB_Juggernaut_Paladin_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [FB_LK_Paladin_copy] Paladin (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Paladin as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Paladin_copy", new CardDef(new Power
			{
				// TODO [FB_LK_Paladin_copy] Paladin && Test: Paladin_FB_LK_Paladin_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TB_ClassRandom_Paladin] Second Class: Paladin (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Paladin cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Paladin", new CardDef(new Power
			{
				// TODO [TB_ClassRandom_Paladin] Second Class: Paladin && Test: Second Class: Paladin_TB_ClassRandom_Paladin
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TB_CoOpv3_200] Follow MY Rules! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Change the Attack of all other minions to 1.
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_200", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_200] Follow MY Rules! && Test: Follow MY Rules!_TB_CoOpv3_200
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TB_TagTeam_Paladin] Dark Light (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Bend the Light to your will, while you unleash the Apocalypse!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Paladin", new CardDef(new Power
			{
				// TODO [TB_TagTeam_Paladin] Dark Light && Test: Dark Light_TB_TagTeam_Paladin
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [FB_Juggernaut_Priest_Ench] Opponent's Class: Priest Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent: Priest
			// --------------------------------------------------------
			// Entourage: CS1h_001
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Priest_Ench", new CardDef(new[] {"CS1h_001"}, new Power
			{
				// TODO [FB_Juggernaut_Priest_Ench] Opponent's Class: Priest Ench && Test: Opponent's Class: Priest Ench_FB_Juggernaut_Priest_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Juggernaut_Priest_Ench")
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [FB_LK_Priest_Ench_copy] Next Hero: Priest Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Priest cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS1h_001
			// --------------------------------------------------------
			cards.Add("FB_LK_Priest_Ench_copy", new CardDef(new[] {"CS1h_001"}, new Power
			{
				// TODO [FB_LK_Priest_Ench_copy] Next Hero: Priest Ench Copy && Test: Next Hero: Priest Ench Copy_FB_LK_Priest_Ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK_Priest_Ench_copy")
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [FB_TagTeam_Priest_Ench] Next Hero: Priest Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Priest cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS1h_001
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Priest_Ench", new CardDef(new[] {"CS1h_001"}, new Power
			{
				// TODO [FB_TagTeam_Priest_Ench] Next Hero: Priest Ench && Test: Next Hero: Priest Ench_FB_TagTeam_Priest_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_TagTeam_Priest_Ench")
			}));

			// ---------------------------------------- MINION - PRIEST
			// [FB_Champs_CFM_020] Raza the Chained (*) - COST:5 [ATK:5/HP:5] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]  <b>Battlecry:</b> If your deck has  
			//       no duplicates, your Hero
			//        Power costs (0) this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_CFM_020", new CardDef(new Power
			{
				// TODO [FB_Champs_CFM_020] Raza the Chained && Test: Raza the Chained_FB_Champs_CFM_020
				InfoCardId = "FB_Champs_CFM_020e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [FB_Juggernaut_Priest] Priest (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent is a Priest.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Priest", new CardDef(new Power
			{
				// TODO [FB_Juggernaut_Priest] Priest && Test: Priest_FB_Juggernaut_Priest
				InfoCardId = "FB_Juggernaut_Priest_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [FB_LK_Priest_copy] Priest (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Priest as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Priest_copy", new CardDef(new Power
			{
				// TODO [FB_LK_Priest_copy] Priest && Test: Priest_FB_LK_Priest_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_ClassRandom_Priest] Second Class: Priest (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Priest cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Priest", new CardDef(new Power
			{
				// TODO [TB_ClassRandom_Priest] Second Class: Priest && Test: Second Class: Priest_TB_ClassRandom_Priest
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_CoOpv3_002] Twisted Light (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Restore 30 health to Nefarian. Deal 30 damage to all other minions.
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_002", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_002] Twisted Light && Test: Twisted Light_TB_CoOpv3_002
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_Coopv3_102] Shadow or Light? (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Each player draws 2 cards; or Restore 8 Health to each hero.
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_102", new CardDef(new Power
			{
				// TODO [TB_Coopv3_102] Shadow or Light? && Test: Shadow or Light?_TB_Coopv3_102
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_Coopv3_102a] Secrets of Shadow (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each player draws 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_102a", new CardDef(new Power
			{
				// TODO [TB_Coopv3_102a] Secrets of Shadow && Test: Secrets of Shadow_TB_Coopv3_102a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_Coopv3_102b] Alms of Light (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Restore 8 Health to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_102b", new CardDef(new Power
			{
				// TODO [TB_Coopv3_102b] Alms of Light && Test: Alms of Light_TB_Coopv3_102b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_EVILBRM_DALA_Priest_09] Twisted (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: UNG_034, GVG_011, DAL_735, EX1_045, UNG_844, LOE_107, EX1_048, CFM_657, GVG_014, DAL_434, EX1_332, CFM_661, AT_016, KAR_013, EX1_626, TRL_258, LOE_111, LOE_104, LOOT_008
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_DALA_Priest_09", new CardDef(new[] {"UNG_034","GVG_011","DAL_735","EX1_045","UNG_844","LOE_107","EX1_048","CFM_657","GVG_014","DAL_434","EX1_332","CFM_661","AT_016","KAR_013","EX1_626","TRL_258","LOE_111","LOE_104","LOOT_008"}, new Power
			{
				// TODO [TB_EVILBRM_DALA_Priest_09] Twisted && Test: Twisted_TB_EVILBRM_DALA_Priest_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_EVILBRM_Priest_02] Afterlife (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: DAL_030, BOT_509, LOE_006, DAL_413, LOOT_534, LOOT_534, UNG_037, DAL_040, UNG_900, DAL_039, BOT_566, GIL_805, EX1_016, DAL_775, TRL_537, GVG_114, ICC_214, OG_133, LOOT_187, ULD_265, ULD_269, ULD_266, ULD_208, ICC_702
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Priest_02", new CardDef(new[] {"DAL_030","BOT_509","LOE_006","DAL_413","LOOT_534","LOOT_534","UNG_037","DAL_040","UNG_900","DAL_039","BOT_566","GIL_805","EX1_016","DAL_775","TRL_537","GVG_114","ICC_214","OG_133","LOOT_187","ULD_265","ULD_269","ULD_266","ULD_208","ICC_702"}, new Power
			{
				// TODO [TB_EVILBRM_Priest_02] Afterlife && Test: Afterlife_TB_EVILBRM_Priest_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_EVILBRM_Priest_04] Shadows (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: GVG_009, DAL_030, TRL_501, ICC_210, ICC_212, AT_014, EX1_591, EX1_334, OG_101, DAL_723, DAL_011, CFM_603, DS1_233, CS2_234, UNG_029, EX1_622, TRL_500, ICC_235, ICC_830, ULD_714, ULD_718
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Priest_04", new CardDef(new[] {"GVG_009","DAL_030","TRL_501","ICC_210","ICC_212","AT_014","EX1_591","EX1_334","OG_101","DAL_723","DAL_011","CFM_603","DS1_233","CS2_234","UNG_029","EX1_622","TRL_500","ICC_235","ICC_830","ULD_714","ULD_718"}, new Power
			{
				// TODO [TB_EVILBRM_Priest_04] Shadows && Test: Shadows_TB_EVILBRM_Priest_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_EVILBRM_Priest_05] What's Mind is Mine (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: GIL_142, UNG_032, DAL_729, OG_335, EX1_091, EX1_016, ICC_215, TRL_259, CS2_003, LOOT_353, TRL_097, BOT_435, EX1_339, EX1_345, EX1_334, GIL_134, ICC_207, CS1_113
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Priest_05", new CardDef(new[] {"GIL_142","UNG_032","DAL_729","OG_335","EX1_091","EX1_016","ICC_215","TRL_259","CS2_003","LOOT_353","TRL_097","BOT_435","EX1_339","EX1_345","EX1_334","GIL_134","ICC_207","CS1_113"}, new Power
			{
				// TODO [TB_EVILBRM_Priest_05] What's Mind is Mine && Test: What's Mind is Mine_TB_EVILBRM_Priest_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_EVILBRM_Priest_06] Old God (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: OG_281, OG_284, OG_162, OG_286, OG_283, OG_334, OG_096, OG_321, OG_339, OG_131, OG_255, OG_280, OG_188, OG_293
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Priest_06", new CardDef(new[] {"OG_281","OG_284","OG_162","OG_286","OG_283","OG_334","OG_096","OG_321","OG_339","OG_131","OG_255","OG_280","OG_188","OG_293"}, new Power
			{
				// TODO [TB_EVILBRM_Priest_06] Old God && Test: Old God_TB_EVILBRM_Priest_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_EVILBRM_Priest_07] Pint-Sized (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: DAL_544, FP1_001, UNG_809, DAL_030, TRL_502, UNG_022, TRL_131, DAL_773, LOOT_394, GIL_212, NEW1_026, KAR_114, GIL_620, OG_316, TRL_260, GVG_110, LOOT_278, GIL_813, BOT_567, ULD_719, ULD_712, ULD_282, ULD_723
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Priest_07", new CardDef(new[] {"DAL_544","FP1_001","UNG_809","DAL_030","TRL_502","UNG_022","TRL_131","DAL_773","LOOT_394","GIL_212","NEW1_026","KAR_114","GIL_620","OG_316","TRL_260","GVG_110","LOOT_278","GIL_813","BOT_567","ULD_719","ULD_712","ULD_282","ULD_723"}, new Power
			{
				// TODO [TB_EVILBRM_Priest_07] Pint-Sized && Test: Pint-Sized_TB_EVILBRM_Priest_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_EVILBRM_Priest_11] Miracles (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: BOT_558, EX1_055, UNG_034, NEW1_020, EX1_044, TRL_131, KAR_035, NEW1_026, UNG_963, BOT_258, EX1_095, TRL_408, CS2_004, UNG_029, ICC_802, BOT_219, LOOT_278, BOT_529, LOOT_209
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Priest_11", new CardDef(new[] {"BOT_558","EX1_055","UNG_034","NEW1_020","EX1_044","TRL_131","KAR_035","NEW1_026","UNG_963","BOT_258","EX1_095","TRL_408","CS2_004","UNG_029","ICC_802","BOT_219","LOOT_278","BOT_529","LOOT_209"}, new Power
			{
				// TODO [TB_EVILBRM_Priest_11] Miracles && Test: Miracles_TB_EVILBRM_Priest_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_TagTeam_Priest] Unbreakable (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Inspire</b> your minions, even in death.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Priest", new CardDef(new Power
			{
				// TODO [TB_TagTeam_Priest] Unbreakable && Test: Unbreakable_TB_TagTeam_Priest
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TB_TempleOutrun_Mirrors] Mirror, Mirror (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_EVILBRM_LOOTA_813, TB_EVILBRM_LOOTA_813, TB_EVILBRM_LOOTA_813
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Mirrors", new CardDef(new[] {"TB_EVILBRM_LOOTA_813","TB_EVILBRM_LOOTA_813","TB_EVILBRM_LOOTA_813"}, new Power
			{
				// TODO [TB_TempleOutrun_Mirrors] Mirror, Mirror && Test: Mirror, Mirror_TB_TempleOutrun_Mirrors
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void RogueNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [FB_Champs_ICC_221e] Leeching Poison (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Has <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_ICC_221e", new CardDef(new Power
			{
				// TODO [FB_Champs_ICC_221e] Leeching Poison && Test: Leeching Poison_FB_Champs_ICC_221e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Champs_ICC_221e")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [FB_Juggernaut_Rogue_Ench] Opponent's Class: Rogue Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent: Rogue
			// --------------------------------------------------------
			// Entourage: CS2_083b
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Rogue_Ench", new CardDef(new[] {"CS2_083b"}, new Power
			{
				// TODO [FB_Juggernaut_Rogue_Ench] Opponent's Class: Rogue Ench && Test: Opponent's Class: Rogue Ench_FB_Juggernaut_Rogue_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Juggernaut_Rogue_Ench")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [FB_LK_Rogue_Ench_copy] Next Hero: Rogue Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Rogue cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_083b
			// --------------------------------------------------------
			cards.Add("FB_LK_Rogue_Ench_copy", new CardDef(new[] {"CS2_083b"}, new Power
			{
				// TODO [FB_LK_Rogue_Ench_copy] Next Hero: Rogue Ench Copy && Test: Next Hero: Rogue Ench Copy_FB_LK_Rogue_Ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK_Rogue_Ench_copy")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [FB_TagTeam_Rogue_Ench] Next Hero: Rogue Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Rogue cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_083b
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Rogue_Ench", new CardDef(new[] {"CS2_083b"}, new Power
			{
				// TODO [FB_TagTeam_Rogue_Ench] Next Hero: Rogue Ench && Test: Next Hero: Rogue Ench_FB_TagTeam_Rogue_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_TagTeam_Rogue_Ench")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TB_BlingBrawl_Hero1e] Sharpened (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +1 Attack
			// --------------------------------------------------------
			cards.Add("TB_BlingBrawl_Hero1e", new CardDef(new Power
			{
				// TODO [TB_BlingBrawl_Hero1e] Sharpened && Test: Sharpened_TB_BlingBrawl_Hero1e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_BlingBrawl_Hero1e")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TB_ShadowReflection_001e] Shadow Reflection (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Always copy your last played card.
			// --------------------------------------------------------
			cards.Add("TB_ShadowReflection_001e", new CardDef(new Power
			{
				// TODO [TB_ShadowReflection_001e] Shadow Reflection && Test: Shadow Reflection_TB_ShadowReflection_001e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_ShadowReflection_001e")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TB_Superfriends001e] Facilitated (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The next legend you cast this turn costs (3) less.
			// --------------------------------------------------------
			cards.Add("TB_Superfriends001e", new CardDef(new Power
			{
				// TODO [TB_Superfriends001e] Facilitated && Test: Facilitated_TB_Superfriends001e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Superfriends001e")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TB_Superfriends002e] Draw Offensive Play (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Draw Offensive Play on first, third, and fifth turn
			// --------------------------------------------------------
			cards.Add("TB_Superfriends002e", new CardDef(new Power
			{
				// TODO [TB_Superfriends002e] Draw Offensive Play && Test: Draw Offensive Play_TB_Superfriends002e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Superfriends002e")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TB_TempleOutrun_ECo] Contracted (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The next spell you cast this turn cost (0).
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_ECo", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_ECo] Contracted && Test: Contracted_TB_TempleOutrun_ECo
				InfoCardId = "TB_TempleOutrun_ECovo",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_TempleOutrun_ECo")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TB_TempleOutrun_ECovo] Covenanted (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All cards played this turn cost (0).
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_ECovo", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_ECovo] Covenanted && Test: Covenanted_TB_TempleOutrun_ECovo
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_TempleOutrun_ECovo")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TB_TempleRun_BestFriendBuff] Friendship (Can't be Silenced) (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased Stats
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleRun_BestFriendBuff", new CardDef(new Power
			{
				// TODO [TB_TempleRun_BestFriendBuff] Friendship (Can't be Silenced) && Test: Friendship (Can't be Silenced)_TB_TempleRun_BestFriendBuff
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_TempleRun_BestFriendBuff")
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [EVILBRM_DALA_Rogue_02] Thief (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: KAR_069, OG_330, DAL_714, GIL_827, GIL_677, CFM_781, DAL_416, ICC_811, KAR_070, GVG_028, GIL_598, GIL_598, BRM_030, UNG_856, DAL_716, GIL_672
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("EVILBRM_DALA_Rogue_02", new CardDef(new[] {"KAR_069","OG_330","DAL_714","GIL_827","GIL_677","CFM_781","DAL_416","ICC_811","KAR_070","GVG_028","GIL_598","GIL_598","BRM_030","UNG_856","DAL_716","GIL_672"}, new Power
			{
				// TODO [EVILBRM_DALA_Rogue_02] Thief && Test: Thief_EVILBRM_DALA_Rogue_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [FB_Champs_CS2_073] Cold Blood (*) - COST:1 
			// - Fac: neutral, Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2 Attack. <b>Combo:</b> +4 Attack instead.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_CS2_073", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [FB_Champs_CS2_073] Cold Blood && Test: Cold Blood_FB_Champs_CS2_073
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_Champs_CS2_233", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_WEAPON_EQUIPPED,0}}, new Power
			{
				// TODO [FB_Champs_CS2_233] Blade Flurry && Test: Blade Flurry_FB_Champs_CS2_233
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [FB_Champs_ICC_221] Leeching Poison (*) - COST:2 
			// - Fac: neutral, Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: Give your weapon <b>Lifesteal</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_ICC_221", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_WEAPON_EQUIPPED,0}}, new Power
			{
				// TODO [FB_Champs_ICC_221] Leeching Poison && Test: Leeching Poison_FB_Champs_ICC_221
				InfoCardId = "FB_Champs_ICC_221e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [FB_Champs_UNG_067] The Caverns Below (*) - COST:1 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Play four minions
			//       with the same name.
			//       <b>Reward:</b> Crystal Core.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 4
			// - 676 = 1
			// - 839 = 1
			// - QUEST_REWARD_DATABASE_ID = 55127
			// --------------------------------------------------------
			cards.Add("FB_Champs_UNG_067", new CardDef(new Power
			{
				// TODO [FB_Champs_UNG_067] The Caverns Below && Test: The Caverns Below_FB_Champs_UNG_067
				InfoCardId = "FB_Champs_UNG_067t1e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [FB_Champs_UNG_067t1] Crystal Core (*) - COST:5 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: For the rest of the game, your minions are 5/5.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - RITUAL = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_UNG_067t1", new CardDef(new Power
			{
				// TODO [FB_Champs_UNG_067t1] Crystal Core && Test: Crystal Core_FB_Champs_UNG_067t1
				InfoCardId = "FB_Champs_UNG_067t1e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [FB_Juggernaut_Rogue] Rogue (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent is a Rogue.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Rogue", new CardDef(new Power
			{
				// TODO [FB_Juggernaut_Rogue] Rogue && Test: Rogue_FB_Juggernaut_Rogue
				InfoCardId = "FB_Juggernaut_Rogue_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [FB_LK_Rogue_copy] Rogue (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Rogue as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Rogue_copy", new CardDef(new Power
			{
				// TODO [FB_LK_Rogue_copy] Rogue && Test: Rogue_FB_LK_Rogue_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_ClassRandom_Rogue] Second Class: Rogue (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Rogue cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Rogue", new CardDef(new Power
			{
				// TODO [TB_ClassRandom_Rogue] Second Class: Rogue && Test: Second Class: Rogue_TB_ClassRandom_Rogue
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_CoOpv3_201] Cast from Shadow (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy all undamaged minions. Return the rest to their owner's hand.
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_201", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_201] Cast from Shadow && Test: Cast from Shadow_TB_CoOpv3_201
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_EVILBRM_Rogue_01] Combo (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: OG_070, EX1_131, EX1_613, DAL_415, EX1_134, LOOT_211, TRL_092, UNG_064, GIL_557, CS2_073, EX1_124, CFM_690
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Rogue_01", new CardDef(new[] {"OG_070","EX1_131","EX1_613","DAL_415","EX1_134","LOOT_211","TRL_092","UNG_064","GIL_557","CS2_073","EX1_124","CFM_690"}, new Power
			{
				// TODO [TB_EVILBRM_Rogue_01] Combo && Test: Combo_TB_EVILBRM_Rogue_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_EVILBRM_Rogue_02] Thief (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: KAR_069, OG_330, DAL_714, GIL_827, GIL_677, CFM_781, DAL_416, ICC_811, KAR_070, GVG_028, GIL_598, GIL_598, BRM_030, UNG_856, DAL_716, GIL_672
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Rogue_02", new CardDef(new[] {"KAR_069","OG_330","DAL_714","GIL_827","GIL_677","CFM_781","DAL_416","ICC_811","KAR_070","GVG_028","GIL_598","GIL_598","BRM_030","UNG_856","DAL_716","GIL_672"}, new Power
			{
				// TODO [TB_EVILBRM_Rogue_02] Thief && Test: Thief_TB_EVILBRM_Rogue_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_EVILBRM_Rogue_03] Trickery (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: BOT_288, DAL_400, DAL_415, LOOT_165, BOT_559, LOOT_026, LOOT_412, DAL_417, DAL_719, TRL_541, DAL_010, EX1_581, AT_035, BOT_087, DAL_366, OG_073, DAL_720, ICC_827
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Rogue_03", new CardDef(new[] {"BOT_288","DAL_400","DAL_415","LOOT_165","BOT_559","LOOT_026","LOOT_412","DAL_417","DAL_719","TRL_541","DAL_010","EX1_581","AT_035","BOT_087","DAL_366","OG_073","DAL_720","ICC_827"}, new Power
			{
				// TODO [TB_EVILBRM_Rogue_03] Trickery && Test: Trickery_TB_EVILBRM_Rogue_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_EVILBRM_Rogue_05] Deathrattle (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: CFM_691, LOE_019, LOE_012, FP1_031, DAL_749, BOT_243, DAL_775, TRL_537, AT_036, OG_133, OG_072, BOT_084, BOT_508, LOOT_503, BOT_286
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Rogue_05", new CardDef(new[] {"CFM_691","LOE_019","LOE_012","FP1_031","DAL_749","BOT_243","DAL_775","TRL_537","AT_036","OG_133","OG_072","BOT_084","BOT_508","LOOT_503","BOT_286"}, new Power
			{
				// TODO [TB_EVILBRM_Rogue_05] Deathrattle && Test: Deathrattle_TB_EVILBRM_Rogue_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_EVILBRM_Rogue_07] Scallywags (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: KAR_069, CS2_146, GVG_075, TRL_071, NEW1_027, AT_032, TRL_015, OG_267, NEW1_024, AT_070, TRL_126, TRL_124, TRL_157, GIL_687, TRL_127, TRL_074
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Rogue_07", new CardDef(new[] {"KAR_069","CS2_146","GVG_075","TRL_071","NEW1_027","AT_032","TRL_015","OG_267","NEW1_024","AT_070","TRL_126","TRL_124","TRL_157","GIL_687","TRL_127","TRL_074"}, new Power
			{
				// TODO [TB_EVILBRM_Rogue_07] Scallywags && Test: Scallywags_TB_EVILBRM_Rogue_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_EVILBRM_Rogue_08] Cutthroat (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: CS2_188, EX1_008, EX1_162, UNG_075, AT_087, EX1_046, ICC_029, DAL_749, EX1_116, DAL_592, CS2_073, EX1_124, GVG_022
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Rogue_08", new CardDef(new[] {"CS2_188","EX1_008","EX1_162","UNG_075","AT_087","EX1_046","ICC_029","DAL_749","EX1_116","DAL_592","CS2_073","EX1_124","GVG_022"}, new Power
			{
				// TODO [TB_EVILBRM_Rogue_08] Cutthroat && Test: Cutthroat_TB_EVILBRM_Rogue_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_EVILBRM_Rogue_09] Draw! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: EX1_012, EX1_096, EX1_007, EX1_050, LOOT_211, DAL_582, DAL_565, BRM_031, EX1_145, EX1_278, UNG_060, EX1_129, BOT_242, OG_073, CS2_077
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Rogue_09", new CardDef(new[] {"EX1_012","EX1_096","EX1_007","EX1_050","LOOT_211","DAL_582","DAL_565","BRM_031","EX1_145","EX1_278","UNG_060","EX1_129","BOT_242","OG_073","CS2_077"}, new Power
			{
				// TODO [TB_EVILBRM_Rogue_09] Draw! && Test: Draw!_TB_EVILBRM_Rogue_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_EVILBRM_Rogue_10] Battlecry (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: BOT_283, LOE_077, GIL_827, LOOT_165, GVG_107, LOOT_026, DAL_416, TRL_092, OG_080, TRL_409, ICC_257, OG_291, TRL_077, UNG_848, ICC_705, EX1_144, DAL_728, DAL_010, NEW1_004
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Rogue_10", new CardDef(new[] {"BOT_283","LOE_077","GIL_827","LOOT_165","GVG_107","LOOT_026","DAL_416","TRL_092","OG_080","TRL_409","ICC_257","OG_291","TRL_077","UNG_848","ICC_705","EX1_144","DAL_728","DAL_010","NEW1_004"}, new Power
			{
				// TODO [TB_EVILBRM_Rogue_10] Battlecry && Test: Battlecry_TB_EVILBRM_Rogue_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_EVILBRM_Rogue_11] Spellslinger (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: EX1_012, UNG_058, NEW1_026, DAL_095, EX1_284, EX1_095, EX1_563, OG_134, CS2_072, EX1_145, GIL_506, EX1_124, CFM_690, EX1_278, EX1_129, OG_176, EX1_044
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Rogue_11", new CardDef(new[] {"EX1_012","UNG_058","NEW1_026","DAL_095","EX1_284","EX1_095","EX1_563","OG_134","CS2_072","EX1_145","GIL_506","EX1_124","CFM_690","EX1_278","EX1_129","OG_176","EX1_044"}, new Power
			{
				// TODO [TB_EVILBRM_Rogue_11] Spellslinger && Test: Spellslinger_TB_EVILBRM_Rogue_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_EVILBRM_Rogue_12] Legends (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: EX1_613, GIL_677, BOT_243, FP1_030, EX1_116, BRM_028, EX1_110, EX1_016, ICC_314, AT_036, EX1_563, EX1_572, FP1_010, GVG_110, LOOT_357, EX1_298, GVG_114
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Rogue_12", new CardDef(new[] {"EX1_613","GIL_677","BOT_243","FP1_030","EX1_116","BRM_028","EX1_110","EX1_016","ICC_314","AT_036","EX1_563","EX1_572","FP1_010","GVG_110","LOOT_357","EX1_298","GVG_114"}, new Power
			{
				// TODO [TB_EVILBRM_Rogue_12] Legends && Test: Legends_TB_EVILBRM_Rogue_12
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_ShadowReflection_001", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MUST_PLAY_OTHER_CARD_FIRST,0}}, new Power
			{
				// TODO [TB_ShadowReflection_001] Shadow Reflection && Test: Shadow Reflection_TB_ShadowReflection_001
				InfoCardId = "TB_ShadowReflection_001e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_TagTeam_Rogue] The Saint (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Assassinate with blinding speed!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Rogue", new CardDef(new Power
			{
				// TODO [TB_TagTeam_Rogue] The Saint && Test: The Saint_TB_TagTeam_Rogue
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_TempleOutrun_EC] Ethereal Contract (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your next card costs (0) and is removed from your Dungeon Deck.
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_EC", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_EC] Ethereal Contract && Test: Ethereal Contract_TB_TempleOutrun_EC
				InfoCardId = "TB_TempleOutrun_ECe",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TB_TempleOutrun_ECov] Ethereal Covenant (*) - COST:1 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Cards played this turn cost (0) and are removed from your Dungeon Deck.
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_ECov", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_ECov] Ethereal Covenant && Test: Ethereal Covenant_TB_TempleOutrun_ECov
				InfoCardId = "TB_TempleOutrun_ECovo",
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void ShamanNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [FB_Juggernaut_Shaman_Ench] Opponent's Class: Shaman Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent: Shaman
			// --------------------------------------------------------
			// Entourage: CS2_049
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Shaman_Ench", new CardDef(new[] {"CS2_049"}, new Power
			{
				// TODO [FB_Juggernaut_Shaman_Ench] Opponent's Class: Shaman Ench && Test: Opponent's Class: Shaman Ench_FB_Juggernaut_Shaman_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Juggernaut_Shaman_Ench")
			}));

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [FB_LK_Shaman_Ench_copy] Next Hero: Shaman Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Shaman cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_049
			// --------------------------------------------------------
			cards.Add("FB_LK_Shaman_Ench_copy", new CardDef(new[] {"CS2_049"}, new Power
			{
				// TODO [FB_LK_Shaman_Ench_copy] Next Hero: Shaman Ench Copy && Test: Next Hero: Shaman Ench Copy_FB_LK_Shaman_Ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK_Shaman_Ench_copy")
			}));

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [FB_TagTeam_Shaman_Ench] Next Hero: Shaman Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Shaman cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_049
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Shaman_Ench", new CardDef(new[] {"CS2_049"}, new Power
			{
				// TODO [FB_TagTeam_Shaman_Ench] Next Hero: Shaman Ench && Test: Next Hero: Shaman Ench_FB_TagTeam_Shaman_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_TagTeam_Shaman_Ench")
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [FB_Champs_EX1_565] Flametongue Totem (*) - COST:2 [ATK:0/HP:3] 
			// - Race: totem, Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Adjacent minions have +2_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ADJACENT_BUFF = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_565", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_565] Flametongue Totem && Test: Flametongue Totem_FB_Champs_EX1_565
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_Champs_EX1_246", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [FB_Champs_EX1_246] Hex && Test: Hex_FB_Champs_EX1_246
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [FB_Juggernaut_Shaman] Shaman (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent is a Shaman.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Shaman", new CardDef(new Power
			{
				// TODO [FB_Juggernaut_Shaman] Shaman && Test: Shaman_FB_Juggernaut_Shaman
				InfoCardId = "FB_Juggernaut_Shaman_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [FB_LK_Shaman_copy] Shaman (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Shaman as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Shaman_copy", new CardDef(new Power
			{
				// TODO [FB_LK_Shaman_copy] Shaman && Test: Shaman_FB_LK_Shaman_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_ClassRandom_Shaman] Second Class: Shaman (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Shaman cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Shaman", new CardDef(new Power
			{
				// TODO [TB_ClassRandom_Shaman] Second Class: Shaman && Test: Second Class: Shaman_TB_ClassRandom_Shaman
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_CoOpv3_006] Elemental Eruption (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 4-6 damage to all other minions.
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_006", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_006] Elemental Eruption && Test: Elemental Eruption_TB_CoOpv3_006
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_EVILBRM_Shaman_01] Flood (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: EX1_565, UNG_201, AT_046, LOOT_167, DAL_566, ICC_900, BOT_102, LOE_089, UNG_010, CS2_222, EX1_562, TRL_012, BOT_451, KAR_073, EX1_248, UNG_956, CFM_310, CS2_046, TRL_351
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Shaman_01", new CardDef(new[] {"EX1_565","UNG_201","AT_046","LOOT_167","DAL_566","ICC_900","BOT_102","LOE_089","UNG_010","CS2_222","EX1_562","TRL_012","BOT_451","KAR_073","EX1_248","UNG_956","CFM_310","CS2_046","TRL_351"}, new Power
			{
				// TODO [TB_EVILBRM_Shaman_01] Flood && Test: Flood_TB_EVILBRM_Shaman_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_EVILBRM_Shaman_03] Fishy (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: DAL_077, GIL_678, DAL_049, UNG_073, EX1_507, EX1_103, UNG_937, UNG_089, TRL_520, EX1_062, GVG_040, DAL_726, CFM_344, OG_161, GVG_042, ICC_089, DAL_710, CFM_310, LOE_113
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Shaman_03", new CardDef(new[] {"DAL_077","GIL_678","DAL_049","UNG_073","EX1_507","EX1_103","UNG_937","UNG_089","TRL_520","EX1_062","GVG_040","DAL_726","CFM_344","OG_161","GVG_042","ICC_089","DAL_710","CFM_310","LOE_113"}, new Power
			{
				// TODO [TB_EVILBRM_Shaman_03] Fishy && Test: Fishy_TB_EVILBRM_Shaman_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_EVILBRM_Shaman_05] Big Shaman (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: ICC_912, DAL_052, BOT_548, CFM_324, NEW1_010, DAL_047, GIL_616, ICC_314, EX1_563, EX1_572, DAL_553, OG_042, CS2_039, BOT_099
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Shaman_05", new CardDef(new[] {"ICC_912","DAL_052","BOT_548","CFM_324","NEW1_010","DAL_047","GIL_616","ICC_314","EX1_563","EX1_572","DAL_553","OG_042","CS2_039","BOT_099"}, new Power
			{
				// TODO [TB_EVILBRM_Shaman_05] Big Shaman && Test: Big Shaman_TB_EVILBRM_Shaman_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_EVILBRM_Shaman_06] Elemental Wrath (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: UNG_809, UNG_202, BOT_533, GIL_581, UNG_070, UNG_816, EX1_250, CS2_042, UNG_208, EX1_249, UNG_847, EX1_298, UNG_211, DAL_047, UNG_907, BOT_093
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Shaman_06", new CardDef(new[] {"UNG_809","UNG_202","BOT_533","GIL_581","UNG_070","UNG_816","EX1_250","CS2_042","UNG_208","EX1_249","UNG_847","EX1_298","UNG_211","DAL_047","UNG_907","BOT_093"}, new Power
			{
				// TODO [TB_EVILBRM_Shaman_06] Elemental Wrath && Test: Elemental Wrath_TB_EVILBRM_Shaman_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_EVILBRM_Shaman_07] Battlecry (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: ICC_058, LOOT_517, LOE_077, LOOT_516, LOE_016, DAL_546, ICC_466, CFM_668, FP1_030, LOOT_167, ICC_257, LOOT_358, AT_054, UNG_848, GIL_820, DAL_431, GIL_836
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Shaman_07", new CardDef(new[] {"ICC_058","LOOT_517","LOE_077","LOOT_516","LOE_016","DAL_546","ICC_466","CFM_668","FP1_030","LOOT_167","ICC_257","LOOT_358","AT_054","UNG_848","GIL_820","DAL_431","GIL_836"}, new Power
			{
				// TODO [TB_EVILBRM_Shaman_07] Battlecry && Test: Battlecry_TB_EVILBRM_Shaman_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_EVILBRM_Shaman_08] Spells (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: GIL_531, TRL_060, BOT_411, KAR_021, EX1_284, GIL_807, EX1_563, OG_134, EX1_245, EX1_238, GVG_038, KAR_073, EX1_241, TRL_058, EX1_259, DAL_009, LOOT_506, GIL_504
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Shaman_08", new CardDef(new[] {"GIL_531","TRL_060","BOT_411","KAR_021","EX1_284","GIL_807","EX1_563","OG_134","EX1_245","EX1_238","GVG_038","KAR_073","EX1_241","TRL_058","EX1_259","DAL_009","LOOT_506","GIL_504"}, new Power
			{
				// TODO [TB_EVILBRM_Shaman_08] Spells && Test: Spells_TB_EVILBRM_Shaman_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_EVILBRM_Shaman_10] Regeneration (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: DAL_544, CFM_120, UNG_938, CS2_117, LOOT_291, GIL_622, CFM_061, OG_209, GIL_667, GVG_069, GIL_118, DAL_432, LOOT_373, AT_048, UNG_817
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Shaman_10", new CardDef(new[] {"DAL_544","CFM_120","UNG_938","CS2_117","LOOT_291","GIL_622","CFM_061","OG_209","GIL_667","GVG_069","GIL_118","DAL_432","LOOT_373","AT_048","UNG_817"}, new Power
			{
				// TODO [TB_EVILBRM_Shaman_10] Regeneration && Test: Regeneration_TB_EVILBRM_Shaman_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_TagTeam_Shaman] Totems Versus Secrets (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Uncover your adversary's secrets, while assembling your totem army
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Shaman", new CardDef(new Power
			{
				// TODO [TB_TagTeam_Shaman] Totems Versus Secrets && Test: Totems Versus Secrets_TB_TagTeam_Shaman
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_Champs_KAR_063", new CardDef(new Power
			{
				// TODO [FB_Champs_KAR_063] Spirit Claws && Test: Spirit Claws_FB_Champs_KAR_063
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarlockNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [FB_Juggernaut_PickClass_Column] Pick Opponent's Class: Column (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: FB_Juggernaut_Hunter, FB_Juggernaut_Paladin, FB_Juggernaut_Rogue, FB_Juggernaut_Warlock
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_PickClass_Column", new CardDef(new[] {"FB_Juggernaut_Hunter","FB_Juggernaut_Paladin","FB_Juggernaut_Rogue","FB_Juggernaut_Warlock"}, new Power
			{
				// TODO [FB_Juggernaut_PickClass_Column] Pick Opponent's Class: Column && Test: Pick Opponent's Class: Column_FB_Juggernaut_PickClass_Column
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Juggernaut_PickClass_Column")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [FB_Juggernaut_PickClass_Row] Pick Opponent's Class: Row (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: FB_Juggernaut_Druid, FB_Juggernaut_Mage, FB_Juggernaut_Priest, FB_Juggernaut_Shaman, FB_Juggernaut_Warrior
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_PickClass_Row", new CardDef(new[] {"FB_Juggernaut_Druid","FB_Juggernaut_Mage","FB_Juggernaut_Priest","FB_Juggernaut_Shaman","FB_Juggernaut_Warrior"}, new Power
			{
				// TODO [FB_Juggernaut_PickClass_Row] Pick Opponent's Class: Row && Test: Pick Opponent's Class: Row_FB_Juggernaut_PickClass_Row
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Juggernaut_PickClass_Row")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [FB_Juggernaut_Warlock_Ench] Opponent's Class: Warlock Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent: Warlock
			// --------------------------------------------------------
			// Entourage: CS2_056
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Warlock_Ench", new CardDef(new[] {"CS2_056"}, new Power
			{
				// TODO [FB_Juggernaut_Warlock_Ench] Opponent's Class: Warlock Ench && Test: Opponent's Class: Warlock Ench_FB_Juggernaut_Warlock_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Juggernaut_Warlock_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [FB_Juggernaut_Warrior_Ench] Opponent's Class: Warrior Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent: Warlock
			// --------------------------------------------------------
			// Entourage: CS2_102
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Warrior_Ench", new CardDef(new[] {"CS2_102"}, new Power
			{
				// TODO [FB_Juggernaut_Warrior_Ench] Opponent's Class: Warrior Ench && Test: Opponent's Class: Warrior Ench_FB_Juggernaut_Warrior_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Juggernaut_Warrior_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [FB_LK_Warlock_Ench_copy] Next Hero: Warlock Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warlock cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_056
			// --------------------------------------------------------
			cards.Add("FB_LK_Warlock_Ench_copy", new CardDef(new[] {"CS2_056"}, new Power
			{
				// TODO [FB_LK_Warlock_Ench_copy] Next Hero: Warlock Ench Copy && Test: Next Hero: Warlock Ench Copy_FB_LK_Warlock_Ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK_Warlock_Ench_copy")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [FB_TagTeam_Warlock_Ench] Next Hero: Warlock Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warlock cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_056
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Warlock_Ench", new CardDef(new[] {"CS2_056"}, new Power
			{
				// TODO [FB_TagTeam_Warlock_Ench] Next Hero: Warlock Ench && Test: Next Hero: Warlock Ench_FB_TagTeam_Warlock_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_TagTeam_Warlock_Ench")
			}));

			// --------------------------------------- MINION - WARLOCK
			// [FB_Champs_LOOT_306] Possessed Lackey (*) - COST:5 [ATK:2/HP:2] 
			// - Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> <b>Recruit</b> a_Demon.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_LOOT_306", new CardDef(new Power
			{
				// TODO [FB_Champs_LOOT_306] Possessed Lackey && Test: Possessed Lackey_FB_Champs_LOOT_306
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TOT_204] Timeshift: Dreadsteed (*) - COST:4 [ATK:1/HP:1] 
			// - Race: demon, Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a Dreadsteed.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TOT_204", new CardDef(new Power
			{
				// TODO [TOT_204] Timeshift: Dreadsteed && Test: Timeshift: Dreadsteed_TOT_204
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EVILBRM_DALA_Warlock_02] Swarming (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: LOOT_014, OG_241, LOE_116, ICC_903, LOE_023, DAL_606, TRL_251, UNG_835, OG_113, BRM_006, AT_019, UNG_047, TRL_257, OG_114, EX1_316, GIL_191, KAR_025, TRL_555
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("EVILBRM_DALA_Warlock_02", new CardDef(new[] {"LOOT_014","OG_241","LOE_116","ICC_903","LOE_023","DAL_606","TRL_251","UNG_835","OG_113","BRM_006","AT_019","UNG_047","TRL_257","OG_114","EX1_316","GIL_191","KAR_025","TRL_555"}, new Power
			{
				// TODO [EVILBRM_DALA_Warlock_02] Swarming && Test: Swarming_EVILBRM_DALA_Warlock_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EVILBRM_DALA_Warlock_03] Draw (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: LOOT_014, OG_109, GIL_815, BOT_559, EX1_050, LOE_079, DAL_582, LOOT_526, UNG_851, EX1_284, DAL_565, DAL_185, DAL_607, TRL_541, EX1_302, BOT_568, DAL_602, OG_239
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("EVILBRM_DALA_Warlock_03", new CardDef(new[] {"LOOT_014","OG_109","GIL_815","BOT_559","EX1_050","LOE_079","DAL_582","LOOT_526","UNG_851","EX1_284","DAL_565","DAL_185","DAL_607","TRL_541","EX1_302","BOT_568","DAL_602","OG_239"}, new Power
			{
				// TODO [EVILBRM_DALA_Warlock_03] Draw && Test: Draw_EVILBRM_DALA_Warlock_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EVILBRM_DALA_Warlock_07] In Control (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: EX1_012, NEW1_021, EX1_058, EX1_043, OG_174, ICC_075, LOOT_415, GIL_618, BRM_028, GIL_124, CFM_751, GIL_825, ICC_314, LOOT_368, EX1_105, EX1_620, ICC_041, EX1_303, LOOT_043, EX1_309
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("EVILBRM_DALA_Warlock_07", new CardDef(new[] {"EX1_012","NEW1_021","EX1_058","EX1_043","OG_174","ICC_075","LOOT_415","GIL_618","BRM_028","GIL_124","CFM_751","GIL_825","ICC_314","LOOT_368","EX1_105","EX1_620","ICC_041","EX1_303","LOOT_043","EX1_309"}, new Power
			{
				// TODO [EVILBRM_DALA_Warlock_07] In Control && Test: In Control_EVILBRM_DALA_Warlock_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EVILBRM_DALA_Warlock_09] Lil' Demons (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: CS2_059, EX1_319, KAR_089, CS2_065, GVG_018, BOT_443, LOOT_013, BOT_224, BRM_006, CFM_610, DAL_751, DAL_561, TRL_249, BOT_263, EX1_596, BRM_005, DAL_007, DAL_605, GVG_045
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("EVILBRM_DALA_Warlock_09", new CardDef(new[] {"CS2_059","EX1_319","KAR_089","CS2_065","GVG_018","BOT_443","LOOT_013","BOT_224","BRM_006","CFM_610","DAL_751","DAL_561","TRL_249","BOT_263","EX1_596","BRM_005","DAL_007","DAL_605","GVG_045"}, new Power
			{
				// TODO [EVILBRM_DALA_Warlock_09] Lil' Demons && Test: Lil' Demons_EVILBRM_DALA_Warlock_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EVILBRM_DALA_Warlock_10] Empowering (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: ICC_092, EX1_004, TRL_251, ICC_094, OG_256, BOT_224, TRL_517, DAL_563, BOT_536, EX1_093, CFM_668, ICC_029, AT_090, LOOT_167, TRL_253, BOT_263, TRL_249, CFM_611
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("EVILBRM_DALA_Warlock_10", new CardDef(new[] {"ICC_092","EX1_004","TRL_251","ICC_094","OG_256","BOT_224","TRL_517","DAL_563","BOT_536","EX1_093","CFM_668","ICC_029","AT_090","LOOT_167","TRL_253","BOT_263","TRL_249","CFM_611"}, new Power
			{
				// TODO [EVILBRM_DALA_Warlock_10] Empowering && Test: Empowering_EVILBRM_DALA_Warlock_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EVILBRM_DALA_Warlock_11] Curatives (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: CFM_120, GIL_558, GVG_018, GIL_143, CS2_117, GIL_622, TRL_252, GIL_565, BOT_548, ICC_905, GIL_667, DAL_185, LOOT_017, OG_118, ICC_055, CS2_061, LOOT_043, EX1_309
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("EVILBRM_DALA_Warlock_11", new CardDef(new[] {"CFM_120","GIL_558","GVG_018","GIL_143","CS2_117","GIL_622","TRL_252","GIL_565","BOT_548","ICC_905","GIL_667","DAL_185","LOOT_017","OG_118","ICC_055","CS2_061","LOOT_043","EX1_309"}, new Power
			{
				// TODO [EVILBRM_DALA_Warlock_11] Curatives && Test: Curatives_EVILBRM_DALA_Warlock_11
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_Champs_EX1_308", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [FB_Champs_EX1_308] Soulfire && Test: Soulfire_FB_Champs_EX1_308
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [FB_Champs_LOOT_017] Dark Pact (*) - COST:1 
			// - Fac: alliance, Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a friendly minion. Restore #8 Health to your hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_LOOT_017", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [FB_Champs_LOOT_017] Dark Pact && Test: Dark Pact_FB_Champs_LOOT_017
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [FB_Juggernaut_Warlock] Warlock (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent is a Warlock.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Warlock", new CardDef(new Power
			{
				// TODO [FB_Juggernaut_Warlock] Warlock && Test: Warlock_FB_Juggernaut_Warlock
				InfoCardId = "FB_Juggernaut_Warlock_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [FB_LK_Warlock_copy] Warlock (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Warlock as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Warlock_copy", new CardDef(new Power
			{
				// TODO [FB_LK_Warlock_copy] Warlock && Test: Warlock_FB_LK_Warlock_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TB_ClassRandom_Warlock] Second Class: Warlock (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warlock cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Warlock", new CardDef(new Power
			{
				// TODO [TB_ClassRandom_Warlock] Second Class: Warlock && Test: Second Class: Warlock_TB_ClassRandom_Warlock
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TB_SPT_DpromoEX1_312] Twisting Nether? (*) - COST:8 
			// - Fac: neutral, Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: This doesn't look like Twisting Nether...
			// --------------------------------------------------------
			cards.Add("TB_SPT_DpromoEX1_312", new CardDef(new Power
			{
				// TODO [TB_SPT_DpromoEX1_312] Twisting Nether? && Test: Twisting Nether?_TB_SPT_DpromoEX1_312
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TB_TagTeam_Warlock] Death Becomes (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Summon monstrous demons and burn away the enemy's weapons
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Warlock", new CardDef(new Power
			{
				// TODO [TB_TagTeam_Warlock] Death Becomes && Test: Death Becomes_TB_TagTeam_Warlock
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [FB_LK_Warrior_Ench_copy] Next Hero: Warrior Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warrior cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_102
			// --------------------------------------------------------
			cards.Add("FB_LK_Warrior_Ench_copy", new CardDef(new[] {"CS2_102"}, new Power
			{
				// TODO [FB_LK_Warrior_Ench_copy] Next Hero: Warrior Ench Copy && Test: Next Hero: Warrior Ench Copy_FB_LK_Warrior_Ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK_Warrior_Ench_copy")
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [FB_TagTeam_Warrior_Ench] Next Hero: Warrior Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warrior cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_102
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Warrior_Ench", new CardDef(new[] {"CS2_102"}, new Power
			{
				// TODO [FB_TagTeam_Warrior_Ench] Next Hero: Warrior Ench && Test: Next Hero: Warrior Ench_FB_TagTeam_Warrior_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_TagTeam_Warrior_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [TB_MP_01e] Charge! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Has <b>Charge</b>
			// --------------------------------------------------------
			cards.Add("TB_MP_01e", new CardDef(new Power
			{
				// TODO [TB_MP_01e] Charge! && Test: Charge!_TB_MP_01e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_MP_01e")
			}));

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
			cards.Add("FB_Champs_CS2_108", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_DAMAGED_TARGET,0}}, new Power
			{
				// TODO [FB_Champs_CS2_108] Execute && Test: Execute_FB_Champs_CS2_108
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [FB_Juggernaut_Warrior] Warrior (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your opponent is a Warrior.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Warrior", new CardDef(new Power
			{
				// TODO [FB_Juggernaut_Warrior] Warrior && Test: Warrior_FB_Juggernaut_Warrior
				InfoCardId = "FB_Juggernaut_Warrior_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [FB_LK_Warrior_copy] Warrior (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Warrior as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Warrior_copy", new CardDef(new Power
			{
				// TODO [FB_LK_Warrior_copy] Warrior && Test: Warrior_FB_LK_Warrior_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [FB_Toki_Quest] Defeat the Anomalies (*) - COST:1 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Quest:</b> Defeat
			//       8 Anomalies
			//       <b>Effect:</b>Summon Anomalous Rex.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 8
			// - 676 = 1
			// - QUEST_REWARD_DATABASE_ID = 50186
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_Quest", new CardDef(new Power
			{
				// TODO [FB_Toki_Quest] Defeat the Anomalies && Test: Defeat the Anomalies_FB_Toki_Quest
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_ClassRandom_Warrior] Second Class: Warrior (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warrior cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Warrior", new CardDef(new Power
			{
				// TODO [TB_ClassRandom_Warrior] Second Class: Warrior && Test: Second Class: Warrior_TB_ClassRandom_Warrior
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_EVILBRM_Warrior_01] Mercenaries (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: OG_312, CFM_637, CS2_146, NEW1_018, TRL_507, GVG_075, OG_315, GIL_681, NEW1_027, NEW1_022, CFM_651, TRL_015, NEW1_024, GVG_070, AT_070, CS2_106, FP1_021, CS2_112, KAR_028, CFM_631
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Warrior_01", new CardDef(new[] {"OG_312","CFM_637","CS2_146","NEW1_018","TRL_507","GVG_075","OG_315","GIL_681","NEW1_027","NEW1_022","CFM_651","TRL_015","NEW1_024","GVG_070","AT_070","CS2_106","FP1_021","CS2_112","KAR_028","CFM_631"}, new Power
			{
				// TODO [TB_EVILBRM_Warrior_01] Mercenaries && Test: Mercenaries_TB_EVILBRM_Warrior_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_EVILBRM_Warrior_04] Bombs Away! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: EX1_082, BOT_431, GIL_815, LOE_077, BOT_532, DAL_060, BOT_559, EX1_050, GVG_099, CFM_667, GVG_090, BOT_511, GVG_056, DAL_064, GVG_110, ICC_091, DAL_063
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Warrior_04", new CardDef(new[] {"EX1_082","BOT_431","GIL_815","LOE_077","BOT_532","DAL_060","BOT_559","EX1_050","GVG_099","CFM_667","GVG_090","BOT_511","GVG_056","DAL_064","GVG_110","ICC_091","DAL_063"}, new Power
			{
				// TODO [TB_EVILBRM_Warrior_04] Bombs Away! && Test: Bombs Away!_TB_EVILBRM_Warrior_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_EVILBRM_Warrior_05] Rush (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TRL_327, GIL_580, GIL_155, GIL_113, GIL_803, NEW1_011, EX1_116, GIL_547, EX1_067, TRL_550, TRL_329, EX1_414, GIL_202, DAL_070, NEW1_036, DAL_062, CS2_105, BOT_069, GIL_653
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Warrior_05", new CardDef(new[] {"TRL_327","GIL_580","GIL_155","GIL_113","GIL_803","NEW1_011","EX1_116","GIL_547","EX1_067","TRL_550","TRL_329","EX1_414","GIL_202","DAL_070","NEW1_036","DAL_062","CS2_105","BOT_069","GIL_653"}, new Power
			{
				// TODO [TB_EVILBRM_Warrior_05] Rush && Test: Rush_TB_EVILBRM_Warrior_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_EVILBRM_Warrior_06] Iron and Steel (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: GVG_051, DAL_759, GVG_085, BOT_907, GVG_006, DAL_060, DAL_770, BOT_312, BOT_563, BOT_548, BOT_104, BOT_107, GVG_056, BOT_218, BOT_237, GVG_114, DAL_070, BOT_299, GVG_050, BOT_406, BOT_238
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Warrior_06", new CardDef(new[] {"GVG_051","DAL_759","GVG_085","BOT_907","GVG_006","DAL_060","DAL_770","BOT_312","BOT_563","BOT_548","BOT_104","BOT_107","GVG_056","BOT_218","BOT_237","GVG_114","DAL_070","BOT_299","GVG_050","BOT_406","BOT_238"}, new Power
			{
				// TODO [TB_EVILBRM_Warrior_06] Iron and Steel && Test: Iron and Steel_TB_EVILBRM_Warrior_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_EVILBRM_Warrior_08] Armored Up (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: BOT_059, BOT_447, LOOT_413, EX1_402, LOOT_367, DAL_759, ICC_062, CFM_756, LOOT_365, GVG_053, LOOT_519, EX1_410, ICC_837, BOT_042, AT_064, DAL_008, LOOT_364, EX1_606, KAR_091, LOOT_285
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Warrior_08", new CardDef(new[] {"BOT_059","BOT_447","LOOT_413","EX1_402","LOOT_367","DAL_759","ICC_062","CFM_756","LOOT_365","GVG_053","LOOT_519","EX1_410","ICC_837","BOT_042","AT_064","DAL_008","LOOT_364","EX1_606","KAR_091","LOOT_285"}, new Power
			{
				// TODO [TB_EVILBRM_Warrior_08] Armored Up && Test: Armored Up_TB_EVILBRM_Warrior_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_EVILBRM_Warrior_09] Arsenal (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: CS2_146, NEW1_018, CFM_643, BOT_083, CFM_755, AT_066, EX1_398, NEW1_024, OG_220, EX1_409, GIL_537, LOOT_203, UNG_929, CFM_631, ICC_064, CS2_112, BOT_406, TRL_325, EX1_411
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Warrior_09", new CardDef(new[] {"CS2_146","NEW1_018","CFM_643","BOT_083","CFM_755","AT_066","EX1_398","NEW1_024","OG_220","EX1_409","GIL_537","LOOT_203","UNG_929","CFM_631","ICC_064","CS2_112","BOT_406","TRL_325","EX1_411"}, new Power
			{
				// TODO [TB_EVILBRM_Warrior_09] Arsenal && Test: Arsenal_TB_EVILBRM_Warrior_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_EVILBRM_Warrior_10] All Might (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: NEW1_021, NEW1_041, AT_130, EX1_002, GIL_124, UNG_933, NEW1_030, TRL_321, CFM_716, EX1_391, CS2_104, CS2_114, CS2_108, EX1_407, GVG_052, GVG_054
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_Warrior_10", new CardDef(new[] {"NEW1_021","NEW1_041","AT_130","EX1_002","GIL_124","UNG_933","NEW1_030","TRL_321","CFM_716","EX1_391","CS2_104","CS2_114","CS2_108","EX1_407","GVG_052","GVG_054"}, new Power
			{
				// TODO [TB_EVILBRM_Warrior_10] All Might && Test: All Might_TB_EVILBRM_Warrior_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_Henchmania_ChuHt] Improvised Explosive (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Casts When Drawn</b>
			//       You take 2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			// RefTag:
			// - CASTSWHENDRAWN = 1
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_ChuHt", new CardDef(new Power
			{
				// TODO [TB_Henchmania_ChuHt] Improvised Explosive && Test: Improvised Explosive_TB_Henchmania_ChuHt
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecre8] Visions of the Assassin (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Stealth</b>, All minions equip a dagger.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecre8", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecre8] Visions of the Assassin && Test: Visions of the Assassin_TB_SPT_DPromoSecre8
				InfoCardId = "TB_SPT_DPromoSecre8e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret1] Visions of the Barbarian (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Charge</b>, THUNDER FURY!
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret1", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecret1] Visions of the Barbarian && Test: Visions of the Barbarian_TB_SPT_DPromoSecret1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret10] Visions of Hate (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When both heroes have 15 or less Health, BRAWL!
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret10", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecret10] Visions of Hate && Test: Visions of Hate_TB_SPT_DPromoSecret10
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_DPromoSecret2", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecret2] Visions of the Crusader && Test: Visions of the Crusader_TB_SPT_DPromoSecret2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret3] Visions of Valor (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a Legendary minion, give all minions <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret3", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecret3] Visions of Valor && Test: Visions of Valor_TB_SPT_DPromoSecret3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret4] Visions of Fate (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent takes lethal damage... save him.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret4", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecret4] Visions of Fate && Test: Visions of Fate_TB_SPT_DPromoSecret4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret5] Visions of the Amazon (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Battlecry</b>, Summon a Mirror Image for both players.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret5", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecret5] Visions of the Amazon && Test: Visions of the Amazon_TB_SPT_DPromoSecret5
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret6] Visions of the Sorcerer (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Spell Damage</b>, Summon 2 Guardians.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret6", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecret6] Visions of the Sorcerer && Test: Visions of the Sorcerer_TB_SPT_DPromoSecret6
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret7] Visions of the Necromancer (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a card with <b>Deathrattle</b>, destroy it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret7", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecret7] Visions of the Necromancer && Test: Visions of the Necromancer_TB_SPT_DPromoSecret7
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret9] Visions of Knowledge (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent's hand has 9 or more cards, reduce the cost of all cards in both hands to (1).
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret9", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecret9] Visions of Knowledge && Test: Visions of Knowledge_TB_SPT_DPromoSecret9
				InfoCardId = "TB_SPT_DPromoSecret9e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_TagTeam_Warrior] The Rock (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Enrage your allies, while wielding weapons at your foes!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Warrior", new CardDef(new Power
			{
				// TODO [TB_TagTeam_Warrior] The Rock && Test: The Rock_TB_TagTeam_Warrior
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_TempleOutrun_Warrior_11] Taunt (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: CFM_790, UNG_808, AT_069, UNG_928, UNG_072, GIL_207, LOE_022, CFM_756, UNG_957, FP1_012, GIL_667, DAL_088, UNG_925, UNG_838, UNG_848, OG_340, CFM_940, AT_068, AT_065, BOT_548
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Warrior_11", new CardDef(new[] {"CFM_790","UNG_808","AT_069","UNG_928","UNG_072","GIL_207","LOE_022","CFM_756","UNG_957","FP1_012","GIL_667","DAL_088","UNG_925","UNG_838","UNG_848","OG_340","CFM_940","AT_068","AT_065","BOT_548"}, new Power
			{
				// TODO [TB_TempleOutrun_Warrior_11] Taunt && Test: Taunt_TB_TempleOutrun_Warrior_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [FB_Champs_CS2_106] Fiery War Axe (*) - COST:2 [ATK:3/HP:0] 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("FB_Champs_CS2_106", new CardDef(new Power
			{
				// TODO [FB_Champs_CS2_106] Fiery War Axe && Test: Fiery War Axe_FB_Champs_CS2_106
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void DreamNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - DREAM
			// [TB_MP_02e] Repurposed (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a card.
			// --------------------------------------------------------
			cards.Add("TB_MP_02e", new CardDef(new Power
			{
				// TODO [TB_MP_02e] Repurposed && Test: Repurposed_TB_MP_02e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_MP_02e")
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRMC_100e] Living Bomb (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: On Ragnaros' turn, deal 5 damage to this side of the board.
			// --------------------------------------------------------
			cards.Add("BRMC_100e", new CardDef(new Power
			{
				// TODO [BRMC_100e] Living Bomb && Test: Living Bomb_BRMC_100e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("BRMC_100e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRMC_86e] I Hear You... (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("BRMC_86e", new CardDef(new Power
			{
				// TODO [BRMC_86e] I Hear You... && Test: I Hear You..._BRMC_86e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("BRMC_86e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRMC_97e] Burning Adrenaline (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			cards.Add("BRMC_97e", new CardDef(new Power
			{
				// TODO [BRMC_97e] Burning Adrenaline && Test: Burning Adrenaline_BRMC_97e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("BRMC_97e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRMC_98e] Dragonlust (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("BRMC_98e", new CardDef(new Power
			{
				// TODO [BRMC_98e] Dragonlust && Test: Dragonlust_BRMC_98e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("BRMC_98e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl001] Innkeeper Tools - Build A Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Play the Brawl as normal or Build a new brawl
			// --------------------------------------------------------
			// Entourage: FB_BuildABrawl001a, FB_BuildABrawl001b, FB_BuildABrawl001c, FB_BuildABrawl003c
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001", new CardDef(new[] {"FB_BuildABrawl001a","FB_BuildABrawl001b","FB_BuildABrawl001c","FB_BuildABrawl003c"}, new Power
			{
				// TODO [FB_BuildABrawl001] Innkeeper Tools - Build A Brawl && Test: Innkeeper Tools - Build A Brawl_FB_BuildABrawl001
				InfoCardId = "FB_BuildABrawl001a_ench",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl001")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl001a_ench] By the Power of Ragnaros! Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each turn reduce the cost of all cards by (1).
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001a_ench", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl001a_ench] By the Power of Ragnaros! Enchant && Test: By the Power of Ragnaros! Enchant_FB_BuildABrawl001a_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl001a_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl001b_ench] Randomonium Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each turn randomize the cost of all cards in your hand.
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001b_ench", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl001b_ench] Randomonium Enchant && Test: Randomonium Enchant_FB_BuildABrawl001b_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl001b_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl001c_ench] Battle of Tol Barad Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After a minion is played add a spell of the same mana cost to your hand. 
			//        It costs (0).
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001c_ench", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl001c_ench] Battle of Tol Barad Enchant && Test: Battle of Tol Barad Enchant_FB_BuildABrawl001c_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl001c_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl002] Innkeeper Tools - Build A Brawl 2 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Second Tier of Choices for Build A Brawl
			// --------------------------------------------------------
			// Entourage: FB_BuildABrawl002a, FB_BuildABrawl002b, FB_BuildABrawl002c, FB_BuildABrawl003b
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002", new CardDef(new[] {"FB_BuildABrawl002a","FB_BuildABrawl002b","FB_BuildABrawl002c","FB_BuildABrawl003b"}, new Power
			{
				// TODO [FB_BuildABrawl002] Innkeeper Tools - Build A Brawl 2 && Test: Innkeeper Tools - Build A Brawl 2_FB_BuildABrawl002
				InfoCardId = "FB_BuildABrawl002a_ench",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl002")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl002a_ench] Great Summoner Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Spells summon minions of the same mana cost.
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002a_ench", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl002a_ench] Great Summoner Enchant && Test: Great Summoner Enchant_FB_BuildABrawl002a_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl002a_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl002b_ench] Masked Ball Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All minions gain <b>Deathrattle:</b> Summon a minion that costs (2) less.
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002b_ench", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl002b_ench] Masked Ball Enchant && Test: Masked Ball Enchant_FB_BuildABrawl002b_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl002b_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl002c_ench] Servant of Yogg Saron Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All minons cast a random spell at a random target when played.
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002c_ench", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl002c_ench] Servant of Yogg Saron Enchant && Test: Servant of Yogg Saron Enchant_FB_BuildABrawl002c_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl002c_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl003] Innkeeper Tools - Build A Brawl 3 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Third Tier of Choices for Build A Brawl
			// --------------------------------------------------------
			// Entourage: 00000011-91c8-41bf-87c6-63491203f862, FB_BuildABrawl003b, FB_BuildABrawl003c
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl003", new CardDef(new[] {"00000011-91c8-41bf-87c6-63491203f862","FB_BuildABrawl003b","FB_BuildABrawl003c"}, new Power
			{
				// TODO [FB_BuildABrawl003] Innkeeper Tools - Build A Brawl 3 && Test: Innkeeper Tools - Build A Brawl 3_FB_BuildABrawl003
				InfoCardId = "FB_BuildABrawl003b_ench",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl003")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl003b_ench] Clash of the Minions Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All minions gain <b>Charge</b> and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl003b_ench", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl003b_ench] Clash of the Minions Enchant && Test: Clash of the Minions Enchant_FB_BuildABrawl003b_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl003b_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl003c_ench] Blood Magic Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All spells cost health instead of mana
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl003c_ench", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl003c_ench] Blood Magic Enchant && Test: Blood Magic Enchant_FB_BuildABrawl003c_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl003c_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl_Tools_ench] Build-A-Brawl Innkeeper Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Choose a new blend of Tavern Brawls for your Fireside Gathering.
			// --------------------------------------------------------
			// Entourage: FB_IKC_SetupNo, FB_BuildABrawl_Tools_reset
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl_Tools_ench", new CardDef(new[] {"FB_IKC_SetupNo","FB_BuildABrawl_Tools_reset"}, new Power
			{
				// TODO [FB_BuildABrawl_Tools_ench] Build-A-Brawl Innkeeper Enchant && Test: Build-A-Brawl Innkeeper Enchant_FB_BuildABrawl_Tools_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_BuildABrawl_Tools_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_AT_045eee] Aviana's Blessing (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("FB_Champs_AT_045eee", new CardDef(new Power
			{
				// TODO [FB_Champs_AT_045eee] Aviana's Blessing && Test: Aviana's Blessing_FB_Champs_AT_045eee
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Champs_AT_045eee")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_CFM_020e] Raza Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your <b>Hero Power</b> costs (0).
			// --------------------------------------------------------
			cards.Add("FB_Champs_CFM_020e", new CardDef(new Power
			{
				// TODO [FB_Champs_CFM_020e] Raza Enchant && Test: Raza Enchant_FB_Champs_CFM_020e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Champs_CFM_020e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_FP1_028e] Darkness Calls (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("FB_Champs_FP1_028e", new CardDef(new Power
			{
				// TODO [FB_Champs_FP1_028e] Darkness Calls && Test: Darkness Calls_FB_Champs_FP1_028e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Champs_FP1_028e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_SetEvent] Set Mission Event (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("FB_Champs_SetEvent", new CardDef(new Power
			{
				// TODO [FB_Champs_SetEvent] Set Mission Event && Test: Set Mission Event_FB_Champs_SetEvent
				InfoCardId = "FB_Champs_SetEvent_copy",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Champs_SetEvent")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_SetEvent_copy] Add FSG Score Screen (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Champs_SetEvent_copy", new CardDef(new Power
			{
				// TODO [FB_Champs_SetEvent_copy] Add FSG Score Screen && Test: Add FSG Score Screen_FB_Champs_SetEvent_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Champs_SetEvent_copy")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_SetEventMulligan] Set Mission Event at game start (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Champs_SetEventMulligan", new CardDef(new Power
			{
				// TODO [FB_Champs_SetEventMulligan] Set Mission Event at game start && Test: Set Mission Event at game start_FB_Champs_SetEventMulligan
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Champs_SetEventMulligan")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_SetUp_Ench] Champs Setup (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Champs_SetUp_Ench", new CardDef(new Power
			{
				// TODO [FB_Champs_SetUp_Ench] Champs Setup && Test: Champs Setup_FB_Champs_SetUp_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Champs_SetUp_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_UNG_067t1e] Crystallized (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your minions are 5/5.
			// --------------------------------------------------------
			// GameTag:
			// - 758 = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_UNG_067t1e", new CardDef(new Power
			{
				// TODO [FB_Champs_UNG_067t1e] Crystallized && Test: Crystallized_FB_Champs_UNG_067t1e
				InfoCardId = "FB_Champs_UNG_067t1e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Champs_UNG_067t1e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_UNG_067t1e2] Crystallized (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: 5/5.
			// --------------------------------------------------------
			// GameTag:
			// - 758 = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_UNG_067t1e2", new CardDef(new Power
			{
				// TODO [FB_Champs_UNG_067t1e2] Crystallized && Test: Crystallized_FB_Champs_UNG_067t1e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Champs_UNG_067t1e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Duelers_Discover] Discover Card (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Duelers_Discover", new CardDef(new Power
			{
				// TODO [FB_Duelers_Discover] Discover Card && Test: Discover Card_FB_Duelers_Discover
				InfoCardId = "FB_Duelers_Discover1",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Duelers_Discover")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Duelers_Discover1] Discover Card 1 (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Duelers_Discover1", new CardDef(new Power
			{
				// TODO [FB_Duelers_Discover1] Discover Card 1 && Test: Discover Card 1_FB_Duelers_Discover1
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Duelers_Discover1")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Duelers_Discover2] Discover Card 2 (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Duelers_Discover2", new CardDef(new Power
			{
				// TODO [FB_Duelers_Discover2] Discover Card 2 && Test: Discover Card 2_FB_Duelers_Discover2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Duelers_Discover2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Duelers_Discover3] Discover Card 3 (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Duelers_Discover3", new CardDef(new Power
			{
				// TODO [FB_Duelers_Discover3] Discover Card 3 && Test: Discover Card 3_FB_Duelers_Discover3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Duelers_Discover3")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Duelers_Discover4] Discover Card 4 (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Duelers_Discover4", new CardDef(new Power
			{
				// TODO [FB_Duelers_Discover4] Discover Card 4 && Test: Discover Card 4_FB_Duelers_Discover4
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Duelers_Discover4")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Duelers_Discover5] Discover Card 5 (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Duelers_Discover5", new CardDef(new Power
			{
				// TODO [FB_Duelers_Discover5] Discover Card 5 && Test: Discover Card 5_FB_Duelers_Discover5
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Duelers_Discover5")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Duelers_Drawn] Already Drawn (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Duelers_Drawn", new CardDef(new Power
			{
				// TODO [FB_Duelers_Drawn] Already Drawn && Test: Already Drawn_FB_Duelers_Drawn
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Duelers_Drawn")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Duelers_SuddenDeath] Sudden Death Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Duelers_SuddenDeath", new CardDef(new Power
			{
				// TODO [FB_Duelers_SuddenDeath] Sudden Death Ench && Test: Sudden Death Ench_FB_Duelers_SuddenDeath
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Duelers_SuddenDeath")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO001] Innkeeper Tools - ELO (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset the brawl or play as normal
			// --------------------------------------------------------
			// Entourage: FB_ELO001a, FB_ELO001b
			// --------------------------------------------------------
			cards.Add("FB_ELO001", new CardDef(new[] {"FB_ELO001a","FB_ELO001b"}, new Power
			{
				// TODO [FB_ELO001] Innkeeper Tools - ELO && Test: Innkeeper Tools - ELO_FB_ELO001
				InfoCardId = "FB_ELO001bench",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_ELO001")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO001bench] ELO Reset Confirmation (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: FB_ELO001c, FB_ELO001d
			// --------------------------------------------------------
			cards.Add("FB_ELO001bench", new CardDef(new[] {"FB_ELO001c","FB_ELO001d"}, new Power
			{
				// TODO [FB_ELO001bench] ELO Reset Confirmation && Test: ELO Reset Confirmation_FB_ELO001bench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_ELO001bench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002] Competitive Spirits (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Gain an advantage against your opponent.
			// --------------------------------------------------------
			// Entourage: FB_ELO002a, FB_ELO002b, FB_ELO002c
			// --------------------------------------------------------
			cards.Add("FB_ELO002", new CardDef(new[] {"FB_ELO002a","FB_ELO002b","FB_ELO002c"}, new Power
			{
				// TODO [FB_ELO002] Competitive Spirits && Test: Competitive Spirits_FB_ELO002
				InfoCardId = "FB_ELO002_copy",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_ELO002")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002_copy] Greater Competitive Spirits (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Gain an advantage against your opponent.
			// --------------------------------------------------------
			// Entourage: FB_ELO002a_copy, FB_ELO002b_copy, FB_ELO002c_copy
			// --------------------------------------------------------
			cards.Add("FB_ELO002_copy", new CardDef(new[] {"FB_ELO002a_copy","FB_ELO002b_copy","FB_ELO002c_copy"}, new Power
			{
				// TODO [FB_ELO002_copy] Greater Competitive Spirits && Test: Greater Competitive Spirits_FB_ELO002_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_ELO002_copy")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002a_ench] Spirit of Heroism (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the cost of your Hero Power by (1).
			// --------------------------------------------------------
			cards.Add("FB_ELO002a_ench", new CardDef(new Power
			{
				// TODO [FB_ELO002a_ench] Spirit of Heroism && Test: Spirit of Heroism_FB_ELO002a_ench
				InfoCardId = "FB_ELO002a_ench_copy",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_ELO002a_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002a_ench_copy] Greater Spirit of Heroism (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Replace your starting Hero Power with a better one. It costs (0)
			// --------------------------------------------------------
			cards.Add("FB_ELO002a_ench_copy", new CardDef(new Power
			{
				// TODO [FB_ELO002a_ench_copy] Greater Spirit of Heroism && Test: Greater Spirit of Heroism_FB_ELO002a_ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_ELO002a_ench_copy")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002b_ench] Spirit of Wisdom (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the Cost of all spells in your deck and hand by (1).
			// --------------------------------------------------------
			cards.Add("FB_ELO002b_ench", new CardDef(new Power
			{
				// TODO [FB_ELO002b_ench] Spirit of Wisdom && Test: Spirit of Wisdom_FB_ELO002b_ench
				InfoCardId = "FB_ELO002b_ench_copy",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_ELO002b_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002b_ench_copy] Greater Spirit of Wisdom (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the Cost of all spells in your deck and hand by (2).
			// --------------------------------------------------------
			cards.Add("FB_ELO002b_ench_copy", new CardDef(new Power
			{
				// TODO [FB_ELO002b_ench_copy] Greater Spirit of Wisdom && Test: Greater Spirit of Wisdom_FB_ELO002b_ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_ELO002b_ench_copy")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002c_ench] Spirit of Strength (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give all minions in your deck and hand +1 Attack.
			// --------------------------------------------------------
			cards.Add("FB_ELO002c_ench", new CardDef(new Power
			{
				// TODO [FB_ELO002c_ench] Spirit of Strength && Test: Spirit of Strength_FB_ELO002c_ench
				InfoCardId = "FB_ELO002c_ench_copy",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_ELO002c_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002c_ench_copy] Greater Spirit of Strength (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give all minions in your deck and hand +2 Attack.
			// --------------------------------------------------------
			cards.Add("FB_ELO002c_ench_copy", new CardDef(new Power
			{
				// TODO [FB_ELO002c_ench_copy] Greater Spirit of Strength && Test: Greater Spirit of Strength_FB_ELO002c_ench_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_ELO002c_ench_copy")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_IKC_AllStar_Setup_Ench] Innkeepers Choice All-Star Squad Setup (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_IKC_AllStar_Setup_Ench", new CardDef(new Power
			{
				// TODO [FB_IKC_AllStar_Setup_Ench] Innkeepers Choice All-Star Squad Setup && Test: Innkeepers Choice All-Star Squad Setup_FB_IKC_AllStar_Setup_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_IKC_AllStar_Setup_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_IKC_KeepOld_Ench] Innkeepers Choice Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_IKC_KeepOld_Ench", new CardDef(new Power
			{
				// TODO [FB_IKC_KeepOld_Ench] Innkeepers Choice Enchant && Test: Innkeepers Choice Enchant_FB_IKC_KeepOld_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_IKC_KeepOld_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_IKC_KeepSetUp_Ench] Innkeepers Choice Setup (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_IKC_KeepSetUp_Ench", new CardDef(new Power
			{
				// TODO [FB_IKC_KeepSetUp_Ench] Innkeepers Choice Setup && Test: Innkeepers Choice Setup_FB_IKC_KeepSetUp_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_IKC_KeepSetUp_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LK003] Check for Hero Death in Lich King Raid (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_LK003", new CardDef(new Power
			{
				// TODO [FB_LK003] Check for Hero Death in Lich King Raid && Test: Check for Hero Death in Lich King Raid_FB_LK003
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK003")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LK009] Swap Hero With Death Knight (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_LK009", new CardDef(new Power
			{
				// TODO [FB_LK009] Swap Hero With Death Knight && Test: Swap Hero With Death Knight_FB_LK009
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK009")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LK_GetClass_copy] Discover Next Class Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: FB_LK_Warrior_copy, FB_LK_Druid_copy, FB_LK_Hunter_copy, FB_LK_Mage_copy, FB_LK_Paladin_copy, FB_LK_Priest_copy, FB_LK_Rogue_copy, FB_LK_Shaman_copy, FB_LK_Warlock_copy
			// --------------------------------------------------------
			cards.Add("FB_LK_GetClass_copy", new CardDef(new[] {"FB_LK_Warrior_copy","FB_LK_Druid_copy","FB_LK_Hunter_copy","FB_LK_Mage_copy","FB_LK_Paladin_copy","FB_LK_Priest_copy","FB_LK_Rogue_copy","FB_LK_Shaman_copy","FB_LK_Warlock_copy"}, new Power
			{
				// TODO [FB_LK_GetClass_copy] Discover Next Class Copy && Test: Discover Next Class Copy_FB_LK_GetClass_copy
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK_GetClass_copy")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LK_WaitForDiscover] Wait for Discover (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_LK_WaitForDiscover", new CardDef(new Power
			{
				// TODO [FB_LK_WaitForDiscover] Wait for Discover && Test: Wait for Discover_FB_LK_WaitForDiscover
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LK_WaitForDiscover")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LKStats001] Innkeeper Tools (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Fight the Lich King or make modifications to his health.
			// --------------------------------------------------------
			// Entourage: FB_LKStats001a, FB_LKStats002
			// --------------------------------------------------------
			cards.Add("FB_LKStats001", new CardDef(new[] {"FB_LKStats001a","FB_LKStats002"}, new Power
			{
				// TODO [FB_LKStats001] Innkeeper Tools && Test: Innkeeper Tools_FB_LKStats001
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LKStats001")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LKStats002ench] Lich King Modifications Copy (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
			// --------------------------------------------------------
			cards.Add("FB_LKStats002ench", new CardDef(new[] {"FB_LKStats002a","FB_LKStats002b","FB_LKStats002c"}, new Power
			{
				// TODO [FB_LKStats002ench] Lich King Modifications Copy && Test: Lich King Modifications Copy_FB_LKStats002ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_LKStats002ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_RagRaid_InnkeeperTools] RagRaid Innkeeper Tools for Reset - NOT PLAYER FACING (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset Rag if he's dead
			// --------------------------------------------------------
			// Entourage: FB_RagRaid_InnkeeperReset, FB_RagRaid_ResetCancel
			// --------------------------------------------------------
			cards.Add("FB_RagRaid_InnkeeperTools", new CardDef(new[] {"FB_RagRaid_InnkeeperReset","FB_RagRaid_ResetCancel"}, new Power
			{
				// TODO [FB_RagRaid_InnkeeperTools] RagRaid Innkeeper Tools for Reset - NOT PLAYER FACING && Test: RagRaid Innkeeper Tools for Reset - NOT PLAYER FACING_FB_RagRaid_InnkeeperTools
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_RagRaid_InnkeeperTools")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Reload_SavedCard] Saved Card (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Reload_SavedCard", new CardDef(new Power
			{
				// TODO [FB_Reload_SavedCard] Saved Card && Test: Saved Card_FB_Reload_SavedCard
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Reload_SavedCard")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_SPT_AnnoyO_Ench] More Annoying (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased Stats.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_SPT_AnnoyO_Ench", new CardDef(new Power
			{
				// TODO [FB_SPT_AnnoyO_Ench] More Annoying && Test: More Annoying_FB_SPT_AnnoyO_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_SPT_AnnoyO_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_TagTeam_WaitForDiscover] Wait for Discover (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_WaitForDiscover", new CardDef(new Power
			{
				// TODO [FB_TagTeam_WaitForDiscover] Wait for Discover && Test: Wait for Discover_FB_TagTeam_WaitForDiscover
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_TagTeam_WaitForDiscover")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Toki_BadMinion] Minion of the Enemy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: This minion belongs to the enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_BadMinion", new CardDef(new Power
			{
				// TODO [FB_Toki_BadMinion] Minion of the Enemy && Test: Minion of the Enemy_FB_Toki_BadMinion
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Toki_BadMinion")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Toki_IncreaseHealthEnch] Augmented Reality (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Attack increased.
			// --------------------------------------------------------
			cards.Add("FB_Toki_IncreaseHealthEnch", new CardDef(new Power
			{
				// TODO [FB_Toki_IncreaseHealthEnch] Augmented Reality && Test: Augmented Reality_FB_Toki_IncreaseHealthEnch
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Toki_IncreaseHealthEnch")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Toki_ReverseTurnEnch] Deferred (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_ReverseTurnEnch", new CardDef(new Power
			{
				// TODO [FB_Toki_ReverseTurnEnch] Deferred && Test: Deferred_FB_Toki_ReverseTurnEnch
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_Toki_ReverseTurnEnch")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_TopX_Ban] Ban Opponent's Card (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_TopX_Ban", new CardDef(new Power
			{
				// TODO [FB_TopX_Ban] Ban Opponent's Card && Test: Ban Opponent's Card_FB_TopX_Ban
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("FB_TopX_Ban")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [HRW02_1e] Overclock (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("HRW02_1e", new CardDef(new Power
			{
				// TODO [HRW02_1e] Overclock && Test: Overclock_HRW02_1e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("HRW02_1e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_13_19e] Saddened (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Can't attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_19e", new CardDef(new Power
			{
				// TODO [KARA_13_19e] Saddened && Test: Saddened_KARA_13_19e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_13_19e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_001] Boss HP Swapper (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: BRMA14_10, BRMA14_10H, BRMA09_4, BRMA09_4H, BRMA17_5, BRMA17_5H, NAX15_04, NAX15_04H, NAX12_02, NAX12_02H, BRM_027p, BRM_027pH, BRMA09_5, BRMA09_5H, BRMA16_2, BRMA16_2H, NAX5_02, NAX5_02H, BRMA11_2, BRMA11_2H, BRMA17_8, BRMA17_8H, NAX15_02, NAX15_02H, NAX14_02, NAX8_02, NAX8_02H, NAX10_03, NAX10_03H, BRMA05_2, BRMA05_2H, BRMA02_2, BRMA02_2H, BRMA04_2, BRMA07_2, BRMA07_2H, NAX6_02, NAX6_02H, BRMA09_2, BRMA09_2H, BRMA01_2, BRMA01_2H, NAX11_02, NAX11_02H, NAX13_02, NAX2_03, NAX2_03H, NAX1_04, NAX1h_04, BRMA06_2, BRMA06_2H, BRMA10_3, BRMA10_3H, NAX7_03, NAX7_03H, NAX9_06, NAX3_02, NAX3_02H, BRMA13_4, BRMA13_4H
			// --------------------------------------------------------
			cards.Add("TB_001", new CardDef(new[] {"BRMA14_10","BRMA14_10H","BRMA09_4","BRMA09_4H","BRMA17_5","BRMA17_5H","NAX15_04","NAX15_04H","NAX12_02","NAX12_02H","BRM_027p","BRM_027pH","BRMA09_5","BRMA09_5H","BRMA16_2","BRMA16_2H","NAX5_02","NAX5_02H","BRMA11_2","BRMA11_2H","BRMA17_8","BRMA17_8H","NAX15_02","NAX15_02H","NAX14_02","NAX8_02","NAX8_02H","NAX10_03","NAX10_03H","BRMA05_2","BRMA05_2H","BRMA02_2","BRMA02_2H","BRMA04_2","BRMA07_2","BRMA07_2H","NAX6_02","NAX6_02H","BRMA09_2","BRMA09_2H","BRMA01_2","BRMA01_2H","NAX11_02","NAX11_02H","NAX13_02","NAX2_03","NAX2_03H","NAX1_04","NAX1h_04","BRMA06_2","BRMA06_2H","BRMA10_3","BRMA10_3H","NAX7_03","NAX7_03H","NAX9_06","NAX3_02","NAX3_02H","BRMA13_4","BRMA13_4H"}, new Power
			{
				// TODO [TB_001] Boss HP Swapper && Test: Boss HP Swapper_TB_001
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_001")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_006e] Big Banana (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Has +2/+2.
			// --------------------------------------------------------
			cards.Add("TB_006e", new CardDef(new Power
			{
				// TODO [TB_006e] Big Banana && Test: Big Banana_TB_006e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_006e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_007e] Deviate Switch (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Deviate Banana.
			// --------------------------------------------------------
			cards.Add("TB_007e", new CardDef(new Power
			{
				// TODO [TB_007e] Deviate Switch && Test: Deviate Switch_TB_007e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_007e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_009] Create 15 Secrets (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: FP1_020, EX1_287, FP1_018, EX1_610, EX1_132, EX1_611, EX1_289, EX1_295, EX1_294, EX1_533, EX1_130, EX1_136, EX1_379, EX1_554, EX1_609, tt_010, EX1_594
			// --------------------------------------------------------
			cards.Add("TB_009", new CardDef(new[] {"FP1_020","EX1_287","FP1_018","EX1_610","EX1_132","EX1_611","EX1_289","EX1_295","EX1_294","EX1_533","EX1_130","EX1_136","EX1_379","EX1_554","EX1_609","tt_010","EX1_594"}, new Power
			{
				// TODO [TB_009] Create 15 Secrets && Test: Create 15 Secrets_TB_009
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_009")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_010] Deckbuilding Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_010", new CardDef(new Power
			{
				// TODO [TB_010] Deckbuilding Enchant && Test: Deckbuilding Enchant_TB_010
				InfoCardId = "TB_010e",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_010")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_010e] Choose One of Three (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_010e", new CardDef(new Power
			{
				// TODO [TB_010e] Choose One of Three && Test: Choose One of Three_TB_010e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_010e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_013] Player Choice Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_013", new CardDef(new Power
			{
				// TODO [TB_013] Player Choice Enchant && Test: Player Choice Enchant_TB_013
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_013")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_100th_001] Valeera's Bag Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Playing a spell summons a minion of that type.
			// --------------------------------------------------------
			cards.Add("TB_100th_001", new CardDef(new Power
			{
				// TODO [TB_100th_001] Valeera's Bag Enchant && Test: Valeera's Bag Enchant_TB_100th_001
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_100th_001")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_100th_BananaPlayerEnchant] Bananas on Death (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Spawn Banana
			// --------------------------------------------------------
			cards.Add("TB_100th_BananaPlayerEnchant", new CardDef(new Power
			{
				// TODO [TB_100th_BananaPlayerEnchant] Bananas on Death && Test: Bananas on Death_TB_100th_BananaPlayerEnchant
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_100th_BananaPlayerEnchant")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_207MaskedBallE] TB207 Masked Ball e (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_207MaskedBallE", new CardDef(new Power
			{
				// TODO [TB_207MaskedBallE] TB207 Masked Ball e && Test: TB207 Masked Ball e_TB_207MaskedBallE
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_207MaskedBallE")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_207TolBaradE] TB207 Minions Make Spells e (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_207TolBaradE", new CardDef(new Power
			{
				// TODO [TB_207TolBaradE] TB207 Minions Make Spells e && Test: TB207 Minions Make Spells e_TB_207TolBaradE
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_207TolBaradE")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_AllMinionsTauntCharge] Give Taunt and Charge (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: This minion is granted <b>Taunt</b> and <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("TB_AllMinionsTauntCharge", new CardDef(new Power
			{
				// TODO [TB_AllMinionsTauntCharge] Give Taunt and Charge && Test: Give Taunt and Charge_TB_AllMinionsTauntCharge
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_AllMinionsTauntCharge")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Amalgam_Ench] Amalgam Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Minions have all races.
			// --------------------------------------------------------
			// GameTag:
			// - 1137 = 1
			// --------------------------------------------------------
			cards.Add("TB_Amalgam_Ench", new CardDef(new Power
			{
				// TODO [TB_Amalgam_Ench] Amalgam Enchant && Test: Amalgam Enchant_TB_Amalgam_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Amalgam_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_ArchivistEnch] Archivist Enchant - Not Player Facing (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_ArchivistEnch", new CardDef(new Power
			{
				// TODO [TB_ArchivistEnch] Archivist Enchant - Not Player Facing && Test: Archivist Enchant - Not Player Facing_TB_ArchivistEnch
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_ArchivistEnch")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_BlingBrawl_Blade1e] Blingtron's Blade (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: When this breaks, randomly summon a new weapon.
			// --------------------------------------------------------
			cards.Add("TB_BlingBrawl_Blade1e", new CardDef(new Power
			{
				// TODO [TB_BlingBrawl_Blade1e] Blingtron's Blade && Test: Blingtron's Blade_TB_BlingBrawl_Blade1e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_BlingBrawl_Blade1e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_BlingBrawl_Blade2e] Blingtron's Blade HERO (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_BlingBrawl_Blade2e", new CardDef(new Power
			{
				// TODO [TB_BlingBrawl_Blade2e] Blingtron's Blade HERO && Test: Blingtron's Blade HERO_TB_BlingBrawl_Blade2e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_BlingBrawl_Blade2e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Blizzcon2016_GoonsEnchant] The Grimy Goons (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Blizzcon2016_GoonsEnchant", new CardDef(new Power
			{
				// TODO [TB_Blizzcon2016_GoonsEnchant] The Grimy Goons && Test: The Grimy Goons_TB_Blizzcon2016_GoonsEnchant
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Blizzcon2016_GoonsEnchant")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Blizzcon2016_KabalEnchant] The Kabal (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Blizzcon2016_KabalEnchant", new CardDef(new Power
			{
				// TODO [TB_Blizzcon2016_KabalEnchant] The Kabal && Test: The Kabal_TB_Blizzcon2016_KabalEnchant
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Blizzcon2016_KabalEnchant")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Blizzcon2016_LotusEnchant] The Jade Lotus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Blizzcon2016_LotusEnchant", new CardDef(new Power
			{
				// TODO [TB_Blizzcon2016_LotusEnchant] The Jade Lotus && Test: The Jade Lotus_TB_Blizzcon2016_LotusEnchant
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Blizzcon2016_LotusEnchant")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_BoomAnnoy_001e] Loves Annoy-o-tron (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("TB_BoomAnnoy_001e", new CardDef(new Power
			{
				// TODO [TB_BoomAnnoy_001e] Loves Annoy-o-tron && Test: Loves Annoy-o-tron_TB_BoomAnnoy_001e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_BoomAnnoy_001e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_BoomBotFestival_001e] Boom Bot Attached (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 1-4 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("TB_BoomBotFestival_001e", new CardDef(new Power
			{
				// TODO [TB_BoomBotFestival_001e] Boom Bot Attached && Test: Boom Bot Attached_TB_BoomBotFestival_001e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_BoomBotFestival_001e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Carousel_EnchA] Carousel Enchant A - Not Player Facing (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Rotate Minions
			// --------------------------------------------------------
			cards.Add("TB_Carousel_EnchA", new CardDef(new Power
			{
				// TODO [TB_Carousel_EnchA] Carousel Enchant A - Not Player Facing && Test: Carousel Enchant A - Not Player Facing_TB_Carousel_EnchA
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Carousel_EnchA")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Carousel_EnchB] Carousel Enchant B - Not Player Facing (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Rotate Minions
			// --------------------------------------------------------
			cards.Add("TB_Carousel_EnchB", new CardDef(new Power
			{
				// TODO [TB_Carousel_EnchB] Carousel Enchant B - Not Player Facing && Test: Carousel Enchant B - Not Player Facing_TB_Carousel_EnchB
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Carousel_EnchB")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Champs_KeepWinnerDeck_Choice] Innkeeper Tools - Reset Session (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset the brawl or play as normal
			// --------------------------------------------------------
			// Entourage: FB_ELO001a, FB_ELO001b
			// --------------------------------------------------------
			cards.Add("TB_Champs_KeepWinnerDeck_Choice", new CardDef(new[] {"FB_ELO001a","FB_ELO001b"}, new Power
			{
				// TODO [TB_Champs_KeepWinnerDeck_Choice] Innkeeper Tools - Reset Session && Test: Innkeeper Tools - Reset Session_TB_Champs_KeepWinnerDeck_Choice
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Champs_KeepWinnerDeck_Choice")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Champs_KeepWinnerDeck_IK] Reset Champs Decks (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: As the Innkeeper, you can reset your Fireside Brawl's decks.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_Champs_KeepWinnerDeck_IK", new CardDef(new Power
			{
				// TODO [TB_Champs_KeepWinnerDeck_IK] Reset Champs Decks && Test: Reset Champs Decks_TB_Champs_KeepWinnerDeck_IK
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Champs_KeepWinnerDeck_IK")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Chupacabran_HP_E] Bloodthirsty (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased stats and <b>Lifesteal.</b>
			// --------------------------------------------------------
			cards.Add("TB_Chupacabran_HP_E", new CardDef(new Power
			{
				// TODO [TB_Chupacabran_HP_E] Bloodthirsty && Test: Bloodthirsty_TB_Chupacabran_HP_E
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Chupacabran_HP_E")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_ClassRandom_Pick2nd_100th] Pick your second class (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_ClassRandom_Warrior, TB_ClassRandom_Warlock, TB_ClassRandom_Shaman, TB_ClassRandom_Rogue, TB_ClassRandom_Priest, TB_ClassRandom_Paladin, TB_ClassRandom_Mage, TB_ClassRandom_Hunter, TB_ClassRandom_Druid
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Pick2nd_100th", new CardDef(new[] {"TB_ClassRandom_Warrior","TB_ClassRandom_Warlock","TB_ClassRandom_Shaman","TB_ClassRandom_Rogue","TB_ClassRandom_Priest","TB_ClassRandom_Paladin","TB_ClassRandom_Mage","TB_ClassRandom_Hunter","TB_ClassRandom_Druid"}, new Power
			{
				// TODO [TB_ClassRandom_Pick2nd_100th] Pick your second class && Test: Pick your second class_TB_ClassRandom_Pick2nd_100th
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_ClassRandom_Pick2nd_100th")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_ClassRandom_PickSecondClass] Pick your second class (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_ClassRandom_Warrior, TB_ClassRandom_Warlock, TB_ClassRandom_Shaman, TB_ClassRandom_Rogue, TB_ClassRandom_Priest, TB_ClassRandom_Paladin, TB_ClassRandom_Mage, TB_ClassRandom_Hunter, TB_ClassRandom_Druid
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_PickSecondClass", new CardDef(new[] {"TB_ClassRandom_Warrior","TB_ClassRandom_Warlock","TB_ClassRandom_Shaman","TB_ClassRandom_Rogue","TB_ClassRandom_Priest","TB_ClassRandom_Paladin","TB_ClassRandom_Mage","TB_ClassRandom_Hunter","TB_ClassRandom_Druid"}, new Power
			{
				// TODO [TB_ClassRandom_PickSecondClass] Pick your second class && Test: Pick your second class_TB_ClassRandom_PickSecondClass
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_ClassRandom_PickSecondClass")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_009e] Going Nova (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: It's about to blow!
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_009e", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_009e] Going Nova && Test: Going Nova_TB_CoOpv3_009e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_CoOpv3_009e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_101e] Team Player Enchantment (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Immune</b> ahile attacking
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_101e", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_101e] Team Player Enchantment && Test: Team Player Enchantment_TB_CoOpv3_101e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_CoOpv3_101e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_104e] Unity (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +2/+2
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_104e", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_104e] Unity && Test: Unity_TB_CoOpv3_104e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_CoOpv3_104e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_BOSS2e] Getting Angry.... (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Now he's mad....
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_BOSS2e", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_BOSS2e] Getting Angry.... && Test: Getting Angry...._TB_CoOpv3_BOSS2e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_CoOpv3_BOSS2e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_BOSS3e] Enough! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Nefarian is <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_BOSS3e", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_BOSS3e] Enough! && Test: Enough!_TB_CoOpv3_BOSS3e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_CoOpv3_BOSS3e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_BOSS4e] Cowed (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Can't attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_BOSS4e", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_BOSS4e] Cowed && Test: Cowed_TB_CoOpv3_BOSS4e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_CoOpv3_BOSS4e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_BOSSe] WHY WON'T YOU DIE!? (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Now he's REALLY mad....
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_BOSSe", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_BOSSe] WHY WON'T YOU DIE!? && Test: WHY WON'T YOU DIE!?_TB_CoOpv3_BOSSe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_CoOpv3_BOSSe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_DeathrattleYog_Copied] Deathrattle Roll (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Copied Deathrattle from {0}.
			// --------------------------------------------------------
			cards.Add("TB_DeathrattleYog_Copied", new CardDef(new Power
			{
				// TODO [TB_DeathrattleYog_Copied] Deathrattle Roll && Test: Deathrattle Roll_TB_DeathrattleYog_Copied
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_DeathrattleYog_Copied")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_DeathrattleYog_ench] Deathrattle Yog Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_DeathrattleYog_ench", new CardDef(new Power
			{
				// TODO [TB_DeathrattleYog_ench] Deathrattle Yog Enchant && Test: Deathrattle Yog Enchant_TB_DeathrattleYog_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_DeathrattleYog_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_DeckRecipe_MyDeckID] My Deck ID (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_DeckRecipe_MyDeckID", new CardDef(new Power
			{
				// TODO [TB_DeckRecipe_MyDeckID] My Deck ID && Test: My Deck ID_TB_DeckRecipe_MyDeckID
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_DeckRecipe_MyDeckID")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_DiscoverMyDeck_Enchantment] Discover My Deck Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_DiscoverMyDeck_Enchantment", new CardDef(new Power
			{
				// TODO [TB_DiscoverMyDeck_Enchantment] Discover My Deck Enchant && Test: Discover My Deck Enchant_TB_DiscoverMyDeck_Enchantment
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_DiscoverMyDeck_Enchantment")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_DoubleMinions_ench] Double Minions Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_DoubleMinions_ench", new CardDef(new Power
			{
				// TODO [TB_DoubleMinions_ench] Double Minions Enchant && Test: Double Minions Enchant_TB_DoubleMinions_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_DoubleMinions_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_DrawnDiscovery_Ench] Draw and Discover Ench (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_Henchmania_DiscoverA, TB_Henchmania_DiscoverB, TB_Henchmania_DiscoverC, TB_Henchmania_DiscoverD
			// --------------------------------------------------------
			cards.Add("TB_DrawnDiscovery_Ench", new CardDef(new[] {"TB_Henchmania_DiscoverA","TB_Henchmania_DiscoverB","TB_Henchmania_DiscoverC","TB_Henchmania_DiscoverD"}, new Power
			{
				// TODO [TB_DrawnDiscovery_Ench] Draw and Discover Ench && Test: Draw and Discover Ench_TB_DrawnDiscovery_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_DrawnDiscovery_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_EndlessMinions01] Endless Enchantment (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("TB_EndlessMinions01", new CardDef(new Power
			{
				// TODO [TB_EndlessMinions01] Endless Enchantment && Test: Endless Enchantment_TB_EndlessMinions01
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_EndlessMinions01")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Face_Ench1] Safe (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: This minion is safe from attacks and cannot have taunt.
			// --------------------------------------------------------
			cards.Add("TB_Face_Ench1", new CardDef(new Power
			{
				// TODO [TB_Face_Ench1] Safe && Test: Safe_TB_Face_Ench1
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Face_Ench1")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Firefest2_003e] Firey (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("TB_Firefest2_003e", new CardDef(new Power
			{
				// TODO [TB_Firefest2_003e] Firey && Test: Firey_TB_Firefest2_003e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Firefest2_003e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Firefest2_005e] Frostbitten (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +4 Health.
			// --------------------------------------------------------
			cards.Add("TB_Firefest2_005e", new CardDef(new Power
			{
				// TODO [TB_Firefest2_005e] Frostbitten && Test: Frostbitten_TB_Firefest2_005e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Firefest2_005e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FireFestEnch] Conflagrate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Gains Attack for each minion killed.
			// --------------------------------------------------------
			cards.Add("TB_FireFestEnch", new CardDef(new Power
			{
				// TODO [TB_FireFestEnch] Conflagrate && Test: Conflagrate_TB_FireFestEnch
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_FireFestEnch")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessing1] Leech Blessing (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing1", new CardDef(new Power
			{
				// TODO [TB_FoxBlessing1] Leech Blessing && Test: Leech Blessing_TB_FoxBlessing1
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_FoxBlessing1")
			}));

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
			cards.Add("TB_FoxBlessing2", new CardDef(new Power
			{
				// TODO [TB_FoxBlessing2] Deadly Blessing && Test: Deadly Blessing_TB_FoxBlessing2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_FoxBlessing2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessing3] Swordmaster Blessing (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing3", new CardDef(new Power
			{
				// TODO [TB_FoxBlessing3] Swordmaster Blessing && Test: Swordmaster Blessing_TB_FoxBlessing3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_FoxBlessing3")
			}));

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
			cards.Add("TB_FoxBlessing4", new CardDef(new Power
			{
				// TODO [TB_FoxBlessing4] MEGA BLESSING! && Test: MEGA BLESSING!_TB_FoxBlessing4
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_FoxBlessing4")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessing5] Stealth Blessing (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing5", new CardDef(new Power
			{
				// TODO [TB_FoxBlessing5] Stealth Blessing && Test: Stealth Blessing_TB_FoxBlessing5
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_FoxBlessing5")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessing6] Charge Blessing (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing6", new CardDef(new Power
			{
				// TODO [TB_FoxBlessing6] Charge Blessing && Test: Charge Blessing_TB_FoxBlessing6
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_FoxBlessing6")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessingEnch] Fox Blessing Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessingEnch", new CardDef(new Power
			{
				// TODO [TB_FoxBlessingEnch] Fox Blessing Enchant && Test: Fox Blessing Enchant_TB_FoxBlessingEnch
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_FoxBlessingEnch")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FW_Warpere] Omegawarp (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			cards.Add("TB_FW_Warpere", new CardDef(new Power
			{
				// TODO [TB_FW_Warpere] Omegawarp && Test: Omegawarp_TB_FW_Warpere
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_FW_Warpere")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_GiftExchange_Enchantment] Cheap Gift (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: This card's cost is reduced.
			// --------------------------------------------------------
			cards.Add("TB_GiftExchange_Enchantment", new CardDef(new Power
			{
				// TODO [TB_GiftExchange_Enchantment] Cheap Gift && Test: Cheap Gift_TB_GiftExchange_Enchantment
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_GiftExchange_Enchantment")
			}));

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
			cards.Add("TB_GP_01e", new CardDef(new Power
			{
				// TODO [TB_GP_01e] Shadow Tower Power && Test: Shadow Tower Power_TB_GP_01e
				InfoCardId = "TB_GP_01e_copy1",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_GP_01e")
			}));

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
			cards.Add("TB_GP_01e_copy1", new CardDef(new Power
			{
				// TODO [TB_GP_01e_copy1] Shadow Tower Give My minions Stealth && Test: Shadow Tower Give My minions Stealth_TB_GP_01e_copy1
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_GP_01e_copy1")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_GP_01e_v2] Shadow Tower Stealth (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>.
			// --------------------------------------------------------
			cards.Add("TB_GP_01e_v2", new CardDef(new Power
			{
				// TODO [TB_GP_01e_v2] Shadow Tower Stealth && Test: Shadow Tower Stealth_TB_GP_01e_v2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_GP_01e_v2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_GreatCurves_01] TB_ClockworkCardDealer (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_GreatCurves_01", new CardDef(new Power
			{
				// TODO [TB_GreatCurves_01] TB_ClockworkCardDealer && Test: TB_ClockworkCardDealer_TB_GreatCurves_01
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_GreatCurves_01")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_HeadlessHorseman_005e] Yar. (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased Attack and Health
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_005e", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_005e] Yar. && Test: Yar._TB_HeadlessHorseman_005e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_HeadlessHorseman_005e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_HeadlessHorseman_GameEnch] Pick Costume (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_HeadlessHorseman_s001a, TB_HeadlessHorseman_s001c, TB_HeadlessHorseman_s001b, TB_HeadlessHorseman_s001d
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_GameEnch", new CardDef(new[] {"TB_HeadlessHorseman_s001a","TB_HeadlessHorseman_s001c","TB_HeadlessHorseman_s001b","TB_HeadlessHorseman_s001d"}, new Power
			{
				// TODO [TB_HeadlessHorseman_GameEnch] Pick Costume && Test: Pick Costume_TB_HeadlessHorseman_GameEnch
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_HeadlessHorseman_GameEnch")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_HeadlessHorseman_HP5e] Senses Weakness (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: +2 Attack
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_HP5e", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_HP5e] Senses Weakness && Test: Senses Weakness_TB_HeadlessHorseman_HP5e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_HeadlessHorseman_HP5e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Henchmania_Discover] Henchmania Discover (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_Henchmania_DiscoverA, TB_Henchmania_DiscoverB, TB_Henchmania_DiscoverC, TB_Henchmania_DiscoverD
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_Discover", new CardDef(new[] {"TB_Henchmania_DiscoverA","TB_Henchmania_DiscoverB","TB_Henchmania_DiscoverC","TB_Henchmania_DiscoverD"}, new Power
			{
				// TODO [TB_Henchmania_Discover] Henchmania Discover && Test: Henchmania Discover_TB_Henchmania_Discover
				InfoCardId = "TB_Henchmania_DiscoverAe",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Henchmania_Discover")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Henchmania_DiscoverAe] Work for Hagatha Enchantment (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn transform a random friendly minion into
			//       one that costs (1) more.
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_DiscoverAe", new CardDef(new Power
			{
				// TODO [TB_Henchmania_DiscoverAe] Work for Hagatha Enchantment && Test: Work for Hagatha Enchantment_TB_Henchmania_DiscoverAe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Henchmania_DiscoverAe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Henchmania_DiscoverBe] Work for Dr. Boom enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_DiscoverBe", new CardDef(new Power
			{
				// TODO [TB_Henchmania_DiscoverBe] Work for Dr. Boom enchant && Test: Work for Dr. Boom enchant_TB_Henchmania_DiscoverBe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Henchmania_DiscoverBe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Henchmania_DiscoverCe] Work for Togwaggle enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_DiscoverCe", new CardDef(new Power
			{
				// TODO [TB_Henchmania_DiscoverCe] Work for Togwaggle enchant && Test: Work for Togwaggle enchant_TB_Henchmania_DiscoverCe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Henchmania_DiscoverCe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Henchmania_DiscoverDe] Work for Madame Lazul enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_DiscoverDe", new CardDef(new Power
			{
				// TODO [TB_Henchmania_DiscoverDe] Work for Madame Lazul enchant && Test: Work for Madame Lazul enchant_TB_Henchmania_DiscoverDe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Henchmania_DiscoverDe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Henchmania_VOController] VO Controller - Not Player Facing (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_VOController", new CardDef(new Power
			{
				// TODO [TB_Henchmania_VOController] VO Controller - Not Player Facing && Test: VO Controller - Not Player Facing_TB_Henchmania_VOController
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Henchmania_VOController")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Ignoblegarden2e] Room Bot (*) - COST:0 
			// - Race: mechanical, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>. <b>Taunt</b>
			//       <b>Deathrattle:</b>Summon 3 1/1 Boom Bots.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("TB_Ignoblegarden2e", new CardDef(new Power
			{
				// TODO [TB_Ignoblegarden2e] Room Bot && Test: Room Bot_TB_Ignoblegarden2e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Ignoblegarden2e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_KaraPortal_003] Saddened Hero Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give can't attack this turn to enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TB_KaraPortal_003", new CardDef(new Power
			{
				// TODO [TB_KaraPortal_003] Saddened Hero Enchant && Test: Saddened Hero Enchant_TB_KaraPortal_003
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_KaraPortal_003")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_KeepWinnerDeck_Mirror] Mirror Match (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Flags if a player is playing against the same deck
			// --------------------------------------------------------
			cards.Add("TB_KeepWinnerDeck_Mirror", new CardDef(new Power
			{
				// TODO [TB_KeepWinnerDeck_Mirror] Mirror Match && Test: Mirror Match_TB_KeepWinnerDeck_Mirror
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_KeepWinnerDeck_Mirror")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_KoboldGiftEnch] Great Father Kobold Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_KoboldGiftEnch", new CardDef(new Power
			{
				// TODO [TB_KoboldGiftEnch] Great Father Kobold Enchant && Test: Great Father Kobold Enchant_TB_KoboldGiftEnch
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_KoboldGiftEnch")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_KTRAF_10e] Dark Power (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Granted power from Noth
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_10e", new CardDef(new Power
			{
				// TODO [TB_KTRAF_10e] Dark Power && Test: Dark Power_TB_KTRAF_10e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_KTRAF_10e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_LethalSetup02] Brawl Progress Saved (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Welcome back! Would you like to restart or continue?
			// --------------------------------------------------------
			// Entourage: TB_LethalSetup001a, TB_LethalSetup001b
			// --------------------------------------------------------
			cards.Add("TB_LethalSetup02", new CardDef(new[] {"TB_LethalSetup001a","TB_LethalSetup001b"}, new Power
			{
				// TODO [TB_LethalSetup02] Brawl Progress Saved && Test: Brawl Progress Saved_TB_LethalSetup02
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_LethalSetup02")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_MammothParty_s002ee] Raucous (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +2/+2
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s002ee", new CardDef(new Power
			{
				// TODO [TB_MammothParty_s002ee] Raucous && Test: Raucous_TB_MammothParty_s002ee
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_MammothParty_s002ee")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_MechWar_CommonCards] TBMechWarCommonCards (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: GVG_069, GVG_079, GVG_034, GVG_048, GVG_049, GVG_088
			// --------------------------------------------------------
			cards.Add("TB_MechWar_CommonCards", new CardDef(new[] {"GVG_069","GVG_079","GVG_034","GVG_048","GVG_049","GVG_088"}, new Power
			{
				// TODO [TB_MechWar_CommonCards] TBMechWarCommonCards && Test: TBMechWarCommonCards_TB_MechWar_CommonCards
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_MechWar_CommonCards")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Mini_1e] Miniature (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Mini-sized, set to 1/1
			// --------------------------------------------------------
			cards.Add("TB_Mini_1e", new CardDef(new Power
			{
				// TODO [TB_Mini_1e] Miniature && Test: Miniature_TB_Mini_1e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Mini_1e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Murlocs_Ench] Unite the Murlocs Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Murlocs_Ench", new CardDef(new Power
			{
				// TODO [TB_Murlocs_Ench] Unite the Murlocs Enchant && Test: Unite the Murlocs Enchant_TB_Murlocs_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Murlocs_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_NewBlinkFox] Blink Fox Enchant (*) - COST:0 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_NewBlinkFox", new CardDef(new Power
			{
				// TODO [TB_NewBlinkFox] Blink Fox Enchant && Test: Blink Fox Enchant_TB_NewBlinkFox
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_NewBlinkFox")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003e] Shifting (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Transforming into random dyes.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003e", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003e] Shifting && Test: Shifting_TB_Noblegarden_003e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t1e] Blue Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Windfury</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t1e", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t1e] Blue Egg && Test: Blue Egg_TB_Noblegarden_003t1e
				InfoCardId = "TB_Noblegarden_003t1e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t1e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t1e2] Blue Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t1e2", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t1e2] Blue Hatchling && Test: Blue Hatchling_TB_Noblegarden_003t1e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t1e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t2e] Purple Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Lifesteal</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t2e", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t2e] Purple Egg && Test: Purple Egg_TB_Noblegarden_003t2e
				InfoCardId = "TB_Noblegarden_003t2e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t2e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t2e2] Purple Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t2e2", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t2e2] Purple Hatchling && Test: Purple Hatchling_TB_Noblegarden_003t2e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t2e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t3e] Green Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Poisonous</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t3e", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t3e] Green Egg && Test: Green Egg_TB_Noblegarden_003t3e
				InfoCardId = "TB_Noblegarden_003t3e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t3e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t3e2] Green Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t3e2", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t3e2] Green Hatchling && Test: Green Hatchling_TB_Noblegarden_003t3e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t3e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t4e] Silver Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Stealth</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t4e", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t4e] Silver Egg && Test: Silver Egg_TB_Noblegarden_003t4e
				InfoCardId = "TB_Noblegarden_003t4e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t4e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t4e2] Silver Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t4e2", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t4e2] Silver Hatchling && Test: Silver Hatchling_TB_Noblegarden_003t4e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t4e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t5e] Orange Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t5e", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t5e] Orange Egg && Test: Orange Egg_TB_Noblegarden_003t5e
				InfoCardId = "TB_Noblegarden_003t5e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t5e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t5e2] Orange Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t5e2", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t5e2] Orange Hatchling && Test: Orange Hatchling_TB_Noblegarden_003t5e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t5e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t6e] Pink Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t6e", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t6e] Pink Egg && Test: Pink Egg_TB_Noblegarden_003t6e
				InfoCardId = "TB_Noblegarden_003t6e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t6e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t6e2] Pink Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t6e2", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t6e2] Pink Hatchling && Test: Pink Hatchling_TB_Noblegarden_003t6e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t6e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t7e] Gold Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Divine Shield</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t7e", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t7e] Gold Egg && Test: Gold Egg_TB_Noblegarden_003t7e
				InfoCardId = "TB_Noblegarden_003t7e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t7e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t7e2] Gold Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t7e2", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t7e2] Gold Hatchling && Test: Gold Hatchling_TB_Noblegarden_003t7e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t7e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t8e] Red Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has +2/+2.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t8e", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t8e] Red Egg && Test: Red Egg_TB_Noblegarden_003t8e
				InfoCardId = "TB_Noblegarden_003t8e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t8e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t8e2] Red Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +2/+2
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t8e2", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_003t8e2] Red Hatchling && Test: Red Hatchling_TB_Noblegarden_003t8e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_003t8e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_005e] Delicious Carrots (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased Attack and Health, moreso for Bunnies
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_005e", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_005e] Delicious Carrots && Test: Delicious Carrots_TB_Noblegarden_005e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Noblegarden_005e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate] Pick Your Fate Build Around (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_PickYourFate_9, TB_PickYourFate_10, TB_PickYourFate_11b, TB_PickYourFate_8
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate", new CardDef(new[] {"TB_PickYourFate_9","TB_PickYourFate_10","TB_PickYourFate_11b","TB_PickYourFate_8"}, new Power
			{
				// TODO [TB_PickYourFate] Pick Your Fate Build Around && Test: Pick Your Fate Build Around_TB_PickYourFate
				InfoCardId = "TB_PickYourFate7Ench",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate7Ench] Fate 7 Ench Get a Coin (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate7Ench", new CardDef(new Power
			{
				// TODO [TB_PickYourFate7Ench] Fate 7 Ench Get a Coin && Test: Fate 7 Ench Get a Coin_TB_PickYourFate7Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate7Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_10_Ench] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_10_Ench", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_10_Ench] Fate && Test: Fate_TB_PickYourFate_10_Ench
				InfoCardId = "TB_PickYourFate_10_EnchMinion",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_10_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_10_EnchMinion] Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your <b>Battlecry</b> minions have +1/+1.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_10_EnchMinion", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_10_EnchMinion] Bonus && Test: Bonus_TB_PickYourFate_10_EnchMinion
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_10_EnchMinion")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_11_Ench] Fate 11 Ench. Murloc (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_11_Ench", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_11_Ench] Fate 11 Ench. Murloc && Test: Fate 11 Ench. Murloc_TB_PickYourFate_11_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_11_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_12_Ench] Fate 12 Ench, Confuse (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_12_Ench", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_12_Ench] Fate 12 Ench, Confuse && Test: Fate 12 Ench, Confuse_TB_PickYourFate_12_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_12_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_1_Ench] Pick Your Fate 1 Ench (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_1_Ench", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_1_Ench] Pick Your Fate 1 Ench && Test: Pick Your Fate 1 Ench_TB_PickYourFate_1_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_1_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_2_Ench] Pick Your Fate 2 Ench (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_2_Ench", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_2_Ench] Pick Your Fate 2 Ench && Test: Pick Your Fate 2 Ench_TB_PickYourFate_2_Ench
				InfoCardId = "TB_PickYourFate_2_EnchMinion",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_2_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_2_EnchMinion] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Your owner gets a banana.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_2_EnchMinion", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_2_EnchMinion] Fate && Test: Fate_TB_PickYourFate_2_EnchMinion
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_2_EnchMinion")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_2nd] Pick Your Fate Randon 2nd (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_PickYourFate_1, TB_PickYourFate_4, TB_PickYourFate_7_2nd, TB_PickYourFate_3, TB_PickYourFate_6_2nd, TB_PickYourFate_11rand
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_2nd", new CardDef(new[] {"TB_PickYourFate_1","TB_PickYourFate_4","TB_PickYourFate_7_2nd","TB_PickYourFate_3","TB_PickYourFate_6_2nd","TB_PickYourFate_11rand"}, new Power
			{
				// TODO [TB_PickYourFate_2nd] Pick Your Fate Randon 2nd && Test: Pick Your Fate Randon 2nd_TB_PickYourFate_2nd
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_2nd")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_3_Ench] Pick Your Fate 3 Ench (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_3_Ench", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_3_Ench] Pick Your Fate 3 Ench && Test: Pick Your Fate 3 Ench_TB_PickYourFate_3_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_3_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_4_Ench] Pick Your Fate 4 Ench (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_4_Ench", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_4_Ench] Pick Your Fate 4 Ench && Test: Pick Your Fate 4 Ench_TB_PickYourFate_4_Ench
				InfoCardId = "TB_PickYourFate_4_EnchMinion",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_4_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_4_EnchMinion] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_4_EnchMinion", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_4_EnchMinion] Fate && Test: Fate_TB_PickYourFate_4_EnchMinion
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_4_EnchMinion")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_5_Ench] Pick Your Fate 5 Ench (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_5_Ench", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_5_Ench] Pick Your Fate 5 Ench && Test: Pick Your Fate 5 Ench_TB_PickYourFate_5_Ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_5_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_7_Ench_2nd] Fate 7 Ench 2nd (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_7_Ench_2nd", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_7_Ench_2nd] Fate 7 Ench 2nd && Test: Fate 7 Ench 2nd_TB_PickYourFate_7_Ench_2nd
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_7_Ench_2nd")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_7_EnchMiniom2nd] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> random card in owner's hand costs (0).
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_7_EnchMiniom2nd", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_7_EnchMiniom2nd] Fate && Test: Fate_TB_PickYourFate_7_EnchMiniom2nd
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_7_EnchMiniom2nd")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_7_EnchMinion] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Your owner gets a coin.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_7_EnchMinion", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_7_EnchMinion] Fate && Test: Fate_TB_PickYourFate_7_EnchMinion
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_7_EnchMinion")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_8_Ench] Fate 8 Get Armor (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_8_Ench", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_8_Ench] Fate 8 Get Armor && Test: Fate 8 Get Armor_TB_PickYourFate_8_Ench
				InfoCardId = "TB_PickYourFate_8_EnchRand",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_8_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_8_EnchRand] Fate 8 Rand 2 armor each turn (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_8_EnchRand", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_8_EnchRand] Fate 8 Rand 2 armor each turn && Test: Fate 8 Rand 2 armor each turn_TB_PickYourFate_8_EnchRand
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_8_EnchRand")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_9_Ench] Fate 9 Ench. Deathrattle bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_9_Ench", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_9_Ench] Fate 9 Ench. Deathrattle bonus && Test: Fate 9 Ench. Deathrattle bonus_TB_PickYourFate_9_Ench
				InfoCardId = "TB_PickYourFate_9_EnchMinion",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_9_Ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_9_EnchMinion] Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your <b>Deathrattle</b> minions have +1/+1.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_9_EnchMinion", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_9_EnchMinion] Bonus && Test: Bonus_TB_PickYourFate_9_EnchMinion
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_9_EnchMinion")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_Confused] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Attack and Health swap at end of each turn.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_Confused", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_Confused] Fate && Test: Fate_TB_PickYourFate_Confused
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_Confused")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_Windfury] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: This minion has <b>Windfury</b>
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_Windfury", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_Windfury] Fate && Test: Fate_TB_PickYourFate_Windfury
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFate_Windfury")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFateRandom] Pick Your Fate Random (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_PickYourFate_12, TB_PickYourFate_2, TB_PickYourFate_8rand, TB_PickYourFate_6, TB_PickYourFate_5, TB_PickYourFate_7
			// --------------------------------------------------------
			cards.Add("TB_PickYourFateRandom", new CardDef(new[] {"TB_PickYourFate_12","TB_PickYourFate_2","TB_PickYourFate_8rand","TB_PickYourFate_6","TB_PickYourFate_5","TB_PickYourFate_7"}, new Power
			{
				// TODO [TB_PickYourFateRandom] Pick Your Fate Random && Test: Pick Your Fate Random_TB_PickYourFateRandom
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_PickYourFateRandom")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Pilot1] Mystery Pilot (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Who could it be?!
			// --------------------------------------------------------
			cards.Add("TB_Pilot1", new CardDef(new Power
			{
				// TODO [TB_Pilot1] Mystery Pilot && Test: Mystery Pilot_TB_Pilot1
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Pilot1")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_RandCardCost] TBRandomCardCost (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_RandCardCost", new CardDef(new Power
			{
				// TODO [TB_RandCardCost] TBRandomCardCost && Test: TBRandomCardCost_TB_RandCardCost
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_RandCardCost")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_RandHero2_001] TB_EnchWhosTheBossNow (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: BRMA07_2_2_TB, BRMA01_2H_2_TB, BRMA17_5_TB, NAX12_02H_2_TB, BRMA02_2_2_TB, NAX11_02H_2_TB, BRMA13_4_2_TB, BRMA09_2_TB, BRMA14_10H_TB, BRMA06_2H_TB, NAX3_02_TB, NAX8_02H_TB
			// --------------------------------------------------------
			cards.Add("TB_RandHero2_001", new CardDef(new[] {"BRMA07_2_2_TB","BRMA01_2H_2_TB","BRMA17_5_TB","NAX12_02H_2_TB","BRMA02_2_2_TB","NAX11_02H_2_TB","BRMA13_4_2_TB","BRMA09_2_TB","BRMA14_10H_TB","BRMA06_2H_TB","NAX3_02_TB","NAX8_02H_TB"}, new Power
			{
				// TODO [TB_RandHero2_001] TB_EnchWhosTheBossNow && Test: TB_EnchWhosTheBossNow_TB_RandHero2_001
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_RandHero2_001")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_RandomHand_ench] Random Hand Enchant - Not Player Facing (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_RandomHand_ench", new CardDef(new Power
			{
				// TODO [TB_RandomHand_ench] Random Hand Enchant - Not Player Facing && Test: Random Hand Enchant - Not Player Facing_TB_RandomHand_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_RandomHand_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_RMC_001] TB_EnchRandomManaCost (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_RMC_001", new CardDef(new Power
			{
				// TODO [TB_RMC_001] TB_EnchRandomManaCost && Test: TB_EnchRandomManaCost_TB_RMC_001
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_RMC_001")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SC20_001] Portal Selection (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_SC20_001a, TB_SC20_001b, TB_SC20_001c
			// --------------------------------------------------------
			cards.Add("TB_SC20_001", new CardDef(new[] {"TB_SC20_001a","TB_SC20_001b","TB_SC20_001c"}, new Power
			{
				// TODO [TB_SC20_001] Portal Selection && Test: Portal Selection_TB_SC20_001
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_SC20_001")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_ShrinesPaladin] Paladin Shrines (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TRLA_105, TRLA_137, TRLA_138
			// --------------------------------------------------------
			cards.Add("TB_ShrinesPaladin", new CardDef(new[] {"TRLA_105","TRLA_137","TRLA_138"}, new Power
			{
				// TODO [TB_ShrinesPaladin] Paladin Shrines && Test: Paladin Shrines_TB_ShrinesPaladin
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_ShrinesPaladin")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_ShrinesWarlock] Warlock Shrines (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TRLA_113, TRLA_178, TRLA_179
			// --------------------------------------------------------
			cards.Add("TB_ShrinesWarlock", new CardDef(new[] {"TRLA_113","TRLA_178","TRLA_179"}, new Power
			{
				// TODO [TB_ShrinesWarlock] Warlock Shrines && Test: Warlock Shrines_TB_ShrinesWarlock
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_ShrinesWarlock")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_ShrinesWarrior] Warrior Shrines (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TRLA_104, TRLA_170, TRLA_171
			// --------------------------------------------------------
			cards.Add("TB_ShrinesWarrior", new CardDef(new[] {"TRLA_104","TRLA_170","TRLA_171"}, new Power
			{
				// TODO [TB_ShrinesWarrior] Warrior Shrines && Test: Warrior Shrines_TB_ShrinesWarrior
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_ShrinesWarrior")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Spellwrite_001] SpellCaster (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Spellwrite_001", new CardDef(new Power
			{
				// TODO [TB_Spellwrite_001] SpellCaster && Test: SpellCaster_TB_Spellwrite_001
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Spellwrite_001")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_DPromoEnch3] Shield Glare (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Attack changed to 1.
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoEnch3", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoEnch3] Shield Glare && Test: Shield Glare_TB_SPT_DPromoEnch3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_SPT_DPromoEnch3")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_DPromoSecre8e] Assassin's Stealth (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>.
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecre8e", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecre8e] Assassin's Stealth && Test: Assassin's Stealth_TB_SPT_DPromoSecre8e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_SPT_DPromoSecre8e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_DPromoSecret9e] Knowledge (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret9e", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSecret9e] Knowledge && Test: Knowledge_TB_SPT_DPromoSecret9e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_SPT_DPromoSecret9e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_DPromoSpellBovine1e] Herding (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Minion has <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpellBovine1e", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSpellBovine1e] Herding && Test: Herding_TB_SPT_DPromoSpellBovine1e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_SPT_DPromoSpellBovine1e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_Minion1e] Will of Stormwind (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Stormwind is granting this card Health.
			// --------------------------------------------------------
			cards.Add("TB_SPT_Minion1e", new CardDef(new Power
			{
				// TODO [TB_SPT_Minion1e] Will of Stormwind && Test: Will of Stormwind_TB_SPT_Minion1e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_SPT_Minion1e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_Minion2e] Emboldened (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Standard Bearer is granting +2 Attack to this minion.
			// --------------------------------------------------------
			cards.Add("TB_SPT_Minion2e", new CardDef(new Power
			{
				// TODO [TB_SPT_Minion2e] Emboldened && Test: Emboldened_TB_SPT_Minion2e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_SPT_Minion2e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_Minion3e] Strength of Stormwind (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Stormwind is granting this card Attack and Health.
			// --------------------------------------------------------
			cards.Add("TB_SPT_Minion3e", new CardDef(new Power
			{
				// TODO [TB_SPT_Minion3e] Strength of Stormwind && Test: Strength of Stormwind_TB_SPT_Minion3e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_SPT_Minion3e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SwapBossHeroPowerByClass] Swap Boss Hero Power by Class (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_SwapBossHeroPowerByClass", new CardDef(new Power
			{
				// TODO [TB_SwapBossHeroPowerByClass] Swap Boss Hero Power by Class && Test: Swap Boss Hero Power by Class_TB_SwapBossHeroPowerByClass
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_SwapBossHeroPowerByClass")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SwapHeroWithDeathKnight] Swap Hero With Death Knight (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_SwapHeroWithDeathKnight", new CardDef(new Power
			{
				// TODO [TB_SwapHeroWithDeathKnight] Swap Hero With Death Knight && Test: Swap Hero With Death Knight_TB_SwapHeroWithDeathKnight
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_SwapHeroWithDeathKnight")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_TagTeam] Check for Hero Death (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_TagTeam", new CardDef(new Power
			{
				// TODO [TB_TagTeam] Check for Hero Death && Test: Check for Hero Death_TB_TagTeam
				InfoCardId = "TB_TagTeam_GetClass",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_TagTeam")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_TagTeam_GetClass] Discover Next Class (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_TagTeam_Paladin, TB_TagTeam_Shaman, TB_TagTeam_Warlock, TB_TagTeam_Druid, TB_TagTeam_Hunter, TB_TagTeam_Mage, TB_TagTeam_Priest, TB_TagTeam_Rogue, TB_TagTeam_Warrior
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_GetClass", new CardDef(new[] {"TB_TagTeam_Paladin","TB_TagTeam_Shaman","TB_TagTeam_Warlock","TB_TagTeam_Druid","TB_TagTeam_Hunter","TB_TagTeam_Mage","TB_TagTeam_Priest","TB_TagTeam_Rogue","TB_TagTeam_Warrior"}, new Power
			{
				// TODO [TB_TagTeam_GetClass] Discover Next Class && Test: Discover Next Class_TB_TagTeam_GetClass
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_TagTeam_GetClass")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_TempleOutrun_ECe] Proposed Contract (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The next card you play costs (0) and is removed from your dungeon deck.
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_ECe", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_ECe] Proposed Contract && Test: Proposed Contract_TB_TempleOutrun_ECe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_TempleOutrun_ECe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_TempleOutrun_TogwaggleHPe] Fooled (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_TogwaggleHPe", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_TogwaggleHPe] Fooled && Test: Fooled_TB_TempleOutrun_TogwaggleHPe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_TempleOutrun_TogwaggleHPe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_TwoTurnsEnchant] Two Turns (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_TwoTurnsEnchant", new CardDef(new Power
			{
				// TODO [TB_TwoTurnsEnchant] Two Turns && Test: Two Turns_TB_TwoTurnsEnchant
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_TwoTurnsEnchant")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Vargoth_ench] Vargoth Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Vargoth_ench", new CardDef(new Power
			{
				// TODO [TB_Vargoth_ench] Vargoth Enchant && Test: Vargoth Enchant_TB_Vargoth_ench
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_Vargoth_ench")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_VoidSingularityEnch] Void Singularity Spell (*) - COST:0 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_VoidSingularityEnch", new CardDef(new Power
			{
				// TODO [TB_VoidSingularityEnch] Void Singularity Spell && Test: Void Singularity Spell_TB_VoidSingularityEnch
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_VoidSingularityEnch")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_YoggServant_Enchant] Yogg Servant Hero Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_YoggServant_Enchant", new CardDef(new Power
			{
				// TODO [TB_YoggServant_Enchant] Yogg Servant Hero Enchant && Test: Yogg Servant Hero Enchant_TB_YoggServant_Enchant
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TB_YoggServant_Enchant")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TBA01_5e] Magic! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TBA01_5e", new CardDef(new Power
			{
				// TODO [TBA01_5e] Magic! && Test: Magic!_TBA01_5e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TBA01_5e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TBST_006] OLDTBST Push Common Card (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: push a common card into player's hand
			// --------------------------------------------------------
			// Entourage: TBST_003, TBST_002, TBST_001
			// --------------------------------------------------------
			cards.Add("TBST_006", new CardDef(new[] {"TBST_003","TBST_002","TBST_001"}, new Power
			{
				// TODO [TBST_006] OLDTBST Push Common Card && Test: OLDTBST Push Common Card_TBST_006
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TBST_006")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TBUD_1] TBUD Summon Early Minion (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each turn, if you have less health then a your opponent, summon a free minion
			// --------------------------------------------------------
			// Entourage: CS1_042, CS2_171
			// --------------------------------------------------------
			cards.Add("TBUD_1", new CardDef(new[] {"CS1_042","CS2_171"}, new Power
			{
				// TODO [TBUD_1] TBUD Summon Early Minion && Test: TBUD Summon Early Minion_TBUD_1
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TBUD_1")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TOT_100e] Taverns Echo (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy card if in hand at the end of turn.
			// --------------------------------------------------------
			// GameTag:
			// - GHOSTLY = 1
			// --------------------------------------------------------
			cards.Add("TOT_100e", new CardDef(new Power
			{
				// TODO [TOT_100e] Taverns Echo && Test: Taverns Echo_TOT_100e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TOT_100e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ART_BOT_Bundle_001] Golden Legendary (*) - COST:0 
			// - Fac: alliance, Set: tb, Rarity: legendary
			// --------------------------------------------------------
			cards.Add("ART_BOT_Bundle_001", new CardDef(new Power
			{
				// TODO [ART_BOT_Bundle_001] Golden Legendary && Test: Golden Legendary_ART_BOT_Bundle_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_84] Dragonkin Spellcaster (*) - COST:5 [ATK:4/HP:6] 
			// - Race: dragon, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 2/2 Whelps.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRMC_84", new CardDef(new Power
			{
				// TODO [BRMC_84] Dragonkin Spellcaster && Test: Dragonkin Spellcaster_BRMC_84
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMC_85", new CardDef(new Power
			{
				// TODO [BRMC_85] Lucifron && Test: Lucifron_BRMC_85
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_86] Atramedes (*) - COST:4 [ATK:2/HP:8] 
			// - Race: dragon, Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever your opponent plays a card, gain +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_86", new CardDef(new Power
			{
				// TODO [BRMC_86] Atramedes && Test: Atramedes_BRMC_86
				InfoCardId = "BRMC_86e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMC_87", new CardDef(new Power
			{
				// TODO [BRMC_87] Moira Bronzebeard && Test: Moira Bronzebeard_BRMC_87
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_88] Drakonid Slayer (*) - COST:6 [ATK:6/HP:6] 
			// - Race: dragon, Set: tb, 
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever he attacks.
			// --------------------------------------------------------
			cards.Add("BRMC_88", new CardDef(new Power
			{
				// TODO [BRMC_88] Drakonid Slayer && Test: Drakonid Slayer_BRMC_88
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_89] Whirling Ash (*) - COST:2 [ATK:4/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("BRMC_89", new CardDef(new Power
			{
				// TODO [BRMC_89] Whirling Ash && Test: Whirling Ash_BRMC_89
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_90] Living Lava (*) - COST:2 [ATK:6/HP:6] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BRMC_90", new CardDef(new Power
			{
				// TODO [BRMC_90] Living Lava && Test: Living Lava_BRMC_90
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMC_91", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				// TODO [BRMC_91] Son of the Flame && Test: Son of the Flame_BRMC_91
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMC_92", new CardDef(new Power
			{
				// TODO [BRMC_92] Coren Direbrew && Test: Coren Direbrew_BRMC_92
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_95] Golemagg (*) - COST:50 [ATK:20/HP:20] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Costs (1) less for each damage your hero has taken.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_95", new CardDef(new Power
			{
				// TODO [BRMC_95] Golemagg && Test: Golemagg_BRMC_95
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_95he] Core Hound Pup (*) - COST:3 [ATK:2/HP:4] 
			// - Race: beast, Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of each turn, summon all Core Hound Pups that died this turn.
			// --------------------------------------------------------
			cards.Add("BRMC_95he", new CardDef(new Power
			{
				// TODO [BRMC_95he] Core Hound Pup && Test: Core Hound Pup_BRMC_95he
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_96] High Justice Grimstone (*) - COST:3 [ATK:4/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, summon a <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_96", new CardDef(new Power
			{
				// TODO [BRMC_96] High Justice Grimstone && Test: High Justice Grimstone_BRMC_96
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_97] Vaelastrasz (*) - COST:6 [ATK:7/HP:7] 
			// - Race: dragon, Set: tb, 
			// --------------------------------------------------------
			// Text: Your cards cost (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_97", new CardDef(new Power
			{
				// TODO [BRMC_97] Vaelastrasz && Test: Vaelastrasz_BRMC_97
				InfoCardId = "BRMC_97e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_98] Razorgore (*) - COST:6 [ATK:4/HP:12] 
			// - Race: dragon, Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, give your minions +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_98", new CardDef(new Power
			{
				// TODO [BRMC_98] Razorgore && Test: Razorgore_BRMC_98
				InfoCardId = "BRMC_98e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMC_99", new CardDef(new Power
			{
				// TODO [BRMC_99] Garr && Test: Garr_BRMC_99
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_99e] Rock Elemental (*) - COST:2 [ATK:2/HP:3] 
			// - Race: elemental, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BRMC_99e", new CardDef(new Power
			{
				// TODO [BRMC_99e] Rock Elemental && Test: Rock Elemental_BRMC_99e
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_CFM_637] Patches the Pirate (*) - COST:1 [ATK:1/HP:1] 
			// - Race: pirate, Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Charge</b>. After you play a Pirate,
			//       summon this minion
			//       from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_CFM_637", new CardDef(new Power
			{
				// TODO [FB_Champs_CFM_637] Patches the Pirate && Test: Patches the Pirate_FB_Champs_CFM_637
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_Champs_CS2_188", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [FB_Champs_CS2_188] Abusive Sergeant && Test: Abusive Sergeant_FB_Champs_CS2_188
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_Champs_EX1_005", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_MIN_ATTACK,7}}, new Power
			{
				// TODO [FB_Champs_EX1_005] Big Game Hunter && Test: Big Game Hunter_FB_Champs_EX1_005
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_EX1_029] Leper Gnome (*) - COST:1 [ATK:2/HP:1] 
			// - Fac: neutral, Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 2 damage to the enemy_hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_029", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_029] Leper Gnome && Test: Leper Gnome_FB_Champs_EX1_029
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_EX1_095] Gadgetzan Auctioneer (*) - COST:5 [ATK:4/HP:4] 
			// - Fac: neutral, Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, draw a card.
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_095", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_095] Gadgetzan Auctioneer && Test: Gadgetzan Auctioneer_FB_Champs_EX1_095
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_EX1_556] Harvest Golem (*) - COST:3 [ATK:2/HP:3] 
			// - Fac: neutral, Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 2/1 Damaged Golem.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_556", new CardDef(new Power
			{
				// TODO [FB_Champs_EX1_556] Harvest Golem && Test: Harvest Golem_FB_Champs_EX1_556
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_FP1_028] Undertaker (*) - COST:1 [ATK:1/HP:2] 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you summon a minion with <b>Deathrattle</b>, gain +1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_FP1_028", new CardDef(new Power
			{
				// TODO [FB_Champs_FP1_028] Undertaker && Test: Undertaker_FB_Champs_FP1_028
				InfoCardId = "FB_Champs_FP1_028e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_ICC_466] Saronite Chain Gang (*) - COST:4 [ATK:2/HP:3] 
			// - Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Summon a
			//       copy of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_ICC_466", new CardDef(new Power
			{
				// TODO [FB_Champs_ICC_466] Saronite Chain Gang && Test: Saronite Chain Gang_FB_Champs_ICC_466
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_ICC_705] Bonemare (*) - COST:7 [ATK:5/HP:5] 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +4/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_ICC_705", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [FB_Champs_ICC_705] Bonemare && Test: Bonemare_FB_Champs_ICC_705
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_LOE_038] Naga Sea Witch (*) - COST:5 [ATK:5/HP:5] 
			// - Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: Your cards cost (5).
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_LOE_038", new CardDef(new Power
			{
				// TODO [FB_Champs_LOE_038] Naga Sea Witch && Test: Naga Sea Witch_FB_Champs_LOE_038
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_LOOT_149] Corridor Creeper (*) - COST:7 [ATK:5/HP:5] 
			// - Race: beast, Fac: neutral, Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less whenever a minion dies while this is_in_your hand.
			// --------------------------------------------------------
			cards.Add("FB_Champs_LOOT_149", new CardDef(new Power
			{
				// TODO [FB_Champs_LOOT_149] Corridor Creeper && Test: Corridor Creeper_FB_Champs_LOOT_149
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_LOOT_539] Spiteful Summoner (*) - COST:6 [ATK:4/HP:4] 
			// - Fac: neutral, Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Reveal a spell
			//       from your deck. Summon
			//        a random minion with
			//       the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_LOOT_539", new CardDef(new Power
			{
				// TODO [FB_Champs_LOOT_539] Spiteful Summoner && Test: Spiteful Summoner_FB_Champs_LOOT_539
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_NEW1_019] Knife Juggler (*) - COST:2 [ATK:3/HP:2] 
			// - Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]After you summon a
			//       minion, deal 1 damage
			//       to a random enemy.
			// --------------------------------------------------------
			cards.Add("FB_Champs_NEW1_019", new CardDef(new Power
			{
				// TODO [FB_Champs_NEW1_019] Knife Juggler && Test: Knife Juggler_FB_Champs_NEW1_019
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_skele21] Damaged Golem (*) - COST:1 [ATK:2/HP:1] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Champs_skele21", new CardDef(new Power
			{
				// TODO [FB_Champs_skele21] Damaged Golem && Test: Damaged Golem_FB_Champs_skele21
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Toki_Boss_Minion1] Paradox (*) - COST:2 [ATK:2/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Auto attack: Deal 2 damage to characters opposite this one.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HERO_POWER = 48763
			// --------------------------------------------------------
			// RefTag:
			// - BOSS = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_Boss_Minion1", new CardDef(new Power
			{
				// TODO [FB_Toki_Boss_Minion1] Paradox && Test: Paradox_FB_Toki_Boss_Minion1
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("HRW02_1", new CardDef(new Power
			{
				// TODO [HRW02_1] Gearmaster Mechazod && Test: Gearmaster Mechazod_HRW02_1
				InfoCardId = "HRW02_1e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("HRW02_2", new CardDef(new Power
			{
				// TODO [HRW02_2] Gearmaster Mechazod && Test: Gearmaster Mechazod_HRW02_2
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [HRW02_3] Kill Objective: Anub'arak (*) - COST:0 [ATK:1/HP:100] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Wreaks havoc at the beginning of each turn.  Immune to abilites that don't affect heroes.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("HRW02_3", new CardDef(new Power
			{
				// TODO [HRW02_3] Kill Objective: Anub'arak && Test: Kill Objective: Anub'arak_HRW02_3
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("KARA_13_15", new CardDef(new Power
			{
				// TODO [KARA_13_15] Wanda Wonderhooves && Test: Wanda Wonderhooves_KARA_13_15
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("KARA_13_16", new CardDef(new Power
			{
				// TODO [KARA_13_16] Susie Sizzlesong && Test: Susie Sizzlesong_KARA_13_16
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("KARA_13_17", new CardDef(new Power
			{
				// TODO [KARA_13_17] Mark Moonwalker && Test: Mark Moonwalker_KARA_13_17
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("KARA_13_19", new CardDef(new Power
			{
				// TODO [KARA_13_19] Red Riding Hood && Test: Red Riding Hood_KARA_13_19
				InfoCardId = "KARA_13_19e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_13_20] Party Elemental (*) - COST:3 [ATK:3/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Comes with a party!
			// --------------------------------------------------------
			cards.Add("KARA_13_20", new CardDef(new Power
			{
				// TODO [KARA_13_20] Party Elemental && Test: Party Elemental_KARA_13_20
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_13_22] Mime (*) - COST:5 [ATK:5/HP:6] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Always <b>silenced</b>.
			// --------------------------------------------------------
			cards.Add("KARA_13_22", new CardDef(new Power
			{
				// TODO [KARA_13_22] Mime && Test: Mime_KARA_13_22
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_13_23] Romulo (*) - COST:5 [ATK:3/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, restore #3 health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_23", new CardDef(new Power
			{
				// TODO [KARA_13_23] Romulo && Test: Romulo_KARA_13_23
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_015] Pirate (*) - COST:2 [ATK:2/HP:3] 
			// - Race: pirate, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_015", new CardDef(new Power
			{
				// TODO [TB_015] Pirate && Test: Pirate_TB_015
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_207masterChest] Master Chest (*) - COST:3 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give your opponent a fantastic treasure!
			// --------------------------------------------------------
			// Entourage: LOOT_998h, LOOT_998j, LOOT_998l, LOOT_998k
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - MULTIPLY_BUFF_VALUE = 1
			// --------------------------------------------------------
			cards.Add("TB_207masterChest", new CardDef(new[] {"LOOT_998h","LOOT_998j","LOOT_998l","LOOT_998k"}, new Power
			{
				// TODO [TB_207masterChest] Master Chest && Test: Master Chest_TB_207masterChest
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_CoOp_Mechazod2] Overloaded Mechazod (*) - COST:10 [ATK:9/HP:80] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Boss</b>
			//       At the beginning of each turn, Mechazod strikes!
			// --------------------------------------------------------
			cards.Add("TB_CoOp_Mechazod2", new CardDef(new Power
			{
				// TODO [TB_CoOp_Mechazod2] Overloaded Mechazod && Test: Overloaded Mechazod_TB_CoOp_Mechazod2
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_CoOp_Mechazod_OLD", new CardDef(new Power
			{
				// TODO [TB_CoOp_Mechazod_OLD] Gearmaster Mechazod && Test: Gearmaster Mechazod_TB_CoOp_Mechazod_OLD
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_CoOp_Mechazod_V2", new CardDef(new Power
			{
				// TODO [TB_CoOp_Mechazod_V2] Gearmaster Mechazod && Test: Gearmaster Mechazod_TB_CoOp_Mechazod_V2
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_CoopHero_001] Netherspite Infernal (*) - COST:2 [ATK:2/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of each turn, deal 1 damage to all enemies.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40221
			// --------------------------------------------------------
			cards.Add("TB_CoopHero_001", new CardDef(new Power
			{
				// TODO [TB_CoopHero_001] Netherspite Infernal && Test: Netherspite Infernal_TB_CoopHero_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_009t] Explosive Rune (*) - COST:2 [ATK:0/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, this explodes, dealing 9 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_009t", new CardDef(new Power
			{
				// TODO [TB_Coopv3_009t] Explosive Rune && Test: Explosive Rune_TB_Coopv3_009t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_100] Dragonscale Warrior (*) - COST:3 [ATK:3/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever any player targets this minion with a spell, that player draws a card.
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_100", new CardDef(new Power
			{
				// TODO [TB_Coopv3_100] Dragonscale Warrior && Test: Dragonscale Warrior_TB_Coopv3_100
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_101] Freewheeling Skulker (*) - COST:5 [ATK:5/HP:6] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, switch sides.
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_101", new CardDef(new Power
			{
				// TODO [TB_Coopv3_101] Freewheeling Skulker && Test: Freewheeling Skulker_TB_Coopv3_101
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_103] Intrepid Dragonstalker (*) - COST:5 [ATK:3/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever ANY player plays a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_103", new CardDef(new Power
			{
				// TODO [TB_Coopv3_103] Intrepid Dragonstalker && Test: Intrepid Dragonstalker_TB_Coopv3_103
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_104] Main Tank (*) - COST:4 [ATK:4/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all other minions +2/+2, except the <b>Boss</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_104", new CardDef(new Power
			{
				// TODO [TB_Coopv3_104] Main Tank && Test: Main Tank_TB_Coopv3_104
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_104_NewClasses] Main Tank (*) - COST:4 [ATK:4/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all other minions +2/+2, except the <b>Boss</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_104_NewClasses", new CardDef(new Power
			{
				// TODO [TB_Coopv3_104_NewClasses] Main Tank && Test: Main Tank_TB_Coopv3_104_NewClasses
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_105] Raid Healer (*) - COST:4 [ATK:0/HP:7] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever your hero is healed, also heal your teammate for that much.
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_105", new CardDef(new Power
			{
				// TODO [TB_Coopv3_105] Raid Healer && Test: Raid Healer_TB_Coopv3_105
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_CoOpv3_Boss", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_Boss] Nefarian && Test: Nefarian_TB_CoOpv3_Boss
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_CoOpv3_Boss_FB", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_Boss_FB] Nefarian && Test: Nefarian_TB_CoOpv3_Boss_FB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_CoOpv3_Boss_NewClasses", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_Boss_NewClasses] Nefarian && Test: Nefarian_TB_CoOpv3_Boss_NewClasses
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Dorothee_001", new CardDef(new Power
			{
				// TODO [TB_Dorothee_001] Dorothee && Test: Dorothee_TB_Dorothee_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FireFestival_Brazier] Brazier (*) - COST:8 [ATK:1/HP:1] 
			// - Race: elemental, Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("TB_FireFestival_Brazier", new CardDef(new Power
			{
				// TODO [TB_FireFestival_Brazier] Brazier && Test: Brazier_TB_FireFestival_Brazier
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FireFestival_Fireworks] Fireworks (*) - COST:8 [ATK:1/HP:1] 
			// - Race: elemental, Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("TB_FireFestival_Fireworks", new CardDef(new Power
			{
				// TODO [TB_FireFestival_Fireworks] Fireworks && Test: Fireworks_TB_FireFestival_Fireworks
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_FireFestival_MRag", new CardDef(new Power
			{
				// TODO [TB_FireFestival_MRag] Mini-Rag && Test: Mini-Rag_TB_FireFestival_MRag
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FireFestival_Rakanishu] Rakanishu (*) - COST:1 [ATK:2/HP:3] 
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
			cards.Add("TB_FireFestival_Rakanishu", new CardDef(new Power
			{
				// TODO [TB_FireFestival_Rakanishu] Rakanishu && Test: Rakanishu_TB_FireFestival_Rakanishu
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Frost_Rag", new CardDef(new Power
			{
				// TODO [TB_Frost_Rag] Ragnaros? && Test: Ragnaros?_TB_Frost_Rag
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_FW_DrBoomMega", new CardDef(new Power
			{
				// TODO [TB_FW_DrBoomMega] Dr. Boom Boom Boom Boom && Test: Dr. Boom Boom Boom Boom_TB_FW_DrBoomMega
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_FW_ImbaTron", new CardDef(new Power
			{
				// TODO [TB_FW_ImbaTron] Annoy-o-p-Tron && Test: Annoy-o-p-Tron_TB_FW_ImbaTron
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FW_Mortar] Dwarf Demolitionist (*) - COST:1 [ATK:1/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever you play a card, deal 1-4 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("TB_FW_Mortar", new CardDef(new Power
			{
				// TODO [TB_FW_Mortar] Dwarf Demolitionist && Test: Dwarf Demolitionist_TB_FW_Mortar
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_FW_OmegaMax", new CardDef(new Power
			{
				// TODO [TB_FW_OmegaMax] Force-Tank OMEGA MAX && Test: Force-Tank OMEGA MAX_TB_FW_OmegaMax
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FW_Warper] Omegawarper (*) - COST:3 [ATK:3/HP:5] 
			// - Race: mechanical, Set: tb, 
			// --------------------------------------------------------
			// Text: Both player's Mechs cost (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("TB_FW_Warper", new CardDef(new Power
			{
				// TODO [TB_FW_Warper] Omegawarper && Test: Omegawarper_TB_FW_Warper
				InfoCardId = "TB_FW_Warpere",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_GiftExchange_Treasure] Winter Veil Gift (*) - COST:0 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give current player a Stolen Gift.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_GiftExchange_Treasure", new CardDef(new Power
			{
				// TODO [TB_GiftExchange_Treasure] Winter Veil Gift && Test: Winter Veil Gift_TB_GiftExchange_Treasure
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_GP_03", new CardDef(new Power
			{
				// TODO [TB_GP_03] Shadow Tower New && Test: Shadow Tower New_TB_GP_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_HeadlessHorseman_001] Headless Horseman's Head (*) - COST:10 [ATK:2/HP:35] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy his head to win the game, but watch out for fireballs!
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_001", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_001] Headless Horseman's Head && Test: Headless Horseman's Head_TB_HeadlessHorseman_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_HeadlessHorseman_002] Sinister Squashling (*) - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: After this minion attacks, destroy it and deal 3 damage to all enemies.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_002", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_002] Sinister Squashling && Test: Sinister Squashling_TB_HeadlessHorseman_002
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_HeadlessHorseman_003] Pulsing Pumpkin (*) - COST:3 [ATK:0/HP:5] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy this and summon 2 Sinister Squashlings
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_003", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_003] Pulsing Pumpkin && Test: Pulsing Pumpkin_TB_HeadlessHorseman_003
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_HeadlessHorseman_004] Captain Cookie (*) - COST:5 [ATK:0/HP:3] 
			// - Race: murloc, Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever you summon a Pirate while this is in your hand, give this minion +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_004", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_004] Captain Cookie && Test: Captain Cookie_TB_HeadlessHorseman_004
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_HeadlessHorseman_005] Spectral Steed (*) - COST:5 [ATK:5/HP:6] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Minions attacking this have a 50% chance to attack a different character.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_005", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_005] Spectral Steed && Test: Spectral Steed_TB_HeadlessHorseman_005
				InfoCardId = "TB_HeadlessHorseman_005e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Ignoblegarden1] Bloom Bot (*) - COST:4 [ATK:1/HP:5] 
			// - Race: mechanical, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a Legendary minion.
			//       Give it <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_Ignoblegarden1", new CardDef(new Power
			{
				// TODO [TB_Ignoblegarden1] Bloom Bot && Test: Bloom Bot_TB_Ignoblegarden1
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Ignoblegarden2] Room Bot (*) - COST:3 [ATK:1/HP:2] 
			// - Race: mechanical, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>. <b>Taunt</b>
			//       <b>Deathrattle:</b>Summon 3 1/1 Boom Bots.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("TB_Ignoblegarden2", new CardDef(new Power
			{
				// TODO [TB_Ignoblegarden2] Room Bot && Test: Room Bot_TB_Ignoblegarden2
				InfoCardId = "TB_Ignoblegarden2e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Ignoblegarden3] Doom Bot (*) - COST:5 [ATK:1/HP:7] 
			// - Race: mechanical, Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle</b>: Deal 5 damage to ALL minions.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_Ignoblegarden3", new CardDef(new Power
			{
				// TODO [TB_Ignoblegarden3] Doom Bot && Test: Doom Bot_TB_Ignoblegarden3
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_IgnoblegardenEgg] Noblegarden Egg (*) - COST:2 [ATK:0/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Start of next turn, hatch.
			// --------------------------------------------------------
			cards.Add("TB_IgnoblegardenEgg", new CardDef(new Power
			{
				// TODO [TB_IgnoblegardenEgg] Noblegarden Egg && Test: Noblegarden Egg_TB_IgnoblegardenEgg
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KaraPortals_003] Party Elemental (*) - COST:3 [ATK:3/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_KaraPortals_003", new CardDef(new Power
			{
				// TODO [TB_KaraPortals_003] Party Elemental && Test: Party Elemental_TB_KaraPortals_003
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_KoboldGiftMinion", new CardDef(new Power
			{
				// TODO [TB_KoboldGiftMinion] Large Waxy Gift && Test: Large Waxy Gift_TB_KoboldGiftMinion
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_1] Anub'Rekhan (*) - COST:4 [ATK:5/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a 3/1 Nerubian.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_1", new CardDef(new Power
			{
				// TODO [TB_KTRAF_1] Anub'Rekhan && Test: Anub'Rekhan_TB_KTRAF_1
				InfoCardId = "TB_KTRAF_10e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_10] Noth the Plaguebringer (*) - COST:9 [ATK:2/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever an enemy minion dies, summon a 1/1 Skeleton and give your other minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_10", new CardDef(new Power
			{
				// TODO [TB_KTRAF_10] Noth the Plaguebringer && Test: Noth the Plaguebringer_TB_KTRAF_10
				InfoCardId = "TB_KTRAF_10e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_KTRAF_11", new CardDef(new Power
			{
				// TODO [TB_KTRAF_11] Sapphiron && Test: Sapphiron_TB_KTRAF_11
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_KTRAF_12", new CardDef(new Power
			{
				// TODO [TB_KTRAF_12] Patchwerk && Test: Patchwerk_TB_KTRAF_12
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_KTRAF_2", new CardDef(new Power
			{
				// TODO [TB_KTRAF_2] Lady Blaumeux && Test: Lady Blaumeux_TB_KTRAF_2
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_KTRAF_2s", new CardDef(new Power
			{
				// TODO [TB_KTRAF_2s] Sir Zeliek && Test: Sir Zeliek_TB_KTRAF_2s
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_KTRAF_3", new CardDef(new[] {"FP1_001","AT_030","LOE_019","EX1_012","EX1_059","FP1_004","EX1_616","FP1_024","tt_004"}, new Power
			{
				// TODO [TB_KTRAF_3] Gluth && Test: Gluth_TB_KTRAF_3
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_KTRAF_4", new CardDef(new Power
			{
				// TODO [TB_KTRAF_4] Gothik the Harvester && Test: Gothik the Harvester_TB_KTRAF_4
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_4m] Spectral Gothik (*) - COST:3 [ATK:0/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 4 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_4m", new CardDef(new Power
			{
				// TODO [TB_KTRAF_4m] Spectral Gothik && Test: Spectral Gothik_TB_KTRAF_4m
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_5] Grand Widow Faerlina (*) - COST:4 [ATK:0/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Has +1 Attack for each card in your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_5", new CardDef(new Power
			{
				// TODO [TB_KTRAF_5] Grand Widow Faerlina && Test: Grand Widow Faerlina_TB_KTRAF_5
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_KTRAF_6", new CardDef(new Power
			{
				// TODO [TB_KTRAF_6] Grobbulus && Test: Grobbulus_TB_KTRAF_6
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_6m] Fallout Slime (*) - COST:1 [ATK:2/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_6m", new CardDef(new Power
			{
				// TODO [TB_KTRAF_6m] Fallout Slime && Test: Fallout Slime_TB_KTRAF_6m
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_7] Heigan the Unclean (*) - COST:3 [ATK:4/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 4 damage to a  random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_7", new CardDef(new Power
			{
				// TODO [TB_KTRAF_7] Heigan the Unclean && Test: Heigan the Unclean_TB_KTRAF_7
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_KTRAF_8", new CardDef(new Power
			{
				// TODO [TB_KTRAF_8] Instructor Razuvious && Test: Instructor Razuvious_TB_KTRAF_8
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_Under] Understudy (*) - COST:2 [ATK:0/HP:7] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_Under", new CardDef(new Power
			{
				// TODO [TB_KTRAF_Under] Understudy && Test: Understudy_TB_KTRAF_Under
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_LEAGUE_REVIVAL_BrannBoss] King Krush, Untamed (*) - COST:10 [ATK:8/HP:60] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Boss</b>
			//       At the end of each turn, attack a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - CANT_BE_SILENCED = 1
			// - 463 = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_BrannBoss", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_BrannBoss] King Krush, Untamed && Test: King Krush, Untamed_TB_LEAGUE_REVIVAL_BrannBoss
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_LEAGUE_REVIVAL_FinleyChest] Sandy Chest (*) - COST:3 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give your opponent a fantastic treasure!
			// --------------------------------------------------------
			// Entourage: LOOT_998h, LOOT_998j, LOOT_998l, LOOT_998k, LOOTA_836, LOOTA_836
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - MULTIPLY_BUFF_VALUE = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_FinleyChest", new CardDef(new[] {"LOOT_998h","LOOT_998j","LOOT_998l","LOOT_998k","LOOTA_836","LOOTA_836"}, new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_FinleyChest] Sandy Chest && Test: Sandy Chest_TB_LEAGUE_REVIVAL_FinleyChest
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_LEAGUE_REVIVAL_FinleySandPile] Pile of Sand (*) - COST:0 [ATK:0/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your hero is <b>Immune</b>
			//       <b>Deathrattle:</b> Uncover what is beneath the sand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - CANT_ATTACK = 1
			// - HIDE_COST = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_FinleySandPile", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_FinleySandPile] Pile of Sand && Test: Pile of Sand_TB_LEAGUE_REVIVAL_FinleySandPile
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_MammothParty_Boss002", new CardDef(new[] {"TB_MammothParty_303","TB_MammothParty_302","TB_MammothParty_301"}, new Power
			{
				// TODO [TB_MammothParty_Boss002] Piñata Golem && Test: Piñata Golem_TB_MammothParty_Boss002
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_MammothParty_m001", new CardDef(new Power
			{
				// TODO [TB_MammothParty_m001] Party Crasher && Test: Party Crasher_TB_MammothParty_m001
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_MammothParty_m001_alt", new CardDef(new Power
			{
				// TODO [TB_MammothParty_m001_alt] Party Crasher && Test: Party Crasher_TB_MammothParty_m001_alt
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_MechWar_Minion1] Mech Fan (*) - COST:2 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TB_MechWar_Minion1", new CardDef(new Power
			{
				// TODO [TB_MechWar_Minion1] Mech Fan && Test: Mech Fan_TB_MechWar_Minion1
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_MnkWf01", new CardDef(new Power
			{
				// TODO [TB_MnkWf01] Nadia, Mankrik's Wife && Test: Nadia, Mankrik's Wife_TB_MnkWf01
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Noblegarden_002] Noblegarden Egg (*) - COST:2 [ATK:0/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>. At the start of your turn, hatch this into something cute.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_002", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_002] Noblegarden Egg && Test: Noblegarden Egg_TB_Noblegarden_002
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Noblegarden_002t1] Bunny (*) - COST:1 [ATK:1/HP:3] 
			// - Race: beast, Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_002t1", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_002t1] Bunny && Test: Bunny_TB_Noblegarden_002t1
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Noblegarden_002t2] Noblegarden Goblin (*) - COST:3 [ATK:5/HP:2] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_002t2", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_002t2] Noblegarden Goblin && Test: Noblegarden Goblin_TB_Noblegarden_002t2
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Noblegarden_006", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_006] Hawkstrider Hen && Test: Hawkstrider Hen_TB_Noblegarden_006
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DPromoCrate1] Weapon Rack (*) - COST:1 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Current turn player gains a random weapon.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoCrate1", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoCrate1] Weapon Rack && Test: Weapon Rack_TB_SPT_DPromoCrate1
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DPromoCrate2] Discarded Armor (*) - COST:1 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Current turn player gains 5 armor.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoCrate2", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoCrate2] Discarded Armor && Test: Discarded Armor_TB_SPT_DPromoCrate2
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DPromoCrate3] Chest of Gold! (*) - COST:1 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Current turn player gains gold!
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoCrate3", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoCrate3] Chest of Gold! && Test: Chest of Gold!_TB_SPT_DPromoCrate3
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DPromoMinion] Hell Bovine (*) - COST:3 [ATK:2/HP:2] 
			// - Race: demon, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Place a copy of this card in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoMinion", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoMinion] Hell Bovine && Test: Hell Bovine_TB_SPT_DPromoMinion
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_DPromoMinion2", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoMinion2] Guardian && Test: Guardian_TB_SPT_DPromoMinion2
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_DPromoMinionChamp", new CardDef(new[] {"AT_050","CS2_112","LOE_118","EX1_567","TB_BlingBrawl_Weapon","CS2_106","CFM_631","CS2_080"}, new Power
			{
				// TODO [TB_SPT_DPromoMinionChamp] Hell Bovine Champion && Test: Hell Bovine Champion_TB_SPT_DPromoMinionChamp
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_DPromoMinionInit", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoMinionInit] Hell Bovine && Test: Hell Bovine_TB_SPT_DPromoMinionInit
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_DpromoPortal", new CardDef(new Power
			{
				// TODO [TB_SPT_DpromoPortal] Enigmatic Portal && Test: Enigmatic Portal_TB_SPT_DpromoPortal
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_Minion1", new CardDef(new Power
			{
				// TODO [TB_SPT_Minion1] Shieldsman && Test: Shieldsman_TB_SPT_Minion1
				InfoCardId = "TB_SPT_Minion1e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_Minion2", new CardDef(new Power
			{
				// TODO [TB_SPT_Minion2] Battle Standard && Test: Battle Standard_TB_SPT_Minion2
				InfoCardId = "TB_SPT_Minion2e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_Minion3] Swordsman (*) - COST:3 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain Attack and Health equal to Stormwind's Attack
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_Minion3", new CardDef(new Power
			{
				// TODO [TB_SPT_Minion3] Swordsman && Test: Swordsman_TB_SPT_Minion3
				InfoCardId = "TB_SPT_Minion3e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_MTH_Minion1", new CardDef(new Power
			{
				// TODO [TB_SPT_MTH_Minion1] Happy Partygoer && Test: Happy Partygoer_TB_SPT_MTH_Minion1
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SPT_MTH_Minion2", new CardDef(new Power
			{
				// TODO [TB_SPT_MTH_Minion2] Party Banner && Test: Party Banner_TB_SPT_MTH_Minion2
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_MTH_Minion3] Ornery Partygoer (*) - COST:3 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain Attack and Health equal to Stormwind's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Minion3", new CardDef(new Power
			{
				// TODO [TB_SPT_MTH_Minion3] Ornery Partygoer && Test: Ornery Partygoer_TB_SPT_MTH_Minion3
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_TempleOutrun_HHHead] Headless Horseman's Head (*) - COST:10 [ATK:3/HP:35] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy his head to win the game, but watch out for fireballs!
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_HHHead", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_HHHead] Headless Horseman's Head && Test: Headless Horseman's Head_TB_TempleOutrun_HHHead
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_TempleOutrun_Lender] Best Friend Forever (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: horde, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Charge</b>,<b> Taunt</b>.
			//       <b>Battlecry:</b> Combines with other Friends.
			//       Lasts. FOREVER.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Lender", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Lender] Best Friend Forever && Test: Best Friend Forever_TB_TempleOutrun_Lender
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TB_VoidSingularityMinion] Void Singularity (*) - COST:1 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_VoidSingularityMinion", new CardDef(new Power
			{
				// TODO [TB_VoidSingularityMinion] Void Singularity && Test: Void Singularity_TB_VoidSingularityMinion
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TBST_001] OLDN3wb Tank (*) - COST:1 [ATK:2/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TBST_001", new CardDef(new Power
			{
				// TODO [TBST_001] OLDN3wb Tank && Test: OLDN3wb Tank_TBST_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TBST_002] OLDN3wb Mage (*) - COST:1 [ATK:2/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 1 damage to random enemy minion.
			// --------------------------------------------------------
			cards.Add("TBST_002", new CardDef(new Power
			{
				// TODO [TBST_002] OLDN3wb Mage && Test: OLDN3wb Mage_TBST_002
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TBST_003] OLDN3wb Healer (*) - COST:1 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, heal 2 damage from adjacent minions.
			// --------------------------------------------------------
			cards.Add("TBST_003", new CardDef(new Power
			{
				// TODO [TBST_003] OLDN3wb Healer && Test: OLDN3wb Healer_TBST_003
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TBST_004] OLDLegit Healer (*) - COST:3 [ATK:2/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a random friendly minion that died this turn.
			// --------------------------------------------------------
			cards.Add("TBST_004", new CardDef(new Power
			{
				// TODO [TBST_004] OLDLegit Healer && Test: OLDLegit Healer_TBST_004
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TBST_005", new CardDef(new Power
			{
				// TODO [TBST_005] OLDPvP Rogue && Test: OLDPvP Rogue_TBST_005
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMA01_2H_2c_TB] Pile On!!! (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Put two minions from your deck and one from your opponent's into the battlefield.
			// --------------------------------------------------------
			cards.Add("BRMA01_2H_2c_TB", new CardDef(new Power
			{
				// TODO [BRMA01_2H_2c_TB] Pile On!!! && Test: Pile On!!!_BRMA01_2H_2c_TB
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMA02_2_2c_TB] Jeering Crowd (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a 1/1 Spectator with <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BRMA02_2_2c_TB", new CardDef(new Power
			{
				// TODO [BRMA02_2_2c_TB] Jeering Crowd && Test: Jeering Crowd_BRMA02_2_2c_TB
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMA07_2_2c_TB] ME SMASH (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy a random enemy minion.
			// --------------------------------------------------------
			cards.Add("BRMA07_2_2c_TB", new CardDef(new Power
			{
				// TODO [BRMA07_2_2c_TB] ME SMASH && Test: ME SMASH_BRMA07_2_2c_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMC_100", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [BRMC_100] Living Bomb && Test: Living Bomb_BRMC_100
				InfoCardId = "BRMC_100e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMC_83] Open the Gates (*) - COST:8 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Fill your board with 2/2 Whelps.
			// --------------------------------------------------------
			cards.Add("BRMC_83", new CardDef(new Power
			{
				// TODO [BRMC_83] Open the Gates && Test: Open the Gates_BRMC_83
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMC_93] Omnotron Defense System (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a random Tron.
			// --------------------------------------------------------
			// Entourage: BRMA14_3, BRMA14_5, BRMA14_7, BRMA14_9
			// --------------------------------------------------------
			cards.Add("BRMC_93", new CardDef(new[] {"BRMA14_3","BRMA14_5","BRMA14_7","BRMA14_9"}, new Power
			{
				// TODO [BRMC_93] Omnotron Defense System && Test: Omnotron Defense System_BRMC_93
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMC_95h] Core Hound Puppies (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon two 2/4 Core Hound Pups.
			// --------------------------------------------------------
			cards.Add("BRMC_95h", new CardDef(new Power
			{
				// TODO [BRMC_95h] Core Hound Puppies && Test: Core Hound Puppies_BRMC_95h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Annoyo_001] Recharge! Recharge! (*) - COST:3 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Replace your deck with a fresh one.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Annoyo_001", new CardDef(new Power
			{
				// TODO [FB_Annoyo_001] Recharge! Recharge! && Test: Recharge! Recharge!_FB_Annoyo_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Annoyo_002a] Upgrade Annoy-o-Core (*) - COST:3 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Each Annoy-o-Tron summoned is +1/+1 more than the last.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Annoyo_002a", new CardDef(new Power
			{
				// TODO [FB_Annoyo_002a] Upgrade Annoy-o-Core && Test: Upgrade Annoy-o-Core_FB_Annoyo_002a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Annoyo_002b] Upgrade Annoy-o-Core (*) - COST:3 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Each Annoy-o-Tron summoned is +2/+2 more than the last.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Annoyo_002b", new CardDef(new Power
			{
				// TODO [FB_Annoyo_002b] Upgrade Annoy-o-Core && Test: Upgrade Annoy-o-Core_FB_Annoyo_002b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Annoyo_002c] Upgrade Annoy-o-Core (*) - COST:3 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Each Annoy-o-Tron summoned is +4/+4 more than the last.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Annoyo_002c", new CardDef(new Power
			{
				// TODO [FB_Annoyo_002c] Upgrade Annoy-o-Core && Test: Upgrade Annoy-o-Core_FB_Annoyo_002c
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Annoyo_002d] Maximum Annoying! (*) - COST:3 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Each Annoy-o-Tron summoned is +8/+8 more than the last.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Annoyo_002d", new CardDef(new Power
			{
				// TODO [FB_Annoyo_002d] Maximum Annoying! && Test: Maximum Annoying!_FB_Annoyo_002d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Annoyo_003] Increase Volume (*) - COST:3 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Your Hero Power now summons two 
			//       Annoy-o-Trons.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Annoyo_003", new CardDef(new Power
			{
				// TODO [FB_Annoyo_003] Increase Volume && Test: Increase Volume_FB_Annoyo_003
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl001a] By the Power of Ragnaros! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, reduce the Cost of cards in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001a", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl001a] By the Power of Ragnaros! && Test: By the Power of Ragnaros!_FB_BuildABrawl001a
				InfoCardId = "FB_BuildABrawl001a_ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl001b] Randomonium (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, randomize the Cost of cards in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001b", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl001b] Randomonium && Test: Randomonium_FB_BuildABrawl001b
				InfoCardId = "FB_BuildABrawl001b_ench",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("FB_BuildABrawl001c", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl001c] Battle of Tol Barad && Test: Battle of Tol Barad_FB_BuildABrawl001c
				InfoCardId = "FB_BuildABrawl001c_ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl002a] Summoner Competition (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you cast a spell, summon a random minion of the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002a", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl002a] Summoner Competition && Test: Summoner Competition_FB_BuildABrawl002a
				InfoCardId = "FB_BuildABrawl002a_ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl002b] The Masked Ball (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you summon a minion, give it "<b>Deathrattle:</b> Summon a minion that costs (2) less."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002b", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl002b] The Masked Ball && Test: The Masked Ball_FB_BuildABrawl002b
				InfoCardId = "FB_BuildABrawl002b_ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl002c] Servant of Yogg Tryouts (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you summon a minion, cast a random spell on a random target.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002c", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl002c] Servant of Yogg Tryouts && Test: Servant of Yogg Tryouts_FB_BuildABrawl002c
				InfoCardId = "FB_BuildABrawl002c_ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl003b] Clash of the Minions (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you summon a minion, give it <b>Charge</b> and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl003b", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl003b] Clash of the Minions && Test: Clash of the Minions_FB_BuildABrawl003b
				InfoCardId = "FB_BuildABrawl003b_ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl003c] Blood Magic (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All spells cost Health instead of Mana.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl003c", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl003c] Blood Magic && Test: Blood Magic_FB_BuildABrawl003c
				InfoCardId = "FB_BuildABrawl003c_ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl_Tools_reset] Build-A-Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Choose a new blend of Tavern Brawls for your Fireside Gathering.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl_Tools_reset", new CardDef(new Power
			{
				// TODO [FB_BuildABrawl_Tools_reset] Build-A-Brawl && Test: Build-A-Brawl_FB_BuildABrawl_Tools_reset
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Champs_Reset] Reset the Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset the Champions' Win Percents to 0.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 12
			// --------------------------------------------------------
			cards.Add("FB_Champs_Reset", new CardDef(new Power
			{
				// TODO [FB_Champs_Reset] Reset the Brawl && Test: Reset the Brawl_FB_Champs_Reset
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Duelers_Draw] Draw! (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Both Players gain 10 mana.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Duelers_Draw", new CardDef(new Power
			{
				// TODO [FB_Duelers_Draw] Draw! && Test: Draw!_FB_Duelers_Draw
				InfoCardId = "FB_Duelers_Drawn",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Duelers_Endl] Sudden Death! (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Deal damage randomly between each hero's side, until one dies.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("FB_Duelers_Endl", new CardDef(new Power
			{
				// TODO [FB_Duelers_Endl] Sudden Death! && Test: Sudden Death!_FB_Duelers_Endl
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO001a] Play the Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Continue playing normally.
			// --------------------------------------------------------
			cards.Add("FB_ELO001a", new CardDef(new Power
			{
				// TODO [FB_ELO001a] Play the Brawl && Test: Play the Brawl_FB_ELO001a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO001b] Reset the Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset all player wins to 0.
			// --------------------------------------------------------
			cards.Add("FB_ELO001b", new CardDef(new Power
			{
				// TODO [FB_ELO001b] Reset the Brawl && Test: Reset the Brawl_FB_ELO001b
				InfoCardId = "FB_ELO001bench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO001c] Confirm (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset all Fireside Gathering Player wins. This will end the current game.
			// --------------------------------------------------------
			cards.Add("FB_ELO001c", new CardDef(new Power
			{
				// TODO [FB_ELO001c] Confirm && Test: Confirm_FB_ELO001c
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO001d] Cancel (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Do NOT reset Fireside Gathering Player wins. Play the Brawl as normal.
			// --------------------------------------------------------
			cards.Add("FB_ELO001d", new CardDef(new Power
			{
				// TODO [FB_ELO001d] Cancel && Test: Cancel_FB_ELO001d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002a] Spirit of Heroism (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the cost of your Hero Power by (1).
			// --------------------------------------------------------
			cards.Add("FB_ELO002a", new CardDef(new Power
			{
				// TODO [FB_ELO002a] Spirit of Heroism && Test: Spirit of Heroism_FB_ELO002a
				InfoCardId = "FB_ELO002a_ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002a_copy] Greater Spirit of Heroism (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Replace your starting Hero Power with a better one. It costs (0).
			// --------------------------------------------------------
			cards.Add("FB_ELO002a_copy", new CardDef(new Power
			{
				// TODO [FB_ELO002a_copy] Greater Spirit of Heroism && Test: Greater Spirit of Heroism_FB_ELO002a_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002b] Spirit of Wisdom (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the Cost of all spells in your deck and hand by (1).
			// --------------------------------------------------------
			cards.Add("FB_ELO002b", new CardDef(new Power
			{
				// TODO [FB_ELO002b] Spirit of Wisdom && Test: Spirit of Wisdom_FB_ELO002b
				InfoCardId = "FB_ELO002b_ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002b_copy] Greater Spirit of Wisdom (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the Cost of all spells in your deck and hand by (2).
			// --------------------------------------------------------
			cards.Add("FB_ELO002b_copy", new CardDef(new Power
			{
				// TODO [FB_ELO002b_copy] Greater Spirit of Wisdom && Test: Greater Spirit of Wisdom_FB_ELO002b_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002c] Spirit of Strength (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give all minions in your deck and hand 
			//       +1 Attack.
			// --------------------------------------------------------
			cards.Add("FB_ELO002c", new CardDef(new Power
			{
				// TODO [FB_ELO002c] Spirit of Strength && Test: Spirit of Strength_FB_ELO002c
				InfoCardId = "FB_ELO002c_ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002c_copy] Greater Spirit of Strength (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give all minions in your deck and hand 
			//       +2 Attack.
			// --------------------------------------------------------
			cards.Add("FB_ELO002c_copy", new CardDef(new Power
			{
				// TODO [FB_ELO002c_copy] Greater Spirit of Strength && Test: Greater Spirit of Strength_FB_ELO002c_copy
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_IKC_SetupNo] Play! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Play the brawl normally.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_IKC_SetupNo", new CardDef(new Power
			{
				// TODO [FB_IKC_SetupNo] Play! && Test: Play!_FB_IKC_SetupNo
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_IKC_SetupYes] Set Up Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Change the Innkeeper's Choice card.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_IKC_SetupYes", new CardDef(new Power
			{
				// TODO [FB_IKC_SetupYes] Set Up Brawl && Test: Set Up Brawl_FB_IKC_SetupYes
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Juggernaut_Bomb_Effect] Bombs Away! (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 1-3 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("FB_Juggernaut_Bomb_Effect", new CardDef(new Power
			{
				// TODO [FB_Juggernaut_Bomb_Effect] Bombs Away! && Test: Bombs Away!_FB_Juggernaut_Bomb_Effect
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LK004] Calling for Backup (*) - COST:10 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Choose the next Hero.
			// --------------------------------------------------------
			cards.Add("FB_LK004", new CardDef(new Power
			{
				// TODO [FB_LK004] Calling for Backup && Test: Calling for Backup_FB_LK004
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LK010] The Final Battle (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Show The Lich King your true form!
			// --------------------------------------------------------
			cards.Add("FB_LK010", new CardDef(new Power
			{
				// TODO [FB_LK010] The Final Battle && Test: The Final Battle_FB_LK010
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LK011] Cancelling the Apocalypse! (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy all minions.
			//       <i>Nice try, Uther!</i>
			// --------------------------------------------------------
			cards.Add("FB_LK011", new CardDef(new Power
			{
				// TODO [FB_LK011] Cancelling the Apocalypse! && Test: Cancelling the Apocalypse!_FB_LK011
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LK_ClearBoard] A New Hero Approaches (*) - COST:10 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy all minions. Drain all Mana.
			// --------------------------------------------------------
			cards.Add("FB_LK_ClearBoard", new CardDef(new Power
			{
				// TODO [FB_LK_ClearBoard] A New Hero Approaches && Test: A New Hero Approaches_FB_LK_ClearBoard
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LK_NewHeroCards] New Hero! (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: A new Hero takes position.
			// --------------------------------------------------------
			cards.Add("FB_LK_NewHeroCards", new CardDef(new Power
			{
				// TODO [FB_LK_NewHeroCards] New Hero! && Test: New Hero!_FB_LK_NewHeroCards
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKDebug001] LK Phase 2 Debug (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Change boss to phase 2
			// --------------------------------------------------------
			cards.Add("FB_LKDebug001", new CardDef(new Power
			{
				// TODO [FB_LKDebug001] LK Phase 2 Debug && Test: LK Phase 2 Debug_FB_LKDebug001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKDebug002] LK Phase 3 Debug (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Change boss to phase 3
			// --------------------------------------------------------
			cards.Add("FB_LKDebug002", new CardDef(new Power
			{
				// TODO [FB_LKDebug002] LK Phase 3 Debug && Test: LK Phase 3 Debug_FB_LKDebug002
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats001a] Fight the Lich King! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Continue playing normally.
			// --------------------------------------------------------
			cards.Add("FB_LKStats001a", new CardDef(new Power
			{
				// TODO [FB_LKStats001a] Fight the Lich King! && Test: Fight the Lich King!_FB_LKStats001a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats001d] Modify the Lich King (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Change Health, Assign Modifiers.
			// --------------------------------------------------------
			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
			// --------------------------------------------------------
			cards.Add("FB_LKStats001d", new CardDef(new[] {"FB_LKStats002a","FB_LKStats002b","FB_LKStats002c"}, new Power
			{
				// TODO [FB_LKStats001d] Modify the Lich King && Test: Modify the Lich King_FB_LKStats001d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats002] Lich King Modifications (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increase or Decrease the maximum health of the Lich King.
			// --------------------------------------------------------
			cards.Add("FB_LKStats002", new CardDef(new Power
			{
				// TODO [FB_LKStats002] Lich King Modifications && Test: Lich King Modifications_FB_LKStats002
				InfoCardId = "FB_LKStats002ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats002a] Increase Health (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increase the Lich King's maximum health by 10%.
			// --------------------------------------------------------
			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
			// --------------------------------------------------------
			cards.Add("FB_LKStats002a", new CardDef(new[] {"FB_LKStats002a","FB_LKStats002b","FB_LKStats002c"}, new Power
			{
				// TODO [FB_LKStats002a] Increase Health && Test: Increase Health_FB_LKStats002a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats002b] Decrease Health (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Decrease the Lich King's maximum health by 10%
			// --------------------------------------------------------
			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
			// --------------------------------------------------------
			cards.Add("FB_LKStats002b", new CardDef(new[] {"FB_LKStats002a","FB_LKStats002b","FB_LKStats002c"}, new Power
			{
				// TODO [FB_LKStats002b] Decrease Health && Test: Decrease Health_FB_LKStats002b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats002c] Modifications Complete (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Lock in the new maximum health. This will end the setup phase.
			// --------------------------------------------------------
			// Entourage: FB_LKStats001a, 00000011-f9e0-4b0b-852d-9f932641109f
			// --------------------------------------------------------
			cards.Add("FB_LKStats002c", new CardDef(new[] {"FB_LKStats001a","00000011-f9e0-4b0b-852d-9f932641109f"}, new Power
			{
				// TODO [FB_LKStats002c] Modifications Complete && Test: Modifications Complete_FB_LKStats002c
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_RagRaid_Amulet] Amulet of Domination (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Take control of an enemy minion. Add it to your Dungeon Deck.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("FB_RagRaid_Amulet", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [FB_RagRaid_Amulet] Amulet of Domination && Test: Amulet of Domination_FB_RagRaid_Amulet
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_RagRaid_InnkeeperReset] TOO SOON! (*) - COST:0 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Summon Big Bad Ragnaros again, he will start at 15000 health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("FB_RagRaid_InnkeeperReset", new CardDef(new Power
			{
				// TODO [FB_RagRaid_InnkeeperReset] TOO SOON! && Test: TOO SOON!_FB_RagRaid_InnkeeperReset
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_RagRaid_ResetCancel] Cancel (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Don't reset Big Bad Ragnaros' health. Will end the game.
			// --------------------------------------------------------
			cards.Add("FB_RagRaid_ResetCancel", new CardDef(new Power
			{
				// TODO [FB_RagRaid_ResetCancel] Cancel && Test: Cancel_FB_RagRaid_ResetCancel
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Toki_AttackPlayers] Timeline Collision (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Deal Attack damage to each Hero.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("FB_Toki_AttackPlayers", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [FB_Toki_AttackPlayers] Timeline Collision && Test: Timeline Collision_FB_Toki_AttackPlayers
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Toki_BossSpell_01] Time Bubble (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Gain <b><b>Divine Shield</b>.</b>
			//       If you already have it, then cast Timely Blast.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// - BOSS = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_BossSpell_01", new CardDef(new Power
			{
				// TODO [FB_Toki_BossSpell_01] Time Bubble && Test: Time Bubble_FB_Toki_BossSpell_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Toki_do_auto] Timely Blast (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Deal damage equal to this minion's Attack to characters opposite it.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_do_auto", new CardDef(new Power
			{
				// TODO [FB_Toki_do_auto] Timely Blast && Test: Timely Blast_FB_Toki_do_auto
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Toki_IncreaseHealth] Augment (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Give all Anomalies +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_IncreaseHealth", new CardDef(new Power
			{
				// TODO [FB_Toki_IncreaseHealth] Augment && Test: Augment_FB_Toki_IncreaseHealth
				InfoCardId = "FB_Toki_IncreaseHealthEnch",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Toki_ManaPortal] Future Investment (*) - COST:5 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Cards in your hand, and next game's starting hand, cost (0).
			// --------------------------------------------------------
			cards.Add("FB_Toki_ManaPortal", new CardDef(new Power
			{
				// TODO [FB_Toki_ManaPortal] Future Investment && Test: Future Investment_FB_Toki_ManaPortal
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Toki_ManaPortal2] Exercising Options (*) - COST:1 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Your starting hand's cards all cost (0).
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_ManaPortal2", new CardDef(new Power
			{
				// TODO [FB_Toki_ManaPortal2] Exercising Options && Test: Exercising Options_FB_Toki_ManaPortal2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Toki_SummonParadoxes] Pair of Paradoxes (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Summon two 2/3 Paradoxes.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_Toki_SummonParadoxes", new CardDef(new Power
			{
				// TODO [FB_Toki_SummonParadoxes] Pair of Paradoxes && Test: Pair of Paradoxes_FB_Toki_SummonParadoxes
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Toki_TimePortal] Portal to the Future! (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Copy a minion. Fill next game's starting hand with it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("FB_Toki_TimePortal", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [FB_Toki_TimePortal] Portal to the Future! && Test: Portal to the Future!_FB_Toki_TimePortal
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Toki_TimePortal_Reload] Portal FROM the Future! (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Fill your hand with copies of last game's minion.
			// --------------------------------------------------------
			cards.Add("FB_Toki_TimePortal_Reload", new CardDef(new Power
			{
				// TODO [FB_Toki_TimePortal_Reload] Portal FROM the Future! && Test: Portal FROM the Future!_FB_Toki_TimePortal_Reload
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Toki_TimePortalSpell] Arrownado! (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Deal damage equal to the Anomaly's Attack to all other minions.
			// --------------------------------------------------------
			cards.Add("FB_Toki_TimePortalSpell", new CardDef(new Power
			{
				// TODO [FB_Toki_TimePortalSpell] Arrownado! && Test: Arrownado!_FB_Toki_TimePortalSpell
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_TopX_Mystery] The Mystery Card (*) - COST:0 
			// - Fac: neutral, Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: Choose your opponent's hidden fourth card.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_TopX_Mystery", new CardDef(new Power
			{
				// TODO [FB_TopX_Mystery] The Mystery Card && Test: The Mystery Card_FB_TopX_Mystery
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [NAX12_02H_2c_TB] Decimate (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Change the Health of enemy minions to 1.
			// --------------------------------------------------------
			cards.Add("NAX12_02H_2c_TB", new CardDef(new Power
			{
				// TODO [NAX12_02H_2c_TB] Decimate && Test: Decimate_NAX12_02H_2c_TB
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_006", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [TB_006] Big Banana && Test: Big Banana_TB_006
				InfoCardId = "TB_006e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_007", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [TB_007] Deviate Banana && Test: Deviate Banana_TB_007
				InfoCardId = "TB_007e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_008", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [TB_008] Rotten Banana && Test: Rotten Banana_TB_008
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_011] Tarnished Coin (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			cards.Add("TB_011", new CardDef(new Power
			{
				// TODO [TB_011] Tarnished Coin && Test: Tarnished Coin_TB_011
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_012] Choose a New Card! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Look at 3 random cards. Choose one and shuffle it into your deck.
			// --------------------------------------------------------
			cards.Add("TB_012", new CardDef(new Power
			{
				// TODO [TB_012] Choose a New Card! && Test: Choose a New Card!_TB_012
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_014] Choose a New Card! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Look at 3 random cards. Choose one and put it into your hand.
			// --------------------------------------------------------
			cards.Add("TB_014", new CardDef(new Power
			{
				// TODO [TB_014] Choose a New Card! && Test: Choose a New Card!_TB_014
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_207CatacombQ] Journey to the Catacombs (*) - COST:1 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Play 4 minions.
			//       <b>Reward:</b> Master Chest!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - ImmuneToSpellpower = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 4
			// - 676 = 1
			// - QUEST_REWARD_DATABASE_ID = 56192
			// --------------------------------------------------------
			cards.Add("TB_207CatacombQ", new CardDef(new Power
			{
				// TODO [TB_207CatacombQ] Journey to the Catacombs && Test: Journey to the Catacombs_TB_207CatacombQ
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_3Wishes_Spell] First Wish (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Wish for the perfect card. Shuffle a Second Wish into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_3Wishes_Spell", new CardDef(new Power
			{
				// TODO [TB_3Wishes_Spell] First Wish && Test: First Wish_TB_3Wishes_Spell
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_3Wishes_Spell_2] Second Wish (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Wish for the perfect card. Shuffle a Third (and final) Wish into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("TB_3Wishes_Spell_2", new CardDef(new Power
			{
				// TODO [TB_3Wishes_Spell_2] Second Wish && Test: Second Wish_TB_3Wishes_Spell_2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_3Wishes_Spell_3] Third Wish (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Wish for the perfect card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_3Wishes_Spell_3", new CardDef(new Power
			{
				// TODO [TB_3Wishes_Spell_3] Third Wish && Test: Third Wish_TB_3Wishes_Spell_3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_ArchivistSpell] Archivist Spell - Not Player Facing (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_ArchivistSpell", new CardDef(new Power
			{
				// TODO [TB_ArchivistSpell] Archivist Spell - Not Player Facing && Test: Archivist Spell - Not Player Facing_TB_ArchivistSpell
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_BuildSeededDeck] Build a seeded deck please! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Build a Deck!
			// --------------------------------------------------------
			cards.Add("TB_BuildSeededDeck", new CardDef(new Power
			{
				// TODO [TB_BuildSeededDeck] Build a seeded deck please! && Test: Build a seeded deck please!_TB_BuildSeededDeck
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_BuildStarterDeck] Build a Dungeon Run starter deck please! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Build a Deck!
			// --------------------------------------------------------
			cards.Add("TB_BuildStarterDeck", new CardDef(new Power
			{
				// TODO [TB_BuildStarterDeck] Build a Dungeon Run starter deck please! && Test: Build a Dungeon Run starter deck please!_TB_BuildStarterDeck
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Carousel_SpellA] Carousel Spell A - Not Player Facing (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Rotate Minions
			// --------------------------------------------------------
			cards.Add("TB_Carousel_SpellA", new CardDef(new Power
			{
				// TODO [TB_Carousel_SpellA] Carousel Spell A - Not Player Facing && Test: Carousel Spell A - Not Player Facing_TB_Carousel_SpellA
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Carousel_SpellB] Carousel Spell B - Not Player Facing (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Rotate Minions
			// --------------------------------------------------------
			cards.Add("TB_Carousel_SpellB", new CardDef(new Power
			{
				// TODO [TB_Carousel_SpellB] Carousel Spell B - Not Player Facing && Test: Carousel Spell B - Not Player Facing_TB_Carousel_SpellB
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Champs_GetChampsDeckID] Get Champs DeckID (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset Your Deck
			// --------------------------------------------------------
			cards.Add("TB_Champs_GetChampsDeckID", new CardDef(new Power
			{
				// TODO [TB_Champs_GetChampsDeckID] Get Champs DeckID && Test: Get Champs DeckID_TB_Champs_GetChampsDeckID
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Champs_KeepWinnerDeck_Reset] Reset Decks (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Everyone gets a new deck, next game.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_Champs_KeepWinnerDeck_Reset", new CardDef(new Power
			{
				// TODO [TB_Champs_KeepWinnerDeck_Reset] Reset Decks && Test: Reset Decks_TB_Champs_KeepWinnerDeck_Reset
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_ckBuildDeck_Dalaran] Build a Deck Please! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Build a Deck!
			// --------------------------------------------------------
			cards.Add("TB_ckBuildDeck_Dalaran", new CardDef(new Power
			{
				// TODO [TB_ckBuildDeck_Dalaran] Build a Deck Please! && Test: Build a Deck Please!_TB_ckBuildDeck_Dalaran
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_1] Prioritize (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal Attack damage to biggest minion.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_1", new CardDef(new Power
			{
				// TODO [TB_CoOpBossSpell_1] Prioritize && Test: Prioritize_TB_CoOpBossSpell_1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_2] Bomb Salvo (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal Attack damage to up to 3 random targets.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_2", new CardDef(new Power
			{
				// TODO [TB_CoOpBossSpell_2] Bomb Salvo && Test: Bomb Salvo_TB_CoOpBossSpell_2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_3] Release Coolant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Freeze and deal Attack damage to all minions.
			//       Gain 2 Attack.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_3", new CardDef(new Power
			{
				// TODO [TB_CoOpBossSpell_3] Release Coolant && Test: Release Coolant_TB_CoOpBossSpell_3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_4] Overclock (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Gain 2 Attack.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_4", new CardDef(new Power
			{
				// TODO [TB_CoOpBossSpell_4] Overclock && Test: Overclock_TB_CoOpBossSpell_4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_5] Double Zap (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal Attack damage to both players.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_5", new CardDef(new Power
			{
				// TODO [TB_CoOpBossSpell_5] Double Zap && Test: Double Zap_TB_CoOpBossSpell_5
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_6] Kill the Lorewalker (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy Lorewalker Cho.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_6", new CardDef(new Power
			{
				// TODO [TB_CoOpBossSpell_6] Kill the Lorewalker && Test: Kill the Lorewalker_TB_CoOpBossSpell_6
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoopHero_002] Power (Spell) (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Armies!!
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2379
			// --------------------------------------------------------
			cards.Add("TB_CoopHero_002", new CardDef(new Power
			{
				// TODO [TB_CoopHero_002] Power (Spell) && Test: Power (Spell)_TB_CoopHero_002
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_001] Glorious Finale (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The true battle begins....
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_001", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_001] Glorious Finale && Test: Glorious Finale_TB_CoOpv3_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_003] Bamboozle (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Swap player's hands.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_003", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_003] Bamboozle && Test: Bamboozle_TB_CoOpv3_003
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_004] Cleave (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 7 damage to a minion and its owner.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_004", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_004] Cleave && Test: Cleave_TB_CoOpv3_004
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_005] Cleave (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 4 damage to a minion and its owner.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_005", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_005] Cleave && Test: Cleave_TB_CoOpv3_005
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_007] Flame Missiles (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 5 damage randomly split among all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_007", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_007] Flame Missiles && Test: Flame Missiles_TB_CoOpv3_007
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_008] Flame Missiles (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 10 damage randomly split among all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_008", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_008] Flame Missiles && Test: Flame Missiles_TB_CoOpv3_008
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_009] Explosive Rune (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon an 'Explosive Rune.'
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_009", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_009] Explosive Rune && Test: Explosive Rune_TB_CoOpv3_009
				InfoCardId = "TB_CoOpv3_009e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_010] Explosive Runes (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon two 'Explosive Runes.'
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_010", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_010] Explosive Runes && Test: Explosive Runes_TB_CoOpv3_010
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_011] Don't Push Me! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: He's getting angry....
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_011", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_011] Don't Push Me! && Test: Don't Push Me!_TB_CoOpv3_011
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_012] Immolate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 4 damage to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_012", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_012] Immolate && Test: Immolate_TB_CoOpv3_012
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_013] Immolate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 7 damage to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_013", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_013] Immolate && Test: Immolate_TB_CoOpv3_013
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_202] Vicious Swipe (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal attack damage to 2 random minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_202", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_202] Vicious Swipe && Test: Vicious Swipe_TB_CoOpv3_202
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_203] Meddling Fool! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Damage the Lorewalker
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_203", new CardDef(new Power
			{
				// TODO [TB_CoOpv3_203] Meddling Fool! && Test: Meddling Fool!_TB_CoOpv3_203
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_DiscoverMyDeck_Discovery] Peruse (*) - COST:1 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a card from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TB_DiscoverMyDeck_Discovery", new CardDef(new Power
			{
				// TODO [TB_DiscoverMyDeck_Discovery] Peruse && Test: Peruse_TB_DiscoverMyDeck_Discovery
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_DoubleMinions_spell] Double Minions Spell (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_DoubleMinions_spell", new CardDef(new Power
			{
				// TODO [TB_DoubleMinions_spell] Double Minions Spell && Test: Double Minions Spell_TB_DoubleMinions_spell
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_EVILBRM_LOOTA_805] Amulet of Domination (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Take control of an enemy minion. Add it to your Dungeon Deck.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_LOOTA_805", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [TB_EVILBRM_LOOTA_805] Amulet of Domination && Test: Amulet of Domination_TB_EVILBRM_LOOTA_805
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_EVILBRM_LOOTA_813] Magic Mirror (*) - COST:1 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Choose a minion and summon a copy of it. Add it to your Dungeon_Deck.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("TB_EVILBRM_LOOTA_813", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [TB_EVILBRM_LOOTA_813] Magic Mirror && Test: Magic Mirror_TB_EVILBRM_LOOTA_813
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Firefest2_001] MELT! (*) - COST:4 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 1 damage to all minions. Unfreeze them.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 1004
			// --------------------------------------------------------
			cards.Add("TB_Firefest2_001", new CardDef(new Power
			{
				// TODO [TB_Firefest2_001] MELT! && Test: MELT!_TB_Firefest2_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Firefest2_002] FREEZE, INSECT! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 4 damage to a random minion and <b>Freeze</b> it.
			// --------------------------------------------------------
			cards.Add("TB_Firefest2_002", new CardDef(new Power
			{
				// TODO [TB_Firefest2_002] FREEZE, INSECT! && Test: FREEZE, INSECT!_TB_Firefest2_002
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Firefest2a] Move Over! (Ahune 1st) (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a different Frozen Throne boss.
			//        <i> You aren't worth the Lich King's time.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_Firefest2a", new CardDef(new Power
			{
				// TODO [TB_Firefest2a] Move Over! (Ahune 1st) && Test: Move Over! (Ahune 1st)_TB_Firefest2a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Firefest2b] Move Over! (Ahune to Ragnaros) (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a different Frozen Throne boss.
			//        <i> You aren't worth the Lich King's time.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_Firefest2b", new CardDef(new Power
			{
				// TODO [TB_Firefest2b] Move Over! (Ahune to Ragnaros) && Test: Move Over! (Ahune to Ragnaros)_TB_Firefest2b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Firefest2c] Move Over! (Ragnaros to Ahune) (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a different Frozen Throne boss.
			//        <i> You aren't worth the Lich King's time.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_Firefest2c", new CardDef(new Power
			{
				// TODO [TB_Firefest2c] Move Over! (Ragnaros to Ahune) && Test: Move Over! (Ragnaros to Ahune)_TB_Firefest2c
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Firefest2d] Move Over! (Ragnaros fully replaces Ahune) (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a different Frozen Throne boss.
			//        <i> You aren't worth the Lich King's time.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_Firefest2d", new CardDef(new Power
			{
				// TODO [TB_Firefest2d] Move Over! (Ragnaros fully replaces Ahune) && Test: Move Over! (Ragnaros fully replaces Ahune)_TB_Firefest2d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_FoxBlessing] Blessing of the Raven (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each minion summoned gains either <b>Lifesteal</b>, <b>Poisonous</b>, <b>Stealth</b>, <b>Charge</b> or <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing", new CardDef(new Power
			{
				// TODO [TB_FoxBlessing] Blessing of the Raven && Test: Blessing of the Raven_TB_FoxBlessing
				InfoCardId = "TB_FoxBlessing1",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_GiftExchange_Snowball] Hardpacked Snowballs (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Return 3 random enemy minions to your opponent's hand.
			// --------------------------------------------------------
			cards.Add("TB_GiftExchange_Snowball", new CardDef(new Power
			{
				// TODO [TB_GiftExchange_Snowball] Hardpacked Snowballs && Test: Hardpacked Snowballs_TB_GiftExchange_Snowball
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_GiftExchange_Treasure_Spell] Stolen Winter Veil Gift (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a random Treasure. Its cost is reduced.
			// --------------------------------------------------------
			// GameTag:
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TB_GiftExchange_Treasure_Spell", new CardDef(new Power
			{
				// TODO [TB_GiftExchange_Treasure_Spell] Stolen Winter Veil Gift && Test: Stolen Winter Veil Gift_TB_GiftExchange_Treasure_Spell
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_GiftReceiptSpell] Gift Receipt (*) - COST:5 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Refresh your Mana Crystals. Swap decks with your_opponent and destroy their Gift Receipt.
			// --------------------------------------------------------
			cards.Add("TB_GiftReceiptSpell", new CardDef(new Power
			{
				// TODO [TB_GiftReceiptSpell] Gift Receipt && Test: Gift Receipt_TB_GiftReceiptSpell
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_GiftReceiptSpell_Start] Happy Winter Veil! (*) - COST:5 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Gift your deck to your opponent, include a Gift Receipt.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_GiftReceiptSpell_Start", new CardDef(new Power
			{
				// TODO [TB_GiftReceiptSpell_Start] Happy Winter Veil! && Test: Happy Winter Veil!_TB_GiftReceiptSpell_Start
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_s001a] Witch Costume (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Dress up as a Witch. Draw a new hand.
			// --------------------------------------------------------
			// Entourage: EX1_246, CFM_603, LOE_046, LOE_115, KAR_300, OG_179, CS2_013, EX1_277, GVG_001, CS2_023, UNG_948, OG_090, CFM_661, DS1_233, CS2_234, UNG_029, ICC_802, CS2_053
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_s001a", new CardDef(new[] {"EX1_246","CFM_603","LOE_046","LOE_115","KAR_300","OG_179","CS2_013","EX1_277","GVG_001","CS2_023","UNG_948","OG_090","CFM_661","DS1_233","CS2_234","UNG_029","ICC_802","CS2_053"}, new Power
			{
				// TODO [TB_HeadlessHorseman_s001a] Witch Costume && Test: Witch Costume_TB_HeadlessHorseman_s001a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_s001b] Cat Costume (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Dress up as a Cat.
			//       Draw a new hand.
			// --------------------------------------------------------
			// Entourage: CFM_315, GVG_034, EX1_165, KAR_004, KARA_05_02, CS2_005, UNG_910, EX1_570, AT_042, UNG_812, GVG_046, NAX15_05, KARA_07_05heroic, EX1_028, EX1_534, ICC_079, CS2_011, CS2_012
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_s001b", new CardDef(new[] {"CFM_315","GVG_034","EX1_165","KAR_004","KARA_05_02","CS2_005","UNG_910","EX1_570","AT_042","UNG_812","GVG_046","NAX15_05","KARA_07_05heroic","EX1_028","EX1_534","ICC_079","CS2_011","CS2_012"}, new Power
			{
				// TODO [TB_HeadlessHorseman_s001b] Cat Costume && Test: Cat Costume_TB_HeadlessHorseman_s001b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_s001c] Pirate Costume (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Dress up as a Pirate. Draw a new hand.
			// --------------------------------------------------------
			// Entourage: CFM_637, GVG_075, GVG_075, NEW1_027, NEW1_027, OG_315, OG_315, AT_070, GVG_025, GVG_025, AT_032, AT_032, CS2_106, ICC_018, OG_312, CS2_080, EX1_133
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_s001c", new CardDef(new[] {"CFM_637","GVG_075","GVG_075","NEW1_027","NEW1_027","OG_315","OG_315","AT_070","GVG_025","GVG_025","AT_032","AT_032","CS2_106","ICC_018","OG_312","CS2_080","EX1_133"}, new Power
			{
				// TODO [TB_HeadlessHorseman_s001c] Pirate Costume && Test: Pirate Costume_TB_HeadlessHorseman_s001c
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_s001d] Mummy Costume (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Dress up as a Mummy. Draw a new hand.
			// --------------------------------------------------------
			// Entourage: EX1_246, CFM_603, LOE_046, LOE_115, KAR_300, OG_179, CS2_013, EX1_277, GVG_001, CS2_023, UNG_948, OG_090, CFM_661, DS1_233, CS2_234, UNG_029, ICC_802, CS2_053
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_s001d", new CardDef(new[] {"EX1_246","CFM_603","LOE_046","LOE_115","KAR_300","OG_179","CS2_013","EX1_277","GVG_001","CS2_023","UNG_948","OG_090","CFM_661","DS1_233","CS2_234","UNG_029","ICC_802","CS2_053"}, new Power
			{
				// TODO [TB_HeadlessHorseman_s001d] Mummy Costume && Test: Mummy Costume_TB_HeadlessHorseman_s001d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_s004] Fiery Burst (*) - COST:3 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 2 damage to all enemies.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_s004", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_s004] Fiery Burst && Test: Fiery Burst_TB_HeadlessHorseman_s004
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_s005] Fear (*) - COST:7 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy all enemy minions with 4 or less Attack.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_s005", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_s005] Fear && Test: Fear_TB_HeadlessHorseman_s005
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_XXX] Create Horseman (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your hero becomes the Horseman. Cast again to become the 2nd form.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_XXX", new CardDef(new Power
			{
				// TODO [TB_HeadlessHorseman_XXX] Create Horseman && Test: Create Horseman_TB_HeadlessHorseman_XXX
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Henchmania_DiscoverA] Work for Hagatha (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn transform a random friendly minion into
			//       one that costs (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_DiscoverA", new CardDef(new Power
			{
				// TODO [TB_Henchmania_DiscoverA] Work for Hagatha && Test: Work for Hagatha_TB_Henchmania_DiscoverA
				InfoCardId = "TB_Henchmania_DiscoverAe",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Henchmania_DiscoverB] Work for Dr. Boom (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give all friendly minions <b>Deathrattle:</b> Deal 1-2 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_DiscoverB", new CardDef(new Power
			{
				// TODO [TB_Henchmania_DiscoverB] Work for Dr. Boom && Test: Work for Dr. Boom_TB_Henchmania_DiscoverB
				InfoCardId = "TB_Henchmania_DiscoverBe",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Henchmania_DiscoverC] Work for Togwaggle (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you play a Minion add a Coin to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_DiscoverC", new CardDef(new Power
			{
				// TODO [TB_Henchmania_DiscoverC] Work for Togwaggle && Test: Work for Togwaggle_TB_Henchmania_DiscoverC
				InfoCardId = "TB_Henchmania_DiscoverCe",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Henchmania_DiscoverD] Work for Madame Lazul (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you play a spell, gain a copy of a random card in your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_Henchmania_DiscoverD", new CardDef(new Power
			{
				// TODO [TB_Henchmania_DiscoverD] Work for Madame Lazul && Test: Work for Madame Lazul_TB_Henchmania_DiscoverD
				InfoCardId = "TB_Henchmania_DiscoverDe",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_KaraPortal_001] Party Portal! (*) - COST:3 
			// - Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Summon a random Partygoer.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TB_KaraPortal_001", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [TB_KaraPortal_001] Party Portal! && Test: Party Portal!_TB_KaraPortal_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_KaraPortal_002] Call Mediva (*) - COST:2 
			// - Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Summon a random Mediva
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TB_KaraPortal_002", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [TB_KaraPortal_002] Call Mediva && Test: Call Mediva_TB_KaraPortal_002
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_KoboldGiftSpell] Great Father Kobold Spell (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_KoboldGiftSpell", new CardDef(new Power
			{
				// TODO [TB_KoboldGiftSpell] Great Father Kobold Spell && Test: Great Father Kobold Spell_TB_KoboldGiftSpell
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_KTRAF_101", new CardDef(new[] {"TB_KTRAF_1","TB_KTRAF_3","TB_KTRAF_4","TB_KTRAF_5","TB_KTRAF_6","TB_KTRAF_7","TB_KTRAF_8","TB_KTRAF_2","TB_KTRAF_10","TB_KTRAF_12","TB_KTRAF_11"}, new Power
			{
				// TODO [TB_KTRAF_101] Darkness Calls && Test: Darkness Calls_TB_KTRAF_101
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_KTRAF_104] Uncover Staff Piece (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add another piece to your Hero Power.
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_104", new CardDef(new Power
			{
				// TODO [TB_KTRAF_104] Uncover Staff Piece && Test: Uncover Staff Piece_TB_KTRAF_104
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_LEAGUE_REVIVAL_FinleySwap] Move Over! (Finley Swaps in) NOT PLAYER FACING (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_LEAGUE_REVIVAL_FinleySwap", new CardDef(new Power
			{
				// TODO [TB_LEAGUE_REVIVAL_FinleySwap] Move Over! (Finley Swaps in) NOT PLAYER FACING && Test: Move Over! (Finley Swaps in) NOT PLAYER FACING_TB_LEAGUE_REVIVAL_FinleySwap
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal002] Puzzle 1 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Seems simple enough.
			// --------------------------------------------------------
			cards.Add("TB_Lethal002", new CardDef(new Power
			{
				// TODO [TB_Lethal002] Puzzle 1 && Test: Puzzle 1_TB_Lethal002
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal003] Puzzle 2 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Survival percentage is 32.33 repeating of course.
			// --------------------------------------------------------
			cards.Add("TB_Lethal003", new CardDef(new Power
			{
				// TODO [TB_Lethal003] Puzzle 2 && Test: Puzzle 2_TB_Lethal003
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal004] Puzzle 5 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Go Go Malygos!
			// --------------------------------------------------------
			cards.Add("TB_Lethal004", new CardDef(new Power
			{
				// TODO [TB_Lethal004] Puzzle 5 && Test: Puzzle 5_TB_Lethal004
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal005] Puzzle 6 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Heal em to death!
			// --------------------------------------------------------
			cards.Add("TB_Lethal005", new CardDef(new Power
			{
				// TODO [TB_Lethal005] Puzzle 6 && Test: Puzzle 6_TB_Lethal005
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal006] Puzzle 7 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: An inspiration to totems everywhere!
			// --------------------------------------------------------
			cards.Add("TB_Lethal006", new CardDef(new Power
			{
				// TODO [TB_Lethal006] Puzzle 7 && Test: Puzzle 7_TB_Lethal006
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal007] Puzzle 3 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: BY PUZZLE BE PURGED!
			// --------------------------------------------------------
			cards.Add("TB_Lethal007", new CardDef(new Power
			{
				// TODO [TB_Lethal007] Puzzle 3 && Test: Puzzle 3_TB_Lethal007
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal008] Puzzle 9 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: What!? This again?
			// --------------------------------------------------------
			cards.Add("TB_Lethal008", new CardDef(new Power
			{
				// TODO [TB_Lethal008] Puzzle 9 && Test: Puzzle 9_TB_Lethal008
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal009] Puzzle 4 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Beasts, Beasts and more Beasts!
			// --------------------------------------------------------
			cards.Add("TB_Lethal009", new CardDef(new Power
			{
				// TODO [TB_Lethal009] Puzzle 4 && Test: Puzzle 4_TB_Lethal009
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal010] Puzzle 8 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: A chilly challenge!
			// --------------------------------------------------------
			cards.Add("TB_Lethal010", new CardDef(new Power
			{
				// TODO [TB_Lethal010] Puzzle 8 && Test: Puzzle 8_TB_Lethal010
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_LethalSetup001a] Continue (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Continue from where you left off.
			// --------------------------------------------------------
			cards.Add("TB_LethalSetup001a", new CardDef(new Power
			{
				// TODO [TB_LethalSetup001a] Continue && Test: Continue_TB_LethalSetup001a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_LethalSetup001b] Restart (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Start again at the beginning.
			// --------------------------------------------------------
			cards.Add("TB_LethalSetup001b", new CardDef(new Power
			{
				// TODO [TB_LethalSetup001b] Restart && Test: Restart_TB_LethalSetup001b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_301] Rock Candy (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy a random Party Crasher.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_301", new CardDef(new Power
			{
				// TODO [TB_MammothParty_301] Rock Candy && Test: Rock Candy_TB_MammothParty_301
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_302] Regenerative Cookies (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Restore 4 Health to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_302", new CardDef(new Power
			{
				// TODO [TB_MammothParty_302] Regenerative Cookies && Test: Regenerative Cookies_TB_MammothParty_302
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_303] Divine Sweets (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each player draws a card.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_303", new CardDef(new Power
			{
				// TODO [TB_MammothParty_303] Divine Sweets && Test: Divine Sweets_TB_MammothParty_303
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_s004] Something in the Punch (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 2 damage to all minions other than Party Crashers.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s004", new CardDef(new Power
			{
				// TODO [TB_MammothParty_s004] Something in the Punch && Test: Something in the Punch_TB_MammothParty_s004
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_s101] Party Supplies (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Choose One - </b> Destroy a random Party Crasher; or Each player draws a card.
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s101", new CardDef(new Power
			{
				// TODO [TB_MammothParty_s101] Party Supplies && Test: Party Supplies_TB_MammothParty_s101
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_s101a] Fruit Plate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each player draws a card.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s101a", new CardDef(new Power
			{
				// TODO [TB_MammothParty_s101a] Fruit Plate && Test: Fruit Plate_TB_MammothParty_s101a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_s101b] Like a Sore Thumb (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy a random Party Crasher.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s101b", new CardDef(new Power
			{
				// TODO [TB_MammothParty_s101b] Like a Sore Thumb && Test: Like a Sore Thumb_TB_MammothParty_s101b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_s998] Noise Complaint (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: If the board opposing the <b>Boss</b> is full, destroy all those minions.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s998", new CardDef(new Power
			{
				// TODO [TB_MammothParty_s998] Noise Complaint && Test: Noise Complaint_TB_MammothParty_s998
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - QUEST_REWARD_DATABASE_ID = 45999
			// --------------------------------------------------------
			cards.Add("TB_Marin_001", new CardDef(new Power
			{
				// TODO [TB_Marin_001] Journey to the Catacombs && Test: Journey to the Catacombs_TB_Marin_001
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Noblegarden_003", new CardDef(new[] {"TB_Noblegarden_003t1","TB_Noblegarden_003t7","TB_Noblegarden_003t3","TB_Noblegarden_003t5","TB_Noblegarden_003t2","TB_Noblegarden_003t4","TB_Noblegarden_003t6","TB_Noblegarden_003t8"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_CANNOT_PLAY_THIS,0}}, new Power
			{
				// TODO [TB_Noblegarden_003] Shifting Dye && Test: Shifting Dye_TB_Noblegarden_003
				InfoCardId = "TB_Noblegarden_003e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Noblegarden_003t1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_WITH_RACE,38}}, new Power
			{
				// TODO [TB_Noblegarden_003t1] Blue Shifting Dye && Test: Blue Shifting Dye_TB_Noblegarden_003t1
				InfoCardId = "TB_Noblegarden_003t1e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Noblegarden_003t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_WITH_RACE,38}}, new Power
			{
				// TODO [TB_Noblegarden_003t2] Purple Shifting Dye && Test: Purple Shifting Dye_TB_Noblegarden_003t2
				InfoCardId = "TB_Noblegarden_003t2e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Noblegarden_003t3", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_WITH_RACE,38}}, new Power
			{
				// TODO [TB_Noblegarden_003t3] Green Shifting Dye && Test: Green Shifting Dye_TB_Noblegarden_003t3
				InfoCardId = "TB_Noblegarden_003t3e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Noblegarden_003t4", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_WITH_RACE,38}}, new Power
			{
				// TODO [TB_Noblegarden_003t4] Silver Shifting Dye && Test: Silver Shifting Dye_TB_Noblegarden_003t4
				InfoCardId = "TB_Noblegarden_003t4e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Noblegarden_003t5", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_WITH_RACE,38}}, new Power
			{
				// TODO [TB_Noblegarden_003t5] Orange Shifting Dye && Test: Orange Shifting Dye_TB_Noblegarden_003t5
				InfoCardId = "TB_Noblegarden_003t5e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Noblegarden_003t6", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_WITH_RACE,38}}, new Power
			{
				// TODO [TB_Noblegarden_003t6] Pink Shifting Dye && Test: Pink Shifting Dye_TB_Noblegarden_003t6
				InfoCardId = "TB_Noblegarden_003t6e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Noblegarden_003t7", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_WITH_RACE,38}}, new Power
			{
				// TODO [TB_Noblegarden_003t7] Gold Shifting Dye && Test: Gold Shifting Dye_TB_Noblegarden_003t7
				InfoCardId = "TB_Noblegarden_003t7e",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Noblegarden_003t8", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_WITH_RACE,38}}, new Power
			{
				// TODO [TB_Noblegarden_003t8] Red Shifting Dye && Test: Red Shifting Dye_TB_Noblegarden_003t8
				InfoCardId = "TB_Noblegarden_003t8e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_004] Noblegarden Spoon (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Hatch your Noblegarden Eggs!
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_004", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_004] Noblegarden Spoon && Test: Noblegarden Spoon_TB_Noblegarden_004
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_005] Carrots (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give friendly minions +1/+1 or +2/+2 if it's a <b>Bunny</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_005", new CardDef(new Power
			{
				// TODO [TB_Noblegarden_005] Carrots && Test: Carrots_TB_Noblegarden_005
				InfoCardId = "TB_Noblegarden_005e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_1] Dire Fate: Taunt and Charge (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All minions have <b>Taunt</b> and <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_1", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_1] Dire Fate: Taunt and Charge && Test: Dire Fate: Taunt and Charge_TB_PickYourFate_1
				InfoCardId = "TB_PickYourFate_10_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_10] Battlecry Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your <b>Battlecry</b> minions have +1/+1.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_10", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_10] Battlecry Bonus && Test: Battlecry Bonus_TB_PickYourFate_10
				InfoCardId = "TB_PickYourFate_10_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_11b] Murloc Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a 1/1 Murloc at the end of your turn.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_11b", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_11b] Murloc Bonus && Test: Murloc Bonus_TB_PickYourFate_11b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_11rand] Dire Fate: Murlocs (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Turn each minion in play into a 1/1 Murloc.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_11rand", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_11rand] Dire Fate: Murlocs && Test: Dire Fate: Murlocs_TB_PickYourFate_11rand
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_12] Fate: Confusion (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of each turn, swap all minions' Attack and Health.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_12", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_12] Fate: Confusion && Test: Fate: Confusion_TB_PickYourFate_12
				InfoCardId = "TB_PickYourFate_12_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_2] Fate: Bananas (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: When a minion dies, its owner gets a (1) mana Banana.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_2", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_2] Fate: Bananas && Test: Fate: Bananas_TB_PickYourFate_2
				InfoCardId = "TB_PickYourFate_2_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_3] Dire Fate: Windfury (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All minions have <b>Windfury</b>.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_3", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_3] Dire Fate: Windfury && Test: Dire Fate: Windfury_TB_PickYourFate_3
				InfoCardId = "TB_PickYourFate_3_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_4] Dire Fate: Card (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: When a minion dies, its owner draws a card.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_4", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_4] Dire Fate: Card && Test: Dire Fate: Card_TB_PickYourFate_4
				InfoCardId = "TB_PickYourFate_4_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_5] Fate: Spells (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Spells cost (1) less.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_5", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_5] Fate: Spells && Test: Fate: Spells_TB_PickYourFate_5
				InfoCardId = "TB_PickYourFate_5_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_6] Fate: Portals (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Shuffle 10 Unstable Portals into each player's deck.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_6", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_6] Fate: Portals && Test: Fate: Portals_TB_PickYourFate_6
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_6_2nd] Dire Fate: Unstable Portals (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Place 3 Unstable Portals in each player's hand.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_6_2nd", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_6_2nd] Dire Fate: Unstable Portals && Test: Dire Fate: Unstable Portals_TB_PickYourFate_6_2nd
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_7] Fate: Coin (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: When a minion dies, its owner gets a Coin.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_7", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_7] Fate: Coin && Test: Fate: Coin_TB_PickYourFate_7
				InfoCardId = "TB_PickYourFate_7_Ench_2nd",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_7_2nd] Dire Fate: Manaburst (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Minions gain <b>Deathrattle:</b> Random card in owner's hand costs (0).
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_7_2nd", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_7_2nd] Dire Fate: Manaburst && Test: Dire Fate: Manaburst_TB_PickYourFate_7_2nd
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_8] Spell Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain 3 Armor.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_8", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_8] Spell Bonus && Test: Spell Bonus_TB_PickYourFate_8
				InfoCardId = "TB_PickYourFate_8_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_8rand] Fate: Armor (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each player gains 2 Armor on the start of their turn.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_8rand", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_8rand] Fate: Armor && Test: Fate: Armor_TB_PickYourFate_8rand
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_9] Deathrattle Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your <b>Deathrattle</b> minions have +1/+1.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_9", new CardDef(new Power
			{
				// TODO [TB_PickYourFate_9] Deathrattle Bonus && Test: Deathrattle Bonus_TB_PickYourFate_9
				InfoCardId = "TB_PickYourFate_9_Ench",
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_Presents_001", new CardDef(new Power
			{
				// TODO [TB_Presents_001] Present! && Test: Present!_TB_Presents_001
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Presents_002] Card Present (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_Presents_002", new CardDef(new Power
			{
				// TODO [TB_Presents_002] Card Present && Test: Card Present_TB_Presents_002
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Presents_003] Zombie Present (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a 3/3 Zombie.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_Presents_003", new CardDef(new Power
			{
				// TODO [TB_Presents_003] Zombie Present && Test: Zombie Present_TB_Presents_003
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_RandomDeckRecipeResetDecks] Reset Decks (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset Both Player Decks
			// --------------------------------------------------------
			cards.Add("TB_RandomDeckRecipeResetDecks", new CardDef(new Power
			{
				// TODO [TB_RandomDeckRecipeResetDecks] Reset Decks && Test: Reset Decks_TB_RandomDeckRecipeResetDecks
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_RandomDeckRecipeResetYours] Reset Your Deck (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset Your Deck
			// --------------------------------------------------------
			cards.Add("TB_RandomDeckRecipeResetYours", new CardDef(new Power
			{
				// TODO [TB_RandomDeckRecipeResetYours] Reset Your Deck && Test: Reset Your Deck_TB_RandomDeckRecipeResetYours
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_RandomHand_spell] Random Hand Spell - Not Player Facing (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_RandomHand_spell", new CardDef(new Power
			{
				// TODO [TB_RandomHand_spell] Random Hand Spell - Not Player Facing && Test: Random Hand Spell - Not Player Facing_TB_RandomHand_spell
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SC20_001a", new CardDef(new Power
			{
				// TODO [TB_SC20_001a] Tech Portals && Test: Tech Portals_TB_SC20_001a
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SC20_001b", new CardDef(new Power
			{
				// TODO [TB_SC20_001b] Swarm Portals && Test: Swarm Portals_TB_SC20_001b
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("TB_SC20_001c", new CardDef(new Power
			{
				// TODO [TB_SC20_001c] Mind Portals && Test: Mind Portals_TB_SC20_001c
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SC20_002] Tech Portal (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random Tech card to your hand. It costs (3) less.
			// --------------------------------------------------------
			cards.Add("TB_SC20_002", new CardDef(new Power
			{
				// TODO [TB_SC20_002] Tech Portal && Test: Tech Portal_TB_SC20_002
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SC20_003] Swarm Portal (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random Swarm card to your hand. It costs (3) less.
			// --------------------------------------------------------
			cards.Add("TB_SC20_003", new CardDef(new Power
			{
				// TODO [TB_SC20_003] Swarm Portal && Test: Swarm Portal_TB_SC20_003
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SC20_004] Mind Portal (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random Mind card to your hand. It costs (3) less.
			// --------------------------------------------------------
			cards.Add("TB_SC20_004", new CardDef(new Power
			{
				// TODO [TB_SC20_004] Mind Portal && Test: Mind Portal_TB_SC20_004
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SpeedRun_End] End Speed Run Duration (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Start the Speed Run
			// --------------------------------------------------------
			cards.Add("TB_SpeedRun_End", new CardDef(new Power
			{
				// TODO [TB_SpeedRun_End] End Speed Run Duration && Test: End Speed Run Duration_TB_SpeedRun_End
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SpeedRun_Show] Show Speed Run Duration (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Start the Speed Run
			// --------------------------------------------------------
			cards.Add("TB_SpeedRun_Show", new CardDef(new Power
			{
				// TODO [TB_SpeedRun_Show] Show Speed Run Duration && Test: Show Speed Run Duration_TB_SpeedRun_Show
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SpeedRun_Start] Start the Speed Run (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Start the Speed Run
			// --------------------------------------------------------
			cards.Add("TB_SpeedRun_Start", new CardDef(new Power
			{
				// TODO [TB_SpeedRun_Start] Start the Speed Run && Test: Start the Speed Run_TB_SpeedRun_Start
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromo_EnterPortal] The Portal Opens (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Through the Nether and into...
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromo_EnterPortal", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromo_EnterPortal] The Portal Opens && Test: The Portal Opens_TB_SPT_DPromo_EnterPortal
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromoSpell1] Lightning (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Deal $3 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpell1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [TB_SPT_DPromoSpell1] Lightning && Test: Lightning_TB_SPT_DPromoSpell1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromoSpell2] Summon Guardians (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon two 2/4 Guardians.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpell2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [TB_SPT_DPromoSpell2] Summon Guardians && Test: Summon Guardians_TB_SPT_DPromoSpell2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromoSpellBovine1] Moo... (*) - COST:6 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Summon 3 Hell Bovines. Give all Hell Bovines <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpellBovine1", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSpellBovine1] Moo... && Test: Moo..._TB_SPT_DPromoSpellBovine1
				InfoCardId = "TB_SPT_DPromoSpellBovine1e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromoSpellPortal] The Portal Opens (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Through the Nether and into...
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpellPortal", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [TB_SPT_DPromoSpellPortal] The Portal Opens && Test: The Portal Opens_TB_SPT_DPromoSpellPortal
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromoSpellPortal2] Stampede (*) - COST:4 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Summon 2 Hell Bovines. Give all Hell Bovines <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpellPortal2", new CardDef(new Power
			{
				// TODO [TB_SPT_DPromoSpellPortal2] Stampede && Test: Stampede_TB_SPT_DPromoSpellPortal2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Superfriends001] Offensive Play (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The next Legendary minion you play and all your other copies cost (3) less.
			// --------------------------------------------------------
			cards.Add("TB_Superfriends001", new CardDef(new Power
			{
				// TODO [TB_Superfriends001] Offensive Play && Test: Offensive Play_TB_Superfriends001
				InfoCardId = "TB_Superfriends001e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_TagTeam_ClearBoard] Your Next Victim Comes (*) - COST:10 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy all minions. Drain all Mana. Gain 5 Health.
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_ClearBoard", new CardDef(new Power
			{
				// TODO [TB_TagTeam_ClearBoard] Your Next Victim Comes && Test: Your Next Victim Comes_TB_TagTeam_ClearBoard
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_TagTeam_NewHeroCards] New Hero! (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: A new Hero takes position.
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_NewHeroCards", new CardDef(new Power
			{
				// TODO [TB_TagTeam_NewHeroCards] New Hero! && Test: New Hero!_TB_TagTeam_NewHeroCards
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_TempleOutrun_Treasure_Reno1] Look What I Found! (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a Treasure.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_Treasure_Reno1", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_Treasure_Reno1] Look What I Found! && Test: Look What I Found!_TB_TempleOutrun_Treasure_Reno1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_ZombeastSpell] Zombeast Brawl Spell (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_ZombeastSpell", new CardDef(new Power
			{
				// TODO [TB_ZombeastSpell] Zombeast Brawl Spell && Test: Zombeast Brawl Spell_TB_ZombeastSpell
				//PowerTask = null,
				//Trigger = null,
			}));

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
			cards.Add("BRMC_94", new CardDef(new Power
			{
				// TODO [BRMC_94] Sulfuras && Test: Sulfuras_BRMC_94
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [TB_BlingBrawl_Weapon] Foam Sword (*) - COST:1 [ATK:2/HP:0] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("TB_BlingBrawl_Weapon", new CardDef(new Power
			{
				// TODO [TB_BlingBrawl_Weapon] Foam Sword && Test: Foam Sword_TB_BlingBrawl_Weapon
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [TB_KTRAF_08w] Massive Runeblade (*) - COST:3 [ATK:5/HP:0] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deals double damage to heroes.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_08w", new CardDef(new Power
			{
				// TODO [TB_KTRAF_08w] Massive Runeblade && Test: Massive Runeblade_TB_KTRAF_08w
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [TB_SPT_BossWeapon] Armory (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Attack increases over time.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_BossWeapon", new CardDef(new Power
			{
				// TODO [TB_SPT_BossWeapon] Armory && Test: Armory_TB_SPT_BossWeapon
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [TB_SPT_MTH_BossWeapon] Party Armory (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Attack increases over time.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_BossWeapon", new CardDef(new Power
			{
				// TODO [TB_SPT_MTH_BossWeapon] Party Armory && Test: Party Armory_TB_SPT_MTH_BossWeapon
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [TB_TempleOutrun_DALA_719] Soulreaper's Scythe (*) - COST:5 [ATK:6/HP:0] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon all minions killed by this weapon this run.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TB_TempleOutrun_DALA_719", new CardDef(new Power
			{
				// TODO [TB_TempleOutrun_DALA_719] Soulreaper's Scythe && Test: Soulreaper's Scythe_TB_TempleOutrun_DALA_719
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
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
