using System.Collections.Generic;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.CardSets
{
	public class GvgCardsGen
	{
		private static void Druid(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [GVG_031] Recycle - COST:6 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Shuffle an enemy minion into your opponent's deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_031", new List<Enchantment> {
				// TODO  MoveToDeck Opponent
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new CopyTask(EntityType.TARGET, 1),
                        new AddStackTo(EntityType.OP_DECK),
                        new DestroyTask(EntityType.TARGET))
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_033] Tree of Life - COST:9 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Restore all characters to full Health.
			// --------------------------------------------------------
			cards.Add("GVG_033", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new HealFullTask(EntityType.ALL)
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_041] Dark Wispers - COST:6 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Summon 5 Wisps; or Give_a minion +5/+5 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GVG_041", new List<Enchantment> {
				// TODO [GVG_041] Dark Wispers && Test: Dark Wispers_GVG_041
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- MINION - DRUID
			// [GVG_030] Anodized Robo Cub - COST:2 [ATK:2/HP:2] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Choose One -</b>
			//       +1 Attack; or +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("GVG_030", new List<Enchantment> {
				// TODO [GVG_030] Anodized Robo Cub && Test: Anodized Robo Cub_GVG_030
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - DRUID
			// [GVG_032] Grove Tender - COST:3 [ATK:2/HP:4] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Give each player a Mana Crystal; or Each player draws a card.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("GVG_032", new List<Enchantment> {
				// TODO [GVG_032] Grove Tender && Test: Grove Tender_GVG_032
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - DRUID
			// [GVG_034] Mech-Bear-Cat - COST:6 [ATK:7/HP:6] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, add a <b>Spare Part</b> card to your hand.
			// --------------------------------------------------------
			// Entourage: PART_007, PART_006, PART_005, PART_001, PART_003, PART_002, PART_004
			// --------------------------------------------------------
			// RefTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("GVG_034", new List<Enchantment> {
				// TODO [GVG_034] Mech-Bear-Cat && Test: Mech-Bear-Cat_GVG_034
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - DRUID
			// [GVG_035] Malorne - COST:7 [ATK:9/HP:7] 
			// - Race: beast, Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle this minion into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_035", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = new AddCardTo("GVG_035", EntityType.DECK)
				},
			});

			// ----------------------------------------- MINION - DRUID
			// [GVG_080] Druid of the Fang - COST:5 [ATK:4/HP:4] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a Beast, transform this minion into a 7/7.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_080", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingRace(Race.BEAST)),
                        new FlagTask(true, ComplexTask.Create(
                            new SetAttackTask(7, EntityType.SOURCE),
                            new SetHealthTask(7, EntityType.SOURCE))))
				},
			});

		}

		private static void DruidNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [GVG_030a] Attack Mode (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_030a", new List<Enchantment> {
				// TODO [GVG_030a] Attack Mode && Test: Attack Mode_GVG_030a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_030b] Tank Mode (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +1 Health.
			// --------------------------------------------------------
			cards.Add("GVG_030b", new List<Enchantment> {
				// TODO [GVG_030b] Tank Mode && Test: Tank Mode_GVG_030b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_032a] Gift of Mana (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Give each player a Mana Crystal.
			// --------------------------------------------------------
			cards.Add("GVG_032a", new List<Enchantment> {
				// TODO [GVG_032a] Gift of Mana && Test: Gift of Mana_GVG_032a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_032b] Gift of Cards (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Each player draws a card.
			// --------------------------------------------------------
			cards.Add("GVG_032b", new List<Enchantment> {
				// TODO [GVG_032b] Gift of Cards && Test: Gift of Cards_GVG_032b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_041a] Dark Wispers (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +5/+5 and <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_041a", new List<Enchantment> {
				// TODO [GVG_041a] Dark Wispers && Test: Dark Wispers_GVG_041a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_041b] Dark Wispers (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Summon 5 Wisps.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("GVG_041b", new List<Enchantment> {
				// TODO [GVG_041b] Dark Wispers && Test: Dark Wispers_GVG_041b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [GVG_030ae] Attack Mode (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_030ae", new List<Enchantment> {
				// TODO [GVG_030ae] Attack Mode && Test: Attack Mode_GVG_030ae
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [GVG_030be] Tank Mode (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +1 Health.
			// --------------------------------------------------------
			cards.Add("GVG_030be", new List<Enchantment> {
				// TODO [GVG_030be] Tank Mode && Test: Tank Mode_GVG_030be
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [GVG_041c] Dark Wispers (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +5/+5 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("GVG_041c", new List<Enchantment> {
				// TODO [GVG_041c] Dark Wispers && Test: Dark Wispers_GVG_041c
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - DRUID
			// [GVG_080t] Druid of the Fang (*) - COST:5 [ATK:7/HP:7] 
			// - Race: beast, Set: pe1, 
			// --------------------------------------------------------
			cards.Add("GVG_080t", new List<Enchantment> {
				// TODO [GVG_080t] Druid of the Fang && Test: Druid of the Fang_GVG_080t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Hunter(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - HUNTER
			// [GVG_017] Call Pet - COST:2 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw a card.
			//       If it's a Beast, it costs (4) less.
			// --------------------------------------------------------
			cards.Add("GVG_017", new List<Enchantment> {
				// TODO [GVG_017] Call Pet && Test: Call Pet_GVG_017
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [GVG_026] Feign Death - COST:2 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Trigger all <b>Deathrattles</b> on your minions.
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_026", new List<Enchantment> {
				// TODO [GVG_026] Feign Death && Test: Feign Death_GVG_026
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [GVG_073] Cobra Shot - COST:5 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage to a minion and the enemy hero. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_073", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DamageTask(3, EntityType.TARGET, true),
                        new DamageTask(3, EntityType.OP_HERO, true))

                },
			});

			// ---------------------------------------- MINION - HUNTER
			// [GVG_046] King of Beasts - COST:5 [ATK:2/HP:6] 
			// - Race: beast, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Battlecry:</b> Gain +1 Attack for each other Beast you have.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_046", new List<Enchantment> {
				// TODO [GVG_046] King of Beasts && Test: King of Beasts_GVG_046
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - HUNTER
			// [GVG_048] Metaltooth Leaper - COST:3 [ATK:3/HP:3] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your other Mechs +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_048", new List<Enchantment> {
				// TODO [GVG_048] Metaltooth Leaper && Test: Metaltooth Leaper_GVG_048
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - HUNTER
			// [GVG_049] Gahz'rilla - COST:7 [ATK:6/HP:9] 
			// - Race: beast, Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, double its Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_049", new List<Enchantment> {
				// TODO [GVG_049] Gahz'rilla && Test: Gahz'rilla_GVG_049
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - HUNTER
			// [GVG_087] Steamwheedle Sniper - COST:2 [ATK:2/HP:3] 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your Hero Power can target minions.
			// --------------------------------------------------------
			cards.Add("GVG_087", new List<Enchantment> {
				// TODO [GVG_087] Steamwheedle Sniper && Test: Steamwheedle Sniper_GVG_087
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- WEAPON - HUNTER
			// [GVG_043] Glaivezooka - COST:2 [ATK:2/HP:0] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random friendly minion +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_043", new List<Enchantment> {
				// TODO [GVG_043] Glaivezooka && Test: Glaivezooka_GVG_043
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
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
			// [GVG_043e] Glaivezooka (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_043e", new List<Enchantment> {
				// TODO [GVG_043e] Glaivezooka && Test: Glaivezooka_GVG_043e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [GVG_046e] The King (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("GVG_046e", new List<Enchantment> {
				// TODO [GVG_046e] The King && Test: The King_GVG_046e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [GVG_048e] Metal Teeth (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_048e", new List<Enchantment> {
				// TODO [GVG_048e] Metal Teeth && Test: Metal Teeth_GVG_048e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [GVG_049e] Might of Zul'Farrak (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Multiplying Attack.
			// --------------------------------------------------------
			cards.Add("GVG_049e", new List<Enchantment> {
				// TODO [GVG_049e] Might of Zul'Farrak && Test: Might of Zul'Farrak_GVG_049e
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
			// [GVG_001] Flamecannon - COST:2 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage to a random enemy minion. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("GVG_001", new List<Enchantment> {
				// TODO [GVG_001] Flamecannon && Test: Flamecannon_GVG_001
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [GVG_003] Unstable Portal - COST:2 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Add a random minion to your hand. It costs (3) less.
			// --------------------------------------------------------
			cards.Add("GVG_003", new List<Enchantment> {
				// TODO [GVG_003] Unstable Portal && Test: Unstable Portal_GVG_003
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [GVG_005] Echo of Medivh - COST:4 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Put a copy of each friendly minion into your hand.
			// --------------------------------------------------------
			cards.Add("GVG_005", new List<Enchantment> {
				// TODO [GVG_005] Echo of Medivh && Test: Echo of Medivh_GVG_005
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ MINION - MAGE
			// [GVG_002] Snowchugger - COST:2 [ATK:2/HP:3] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> any character damaged by this minion.
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("GVG_002", new List<Enchantment> {
				// TODO [GVG_002] Snowchugger && Test: Snowchugger_GVG_002
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ------------------------------------------ MINION - MAGE
			// [GVG_004] Goblin Blastmage - COST:4 [ATK:5/HP:4] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a Mech, deal 4 damage randomly split among all enemies.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_004", new List<Enchantment> {
				// TODO [GVG_004] Goblin Blastmage && Test: Goblin Blastmage_GVG_004
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ------------------------------------------ MINION - MAGE
			// [GVG_007] Flame Leviathan - COST:7 [ATK:7/HP:7] 
			// - Race: mechanical, Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: When you draw this, deal 2 damage to all characters.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("GVG_007", new List<Enchantment> {
				// TODO [GVG_007] Flame Leviathan && Test: Flame Leviathan_GVG_007
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ------------------------------------------ MINION - MAGE
			// [GVG_122] Wee Spellstopper - COST:4 [ATK:2/HP:5] 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Adjacent minions can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_122", new List<Enchantment> {
				// TODO [GVG_122] Wee Spellstopper && Test: Wee Spellstopper_GVG_122
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ------------------------------------------ MINION - MAGE
			// [GVG_123] Soot Spewer - COST:3 [ATK:3/HP:3] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("GVG_123", new List<Enchantment> {
				// TODO [GVG_123] Soot Spewer && Test: Soot Spewer_GVG_123
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [GVG_123e] Overclocked (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Spell Damage +2.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 2
			// --------------------------------------------------------
			cards.Add("GVG_123e", new List<Enchantment> {
				// TODO [GVG_123e] Overclocked && Test: Overclocked_GVG_123e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Paladin(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - PALADIN
			// [GVG_057] Seal of Light - COST:2 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #4 Health to your hero and gain +2 Attack this turn.
			// --------------------------------------------------------
			cards.Add("GVG_057", new List<Enchantment> {
				// TODO [GVG_057] Seal of Light && Test: Seal of Light_GVG_057
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [GVG_061] Muster for Battle - COST:3 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon three 1/1 Silver Hand Recruits. Equip a 1/4 Weapon.
			// --------------------------------------------------------
			cards.Add("GVG_061", new List<Enchantment> {
				// TODO [GVG_061] Muster for Battle && Test: Muster for Battle_GVG_061
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - PALADIN
			// [GVG_058] Shielded Minibot - COST:2 [ATK:2/HP:2] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GVG_058", new List<Enchantment> {
				// TODO [GVG_058] Shielded Minibot && Test: Shielded Minibot_GVG_058
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - PALADIN
			// [GVG_060] Quartermaster - COST:5 [ATK:2/HP:5] 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your Silver Hand Recruits +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_060", new List<Enchantment> {
				// TODO [GVG_060] Quartermaster && Test: Quartermaster_GVG_060
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - PALADIN
			// [GVG_062] Cobalt Guardian - COST:5 [ATK:6/HP:3] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you summon a Mech, gain <b>Divine Shield</b>.
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GVG_062", new List<Enchantment> {
				// TODO [GVG_062] Cobalt Guardian && Test: Cobalt Guardian_GVG_062
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - PALADIN
			// [GVG_063] Bolvar Fordragon - COST:5 [ATK:1/HP:7] 
			// - Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever a friendly minion dies while this is in your hand, gain +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_063", new List<Enchantment> {
				// TODO [GVG_063] Bolvar Fordragon && Test: Bolvar Fordragon_GVG_063
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - PALADIN
			// [GVG_101] Scarlet Purifier - COST:3 [ATK:4/HP:3] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage to all minions with <b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_101", new List<Enchantment> {
				// TODO [GVG_101] Scarlet Purifier && Test: Scarlet Purifier_GVG_101
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - PALADIN
			// [GVG_059] Coghammer - COST:3 [ATK:2/HP:0] 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random friendly minion <b>Divine Shield</b> and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GVG_059", new List<Enchantment> {
				// TODO [GVG_059] Coghammer && Test: Coghammer_GVG_059
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
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
			// [GVG_060e] Well Equipped (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_060e", new List<Enchantment> {
				// TODO [GVG_060e] Well Equipped && Test: Well Equipped_GVG_060e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [GVG_101e] Pure (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Increased Stats.
			// --------------------------------------------------------
			cards.Add("GVG_101e", new List<Enchantment> {
				// TODO [GVG_101e] Pure && Test: Pure_GVG_101e
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
			// [GVG_008] Lightbomb - COST:6 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal damage to each minion equal to its Attack. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("GVG_008", new List<Enchantment> {
				// TODO [GVG_008] Lightbomb && Test: Lightbomb_GVG_008
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [GVG_010] Velen's Chosen - COST:3 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2/+4 and <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("GVG_010", new List<Enchantment> {
				// TODO [GVG_010] Velen's Chosen && Test: Velen's Chosen_GVG_010
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [GVG_012] Light of the Naaru - COST:1 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Restore #3 Health. If the target is still damaged, summon a Lightwarden.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_012", new List<Enchantment> {
				// TODO [GVG_012] Light of the Naaru && Test: Light of the Naaru_GVG_012
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - PRIEST
			// [GVG_009] Shadowbomber - COST:1 [ATK:2/HP:1] 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_009", new List<Enchantment> {
				// TODO [GVG_009] Shadowbomber && Test: Shadowbomber_GVG_009
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - PRIEST
			// [GVG_011] Shrinkmeister - COST:2 [ATK:3/HP:2] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a minion -2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("GVG_011", new List<Enchantment> {
				// TODO [GVG_011] Shrinkmeister && Test: Shrinkmeister_GVG_011
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - PRIEST
			// [GVG_014] Vol'jin - COST:5 [ATK:6/HP:2] 
			// - Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Swap Health with another minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("GVG_014", new List<Enchantment> {
				// TODO [GVG_014] Vol'jin && Test: Vol'jin_GVG_014
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - PRIEST
			// [GVG_072] Shadowboxer - COST:2 [ATK:2/HP:3] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a character is healed, deal 1 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("GVG_072", new List<Enchantment> {
				// TODO [GVG_072] Shadowboxer && Test: Shadowboxer_GVG_072
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - PRIEST
			// [GVG_083] Upgraded Repair Bot - COST:5 [ATK:5/HP:5] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Mech +4 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 17
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("GVG_083", new List<Enchantment> {
				// TODO [GVG_083] Upgraded Repair Bot && Test: Upgraded Repair Bot_GVG_083
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void PriestNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [GVG_014a] Shadowed (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Health was swapped.
			// --------------------------------------------------------
			cards.Add("GVG_014a", new List<Enchantment> {
				// TODO [GVG_014a] Shadowed && Test: Shadowed_GVG_014a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [GVG_069a] Repairs! (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +4 Health.
			// --------------------------------------------------------
			cards.Add("GVG_069a", new List<Enchantment> {
				// TODO [GVG_069a] Repairs! && Test: Repairs!_GVG_069a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Rogue(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [GVG_022] Tinker's Sharpsword Oil - COST:4 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Give your weapon +3 Attack. <b>Combo:</b> Give a random friendly minion +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_022", new List<Enchantment> {
				// TODO [GVG_022] Tinker's Sharpsword Oil && Test: Tinker's Sharpsword Oil_GVG_022
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [GVG_047] Sabotage - COST:4 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a random enemy minion. <b>Combo:</b> And your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_047", new List<Enchantment> {
				// TODO [GVG_047] Sabotage && Test: Sabotage_GVG_047
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- MINION - ROGUE
			// [GVG_023] Goblin Auto-Barber - COST:2 [ATK:3/HP:2] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your weapon +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_023", new List<Enchantment> {
				// TODO [GVG_023] Goblin Auto-Barber && Test: Goblin Auto-Barber_GVG_023
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ----------------------------------------- MINION - ROGUE
			// [GVG_025] One-eyed Cheat - COST:2 [ATK:4/HP:1] 
			// - Race: pirate, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you summon a Pirate, gain <b>Stealth</b>.
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("GVG_025", new List<Enchantment> {
				// TODO [GVG_025] One-eyed Cheat && Test: One-eyed Cheat_GVG_025
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - ROGUE
			// [GVG_027] Iron Sensei - COST:3 [ATK:2/HP:2] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, give another friendly Mech +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_027", new List<Enchantment> {
				// TODO [GVG_027] Iron Sensei && Test: Iron Sensei_GVG_027
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - ROGUE
			// [GVG_028] Trade Prince Gallywix - COST:6 [ATK:5/HP:8] 
			// - Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, gain a copy of it and give them a Coin.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_028", new List<Enchantment> {
				// TODO [GVG_028] Trade Prince Gallywix && Test: Trade Prince Gallywix_GVG_028
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - ROGUE
			// [GVG_088] Ogre Ninja - COST:5 [ATK:6/HP:6] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - FORGETFUL = 1
			// --------------------------------------------------------
			cards.Add("GVG_088", new List<Enchantment> {
				// TODO [GVG_088] Ogre Ninja && Test: Ogre Ninja_GVG_088
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [GVG_024] Cogmaster's Wrench - COST:3 [ATK:1/HP:0] 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Has +2 Attack while you have a Mech.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_024", new List<Enchantment> {
				// TODO [GVG_024] Cogmaster's Wrench && Test: Cogmaster's Wrench_GVG_024
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [GVG_027e] Ironed Out (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GVG_027e", new List<Enchantment> {
				// TODO [GVG_027e] Ironed Out && Test: Ironed Out_GVG_027e
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
			// [GVG_029] Ancestor's Call - COST:4 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Put a random minion from each player's hand into the battlefield.
			// --------------------------------------------------------
			cards.Add("GVG_029", new List<Enchantment> {
				// TODO [GVG_029] Ancestor's Call && Test: Ancestor's Call_GVG_029
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [GVG_038] Crackle - COST:2 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3-$6 damage. <b>Overload:</b> (1) *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_038", new List<Enchantment> {
				// TODO [GVG_038] Crackle && Test: Crackle_GVG_038
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GVG_037] Whirling Zap-o-matic - COST:2 [ATK:3/HP:2] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("GVG_037", new List<Enchantment> {
				// TODO [GVG_037] Whirling Zap-o-matic && Test: Whirling Zap-o-matic_GVG_037
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GVG_039] Vitality Totem - COST:2 [ATK:0/HP:3] 
			// - Race: totem, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 4 Health to your hero.
			// --------------------------------------------------------
			cards.Add("GVG_039", new List<Enchantment> {
				// TODO [GVG_039] Vitality Totem && Test: Vitality Totem_GVG_039
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GVG_040] Siltfin Spiritwalker - COST:4 [ATK:2/HP:5] 
			// - Race: murloc, Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever another friendly Murloc dies, draw a card. <b><b>Overload</b>:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			cards.Add("GVG_040", new List<Enchantment> {
				// TODO [GVG_040] Siltfin Spiritwalker && Test: Siltfin Spiritwalker_GVG_040
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GVG_042] Neptulon - COST:7 [ATK:7/HP:7] 
			// - Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add 4 random Murlocs to your hand. <b>Overload:</b> (3)
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - OVERLOAD = 3
			// - BATTLECRY = 1
			// - OVERLOAD_OWED = 3
			// --------------------------------------------------------
			cards.Add("GVG_042", new List<Enchantment> {
				// TODO [GVG_042] Neptulon && Test: Neptulon_GVG_042
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GVG_066] Dunemaul Shaman - COST:4 [ATK:5/HP:4] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Windfury, Overload:</b> (1)
			//       50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// - FORGETFUL = 1
			// --------------------------------------------------------
			cards.Add("GVG_066", new List<Enchantment> {
				// TODO [GVG_066] Dunemaul Shaman && Test: Dunemaul Shaman_GVG_066
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [GVG_036] Powermace - COST:3 [ATK:3/HP:0] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give a random friendly Mech +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_036", new List<Enchantment> {
				// TODO [GVG_036] Powermace && Test: Powermace_GVG_036
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

		}

		private static void ShamanNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [GVG_036e] Powered (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_036e", new List<Enchantment> {
				// TODO [GVG_036e] Powered && Test: Powered_GVG_036e
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
			// [GVG_015] Darkbomb - COST:2 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_015", new List<Enchantment> {
				// TODO [GVG_015] Darkbomb && Test: Darkbomb_GVG_015
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [GVG_019] Demonheart - COST:5 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $5 damage to a minion.  If it's a friendly Demon, give it +5/+5 instead. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_019", new List<Enchantment> {
				// TODO [GVG_019] Demonheart && Test: Demonheart_GVG_019
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [GVG_045] Imp-losion - COST:4 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2-$4 damage to a minion. Summon a 1/1 Imp for each damage dealt. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_045", new List<Enchantment> {
				// TODO [GVG_045] Imp-losion && Test: Imp-losion_GVG_045
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARLOCK
			// [GVG_018] Mistress of Pain - COST:2 [ATK:1/HP:4] 
			// - Race: demon, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever this minion deals damage, restore that much Health to your hero.
			// --------------------------------------------------------
			cards.Add("GVG_018", new List<Enchantment> {
				// TODO [GVG_018] Mistress of Pain && Test: Mistress of Pain_GVG_018
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARLOCK
			// [GVG_020] Fel Cannon - COST:4 [ATK:3/HP:5] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 2 damage to a non-Mech minion.
			// --------------------------------------------------------
			cards.Add("GVG_020", new List<Enchantment> {
				// TODO [GVG_020] Fel Cannon && Test: Fel Cannon_GVG_020
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARLOCK
			// [GVG_021] Mal'Ganis - COST:9 [ATK:9/HP:7] 
			// - Race: demon, Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your other Demons have +2/+2.
			//       Your hero is <b>Immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("GVG_021", new List<Enchantment> {
				// TODO [GVG_021] Mal'Ganis && Test: Mal'Ganis_GVG_021
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARLOCK
			// [GVG_077] Anima Golem - COST:6 [ATK:9/HP:9] 
			// - Race: mechanical, Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of each turn, destroy this minion if it's your only one.
			// --------------------------------------------------------
			cards.Add("GVG_077", new List<Enchantment> {
				// TODO [GVG_077] Anima Golem && Test: Anima Golem_GVG_077
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARLOCK
			// [GVG_100] Floating Watcher - COST:5 [ATK:4/HP:4] 
			// - Race: demon, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your hero takes damage on your turn, gain +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_100", new List<Enchantment> {
				// TODO [GVG_100] Floating Watcher && Test: Floating Watcher_GVG_100
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void WarlockNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [GVG_019e] Demonheart (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +5/+5.
			// --------------------------------------------------------
			cards.Add("GVG_019e", new List<Enchantment> {
				// TODO [GVG_019e] Demonheart && Test: Demonheart_GVG_019e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [GVG_021e] Grasp of Mal'Ganis (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Mal'Ganis is granting +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_021e", new List<Enchantment> {
				// TODO [GVG_021e] Grasp of Mal'Ganis && Test: Grasp of Mal'Ganis_GVG_021e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [GVG_100e] Brow Furrow (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GVG_100e", new List<Enchantment> {
				// TODO [GVG_100e] Brow Furrow && Test: Brow Furrow_GVG_100e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARLOCK
			// [GVG_045t] Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Set: pe1, 
			// --------------------------------------------------------
			cards.Add("GVG_045t", new List<Enchantment> {
				// TODO [GVG_045t] Imp && Test: Imp_GVG_045t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Warrior(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [GVG_050] Bouncing Blade - COST:3 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $1 damage to a random minion. Repeat until a minion dies. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("GVG_050", new List<Enchantment> {
				// TODO [GVG_050] Bouncing Blade && Test: Bouncing Blade_GVG_050
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [GVG_052] Crush - COST:7 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. If you have a damaged minion, this costs (4) less.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_052", new List<Enchantment> {
				// TODO [GVG_052] Crush && Test: Crush_GVG_052
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [GVG_051] Warbot - COST:1 [ATK:1/HP:3] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Enrage:</b> +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("GVG_051", new List<Enchantment> {
				// TODO [GVG_051] Warbot && Test: Warbot_GVG_051
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARRIOR
			// [GVG_053] Shieldmaiden - COST:6 [ATK:5/HP:5] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain 5 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_053", new List<Enchantment> {
				// TODO [GVG_053] Shieldmaiden && Test: Shieldmaiden_GVG_053
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [GVG_055] Screwjank Clunker - COST:4 [ATK:2/HP:5] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Mech +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 17
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("GVG_055", new List<Enchantment> {
				// TODO [GVG_055] Screwjank Clunker && Test: Screwjank Clunker_GVG_055
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [GVG_056] Iron Juggernaut - COST:6 [ATK:6/HP:5] 
			// - Race: mechanical, Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle a Mine into your opponent's deck. When drawn, it explodes for 10 damage.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_056", new List<Enchantment> {
				// TODO [GVG_056] Iron Juggernaut && Test: Iron Juggernaut_GVG_056
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [GVG_086] Siege Engine - COST:5 [ATK:5/HP:5] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you gain Armor, give this minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_086", new List<Enchantment> {
				// TODO [GVG_086] Siege Engine && Test: Siege Engine_GVG_086
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [GVG_054] Ogre Warmaul - COST:3 [ATK:4/HP:0] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: 50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("GVG_054", new List<Enchantment> {
				// TODO [GVG_054] Ogre Warmaul && Test: Ogre Warmaul_GVG_054
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void WarriorNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [GVG_056t] Burrowing Mine (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: When you draw this, it explodes. You take 10 damage and draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("GVG_056t", new List<Enchantment> {
				// TODO [GVG_056t] Burrowing Mine && Test: Burrowing Mine_GVG_056t
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [GVG_051e] Enraged (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +1 Attack
			// --------------------------------------------------------
			cards.Add("GVG_051e", new List<Enchantment> {
				// TODO [GVG_051e] Enraged && Test: Enraged_GVG_051e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [GVG_055e] Screwy Jank (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_055e", new List<Enchantment> {
				// TODO [GVG_055e] Screwy Jank && Test: Screwy Jank_GVG_055e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [GVG_086e] Armor Plated (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("GVG_086e", new List<Enchantment> {
				// TODO [GVG_086e] Armor Plated && Test: Armor Plated_GVG_086e
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
			// [GVG_006] Mechwarper - COST:2 [ATK:2/HP:3] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Your Mechs cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_006", new List<Enchantment> {
				// TODO [GVG_006] Mechwarper && Test: Mechwarper_GVG_006
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_013] Cogmaster - COST:1 [ATK:1/HP:2] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Has +2 Attack while you have a Mech.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_013", new List<Enchantment> {
				// TODO [GVG_013] Cogmaster && Test: Cogmaster_GVG_013
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_016] Fel Reaver - COST:5 [ATK:8/HP:8] 
			// - Race: mechanical, Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever your opponent plays a card, remove the top 3 cards of your deck.
			// --------------------------------------------------------
			cards.Add("GVG_016", new List<Enchantment> {
				// TODO [GVG_016] Fel Reaver && Test: Fel Reaver_GVG_016
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_044] Spider Tank - COST:3 [ATK:3/HP:4] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			cards.Add("GVG_044", new List<Enchantment> {
				// TODO [GVG_044] Spider Tank && Test: Spider Tank_GVG_044
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_064] Puddlestomper - COST:2 [ATK:3/HP:2] 
			// - Race: murloc, Set: pe1, Rarity: common
			// --------------------------------------------------------
			cards.Add("GVG_064", new List<Enchantment> {
				// TODO [GVG_064] Puddlestomper && Test: Puddlestomper_GVG_064
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_065] Ogre Brute - COST:3 [ATK:4/HP:4] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: 50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - FORGETFUL = 1
			// --------------------------------------------------------
			cards.Add("GVG_065", new List<Enchantment> {
				// TODO [GVG_065] Ogre Brute && Test: Ogre Brute_GVG_065
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_067] Stonesplinter Trogg - COST:2 [ATK:2/HP:3] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_067", new List<Enchantment> {
				// TODO [GVG_067] Stonesplinter Trogg && Test: Stonesplinter Trogg_GVG_067
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_068] Burly Rockjaw Trogg - COST:4 [ATK:3/HP:5] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_068", new List<Enchantment> {
				// TODO [GVG_068] Burly Rockjaw Trogg && Test: Burly Rockjaw Trogg_GVG_068
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_069] Antique Healbot - COST:5 [ATK:3/HP:3] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 8 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_069", new List<Enchantment> {
				// TODO [GVG_069] Antique Healbot && Test: Antique Healbot_GVG_069
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_070] Salty Dog - COST:5 [ATK:7/HP:4] 
			// - Race: pirate, Set: pe1, Rarity: common
			// --------------------------------------------------------
			cards.Add("GVG_070", new List<Enchantment> {
				// TODO [GVG_070] Salty Dog && Test: Salty Dog_GVG_070
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_071] Lost Tallstrider - COST:4 [ATK:5/HP:4] 
			// - Race: beast, Set: pe1, Rarity: common
			// --------------------------------------------------------
			cards.Add("GVG_071", new List<Enchantment> {
				// TODO [GVG_071] Lost Tallstrider && Test: Lost Tallstrider_GVG_071
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_074] Kezan Mystic - COST:4 [ATK:4/HP:3] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Take control of a random enemy <b>Secret</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GVG_074", new List<Enchantment> {
				// TODO [GVG_074] Kezan Mystic && Test: Kezan Mystic_GVG_074
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_075] Ship's Cannon - COST:2 [ATK:2/HP:3] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: After you summon a Pirate, deal 2 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("GVG_075", new List<Enchantment> {
				// TODO [GVG_075] Ship's Cannon && Test: Ship's Cannon_GVG_075
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_076] Explosive Sheep - COST:2 [ATK:1/HP:1] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 2 damage to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_076", new List<Enchantment> {
				// TODO [GVG_076] Explosive Sheep && Test: Explosive Sheep_GVG_076
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_078] Mechanical Yeti - COST:4 [ATK:4/HP:5] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give each player a <b>Spare Part.</b>
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("GVG_078", new List<Enchantment> {
				// TODO [GVG_078] Mechanical Yeti && Test: Mechanical Yeti_GVG_078
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_079] Force-Tank MAX - COST:8 [ATK:7/HP:7] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GVG_079", new List<Enchantment> {
				// TODO [GVG_079] Force-Tank MAX && Test: Force-Tank MAX_GVG_079
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_081] Gilblin Stalker - COST:2 [ATK:2/HP:3] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("GVG_081", new List<Enchantment> {
				// TODO [GVG_081] Gilblin Stalker && Test: Gilblin Stalker_GVG_081
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_082] Clockwork Gnome - COST:1 [ATK:2/HP:1] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a <b>Spare Part</b> card to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("GVG_082", new List<Enchantment> {
				// TODO [GVG_082] Clockwork Gnome && Test: Clockwork Gnome_GVG_082
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_084] Flying Machine - COST:3 [ATK:1/HP:4] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("GVG_084", new List<Enchantment> {
				// TODO [GVG_084] Flying Machine && Test: Flying Machine_GVG_084
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_085] Annoy-o-Tron - COST:2 [ATK:1/HP:2] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GVG_085", new List<Enchantment> {
				// TODO [GVG_085] Annoy-o-Tron && Test: Annoy-o-Tron_GVG_085
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_089] Illuminator - COST:3 [ATK:2/HP:4] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: If you control a <b>Secret</b> at the end of your turn, restore 4 Health to your hero.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GVG_089", new List<Enchantment> {
				// TODO [GVG_089] Illuminator && Test: Illuminator_GVG_089
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_090] Madder Bomber - COST:5 [ATK:5/HP:4] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 6 damage randomly split between all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_090", new List<Enchantment> {
				// TODO [GVG_090] Madder Bomber && Test: Madder Bomber_GVG_090
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_091] Arcane Nullifier X-21 - COST:4 [ATK:2/HP:5] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CANT_BE_TARGETED_BY_ABILITIES = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("GVG_091", new List<Enchantment> {
				// TODO [GVG_091] Arcane Nullifier X-21 && Test: Arcane Nullifier X-21_GVG_091
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_092] Gnomish Experimenter - COST:3 [ATK:3/HP:2] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a card. If it's a minion, transform it into a Chicken.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_092", new List<Enchantment> {
				// TODO [GVG_092] Gnomish Experimenter && Test: Gnomish Experimenter_GVG_092
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_093] Target Dummy - COST:0 [ATK:0/HP:2] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GVG_093", new List<Enchantment> {
				// TODO [GVG_093] Target Dummy && Test: Target Dummy_GVG_093
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_094] Jeeves - COST:4 [ATK:1/HP:4] 
			// - Race: mechanical, Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of each player's turn, that player draws until they have 3 cards.
			// --------------------------------------------------------
			cards.Add("GVG_094", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new FuncNumberTask(p =>
                        {
                            var controller = p.Controller;
                            var diffHands = 3 - controller.Hand.Count;
                            return diffHands > 0 ? diffHands : 0;
                        }),
                        new EnqueueNumberTask(new DrawTask())),
                },
            });

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_095] Goblin Sapper - COST:3 [ATK:2/HP:4] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: Has +4 Attack while your opponent has 6 or more cards in hand.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_095", new List<Enchantment> {
				// TODO [GVG_095] Goblin Sapper && Test: Goblin Sapper_GVG_095
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_096] Piloted Shredder - COST:4 [ATK:4/HP:3] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random 2-Cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_096", new List<Enchantment> {
				// TODO [GVG_096] Piloted Shredder && Test: Piloted Shredder_GVG_096
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_097] Lil' Exorcist - COST:3 [ATK:2/HP:3] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Gain +1/+1 for each enemy <b>Deathrattle</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_097", new List<Enchantment> {
				// TODO [GVG_097] Lil' Exorcist && Test: Lil' Exorcist_GVG_097
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_098] Gnomeregan Infantry - COST:3 [ATK:1/HP:4] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("GVG_098", new List<Enchantment> {
				// TODO [GVG_098] Gnomeregan Infantry && Test: Gnomeregan Infantry_GVG_098
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_099] Bomb Lobber - COST:5 [ATK:3/HP:3] 
			// - Set: pe1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 4 damage to a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_099", new List<Enchantment> {
				// TODO [GVG_099] Bomb Lobber && Test: Bomb Lobber_GVG_099
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_102] Tinkertown Technician - COST:3 [ATK:3/HP:3] 
			// - Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a Mech, gain +1/+1 and add a <b>Spare Part</b> to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("GVG_102", new List<Enchantment> {
				// TODO [GVG_102] Tinkertown Technician && Test: Tinkertown Technician_GVG_102
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_103] Micro Machine - COST:2 [ATK:1/HP:2] 
			// - Race: mechanical, Set: pe1, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of each turn, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_103", new List<Enchantment> {
				// TODO [GVG_103] Micro Machine && Test: Micro Machine_GVG_103
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_104] Hobgoblin - COST:3 [ATK:2/HP:3] 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you play a 1-Attack minion, give it +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_104", new List<Enchantment> {
				// TODO [GVG_104] Hobgoblin && Test: Hobgoblin_GVG_104
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_105] Piloted Sky Golem - COST:6 [ATK:6/HP:4] 
			// - Race: mechanical, Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random 4-Cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_105", new List<Enchantment> {
				// TODO [GVG_105] Piloted Sky Golem && Test: Piloted Sky Golem_GVG_105
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_106] Junkbot - COST:5 [ATK:1/HP:5] 
			// - Race: mechanical, Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever a friendly Mech dies, gain +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_106", new List<Enchantment> {
				// TODO [GVG_106] Junkbot && Test: Junkbot_GVG_106
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_107] Enhance-o Mechano - COST:4 [ATK:3/HP:2] 
			// - Race: mechanical, Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your other minions <b>Windfury</b>, <b>Taunt</b>, or <b>Divine Shield</b>
			//       <i>(at random)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GVG_107", new List<Enchantment> {
				// TODO [GVG_107] Enhance-o Mechano && Test: Enhance-o Mechano_GVG_107
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_108] Recombobulator - COST:2 [ATK:3/HP:2] 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform a friendly minion into a random minion with the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("GVG_108", new List<Enchantment> {
				// TODO [GVG_108] Recombobulator && Test: Recombobulator_GVG_108
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_109] Mini-Mage - COST:4 [ATK:4/HP:1] 
			// - Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("GVG_109", new List<Enchantment> {
				// TODO [GVG_109] Mini-Mage && Test: Mini-Mage_GVG_109
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_110] Dr. Boom - COST:7 [ATK:7/HP:7] 
			// - Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/1 Boom Bots. <i>WARNING: Bots may explode.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_110", new List<Enchantment> {
				// TODO [GVG_110] Dr. Boom && Test: Dr. Boom_GVG_110
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_111] Mimiron's Head - COST:5 [ATK:4/HP:5] 
			// - Race: mechanical, Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the start of your turn, if you have at least 3 Mechs, destroy them all and form V-07-TR-0N.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_111", new List<Enchantment> {
				// TODO [GVG_111] Mimiron's Head && Test: Mimiron's Head_GVG_111
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_112] Mogor the Ogre - COST:6 [ATK:7/HP:6] 
			// - Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: All minions have a 50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_112", new List<Enchantment> {
				// TODO [GVG_112] Mogor the Ogre && Test: Mogor the Ogre_GVG_112
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_113] Foe Reaper 4000 - COST:8 [ATK:6/HP:9] 
			// - Race: mechanical, Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever it attacks.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_113", new List<Enchantment> {
				// TODO [GVG_113] Foe Reaper 4000 && Test: Foe Reaper 4000_GVG_113
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_114] Sneed's Old Shredder - COST:8 [ATK:5/HP:7] 
			// - Race: mechanical, Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_114", new List<Enchantment> {
				// TODO [GVG_114] Sneed's Old Shredder && Test: Sneed's Old Shredder_GVG_114
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_115] Toshley - COST:6 [ATK:5/HP:7] 
			// - Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b> Add a <b>Spare Part</b> card to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("GVG_115", new List<Enchantment> {
				// TODO [GVG_115] Toshley && Test: Toshley_GVG_115
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_116] Mekgineer Thermaplugg - COST:9 [ATK:9/HP:7] 
			// - Race: mechanical, Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever an enemy minion dies, summon a Leper Gnome.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_116", new List<Enchantment> {
				// TODO [GVG_116] Mekgineer Thermaplugg && Test: Mekgineer Thermaplugg_GVG_116
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_117] Gazlowe - COST:6 [ATK:3/HP:6] 
			// - Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you cast a 1-mana spell, add a random Mech to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_117", new List<Enchantment> {
				// TODO [GVG_117] Gazlowe && Test: Gazlowe_GVG_117
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_118] Troggzor the Earthinator - COST:7 [ATK:6/HP:6] 
			// - Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, summon a Burly Rockjaw Trogg.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_118", new List<Enchantment> {
				// TODO [GVG_118] Troggzor the Earthinator && Test: Troggzor the Earthinator_GVG_118
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_119] Blingtron 3000 - COST:5 [ATK:3/HP:4] 
			// - Race: mechanical, Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip a random weapon for each player.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_119", new List<Enchantment> {
				// TODO [GVG_119] Blingtron 3000 && Test: Blingtron 3000_GVG_119
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_120] Hemet Nesingwary - COST:5 [ATK:6/HP:3] 
			// - Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a Beast.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_WITH_RACE = 20
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("GVG_120", new List<Enchantment> {
				// TODO [GVG_120] Hemet Nesingwary && Test: Hemet Nesingwary_GVG_120
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_121] Clockwork Giant - COST:12 [ATK:8/HP:8] 
			// - Race: mechanical, Set: pe1, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each card in your opponent's hand.
			// --------------------------------------------------------
			cards.Add("GVG_121", new List<Enchantment> {
				// TODO [GVG_121] Clockwork Giant && Test: Clockwork Giant_GVG_121
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
			// [GVG_028t] Gallywix's Coin (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Gain 1 Mana Crystal this turn only.
			//       <i>(Won't trigger Gallywix.)</i>
			// --------------------------------------------------------
			cards.Add("GVG_028t", new List<Enchantment> {
				// TODO [GVG_028t] Gallywix's Coin && Test: Gallywix's Coin_GVG_028t
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_001] Armor Plating (*) - COST:1 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Give a minion +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("PART_001", new List<Enchantment> {
				// TODO [PART_001] Armor Plating && Test: Armor Plating_PART_001
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_002] Time Rewinder (*) - COST:1 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Return a friendly minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("PART_002", new List<Enchantment> {
				// TODO [PART_002] Time Rewinder && Test: Time Rewinder_PART_002
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_003] Rusty Horn (*) - COST:1 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Give a minion <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("PART_003", new List<Enchantment> {
				// TODO [PART_003] Rusty Horn && Test: Rusty Horn_PART_003
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_004] Finicky Cloakfield (*) - COST:1 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Give a friendly minion <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("PART_004", new List<Enchantment> {
				// TODO [PART_004] Finicky Cloakfield && Test: Finicky Cloakfield_PART_004
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_005] Emergency Coolant (*) - COST:1 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("PART_005", new List<Enchantment> {
				// TODO [PART_005] Emergency Coolant && Test: Emergency Coolant_PART_005
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_006] Reversing Switch (*) - COST:1 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Swap a minion's Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("PART_006", new List<Enchantment> {
				// TODO [PART_006] Reversing Switch && Test: Reversing Switch_PART_006
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_007] Whirling Blades (*) - COST:1 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Give a minion +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("PART_007", new List<Enchantment> {
				// TODO [PART_007] Whirling Blades && Test: Whirling Blades_PART_007
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_010b] Velen's Chosen (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +2/+4 and <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			cards.Add("GVG_010b", new List<Enchantment> {
				// TODO [GVG_010b] Velen's Chosen && Test: Velen's Chosen_GVG_010b
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_011a] Shrink Ray (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: -2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("GVG_011a", new List<Enchantment> {
				// TODO [GVG_011a] Shrink Ray && Test: Shrink Ray_GVG_011a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_022a] Tinker's Sharpsword Oil (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_022a", new List<Enchantment> {
				// TODO [GVG_022a] Tinker's Sharpsword Oil && Test: Tinker's Sharpsword Oil_GVG_022a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_022b] Tinker's Sharpsword Oil (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_022b", new List<Enchantment> {
				// TODO [GVG_022b] Tinker's Sharpsword Oil && Test: Tinker's Sharpsword Oil_GVG_022b
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_023a] Extra Sharp (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_023a", new List<Enchantment> {
				// TODO [GVG_023a] Extra Sharp && Test: Extra Sharp_GVG_023a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_057a] Seal of Light (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("GVG_057a", new List<Enchantment> {
				// TODO [GVG_057a] Seal of Light && Test: Seal of Light_GVG_057a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_063a] Retribution (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Increased Attack
			// --------------------------------------------------------
			cards.Add("GVG_063a", new List<Enchantment> {
				// TODO [GVG_063a] Retribution && Test: Retribution_GVG_063a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_067a] Metabolized Magic (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_067a", new List<Enchantment> {
				// TODO [GVG_067a] Metabolized Magic && Test: Metabolized Magic_GVG_067a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_068a] Metabolized Magic (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_068a", new List<Enchantment> {
				// TODO [GVG_068a] Metabolized Magic && Test: Metabolized Magic_GVG_068a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_076a] Pistons (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("GVG_076a", new List<Enchantment> {
				// TODO [GVG_076a] Pistons && Test: Pistons_GVG_076a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_102e] Might of Tinkertown (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("GVG_102e", new List<Enchantment> {
				// TODO [GVG_102e] Might of Tinkertown && Test: Might of Tinkertown_GVG_102e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_104a] HERE, TAKE BUFF. (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_104a", new List<Enchantment> {
				// TODO [GVG_104a] HERE, TAKE BUFF. && Test: HERE, TAKE BUFF._GVG_104a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_106e] Junked Up (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GVG_106e", new List<Enchantment> {
				// TODO [GVG_106e] Junked Up && Test: Junked Up_GVG_106e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [PART_001e] Armor Plating (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("PART_001e", new List<Enchantment> {
				// TODO [PART_001e] Armor Plating && Test: Armor Plating_PART_001e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [PART_004e] Cloaked (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Stealthed until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("PART_004e", new List<Enchantment> {
				// TODO [PART_004e] Cloaked && Test: Cloaked_PART_004e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [PART_006a] Switched (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Reversing Switch.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("PART_006a", new List<Enchantment> {
				// TODO [PART_006a] Switched && Test: Switched_PART_006a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [PART_007e] Whirling Blades (*) - COST:0 
			// - Set: pe1, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("PART_007e", new List<Enchantment> {
				// TODO [PART_007e] Whirling Blades && Test: Whirling Blades_PART_007e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_092t] Chicken (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: pe1, 
			// --------------------------------------------------------
			cards.Add("GVG_092t", new List<Enchantment> {
				// TODO [GVG_092t] Chicken && Test: Chicken_GVG_092t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_110t] Boom Bot (*) - COST:1 [ATK:1/HP:1] 
			// - Race: mechanical, Set: pe1, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 1-4 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_110t", new List<Enchantment> {
				// TODO [GVG_110t] Boom Bot && Test: Boom Bot_GVG_110t
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_111t] V-07-TR-0N (*) - COST:8 [ATK:4/HP:8] 
			// - Race: mechanical, Set: pe1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Mega-Windfury</b> <i>(Can attack four times a turn.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("GVG_111t", new List<Enchantment> {
				// TODO [GVG_111t] V-07-TR-0N && Test: V-07-TR-0N_GVG_111t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		public static void AddAll(Dictionary<string, List<Enchantment>> cards)
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
