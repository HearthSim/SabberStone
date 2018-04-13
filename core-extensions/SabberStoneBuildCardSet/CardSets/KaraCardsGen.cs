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
	public class KaraCardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_A01_01] Magic Mirror (*) - COST:0 [ATK:0/HP:30] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39632
			// --------------------------------------------------------
			cards.Add("KAR_A01_01", new Power {
				// TODO [KAR_A01_01] Magic Mirror && Test: Magic Mirror_KAR_A01_01
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_A01_01H] Magic Mirror (*) - COST:0 [ATK:0/HP:30] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40085
			// --------------------------------------------------------
			cards.Add("KAR_A01_01H", new Power {
				// TODO [KAR_A01_01H] Magic Mirror && Test: Magic Mirror_KAR_A01_01H
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_A02_12] Silverware Golem (*) - COST:0 [ATK:0/HP:30] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39725
			// --------------------------------------------------------
			cards.Add("KAR_A02_12", new Power {
				// TODO [KAR_A02_12] Silverware Golem && Test: Silverware Golem_KAR_A02_12
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_A02_12H] Silverware Golem (*) - COST:0 [ATK:0/HP:30] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40083
			// --------------------------------------------------------
			cards.Add("KAR_A02_12H", new Power {
				// TODO [KAR_A02_12H] Silverware Golem && Test: Silverware Golem_KAR_A02_12H
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss1] White King (*) - COST:0 [ATK:0/HP:20] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39544
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss1", new Power {
				// TODO [KAR_a10_Boss1] White King && Test: White King_KAR_a10_Boss1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss1H] White King (*) - COST:0 [ATK:0/HP:20] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40086
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss1H", new Power {
				// TODO [KAR_a10_Boss1H] White King && Test: White King_KAR_a10_Boss1H
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss2] Black King (*) - COST:0 [ATK:0/HP:20] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39801
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss2", new Power {
				// TODO [KAR_a10_Boss2] Black King && Test: Black King_KAR_a10_Boss2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss2H] Black King (*) - COST:0 [ATK:0/HP:20] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39801
			// - CANT_BE_FATIGUED = 1
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss2H", new Power {
				// TODO [KAR_a10_Boss2H] Black King && Test: Black King_KAR_a10_Boss2H
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A01_02] Reflections (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever a minion is played, summon a 1/1 copy of it.
			// --------------------------------------------------------
			cards.Add("KAR_A01_02", new Power {
				// TODO [KAR_A01_02] Reflections && Test: Reflections_KAR_A01_02
				InfoCardId = "KAR_A01_02e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A01_02H] Reflections (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever a minion is played, Magic Mirror summons a 1/1 copy of it.
			// --------------------------------------------------------
			cards.Add("KAR_A01_02H", new Power {
				// TODO [KAR_A01_02H] Reflections && Test: Reflections_KAR_A01_02H
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A02_13] Be Our Guest (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 1/1 Plate.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_13", new Power {
				// TODO [KAR_A02_13] Be Our Guest && Test: Be Our Guest_KAR_A02_13
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A02_13H] Be Our Guest (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon two 1/1 Plates.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_13H", new Power {
				// TODO [KAR_A02_13H] Be Our Guest && Test: Be Our Guest_KAR_A02_13H
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A10_22] Castle (*) - COST:2 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Discover</b> a chess piece.
			// --------------------------------------------------------
			// Entourage: KAR_A10_09, KAR_A10_02, KAR_A10_08, KAR_A10_04, KAR_A10_05
			// --------------------------------------------------------
			cards.Add("KAR_A10_22", new Power {
				// TODO [KAR_A10_22] Castle && Test: Castle_KAR_A10_22
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A10_22H] Castle (*) - COST:1 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Move a friendly minion left. Repeatable.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("KAR_A10_22H", new Power {
				// TODO [KAR_A10_22H] Castle && Test: Castle_KAR_A10_22H
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A10_33] Cheat (*) - COST:2 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy the left-most enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_33", new Power {
				// TODO [KAR_A10_33] Cheat && Test: Cheat_KAR_A10_33
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [KAR_065] Menagerie Warden - COST:6 [ATK:5/HP:5] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly Beast. Summon a_copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 20
			// --------------------------------------------------------
			cards.Add("KAR_065", new Power {
				// TODO [KAR_065] Menagerie Warden && Test: Menagerie Warden_KAR_065
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [KAR_300] Enchanted Raven - COST:1 [ATK:2/HP:2] 
			// - Race: beast, Set: kara, Rarity: common
			// --------------------------------------------------------
			cards.Add("KAR_300", new Power {
				// TODO [KAR_300] Enchanted Raven && Test: Enchanted Raven_KAR_300
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [KAR_075] Moonglade Portal - COST:6 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: Restore #6 Health. Summon a random
			//       6-Cost minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("KAR_075", new Power {
				// TODO [KAR_075] Moonglade Portal && Test: Moonglade Portal_KAR_075
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [KAR_005] Kindly Grandmother - COST:2 [ATK:1/HP:1] 
			// - Race: beast, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 3/2 Big Bad Wolf.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("KAR_005", new Power {
				// TODO [KAR_005] Kindly Grandmother && Test: Kindly Grandmother_KAR_005
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [KAR_006] Cloaked Huntress - COST:3 [ATK:3/HP:4] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Your <b>Secrets</b> cost (0).
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("KAR_006", new Power {
				// TODO [KAR_006] Cloaked Huntress && Test: Cloaked Huntress_KAR_006
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [KAR_004] Cat Trick - COST:2 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent casts a spell, summon a 4/2 Panther with <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("KAR_004", new Power {
				// TODO [KAR_004] Cat Trick && Test: Cat Trick_KAR_004
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [KAR_004a] Cat in a Hat (*) - COST:3 [ATK:4/HP:2] 
			// - Race: beast, Fac: horde, Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("KAR_004a", new Power {
				// TODO [KAR_004a] Cat in a Hat && Test: Cat in a Hat_KAR_004a
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [KAR_005a] Big Bad Wolf (*) - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_005a", new Power {
				// TODO [KAR_005a] Big Bad Wolf && Test: Big Bad Wolf_KAR_005a
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [KAR_009] Babbling Book - COST:1 [ATK:1/HP:1] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Mage spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_009", new Power {
				// TODO [KAR_009] Babbling Book && Test: Babbling Book_KAR_009
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [KAR_092] Medivh's Valet - COST:2 [ATK:2/HP:3] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, deal 3 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("KAR_092", new Power {
				// TODO [KAR_092] Medivh's Valet && Test: Medivh's Valet_KAR_092
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [KAR_076] Firelands Portal - COST:7 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $5 damage. Summon a random
			//       5-Cost minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("KAR_076", new Power {
				// TODO [KAR_076] Firelands Portal && Test: Firelands Portal_KAR_076
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [KAR_010] Nightbane Templar - COST:3 [ATK:2/HP:3] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, summon two 1/1 Whelps.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_010", new Power {
				// TODO [KAR_010] Nightbane Templar && Test: Nightbane Templar_KAR_010
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [KAR_057] Ivory Knight - COST:6 [ATK:4/HP:4] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Discover</b> a spell.
			//       Restore Health to your hero
			//       equal to its Cost.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("KAR_057", new Power {
				// TODO [KAR_057] Ivory Knight && Test: Ivory Knight_KAR_057
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [KAR_077] Silvermoon Portal - COST:4 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2/+2. Summon a random
			//       2-Cost minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("KAR_077", new Power {
				// TODO [KAR_077] Silvermoon Portal && Test: Silvermoon Portal_KAR_077
				InfoCardId = "KAR_077e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [KAR_010a] Whelp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: dragon, Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_010a", new Power {
				// TODO [KAR_010a] Whelp && Test: Whelp_KAR_010a
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [KAR_035] Priest of the Feast - COST:4 [ATK:3/HP:6] 
			// - Fac: neutral, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, restore 3 Health to
			//       your hero.
			// --------------------------------------------------------
			cards.Add("KAR_035", new Power {
				// TODO [KAR_035] Priest of the Feast && Test: Priest of the Feast_KAR_035
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [KAR_204] Onyx Bishop - COST:5 [ATK:3/HP:4] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a friendly minion that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_204", new Power {
				// TODO [KAR_204] Onyx Bishop && Test: Onyx Bishop_KAR_204
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [KAR_013] Purify - COST:2 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Silence</b> a friendly minion. Draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("KAR_013", new Power {
				// TODO [KAR_013] Purify && Test: Purify_KAR_013
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [KAR_069] Swashburglar - COST:1 [ATK:1/HP:1] 
			// - Race: pirate, Fac: neutral, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random card to your hand <i>(from your opponent's class).</i>
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_069", new Power {
				// TODO [KAR_069] Swashburglar && Test: Swashburglar_KAR_069
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [KAR_070] Ethereal Peddler - COST:5 [ATK:5/HP:6] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding any cards from another class, reduce their Cost by (2).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_070", new Power {
				// TODO [KAR_070] Ethereal Peddler && Test: Ethereal Peddler_KAR_070
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [KAR_094] Deadly Fork - COST:3 [ATK:3/HP:2] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a 3/2 weapon to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("KAR_094", new Power {
				// TODO [KAR_094] Deadly Fork && Test: Deadly Fork_KAR_094
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- WEAPON - ROGUE
			// [KAR_094a] Sharp Fork (*) - COST:3 [ATK:3/HP:0] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("KAR_094a", new Power {
				// TODO [KAR_094a] Sharp Fork && Test: Sharp Fork_KAR_094a
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [KAR_021] Wicked Witchdoctor - COST:4 [ATK:3/HP:4] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a random basic_Totem.
			// --------------------------------------------------------
			cards.Add("KAR_021", new Power {
				// TODO [KAR_021] Wicked Witchdoctor && Test: Wicked Witchdoctor_KAR_021
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [KAR_073] Maelstrom Portal - COST:2 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal_$1_damage to_all_enemy_minions. Summon_a_random
			//       1-Cost minion. @spelldmg
			// --------------------------------------------------------
			cards.Add("KAR_073", new Power {
				// TODO [KAR_073] Maelstrom Portal && Test: Maelstrom Portal_KAR_073
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [KAR_063] Spirit Claws - COST:2 [ATK:1/HP:0] 
			// - Set: kara, Rarity: common
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
			cards.Add("KAR_063", new Power {
				// TODO [KAR_063] Spirit Claws && Test: Spirit Claws_KAR_063
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [KAR_089] Malchezaar's Imp - COST:1 [ATK:1/HP:3] 
			// - Race: demon, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you discard a card, draw a card.
			// --------------------------------------------------------
			cards.Add("KAR_089", new Power {
				// TODO [KAR_089] Malchezaar's Imp && Test: Malchezaar's Imp_KAR_089
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [KAR_205] Silverware Golem - COST:3 [ATK:3/HP:3] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: If you discard this minion, summon it.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("KAR_205", new Power {
				// TODO [KAR_205] Silverware Golem && Test: Silverware Golem_KAR_205
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [KAR_025] Kara Kazham! - COST:5 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Summon a 1/1 Candle, 2/2 Broom, and 3/3 Teapot.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KAR_025", new Power {
				// TODO [KAR_025] Kara Kazham! && Test: Kara Kazham!_KAR_025
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [KAR_025a] Candle (*) - COST:1 [ATK:1/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_025a", new Power {
				// TODO [KAR_025a] Candle && Test: Candle_KAR_025a
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [KAR_025b] Broom (*) - COST:2 [ATK:2/HP:2] 
			// - Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_025b", new Power {
				// TODO [KAR_025b] Broom && Test: Broom_KAR_025b
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [KAR_025c] Teapot (*) - COST:3 [ATK:3/HP:3] 
			// - Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_025c", new Power {
				// TODO [KAR_025c] Teapot && Test: Teapot_KAR_025c
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [KAR_026] Protect the King! - COST:3 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: For each enemy minion, summon a 1/1 Pawn with <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_026", new Power {
				// TODO [KAR_026] Protect the King! && Test: Protect the King!_KAR_026
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [KAR_091] Ironforge Portal - COST:5 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 4 Armor.
			//       Summon a random
			//       4-Cost minion.
			// --------------------------------------------------------
			cards.Add("KAR_091", new Power {
				// TODO [KAR_091] Ironforge Portal && Test: Ironforge Portal_KAR_091
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [KAR_028] Fool's Bane - COST:5 [ATK:3/HP:0] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Unlimited attacks each turn. Can't attack heroes.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			cards.Add("KAR_028", new Power {
				// TODO [KAR_028] Fool's Bane && Test: Fool's Bane_KAR_028
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [KAR_026t] Pawn (*) - COST:1 [ATK:1/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_026t", new Power {
				// TODO [KAR_026t] Pawn && Test: Pawn_KAR_026t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [KAR_011] Pompous Thespian - COST:2 [ATK:3/HP:2] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_011", new Power {
				// TODO [KAR_011] Pompous Thespian && Test: Pompous Thespian_KAR_011
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_029] Runic Egg - COST:1 [ATK:0/HP:2] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("KAR_029", new Power {
				// TODO [KAR_029] Runic Egg && Test: Runic Egg_KAR_029
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_030a] Pantry Spider - COST:3 [ATK:1/HP:3] 
			// - Race: beast, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a
			//       1/3 Spider.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_030a", new Power {
				// TODO [KAR_030a] Pantry Spider && Test: Pantry Spider_KAR_030a
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_033] Book Wyrm - COST:6 [ATK:3/HP:6] 
			// - Race: dragon, Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy an enemy minion with 3 or less Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NONSELF_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_MAX_ATTACK = 3
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// --------------------------------------------------------
			cards.Add("KAR_033", new Power {
				// TODO [KAR_033] Book Wyrm && Test: Book Wyrm_KAR_033
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_036] Arcane Anomaly - COST:1 [ATK:2/HP:1] 
			// - Race: elemental, Fac: neutral, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, give this minion
			//       +1 Health.
			// --------------------------------------------------------
			cards.Add("KAR_036", new Power {
				// TODO [KAR_036] Arcane Anomaly && Test: Arcane Anomaly_KAR_036
				InfoCardId = "KAR_036e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_037] Avian Watcher - COST:5 [ATK:3/HP:6] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, gain +1/+1
			//       and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("KAR_037", new Power {
				// TODO [KAR_037] Avian Watcher && Test: Avian Watcher_KAR_037
				InfoCardId = "KAR_037t",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_041] Moat Lurker - COST:6 [ATK:3/HP:3] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a minion. <b>Deathrattle:</b> Resummon it.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("KAR_041", new Power {
				// TODO [KAR_041] Moat Lurker && Test: Moat Lurker_KAR_041
				InfoCardId = "KAR_041e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_044] Moroes - COST:3 [ATK:1/HP:1] 
			// - Set: kara, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       At the end of your turn, summon a 1/1 Steward.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("KAR_044", new Power {
				// TODO [KAR_044] Moroes && Test: Moroes_KAR_044
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_061] The Curator - COST:7 [ATK:4/HP:6] 
			// - Race: mechanical, Set: kara, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Draw a Beast, Dragon, and Murloc from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_061", new Power {
				// TODO [KAR_061] The Curator && Test: The Curator_KAR_061
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_062] Netherspite Historian - COST:2 [ATK:1/HP:3] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, <b>Discover</b>
			//       a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("KAR_062", new Power {
				// TODO [KAR_062] Netherspite Historian && Test: Netherspite Historian_KAR_062
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_095] Zoobot - COST:3 [ATK:3/HP:3] 
			// - Race: mechanical, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_095", new Power {
				// TODO [KAR_095] Zoobot && Test: Zoobot_KAR_095
				InfoCardId = "KAR_095e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_096] Prince Malchezaar - COST:5 [ATK:5/HP:6] 
			// - Race: demon, Set: kara, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Start of Game:</b>
			//       Add 5 extra <b>Legendary</b>
			//       minions to your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - START_OF_GAME = 1
			// --------------------------------------------------------
			cards.Add("KAR_096", new Power {
				// TODO [KAR_096] Prince Malchezaar && Test: Prince Malchezaar_KAR_096
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_097] Medivh, the Guardian - COST:8 [ATK:7/HP:7] 
			// - Set: kara, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip Atiesh, Greatstaff of the Guardian.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_097", new Power {
				// TODO [KAR_097] Medivh, the Guardian && Test: Medivh, the Guardian_KAR_097
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_114] Barnes - COST:4 [ATK:3/HP:4] 
			// - Set: kara, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 1/1 copy of a random minion in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_114", new Power {
				// TODO [KAR_114] Barnes && Test: Barnes_KAR_114
				InfoCardId = "KAR_114e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_702] Menagerie Magician - COST:5 [ATK:4/HP:4] 
			// - Fac: neutral, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_702", new Power {
				// TODO [KAR_702] Menagerie Magician && Test: Menagerie Magician_KAR_702
				InfoCardId = "KAR_702e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_710] Arcanosmith - COST:4 [ATK:3/HP:2] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 0/5 minion with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_710", new Power {
				// TODO [KAR_710] Arcanosmith && Test: Arcanosmith_KAR_710
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_711] Arcane Giant - COST:12 [ATK:8/HP:8] 
			// - Set: kara, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Costs (1) less for each spell
			//       you've cast this game.
			// --------------------------------------------------------
			cards.Add("KAR_711", new Power {
				// TODO [KAR_711] Arcane Giant && Test: Arcane Giant_KAR_711
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_712] Violet Illusionist - COST:3 [ATK:4/HP:3] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: During your turn, your hero is <b>Immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("KAR_712", new Power {
				// TODO [KAR_712] Violet Illusionist && Test: Violet Illusionist_KAR_712
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_036e] Eating (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("KAR_036e", new Power {
				// TODO [KAR_036e] Eating && Test: Eating_KAR_036e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_037t] Secrets of Karazhan (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("KAR_037t", new Power {
				// TODO [KAR_037t] Secrets of Karazhan && Test: Secrets of Karazhan_KAR_037t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_041e] Moat Lurker (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Destroyed {0}.
			// --------------------------------------------------------
			cards.Add("KAR_041e", new Power {
				// TODO [KAR_041e] Moat Lurker && Test: Moat Lurker_KAR_041e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_077e] Silver Might (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("KAR_077e", new Power {
				// TODO [KAR_077e] Silver Might && Test: Silver Might_KAR_077e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_095e] Well Fed (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("KAR_095e", new Power {
				// TODO [KAR_095e] Well Fed && Test: Well Fed_KAR_095e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_114e] Incredible Impression (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Attack and Health set to 1.
			// --------------------------------------------------------
			cards.Add("KAR_114e", new Power {
				// TODO [KAR_114e] Incredible Impression && Test: Incredible Impression_KAR_114e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_702e] A Simple Trick (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("KAR_702e", new Power {
				// TODO [KAR_702e] A Simple Trick && Test: A Simple Trick_KAR_702e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A01_02e] Reflection (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("KAR_A01_02e", new Power {
				// TODO [KAR_A01_02e] Reflection && Test: Reflection_KAR_A01_02e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_06e2] Filled Up (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("KAR_A02_06e2", new Power {
				// TODO [KAR_A02_06e2] Filled Up && Test: Filled Up_KAR_A02_06e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_06He] Filled Up (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("KAR_A02_06He", new Power {
				// TODO [KAR_A02_06He] Filled Up && Test: Filled Up_KAR_A02_06He
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_09e] Table Set (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("KAR_A02_09e", new Power {
				// TODO [KAR_A02_09e] Table Set && Test: Table Set_KAR_A02_09e
				InfoCardId = "KAR_A02_09eH",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_09eH] Table Set (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("KAR_A02_09eH", new Power {
				// TODO [KAR_A02_09eH] Table Set && Test: Table Set_KAR_A02_09eH
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_030] Cellar Spider (*) - COST:3 [ATK:1/HP:3] 
			// - Race: beast, Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_030", new Power {
				// TODO [KAR_030] Cellar Spider && Test: Cellar Spider_KAR_030
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_044a] Steward (*) - COST:1 [ATK:1/HP:1] 
			// - Fac: neutral, Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_044a", new Power {
				// TODO [KAR_044a] Steward && Test: Steward_KAR_044a
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_710m] Animated Shield (*) - COST:2 [ATK:0/HP:5] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_710m", new Power {
				// TODO [KAR_710m] Animated Shield && Test: Animated Shield_KAR_710m
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_01] Plate (*) - COST:1 [ATK:1/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_A02_01", new Power {
				// TODO [KAR_A02_01] Plate && Test: Plate_KAR_A02_01
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_01H] Plate (*) - COST:1 [ATK:2/HP:2] 
			// - Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_A02_01H", new Power {
				// TODO [KAR_A02_01H] Plate && Test: Plate_KAR_A02_01H
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_03] Fork (*) - COST:3 [ATK:3/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Plates have <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_03", new Power {
				// TODO [KAR_A02_03] Fork && Test: Fork_KAR_A02_03
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_03H] Fork (*) - COST:2 [ATK:3/HP:3] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Plates have <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_03H", new Power {
				// TODO [KAR_A02_03H] Fork && Test: Fork_KAR_A02_03H
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_04] Knife (*) - COST:3 [ATK:5/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Plates have <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_04", new Power {
				// TODO [KAR_A02_04] Knife && Test: Knife_KAR_A02_04
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_04H] Knife (*) - COST:3 [ATK:5/HP:5] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Plates have <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_04H", new Power {
				// TODO [KAR_A02_04H] Knife && Test: Knife_KAR_A02_04H
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_05] Cup (*) - COST:2 [ATK:2/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Plates have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_05", new Power {
				// TODO [KAR_A02_05] Cup && Test: Cup_KAR_A02_05
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_05H] Cup (*) - COST:2 [ATK:2/HP:2] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Plates have +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_05H", new Power {
				// TODO [KAR_A02_05H] Cup && Test: Cup_KAR_A02_05H
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_06] Pitcher (*) - COST:4 [ATK:3/HP:3] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a minion +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("KAR_A02_06", new Power {
				// TODO [KAR_A02_06] Pitcher && Test: Pitcher_KAR_A02_06
				InfoCardId = "KAR_A02_06e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_06H] Pitcher (*) - COST:4 [ATK:5/HP:5] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a minion +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("KAR_A02_06H", new Power {
				// TODO [KAR_A02_06H] Pitcher && Test: Pitcher_KAR_A02_06H
				InfoCardId = "KAR_A02_06He",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_01] Black Pawn (*) - COST:1 [ATK:1/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 1 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_01", new Power {
				// TODO [KAR_A10_01] Black Pawn && Test: Black Pawn_KAR_A10_01
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_02] White Pawn (*) - COST:1 [ATK:1/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 1 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_02", new Power {
				// TODO [KAR_A10_02] White Pawn && Test: White Pawn_KAR_A10_02
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_03] Black Rook (*) - COST:3 [ATK:2/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 2 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_03", new Power {
				// TODO [KAR_A10_03] Black Rook && Test: Black Rook_KAR_A10_03
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_04] White Rook (*) - COST:3 [ATK:2/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 2 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_04", new Power {
				// TODO [KAR_A10_04] White Rook && Test: White Rook_KAR_A10_04
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_05] White Bishop (*) - COST:3 [ATK:0/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Restore 2 Health to adjacent minions.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_05", new Power {
				// TODO [KAR_A10_05] White Bishop && Test: White Bishop_KAR_A10_05
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_06] Black Bishop (*) - COST:3 [ATK:0/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Restore 2 Health to adjacent minions.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_06", new Power {
				// TODO [KAR_A10_06] Black Bishop && Test: Black Bishop_KAR_A10_06
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_07] Black Knight (*) - COST:4 [ATK:4/HP:3] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>.
			//       Can't Attack Heroes.
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_07", new Power {
				// TODO [KAR_A10_07] Black Knight && Test: Black Knight_KAR_A10_07
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_08] White Knight (*) - COST:4 [ATK:4/HP:3] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>.
			//       Can't Attack Heroes.
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_08", new Power {
				// TODO [KAR_A10_08] White Knight && Test: White Knight_KAR_A10_08
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_09] White Queen (*) - COST:7 [ATK:4/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 4 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_09", new Power {
				// TODO [KAR_A10_09] White Queen && Test: White Queen_KAR_A10_09
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_10] Black Queen (*) - COST:7 [ATK:4/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 4 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_10", new Power {
				// TODO [KAR_A10_10] Black Queen && Test: Black Queen_KAR_A10_10
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_09] Set the Table (*) - COST:4 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Give your Plates +1/+1.
			// --------------------------------------------------------
			cards.Add("KAR_A02_09", new Power {
				// TODO [KAR_A02_09] Set the Table && Test: Set the Table_KAR_A02_09
				InfoCardId = "KAR_A02_09e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_09H] Set the Table (*) - COST:4 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Give your Plates +2/+2.
			// --------------------------------------------------------
			cards.Add("KAR_A02_09H", new Power {
				// TODO [KAR_A02_09H] Set the Table && Test: Set the Table_KAR_A02_09H
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_10] Pour a Round (*) - COST:3 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Draw a card for each of your Plates.
			// --------------------------------------------------------
			cards.Add("KAR_A02_10", new Power {
				// TODO [KAR_A02_10] Pour a Round && Test: Pour a Round_KAR_A02_10
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_11] Tossing Plates (*) - COST:5 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon five 1/1 Plates.
			// --------------------------------------------------------
			cards.Add("KAR_A02_11", new Power {
				// TODO [KAR_A02_11] Tossing Plates && Test: Tossing Plates_KAR_A02_11
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [KAR_097t] Atiesh (*) - COST:3 [ATK:1/HP:0] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: [x]After you cast a spell,
			//       summon a random
			//       minion of that Cost.
			//       Lose 1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("KAR_097t", new Power {
				// TODO [KAR_097t] Atiesh && Test: Atiesh_KAR_097t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [KAR_A02_02] Spoon (*) - COST:1 [ATK:1/HP:0] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("KAR_A02_02", new Power {
				// TODO [KAR_A02_02] Spoon && Test: Spoon_KAR_A02_02
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [KAR_A02_02H] Spoon (*) - COST:1 [ATK:3/HP:0] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("KAR_A02_02H", new Power {
				// TODO [KAR_A02_02H] Spoon && Test: Spoon_KAR_A02_02H
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			Druid(cards);
			Hunter(cards);
			HunterNonCollect(cards);
			Mage(cards);
			Paladin(cards);
			PaladinNonCollect(cards);
			Priest(cards);
			Rogue(cards);
			RogueNonCollect(cards);
			Shaman(cards);
			Warlock(cards);
			WarlockNonCollect(cards);
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
