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
	public class DalaranCardsGen
	{
		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [DAL_354] Acornbearer - COST:1 [ATK:2/HP:1] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add two 1/1 Squirrels to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_354", new Power {
				// TODO [DAL_354] Acornbearer && Test: Acornbearer_DAL_354
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [DAL_355] Lifeweaver - COST:3 [ATK:2/HP:5] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you restore Health, add a random Druid spell to your hand.
			// --------------------------------------------------------
			cards.Add("DAL_355", new Power {
				// TODO [DAL_355] Lifeweaver && Test: Lifeweaver_DAL_355
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [DAL_357] Lucentbark - COST:8 [ATK:4/HP:8] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Go dormant. Restore 5 Health to awaken this minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_357", new Power {
				// TODO [DAL_357] Lucentbark && Test: Lucentbark_DAL_357
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [DAL_732] Keeper Stalladris - COST:2 [ATK:2/HP:3] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you cast a <b>Choose One</b> spell, add copies of both choices_to_your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DAL_732", new Power {
				// TODO [DAL_732] Keeper Stalladris && Test: Keeper Stalladris_DAL_732
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [DAL_799] Crystal Stag - COST:5 [ATK:4/HP:4] 
			// - Race: beast, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Rush</b>. <b>Battlecry:</b> If you've restored 5 Health this game, summon a copy of this.@ <i>({0} left!)</i>@ <i>(Ready!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// - PLAYER_TAG_THRESHOLD_TAG_ID = 958
			// - PLAYER_TAG_THRESHOLD_VALUE = 5
			// --------------------------------------------------------
			cards.Add("DAL_799", new Power {
				// TODO [DAL_799] Crystal Stag && Test: Crystal Stag_DAL_799
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [DAL_256] The Forest's Aid - COST:8 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Summon five 2/2 Treants.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 52821
			// - TWINSPELL = 1
			// --------------------------------------------------------
			cards.Add("DAL_256", new Power {
				// TODO [DAL_256] The Forest's Aid && Test: The Forest's Aid_DAL_256
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [DAL_350] Crystal Power - COST:1 
			// - Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Deal $2 damage to a minion; or_Restore #5 Health. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_350", new Power {
				// TODO [DAL_350] Crystal Power && Test: Crystal Power_DAL_350
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [DAL_351] Blessing of the Ancients - COST:3 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Give your minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54128
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_351", new Power {
				// TODO [DAL_351] Blessing of the Ancients && Test: Blessing of the Ancients_DAL_351
				InfoCardId = "DAL_351e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [DAL_352] Crystalsong Portal - COST:2 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a Druid minion. If your hand has no minions, keep all 3.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_352", new Power {
				// TODO [DAL_352] Crystalsong Portal && Test: Crystalsong Portal_DAL_352
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [DAL_733] Dreamway Guardians - COST:2 
			// - Fac: neutral, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon two 1/2 Dryads with <b>Lifesteal</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("DAL_733", new Power {
				// TODO [DAL_733] Dreamway Guardians && Test: Dreamway Guardians_DAL_733
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [DAL_256t2] Treant (*) - COST:2 [ATK:2/HP:2] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			cards.Add("DAL_256t2", new Power {
				// TODO [DAL_256t2] Treant && Test: Treant_DAL_256t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [DAL_354t] Squirrel (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: dalaran, 
			// --------------------------------------------------------
			cards.Add("DAL_354t", new Power {
				// TODO [DAL_354t] Squirrel && Test: Squirrel_DAL_354t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [DAL_357t] Spirit of Lucentbark (*) - COST:11 [ATK:0/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: When you restore 5 Health, awaken this minion.
			//       <i>(@ left!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 5
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 5
			// --------------------------------------------------------
			cards.Add("DAL_357t", new Power {
				// TODO [DAL_357t] Spirit of Lucentbark && Test: Spirit of Lucentbark_DAL_357t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [DAL_733t] Crystal Dryad (*) - COST:1 [ATK:1/HP:2] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("DAL_733t", new Power {
				// TODO [DAL_733t] Crystal Dryad && Test: Crystal Dryad_DAL_733t
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [DAL_256ts] The Forest's Aid (*) - COST:8 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon five 2/2 Treants.
			// --------------------------------------------------------
			cards.Add("DAL_256ts", new Power {
				// TODO [DAL_256ts] The Forest's Aid && Test: The Forest's Aid_DAL_256ts
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [DAL_350a] Piercing Thorns (*) - COST:1 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_350a", new Power {
				// TODO [DAL_350a] Piercing Thorns && Test: Piercing Thorns_DAL_350a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [DAL_350b] Healing Blossom (*) - COST:1 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: Restore #5 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_350b", new Power {
				// TODO [DAL_350b] Healing Blossom && Test: Healing Blossom_DAL_350b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [DAL_351ts] Blessing of the Ancients (*) - COST:3 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions +1/+1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_351ts", new Power {
				// TODO [DAL_351ts] Blessing of the Ancients && Test: Blessing of the Ancients_DAL_351ts
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [DAL_372] Arcane Fletcher - COST:4 [ATK:3/HP:3] 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Whenever you play a
			//       1-Cost minion, draw a
			//       spell from your deck.
			// --------------------------------------------------------
			cards.Add("DAL_372", new Power {
				// TODO [DAL_372] Arcane Fletcher && Test: Arcane Fletcher_DAL_372
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [DAL_376] Oblivitron - COST:6 [ATK:3/HP:4] 
			// - Race: mechanical, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Summon a
			//       Mech from your hand and
			//       trigger its <b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_376", new Power {
				// TODO [DAL_376] Oblivitron && Test: Oblivitron_DAL_376
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [DAL_379] Vereesa Windrunner - COST:7 [ATK:5/HP:6] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip Thori'dal, the Stars' Fury.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_379", new Power {
				// TODO [DAL_379] Vereesa Windrunner && Test: Vereesa Windrunner_DAL_379
				InfoCardId = "DAL_379e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [DAL_587] Shimmerfly - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Hunter spell to your hand.
			// --------------------------------------------------------
			// Entourage: NEW1_032, NEW1_033, NEW1_034
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_587", new Power {
				// TODO [DAL_587] Shimmerfly && Test: Shimmerfly_DAL_587
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [DAL_604] Ursatron - COST:3 [ATK:3/HP:3] 
			// - Race: mechanical, Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a Mech from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_604", new Power {
				// TODO [DAL_604] Ursatron && Test: Ursatron_DAL_604
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_371] Marked Shot - COST:4 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage to_a_minion. <b>Discover</b>_a_spell. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_371", new Power {
				// TODO [DAL_371] Marked Shot && Test: Marked Shot_DAL_371
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_373] Rapid Fire - COST:1 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Deal $1 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54143
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_373", new Power {
				// TODO [DAL_373] Rapid Fire && Test: Rapid Fire_DAL_373
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_377] Nine Lives - COST:3 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a friendly <b>Deathrattle</b> minion that died this game. Also trigger its <b>Deathrattle</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_DEATHRATTLE_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_377", new Power {
				// TODO [DAL_377] Nine Lives && Test: Nine Lives_DAL_377
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_378] Unleash the Beast - COST:6 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Summon a 5/5 Wyvern with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54145
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_378", new Power {
				// TODO [DAL_378] Unleash the Beast && Test: Unleash the Beast_DAL_378
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_589] Hunting Party - COST:5 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Copy all Beasts in your_hand.
			// --------------------------------------------------------
			cards.Add("DAL_589", new Power {
				// TODO [DAL_589] Hunting Party && Test: Hunting Party_DAL_589
				InfoCardId = "DAL_589e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [DAL_379e] Stars' Fury (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: You have <b>Spell Damage +2</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("DAL_379e", new Power {
				// TODO [DAL_379e] Stars' Fury && Test: Stars' Fury_DAL_379e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [DAL_378t1] Wyvern (*) - COST:5 [ATK:5/HP:5] 
			// - Race: beast, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_378t1", new Power {
				// TODO [DAL_378t1] Wyvern && Test: Wyvern_DAL_378t1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_373ts] Rapid Fire (*) - COST:1 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_373ts", new Power {
				// TODO [DAL_373ts] Rapid Fire && Test: Rapid Fire_DAL_373ts
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_378ts] Unleash the Beast (*) - COST:6 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 5/5 Wyvern with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_ATTACK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_378ts", new Power {
				// TODO [DAL_378ts] Unleash the Beast && Test: Unleash the Beast_DAL_378ts
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - HUNTER
			// [DAL_379t] Thori'dal, the Stars' Fury (*) - COST:3 [ATK:2/HP:0] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After your hero attacks, gain <b>Spell Damage +2</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_379t", new Power {
				// TODO [DAL_379t] Thori'dal, the Stars' Fury && Test: Thori'dal, the Stars' Fury_DAL_379t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [DAL_163] Messenger Raven - COST:3 [ATK:3/HP:2] 
			// - Race: beast, Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a
			//       Mage minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_163", new Power {
				// TODO [DAL_163] Messenger Raven && Test: Messenger Raven_DAL_163
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [DAL_182] Magic Dart Frog - COST:2 [ATK:1/HP:3] 
			// - Race: beast, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: After you cast a spell, deal 1 damage to a random enemy minion.
			// --------------------------------------------------------
			cards.Add("DAL_182", new Power {
				// TODO [DAL_182] Magic Dart Frog && Test: Magic Dart Frog_DAL_182
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [DAL_575] Khadgar - COST:2 [ATK:2/HP:2] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your cards that summon minions summon twice_as_many.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DAL_575", new Power {
				// TODO [DAL_575] Khadgar && Test: Khadgar_DAL_575
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [DAL_576] Kirin Tor Tricaster - COST:4 [ATK:3/HP:3] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Spell Damage +3</b>
			//       Your spells cost (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 3
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("DAL_576", new Power {
				// TODO [DAL_576] Kirin Tor Tricaster && Test: Kirin Tor Tricaster_DAL_576
				InfoCardId = "DAL_576e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [DAL_603] Mana Cyclone - COST:2 [ATK:2/HP:2] 
			// - Race: elemental, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> For each spell
			//       you've cast this turn, add
			//       a random Mage spell
			//       to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_603", new Power {
				// TODO [DAL_603] Mana Cyclone && Test: Mana Cyclone_DAL_603
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [DAL_609] Kalecgos - COST:10 [ATK:4/HP:12] 
			// - Race: dragon, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your first spell each
			//       turn costs (0).
			//       <b>Battlecry:</b> <b>Discover</b>
			//       a spell.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - AURA = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_609", new Power {
				// TODO [DAL_609] Kalecgos && Test: Kalecgos_DAL_609
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [DAL_177] Conjurer's Calling - COST:3 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Destroy a minion. Summon 2 minions of the same Cost to replace it.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 52637
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_177", new Power {
				// TODO [DAL_177] Conjurer's Calling && Test: Conjurer's Calling_DAL_177
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [DAL_577] Ray of Frost - COST:1 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       <b>Freeze</b> a minion.
			//       If it's already <b>Frozen</b>,
			//       deal $2 damage to it. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54193
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("DAL_577", new Power {
				// TODO [DAL_577] Ray of Frost && Test: Ray of Frost_DAL_577
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [DAL_578] Power of Creation - COST:8 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a 6-Cost minion. Summon two copies of it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_578", new Power {
				// TODO [DAL_578] Power of Creation && Test: Power of Creation_DAL_578
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [DAL_608] Magic Trick - COST:1 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Discover</b> a spell that costs (3) or less.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_608", new Power {
				// TODO [DAL_608] Magic Trick && Test: Magic Trick_DAL_608
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [DAL_177ts] Conjurer's Calling (*) - COST:3 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a minion. Summon 2 minions of the same Cost to replace it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_177ts", new Power {
				// TODO [DAL_177ts] Conjurer's Calling && Test: Conjurer's Calling_DAL_177ts
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [DAL_577ts] Ray of Frost (*) - COST:1 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion.
			//       If it's already <b>Frozen</b>,
			//       deal $2 damage to it. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("DAL_577ts", new Power {
				// TODO [DAL_577ts] Ray of Frost && Test: Ray of Frost_DAL_577ts
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [DAL_146] Bronze Herald - COST:3 [ATK:3/HP:2] 
			// - Race: dragon, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add two 4/4 Dragons to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_146", new Power {
				// TODO [DAL_146] Bronze Herald && Test: Bronze Herald_DAL_146
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [DAL_147] Dragon Speaker - COST:5 [ATK:3/HP:5] 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all Dragons in your hand +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_147", new Power {
				// TODO [DAL_147] Dragon Speaker && Test: Dragon Speaker_DAL_147
				InfoCardId = "DAL_147e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [DAL_573] Commander Rhyssa - COST:3 [ATK:4/HP:3] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your <b>Secrets</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_573", new Power {
				// TODO [DAL_573] Commander Rhyssa && Test: Commander Rhyssa_DAL_573
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [DAL_581] Nozari - COST:10 [ATK:4/HP:12] 
			// - Race: dragon, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore both heroes to full Health.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("DAL_581", new Power {
				// TODO [DAL_581] Nozari && Test: Nozari_DAL_581
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_141] Desperate Measures - COST:1 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Cast a random Paladin <b>Secret</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54129
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_141", new Power {
				// TODO [DAL_141] Desperate Measures && Test: Desperate Measures_DAL_141
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_568] Lightforged Blessing - COST:2 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Give a friendly minion <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54189
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("DAL_568", new Power {
				// TODO [DAL_568] Lightforged Blessing && Test: Lightforged Blessing_DAL_568
				InfoCardId = "DAL_568e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_570] Never Surrender! - COST:1 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent casts a spell, give your minions +2_Health.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_570", new Power {
				// TODO [DAL_570] Never Surrender! && Test: Never Surrender!_DAL_570
				InfoCardId = "DAL_570e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_727] Call to Adventure - COST:3 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw the lowest Cost minion from your deck. Give it +2/+2.
			// --------------------------------------------------------
			cards.Add("DAL_727", new Power {
				// TODO [DAL_727] Call to Adventure && Test: Call to Adventure_DAL_727
				InfoCardId = "DAL_727e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_731] Duel! - COST:5 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon a minion from each player's deck.
			//       They fight!
			// --------------------------------------------------------
			cards.Add("DAL_731", new Power {
				// TODO [DAL_731] Duel! && Test: Duel!_DAL_731
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [DAL_571] Mysterious Blade - COST:2 [ATK:2/HP:0] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a
			//       <b>Secret</b>, gain +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_571", new Power {
				// TODO [DAL_571] Mysterious Blade && Test: Mysterious Blade_DAL_571
				InfoCardId = "DAL_571e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [DAL_568e] Lightforged Blessing (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			cards.Add("DAL_568e", new Power {
				// TODO [DAL_568e] Lightforged Blessing && Test: Lightforged Blessing_DAL_568e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [DAL_571e] Mysterious (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("DAL_571e", new Power {
				// TODO [DAL_571e] Mysterious && Test: Mysterious_DAL_571e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [DAL_146t] Bronze Dragon (*) - COST:4 [ATK:4/HP:4] 
			// - Race: dragon, Set: dalaran, 
			// --------------------------------------------------------
			cards.Add("DAL_146t", null);

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_141ts] Desperate Measures (*) - COST:1 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Cast a random Paladin <b>Secret</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_141ts", new Power {
				// TODO [DAL_141ts] Desperate Measures && Test: Desperate Measures_DAL_141ts
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_568ts] Lightforged Blessing (*) - COST:2 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Give a friendly minion <b>Lifesteal</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("DAL_568ts", new Power {
				// TODO [DAL_568ts] Lightforged Blessing && Test: Lightforged Blessing_DAL_568ts
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [DAL_030] Shadowy Figure - COST:2 [ATK:2/HP:2] 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform into a_2/2 copy of a friendly <b>Deathrattle</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_030", new Power {
				// TODO [DAL_030] Shadowy Figure && Test: Shadowy Figure_DAL_030
				InfoCardId = "DAL_030e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [DAL_039] Convincing Infiltrator - COST:5 [ATK:2/HP:6] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b><b>Taunt</b></b>
			//       <b>Deathrattle:</b> Destroy a
			//        random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_039", new Power {
				// TODO [DAL_039] Convincing Infiltrator && Test: Convincing Infiltrator_DAL_039
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [DAL_040] Hench-Clan Shadequill - COST:4 [ATK:4/HP:7] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Restore 5 Health to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("DAL_040", new Power {
				// TODO [DAL_040] Hench-Clan Shadequill && Test: Hench-Clan Shadequill_DAL_040
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [DAL_413] EVIL Conscripter - COST:2 [ATK:2/HP:2] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a <b>Lackey</b> to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_413", new Power {
				// TODO [DAL_413] EVIL Conscripter && Test: EVIL Conscripter_DAL_413
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [DAL_721] Catrina Muerte - COST:8 [ATK:6/HP:8] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]At the end of your turn,
			//       summon a friendly minion
			//       that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DAL_721", new Power {
				// TODO [DAL_721] Catrina Muerte && Test: Catrina Muerte_DAL_721
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [DAL_729] Madame Lazul - COST:3 [ATK:3/HP:2] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Discover</b> a
			//       copy of a card in your
			//       opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_729", new Power {
				// TODO [DAL_729] Madame Lazul && Test: Madame Lazul_DAL_729
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [DAL_011] Lazul's Scheme - COST:0 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Reduce the Attack of an enemy minion by
			//       @ until your next turn. <i>(Upgrades each turn!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_011", new Power {
				// TODO [DAL_011] Lazul's Scheme && Test: Lazul's Scheme_DAL_011
				InfoCardId = "DAL_011e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [DAL_065] Unsleeping Soul - COST:4 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Silence</b> a friendly minion, then summon a copy of it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("DAL_065", new Power {
				// TODO [DAL_065] Unsleeping Soul && Test: Unsleeping Soul_DAL_065
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [DAL_723] Forbidden Words - COST:0 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Spend all your Mana.
			//       Destroy a minion with that
			//       much Attack or less.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - 85 = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_723", new Power {
				// TODO [DAL_723] Forbidden Words && Test: Forbidden Words_DAL_723
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [DAL_724] Mass Resurrection - COST:9 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 3 friendly minions that died
			//       this game.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			cards.Add("DAL_724", new Power {
				// TODO [DAL_724] Mass Resurrection && Test: Mass Resurrection_DAL_724
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [DAL_030e] Shade (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: 2/2.
			// --------------------------------------------------------
			cards.Add("DAL_030e", new Power {
				// TODO [DAL_030e] Shade && Test: Shade_DAL_030e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [DAL_415] EVIL Miscreant - COST:3 [ATK:1/HP:5] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Add two random <b>Lackeys</b> to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_415", new Power {
				// TODO [DAL_415] EVIL Miscreant && Test: EVIL Miscreant_DAL_415
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [DAL_416] Hench-Clan Burglar - COST:4 [ATK:4/HP:3] 
			// - Race: pirate, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a spell from another class.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_416", new Power {
				// TODO [DAL_416] Hench-Clan Burglar && Test: Hench-Clan Burglar_DAL_416
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [DAL_417] Heistbaron Togwaggle - COST:6 [ATK:5/HP:5] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a_<b>Lackey</b>, choose a fantastic treasure.
			// --------------------------------------------------------
			// Entourage: LOOT_998h, LOOT_998j, LOOT_998l, LOOT_998k
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - MULTIPLY_BUFF_VALUE = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_417", new Power {
				// TODO [DAL_417] Heistbaron Togwaggle && Test: Heistbaron Togwaggle_DAL_417
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [DAL_714] Underbelly Fence - COST:2 [ATK:2/HP:3] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you're holding
			//       a card from another class,
			//       _gain +1/+1 and <b><b>Rush</b>.</b>
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_714", new Power {
				// TODO [DAL_714] Underbelly Fence && Test: Underbelly Fence_DAL_714
				InfoCardId = "DAL_714e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [DAL_719] Tak Nozwhisker - COST:7 [ATK:6/HP:6] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Whenever you shuffle a
			//       card into your deck, add
			//       a copy to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DAL_719", new Power {
				// TODO [DAL_719] Tak Nozwhisker && Test: Tak Nozwhisker_DAL_719
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_010] Togwaggle's Scheme - COST:1 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Choose a minion. Shuffle @ |4(copy, copies) of it into your deck.
			//       <i>(Upgrades each turn!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_010", new Power {
				// TODO [DAL_010] Togwaggle's Scheme && Test: Togwaggle's Scheme_DAL_010
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_366] Unidentified Contract - COST:6 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. Gains a bonus effect in_your hand.
			// --------------------------------------------------------
			// Entourage: DAL_366t1, DAL_366t2, DAL_366t3, DAL_366t4
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_366", new Power {
				// TODO [DAL_366] Unidentified Contract && Test: Unidentified Contract_DAL_366
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_716] Vendetta - COST:4 
			// - Fac: neutral, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $4 damage to a minion. Costs (0) if you're holding a card from another class. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_716", new Power {
				// TODO [DAL_716] Vendetta && Test: Vendetta_DAL_716
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_728] Daring Escape - COST:1 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Return all friendly minions to your hand.
			// --------------------------------------------------------
			cards.Add("DAL_728", new Power {
				// TODO [DAL_728] Daring Escape && Test: Daring Escape_DAL_728
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [DAL_720] Waggle Pick - COST:4 [ATK:4/HP:0] 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Return
			//       a random friendly
			//       minion to your hand.
			//       It costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_720", new Power {
				// TODO [DAL_720] Waggle Pick && Test: Waggle Pick_DAL_720
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [DAL_366t1] Assassin's Contract (*) - COST:6 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. Summon a 1/1 Patient Assassin.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_366t1", new Power {
				// TODO [DAL_366t1] Assassin's Contract && Test: Assassin's Contract_DAL_366t1
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_366t2] Recruitment Contract (*) - COST:6 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. Add_a copy of it to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_366t2", new Power {
				// TODO [DAL_366t2] Recruitment Contract && Test: Recruitment Contract_DAL_366t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_366t3] Lucrative Contract (*) - COST:6 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. Add 2 Coins to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_366t3", new Power {
				// TODO [DAL_366t3] Lucrative Contract && Test: Lucrative Contract_DAL_366t3
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_366t4] Turncoat Contract (*) - COST:6 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. It_deals its damage to adjacent minions.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_366t4", new Power {
				// TODO [DAL_366t4] Turncoat Contract && Test: Turncoat Contract_DAL_366t4
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [DAL_047] Walking Fountain - COST:8 [ATK:4/HP:8] 
			// - Race: elemental, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>, <b>Rush</b>, <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// - LIFESTEAL = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_047", new Power {
				// TODO [DAL_047] Walking Fountain && Test: Walking Fountain_DAL_047
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_049] Underbelly Angler - COST:2 [ATK:2/HP:3] 
			// - Race: murloc, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: After you play a Murloc, add a random Murloc to your hand.
			// --------------------------------------------------------
			cards.Add("DAL_049", new Power {
				// TODO [DAL_049] Underbelly Angler && Test: Underbelly Angler_DAL_049
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_052] Muckmorpher - COST:5 [ATK:4/HP:4] 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Transform into
			//       a 4/4 copy of a different
			//       minion in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_052", new Power {
				// TODO [DAL_052] Muckmorpher && Test: Muckmorpher_DAL_052
				InfoCardId = "DAL_052e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_431] Swampqueen Hagatha - COST:7 [ATK:5/HP:5] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Add a 5/5
			//       Horror to your hand. Teach
			//       it two Shaman spells.
			// --------------------------------------------------------
			// Entourage: DAL_431t
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_431", new Power {
				// TODO [DAL_431] Swampqueen Hagatha && Test: Swampqueen Hagatha_DAL_431
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_433] Sludge Slurper - COST:1 [ATK:2/HP:1] 
			// - Race: murloc, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a <b>Lackey</b> to your hand. <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_433", new Power {
				// TODO [DAL_433] Sludge Slurper && Test: Sludge Slurper_DAL_433
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_726] Scargil - COST:4 [ATK:4/HP:4] 
			// - Race: murloc, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your Murlocs cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("DAL_726", new Power {
				// TODO [DAL_726] Scargil && Test: Scargil_DAL_726
				InfoCardId = "DAL_726e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [DAL_009] Hagatha's Scheme - COST:5 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $@ damage
			//       to all minions.
			//       <i>(Upgrades each turn!)</i> @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			cards.Add("DAL_009", new Power {
				// TODO [DAL_009] Hagatha's Scheme && Test: Hagatha's Scheme_DAL_009
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [DAL_071] Mutate - COST:0 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Transform a friendly minion into a random one that costs (1) more.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_071", new Power {
				// TODO [DAL_071] Mutate && Test: Mutate_DAL_071
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [DAL_432] Witch's Brew - COST:2 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Restore #4 Health. Repeatable this turn.
			// --------------------------------------------------------
			// GameTag:
			// - NON_KEYWORD_ECHO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_432", new Power {
				// TODO [DAL_432] Witch's Brew && Test: Witch's Brew_DAL_432
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [DAL_710] Soul of the Murloc - COST:2 
			// - Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions "<b>Deathrattle:</b> Summon a 1/1 Murloc."
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_710", new Power {
				// TODO [DAL_710] Soul of the Murloc && Test: Soul of the Murloc_DAL_710
				InfoCardId = "DAL_710e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [DAL_710e] Soul of the Murloc (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 1/1 Murloc.
			// --------------------------------------------------------
			cards.Add("DAL_710e", new Power {
				// TODO [DAL_710e] Soul of the Murloc && Test: Soul of the Murloc_DAL_710e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_431t] Drustvar Horror (*) - COST:5 [ATK:5/HP:5] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Cast {0} and {1}.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_431t", new Power {
				// TODO [DAL_431t] Drustvar Horror && Test: Drustvar Horror_DAL_431t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [DAL_185] Aranasi Broodmother - COST:6 [ATK:4/HP:6] 
			// - Race: demon, Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       When you draw this, restore
			//       4 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("DAL_185", new Power {
				// TODO [DAL_185] Aranasi Broodmother && Test: Aranasi Broodmother_DAL_185
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [DAL_422] Arch-Villain Rafaam - COST:7 [ATK:7/HP:8] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b><b>Taunt</b>
			//       Battlecry:</b> Replace your hand and deck with <b>Legendary</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_422", new Power {
				// TODO [DAL_422] Arch-Villain Rafaam && Test: Arch-Villain Rafaam_DAL_422
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [DAL_561] Jumbo Imp - COST:10 [ATK:8/HP:8] 
			// - Race: demon, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less whenever a friendly Demon dies while this is in your hand.
			// --------------------------------------------------------
			cards.Add("DAL_561", new Power {
				// TODO [DAL_561] Jumbo Imp && Test: Jumbo Imp_DAL_561
				InfoCardId = "DAL_561e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [DAL_563] Eager Underling - COST:4 [ATK:2/HP:2] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give two random friendly minions +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_563", new Power {
				// TODO [DAL_563] Eager Underling && Test: Eager Underling_DAL_563
				InfoCardId = "DAL_563e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [DAL_606] EVIL Genius - COST:2 [ATK:2/HP:2] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a friendly minion to add 2 random <b>Lackeys</b>_to_your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_606", new Power {
				// TODO [DAL_606] EVIL Genius && Test: EVIL Genius_DAL_606
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [DAL_607] Fel Lord Betrug - COST:8 [ATK:5/HP:7] 
			// - Race: demon, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Whenever you draw a
			//       minion, summon a copy
			//        with <b>Rush</b> that dies at
			//       end of turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_607", new Power {
				// TODO [DAL_607] Fel Lord Betrug && Test: Fel Lord Betrug_DAL_607
				InfoCardId = "DAL_607e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [DAL_007] Rafaam's Scheme - COST:3 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Summon @ 1/1 |4(Imp, Imps). <i>(Upgrades each turn!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			cards.Add("DAL_007", new Power {
				// TODO [DAL_007] Rafaam's Scheme && Test: Rafaam's Scheme_DAL_007
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [DAL_173] Darkest Hour - COST:6 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all friendly minions. For each one, summon a random minion from your deck.
			// --------------------------------------------------------
			cards.Add("DAL_173", new Power {
				// TODO [DAL_173] Darkest Hour && Test: Darkest Hour_DAL_173
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [DAL_602] Plot Twist - COST:2 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Shuffle your hand
			//       into your deck.
			//       Draw that many cards.
			// --------------------------------------------------------
			cards.Add("DAL_602", new Power {
				// TODO [DAL_602] Plot Twist && Test: Plot Twist_DAL_602
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [DAL_605] Impferno - COST:3 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your Demons +1 Attack. Deal $1 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 15
			// --------------------------------------------------------
			cards.Add("DAL_605", new Power {
				// TODO [DAL_605] Impferno && Test: Impferno_DAL_605
				InfoCardId = "DAL_605e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [DAL_605e] Imptastic (*) - COST:2 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("DAL_605e", new Power {
				// TODO [DAL_605e] Imptastic && Test: Imptastic_DAL_605e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [DAL_060] Clockwork Goblin - COST:3 [ATK:3/HP:3] 
			// - Race: mechanical, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Shuffle a Bomb
			//       into your opponent's deck.
			//       When drawn, it explodes
			//       for 5 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_060", new Power {
				// TODO [DAL_060] Clockwork Goblin && Test: Clockwork Goblin_DAL_060
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [DAL_064] Blastmaster Boom - COST:7 [ATK:7/HP:7] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon two 1/1
			//       Boom Bots for each Bomb
			//       in your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_064", new Power {
				// TODO [DAL_064] Blastmaster Boom && Test: Blastmaster Boom_DAL_064
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [DAL_070] The Boom Reaver - COST:10 [ATK:7/HP:9] 
			// - Race: mechanical, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a copy of a minion in your deck. Give it <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_070", new Power {
				// TODO [DAL_070] The Boom Reaver && Test: The Boom Reaver_DAL_070
				InfoCardId = "DAL_070e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [DAL_759] Vicious Scraphound - COST:2 [ATK:2/HP:2] 
			// - Race: mechanical, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion
			//       deals damage, gain that much Armor.
			// --------------------------------------------------------
			cards.Add("DAL_759", new Power {
				// TODO [DAL_759] Vicious Scraphound && Test: Vicious Scraphound_DAL_759
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [DAL_770] Omega Devastator - COST:4 [ATK:4/HP:5] 
			// - Race: mechanical, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you have 10
			//       Mana Crystals, deal 10
			//       damage to a minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - 84 = 10
			// --------------------------------------------------------
			cards.Add("DAL_770", new Power {
				// TODO [DAL_770] Omega Devastator && Test: Omega Devastator_DAL_770
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [DAL_008] Dr. Boom's Scheme - COST:4 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Gain @ Armor.
			//       <i>(Upgrades each turn!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			cards.Add("DAL_008", new Power {
				// TODO [DAL_008] Dr. Boom's Scheme && Test: Dr. Boom's Scheme_DAL_008
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [DAL_059] Dimensional Ripper - COST:10 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 2 copies of a minion in your deck.
			// --------------------------------------------------------
			cards.Add("DAL_059", new Power {
				// TODO [DAL_059] Dimensional Ripper && Test: Dimensional Ripper_DAL_059
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [DAL_062] Sweeping Strikes - COST:2 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion "Also damages minions next to whomever this attacks."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_062", new Power {
				// TODO [DAL_062] Sweeping Strikes && Test: Sweeping Strikes_DAL_062
				InfoCardId = "DAL_062e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [DAL_769] Improve Morale - COST:1 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Deal $1 damage
			//       to a minion.
			//       If it survives, add a
			//       <b>Lackey</b> to your hand. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_769", new Power {
				// TODO [DAL_769] Improve Morale && Test: Improve Morale_DAL_769
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [DAL_063] Wrenchcalibur - COST:4 [ATK:3/HP:0] 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: After your hero attacks, shuffle a Bomb into your [x]opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("DAL_063", new Power {
				// TODO [DAL_063] Wrenchcalibur && Test: Wrenchcalibur_DAL_063
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [DAL_062e] Sweeping Strikes (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Damages minions adjacent to defender.
			// --------------------------------------------------------
			cards.Add("DAL_062e", new Power {
				// TODO [DAL_062e] Sweeping Strikes && Test: Sweeping Strikes_DAL_062e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [DAL_070e] Reaving (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Has <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("DAL_070e", new Power {
				// TODO [DAL_070e] Reaving && Test: Reaving_DAL_070e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [DAL_742e] Whirling (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Mega-Windfury</b>
			// --------------------------------------------------------
			cards.Add("DAL_742e", new Power {
				// TODO [DAL_742e] Whirling && Test: Whirling_DAL_742e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [DAL_058] Hecklebot - COST:4 [ATK:3/HP:8] 
			// - Race: mechanical, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Your opponent summons a minion from their deck.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_058", new Power {
				// TODO [DAL_058] Hecklebot && Test: Hecklebot_DAL_058
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_077] Toxfin - COST:1 [ATK:1/HP:2] 
			// - Race: murloc, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Murloc <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 14
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("DAL_077", new Power {
				// TODO [DAL_077] Toxfin && Test: Toxfin_DAL_077
				InfoCardId = "DAL_077e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_078] Travelling Healer - COST:4 [ATK:3/HP:2] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>
			//       <b>Battlecry:</b> Restore #3 Health.
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("DAL_078", new Power {
				// TODO [DAL_078] Travelling Healer && Test: Travelling Healer_DAL_078
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_081] Spellward Jeweler - COST:3 [ATK:3/HP:4] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Your hero can't
			//       be targeted by spells or
			//       Hero Powers until your
			//       next turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_081", new Power {
				// TODO [DAL_081] Spellward Jeweler && Test: Spellward Jeweler_DAL_081
				InfoCardId = "DAL_081e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_085] Dalaran Crusader - COST:5 [ATK:5/HP:4] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("DAL_085", new Power {
				// TODO [DAL_085] Dalaran Crusader && Test: Dalaran Crusader_DAL_085
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_086] Sunreaver Spy - COST:2 [ATK:2/HP:3] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_086", new Power {
				// TODO [DAL_086] Sunreaver Spy && Test: Sunreaver Spy_DAL_086
				InfoCardId = "DAL_086e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_087] Hench-Clan Hag - COST:4 [ATK:3/HP:3] 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/1 Amalgams with all minion types.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_087", new Power {
				// TODO [DAL_087] Hench-Clan Hag && Test: Hench-Clan Hag_DAL_087
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_088] Safeguard - COST:6 [ATK:4/HP:5] 
			// - Race: mechanical, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Deathrattle:</b> Summon a 0/5
			//       Vault Safe with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_088", new Power {
				// TODO [DAL_088] Safeguard && Test: Safeguard_DAL_088
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_089] Spellbook Binder - COST:2 [ATK:3/HP:2] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have <b>Spell Damage</b>, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_089", new Power {
				// TODO [DAL_089] Spellbook Binder && Test: Spellbook Binder_DAL_089
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_090] Hench-Clan Sneak - COST:3 [ATK:3/HP:3] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("DAL_090", new Power {
				// TODO [DAL_090] Hench-Clan Sneak && Test: Hench-Clan Sneak_DAL_090
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_092] Arcane Servant - COST:2 [ATK:2/HP:3] 
			// - Race: elemental, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			cards.Add("DAL_092", new Power {
				// TODO [DAL_092] Arcane Servant && Test: Arcane Servant_DAL_092
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_095] Violet Spellsword - COST:4 [ATK:1/HP:6] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain +1 Attack
			//       for each spell in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_095", new Power {
				// TODO [DAL_095] Violet Spellsword && Test: Violet Spellsword_DAL_095
				InfoCardId = "DAL_095e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_096] Violet Warden - COST:6 [ATK:4/HP:7] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_096", new Power {
				// TODO [DAL_096] Violet Warden && Test: Violet Warden_DAL_096
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_400] EVIL Cable Rat - COST:2 [ATK:1/HP:1] 
			// - Race: beast, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a <b>Lackey</b> to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_400", new Power {
				// TODO [DAL_400] EVIL Cable Rat && Test: EVIL Cable Rat_DAL_400
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_434] Arcane Watcher - COST:3 [ATK:5/HP:6] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Can't attack unless you have <b>Spell Damage</b>.
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_434", new Power {
				// TODO [DAL_434] Arcane Watcher && Test: Arcane Watcher_DAL_434
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_538] Unseen Saboteur - COST:6 [ATK:5/HP:6] 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your opponent casts a random spell from their hand <i>(targets chosen randomly)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_538", new Power {
				// TODO [DAL_538] Unseen Saboteur && Test: Unseen Saboteur_DAL_538
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_539] Sunreaver Warmage - COST:5 [ATK:4/HP:4] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a spell that costs (5) or more, deal 4 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_DRAG_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_539", new Power {
				// TODO [DAL_539] Sunreaver Warmage && Test: Sunreaver Warmage_DAL_539
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_544] Potion Vendor - COST:1 [ATK:1/HP:1] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore #2 Health to all friendly characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_544", new Power {
				// TODO [DAL_544] Potion Vendor && Test: Potion Vendor_DAL_544
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_546] Barista Lynchen - COST:5 [ATK:4/HP:5] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a copy of each of your other <b>Battlecry</b> minions_to_your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_546", new Power {
				// TODO [DAL_546] Barista Lynchen && Test: Barista Lynchen_DAL_546
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_548] Azerite Elemental - COST:5 [ATK:2/HP:7] 
			// - Race: elemental, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: At the start of your turn, gain <b>Spell Damage +2</b>.
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_548", new Power {
				// TODO [DAL_548] Azerite Elemental && Test: Azerite Elemental_DAL_548
				InfoCardId = "DAL_548e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_550] Underbelly Ooze - COST:7 [ATK:3/HP:5] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: After this minion survives damage, summon a copy_of it.
			// --------------------------------------------------------
			cards.Add("DAL_550", new Power {
				// TODO [DAL_550] Underbelly Ooze && Test: Underbelly Ooze_DAL_550
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_551] Proud Defender - COST:4 [ATK:2/HP:6] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Has +2 Attack while you [x]have no other minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DAL_551", new Power {
				// TODO [DAL_551] Proud Defender && Test: Proud Defender_DAL_551
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_553] Big Bad Archmage - COST:10 [ATK:6/HP:6] 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a random
			//       6-Cost minion.
			// --------------------------------------------------------
			cards.Add("DAL_553", new Power {
				// TODO [DAL_553] Big Bad Archmage && Test: Big Bad Archmage_DAL_553
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_554] Chef Nomi - COST:7 [ATK:6/HP:6] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck is empty, summon six 6/6 Greasefire_Elementals.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_554", new Power {
				// TODO [DAL_554] Chef Nomi && Test: Chef Nomi_DAL_554
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_558] Archmage Vargoth - COST:4 [ATK:2/HP:6] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]At the end of your turn, cast
			//       a spell you've cast this turn
			//       <i>(targets are random)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DAL_558", new Power {
				// TODO [DAL_558] Archmage Vargoth && Test: Archmage Vargoth_DAL_558
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_560] Heroic Innkeeper - COST:8 [ATK:4/HP:4] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt.</b> <b>Battlecry:</b> Gain +2/+2 for each other friendly minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_560", new Power {
				// TODO [DAL_560] Heroic Innkeeper && Test: Heroic Innkeeper_DAL_560
				InfoCardId = "DAL_560e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_565] Portal Overfiend - COST:6 [ATK:5/HP:6] 
			// - Race: demon, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Shuffle 3 Portals
			//       into your deck. When drawn,
			//       summon a 2/2 Demon
			//       with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_565", new Power {
				// TODO [DAL_565] Portal Overfiend && Test: Portal Overfiend_DAL_565
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_566] Eccentric Scribe - COST:6 [ATK:6/HP:4] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon
			//       four 1/1 Vengeful Scrolls.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_566", new Power {
				// TODO [DAL_566] Eccentric Scribe && Test: Eccentric Scribe_DAL_566
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_582] Portal Keeper - COST:4 [ATK:5/HP:2] 
			// - Race: demon, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Shuffle 3 Portals
			//       into your deck. When drawn,
			//       summon a 2/2 Demon
			//       with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_582", new Power {
				// TODO [DAL_582] Portal Keeper && Test: Portal Keeper_DAL_582
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_592] Batterhead - COST:8 [ATK:3/HP:12] 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Rush</b>. After this attacks and kills a minion, it may_attack again.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_592", new Power {
				// TODO [DAL_592] Batterhead && Test: Batterhead_DAL_592
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_735] Dalaran Librarian - COST:2 [ATK:2/HP:3] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b>
			//       adjacent minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("DAL_735", new Power {
				// TODO [DAL_735] Dalaran Librarian && Test: Dalaran Librarian_DAL_735
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_736] Archivist Elysiana - COST:8 [ATK:7/HP:7] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> 5 cards. Replace your deck with 2_copies of each.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_736", new Power {
				// TODO [DAL_736] Archivist Elysiana && Test: Archivist Elysiana_DAL_736
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_742] Whirlwind Tempest - COST:8 [ATK:6/HP:6] 
			// - Race: elemental, Fac: neutral, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Your minions with <b>Windfury</b> have <b>Mega-Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// - MEGA_WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("DAL_742", new Power {
				// TODO [DAL_742] Whirlwind Tempest && Test: Whirlwind Tempest_DAL_742
				InfoCardId = "DAL_742e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_743] Hench-Clan Hogsteed - COST:2 [ATK:2/HP:1] 
			// - Race: beast, Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Deathrattle:</b> Summon a 1/1 Murloc.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_743", new Power {
				// TODO [DAL_743] Hench-Clan Hogsteed && Test: Hench-Clan Hogsteed_DAL_743
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_744] Faceless Rager - COST:3 [ATK:5/HP:1] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Copy a friendly minion's Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_744", new Power {
				// TODO [DAL_744] Faceless Rager && Test: Faceless Rager_DAL_744
				InfoCardId = "DAL_744e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_747] Flight Master - COST:3 [ATK:3/HP:4] 
			// - Fac: alliance, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/2 Gryphon for each player.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_747", new Power {
				// TODO [DAL_747] Flight Master && Test: Flight Master_DAL_747
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_748] Mana Reservoir - COST:2 [ATK:0/HP:6] 
			// - Race: elemental, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_748", new Power {
				// TODO [DAL_748] Mana Reservoir && Test: Mana Reservoir_DAL_748
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_749] Recurring Villain - COST:5 [ATK:3/HP:6] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If this minion has 4 or more Attack, resummon it.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_749", new Power {
				// TODO [DAL_749] Recurring Villain && Test: Recurring Villain_DAL_749
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_751] Mad Summoner - COST:6 [ATK:4/HP:4] 
			// - Race: demon, Fac: alliance, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Fill each player's
			//       board with 1/1 Imps.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_751", new Power {
				// TODO [DAL_751] Mad Summoner && Test: Mad Summoner_DAL_751
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_752] Jepetto Joybuzz - COST:8 [ATK:6/HP:6] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw 2 minions from your deck. Set their Attack, Health, and Cost to 1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_752", new Power {
				// TODO [DAL_752] Jepetto Joybuzz && Test: Jepetto Joybuzz_DAL_752
				InfoCardId = "DAL_752e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_760] Burly Shovelfist - COST:9 [ATK:9/HP:9] 
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_760", null);

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_771] Soldier of Fortune - COST:4 [ATK:5/HP:6] 
			// - Race: elemental, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion attacks, give your opponent a Coin.
			// --------------------------------------------------------
			cards.Add("DAL_771", new Power {
				// TODO [DAL_771] Soldier of Fortune && Test: Soldier of Fortune_DAL_771
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_773] Magic Carpet - COST:3 [ATK:1/HP:6] 
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: After you play a 1-Cost minion, give it +1 Attack and <b>Rush</b>.
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_773", new Power {
				// TODO [DAL_773] Magic Carpet && Test: Magic Carpet_DAL_773
				InfoCardId = "DAL_773e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_774] Exotic Mountseller - COST:7 [ATK:5/HP:8] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a random
			//       3-Cost Beast.
			// --------------------------------------------------------
			cards.Add("DAL_774", new Power {
				// TODO [DAL_774] Exotic Mountseller && Test: Exotic Mountseller_DAL_774
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_775] Tunnel Blaster - COST:7 [ATK:3/HP:7] 
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Deathrattle:</b> Deal 3 damage
			//       to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_775", new Power {
				// TODO [DAL_775] Tunnel Blaster && Test: Tunnel Blaster_DAL_775
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_011e] Lazul's Curse (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Reduced Attack.
			// --------------------------------------------------------
			cards.Add("DAL_011e", new Power {
				// TODO [DAL_011e] Lazul's Curse && Test: Lazul's Curse_DAL_011e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_052e] Muckmorphing (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: 4/4.
			// --------------------------------------------------------
			cards.Add("DAL_052e", new Power {
				// TODO [DAL_052e] Muckmorphing && Test: Muckmorphing_DAL_052e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_077e] Toxic Fin (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("DAL_077e", new Power {
				// TODO [DAL_077e] Toxic Fin && Test: Toxic Fin_DAL_077e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_081e] Sparkly (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("DAL_081e", new Power {
				// TODO [DAL_081e] Sparkly && Test: Sparkly_DAL_081e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_086e] Stolen Secrets (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +1/+1
			// --------------------------------------------------------
			cards.Add("DAL_086e", new Power {
				// TODO [DAL_086e] Stolen Secrets && Test: Stolen Secrets_DAL_086e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_095e] Pizzazz (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("DAL_095e", new Power {
				// TODO [DAL_095e] Pizzazz && Test: Pizzazz_DAL_095e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_147e] Dragon Shout (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("DAL_147e", new Power {
				// TODO [DAL_147e] Dragon Shout && Test: Dragon Shout_DAL_147e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_351e] Ancient Blessings (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("DAL_351e", new Power {
				// TODO [DAL_351e] Ancient Blessings && Test: Ancient Blessings_DAL_351e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_548e] Arcane Expansion (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Increased <b>Spell Damage</b>.
			// --------------------------------------------------------
			cards.Add("DAL_548e", new Power {
				// TODO [DAL_548e] Arcane Expansion && Test: Arcane Expansion_DAL_548e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_560e2] Protect the Brews! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("DAL_560e2", new Power {
				// TODO [DAL_560e2] Protect the Brews! && Test: Protect the Brews!_DAL_560e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_561e] Imp-onomical (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("DAL_561e", new Power {
				// TODO [DAL_561e] Imp-onomical && Test: Imp-onomical_DAL_561e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_563e] Power of EVIL (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("DAL_563e", new Power {
				// TODO [DAL_563e] Power of EVIL && Test: Power of EVIL_DAL_563e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_570e] Never Surrender! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("DAL_570e", new Power {
				// TODO [DAL_570e] Never Surrender! && Test: Never Surrender!_DAL_570e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_576e] Kirin Tor's Curse (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Costs (1) more.
			// --------------------------------------------------------
			cards.Add("DAL_576e", new Power {
				// TODO [DAL_576e] Kirin Tor's Curse && Test: Kirin Tor's Curse_DAL_576e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_589e] Hunting Party (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("DAL_589e", new Power {
				// TODO [DAL_589e] Hunting Party && Test: Hunting Party_DAL_589e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_607e] Fleeting Fel (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>. Dies at end of turn.
			// --------------------------------------------------------
			cards.Add("DAL_607e", new Power {
				// TODO [DAL_607e] Fleeting Fel && Test: Fleeting Fel_DAL_607e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_714e] Street Smarts (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("DAL_714e", new Power {
				// TODO [DAL_714e] Street Smarts && Test: Street Smarts_DAL_714e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_726e] Scargil's Blessing (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("DAL_726e", new Power {
				// TODO [DAL_726e] Scargil's Blessing && Test: Scargil's Blessing_DAL_726e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_727e] Heroic (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("DAL_727e", new Power {
				// TODO [DAL_727e] Heroic && Test: Heroic_DAL_727e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_739e] Short Fuse (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("DAL_739e", new Power {
				// TODO [DAL_739e] Short Fuse && Test: Short Fuse_DAL_739e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_744e] Familiar Faces (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Copied health.
			// --------------------------------------------------------
			cards.Add("DAL_744e", new Power {
				// TODO [DAL_744e] Familiar Faces && Test: Familiar Faces_DAL_744e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_752e] Toy-sized (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Jepetto Joybuzz made this 1/1.
			// --------------------------------------------------------
			cards.Add("DAL_752e", new Power {
				// TODO [DAL_752e] Toy-sized && Test: Toy-sized_DAL_752e
				InfoCardId = "DAL_752e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_752e2] On Sale (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("DAL_752e2", new Power {
				// TODO [DAL_752e2] On Sale && Test: On Sale_DAL_752e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_773e] Flying High (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("DAL_773e", new Power {
				// TODO [DAL_773e] Flying High && Test: Flying High_DAL_773e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_087t] Amalgam (*) - COST:1 [ATK:1/HP:1] 
			// - Race: all, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<i>This is an Elemental, Mech,
			//       Demon, Murloc, Dragon,
			//       Beast, Pirate and Totem.</i>
			// --------------------------------------------------------
			cards.Add("DAL_087t", new Power {
				// TODO [DAL_087t] Amalgam && Test: Amalgam_DAL_087t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_088t2] Vault Safe (*) - COST:2 [ATK:0/HP:5] 
			// - Race: mechanical, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DAL_088t2", null);

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_554t] Greasefire Elemental (*) - COST:6 [ATK:6/HP:6] 
			// - Race: elemental, Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			cards.Add("DAL_554t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_566t] Vengeful Scroll (*) - COST:1 [ATK:1/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			cards.Add("DAL_566t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_582t2] Felhound (*) - COST:2 [ATK:2/HP:2] 
			// - Race: demon, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_582t2", null);

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_613] Faceless Lackey (*) - COST:1 [ATK:1/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a random 2-Cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_613", new Power {
				// TODO [DAL_613] Faceless Lackey && Test: Faceless Lackey_DAL_613
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_614] Kobold Lackey (*) - COST:1 [ATK:1/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_614", new Power {
				// TODO [DAL_614] Kobold Lackey && Test: Kobold Lackey_DAL_614
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_615] Witchy Lackey (*) - COST:1 [ATK:1/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform a friendly minion into one that costs (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_615", new Power {
				// TODO [DAL_615] Witchy Lackey && Test: Witchy Lackey_DAL_615
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_739] Goblin Lackey (*) - COST:1 [ATK:1/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +1 Attack and_<b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_739", new Power {
				// TODO [DAL_739] Goblin Lackey && Test: Goblin Lackey_DAL_739
				InfoCardId = "DAL_739e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_741] Ethereal Lackey (*) - COST:1 [ATK:1/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_741", new Power {
				// TODO [DAL_741] Ethereal Lackey && Test: Ethereal Lackey_DAL_741
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_743t] Hench-Clan Squire (*) - COST:1 [ATK:1/HP:1] 
			// - Race: murloc, Set: dalaran, 
			// --------------------------------------------------------
			cards.Add("DAL_743t", new Power {
				// TODO [DAL_743t] Hench-Clan Squire && Test: Hench-Clan Squire_DAL_743t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_747t] Gryphon (*) - COST:2 [ATK:2/HP:2] 
			// - Race: beast, Fac: alliance, Set: dalaran, 
			// --------------------------------------------------------
			cards.Add("DAL_747t", new Power {
				// TODO [DAL_747t] Gryphon && Test: Gryphon_DAL_747t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_751t] Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			cards.Add("DAL_751t", new Power {
				// TODO [DAL_751t] Imp && Test: Imp_DAL_751t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [DAL_582t] Felhound Portal (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Casts When Drawn</b>
			//       Summon a 2/2 Felhound with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// - CASTSWHENDRAWN = 1
			// --------------------------------------------------------
			cards.Add("DAL_582t", new Power {
				// TODO [DAL_582t] Felhound Portal && Test: Felhound Portal_DAL_582t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
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
