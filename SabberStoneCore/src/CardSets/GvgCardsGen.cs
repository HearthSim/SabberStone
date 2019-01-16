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
using SabberStoneCore.Actions;
using SabberStoneCore.Auras;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets
{
	public class GvgCardsGen
	{
		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [GVG_030] Anodized Robo Cub - COST:2 [ATK:2/HP:2] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Choose One -</b>
			//       +1 Attack; or +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("GVG_030", //CHOOSE_ONE
				null);

			// ----------------------------------------- MINION - DRUID
			// [GVG_032] Grove Tender - COST:3 [ATK:2/HP:4] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Give each player a Mana Crystal; or Each player draws a card.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("GVG_032", //CHOOSE_ONE
				null);

			// ----------------------------------------- MINION - DRUID
			// [GVG_034] Mech-Bear-Cat - COST:6 [ATK:7/HP:6] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, add a <b>Spare Part</b> card to your hand.
			// --------------------------------------------------------
			// Entourage: PART_007, PART_006, PART_005, PART_001, PART_003, PART_002, PART_004
			// --------------------------------------------------------
			// RefTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("GVG_034", new Power {
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = ComplexTask.GetRandomEntourageCardToHand()
				}
			});

			// ----------------------------------------- MINION - DRUID
			// [GVG_035] Malorne - COST:7 [ATK:9/HP:7] 
			// - Race: beast, Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle this minion into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("GVG_035", new Power {
				PowerTask = new AddCardTo("GVG_035", EntityType.DECK)
			});

			// ----------------------------------------- MINION - DRUID
			// [GVG_080] Druid of the Fang - COST:5 [ATK:4/HP:4] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a Beast, transform this minion into a 7/7.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_080", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingRace(Race.BEAST)),
					new FlagTask(true, new TransformTask("GVG_080t", EntityType.SOURCE)))
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_031] Recycle - COST:6 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Shuffle an enemy minion into your opponent's deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_031", new Power {
				// http://hearthstone.gamepedia.com/Recycle
				PowerTask = ComplexTask.Create(
					new CopyTask(EntityType.TARGET, Zone.DECK, toOpponent: true),
					new MoveToSetaside(EntityType.TARGET))
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_033] Tree of Life - COST:9 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Restore all characters to full Health.
			// --------------------------------------------------------
			cards.Add("GVG_033", new Power {
				PowerTask = new HealFullTask(EntityType.ALL)
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_041] Dark Wispers - COST:6 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Summon 5 Wisps; or Give_a minion +5/+5 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GVG_041", //CHOOSE_ONE
				null);

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [GVG_030ae] Attack Mode (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_030ae", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_030ae")
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [GVG_030be] Tank Mode (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +1 Health.
			// --------------------------------------------------------
			cards.Add("GVG_030be", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_030be")
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [GVG_041c] Dark Wispers (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +5/+5 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("GVG_041c", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_041c")
			});

			// ----------------------------------------- MINION - DRUID
			// [GVG_080t] Druid of the Fang (*) - COST:5 [ATK:7/HP:7] 
			// - Race: beast, Set: gvg, 
			// --------------------------------------------------------
			cards.Add("GVG_080t", null);

			// ------------------------------------------ SPELL - DRUID
			// [GVG_030a] Attack Mode (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_030a", new Power {
				PowerTask = new AddEnchantmentTask("GVG_030ae", EntityType.SOURCE)
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_030b] Tank Mode (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +1 Health.
			// --------------------------------------------------------
			cards.Add("GVG_030b", new Power {
				PowerTask = new AddEnchantmentTask("GVG_030be", EntityType.SOURCE)
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_032a] Gift of Mana (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Give each player a Mana Crystal.
			// --------------------------------------------------------
			cards.Add("GVG_032a", new Power {
				PowerTask = ComplexTask.Create(
					new ManaCrystalEmptyTask(1),
					new ManaCrystalEmptyTask(1, true))
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_032b] Gift of Cards (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Each player draws a card.
			// --------------------------------------------------------
			cards.Add("GVG_032b", new Power {
				PowerTask = ComplexTask.Create(
					new DrawTask(),
					new DrawOpTask())
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_041a] Dark Wispers (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +5/+5 and <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_041a", new Power {
				PowerTask = new AddEnchantmentTask("GVG_041c", EntityType.SOURCE)
			});

			// ------------------------------------------ SPELL - DRUID
			// [GVG_041b] Dark Wispers (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Summon 5 Wisps.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("GVG_041b", new Power {
				PowerTask = new SummonTask("CS2_231", 5)
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [GVG_046] King of Beasts - COST:5 [ATK:2/HP:6] 
			// - Race: beast, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Battlecry:</b> Gain +1 Attack for each other Beast you have.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_046", new Power {
				// TODO [GVG_046] King of Beasts && Test: King of Beasts_GVG_046
				InfoCardId = "GVG_046e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [GVG_048] Metaltooth Leaper - COST:3 [ATK:3/HP:3] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your other Mechs +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_048", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.MECHANICAL)),
					new AddEnchantmentTask("GVG_048e", EntityType.STACK))
			});

			// ---------------------------------------- MINION - HUNTER
			// [GVG_049] Gahz'rilla - COST:7 [ATK:6/HP:9] 
			// - Race: beast, Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, double its Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_049", new Power {
				// TODO [GVG_049] Gahz'rilla && Test: Gahz'rilla_GVG_049
				InfoCardId = "GVG_049e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [GVG_087] Steamwheedle Sniper - COST:2 [ATK:2/HP:3] 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Your Hero Power can target minions.
			// --------------------------------------------------------
			cards.Add("GVG_087", new Power {
				// TODO [GVG_087] Steamwheedle Sniper && Test: Steamwheedle Sniper_GVG_087
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [GVG_017] Call Pet - COST:2 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw a card.
			//       If it's a Beast, it costs (4) less.
			// --------------------------------------------------------
			cards.Add("GVG_017", new Power {
				// TODO [GVG_017] Call Pet && Test: Call Pet_GVG_017
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [GVG_026] Feign Death - COST:2 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Trigger all <b>Deathrattles</b> on your minions.
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_026", new Power {
				PowerTask = new ActivateDeathrattleTask(EntityType.MINIONS)
			});

			// ----------------------------------------- SPELL - HUNTER
			// [GVG_073] Cobra Shot - COST:5 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage to a minion and the enemy hero. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_073", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(3, EntityType.TARGET, true),
					new DamageTask(3, EntityType.OP_HERO, true))
			});

			// ---------------------------------------- WEAPON - HUNTER
			// [GVG_043] Glaivezooka - COST:2 [ATK:2/HP:0] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random friendly minion +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_043", new Power {
				// TODO [GVG_043] Glaivezooka && Test: Glaivezooka_GVG_043
				InfoCardId = "GVG_043e",
				PowerTask = ComplexTask.Create(
					new RandomTask(1, EntityType.MINIONS),
					new AddEnchantmentTask("GVG_043e", EntityType.STACK))
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [GVG_043e] Glaivezooka (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_043e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_043e")
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [GVG_046e] The King (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("GVG_046e", new Power {
				// TODO [GVG_046e] The King && Test: The King_GVG_046e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [GVG_048e] Metal Teeth (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_048e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_048e")
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [GVG_049e] Might of Zul'Farrak (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Multiplying Attack.
			// --------------------------------------------------------
			cards.Add("GVG_049e", new Power {
				// TODO [GVG_049e] Might of Zul'Farrak && Test: Might of Zul'Farrak_GVG_049e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [GVG_002] Snowchugger - COST:2 [ATK:2/HP:3] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> any character damaged by this minion.
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("GVG_002", null);

			// ------------------------------------------ MINION - MAGE
			// [GVG_004] Goblin Blastmage - COST:4 [ATK:5/HP:4] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a Mech, deal 4 damage randomly split among all enemies.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_004", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingRace(Race.MECHANICAL)),
					new FlagTask(true, ComplexTask.DamageRandomTargets(4, EntityType.ENEMIES, 1)))
			});

			// ------------------------------------------ MINION - MAGE
			// [GVG_007] Flame Leviathan - COST:7 [ATK:7/HP:7] 
			// - Race: mechanical, Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: When you draw this, deal 2 damage to all characters.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("GVG_007", new Power {
				// TODO Test: Flame Leviathan_GVG_007
				TopdeckTask = new DamageTask(2, EntityType.ALLMINIONS)
			});

			// ------------------------------------------ MINION - MAGE
			// [GVG_122] Wee Spellstopper - COST:4 [ATK:2/HP:5] 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Adjacent minions can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_122", new Power {
				// TODO [GVG_122] Wee Spellstopper && Test: Wee Spellstopper_GVG_122
				//Aura = new Aura(AuraType.ADJACENT, new Effect(GameTag.CANT_BE_TARGETED_BY_SPELLS, EffectOperator.SET))
			});

			// ------------------------------------------ MINION - MAGE
			// [GVG_123] Soot Spewer - COST:3 [ATK:3/HP:3] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("GVG_123", null);

			// ------------------------------------------- SPELL - MAGE
			// [GVG_001] Flamecannon - COST:2 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage to a random enemy minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("GVG_001", new Power {
				PowerTask = ComplexTask.DamageRandomTargets(1, EntityType.OP_MINIONS, 4, true)
			});

			// ------------------------------------------- SPELL - MAGE
			// [GVG_003] Unstable Portal - COST:2 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Add a random minion to your hand. It costs (3) less.
			// --------------------------------------------------------
			cards.Add("GVG_003", new Power {
				PowerTask = ComplexTask.Create(
					new RandomCardTask(CardType.MINION, CardClass.INVALID),
					new AddStackTo(EntityType.HAND),
					new AddAuraEffect(Effects.ReduceCost(3), EntityType.STACK))
			});

			// ------------------------------------------- SPELL - MAGE
			// [GVG_005] Echo of Medivh - COST:4 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Put a copy of each friendly minion into your hand.
			// --------------------------------------------------------
			cards.Add("GVG_005", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new CopyTask(EntityType.STACK, Zone.HAND))
			});

		}

		//private static void MageNonCollect(IDictionary<string, Power> cards)
		//{

		//}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [GVG_058] Shielded Minibot - COST:2 [ATK:2/HP:2] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GVG_058", null);

			// --------------------------------------- MINION - PALADIN
			// [GVG_060] Quartermaster - COST:5 [ATK:2/HP:5] 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your Silver Hand Recruits +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_060", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsSilverHandRecruit),
					new AddEnchantmentTask("GVG_060e", EntityType.STACK))
			});

			// --------------------------------------- MINION - PALADIN
			// [GVG_062] Cobalt Guardian - COST:5 [ATK:6/HP:3] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you summon a Mech, gain <b>Divine Shield</b>.
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GVG_062", new Power {
				Trigger = new Trigger(TriggerType.SUMMON)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsRace(Race.MECHANICAL),
					SingleTask = ComplexTask.DivineShield(EntityType.TARGET)
				}
			});

			// --------------------------------------- MINION - PALADIN
			// [GVG_063] Bolvar Fordragon - COST:5 [ATK:1/HP:7] 
			// - Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever a friendly minion dies while this is in your hand, gain +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_063", new Power {
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerActivation = TriggerActivation.HAND,
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("GVG_063a", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - PALADIN
			// [GVG_101] Scarlet Purifier - COST:3 [ATK:4/HP:3] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage to all minions with <b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_101", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS),
					new FilterStackTask(SelfCondition.IsDeathrattleMinion),
					new DamageTask(2, EntityType.STACK))
			});

			// ---------------------------------------- SPELL - PALADIN
			// [GVG_057] Seal of Light - COST:2 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #4 Health to your hero and gain +2 Attack this turn.
			// --------------------------------------------------------
			cards.Add("GVG_057", new Power {
				PowerTask = ComplexTask.Create(
					new HealTask(4, EntityType.HERO),
					new AddEnchantmentTask("GVG_057a", EntityType.HERO))
			});

			// ---------------------------------------- SPELL - PALADIN
			// [GVG_061] Muster for Battle - COST:3 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon three 1/1 Silver Hand Recruits. Equip a 1/4 Weapon.
			// --------------------------------------------------------
			cards.Add("GVG_061", new Power {
				PowerTask = ComplexTask.Create(
					new EnqueueTask(3, new SummonTask("CS2_101t", SummonSide.SPELL)),
					new WeaponTask("CS2_091"))
			});

			// --------------------------------------- WEAPON - PALADIN
			// [GVG_059] Coghammer - COST:3 [ATK:2/HP:0] 
			// - Set: gvg, Rarity: epic
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
			cards.Add("GVG_059", new Power {
				PowerTask = ComplexTask.Create(
					new RandomTask(1, EntityType.MINIONS),
					ComplexTask.Taunt(EntityType.STACK),
					ComplexTask.DivineShield(EntityType.STACK))
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [GVG_060e] Well Equipped (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_060e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_060e")
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [GVG_101e] Pure (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Increased Stats.
			// --------------------------------------------------------
			cards.Add("GVG_101e", new Power {
				// TODO [GVG_101e] Pure && Test: Pure_GVG_101e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [GVG_009] Shadowbomber - COST:1 [ATK:2/HP:1] 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_009", new Power {
				PowerTask = new DamageTask(3, EntityType.HEROES)
			});

			// ---------------------------------------- MINION - PRIEST
			// [GVG_011] Shrinkmeister - COST:2 [ATK:3/HP:2] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a minion -2_Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_011", new Power {
				PowerTask = new AddEnchantmentTask("GVG_011a", EntityType.TARGET)
			});

			// ---------------------------------------- MINION - PRIEST
			// [GVG_014] Vol'jin - COST:5 [ATK:6/HP:2] 
			// - Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Swap Health with another minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_014", new Power {
				// TODO [GVG_014] Vol'jin && Test: Vol'jin_GVG_014
				InfoCardId = "GVG_014a",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [GVG_072] Shadowboxer - COST:2 [ATK:2/HP:3] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a minion is healed, deal 1 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("GVG_072", new Power {
				Trigger = new Trigger(TriggerType.HEAL)
				{
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = ComplexTask.Create(
						new RandomTask(1, EntityType.ENEMIES),
						new DamageTask(1, EntityType.STACK))
				}
			});

			// ---------------------------------------- MINION - PRIEST
			// [GVG_083] Upgraded Repair Bot - COST:5 [ATK:5/HP:5] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Mech +4 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 17
			// --------------------------------------------------------
			cards.Add("GVG_083", new Power {
				PowerTask = new AddEnchantmentTask("GVG_069a", EntityType.TARGET)
			});

			// ----------------------------------------- SPELL - PRIEST
			// [GVG_008] Lightbomb - COST:6 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal damage to each minion equal to its Attack. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("GVG_008", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.SOURCE),
					new IncludeTask(EntityType.ALLMINIONS, addFlag: true),
					new FuncPlayablesTask(list =>
					{
						IPlayable source = list[0];
						for (int i = 1; i < list.Count; i++)
						{
							var c = (ICharacter) list[i];
							Generic.DamageCharFunc(source, c, c.AttackDamage, true);
						}

						return null;
					}))
			});

			// ----------------------------------------- SPELL - PRIEST
			// [GVG_010] Velen's Chosen - COST:3 
			// - Set: gvg, Rarity: common
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
			cards.Add("GVG_010", new Power {
				PowerTask = new AddEnchantmentTask("GVG_010b", EntityType.TARGET)
			});

			// ----------------------------------------- SPELL - PRIEST
			// [GVG_012] Light of the Naaru - COST:1 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Restore #3 Health. If the target is still damaged, summon a Lightwarden.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_012", new Power {
				PowerTask = ComplexTask.Create(
					new HealTask(3, EntityType.TARGET),
					new ConditionTask(EntityType.TARGET, SelfCondition.IsDamaged),
					new FlagTask(true, new SummonTask("EX1_001", 1)))
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [GVG_014a] Shadowed (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Health was swapped.
			// --------------------------------------------------------
			cards.Add("GVG_014a", new Power {
				// TODO [GVG_014a] Shadowed && Test: Shadowed_GVG_014a
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [GVG_069a] Repairs! (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +4 Health.
			// --------------------------------------------------------
			cards.Add("GVG_069a", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_069a")
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [GVG_023] Goblin Auto-Barber - COST:2 [ATK:3/HP:2] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your weapon +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_023", new Power {
				PowerTask = new AddEnchantmentTask("GVG_023a", EntityType.WEAPON)
			});

			// ----------------------------------------- MINION - ROGUE
			// [GVG_025] One-eyed Cheat - COST:2 [ATK:4/HP:1] 
			// - Race: pirate, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you summon a Pirate, gain <b>Stealth</b>.
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("GVG_025", new Power {
				// TODO [GVG_025] One-eyed Cheat && Test: One-eyed Cheat_GVG_025
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [GVG_027] Iron Sensei - COST:3 [ATK:2/HP:2] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, give another friendly Mech +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_027", new Power {
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.MINIONS_NOSOURCE),
						new FilterStackTask(SelfCondition.IsRace(Race.MECHANICAL)),
						new RandomTask(1, EntityType.STACK),
						new AddEnchantmentTask("GVG_027e", EntityType.STACK))
				}
			});

			// ----------------------------------------- MINION - ROGUE
			// [GVG_028] Trade Prince Gallywix - COST:6 [ATK:5/HP:8] 
			// - Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, gain a copy of it and give them a Coin.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_028", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = ComplexTask.Create(
						new CopyTask(EntityType.TARGET, Zone.HAND),
						new AddCardTo("GVG_028t", EntityType.OP_HAND))
				}
			});

			// ----------------------------------------- MINION - ROGUE
			// [GVG_088] Ogre Ninja - COST:5 [ATK:6/HP:6] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - FORGETFUL = 1
			// --------------------------------------------------------
			cards.Add("GVG_088", new Power {
				// TODO [GVG_088] Ogre Ninja && Test: Ogre Ninja_GVG_088
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [GVG_022] Tinker's Sharpsword Oil - COST:4 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: Give your weapon +3 Attack. <b>Combo:</b> Give a random friendly minion +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_022", new Power {
				PowerTask = new AddEnchantmentTask("GVG_022a", EntityType.WEAPON),
				ComboTask = ComplexTask.Create(
					new AddEnchantmentTask("GVG_022a", EntityType.WEAPON),
					new RandomTask(1, EntityType.MINIONS),
					new AddEnchantmentTask("GVG_022b", EntityType.STACK))
			});

			// ------------------------------------------ SPELL - ROGUE
			// [GVG_047] Sabotage - COST:4 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a random enemy minion. <b>Combo:</b> And your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_047", new Power {
				PowerTask = ComplexTask.DestroyRandomTargets(1, EntityType.OP_MINIONS),
				ComboTask = ComplexTask.Create(
					new RandomTask(1, EntityType.OP_MINIONS),
					new IncludeTask(EntityType.OP_WEAPON, null, true),
					new DestroyTask(EntityType.STACK))
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [GVG_024] Cogmaster's Wrench - COST:3 [ATK:1/HP:0] 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Has +2 Attack while you have a Mech.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_024", new Power {
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.ADD, p => p.Controller.BoardZone.Any(m => m.Race == Race.MECHANICAL) ? 2 : 0)
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [GVG_027e] Ironed Out (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GVG_027e", new Power {
				Enchant = new Enchant(Effects.AttackHealth_N(2))
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [GVG_037] Whirling Zap-o-matic - COST:2 [ATK:3/HP:2] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("GVG_037", null);

			// ---------------------------------------- MINION - SHAMAN
			// [GVG_039] Vitality Totem - COST:2 [ATK:0/HP:3] 
			// - Race: totem, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 4 Health to your hero.
			// --------------------------------------------------------
			cards.Add("GVG_039", new Power {
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new HealTask(4, EntityType.HERO)
				}
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GVG_040] Siltfin Spiritwalker - COST:4 [ATK:2/HP:5] 
			// - Race: murloc, Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever another friendly Murloc dies, draw a card. <b><b>Overload</b>:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			cards.Add("GVG_040", new Power {
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsRace(Race.MURLOC),
					SingleTask = new DrawTask()
				}
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GVG_042] Neptulon - COST:7 [ATK:7/HP:7] 
			// - Race: elemental, Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add 4 random Murlocs to your hand. <b>Overload:</b> (3)
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - OVERLOAD = 3
			// - BATTLECRY = 1
			// - OVERLOAD_OWED = 3
			// --------------------------------------------------------
			cards.Add("GVG_042", new Power {
				PowerTask = new EnqueueTask(4, ComplexTask.Create(
					new RandomMinionTask(GameTag.CARDRACE, (int)Race.MURLOC),
					new AddStackTo(EntityType.HAND)))
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GVG_066] Dunemaul Shaman - COST:4 [ATK:5/HP:4] 
			// - Set: gvg, Rarity: rare
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
			cards.Add("GVG_066", new Power {
				// TODO [GVG_066] Dunemaul Shaman && Test: Dunemaul Shaman_GVG_066
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [GVG_029] Ancestor's Call - COST:4 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Put a random minion from each player's hand into the battlefield.
			// --------------------------------------------------------
			cards.Add("GVG_029", new Power {
				// TODO Test: Ancestor's Call_GVG_029
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new SummonStackTask(true),
					new IncludeTask(EntityType.OP_HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new SummonStackTask(true))
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [GVG_038] Crackle - COST:2 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3-$6 damage. <b>Overload:</b> (1) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_038", new Power {
				PowerTask = ComplexTask.Create(
					new MathRandTask(3, 6),
					new DamageNumberTask(EntityType.TARGET, true))
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [GVG_036] Powermace - COST:3 [ATK:3/HP:0] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give a random friendly Mech +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_036", new Power {
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.MECHANICAL)),
					new RandomTask(1, EntityType.STACK),
					new AddEnchantmentTask("GVG_036e", EntityType.STACK))
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [GVG_036e] Powered (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_036e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_036e")
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [GVG_018] Mistress of Pain - COST:2 [ATK:1/HP:4] 
			// - Race: demon, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GVG_018", null);

			// --------------------------------------- MINION - WARLOCK
			// [GVG_020] Fel Cannon - COST:4 [ATK:3/HP:5] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 2 damage to a non-Mech minion.
			// --------------------------------------------------------
			cards.Add("GVG_020", new Power {
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.ALLMINIONS),
						new FilterStackTask(SelfCondition.IsNotRace(Race.MECHANICAL)),
						new RandomTask(1, EntityType.STACK),
						new DamageTask(2, EntityType.STACK))
				}
			});

			// --------------------------------------- MINION - WARLOCK
			// [GVG_021] Mal'Ganis - COST:9 [ATK:9/HP:7] 
			// - Race: demon, Set: gvg, Rarity: legendary
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
			cards.Add("GVG_021", new Power {
				// TODO [GVG_021] Mal'Ganis && Test: Mal'Ganis_GVG_021
				InfoCardId = "GVG_021e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [GVG_077] Anima Golem - COST:6 [ATK:9/HP:9] 
			// - Race: mechanical, Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of each turn, destroy this minion if it's your only one.
			// --------------------------------------------------------
			cards.Add("GVG_077", new Power {
				// TODO [GVG_077] Anima Golem && Test: Anima Golem_GVG_077
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [GVG_100] Floating Watcher - COST:5 [ATK:4/HP:4] 
			// - Race: demon, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your hero takes damage on your turn, gain +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_100", new Power {
				// TODO Test: Floating Watcher_GVG_100
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.HERO,
					Condition = SelfCondition.IsMyTurn,
					SingleTask = new AddEnchantmentTask("GVG_100e", EntityType.SOURCE)
				}
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [GVG_015] Darkbomb - COST:2 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GVG_015", new Power {
				PowerTask = new DamageTask(3, EntityType.TARGET, true)
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [GVG_019] Demonheart - COST:5 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $5 damage to a minion.  If it's a friendly Demon, give it +5/+5 instead. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_019", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.TARGET,
						RelaCondition.IsFriendly,
						RelaCondition.IsOther(SelfCondition.IsRace(Race.DEMON))),
					new FlagTask(true, new AddEnchantmentTask("GVG_019e", EntityType.TARGET)),
					new FlagTask(false, new DamageTask(2, EntityType.TARGET)))
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [GVG_045] Imp-losion - COST:4 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2-$4 damage to a minion. Summon a 1/1 Imp for each damage dealt. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_045", new Power {
				PowerTask = ComplexTask.Create(
					new MathRandTask(2, 4),
					new DamageNumberTask(EntityType.TARGET, true),
					new EnqueueNumberTask(new SummonTask("GVG_045t"), true))
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [GVG_019e] Demonheart (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +5/+5.
			// --------------------------------------------------------
			cards.Add("GVG_019e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_019e")
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [GVG_021e] Grasp of Mal'Ganis (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Mal'Ganis is granting +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_021e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_021e")
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [GVG_100e] Brow Furrow (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GVG_100e", new Power {
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(2))
			});

			// --------------------------------------- MINION - WARLOCK
			// [GVG_045t] Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Set: gvg, 
			// --------------------------------------------------------
			cards.Add("GVG_045t", null);

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [GVG_051] Warbot - COST:1 [ATK:1/HP:3] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Enrage:</b> +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("GVG_051", new Power {
				//Trigger = Triggers.EnrageTrigger("GVG_051e")
				Aura = new EnrageEffect(AuraType.SELF, "GVG_051e")
			});

			// --------------------------------------- MINION - WARRIOR
			// [GVG_053] Shieldmaiden - COST:6 [ATK:5/HP:5] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain 5 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_053", new Power {
				PowerTask = new ArmorTask(5)
			});

			// --------------------------------------- MINION - WARRIOR
			// [GVG_055] Screwjank Clunker - COST:4 [ATK:2/HP:5] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Mech +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 17
			// --------------------------------------------------------
			cards.Add("GVG_055", new Power {
				PowerTask = new AddEnchantmentTask("GVG_055e", EntityType.TARGET)
			});

			// --------------------------------------- MINION - WARRIOR
			// [GVG_056] Iron Juggernaut - COST:6 [ATK:6/HP:5] 
			// - Race: mechanical, Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle a Mine into your opponent's deck. When drawn, it explodes for 10 damage.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_056", new Power {
				// TODO Test: Iron Juggernaut_GVG_056
				PowerTask = new AddCardTo("GVG_056t", EntityType.OP_DECK)
			});

			// --------------------------------------- MINION - WARRIOR
			// [GVG_086] Siege Engine - COST:5 [ATK:5/HP:5] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you gain Armor, give this minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_086", new Power {
				Trigger = new Trigger(TriggerType.ARMOR)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("GVG_086e", EntityType.SOURCE)
				}
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [GVG_050] Bouncing Blade - COST:3 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $1 damage to a random minion. Repeat until a minion dies. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("GVG_050", new Power {
				// TODO [GVG_050] Bouncing Blade && Test: Bouncing Blade_GVG_050
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [GVG_052] Crush - COST:7 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. If you have a damaged minion, this costs (4) less.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_052", new Power {
				PowerTask = new DestroyTask(EntityType.TARGET),
				Aura = new AdaptiveCostEffect(p => p.Controller.BoardZone.Any(m => m.Damage > 0) ? 4 : 0)
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [GVG_054] Ogre Warmaul - COST:3 [ATK:4/HP:0] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: 50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("GVG_054", new Power {
				// TODO [GVG_054] Ogre Warmaul && Test: Ogre Warmaul_GVG_054
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [GVG_051e] Enraged (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +1 Attack
			// --------------------------------------------------------
			cards.Add("GVG_051e", new Power {
				//Aura = new EnrageEffect(AuraType.SELF, Effects.Attack_N(1))
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_051e")
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [GVG_055e] Screwy Jank (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_055e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_055e")
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [GVG_086e] Armor Plated (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("GVG_086e", new Power {
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [GVG_056t] Burrowing Mine (*) - COST:6 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: [x]You take 10 damage.
			//       Draw a card. This
			//       explodes when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("GVG_056t", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(10, EntityType.HERO),
					new DrawTask()),
				TopdeckTask = ComplexTask.Create(
					new DamageTask(10, EntityType.HERO),
					new DrawTask())
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [GVG_006] Mechwarper - COST:2 [ATK:2/HP:3] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: Your Mechs cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_006", new Power {
				Aura = new Aura(AuraType.HAND, Effects.ReduceCost(1))
				{
					Condition = SelfCondition.IsRace(Race.MECHANICAL)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_013] Cogmaster - COST:1 [ATK:1/HP:2] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: Has +2 Attack while you have a Mech.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_013", new Power {
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.ADD,
					p => p.Controller.BoardZone.Any(m => m.Race == Race.MECHANICAL) ? 2 : 0)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_016] Fel Reaver - COST:5 [ATK:8/HP:8] 
			// - Race: mechanical, Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever your opponent plays a card, remove the top 3 cards of your deck.
			// --------------------------------------------------------
			cards.Add("GVG_016", new Power {
				// TODO [GVG_016] Fel Reaver && Test: Fel Reaver_GVG_016
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_044] Spider Tank - COST:3 [ATK:3/HP:4] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			cards.Add("GVG_044", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_064] Puddlestomper - COST:2 [ATK:3/HP:2] 
			// - Race: murloc, Set: gvg, Rarity: common
			// --------------------------------------------------------
			cards.Add("GVG_064", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_065] Ogre Brute - COST:3 [ATK:4/HP:4] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: 50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - FORGETFUL = 1
			// --------------------------------------------------------
			cards.Add("GVG_065", new Power {
				// TODO [GVG_065] Ogre Brute && Test: Ogre Brute_GVG_065
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_067] Stonesplinter Trogg - COST:2 [ATK:2/HP:3] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_067", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = new AddEnchantmentTask("GVG_067a", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_068] Burly Rockjaw Trogg - COST:4 [ATK:3/HP:5] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_068", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = new AddEnchantmentTask("GVG_068a", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_069] Antique Healbot - COST:5 [ATK:3/HP:3] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 8 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_069", new Power {
				PowerTask = new HealTask(8, EntityType.HERO)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_070] Salty Dog - COST:5 [ATK:7/HP:4] 
			// - Race: pirate, Set: gvg, Rarity: common
			// --------------------------------------------------------
			cards.Add("GVG_070", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_071] Lost Tallstrider - COST:4 [ATK:5/HP:4] 
			// - Race: beast, Set: gvg, Rarity: common
			// --------------------------------------------------------
			cards.Add("GVG_071", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_074] Kezan Mystic - COST:4 [ATK:4/HP:3] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Take control of a random enemy <b>Secret</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GVG_074", new Power {
				// TODO [GVG_074] Kezan Mystic && Test: Kezan Mystic_GVG_074
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_075] Ship's Cannon - COST:2 [ATK:2/HP:3] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: After you summon a Pirate, deal 2 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("GVG_075", new Power {
				Trigger = new Trigger(TriggerType.AFTER_SUMMON)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsRace(Race.PIRATE),
					SingleTask = ComplexTask.Create(
						new RandomTask(1, EntityType.ENEMIES),
						new DamageTask(2, EntityType.STACK))
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_076] Explosive Sheep - COST:2 [ATK:1/HP:1] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 2 damage to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_076", new Power {
				DeathrattleTask = new DamageTask(2, EntityType.ALLMINIONS)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_078] Mechanical Yeti - COST:4 [ATK:4/HP:5] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give each player a <b>Spare Part.</b>
			// --------------------------------------------------------
			// Entourage: PART_007, PART_006, PART_005, PART_001, PART_003, PART_002, PART_004
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("GVG_078", new Power {
				DeathrattleTask = ComplexTask.Create(
					ComplexTask.GetRandomEntourageCardToHand(),
					ComplexTask.GetRandomEntourageCardToHand(true))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_079] Force-Tank MAX - COST:8 [ATK:7/HP:7] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GVG_079", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_081] Gilblin Stalker - COST:2 [ATK:2/HP:3] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("GVG_081", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_082] Clockwork Gnome - COST:1 [ATK:2/HP:1] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a <b>Spare Part</b> card to your hand.
			// --------------------------------------------------------
			// Entourage: PART_007, PART_006, PART_005, PART_001, PART_003, PART_002, PART_004
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("GVG_082", new Power {
				DeathrattleTask = ComplexTask.GetRandomEntourageCardToHand()
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_084] Flying Machine - COST:3 [ATK:1/HP:4] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("GVG_084", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_085] Annoy-o-Tron - COST:2 [ATK:1/HP:2] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GVG_085", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_089] Illuminator - COST:3 [ATK:2/HP:4] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: If you control a <b>Secret</b> at the end of your turn, restore 4 Health to your hero.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GVG_089", new Power {
				// TODO Test: Illuminator_GVG_089
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					Condition = SelfCondition.IsControllingSecret,
					SingleTask = new HealTask(4, EntityType.HERO)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_090] Madder Bomber - COST:5 [ATK:5/HP:4] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 6 damage randomly split between all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_090", new Power {
				PowerTask =
					new EnqueueTask(6, ComplexTask.DamageRandomTargets(1, EntityType.ALL_NOSOURCE, 1))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_091] Arcane Nullifier X-21 - COST:4 [ATK:2/HP:5] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("GVG_091", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_092] Gnomish Experimenter - COST:3 [ATK:3/HP:2] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a card. If it's a minion, transform it into a Chicken.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_092", new Power {
				// TODO [GVG_092] Gnomish Experimenter && Test: Gnomish Experimenter_GVG_092
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_093] Target Dummy - COST:0 [ATK:0/HP:2] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GVG_093", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_094] Jeeves - COST:4 [ATK:1/HP:4] 
			// - Race: mechanical, Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of each player's turn, that player draws until they have 3 cards.
			// --------------------------------------------------------
			cards.Add("GVG_094", new Power {
				PowerTask = ComplexTask.Create(
					new FuncNumberTask(p =>
					{
						Controller controller = p.Controller;
						int diffHands = 3 - controller.HandZone.Count;
						return diffHands > 0 ? diffHands : 0;
					}),
					new EnqueueNumberTask(new DrawTask())),
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_095] Goblin Sapper - COST:3 [ATK:2/HP:4] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: Has +4 Attack while your opponent has 6 or more cards in hand.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_095", new Power {
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.ADD, p => p.Controller.Opponent.HandZone.Count > 5 ? 4 : 0)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_096] Piloted Shredder - COST:4 [ATK:4/HP:3] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random 2-Cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_096", new Power {
				DeathrattleTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.COST, 2),
					new SummonTask(SummonSide.DEATHRATTLE))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_097] Lil' Exorcist - COST:3 [ATK:2/HP:3] 
			// - Set: gvg, Rarity: rare
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
			cards.Add("GVG_097", new Power {
				// TODO [GVG_097] Lil' Exorcist && Test: Lil' Exorcist_GVG_097
				//PowerTask = ComplexTask.Create(
				//	new IncludeTask(EntityType.OP_MINIONS),
				//	new FilterStackTask(SelfCondition.IsDeathrattleMinion),
				//	new CountTask(EntityType.STACK),
				//	new AddEnchantmentTask("???", EntityType.SOURCE, true))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_098] Gnomeregan Infantry - COST:3 [ATK:1/HP:4] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("GVG_098", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_099] Bomb Lobber - COST:5 [ATK:3/HP:3] 
			// - Set: gvg, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 4 damage to a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_099", new Power {
				PowerTask = ComplexTask.Create(
					new RandomTask(1, EntityType.OP_MINIONS),
					new DamageTask(4, EntityType.STACK))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_102] Tinkertown Technician - COST:3 [ATK:3/HP:3] 
			// - Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a Mech, gain +1/+1 and add a <b>Spare Part</b> to your hand.
			// --------------------------------------------------------
			// Entourage: PART_007, PART_006, PART_005, PART_001, PART_003, PART_002, PART_004
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("GVG_102", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingRace(Race.MECHANICAL)),
					new FlagTask(true, ComplexTask.Create(
						new AddEnchantmentTask("GVG_102e", EntityType.SOURCE),
						ComplexTask.GetRandomEntourageCardToHand())))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_103] Micro Machine - COST:2 [ATK:1/HP:2] 
			// - Race: mechanical, Set: gvg, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of each turn, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_103", new Power {
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = new AddEnchantmentTask("GVG_076a", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_104] Hobgoblin - COST:3 [ATK:2/HP:3] 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you play a 1-Attack minion, give it +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_104", new Power {
				// TODO Test: Hobgoblin_GVG_104
				Trigger = new Trigger(TriggerType.SUMMON)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsTagValue(GameTag.ATK, 1),
					SingleTask = new AddEnchantmentTask("GVG_104a", EntityType.TARGET)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_105] Piloted Sky Golem - COST:6 [ATK:6/HP:4] 
			// - Race: mechanical, Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random 4-Cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_105", new Power {
				DeathrattleTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.COST, 4),
					new SummonTask(SummonSide.DEATHRATTLE))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_106] Junkbot - COST:5 [ATK:1/HP:5] 
			// - Race: mechanical, Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever a friendly Mech dies, gain +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_106", new Power {
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsRace(Race.MECHANICAL),
					SingleTask = new AddEnchantmentTask("GVG_106e", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_107] Enhance-o Mechano - COST:4 [ATK:3/HP:2] 
			// - Race: mechanical, Set: gvg, Rarity: epic
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
			cards.Add("GVG_107", new Power {
				// TODO [GVG_107] Enhance-o Mechano && Test: Enhance-o Mechano_GVG_107
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_108] Recombobulator - COST:2 [ATK:3/HP:2] 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform a friendly minion into a random minion with the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GVG_108", new Power {
				// TODO [GVG_108] Recombobulator && Test: Recombobulator_GVG_108
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_109] Mini-Mage - COST:4 [ATK:4/HP:1] 
			// - Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("GVG_109", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_110] Dr. Boom - COST:7 [ATK:7/HP:7] 
			// - Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/1 Boom Bots. <i>WARNING: Bots may explode.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_110", new Power {
				PowerTask = ComplexTask.Create(
					new SummonTask("GVG_110t", SummonSide.LEFT),
					new SummonTask("GVG_110t", SummonSide.RIGHT))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_111] Mimiron's Head - COST:5 [ATK:4/HP:5] 
			// - Race: mechanical, Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the start of your turn, if you have at least 3 Mechs, destroy them all and form V-07-TR-0N.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_111", new Power {
				// TODO [GVG_111] Mimiron's Head && Test: Mimiron's Head_GVG_111
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_112] Mogor the Ogre - COST:6 [ATK:7/HP:6] 
			// - Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: All minions have a 50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_112", new Power {
				// TODO [GVG_112] Mogor the Ogre && Test: Mogor the Ogre_GVG_112
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_113] Foe Reaper 4000 - COST:8 [ATK:6/HP:9] 
			// - Race: mechanical, Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever it attacks.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_113", new Power {
				// TODO [GVG_113] Foe Reaper 4000 && Test: Foe Reaper 4000_GVG_113
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_114] Sneed's Old Shredder - COST:8 [ATK:5/HP:7] 
			// - Race: mechanical, Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_114", new Power {
				DeathrattleTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.RARITY, (int)Rarity.LEGENDARY),
					new SummonTask(SummonSide.DEATHRATTLE))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_115] Toshley - COST:6 [ATK:5/HP:7] 
			// - Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b> Add a <b>Spare Part</b> card to your hand.
			// --------------------------------------------------------
			// Entourage: PART_007, PART_006, PART_005, PART_003, PART_002, PART_001, PART_004
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("GVG_115", new Power {
				PowerTask = ComplexTask.GetRandomEntourageCardToHand(),
				DeathrattleTask = ComplexTask.GetRandomEntourageCardToHand()
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_116] Mekgineer Thermaplugg - COST:9 [ATK:9/HP:7] 
			// - Race: mechanical, Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever an enemy minion dies, summon a Leper Gnome.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_116", new Power {
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = new SummonTask("EX1_029")
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_117] Gazlowe - COST:6 [ATK:3/HP:6] 
			// - Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you cast a 1-mana spell, add a random Mech to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_117", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsTagValue(GameTag.COST, 1),
					SingleTask = ComplexTask.Create(
						new RandomCardTask(CardType.INVALID, CardClass.INVALID, Race.MECHANICAL),
						new AddStackTo(EntityType.HAND))
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_118] Troggzor the Earthinator - COST:7 [ATK:6/HP:6] 
			// - Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, summon a Burly Rockjaw Trogg.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GVG_118", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = new SummonTask("GVG_068")
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_119] Blingtron 3000 - COST:5 [ATK:3/HP:4] 
			// - Race: mechanical, Set: gvg, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip a random weapon for each player.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GVG_119", new Power {
				// TODO [GVG_119] Blingtron 3000 && Test: Blingtron 3000_GVG_119
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_120] Hemet Nesingwary - COST:5 [ATK:6/HP:3] 
			// - Set: gvg, Rarity: legendary
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
			cards.Add("GVG_120", new Power {
				PowerTask = new DestroyTask(EntityType.TARGET)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_121] Clockwork Giant - COST:12 [ATK:8/HP:8] 
			// - Race: mechanical, Set: gvg, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each card in your opponent's hand.
			// --------------------------------------------------------
			cards.Add("GVG_121", new Power {
				Aura = new AdaptiveCostEffect(p => p.Controller.Opponent.HandZone.Count)
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_010b] Velen's Chosen (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +2/+4 and <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			cards.Add("GVG_010b", new Power {
				Enchant = new Enchant(
					Effects.Attack_N(2),
					Effects.Health_N(4),
					new Effect(GameTag.SPELLPOWER, EffectOperator.ADD, 1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_011a] Shrink Ray (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: -2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("GVG_011a", new Power {
				Enchant = new Enchant(ATK.Effect(EffectOperator.SUB, 2))
				{
					IsOneTurnEffect = true
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_022a] Tinker's Sharpsword Oil (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_022a", new Power {
				Enchant = new Enchant(GameTag.ATK, EffectOperator.ADD, 3)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_022b] Tinker's Sharpsword Oil (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_022b", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_022b")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_023a] Extra Sharp (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GVG_023a", new Power {
				Enchant = new Enchant(GameTag.ATK, EffectOperator.ADD, 1)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_057a] Seal of Light (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("GVG_057a", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_057a")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_063a] Retribution (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Increased Attack
			// --------------------------------------------------------
			cards.Add("GVG_063a", new Power {
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_067a] Metabolized Magic (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_067a", new Power {
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_068a] Metabolized Magic (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GVG_068a", new Power {
				Enchant = new OngoingEnchant(Effects.Attack_N(2))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_076a] Pistons (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("GVG_076a", new Power {
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_102e] Might of Tinkertown (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("GVG_102e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_102e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_104a] HERE, TAKE BUFF. (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("GVG_104a", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GVG_104a")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GVG_106e] Junked Up (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GVG_106e", new Power {
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(21))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [PART_001e] Armor Plating (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("PART_001e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("PART_001e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [PART_004e] Cloaked (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Stealthed until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("PART_004e", Power.OneTurnStealthEnchantmentPower);

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [PART_006a] Switched (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Reversing Switch.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("PART_006a", new Power {
				Enchant = Enchants.Enchants.SetAttackHealthScriptTag
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [PART_007e] Whirling Blades (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			cards.Add("PART_007e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("PART_007e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_092t] Chicken (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gvg, 
			// --------------------------------------------------------
			cards.Add("GVG_092t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_110t] Boom Bot (*) - COST:1 [ATK:1/HP:1] 
			// - Race: mechanical, Set: gvg, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 1-4 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GVG_110t", new Power {
				PowerTask = ComplexTask.Create(
					new RandomTask(1, EntityType.ENEMIES),
					new MathRandTask(1, 4),
					new DamageNumberTask(EntityType.STACK))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GVG_111t] V-07-TR-0N (*) - COST:8 [ATK:4/HP:8] 
			// - Race: mechanical, Set: gvg, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Mega-Windfury</b> <i>(Can attack four times a turn.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("GVG_111t", new Power {
				// TODO [GVG_111t] V-07-TR-0N && Test: V-07-TR-0N_GVG_111t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [GVG_028t] Gallywix's Coin (*) - COST:0 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Gain 1 Mana Crystal this turn only.
			//       <i>(Won't trigger Gallywix.)</i>
			// --------------------------------------------------------
			cards.Add("GVG_028t", new Power {
				PowerTask = new TempManaTask(1)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_001] Armor Plating (*) - COST:1 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Give a minion +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("PART_001", new Power {
				PowerTask = new AddEnchantmentTask("PART_001e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_002] Time Rewinder (*) - COST:1 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Return a friendly minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("PART_002", new Power {
				PowerTask = new ReturnHandTask(EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_003] Rusty Horn (*) - COST:1 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Give a minion <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("PART_003", new Power {
				PowerTask = ComplexTask.Taunt(EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_004] Finicky Cloakfield (*) - COST:1 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Give a friendly minion <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("PART_004", new Power {
				PowerTask = new AddEnchantmentTask("PART_004e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_005] Emergency Coolant (*) - COST:1 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("PART_005", new Power {
				PowerTask = ComplexTask.Freeze(EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_006] Reversing Switch (*) - COST:1 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Swap a minion's Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("PART_006", new Power {
				PowerTask = new SwapAttackHealthTask(EntityType.TARGET, "PART_006a")
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PART_007] Whirling Blades (*) - COST:1 
			// - Set: gvg, 
			// --------------------------------------------------------
			// Text: Give a minion +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - SPARE_PART = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("PART_007", new Power {
				PowerTask = new AddEnchantmentTask("PART_007e", EntityType.TARGET)
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			Druid(cards);
			DruidNonCollect(cards);
			Hunter(cards);
			HunterNonCollect(cards);
			Mage(cards);
			//MageNonCollect(cards);
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
