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
	public class BrmCardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- HERO - NEUTRAL
			// [BRM_027h] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:8] 
			// - Set: brm, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2319
			// --------------------------------------------------------
			cards.Add("BRM_027h", new Power {
				// TODO [BRM_027h] Ragnaros the Firelord && Test: Ragnaros the Firelord_BRM_027h
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRM_027p] DIE, INSECT! (*) - COST:2 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $8 damage to a random enemy. @spelldmg
			// --------------------------------------------------------
			cards.Add("BRM_027p", new Power {
				// TODO [BRM_027p] DIE, INSECT! && Test: DIE, INSECT!_BRM_027p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRM_027pH] DIE, INSECTS! (*) - COST:2 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $8 damage to a random enemy. TWICE. @spelldmg
			// --------------------------------------------------------
			cards.Add("BRM_027pH", new Power {
				// TODO [BRM_027pH] DIE, INSECTS! && Test: DIE, INSECTS!_BRM_027pH
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [BRM_009] Volcanic Lumberer - COST:9 [ATK:7/HP:8] 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Costs (1) less for each minion that died this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BRM_009", new Power {
				// TODO [BRM_009] Volcanic Lumberer && Test: Volcanic Lumberer_BRM_009
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [BRM_010] Druid of the Flame - COST:3 [ATK:2/HP:2] 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Transform into a 5/2 minion; or a 2/5 minion.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("BRM_010", new Power {
				// TODO [BRM_010] Druid of the Flame && Test: Druid of the Flame_BRM_010
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [BRM_010t] Druid of the Flame (*) - COST:3 [ATK:5/HP:2] 
			// - Race: beast, Set: brm, Rarity: common
			// --------------------------------------------------------
			cards.Add("BRM_010t", new Power {
				// TODO [BRM_010t] Druid of the Flame && Test: Druid of the Flame_BRM_010t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [BRM_010t2] Druid of the Flame (*) - COST:3 [ATK:2/HP:5] 
			// - Race: beast, Set: brm, Rarity: common
			// --------------------------------------------------------
			cards.Add("BRM_010t2", new Power {
				// TODO [BRM_010t2] Druid of the Flame && Test: Druid of the Flame_BRM_010t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [OG_044b] Druid of the Flame (*) - COST:3 [ATK:5/HP:5] 
			// - Race: beast, Set: brm, Rarity: common
			// --------------------------------------------------------
			cards.Add("OG_044b", new Power {
				// TODO [OG_044b] Druid of the Flame && Test: Druid of the Flame_OG_044b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [BRM_010a] Firecat Form (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("BRM_010a", new Power {
				// TODO [BRM_010a] Firecat Form && Test: Firecat Form_BRM_010a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [BRM_010b] Fire Hawk Form (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("BRM_010b", new Power {
				// TODO [BRM_010b] Fire Hawk Form && Test: Fire Hawk Form_BRM_010b
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [BRM_014] Core Rager - COST:4 [ATK:4/HP:4] 
			// - Race: beast, Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your hand is empty, gain +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_014", new Power {
				// TODO [BRM_014] Core Rager && Test: Core Rager_BRM_014
				InfoCardId = "BRM_014e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [BRM_013] Quick Shot - COST:2 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage.
			//       If your hand is empty, draw a card. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BRM_013", new Power {
				// TODO [BRM_013] Quick Shot && Test: Quick Shot_BRM_013
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [BRM_014e] Power Rager (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: +3/+3
			// --------------------------------------------------------
			cards.Add("BRM_014e", new Power {
				// TODO [BRM_014e] Power Rager && Test: Power Rager_BRM_014e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [BRM_002] Flamewaker - COST:3 [ATK:2/HP:4] 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: After you cast a spell, deal 2 damage randomly split among all enemies.
			// --------------------------------------------------------
			cards.Add("BRM_002", new Power {
				// TODO [BRM_002] Flamewaker && Test: Flamewaker_BRM_002
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [BRM_003] Dragon's Breath - COST:5 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage. Costs (1) less for each minion that died this turn. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BRM_003", new Power {
				// TODO [BRM_003] Dragon's Breath && Test: Dragon's Breath_BRM_003
				InfoCardId = "BRM_003e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [BRM_003e] Dragon's Might (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Costs (3) less this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BRM_003e", new Power {
				// TODO [BRM_003e] Dragon's Might && Test: Dragon's Might_BRM_003e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [BRM_018] Dragon Consort - COST:5 [ATK:5/HP:5] 
			// - Race: dragon, Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> The next Dragon you play costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_018", new Power {
				// TODO [BRM_018] Dragon Consort && Test: Dragon Consort_BRM_018
				InfoCardId = "BRM_018e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [BRM_001] Solemn Vigil - COST:5 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 cards. Costs (1) less for each minion that died this turn.
			// --------------------------------------------------------
			cards.Add("BRM_001", new Power {
				// TODO [BRM_001] Solemn Vigil && Test: Solemn Vigil_BRM_001
				InfoCardId = "BRM_001e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [BRM_018e] Unchained! (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Your next Dragon costs (2) less.
			// --------------------------------------------------------
			cards.Add("BRM_018e", new Power {
				// TODO [BRM_018e] Unchained! && Test: Unchained!_BRM_018e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [BRM_004] Twilight Whelp - COST:1 [ATK:2/HP:1] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_004", new Power {
				// TODO [BRM_004] Twilight Whelp && Test: Twilight Whelp_BRM_004
				InfoCardId = "BRM_004e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [BRM_017] Resurrect - COST:2 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a random friendly minion that died this game.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			cards.Add("BRM_017", new Power {
				// TODO [BRM_017] Resurrect && Test: Resurrect_BRM_017
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BRM_001e] Melt (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Attack changed to 0 this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BRM_001e", new Power {
				// TODO [BRM_001e] Melt && Test: Melt_BRM_001e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [BRM_008] Dark Iron Skulker - COST:5 [ATK:4/HP:3] 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage to all undamaged enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_008", new Power {
				// TODO [BRM_008] Dark Iron Skulker && Test: Dark Iron Skulker_BRM_008
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [BRM_007] Gang Up - COST:2 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Choose a minion. Shuffle 3 copies of it into your deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BRM_007", new Power {
				// TODO [BRM_007] Gang Up && Test: Gang Up_BRM_007
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [BRM_012] Fireguard Destroyer - COST:4 [ATK:3/HP:6] 
			// - Race: elemental, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain 1-4 Attack. <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - BATTLECRY = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			cards.Add("BRM_012", new Power {
				// TODO [BRM_012] Fireguard Destroyer && Test: Fireguard Destroyer_BRM_012
				InfoCardId = "BRM_012e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [BRM_011] Lava Shock - COST:2 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage.
			//       Unlock your <b>Overloaded</b> Mana Crystals. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("BRM_011", new Power {
				// TODO [BRM_011] Lava Shock && Test: Lava Shock_BRM_011
				InfoCardId = "BRM_011t",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [BRM_011t] Lava Shock (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Cards you play this turn don't cause <b>Overload</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BRM_011t", new Power {
				// TODO [BRM_011t] Lava Shock && Test: Lava Shock_BRM_011t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [BRM_006] Imp Gang Boss - COST:3 [ATK:2/HP:4] 
			// - Race: demon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, summon a 1/1 Imp.
			// --------------------------------------------------------
			cards.Add("BRM_006", new Power {
				// TODO [BRM_006] Imp Gang Boss && Test: Imp Gang Boss_BRM_006
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [BRM_005] Demonwrath - COST:3 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Deal $2 damage to all
			//       minions except Demons. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("BRM_005", new Power {
				// TODO [BRM_005] Demonwrath && Test: Demonwrath_BRM_005
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [BRM_006t] Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Set: brm, 
			// --------------------------------------------------------
			cards.Add("BRM_006t", new Power {
				// TODO [BRM_006t] Imp && Test: Imp_BRM_006t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [BRM_016] Axe Flinger - COST:4 [ATK:2/HP:5] 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, deal 2 damage to the enemy hero.
			// --------------------------------------------------------
			cards.Add("BRM_016", new Power {
				// TODO [BRM_016] Axe Flinger && Test: Axe Flinger_BRM_016
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [BRM_015] Revenge - COST:2 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $1 damage to all minions. If you have 12 or less Health, deal $3 damage instead. @spelldmg
			// --------------------------------------------------------
			cards.Add("BRM_015", new Power {
				// TODO [BRM_015] Revenge && Test: Revenge_BRM_015
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [BRM_019] Grim Patron - COST:5 [ATK:3/HP:3] 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: After this minion survives damage, summon another Grim Patron.
			// --------------------------------------------------------
			cards.Add("BRM_019", new Power {
				// TODO [BRM_019] Grim Patron && Test: Grim Patron_BRM_019
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_020] Dragonkin Sorcerer - COST:4 [ATK:3/HP:5] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever <b>you</b> target this minion with a spell, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("BRM_020", new Power {
				// TODO [BRM_020] Dragonkin Sorcerer && Test: Dragonkin Sorcerer_BRM_020
				InfoCardId = "BRM_020e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_022] Dragon Egg - COST:1 [ATK:0/HP:2] 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, summon a 2/1 Whelp.
			// --------------------------------------------------------
			cards.Add("BRM_022", new Power {
				// TODO [BRM_022] Dragon Egg && Test: Dragon Egg_BRM_022
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_024] Drakonid Crusher - COST:6 [ATK:6/HP:6] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your opponent has 15 or less Health, gain +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_024", new Power {
				// TODO [BRM_024] Drakonid Crusher && Test: Drakonid Crusher_BRM_024
				InfoCardId = "BRM_024e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_025] Volcanic Drake - COST:6 [ATK:6/HP:4] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Costs (1) less for each minion that died this turn.
			// --------------------------------------------------------
			cards.Add("BRM_025", new Power {
				// TODO [BRM_025] Volcanic Drake && Test: Volcanic Drake_BRM_025
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_026] Hungry Dragon - COST:4 [ATK:5/HP:6] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a random 1-Cost minion for_your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_026", new Power {
				// TODO [BRM_026] Hungry Dragon && Test: Hungry Dragon_BRM_026
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_027] Majordomo Executus - COST:9 [ATK:9/HP:7] 
			// - Set: brm, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Replace your hero with Ragnaros, the Firelord.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BRM_027", new Power {
				// TODO [BRM_027] Majordomo Executus && Test: Majordomo Executus_BRM_027
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_028] Emperor Thaurissan - COST:6 [ATK:5/HP:5] 
			// - Set: brm, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, reduce the Cost of cards in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRM_028", new Power {
				// TODO [BRM_028] Emperor Thaurissan && Test: Emperor Thaurissan_BRM_028
				InfoCardId = "BRM_028e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_029] Rend Blackhand - COST:7 [ATK:8/HP:4] 
			// - Set: brm, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy a <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// - REQ_LEGENDARY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BRM_029", new Power {
				// TODO [BRM_029] Rend Blackhand && Test: Rend Blackhand_BRM_029
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_030] Nefarian - COST:9 [ATK:8/HP:8] 
			// - Race: dragon, Set: brm, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add 2 random spells to your hand <i>(from your opponent's class)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_030", new Power {
				// TODO [BRM_030] Nefarian && Test: Nefarian_BRM_030
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_031] Chromaggus - COST:8 [ATK:6/HP:8] 
			// - Race: dragon, Set: brm, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you draw a card, put another copy into your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRM_031", new Power {
				// TODO [BRM_031] Chromaggus && Test: Chromaggus_BRM_031
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_033] Blackwing Technician - COST:3 [ATK:2/HP:4] 
			// - Fac: neutral, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_033", new Power {
				// TODO [BRM_033] Blackwing Technician && Test: Blackwing Technician_BRM_033
				InfoCardId = "BRM_033e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_034] Blackwing Corruptor - COST:5 [ATK:5/HP:4] 
			// - Fac: neutral, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, deal 3 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// --------------------------------------------------------
			cards.Add("BRM_034", new Power {
				// TODO [BRM_034] Blackwing Corruptor && Test: Blackwing Corruptor_BRM_034
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_004e] Twilight Endurance (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("BRM_004e", new Power {
				// TODO [BRM_004e] Twilight Endurance && Test: Twilight Endurance_BRM_004e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_012e] On Fire! (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("BRM_012e", new Power {
				// TODO [BRM_012e] On Fire! && Test: On Fire!_BRM_012e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_020e] Draconic Power (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("BRM_020e", new Power {
				// TODO [BRM_020e] Draconic Power && Test: Draconic Power_BRM_020e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_024e] Large Talons (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("BRM_024e", new Power {
				// TODO [BRM_024e] Large Talons && Test: Large Talons_BRM_024e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_028e] Imperial Favor (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("BRM_028e", new Power {
				// TODO [BRM_028e] Imperial Favor && Test: Imperial Favor_BRM_028e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_033e] Dragon Blood (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: +1/+1
			// --------------------------------------------------------
			cards.Add("BRM_033e", new Power {
				// TODO [BRM_033e] Dragon Blood && Test: Dragon Blood_BRM_033e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_004t] Whelp (*) - COST:1 [ATK:1/HP:1] 
			// - Set: brm, 
			// --------------------------------------------------------
			cards.Add("BRM_004t", new Power {
				// TODO [BRM_004t] Whelp && Test: Whelp_BRM_004t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_022t] Black Whelp (*) - COST:1 [ATK:2/HP:1] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			cards.Add("BRM_022t", new Power {
				// TODO [BRM_022t] Black Whelp && Test: Black Whelp_BRM_022t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRM_030t] Tail Swipe (*) - COST:4 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Deal $4 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BRM_030t", new Power {
				// TODO [BRM_030t] Tail Swipe && Test: Tail Swipe_BRM_030t
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
			Shaman(cards);
			ShamanNonCollect(cards);
			Warlock(cards);
			WarlockNonCollect(cards);
			Warrior(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
