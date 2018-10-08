using System.Collections.Generic;
using SabberStoneCore.Enchants;

namespace SabberStoneCore.CardSets.Adventure
{
	public class TgtCardsGenAdv
	{
		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ------------------------------------ HERO_POWER - SHAMAN
			// [AT_050t] Lightning Jolt (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_050t", new Power {
				// TODO [AT_050t] Lightning Jolt && Test: Lightning Jolt_AT_050t
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- HERO_POWER - DRUID
			// [AT_132_DRUID] Dire Shapeshift (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 2 Armor and +2 Attack this turn.
			// --------------------------------------------------------
			cards.Add("AT_132_DRUID", new Power {
				// TODO [AT_132_DRUID] Dire Shapeshift && Test: Dire Shapeshift_AT_132_DRUID
				InfoCardId = "AT_132_DRUIDe",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ HERO_POWER - HUNTER
			// [AT_132_HUNTER] Ballista Shot (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $3 damage to the enemy hero. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_STEADY_SHOT = 0
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("AT_132_HUNTER", new Power {
				// TODO [AT_132_HUNTER] Ballista Shot && Test: Ballista Shot_AT_132_HUNTER
				//PowerTask = null,
				//Trigger = null,
			});

			// -------------------------------------- HERO_POWER - MAGE
			// [AT_132_MAGE] Fireblast Rank 2 (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_132_MAGE", new Power {
				// TODO [AT_132_MAGE] Fireblast Rank 2 && Test: Fireblast Rank 2_AT_132_MAGE
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - PALADIN
			// [AT_132_PALADIN] The Silver Hand (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon two 1/1 Recruits.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("AT_132_PALADIN", new Power {
				// TODO [AT_132_PALADIN] The Silver Hand && Test: The Silver Hand_AT_132_PALADIN
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ HERO_POWER - PRIEST
			// [AT_132_PRIEST] Heal (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Restore #4 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_132_PRIEST", new Power {
				// TODO [AT_132_PRIEST] Heal && Test: Heal_AT_132_PRIEST
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- HERO_POWER - ROGUE
			// [AT_132_ROGUE] Poisoned Daggers (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Equip a 2/2 Weapon.
			// --------------------------------------------------------
			cards.Add("AT_132_ROGUE", new Power {
				// TODO [AT_132_ROGUE] Poisoned Daggers && Test: Poisoned Daggers_AT_132_ROGUE
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ HERO_POWER - SHAMAN
			// [AT_132_SHAMAN] Totemic Slam (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a Totem of your choice.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("AT_132_SHAMAN", new Power {
				// TODO [AT_132_SHAMAN] Totemic Slam && Test: Totemic Slam_AT_132_SHAMAN
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - WARLOCK
			// [AT_132_WARLOCK] Soul Tap (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw a card.
			// --------------------------------------------------------
			cards.Add("AT_132_WARLOCK", new Power {
				// TODO [AT_132_WARLOCK] Soul Tap && Test: Soul Tap_AT_132_WARLOCK
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - WARRIOR
			// [AT_132_WARRIOR] Tank Up! (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 4 Armor.
			// --------------------------------------------------------
			cards.Add("AT_132_WARRIOR", new Power {
				// TODO [AT_132_WARRIOR] Tank Up! && Test: Tank Up!_AT_132_WARRIOR
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [AT_038] Darnassus Aspirant - COST:2 [ATK:2/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain an empty Mana Crystal.
			//       <b>Deathrattle:</b> Lose a Mana Crystal.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_038", new Power {
				// TODO [AT_038] Darnassus Aspirant && Test: Darnassus Aspirant_AT_038
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_039] Savage Combatant - COST:4 [ATK:5/HP:4] 
			// - Race: beast, Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Give your hero
			//       +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_039", new Power {
				// TODO [AT_039] Savage Combatant && Test: Savage Combatant_AT_039
				InfoCardId = "AT_039e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_040] Wildwalker - COST:4 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Beast +3 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 20
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("AT_040", new Power {
				// TODO [AT_040] Wildwalker && Test: Wildwalker_AT_040
				InfoCardId = "AT_040e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_041] Knight of the Wild - COST:7 [ATK:6/HP:6] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you summon a Beast, reduce the Cost of this card by (1).
			// --------------------------------------------------------
			cards.Add("AT_041", new Power {
				// TODO [AT_041] Knight of the Wild && Test: Knight of the Wild_AT_041
				InfoCardId = "AT_041e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_042] Druid of the Saber - COST:2 [ATK:2/HP:1] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Choose One -</b> Transform
			//       into a 2/1 with <b>Charge</b>;
			//       or a 3/2 with <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_042", new Power {
				// TODO [AT_042] Druid of the Saber && Test: Druid of the Saber_AT_042
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_045] Aviana - COST:9 [ATK:5/HP:5] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your minions cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("AT_045", new Power {
				// TODO [AT_045] Aviana && Test: Aviana_AT_045
				InfoCardId = "AT_045e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_037] Living Roots - COST:1 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Deal $2 damage; or Summon two 1/1 Saplings. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_037", new Power {
				// TODO [AT_037] Living Roots && Test: Living Roots_AT_037
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_043] Astral Communion - COST:4 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Gain 10 Mana Crystals. Discard your hand.
			// --------------------------------------------------------
			// GameTag:
			// - 890 = 10
			// --------------------------------------------------------
			cards.Add("AT_043", new Power {
				// TODO [AT_043] Astral Communion && Test: Astral Communion_AT_043
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_044] Mulch - COST:3 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion.
			//       Add a random minion to your opponent's hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("AT_044", new Power {
				// TODO [AT_044] Mulch && Test: Mulch_AT_044
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [AT_039e] Savage (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("AT_039e", new Power {
				// TODO [AT_039e] Savage && Test: Savage_AT_039e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [AT_040e] Kindred Spirit (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("AT_040e", new Power {
				// TODO [AT_040e] Kindred Spirit && Test: Kindred Spirit_AT_040e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [AT_132_DRUIDe] Dire Claws (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("AT_132_DRUIDe", new Power {
				// TODO [AT_132_DRUIDe] Dire Claws && Test: Dire Claws_AT_132_DRUIDe
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_037t] Sapling (*) - COST:1 [ATK:1/HP:1] 
			// - Set: tgt, 
			// --------------------------------------------------------
			cards.Add("AT_037t", new Power {
				// TODO [AT_037t] Sapling && Test: Sapling_AT_037t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_042t] Sabertooth Lion (*) - COST:2 [ATK:2/HP:1] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_042t", new Power {
				// TODO [AT_042t] Sabertooth Lion && Test: Sabertooth Lion_AT_042t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_042t2] Sabertooth Panther (*) - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("AT_042t2", new Power {
				// TODO [AT_042t2] Sabertooth Panther && Test: Sabertooth Panther_AT_042t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [OG_044c] Sabertooth Tiger (*) - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge, Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("OG_044c", new Power {
				// TODO [OG_044c] Sabertooth Tiger && Test: Sabertooth Tiger_OG_044c
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_037a] Living Roots (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_037a", new Power {
				// TODO [AT_037a] Living Roots && Test: Living Roots_AT_037a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_037b] Living Roots (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Summon two 1/1 Saplings.
			// --------------------------------------------------------
			cards.Add("AT_037b", new Power {
				// TODO [AT_037b] Living Roots && Test: Living Roots_AT_037b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_042a] Lion Form (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			cards.Add("AT_042a", new Power {
				// TODO [AT_042a] Lion Form && Test: Lion Form_AT_042a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_042b] Panther Form (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Stealth</b>
			// --------------------------------------------------------
			cards.Add("AT_042b", new Power {
				// TODO [AT_042b] Panther Form && Test: Panther Form_AT_042b
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [AT_010] Ram Wrangler - COST:5 [ATK:3/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a Beast, summon a
			//       random Beast.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_010", new Power {
				// TODO [AT_010] Ram Wrangler && Test: Ram Wrangler_AT_010
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [AT_057] Stablemaster - COST:3 [ATK:4/HP:2] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Beast <b>Immune</b> this turn.
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
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("AT_057", new Power {
				// TODO [AT_057] Stablemaster && Test: Stablemaster_AT_057
				InfoCardId = "AT_057o",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [AT_058] King's Elekk - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, draw it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_058", new Power {
				// TODO [AT_058] King's Elekk && Test: King's Elekk_AT_058
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [AT_059] Brave Archer - COST:1 [ATK:2/HP:1] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> If your hand is empty, deal 2 damage to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_059", new Power {
				// TODO [AT_059] Brave Archer && Test: Brave Archer_AT_059
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [AT_063] Acidmaw - COST:7 [ATK:4/HP:2] 
			// - Race: beast, Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever another minion takes damage, destroy it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("AT_063", new Power {
				// TODO [AT_063] Acidmaw && Test: Acidmaw_AT_063
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [AT_063t] Dreadscale - COST:3 [ATK:4/HP:2] 
			// - Race: beast, Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 1 damage to all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("AT_063t", new Power {
				// TODO [AT_063t] Dreadscale && Test: Dreadscale_AT_063t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [AT_056] Powershot - COST:3 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion and the minions next to it. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("AT_056", new Power {
				// TODO [AT_056] Powershot && Test: Powershot_AT_056
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [AT_060] Bear Trap - COST:2 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your hero is attacked, summon a 3/3 Bear with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_060", new Power {
				// TODO [AT_060] Bear Trap && Test: Bear Trap_AT_060
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [AT_061] Lock and Load - COST:2 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Each time you cast a spell this turn, add a random Hunter card to your hand.
			// --------------------------------------------------------
			cards.Add("AT_061", new Power {
				// TODO [AT_061] Lock and Load && Test: Lock and Load_AT_061
				InfoCardId = "AT_061e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [AT_062] Ball of Spiders - COST:6 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon three 1/1 Webspinners.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("AT_062", new Power {
				// TODO [AT_062] Ball of Spiders && Test: Ball of Spiders_AT_062
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [AT_057o] Groomed (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("AT_057o", new Power {
				// TODO [AT_057o] Groomed && Test: Groomed_AT_057o
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [AT_061e] Lock and Load (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("AT_061e", new Power {
				// TODO [AT_061e] Lock and Load && Test: Lock and Load_AT_061e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [AT_003] Fallen Hero - COST:2 [ATK:3/HP:2] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Your Hero Power deals 1 extra damage.
			// --------------------------------------------------------
			// GameTag:
			// - HEROPOWER_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("AT_003", new Power {
				// TODO [AT_003] Fallen Hero && Test: Fallen Hero_AT_003
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [AT_006] Dalaran Aspirant - COST:4 [ATK:3/HP:5] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Gain <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("AT_006", new Power {
				// TODO [AT_006] Dalaran Aspirant && Test: Dalaran Aspirant_AT_006
				InfoCardId = "AT_006e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [AT_007] Spellslinger - COST:3 [ATK:3/HP:4] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random spell to each player's hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_007", new Power {
				// TODO [AT_007] Spellslinger && Test: Spellslinger_AT_007
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [AT_008] Coldarra Drake - COST:6 [ATK:6/HP:6] 
			// - Race: dragon, Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: You can use your Hero Power any number of times.
			// --------------------------------------------------------
			cards.Add("AT_008", new Power {
				// TODO [AT_008] Coldarra Drake && Test: Coldarra Drake_AT_008
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [AT_009] Rhonin - COST:8 [ATK:7/HP:7] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add 3 copies of Arcane Missiles to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("AT_009", new Power {
				// TODO [AT_009] Rhonin && Test: Rhonin_AT_009
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [AT_001] Flame Lance - COST:5 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $8 damage to a minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("AT_001", new Power {
				// TODO [AT_001] Flame Lance && Test: Flame Lance_AT_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [AT_002] Effigy - COST:3 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a friendly minion dies, summon a random minion with the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("AT_002", new Power {
				// TODO [AT_002] Effigy && Test: Effigy_AT_002
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [AT_004] Arcane Blast - COST:1 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. This spell gets double bonus from <b>Spell Damage</b>. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - RECEIVES_DOUBLE_SPELLDAMAGE_BONUS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("AT_004", new Power {
				// TODO [AT_004] Arcane Blast && Test: Arcane Blast_AT_004
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [AT_005] Polymorph: Boar - COST:3 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Transform a minion into a 4/2 Boar with <b>Charge</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_005", new Power {
				// TODO [AT_005] Polymorph: Boar && Test: Polymorph: Boar_AT_005
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [AT_006e] Power of Dalaran (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Spell Damage.
			// --------------------------------------------------------
			cards.Add("AT_006e", new Power {
				// TODO [AT_006e] Power of Dalaran && Test: Power of Dalaran_AT_006e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [AT_075] Warhorse Trainer - COST:3 [ATK:2/HP:4] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Your Silver Hand Recruits have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("AT_075", new Power {
				// TODO [AT_075] Warhorse Trainer && Test: Warhorse Trainer_AT_075
				InfoCardId = "AT_075e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [AT_076] Murloc Knight - COST:4 [ATK:3/HP:4] 
			// - Race: murloc, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Summon a random Murloc.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_076", new Power {
				// TODO [AT_076] Murloc Knight && Test: Murloc Knight_AT_076
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [AT_079] Mysterious Challenger - COST:6 [ATK:6/HP:6] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Put one of each <b>Secret</b> from your deck into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("AT_079", new Power {
				// TODO [AT_079] Mysterious Challenger && Test: Mysterious Challenger_AT_079
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [AT_081] Eadric the Pure - COST:7 [ATK:3/HP:7] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Change all enemy minions'
			//       Attack to 1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_081", new Power {
				// TODO [AT_081] Eadric the Pure && Test: Eadric the Pure_AT_081
				InfoCardId = "AT_081e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [AT_104] Tuskarr Jouster - COST:5 [ATK:5/HP:5] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, restore 7 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_104", new Power {
				// TODO [AT_104] Tuskarr Jouster && Test: Tuskarr Jouster_AT_104
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [AT_073] Competitive Spirit - COST:1 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your turn starts, give your minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("AT_073", new Power {
				// TODO [AT_073] Competitive Spirit && Test: Competitive Spirit_AT_073
				InfoCardId = "AT_073e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [AT_074] Seal of Champions - COST:3 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion
			//       +3 Attack and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("AT_074", new Power {
				// TODO [AT_074] Seal of Champions && Test: Seal of Champions_AT_074
				InfoCardId = "AT_074e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [AT_078] Enter the Coliseum - COST:6 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all minions except each player's highest Attack minion.
			// --------------------------------------------------------
			cards.Add("AT_078", new Power {
				// TODO [AT_078] Enter the Coliseum && Test: Enter the Coliseum_AT_078
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [AT_077] Argent Lance - COST:2 [ATK:2/HP:0] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_077", new Power {
				// TODO [AT_077] Argent Lance && Test: Argent Lance_AT_077
				InfoCardId = "AT_077e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [AT_074e2] Seal of Champions (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +3 Attack and <b>Divine Shield</b>.
			// --------------------------------------------------------
			cards.Add("AT_074e2", new Power {
				// TODO [AT_074e2] Seal of Champions && Test: Seal of Champions_AT_074e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [AT_075e] Might of the Hostler (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Warhorse Trainer is granting this minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("AT_075e", new Power {
				// TODO [AT_075e] Might of the Hostler && Test: Might of the Hostler_AT_075e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [AT_081e] Purified (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Attack changed to 1.
			// --------------------------------------------------------
			cards.Add("AT_081e", new Power {
				// TODO [AT_081e] Purified && Test: Purified_AT_081e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [AT_011] Holy Champion - COST:4 [ATK:3/HP:5] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever a character is healed, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("AT_011", new Power {
				// TODO [AT_011] Holy Champion && Test: Holy Champion_AT_011
				InfoCardId = "AT_011e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [AT_012] Spawn of Shadows - COST:4 [ATK:5/HP:4] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Deal 4 damage to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_012", new Power {
				// TODO [AT_012] Spawn of Shadows && Test: Spawn of Shadows_AT_012
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [AT_014] Shadowfiend - COST:3 [ATK:3/HP:3] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you draw a card, reduce its Cost by (1).
			// --------------------------------------------------------
			cards.Add("AT_014", new Power {
				// TODO [AT_014] Shadowfiend && Test: Shadowfiend_AT_014
				InfoCardId = "AT_014e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [AT_018] Confessor Paletress - COST:7 [ATK:5/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Summon a random <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_018", new Power {
				// TODO [AT_018] Confessor Paletress && Test: Confessor Paletress_AT_018
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [AT_116] Wyrmrest Agent - COST:2 [ATK:1/HP:4] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_116", new Power {
				// TODO [AT_116] Wyrmrest Agent && Test: Wyrmrest Agent_AT_116
				InfoCardId = "AT_116e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [AT_013] Power Word: Glory - COST:1 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Choose a minion. Whenever it attacks, restore 4 Health to
			//       your hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_013", new Power {
				// TODO [AT_013] Power Word: Glory && Test: Power Word: Glory_AT_013
				InfoCardId = "AT_013e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [AT_015] Convert - COST:2 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Put a copy of an enemy minion into your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("AT_015", new Power {
				// TODO [AT_015] Convert && Test: Convert_AT_015
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [AT_016] Confuse - COST:2 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Swap the Attack and Health of all minions.
			// --------------------------------------------------------
			cards.Add("AT_016", new Power {
				// TODO [AT_016] Confuse && Test: Confuse_AT_016
				InfoCardId = "AT_016e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [AT_055] Flash Heal - COST:1 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #5 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_055", new Power {
				// TODO [AT_055] Flash Heal && Test: Flash Heal_AT_055
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [AT_014e] Shadowfiended (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("AT_014e", new Power {
				// TODO [AT_014e] Shadowfiended && Test: Shadowfiended_AT_014e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [AT_016e] Confused (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Swapped Attack and Health.
			// --------------------------------------------------------
			cards.Add("AT_016e", new Power {
				// TODO [AT_016e] Confused && Test: Confused_AT_016e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [AT_116e] Bring it on! (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("AT_116e", new Power {
				// TODO [AT_116e] Bring it on! && Test: Bring it on!_AT_116e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [AT_028] Shado-Pan Rider - COST:5 [ATK:3/HP:7] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Gain +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("AT_028", new Power {
				// TODO [AT_028] Shado-Pan Rider && Test: Shado-Pan Rider_AT_028
				InfoCardId = "AT_028e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_029] Buccaneer - COST:1 [ATK:2/HP:1] 
			// - Race: pirate, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you equip a weapon, give it +1 Attack.
			// --------------------------------------------------------
			cards.Add("AT_029", new Power {
				// TODO [AT_029] Buccaneer && Test: Buccaneer_AT_029
				InfoCardId = "AT_029e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_030] Undercity Valiant - COST:2 [ATK:3/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Deal 1 damage.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_FOR_COMBO = 0
			// --------------------------------------------------------
			cards.Add("AT_030", new Power {
				// TODO [AT_030] Undercity Valiant && Test: Undercity Valiant_AT_030
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_031] Cutpurse - COST:2 [ATK:2/HP:2] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever this minion attacks a hero, add the Coin to your hand.
			// --------------------------------------------------------
			cards.Add("AT_031", new Power {
				// TODO [AT_031] Cutpurse && Test: Cutpurse_AT_031
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_032] Shady Dealer - COST:3 [ATK:4/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a Pirate, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_032", new Power {
				// TODO [AT_032] Shady Dealer && Test: Shady Dealer_AT_032
				InfoCardId = "AT_032e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_036] Anub'arak - COST:9 [ATK:8/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return this to your hand and summon a 4/4 Nerubian.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("AT_036", new Power {
				// TODO [AT_036] Anub'arak && Test: Anub'arak_AT_036
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [AT_033] Burgle - COST:3 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Add 2 random class cards to your hand <i>(from your opponent's class)</i>.
			// --------------------------------------------------------
			cards.Add("AT_033", new Power {
				// TODO [AT_033] Burgle && Test: Burgle_AT_033
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [AT_035] Beneath the Grounds - COST:3 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle 3 Ambushes into your opponent's deck. When drawn, you summon a 4/4 Nerubian.
			// --------------------------------------------------------
			cards.Add("AT_035", new Power {
				// TODO [AT_035] Beneath the Grounds && Test: Beneath the Grounds_AT_035
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [AT_034] Poisoned Blade - COST:4 [ATK:1/HP:0] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Your Hero Power gives this weapon +1 Attack instead of replacing it.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("AT_034", new Power {
				// TODO [AT_034] Poisoned Blade && Test: Poisoned Blade_AT_034
				InfoCardId = "AT_034e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [AT_032e] Shady Deals (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_032e", new Power {
				// TODO [AT_032e] Shady Deals && Test: Shady Deals_AT_032e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [AT_034e] Laced (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("AT_034e", new Power {
				// TODO [AT_034e] Laced && Test: Laced_AT_034e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_036t] Nerubian (*) - COST:4 [ATK:4/HP:4] 
			// - Set: tgt, 
			// --------------------------------------------------------
			cards.Add("AT_036t", new Power {
				// TODO [AT_036t] Nerubian && Test: Nerubian_AT_036t
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [AT_035t] Nerubian Ambush! (*) - COST:3 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Summon a 4/4 Nerubian for your opponent. Draw a card. Cast this when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("AT_035t", new Power {
				// TODO [AT_035t] Nerubian Ambush! && Test: Nerubian Ambush!_AT_035t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [AT_132_ROGUEt] Poisoned Dagger (*) - COST:1 [ATK:2/HP:0] 
			// - Set: tgt, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("AT_132_ROGUEt", new Power {
				// TODO [AT_132_ROGUEt] Poisoned Dagger && Test: Poisoned Dagger_AT_132_ROGUEt
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [AT_046] Tuskarr Totemic - COST:3 [ATK:3/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a random basic Totem.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_046", new Power {
				// TODO [AT_046] Tuskarr Totemic && Test: Tuskarr Totemic_AT_046
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_047] Draenei Totemcarver - COST:4 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1/+1 for each friendly Totem.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_047", new Power {
				// TODO [AT_047] Draenei Totemcarver && Test: Draenei Totemcarver_AT_047
				InfoCardId = "AT_047e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_049] Thunder Bluff Valiant - COST:5 [ATK:3/HP:6] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Give your Totems +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_049", new Power {
				// TODO [AT_049] Thunder Bluff Valiant && Test: Thunder Bluff Valiant_AT_049
				InfoCardId = "AT_049e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_052] Totem Golem - COST:2 [ATK:3/HP:4] 
			// - Race: totem, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			cards.Add("AT_052", new Power {
				// TODO [AT_052] Totem Golem && Test: Totem Golem_AT_052
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_054] The Mistcaller - COST:6 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all minions in your hand and deck +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_054", new Power {
				// TODO [AT_054] The Mistcaller && Test: The Mistcaller_AT_054
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [AT_048] Healing Wave - COST:3 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Restore #7 Health. Reveal a minion in each deck. If yours costs more, Restore #14 instead.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_048", new Power {
				// TODO [AT_048] Healing Wave && Test: Healing Wave_AT_048
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [AT_051] Elemental Destruction - COST:3 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $4-$5 damage to all minions. <b>Overload:</b> (5) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD_OWED = 5
			// --------------------------------------------------------
			cards.Add("AT_051", new Power {
				// TODO [AT_051] Elemental Destruction && Test: Elemental Destruction_AT_051
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [AT_053] Ancestral Knowledge - COST:2 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 cards. <b>Overload:</b> (2)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			cards.Add("AT_053", new Power {
				// TODO [AT_053] Ancestral Knowledge && Test: Ancestral Knowledge_AT_053
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [AT_050] Charged Hammer - COST:4 [ATK:2/HP:0] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Your Hero Power becomes 'Deal 2 damage.'
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("AT_050", new Power {
				// TODO [AT_050] Charged Hammer && Test: Charged Hammer_AT_050
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [AT_047e] Experienced (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("AT_047e", new Power {
				// TODO [AT_047e] Experienced && Test: Experienced_AT_047e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [AT_049e] Power of the Bluff (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("AT_049e", new Power {
				// TODO [AT_049e] Power of the Bluff && Test: Power of the Bluff_AT_049e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_132_SHAMANa] Healing Totem (*) - COST:0 [ATK:0/HP:2] 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 1 Health to all friendly minions.
			// --------------------------------------------------------
			cards.Add("AT_132_SHAMANa", new Power {
				// TODO [AT_132_SHAMANa] Healing Totem && Test: Healing Totem_AT_132_SHAMANa
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_132_SHAMANb] Searing Totem (*) - COST:0 [ATK:1/HP:1] 
			// - Set: tgt, 
			// --------------------------------------------------------
			cards.Add("AT_132_SHAMANb", new Power {
				// TODO [AT_132_SHAMANb] Searing Totem && Test: Searing Totem_AT_132_SHAMANb
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_132_SHAMANc] Stoneclaw Totem (*) - COST:0 [ATK:0/HP:2] 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			cards.Add("AT_132_SHAMANc", new Power {
				// TODO [AT_132_SHAMANc] Stoneclaw Totem && Test: Stoneclaw Totem_AT_132_SHAMANc
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_132_SHAMANd] Wrath of Air Totem (*) - COST:0 [ATK:0/HP:2] 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			cards.Add("AT_132_SHAMANd", new Power {
				// TODO [AT_132_SHAMANd] Wrath of Air Totem && Test: Wrath of Air Totem_AT_132_SHAMANd
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [AT_019] Dreadsteed - COST:4 [ATK:1/HP:1] 
			// - Race: demon, Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> At the end
			//        of the turn, summon a Dreadsteed.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("AT_019", new Power {
				// TODO [AT_019] Dreadsteed && Test: Dreadsteed_AT_019
				InfoCardId = "AT_019e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_020] Fearsome Doomguard - COST:7 [ATK:6/HP:8] 
			// - Race: demon, Set: tgt, Rarity: common
			// --------------------------------------------------------
			cards.Add("AT_020", new Power {
				// TODO [AT_020] Fearsome Doomguard && Test: Fearsome Doomguard_AT_020
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_021] Tiny Knight of Evil - COST:2 [ATK:3/HP:2] 
			// - Race: demon, Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you discard a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_021", new Power {
				// TODO [AT_021] Tiny Knight of Evil && Test: Tiny Knight of Evil_AT_021
				InfoCardId = "AT_021e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_023] Void Crusher - COST:6 [ATK:5/HP:4] 
			// - Race: demon, Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Destroy a random minion for each player.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_023", new Power {
				// TODO [AT_023] Void Crusher && Test: Void Crusher_AT_023
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_026] Wrathguard - COST:2 [ATK:4/HP:3] 
			// - Race: demon, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, also deal that amount to your hero.
			// --------------------------------------------------------
			cards.Add("AT_026", new Power {
				// TODO [AT_026] Wrathguard && Test: Wrathguard_AT_026
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_027] Wilfred Fizzlebang - COST:6 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Cards you draw from your Hero Power cost (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("AT_027", new Power {
				// TODO [AT_027] Wilfred Fizzlebang && Test: Wilfred Fizzlebang_AT_027
				InfoCardId = "AT_027e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [AT_022] Fist of Jaraxxus - COST:4 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: When you play or discard this, deal $4 damage to a random enemy. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("AT_022", new Power {
				// TODO [AT_022] Fist of Jaraxxus && Test: Fist of Jaraxxus_AT_022
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [AT_024] Demonfuse - COST:2 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Give a Demon +3/+3. Give your opponent a Mana Crystal.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 15
			// --------------------------------------------------------
			cards.Add("AT_024", new Power {
				// TODO [AT_024] Demonfuse && Test: Demonfuse_AT_024
				InfoCardId = "AT_024e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [AT_025] Dark Bargain - COST:6 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy 2 random enemy minions. Discard 2 random cards.
			// --------------------------------------------------------
			// GameTag:
			// - 890 = 2
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("AT_025", new Power {
				// TODO [AT_025] Dark Bargain && Test: Dark Bargain_AT_025
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [AT_021e] Felrage (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("AT_021e", new Power {
				// TODO [AT_021e] Felrage && Test: Felrage_AT_021e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [AT_027e] Master Summoner (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			cards.Add("AT_027e", new Power {
				// TODO [AT_027e] Master Summoner && Test: Master Summoner_AT_027e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [AT_066] Orgrimmar Aspirant - COST:3 [ATK:3/HP:3] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Give your weapon +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_066", new Power {
				// TODO [AT_066] Orgrimmar Aspirant && Test: Orgrimmar Aspirant_AT_066
				InfoCardId = "AT_066e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [AT_067] Magnataur Alpha - COST:4 [ATK:5/HP:3] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever
			//       he attacks.
			// --------------------------------------------------------
			cards.Add("AT_067", new Power {
				// TODO [AT_067] Magnataur Alpha && Test: Magnataur Alpha_AT_067
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [AT_069] Sparring Partner - COST:2 [ATK:3/HP:2] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Give a
			//       minion <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("AT_069", new Power {
				// TODO [AT_069] Sparring Partner && Test: Sparring Partner_AT_069
				InfoCardId = "AT_069e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [AT_071] Alexstrasza's Champion - COST:2 [ATK:2/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_071", new Power {
				// TODO [AT_071] Alexstrasza's Champion && Test: Alexstrasza's Champion_AT_071
				InfoCardId = "AT_071e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [AT_072] Varian Wrynn - COST:10 [ATK:7/HP:7] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw 3 cards.
			//       Put any minions you drew directly into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_072", new Power {
				// TODO [AT_072] Varian Wrynn && Test: Varian Wrynn_AT_072
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [AT_130] Sea Reaver - COST:6 [ATK:6/HP:7] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: When you draw this, deal 1 damage to your minions.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("AT_130", new Power {
				// TODO [AT_130] Sea Reaver && Test: Sea Reaver_AT_130
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [AT_064] Bash - COST:3 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage.
			//       Gain 3 Armor. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_064", new Power {
				// TODO [AT_064] Bash && Test: Bash_AT_064
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [AT_068] Bolster - COST:2 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Give your <b>Taunt</b> minions +2/+2.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_068", new Power {
				// TODO [AT_068] Bolster && Test: Bolster_AT_068
				InfoCardId = "AT_068e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [AT_065] King's Defender - COST:3 [ATK:3/HP:0] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a minion with <b>Taunt</b>, gain +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_065", new Power {
				// TODO [AT_065] King's Defender && Test: King's Defender_AT_065
				InfoCardId = "AT_065e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [AT_066e] Forges of Orgrimmar (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("AT_066e", new Power {
				// TODO [AT_066e] Forges of Orgrimmar && Test: Forges of Orgrimmar_AT_066e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [AT_068e] Bolstered (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("AT_068e", new Power {
				// TODO [AT_068e] Bolstered && Test: Bolstered_AT_068e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [AT_069e] Training Complete (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			cards.Add("AT_069e", new Power {
				// TODO [AT_069e] Training Complete && Test: Training Complete_AT_069e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [AT_071e] Alexstrasza's Boon (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("AT_071e", new Power {
				// TODO [AT_071e] Alexstrasza's Boon && Test: Alexstrasza's Boon_AT_071e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [AT_017] Twilight Guardian - COST:4 [ATK:2/HP:6] 
			// - Race: dragon, Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_017", new Power {
				// TODO [AT_017] Twilight Guardian && Test: Twilight Guardian_AT_017
				InfoCardId = "AT_017e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_070] Skycap'n Kragg - COST:7 [ATK:4/HP:6] 
			// - Race: pirate, Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charrrrrge</b>
			//       Costs (1) less for each friendly Pirate.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_070", new Power {
				// TODO [AT_070] Skycap'n Kragg && Test: Skycap'n Kragg_AT_070
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_080] Garrison Commander - COST:2 [ATK:2/HP:3] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: You can use your Hero Power twice a turn.
			// --------------------------------------------------------
			cards.Add("AT_080", new Power {
				// TODO [AT_080] Garrison Commander && Test: Garrison Commander_AT_080
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_082] Lowly Squire - COST:1 [ATK:1/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Gain +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_082", new Power {
				// TODO [AT_082] Lowly Squire && Test: Lowly Squire_AT_082
				InfoCardId = "AT_082e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_083] Dragonhawk Rider - COST:3 [ATK:3/HP:3] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Gain <b>Windfury</b>
			//       this turn.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("AT_083", new Power {
				// TODO [AT_083] Dragonhawk Rider && Test: Dragonhawk Rider_AT_083
				InfoCardId = "AT_083e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_084] Lance Carrier - COST:2 [ATK:1/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("AT_084", new Power {
				// TODO [AT_084] Lance Carrier && Test: Lance Carrier_AT_084
				InfoCardId = "AT_084e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_085] Maiden of the Lake - COST:4 [ATK:2/HP:6] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Your Hero Power costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("AT_085", new Power {
				// TODO [AT_085] Maiden of the Lake && Test: Maiden of the Lake_AT_085
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_086] Saboteur - COST:3 [ATK:4/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your opponent's Hero Power costs (5) more next turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_086", new Power {
				// TODO [AT_086] Saboteur && Test: Saboteur_AT_086
				InfoCardId = "AT_086e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_087] Argent Horserider - COST:3 [ATK:2/HP:1] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_087", new Power {
				// TODO [AT_087] Argent Horserider && Test: Argent Horserider_AT_087
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_088] Mogor's Champion - COST:6 [ATK:8/HP:5] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: 50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - FORGETFUL = 1
			// --------------------------------------------------------
			cards.Add("AT_088", new Power {
				// TODO [AT_088] Mogor's Champion && Test: Mogor's Champion_AT_088
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_089] Boneguard Lieutenant - COST:2 [ATK:3/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Gain +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_089", new Power {
				// TODO [AT_089] Boneguard Lieutenant && Test: Boneguard Lieutenant_AT_089
				InfoCardId = "AT_089e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_090] Mukla's Champion - COST:5 [ATK:4/HP:3] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Give your other minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_090", new Power {
				// TODO [AT_090] Mukla's Champion && Test: Mukla's Champion_AT_090
				InfoCardId = "AT_090e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_091] Tournament Medic - COST:4 [ATK:1/HP:8] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Restore 2 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_091", new Power {
				// TODO [AT_091] Tournament Medic && Test: Tournament Medic_AT_091
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_092] Ice Rager - COST:3 [ATK:5/HP:2] 
			// - Race: elemental, Set: tgt, Rarity: common
			// --------------------------------------------------------
			cards.Add("AT_092", new Power {
				// TODO [AT_092] Ice Rager && Test: Ice Rager_AT_092
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_093] Frigid Snobold - COST:4 [ATK:2/HP:6] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("AT_093", new Power {
				// TODO [AT_093] Frigid Snobold && Test: Frigid Snobold_AT_093
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_094] Flame Juggler - COST:2 [ATK:2/HP:3] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_094", new Power {
				// TODO [AT_094] Flame Juggler && Test: Flame Juggler_AT_094
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_095] Silent Knight - COST:3 [ATK:2/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("AT_095", new Power {
				// TODO [AT_095] Silent Knight && Test: Silent Knight_AT_095
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_096] Clockwork Knight - COST:5 [ATK:5/HP:5] 
			// - Race: mechanical, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Mech +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 17
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("AT_096", new Power {
				// TODO [AT_096] Clockwork Knight && Test: Clockwork Knight_AT_096
				InfoCardId = "AT_096e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_097] Tournament Attendee - COST:1 [ATK:2/HP:1] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_097", new Power {
				// TODO [AT_097] Tournament Attendee && Test: Tournament Attendee_AT_097
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_098] Sideshow Spelleater - COST:6 [ATK:6/HP:5] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Copy your opponent's Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_098", new Power {
				// TODO [AT_098] Sideshow Spelleater && Test: Sideshow Spelleater_AT_098
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_099] Kodorider - COST:6 [ATK:3/HP:5] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Summon a 3/5 War Kodo.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_099", new Power {
				// TODO [AT_099] Kodorider && Test: Kodorider_AT_099
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_100] Silver Hand Regent - COST:3 [ATK:3/HP:3] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Summon a 1/1 Silver Hand Recruit.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_100", new Power {
				// TODO [AT_100] Silver Hand Regent && Test: Silver Hand Regent_AT_100
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_101] Pit Fighter - COST:5 [ATK:5/HP:6] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			cards.Add("AT_101", new Power {
				// TODO [AT_101] Pit Fighter && Test: Pit Fighter_AT_101
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_102] Captured Jormungar - COST:7 [ATK:5/HP:9] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			cards.Add("AT_102", new Power {
				// TODO [AT_102] Captured Jormungar && Test: Captured Jormungar_AT_102
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_103] North Sea Kraken - COST:9 [ATK:9/HP:7] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 4 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_103", new Power {
				// TODO [AT_103] North Sea Kraken && Test: North Sea Kraken_AT_103
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_105] Injured Kvaldir - COST:1 [ATK:2/HP:4] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_105", new Power {
				// TODO [AT_105] Injured Kvaldir && Test: Injured Kvaldir_AT_105
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_106] Light's Champion - COST:3 [ATK:4/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b> a Demon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_WITH_RACE = 15
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("AT_106", new Power {
				// TODO [AT_106] Light's Champion && Test: Light's Champion_AT_106
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_108] Armored Warhorse - COST:4 [ATK:5/HP:3] 
			// - Race: beast, Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_108", new Power {
				// TODO [AT_108] Armored Warhorse && Test: Armored Warhorse_AT_108
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_109] Argent Watchman - COST:2 [ATK:2/HP:4] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Can't attack.
			//       <b>Inspire:</b> Can attack as normal this turn.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_ATTACK = 1
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_109", new Power {
				// TODO [AT_109] Argent Watchman && Test: Argent Watchman_AT_109
				InfoCardId = "AT_109e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_110] Coliseum Manager - COST:3 [ATK:2/HP:5] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Return this minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_110", new Power {
				// TODO [AT_110] Coliseum Manager && Test: Coliseum Manager_AT_110
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_111] Refreshment Vendor - COST:4 [ATK:3/HP:5] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 4 Health to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_111", new Power {
				// TODO [AT_111] Refreshment Vendor && Test: Refreshment Vendor_AT_111
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_112] Master Jouster - COST:6 [ATK:5/HP:6] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Taunt</b> and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("AT_112", new Power {
				// TODO [AT_112] Master Jouster && Test: Master Jouster_AT_112
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_113] Recruiter - COST:5 [ATK:5/HP:4] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Add a 2/2 Squire to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_113", new Power {
				// TODO [AT_113] Recruiter && Test: Recruiter_AT_113
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_114] Evil Heckler - COST:4 [ATK:5/HP:4] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_114", new Power {
				// TODO [AT_114] Evil Heckler && Test: Evil Heckler_AT_114
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_115] Fencing Coach - COST:3 [ATK:2/HP:2] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> The next time you use your Hero Power, it costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("AT_115", new Power {
				// TODO [AT_115] Fencing Coach && Test: Fencing Coach_AT_115
				InfoCardId = "AT_115e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_117] Master of Ceremonies - COST:3 [ATK:4/HP:2] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a minion with <b>Spell Damage</b>, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_117", new Power {
				// TODO [AT_117] Master of Ceremonies && Test: Master of Ceremonies_AT_117
				InfoCardId = "AT_117e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_118] Grand Crusader - COST:6 [ATK:5/HP:5] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Paladin card to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_118", new Power {
				// TODO [AT_118] Grand Crusader && Test: Grand Crusader_AT_118
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_119] Kvaldir Raider - COST:5 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_119", new Power {
				// TODO [AT_119] Kvaldir Raider && Test: Kvaldir Raider_AT_119
				InfoCardId = "AT_119e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_120] Frost Giant - COST:10 [ATK:8/HP:8] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each time you used your Hero Power this game.
			// --------------------------------------------------------
			cards.Add("AT_120", new Power {
				// TODO [AT_120] Frost Giant && Test: Frost Giant_AT_120
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_121] Crowd Favorite - COST:4 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you play a card with <b>Battlecry</b>, gain +1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_121", new Power {
				// TODO [AT_121] Crowd Favorite && Test: Crowd Favorite_AT_121
				InfoCardId = "AT_121e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_122] Gormok the Impaler - COST:4 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have at least 4 other minions, deal 4 damage.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS = 4
			// --------------------------------------------------------
			cards.Add("AT_122", new Power {
				// TODO [AT_122] Gormok the Impaler && Test: Gormok the Impaler_AT_122
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_123] Chillmaw - COST:7 [ATK:6/HP:6] 
			// - Race: dragon, Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Deathrattle:</b> If you're holding
			//       a Dragon, deal 3 damage
			//       to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("AT_123", new Power {
				// TODO [AT_123] Chillmaw && Test: Chillmaw_AT_123
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_124] Bolf Ramshield - COST:6 [ATK:3/HP:9] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever your hero takes damage, this minion takes it instead.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("AT_124", new Power {
				// TODO [AT_124] Bolf Ramshield && Test: Bolf Ramshield_AT_124
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_125] Icehowl - COST:9 [ATK:10/HP:10] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       Can't attack heroes.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_125", new Power {
				// TODO [AT_125] Icehowl && Test: Icehowl_AT_125
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_127] Nexus-Champion Saraad - COST:5 [ATK:4/HP:5] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Add a random spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_127", new Power {
				// TODO [AT_127] Nexus-Champion Saraad && Test: Nexus-Champion Saraad_AT_127
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_128] The Skeleton Knight - COST:6 [ATK:7/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Reveal a minion in each deck. If yours costs more, return this to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("AT_128", new Power {
				// TODO [AT_128] The Skeleton Knight && Test: The Skeleton Knight_AT_128
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_129] Fjola Lightbane - COST:3 [ATK:3/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever <b>you</b> target this minion with a spell, gain <b>Divine Shield.</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("AT_129", new Power {
				// TODO [AT_129] Fjola Lightbane && Test: Fjola Lightbane_AT_129
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_131] Eydis Darkbane - COST:3 [ATK:3/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever <b>you</b> target this minion with a spell, deal 3 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("AT_131", new Power {
				// TODO [AT_131] Eydis Darkbane && Test: Eydis Darkbane_AT_131
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_132] Justicar Trueheart - COST:6 [ATK:6/HP:3] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Replace your starting Hero Power with a better one.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("AT_132", new Power {
				// TODO [AT_132] Justicar Trueheart && Test: Justicar Trueheart_AT_132
				InfoCardId = "AT_132_DRUIDe",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_133] Gadgetzan Jouster - COST:1 [ATK:1/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_133", new Power {
				// TODO [AT_133] Gadgetzan Jouster && Test: Gadgetzan Jouster_AT_133
				InfoCardId = "AT_133e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_011e] Light's Blessing (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("AT_011e", new Power {
				// TODO [AT_011e] Light's Blessing && Test: Light's Blessing_AT_011e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_013e] Power Word: Glory (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: When this attacks, restore 4 Health to the hero of the player who buffed it.
			// --------------------------------------------------------
			cards.Add("AT_013e", new Power {
				// TODO [AT_013e] Power Word: Glory && Test: Power Word: Glory_AT_013e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_017e] Twilight's Embrace (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("AT_017e", new Power {
				// TODO [AT_017e] Twilight's Embrace && Test: Twilight's Embrace_AT_017e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_019e] Dreadsteed (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Summon a Dreadsteed at the end of the turn.
			// --------------------------------------------------------
			cards.Add("AT_019e", new Power {
				// TODO [AT_019e] Dreadsteed && Test: Dreadsteed_AT_019e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_024e] Dark Fusion (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("AT_024e", new Power {
				// TODO [AT_024e] Dark Fusion && Test: Dark Fusion_AT_024e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_028e] Chi Lance (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("AT_028e", new Power {
				// TODO [AT_028e] Chi Lance && Test: Chi Lance_AT_028e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_029e] Extra Stabby (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1 Attack
			// --------------------------------------------------------
			cards.Add("AT_029e", new Power {
				// TODO [AT_029e] Extra Stabby && Test: Extra Stabby_AT_029e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_041e] Call of the Wild (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Cost reduced.
			// --------------------------------------------------------
			cards.Add("AT_041e", new Power {
				// TODO [AT_041e] Call of the Wild && Test: Call of the Wild_AT_041e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_045e] Empowering Mist (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_045e", new Power {
				// TODO [AT_045e] Empowering Mist && Test: Empowering Mist_AT_045e
				InfoCardId = "AT_045ee",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_045ee] Mistcaller Deck Ench (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			cards.Add("AT_045ee", new Power {
				// TODO [AT_045ee] Mistcaller Deck Ench && Test: Mistcaller Deck Ench_AT_045ee
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_065e] King's Defender (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1 Durability.
			// --------------------------------------------------------
			cards.Add("AT_065e", new Power {
				// TODO [AT_065e] King's Defender && Test: King's Defender_AT_065e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_073e] Competitive Spirit (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_073e", new Power {
				// TODO [AT_073e] Competitive Spirit && Test: Competitive Spirit_AT_073e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_077e] Extra Poke (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1 Durability.
			// --------------------------------------------------------
			cards.Add("AT_077e", new Power {
				// TODO [AT_077e] Extra Poke && Test: Extra Poke_AT_077e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_082e] Training (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("AT_082e", new Power {
				// TODO [AT_082e] Training && Test: Training_AT_082e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_083e] Dragonhawkery (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("AT_083e", new Power {
				// TODO [AT_083e] Dragonhawkery && Test: Dragonhawkery_AT_083e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_084e] Equipped (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("AT_084e", new Power {
				// TODO [AT_084e] Equipped && Test: Equipped_AT_084e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_086e] Villainy (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Your Hero Power costs (5) more this turn.
			// --------------------------------------------------------
			cards.Add("AT_086e", new Power {
				// TODO [AT_086e] Villainy && Test: Villainy_AT_086e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_089e] Boneguarded (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("AT_089e", new Power {
				// TODO [AT_089e] Boneguarded && Test: Boneguarded_AT_089e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_090e] Might of the Monkey (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_090e", new Power {
				// TODO [AT_090e] Might of the Monkey && Test: Might of the Monkey_AT_090e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_096e] Wound Up (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_096e", new Power {
				// TODO [AT_096e] Wound Up && Test: Wound Up_AT_096e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_109e] Inspired (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Can attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("AT_109e", new Power {
				// TODO [AT_109e] Inspired && Test: Inspired_AT_109e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_115e] Fencing Practice (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Your Hero Power costs (2) less.
			// --------------------------------------------------------
			cards.Add("AT_115e", new Power {
				// TODO [AT_115e] Fencing Practice && Test: Fencing Practice_AT_115e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_117e] Ceremony (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("AT_117e", new Power {
				// TODO [AT_117e] Ceremony && Test: Ceremony_AT_117e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_119e] Inspired (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("AT_119e", new Power {
				// TODO [AT_119e] Inspired && Test: Inspired_AT_119e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_121e] Huge Ego (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("AT_121e", new Power {
				// TODO [AT_121e] Huge Ego && Test: Huge Ego_AT_121e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_133e] Victory! (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_133e", new Power {
				// TODO [AT_133e] Victory! && Test: Victory!_AT_133e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_005t] Boar (*) - COST:3 [ATK:4/HP:2] 
			// - Race: beast, Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_005t", new Power {
				// TODO [AT_005t] Boar && Test: Boar_AT_005t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_099t] War Kodo (*) - COST:5 [ATK:3/HP:5] 
			// - Race: beast, Set: tgt, 
			// --------------------------------------------------------
			cards.Add("AT_099t", new Power {
				// TODO [AT_099t] War Kodo && Test: War Kodo_AT_099t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
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
