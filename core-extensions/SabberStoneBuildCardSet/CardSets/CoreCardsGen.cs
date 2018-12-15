#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
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
	public class CoreCardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- HERO - WARRIOR
			// [HERO_01] Garrosh Hellscream - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 725
			// --------------------------------------------------------
			cards.Add("HERO_01", new Power {
				// TODO [HERO_01] Garrosh Hellscream && Test: Garrosh Hellscream_HERO_01
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ HERO - SHAMAN
			// [HERO_02] Thrall - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 687
			// --------------------------------------------------------
			cards.Add("HERO_02", new Power {
				// TODO [HERO_02] Thrall && Test: Thrall_HERO_02
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- HERO - ROGUE
			// [HERO_03] Valeera Sanguinar - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 730
			// --------------------------------------------------------
			cards.Add("HERO_03", new Power {
				// TODO [HERO_03] Valeera Sanguinar && Test: Valeera Sanguinar_HERO_03
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - PALADIN
			// [HERO_04] Uther Lightbringer - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 472
			// --------------------------------------------------------
			cards.Add("HERO_04", new Power {
				// TODO [HERO_04] Uther Lightbringer && Test: Uther Lightbringer_HERO_04
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ HERO - HUNTER
			// [HERO_05] Rexxar - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("HERO_05", new Power {
				// TODO [HERO_05] Rexxar && Test: Rexxar_HERO_05
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- HERO - DRUID
			// [HERO_06] Malfurion Stormrage - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 1123
			// --------------------------------------------------------
			cards.Add("HERO_06", new Power {
				// TODO [HERO_06] Malfurion Stormrage && Test: Malfurion Stormrage_HERO_06
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - WARLOCK
			// [HERO_07] Gul'dan - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 300
			// --------------------------------------------------------
			cards.Add("HERO_07", new Power {
				// TODO [HERO_07] Gul'dan && Test: Gul'dan_HERO_07
				//PowerTask = null,
				//Trigger = null,
			});

			// -------------------------------------------- HERO - MAGE
			// [HERO_08] Jaina Proudmoore - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 807
			// --------------------------------------------------------
			cards.Add("HERO_08", new Power {
				// TODO [HERO_08] Jaina Proudmoore && Test: Jaina Proudmoore_HERO_08
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ HERO - PRIEST
			// [HERO_09] Anduin Wrynn - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 479
			// --------------------------------------------------------
			cards.Add("HERO_09", new Power {
				// TODO [HERO_09] Anduin Wrynn && Test: Anduin Wrynn_HERO_09
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ------------------------------------ HERO_POWER - PRIEST
			// [CS1h_001] Lesser Heal (*) - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Restore #2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - 1086 = 2741
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS1h_001", new Power {
				// TODO [CS1h_001] Lesser Heal && Test: Lesser Heal_CS1h_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- HERO_POWER - DRUID
			// [CS2_017] Shapeshift (*) - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       +1 Attack this turn.
			//       +1 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - 1086 = 2737
			// --------------------------------------------------------
			cards.Add("CS2_017", new Power {
				// TODO [CS2_017] Shapeshift && Test: Shapeshift_CS2_017
				InfoCardId = "CS2_017o",
				//PowerTask = null,
				//Trigger = null,
			});

			// -------------------------------------- HERO_POWER - MAGE
			// [CS2_034] Fireblast (*) - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $1 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 1086 = 2739
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_034", new Power {
				// TODO [CS2_034] Fireblast && Test: Fireblast_CS2_034
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ HERO_POWER - SHAMAN
			// [CS2_049] Totemic Call (*) - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a random Totem.
			// --------------------------------------------------------
			// Entourage: CS2_050, CS2_051, CS2_052, NEW1_009
			// --------------------------------------------------------
			// GameTag:
			// - 1086 = 2742
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_049", new Power {
				// TODO [CS2_049] Totemic Call && Test: Totemic Call_CS2_049
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - WARLOCK
			// [CS2_056] Life Tap (*) - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw a card and take $2_damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 1086 = 2744
			// --------------------------------------------------------
			cards.Add("CS2_056", new Power {
				// TODO [CS2_056] Life Tap && Test: Life Tap_CS2_056
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- HERO_POWER - ROGUE
			// [CS2_083b] Dagger Mastery (*) - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Equip a 1/2 Dagger.
			// --------------------------------------------------------
			// GameTag:
			// - 1086 = 2743
			// --------------------------------------------------------
			cards.Add("CS2_083b", new Power {
				// TODO [CS2_083b] Dagger Mastery && Test: Dagger Mastery_CS2_083b
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - PALADIN
			// [CS2_101] Reinforce (*) - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 1/1 Silver Hand Recruit.
			// --------------------------------------------------------
			// GameTag:
			// - 1086 = 2740
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("CS2_101", new Power {
				// TODO [CS2_101] Reinforce && Test: Reinforce_CS2_101
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - WARRIOR
			// [CS2_102] Armor Up! (*) - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 2 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - 1086 = 2745
			// --------------------------------------------------------
			cards.Add("CS2_102", new Power {
				// TODO [CS2_102] Armor Up! && Test: Armor Up!_CS2_102
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ HERO_POWER - HUNTER
			// [DS1h_292] Steady Shot (*) - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage to the enemy hero.@<b>Hero Power</b>
			//       Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 1086 = 2738
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_STEADY_SHOT = 0
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("DS1h_292", new Power {
				// TODO [DS1h_292] Steady Shot && Test: Steady Shot_DS1h_292
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [CS2_232] Ironbark Protector - COST:8 [ATK:8/HP:8] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_232", new Power {
				// TODO [CS2_232] Ironbark Protector && Test: Ironbark Protector_CS2_232
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CS2_005] Claw - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give your hero +2_Attack this turn. Gain 2 Armor.
			// --------------------------------------------------------
			cards.Add("CS2_005", new Power {
				// TODO [CS2_005] Claw && Test: Claw_CS2_005
				InfoCardId = "CS2_005o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CS2_007] Healing Touch - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Restore #8 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_007", new Power {
				// TODO [CS2_007] Healing Touch && Test: Healing Touch_CS2_007
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CS2_008] Moonfire - COST:0 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $1 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_008", new Power {
				// TODO [CS2_008] Moonfire && Test: Moonfire_CS2_008
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CS2_009] Mark of the Wild - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a minion <b>Taunt</b> and +2/+2.<i>
			//       (+2 Attack/+2 Health)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_009", new Power {
				// TODO [CS2_009] Mark of the Wild && Test: Mark of the Wild_CS2_009
				InfoCardId = "CS2_009e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CS2_011] Savage Roar - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give your characters +2_Attack this turn.
			// --------------------------------------------------------
			cards.Add("CS2_011", new Power {
				// TODO [CS2_011] Savage Roar && Test: Savage Roar_CS2_011
				InfoCardId = "CS2_011o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CS2_012] Swipe - COST:4 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $4 damage to an enemy and $1 damage to all other enemies. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_012", new Power {
				// TODO [CS2_012] Swipe && Test: Swipe_CS2_012
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CS2_013] Wild Growth - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Gain an empty Mana Crystal.
			// --------------------------------------------------------
			cards.Add("CS2_013", new Power {
				// TODO [CS2_013] Wild Growth && Test: Wild Growth_CS2_013
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_169] Innervate - COST:0 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			cards.Add("EX1_169", new Power {
				// TODO [EX1_169] Innervate && Test: Innervate_EX1_169
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_173] Starfire - COST:6 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $5 damage.
			//       Draw a card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_173", new Power {
				// TODO [EX1_173] Starfire && Test: Starfire_EX1_173
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [CS2_005o] Claw (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CS2_005o", new Power {
				// TODO [CS2_005o] Claw && Test: Claw_CS2_005o
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [CS2_009e] Mark of the Wild (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +2/+2 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("CS2_009e", new Power {
				// TODO [CS2_009e] Mark of the Wild && Test: Mark of the Wild_CS2_009e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [CS2_011o] Savage Roar (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CS2_011o", new Power {
				// TODO [CS2_011o] Savage Roar && Test: Savage Roar_CS2_011o
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [CS2_017o] Claws (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Your hero has +1 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CS2_017o", new Power {
				// TODO [CS2_017o] Claws && Test: Claws_CS2_017o
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [BCON_008] Nature's Champion (*) - COST:3 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Return a friendly minion to your hand and give it +5/+5.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BCON_008", new Power {
				// TODO [BCON_008] Nature's Champion && Test: Nature's Champion_BCON_008
				InfoCardId = "BCON_008e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CS2_013t] Excess Mana (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Draw a card. <i>(You can only have 10 Mana in your tray.)</i>
			// --------------------------------------------------------
			cards.Add("CS2_013t", new Power {
				// TODO [CS2_013t] Excess Mana && Test: Excess Mana_CS2_013t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [CS2_237] Starving Buzzard - COST:5 [ATK:3/HP:2] 
			// - Race: beast, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Whenever you summon a Beast, draw a card.
			// --------------------------------------------------------
			cards.Add("CS2_237", new Power {
				// TODO [CS2_237] Starving Buzzard && Test: Starving Buzzard_CS2_237
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [DS1_070] Houndmaster - COST:4 [ATK:4/HP:3] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Beast +2/+2 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 20
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DS1_070", new Power {
				// TODO [DS1_070] Houndmaster && Test: Houndmaster_DS1_070
				InfoCardId = "DS1_070o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [DS1_175] Timber Wolf - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Your other Beasts have +1_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("DS1_175", new Power {
				// TODO [DS1_175] Timber Wolf && Test: Timber Wolf_DS1_175
				InfoCardId = "DS1_175o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [DS1_178] Tundra Rhino - COST:5 [ATK:2/HP:5] 
			// - Race: beast, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Your Beasts have <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("DS1_178", new Power {
				// TODO [DS1_178] Tundra Rhino && Test: Tundra Rhino_DS1_178
				InfoCardId = "DS1_178e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [CS2_084] Hunter's Mark - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Change a minion's Health to 1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_084", new Power {
				// TODO [CS2_084] Hunter's Mark && Test: Hunter's Mark_CS2_084
				InfoCardId = "CS2_084e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [DS1_183] Multi-Shot - COST:4 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $3 damage to two random enemy minions. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("DS1_183", new Power {
				// TODO [DS1_183] Multi-Shot && Test: Multi-Shot_DS1_183
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [DS1_184] Tracking - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Look at the top 3 cards of your deck. Draw one and discard the_others.
			// --------------------------------------------------------
			cards.Add("DS1_184", new Power {
				// TODO [DS1_184] Tracking && Test: Tracking_DS1_184
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [DS1_185] Arcane Shot - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DS1_185", new Power {
				// TODO [DS1_185] Arcane Shot && Test: Arcane Shot_DS1_185
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_539] Kill Command - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $3 damage. If you control a Beast, deal
			//       $5 damage instead. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_539", new Power {
				// TODO [EX1_539] Kill Command && Test: Kill Command_EX1_539
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [NEW1_031] Animal Companion - COST:3 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Summon a random Beast Companion.
			// --------------------------------------------------------
			// Entourage: NEW1_032, NEW1_033, NEW1_034
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("NEW1_031", new Power {
				// TODO [NEW1_031] Animal Companion && Test: Animal Companion_NEW1_031
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [CS2_084e] Hunter's Mark (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: This minion has 1 Health.
			// --------------------------------------------------------
			cards.Add("CS2_084e", new Power {
				// TODO [CS2_084e] Hunter's Mark && Test: Hunter's Mark_CS2_084e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [DS1_070o] Master's Presence (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +2/+2 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("DS1_070o", new Power {
				// TODO [DS1_070o] Master's Presence && Test: Master's Presence_DS1_070o
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [DS1_175o] Furious Howl (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +1 Attack from {0}.
			// --------------------------------------------------------
			cards.Add("DS1_175o", new Power {
				// TODO [DS1_175o] Furious Howl && Test: Furious Howl_DS1_175o
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [DS1_178e] Charge (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: {0} grants <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("DS1_178e", new Power {
				// TODO [DS1_178e] Charge && Test: Charge_DS1_178e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [NEW1_033o] Eye In The Sky (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Leokk is granting this minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("NEW1_033o", new Power {
				// TODO [NEW1_033o] Eye In The Sky && Test: Eye In The Sky_NEW1_033o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [NEW1_032] Misha (*) - COST:3 [ATK:4/HP:4] 
			// - Race: beast, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("NEW1_032", new Power {
				// TODO [NEW1_032] Misha && Test: Misha_NEW1_032
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [NEW1_033] Leokk (*) - COST:3 [ATK:2/HP:4] 
			// - Race: beast, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Your other minions have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("NEW1_033", new Power {
				// TODO [NEW1_033] Leokk && Test: Leokk_NEW1_033
				InfoCardId = "NEW1_033o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [NEW1_034] Huffer (*) - COST:3 [ATK:4/HP:2] 
			// - Race: beast, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("NEW1_034", new Power {
				// TODO [NEW1_034] Huffer && Test: Huffer_NEW1_034
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [BCON_001] Deadeye (*) - COST:2 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: For the rest of the game,
			//       your Hero Power can target minions.
			// --------------------------------------------------------
			cards.Add("BCON_001", new Power {
				// TODO [BCON_001] Deadeye && Test: Deadeye_BCON_001
				InfoCardId = "BCON_001e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [CS2_033] Water Elemental - COST:4 [ATK:3/HP:6] 
			// - Race: elemental, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Freeze</b> any character damaged by this minion.
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CS2_033", new Power {
				// TODO [CS2_033] Water Elemental && Test: Water Elemental_CS2_033
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CS2_022] Polymorph - COST:4 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Transform a minion
			//       into a 1/1 Sheep.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_022", new Power {
				// TODO [CS2_022] Polymorph && Test: Polymorph_CS2_022
				InfoCardId = "CS2_022e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CS2_023] Arcane Intellect - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Draw 2 cards.
			// --------------------------------------------------------
			cards.Add("CS2_023", new Power {
				// TODO [CS2_023] Arcane Intellect && Test: Arcane Intellect_CS2_023
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CS2_024] Frostbolt - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $3 damage to a_character and <b>Freeze</b> it. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_024", new Power {
				// TODO [CS2_024] Frostbolt && Test: Frostbolt_CS2_024
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CS2_025] Arcane Explosion - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $1 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("CS2_025", new Power {
				// TODO [CS2_025] Arcane Explosion && Test: Arcane Explosion_CS2_025
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CS2_026] Frost Nova - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Freeze</b> all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CS2_026", new Power {
				// TODO [CS2_026] Frost Nova && Test: Frost Nova_CS2_026
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CS2_027] Mirror Image - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Summon two 0/2 minions with <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_027", new Power {
				// TODO [CS2_027] Mirror Image && Test: Mirror Image_CS2_027
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CS2_029] Fireball - COST:4 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $6 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_029", new Power {
				// TODO [CS2_029] Fireball && Test: Fireball_CS2_029
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CS2_032] Flamestrike - COST:7 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $4 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("CS2_032", new Power {
				// TODO [CS2_032] Flamestrike && Test: Flamestrike_CS2_032
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [EX1_277] Arcane Missiles - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $3 damage randomly split among all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("EX1_277", new Power {
				// TODO [EX1_277] Arcane Missiles && Test: Arcane Missiles_EX1_277
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [CS2_022e] Polymorph (*) - COST:0 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: This minion has been transformed into a 1/1 Sheep.
			// --------------------------------------------------------
			// GameTag:
			// - MORPH = 1
			// --------------------------------------------------------
			cards.Add("CS2_022e", new Power {
				// TODO [CS2_022e] Polymorph && Test: Polymorph_CS2_022e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [CS2_mirror] Mirror Image (*) - COST:0 [ATK:0/HP:2] 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_mirror", new Power {
				// TODO [CS2_mirror] Mirror Image && Test: Mirror Image_CS2_mirror
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [BCON_004] Polymorph: ??? (*) - COST:5 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Choose a minion. <b>Discover</b> a new minion to transform it into.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BCON_004", new Power {
				// TODO [BCON_004] Polymorph: ??? && Test: Polymorph: ???_BCON_004
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [CS2_088] Guardian of Kings - COST:7 [ATK:5/HP:6] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore #6 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_088", new Power {
				// TODO [CS2_088] Guardian of Kings && Test: Guardian of Kings_CS2_088
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [CS2_087] Blessing of Might - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a minion +3_Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_087", new Power {
				// TODO [CS2_087] Blessing of Might && Test: Blessing of Might_CS2_087
				InfoCardId = "CS2_087e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [CS2_089] Holy Light - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Restore #6 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_089", new Power {
				// TODO [CS2_089] Holy Light && Test: Holy Light_CS2_089
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [CS2_092] Blessing of Kings - COST:4 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a minion +4/+4. <i>(+4 Attack/+4 Health)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_092", new Power {
				// TODO [CS2_092] Blessing of Kings && Test: Blessing of Kings_CS2_092
				InfoCardId = "CS2_092e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [CS2_093] Consecration - COST:4 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $2 damage to all_enemies. @spelldmg
			// --------------------------------------------------------
			cards.Add("CS2_093", new Power {
				// TODO [CS2_093] Consecration && Test: Consecration_CS2_093
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [CS2_094] Hammer of Wrath - COST:4 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $3 damage.
			//       Draw a card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_094", new Power {
				// TODO [CS2_094] Hammer of Wrath && Test: Hammer of Wrath_CS2_094
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_360] Humility - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Change a minion's Attack to 1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_360", new Power {
				// TODO [EX1_360] Humility && Test: Humility_EX1_360
				InfoCardId = "EX1_360e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_371] Hand of Protection - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a minion <b>Divine Shield</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_371", new Power {
				// TODO [EX1_371] Hand of Protection && Test: Hand of Protection_EX1_371
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [CS2_091] Light's Justice - COST:1 [ATK:1/HP:0] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			cards.Add("CS2_091", new Power {
				// TODO [CS2_091] Light's Justice && Test: Light's Justice_CS2_091
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [CS2_097] Truesilver Champion - COST:4 [ATK:4/HP:0] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Whenever your hero attacks, restore #2_Health to it.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("CS2_097", new Power {
				// TODO [CS2_097] Truesilver Champion && Test: Truesilver Champion_CS2_097
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [CS2_087e] Blessing of Might (*) - COST:0 
			// - Fac: neutral, Set: core, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_087e", new Power {
				// TODO [CS2_087e] Blessing of Might && Test: Blessing of Might_CS2_087e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [CS2_092e] Blessing of Kings (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			cards.Add("CS2_092e", new Power {
				// TODO [CS2_092e] Blessing of Kings && Test: Blessing of Kings_CS2_092e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_360e] Humility (*) - COST:0 
			// - Fac: neutral, Set: core, 
			// --------------------------------------------------------
			// Text: Attack has been changed to 1.
			// --------------------------------------------------------
			cards.Add("EX1_360e", new Power {
				// TODO [EX1_360e] Humility && Test: Humility_EX1_360e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [CS2_101t] Silver Hand Recruit (*) - COST:1 [ATK:1/HP:1] 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_101t", new Power {
				// TODO [CS2_101t] Silver Hand Recruit && Test: Silver Hand Recruit_CS2_101t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [BCON_012] Hand of Salvation (*) - COST:1 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your second minion dies in a turn, return it to life.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("BCON_012", new Power {
				// TODO [BCON_012] Hand of Salvation && Test: Hand of Salvation_BCON_012
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [CS2_235] Northshire Cleric - COST:1 [ATK:1/HP:3] 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Whenever a minion is healed, draw a card.
			// --------------------------------------------------------
			cards.Add("CS2_235", new Power {
				// TODO [CS2_235] Northshire Cleric && Test: Northshire Cleric_CS2_235
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CS1_112] Holy Nova - COST:5 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $2 damage to all enemies. Restore #2_Health to all friendly characters. @spelldmg
			// --------------------------------------------------------
			cards.Add("CS1_112", new Power {
				// TODO [CS1_112] Holy Nova && Test: Holy Nova_CS1_112
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CS1_113] Mind Control - COST:10 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Take control of an enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("CS1_113", new Power {
				// TODO [CS1_113] Mind Control && Test: Mind Control_CS1_113
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CS1_130] Holy Smite - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS1_130", new Power {
				// TODO [CS1_130] Holy Smite && Test: Holy Smite_CS1_130
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CS2_003] Mind Vision - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Put a copy of a random card in your opponent's hand into your hand.
			// --------------------------------------------------------
			cards.Add("CS2_003", new Power {
				// TODO [CS2_003] Mind Vision && Test: Mind Vision_CS2_003
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CS2_004] Power Word: Shield - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a minion +2_Health.
			//       Draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_004", new Power {
				// TODO [CS2_004] Power Word: Shield && Test: Power Word: Shield_CS2_004
				InfoCardId = "CS2_004e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CS2_234] Shadow Word: Pain - COST:2 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Destroy a minion with 3_or less Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_TARGET_MAX_ATTACK = 3
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_234", new Power {
				// TODO [CS2_234] Shadow Word: Pain && Test: Shadow Word: Pain_CS2_234
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CS2_236] Divine Spirit - COST:2 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Double a minion's Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_236", new Power {
				// TODO [CS2_236] Divine Spirit && Test: Divine Spirit_CS2_236
				InfoCardId = "CS2_236e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [DS1_233] Mind Blast - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $5 damage to the enemy hero. @spelldmg
			// --------------------------------------------------------
			cards.Add("DS1_233", new Power {
				// TODO [DS1_233] Mind Blast && Test: Mind Blast_DS1_233
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_622] Shadow Word: Death - COST:3 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Destroy a minion with 5_or more Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_MIN_ATTACK = 5
			// --------------------------------------------------------
			cards.Add("EX1_622", new Power {
				// TODO [EX1_622] Shadow Word: Death && Test: Shadow Word: Death_EX1_622
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CS2_004e] Power Word: Shield (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("CS2_004e", new Power {
				// TODO [CS2_004e] Power Word: Shield && Test: Power Word: Shield_CS2_004e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CS2_236e] Divine Spirit (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: This minion has double Health.
			// --------------------------------------------------------
			cards.Add("CS2_236e", new Power {
				// TODO [CS2_236e] Divine Spirit && Test: Divine Spirit_CS2_236e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [EX1_019e] Cleric's Blessing (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_019e", new Power {
				// TODO [EX1_019e] Cleric's Blessing && Test: Cleric's Blessing_EX1_019e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [BCON_015] Generous Spirit (*) - COST:2 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: [x]Choose a friendly minion.
			//       Give it to your opponent
			//       and draw 3 cards.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BCON_015", new Power {
				// TODO [BCON_015] Generous Spirit && Test: Generous Spirit_BCON_015
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [CS2_072] Backstab - COST:0 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $2 damage to an undamaged minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_UNDAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_072", new Power {
				// TODO [CS2_072] Backstab && Test: Backstab_CS2_072
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_074] Deadly Poison - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give your weapon +2_Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			cards.Add("CS2_074", new Power {
				// TODO [CS2_074] Deadly Poison && Test: Deadly Poison_CS2_074
				InfoCardId = "CS2_074e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_075] Sinister Strike - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $3 damage to the_enemy hero. @spelldmg
			// --------------------------------------------------------
			cards.Add("CS2_075", new Power {
				// TODO [CS2_075] Sinister Strike && Test: Sinister Strike_CS2_075
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_076] Assassinate - COST:5 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Destroy an enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_076", new Power {
				// TODO [CS2_076] Assassinate && Test: Assassinate_CS2_076
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_077] Sprint - COST:7 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Draw 4 cards.
			// --------------------------------------------------------
			cards.Add("CS2_077", new Power {
				// TODO [CS2_077] Sprint && Test: Sprint_CS2_077
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_129] Fan of Knives - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $1 damage to all enemy minions. Draw_a card. @spelldmg
			// --------------------------------------------------------
			cards.Add("EX1_129", new Power {
				// TODO [EX1_129] Fan of Knives && Test: Fan of Knives_EX1_129
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_278] Shiv - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $1 damage.
			//       Draw a card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_278", new Power {
				// TODO [EX1_278] Shiv && Test: Shiv_EX1_278
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_581] Sap - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Return an enemy minion to your opponent's hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_581", new Power {
				// TODO [EX1_581] Sap && Test: Sap_EX1_581
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [NEW1_004] Vanish - COST:6 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Return all minions to their owner's hand.
			// --------------------------------------------------------
			cards.Add("NEW1_004", new Power {
				// TODO [NEW1_004] Vanish && Test: Vanish_NEW1_004
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [CS2_080] Assassin's Blade - COST:5 [ATK:3/HP:0] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			cards.Add("CS2_080", new Power {
				// TODO [CS2_080] Assassin's Blade && Test: Assassin's Blade_CS2_080
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [BCON_016e] Smoke Bombed (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Stealthed until your next turn.
			// --------------------------------------------------------
			cards.Add("BCON_016e", new Power {
				// TODO [BCON_016e] Smoke Bombed && Test: Smoke Bombed_BCON_016e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CS2_083e] Sharpened (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +1 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CS2_083e", new Power {
				// TODO [CS2_083e] Sharpened && Test: Sharpened_CS2_083e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [BCON_016] Smoke Bomb (*) - COST:1 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a minion <b>Stealth</b> until your next turn. Draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BCON_016", new Power {
				// TODO [BCON_016] Smoke Bomb && Test: Smoke Bomb_BCON_016
				InfoCardId = "BCON_016e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [CS2_082] Wicked Knife (*) - COST:1 [ATK:1/HP:0] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("CS2_082", new Power {
				// TODO [CS2_082] Wicked Knife && Test: Wicked Knife_CS2_082
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [CS2_042] Fire Elemental - COST:6 [ATK:6/HP:5] 
			// - Race: elemental, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CS2_042", new Power {
				// TODO [CS2_042] Fire Elemental && Test: Fire Elemental_CS2_042
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_565] Flametongue Totem - COST:2 [ATK:0/HP:3] 
			// - Race: totem, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Adjacent minions have +2_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ADJACENT_BUFF = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_565", new Power {
				// TODO [EX1_565] Flametongue Totem && Test: Flametongue Totem_EX1_565
				InfoCardId = "EX1_565o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_587] Windspeaker - COST:4 [ATK:3/HP:3] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion <b>Windfury</b>.
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
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("EX1_587", new Power {
				// TODO [EX1_587] Windspeaker && Test: Windspeaker_EX1_587
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_037] Frost Shock - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $1 damage to an enemy character and <b>Freeze</b> it. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_037", new Power {
				// TODO [CS2_037] Frost Shock && Test: Frost Shock_CS2_037
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_039] Windfury - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a minion <b>Windfury</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("CS2_039", new Power {
				// TODO [CS2_039] Windfury && Test: Windfury_CS2_039
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_041] Ancestral Healing - COST:0 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Restore a minion
			//       to full Health and
			//       give it <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_041", new Power {
				// TODO [CS2_041] Ancestral Healing && Test: Ancestral Healing_CS2_041
				InfoCardId = "CS2_041e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_045] Rockbiter Weapon - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a friendly character +3 Attack this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_045", new Power {
				// TODO [CS2_045] Rockbiter Weapon && Test: Rockbiter Weapon_CS2_045
				InfoCardId = "CS2_045e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_046] Bloodlust - COST:5 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give your minions +3_Attack this turn.
			// --------------------------------------------------------
			cards.Add("CS2_046", new Power {
				// TODO [CS2_046] Bloodlust && Test: Bloodlust_CS2_046
				InfoCardId = "CS2_046e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_244] Totemic Might - COST:0 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give your Totems +2_Health.
			// --------------------------------------------------------
			cards.Add("EX1_244", new Power {
				// TODO [EX1_244] Totemic Might && Test: Totemic Might_EX1_244
				InfoCardId = "EX1_244e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_246] Hex - COST:4 
			// - Fac: neutral, Set: core, Rarity: free
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
			cards.Add("EX1_246", new Power {
				// TODO [EX1_246] Hex && Test: Hex_EX1_246
				InfoCardId = "EX1_246e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [CS2_041e] Ancestral Infusion (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Taunt.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_041e", new Power {
				// TODO [CS2_041e] Ancestral Infusion && Test: Ancestral Infusion_CS2_041e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [CS2_045e] Rockbiter Weapon (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: This character has +3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CS2_045e", new Power {
				// TODO [CS2_045e] Rockbiter Weapon && Test: Rockbiter Weapon_CS2_045e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [CS2_046e] Bloodlust (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CS2_046e", new Power {
				// TODO [CS2_046e] Bloodlust && Test: Bloodlust_CS2_046e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [EX1_244e] Totemic Might (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("EX1_244e", new Power {
				// TODO [EX1_244e] Totemic Might && Test: Totemic Might_EX1_244e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [EX1_246e] Hexxed (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: This minion has been transformed!
			// --------------------------------------------------------
			// GameTag:
			// - MORPH = 1
			// --------------------------------------------------------
			cards.Add("EX1_246e", new Power {
				// TODO [EX1_246e] Hexxed && Test: Hexxed_EX1_246e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [EX1_565o] Flametongue (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +2 Attack from Flametongue Totem.
			// --------------------------------------------------------
			cards.Add("EX1_565o", new Power {
				// TODO [EX1_565o] Flametongue && Test: Flametongue_EX1_565o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [CS2_050] Searing Totem (*) - COST:1 [ATK:1/HP:1] 
			// - Race: totem, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_050", new Power {
				// TODO [CS2_050] Searing Totem && Test: Searing Totem_CS2_050
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [CS2_051] Stoneclaw Totem (*) - COST:1 [ATK:0/HP:2] 
			// - Race: totem, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_051", new Power {
				// TODO [CS2_051] Stoneclaw Totem && Test: Stoneclaw Totem_CS2_051
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [CS2_052] Wrath of Air Totem (*) - COST:1 [ATK:0/HP:2] 
			// - Race: totem, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("CS2_052", new Power {
				// TODO [CS2_052] Wrath of Air Totem && Test: Wrath of Air Totem_CS2_052
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [NEW1_009] Healing Totem (*) - COST:1 [ATK:0/HP:2] 
			// - Race: totem, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: At the end of your turn, restore #1 Health to all friendly minions.
			// --------------------------------------------------------
			cards.Add("NEW1_009", new Power {
				// TODO [NEW1_009] Healing Totem && Test: Healing Totem_NEW1_009
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [BCON_021] Crackling Doom (*) - COST:0 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $12 damage to all_minions.
			//       <b>Overload</b>: (10) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 10
			// - OVERLOAD_OWED = 10
			// --------------------------------------------------------
			cards.Add("BCON_021", new Power {
				// TODO [BCON_021] Crackling Doom && Test: Crackling Doom_BCON_021
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [CS2_064] Dread Infernal - COST:6 [ATK:6/HP:6] 
			// - Race: demon, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage to ALL other characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_064", new Power {
				// TODO [CS2_064] Dread Infernal && Test: Dread Infernal_CS2_064
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [CS2_065] Voidwalker - COST:1 [ATK:1/HP:3] 
			// - Race: demon, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_065", new Power {
				// TODO [CS2_065] Voidwalker && Test: Voidwalker_CS2_065
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_306] Succubus - COST:2 [ATK:4/HP:3] 
			// - Race: demon, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Discard a random card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - DISCARD_CARDS = 1
			// --------------------------------------------------------
			cards.Add("EX1_306", new Power {
				// TODO [EX1_306] Succubus && Test: Succubus_EX1_306
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [CS2_057] Shadow Bolt - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $4 damage
			//       to a minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_057", new Power {
				// TODO [CS2_057] Shadow Bolt && Test: Shadow Bolt_CS2_057
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [CS2_061] Drain Life - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $2 damage. Restore #2 Health to your hero. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_061", new Power {
				// TODO [CS2_061] Drain Life && Test: Drain Life_CS2_061
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [CS2_062] Hellfire - COST:4 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $3 damage to ALL_characters. @spelldmg
			// --------------------------------------------------------
			cards.Add("CS2_062", new Power {
				// TODO [CS2_062] Hellfire && Test: Hellfire_CS2_062
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [CS2_063] Corruption - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Choose an enemy minion. At the start of your turn, destroy it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_063", new Power {
				// TODO [CS2_063] Corruption && Test: Corruption_CS2_063
				InfoCardId = "CS2_063e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_302] Mortal Coil - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $1 damage to a minion. If that kills it, draw a card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_302", new Power {
				// TODO [EX1_302] Mortal Coil && Test: Mortal Coil_EX1_302
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_308] Soulfire - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: [x]Deal $4 damage.
			//       Discard a random card. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - DISCARD_CARDS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_308", new Power {
				// TODO [EX1_308] Soulfire && Test: Soulfire_EX1_308
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [NEW1_003] Sacrificial Pact - COST:0 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Destroy a Demon. Restore #5 Health to your hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_TARGET_WITH_RACE = 15
			// --------------------------------------------------------
			cards.Add("NEW1_003", new Power {
				// TODO [NEW1_003] Sacrificial Pact && Test: Sacrificial Pact_NEW1_003
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [CS2_063e] Corruption (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: At the start of the corrupting player's turn, destroy this minion.
			// --------------------------------------------------------
			cards.Add("CS2_063e", new Power {
				// TODO [CS2_063e] Corruption && Test: Corruption_CS2_063e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [BCON_024] Bottled Madness (*) - COST:0 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Replace your hand with random Demons.
			// --------------------------------------------------------
			cards.Add("BCON_024", new Power {
				// TODO [BCON_024] Bottled Madness && Test: Bottled Madness_BCON_024
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [EX1_084] Warsong Commander - COST:3 [ATK:2/HP:3] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Your <b>Charge</b> minions have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_084", new Power {
				// TODO [EX1_084] Warsong Commander && Test: Warsong Commander_EX1_084
				InfoCardId = "EX1_084e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [NEW1_011] Kor'kron Elite - COST:4 [ATK:4/HP:3] 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("NEW1_011", new Power {
				// TODO [NEW1_011] Kor'kron Elite && Test: Kor'kron Elite_NEW1_011
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CS2_103] Charge - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a friendly minion <b>Charge</b>. It can't attack heroes this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CS2_103", new Power {
				// TODO [CS2_103] Charge && Test: Charge_CS2_103
				InfoCardId = "CS2_103e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CS2_105] Heroic Strike - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give your hero +4_Attack this turn.
			// --------------------------------------------------------
			cards.Add("CS2_105", new Power {
				// TODO [CS2_105] Heroic Strike && Test: Heroic Strike_CS2_105
				InfoCardId = "CS2_105e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CS2_108] Execute - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Destroy a damaged enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_DAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_108", new Power {
				// TODO [CS2_108] Execute && Test: Execute_CS2_108
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CS2_114] Cleave - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: [x]Deal $2 damage to
			//       two random enemy
			//       minions. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("CS2_114", new Power {
				// TODO [CS2_114] Cleave && Test: Cleave_CS2_114
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_400] Whirlwind - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $1 damage to ALL_minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("EX1_400", new Power {
				// TODO [EX1_400] Whirlwind && Test: Whirlwind_EX1_400
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_606] Shield Block - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Draw a card.
			// --------------------------------------------------------
			cards.Add("EX1_606", new Power {
				// TODO [EX1_606] Shield Block && Test: Shield Block_EX1_606
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [CS2_106] Fiery War Axe - COST:3 [ATK:3/HP:0] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("CS2_106", new Power {
				// TODO [CS2_106] Fiery War Axe && Test: Fiery War Axe_CS2_106
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [CS2_112] Arcanite Reaper - COST:5 [ATK:5/HP:0] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("CS2_112", new Power {
				// TODO [CS2_112] Arcanite Reaper && Test: Arcanite Reaper_CS2_112
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CS2_103e2] Charge (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Has <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("CS2_103e2", new Power {
				// TODO [CS2_103e2] Charge && Test: Charge_CS2_103e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CS2_105e] Heroic Strike (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +4 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CS2_105e", new Power {
				// TODO [CS2_105e] Heroic Strike && Test: Heroic Strike_CS2_105e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_084e] Charge (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Warsong Commander is granting this minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_084e", new Power {
				// TODO [EX1_084e] Charge && Test: Charge_EX1_084e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [CS1_042] Goldshire Footman - COST:1 [ATK:1/HP:2] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS1_042", new Power {
				// TODO [CS1_042] Goldshire Footman && Test: Goldshire Footman_CS1_042
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_118] Magma Rager - COST:3 [ATK:5/HP:1] 
			// - Race: elemental, Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_118", new Power {
				// TODO [CS2_118] Magma Rager && Test: Magma Rager_CS2_118
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_119] Oasis Snapjaw - COST:4 [ATK:2/HP:7] 
			// - Race: beast, Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_119", new Power {
				// TODO [CS2_119] Oasis Snapjaw && Test: Oasis Snapjaw_CS2_119
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_120] River Crocolisk - COST:2 [ATK:2/HP:3] 
			// - Race: beast, Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_120", new Power {
				// TODO [CS2_120] River Crocolisk && Test: River Crocolisk_CS2_120
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_121] Frostwolf Grunt - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_121", new Power {
				// TODO [CS2_121] Frostwolf Grunt && Test: Frostwolf Grunt_CS2_121
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_122] Raid Leader - COST:3 [ATK:2/HP:2] 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Your other minions have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("CS2_122", new Power {
				// TODO [CS2_122] Raid Leader && Test: Raid Leader_CS2_122
				InfoCardId = "CS2_122e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_124] Wolfrider - COST:3 [ATK:3/HP:1] 
			// - Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CS2_124", new Power {
				// TODO [CS2_124] Wolfrider && Test: Wolfrider_CS2_124
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_125] Ironfur Grizzly - COST:3 [ATK:3/HP:3] 
			// - Race: beast, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_125", new Power {
				// TODO [CS2_125] Ironfur Grizzly && Test: Ironfur Grizzly_CS2_125
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_127] Silverback Patriarch - COST:3 [ATK:1/HP:4] 
			// - Race: beast, Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_127", new Power {
				// TODO [CS2_127] Silverback Patriarch && Test: Silverback Patriarch_CS2_127
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_131] Stormwind Knight - COST:4 [ATK:2/HP:5] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CS2_131", new Power {
				// TODO [CS2_131] Stormwind Knight && Test: Stormwind Knight_CS2_131
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_141] Ironforge Rifleman - COST:3 [ATK:2/HP:2] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_141", new Power {
				// TODO [CS2_141] Ironforge Rifleman && Test: Ironforge Rifleman_CS2_141
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_142] Kobold Geomancer - COST:2 [ATK:2/HP:2] 
			// - Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("CS2_142", new Power {
				// TODO [CS2_142] Kobold Geomancer && Test: Kobold Geomancer_CS2_142
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_147] Gnomish Inventor - COST:4 [ATK:2/HP:4] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_147", new Power {
				// TODO [CS2_147] Gnomish Inventor && Test: Gnomish Inventor_CS2_147
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_150] Stormpike Commando - COST:5 [ATK:4/HP:2] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_150", new Power {
				// TODO [CS2_150] Stormpike Commando && Test: Stormpike Commando_CS2_150
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_155] Archmage - COST:6 [ATK:4/HP:7] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("CS2_155", new Power {
				// TODO [CS2_155] Archmage && Test: Archmage_CS2_155
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_162] Lord of the Arena - COST:6 [ATK:6/HP:5] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_162", new Power {
				// TODO [CS2_162] Lord of the Arena && Test: Lord of the Arena_CS2_162
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_168] Murloc Raider - COST:1 [ATK:2/HP:1] 
			// - Race: murloc, Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_168", new Power {
				// TODO [CS2_168] Murloc Raider && Test: Murloc Raider_CS2_168
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_171] Stonetusk Boar - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CS2_171", new Power {
				// TODO [CS2_171] Stonetusk Boar && Test: Stonetusk Boar_CS2_171
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_172] Bloodfen Raptor - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_172", new Power {
				// TODO [CS2_172] Bloodfen Raptor && Test: Bloodfen Raptor_CS2_172
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_173] Bluegill Warrior - COST:2 [ATK:2/HP:1] 
			// - Race: murloc, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CS2_173", new Power {
				// TODO [CS2_173] Bluegill Warrior && Test: Bluegill Warrior_CS2_173
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_179] Sen'jin Shieldmasta - COST:4 [ATK:3/HP:5] 
			// - Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_179", new Power {
				// TODO [CS2_179] Sen'jin Shieldmasta && Test: Sen'jin Shieldmasta_CS2_179
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_182] Chillwind Yeti - COST:4 [ATK:4/HP:5] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_182", new Power {
				// TODO [CS2_182] Chillwind Yeti && Test: Chillwind Yeti_CS2_182
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_186] War Golem - COST:7 [ATK:7/HP:7] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_186", new Power {
				// TODO [CS2_186] War Golem && Test: War Golem_CS2_186
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_187] Booty Bay Bodyguard - COST:5 [ATK:5/HP:4] 
			// - Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_187", new Power {
				// TODO [CS2_187] Booty Bay Bodyguard && Test: Booty Bay Bodyguard_CS2_187
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_189] Elven Archer - COST:1 [ATK:1/HP:1] 
			// - Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_189", new Power {
				// TODO [CS2_189] Elven Archer && Test: Elven Archer_CS2_189
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_196] Razorfen Hunter - COST:3 [ATK:2/HP:3] 
			// - Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 1/1_Boar.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_196", new Power {
				// TODO [CS2_196] Razorfen Hunter && Test: Razorfen Hunter_CS2_196
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_197] Ogre Magi - COST:4 [ATK:4/HP:4] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("CS2_197", new Power {
				// TODO [CS2_197] Ogre Magi && Test: Ogre Magi_CS2_197
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_200] Boulderfist Ogre - COST:6 [ATK:6/HP:7] 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_200", new Power {
				// TODO [CS2_200] Boulderfist Ogre && Test: Boulderfist Ogre_CS2_200
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_201] Core Hound - COST:7 [ATK:9/HP:5] 
			// - Race: beast, Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_201", new Power {
				// TODO [CS2_201] Core Hound && Test: Core Hound_CS2_201
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_213] Reckless Rocketeer - COST:6 [ATK:5/HP:2] 
			// - Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CS2_213", new Power {
				// TODO [CS2_213] Reckless Rocketeer && Test: Reckless Rocketeer_CS2_213
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_222] Stormwind Champion - COST:7 [ATK:6/HP:6] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Your other minions have +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("CS2_222", new Power {
				// TODO [CS2_222] Stormwind Champion && Test: Stormwind Champion_CS2_222
				InfoCardId = "CS2_222o",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_226] Frostwolf Warlord - COST:5 [ATK:4/HP:4] 
			// - Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1/+1 for each other friendly minion on the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_226", new Power {
				// TODO [CS2_226] Frostwolf Warlord && Test: Frostwolf Warlord_CS2_226
				InfoCardId = "CS2_226e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DS1_055] Darkscale Healer - COST:5 [ATK:4/HP:5] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore #2 Health to all friendly characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DS1_055", new Power {
				// TODO [DS1_055] Darkscale Healer && Test: Darkscale Healer_DS1_055
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_011] Voodoo Doctor - COST:1 [ATK:2/HP:1] 
			// - Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore #2_Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_011", new Power {
				// TODO [EX1_011] Voodoo Doctor && Test: Voodoo Doctor_EX1_011
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_015] Novice Engineer - COST:2 [ATK:1/HP:1] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_015", new Power {
				// TODO [EX1_015] Novice Engineer && Test: Novice Engineer_EX1_015
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_019] Shattered Sun Cleric - COST:3 [ATK:3/HP:2] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_019", new Power {
				// TODO [EX1_019] Shattered Sun Cleric && Test: Shattered Sun Cleric_EX1_019
				InfoCardId = "EX1_019e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_025] Dragonling Mechanic - COST:4 [ATK:2/HP:4] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/1 Mechanical Dragonling.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_025", new Power {
				// TODO [EX1_025] Dragonling Mechanic && Test: Dragonling Mechanic_EX1_025
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_066] Acidic Swamp Ooze - COST:2 [ATK:3/HP:2] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_066", new Power {
				// TODO [EX1_066] Acidic Swamp Ooze && Test: Acidic Swamp Ooze_EX1_066
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_399] Gurubashi Berserker - COST:5 [ATK:2/HP:7] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, gain +3_Attack.
			// --------------------------------------------------------
			cards.Add("EX1_399", new Power {
				// TODO [EX1_399] Gurubashi Berserker && Test: Gurubashi Berserker_EX1_399
				InfoCardId = "EX1_399e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_506] Murloc Tidehunter - COST:2 [ATK:2/HP:1] 
			// - Race: murloc, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 1/1_Murloc Scout.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_506", new Power {
				// TODO [EX1_506] Murloc Tidehunter && Test: Murloc Tidehunter_EX1_506
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_508] Grimscale Oracle - COST:1 [ATK:1/HP:1] 
			// - Race: murloc, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Your other Murlocs have +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_508", new Power {
				// TODO [EX1_508] Grimscale Oracle && Test: Grimscale Oracle_EX1_508
				InfoCardId = "EX1_508o",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_582] Dalaran Mage - COST:3 [ATK:1/HP:4] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("EX1_582", new Power {
				// TODO [EX1_582] Dalaran Mage && Test: Dalaran Mage_EX1_582
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_593] Nightblade - COST:5 [ATK:4/HP:4] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry: </b>Deal 3 damage to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_593", new Power {
				// TODO [EX1_593] Nightblade && Test: Nightblade_EX1_593
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BCON_001e] Deadeye (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Your Hero Power can target minions.
			// --------------------------------------------------------
			cards.Add("BCON_001e", new Power {
				// TODO [BCON_001e] Deadeye && Test: Deadeye_BCON_001e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BCON_008e] Nature's Champion (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +5/+5.
			// --------------------------------------------------------
			cards.Add("BCON_008e", new Power {
				// TODO [BCON_008e] Nature's Champion && Test: Nature's Champion_BCON_008e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_074e] Deadly Poison (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_074e", new Power {
				// TODO [CS2_074e] Deadly Poison && Test: Deadly Poison_CS2_074e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_122e] Enhanced (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Raid Leader is granting this minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_122e", new Power {
				// TODO [CS2_122e] Enhanced && Test: Enhanced_CS2_122e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_222o] Might of Stormwind (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Has +1/+1.
			// --------------------------------------------------------
			cards.Add("CS2_222o", new Power {
				// TODO [CS2_222o] Might of Stormwind && Test: Might of Stormwind_CS2_222o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_226e] Frostwolf Banner (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("CS2_226e", new Power {
				// TODO [CS2_226e] Frostwolf Banner && Test: Frostwolf Banner_CS2_226e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_399e] Berserking (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: This minion has increased Attack.
			// --------------------------------------------------------
			cards.Add("EX1_399e", new Power {
				// TODO [EX1_399e] Berserking && Test: Berserking_EX1_399e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_508o] Mlarggragllabl! (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: This Murloc has +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_508o", new Power {
				// TODO [EX1_508o] Mlarggragllabl! && Test: Mlarggragllabl!_EX1_508o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GAME_001] Luck of the Coin (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Going second grants you increased Health.
			// --------------------------------------------------------
			cards.Add("GAME_001", new Power {
				// TODO [GAME_001] Luck of the Coin && Test: Luck of the Coin_GAME_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GAME_003] Coin's Vengeance (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Going second makes your first minion stronger.
			// --------------------------------------------------------
			cards.Add("GAME_003", new Power {
				// TODO [GAME_003] Coin's Vengeance && Test: Coin's Vengeance_GAME_003
				InfoCardId = "GAME_003e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GAME_003e] Coin's Vengence (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Going second makes your first minion stronger.
			// --------------------------------------------------------
			cards.Add("GAME_003e", new Power {
				// TODO [GAME_003e] Coin's Vengence && Test: Coin's Vengence_GAME_003e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GAME_004] AFK (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Your turns are shorter.
			// --------------------------------------------------------
			cards.Add("GAME_004", new Power {
				// TODO [GAME_004] AFK && Test: AFK_GAME_004
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GAME_005e] The Coin (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			cards.Add("GAME_005e", new Power {
				// TODO [GAME_005e] The Coin && Test: The Coin_GAME_005e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GAME_011] Tournament Short Turn (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Your turns are shorter.
			// --------------------------------------------------------
			cards.Add("GAME_011", new Power {
				// TODO [GAME_011] Tournament Short Turn && Test: Tournament Short Turn_GAME_011
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GBL_001e] Cost = 1 (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("GBL_001e", new Power {
				// TODO [GBL_001e] Cost = 1 && Test: Cost = 1_GBL_001e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GBL_002e] Cost - 2 (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("GBL_002e", new Power {
				// TODO [GBL_002e] Cost - 2 && Test: Cost - 2_GBL_002e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GBL_003e] Cost - 1 (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("GBL_003e", new Power {
				// TODO [GBL_003e] Cost - 1 && Test: Cost - 1_GBL_003e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GBL_004e] Cost - 3 (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Costs (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("GBL_004e", new Power {
				// TODO [GBL_004e] Cost - 3 && Test: Cost - 3_GBL_004e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GBL_005e] Cost + 2 (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Costs (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("GBL_005e", new Power {
				// TODO [GBL_005e] Cost + 2 && Test: Cost + 2_GBL_005e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GBL_006e] Cost = 2 (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Costs (2).
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("GBL_006e", new Power {
				// TODO [GBL_006e] Cost = 2 && Test: Cost = 2_GBL_006e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GBL_007e] Cost = 10 (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Costs (10).
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("GBL_007e", new Power {
				// TODO [GBL_007e] Cost = 10 && Test: Cost = 10_GBL_007e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GBL_008e] Cost - 4 (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Costs (4) less.
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("GBL_008e", new Power {
				// TODO [GBL_008e] Cost - 4 && Test: Cost - 4_GBL_008e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GBL_009e] Cost = 0 (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("GBL_009e", new Power {
				// TODO [GBL_009e] Cost = 0 && Test: Cost = 0_GBL_009e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_boar] Boar (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			cards.Add("CS2_boar", new Power {
				// TODO [CS2_boar] Boar && Test: Boar_CS2_boar
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_tk1] Sheep (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			cards.Add("CS2_tk1", new Power {
				// TODO [CS2_tk1] Sheep && Test: Sheep_CS2_tk1
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_025t] Mechanical Dragonling (*) - COST:1 [ATK:2/HP:1] 
			// - Race: mechanical, Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_025t", new Power {
				// TODO [EX1_025t] Mechanical Dragonling && Test: Mechanical Dragonling_EX1_025t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_506a] Murloc Scout (*) - COST:1 [ATK:1/HP:1] 
			// - Race: murloc, Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_506a", new Power {
				// TODO [EX1_506a] Murloc Scout && Test: Murloc Scout_EX1_506a
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GAME_002] Avatar of the Coin (*) - COST:0 [ATK:1/HP:1] 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <i>You lost the coin flip, but gained a friend.</i>
			// --------------------------------------------------------
			cards.Add("GAME_002", new Power {
				// TODO [GAME_002] Avatar of the Coin && Test: Avatar of the Coin_GAME_002
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [hexfrog] Frog (*) - COST:0 [ATK:0/HP:1] 
			// - Race: beast, Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("hexfrog", new Power {
				// TODO [hexfrog] Frog && Test: Frog_hexfrog
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [skele11] Skeleton (*) - COST:1 [ATK:1/HP:1] 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b></b>
			// --------------------------------------------------------
			cards.Add("skele11", new Power {
				// TODO [skele11] Skeleton && Test: Skeleton_skele11
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [GAME_005] The Coin (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			cards.Add("GAME_005", new Power {
				// TODO [GAME_005] The Coin && Test: The Coin_GAME_005
				InfoCardId = "GAME_005e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [GAME_006] NOOOOOOOOOOOO (*) - COST:2 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Somehow, the card you USED to have has been deleted.  Here, have this one instead!
			// --------------------------------------------------------
			cards.Add("GAME_006", new Power {
				// TODO [GAME_006] NOOOOOOOOOOOO && Test: NOOOOOOOOOOOO_GAME_006
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			Druid(cards);
			DruidNonCollect(cards);
			Hunter(cards);
			HunterNonCollect(cards);
			Mage(cards);
			MageNonCollect(cards);
			Paladin(cards);
			PaladinNonCollect(cards);
			Priest(cards);
			PriestNonCollect(cards);
			Rogue(cards);
			RogueNonCollect(cards);
			Shaman(cards);
			ShamanNonCollect(cards);
			Warlock(cards);
			WarlockNonCollect(cards);
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
