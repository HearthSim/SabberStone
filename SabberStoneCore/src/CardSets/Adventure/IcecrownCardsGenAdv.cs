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
//	public class IcecrownCardsGenAdv
//	{
//		private static void Heroes(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------------- HERO - NEUTRAL
//			// [ICCA01_001] The Lich King (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 42457
//			// --------------------------------------------------------
//			cards.Add("ICCA01_001", new Power {
//				// TODO [ICCA01_001] The Lich King && Test: The Lich King_ICCA01_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - PALADIN
//			// [ICCA01_013] Tirion Fordring (*) - COST:0 [ATK:0/HP:30] 
//			// - Fac: neutral, Set: icecrown, 
//			// --------------------------------------------------------
//			// Entourage: ICC_314t2, ICC_314t3, ICC_314t4, ICC_314t1, ICC_314t6, ICC_314t5, ICC_314t7, ICC_314t8
//			// --------------------------------------------------------
//			cards.Add("ICCA01_013", new List<Power> {
//				// TODO [ICCA01_013] Tirion Fordring && Test: Tirion Fordring_ICCA01_013
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [ICCA03_001] Secrets of the Citadel (*) - COST:0 [ATK:0/HP:100] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			cards.Add("ICCA03_001", new List<Power> {
//				// TODO [ICCA03_001] Secrets of the Citadel && Test: Secrets of the Citadel_ICCA03_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [ICCA04_001] Sindragosa (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 45627
//			// --------------------------------------------------------
//			cards.Add("ICCA04_001", new List<Power> {
//				// TODO [ICCA04_001] Sindragosa && Test: Sindragosa_ICCA04_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [ICCA05_001] Blood-Queen Lana'thel (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 43194
//			// --------------------------------------------------------
//			cards.Add("ICCA05_001", new List<Power> {
//				// TODO [ICCA05_001] Blood-Queen Lana'thel && Test: Blood-Queen Lana'thel_ICCA05_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [ICCA06_001] Lord Marrowgar (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 42447
//			// --------------------------------------------------------
//			cards.Add("ICCA06_001", new List<Power> {
//				// TODO [ICCA06_001] Lord Marrowgar && Test: Lord Marrowgar_ICCA06_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [ICCA07_001] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 42876
//			// --------------------------------------------------------
//			cards.Add("ICCA07_001", new List<Power> {
//				// TODO [ICCA07_001] Professor Putricide && Test: Professor Putricide_ICCA07_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [ICCA07_001h2] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 42876
//			// --------------------------------------------------------
//			cards.Add("ICCA07_001h2", new List<Power> {
//				// TODO [ICCA07_001h2] Professor Putricide && Test: Professor Putricide_ICCA07_001h2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [ICCA07_001h3] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 42876
//			// --------------------------------------------------------
//			cards.Add("ICCA07_001h3", new List<Power> {
//				// TODO [ICCA07_001h3] Professor Putricide && Test: Professor Putricide_ICCA07_001h3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [ICCA08_001] The Lich King (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 42457
//			// --------------------------------------------------------
//			cards.Add("ICCA08_001", new List<Power> {
//				// TODO [ICCA08_001] The Lich King && Test: The Lich King_ICCA08_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [ICCA09_002] Deathbringer Saurfang (*) - COST:0 [ATK:0/HP:20] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 43038
//			// --------------------------------------------------------
//			cards.Add("ICCA09_002", new List<Power> {
//				// TODO [ICCA09_002] Deathbringer Saurfang && Test: Deathbringer Saurfang_ICCA09_002
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [ICCA10_009] Lady Deathwhisper (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 45605
//			// --------------------------------------------------------
//			cards.Add("ICCA10_009", new List<Power> {
//				// TODO [ICCA10_009] Lady Deathwhisper && Test: Lady Deathwhisper_ICCA10_009
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
//			// [ICCA04_008p] Frost Breath (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Permanently <b>Freeze</b> all enemy minions.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA04_008p", new List<Power> {
//				// TODO [ICCA04_008p] Frost Breath && Test: Frost Breath_ICCA04_008p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA04_009p] Frost Breath (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Triggered Power</b>
//			//       At 20 Health, transforms all enemy minions into blocks of ice.
//			// --------------------------------------------------------
//			cards.Add("ICCA04_009p", new List<Power> {
//				// TODO [ICCA04_009p] Frost Breath && Test: Frost Breath_ICCA04_009p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA04_010p] Frost Breath (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Triggered Power</b>
//			//       At 10 Health, transforms all enemy minions into blocks of ice.
//			// --------------------------------------------------------
//			cards.Add("ICCA04_010p", new List<Power> {
//				// TODO [ICCA04_010p] Frost Breath && Test: Frost Breath_ICCA04_010p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA04_011p] Ice Claw (*) - COST:2 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal $2 damage. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("ICCA04_011p", new List<Power> {
//				// TODO [ICCA04_011p] Ice Claw && Test: Ice Claw_ICCA04_011p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA05_002p] Vampiric Bite (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Give a non-Vampire +2/+2. You <i>must</i> use this.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_NOT_VAMPIRE = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("ICCA05_002p", new List<Power> {
//				// TODO [ICCA05_002p] Vampiric Bite && Test: Vampiric Bite_ICCA05_002p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA05_004p] Vampiric Leech (*) - COST:2 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       <b>Lifesteal</b>
//			//       Deal $3 damage. @spelldmg
//			// --------------------------------------------------------
//			// GameTag:
//			// - LIFESTEAL = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("ICCA05_004p", new List<Power> {
//				// TODO [ICCA05_004p] Vampiric Leech && Test: Vampiric Leech_ICCA05_004p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA06_002p] Skeletal Reconstruction (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Restore your hero to full Health.
//			// --------------------------------------------------------
//			cards.Add("ICCA06_002p", new List<Power> {
//				// TODO [ICCA06_002p] Skeletal Reconstruction && Test: Skeletal Reconstruction_ICCA06_002p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA07_002p] Mad Science (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       All <b>Secrets</b> cost (0).
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA07_002p", new List<Power> {
//				// TODO [ICCA07_002p] Mad Science && Test: Mad Science_ICCA07_002p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA07_003p] Madder Science (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       All weapons cost (1).
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA07_003p", new List<Power> {
//				// TODO [ICCA07_003p] Madder Science && Test: Madder Science_ICCA07_003p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA07_005p] Maddest Science (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       All cards cost (5).
//			//       Because SCIENCE!
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA07_005p", new List<Power> {
//				// TODO [ICCA07_005p] Maddest Science && Test: Maddest Science_ICCA07_005p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA08_002p] The Scourge (*) - COST:2 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 2/2 Ghoul.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_002p", new List<Power> {
//				// TODO [ICCA08_002p] The Scourge && Test: The Scourge_ICCA08_002p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------- HERO_POWER - DEATHKNIGHT
//			// [ICCA08_030p] Remorseless Winter (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal @ damage to the enemy hero. +1 Damage each time.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAG_SCRIPT_DATA_NUM_1 = 1
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_030p", new List<Power> {
//				// TODO [ICCA08_030p] Remorseless Winter && Test: Remorseless Winter_ICCA08_030p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA08_032p] Harvest of Souls (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       You are <b>Immune</b> if you control a Trapped Soul.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_032p", new List<Power> {
//				// TODO [ICCA08_032p] Harvest of Souls && Test: Harvest of Souls_ICCA08_032p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA09_001p] Blood Rune (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       Can only take damage from weapons.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA09_001p", new List<Power> {
//				// TODO [ICCA09_001p] Blood Rune && Test: Blood Rune_ICCA09_001p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [ICCA10_009p] Whisper of Death (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: [x]<b>Hero Power</b>
//			//       Damage all enemy
//			//       minions until they have
//			//       1 Health.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA10_009p", new List<Power> {
//				// TODO [ICCA10_009p] Whisper of Death && Test: Whisper of Death_ICCA10_009p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//		}

//		private static void DeathknightNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------ ENCHANTMENT - DEATHKNIGHT
//			// [ICCA08_023e] Plagued (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: 1/1.
//			// --------------------------------------------------------
//			cards.Add("ICCA08_023e", new List<Power> {
//				// TODO [ICCA08_023e] Plagued && Test: Plagued_ICCA08_023e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [ICCA01_003] Blood Tap (*) - COST:1 
//			// - Fac: neutral, Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: The next spell you cast this turn costs (0).
//			// --------------------------------------------------------
//			cards.Add("ICCA01_003", new List<Power> {
//				// TODO [ICCA01_003] Blood Tap && Test: Blood Tap_ICCA01_003
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [ICCA01_004] Army of the Dead (*) - COST:10 
//			// - Fac: neutral, Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Summon seven 3/3 Ghouls with <b>Taunt</b>.
//			// --------------------------------------------------------
//			cards.Add("ICCA01_004", new List<Power> {
//				// TODO [ICCA01_004] Army of the Dead && Test: Army of the Dead_ICCA01_004
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [ICCA08_021] The True Lich (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Set the enemy hero's remaining Health to 1.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_021", new List<Power> {
//				// TODO [ICCA08_021] The True Lich && Test: The True Lich_ICCA08_021
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [ICCA08_022] Fallen Champions (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Whenever an enemy dies this game, take control of it.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_022", new List<Power> {
//				// TODO [ICCA08_022] Fallen Champions && Test: Fallen Champions_ICCA08_022
//				new Power
//				{
//					InfoCardId = "ICCA08_022e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [ICCA08_023] Necrotic Plague (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Set minions in your opponent's hand and deck to 1/1.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_023", new List<Power> {
//				// TODO [ICCA08_023] Necrotic Plague && Test: Necrotic Plague_ICCA08_023
//				new Power
//				{
//					InfoCardId = "ICCA08_023e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [ICCA08_024] The Hunted (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Deal $2 damage to your opponent for each minion in their deck. @spelldmg
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_024", new List<Power> {
//				// TODO [ICCA08_024] The Hunted && Test: The Hunted_ICCA08_024
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [ICCA08_025] Purge the Weak (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Destroy all enemy minions that cost (3) or less, wherever they are.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_025", new List<Power> {
//				// TODO [ICCA08_025] Purge the Weak && Test: Purge the Weak_ICCA08_025
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [ICCA08_026] Soul Reaper (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Deal $2 damage for each duplicate in opponent’s deck. @spelldmg
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("ICCA08_026", new List<Power> {
//				// TODO [ICCA08_026] Soul Reaper && Test: Soul Reaper_ICCA08_026
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [ICCA08_027] The True King (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Gain 100 Armor.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_027", new List<Power> {
//				// TODO [ICCA08_027] The True King && Test: The True King_ICCA08_027
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [ICCA08_028] The Price of Power (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Destroy every spell in your opponent's hand and deck.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_028", new List<Power> {
//				// TODO [ICCA08_028] The Price of Power && Test: The Price of Power_ICCA08_028
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [ICCA08_029] Shut up, Priest (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Your opponent can't emote.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_029", new List<Power> {
//				// TODO [ICCA08_029] Shut up, Priest && Test: Shut up, Priest_ICCA08_029
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------- WEAPON - DEATHKNIGHT
//			// [ICCA01_005] Frostmourne (*) - COST:2 [ATK:5/HP:0] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 3
//			// --------------------------------------------------------
//			cards.Add("ICCA01_005", new List<Power> {
//				// TODO [ICCA01_005] Frostmourne && Test: Frostmourne_ICCA01_005
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------- WEAPON - DEATHKNIGHT
//			// [ICCA08_020] Frostmourne (*) - COST:7 [ATK:5/HP:0] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Remove all your minions. <b>Deathrattle:</b> Resummon them.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 3
//			// - BATTLECRY = 1
//			// - IMMUNE = 1
//			// - CANT_BE_DESTROYED = 1
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA08_020", new List<Power> {
//				// TODO [ICCA08_020] Frostmourne && Test: Frostmourne_ICCA08_020
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void MageNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------------- SPELL - MAGE
//			// [ICCA04_002] Unchained Magic (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Deal $3 damage to the enemy hero for each spell in their hand. @spelldmg
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA04_002", new List<Power> {
//				// TODO [ICCA04_002] Unchained Magic && Test: Unchained Magic_ICCA04_002
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void WarlockNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------------- SPELL - WARLOCK
//			// [ICCA05_020] Bite of the Blood-Queen (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Turn a hero into a Vampire.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA05_020", new List<Power> {
//				// TODO [ICCA05_020] Bite of the Blood-Queen && Test: Bite of the Blood-Queen_ICCA05_020
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARLOCK
//			// [ICCA05_021] Blood Essence (*) - COST:1 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Transform 2 random minions in your opponent's hand into spells.
//			// --------------------------------------------------------
//			cards.Add("ICCA05_021", new List<Power> {
//				// TODO [ICCA05_021] Blood Essence && Test: Blood Essence_ICCA05_021
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void NeutralNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [ICCA05_002e] Bitten! (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: +2/+2. Can't be bitten again.
//			// --------------------------------------------------------
//			cards.Add("ICCA05_002e", new List<Power> {
//				// TODO [ICCA05_002e] Bitten! && Test: Bitten!_ICCA05_002e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [ICCA07_004e] Grow (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: The ooze is growing.
//			// --------------------------------------------------------
//			cards.Add("ICCA07_004e", new List<Power> {
//				// TODO [ICCA07_004e] Grow && Test: Grow_ICCA07_004e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [ICCA08_022e] Join the Ranks Player Enchantment (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			cards.Add("ICCA08_022e", new List<Power> {
//				// TODO [ICCA08_022e] Join the Ranks Player Enchantment && Test: Join the Ranks Player Enchantment_ICCA08_022e
//				new Power
//				{
//					InfoCardId = "ICCA08_022e2",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [ICCA08_022e2] Join the Ranks (*) - COST:0 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: When this dies, resummon it for your oponent.
//			// --------------------------------------------------------
//			cards.Add("ICCA08_022e2", new List<Power> {
//				// TODO [ICCA08_022e2] Join the Ranks && Test: Join the Ranks_ICCA08_022e2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA01_004t] Ghoul (*) - COST:3 [ATK:3/HP:3] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA01_004t", new List<Power> {
//				// TODO [ICCA01_004t] Ghoul && Test: Ghoul_ICCA01_004t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA01_007] Eager Rogue (*) - COST:1 [ATK:3/HP:2] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Deals no damage while attacking.
//			// --------------------------------------------------------
//			cards.Add("ICCA01_007", new List<Power> {
//				// TODO [ICCA01_007] Eager Rogue && Test: Eager Rogue_ICCA01_007
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA01_008] Terrible Tank (*) - COST:2 [ATK:2/HP:3] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			cards.Add("ICCA01_008", new List<Power> {
//				// TODO [ICCA01_008] Terrible Tank && Test: Terrible Tank_ICCA01_008
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA01_009] Needy Hunter (*) - COST:3 [ATK:3/HP:3] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Whenever this minion attacks, add a Coin to your hand.
//			// --------------------------------------------------------
//			cards.Add("ICCA01_009", new List<Power> {
//				// TODO [ICCA01_009] Needy Hunter && Test: Needy Hunter_ICCA01_009
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA01_010] A. F. Kay (*) - COST:4 [ATK:5/HP:2] 
//			// - Set: icecrown, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Can't attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - CANT_ATTACK = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA01_010", new List<Power> {
//				// TODO [ICCA01_010] A. F. Kay && Test: A. F. Kay_ICCA01_010
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA01_011] Warlock on Fire (*) - COST:5 [ATK:7/HP:1] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: At the end of your turn, deal 1 damage to this minion.
//			// --------------------------------------------------------
//			cards.Add("ICCA01_011", new List<Power> {
//				// TODO [ICCA01_011] Warlock on Fire && Test: Warlock on Fire_ICCA01_011
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA04_004] Block of Ice (*) - COST:3 [ATK:0/HP:7] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA04_004", new List<Power> {
//				// TODO [ICCA04_004] Block of Ice && Test: Block of Ice_ICCA04_004
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA05_003] Sleeping Acolyte (*) - COST:1 [ATK:0/HP:10] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			cards.Add("ICCA05_003", new List<Power> {
//				// TODO [ICCA05_003] Sleeping Acolyte && Test: Sleeping Acolyte_ICCA05_003
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA06_005] Bone Spike (*) - COST:4 [ATK:0/HP:8] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: At the start of your turn, deal 15 damage to the enemy hero.
//			// --------------------------------------------------------
//			cards.Add("ICCA06_005", new List<Power> {
//				// TODO [ICCA06_005] Bone Spike && Test: Bone Spike_ICCA06_005
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA07_004] Growing Ooze (*) - COST:1 [ATK:1/HP:1] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: At the start of your turn, gain +1/+1.
//			// --------------------------------------------------------
//			cards.Add("ICCA07_004", new List<Power> {
//				// TODO [ICCA07_004] Growing Ooze && Test: Growing Ooze_ICCA07_004
//				new Power
//				{
//					InfoCardId = "ICCA07_004e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA07_008] Festergut (*) - COST:4 [ATK:3/HP:5] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: At the end of your turn, deal 3 damage to all enemy minions.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA07_008", new List<Power> {
//				// TODO [ICCA07_008] Festergut && Test: Festergut_ICCA07_008
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA08_002t] Ghoul (*) - COST:2 [ATK:2/HP:2] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			cards.Add("ICCA08_002t", new List<Power> {
//				// TODO [ICCA08_002t] Ghoul && Test: Ghoul_ICCA08_002t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA08_017] Val'kyr Shadowguard (*) - COST:3 [ATK:0/HP:5] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: At the start of your turn, destroy a random enemy minion and this one.
//			// --------------------------------------------------------
//			cards.Add("ICCA08_017", new List<Power> {
//				// TODO [ICCA08_017] Val'kyr Shadowguard && Test: Val'kyr Shadowguard_ICCA08_017
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA08_033] Trapped Soul (*) - COST:3 [ATK:2/HP:6] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			cards.Add("ICCA08_033", new List<Power> {
//				// TODO [ICCA08_033] Trapped Soul && Test: Trapped Soul_ICCA08_033
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA09_001t1] Blood Beast (*) - COST:3 [ATK:2/HP:4] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: At the start of your turn, restore 3 Health to your hero.
//			// --------------------------------------------------------
//			cards.Add("ICCA09_001t1", new List<Power> {
//				// TODO [ICCA09_001t1] Blood Beast && Test: Blood Beast_ICCA09_001t1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA10_001] Valithria Dreamwalker (*) - COST:5 [ATK:30/HP:5] 
//			// - Race: dragon, Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Can't attack or be attacked while damaged.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - HERO_POWER = 45289
//			// --------------------------------------------------------
//			// RefTag:
//			// - CANT_ATTACK = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA10_001", new List<Power> {
//				// TODO [ICCA10_001] Valithria Dreamwalker && Test: Valithria Dreamwalker_ICCA10_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [ICCA11_001] Skeletal Knight (*) - COST:1 [ATK:2/HP:3] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Add a
//			//        <b>Knights of the Frozen Throne</b> card to your opponent's hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA11_001", new List<Power> {
//				// TODO [ICCA11_001] Skeletal Knight && Test: Skeletal Knight_ICCA11_001
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [ICCA06_004] Bone Storm (*) - COST:2 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: Deal $1 damage to all enemies. Draw a card. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_FRIENDLY_TARGET = 0
//			// --------------------------------------------------------
//			cards.Add("ICCA06_004", new List<Power> {
//				// TODO [ICCA06_004] Bone Storm && Test: Bone Storm_ICCA06_004
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [ICCA06_003] Bryn'troll, the Bone Arbiter (*) - COST:6 [ATK:3/HP:0] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// Text: <b>Windfury</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 6
//			// - WINDFURY = 1
//			// --------------------------------------------------------
//			cards.Add("ICCA06_003", new List<Power> {
//				// TODO [ICCA06_003] Bryn'troll, the Bone Arbiter && Test: Bryn'troll, the Bone Arbiter_ICCA06_003
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [ICCA07_020] Tentacles (*) - COST:6 [ATK:3/HP:0] 
//			// - Set: icecrown, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 6
//			// --------------------------------------------------------
//			cards.Add("ICCA07_020", new List<Power> {
//				// TODO [ICCA07_020] Tentacles && Test: Tentacles_ICCA07_020
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
//			DeathknightNonCollect(cards);
//			MageNonCollect(cards);
//			WarlockNonCollect(cards);
//			NeutralNonCollect(cards);
//		}
//	}
//}
