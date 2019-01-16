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

namespace SabberStoneCore.CardSets.Standard
{
	public class TrollCardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ HERO - HUNTER
			// [TRL_065] Zul'jin - COST:10 [ATK:0/HP:30] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Cast all spells
			//       you've played this game
			//       <i>(targets chosen randomly)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 50579
			// --------------------------------------------------------
			cards.Add("TRL_065", new Power {
				// TODO [TRL_065] Zul'jin && Test: Zul'jin_TRL_065
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ------------------------------------ HERO_POWER - HUNTER
			// [TRL_065h] Berserker Throw (*) - COST:2 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_065h", new Power {
				// TODO [TRL_065h] Berserker Throw && Test: Berserker Throw_TRL_065h
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [TRL_223] Spirit of the Raptor - COST:1 [ATK:0/HP:3] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       After your hero attacks and
			//       __kills a minion, draw a card.__
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_223", new Power {
				// TODO [TRL_223] Spirit of the Raptor && Test: Spirit of the Raptor_TRL_223
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_232] Ironhide Direhorn - COST:7 [ATK:7/HP:7] 
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Summon a 5/5_Ironhide Runt.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_232", new Power {
				// TODO [TRL_232] Ironhide Direhorn && Test: Ironhide Direhorn_TRL_232
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_240] Savage Striker - COST:2 [ATK:2/HP:3] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal damage to an enemy minion equal to your hero's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE_AND_HERO_HAS_ATTACK = 0
			// --------------------------------------------------------
			cards.Add("TRL_240", new Power {
				// TODO [TRL_240] Savage Striker && Test: Savage Striker_TRL_240
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_241] Gonk, the Raptor - COST:7 [ATK:4/HP:9] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: After your hero attacks and_kills a minion, it may_attack again.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TRL_241", new Power {
				// TODO [TRL_241] Gonk, the Raptor && Test: Gonk, the Raptor_TRL_241
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_341] Treespeaker - COST:5 [ATK:4/HP:4] 
			// - Fac: neutral, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform your Treants into 5/5 Ancients.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_341", new Power {
				// TODO [TRL_341] Treespeaker && Test: Treespeaker_TRL_341
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_343] Wardruid Loti - COST:3 [ATK:1/HP:2] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Choose One - </b>Transform into one of Loti's four dinosaur forms.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("TRL_343", new Power {
				// TODO [TRL_343] Wardruid Loti && Test: Wardruid Loti_TRL_343
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [TRL_243] Pounce - COST:0 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Give your hero +2_Attack this turn.
			// --------------------------------------------------------
			cards.Add("TRL_243", new Power {
				// TODO [TRL_243] Pounce && Test: Pounce_TRL_243
				InfoCardId = "TRL_243e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [TRL_244] Predatory Instincts - COST:4 
			// - Fac: neutral, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Draw a Beast from your
			//       deck. Double its Health.
			// --------------------------------------------------------
			cards.Add("TRL_244", new Power {
				// TODO [TRL_244] Predatory Instincts && Test: Predatory Instincts_TRL_244
				InfoCardId = "TRL_244e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [TRL_254] Mark of the Loa - COST:4 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One</b> -
			//       Give a minion +2/+4
			//       and <b>Taunt</b>; or Summon
			//       two 3/2 Raptors.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_254", new Power {
				// TODO [TRL_254] Mark of the Loa && Test: Mark of the Loa_TRL_254
				InfoCardId = "TRL_254ae",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [TRL_255] Stampeding Roar - COST:6 
			// - Fac: neutral, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon a random Beast from your hand and give it <b>Rush</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINION_OF_RACE_IN_HAND = 20
			// --------------------------------------------------------
			cards.Add("TRL_255", new Power {
				// TODO [TRL_255] Stampeding Roar && Test: Stampeding Roar_TRL_255
				InfoCardId = "TRL_255e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [TRL_254ae] Mark of the Loa (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +2/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("TRL_254ae", new Power {
				// TODO [TRL_254ae] Mark of the Loa && Test: Mark of the Loa_TRL_254ae
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [TRL_255e] Stampede! (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Has <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("TRL_255e", new Power {
				// TODO [TRL_255e] Stampede! && Test: Stampede!_TRL_255e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_232t] Ironhide Runt (*) - COST:5 [ATK:5/HP:5] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			cards.Add("TRL_232t", new Power {
				// TODO [TRL_232t] Ironhide Runt && Test: Ironhide Runt_TRL_232t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_254t] Raptor (*) - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			cards.Add("TRL_254t", new Power {
				// TODO [TRL_254t] Raptor && Test: Raptor_TRL_254t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_341t] Ancient (*) - COST:5 [ATK:5/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			cards.Add("TRL_341t", new Power {
				// TODO [TRL_341t] Ancient && Test: Ancient_TRL_341t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_343at1] Ankylodon (*) - COST:3 [ATK:1/HP:6] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_343at1", new Power {
				// TODO [TRL_343at1] Ankylodon && Test: Ankylodon_TRL_343at1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_343at2] Wardruid Loti (*) - COST:3 [ATK:1/HP:6] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_343at2", new Power {
				// TODO [TRL_343at2] Wardruid Loti && Test: Wardruid Loti_TRL_343at2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_343bt1] Sabertusk (*) - COST:3 [ATK:4/HP:2] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_343bt1", new Power {
				// TODO [TRL_343bt1] Sabertusk && Test: Sabertusk_TRL_343bt1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_343bt2] Wardruid Loti (*) - COST:3 [ATK:4/HP:2] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_343bt2", new Power {
				// TODO [TRL_343bt2] Wardruid Loti && Test: Wardruid Loti_TRL_343bt2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_343ct1] Pterrordax (*) - COST:3 [ATK:1/HP:4] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("TRL_343ct1", new Power {
				// TODO [TRL_343ct1] Pterrordax && Test: Pterrordax_TRL_343ct1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_343ct2] Wardruid Loti (*) - COST:3 [ATK:1/HP:4] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			cards.Add("TRL_343ct2", new Power {
				// TODO [TRL_343ct2] Wardruid Loti && Test: Wardruid Loti_TRL_343ct2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_343dt1] Ravasaur (*) - COST:3 [ATK:1/HP:2] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>, <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - STEALTH = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("TRL_343dt1", new Power {
				// TODO [TRL_343dt1] Ravasaur && Test: Ravasaur_TRL_343dt1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_343dt2] Wardruid Loti (*) - COST:3 [ATK:1/HP:2] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>, <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("TRL_343dt2", new Power {
				// TODO [TRL_343dt2] Wardruid Loti && Test: Wardruid Loti_TRL_343dt2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [TRL_343et1] Wardruid Loti (*) - COST:3 [ATK:4/HP:6] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>, <b>Rush</b>, <b>Poisonous</b>, <b>Stealth</b>, <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - STEALTH = 1
			// - SPELLPOWER = 1
			// - POISONOUS = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_343et1", new Power {
				// TODO [TRL_343et1] Wardruid Loti && Test: Wardruid Loti_TRL_343et1
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [TRL_254a] Gonk's Resilience (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: Give a minion +2/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_254a", new Power {
				// TODO [TRL_254a] Gonk's Resilience && Test: Gonk's Resilience_TRL_254a
				InfoCardId = "TRL_254ae",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [TRL_254b] Raptor Pack (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: Summon two 3/2 Raptors.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("TRL_254b", new Power {
				// TODO [TRL_254b] Raptor Pack && Test: Raptor Pack_TRL_254b
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [TRL_348] Springpaw - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       <b>Battlecry:</b> Add a 1/1 Lynx
			//       with <b>Rush</b> to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_348", new Power {
				// TODO [TRL_348] Springpaw && Test: Springpaw_TRL_348
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [TRL_349] Bloodscalp Strategist - COST:3 [ATK:2/HP:4] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a weapon equipped, <b>Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_349", new Power {
				// TODO [TRL_349] Bloodscalp Strategist && Test: Bloodscalp Strategist_TRL_349
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [TRL_900] Halazzi, the Lynx - COST:5 [ATK:3/HP:2] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Fill your hand with 1/1 Lynxes that have_<b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_900", new Power {
				// TODO [TRL_900] Halazzi, the Lynx && Test: Halazzi, the Lynx_TRL_900
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [TRL_901] Spirit of the Lynx - COST:3 [ATK:0/HP:3] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       Whenever you summon a 
			//       Beast, give it +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_901", new Power {
				// TODO [TRL_901] Spirit of the Lynx && Test: Spirit of the Lynx_TRL_901
				InfoCardId = "TRL_901e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [TRL_119] The Beast Within - COST:1 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a friendly Beast +1/+1, then it attacks a random enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_TARGET_WITH_RACE = 20
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_119", new Power {
				// TODO [TRL_119] The Beast Within && Test: The Beast Within_TRL_119
				InfoCardId = "TRL_119e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [TRL_339] Master's Call - COST:3 
			// - Fac: neutral, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a minion in your deck.
			//       If all 3 are Beasts,
			//       draw them all.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_339", new Power {
				// TODO [TRL_339] Master's Call && Test: Master's Call_TRL_339
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [TRL_347] Baited Arrow - COST:5 
			// - Fac: neutral, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage. <b>Overkill:</b> Summon a 5/5 Devilsaur. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_347", new Power {
				// TODO [TRL_347] Baited Arrow && Test: Baited Arrow_TRL_347
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [TRL_566] Revenge of the Wild - COST:2 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon your Beasts that died this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_MINION_OF_RACE_DIED_THIS_TURN = 20
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("TRL_566", new Power {
				// TODO [TRL_566] Revenge of the Wild && Test: Revenge of the Wild_TRL_566
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - HUNTER
			// [TRL_111] Headhunter's Hatchet - COST:2 [ATK:2/HP:0] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you
			//       control a Beast, gain
			//       +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_111", new Power {
				// TODO [TRL_111] Headhunter's Hatchet && Test: Headhunter's Hatchet_TRL_111
				InfoCardId = "TRL_111e1",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [TRL_347t] Devilsaur (*) - COST:5 [ATK:5/HP:5] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			cards.Add("TRL_347t", new Power {
				// TODO [TRL_347t] Devilsaur && Test: Devilsaur_TRL_347t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [TRL_348t] Lynx (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_348t", new Power {
				// TODO [TRL_348t] Lynx && Test: Lynx_TRL_348t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [TRL_311] Arcanosaur - COST:6 [ATK:3/HP:3] 
			// - Race: elemental, Fac: neutral, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you played an_Elemental last turn, deal_3_damage_to_all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_311", new Power {
				// TODO [TRL_311] Arcanosaur && Test: Arcanosaur_TRL_311
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [TRL_315] Pyromaniac - COST:3 [ATK:3/HP:4] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever your Hero Power_kills a minion, draw a card.
			// --------------------------------------------------------
			cards.Add("TRL_315", new Power {
				// TODO [TRL_315] Pyromaniac && Test: Pyromaniac_TRL_315
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [TRL_316] Jan'alai, the Dragonhawk - COST:7 [ATK:4/HP:4] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your Hero Power
			//       dealt 8 damage this game,
			//       summon Ragnaros the
			//       Firelord.@ <i>({0} left!)</i>@ <i>(Ready!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - PLAYER_TAG_THRESHOLD_TAG_ID = 1025
			// - PLAYER_TAG_THRESHOLD_VALUE = 8
			// --------------------------------------------------------
			cards.Add("TRL_316", new Power {
				// TODO [TRL_316] Jan'alai, the Dragonhawk && Test: Jan'alai, the Dragonhawk_TRL_316
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [TRL_318] Hex Lord Malacrass - COST:8 [ATK:5/HP:5] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: Add a copy of your opening hand to your hand <i>(except this card)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_318", new Power {
				// TODO [TRL_318] Hex Lord Malacrass && Test: Hex Lord Malacrass_TRL_318
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [TRL_319] Spirit of the Dragonhawk - COST:2 [ATK:0/HP:3] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       Your Hero Power also targets
			//        adjacent minions.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("TRL_319", new Power {
				// TODO [TRL_319] Spirit of the Dragonhawk && Test: Spirit of the Dragonhawk_TRL_319
				InfoCardId = "TRL_319e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [TRL_390] Daring Fire-Eater - COST:1 [ATK:1/HP:1] 
			// - Fac: neutral, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your next Hero Power this turn deals 2_more damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_390", new Power {
				// TODO [TRL_390] Daring Fire-Eater && Test: Daring Fire-Eater_TRL_390
				InfoCardId = "TRL_390e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [TRL_310] Elemental Evocation - COST:0 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: The next Elemental you_play this turn costs (2) less.
			// --------------------------------------------------------
			cards.Add("TRL_310", new Power {
				// TODO [TRL_310] Elemental Evocation && Test: Elemental Evocation_TRL_310
				InfoCardId = "TRL_310e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [TRL_313] Scorch - COST:4 
			// - Fac: neutral, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Deal $4 damage to a
			//       minion. Costs (1) if you
			//       played an Elemental
			//       last turn. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_313", new Power {
				// TODO [TRL_313] Scorch && Test: Scorch_TRL_313
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [TRL_317] Blast Wave - COST:5 
			// - Fac: neutral, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to_all minions.
			//       <b>Overkill</b>: Add a random Mage spell to your hand. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_317", new Power {
				// TODO [TRL_317] Blast Wave && Test: Blast Wave_TRL_317
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [TRL_400] Splitting Image - COST:3 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions is attacked, summon a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TRL_400", new Power {
				// TODO [TRL_400] Splitting Image && Test: Splitting Image_TRL_400
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [TRL_310e] Elemental Evocation (*) - COST:0 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: The next Elemental you play this turn costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_310e", new Power {
				// TODO [TRL_310e] Elemental Evocation && Test: Elemental Evocation_TRL_310e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [TRL_300] Shirvallah, the Tiger - COST:25 [ATK:7/HP:5] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>, <b>Rush</b>, <b>Lifesteal</b>
			//        Costs (1) less for each Mana
			//       you've spent on spells.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DIVINE_SHIELD = 1
			// - LIFESTEAL = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_300", new Power {
				// TODO [TRL_300] Shirvallah, the Tiger && Test: Shirvallah, the Tiger_TRL_300
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [TRL_306] Immortal Prelate - COST:2 [ATK:1/HP:3] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle this into your deck. It keeps any enchantments.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("TRL_306", new Power {
				// TODO [TRL_306] Immortal Prelate && Test: Immortal Prelate_TRL_306
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [TRL_308] High Priest Thekal - COST:3 [ATK:3/HP:4] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Convert all but 1_of your Hero's Health into Armor.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_308", new Power {
				// TODO [TRL_308] High Priest Thekal && Test: High Priest Thekal_TRL_308
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [TRL_309] Spirit of the Tiger - COST:4 [ATK:0/HP:3] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       After you cast a spell,
			//       summon a Tiger with stats
			//       equal to its Cost.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_309", new Power {
				// TODO [TRL_309] Spirit of the Tiger && Test: Spirit of the Tiger_TRL_309
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [TRL_545] Zandalari Templar - COST:4 [ATK:4/HP:4] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you've restored
			//       10 Health this game, gain
			//       +4/+4 and <b>Taunt</b>.@ <i>({0} left!)</i>@ <i>(Ready!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - PLAYER_TAG_THRESHOLD_TAG_ID = 958
			// - PLAYER_TAG_THRESHOLD_VALUE = 10
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_545", new Power {
				// TODO [TRL_545] Zandalari Templar && Test: Zandalari Templar_TRL_545
				InfoCardId = "TRL_545e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [TRL_302] Time Out! - COST:3 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Your hero is <b>Immune</b> until your next turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("TRL_302", new Power {
				// TODO [TRL_302] Time Out! && Test: Time Out!_TRL_302
				InfoCardId = "TRL_302e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [TRL_305] A New Challenger... - COST:7 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a 6-Cost minion. Summon it with <b>Taunt</b> and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_305", new Power {
				// TODO [TRL_305] A New Challenger... && Test: A New Challenger..._TRL_305
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [TRL_307] Flash of Light - COST:2 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #4 Health.
			//       Draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_307", new Power {
				// TODO [TRL_307] Flash of Light && Test: Flash of Light_TRL_307
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [TRL_304] Farraki Battleaxe - COST:5 [ATK:3/HP:0] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Give a minion in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_304", new Power {
				// TODO [TRL_304] Farraki Battleaxe && Test: Farraki Battleaxe_TRL_304
				InfoCardId = "TRL_304e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [TRL_543] Bloodclaw - COST:1 [ATK:2/HP:0] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 5 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_543", new Power {
				PowerTask = new DamageTask(5, EntityType.HERO)
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [TRL_302e] Time Out! (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Immune</b> until your next turn.
			// --------------------------------------------------------
			cards.Add("TRL_302e", new Power {
				// TODO [TRL_302e] Time Out! && Test: Time Out!_TRL_302e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [TRL_309t] Tiger (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			cards.Add("TRL_309t", new Power {
				// TODO [TRL_309t] Tiger && Test: Tiger_TRL_309t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [TRL_131] Sand Drudge - COST:3 [ATK:3/HP:3] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a 1/1 Zombie with <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_131", new Power {
				// TODO [TRL_131] Sand Drudge && Test: Sand Drudge_TRL_131
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [TRL_259] Princess Talanji - COST:8 [ATK:7/HP:5] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon all minions from your hand that_didn't start in your_deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_259", new Power {
				// TODO [TRL_259] Princess Talanji && Test: Princess Talanji_TRL_259
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [TRL_260] Bwonsamdi, the Dead - COST:7 [ATK:7/HP:7] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw 1-Cost
			//       minions from your deck
			//       until your hand is full.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_260", new Power {
				// TODO [TRL_260] Bwonsamdi, the Dead && Test: Bwonsamdi, the Dead_TRL_260
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [TRL_408] Grave Horror - COST:12 [ATK:7/HP:8] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       Costs (1) less for each spell
			//       you've cast this game.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_408", new Power {
				// TODO [TRL_408] Grave Horror && Test: Grave Horror_TRL_408
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [TRL_501] Auchenai Phantasm - COST:2 [ATK:3/HP:2] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> This turn, your healing effects deal damage instead.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_501", new Power {
				// TODO [TRL_501] Auchenai Phantasm && Test: Auchenai Phantasm_TRL_501
				InfoCardId = "TRL_501e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [TRL_502] Spirit of the Dead - COST:1 [ATK:0/HP:3] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       After a friendly minion dies,
			//       shuffle a 1-Cost copy of it
			//       into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_502", new Power {
				// TODO [TRL_502] Spirit of the Dead && Test: Spirit of the Dead_TRL_502
				InfoCardId = "TRL_502e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [TRL_097] Seance - COST:2 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Choose a minion. Add_a copy of it to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_097", new Power {
				// TODO [TRL_097] Seance && Test: Seance_TRL_097
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [TRL_128] Regenerate - COST:0 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #3 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_128", new Power {
				// TODO [TRL_128] Regenerate && Test: Regenerate_TRL_128
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [TRL_258] Mass Hysteria - COST:5 
			// - Fac: neutral, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Force each minion to_attack another random minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_258", new Power {
				// TODO [TRL_258] Mass Hysteria && Test: Mass Hysteria_TRL_258
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [TRL_500] Surrender to Madness - COST:3 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Destroy 3 of your Mana
			//       Crystals. Give all minions
			//       in your deck +2/+2.
			// --------------------------------------------------------
			cards.Add("TRL_500", new Power {
				// TODO [TRL_500] Surrender to Madness && Test: Surrender to Madness_TRL_500
				InfoCardId = "TRL_500e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [TRL_500e] Absolutely Mad! (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("TRL_500e", new Power {
				// TODO [TRL_500e] Absolutely Mad! && Test: Absolutely Mad!_TRL_500e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [TRL_502e] Prayer to Bwonsamdi (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Bwonsamdi made this cost (1).
			// --------------------------------------------------------
			cards.Add("TRL_502e", new Power {
				// TODO [TRL_502e] Prayer to Bwonsamdi && Test: Prayer to Bwonsamdi_TRL_502e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [TRL_131t] Zombie (*) - COST:1 [ATK:1/HP:1] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_131t", new Power {
				// TODO [TRL_131t] Zombie && Test: Zombie_TRL_131t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [TRL_071] Bloodsail Howler - COST:2 [ATK:1/HP:1] 
			// - Race: pirate, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       <b>Battlecry:</b> Gain +1/+1
			//       for each other Pirate
			//       you control.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_071", new Power {
				// TODO [TRL_071] Bloodsail Howler && Test: Bloodsail Howler_TRL_071
				InfoCardId = "TRL_071e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [TRL_077] Gurubashi Hypemon - COST:7 [ATK:5/HP:7] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a 1/1 copy of a <b>Battlecry</b> minion. It costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_077", new Power {
				// TODO [TRL_077] Gurubashi Hypemon && Test: Gurubashi Hypemon_TRL_077
				InfoCardId = "TRL_077e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [TRL_092] Spirit of the Shark - COST:4 [ATK:0/HP:3] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       Your minions' <b>Battlecries</b>
			//       __and <b>Combos</b> trigger twice._
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("TRL_092", new Power {
				// TODO [TRL_092] Spirit of the Shark && Test: Spirit of the Shark_TRL_092
				InfoCardId = "TRL_092e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [TRL_126] Captain Hooktusk - COST:8 [ATK:6/HP:3] 
			// - Race: pirate, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon 3 Pirates from your deck. Give them <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_126", new Power {
				// TODO [TRL_126] Captain Hooktusk && Test: Captain Hooktusk_TRL_126
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [TRL_409] Gral, the Shark - COST:5 [ATK:2/HP:2] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Eat a minion in
			//       your deck and gain its stats.
			//       <b>Deathrattle:</b> Add it to
			//       your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_409", new Power {
				// TODO [TRL_409] Gral, the Shark && Test: Gral, the Shark_TRL_409
				InfoCardId = "TRL_409e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [TRL_124] Raiding Party - COST:3 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw 2 Pirates from_your deck.
			//       <b>Combo:</b> And a weapon.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("TRL_124", new Power {
				// TODO [TRL_124] Raiding Party && Test: Raiding Party_TRL_124
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [TRL_127] Cannon Barrage - COST:6 
			// - Fac: neutral, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Deal $3 damage to a
			//       random enemy. Repeat
			//       for each of your Pirates. @spelldmg
			// --------------------------------------------------------
			cards.Add("TRL_127", new Power {
				// TODO [TRL_127] Cannon Barrage && Test: Cannon Barrage_TRL_127
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [TRL_156] Stolen Steel - COST:2 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a weapon <i>(from another class)</i>.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_156", new Power {
				// TODO [TRL_156] Stolen Steel && Test: Stolen Steel_TRL_156
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [TRL_157] Walk the Plank - COST:4 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy an undamaged minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_UNDAMAGED_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_157", new Power {
				// TODO [TRL_157] Walk the Plank && Test: Walk the Plank_TRL_157
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [TRL_074] Serrated Tooth - COST:1 [ATK:1/HP:0] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give your minions <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_074", new Power {
				// TODO [TRL_074] Serrated Tooth && Test: Serrated Tooth_TRL_074
				InfoCardId = "TRL_074e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TRL_409e] Blood in the Water (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Destroyed {0} and gained its stats.
			// --------------------------------------------------------
			cards.Add("TRL_409e", new Power {
				// TODO [TRL_409e] Blood in the Water && Test: Blood in the Water_TRL_409e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [TRL_059] Bog Slosher - COST:3 [ATK:3/HP:3] 
			// - Race: elemental, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return a friendly minion to your hand and give it +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_059", new Power {
				// TODO [TRL_059] Bog Slosher && Test: Bog Slosher_TRL_059
				InfoCardId = "TRL_059e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [TRL_060] Spirit of the Frog - COST:3 [ATK:0/HP:3] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       Whenever you cast a spell,
			//       draw a spell from your deck
			//       that costs (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_060", new Power {
				// TODO [TRL_060] Spirit of the Frog && Test: Spirit of the Frog_TRL_060
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [TRL_085] Zentimo - COST:3 [ATK:1/HP:3] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Whenever you target a
			//       minion with a spell, it also
			//       targets adjacent ones.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TRL_085", new Power {
				// TODO [TRL_085] Zentimo && Test: Zentimo_TRL_085
				InfoCardId = "TRL_085e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [TRL_345] Krag'wa, the Frog - COST:6 [ATK:4/HP:6] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return all spells you played last turn to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_345", new Power {
				// TODO [TRL_345] Krag'wa, the Frog && Test: Krag'wa, the Frog_TRL_345
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [TRL_522] Wartbringer - COST:1 [ATK:2/HP:1] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you played 2_spells this turn, deal 2_damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_SPELLS_PLAYED_THIS_TURN = 2
			// --------------------------------------------------------
			cards.Add("TRL_522", new Power {
				// TODO [TRL_522] Wartbringer && Test: Wartbringer_TRL_522
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [TRL_012] Totemic Smash - COST:1 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage. <b>Overkill</b>: Summon a basic Totem. @spelldmg
			// --------------------------------------------------------
			// Entourage: CS2_052, CS2_050, NEW1_009, CS2_051
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_012", new Power {
				// TODO [TRL_012] Totemic Smash && Test: Totemic Smash_TRL_012
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [TRL_058] Haunting Visions - COST:3 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (3) less. <b>Discover</b> a spell.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_058", new Power {
				// TODO [TRL_058] Haunting Visions && Test: Haunting Visions_TRL_058
				InfoCardId = "TRL_058e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [TRL_082] Big Bad Voodoo - COST:2 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a friendly minion "<b>Deathrattle:</b> Summon a random minion that costs (1) more."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_082", new Power {
				// TODO [TRL_082] Big Bad Voodoo && Test: Big Bad Voodoo_TRL_082
				InfoCardId = "TRL_082e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [TRL_351] Rain of Toads - COST:6 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Summon three 2/4 Toads with <b>Taunt</b>. <b>Overload:</b> (3)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 3
			// - OVERLOAD_OWED = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_351", new Power {
				// TODO [TRL_351] Rain of Toads && Test: Rain of Toads_TRL_351
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [TRL_352] Likkim - COST:2 [ATK:1/HP:0] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Has +2 Attack while you have <b>Overloaded</b> Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("TRL_352", new Power {
				// TODO [TRL_352] Likkim && Test: Likkim_TRL_352
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [TRL_059e] Sloshed (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("TRL_059e", new Power {
				// TODO [TRL_059e] Sloshed && Test: Sloshed_TRL_059e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [TRL_082e] Voodoo (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a minion that costs (1) more.
			// --------------------------------------------------------
			cards.Add("TRL_082e", new Power {
				// TODO [TRL_082e] Voodoo && Test: Voodoo_TRL_082e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [TRL_351t] Toad (*) - COST:3 [ATK:2/HP:4] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_351t", null);

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [TRL_247] Soulwarden - COST:6 [ATK:6/HP:6] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add 3 random cards you discarded this game to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_247", new Power {
				// TODO [TRL_247] Soulwarden && Test: Soulwarden_TRL_247
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [TRL_251] Spirit of the Bat - COST:2 [ATK:0/HP:3] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Stealth</b> for 1 turn.
			//       After a friendly minion dies, give a minion in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_251", new Power {
				// TODO [TRL_251] Spirit of the Bat && Test: Spirit of the Bat_TRL_251
				InfoCardId = "TRL_251e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [TRL_252] High Priestess Jeklik - COST:4 [ATK:3/HP:4] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>, <b>Lifesteal</b>
			//       When you discard this,
			//       add 2 copies of it to
			//       your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - InvisibleDeathrattle = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("TRL_252", new Power {
				// TODO [TRL_252] High Priestess Jeklik && Test: High Priestess Jeklik_TRL_252
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [TRL_253] Hir'eek, the Bat - COST:8 [ATK:1/HP:1] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Fill your board with copies of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_253", new Power {
				// TODO [TRL_253] Hir'eek, the Bat && Test: Hir'eek, the Bat_TRL_253
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [TRL_257] Blood Troll Sapper - COST:7 [ATK:5/HP:8] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: After a friendly minion dies, deal 2 damage to the enemy hero.
			// --------------------------------------------------------
			cards.Add("TRL_257", new Power {
				// TODO [TRL_257] Blood Troll Sapper && Test: Blood Troll Sapper_TRL_257
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [TRL_551] Reckless Diretroll - COST:3 [ATK:2/HP:6] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Discard your lowest Cost card.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// - DISCARD_CARDS = 1
			// --------------------------------------------------------
			cards.Add("TRL_551", new Power {
				// TODO [TRL_551] Reckless Diretroll && Test: Reckless Diretroll_TRL_551
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [TRL_245] Shriek - COST:1 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Discard your lowest Cost card. Deal $2 damage to all minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - DISCARD_CARDS = 1
			// --------------------------------------------------------
			cards.Add("TRL_245", new Power {
				// TODO [TRL_245] Shriek && Test: Shriek_TRL_245
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [TRL_246] Void Contract - COST:8 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy half of each player's deck.
			// --------------------------------------------------------
			cards.Add("TRL_246", new Power {
				// TODO [TRL_246] Void Contract && Test: Void Contract_TRL_246
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [TRL_249] Grim Rally - COST:1 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a friendly minion. Give your minions +1/+1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_249", new Power {
				// TODO [TRL_249] Grim Rally && Test: Grim Rally_TRL_249
				InfoCardId = "TRL_249e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [TRL_555] Demonbolt - COST:8 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a minion. Costs (1) less for each minion you control.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_555", new Power {
				// TODO [TRL_555] Demonbolt && Test: Demonbolt_TRL_555
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [TRL_323] Emberscale Drake - COST:5 [ATK:5/HP:5] 
			// - Race: dragon, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain 5 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_323", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, new ArmorTask(5)))
			});

			// --------------------------------------- MINION - WARRIOR
			// [TRL_326] Smolderthorn Lancer - COST:3 [ATK:3/HP:2] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy a damaged enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// - REQ_DAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_326", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, new DestroyTask(EntityType.TARGET)))
			});

			// --------------------------------------- MINION - WARRIOR
			// [TRL_327] Spirit of the Rhino - COST:1 [ATK:0/HP:3] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Stealth</b> for 1 turn.
			//       Your <b>Rush</b> minions are <b>Immune</b> the turn they're summoned.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_327", new Power {
				// TODO [TRL_327] Spirit of the Rhino && Test: Spirit of the Rhino_TRL_327
				InfoCardId = "TRL_327e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [TRL_328] War Master Voone - COST:4 [ATK:4/HP:3] 
			// - Fac: neutral, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Copy all
			//       Dragons in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_328", new Power {
				// TODO [TRL_328] War Master Voone && Test: War Master Voone_TRL_328
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [TRL_329] Akali, the Rhino - COST:8 [ATK:5/HP:5] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill:</b> Draw a <b>Rush</b> minion from your deck. Give it +5/+5.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - RUSH = 1
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_329", new Power {
				// TODO [TRL_329] Akali, the Rhino && Test: Akali, the Rhino_TRL_329
				InfoCardId = "TRL_329e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TRL_321] Devastate - COST:1 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage to a damaged minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_DAMAGED_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_321", new Power {
				// TODO [TRL_321] Devastate && Test: Devastate_TRL_321
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TRL_324] Heavy Metal! - COST:6 
			// - Fac: neutral, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Summon a random
			//       minion with Cost equal
			//       to your Armor <i>(up to 10).</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("TRL_324", new Power {
				// TODO [TRL_324] Heavy Metal! && Test: Heavy Metal!_TRL_324
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TRL_362] Dragon Roar - COST:2 
			// - Fac: neutral, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Add 2 random Dragons to your hand.
			// --------------------------------------------------------
			cards.Add("TRL_362", new Power {
				// TODO [TRL_362] Dragon Roar && Test: Dragon Roar_TRL_362
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [TRL_325] Sul'thraze - COST:6 [ATK:4/HP:0] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Overkill</b>: You may attack again.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_325", new Power {
				// TODO [TRL_325] Sul'thraze && Test: Sul'thraze_TRL_325
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [TRL_360] Overlord's Whip - COST:3 [ATK:2/HP:0] 
			// - Fac: neutral, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: After you play a minion, deal 1 damage to it.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			cards.Add("TRL_360", new Power {
				// TODO [TRL_360] Overlord's Whip && Test: Overlord's Whip_TRL_360
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [TRL_329e] Rhino Skin (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +5/+5.
			// --------------------------------------------------------
			cards.Add("TRL_329e", new Power {
				// TODO [TRL_329e] Rhino Skin && Test: Rhino Skin_TRL_329e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [TRL_010] Half-Time Scavenger - COST:4 [ATK:3/HP:5] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Overkill</b>: Gain 3 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_010", new Power {
				// TODO [TRL_010] Half-Time Scavenger && Test: Half-Time Scavenger_TRL_010
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_015] Ticket Scalper - COST:4 [ATK:5/HP:3] 
			// - Race: pirate, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Overkill</b>: Draw 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_015", new Power {
				// TODO [TRL_015] Ticket Scalper && Test: Ticket Scalper_TRL_015
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_020] Sightless Ranger - COST:5 [ATK:3/HP:4] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill</b>: Summon two 1/1_Bats.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_020", new Power {
				// TODO [TRL_020] Sightless Ranger && Test: Sightless Ranger_TRL_020
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_057] Serpent Ward - COST:2 [ATK:0/HP:2] 
			// - Race: totem, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn,
			//       deal 2 damage to the enemy hero.
			// --------------------------------------------------------
			cards.Add("TRL_057", new Power {
				// TODO [TRL_057] Serpent Ward && Test: Serpent Ward_TRL_057
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_096] Griftah - COST:4 [ATK:4/HP:5] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Discover</b> two
			//       cards. Give one to your
			//       opponent at random.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_096", new Power {
				// TODO [TRL_096] Griftah && Test: Griftah_TRL_096
				InfoCardId = "TRL_096e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_151] Former Champ - COST:5 [ATK:1/HP:1] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 5/5_Hotshot.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_151", new Power {
				// TODO [TRL_151] Former Champ && Test: Former Champ_TRL_151
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_312] Spellzerker - COST:2 [ATK:2/HP:3] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Has <b>Spell Damage +2</b> while damaged.
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("TRL_312", new Power {
				// TODO [TRL_312] Spellzerker && Test: Spellzerker_TRL_312
				InfoCardId = "TRL_312e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_363] Saronite Taskmaster - COST:1 [ATK:2/HP:3] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 0/3 Free Agent with <b>Taunt</b> for_your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_363", new Power {
				// TODO [TRL_363] Saronite Taskmaster && Test: Saronite Taskmaster_TRL_363
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_405] Untamed Beastmaster - COST:3 [ATK:3/HP:4] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you draw a Beast, give it +2/+2.
			// --------------------------------------------------------
			cards.Add("TRL_405", new Power {
				// TODO [TRL_405] Untamed Beastmaster && Test: Untamed Beastmaster_TRL_405
				InfoCardId = "TRL_405e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_406] Dozing Marksman - COST:2 [ATK:0/HP:4] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Has +4 Attack while damaged.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("TRL_406", new Power {
				// TODO [TRL_406] Dozing Marksman && Test: Dozing Marksman_TRL_406
				InfoCardId = "TRL_406e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_407] Waterboy - COST:2 [ATK:2/HP:1] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your next Hero Power this turn costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_407", new Power {
				// TODO [TRL_407] Waterboy && Test: Waterboy_TRL_407
				InfoCardId = "TRL_407e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_503] Scarab Egg - COST:2 [ATK:0/HP:2] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon three 1/1 Scarabs.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_503", new Power {
				// TODO [TRL_503] Scarab Egg && Test: Scarab Egg_TRL_503
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_504] Booty Bay Bookie - COST:2 [ATK:3/HP:3] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your opponent a Coin.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_504", new Power {
				// TODO [TRL_504] Booty Bay Bookie && Test: Booty Bay Bookie_TRL_504
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_505] Helpless Hatchling - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Reduce the Cost of a Beast in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_505", new Power {
				// TODO [TRL_505] Helpless Hatchling && Test: Helpless Hatchling_TRL_505
				InfoCardId = "TRL_505e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_506] Gurubashi Chicken - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Gain +5 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_506", new Power {
				// TODO [TRL_506] Gurubashi Chicken && Test: Gurubashi Chicken_TRL_506
				InfoCardId = "TRL_506e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_507] Sharkfin Fan - COST:2 [ATK:2/HP:2] 
			// - Race: pirate, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: After your hero attacks, summon a 1/1 Pirate.
			// --------------------------------------------------------
			cards.Add("TRL_507", new Power {
				// TODO [TRL_507] Sharkfin Fan && Test: Sharkfin Fan_TRL_507
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_508] Regeneratin' Thug - COST:4 [ATK:3/HP:5] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of your turn, restore #2 Health to this_minion.
			// --------------------------------------------------------
			cards.Add("TRL_508", new Power {
				// TODO [TRL_508] Regeneratin' Thug && Test: Regeneratin' Thug_TRL_508
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_509] Banana Buffoon - COST:3 [ATK:2/HP:2] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add 2 Bananas to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_509", new Power {
				// TODO [TRL_509] Banana Buffoon && Test: Banana Buffoon_TRL_509
				InfoCardId = "TRL_509te",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_512] Cheaty Anklebiter - COST:2 [ATK:2/HP:1] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       <b>Battlecry:</b> Deal 1 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("TRL_512", new Power {
				// TODO [TRL_512] Cheaty Anklebiter && Test: Cheaty Anklebiter_TRL_512
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_513] Mosh'ogg Enforcer - COST:8 [ATK:2/HP:14] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("TRL_513", new Power {
				// TODO [TRL_513] Mosh'ogg Enforcer && Test: Mosh'ogg Enforcer_TRL_513
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_514] Belligerent Gnome - COST:2 [ATK:1/HP:4] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> If your opponent
			//       has 2 or more minions,
			//       gain +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_514", new Power {
				// TODO [TRL_514] Belligerent Gnome && Test: Belligerent Gnome_TRL_514
				InfoCardId = "TRL_514e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_515] Rabble Bouncer - COST:7 [ATK:2/HP:7] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Costs (1) less for each enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_515", new Power {
				// TODO [TRL_515] Rabble Bouncer && Test: Rabble Bouncer_TRL_515
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_516] Gurubashi Offering - COST:1 [ATK:0/HP:2] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy this and gain 8_Armor.
			// --------------------------------------------------------
			// GameTag:
			// - 886 = 1
			// --------------------------------------------------------
			cards.Add("TRL_516", new Power {
				// TODO [TRL_516] Gurubashi Offering && Test: Gurubashi Offering_TRL_516
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_517] Arena Fanatic - COST:4 [ATK:2/HP:3] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all minions in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_517", new Power {
				// TODO [TRL_517] Arena Fanatic && Test: Arena Fanatic_TRL_517
				InfoCardId = "TRL_517e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_520] Murloc Tastyfin - COST:4 [ATK:3/HP:2] 
			// - Race: murloc, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Draw 2 Murlocs
			//       from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_520", new Power {
				// TODO [TRL_520] Murloc Tastyfin && Test: Murloc Tastyfin_TRL_520
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_521] Arena Patron - COST:5 [ATK:3/HP:3] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Summon another Arena Patron.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_521", new Power {
				// TODO [TRL_521] Arena Patron && Test: Arena Patron_TRL_521
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_523] Firetree Witchdoctor - COST:2 [ATK:2/HP:2] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you're holding
			//       a Dragon, <b>Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_523", new Power {
				// TODO [TRL_523] Firetree Witchdoctor && Test: Firetree Witchdoctor_TRL_523
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_524] Shieldbreaker - COST:2 [ATK:2/HP:1] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b> an enemy minion with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_MUST_TARGET_TAUNTER = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("TRL_524", new Power {
				// TODO [TRL_524] Shieldbreaker && Test: Shieldbreaker_TRL_524
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_525] Arena Treasure Chest - COST:4 [ATK:0/HP:4] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_525", new Power {
				// TODO [TRL_525] Arena Treasure Chest && Test: Arena Treasure Chest_TRL_525
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_526] Dragonmaw Scorcher - COST:5 [ATK:3/HP:6] 
			// - Race: dragon, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage to all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_526", new Power {
				// TODO [TRL_526] Dragonmaw Scorcher && Test: Dragonmaw Scorcher_TRL_526
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_527] Drakkari Trickster - COST:3 [ATK:3/HP:4] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Give each player a
			//       copy of a random card from
			//       their opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_527", new Power {
				// TODO [TRL_527] Drakkari Trickster && Test: Drakkari Trickster_TRL_527
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_528] Linecracker - COST:7 [ATK:5/HP:10] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Double this minion's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_528", new Power {
				// TODO [TRL_528] Linecracker && Test: Linecracker_TRL_528
				InfoCardId = "TRL_528e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_530] Masked Contender - COST:3 [ATK:2/HP:4] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a_<b>Secret</b>, play a <b>Secret</b> from_your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TRL_530", new Power {
				// TODO [TRL_530] Masked Contender && Test: Masked Contender_TRL_530
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_531] Rumbletusk Shaker - COST:4 [ATK:3/HP:2] 
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 3/2 Rumbletusk Breaker.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_531", new Power {
				// TODO [TRL_531] Rumbletusk Shaker && Test: Rumbletusk Shaker_TRL_531
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_532] Mosh'Ogg Announcer - COST:5 [ATK:6/HP:5] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Enemies attacking this
			//       have a 50% chance to
			//       attack someone else.
			// --------------------------------------------------------
			cards.Add("TRL_532", new Power {
				// TODO [TRL_532] Mosh'Ogg Announcer && Test: Mosh'Ogg Announcer_TRL_532
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_533] Ice Cream Peddler - COST:4 [ATK:3/HP:5] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a_<b>Frozen</b> minion, gain 8_Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("TRL_533", new Power {
				// TODO [TRL_533] Ice Cream Peddler && Test: Ice Cream Peddler_TRL_533
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_535] Snapjaw Shellfighter - COST:5 [ATK:3/HP:8] 
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Whenever an adjacent
			//       minion takes damage, this
			//       _minion takes it instead.
			// --------------------------------------------------------
			cards.Add("TRL_535", new Power {
				// TODO [TRL_535] Snapjaw Shellfighter && Test: Snapjaw Shellfighter_TRL_535
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_537] Da Undatakah - COST:8 [ATK:8/HP:5] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain the
			//       <b>Deathrattle</b> effects of
			//       3 friendly minions that
			//       died this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_537", new Power {
				// TODO [TRL_537] Da Undatakah && Test: Da Undatakah_TRL_537
				InfoCardId = "TRL_537e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_541] Hakkar, the Soulflayer - COST:10 [ATK:9/HP:6] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle a Corrupted Blood into each player's deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_541", new Power {
				// TODO [TRL_541] Hakkar, the Soulflayer && Test: Hakkar, the Soulflayer_TRL_541
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_542] Oondasta - COST:9 [ATK:7/HP:7] 
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill:</b> Summon a Beast from your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - RUSH = 1
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_542", new Power {
				// TODO [TRL_542] Oondasta && Test: Oondasta_TRL_542
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_546] Ornery Tortoise - COST:3 [ATK:3/HP:5] 
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 5 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_546", new Power {
				PowerTask = new DamageTask(5, EntityType.HERO)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_550] Amani War Bear - COST:7 [ATK:5/HP:7] 
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_550", null);

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_564] Mojomaster Zihi - COST:6 [ATK:5/HP:5] 
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Set each player to 5 Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_564", new Power {
				// TODO [TRL_564] Mojomaster Zihi && Test: Mojomaster Zihi_TRL_564
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_569] Crowd Roaster - COST:7 [ATK:7/HP:4] 
			// - Race: dragon, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you're holding
			//       a Dragon, deal 7 damage
			//       to an enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// --------------------------------------------------------
			cards.Add("TRL_569", new Power {
				// TODO [TRL_569] Crowd Roaster && Test: Crowd Roaster_TRL_569
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_570] Soup Vendor - COST:2 [ATK:1/HP:4] 
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you restore 3 or more Health to your hero, draw a card.
			// --------------------------------------------------------
			cards.Add("TRL_570", new Power {
				// TODO [TRL_570] Soup Vendor && Test: Soup Vendor_TRL_570
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_058e] Visions (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_058e", new Power {
				// TODO [TRL_058e] Visions && Test: Visions_TRL_058e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_071e] Bloody Sails (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("TRL_071e", new Power {
				// TODO [TRL_071e] Bloody Sails && Test: Bloody Sails_TRL_071e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_074e] Carnassial (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("TRL_074e", new Power {
				// TODO [TRL_074e] Carnassial && Test: Carnassial_TRL_074e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_077e] Hype! (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Gurubashi Hypemon made this 1/1.
			// --------------------------------------------------------
			cards.Add("TRL_077e", new Power {
				// TODO [TRL_077e] Hype! && Test: Hype!_TRL_077e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_092e] Power of the Shark (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Your minions' <b>Battlecries</b>
			//       __and <b>Combos</b> trigger twice._
			// --------------------------------------------------------
			cards.Add("TRL_092e", new Power {
				// TODO [TRL_092e] Power of the Shark && Test: Power of the Shark_TRL_092e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_096e] Guess the Card! (*) - COST:4 [ATK:4/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Guess the card your opponent chose to get a copy.
			// --------------------------------------------------------
			cards.Add("TRL_096e", new Power {
				// TODO [TRL_096e] Guess the Card! && Test: Guess the Card!_TRL_096e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_111e1] Headhunter's Hatchet (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Increased Durability.
			// --------------------------------------------------------
			cards.Add("TRL_111e1", new Power {
				// TODO [TRL_111e1] Headhunter's Hatchet && Test: Headhunter's Hatchet_TRL_111e1
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_119e] The Beast Within (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("TRL_119e", new Power {
				// TODO [TRL_119e] The Beast Within && Test: The Beast Within_TRL_119e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_243e] Pounce (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_243e", new Power {
				// TODO [TRL_243e] Pounce && Test: Pounce_TRL_243e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_244e] Predatory Instincts (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Doubled Health.
			// --------------------------------------------------------
			cards.Add("TRL_244e", new Power {
				// TODO [TRL_244e] Predatory Instincts && Test: Predatory Instincts_TRL_244e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_249e] Grim Rally (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("TRL_249e", new Power {
				// TODO [TRL_249e] Grim Rally && Test: Grim Rally_TRL_249e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_251e] Hir'eek's Offering (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Increased stats from Spirit of the Bat.
			// --------------------------------------------------------
			cards.Add("TRL_251e", new Power {
				// TODO [TRL_251e] Hir'eek's Offering && Test: Hir'eek's Offering_TRL_251e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_304e] Battle Ready (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +2/+2 from Farraki Battleaxe.
			// --------------------------------------------------------
			cards.Add("TRL_304e", new Power {
				// TODO [TRL_304e] Battle Ready && Test: Battle Ready_TRL_304e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_312e] Power of Gurubashi (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Spell Damage +2</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("TRL_312e", new Power {
				// TODO [TRL_312e] Power of Gurubashi && Test: Power of Gurubashi_TRL_312e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_319e] Power of the Dragonhawk (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Your Hero Power also hits adjacent minions.
			// --------------------------------------------------------
			cards.Add("TRL_319e", new Power {
				// TODO [TRL_319e] Power of the Dragonhawk && Test: Power of the Dragonhawk_TRL_319e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_327e] Protected by Spirit of the Rhino (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_327e", new Power {
				// TODO [TRL_327e] Protected by Spirit of the Rhino && Test: Protected by Spirit of the Rhino_TRL_327e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_390e2] Flameweaving (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Your next Hero Power deals 2 more damage.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_390e2", new Power {
				// TODO [TRL_390e2] Flameweaving && Test: Flameweaving_TRL_390e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_405e] Warpaint (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("TRL_405e", new Power {
				// TODO [TRL_405e] Warpaint && Test: Warpaint_TRL_405e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_406e] Wrong Side of Da Bed (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +4 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("TRL_406e", new Power {
				// TODO [TRL_406e] Wrong Side of Da Bed && Test: Wrong Side of Da Bed_TRL_406e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_407e] High Quality H2O (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Your Hero Power costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_407e", new Power {
				// TODO [TRL_407e] High Quality H2O && Test: High Quality H2O_TRL_407e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_501e] Dark Soul (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Your healing effects are dealing damage.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_501e", new Power {
				// TODO [TRL_501e] Dark Soul && Test: Dark Soul_TRL_501e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_505e] Avenger (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("TRL_505e", new Power {
				// TODO [TRL_505e] Avenger && Test: Avenger_TRL_505e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_506e] Ready to Strike (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +5 Attack.
			// --------------------------------------------------------
			cards.Add("TRL_506e", new Power {
				// TODO [TRL_506e] Ready to Strike && Test: Ready to Strike_TRL_506e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_509te] Bananas (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Has +1/+1.
			// --------------------------------------------------------
			cards.Add("TRL_509te", new Power {
				// TODO [TRL_509te] Bananas && Test: Bananas_TRL_509te
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_514e] Belligerent (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("TRL_514e", new Power {
				// TODO [TRL_514e] Belligerent && Test: Belligerent_TRL_514e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_517e2] WHOOOOO! (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("TRL_517e2", new Power {
				// TODO [TRL_517e2] WHOOOOO! && Test: WHOOOOO!_TRL_517e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_528e] Crazed (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Doubled Attack.
			// --------------------------------------------------------
			cards.Add("TRL_528e", new Power {
				// TODO [TRL_528e] Crazed && Test: Crazed_TRL_528e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_537e] Undatakah Deathrattles (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			cards.Add("TRL_537e", new Power {
				// TODO [TRL_537e] Undatakah Deathrattles && Test: Undatakah Deathrattles_TRL_537e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_545e] Rejuvenated (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +4/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("TRL_545e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_545e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_901e] Blessing of Halazzi (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("TRL_901e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_901e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_020t] Bat (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			cards.Add("TRL_020t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_151t] Hotshot (*) - COST:5 [ATK:5/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			cards.Add("TRL_151t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_316t] Ragnaros the Firelord (*) - COST:8 [ATK:8/HP:8] 
			// - Race: elemental, Fac: neutral, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: Can't attack. At the end of your turn, deal 8 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("TRL_316t", new Power {
				// TODO [TRL_316t] Ragnaros the Firelord && Test: Ragnaros the Firelord_TRL_316t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_363t] Free Agent (*) - COST:1 [ATK:0/HP:3] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_363t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_503t] Scarab (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			cards.Add("TRL_503t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_507t] Swabbie (*) - COST:1 [ATK:1/HP:1] 
			// - Race: pirate, Set: troll, 
			// --------------------------------------------------------
			cards.Add("TRL_507t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_531t] Rumbletusk Breaker (*) - COST:2 [ATK:3/HP:2] 
			// - Set: troll, 
			// --------------------------------------------------------
			cards.Add("TRL_531t", null);

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRL_509t] Bananas (*) - COST:1 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Give a minion +1/+1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_509t", new Power {
				// TODO [TRL_509t] Bananas && Test: Bananas_TRL_509t
				InfoCardId = "TRL_509te",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRL_541t] Corrupted Blood (*) - COST:1 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Casts When Drawn</b>
			//       Take 3 damage. After you draw, shuffle two copies of this into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			// RefTag:
			// - CASTSWHENDRAWN = 1
			// --------------------------------------------------------
			cards.Add("TRL_541t", new Power {
				// TODO [TRL_541t] Corrupted Blood && Test: Corrupted Blood_TRL_541t
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
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
