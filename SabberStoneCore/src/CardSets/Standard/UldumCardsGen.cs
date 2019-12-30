using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Auras;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Triggers;
using SabberStoneCore.src.Loader;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets.Standard
{
	public class UldumCardsGen
	{
		private static void HeroPowers(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------- HERO_POWER - DRUID
			// [ULD_131p] Ossirian Tear (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your <b>Choose One</b> cards have both effects combined.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("ULD_131p", new CardDef(new Power
			{
				// TODO [ULD_131p] Ossirian Tear && Test: Ossirian Tear_ULD_131p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARLOCK
			// [ULD_140p] Tome of Origination (*) - COST:2
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw a card.
			//       It costs (0).
			// --------------------------------------------------------
			cards.Add("ULD_140p", new CardDef(new Power
			{
				// TODO [ULD_140p] Tome of Origination && Test: Tome of Origination_ULD_140p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - HUNTER
			// [ULD_155p] Ramkahen Roar (*) - COST:2
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give your minions +2_Attack.
			// --------------------------------------------------------
			cards.Add("ULD_155p", new CardDef(new Power
			{
				// TODO [ULD_155p] Ramkahen Roar && Test: Ramkahen Roar_ULD_155p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - SHAMAN
			// [ULD_291p] Heart of Vir'naal (*) - COST:2
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Your <b>Battlecries</b> trigger twice this turn.
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_291p", new CardDef(new Power
			{
				// TODO [ULD_291p] Heart of Vir'naal && Test: Heart of Vir'naal_ULD_291p
				InfoCardId = "ULD_291pe",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - ROGUE
			// [ULD_326p] Ancient Blades (*) - COST:2
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Equip a 3/2 Blade with
			//        <b>Immune</b> while attacking.
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("ULD_326p", new CardDef(new Power
			{
				// TODO [ULD_326p] Ancient Blades && Test: Ancient Blades_ULD_326p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - PALADIN
			// [ULD_431p] Emperor Wraps (*) - COST:2
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Summon a 2/2 copy
			//       of a friendly minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("ULD_431p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [ULD_431p] Emperor Wraps && Test: Emperor Wraps_ULD_431p
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------- HERO_POWER - MAGE
			// [ULD_433p] Ascendant Scroll (*) - COST:2
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random Mage
			//       spell to your hand.
			//       It costs (2) less.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("ULD_433p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				// TODO [ULD_433p] Ascendant Scroll && Test: Ascendant Scroll_ULD_433p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [ULD_711p3] Anraphet's Core (*) - COST:2
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Summon a 4/3 Golem.
			//       After your hero attacks,
			//       refresh this.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("ULD_711p3", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [ULD_711p3] Anraphet's Core && Test: Anraphet's Core_ULD_711p3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - PRIEST
			// [ULD_724p] Obelisk's Eye (*) - COST:2
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Restore #3 Health.
			//       If you target a minion, also give it +3/+3.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ULD_724p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [ULD_724p] Obelisk's Eye && Test: Obelisk's Eye_ULD_724p
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Druid(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [ULD_133] Crystal Merchant - COST:2 [ATK:1/HP:4]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: If you have any unspent Mana at the end of your turn, draw a card.
			// --------------------------------------------------------
			cards.Add("ULD_133", new CardDef(new Power
			{
				// TODO [ULD_133] Crystal Merchant && Test: Crystal Merchant_ULD_133
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [ULD_137] Garden Gnome - COST:4 [ATK:2/HP:3]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you're holding
			//       a spell that costs (5) or more,
			//       summon two 2/2 Treants.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_137", new CardDef(new Power
			{
				// TODO [ULD_137] Garden Gnome && Test: Garden Gnome_ULD_137
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [ULD_138] Anubisath Defender - COST:5 [ATK:3/HP:5]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. Costs (0) if you've cast a spell that costs (5) or more this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_138", new CardDef(new Power
			{
				// TODO [ULD_138] Anubisath Defender && Test: Anubisath Defender_ULD_138
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [ULD_139] Elise the Enlightened - COST:5 [ATK:5/HP:5]
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no duplicates, duplicate your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_139", new CardDef(new Power
			{
				// TODO [ULD_139] Elise the Enlightened && Test: Elise the Enlightened_ULD_139
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [ULD_292] Oasis Surger - COST:5 [ATK:3/HP:3]
			// - Race: elemental, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Choose One -</b> Gain +2/+2; or Summon a copy of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ULD_292", new CardDef(new Power
			{
				// TODO [ULD_292] Oasis Surger && Test: Oasis Surger_ULD_292
				InfoCardId = "ULD_292ae",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ULD_131] Untapped Potential - COST:1
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> End 4 turns
			//       with any unspent Mana.
			//       <b>Reward:</b> Ossirian Tear.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 4
			// - 676 = 1
			// - 839 = 1
			// - QUEST_REWARD_DATABASE_ID = 53499
			// --------------------------------------------------------
			cards.Add("ULD_131", new CardDef(new Power
			{
				// TODO [ULD_131] Untapped Potential && Test: Untapped Potential_ULD_131
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ULD_134] BEEEES!!! - COST:3 [ATK:1/HP:4]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Choose a minion.
			//       Summon four 1/1 Bees
			//       that attack it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("ULD_134", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [ULD_134] BEEEES!!! && Test: BEEEES!!!_ULD_134
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ULD_135] Hidden Oasis - COST:6
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One</b> - Summon a 6/6 Ancient with <b>Taunt</b>; or Restore #12 Health.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_135", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [ULD_135] Hidden Oasis && Test: Hidden Oasis_ULD_135
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ULD_136] Worthy Expedition - COST:1
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Choose One</b> card.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("ULD_136", new CardDef(new Power
			{
				// TODO [ULD_136] Worthy Expedition && Test: Worthy Expedition_ULD_136
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ULD_273] Overflow - COST:7
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: Restore #5 Health
			//       to all characters.
			//       Draw 5 cards.
			// --------------------------------------------------------
			cards.Add("ULD_273", new CardDef(new Power
			{
				// TODO [ULD_273] Overflow && Test: Overflow_ULD_273
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [ULD_288e] Buried (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Anka, the Buried made this 1/1.
			// --------------------------------------------------------
			cards.Add("ULD_288e", new CardDef(new Power
			{
				// TODO [ULD_288e] Buried && Test: Buried_ULD_288e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_288e")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [ULD_292ae] Focused (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("ULD_292ae", new CardDef(new Power
			{
				// TODO [ULD_292ae] Focused && Test: Focused_ULD_292ae
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_292ae")
			}));

			// ----------------------------------------- MINION - DRUID
			// [ULD_134t] Bee (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: uldum,
			// --------------------------------------------------------
			cards.Add("ULD_134t", new CardDef(new Power
			{
				// TODO [ULD_134t] Bee && Test: Bee_ULD_134t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [ULD_135at] Vir'naal Ancient (*) - COST:6 [ATK:6/HP:6]
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_135at", new CardDef(new Power
			{
				// TODO [ULD_135at] Vir'naal Ancient && Test: Vir'naal Ancient_ULD_135at
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [ULD_137t] Treant (*) - COST:2 [ATK:2/HP:2]
			// - Set: uldum,
			// --------------------------------------------------------
			cards.Add("ULD_137t", new CardDef(new Power
			{
				// TODO [ULD_137t] Treant && Test: Treant_ULD_137t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ULD_135a] Befriend the Ancient (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Summon a 6/6 Ancient with <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_135a", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [ULD_135a] Befriend the Ancient && Test: Befriend the Ancient_ULD_135a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ULD_135b] Drink the Water (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Restore #12 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ULD_135b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [ULD_135b] Drink the Water && Test: Drink the Water_ULD_135b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ULD_292a] Focused Burst (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Gain +2/+2.
			// --------------------------------------------------------
			cards.Add("ULD_292a", new CardDef(new Power
			{
				// TODO [ULD_292a] Focused Burst && Test: Focused Burst_ULD_292a
				InfoCardId = "ULD_292ae",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ULD_292b] Divide and Conquer (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Summon a copy of this_minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 2
			// --------------------------------------------------------
			cards.Add("ULD_292b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,2}}, new Power
			{
				// TODO [ULD_292b] Divide and Conquer && Test: Divide and Conquer_ULD_292b
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Hunter(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [ULD_151] Ramkahen Wildtamer - COST:3 [ATK:4/HP:3]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Copy a random Beast in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_151", new CardDef(new Power
			{
				// TODO [ULD_151] Ramkahen Wildtamer && Test: Ramkahen Wildtamer_ULD_151
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ULD_154] Hyena Alpha - COST:4 [ATK:3/HP:3]
			// - Race: beast, Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you control
			//       a <b>Secret</b>, summon two
			//       2/2 Hyenas.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ULD_154", new CardDef(new Power
			{
				// TODO [ULD_154] Hyena Alpha && Test: Hyena Alpha_ULD_154
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ULD_156] Dinotamer Brann - COST:7 [ATK:2/HP:4]
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no duplicates, summon King Krush.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_156", new CardDef(new Power
			{
				// TODO [ULD_156] Dinotamer Brann && Test: Dinotamer Brann_ULD_156
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ULD_212] Wild Bloodstinger - COST:6 [ATK:6/HP:9]
			// - Race: beast, Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a minion from your opponent's hand. Attack it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_212", new CardDef(new Power
			{
				// TODO [ULD_212] Wild Bloodstinger && Test: Wild Bloodstinger_ULD_212
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ULD_410] Scarlet Webweaver - COST:6 [ATK:5/HP:5]
			// - Race: beast, Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reduce the Cost of a random Beast in your_hand by (5).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_410", new CardDef(new Power
			{
				// TODO [ULD_410] Scarlet Webweaver && Test: Scarlet Webweaver_ULD_410
				InfoCardId = "ULD_410e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [ULD_152] Pressure Plate - COST:2
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent casts a spell, destroy a random enemy_minion.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ULD_152", new CardDef(new Power
			{
				// TODO [ULD_152] Pressure Plate && Test: Pressure Plate_ULD_152
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [ULD_155] Unseal the Vault - COST:1
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Quest:</b> Summon 20_minions.
			//       <b>Reward:</b> Ramkahen Roar.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 20
			// - 676 = 1
			// - 839 = 1
			// - QUEST_REWARD_DATABASE_ID = 53925
			// --------------------------------------------------------
			cards.Add("ULD_155", new CardDef(new Power
			{
				// TODO [ULD_155] Unseal the Vault && Test: Unseal the Vault_ULD_155
				InfoCardId = "ULD_155e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [ULD_429] Hunter's Pack - COST:3
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: Add a random Hunter Beast, <b>Secret</b>, and weapon to your_hand.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ULD_429", new CardDef(new Power
			{
				// TODO [ULD_429] Hunter's Pack && Test: Hunter's Pack_ULD_429
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [ULD_713] Swarm of Locusts - COST:6
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon seven 1/1 Locusts with <b>Rush</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ULD_713", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [ULD_713] Swarm of Locusts && Test: Swarm of Locusts_ULD_713
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- WEAPON - HUNTER
			// [ULD_430] Desert Spear - COST:3 [ATK:1/HP:0]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: After your hero attacks, summon a 1/1 Locust with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ULD_430", new CardDef(new Power
			{
				// TODO [ULD_430] Desert Spear && Test: Desert Spear_ULD_430
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [ULD_155e] Roar! (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("ULD_155e", new CardDef(new Power
			{
				// TODO [ULD_155e] Roar! && Test: Roar!_ULD_155e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_155e")
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [ULD_410e] Weaved (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Costs (5) less.
			// --------------------------------------------------------
			cards.Add("ULD_410e", new CardDef(new Power
			{
				// TODO [ULD_410e] Weaved && Test: Weaved_ULD_410e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_410e")
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ULD_154t] Hyena (*) - COST:2 [ATK:2/HP:2]
			// - Race: beast, Set: uldum,
			// --------------------------------------------------------
			cards.Add("ULD_154t", new CardDef(new Power
			{
				// TODO [ULD_154t] Hyena && Test: Hyena_ULD_154t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ULD_156t] Duke (*) - COST:5 [ATK:5/HP:5]
			// - Race: beast, Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ULD_156t", new CardDef(new Power
			{
				// TODO [ULD_156t] Duke && Test: Duke_ULD_156t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ULD_156t2] Duchess (*) - COST:5 [ATK:5/HP:5]
			// - Race: beast, Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ULD_156t2", new CardDef(new Power
			{
				// TODO [ULD_156t2] Duchess && Test: Duchess_ULD_156t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ULD_156t3] King Krush (*) - COST:9 [ATK:8/HP:8]
			// - Race: beast, Fac: neutral, Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("ULD_156t3", new CardDef(new Power
			{
				// TODO [ULD_156t3] King Krush && Test: King Krush_ULD_156t3
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Mage(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [ULD_236] Tortollan Pilgrim - COST:8 [ATK:5/HP:5]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry</b>: <b>Discover</b> a copy of
			//       a spell in your deck and cast
			//       it with random targets.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("ULD_236", new CardDef(new Power
			{
				// TODO [ULD_236] Tortollan Pilgrim && Test: Tortollan Pilgrim_ULD_236
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [ULD_238] Reno the Relicologist - COST:6 [ATK:4/HP:6]
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no duplicates, deal 10 damage randomly split among all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_238", new CardDef(new Power
			{
				// TODO [ULD_238] Reno the Relicologist && Test: Reno the Relicologist_ULD_238
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [ULD_240] Arcane Flakmage - COST:2 [ATK:3/HP:2]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: After you play a <b>Secret</b>, deal 2 damage to all enemy minions.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ULD_240", new CardDef(new Power
			{
				// TODO [ULD_240] Arcane Flakmage && Test: Arcane Flakmage_ULD_240
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [ULD_293] Cloud Prince - COST:5 [ATK:4/HP:4]
			// - Race: elemental, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, deal 6 damage.
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
			cards.Add("ULD_293", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS,1}}, new Power
			{
				// TODO [ULD_293] Cloud Prince && Test: Cloud Prince_ULD_293
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [ULD_329] Dune Sculptor - COST:3 [ATK:3/HP:3]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]After you cast a spell,
			//       add a random Mage
			//       minion to your hand.
			// --------------------------------------------------------
			cards.Add("ULD_329", new CardDef(new Power
			{
				// TODO [ULD_329] Dune Sculptor && Test: Dune Sculptor_ULD_329
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [ULD_435] Naga Sand Witch - COST:5 [ATK:5/HP:5]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Change the Cost
			//       of spells in your hand to (5).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_435", new CardDef(new Power
			{
				// TODO [ULD_435] Naga Sand Witch && Test: Naga Sand Witch_ULD_435
				InfoCardId = "ULD_435e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [ULD_216] Puzzle Box of Yogg-Saron - COST:10
			// - Fac: neutral, Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: Cast 10 random spells <i>(targets chosen randomly).</i>
			// --------------------------------------------------------
			cards.Add("ULD_216", new CardDef(new Power
			{
				// TODO [ULD_216] Puzzle Box of Yogg-Saron && Test: Puzzle Box of Yogg-Saron_ULD_216
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [ULD_239] Flame Ward - COST:3
			// - Fac: neutral, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After a minion attacks your hero, deal $3 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ULD_239", new CardDef(new Power
			{
				// TODO [ULD_239] Flame Ward && Test: Flame Ward_ULD_239
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [ULD_433] Raid the Sky Temple - COST:1
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Quest:</b> Cast 10 spells.
			//       <b>Reward: </b>Ascendant Scroll.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 10
			// - 676 = 1
			// - 839 = 1
			// - QUEST_REWARD_DATABASE_ID = 53946
			// --------------------------------------------------------
			cards.Add("ULD_433", new CardDef(new Power
			{
				// TODO [ULD_433] Raid the Sky Temple && Test: Raid the Sky Temple_ULD_433
				InfoCardId = "ULD_433e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [ULD_726] Ancient Mysteries - COST:2
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: Draw a <b>Secret</b> from your deck. It costs (0).
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ULD_726", new CardDef(new Power
			{
				// TODO [ULD_726] Ancient Mysteries && Test: Ancient Mysteries_ULD_726
				InfoCardId = "ULD_726e",
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [ULD_435e] Sandwitched (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Costs (5).
			// --------------------------------------------------------
			cards.Add("ULD_435e", new CardDef(new Power
			{
				// TODO [ULD_435e] Sandwitched && Test: Sandwitched_ULD_435e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_435e")
			}));

			// ------------------------------------- ENCHANTMENT - MAGE
			// [ULD_726e] Translated (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			cards.Add("ULD_726e", new CardDef(new Power
			{
				// TODO [ULD_726e] Translated && Test: Translated_ULD_726e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_726e")
			}));

		}

		private static void Paladin(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [ULD_145] Brazen Zealot - COST:1 [ATK:2/HP:1]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you summon a minion, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("ULD_145", new CardDef(new Power
			{
				// TODO [ULD_145] Brazen Zealot && Test: Brazen Zealot_ULD_145
				InfoCardId = "ULD_145e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [ULD_207] Ancestral Guardian - COST:4 [ATK:4/HP:2]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       <b>Reborn</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_207", new CardDef(new Power
			{
				// TODO [ULD_207] Ancestral Guardian && Test: Ancestral Guardian_ULD_207
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [ULD_217] Micro Mummy - COST:2 [ATK:1/HP:2]
			// - Race: mechanical, Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Reborn</b>
			//       At the end of your turn, give
			//       another random friendly
			//       minion +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_217", new CardDef(new Power
			{
				// TODO [ULD_217] Micro Mummy && Test: Micro Mummy_ULD_217
				InfoCardId = "ULD_217e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [ULD_438] Salhet's Pride - COST:3 [ATK:3/HP:1]
			// - Race: beast, Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw two
			//       1-Health minions from your_deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ULD_438", new CardDef(new Power
			{
				// TODO [ULD_438] Salhet's Pride && Test: Salhet's Pride_ULD_438
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [ULD_439] Sandwasp Queen - COST:2 [ATK:3/HP:1]
			// - Race: beast, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add two 2/1 Sandwasps to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_439", new CardDef(new Power
			{
				// TODO [ULD_439] Sandwasp Queen && Test: Sandwasp Queen_ULD_439
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [ULD_500] Sir Finley of the Sands - COST:2 [ATK:2/HP:3]
			// - Race: murloc, Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your deck has
			//       no duplicates, <b>Discover</b> an
			//       upgraded Hero Power.
			// --------------------------------------------------------
			// Entourage: AT_132_DRUID, AT_132_HUNTER, AT_132_MAGE, AT_132_PALADIN, AT_132_PRIEST, AT_132_SHAMAN, AT_132_ROGUE, AT_132_WARLOCK, AT_132_WARRIOR
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("ULD_500", new CardDef(new[] {"AT_132_DRUID","AT_132_HUNTER","AT_132_MAGE","AT_132_PALADIN","AT_132_PRIEST","AT_132_SHAMAN","AT_132_ROGUE","AT_132_WARLOCK","AT_132_WARRIOR"}, new Power
			{
				// TODO [ULD_500] Sir Finley of the Sands && Test: Sir Finley of the Sands_ULD_500
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [ULD_143] Pharaoh's Blessing - COST:6
			// - Fac: neutral, Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion +4/+4, <b>Divine Shield</b>, and <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ULD_143", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_143] Pharaoh's Blessing && Test: Pharaoh's Blessing_ULD_143
				InfoCardId = "ULD_143e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [ULD_431] Making Mummies - COST:1
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Play 5 <b>Reborn</b>
			//       minions.
			//       <b>Reward:</b> Emperor Wraps.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 5
			// - 676 = 1
			// - 839 = 1
			// - QUEST_REWARD_DATABASE_ID = 53908
			// --------------------------------------------------------
			// RefTag:
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_431", new CardDef(new Power
			{
				// TODO [ULD_431] Making Mummies && Test: Making Mummies_ULD_431
				InfoCardId = "ULD_431e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [ULD_716] Tip the Scales - COST:8
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon 7 Murlocs from your deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ULD_716", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_716] Tip the Scales && Test: Tip the Scales_ULD_716
				InfoCardId = "ULD_716e2",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [ULD_728] Subdue - COST:2
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: Set a minion's Attack and Health to 1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ULD_728", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_728] Subdue && Test: Subdue_ULD_728
				InfoCardId = "ULD_728e",
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ULD_143e] Pharaoh's Blessing (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: +4/+4, <b>Divine Shield</b>, and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ULD_143e", new CardDef(new Power
			{
				// TODO [ULD_143e] Pharaoh's Blessing && Test: Pharaoh's Blessing_ULD_143e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_143e")
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ULD_145e] Zeal (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("ULD_145e", new CardDef(new Power
			{
				// TODO [ULD_145e] Zeal && Test: Zeal_ULD_145e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_145e")
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ULD_431e] Emperor Wrapped (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: 2/2.
			// --------------------------------------------------------
			cards.Add("ULD_431e", new CardDef(new Power
			{
				// TODO [ULD_431e] Emperor Wrapped && Test: Emperor Wrapped_ULD_431e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_431e")
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ULD_716e2] Watched (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Stats changed to 3/3.
			// --------------------------------------------------------
			cards.Add("ULD_716e2", new CardDef(new Power
			{
				// TODO [ULD_716e2] Watched && Test: Watched_ULD_716e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_716e2")
			}));

			// --------------------------------------- MINION - PALADIN
			// [ULD_439t] Sandwasp (*) - COST:1 [ATK:2/HP:1]
			// - Race: beast, Set: uldum,
			// --------------------------------------------------------
			cards.Add("ULD_439t", new CardDef(new Power
			{
				// TODO [ULD_439t] Sandwasp && Test: Sandwasp_ULD_439t
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Priest(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [ULD_262] High Priest Amet - COST:4 [ATK:2/HP:7]
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Whenever you summon a
			//       minion, set its Health equal
			//       to this minion's.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ULD_262", new CardDef(new Power
			{
				// TODO [ULD_262] High Priest Amet && Test: High Priest Amet_ULD_262
				InfoCardId = "ULD_262e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [ULD_266] Grandmummy - COST:2 [ATK:1/HP:2]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Reborn</b>
			//        <b>Deathrattle:</b> Give a random
			//       friendly minion +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_266", new CardDef(new Power
			{
				// TODO [ULD_266] Grandmummy && Test: Grandmummy_ULD_266
				InfoCardId = "ULD_266e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [ULD_268] Psychopomp - COST:4 [ATK:3/HP:1]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon a
			//       random friendly minion
			//       that died this game.
			//       Give it <b>Reborn</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_268", new CardDef(new Power
			{
				// TODO [ULD_268] Psychopomp && Test: Psychopomp_ULD_268
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [ULD_269] Wretched Reclaimer - COST:3 [ATK:3/HP:3]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Destroy a friendly
			//       minion, then return it to life
			//       with full Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("ULD_269", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				// TODO [ULD_269] Wretched Reclaimer && Test: Wretched Reclaimer_ULD_269
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [ULD_270] Sandhoof Waterbearer - COST:5 [ATK:5/HP:5]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, restore #5 Health to a damaged friendly character.
			// --------------------------------------------------------
			cards.Add("ULD_270", new CardDef(new Power
			{
				// TODO [ULD_270] Sandhoof Waterbearer && Test: Sandhoof Waterbearer_ULD_270
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [ULD_265] Embalming Ritual - COST:1
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion <b>Reborn</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_265", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_265] Embalming Ritual && Test: Embalming Ritual_ULD_265
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [ULD_272] Holy Ripple - COST:2
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $1 damage to all enemies. Restore #1_Health to all friendly characters. @spelldmg
			// --------------------------------------------------------
			cards.Add("ULD_272", new CardDef(new Power
			{
				// TODO [ULD_272] Holy Ripple && Test: Holy Ripple_ULD_272
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [ULD_714] Penance - COST:2
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       Deal $3 damage to a_minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ULD_714", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_714] Penance && Test: Penance_ULD_714
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [ULD_718] Plague of Death - COST:9
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Silence</b> and destroy all_minions.
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("ULD_718", new CardDef(new Power
			{
				// TODO [ULD_718] Plague of Death && Test: Plague of Death_ULD_718
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [ULD_724] Activate the Obelisk - COST:1
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Quest:</b> Restore 15_Health.
			//       <b>Reward:</b> Obelisk's Eye.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 15
			// - 676 = 1
			// - 839 = 1
			// - QUEST_REWARD_DATABASE_ID = 54750
			// --------------------------------------------------------
			cards.Add("ULD_724", new CardDef(new Power
			{
				// TODO [ULD_724] Activate the Obelisk && Test: Activate the Obelisk_ULD_724
				InfoCardId = "ULD_724e",
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [ULD_262e] Amet's Blessing (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Health changed.
			// --------------------------------------------------------
			cards.Add("ULD_262e", new CardDef(new Power
			{
				// TODO [ULD_262e] Amet's Blessing && Test: Amet's Blessing_ULD_262e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_262e")
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [ULD_266e] Grandmummy's Blessing (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_266e", new CardDef(new Power
			{
				// TODO [ULD_266e] Grandmummy's Blessing && Test: Grandmummy's Blessing_ULD_266e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_266e")
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [ULD_724e] Obelisk's Gaze (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ULD_724e", new CardDef(new Power
			{
				// TODO [ULD_724e] Obelisk's Gaze && Test: Obelisk's Gaze_ULD_724e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_724e")
			}));

		}

		private static void Rogue(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [ULD_186] Pharaoh Cat - COST:1 [ATK:1/HP:2]
			// - Race: beast, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random <b>Reborn</b> minion to your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_186", new CardDef(new Power
			{
				// TODO [ULD_186] Pharaoh Cat && Test: Pharaoh Cat_ULD_186
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [ULD_231] Whirlkick Master - COST:2 [ATK:1/HP:2]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you play a <b>Combo</b> card, add a random <b>Combo</b> card to your hand.
			// --------------------------------------------------------
			// RefTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("ULD_231", new CardDef(new Power
			{
				// TODO [ULD_231] Whirlkick Master && Test: Whirlkick Master_ULD_231
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [ULD_280] Sahket Sapper - COST:4 [ATK:4/HP:4]
			// - Race: pirate, Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return a _random enemy minion to_ your_opponent's_hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ULD_280", new CardDef(new Power
			{
				// TODO [ULD_280] Sahket Sapper && Test: Sahket Sapper_ULD_280
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [ULD_288] Anka, the Buried - COST:5 [ATK:5/HP:5]
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Change each <b>Deathrattle</b> minion in your hand into a 1/1 that costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ULD_288", new CardDef(new Power
			{
				// TODO [ULD_288] Anka, the Buried && Test: Anka, the Buried_ULD_288
				InfoCardId = "ULD_288e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [ULD_327] Bazaar Mugger - COST:5 [ATK:3/HP:5]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Battlecry:</b> Add a random minion from another class to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ULD_327", new CardDef(new Power
			{
				// TODO [ULD_327] Bazaar Mugger && Test: Bazaar Mugger_ULD_327
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [ULD_286] Shadow of Death - COST:4
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: Choose a minion. Shuffle 3 'Shadows' into your deck that summon a copy when drawn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ULD_286", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_286] Shadow of Death && Test: Shadow of Death_ULD_286
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [ULD_326] Bazaar Burglary - COST:1
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Add 4 cards from
			//       other classes to your hand.
			//       <b>Reward: </b>Ancient Blades.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 4
			// - 676 = 1
			// - 839 = 1
			// - QUEST_REWARD_DATABASE_ID = 54312
			// --------------------------------------------------------
			cards.Add("ULD_326", new CardDef(new Power
			{
				// TODO [ULD_326] Bazaar Burglary && Test: Bazaar Burglary_ULD_326
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [ULD_328] Clever Disguise - COST:2
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: Add 2 random spells from another class to_your hand.
			// --------------------------------------------------------
			cards.Add("ULD_328", new CardDef(new Power
			{
				// TODO [ULD_328] Clever Disguise && Test: Clever Disguise_ULD_328
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [ULD_715] Plague of Madness - COST:1
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: Each player equips
			//       a 2/2 Knife with <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 2451
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ULD_715", new CardDef(new Power
			{
				// TODO [ULD_715] Plague of Madness && Test: Plague of Madness_ULD_715
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- WEAPON - ROGUE
			// [ULD_285] Hooked Scimitar - COST:3 [ATK:2/HP:0]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Combo:</b> Gain +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("ULD_285", new CardDef(new Power
			{
				// TODO [ULD_285] Hooked Scimitar && Test: Hooked Scimitar_ULD_285
				InfoCardId = "ULD_285e",
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void RogueNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ULD_285e] Polished (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("ULD_285e", new CardDef(new Power
			{
				// TODO [ULD_285e] Polished && Test: Polished_ULD_285e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_285e")
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [ULD_286t] Shadow (*) - COST:4
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Casts When Drawn</b>
			//       Summon a {0}.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			// RefTag:
			// - CASTSWHENDRAWN = 1
			// --------------------------------------------------------
			cards.Add("ULD_286t", new CardDef(new Power
			{
				// TODO [ULD_286t] Shadow && Test: Shadow_ULD_286t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- WEAPON - ROGUE
			// [ULD_326t] Mirage Blade (*) - COST:2 [ATK:3/HP:0]
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Your hero is <b>Immune</b> while attacking.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("ULD_326t", new CardDef(new Power
			{
				// TODO [ULD_326t] Mirage Blade && Test: Mirage Blade_ULD_326t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- WEAPON - ROGUE
			// [ULD_715t] Plagued Knife (*) - COST:1 [ATK:2/HP:0]
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ULD_715t", new CardDef(new Power
			{
				// TODO [ULD_715t] Plagued Knife && Test: Plagued Knife_ULD_715t
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Shaman(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [ULD_158] Sandstorm Elemental - COST:2 [ATK:2/HP:2]
			// - Race: elemental, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage to all enemy minions. <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_158", new CardDef(new Power
			{
				// TODO [ULD_158] Sandstorm Elemental && Test: Sandstorm Elemental_ULD_158
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [ULD_169] Mogu Fleshshaper - COST:7 [ATK:3/HP:4]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>. Costs (1) less for each
			//       minion on the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ULD_169", new CardDef(new Power
			{
				// TODO [ULD_169] Mogu Fleshshaper && Test: Mogu Fleshshaper_ULD_169
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [ULD_170] Weaponized Wasp - COST:3 [ATK:3/HP:3]
			// - Race: beast, Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control
			//       a <b>Lackey</b>, deal 3_damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ88 = 0
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("ULD_170", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ88,0}}, new Power
			{
				// TODO [ULD_170] Weaponized Wasp && Test: Weaponized Wasp_ULD_170
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [ULD_173] Vessina - COST:4 [ATK:2/HP:6]
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: While you're <b>Overloaded</b>, your other minions have +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("ULD_173", new CardDef(new Power
			{
				// TODO [ULD_173] Vessina && Test: Vessina_ULD_173
				InfoCardId = "ULD_173e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [ULD_276] EVIL Totem - COST:2 [ATK:0/HP:2]
			// - Race: totem, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn,
			//       add a <b>Lackey</b> to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - 1359 = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("ULD_276", new CardDef(new Power
			{
				// TODO [ULD_276] EVIL Totem && Test: EVIL Totem_ULD_276
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [ULD_171] Totemic Surge - COST:0
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: Give your Totems +2_Attack.
			// --------------------------------------------------------
			cards.Add("ULD_171", new CardDef(new Power
			{
				// TODO [ULD_171] Totemic Surge && Test: Totemic Surge_ULD_171
				InfoCardId = "ULD_171e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [ULD_172] Plague of Murlocs - COST:3
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: Transform all minions into random Murlocs.
			// --------------------------------------------------------
			cards.Add("ULD_172", new CardDef(new Power
			{
				// TODO [ULD_172] Plague of Murlocs && Test: Plague of Murlocs_ULD_172
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [ULD_181] Earthquake - COST:7
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage to all minions, then deal $2 damage to all minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("ULD_181", new CardDef(new Power
			{
				// TODO [ULD_181] Earthquake && Test: Earthquake_ULD_181
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [ULD_291] Corrupt the Waters - COST:1
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Play 6 <b>Battlecry</b>
			//       cards.
			//       <b>Reward:</b> Heart of Vir'naal.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 6
			// - 676 = 1
			// - 839 = 1
			// - QUEST_REWARD_DATABASE_ID = 54370
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_291", new CardDef(new Power
			{
				// TODO [ULD_291] Corrupt the Waters && Test: Corrupt the Waters_ULD_291
				InfoCardId = "ULD_291pe",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- WEAPON - SHAMAN
			// [ULD_413] Splitting Axe - COST:4 [ATK:3/HP:0]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon copies of your Totems.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_413", new CardDef(new Power
			{
				// TODO [ULD_413] Splitting Axe && Test: Splitting Axe_ULD_413
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void ShamanNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [ULD_171e] Big Surge (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ULD_171e", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [ULD_171e] Big Surge && Test: Big Surge_ULD_171e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_171e")
			}));

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [ULD_173e] Vessina's Devotion (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Vessina is granting this minion +2_Attack.
			// --------------------------------------------------------
			cards.Add("ULD_173e", new CardDef(new Power
			{
				// TODO [ULD_173e] Vessina's Devotion && Test: Vessina's Devotion_ULD_173e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_173e")
			}));

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [ULD_433e] Cheat Sheet (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			cards.Add("ULD_433e", new CardDef(new Power
			{
				// TODO [ULD_433e] Cheat Sheet && Test: Cheat Sheet_ULD_433e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_433e")
			}));

		}

		private static void Warlock(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [ULD_161] Neferset Thrasher - COST:3 [ATK:4/HP:5]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this attacks, deal 3 damage to your_hero.
			// --------------------------------------------------------
			cards.Add("ULD_161", new CardDef(new Power
			{
				// TODO [ULD_161] Neferset Thrasher && Test: Neferset Thrasher_ULD_161
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [ULD_162] EVIL Recruiter - COST:3 [ATK:3/HP:3]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a friendly <b>Lackey</b> to summon a 5/5 Demon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - 1359 = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ87 = 0
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("ULD_162", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ87,0}}, new Power
			{
				// TODO [ULD_162] EVIL Recruiter && Test: EVIL Recruiter_ULD_162
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [ULD_163] Expired Merchant - COST:2 [ATK:2/HP:1]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Discard your
			//       highest Cost card.
			//       <b>Deathrattle:</b> Add 2 copies
			//       of it to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_163", new CardDef(new Power
			{
				// TODO [ULD_163] Expired Merchant && Test: Expired Merchant_ULD_163
				InfoCardId = "ULD_163e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [ULD_165] Riftcleaver - COST:6 [ATK:7/HP:5]
			// - Race: demon, Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a minion. Your hero takes damage equal to its Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ULD_165", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_165] Riftcleaver && Test: Riftcleaver_ULD_165
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [ULD_167] Diseased Vulture - COST:4 [ATK:3/HP:5]
			// - Race: beast, Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: After your hero takes damage on your turn, summon a random
			//       3-Cost minion.
			// --------------------------------------------------------
			cards.Add("ULD_167", new CardDef(new Power
			{
				// TODO [ULD_167] Diseased Vulture && Test: Diseased Vulture_ULD_167
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [ULD_168] Dark Pharaoh Tekahn - COST:5 [ATK:4/HP:4]
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> For the rest of the game, your <b>Lackeys</b> are 4/4.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("ULD_168", new CardDef(new Power
			{
				// TODO [ULD_168] Dark Pharaoh Tekahn && Test: Dark Pharaoh Tekahn_ULD_168
				InfoCardId = "ULD_168e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [ULD_140] Supreme Archaeology - COST:1
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Quest:</b> Draw 20 cards.
			//       <b>Reward:</b> Tome of Origination.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 20
			// - 676 = 1
			// - 839 = 1
			// - QUEST_REWARD_DATABASE_ID = 53740
			// --------------------------------------------------------
			cards.Add("ULD_140", new CardDef(new Power
			{
				// TODO [ULD_140] Supreme Archaeology && Test: Supreme Archaeology_ULD_140
				InfoCardId = "ULD_140e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [ULD_160] Sinister Deal - COST:1
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Lackey</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// - 1359 = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("ULD_160", new CardDef(new Power
			{
				// TODO [ULD_160] Sinister Deal && Test: Sinister Deal_ULD_160
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [ULD_324] Impbalming - COST:4
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a minion. Shuffle 3 Worthless Imps into your deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ULD_324", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_324] Impbalming && Test: Impbalming_ULD_324
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [ULD_717] Plague of Flames - COST:1
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Destroy all your minions.
			//       For each one, destroy a
			//       random enemy minion.
			// --------------------------------------------------------
			cards.Add("ULD_717", new CardDef(new Power
			{
				// TODO [ULD_717] Plague of Flames && Test: Plague of Flames_ULD_717
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarlockNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [ULD_140e] Origination (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			cards.Add("ULD_140e", new CardDef(new Power
			{
				// TODO [ULD_140e] Origination && Test: Origination_ULD_140e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_140e")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [ULD_163e] Expired Goods (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Discarded {0}.
			// --------------------------------------------------------
			cards.Add("ULD_163e", new CardDef(new Power
			{
				// TODO [ULD_163e] Expired Goods && Test: Expired Goods_ULD_163e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_163e")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [ULD_168e] Lackey Empowerment (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Your <b>Lackeys</b> are 4/4.
			// --------------------------------------------------------
			cards.Add("ULD_168e", new CardDef(new Power
			{
				// TODO [ULD_168e] Lackey Empowerment && Test: Lackey Empowerment_ULD_168e
				InfoCardId = "ULD_168e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_168e")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [ULD_168e2] Lackey Empowerment (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Your <b>Lackeys</b> are 4/4.
			// --------------------------------------------------------
			cards.Add("ULD_168e2", new CardDef(new Power
			{
				// TODO [ULD_168e2] Lackey Empowerment && Test: Lackey Empowerment_ULD_168e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_168e2")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [ULD_168e3] Lackey Empowerment (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: 4/4.
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("ULD_168e3", new CardDef(new Power
			{
				// TODO [ULD_168e3] Lackey Empowerment && Test: Lackey Empowerment_ULD_168e3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_168e3")
			}));

			// --------------------------------------- MINION - WARLOCK
			// [ULD_162t] EVIL Demon (*) - COST:5 [ATK:5/HP:5]
			// - Race: demon, Set: uldum,
			// --------------------------------------------------------
			cards.Add("ULD_162t", new CardDef(new Power
			{
				// TODO [ULD_162t] EVIL Demon && Test: EVIL Demon_ULD_162t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [ULD_324t] Worthless Imp (*) - COST:1 [ATK:1/HP:1]
			// - Race: demon, Set: uldum,
			// --------------------------------------------------------
			cards.Add("ULD_324t", new CardDef(new Power
			{
				// TODO [ULD_324t] Worthless Imp && Test: Worthless Imp_ULD_324t
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Warrior(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [ULD_195] Frightened Flunky - COST:2 [ATK:2/HP:2]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> <b>Discover</b> a <b>Taunt</b>_minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("ULD_195", new CardDef(new Power
			{
				// TODO [ULD_195] Frightened Flunky && Test: Frightened Flunky_ULD_195
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [ULD_206] Restless Mummy - COST:4 [ATK:3/HP:2]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Reborn</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_206", new CardDef(new Power
			{
				// TODO [ULD_206] Restless Mummy && Test: Restless Mummy_ULD_206
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [ULD_253] Tomb Warden - COST:8 [ATK:3/HP:6]
			// - Race: mechanical, Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Summon a copy of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_253", new CardDef(new Power
			{
				// TODO [ULD_253] Tomb Warden && Test: Tomb Warden_ULD_253
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [ULD_258] Armagedillo - COST:6 [ATK:4/HP:7]
			// - Race: beast, Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       At the end of your turn,
			//       give all <b>Taunt</b> minions
			//       in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_258", new CardDef(new Power
			{
				// TODO [ULD_258] Armagedillo && Test: Armagedillo_ULD_258
				InfoCardId = "ULD_258e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [ULD_709] Armored Goon - COST:6 [ATK:6/HP:7]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your hero attacks, gain 5 Armor.
			// --------------------------------------------------------
			cards.Add("ULD_709", new CardDef(new Power
			{
				// TODO [ULD_709] Armored Goon && Test: Armored Goon_ULD_709
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [ULD_720] Bloodsworn Mercenary - COST:3 [ATK:3/HP:3]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry</b>: Choose a
			//       damaged friendly minion.
			//       Summon a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_DAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ULD_720", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_DAMAGED_TARGET,0}}, new Power
			{
				// TODO [ULD_720] Bloodsworn Mercenary && Test: Bloodsworn Mercenary_ULD_720
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [ULD_256] Into the Fray - COST:1
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: Give all <b>Taunt</b> minions in your hand +2/+2.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_256", new CardDef(new Power
			{
				// TODO [ULD_256] Into the Fray && Test: Into the Fray_ULD_256
				InfoCardId = "ULD_256e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [ULD_707] Plague of Wrath - COST:5
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy all damaged minions.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 41425
			// --------------------------------------------------------
			cards.Add("ULD_707", new CardDef(new Power
			{
				// TODO [ULD_707] Plague of Wrath && Test: Plague of Wrath_ULD_707
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [ULD_711] Hack the System - COST:1
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Attack 5 times
			//       with your hero.
			//       <b>Reward:</b> Anraphet's Core.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 5
			// - 676 = 1
			// - 839 = 1
			// - QUEST_REWARD_DATABASE_ID = 54416
			// --------------------------------------------------------
			cards.Add("ULD_711", new CardDef(new Power
			{
				// TODO [ULD_711] Hack the System && Test: Hack the System_ULD_711
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [ULD_708] Livewire Lance - COST:3 [ATK:2/HP:0]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: After your Hero attacks, add a <b>Lackey</b> to your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - 1359 = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("ULD_708", new CardDef(new Power
			{
				// TODO [ULD_708] Livewire Lance && Test: Livewire Lance_ULD_708
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [ULD_711t] Stone Golem (*) - COST:3 [ATK:4/HP:3]
			// - Set: uldum,
			// --------------------------------------------------------
			cards.Add("ULD_711t", new CardDef(new Power
			{
				// TODO [ULD_711t] Stone Golem && Test: Stone Golem_ULD_711t
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Neutral(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [ULD_003] Zephrys the Great - COST:2 [ATK:3/HP:2]
			// - Race: elemental, Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no duplicates, wish for the perfect card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_003", new CardDef(new Power
			{
				// TODO [ULD_003] Zephrys the Great && Test: Zephrys the Great_ULD_003
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_157] Questing Explorer - COST:2 [ATK:2/HP:3]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a <b>Quest</b>, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - QUEST = 1
			// --------------------------------------------------------
			cards.Add("ULD_157", new CardDef(new Power
			{
				// TODO [ULD_157] Questing Explorer && Test: Questing Explorer_ULD_157
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_174] Serpent Egg - COST:2 [ATK:0/HP:3]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 3/4 Sea Serpent.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ULD_174", new CardDef(new Power
			{
				// TODO [ULD_174] Serpent Egg && Test: Serpent Egg_ULD_174
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_177] Octosari - COST:8 [ATK:8/HP:8]
			// - Race: beast, Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw 8 cards.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ULD_177", new CardDef(new Power
			{
				// TODO [ULD_177] Octosari && Test: Octosari_ULD_177
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_178] Siamat - COST:7 [ATK:6/HP:6]
			// - Race: elemental, Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain 2 of <b>Rush</b>,
			//       <b>Taunt</b>, <b>Divine Shield</b>, or
			//       <b>Windfury</b> <i>(your choice).</i>
			// --------------------------------------------------------
			// Entourage: ULD_178a2, ULD_178a, ULD_178a3, ULD_178a4
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ULD_178", new CardDef(new[] {"ULD_178a2","ULD_178a","ULD_178a3","ULD_178a4"}, new Power
			{
				// TODO [ULD_178] Siamat && Test: Siamat_ULD_178
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_179] Phalanx Commander - COST:5 [ATK:4/HP:5]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: Your <b>Taunt</b> minions
			//       have +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - 1429 = 58385
			// - TECH_LEVEL = 3
			// - 1456 = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_179", new CardDef(new Power
			{
				// TODO [ULD_179] Phalanx Commander && Test: Phalanx Commander_ULD_179
				InfoCardId = "ULD_179e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_180] Sunstruck Henchman - COST:4 [ATK:6/HP:5]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, this has a 50% chance to_fall asleep.
			// --------------------------------------------------------
			cards.Add("ULD_180", new CardDef(new Power
			{
				// TODO [ULD_180] Sunstruck Henchman && Test: Sunstruck Henchman_ULD_180
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_182] Spitting Camel - COST:2 [ATK:2/HP:4]
			// - Race: beast, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: [x]At the end of your turn,
			//       __deal 1 damage to another__
			//       random friendly minion.
			// --------------------------------------------------------
			cards.Add("ULD_182", new CardDef(new Power
			{
				// TODO [ULD_182] Spitting Camel && Test: Spitting Camel_ULD_182
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_183] Anubisath Warbringer - COST:9 [ATK:9/HP:6]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give all minions in your hand +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ULD_183", new CardDef(new Power
			{
				// TODO [ULD_183] Anubisath Warbringer && Test: Anubisath Warbringer_ULD_183
				InfoCardId = "ULD_183e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_184] Kobold Sandtrooper - COST:2 [ATK:2/HP:1]
			// - Fac: alliance, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 3 damage to the enemy_hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ULD_184", new CardDef(new Power
			{
				// TODO [ULD_184] Kobold Sandtrooper && Test: Kobold Sandtrooper_ULD_184
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_185] Temple Berserker - COST:2 [ATK:1/HP:2]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Reborn</b>
			//       Has +2 Attack while damaged.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_185", new CardDef(new Power
			{
				// TODO [ULD_185] Temple Berserker && Test: Temple Berserker_ULD_185
				InfoCardId = "ULD_185e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_188] Golden Scarab - COST:3 [ATK:2/HP:2]
			// - Race: beast, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b><b>Battlecry:</b> Discover</b> a
			//       4-Cost card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("ULD_188", new CardDef(new Power
			{
				// TODO [ULD_188] Golden Scarab && Test: Golden Scarab_ULD_188
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_189] Faceless Lurker - COST:5 [ATK:3/HP:3]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Double this minion's Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_189", new CardDef(new Power
			{
				// TODO [ULD_189] Faceless Lurker && Test: Faceless Lurker_ULD_189
				InfoCardId = "ULD_189e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_190] Pit Crocolisk - COST:8 [ATK:5/HP:6]
			// - Race: beast, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 5 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ULD_190", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [ULD_190] Pit Crocolisk && Test: Pit Crocolisk_ULD_190
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_191] Beaming Sidekick - COST:1 [ATK:1/HP:2]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ULD_191", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_191] Beaming Sidekick && Test: Beaming Sidekick_ULD_191
				InfoCardId = "ULD_191e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_193] Living Monument - COST:10 [ATK:10/HP:10]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_193", new CardDef(new Power
			{
				// TODO [ULD_193] Living Monument && Test: Living Monument_ULD_193
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_194] Wasteland Scorpid - COST:7 [ATK:3/HP:9]
			// - Race: beast, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ULD_194", new CardDef(new Power
			{
				// TODO [ULD_194] Wasteland Scorpid && Test: Wasteland Scorpid_ULD_194
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_196] Neferset Ritualist - COST:2 [ATK:2/HP:3]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore adjacent minions to full_Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_196", new CardDef(new Power
			{
				// TODO [ULD_196] Neferset Ritualist && Test: Neferset Ritualist_ULD_196
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_197] Quicksand Elemental - COST:2 [ATK:3/HP:2]
			// - Race: elemental, Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all enemy minions -2 Attack this_turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_197", new CardDef(new Power
			{
				// TODO [ULD_197] Quicksand Elemental && Test: Quicksand Elemental_ULD_197
				InfoCardId = "ULD_197e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_198] Conjured Mirage - COST:4 [ATK:3/HP:10]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       At the start of your turn, shuffle this minion into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_198", new CardDef(new Power
			{
				// TODO [ULD_198] Conjured Mirage && Test: Conjured Mirage_ULD_198
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_205] Candletaker - COST:3 [ATK:3/HP:2]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Reborn</b>
			// --------------------------------------------------------
			// GameTag:
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_205", new CardDef(new Power
			{
				// TODO [ULD_205] Candletaker && Test: Candletaker_ULD_205
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_208] Khartut Defender - COST:6 [ATK:3/HP:4]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>, <b>Reborn</b>
			//       <b>Deathrattle:</b> Restore #3
			//       Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_208", new CardDef(new Power
			{
				// TODO [ULD_208] Khartut Defender && Test: Khartut Defender_ULD_208
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_209] Vulpera Scoundrel - COST:3 [ATK:2/HP:3]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: <b>Discover</b> a spell or pick a mystery choice.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("ULD_209", new CardDef(new Power
			{
				// TODO [ULD_209] Vulpera Scoundrel && Test: Vulpera Scoundrel_ULD_209
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_214] Generous Mummy - COST:3 [ATK:5/HP:4]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Reborn</b>
			//       Your opponent's cards cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_214", new CardDef(new Power
			{
				// TODO [ULD_214] Generous Mummy && Test: Generous Mummy_ULD_214
				InfoCardId = "ULD_214e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_215] Wrapped Golem - COST:7 [ATK:7/HP:5]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Reborn</b>
			//       At the end of your turn,
			//       summon a 1/1 Scarab
			//       with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - REBORN = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_215", new CardDef(new Power
			{
				// TODO [ULD_215] Wrapped Golem && Test: Wrapped Golem_ULD_215
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_229] Mischief Maker - COST:3 [ATK:3/HP:3]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Swap the top card of your deck with your_opponent's.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_229", new CardDef(new Power
			{
				// TODO [ULD_229] Mischief Maker && Test: Mischief Maker_ULD_229
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_250] Infested Goblin - COST:3 [ATK:2/HP:3]
			// - Set: uldum, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Add two 1/1 Scarabs with <b>Taunt</b> to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ULD_250", new CardDef(new Power
			{
				// TODO [ULD_250] Infested Goblin && Test: Infested Goblin_ULD_250
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_271] Injured Tol'vir - COST:2 [ATK:2/HP:6]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Deal 3 damage to this minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_271", new CardDef(new Power
			{
				// TODO [ULD_271] Injured Tol'vir && Test: Injured Tol'vir_ULD_271
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_274] Wasteland Assassin - COST:5 [ATK:4/HP:2]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Reborn</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_274", new CardDef(new Power
			{
				// TODO [ULD_274] Wasteland Assassin && Test: Wasteland Assassin_ULD_274
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_275] Bone Wraith - COST:4 [ATK:2/HP:5]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Reborn</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_275", new CardDef(new Power
			{
				// TODO [ULD_275] Bone Wraith && Test: Bone Wraith_ULD_275
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_282] Jar Dealer - COST:1 [ATK:1/HP:1]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Add a random
			//       1-Cost minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ULD_282", new CardDef(new Power
			{
				// TODO [ULD_282] Jar Dealer && Test: Jar Dealer_ULD_282
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_289] Fishflinger - COST:2 [ATK:3/HP:2]
			// - Race: murloc, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a
			//       random Murloc to each player's_hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_289", new CardDef(new Power
			{
				// TODO [ULD_289] Fishflinger && Test: Fishflinger_ULD_289
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_290] History Buff - COST:3 [ATK:3/HP:4]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you play a minion, give a random minion in your hand +1/+1.
			// --------------------------------------------------------
			cards.Add("ULD_290", new CardDef(new Power
			{
				// TODO [ULD_290] History Buff && Test: History Buff_ULD_290
				InfoCardId = "ULD_290e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_304] King Phaoris - COST:10 [ATK:5/HP:5]
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> For each spell
			//       in your hand, summon a
			//       random minion of the
			//       same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_304", new CardDef(new Power
			{
				// TODO [ULD_304] King Phaoris && Test: King Phaoris_ULD_304
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_309] Dwarven Archaeologist - COST:2 [ATK:2/HP:3]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: After you <b>Discover</b> a card, reduce its cost by (1).
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("ULD_309", new CardDef(new Power
			{
				// TODO [ULD_309] Dwarven Archaeologist && Test: Dwarven Archaeologist_ULD_309
				InfoCardId = "ULD_309e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_450] Vilefiend - COST:2 [ATK:2/HP:2]
			// - Race: demon, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ULD_450", new CardDef(new Power
			{
				// TODO [ULD_450] Vilefiend && Test: Vilefiend_ULD_450
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_702] Mortuary Machine - COST:5 [ATK:8/HP:8]
			// - Race: mechanical, Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: After your opponent plays a minion, give it <b>Reborn</b>.
			// --------------------------------------------------------
			// RefTag:
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_702", new CardDef(new Power
			{
				// TODO [ULD_702] Mortuary Machine && Test: Mortuary Machine_ULD_702
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_703] Desert Obelisk - COST:5 [ATK:0/HP:5]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]If you control 3 of these
			//       at the end of your turn,
			//       deal 5 damage to a
			//       random enemy.
			// --------------------------------------------------------
			cards.Add("ULD_703", new CardDef(new Power
			{
				// TODO [ULD_703] Desert Obelisk && Test: Desert Obelisk_ULD_703
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_705] Mogu Cultist - COST:1 [ATK:1/HP:1]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your board is full of Mogu Cultists, sacrifice them all and summon Highkeeper Ra.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_705", new CardDef(new Power
			{
				// TODO [ULD_705] Mogu Cultist && Test: Mogu Cultist_ULD_705
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_706] Blatant Decoy - COST:6 [ATK:5/HP:5]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Each player
			//       summons the lowest Cost
			//       minion from their hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ULD_706", new CardDef(new Power
			{
				// TODO [ULD_706] Blatant Decoy && Test: Blatant Decoy_ULD_706
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_712] Bug Collector - COST:2 [ATK:2/HP:1]
			// - Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 1/1 Locust with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ULD_712", new CardDef(new Power
			{
				// TODO [ULD_712] Bug Collector && Test: Bug Collector_ULD_712
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_719] Desert Hare - COST:3 [ATK:1/HP:1]
			// - Race: beast, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/1 Desert Hares.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ULD_719", new CardDef(new Power
			{
				// TODO [ULD_719] Desert Hare && Test: Desert Hare_ULD_719
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_721] Colossus of the Moon - COST:10 [ATK:10/HP:10]
			// - Set: uldum, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			//       <b>Reborn</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DIVINE_SHIELD = 1
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_721", new CardDef(new Power
			{
				// TODO [ULD_721] Colossus of the Moon && Test: Colossus of the Moon_ULD_721
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_723] Murmy - COST:1 [ATK:1/HP:1]
			// - Race: murloc, Set: uldum, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Reborn</b>
			// --------------------------------------------------------
			// GameTag:
			// - REBORN = 1
			// --------------------------------------------------------
			cards.Add("ULD_723", new CardDef(new Power
			{
				// TODO [ULD_723] Murmy && Test: Murmy_ULD_723
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_727] Body Wrapper - COST:4 [ATK:4/HP:4]
			// - Set: uldum, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a friendly minion that died this game. Shuffle it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("ULD_727", new CardDef(new Power
			{
				// TODO [ULD_727] Body Wrapper && Test: Body Wrapper_ULD_727
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_179e] Commanded (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Phalanx Commander is granting this +2 Attack.
			// --------------------------------------------------------
			cards.Add("ULD_179e", new CardDef(new Power
			{
				// TODO [ULD_179e] Commanded && Test: Commanded_ULD_179e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_179e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_183e] Anubisath Power (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("ULD_183e", new CardDef(new Power
			{
				// TODO [ULD_183e] Anubisath Power && Test: Anubisath Power_ULD_183e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_183e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_185e] Enraged (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("ULD_185e", new CardDef(new Power
			{
				// TODO [ULD_185e] Enraged && Test: Enraged_ULD_185e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_185e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_189e] Bravery (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Doubled Health.
			// --------------------------------------------------------
			cards.Add("ULD_189e", new CardDef(new Power
			{
				// TODO [ULD_189e] Bravery && Test: Bravery_ULD_189e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_189e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_191e] Assisting! (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("ULD_191e", new CardDef(new Power
			{
				// TODO [ULD_191e] Assisting! && Test: Assisting!_ULD_191e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_191e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_197e] Stuck! (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: -2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("ULD_197e", new CardDef(new Power
			{
				// TODO [ULD_197e] Stuck! && Test: Stuck!_ULD_197e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_197e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_214e] Charity (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("ULD_214e", new CardDef(new Power
			{
				// TODO [ULD_214e] Charity && Test: Charity_ULD_214e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_214e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_217e] Microwrapped (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Attack increased.
			// --------------------------------------------------------
			cards.Add("ULD_217e", new CardDef(new Power
			{
				// TODO [ULD_217e] Microwrapped && Test: Microwrapped_ULD_217e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_217e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_256e] Frayed (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: +2/+2 from Into the Fray.
			// --------------------------------------------------------
			cards.Add("ULD_256e", new CardDef(new Power
			{
				// TODO [ULD_256e] Frayed && Test: Frayed_ULD_256e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_256e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_258e] Tough (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Increased stats from Armagedillo.
			// --------------------------------------------------------
			cards.Add("ULD_258e", new CardDef(new Power
			{
				// TODO [ULD_258e] Tough && Test: Tough_ULD_258e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_258e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_290e] Erudite (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Increased stats from History Buff.
			// --------------------------------------------------------
			cards.Add("ULD_290e", new CardDef(new Power
			{
				// TODO [ULD_290e] Erudite && Test: Erudite_ULD_290e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_290e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_291pe] Heart of Vir'naal (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Your <b>Battlecries</b> trigger twice this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("ULD_291pe", new CardDef(new Power
			{
				// TODO [ULD_291pe] Heart of Vir'naal && Test: Heart of Vir'naal_ULD_291pe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_291pe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_309e] Archaelogical Study (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("ULD_309e", new CardDef(new Power
			{
				// TODO [ULD_309e] Archaelogical Study && Test: Archaelogical Study_ULD_309e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_309e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_616e] Hardened (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ULD_616e", new CardDef(new Power
			{
				// TODO [ULD_616e] Hardened && Test: Hardened_ULD_616e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_616e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ULD_728e] Subdued (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("ULD_728e", new CardDef(new Power
			{
				// TODO [ULD_728e] Subdued && Test: Subdued_ULD_728e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("ULD_728e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_174t] Sea Serpent (*) - COST:3 [ATK:3/HP:4]
			// - Race: beast, Set: uldum,
			// --------------------------------------------------------
			cards.Add("ULD_174t", new CardDef(new Power
			{
				// TODO [ULD_174t] Sea Serpent && Test: Sea Serpent_ULD_174t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_215t] Scarab (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_215t", new CardDef(new Power
			{
				// TODO [ULD_215t] Scarab && Test: Scarab_ULD_215t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_430t] Locust (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ULD_430t", new CardDef(new Power
			{
				// TODO [ULD_430t] Locust && Test: Locust_ULD_430t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_616] Titanic Lackey (*) - COST:1 [ATK:1/HP:1]
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +2 Health and_<b>Taunt</b>.
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
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_616", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [ULD_616] Titanic Lackey && Test: Titanic Lackey_ULD_616
				InfoCardId = "ULD_616e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ULD_705t] Highkeeper Ra (*) - COST:10 [ATK:20/HP:20]
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 20 damage to all_enemies.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ULD_705t", new CardDef(new Power
			{
				// TODO [ULD_705t] Highkeeper Ra && Test: Highkeeper Ra_ULD_705t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [ULD_178a] Siamat's Wind (*) - COST:0
			// - Fac: neutral, Set: uldum,
			// --------------------------------------------------------
			// Text: Give Siamat <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("ULD_178a", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_178a] Siamat's Wind && Test: Siamat's Wind_ULD_178a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [ULD_178a2] Siamat's Shield (*) - COST:0
			// - Fac: neutral, Set: uldum,
			// --------------------------------------------------------
			// Text: Give Siamat
			//       <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ULD_178a2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_178a2] Siamat's Shield && Test: Siamat's Shield_ULD_178a2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [ULD_178a3] Siamat's Heart (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Give Siamat <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ULD_178a3", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [ULD_178a3] Siamat's Heart && Test: Siamat's Heart_ULD_178a3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [ULD_178a4] Siamat's Speed (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Give Siamat <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ULD_178a4", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [ULD_178a4] Siamat's Speed && Test: Siamat's Speed_ULD_178a4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [ULD_209t] Mystery Choice! (*) - COST:0
			// - Set: uldum,
			// --------------------------------------------------------
			// Text: Add a random spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("ULD_209t", new CardDef(new Power
			{
				// TODO [ULD_209t] Mystery Choice! && Test: Mystery Choice!_ULD_209t
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
		{
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
