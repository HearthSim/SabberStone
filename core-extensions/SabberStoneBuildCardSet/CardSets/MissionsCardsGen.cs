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
	public class MissionsCardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- HERO - NEUTRAL
			// [TU4a_001] Hogger (*) - COST:0 [ATK:0/HP:10] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4a_001", new Power {
				// TODO [TU4a_001] Hogger && Test: Hogger_TU4a_001
				//PowerTask = null,
				//Trigger = null,
			});

			// -------------------------------------------- HERO - MAGE
			// [TU4a_006] Jaina Proudmoore (*) - COST:0 [ATK:0/HP:30] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4a_006", new Power {
				// TODO [TU4a_006] Jaina Proudmoore && Test: Jaina Proudmoore_TU4a_006
				//PowerTask = null,
				//Trigger = null,
			});

			// -------------------------------------------- HERO - MAGE
			// [TU4b_001] Millhouse Manastorm (*) - COST:0 [ATK:0/HP:20] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4b_001", new Power {
				// TODO [TU4b_001] Millhouse Manastorm && Test: Millhouse Manastorm_TU4b_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TU4c_001] King Mukla (*) - COST:0 [ATK:0/HP:26] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4c_001", new Power {
				// TODO [TU4c_001] King Mukla && Test: King Mukla_TU4c_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ HERO - HUNTER
			// [TU4d_001] Hemet Nesingwary (*) - COST:0 [ATK:0/HP:20] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4d_001", new Power {
				// TODO [TU4d_001] Hemet Nesingwary && Test: Hemet Nesingwary_TU4d_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ HERO - HUNTER
			// [TU4e_001] Illidan Stormrage (*) - COST:0 [ATK:0/HP:30] 
			// - Set: missions, 
			// --------------------------------------------------------
			cards.Add("TU4e_001", new Power {
				// TODO [TU4e_001] Illidan Stormrage && Test: Illidan Stormrage_TU4e_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TU4f_001] Lorewalker Cho (*) - COST:0 [ATK:0/HP:25] 
			// - Set: missions, 
			// --------------------------------------------------------
			cards.Add("TU4f_001", new Power {
				// TODO [TU4f_001] Lorewalker Cho && Test: Lorewalker Cho_TU4f_001
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ------------------------------------ HERO_POWER - HUNTER
			// [TU4d_003] Shotgun Blast (*) - COST:2 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TU4d_003", new Power {
				// TODO [TU4d_003] Shotgun Blast && Test: Shotgun Blast_TU4d_003
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TU4e_002] Flames of Azzinoth (*) - COST:2 
			// - Set: missions, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon two 2/1 minions.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 2
			// --------------------------------------------------------
			cards.Add("TU4e_002", new Power {
				// TODO [TU4e_002] Flames of Azzinoth && Test: Flames of Azzinoth_TU4e_002
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TU4c_006e] Bananas (*) - COST:0 
			// - Set: missions, 
			// --------------------------------------------------------
			// Text: This minion has +1/+1. <i>(+1 Attack/+1 Health)</i>
			// --------------------------------------------------------
			cards.Add("TU4c_006e", new Power {
				// TODO [TU4c_006e] Bananas && Test: Bananas_TU4c_006e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TU4c_008e] Might of Mukla (*) - COST:0 
			// - Set: missions, 
			// --------------------------------------------------------
			// Text: King Mukla has +8 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TU4c_008e", new Power {
				// TODO [TU4c_008e] Might of Mukla && Test: Might of Mukla_TU4c_008e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TU4f_004o] Legacy of the Emperor (*) - COST:0 
			// - Set: missions, 
			// --------------------------------------------------------
			// Text: Has +2/+2. <i>(+2 Attack/+2 Health)</i>
			// --------------------------------------------------------
			cards.Add("TU4f_004o", new Power {
				// TODO [TU4f_004o] Legacy of the Emperor && Test: Legacy of the Emperor_TU4f_004o
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TU4f_006o] Transcendence (*) - COST:0 
			// - Set: missions, 
			// --------------------------------------------------------
			// Text: Until you kill Cho's minions, he can't be attacked.
			// --------------------------------------------------------
			cards.Add("TU4f_006o", new Power {
				// TODO [TU4f_006o] Transcendence && Test: Transcendence_TU4f_006o
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4a_002] Riverpaw Gnoll (*) - COST:1 [ATK:2/HP:1] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4a_002", new Power {
				// TODO [TU4a_002] Riverpaw Gnoll && Test: Riverpaw Gnoll_TU4a_002
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4a_003] Gnoll (*) - COST:1 [ATK:1/HP:1] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4a_003", new Power {
				// TODO [TU4a_003] Gnoll && Test: Gnoll_TU4a_003
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4a_005] Massive Gnoll (*) - COST:4 [ATK:5/HP:2] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4a_005", new Power {
				// TODO [TU4a_005] Massive Gnoll && Test: Massive Gnoll_TU4a_005
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4c_003] Barrel (*) - COST:0 [ATK:0/HP:2] 
			// - Fac: neutral, Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: Is something in this barrel?
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TU4c_003", new Power {
				// TODO [TU4c_003] Barrel && Test: Barrel_TU4c_003
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4c_005] Hidden Gnome (*) - COST:2 [ATK:1/HP:3] 
			// - Fac: neutral, Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: Was hiding in a barrel!
			// --------------------------------------------------------
			cards.Add("TU4c_005", new Power {
				// TODO [TU4c_005] Hidden Gnome && Test: Hidden Gnome_TU4c_005
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4c_007] Mukla's Big Brother (*) - COST:6 [ATK:10/HP:10] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: So strong! And only 6 Mana?!
			// --------------------------------------------------------
			cards.Add("TU4c_007", new Power {
				// TODO [TU4c_007] Mukla's Big Brother && Test: Mukla's Big Brother_TU4c_007
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4d_002] Crazed Hunter (*) - COST:1 [ATK:1/HP:1] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4d_002", new Power {
				// TODO [TU4d_002] Crazed Hunter && Test: Crazed Hunter_TU4d_002
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4e_002t] Flame of Azzinoth (*) - COST:1 [ATK:2/HP:1] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4e_002t", new Power {
				// TODO [TU4e_002t] Flame of Azzinoth && Test: Flame of Azzinoth_TU4e_002t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4e_003] Naga Myrmidon (*) - COST:1 [ATK:1/HP:1] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: <b></b>
			// --------------------------------------------------------
			cards.Add("TU4e_003", new Power {
				// TODO [TU4e_003] Naga Myrmidon && Test: Naga Myrmidon_TU4e_003
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4f_002] Pandaren Scout (*) - COST:1 [ATK:1/HP:1] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4f_002", new Power {
				// TODO [TU4f_002] Pandaren Scout && Test: Pandaren Scout_TU4f_002
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4f_003] Shado-Pan Monk (*) - COST:2 [ATK:2/HP:2] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4f_003", new Power {
				// TODO [TU4f_003] Shado-Pan Monk && Test: Shado-Pan Monk_TU4f_003
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4f_005] Brewmaster (*) - COST:4 [ATK:4/HP:4] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			cards.Add("TU4f_005", new Power {
				// TODO [TU4f_005] Brewmaster && Test: Brewmaster_TU4f_005
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TU4f_007] Crazy Monkey (*) - COST:1 [ATK:1/HP:2] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Throw Bananas.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TU4f_007", new Power {
				// TODO [TU4f_007] Crazy Monkey && Test: Crazy Monkey_TU4f_007
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TU4a_004] Hogger SMASH! (*) - COST:3 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: Deal 4 damage.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_HERO_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TU4a_004", new Power {
				// TODO [TU4a_004] Hogger SMASH! && Test: Hogger SMASH!_TU4a_004
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TU4c_002] Barrel Toss (*) - COST:1 
			// - Fac: neutral, Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: Deal 2 damage.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TU4c_002", new Power {
				// TODO [TU4c_002] Barrel Toss && Test: Barrel Toss_TU4c_002
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TU4c_004] Stomp (*) - COST:2 
			// - Fac: neutral, Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: Deal 2 damage to all enemies.
			// --------------------------------------------------------
			cards.Add("TU4c_004", new Power {
				// TODO [TU4c_004] Stomp && Test: Stomp_TU4c_004
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TU4c_006] Bananas (*) - COST:1 
			// - Fac: neutral, Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: Give a friendly minion +1/+1. <i>(+1 Attack/+1 Health)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TU4c_006", new Power {
				// TODO [TU4c_006] Bananas && Test: Bananas_TU4c_006
				InfoCardId = "TU4c_006e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TU4c_008] Will of Mukla (*) - COST:3 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: Restore 8 Health.
			// --------------------------------------------------------
			cards.Add("TU4c_008", new Power {
				// TODO [TU4c_008] Will of Mukla && Test: Will of Mukla_TU4c_008
				InfoCardId = "TU4c_008e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TU4e_005] Flame Burst (*) - COST:3 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: Shoot 5 missiles at random enemies for $1 damage each. @spelldmg
			// --------------------------------------------------------
			cards.Add("TU4e_005", new Power {
				// TODO [TU4e_005] Flame Burst && Test: Flame Burst_TU4e_005
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TU4f_004] Legacy of the Emperor (*) - COST:3 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions +2/+2. <i>(+2 Attack/+2 Health)</i>
			// --------------------------------------------------------
			cards.Add("TU4f_004", new Power {
				// TODO [TU4f_004] Legacy of the Emperor && Test: Legacy of the Emperor_TU4f_004
				InfoCardId = "TU4f_004o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TU4f_006] Transcendence (*) - COST:1 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			// Text: Until you kill Cho's minions, he can't be attacked.
			// --------------------------------------------------------
			cards.Add("TU4f_006", new Power {
				// TODO [TU4f_006] Transcendence && Test: Transcendence_TU4f_006
				InfoCardId = "TU4f_006o",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [TU4e_004] Warglaive of Azzinoth (*) - COST:2 [ATK:2/HP:0] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("TU4e_004", new Power {
				// TODO [TU4e_004] Warglaive of Azzinoth && Test: Warglaive of Azzinoth_TU4e_004
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [TU4e_007] Dual Warglaives (*) - COST:6 [ATK:4/HP:0] 
			// - Set: missions, Rarity: common
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("TU4e_007", new Power {
				// TODO [TU4e_007] Dual Warglaives && Test: Dual Warglaives_TU4e_007
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			NeutralNonCollect(cards);
		}
	}
}
