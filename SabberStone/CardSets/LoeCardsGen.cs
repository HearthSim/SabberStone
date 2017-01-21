using System.Collections.Generic;
using HearthDb.Enums;
using SabberStone.Conditions;
using SabberStone.Enchants;
using SabberStone.Tasks;
using SabberStone.Tasks.SimpleTasks;

namespace SabberStone.CardSets
{
	public class LoeCardsGen
	{
		private static void Heroes(IDictionary<string, List<Enchantment>> cards)
		{
		}

		private static void HeroPowers(IDictionary<string, List<Enchantment>> cards)
		{
		}

		private static void Druid(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [LOE_115] Raven Idol - COST:1 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b>
			//       <b>Discover</b> a minion; or <b>Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOE_115", new List<Enchantment> {
				// TODO [LOE_115] Raven Idol && Test: Raven Idol_LOE_115
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- MINION - DRUID
			// [LOE_050] Mounted Raptor - COST:3 [ATK:3/HP:2] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random 1-Cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_050", new List<Enchantment> {
				// TODO [LOE_050] Mounted Raptor && Test: Mounted Raptor_LOE_050
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// ----------------------------------------- MINION - DRUID
			// [LOE_051] Jungle Moonkin - COST:4 [ATK:4/HP:4] 
			// - Race: beast, Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Both players have
			//       <b>Spell Damage +2</b>.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 2
			// --------------------------------------------------------
			cards.Add("LOE_051", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HEROES,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(2)
                },
            });

		}

		private static void DruidNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [LOE_115a] Raven Idol (*) - COST:0 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a minion.
			// --------------------------------------------------------
			cards.Add("LOE_115a", new List<Enchantment> {
				// TODO [LOE_115a] Raven Idol && Test: Raven Idol_LOE_115a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOE_115b] Raven Idol (*) - COST:0 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a spell.
			// --------------------------------------------------------
			cards.Add("LOE_115b", new List<Enchantment> {
				// TODO [LOE_115b] Raven Idol && Test: Raven Idol_LOE_115b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void Hunter(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - HUNTER
			// [LOE_021] Dart Trap - COST:2 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After an opposing <b>Hero Power</b> is used, deal $5 damage to a random enemy. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOE_021", new List<Enchantment> {
				// TODO [LOE_021] Dart Trap && Test: Dart Trap_LOE_021
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOE_105] Explorer's Hat - COST:2 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion +1/+1 and "<b>Deathrattle:</b> Add an Explorer's Hat to your hand."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_105", new List<Enchantment> {
				// TODO [LOE_105] Explorer's Hat && Test: Explorer's Hat_LOE_105
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - HUNTER
			// [LOE_020] Desert Camel - COST:3 [ATK:2/HP:4] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Put a 1-Cost minion from each deck into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_020", new List<Enchantment> {
				// TODO [LOE_020] Desert Camel && Test: Desert Camel_LOE_020
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void HunterNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [LOE_105e] Explorer's Hat (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +1/+1. <b>Deathrattle:</b> Add an Explorer's Hat to your hand.
			// --------------------------------------------------------
			cards.Add("LOE_105e", new List<Enchantment> {
				// TODO [LOE_105e] Explorer's Hat && Test: Explorer's Hat_LOE_105e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - HUNTER
			// [LOEA02_10a] Leokk (*) - COST:0 [ATK:2/HP:4] 
			// - Race: beast, Set: loe, 
			// --------------------------------------------------------
			// Text: Your minions have +1 Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_10a", new List<Enchantment> {
				// TODO [LOEA02_10a] Leokk && Test: Leokk_LOEA02_10a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - HUNTER
			// [LOEA02_10c] Misha (*) - COST:0 [ATK:4/HP:4] 
			// - Race: beast, Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_10c", new List<Enchantment> {
				// TODO [LOEA02_10c] Misha && Test: Misha_LOEA02_10c
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Mage(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [LOE_002] Forgotten Torch - COST:3 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage. Shuffle a 'Roaring Torch' into your deck that deals 6 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOE_002", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DamageTask(3, EntityType.TARGET, true),
                        new AddCardTo("LOE_002t", EntityType.DECK)),
				},
			});

			// ------------------------------------------ MINION - MAGE
			// [LOE_003] Ethereal Conjurer - COST:5 [ATK:6/HP:3] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOE_003", new List<Enchantment> {
				// TODO [LOE_003] Ethereal Conjurer && Test: Ethereal Conjurer_LOE_003
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ------------------------------------------ MINION - MAGE
			// [LOE_119] Animated Armor - COST:4 [ATK:4/HP:4] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Your hero can only take 1 damage at a time.
			// --------------------------------------------------------
			cards.Add("LOE_119", new List<Enchantment> {
				// TODO [LOE_119] Animated Armor && Test: Animated Armor_LOE_119
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [LOE_002t] Roaring Torch (*) - COST:3 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Deal $6 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOE_002t", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DamageTask(6, EntityType.TARGET, true),
				},
			});

		}

		private static void Paladin(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - PALADIN
			// [LOE_026] Anyfin Can Happen - COST:10 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 7 Murlocs that died this game.
			// --------------------------------------------------------
			cards.Add("LOE_026", new List<Enchantment> {
				// TODO [LOE_026] Anyfin Can Happen && Test: Anyfin Can Happen_LOE_026
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOE_027] Sacred Trial - COST:1 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent has at least 3 minions and plays another, destroy it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOE_027", new List<Enchantment> {
				// TODO [LOE_027] Sacred Trial && Test: Sacred Trial_LOE_027
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - PALADIN
			// [LOE_017] Keeper of Uldaman - COST:4 [ATK:3/HP:4] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Set a minion's Attack and Health to 3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("LOE_017", new List<Enchantment> {
				// TODO [LOE_017] Keeper of Uldaman && Test: Keeper of Uldaman_LOE_017
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void PaladinNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [LOE_017e] Watched (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Stats changed to 3/3.
			// --------------------------------------------------------
			cards.Add("LOE_017e", new List<Enchantment> {
				// TODO [LOE_017e] Watched && Test: Watched_LOE_017e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Priest(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - PRIEST
			// [LOE_104] Entomb - COST:6 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Choose an enemy minion.
			//       Shuffle it into your deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOE_104", new List<Enchantment> {
				// TODO [LOE_104] Entomb && Test: Entomb_LOE_104
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOE_111] Excavated Evil - COST:5 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $3 damage to all minions.
			//       Shuffle this card into your opponent's deck. *spelldmg
			// --------------------------------------------------------
			cards.Add("LOE_111", new List<Enchantment> {
				// TODO [LOE_111] Excavated Evil && Test: Excavated Evil_LOE_111
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - PRIEST
			// [LOE_006] Museum Curator - COST:2 [ATK:1/HP:2] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a <b>Deathrattle</b> card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOE_006", new List<Enchantment> {
				// TODO [LOE_006] Museum Curator && Test: Museum Curator_LOE_006
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void Rogue(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [LOE_010] Pit Snake - COST:1 [ATK:2/HP:1] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy any minion damaged by this minion.
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("LOE_010", new List<Enchantment> {
				// TODO [LOE_010] Pit Snake && Test: Pit Snake_LOE_010
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - ROGUE
			// [LOE_012] Tomb Pillager - COST:4 [ATK:5/HP:4] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a Coin to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_012", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = new AddCardTo("GAME_005", EntityType.HAND),
				},
			});

			// ----------------------------------------- MINION - ROGUE
			// [LOE_019] Unearthed Raptor - COST:3 [ATK:3/HP:4] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Gain a copy of its <b>Deathrattle</b> effect.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_019", new List<Enchantment> {
				// TODO [LOE_019] Unearthed Raptor && Test: Unearthed Raptor_LOE_019
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [LOE_019e] Unearthed Raptor (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOE_019e", new List<Enchantment> {
				// TODO [LOE_019e] Unearthed Raptor && Test: Unearthed Raptor_LOE_019e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Shaman(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - SHAMAN
			// [LOE_113] Everyfin is Awesome - COST:7 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your minions +2/+2.
			//       Costs (1) less for each Murloc you control.
			// --------------------------------------------------------
			cards.Add("LOE_113", new List<Enchantment> {
				// TODO [LOE_113] Everyfin is Awesome && Test: Everyfin is Awesome_LOE_113
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - SHAMAN
			// [LOE_016] Rumbling Elemental - COST:4 [ATK:2/HP:6] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: After you play a <b>Battlecry</b> minion, deal 2 damage to a random enemy.
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_016", new List<Enchantment> {
				// TODO [LOE_016] Rumbling Elemental && Test: Rumbling Elemental_LOE_016
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - SHAMAN
			// [LOE_018] Tunnel Trogg - COST:1 [ATK:1/HP:3] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you <b>Overload</b>, gain +1 Attack per locked Mana Crystal.
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("LOE_018", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
					Activation = EnchantmentActivation.BOARD,
					Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.OVERLOAD_OWED, 1)
                        .SingleTask(new BuffAttackNumberTask(EntityType.SOURCE))
                        .Build()
				}
			});

		}

		private static void ShamanNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [LOE_018e] Trogg No Stupid (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("LOE_018e", new List<Enchantment> {
				// TODO [LOE_018e] Trogg No Stupid && Test: Trogg No Stupid_LOE_018e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Warlock(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARLOCK
			// [LOE_007] Curse of Rafaam - COST:2 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Give your opponent a 'Cursed!' card.
			//       While they hold it, they take 2 damage on their turn.
			// --------------------------------------------------------
			cards.Add("LOE_007", new List<Enchantment> {
				// TODO [LOE_007] Curse of Rafaam && Test: Curse of Rafaam_LOE_007
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOE_023] Dark Peddler - COST:2 [ATK:2/HP:2] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a
			//       1-Cost card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOE_023", new List<Enchantment> {
				// TODO [LOE_023] Dark Peddler && Test: Dark Peddler_LOE_023
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOE_116] Reliquary Seeker - COST:1 [ATK:1/HP:1] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have 6 other minions, gain +4/+4.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_116", new List<Enchantment> {
				// TODO [LOE_116] Reliquary Seeker && Test: Reliquary Seeker_LOE_116
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void WarlockNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARLOCK
			// [LOE_007t] Cursed! (*) - COST:2 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: While this is in your hand, take 2 damage at the start of your turn.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - EVIL_GLOW = 1
			// --------------------------------------------------------
			cards.Add("LOE_007t", new List<Enchantment> {
				// TODO [LOE_007t] Cursed! && Test: Cursed!_LOE_007t
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [LOE_009e] Sinister Power (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			cards.Add("LOE_009e", new List<Enchantment> {
				// TODO [LOE_009e] Sinister Power && Test: Sinister Power_LOE_009e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Warrior(IDictionary<string, List<Enchantment>> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [LOE_009] Obsidian Destroyer - COST:7 [ATK:7/HP:7] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a 1/1 Scarab with <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOE_009", new List<Enchantment> {
				// TODO [LOE_009] Obsidian Destroyer && Test: Obsidian Destroyer_LOE_009
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARRIOR
			// [LOE_022] Fierce Monkey - COST:3 [ATK:3/HP:4] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOE_022", new List<Enchantment> {
				// TODO [LOE_022] Fierce Monkey && Test: Fierce Monkey_LOE_022
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [LOE_118] Cursed Blade - COST:1 [ATK:2/HP:0] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Double all damage dealt to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("LOE_118", new List<Enchantment> {
				// TODO [LOE_118] Cursed Blade && Test: Cursed Blade_LOE_118
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void WarriorNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [LOE_118e] Cursed Blade (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Double all damage dealt to your hero.
			// --------------------------------------------------------
			cards.Add("LOE_118e", new List<Enchantment> {
				// TODO [LOE_118e] Cursed Blade && Test: Cursed Blade_LOE_118e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARRIOR
			// [LOE_009t] Scarab (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOE_009t", new List<Enchantment> {
				// TODO [LOE_009t] Scarab && Test: Scarab_LOE_009t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Neutral(IDictionary<string, List<Enchantment>> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [LOE_011] Reno Jackson - COST:6 [ATK:4/HP:6] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no duplicates, fully heal your hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_011", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsNoDupeInDeck),
                        new FlagTask(true, new HealFullTask(EntityType.HERO)))
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_029] Jeweled Scarab - COST:2 [ATK:1/HP:1] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a
			//       3-Cost card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOE_029", new List<Enchantment> {
				// TODO [LOE_029] Jeweled Scarab && Test: Jeweled Scarab_LOE_029
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_038] Naga Sea Witch - COST:5 [ATK:5/HP:5] 
			// - Set: loe, Rarity: epic
			// --------------------------------------------------------
			// Text: Your cards cost (5).
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("LOE_038", new List<Enchantment> {
				// TODO [LOE_038] Naga Sea Witch && Test: Naga Sea Witch_LOE_038
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_039] Gorillabot A-3 - COST:4 [ATK:3/HP:4] 
			// - Race: mechanical, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control another Mech, <b>Discover</b> a Mech.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOE_039", new List<Enchantment> {
				// TODO [LOE_039] Gorillabot A-3 && Test: Gorillabot A-3_LOE_039
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_046] Huge Toad - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 1 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_046", new List<Enchantment> {
				// TODO [LOE_046] Huge Toad && Test: Huge Toad_LOE_046
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_047] Tomb Spider - COST:4 [ATK:3/HP:3] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a Beast.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOE_047", new List<Enchantment> {
				// TODO [LOE_047] Tomb Spider && Test: Tomb Spider_LOE_047
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_053] Djinni of Zephyrs - COST:5 [ATK:4/HP:6] 
			// - Set: loe, Rarity: epic
			// --------------------------------------------------------
			// Text: After you cast a spell on another friendly minion, cast a copy of it on this one.
			// --------------------------------------------------------
			cards.Add("LOE_053", new List<Enchantment> {
				// TODO [LOE_053] Djinni of Zephyrs && Test: Djinni of Zephyrs_LOE_053
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_061] Anubisath Sentinel - COST:5 [ATK:4/HP:4] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give a random friendly minion +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_061", new List<Enchantment> {
				// TODO [LOE_061] Anubisath Sentinel && Test: Anubisath Sentinel_LOE_061
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_073] Fossilized Devilsaur - COST:8 [ATK:8/HP:8] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a Beast, gain <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOE_073", new List<Enchantment> {
				// TODO [LOE_073] Fossilized Devilsaur && Test: Fossilized Devilsaur_LOE_073
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_076] Sir Finley Mrrgglton - COST:1 [ATK:1/HP:3] 
			// - Race: murloc, Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a new basic Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOE_076", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new DiscoverTask(DiscoverType.BASIC_HEROPOWERS)
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_077] Brann Bronzebeard - COST:3 [ATK:2/HP:4] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your <b>Battlecries</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_077", new List<Enchantment> {
				// TODO [LOE_077] Brann Bronzebeard && Test: Brann Bronzebeard_LOE_077
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_079] Elise Starseeker - COST:4 [ATK:3/HP:5] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle the 'Map to the Golden Monkey'   into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOE_079", new List<Enchantment> {
				// TODO [LOE_079] Elise Starseeker && Test: Elise Starseeker_LOE_079
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_086] Summoning Stone - COST:5 [ATK:0/HP:6] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a random minion of the same Cost.
			// --------------------------------------------------------
			cards.Add("LOE_086", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOtherSpell)
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(ComplexTask.Create(
                            new RandomMinionTask(GameTag.COST, EntityType.TARGET),
                            new SummonTask()))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_089] Wobbling Runts - COST:6 [ATK:2/HP:6] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon three 2/2 Runts.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_089", new List<Enchantment> {
				// TODO [LOE_089] Wobbling Runts && Test: Wobbling Runts_LOE_089
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_092] Arch-Thief Rafaam - COST:9 [ATK:7/HP:8] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a powerful Artifact.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOE_092", new List<Enchantment> {
				// TODO [LOE_092] Arch-Thief Rafaam && Test: Arch-Thief Rafaam_LOE_092
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_107] Eerie Statue - COST:4 [ATK:7/HP:7] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Can't attack unless it's the only minion in the battlefield.
			// --------------------------------------------------------
			cards.Add("LOE_107", new List<Enchantment> {
				// TODO [LOE_107] Eerie Statue && Test: Eerie Statue_LOE_107
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_110] Ancient Shade - COST:4 [ATK:7/HP:4] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle an 'Ancient Curse' into your deck that deals 7 damage to you when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_110", new List<Enchantment> {
				// TODO [LOE_110] Ancient Shade && Test: Ancient Shade_LOE_110
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA10_3] Murloc Tinyfin - COST:0 [ATK:1/HP:1] 
			// - Race: murloc, Set: loe, Rarity: common
			// --------------------------------------------------------
			cards.Add("LOEA10_3", new List<Enchantment> {
				// TODO [LOEA10_3] Murloc Tinyfin && Test: Murloc Tinyfin_LOEA10_3
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - NEUTRAL
			// [LOE_008] Eye of Hakkar (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Take a secret from your opponent's deck and put it into the battlefield.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOE_008", new List<Enchantment> {
				// TODO [LOE_008] Eye of Hakkar && Test: Eye of Hakkar_LOE_008
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOE_008H] Eye of Hakkar (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Take a secret from your opponent's deck and put it into the battlefield.
			// --------------------------------------------------------
			cards.Add("LOE_008H", new List<Enchantment> {
				// TODO [LOE_008H] Eye of Hakkar && Test: Eye of Hakkar_LOE_008H
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOE_019t] Map to the Golden Monkey (*) - COST:2 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Shuffle the Golden Monkey into your deck. Draw a card.
			// --------------------------------------------------------
			cards.Add("LOE_019t", new List<Enchantment> {
				// TODO [LOE_019t] Map to the Golden Monkey && Test: Map to the Golden Monkey_LOE_019t
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOE_110t] Ancient Curse (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: When you draw this, take 7 damage and draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("LOE_110t", new List<Enchantment> {
				// TODO [LOE_110t] Ancient Curse && Test: Ancient Curse_LOE_110t
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA02_03] Wish for Power (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a spell.
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_03", new List<Enchantment> {
				// TODO [LOEA02_03] Wish for Power && Test: Wish for Power_LOEA02_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA02_04] Wish for Valor (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a (4)-Cost card.
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_04", new List<Enchantment> {
				// TODO [LOEA02_04] Wish for Valor && Test: Wish for Valor_LOEA02_04
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA02_05] Wish for Glory (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a minion.
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_05", new List<Enchantment> {
				// TODO [LOEA02_05] Wish for Glory && Test: Wish for Glory_LOEA02_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA02_06] Wish for More Wishes (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Gain 2 Wishes.
			// --------------------------------------------------------
			cards.Add("LOEA02_06", new List<Enchantment> {
				// TODO [LOEA02_06] Wish for More Wishes && Test: Wish for More Wishes_LOEA02_06
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA02_10] Wish for Companionship (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a Companion.
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_10", new List<Enchantment> {
				// TODO [LOEA02_10] Wish for Companionship && Test: Wish for Companionship_LOEA02_10
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_06] Pit of Spikes (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Choose Your Path!</b>
			// --------------------------------------------------------
			cards.Add("LOEA04_06", new List<Enchantment> {
				// TODO [LOEA04_06] Pit of Spikes && Test: Pit of Spikes_LOEA04_06
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_06a] Swing Across (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Take 10 damage or no damage, at random.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_06a", new List<Enchantment> {
				// TODO [LOEA04_06a] Swing Across && Test: Swing Across_LOEA04_06a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_06b] Walk Across Gingerly (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Take 5 damage.
			// --------------------------------------------------------
			cards.Add("LOEA04_06b", new List<Enchantment> {
				// TODO [LOEA04_06b] Walk Across Gingerly && Test: Walk Across Gingerly_LOEA04_06b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_28] A Glowing Pool (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Drink?</b>
			// --------------------------------------------------------
			cards.Add("LOEA04_28", new List<Enchantment> {
				// TODO [LOEA04_28] A Glowing Pool && Test: A Glowing Pool_LOEA04_28
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_28a] Drink Deeply (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Draw a card.
			// --------------------------------------------------------
			cards.Add("LOEA04_28a", new List<Enchantment> {
				// TODO [LOEA04_28a] Drink Deeply && Test: Drink Deeply_LOEA04_28a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_28b] Wade Through (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Gain a Mana Crystal
			// --------------------------------------------------------
			cards.Add("LOEA04_28b", new List<Enchantment> {
				// TODO [LOEA04_28b] Wade Through && Test: Wade Through_LOEA04_28b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_29] The Eye (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Choose Your Path!</b>
			// --------------------------------------------------------
			cards.Add("LOEA04_29", new List<Enchantment> {
				// TODO [LOEA04_29] The Eye && Test: The Eye_LOEA04_29
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_29a] Touch It (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Restore 10 Health to your hero.
			// --------------------------------------------------------
			cards.Add("LOEA04_29a", new List<Enchantment> {
				// TODO [LOEA04_29a] Touch It && Test: Touch It_LOEA04_29a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_29b] Investigate the Runes (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Draw 2 cards.
			// --------------------------------------------------------
			cards.Add("LOEA04_29b", new List<Enchantment> {
				// TODO [LOEA04_29b] Investigate the Runes && Test: Investigate the Runes_LOEA04_29b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_30] The Darkness (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Take the Shortcut?</b>
			// --------------------------------------------------------
			cards.Add("LOEA04_30", new List<Enchantment> {
				// TODO [LOEA04_30] The Darkness && Test: The Darkness_LOEA04_30
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_30a] Take the Shortcut (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Get 1 turn closer to the Exit! Encounter a 7/7 War Golem.
			// --------------------------------------------------------
			cards.Add("LOEA04_30a", new List<Enchantment> {
				// TODO [LOEA04_30a] Take the Shortcut && Test: Take the Shortcut_LOEA04_30a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_31b] No Way! (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Do nothing.
			// --------------------------------------------------------
			cards.Add("LOEA04_31b", new List<Enchantment> {
				// TODO [LOEA04_31b] No Way! && Test: No Way!_LOEA04_31b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA06_03] Animate Earthen (*) - COST:2 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Give your minions +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOEA06_03", new List<Enchantment> {
				// TODO [LOEA06_03] Animate Earthen && Test: Animate Earthen_LOEA06_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA06_03h] Animate Earthen (*) - COST:2 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Give your minions +3/+3 and <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOEA06_03h", new List<Enchantment> {
				// TODO [LOEA06_03h] Animate Earthen && Test: Animate Earthen_LOEA06_03h
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA06_04] Shattering Spree (*) - COST:2 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Destroy all Statues. For each destroyed, deal 1 damage. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOEA06_04", new List<Enchantment> {
				// TODO [LOEA06_04] Shattering Spree && Test: Shattering Spree_LOEA06_04
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA06_04h] Shattering Spree (*) - COST:2 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Destroy all Statues. For each destroyed, deal 3 damage. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOEA06_04h", new List<Enchantment> {
				// TODO [LOEA06_04h] Shattering Spree && Test: Shattering Spree_LOEA06_04h
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA07_18] Dynamite (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Deal $10 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOEA07_18", new List<Enchantment> {
				// TODO [LOEA07_18] Dynamite && Test: Dynamite_LOEA07_18
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA07_20] Boom! (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Deal $3 damage to all enemy minions. *spelldmg
			// --------------------------------------------------------
			cards.Add("LOEA07_20", new List<Enchantment> {
				// TODO [LOEA07_20] Boom! && Test: Boom!_LOEA07_20
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA07_21] Barrel Forward (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Get 1 turn closer to the Exit!
			// --------------------------------------------------------
			cards.Add("LOEA07_21", new List<Enchantment> {
				// TODO [LOEA07_21] Barrel Forward && Test: Barrel Forward_LOEA07_21
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA07_26] Consult Brann (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			// --------------------------------------------------------
			cards.Add("LOEA07_26", new List<Enchantment> {
				// TODO [LOEA07_26] Consult Brann && Test: Consult Brann_LOEA07_26
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA07_28] Repairs (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Restore 10 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOEA07_28", new List<Enchantment> {
				// TODO [LOEA07_28] Repairs && Test: Repairs_LOEA07_28
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA09_9] Naga Repellent (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Destroy all Hungry Naga.
			// --------------------------------------------------------
			cards.Add("LOEA09_9", new List<Enchantment> {
				// TODO [LOEA09_9] Naga Repellent && Test: Naga Repellent_LOEA09_9
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA09_9H] Naga Repellent (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Change the Attack of all Hungry Naga to 1.
			// --------------------------------------------------------
			cards.Add("LOEA09_9H", new List<Enchantment> {
				// TODO [LOEA09_9H] Naga Repellent && Test: Naga Repellent_LOEA09_9H
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA10_5] Mrgl Mrgl Nyah Nyah (*) - COST:5 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Summon 3 Murlocs that died this game.
			// --------------------------------------------------------
			cards.Add("LOEA10_5", new List<Enchantment> {
				// TODO [LOEA10_5] Mrgl Mrgl Nyah Nyah && Test: Mrgl Mrgl Nyah Nyah_LOEA10_5
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA10_5H] Mrgl Mrgl Nyah Nyah (*) - COST:3 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Summon 5 Murlocs that died this game.
			// --------------------------------------------------------
			cards.Add("LOEA10_5H", new List<Enchantment> {
				// TODO [LOEA10_5H] Mrgl Mrgl Nyah Nyah && Test: Mrgl Mrgl Nyah Nyah_LOEA10_5H
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_10] Hakkari Blood Goblet (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Transform a minion into a 2/1 Pit Snake.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOEA16_10", new List<Enchantment> {
				// TODO [LOEA16_10] Hakkari Blood Goblet && Test: Hakkari Blood Goblet_LOEA16_10
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_11] Crown of Kael'thas (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Deal $10 damage randomly split among ALL characters. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_11", new List<Enchantment> {
				// TODO [LOEA16_11] Crown of Kael'thas && Test: Crown of Kael'thas_LOEA16_11
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_12] Medivh's Locket (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Replace your hand with Unstable Portals.
			// --------------------------------------------------------
			cards.Add("LOEA16_12", new List<Enchantment> {
				// TODO [LOEA16_12] Medivh's Locket && Test: Medivh's Locket_LOEA16_12
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_13] Eye of Orsis (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a minion and gain 3 copies of it.
			// --------------------------------------------------------
			// RefTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_13", new List<Enchantment> {
				// TODO [LOEA16_13] Eye of Orsis && Test: Eye of Orsis_LOEA16_13
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_14] Khadgar's Pipe (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Put a random spell into each player's hand.  Yours costs (0).
			// --------------------------------------------------------
			cards.Add("LOEA16_14", new List<Enchantment> {
				// TODO [LOEA16_14] Khadgar's Pipe && Test: Khadgar's Pipe_LOEA16_14
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_15] Ysera's Tear (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Gain 4 Mana Crystals this turn only.
			// --------------------------------------------------------
			cards.Add("LOEA16_15", new List<Enchantment> {
				// TODO [LOEA16_15] Ysera's Tear && Test: Ysera's Tear_LOEA16_15
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_20] Blessing of the Sun (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Give a minion <b>Immune</b> this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_20", new List<Enchantment> {
				// TODO [LOEA16_20] Blessing of the Sun && Test: Blessing of the Sun_LOEA16_20
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_3] Lantern of Power (*) - COST:10 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Give a minion +10/+10.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOEA16_3", new List<Enchantment> {
				// TODO [LOEA16_3] Lantern of Power && Test: Lantern of Power_LOEA16_3
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_4] Timepiece of Horror (*) - COST:10 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Deal $10 damage randomly split among all enemies. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_4", new List<Enchantment> {
				// TODO [LOEA16_4] Timepiece of Horror && Test: Timepiece of Horror_LOEA16_4
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_5] Mirror of Doom (*) - COST:10 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Fill your board with 3/3 Mummy Zombies.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_5", new List<Enchantment> {
				// TODO [LOEA16_5] Mirror of Doom && Test: Mirror of Doom_LOEA16_5
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_6] Shard of Sulfuras (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Deal $5 damage to ALL characters. *spelldmg
			// --------------------------------------------------------
			cards.Add("LOEA16_6", new List<Enchantment> {
				// TODO [LOEA16_6] Shard of Sulfuras && Test: Shard of Sulfuras_LOEA16_6
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_7] Benediction Splinter (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Restore #10 Health to ALL characters.
			// --------------------------------------------------------
			cards.Add("LOEA16_7", new List<Enchantment> {
				// TODO [LOEA16_7] Benediction Splinter && Test: Benediction Splinter_LOEA16_7
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_8] Putress' Vial (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Destroy a random enemy minion.
			// --------------------------------------------------------
			cards.Add("LOEA16_8", new List<Enchantment> {
				// TODO [LOEA16_8] Putress' Vial && Test: Putress' Vial_LOEA16_8
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_9] Lothar's Left Greave (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Deal $3 damage to all enemies. *spelldmg
			// --------------------------------------------------------
			cards.Add("LOEA16_9", new List<Enchantment> {
				// TODO [LOEA16_9] Lothar's Left Greave && Test: Lothar's Left Greave_LOEA16_9
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA_01] Looming Presence (*) - COST:3 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Draw 2 cards. Gain 4 Armor.
			// --------------------------------------------------------
			cards.Add("LOEA_01", new List<Enchantment> {
				// TODO [LOEA_01] Looming Presence && Test: Looming Presence_LOEA_01
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA_01H] Looming Presence (*) - COST:3 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Draw 3 cards. Gain 6 Armor.
			// --------------------------------------------------------
			cards.Add("LOEA_01H", new List<Enchantment> {
				// TODO [LOEA_01H] Looming Presence && Test: Looming Presence_LOEA_01H
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOE_030e] Hollow (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Stats copied.
			// --------------------------------------------------------
			cards.Add("LOE_030e", new List<Enchantment> {
				// TODO [LOE_030e] Hollow && Test: Hollow_LOE_030e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOE_061e] Power of the Titans (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("LOE_061e", new List<Enchantment> {
				// TODO [LOE_061e] Power of the Titans && Test: Power of the Titans_LOE_061e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOE_073e] Fossilized (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Has <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("LOE_073e", new List<Enchantment> {
				// TODO [LOE_073e] Fossilized && Test: Fossilized_LOE_073e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOE_113e] Mrglllraawrrrglrur! (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("LOE_113e", new List<Enchantment> {
				// TODO [LOE_113e] Mrglllraawrrrglrur! && Test: Mrglllraawrrrglrur!_LOE_113e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA01_11he] Heroic Mode (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +3/+3 if Phaerix controls the Rod.
			// --------------------------------------------------------
			cards.Add("LOEA01_11he", new List<Enchantment> {
				// TODO [LOEA01_11he] Heroic Mode && Test: Heroic Mode_LOEA01_11he
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA04_01e] Temple Escape Enchant (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA04_01e", new List<Enchantment> {
				// TODO [LOEA04_01e] Temple Escape Enchant && Test: Temple Escape Enchant_LOEA04_01e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA04_01eh] Temple Escape Enchant (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA04_01eh", new List<Enchantment> {
				// TODO [LOEA04_01eh] Temple Escape Enchant && Test: Temple Escape Enchant_LOEA04_01eh
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA06_03e] Animated (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("LOEA06_03e", new List<Enchantment> {
				// TODO [LOEA06_03e] Animated && Test: Animated_LOEA06_03e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA06_03eh] Animated (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +3/+3 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("LOEA06_03eh", new List<Enchantment> {
				// TODO [LOEA06_03eh] Animated && Test: Animated_LOEA06_03eh
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA09_2e] Enraged (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +2 Attack
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_2e", new List<Enchantment> {
				// TODO [LOEA09_2e] Enraged && Test: Enraged_LOEA09_2e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA09_2eH] Enraged (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +5 Attack
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_2eH", new List<Enchantment> {
				// TODO [LOEA09_2eH] Enraged && Test: Enraged_LOEA09_2eH
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA09_3a] Famished (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Quite Hungry.
			// --------------------------------------------------------
			cards.Add("LOEA09_3a", new List<Enchantment> {
				// TODO [LOEA09_3a] Famished && Test: Famished_LOEA09_3a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA09_3aH] Famished (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Quite Hungry.
			// --------------------------------------------------------
			cards.Add("LOEA09_3aH", new List<Enchantment> {
				// TODO [LOEA09_3aH] Famished && Test: Famished_LOEA09_3aH
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA09_7e] Cauldron (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA09_7e", new List<Enchantment> {
				// TODO [LOEA09_7e] Cauldron && Test: Cauldron_LOEA09_7e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA16_20e] Blessed (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_20e", new List<Enchantment> {
				// TODO [LOEA16_20e] Blessed && Test: Blessed_LOEA16_20e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA16_20H] Blessing of the Sun (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Immune</b>.
			// --------------------------------------------------------
			cards.Add("LOEA16_20H", new List<Enchantment> {
				// TODO [LOEA16_20H] Blessing of the Sun && Test: Blessing of the Sun_LOEA16_20H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA16_3e] Lantern of Power (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +10/+10.
			// --------------------------------------------------------
			cards.Add("LOEA16_3e", new List<Enchantment> {
				// TODO [LOEA16_3e] Lantern of Power && Test: Lantern of Power_LOEA16_3e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA16_8a] Putressed (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Attack and Health swapped.
			// --------------------------------------------------------
			cards.Add("LOEA16_8a", new List<Enchantment> {
				// TODO [LOEA16_8a] Putressed && Test: Putressed_LOEA16_8a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_016t] Rock (*) - COST:1 [ATK:0/HP:6] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOE_016t", new List<Enchantment> {
				// TODO [LOE_016t] Rock && Test: Rock_LOE_016t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_019t2] Golden Monkey (*) - COST:4 [ATK:6/HP:6] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Replace your hand and deck with <b>Legendary</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_019t2", new List<Enchantment> {
				// TODO [LOE_019t2] Golden Monkey && Test: Golden Monkey_LOE_019t2
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_024t] Rolling Boulder (*) - COST:4 [ATK:0/HP:4] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: At the end of your turn, destroy the minion to the left.
			// --------------------------------------------------------
			cards.Add("LOE_024t", new List<Enchantment> {
				// TODO [LOE_024t] Rolling Boulder && Test: Rolling Boulder_LOE_024t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_089t] Rascally Runt (*) - COST:2 [ATK:2/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOE_089t", new List<Enchantment> {
				// TODO [LOE_089t] Rascally Runt && Test: Rascally Runt_LOE_089t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_089t2] Wily Runt (*) - COST:2 [ATK:2/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOE_089t2", new List<Enchantment> {
				// TODO [LOE_089t2] Wily Runt && Test: Wily Runt_LOE_089t2
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_089t3] Grumbly Runt (*) - COST:2 [ATK:2/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOE_089t3", new List<Enchantment> {
				// TODO [LOE_089t3] Grumbly Runt && Test: Grumbly Runt_LOE_089t3
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA01_11] Rod of the Sun (*) - COST:0 [ATK:0/HP:5] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Surrender this to your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_11", new List<Enchantment> {
				// TODO [LOEA01_11] Rod of the Sun && Test: Rod of the Sun_LOEA01_11
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA01_11h] Rod of the Sun (*) - COST:0 [ATK:0/HP:5] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Surrender this to your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_11h", new List<Enchantment> {
				// TODO [LOEA01_11h] Rod of the Sun && Test: Rod of the Sun_LOEA01_11h
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA01_12] Tol'vir Hoplite (*) - COST:3 [ATK:5/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 5 damage to both heroes.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_12", new List<Enchantment> {
				// TODO [LOEA01_12] Tol'vir Hoplite && Test: Tol'vir Hoplite_LOEA01_12
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA01_12h] Tol'vir Hoplite (*) - COST:3 [ATK:5/HP:5] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 5 damage to both heroes.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_12h", new List<Enchantment> {
				// TODO [LOEA01_12h] Tol'vir Hoplite && Test: Tol'vir Hoplite_LOEA01_12h
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_13bt] Orsis Guard (*) - COST:4 [ATK:7/HP:5] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_13bt", new List<Enchantment> {
				// TODO [LOEA04_13bt] Orsis Guard && Test: Orsis Guard_LOEA04_13bt
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_13bth] Orsis Guard (*) - COST:4 [ATK:8/HP:8] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_13bth", new List<Enchantment> {
				// TODO [LOEA04_13bth] Orsis Guard && Test: Orsis Guard_LOEA04_13bth
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_23] Giant Insect (*) - COST:7 [ATK:10/HP:3] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA04_23", new List<Enchantment> {
				// TODO [LOEA04_23] Giant Insect && Test: Giant Insect_LOEA04_23
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_23h] Giant Insect (*) - COST:7 [ATK:10/HP:6] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA04_23h", new List<Enchantment> {
				// TODO [LOEA04_23h] Giant Insect && Test: Giant Insect_LOEA04_23h
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_24] Anubisath Temple Guard (*) - COST:8 [ATK:5/HP:10] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA04_24", new List<Enchantment> {
				// TODO [LOEA04_24] Anubisath Temple Guard && Test: Anubisath Temple Guard_LOEA04_24
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_24h] Anubisath Temple Guard (*) - COST:8 [ATK:6/HP:15] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA04_24h", new List<Enchantment> {
				// TODO [LOEA04_24h] Anubisath Temple Guard && Test: Anubisath Temple Guard_LOEA04_24h
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_25] Seething Statue (*) - COST:8 [ATK:0/HP:9] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 2 damage to all enemies.
			// --------------------------------------------------------
			cards.Add("LOEA04_25", new List<Enchantment> {
				// TODO [LOEA04_25] Seething Statue && Test: Seething Statue_LOEA04_25
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_25h] Seething Statue (*) - COST:8 [ATK:5/HP:9] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 5 damage to all enemies.
			// --------------------------------------------------------
			cards.Add("LOEA04_25h", new List<Enchantment> {
				// TODO [LOEA04_25h] Seething Statue && Test: Seething Statue_LOEA04_25h
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_27] Animated Statue (*) - COST:1 [ATK:10/HP:10] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: You've disturbed the ancient statue...
			// --------------------------------------------------------
			cards.Add("LOEA04_27", new List<Enchantment> {
				// TODO [LOEA04_27] Animated Statue && Test: Animated Statue_LOEA04_27
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA06_02t] Earthen Statue (*) - COST:1 [ATK:0/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA06_02t", new List<Enchantment> {
				// TODO [LOEA06_02t] Earthen Statue && Test: Earthen Statue_LOEA06_02t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA06_02th] Earthen Statue (*) - COST:1 [ATK:0/HP:5] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA06_02th", new List<Enchantment> {
				// TODO [LOEA06_02th] Earthen Statue && Test: Earthen Statue_LOEA06_02th
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_09] Chasing Trogg (*) - COST:4 [ATK:2/HP:6] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA07_09", new List<Enchantment> {
				// TODO [LOEA07_09] Chasing Trogg && Test: Chasing Trogg_LOEA07_09
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_11] Debris (*) - COST:1 [ATK:0/HP:3] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt.</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_11", new List<Enchantment> {
				// TODO [LOEA07_11] Debris && Test: Debris_LOEA07_11
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_12] Earthen Pursuer (*) - COST:5 [ATK:4/HP:6] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA07_12", new List<Enchantment> {
				// TODO [LOEA07_12] Earthen Pursuer && Test: Earthen Pursuer_LOEA07_12
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_14] Lumbering Golem (*) - COST:6 [ATK:6/HP:6] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA07_14", new List<Enchantment> {
				// TODO [LOEA07_14] Lumbering Golem && Test: Lumbering Golem_LOEA07_14
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_24] Spiked Decoy (*) - COST:1 [ATK:3/HP:6] 
			// - Race: mechanical, Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Can't attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_24", new List<Enchantment> {
				// TODO [LOEA07_24] Spiked Decoy && Test: Spiked Decoy_LOEA07_24
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_25] Mechanical Parrot (*) - COST:1 [ATK:3/HP:6] 
			// - Race: mechanical, Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA07_25", new List<Enchantment> {
				// TODO [LOEA07_25] Mechanical Parrot && Test: Mechanical Parrot_LOEA07_25
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_10] Hungry Naga (*) - COST:2 [ATK:2/HP:1] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA09_10", new List<Enchantment> {
				// TODO [LOEA09_10] Hungry Naga && Test: Hungry Naga_LOEA09_10
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_11] Hungry Naga (*) - COST:3 [ATK:1/HP:1] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA09_11", new List<Enchantment> {
				// TODO [LOEA09_11] Hungry Naga && Test: Hungry Naga_LOEA09_11
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_12] Hungry Naga (*) - COST:4 [ATK:2/HP:1] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA09_12", new List<Enchantment> {
				// TODO [LOEA09_12] Hungry Naga && Test: Hungry Naga_LOEA09_12
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_13] Hungry Naga (*) - COST:5 [ATK:5/HP:1] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA09_13", new List<Enchantment> {
				// TODO [LOEA09_13] Hungry Naga && Test: Hungry Naga_LOEA09_13
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_5] Hungry Naga (*) - COST:1 [ATK:1/HP:1] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA09_5", new List<Enchantment> {
				// TODO [LOEA09_5] Hungry Naga && Test: Hungry Naga_LOEA09_5
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_5H] Hungry Naga (*) - COST:3 [ATK:3/HP:3] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA09_5H", new List<Enchantment> {
				// TODO [LOEA09_5H] Hungry Naga && Test: Hungry Naga_LOEA09_5H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_6] Slithering Archer (*) - COST:2 [ATK:2/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NONSELF_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("LOEA09_6", new List<Enchantment> {
				// TODO [LOEA09_6] Slithering Archer && Test: Slithering Archer_LOEA09_6
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_6H] Slithering Archer (*) - COST:2 [ATK:2/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_6H", new List<Enchantment> {
				// TODO [LOEA09_6H] Slithering Archer && Test: Slithering Archer_LOEA09_6H
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_7] Cauldron (*) - COST:0 [ATK:0/HP:5] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Save Sir Finley and stop the Naga onslaught!
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_7", new List<Enchantment> {
				// TODO [LOEA09_7] Cauldron && Test: Cauldron_LOEA09_7
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_7H] Cauldron (*) - COST:0 [ATK:0/HP:10] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Save Sir Finley!
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_7H", new List<Enchantment> {
				// TODO [LOEA09_7H] Cauldron && Test: Cauldron_LOEA09_7H
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_8] Slithering Guard (*) - COST:5 [ATK:3/HP:6] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_8", new List<Enchantment> {
				// TODO [LOEA09_8] Slithering Guard && Test: Slithering Guard_LOEA09_8
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_8H] Slithering Guard (*) - COST:5 [ATK:5/HP:7] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_8H", new List<Enchantment> {
				// TODO [LOEA09_8H] Slithering Guard && Test: Slithering Guard_LOEA09_8H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA15_3] Boneraptor (*) - COST:3 [ATK:2/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b>Take control of your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOEA15_3", new List<Enchantment> {
				// TODO [LOEA15_3] Boneraptor && Test: Boneraptor_LOEA15_3
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA15_3H] Boneraptor (*) - COST:3 [ATK:2/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b>Take control of your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOEA15_3H", new List<Enchantment> {
				// TODO [LOEA15_3H] Boneraptor && Test: Boneraptor_LOEA15_3H
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_17] Animated Statue (*) - COST:10 [ATK:10/HP:10] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA16_17", new List<Enchantment> {
				// TODO [LOEA16_17] Animated Statue && Test: Animated Statue_LOEA16_17
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_18] Zinaar (*) - COST:5 [ATK:5/HP:5] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, gain a wish.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_18", new List<Enchantment> {
				// TODO [LOEA16_18] Zinaar && Test: Zinaar_LOEA16_18
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_18H] Zinaar (*) - COST:10 [ATK:10/HP:10] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, gain a wish.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_18H", new List<Enchantment> {
				// TODO [LOEA16_18H] Zinaar && Test: Zinaar_LOEA16_18H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_19] Sun Raider Phaerix (*) - COST:5 [ATK:5/HP:5] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, add a Blessing of the Sun to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_19", new List<Enchantment> {
				// TODO [LOEA16_19] Sun Raider Phaerix && Test: Sun Raider Phaerix_LOEA16_19
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_19H] Sun Raider Phaerix (*) - COST:10 [ATK:10/HP:10] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your other minions are <b>Immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_19H", new List<Enchantment> {
				// TODO [LOEA16_19H] Sun Raider Phaerix && Test: Sun Raider Phaerix_LOEA16_19H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_21] Chieftain Scarvash (*) - COST:5 [ATK:5/HP:5] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: Enemy cards cost (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_21", new List<Enchantment> {
				// TODO [LOEA16_21] Chieftain Scarvash && Test: Chieftain Scarvash_LOEA16_21
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_21H] Chieftain Scarvash (*) - COST:10 [ATK:10/HP:10] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: Enemy cards cost (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_21H", new List<Enchantment> {
				// TODO [LOEA16_21H] Chieftain Scarvash && Test: Chieftain Scarvash_LOEA16_21H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_22] Archaedas (*) - COST:5 [ATK:5/HP:5] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, turn a random enemy minion into a 0/2 Statue.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_22", new List<Enchantment> {
				// TODO [LOEA16_22] Archaedas && Test: Archaedas_LOEA16_22
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_22H] Archaedas (*) - COST:10 [ATK:10/HP:10] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, turn a random enemy minion into a 0/2 Statue.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_22H", new List<Enchantment> {
				// TODO [LOEA16_22H] Archaedas && Test: Archaedas_LOEA16_22H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_23] Lord Slitherspear (*) - COST:5 [ATK:5/HP:5] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, summon 1/1 Hungry Naga for each enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_23", new List<Enchantment> {
				// TODO [LOEA16_23] Lord Slitherspear && Test: Lord Slitherspear_LOEA16_23
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_23H] Lord Slitherspear (*) - COST:10 [ATK:10/HP:10] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, summon 1/1 Hungry Naga for each enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_23H", new List<Enchantment> {
				// TODO [LOEA16_23H] Lord Slitherspear && Test: Lord Slitherspear_LOEA16_23H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_24] Giantfin (*) - COST:5 [ATK:5/HP:5] 
			// - Race: murloc, Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, draw until you have as many cards as your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_24", new List<Enchantment> {
				// TODO [LOEA16_24] Giantfin && Test: Giantfin_LOEA16_24
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_24H] Giantfin (*) - COST:10 [ATK:10/HP:10] 
			// - Race: murloc, Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, draw 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_24H", new List<Enchantment> {
				// TODO [LOEA16_24H] Giantfin && Test: Giantfin_LOEA16_24H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_25] Lady Naz'jar (*) - COST:5 [ATK:5/HP:5] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, replace all other minions with new ones of the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_25", new List<Enchantment> {
				// TODO [LOEA16_25] Lady Naz'jar && Test: Lady Naz'jar_LOEA16_25
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_25H] Lady Naz'jar (*) - COST:10 [ATK:10/HP:10] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, replace all other minions with new ones of the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_25H", new List<Enchantment> {
				// TODO [LOEA16_25H] Lady Naz'jar && Test: Lady Naz'jar_LOEA16_25H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_26] Skelesaurus Hex (*) - COST:5 [ATK:5/HP:5] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, give each player a random card. It costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_26", new List<Enchantment> {
				// TODO [LOEA16_26] Skelesaurus Hex && Test: Skelesaurus Hex_LOEA16_26
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_26H] Skelesaurus Hex (*) - COST:10 [ATK:10/HP:10] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, put a random card in your hand. It costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_26H", new List<Enchantment> {
				// TODO [LOEA16_26H] Skelesaurus Hex && Test: Skelesaurus Hex_LOEA16_26H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_27] The Steel Sentinel (*) - COST:5 [ATK:5/HP:5] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: This minion can only take 1 damage at a time.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_27", new List<Enchantment> {
				// TODO [LOEA16_27] The Steel Sentinel && Test: The Steel Sentinel_LOEA16_27
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_27H] The Steel Sentinel (*) - COST:10 [ATK:10/HP:10] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: This minion can only take 1 damage at a time.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_27H", new List<Enchantment> {
				// TODO [LOEA16_27H] The Steel Sentinel && Test: The Steel Sentinel_LOEA16_27H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_5t] Mummy Zombie (*) - COST:3 [ATK:3/HP:3] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOEA16_5t", new List<Enchantment> {
				// TODO [LOEA16_5t] Mummy Zombie && Test: Mummy Zombie_LOEA16_5t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [LOEA09_4] Rare Spear (*) - COST:1 [ATK:1/HP:0] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Whenever your opponent plays a Rare card, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("LOEA09_4", new List<Enchantment> {
				// TODO [LOEA09_4] Rare Spear && Test: Rare Spear_LOEA09_4
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [LOEA09_4H] Rare Spear (*) - COST:1 [ATK:1/HP:0] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Whenever your opponent plays a Rare card, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("LOEA09_4H", new List<Enchantment> {
				// TODO [LOEA09_4H] Rare Spear && Test: Rare Spear_LOEA09_4H
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		public static void AddAll(Dictionary<string, List<Enchantment>> cards)
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
