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
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Undefined
{
	public class Expert1CardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- HERO - WARLOCK
			// [EX1_323h] Lord Jaraxxus (*) - COST:0 [ATK:0/HP:15] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 1178
			// --------------------------------------------------------
			cards.Add("EX1_323h", new Power {
				// TODO [EX1_323h] Lord Jaraxxus && Test: Lord Jaraxxus_EX1_323h
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ------------------------------------ HERO_POWER - PRIEST
			// [EX1_625t] Mind Spike (*) - COST:2 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_625t", new Power {
				// TODO [EX1_625t] Mind Spike && Test: Mind Spike_EX1_625t
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ HERO_POWER - PRIEST
			// [EX1_625t2] Mind Shatter (*) - COST:2 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $3 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_625t2", new Power {
				// TODO [EX1_625t2] Mind Shatter && Test: Mind Shatter_EX1_625t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - WARLOCK
			// [EX1_tk33] INFERNO! (*) - COST:2 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 6/6 Infernal.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("EX1_tk33", new Power {
				// TODO [EX1_tk33] INFERNO! && Test: INFERNO!_EX1_tk33
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [EX1_165] Druid of the Claw - COST:5 [ATK:4/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: common
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
			cards.Add("EX1_165", new Power {
				// TODO [EX1_165] Druid of the Claw && Test: Druid of the Claw_EX1_165
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [EX1_166] Keeper of the Grove - COST:4 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: rare
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
			cards.Add("EX1_166", new Power {
				// TODO [EX1_166] Keeper of the Grove && Test: Keeper of the Grove_EX1_166
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [EX1_178] Ancient of War - COST:7 [ATK:5/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Choose One -</b>
			//       +5 Attack; or +5 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_178", new Power {
				// TODO [EX1_178] Ancient of War && Test: Ancient of War_EX1_178
				InfoCardId = "EX1_178ae",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [EX1_573] Cenarius - COST:9 [ATK:5/HP:8] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Give your other minions +2/+2; or Summon two 2/2 Treants with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_573", new Power {
				// TODO [EX1_573] Cenarius && Test: Cenarius_EX1_573
				InfoCardId = "EX1_573ae",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [NEW1_008] Ancient of Lore - COST:7 [ATK:5/HP:5] 
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Draw a card; or Restore #5 Health.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("NEW1_008", new Power {
				// TODO [NEW1_008] Ancient of Lore && Test: Ancient of Lore_NEW1_008
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_154] Wrath - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b>
			//       Deal $3 damage to a minion; or $1 damage
			//       and draw a card. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_154", new Power {
				// TODO [EX1_154] Wrath && Test: Wrath_EX1_154
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_155] Mark of Nature - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Give a minion +4 Attack; or +4 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_155", new Power {
				// TODO [EX1_155] Mark of Nature && Test: Mark of Nature_EX1_155
				InfoCardId = "EX1_155ae",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_158] Soul of the Forest - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions "<b>Deathrattle:</b> Summon a 2/2 Treant."
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_158", new Power {
				// TODO [EX1_158] Soul of the Forest && Test: Soul of the Forest_EX1_158
				InfoCardId = "EX1_158e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_160] Power of the Wild - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Give your minions +1/+1; or Summon a 3/2 Panther.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("EX1_160", new Power {
				// TODO [EX1_160] Power of the Wild && Test: Power of the Wild_EX1_160
				InfoCardId = "EX1_160be",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_161] Naturalize - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a minion.
			//       Your opponent draws 2_cards.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_161", new Power {
				// TODO [EX1_161] Naturalize && Test: Naturalize_EX1_161
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_164] Nourish - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Gain 2_Mana Crystals; or Draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("EX1_164", new Power {
				// TODO [EX1_164] Nourish && Test: Nourish_EX1_164
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_570] Bite - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your hero +4_Attack this turn. Gain 4 Armor.
			// --------------------------------------------------------
			cards.Add("EX1_570", new Power {
				// TODO [EX1_570] Bite && Test: Bite_EX1_570
				InfoCardId = "EX1_570e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_571] Force of Nature - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon three 2/2 Treants.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("EX1_571", new Power {
				// TODO [EX1_571] Force of Nature && Test: Force of Nature_EX1_571
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_578] Savagery - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal damage equal to your hero's Attack to a minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_578", new Power {
				// TODO [EX1_578] Savagery && Test: Savagery_EX1_578
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_007] Starfall - COST:5 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b>
			//       Deal $5 damage to a minion; or $2 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("NEW1_007", new Power {
				// TODO [NEW1_007] Starfall && Test: Starfall_NEW1_007
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_155ae] Mark of Nature (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion has +4 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_155ae", new Power {
				// TODO [EX1_155ae] Mark of Nature && Test: Mark of Nature_EX1_155ae
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_155be] Mark of Nature (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion has +4 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_155be", new Power {
				// TODO [EX1_155be] Mark of Nature && Test: Mark of Nature_EX1_155be
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_158e] Soul of the Forest (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Deathrattle: Summon a 2/2 Treant.
			// --------------------------------------------------------
			cards.Add("EX1_158e", new Power {
				// TODO [EX1_158e] Soul of the Forest && Test: Soul of the Forest_EX1_158e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_160be] Leader of the Pack (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_160be", new Power {
				// TODO [EX1_160be] Leader of the Pack && Test: Leader of the Pack_EX1_160be
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_178ae] Rooted (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +5 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_178ae", new Power {
				// TODO [EX1_178ae] Rooted && Test: Rooted_EX1_178ae
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_178be] Uprooted (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +5 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_178be", new Power {
				// TODO [EX1_178be] Uprooted && Test: Uprooted_EX1_178be
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_573ae] Demigod's Favor (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("EX1_573ae", new Power {
				// TODO [EX1_573ae] Demigod's Favor && Test: Demigod's Favor_EX1_573ae
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [EX1_158t] Treant (*) - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_158t", new Power {
				// TODO [EX1_158t] Treant && Test: Treant_EX1_158t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [EX1_160t] Panther (*) - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_160t", new Power {
				// TODO [EX1_160t] Panther && Test: Panther_EX1_160t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [EX1_165t1] Druid of the Claw (*) - COST:5 [ATK:4/HP:4] 
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_165t1", new Power {
				// TODO [EX1_165t1] Druid of the Claw && Test: Druid of the Claw_EX1_165t1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [EX1_165t2] Druid of the Claw (*) - COST:5 [ATK:4/HP:6] 
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_165t2", new Power {
				// TODO [EX1_165t2] Druid of the Claw && Test: Druid of the Claw_EX1_165t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [EX1_573t] Treant (*) - COST:2 [ATK:2/HP:2] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_573t", new Power {
				// TODO [EX1_573t] Treant && Test: Treant_EX1_573t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [EX1_tk9] Treant (*) - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_tk9", new Power {
				// TODO [EX1_tk9] Treant && Test: Treant_EX1_tk9
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [OG_044a] Druid of the Claw (*) - COST:5 [ATK:4/HP:6] 
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("OG_044a", new Power {
				// TODO [OG_044a] Druid of the Claw && Test: Druid of the Claw_OG_044a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_154a] Wrath (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal $3 damage to a minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_154a", new Power {
				// TODO [EX1_154a] Wrath && Test: Wrath_EX1_154a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_154b] Wrath (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal $1 damage to a minion. Draw a card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_154b", new Power {
				// TODO [EX1_154b] Wrath && Test: Wrath_EX1_154b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_155a] Mark of Nature (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: +4 Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_155a", new Power {
				// TODO [EX1_155a] Mark of Nature && Test: Mark of Nature_EX1_155a
				InfoCardId = "EX1_155ae",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_155b] Mark of Nature (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: +4 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_155b", new Power {
				// TODO [EX1_155b] Mark of Nature && Test: Mark of Nature_EX1_155b
				InfoCardId = "EX1_155be",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_160a] Summon a Panther (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Summon a 3/2 Panther.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("EX1_160a", new Power {
				// TODO [EX1_160a] Summon a Panther && Test: Summon a Panther_EX1_160a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_160b] Leader of the Pack (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Give your minions +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_160b", new Power {
				// TODO [EX1_160b] Leader of the Pack && Test: Leader of the Pack_EX1_160b
				InfoCardId = "EX1_160be",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_164a] Nourish (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Gain 2 Mana Crystals.
			// --------------------------------------------------------
			cards.Add("EX1_164a", new Power {
				// TODO [EX1_164a] Nourish && Test: Nourish_EX1_164a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_164b] Nourish (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			// --------------------------------------------------------
			cards.Add("EX1_164b", new Power {
				// TODO [EX1_164b] Nourish && Test: Nourish_EX1_164b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_165a] Cat Form (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			cards.Add("EX1_165a", new Power {
				// TODO [EX1_165a] Cat Form && Test: Cat Form_EX1_165a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_165b] Bear Form (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_165b", new Power {
				// TODO [EX1_165b] Bear Form && Test: Bear Form_EX1_165b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_166a] Moonfire (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal 2 damage.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_166a", new Power {
				// TODO [EX1_166a] Moonfire && Test: Moonfire_EX1_166a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_166b] Dispel (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Silence</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_166b", new Power {
				// TODO [EX1_166b] Dispel && Test: Dispel_EX1_166b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_178a] Rooted (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: +5 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_178a", new Power {
				// TODO [EX1_178a] Rooted && Test: Rooted_EX1_178a
				InfoCardId = "EX1_178ae",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_178b] Uproot (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: +5 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_178b", new Power {
				// TODO [EX1_178b] Uproot && Test: Uproot_EX1_178b
				InfoCardId = "EX1_178be",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_573a] Demigod's Favor (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Give your other minions +2/+2.
			// --------------------------------------------------------
			cards.Add("EX1_573a", new Power {
				// TODO [EX1_573a] Demigod's Favor && Test: Demigod's Favor_EX1_573a
				InfoCardId = "EX1_573ae",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_573b] Shan'do's Lesson (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Summon two 2/2 Treants with <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_573b", new Power {
				// TODO [EX1_573b] Shan'do's Lesson && Test: Shan'do's Lesson_EX1_573b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_007a] Starfall (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal $2 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("NEW1_007a", new Power {
				// TODO [NEW1_007a] Starfall && Test: Starfall_NEW1_007a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_007b] Starfall (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal $5 damage to a minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("NEW1_007b", new Power {
				// TODO [NEW1_007b] Starfall && Test: Starfall_NEW1_007b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_008a] Ancient Teachings (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Draw a card.
			// --------------------------------------------------------
			cards.Add("NEW1_008a", new Power {
				// TODO [NEW1_008a] Ancient Teachings && Test: Ancient Teachings_NEW1_008a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_008b] Ancient Secrets (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Restore 5 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("NEW1_008b", new Power {
				// TODO [NEW1_008b] Ancient Secrets && Test: Ancient Secrets_NEW1_008b
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [EX1_531] Scavenging Hyena - COST:2 [ATK:2/HP:2] 
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever a friendly Beast dies, gain +2/+1.
			// --------------------------------------------------------
			cards.Add("EX1_531", new Power {
				// TODO [EX1_531] Scavenging Hyena && Test: Scavenging Hyena_EX1_531
				InfoCardId = "EX1_531e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [EX1_534] Savannah Highmane - COST:6 [ATK:6/HP:5] 
			// - Race: beast, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 2/2 Hyenas.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_534", new Power {
				// TODO [EX1_534] Savannah Highmane && Test: Savannah Highmane_EX1_534
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [EX1_543] King Krush - COST:9 [ATK:8/HP:8] 
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_543", new Power {
				// TODO [EX1_543] King Krush && Test: King Krush_EX1_543
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_533] Misdirection - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy attacks your hero, instead it attacks another random character.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_533", new Power {
				// TODO [EX1_533] Misdirection && Test: Misdirection_EX1_533
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_537] Explosive Shot - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage to a minion and $2 damage to adjacent ones. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_537", new Power {
				// TODO [EX1_537] Explosive Shot && Test: Explosive Shot_EX1_537
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_538] Unleash the Hounds - COST:3 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: For each enemy minion, summon a 1/1 Hound with <b>Charge</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_538", new Power {
				// TODO [EX1_538] Unleash the Hounds && Test: Unleash the Hounds_EX1_538
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_544] Flare - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: All minions lose <b>Stealth</b>. Destroy all enemy <b>Secrets</b>. Draw a card.
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_544", new Power {
				// TODO [EX1_544] Flare && Test: Flare_EX1_544
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_549] Bestial Wrath - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a friendly Beast +2 Attack and <b>Immune</b> this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_TARGET_WITH_RACE = 20
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("EX1_549", new Power {
				// TODO [EX1_549] Bestial Wrath && Test: Bestial Wrath_EX1_549
				InfoCardId = "EX1_549o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_554] Snake Trap - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions is attacked, summon three 1/1 Snakes.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_554", new Power {
				// TODO [EX1_554] Snake Trap && Test: Snake Trap_EX1_554
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_609] Snipe - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, deal $4 damage to it. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_609", new Power {
				// TODO [EX1_609] Snipe && Test: Snipe_EX1_609
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_610] Explosive Trap - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your hero is attacked, deal $2 damage to all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_610", new Power {
				// TODO [EX1_610] Explosive Trap && Test: Explosive Trap_EX1_610
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_611] Freezing Trap - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy minion attacks, return it to its owner's hand. It costs (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_611", new Power {
				// TODO [EX1_611] Freezing Trap && Test: Freezing Trap_EX1_611
				InfoCardId = "EX1_611e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_617] Deadly Shot - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a random enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("EX1_617", new Power {
				// TODO [EX1_617] Deadly Shot && Test: Deadly Shot_EX1_617
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - HUNTER
			// [DS1_188] Gladiator's Longbow - COST:7 [ATK:5/HP:0] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your hero is <b>Immune</b> while attacking.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("DS1_188", new Power {
				// TODO [DS1_188] Gladiator's Longbow && Test: Gladiator's Longbow_DS1_188
				InfoCardId = "DS1_188e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - HUNTER
			// [EX1_536] Eaglehorn Bow - COST:3 [ATK:3/HP:0] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Whenever a friendly
			//       <b>Secret</b> is revealed,
			//       gain +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_536", new Power {
				// TODO [EX1_536] Eaglehorn Bow && Test: Eaglehorn Bow_EX1_536
				InfoCardId = "EX1_536e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [DS1_188e] Gladiator's Longbow enchantment (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			cards.Add("DS1_188e", new Power {
				// TODO [DS1_188e] Gladiator's Longbow enchantment && Test: Gladiator's Longbow enchantment_DS1_188e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [EX1_531e] Well Fed (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Attack and Health.
			// --------------------------------------------------------
			cards.Add("EX1_531e", new Power {
				// TODO [EX1_531e] Well Fed && Test: Well Fed_EX1_531e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [EX1_536e] Upgraded (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Durability.
			// --------------------------------------------------------
			cards.Add("EX1_536e", new Power {
				// TODO [EX1_536e] Upgraded && Test: Upgraded_EX1_536e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [EX1_549o] Bestial Wrath (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +2 Attack and <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_549o", new Power {
				// TODO [EX1_549o] Bestial Wrath && Test: Bestial Wrath_EX1_549o
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [EX1_611e] Trapped (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Will be <b>Frozen</b> again at the start of the next turn.
			// --------------------------------------------------------
			cards.Add("EX1_611e", new Power {
				// TODO [EX1_611e] Trapped && Test: Trapped_EX1_611e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [EX1_534t] Hyena (*) - COST:2 [ATK:2/HP:2] 
			// - Race: beast, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_534t", new Power {
				// TODO [EX1_534t] Hyena && Test: Hyena_EX1_534t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [EX1_538t] Hound (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_538t", new Power {
				// TODO [EX1_538t] Hound && Test: Hound_EX1_538t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [EX1_554t] Snake (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_554t", new Power {
				// TODO [EX1_554t] Snake && Test: Snake_EX1_554t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [EX1_274] Ethereal Arcanist - COST:4 [ATK:3/HP:3] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: If you control a <b>Secret</b> at_the end of your turn, gain +2/+2.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_274", new Power {
				// TODO [EX1_274] Ethereal Arcanist && Test: Ethereal Arcanist_EX1_274
				InfoCardId = "EX1_274e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [EX1_559] Archmage Antonidas - COST:7 [ATK:5/HP:7] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, add a 'Fireball' spell to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_559", new Power {
				// TODO [EX1_559] Archmage Antonidas && Test: Archmage Antonidas_EX1_559
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [EX1_608] Sorcerer's Apprentice - COST:2 [ATK:3/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Your spells cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_608", new Power {
				// TODO [EX1_608] Sorcerer's Apprentice && Test: Sorcerer's Apprentice_EX1_608
				InfoCardId = "EX1_608e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [EX1_612] Kirin Tor Mage - COST:3 [ATK:4/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> The next <b>Secret</b>
			//       you play this turn costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_612", new Power {
				// TODO [EX1_612] Kirin Tor Mage && Test: Kirin Tor Mage_EX1_612
				InfoCardId = "EX1_612o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [NEW1_012] Mana Wyrm - COST:2 [ATK:1/HP:3] 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("NEW1_012", new Power {
				// TODO [NEW1_012] Mana Wyrm && Test: Mana Wyrm_NEW1_012
				InfoCardId = "NEW1_012o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CS2_028] Blizzard - COST:6 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to all enemy minions and <b>Freeze</b> them. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CS2_028", new Power {
				// TODO [CS2_028] Blizzard && Test: Blizzard_CS2_028
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [EX1_179] Icicle - COST:2 
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If it's <b>Frozen</b>, draw a card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("EX1_179", new Power {
				// TODO [EX1_179] Icicle && Test: Icicle_EX1_179
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [EX1_180] Tome of Intellect - COST:1 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Add a random Mage spell to your hand.
			// --------------------------------------------------------
			cards.Add("EX1_180", new Power {
				// TODO [EX1_180] Tome of Intellect && Test: Tome of Intellect_EX1_180
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [EX1_275] Cone of Cold - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion and the minions next to it, and deal $1 damage to them. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_275", new Power {
				// TODO [EX1_275] Cone of Cold && Test: Cone of Cold_EX1_275
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [EX1_279] Pyroblast - COST:10 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $10 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_279", new Power {
				// TODO [EX1_279] Pyroblast && Test: Pyroblast_EX1_279
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [EX1_287] Counterspell - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent casts a spell, <b>Counter</b> it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			// RefTag:
			// - COUNTER = 1
			// --------------------------------------------------------
			cards.Add("EX1_287", new Power {
				// TODO [EX1_287] Counterspell && Test: Counterspell_EX1_287
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [EX1_289] Ice Barrier - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your
			//       hero is attacked,
			//       gain 8 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_289", new Power {
				// TODO [EX1_289] Ice Barrier && Test: Ice Barrier_EX1_289
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [EX1_294] Mirror Entity - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, summon a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_294", new Power {
				// TODO [EX1_294] Mirror Entity && Test: Mirror Entity_EX1_294
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [EX1_594] Vaporize - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a minion attacks your hero, destroy it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_594", new Power {
				// TODO [EX1_594] Vaporize && Test: Vaporize_EX1_594
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [tt_010] Spellbender - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy casts a spell on a minion, summon a 1/3 as the new target.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("tt_010", new Power {
				// TODO [tt_010] Spellbender && Test: Spellbender_tt_010
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [EX1_274e] Raw Power! (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_274e", new Power {
				// TODO [EX1_274e] Raw Power! && Test: Raw Power!_EX1_274e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- ENCHANTMENT - MAGE
			// [EX1_612o] Power of the Kirin Tor (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Your next Secret costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_612o", new Power {
				// TODO [EX1_612o] Power of the Kirin Tor && Test: Power of the Kirin Tor_EX1_612o
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- ENCHANTMENT - MAGE
			// [NEW1_012o] Mana Gorged (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased attack.
			// --------------------------------------------------------
			cards.Add("NEW1_012o", new Power {
				// TODO [NEW1_012o] Mana Gorged && Test: Mana Gorged_NEW1_012o
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [tt_010a] Spellbender (*) - COST:1 [ATK:1/HP:3] 
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			cards.Add("tt_010a", new Power {
				// TODO [tt_010a] Spellbender && Test: Spellbender_tt_010a
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [EX1_362] Argent Protector - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_362", new Power {
				// TODO [EX1_362] Argent Protector && Test: Argent Protector_EX1_362
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [EX1_382] Aldor Peacekeeper - COST:3 [ATK:3/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Change an_enemy minion's Attack to 1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_382", new Power {
				// TODO [EX1_382] Aldor Peacekeeper && Test: Aldor Peacekeeper_EX1_382
				InfoCardId = "EX1_382e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [EX1_383] Tirion Fordring - COST:8 [ATK:6/HP:6] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b><b>Divine Shield</b>,</b> <b>Taunt</b> <b>Deathrattle:</b> Equip a 5/3_Ashbringer.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_383", new Power {
				// TODO [EX1_383] Tirion Fordring && Test: Tirion Fordring_EX1_383
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_130] Noble Sacrifice - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy attacks, summon a 2/1 Defender as the new target.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_130", new Power {
				// TODO [EX1_130] Noble Sacrifice && Test: Noble Sacrifice_EX1_130
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_132] Eye for an Eye - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your hero takes damage, deal_that much damage to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_132", new Power {
				// TODO [EX1_132] Eye for an Eye && Test: Eye for an Eye_EX1_132
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_136] Redemption - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a friendly minion dies, return it to life with 1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_136", new Power {
				// TODO [EX1_136] Redemption && Test: Redemption_EX1_136
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_349] Divine Favor - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw cards until you have as many in hand as your opponent.
			// --------------------------------------------------------
			cards.Add("EX1_349", new Power {
				// TODO [EX1_349] Divine Favor && Test: Divine Favor_EX1_349
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_354] Lay on Hands - COST:8 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Restore #8 Health. Draw_3 cards.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_354", new Power {
				// TODO [EX1_354] Lay on Hands && Test: Lay on Hands_EX1_354
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_355] Blessed Champion - COST:5 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Double a minion's Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_355", new Power {
				// TODO [EX1_355] Blessed Champion && Test: Blessed Champion_EX1_355
				InfoCardId = "EX1_355e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_363] Blessing of Wisdom - COST:1 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Choose a minion. Whenever it attacks, draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_363", new Power {
				// TODO [EX1_363] Blessing of Wisdom && Test: Blessing of Wisdom_EX1_363
				InfoCardId = "EX1_363e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_365] Holy Wrath - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw a card and deal_damage equal to_its Cost. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_365", new Power {
				// TODO [EX1_365] Holy Wrath && Test: Holy Wrath_EX1_365
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_379] Repentance - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, reduce its Health to 1.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_379", new Power {
				// TODO [EX1_379] Repentance && Test: Repentance_EX1_379
				InfoCardId = "EX1_379e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_384] Avenging Wrath - COST:6 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $8 damage randomly split among all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("EX1_384", new Power {
				// TODO [EX1_384] Avenging Wrath && Test: Avenging Wrath_EX1_384
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_619] Equality - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Change the Health of ALL minions to 1.
			// --------------------------------------------------------
			cards.Add("EX1_619", new Power {
				// TODO [EX1_619] Equality && Test: Equality_EX1_619
				InfoCardId = "EX1_619e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [EX1_366] Sword of Justice - COST:3 [ATK:1/HP:0] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: After you summon a minion, give it +1/+1 and this loses 1_Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 5
			// --------------------------------------------------------
			cards.Add("EX1_366", new Power {
				// TODO [EX1_366] Sword of Justice && Test: Sword of Justice_EX1_366
				InfoCardId = "EX1_366e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_355e] Blessed Champion (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion's Attack has been doubled.
			// --------------------------------------------------------
			cards.Add("EX1_355e", new Power {
				// TODO [EX1_355e] Blessed Champion && Test: Blessed Champion_EX1_355e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_363e] Blessing of Wisdom (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: When this minion attacks, the player who blessed it draws a card.
			// --------------------------------------------------------
			cards.Add("EX1_363e", new Power {
				// TODO [EX1_363e] Blessing of Wisdom && Test: Blessing of Wisdom_EX1_363e
				InfoCardId = "EX1_363e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_363e2] Blessing of Wisdom (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: When this minion attacks, the enemy player draws a card.
			// --------------------------------------------------------
			cards.Add("EX1_363e2", new Power {
				// TODO [EX1_363e2] Blessing of Wisdom && Test: Blessing of Wisdom_EX1_363e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_366e] Justice Served (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Has +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_366e", new Power {
				// TODO [EX1_366e] Justice Served && Test: Justice Served_EX1_366e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_379e] Repentance (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Health reduced to 1.
			// --------------------------------------------------------
			cards.Add("EX1_379e", new Power {
				// TODO [EX1_379e] Repentance && Test: Repentance_EX1_379e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_382e] Stand Down! (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Attack changed to 1.
			// --------------------------------------------------------
			cards.Add("EX1_382e", new Power {
				// TODO [EX1_382e] Stand Down! && Test: Stand Down!_EX1_382e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_619e] Equality (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Health changed to 1.
			// --------------------------------------------------------
			cards.Add("EX1_619e", new Power {
				// TODO [EX1_619e] Equality && Test: Equality_EX1_619e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [EX1_130a] Defender (*) - COST:1 [ATK:2/HP:1] 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_130a", new Power {
				// TODO [EX1_130a] Defender && Test: Defender_EX1_130a
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [EX1_383t] Ashbringer (*) - COST:5 [ATK:5/HP:0] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("EX1_383t", new Power {
				// TODO [EX1_383t] Ashbringer && Test: Ashbringer_EX1_383t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [EX1_091] Cabal Shadow Priest - COST:6 [ATK:4/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Take control of an enemy minion that has 2 or less Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_MAX_ATTACK = 2
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_091", new Power {
				// TODO [EX1_091] Cabal Shadow Priest && Test: Cabal Shadow Priest_EX1_091
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [EX1_335] Lightspawn - COST:4 [ATK:0/HP:5] 
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: This minion's Attack is always equal to its Health.
			// --------------------------------------------------------
			cards.Add("EX1_335", new Power {
				// TODO [EX1_335] Lightspawn && Test: Lightspawn_EX1_335
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [EX1_341] Lightwell - COST:2 [ATK:0/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, restore #3 Health to a damaged friendly character.
			// --------------------------------------------------------
			cards.Add("EX1_341", new Power {
				// TODO [EX1_341] Lightwell && Test: Lightwell_EX1_341
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [EX1_350] Prophet Velen - COST:7 [ATK:7/HP:7] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Double the damage and healing of your spells and Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_350", new Power {
				// TODO [EX1_350] Prophet Velen && Test: Prophet Velen_EX1_350
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [EX1_591] Auchenai Soulpriest - COST:4 [ATK:3/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Your cards and powers that restore Health now deal damage instead.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_591", new Power {
				// TODO [EX1_591] Auchenai Soulpriest && Test: Auchenai Soulpriest_EX1_591
				InfoCardId = "EX1_591e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [EX1_623] Temple Enforcer - COST:6 [ATK:6/HP:6] 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +3 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_623", new Power {
				// TODO [EX1_623] Temple Enforcer && Test: Temple Enforcer_EX1_623
				InfoCardId = "EX1_623e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CS1_129] Inner Fire - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Change a minion's Attack to be equal to its Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS1_129", new Power {
				// TODO [CS1_129] Inner Fire && Test: Inner Fire_CS1_129
				InfoCardId = "CS1_129e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_332] Silence - COST:0 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Silence</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_332", new Power {
				// TODO [EX1_332] Silence && Test: Silence_EX1_332
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_334] Shadow Madness - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Gain control of an enemy minion with 3 or less Attack until end of turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_TARGET_MAX_ATTACK = 3
			// --------------------------------------------------------
			cards.Add("EX1_334", new Power {
				// TODO [EX1_334] Shadow Madness && Test: Shadow Madness_EX1_334
				InfoCardId = "EX1_334e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_339] Thoughtsteal - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Copy 2 cards in your opponent's deck and add them to your hand.
			// --------------------------------------------------------
			cards.Add("EX1_339", new Power {
				// TODO [EX1_339] Thoughtsteal && Test: Thoughtsteal_EX1_339
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_345] Mindgames - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Put a copy of
			//       a random minion from
			//       your opponent's deck into the battlefield.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("EX1_345", new Power {
				// TODO [EX1_345] Mindgames && Test: Mindgames_EX1_345
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_621] Circle of Healing - COST:0 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #4 Health to ALL_minions.
			// --------------------------------------------------------
			cards.Add("EX1_621", new Power {
				// TODO [EX1_621] Circle of Healing && Test: Circle of Healing_EX1_621
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_624] Holy Fire - COST:6 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage. Restore #5 Health to your hero. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_624", new Power {
				// TODO [EX1_624] Holy Fire && Test: Holy Fire_EX1_624
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_625] Shadowform - COST:3 
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your Hero Power becomes 'Deal 2 damage'. If already in Shadowform: 3 damage.
			// --------------------------------------------------------
			cards.Add("EX1_625", new Power {
				// TODO [EX1_625] Shadowform && Test: Shadowform_EX1_625
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_626] Mass Dispel - COST:4 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Silence</b> all enemy minions. Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("EX1_626", new Power {
				// TODO [EX1_626] Mass Dispel && Test: Mass Dispel_EX1_626
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CS1_129e] Inner Fire (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion's Attack is equal to its Health.
			// --------------------------------------------------------
			cards.Add("CS1_129e", new Power {
				// TODO [CS1_129e] Inner Fire && Test: Inner Fire_CS1_129e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [EX1_334e] Shadow Madness (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion has switched controllers this turn.
			// --------------------------------------------------------
			cards.Add("EX1_334e", new Power {
				// TODO [EX1_334e] Shadow Madness && Test: Shadow Madness_EX1_334e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [EX1_623e] Infusion (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("EX1_623e", new Power {
				// TODO [EX1_623e] Infusion && Test: Infusion_EX1_623e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [EX1_tk31] Mind Controlling (*) - COST:0 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// GameTag:
			// - SUMMONED = 1
			// --------------------------------------------------------
			cards.Add("EX1_tk31", new Power {
				// TODO [EX1_tk31] Mind Controlling && Test: Mind Controlling_EX1_tk31
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [EX1_345t] Shadow of Nothing (*) - COST:0 [ATK:0/HP:1] 
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Mindgames whiffed! Your opponent had no minions!
			// --------------------------------------------------------
			cards.Add("EX1_345t", new Power {
				// TODO [EX1_345t] Shadow of Nothing && Test: Shadow of Nothing_EX1_345t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [EX1_131] Defias Ringleader - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Summon a 2/1 Defias Bandit.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("EX1_131", new Power {
				// TODO [EX1_131] Defias Ringleader && Test: Defias Ringleader_EX1_131
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [EX1_134] SI:7 Agent - COST:3 [ATK:3/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Deal 2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_FOR_COMBO = 0
			// --------------------------------------------------------
			cards.Add("EX1_134", new Power {
				// TODO [EX1_134] SI:7 Agent && Test: SI:7 Agent_EX1_134
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [EX1_522] Patient Assassin - COST:2 [ATK:1/HP:1] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//        <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("EX1_522", new Power {
				// TODO [EX1_522] Patient Assassin && Test: Patient Assassin_EX1_522
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [EX1_613] Edwin VanCleef - COST:3 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Gain +2/+2 for each other card you've played this turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("EX1_613", new Power {
				// TODO [EX1_613] Edwin VanCleef && Test: Edwin VanCleef_EX1_613
				InfoCardId = "EX1_613e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [NEW1_005] Kidnapper - COST:6 [ATK:5/HP:3] 
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Return a minion to_its owner's hand.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_FOR_COMBO = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("NEW1_005", new Power {
				// TODO [NEW1_005] Kidnapper && Test: Kidnapper_NEW1_005
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [NEW1_014] Master of Disguise - COST:4 [ATK:4/HP:4] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("NEW1_014", new Power {
				// TODO [NEW1_014] Master of Disguise && Test: Master of Disguise_NEW1_014
				InfoCardId = "NEW1_014e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_073] Cold Blood - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
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
			cards.Add("CS2_073", new Power {
				// TODO [CS2_073] Cold Blood && Test: Cold Blood_CS2_073
				InfoCardId = "CS2_073e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_233] Blade Flurry - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy your weapon and deal its damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			cards.Add("CS2_233", new Power {
				// TODO [CS2_233] Blade Flurry && Test: Blade Flurry_CS2_233
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_124] Eviscerate - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage. <b>Combo:</b> Deal $4 damage instead. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_124", new Power {
				// TODO [EX1_124] Eviscerate && Test: Eviscerate_EX1_124
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_126] Betrayal - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Force an enemy minion to deal its damage to the minions next to it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_126", new Power {
				// TODO [EX1_126] Betrayal && Test: Betrayal_EX1_126
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_137] Headcrack - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to the enemy hero. <b>Combo:</b> Return this to your hand next turn. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("EX1_137", new Power {
				// TODO [EX1_137] Headcrack && Test: Headcrack_EX1_137
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_144] Shadowstep - COST:0 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Return a friendly minion to your hand. It_costs (2) less.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_144", new Power {
				// TODO [EX1_144] Shadowstep && Test: Shadowstep_EX1_144
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_145] Preparation - COST:0 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (3) less.
			// --------------------------------------------------------
			cards.Add("EX1_145", new Power {
				// TODO [EX1_145] Preparation && Test: Preparation_EX1_145
				InfoCardId = "EX1_145o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_182] Pilfer - COST:1 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Add a random card to your hand <i>(from your opponent's class)</i>.
			// --------------------------------------------------------
			cards.Add("EX1_182", new Power {
				// TODO [EX1_182] Pilfer && Test: Pilfer_EX1_182
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [EX1_133] Perdition's Blade - COST:3 [ATK:2/HP:0] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage. <b>Combo:</b> Deal 2 instead.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_133", new Power {
				// TODO [EX1_133] Perdition's Blade && Test: Perdition's Blade_EX1_133
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CS2_073e] Cold Blood (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_073e", new Power {
				// TODO [CS2_073e] Cold Blood && Test: Cold Blood_CS2_073e
				InfoCardId = "CS2_073e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CS2_073e2] Cold Blood (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +4 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_073e2", new Power {
				// TODO [CS2_073e2] Cold Blood && Test: Cold Blood_CS2_073e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [EX1_145o] Preparation (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_145o", new Power {
				// TODO [EX1_145o] Preparation && Test: Preparation_EX1_145o
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [EX1_613e] VanCleef's Vengeance (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_613e", new Power {
				// TODO [EX1_613e] VanCleef's Vengeance && Test: VanCleef's Vengeance_EX1_613e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [NEW1_014e] Disguised (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Stealthed until your next turn.
			// --------------------------------------------------------
			cards.Add("NEW1_014e", new Power {
				// TODO [NEW1_014e] Disguised && Test: Disguised_NEW1_014e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [EX1_131t] Defias Bandit (*) - COST:1 [ATK:2/HP:1] 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_131t", new Power {
				// TODO [EX1_131t] Defias Bandit && Test: Defias Bandit_EX1_131t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [EX1_243] Dust Devil - COST:1 [ATK:3/HP:1] 
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>. <b>Overload:</b> (2)
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			cards.Add("EX1_243", new Power {
				// TODO [EX1_243] Dust Devil && Test: Dust Devil_EX1_243
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_250] Earth Elemental - COST:5 [ATK:7/HP:8] 
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b><b>Overload</b>:</b> (3)
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - OVERLOAD = 3
			// - OVERLOAD_OWED = 3
			// --------------------------------------------------------
			cards.Add("EX1_250", new Power {
				// TODO [EX1_250] Earth Elemental && Test: Earth Elemental_EX1_250
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_258] Unbound Elemental - COST:3 [ATK:2/HP:4] 
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you play a card_with <b>Overload</b>, gain_+1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("EX1_258", new Power {
				// TODO [EX1_258] Unbound Elemental && Test: Unbound Elemental_EX1_258
				InfoCardId = "EX1_258e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_575] Mana Tide Totem - COST:3 [ATK:0/HP:3] 
			// - Race: totem, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, draw a card.
			// --------------------------------------------------------
			cards.Add("EX1_575", new Power {
				// TODO [EX1_575] Mana Tide Totem && Test: Mana Tide Totem_EX1_575
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [NEW1_010] Al'Akir the Windlord - COST:8 [ATK:3/HP:5] 
			// - Race: elemental, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge, Divine Shield, Taunt, Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - WINDFURY = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("NEW1_010", new Power {
				// TODO [NEW1_010] Al'Akir the Windlord && Test: Al'Akir the Windlord_NEW1_010
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_038] Ancestral Spirit - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion "<b>Deathrattle:</b> Resummon this minion."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CS2_038", new Power {
				// TODO [CS2_038] Ancestral Spirit && Test: Ancestral Spirit_CS2_038
				InfoCardId = "CS2_038e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_053] Far Sight - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw a card. That card costs (3) less.
			// --------------------------------------------------------
			cards.Add("CS2_053", new Power {
				// TODO [CS2_053] Far Sight && Test: Far Sight_CS2_053
				InfoCardId = "CS2_053e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_238] Lightning Bolt - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage. <b>Overload:</b> (1) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_238", new Power {
				// TODO [EX1_238] Lightning Bolt && Test: Lightning Bolt_EX1_238
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_241] Lava Burst - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage. <b>Overload:</b> (2) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_241", new Power {
				// TODO [EX1_241] Lava Burst && Test: Lava Burst_EX1_241
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_245] Earth Shock - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Silence</b> a minion, then deal $1 damage to it. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_245", new Power {
				// TODO [EX1_245] Earth Shock && Test: Earth Shock_EX1_245
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_248] Feral Spirit - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon two 2/3 Spirit Wolves with <b>Taunt</b>. <b>Overload:</b> (2)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_248", new Power {
				// TODO [EX1_248] Feral Spirit && Test: Feral Spirit_EX1_248
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_251] Forked Lightning - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to 2_random enemy minions. <b>Overload:</b> (2) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("EX1_251", new Power {
				// TODO [EX1_251] Forked Lightning && Test: Forked Lightning_EX1_251
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_259] Lightning Storm - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2-$3 damage to all_enemy minions. <b>Overload:</b> (2) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			cards.Add("EX1_259", new Power {
				// TODO [EX1_259] Lightning Storm && Test: Lightning Storm_EX1_259
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [EX1_247] Stormforged Axe - COST:2 [ATK:2/HP:0] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			cards.Add("EX1_247", new Power {
				// TODO [EX1_247] Stormforged Axe && Test: Stormforged Axe_EX1_247
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [EX1_567] Doomhammer - COST:5 [ATK:2/HP:0] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Windfury, Overload:</b> (2)
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 8
			// - WINDFURY = 1
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			cards.Add("EX1_567", new Power {
				// TODO [EX1_567] Doomhammer && Test: Doomhammer_EX1_567
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [CS2_038e] Ancestral Spirit (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Resummon this minion.
			// --------------------------------------------------------
			cards.Add("CS2_038e", new Power {
				// TODO [CS2_038e] Ancestral Spirit && Test: Ancestral Spirit_CS2_038e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [CS2_053e] Far Sight (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: One of your cards costs (3) less.
			// --------------------------------------------------------
			cards.Add("CS2_053e", new Power {
				// TODO [CS2_053e] Far Sight && Test: Far Sight_CS2_053e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [EX1_258e] Overloading (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_258e", new Power {
				// TODO [EX1_258e] Overloading && Test: Overloading_EX1_258e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_tk11] Spirit Wolf (*) - COST:2 [ATK:2/HP:3] 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_tk11", new Power {
				// TODO [EX1_tk11] Spirit Wolf && Test: Spirit Wolf_EX1_tk11
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [CS2_059] Blood Imp - COST:1 [ATK:0/HP:1] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: [x]  <b>Stealth</b>. At the end of your  
			//       turn, give another random
			//        friendly minion +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CS2_059", new Power {
				// TODO [CS2_059] Blood Imp && Test: Blood Imp_CS2_059
				InfoCardId = "CS2_059o",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_301] Felguard - COST:3 [ATK:3/HP:5] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Destroy one of your Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_301", new Power {
				// TODO [EX1_301] Felguard && Test: Felguard_EX1_301
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_304] Void Terror - COST:3 [ATK:3/HP:3] 
			// - Race: demon, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Destroy both
			//       adjacent minions and gain
			//        their Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_304", new Power {
				// TODO [EX1_304] Void Terror && Test: Void Terror_EX1_304
				InfoCardId = "EX1_304e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_310] Doomguard - COST:5 [ATK:5/HP:7] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Charge</b>. <b>Battlecry:</b> Discard two random cards.
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - BATTLECRY = 1
			// - DISCARD_CARDS = 2
			// --------------------------------------------------------
			cards.Add("EX1_310", new Power {
				// TODO [EX1_310] Doomguard && Test: Doomguard_EX1_310
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_313] Pit Lord - COST:4 [ATK:5/HP:6] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 5 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_313", new Power {
				// TODO [EX1_313] Pit Lord && Test: Pit Lord_EX1_313
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_315] Summoning Portal - COST:4 [ATK:0/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Your minions cost (2) less, but not less than (1).
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_315", new Power {
				// TODO [EX1_315] Summoning Portal && Test: Summoning Portal_EX1_315
				InfoCardId = "EX1_315e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_319] Flame Imp - COST:1 [ATK:3/HP:2] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_319", new Power {
				// TODO [EX1_319] Flame Imp && Test: Flame Imp_EX1_319
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_323] Lord Jaraxxus - COST:9 [ATK:3/HP:15] 
			// - Race: demon, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your hero and replace it with Lord Jaraxxus.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_323", new Power {
				// TODO [EX1_323] Lord Jaraxxus && Test: Lord Jaraxxus_EX1_323
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_181] Call of the Void - COST:1 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Add a random Demon to your hand.
			// --------------------------------------------------------
			cards.Add("EX1_181", new Power {
				// TODO [EX1_181] Call of the Void && Test: Call of the Void_EX1_181
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_303] Shadowflame - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a friendly minion and deal its Attack damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_303", new Power {
				// TODO [EX1_303] Shadowflame && Test: Shadowflame_EX1_303
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_309] Siphon Soul - COST:6 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a minion. Restore #3 Health to_your hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_309", new Power {
				// TODO [EX1_309] Siphon Soul && Test: Siphon Soul_EX1_309
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_312] Twisting Nether - COST:8 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all minions.
			// --------------------------------------------------------
			cards.Add("EX1_312", new Power {
				// TODO [EX1_312] Twisting Nether && Test: Twisting Nether_EX1_312
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_317] Sense Demons - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 Demons
			//       from your deck.
			// --------------------------------------------------------
			cards.Add("EX1_317", new Power {
				// TODO [EX1_317] Sense Demons && Test: Sense Demons_EX1_317
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_320] Bane of Doom - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to_a character. If that kills it, summon a random Demon. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_320", new Power {
				// TODO [EX1_320] Bane of Doom && Test: Bane of Doom_EX1_320
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_596] Demonfire - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If it’s a friendly Demon, give it +2/+2 instead. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_596", new Power {
				// TODO [EX1_596] Demonfire && Test: Demonfire_EX1_596
				InfoCardId = "EX1_596e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [CS2_059o] Blood Pact (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("CS2_059o", new Power {
				// TODO [CS2_059o] Blood Pact && Test: Blood Pact_CS2_059o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [EX1_304e] Consume (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_304e", new Power {
				// TODO [EX1_304e] Consume && Test: Consume_EX1_304e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [EX1_596e] Demonfire (*) - COST:0 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: This Demon has +2/+2.
			// --------------------------------------------------------
			cards.Add("EX1_596e", new Power {
				// TODO [EX1_596e] Demonfire && Test: Demonfire_EX1_596e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_317t] Worthless Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Set: expert1, 
			// --------------------------------------------------------
			// Text: <i>You are out of demons! At least there are always imps...</i>
			// --------------------------------------------------------
			cards.Add("EX1_317t", new Power {
				// TODO [EX1_317t] Worthless Imp && Test: Worthless Imp_EX1_317t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_tk34] Infernal (*) - COST:6 [ATK:6/HP:6] 
			// - Race: demon, Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_tk34", new Power {
				// TODO [EX1_tk34] Infernal && Test: Infernal_EX1_tk34
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARLOCK
			// [EX1_323w] Blood Fury (*) - COST:3 [ATK:3/HP:0] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 8
			// --------------------------------------------------------
			cards.Add("EX1_323w", new Power {
				// TODO [EX1_323w] Blood Fury && Test: Blood Fury_EX1_323w
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [EX1_398] Arathi Weaponsmith - COST:4 [ATK:3/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip a 2/2_weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_398", new Power {
				// TODO [EX1_398] Arathi Weaponsmith && Test: Arathi Weaponsmith_EX1_398
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [EX1_402] Armorsmith - COST:2 [ATK:1/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a friendly minion_takes damage, gain 1 Armor.
			// --------------------------------------------------------
			cards.Add("EX1_402", new Power {
				// TODO [EX1_402] Armorsmith && Test: Armorsmith_EX1_402
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [EX1_414] Grommash Hellscream - COST:8 [ATK:4/HP:9] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       Has +6 Attack while damaged.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_414", new Power {
				// TODO [EX1_414] Grommash Hellscream && Test: Grommash Hellscream_EX1_414
				InfoCardId = "EX1_414e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [EX1_603] Cruel Taskmaster - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage to a minion and give it +2_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_603", new Power {
				// TODO [EX1_603] Cruel Taskmaster && Test: Cruel Taskmaster_EX1_603
				InfoCardId = "EX1_603e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [EX1_604] Frothing Berserker - COST:3 [ATK:2/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a minion takes damage, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_604", new Power {
				// TODO [EX1_604] Frothing Berserker && Test: Frothing Berserker_EX1_604
				InfoCardId = "EX1_604o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CS2_104] Rampage - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Give a damaged minion +3/+3.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_DAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_104", new Power {
				// TODO [CS2_104] Rampage && Test: Rampage_CS2_104
				InfoCardId = "CS2_104e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_391] Slam - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If it survives, draw a card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_391", new Power {
				// TODO [EX1_391] Slam && Test: Slam_EX1_391
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_392] Battle Rage - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Draw a card for each damaged friendly character.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_392", new Power {
				// TODO [EX1_392] Battle Rage && Test: Battle Rage_EX1_392
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_407] Brawl - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all minions except one. <i>(chosen randomly)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("EX1_407", new Power {
				// TODO [EX1_407] Brawl && Test: Brawl_EX1_407
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_408] Mortal Strike - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $4 damage. If you have 12 or less Health, deal $6 instead. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_408", new Power {
				// TODO [EX1_408] Mortal Strike && Test: Mortal Strike_EX1_408
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_409] Upgrade! - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: If you have a weapon, give it +1/+1. Otherwise equip a 1/3 weapon.
			// --------------------------------------------------------
			cards.Add("EX1_409", new Power {
				// TODO [EX1_409] Upgrade! && Test: Upgrade!_EX1_409
				InfoCardId = "EX1_409e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_410] Shield Slam - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal 1 damage to a minion for each Armor you have. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_410", new Power {
				// TODO [EX1_410] Shield Slam && Test: Shield Slam_EX1_410
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_607] Inner Rage - COST:0 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage to a minion and give it +2_Attack. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_607", new Power {
				// TODO [EX1_607] Inner Rage && Test: Inner Rage_EX1_607
				InfoCardId = "EX1_607e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [NEW1_036] Commanding Shout - COST:2 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Your minions can't be reduced below 1 Health this turn. Draw a card.
			// --------------------------------------------------------
			cards.Add("NEW1_036", new Power {
				// TODO [NEW1_036] Commanding Shout && Test: Commanding Shout_NEW1_036
				InfoCardId = "NEW1_036e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [EX1_411] Gorehowl - COST:7 [ATK:7/HP:0] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Attacking a minion costs 1 Attack instead of 1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 1
			// --------------------------------------------------------
			cards.Add("EX1_411", new Power {
				// TODO [EX1_411] Gorehowl && Test: Gorehowl_EX1_411
				InfoCardId = "EX1_411e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CS2_104e] Rampage (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("CS2_104e", new Power {
				// TODO [CS2_104e] Rampage && Test: Rampage_CS2_104e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_409e] Upgraded (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +1 Attack and +1 Durability.
			// --------------------------------------------------------
			cards.Add("EX1_409e", new Power {
				// TODO [EX1_409e] Upgraded && Test: Upgraded_EX1_409e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_411e] Bloodrage (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: No durability loss.
			// --------------------------------------------------------
			cards.Add("EX1_411e", new Power {
				// TODO [EX1_411e] Bloodrage && Test: Bloodrage_EX1_411e
				InfoCardId = "EX1_411e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_411e2] Needs Sharpening (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Decreased Attack.
			// --------------------------------------------------------
			cards.Add("EX1_411e2", new Power {
				// TODO [EX1_411e2] Needs Sharpening && Test: Needs Sharpening_EX1_411e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_414e] Enraged (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +6 Attack
			// --------------------------------------------------------
			cards.Add("EX1_414e", new Power {
				// TODO [EX1_414e] Enraged && Test: Enraged_EX1_414e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_603e] Whipped Into Shape (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_603e", new Power {
				// TODO [EX1_603e] Whipped Into Shape && Test: Whipped Into Shape_EX1_603e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_604o] Berserk (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("EX1_604o", new Power {
				// TODO [EX1_604o] Berserk && Test: Berserk_EX1_604o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_607e] Inner Rage (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_607e", new Power {
				// TODO [EX1_607e] Inner Rage && Test: Inner Rage_EX1_607e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [NEW1_036e] Commanding Shout (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Can't be reduced below 1 Health this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("NEW1_036e", new Power {
				// TODO [NEW1_036e] Commanding Shout && Test: Commanding Shout_NEW1_036e
				InfoCardId = "NEW1_036e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [NEW1_036e2] Commanding Shout (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Your minions can't be reduced below 1 Health this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("NEW1_036e2", new Power {
				// TODO [NEW1_036e2] Commanding Shout && Test: Commanding Shout_NEW1_036e2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [EX1_398t] Battle Axe (*) - COST:1 [ATK:2/HP:0] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("EX1_398t", new Power {
				// TODO [EX1_398t] Battle Axe && Test: Battle Axe_EX1_398t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [EX1_409t] Heavy Axe (*) - COST:1 [ATK:1/HP:0] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("EX1_409t", new Power {
				// TODO [EX1_409t] Heavy Axe && Test: Heavy Axe_EX1_409t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DreamNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DREAM
			// [DREAM_01] Laughing Sister (*) - COST:3 [ATK:3/HP:5] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("DREAM_01", new Power {
				// TODO [DREAM_01] Laughing Sister && Test: Laughing Sister_DREAM_01
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DREAM
			// [DREAM_03] Emerald Drake (*) - COST:4 [ATK:7/HP:6] 
			// - Race: dragon, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("DREAM_03", new Power {
				// TODO [DREAM_03] Emerald Drake && Test: Emerald Drake_DREAM_03
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DREAM
			// [DREAM_02] Ysera Awakens (*) - COST:2 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal $5 damage to all characters except Ysera. @spelldmg
			// --------------------------------------------------------
			cards.Add("DREAM_02", new Power {
				// TODO [DREAM_02] Ysera Awakens && Test: Ysera Awakens_DREAM_02
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DREAM
			// [DREAM_04] Dream (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Return a minion to its owner's hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DREAM_04", new Power {
				// TODO [DREAM_04] Dream && Test: Dream_DREAM_04
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DREAM
			// [DREAM_05] Nightmare (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Give a minion +5/+5. At the start of your next turn, destroy it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DREAM_05", new Power {
				// TODO [DREAM_05] Nightmare && Test: Nightmare_DREAM_05
				InfoCardId = "DREAM_05e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [CS1_069] Fen Creeper - COST:5 [ATK:3/HP:6] 
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS1_069", new Power {
				// TODO [CS1_069] Fen Creeper && Test: Fen Creeper_CS1_069
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_117] Earthen Ring Farseer - COST:3 [ATK:3/HP:3] 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore #3_Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CS2_117", new Power {
				// TODO [CS2_117] Earthen Ring Farseer && Test: Earthen Ring Farseer_CS2_117
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_146] Southsea Deckhand - COST:1 [ATK:2/HP:1] 
			// - Race: pirate, Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Has <b>Charge</b> while you have a weapon equipped.
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CS2_146", new Power {
				// TODO [CS2_146] Southsea Deckhand && Test: Southsea Deckhand_CS2_146
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_151] Silver Hand Knight - COST:5 [ATK:4/HP:4] 
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/2_Squire.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_151", new Power {
				// TODO [CS2_151] Silver Hand Knight && Test: Silver Hand Knight_CS2_151
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_161] Ravenholdt Assassin - COST:7 [ATK:7/HP:5] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CS2_161", new Power {
				// TODO [CS2_161] Ravenholdt Assassin && Test: Ravenholdt Assassin_CS2_161
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_169] Young Dragonhawk - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("CS2_169", new Power {
				// TODO [CS2_169] Young Dragonhawk && Test: Young Dragonhawk_CS2_169
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_181] Injured Blademaster - COST:3 [ATK:4/HP:7] 
			// - Fac: horde, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 4 damage to HIMSELF.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_181", new Power {
				// TODO [CS2_181] Injured Blademaster && Test: Injured Blademaster_CS2_181
				InfoCardId = "CS2_181e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_188] Abusive Sergeant - COST:1 [ATK:1/HP:1] 
			// - Fac: alliance, Set: expert1, Rarity: common
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
			cards.Add("CS2_188", new Power {
				// TODO [CS2_188] Abusive Sergeant && Test: Abusive Sergeant_CS2_188
				InfoCardId = "CS2_188o",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_203] Ironbeak Owl - COST:3 [ATK:2/HP:1] 
			// - Race: beast, Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b> a_minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("CS2_203", new Power {
				// TODO [CS2_203] Ironbeak Owl && Test: Ironbeak Owl_CS2_203
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_221] Spiteful Smith - COST:5 [ATK:4/HP:6] 
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Your weapon has +2 Attack while this is damaged.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("CS2_221", new Power {
				// TODO [CS2_221] Spiteful Smith && Test: Spiteful Smith_CS2_221
				InfoCardId = "CS2_221e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_227] Venture Co. Mercenary - COST:5 [ATK:7/HP:6] 
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Your minions cost (3) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("CS2_227", new Power {
				// TODO [CS2_227] Venture Co. Mercenary && Test: Venture Co. Mercenary_CS2_227
				InfoCardId = "CS2_227e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_231] Wisp - COST:0 [ATK:1/HP:1] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("CS2_231", new Power {
				// TODO [CS2_231] Wisp && Test: Wisp_CS2_231
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_001] Lightwarden - COST:1 [ATK:1/HP:2] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a character is healed, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_001", new Power {
				// TODO [EX1_001] Lightwarden && Test: Lightwarden_EX1_001
				InfoCardId = "EX1_001e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_002] The Black Knight - COST:6 [ATK:4/HP:5] 
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy an enemy minion with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_MUST_TARGET_TAUNTER = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_002", new Power {
				// TODO [EX1_002] The Black Knight && Test: The Black Knight_EX1_002
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_004] Young Priestess - COST:1 [ATK:2/HP:1] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, give another random friendly minion +1 Health.
			// --------------------------------------------------------
			cards.Add("EX1_004", new Power {
				// TODO [EX1_004] Young Priestess && Test: Young Priestess_EX1_004
				InfoCardId = "EX1_004e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_005] Big Game Hunter - COST:5 [ATK:4/HP:2] 
			// - Set: expert1, Rarity: epic
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
			cards.Add("EX1_005", new Power {
				// TODO [EX1_005] Big Game Hunter && Test: Big Game Hunter_EX1_005
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_006] Alarm-o-Bot - COST:3 [ATK:0/HP:3] 
			// - Race: mechanical, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]At the start of your turn,
			//       swap this minion with a
			//          random one in your hand.
			// --------------------------------------------------------
			cards.Add("EX1_006", new Power {
				// TODO [EX1_006] Alarm-o-Bot && Test: Alarm-o-Bot_EX1_006
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_007] Acolyte of Pain - COST:3 [ATK:1/HP:3] 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, draw a_card.
			// --------------------------------------------------------
			cards.Add("EX1_007", new Power {
				// TODO [EX1_007] Acolyte of Pain && Test: Acolyte of Pain_EX1_007
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_008] Argent Squire - COST:1 [ATK:1/HP:1] 
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_008", new Power {
				// TODO [EX1_008] Argent Squire && Test: Argent Squire_EX1_008
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_009] Angry Chicken - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Has +5 Attack while damaged.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_009", new Power {
				// TODO [EX1_009] Angry Chicken && Test: Angry Chicken_EX1_009
				InfoCardId = "EX1_009e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_010] Worgen Infiltrator - COST:1 [ATK:2/HP:1] 
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("EX1_010", new Power {
				// TODO [EX1_010] Worgen Infiltrator && Test: Worgen Infiltrator_EX1_010
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_012] Bloodmage Thalnos - COST:2 [ATK:1/HP:1] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			//       <b>Deathrattle:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - SPELLPOWER = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_012", new Power {
				// TODO [EX1_012] Bloodmage Thalnos && Test: Bloodmage Thalnos_EX1_012
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_014] King Mukla - COST:3 [ATK:5/HP:5] 
			// - Race: beast, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your opponent 2 Bananas.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_014", new Power {
				// TODO [EX1_014] King Mukla && Test: King Mukla_EX1_014
				InfoCardId = "EX1_014te",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_017] Jungle Panther - COST:3 [ATK:4/HP:2] 
			// - Race: beast, Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("EX1_017", new Power {
				// TODO [EX1_017] Jungle Panther && Test: Jungle Panther_EX1_017
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_020] Scarlet Crusader - COST:3 [ATK:3/HP:1] 
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_020", new Power {
				// TODO [EX1_020] Scarlet Crusader && Test: Scarlet Crusader_EX1_020
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_021] Thrallmar Farseer - COST:3 [ATK:2/HP:3] 
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("EX1_021", new Power {
				// TODO [EX1_021] Thrallmar Farseer && Test: Thrallmar Farseer_EX1_021
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_023] Silvermoon Guardian - COST:4 [ATK:3/HP:3] 
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_023", new Power {
				// TODO [EX1_023] Silvermoon Guardian && Test: Silvermoon Guardian_EX1_023
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_028] Stranglethorn Tiger - COST:5 [ATK:5/HP:5] 
			// - Race: beast, Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("EX1_028", new Power {
				// TODO [EX1_028] Stranglethorn Tiger && Test: Stranglethorn Tiger_EX1_028
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_029] Leper Gnome - COST:1 [ATK:1/HP:1] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 2 damage to the enemy_hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_029", new Power {
				// TODO [EX1_029] Leper Gnome && Test: Leper Gnome_EX1_029
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_032] Sunwalker - COST:6 [ATK:4/HP:5] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_032", new Power {
				// TODO [EX1_032] Sunwalker && Test: Sunwalker_EX1_032
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_033] Windfury Harpy - COST:6 [ATK:4/HP:5] 
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("EX1_033", new Power {
				// TODO [EX1_033] Windfury Harpy && Test: Windfury Harpy_EX1_033
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_043] Twilight Drake - COST:4 [ATK:4/HP:1] 
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1 Health for each card in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_043", new Power {
				// TODO [EX1_043] Twilight Drake && Test: Twilight Drake_EX1_043
				InfoCardId = "EX1_043e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_044] Questing Adventurer - COST:3 [ATK:2/HP:2] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you play a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_044", new Power {
				// TODO [EX1_044] Questing Adventurer && Test: Questing Adventurer_EX1_044
				InfoCardId = "EX1_044e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_045] Ancient Watcher - COST:2 [ATK:4/HP:5] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Can't attack.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("EX1_045", new Power {
				// TODO [EX1_045] Ancient Watcher && Test: Ancient Watcher_EX1_045
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_046] Dark Iron Dwarf - COST:4 [ATK:4/HP:4] 
			// - Fac: alliance, Set: expert1, Rarity: common
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
			cards.Add("EX1_046", new Power {
				// TODO [EX1_046] Dark Iron Dwarf && Test: Dark Iron Dwarf_EX1_046
				InfoCardId = "EX1_046e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_048] Spellbreaker - COST:4 [ATK:4/HP:3] 
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b> a_minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("EX1_048", new Power {
				// TODO [EX1_048] Spellbreaker && Test: Spellbreaker_EX1_048
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_049] Youthful Brewmaster - COST:2 [ATK:3/HP:2] 
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return a friendly minion from the battlefield to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_049", new Power {
				// TODO [EX1_049] Youthful Brewmaster && Test: Youthful Brewmaster_EX1_049
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_055] Mana Addict - COST:2 [ATK:1/HP:3] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain +2 Attack this turn.
			// --------------------------------------------------------
			cards.Add("EX1_055", new Power {
				// TODO [EX1_055] Mana Addict && Test: Mana Addict_EX1_055
				InfoCardId = "EX1_055o",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_057] Ancient Brewmaster - COST:4 [ATK:5/HP:4] 
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return a friendly minion from the battlefield to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_057", new Power {
				// TODO [EX1_057] Ancient Brewmaster && Test: Ancient Brewmaster_EX1_057
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_058] Sunfury Protector - COST:2 [ATK:2/HP:3] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give adjacent minions <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_058", new Power {
				// TODO [EX1_058] Sunfury Protector && Test: Sunfury Protector_EX1_058
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_059] Crazed Alchemist - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Swap the Attack and Health of a minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_059", new Power {
				// TODO [EX1_059] Crazed Alchemist && Test: Crazed Alchemist_EX1_059
				InfoCardId = "EX1_059e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_067] Argent Commander - COST:6 [ATK:4/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_067", new Power {
				// TODO [EX1_067] Argent Commander && Test: Argent Commander_EX1_067
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_076] Pint-Sized Summoner - COST:2 [ATK:2/HP:2] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: The first minion you play each turn costs (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_076", new Power {
				// TODO [EX1_076] Pint-Sized Summoner && Test: Pint-Sized Summoner_EX1_076
				InfoCardId = "EX1_076e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_080] Secretkeeper - COST:1 [ATK:1/HP:2] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a <b>Secret</b> is played, gain +1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_080", new Power {
				// TODO [EX1_080] Secretkeeper && Test: Secretkeeper_EX1_080
				InfoCardId = "EX1_080o",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_082] Mad Bomber - COST:2 [ATK:3/HP:2] 
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage randomly split between all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_082", new Power {
				// TODO [EX1_082] Mad Bomber && Test: Mad Bomber_EX1_082
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_083] Tinkmaster Overspark - COST:3 [ATK:3/HP:3] 
			// - Fac: alliance, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Transform
			//       another random minion
			//       into a 5/5 Devilsaur
			//        or a 1/1 Squirrel.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_083", new Power {
				// TODO [EX1_083] Tinkmaster Overspark && Test: Tinkmaster Overspark_EX1_083
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_085] Mind Control Tech - COST:3 [ATK:3/HP:3] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your opponent
			//       has 4 or more minions, take
			//        control of one at random.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_085", new Power {
				// TODO [EX1_085] Mind Control Tech && Test: Mind Control Tech_EX1_085
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_089] Arcane Golem - COST:3 [ATK:4/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your opponent a Mana Crystal.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_089", new Power {
				// TODO [EX1_089] Arcane Golem && Test: Arcane Golem_EX1_089
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_093] Defender of Argus - COST:4 [ATK:2/HP:3] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give adjacent minions +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_093", new Power {
				// TODO [EX1_093] Defender of Argus && Test: Defender of Argus_EX1_093
				InfoCardId = "EX1_093e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_095] Gadgetzan Auctioneer - COST:6 [ATK:4/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, draw a card.
			// --------------------------------------------------------
			cards.Add("EX1_095", new Power {
				// TODO [EX1_095] Gadgetzan Auctioneer && Test: Gadgetzan Auctioneer_EX1_095
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_096] Loot Hoarder - COST:2 [ATK:2/HP:1] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_096", new Power {
				// TODO [EX1_096] Loot Hoarder && Test: Loot Hoarder_EX1_096
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_097] Abomination - COST:5 [ATK:4/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Deathrattle:</b> Deal 2
			//       damage to ALL characters.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_097", new Power {
				// TODO [EX1_097] Abomination && Test: Abomination_EX1_097
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_100] Lorewalker Cho - COST:2 [ATK:0/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever a player casts a spell, put a copy into the other player’s hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_100", new Power {
				// TODO [EX1_100] Lorewalker Cho && Test: Lorewalker Cho_EX1_100
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_102] Demolisher - COST:3 [ATK:1/HP:4] 
			// - Race: mechanical, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 2 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("EX1_102", new Power {
				// TODO [EX1_102] Demolisher && Test: Demolisher_EX1_102
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_103] Coldlight Seer - COST:3 [ATK:2/HP:3] 
			// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your other Murlocs +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_103", new Power {
				// TODO [EX1_103] Coldlight Seer && Test: Coldlight Seer_EX1_103
				InfoCardId = "EX1_103e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_105] Mountain Giant - COST:12 [ATK:8/HP:8] 
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each other card in your hand.
			// --------------------------------------------------------
			cards.Add("EX1_105", new Power {
				// TODO [EX1_105] Mountain Giant && Test: Mountain Giant_EX1_105
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_110] Cairne Bloodhoof - COST:6 [ATK:4/HP:5] 
			// - Fac: alliance, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 4/5 Baine Bloodhoof.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_110", new Power {
				// TODO [EX1_110] Cairne Bloodhoof && Test: Cairne Bloodhoof_EX1_110
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_116] Leeroy Jenkins - COST:5 [ATK:6/HP:2] 
			// - Fac: alliance, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge</b>. <b>Battlecry:</b> Summon two 1/1 Whelps for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_116", new Power {
				// TODO [EX1_116] Leeroy Jenkins && Test: Leeroy Jenkins_EX1_116
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_162] Dire Wolf Alpha - COST:2 [ATK:2/HP:2] 
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Adjacent minions have +1_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ADJACENT_BUFF = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_162", new Power {
				// TODO [EX1_162] Dire Wolf Alpha && Test: Dire Wolf Alpha_EX1_162
				InfoCardId = "EX1_162o",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_170] Emperor Cobra - COST:3 [ATK:2/HP:3] 
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("EX1_170", new Power {
				// TODO [EX1_170] Emperor Cobra && Test: Emperor Cobra_EX1_170
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_249] Baron Geddon - COST:7 [ATK:7/HP:5] 
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 2 damage to ALL other characters.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_249", new Power {
				// TODO [EX1_249] Baron Geddon && Test: Baron Geddon_EX1_249
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_283] Frost Elemental - COST:6 [ATK:5/HP:5] 
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Freeze</b> a_character.
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_283", new Power {
				// TODO [EX1_283] Frost Elemental && Test: Frost Elemental_EX1_283
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_390] Tauren Warrior - COST:3 [ATK:2/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Has +3 Attack while damaged.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_390", new Power {
				// TODO [EX1_390] Tauren Warrior && Test: Tauren Warrior_EX1_390
				InfoCardId = "EX1_390e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_393] Amani Berserker - COST:2 [ATK:2/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Has +3 Attack while damaged.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_393", new Power {
				// TODO [EX1_393] Amani Berserker && Test: Amani Berserker_EX1_393
				InfoCardId = "EX1_393e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_396] Mogu'shan Warden - COST:4 [ATK:1/HP:7] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_396", new Power {
				// TODO [EX1_396] Mogu'shan Warden && Test: Mogu'shan Warden_EX1_396
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_405] Shieldbearer - COST:1 [ATK:0/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_405", new Power {
				// TODO [EX1_405] Shieldbearer && Test: Shieldbearer_EX1_405
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_412] Raging Worgen - COST:3 [ATK:3/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Has +1 Attack and <b>Windfury</b> while damaged.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("EX1_412", new Power {
				// TODO [EX1_412] Raging Worgen && Test: Raging Worgen_EX1_412
				InfoCardId = "EX1_412e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_507] Murloc Warleader - COST:3 [ATK:3/HP:3] 
			// - Race: murloc, Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your other Murlocs have +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_507", new Power {
				// TODO [EX1_507] Murloc Warleader && Test: Murloc Warleader_EX1_507
				InfoCardId = "EX1_507e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_509] Murloc Tidecaller - COST:1 [ATK:1/HP:2] 
			// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you summon a Murloc, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_509", new Power {
				// TODO [EX1_509] Murloc Tidecaller && Test: Murloc Tidecaller_EX1_509
				InfoCardId = "EX1_509e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_556] Harvest Golem - COST:3 [ATK:2/HP:3] 
			// - Race: mechanical, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 2/1 Damaged Golem.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_556", new Power {
				// TODO [EX1_556] Harvest Golem && Test: Harvest Golem_EX1_556
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_557] Nat Pagle - COST:2 [ATK:0/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the start of your turn, you have a 50% chance to draw an extra card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_557", new Power {
				// TODO [EX1_557] Nat Pagle && Test: Nat Pagle_EX1_557
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_558] Harrison Jones - COST:5 [ATK:5/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your opponent's weapon and draw cards equal to its Durability.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_558", new Power {
				// TODO [EX1_558] Harrison Jones && Test: Harrison Jones_EX1_558
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_560] Nozdormu - COST:9 [ATK:8/HP:8] 
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Players only have 15 seconds to take their_turns.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_560", new Power {
				// TODO [EX1_560] Nozdormu && Test: Nozdormu_EX1_560
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_561] Alexstrasza - COST:9 [ATK:8/HP:8] 
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Set a hero's remaining Health to 15.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_HERO_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_561", new Power {
				// TODO [EX1_561] Alexstrasza && Test: Alexstrasza_EX1_561
				InfoCardId = "EX1_561e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_562] Onyxia - COST:9 [ATK:8/HP:8] 
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon 1/1 Whelps until your side of the battlefield is full.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_562", new Power {
				// TODO [EX1_562] Onyxia && Test: Onyxia_EX1_562
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_563] Malygos - COST:9 [ATK:4/HP:12] 
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Spell Damage +5</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - SPELLPOWER = 5
			// --------------------------------------------------------
			cards.Add("EX1_563", new Power {
				// TODO [EX1_563] Malygos && Test: Malygos_EX1_563
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_564] Faceless Manipulator - COST:5 [ATK:3/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a minion and become a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_564", new Power {
				// TODO [EX1_564] Faceless Manipulator && Test: Faceless Manipulator_EX1_564
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_572] Ysera - COST:9 [ATK:4/HP:12] 
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, add_a Dream Card to_your hand.
			// --------------------------------------------------------
			// Entourage: DREAM_01, DREAM_02, DREAM_03, DREAM_04, DREAM_05
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_572", new Power {
				// TODO [EX1_572] Ysera && Test: Ysera_EX1_572
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_577] The Beast - COST:6 [ATK:9/HP:7] 
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 3/3 Finkle Einhorn for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_577", new Power {
				// TODO [EX1_577] The Beast && Test: The Beast_EX1_577
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_583] Priestess of Elune - COST:6 [ATK:5/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore #4 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_583", new Power {
				// TODO [EX1_583] Priestess of Elune && Test: Priestess of Elune_EX1_583
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_584] Ancient Mage - COST:4 [ATK:2/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give adjacent_minions <b>Spell_Damage +1</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("EX1_584", new Power {
				// TODO [EX1_584] Ancient Mage && Test: Ancient Mage_EX1_584
				InfoCardId = "EX1_584e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_586] Sea Giant - COST:10 [ATK:8/HP:8] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each other minion on the battlefield.
			// --------------------------------------------------------
			cards.Add("EX1_586", new Power {
				// TODO [EX1_586] Sea Giant && Test: Sea Giant_EX1_586
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_590] Blood Knight - COST:3 [ATK:3/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> All minions lose <b>Divine Shield</b>. Gain +3/+3 for each Shield lost.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_590", new Power {
				// TODO [EX1_590] Blood Knight && Test: Blood Knight_EX1_590
				InfoCardId = "EX1_590e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_595] Cult Master - COST:4 [ATK:4/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: After a friendly minion dies, draw a card.
			// --------------------------------------------------------
			cards.Add("EX1_595", new Power {
				// TODO [EX1_595] Cult Master && Test: Cult Master_EX1_595
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_597] Imp Master - COST:3 [ATK:1/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]At the end of your turn, deal
			//       1 damage to this minion
			//        and summon a 1/1 Imp.
			// --------------------------------------------------------
			cards.Add("EX1_597", new Power {
				// TODO [EX1_597] Imp Master && Test: Imp Master_EX1_597
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_614] Illidan Stormrage - COST:6 [ATK:7/HP:5] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you play a card, summon a 2/1 Flame of_Azzinoth.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_614", new Power {
				// TODO [EX1_614] Illidan Stormrage && Test: Illidan Stormrage_EX1_614
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_616] Mana Wraith - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: ALL minions cost (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_616", new Power {
				// TODO [EX1_616] Mana Wraith && Test: Mana Wraith_EX1_616
				InfoCardId = "EX1_616e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_017] Hungry Crab - COST:1 [ATK:1/HP:2] 
			// - Race: beast, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a Murloc and gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_WITH_RACE = 14
			// --------------------------------------------------------
			cards.Add("NEW1_017", new Power {
				// TODO [NEW1_017] Hungry Crab && Test: Hungry Crab_NEW1_017
				InfoCardId = "NEW1_017e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_018] Bloodsail Raider - COST:2 [ATK:2/HP:3] 
			// - Race: pirate, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain Attack equal to the Attack
			//       of your weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_018", new Power {
				// TODO [NEW1_018] Bloodsail Raider && Test: Bloodsail Raider_NEW1_018
				InfoCardId = "NEW1_018e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_019] Knife Juggler - COST:2 [ATK:2/HP:2] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]After you summon a
			//       minion, deal 1 damage
			//       to a random enemy.
			// --------------------------------------------------------
			cards.Add("NEW1_019", new Power {
				// TODO [NEW1_019] Knife Juggler && Test: Knife Juggler_NEW1_019
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_020] Wild Pyromancer - COST:2 [ATK:3/HP:2] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: After you cast a spell, deal 1 damage to ALL minions.
			// --------------------------------------------------------
			cards.Add("NEW1_020", new Power {
				// TODO [NEW1_020] Wild Pyromancer && Test: Wild Pyromancer_NEW1_020
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_021] Doomsayer - COST:2 [ATK:0/HP:7] 
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy ALL minions.
			// --------------------------------------------------------
			// GameTag:
			// - 886 = 1
			// --------------------------------------------------------
			cards.Add("NEW1_021", new Power {
				// TODO [NEW1_021] Doomsayer && Test: Doomsayer_NEW1_021
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_022] Dread Corsair - COST:4 [ATK:3/HP:3] 
			// - Race: pirate, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Costs (1) less per Attack of_your weapon.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("NEW1_022", new Power {
				// TODO [NEW1_022] Dread Corsair && Test: Dread Corsair_NEW1_022
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_023] Faerie Dragon - COST:2 [ATK:3/HP:2] 
			// - Race: dragon, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("NEW1_023", new Power {
				// TODO [NEW1_023] Faerie Dragon && Test: Faerie Dragon_NEW1_023
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_024] Captain Greenskin - COST:5 [ATK:5/HP:4] 
			// - Race: pirate, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your weapon +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_024", new Power {
				// TODO [NEW1_024] Captain Greenskin && Test: Captain Greenskin_NEW1_024
				InfoCardId = "NEW1_024o",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_025] Bloodsail Corsair - COST:1 [ATK:1/HP:2] 
			// - Race: pirate, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Remove
			//       1 Durability from your
			//       opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_025", new Power {
				// TODO [NEW1_025] Bloodsail Corsair && Test: Bloodsail Corsair_NEW1_025
				InfoCardId = "NEW1_025e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_026] Violet Teacher - COST:4 [ATK:3/HP:5] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a 1/1 Violet Apprentice.
			// --------------------------------------------------------
			cards.Add("NEW1_026", new Power {
				// TODO [NEW1_026] Violet Teacher && Test: Violet Teacher_NEW1_026
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_027] Southsea Captain - COST:3 [ATK:3/HP:3] 
			// - Race: pirate, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your other Pirates have +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("NEW1_027", new Power {
				// TODO [NEW1_027] Southsea Captain && Test: Southsea Captain_NEW1_027
				InfoCardId = "NEW1_027e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_029] Millhouse Manastorm - COST:2 [ATK:4/HP:4] 
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Enemy spells cost (0) next turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_029", new Power {
				// TODO [NEW1_029] Millhouse Manastorm && Test: Millhouse Manastorm_NEW1_029
				InfoCardId = "NEW1_029t",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_030] Deathwing - COST:10 [ATK:12/HP:12] 
			// - Race: dragon, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all other minions and discard your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - DISCARD_CARDS = 10
			// --------------------------------------------------------
			cards.Add("NEW1_030", new Power {
				// TODO [NEW1_030] Deathwing && Test: Deathwing_NEW1_030
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_037] Master Swordsmith - COST:2 [ATK:1/HP:3] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, give another random friendly minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("NEW1_037", new Power {
				// TODO [NEW1_037] Master Swordsmith && Test: Master Swordsmith_NEW1_037
				InfoCardId = "NEW1_037e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_038] Gruul - COST:8 [ATK:7/HP:7] 
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of each turn, gain +1/+1 .
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("NEW1_038", new Power {
				// TODO [NEW1_038] Gruul && Test: Gruul_NEW1_038
				InfoCardId = "NEW1_038o",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_040] Hogger - COST:6 [ATK:4/HP:4] 
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a 2/2 Gnoll with_<b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("NEW1_040", new Power {
				// TODO [NEW1_040] Hogger && Test: Hogger_NEW1_040
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_041] Stampeding Kodo - COST:5 [ATK:3/HP:5] 
			// - Race: beast, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a random enemy minion with 2 or less Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_041", new Power {
				// TODO [NEW1_041] Stampeding Kodo && Test: Stampeding Kodo_NEW1_041
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [tt_004] Flesheating Ghoul - COST:3 [ATK:2/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever a minion dies, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("tt_004", new Power {
				// TODO [tt_004] Flesheating Ghoul && Test: Flesheating Ghoul_tt_004
				InfoCardId = "tt_004o",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_181e] Full Strength (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion has +2 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_181e", new Power {
				// TODO [CS2_181e] Full Strength && Test: Full Strength_CS2_181e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_188o] 'Inspired' (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion has +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CS2_188o", new Power {
				// TODO [CS2_188o] 'Inspired' && Test: 'Inspired'_CS2_188o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_221e] Sharp! (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +2 Attack from Spiteful Smith.
			// --------------------------------------------------------
			cards.Add("CS2_221e", new Power {
				// TODO [CS2_221e] Sharp! && Test: Sharp!_CS2_221e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_227e] Mercenary's Fee (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Costs (3) more.
			// --------------------------------------------------------
			cards.Add("CS2_227e", new Power {
				// TODO [CS2_227e] Mercenary's Fee && Test: Mercenary's Fee_CS2_227e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DREAM_05e] Nightmare (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion has +5/+5, but will be destroyed soon.
			// --------------------------------------------------------
			cards.Add("DREAM_05e", new Power {
				// TODO [DREAM_05e] Nightmare && Test: Nightmare_DREAM_05e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_001e] Warded (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("EX1_001e", new Power {
				// TODO [EX1_001e] Warded && Test: Warded_EX1_001e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_004e] Elune's Grace (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("EX1_004e", new Power {
				// TODO [EX1_004e] Elune's Grace && Test: Elune's Grace_EX1_004e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_009e] Enraged (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +5 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_009e", new Power {
				// TODO [EX1_009e] Enraged && Test: Enraged_EX1_009e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_014te] Bananas (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Has +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_014te", new Power {
				// TODO [EX1_014te] Bananas && Test: Bananas_EX1_014te
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_043e] Hour of Twilight (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("EX1_043e", new Power {
				// TODO [EX1_043e] Hour of Twilight && Test: Hour of Twilight_EX1_043e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_044e] Level Up! (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Attack and Health.
			// --------------------------------------------------------
			cards.Add("EX1_044e", new Power {
				// TODO [EX1_044e] Level Up! && Test: Level Up!_EX1_044e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_046e] Tempered (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_046e", new Power {
				// TODO [EX1_046e] Tempered && Test: Tempered_EX1_046e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_055o] Empowered (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Mana Addict has increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_055o", new Power {
				// TODO [EX1_055o] Empowered && Test: Empowered_EX1_055o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_059e] Experiments! (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Crazed Alchemist.
			// --------------------------------------------------------
			cards.Add("EX1_059e", new Power {
				// TODO [EX1_059e] Experiments! && Test: Experiments!_EX1_059e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_076e] Pint-Sized Power (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("EX1_076e", new Power {
				// TODO [EX1_076e] Pint-Sized Power && Test: Pint-Sized Power_EX1_076e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_080o] Keeping Secrets (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_080o", new Power {
				// TODO [EX1_080o] Keeping Secrets && Test: Keeping Secrets_EX1_080o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_093e] Hand of Argus (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_093e", new Power {
				// TODO [EX1_093e] Hand of Argus && Test: Hand of Argus_EX1_093e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_103e] Mrghlglhal (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("EX1_103e", new Power {
				// TODO [EX1_103e] Mrghlglhal && Test: Mrghlglhal_EX1_103e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_162o] Strength of the Pack (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +1 Attack from {0}.
			// --------------------------------------------------------
			cards.Add("EX1_162o", new Power {
				// TODO [EX1_162o] Strength of the Pack && Test: Strength of the Pack_EX1_162o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_315e] Portal Summoning (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Costs (2) less, but not less than (1).
			// --------------------------------------------------------
			cards.Add("EX1_315e", new Power {
				// TODO [EX1_315e] Portal Summoning && Test: Portal Summoning_EX1_315e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_390e] Enraged (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_390e", new Power {
				// TODO [EX1_390e] Enraged && Test: Enraged_EX1_390e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_393e] Enraged (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_393e", new Power {
				// TODO [EX1_393e] Enraged && Test: Enraged_EX1_393e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_412e] Enraged (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_412e", new Power {
				// TODO [EX1_412e] Enraged && Test: Enraged_EX1_412e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_509e] Blarghghl (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("EX1_509e", new Power {
				// TODO [EX1_509e] Blarghghl && Test: Blarghghl_EX1_509e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_561e] Alexstrasza's Fire (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Health set to 15.
			// --------------------------------------------------------
			cards.Add("EX1_561e", new Power {
				// TODO [EX1_561e] Alexstrasza's Fire && Test: Alexstrasza's Fire_EX1_561e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_570e] Bite (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +4 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_570e", new Power {
				// TODO [EX1_570e] Bite && Test: Bite_EX1_570e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_584e] Teachings of the Kirin Tor (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			cards.Add("EX1_584e", new Power {
				// TODO [EX1_584e] Teachings of the Kirin Tor && Test: Teachings of the Kirin Tor_EX1_584e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_590e] Shadows of M'uru (*) - COST:0 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: This minion has consumed Divine Shields and has increased Attack and Health.
			// --------------------------------------------------------
			cards.Add("EX1_590e", new Power {
				// TODO [EX1_590e] Shadows of M'uru && Test: Shadows of M'uru_EX1_590e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_591e] Soulweaving (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Your cards and powers that restore Health now deal damage instead.
			// --------------------------------------------------------
			cards.Add("EX1_591e", new Power {
				// TODO [EX1_591e] Soulweaving && Test: Soulweaving_EX1_591e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_608e] Apprentice's Assitance (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("EX1_608e", new Power {
				// TODO [EX1_608e] Apprentice's Assitance && Test: Apprentice's Assitance_EX1_608e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_616e] Mana Drain (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Costs (1) more.
			// --------------------------------------------------------
			cards.Add("EX1_616e", new Power {
				// TODO [EX1_616e] Mana Drain && Test: Mana Drain_EX1_616e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_04e] Empowered (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +8 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_04e", new Power {
				// TODO [KARA_08_04e] Empowered && Test: Empowered_KARA_08_04e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_017e] Full Belly (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +2/+2.  Full of Murloc.
			// --------------------------------------------------------
			cards.Add("NEW1_017e", new Power {
				// TODO [NEW1_017e] Full Belly && Test: Full Belly_NEW1_017e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_018e] Treasure Crazed (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("NEW1_018e", new Power {
				// TODO [NEW1_018e] Treasure Crazed && Test: Treasure Crazed_NEW1_018e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_024o] Greenskin's Command (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("NEW1_024o", new Power {
				// TODO [NEW1_024o] Greenskin's Command && Test: Greenskin's Command_NEW1_024o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_025e] Bolstered (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("NEW1_025e", new Power {
				// TODO [NEW1_025e] Bolstered && Test: Bolstered_NEW1_025e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_029t] Kill Millhouse! (*) - COST:0 
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Spells cost (0) this turn!
			// --------------------------------------------------------
			cards.Add("NEW1_029t", new Power {
				// TODO [NEW1_029t] Kill Millhouse! && Test: Kill Millhouse!_NEW1_029t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_037e] Equipped (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("NEW1_037e", new Power {
				// TODO [NEW1_037e] Equipped && Test: Equipped_NEW1_037e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_038o] Growth (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Gruul is growing...
			// --------------------------------------------------------
			cards.Add("NEW1_038o", new Power {
				// TODO [NEW1_038o] Growth && Test: Growth_NEW1_038o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [tt_004o] Cannibalize (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("tt_004o", new Power {
				// TODO [tt_004o] Cannibalize && Test: Cannibalize_tt_004o
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_152] Squire (*) - COST:1 [ATK:2/HP:2] 
			// - Fac: alliance, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("CS2_152", new Power {
				// TODO [CS2_152] Squire && Test: Squire_CS2_152
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ds1_whelptoken] Whelp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: dragon, Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("ds1_whelptoken", new Power {
				// TODO [ds1_whelptoken] Whelp && Test: Whelp_ds1_whelptoken
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_110t] Baine Bloodhoof (*) - COST:4 [ATK:4/HP:5] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_110t", new Power {
				// TODO [EX1_110t] Baine Bloodhoof && Test: Baine Bloodhoof_EX1_110t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_116t] Whelp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: dragon, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_116t", new Power {
				// TODO [EX1_116t] Whelp && Test: Whelp_EX1_116t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_598] Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_598", new Power {
				// TODO [EX1_598] Imp && Test: Imp_EX1_598
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_614t] Flame of Azzinoth (*) - COST:1 [ATK:2/HP:1] 
			// - Race: elemental, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_614t", new Power {
				// TODO [EX1_614t] Flame of Azzinoth && Test: Flame of Azzinoth_EX1_614t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_finkle] Finkle Einhorn (*) - COST:3 [ATK:3/HP:3] 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_finkle", new Power {
				// TODO [EX1_finkle] Finkle Einhorn && Test: Finkle Einhorn_EX1_finkle
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_tk28] Squirrel (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_tk28", new Power {
				// TODO [EX1_tk28] Squirrel && Test: Squirrel_EX1_tk28
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_tk29] Devilsaur (*) - COST:5 [ATK:5/HP:5] 
			// - Race: beast, Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_tk29", new Power {
				// TODO [EX1_tk29] Devilsaur && Test: Devilsaur_EX1_tk29
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_026t] Violet Apprentice (*) - COST:1 [ATK:1/HP:1] 
			// - Set: expert1, 
			// --------------------------------------------------------
			cards.Add("NEW1_026t", new Power {
				// TODO [NEW1_026t] Violet Apprentice && Test: Violet Apprentice_NEW1_026t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_040t] Gnoll (*) - COST:2 [ATK:2/HP:2] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("NEW1_040t", new Power {
				// TODO [NEW1_040t] Gnoll && Test: Gnoll_NEW1_040t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [skele21] Damaged Golem (*) - COST:1 [ATK:2/HP:1] 
			// - Race: mechanical, Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("skele21", new Power {
				// TODO [skele21] Damaged Golem && Test: Damaged Golem_skele21
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [EX1_014t] Bananas (*) - COST:1 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Give a minion +1/+1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_014t", new Power {
				// TODO [EX1_014t] Bananas && Test: Bananas_EX1_014t
				InfoCardId = "EX1_014te",
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
			DreamNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
