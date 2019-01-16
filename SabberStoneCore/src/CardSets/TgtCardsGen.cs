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

using System;
using System.Collections.Generic;
using SabberStoneCore.Auras;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets
{
	public class TgtCardsGen
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
				PowerTask = new DamageTask(2, EntityType.TARGET, true)
			});

			// ------------------------------------- HERO_POWER - DRUID
			// [AT_132_DRUID] Dire Shapeshift (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 2 Armor and +2 Attack this turn.
			// --------------------------------------------------------
			cards.Add("AT_132_DRUID", new Power {
				PowerTask = ComplexTask.Create(
					new ArmorTask(2),
					new AddEnchantmentTask("AT_132_DRUIDe", EntityType.HERO))
			});

			// ------------------------------------ HERO_POWER - HUNTER
			// [AT_132_HUNTER] Ballista Shot (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $3 damage to the enemy hero.@<b>Hero Power</b>
			//       Deal $3 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_STEADY_SHOT = 0
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("AT_132_HUNTER", new Power {
				PowerTask = new DamageTask(3, EntityType.OP_HERO)
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
				PowerTask = new DamageTask(2, EntityType.TARGET)
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
				PowerTask = new SummonTask("CS2_101t", 2)
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
				PowerTask = new HealTask(4, EntityType.TARGET)
			});

			// ------------------------------------- HERO_POWER - ROGUE
			// [AT_132_ROGUE] Poisoned Daggers (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Equip a 2/2 Weapon.
			// --------------------------------------------------------
			cards.Add("AT_132_ROGUE", new Power {
				PowerTask = new WeaponTask("AT_132_ROGUEt")
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
				PowerTask = new DiscoverTask(DiscoverType.BASIC_TOTEM)
			});

			// ----------------------------------- HERO_POWER - WARLOCK
			// [AT_132_WARLOCK] Soul Tap (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw a card.
			// --------------------------------------------------------
			cards.Add("AT_132_WARLOCK", new Power {
				PowerTask = new DrawTask()
			});

			// ----------------------------------- HERO_POWER - WARRIOR
			// [AT_132_WARRIOR] Tank Up! (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 4 Armor.
			// --------------------------------------------------------
			cards.Add("AT_132_WARRIOR", new Power {
				PowerTask = new ArmorTask(4)
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
				PowerTask = new ManaCrystalEmptyTask(1),
				DeathrattleTask = new ManaCrystalEmptyTask(-1)
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
				Trigger = TriggerBuilder.Type(TriggerType.INSPIRE)
					.SetTask(new AddEnchantmentTask("AT_039e", EntityType.HERO))
					.GetTrigger()
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
				PowerTask = new AddEnchantmentTask("AT_040e", EntityType.TARGET)
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_041] Knight of the Wild - COST:7 [ATK:6/HP:6] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you summon a Beast, reduce the Cost of this card by (1).
			// --------------------------------------------------------
			cards.Add("AT_041", new Power {
				Trigger = TriggerBuilder
					.Type(TriggerType.SUMMON)
					.SetTask(new AddEnchantmentTask("AT_041e", EntityType.SOURCE))
					.SetSource(TriggerSource.FRIENDLY)
					.SetCondition(SelfCondition.IsRace(Race.BEAST))
					.SetActivation(TriggerActivation.HAND)
					.GetTrigger()
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
				PowerTask = new TransformTask("OG_044c", EntityType.SOURCE)
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
				Aura = new Aura(AuraType.HAND, Effects.SetCost(1))
				{
					Condition = SelfCondition.IsMinion
				}
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
			cards.Add("AT_037", null);

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
				PowerTask = ComplexTask.Create(
				new DiscardTask(EntityType.HAND),
						  ComplexTask.ExcessManaCheck,
						  new ManaCrystalFullTask(10))
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
				PowerTask = ComplexTask.Create(
						new DestroyTask(EntityType.TARGET),
						new RandomCardTask(CardType.MINION, CardClass.INVALID, opposite: true),
						new AddStackTo(EntityType.OP_HAND))
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
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_039e")
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [AT_040e] Kindred Spirit (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("AT_040e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_040e")
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
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_132_DRUIDe")
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_037t] Sapling (*) - COST:1 [ATK:1/HP:1] 
			// - Set: tgt, 
			// --------------------------------------------------------
			cards.Add("AT_037t", null);

			// ----------------------------------------- MINION - DRUID
			// [AT_042t] Sabertooth Lion (*) - COST:2 [ATK:2/HP:1] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_042t", null);

			// ----------------------------------------- MINION - DRUID
			// [AT_042t2] Sabertooth Panther (*) - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("AT_042t2", null);

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
			cards.Add("OG_044c", null);

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
				PowerTask = new DamageTask(2, EntityType.TARGET, true)
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_037b] Living Roots (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Summon two 1/1 Saplings.
			// --------------------------------------------------------
			cards.Add("AT_037b", new Power {
				PowerTask = new SummonTask("AT_037t", 2)
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_042a] Lion Form (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			cards.Add("AT_042a", new Power {
				PowerTask = new TransformTask("AT_042t", EntityType.SOURCE)
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_042b] Panther Form (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Stealth</b>.
			// --------------------------------------------------------
			cards.Add("AT_042b", new Power {
				PowerTask = new TransformTask("AT_042t2", EntityType.SOURCE)
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
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingRace(Race.BEAST)),
					new FlagTask(true, ComplexTask.Create(
						new RandomMinionTask(GameTag.CARDRACE, (int)Race.BEAST),
						new SummonTask()))),
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
				PowerTask = new AddEnchantmentTask("AT_057o", EntityType.TARGET)
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
				PowerTask = new RevealTask(new DrawStackTask())
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
				Trigger = new Trigger(TriggerType.INSPIRE)
				{
					Condition = SelfCondition.IsHandEmpty,
					SingleTask = new DamageTask(2, EntityType.OP_HERO)
				}
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
				Trigger = TriggerBuilder
					.Type(TriggerType.TAKE_DAMAGE)
					.SetTask(new DestroyTask(EntityType.TARGET))
					.SetSource(TriggerSource.ALL_MINIONS_EXCEPT_SELF)
					.GetTrigger()
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
				Trigger = TriggerBuilder
					.Type(TriggerType.TURN_END)
					.SetTask(new DamageTask(1, EntityType.ALLMINIONS_NOSOURCE))
					.GetTrigger()
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
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_ATTACK)
					.SetTask(ComplexTask.Secret(
						new SummonTask("CS2_125", 1)))
					.SetCondition(SelfCondition.IsEventTargetIs(CardType.HERO))
					.GetTrigger()
			});

			// ----------------------------------------- SPELL - HUNTER
			// [AT_061] Lock and Load - COST:2 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Each time you cast a spell this turn, add a random Hunter card to your hand.
			// --------------------------------------------------------
			cards.Add("AT_061", new Power {
				PowerTask = new AddEnchantmentTask("AT_061e", EntityType.CONTROLLER)
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
				PowerTask = new SummonTask("FP1_011", 3)
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
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_057o")
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [AT_061e] Lock and Load (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("AT_061e", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					SingleTask = ComplexTask.Create(
						new RandomCardTask(CardType.INVALID, CardClass.HUNTER),
						new AddStackTo(EntityType.HAND))
				}
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
				//Aura = new Aura(AuraType.HERO, new Effect(GameTag.HEROPOWER_DAMAGE, EffectOperator.ADD, 1))
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
				Trigger = new Trigger(TriggerType.INSPIRE)
				{
					SingleTask = new AddEnchantmentTask("AT_006e", EntityType.SOURCE)
				}
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
				PowerTask = ComplexTask.Create(
					new RandomCardTask(CardType.SPELL, CardClass.INVALID),
					new AddStackTo(EntityType.HAND),
					new RandomCardTask(CardType.SPELL, CardClass.INVALID, opposite: true),
					new AddStackTo(EntityType.OP_HAND))
			});

			// ------------------------------------------ MINION - MAGE
			// [AT_008] Coldarra Drake - COST:6 [ATK:6/HP:6] 
			// - Race: dragon, Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: You can use your Hero Power any number of times.
			// --------------------------------------------------------
			cards.Add("AT_008", new Power {
				// TODO [AT_008] Coldarra Drake && Test: Coldarra Drake_AT_008
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new SetGameTagTask(GameTag.EXHAUSTED, 0, EntityType.HERO_POWER))
					.GetTrigger()
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
				DeathrattleTask = new AddCardTo("EX1_277", EntityType.HAND, 3)
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
				PowerTask = new DamageTask(8, EntityType.TARGET, true)
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
				Trigger = TriggerBuilder
					.Type(TriggerType.DEATH)
					.SetSecretTasks(
						new GetGameTagTask(GameTag.COST, EntityType.TARGET),
						new RandomMinionNumberTask(GameTag.COST),
						new SummonTask())
					.SetSource(TriggerSource.FRIENDLY)
					.GetTrigger()
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
				Enchant = new OngoingEnchant(new Effect(GameTag.SPELLPOWER, EffectOperator.ADD, 1))
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
				Aura = new Aura(AuraType.BOARD_EXCEPT_SOURCE, "AT_075e")
				{
					Condition = SelfCondition.IsSilverHandRecruit
				}
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
				Trigger = new Trigger(TriggerType.INSPIRE)
				{
					SingleTask = ComplexTask.Create(
						new RandomCardTask(CardType.MINION, CardClass.INVALID, Race.MURLOC),
						new SummonTask())
				}
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
				PowerTask = new RevealTask(new HealTask(7, EntityType.HERO))
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
				Trigger = TriggerBuilder
					.Type(TriggerType.TURN_START)
					.SetSecretTasks(new AddEnchantmentTask("AT_073e", EntityType.MINIONS))
					.SetCondition(SelfCondition.IsZoneCount(Zone.PLAY, 1, RelaSign.GEQ))
					.GetTrigger()
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
				PowerTask = new AddEnchantmentTask("AT_074e2", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - PALADIN
			// [AT_078] Enter the Coliseum - COST:6 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all minions except each player's highest Attack minion.
			// --------------------------------------------------------
			cards.Add("AT_078", new Power {
				PowerTask = new FuncNumberTask(p =>
				{
					ReadOnlySpan<Minion> minions = p.Controller.BoardZone.GetSpan();
					ReadOnlySpan<Minion> opMinions = p.Controller.Opponent.BoardZone.GetSpan();

					int max = -1;
					int maxIndex = -1;
					for (int i = 0; i < minions.Length; i++)
					{
						int atk = minions[i].AttackDamage;
						if (atk <= max) continue;
						max = atk;
						maxIndex = i;
					}

					if (maxIndex > 0)
						for (int i = 0; i < minions.Length; i++)
							if (i != maxIndex)
								minions[i].Destroy();

					max = maxIndex = -1;

					for (int i = 0; i < opMinions.Length; i++)
					{
						int atk = opMinions[i].AttackDamage;
						if (atk <= max) continue;
						max = atk;
						maxIndex = i;
					}

					if (maxIndex > 0)
						for (int i = 0; i < opMinions.Length; i++)
							if (i != maxIndex)
								opMinions[i].Destroy();
					return 0;
				})
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
				PowerTask = new RevealTask(
					new AddEnchantmentTask("AT_077e", EntityType.SOURCE))
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
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_074e2")
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [AT_075e] Might of the Hostler (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Warhorse Trainer is granting this minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("AT_075e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_075e")
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
				Trigger = TriggerBuilder
					.Type(TriggerType.HEAL)
					.SetTask(new AddEnchantmentTask("AT_011e", EntityType.SOURCE))
					.GetTrigger()
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(ComplexTask.Create(
						new DamageTask(4, EntityType.OP_HERO),
						new DamageTask(4, EntityType.HERO)))
					.GetTrigger()
			});

			// ---------------------------------------- MINION - PRIEST
			// [AT_014] Shadowfiend - COST:3 [ATK:3/HP:3] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you draw a card, reduce its Cost by (1).
			// --------------------------------------------------------
			cards.Add("AT_014", new Power {
				Trigger = TriggerBuilder
					.Type(TriggerType.DRAW)
					.SetTask(new AddEnchantmentTask("AT_014e", EntityType.TARGET))
					.GetTrigger()
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(ComplexTask.Create(
						new RandomCardTask(CardType.MINION, CardClass.INVALID, rarity: Rarity.LEGENDARY),
						new SummonTask()))
					.GetTrigger()
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
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, new AddEnchantmentTask("AT_116e", EntityType.SOURCE)))
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
				PowerTask = new AddEnchantmentTask("AT_013e", EntityType.TARGET)
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
				PowerTask = new CopyTask(EntityType.TARGET, Zone.HAND)
			});

			// ----------------------------------------- SPELL - PRIEST
			// [AT_016] Confuse - COST:2 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Swap the Attack and Health of all minions.
			// --------------------------------------------------------
			cards.Add("AT_016", new Power {
				PowerTask = new SwapAttackHealthTask(EntityType.ALLMINIONS, "AT_016e")
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
				PowerTask = new HealTask(5, EntityType.TARGET)
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
				Enchant = new Enchant(Effects.ReduceCost(1))
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [AT_016e] Confused (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Swapped Attack and Health.
			// --------------------------------------------------------
			cards.Add("AT_016e", new Power {
				Enchant = Enchants.Enchants.SetAttackHealthScriptTag
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [AT_116e] Bring it on! (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("AT_116e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_116e")
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
				ComboTask = new AddEnchantmentTask("AT_028e", EntityType.SOURCE)
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_029] Buccaneer - COST:1 [ATK:2/HP:1] 
			// - Race: pirate, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you equip a weapon, give it +1 Attack.
			// --------------------------------------------------------
			cards.Add("AT_029", new Power {
				Trigger = TriggerBuilder
					.Type(TriggerType.EQUIP_WEAPON)
					.SetTask(new AddEnchantmentTask("AT_029e", EntityType.WEAPON))
					.SetSource(TriggerSource.FRIENDLY)
					.GetTrigger()
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
				ComboTask = new DamageTask(1, EntityType.TARGET)
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_031] Cutpurse - COST:2 [ATK:2/HP:2] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever this minion attacks a hero, add the Coin to your hand.
			// --------------------------------------------------------
			cards.Add("AT_031", new Power {
				Trigger = TriggerBuilder
					.Type(TriggerType.ATTACK)
					.SetTask(new AddCardTo("GAME_005", EntityType.HAND))
					.SetCondition(SelfCondition.IsEventTargetIs(CardType.HERO))
					.SetSource(TriggerSource.SELF)
					.GetTrigger()
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
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingRace(Race.PIRATE)),
					new FlagTask(true, new AddEnchantmentTask("AT_032e", EntityType.SOURCE)))
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
				// TODO Check powerlog
				DeathrattleTask = ComplexTask.Create(
					new ReturnHandTask(EntityType.SOURCE),
					new SummonTask("AT_036t"))
			});

			// ------------------------------------------ SPELL - ROGUE
			// [AT_033] Burgle - COST:3 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Add 2 random cards to your hand <i>(from your opponent's class)</i>.
			// --------------------------------------------------------
			cards.Add("AT_033", new Power {
				PowerTask = ComplexTask.Repeat(ComplexTask.AddRandomOpClassCardToHand, 2)
			});

			// ------------------------------------------ SPELL - ROGUE
			// [AT_035] Beneath the Grounds - COST:3 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle 3 Ambushes into your opponent's deck. When drawn, you summon a 4/4 Nerubian.
			// --------------------------------------------------------
			cards.Add("AT_035", new Power {
				PowerTask = new AddCardTo("AT_035t", EntityType.OP_DECK, 3)
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
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_032e")
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [AT_034e] Laced (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("AT_034e", new Power {
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_036t] Nerubian (*) - COST:4 [ATK:4/HP:4] 
			// - Set: tgt, 
			// --------------------------------------------------------
			cards.Add("AT_036t", null);

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
				PowerTask = ComplexTask.Create(
					new SummonOpTask("AT_036t"),
					new DrawTask()),
				TopdeckTask = ComplexTask.Create(
					new SummonOpTask("AT_036t"),
					new DrawTask())
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [AT_132_ROGUEt] Poisoned Dagger (*) - COST:1 [ATK:2/HP:0] 
			// - Set: tgt, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("AT_132_ROGUEt", null);

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
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.SOURCE),
					new FuncPlayablesTask(list =>
					{
						switch (Util.Random.Next(0, 4))
						{
							case 0:
								return new List<IPlayable>
								{
									Entity.FromCard(list[0].Controller,
										Cards.FromId("NEW1_009"))
								};
							case 1:
								return new List<IPlayable>
								{
									Entity.FromCard(list[0].Controller,
										Cards.FromId("CS2_050"))
								};
							case 2:
								return new List<IPlayable>
								{
									Entity.FromCard(list[0].Controller,
										Cards.FromId("CS2_051"))
								};
							case 3:
								return new List<IPlayable>
								{
									Entity.FromCard(list[0].Controller,
										Cards.FromId("CS2_052"))
								};
							default:
								return null;
						}
					}),
					new SummonTask())
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
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.TOTEM)),
					new CountTask(EntityType.STACK),
					new AddEnchantmentTask("AT_047e", EntityType.SOURCE, true))
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(ComplexTask.Create(
						new IncludeTask(EntityType.MINIONS),
						new FilterStackTask(SelfCondition.IsRace(Race.TOTEM)),
						new AddEnchantmentTask("AT_049e", EntityType.STACK)))
					.GetTrigger()
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
			cards.Add("AT_052", null);

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
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new IncludeTask(EntityType.DECK, addFlag: true),
					new FilterStackTask(SelfCondition.IsMinion),
					new AddEnchantmentTask("AT_045e", EntityType.STACK))
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
				PowerTask = new RevealTask(
						new HealTask(14, EntityType.TARGET),
						new HealTask(7, EntityType.TARGET))
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [AT_051] Elemental Destruction - COST:3 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $4-$5 damage to all minions. <b>Overload:</b> (5) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 5
			// - OVERLOAD_OWED = 5
			// --------------------------------------------------------
			cards.Add("AT_051", new Power {
				PowerTask = new DamageTask(4, 1, EntityType.ALLMINIONS, true)
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
				PowerTask = new DrawTask(2)
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
				DeathrattleTask = new ReplaceHeroPower(Cards.FromId("AT_050t"))
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
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [AT_049e] Power of the Bluff (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("AT_049e", new Power {
				Enchant = new OngoingEnchant(Effects.Attack_N(2))
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
				DeathrattleTask = new AddEnchantmentTask("AT_019e", EntityType.CONTROLLER)
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_020] Fearsome Doomguard - COST:7 [ATK:6/HP:8] 
			// - Race: demon, Set: tgt, Rarity: common
			// --------------------------------------------------------
			cards.Add("AT_020", null);

			// --------------------------------------- MINION - WARLOCK
			// [AT_021] Tiny Knight of Evil - COST:2 [ATK:3/HP:2] 
			// - Race: demon, Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you discard a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_021", new Power {
				Trigger = TriggerBuilder
					.Type(TriggerType.DISCARD)
					.SetTask(new AddEnchantmentTask("AT_021e", EntityType.SOURCE))
					.GetTrigger()
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(ComplexTask.Create(
						ComplexTask.DestroyRandomTargets(1, EntityType.MINIONS),
						ComplexTask.DestroyRandomTargets(1, EntityType.OP_MINIONS)))
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_026] Wrathguard - COST:2 [ATK:4/HP:3] 
			// - Race: demon, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, also deal that amount to your hero.
			// --------------------------------------------------------
			cards.Add("AT_026", new Power {
				Trigger = TriggerBuilder
					.Type(TriggerType.TAKE_DAMAGE)
					.SetTask(ComplexTask.Create(
						new GetEventNumberTask(),
						new DamageNumberTask(EntityType.HERO)))
					.SetSource(TriggerSource.SELF)
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
				PowerTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 4, true),
				Trigger = TriggerBuilder
					.Type(TriggerType.DISCARD)
					.SetTask(ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 4, true))
					.SetActivation(TriggerActivation.HAND)
					.SetSource(TriggerSource.SELF)

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
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("AT_024e", EntityType.TARGET),
					new ManaCrystalEmptyTask(1, true))
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
				PowerTask = ComplexTask.Create(
			ComplexTask.DestroyRandomTargets(2, EntityType.OP_MINIONS),
					ComplexTask.DiscardRandomCard(2)),
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
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new AddEnchantmentTask("AT_066e", EntityType.WEAPON))
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
				PowerTask = new AddEnchantmentTask("AT_069e", EntityType.TARGET)
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
				PowerTask = ComplexTask.Conditional(EntityType.SOURCE,
					SelfCondition.IsDragonInHand,
					new AddEnchantmentTask("AT_071e", EntityType.SOURCE))
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
				PowerTask = ComplexTask.Create(
					new DrawTask(true, 3),
					new FilterStackTask(SelfCondition.IsMinion),
					new SummonStackTask(true))
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
				TopdeckTask = new DamageTask(1, EntityType.MINIONS)
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
				PowerTask = ComplexTask.Create(
					new DamageTask(3, EntityType.TARGET, true),
					new ArmorTask(3))
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
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.HasTaunt),
					new AddEnchantmentTask("AT_068e", EntityType.STACK))
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
				PowerTask = ComplexTask.Conditional(EntityType.SOURCE,
					SelfCondition.HasBoardMinion(GameTag.TAUNT, 1, RelaSign.GEQ),
					new AddEnchantmentTask("AT_065e", EntityType.SOURCE))
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
				Enchant = new Enchant(GameTag.ATK, EffectOperator.ADD, 1)
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [AT_068e] Bolstered (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("AT_068e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_068e")
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [AT_069e] Training Complete (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			cards.Add("AT_069e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_069e")
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [AT_071e] Alexstrasza's Boon (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("AT_071e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_071e")
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
				PowerTask = ComplexTask.Conditional(EntityType.SOURCE,
					SelfCondition.IsDragonInHand,
					new AddEnchantmentTask("AT_017e", EntityType.SOURCE))
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
				Aura = new AdaptiveCostEffect(p =>
				{
					int count = 0;
					ReadOnlySpan<Minion> board = p.Controller.BoardZone.GetSpan();
					for (int i = 0; i < board.Length; i++)
						if (board[i].Race == Race.PIRATE)
							count++;

					return count;
				})
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_080] Garrison Commander - COST:2 [ATK:2/HP:3] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: You can use your Hero Power twice a turn.
			// --------------------------------------------------------
			cards.Add("AT_080", new Power {
				Trigger = new Trigger(TriggerType.INSPIRE)
				{
					Condition = new SelfCondition(p => p.Controller.HeroPowerActivationsThisTurn == 1),
					SingleTask = new SetGameTagTask(GameTag.EXHAUSTED, 0, EntityType.HERO_POWER)
				}
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new AddEnchantmentTask("AT_082e", EntityType.SOURCE))
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new AddEnchantmentTask("AT_083e", EntityType.SOURCE))
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
				PowerTask = new AddEnchantmentTask("AT_084e", EntityType.TARGET)
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
				Aura = new Aura(AuraType.HEROPOWER, Effects.SetCost(1))
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
				//PowerTask = new AddEnchantmentTask("AT_086e", EntityType.OP_HERO_POWER)
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
			cards.Add("AT_087", null);

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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new AddEnchantmentTask("AT_089e", EntityType.SOURCE))

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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new AddEnchantmentTask("AT_090e", EntityType.MINIONS_NOSOURCE))
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new HealTask(2, EntityType.HERO))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_092] Ice Rager - COST:3 [ATK:5/HP:2] 
			// - Race: elemental, Set: tgt, Rarity: common
			// --------------------------------------------------------
			cards.Add("AT_092", null);

			// --------------------------------------- MINION - NEUTRAL
			// [AT_093] Frigid Snobold - COST:4 [ATK:2/HP:6] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("AT_093", null);

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
				PowerTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1)
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
			cards.Add("AT_095", null);

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
				PowerTask = new AddEnchantmentTask("AT_096e", EntityType.TARGET)
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
			cards.Add("AT_097", null);

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
				PowerTask = ComplexTask.Create(
					new CopyTask(EntityType.OP_HERO_POWER, Zone.PLAY, addToStack: true),
					new ReplaceHeroPower())
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new SummonTask("AT_099t", 1, SummonSide.RIGHT))
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new SummonTask("CS2_101t", SummonSide.RIGHT))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_101] Pit Fighter - COST:5 [ATK:5/HP:6] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			cards.Add("AT_101", null);

			// --------------------------------------- MINION - NEUTRAL
			// [AT_102] Captured Jormungar - COST:7 [ATK:5/HP:9] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			cards.Add("AT_102", null);

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
				PowerTask = new DamageTask(4, EntityType.TARGET)
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
				PowerTask = new DamageTask(3, EntityType.SOURCE)
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
				PowerTask = new SilenceTask(EntityType.TARGET)
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
				PowerTask = new RevealTask(ComplexTask.Charge(EntityType.SOURCE))
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
				Trigger = new Trigger(TriggerType.INSPIRE)
				{
					SingleTask = new AddEnchantmentTask("AT_109e", EntityType.SOURCE)
				}
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new ReturnHandTask(EntityType.SOURCE))
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
				PowerTask = ComplexTask.Create(
					new HealTask(4, EntityType.HERO),
					new HealTask(4, EntityType.OP_HERO))
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
				PowerTask = new RevealTask(ComplexTask.Create(
					ComplexTask.Taunt(EntityType.SOURCE),
					ComplexTask.DivineShield(EntityType.SOURCE)))
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new AddCardTo("CS2_152", EntityType.HAND))
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
			cards.Add("AT_114", null);

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
				PowerTask = ComplexTask.Conditional(EntityType.SOURCE,
					SelfCondition.HasBoardMinion(GameTag.SPELLPOWER, 1, RelaSign.GEQ),
					new AddEnchantmentTask("AT_117e", EntityType.SOURCE))
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
				PowerTask = ComplexTask.Create(
					new RandomCardTask(CardType.INVALID, CardClass.PALADIN),
					new AddStackTo(EntityType.HAND))
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
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(new AddEnchantmentTask("AT_119e", EntityType.SOURCE))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_120] Frost Giant - COST:10 [ATK:8/HP:8] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each time you used your Hero Power this game.
			// --------------------------------------------------------
			cards.Add("AT_120", new Power {
				Aura = new AdaptiveCostEffect(p => p.Controller.NumTimesHeroPowerUsedThisGame)
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
				Trigger = TriggerBuilder
					.Type(TriggerType.PLAY_CARD)
					.SetTask(new AddEnchantmentTask("AT_121e", EntityType.SOURCE))
					.SetCondition(SelfCondition.IsBattleCryCard)
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
				PowerTask = new DamageTask(4, EntityType.TARGET)
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
				DeathrattleTask = ComplexTask.Conditional(EntityType.SOURCE,
					SelfCondition.IsDragonInHand,
					new DamageTask(3, EntityType.ALLMINIONS))
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
				Trigger = TriggerBuilder
					.Type(TriggerType.PREDAMAGE)
					.SetTask(new FuncNumberTask(p =>
					{
						EventMetaData data = p.Game.CurrentEventData;

						((Character) p).TakeDamage(data.EventSource, data.EventNumber);

						data.EventNumber = 0;

						return 0;
					}))
					.SetSource(TriggerSource.HERO)
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
				Trigger = TriggerBuilder
					.Type(TriggerType.ZONE)
					.SetTask(new SetGameTagTask(GameTag.CANNOT_ATTACK_HEROES, 1, EntityType.SOURCE))
					.SetRemoveAfterTriggered()
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
				Trigger = new Trigger(TriggerType.INSPIRE)
				{
					SingleTask = ComplexTask.Create(
						new RandomCardTask(CardType.SPELL, CardClass.INVALID),
						new AddStackTo(EntityType.HAND))
				}
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
				DeathrattleTask = new RevealTask(new CopyTask(EntityType.SOURCE, Zone.HAND))
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
				Trigger = TriggerBuilder
					.Type(TriggerType.CAST_SPELL)
					.SetTask(ComplexTask.DivineShield(EntityType.SOURCE))
					.SetSource(TriggerSource.FRIENDLY_SPELL_CASTED_ON_THE_OWNER)
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
				Trigger = TriggerBuilder
					.Type(TriggerType.CAST_SPELL)
					.SetTask(ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 3))
					.SetSource(TriggerSource.FRIENDLY_SPELL_CASTED_ON_THE_OWNER)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_132] Justicar Trueheart - COST:6 [ATK:6/HP:3] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Replace your starting Hero Power with a better one.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_132", new Power {
				PowerTask = SpecificTask.JusticarTrueheart
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
				PowerTask = new RevealTask(new AddEnchantmentTask("AT_133e", EntityType.SOURCE))
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
				Enchant = new OngoingEnchant(Effects.Attack_N(2))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_013e] Power Word: Glory (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: When this attacks, restore 4 Health to the hero of the player who buffed it.
			// --------------------------------------------------------
			cards.Add("AT_013e", new Power {
				Trigger =  TriggerBuilder
					.Type(TriggerType.ATTACK)
					.SetTask(new HealTask(4, EntityType.HERO))
					.SetSource(TriggerSource.ENCHANTMENT_TARGET)
					.GetTrigger()
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_017e] Twilight's Embrace (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("AT_017e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_017e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_019e] Dreadsteed (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Summon a Dreadsteed at the end of the turn.
			// --------------------------------------------------------
			cards.Add("AT_019e", new Power {
				Trigger = TriggerBuilder
					.Type(TriggerType.TURN_END)
					.SetTask(new SummonTask("AT_019"))
					.SetRemoveAfterTriggered()
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_024e] Dark Fusion (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("AT_024e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_024e")
			});
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_028e] Chi Lance (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("AT_028e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_028e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_029e] Extra Stabby (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1 Attack
			// --------------------------------------------------------
			cards.Add("AT_029e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_029e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_041e] Call of the Wild (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Cost reduced.
			// --------------------------------------------------------
			cards.Add("AT_041e", new Power {
				Enchant = new OngoingEnchant(Effects.ReduceCost(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_045e] Empowering Mist (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_045e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_045e")
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
				Enchant = new Enchant(GameTag.DURABILITY, EffectOperator.ADD, 1)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_073e] Competitive Spirit (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_073e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_073e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_077e] Extra Poke (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1 Durability.
			// --------------------------------------------------------
			cards.Add("AT_077e", new Power {
				Enchant = new Enchant(new Effect(GameTag.DURABILITY, EffectOperator.ADD, 1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_082e] Training (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("AT_082e", new Power {
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
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
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_083e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_084e] Equipped (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("AT_084e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_084e")
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
				Enchant = new OngoingEnchant(Effects.Health_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_090e] Might of the Monkey (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_090e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_090e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_096e] Wound Up (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_096e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_096e")
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
				Enchant = new Enchant(GameTag.CANT_ATTACK, EffectOperator.SET, 0)
				{
					IsOneTurnEffect = true
				}
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
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_117e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_119e] Inspired (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("AT_119e", new Power {
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(2))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_121e] Huge Ego (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("AT_121e", new Power {
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_133e] Victory! (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_133e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("AT_133e")
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
			cards.Add("AT_005t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [AT_099t] War Kodo (*) - COST:5 [ATK:3/HP:5] 
			// - Race: beast, Set: tgt, 
			// --------------------------------------------------------
			cards.Add("AT_099t", null);

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
