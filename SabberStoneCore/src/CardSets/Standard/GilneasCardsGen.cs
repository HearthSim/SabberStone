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
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Auras;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets.Standard
{
	public class GilneasCardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ HERO - SHAMAN
			// [GIL_504] Hagatha the Witch - COST:8 [ATK:0/HP:30] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 47631
			// --------------------------------------------------------
			cards.Add("GIL_504", new Power {
				PowerTask = new DamageTask(3, EntityType.ALLMINIONS)
			});

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GIL_504h] Bewitch (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       After you play a minion,
			//       add a random Shaman
			//       spell to your hand.
			// --------------------------------------------------------
			cards.Add("GIL_504h", new Power {
				Trigger = new Trigger(TriggerType.PLAY_MINION)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = ComplexTask.AddRandomShamanSpell
				}
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [GIL_130] Gloom Stag - COST:5 [ATK:2/HP:6] 
			// - Race: beast, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> If your deck has only odd-Cost cards, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_130", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasNoEvenCostInDeck),
					new FlagTask(true, new AddEnchantmentTask("GIL_130e", EntityType.SOURCE)))
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_188] Druid of the Scythe - COST:3 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Choose One -</b> Transform
			//       into a 4/2 with <b>Rush</b>;
			//       or a 2/4 with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_188", new Power {
				PowerTask = new TransformTask("GIL_188t3", EntityType.SOURCE)
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_507] Bewitched Guardian - COST:5 [ATK:4/HP:1] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Gain +1 Health
			//       _for each card in your hand._
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_507", new Power {
				PowerTask = ComplexTask.Create(
					new CountTask(EntityType.HAND),
					new AddEnchantmentTask("GIL_507e", EntityType.SOURCE, true))
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_658] Splintergraft - COST:8 [ATK:8/HP:8] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Choose a friendly
			//       minion. Add a 10/10 copy to
			//       your hand that costs (10).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_658", new Power {
				PowerTask = ComplexTask.Create(
					new CopyTask(EntityType.TARGET, Zone.HAND, addToStack: true),
					new AddEnchantmentTask("GIL_658e", EntityType.STACK))
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_800] Duskfallen Aviana - COST:5 [ATK:3/HP:7] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: On each player's turn, the first card played costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GIL_800", new Power {
				// TODO [GIL_800] Duskfallen Aviana : need optimisation
				Aura = new Aura(AuraType.HANDS, "GIL_800e2")
				{
					Condition = new SelfCondition(p => p.Controller == p.Game.CurrentPlayer && p.Controller.NumCardsPlayedThisTurn == 0),
					Restless = true
				}
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_833] Forest Guide - COST:4 [ATK:1/HP:6] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, both players draw a card.
			// --------------------------------------------------------
			cards.Add("GIL_833", new Power {
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new DrawTask(),
						new DrawOpTask())
				}
			});

			// ------------------------------------------ SPELL - DRUID
			// [GIL_553] Wispering Woods - COST:4 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Summon a 1/1 Wisp for
			//       each card in your hand.
			// --------------------------------------------------------
			cards.Add("GIL_553", new Power {
				PowerTask = ComplexTask.Create(
					new CountTask(EntityType.HAND),
					new EnqueueNumberTask(new SummonTask("GIL_553t")))
			});

			// ------------------------------------------ SPELL - DRUID
			// [GIL_571] Witching Hour - COST:3 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a random friendly Beast that died this game.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINIONS_OF_RACE_DIED_THIS_GAME = 20
			// --------------------------------------------------------
			cards.Add("GIL_571", new Power {
				// TODO Test: Witching Hour_GIL_571
				PowerTask = ComplexTask.SummonRandomMinionThatDied(SelfCondition.IsRace(Race.BEAST))
			});

			// ------------------------------------------ SPELL - DRUID
			// [GIL_637] Ferocious Howl - COST:3 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Draw a card.
			//       Gain 1 Armor for each card in your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_637", new Power {
				// TODO Test: Ferocious Howl_GIL_637
				PowerTask = ComplexTask.Create(
					new DrawTask(),
					new CountTask(EntityType.HAND),
					new ArmorTask())
			});

			// ------------------------------------------ SPELL - DRUID
			// [GIL_663] Witchwood Apple - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Add three 2/2 Treants to your hand.
			// --------------------------------------------------------
			cards.Add("GIL_663", new Power {
				PowerTask = new AddCardTo("GIL_663t", EntityType.HAND, 3)
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [GIL_188t] Druid of the Scythe (*) - COST:3 [ATK:4/HP:2] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_188t", null);

			// ----------------------------------------- MINION - DRUID
			// [GIL_188t2] Druid of the Scythe (*) - COST:3 [ATK:2/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GIL_188t2", null);

			// ----------------------------------------- MINION - DRUID
			// [GIL_188t3] Druid of the Scythe (*) - COST:3 [ATK:4/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_188t3", null);

			// ----------------------------------------- MINION - DRUID
			// [GIL_553t] Wisp (*) - COST:0 [ATK:1/HP:1] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_553t", null);

			// ----------------------------------------- MINION - DRUID
			// [GIL_663t] Treant (*) - COST:2 [ATK:2/HP:2] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_663t", null);

			// ------------------------------------------ SPELL - DRUID
			// [GIL_188a] Dire Panther Form (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2 Attack and <b>Rush</b>
			// --------------------------------------------------------
			cards.Add("GIL_188a", new Power {
				PowerTask = new TransformTask("GIL_188t", EntityType.SOURCE)
			});

			// ------------------------------------------ SPELL - DRUID
			// [GIL_188b] Dire Wolf Form (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2 Health and <b>Taunt</b>
			// --------------------------------------------------------
			cards.Add("GIL_188b", new Power {
				PowerTask = new TransformTask("GIL_188t2", EntityType.SOURCE)
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [GIL_128] Emeriss - COST:10 [ATK:8/HP:8] 
			// - Race: dragon, Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Double the Attack and Health of all minions in_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_128", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new AddEnchantmentTask("GIL_128e", EntityType.STACK))
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_200] Duskhaven Hunter - COST:3 [ATK:2/HP:5] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("GIL_200", new Power {
				Trigger = Triggers.WorgenTransform("GIL_200t", "GIL_200e")
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_562] Vilebrood Skitterer - COST:5 [ATK:1/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_562", null);

			// ---------------------------------------- MINION - HUNTER
			// [GIL_607] Toxmonger - COST:4 [ATK:2/HP:4] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Whenever you play a 1-Cost
			//       minion, give it <b>Poisonous</b>.
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("GIL_607", new Power {
				Trigger = new Trigger(TriggerType.PLAY_CARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsBaseTagValue(GameTag.COST, 1),
					SingleTask = new AddEnchantmentTask("GIL_607e", EntityType.TARGET)
				}
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_607t] Hunting Mastiff - COST:2 [ATK:2/HP:1] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_607t", null);

			// ---------------------------------------- MINION - HUNTER
			// [GIL_650] Houndmaster Shaw - COST:4 [ATK:3/HP:6] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your other minions have
			//       <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_650", new Power {
				Aura = new Aura(AuraType.BOARD_EXCEPT_SOURCE, "GIL_650e")
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_905] Carrion Drake - COST:5 [ATK:3/HP:7] 
			// - Race: dragon, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If a minion died this turn, gain <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("GIL_905", new Power {
				// TODO Test: Carrion Drake_GIL_905
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsAnyDiedThisTurn),
					new FlagTask(true, new AddEnchantmentTask("GIL_905e", EntityType.SOURCE)))
			});

			// ----------------------------------------- SPELL - HUNTER
			// [GIL_518] Wing Blast - COST:4 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $4 damage to a minion. If a minion died this turn, this costs (1). @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_518", new Power {
				// TODO Test: Wing Blast_GIL_518
				PowerTask = new DamageTask(4, EntityType.TARGET, true),
				Aura = new AdaptiveCostEffect(1, TriggerType.DEATH)
			});

			// ----------------------------------------- SPELL - HUNTER
			// [GIL_577] Rat Trap - COST:2 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Secret:</b> After your
			//       opponent plays three
			//       cards in a turn, summon
			//       a 6/6 Rat.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GIL_577", new Power {
				Trigger = new Trigger(TriggerType.AFTER_PLAY_CARD)
				{
					Condition = new SelfCondition(p => p.Controller.NumCardsPlayedThisTurn == 3),
					SingleTask = ComplexTask.Secret(new SummonTask("GIL_577t"))
				}
			});

			// ----------------------------------------- SPELL - HUNTER
			// [GIL_828] Dire Frenzy - COST:4 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Give a Beast +3/+3. Shuffle 3 copies into your deck with +3/+3.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 20
			// --------------------------------------------------------
			cards.Add("GIL_828", new Power {
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("GIL_828e", EntityType.TARGET),
					new CopyTask(EntityType.TARGET, Zone.DECK, 3, true),
					new AddEnchantmentTask("GIL_828e", EntityType.STACK))
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [GIL_200t] Duskhaven Hunter (*) - COST:3 [ATK:5/HP:2] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("GIL_200t", new Power {
				Trigger = Triggers.WorgenTransform("GIL_200", "GIL_200e")
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_577t] Doom Rat (*) - COST:6 [ATK:6/HP:6] 
			// - Race: beast, Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_577t", null);

			// ---------------------------------------- MINION - HUNTER
			// [ICC_828t5] Hunting Mastiff (*) - COST:2 [ATK:2/HP:1] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       <b>Rush</b>@<b>Echo</b>, <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("ICC_828t5", null);

			// ---------------------------------------- MINION - HUNTER
			// [ICC_828t6] Vilebrood Skitterer (*) - COST:5 [ATK:1/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			//       <b>Rush</b>@<b>Poisonous</b>, <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ICC_828t6", null);

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [GIL_116] Arcane Keysmith - COST:4 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a <b>Secret</b>. Put it into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("GIL_116", new Power {
				PowerTask = SpecificTask.ArcaneKeysmith
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_549] Toki, Time-Tinker - COST:6 [ATK:5/HP:5] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Add a random
			//       <b>Legendary</b> minion from
			//       the past to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_549", new Power {
				PowerTask = new SpecificTask.GetRandomPastLegendary()
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_640] Curio Collector - COST:5 [ATK:4/HP:4] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you draw a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("GIL_640", new Power {
				Trigger = new Trigger(TriggerType.DRAW)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("GIL_640e", EntityType.SOURCE)
				}
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_645] Bonfire Elemental - COST:5 [ATK:5/HP:5] 
			// - Race: elemental, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you played an_Elemental last turn, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_645", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
					new FlagTask(true, new DrawTask()))
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_664] Vex Crow - COST:4 [ATK:3/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a random
			//       2-Cost minion.
			// --------------------------------------------------------
			cards.Add("GIL_664", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = ComplexTask.Create(
						new RandomMinionTask(GameTag.COST, 2),
						new SummonTask())
				}
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_691] Archmage Arugal - COST:2 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you draw a minion, add a copy of it to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GIL_691", new Power {
				Trigger = new Trigger(TriggerType.DRAW)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsMinion,
					SingleTask = new CopyTask(EntityType.TARGET, Zone.HAND)
				}
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_838] Black Cat - COST:3 [ATK:3/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			//        <b>Battlecry:</b> If your deck has only odd-Cost cards, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_838", new Power {
				// TODO Test: Black Cat_GIL_838
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasNoEvenCostInDeck),
					new FlagTask(true, new DrawTask()))
			});

			// ------------------------------------------- SPELL - MAGE
			// [GIL_147] Cinderstorm - COST:3 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage randomly split among all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("GIL_147", new Power {
				PowerTask = new EnqueueTask(5, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1), true)
			});

			// ------------------------------------------- SPELL - MAGE
			// [GIL_548] Book of Specters - COST:2 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw 3 cards. Discard any spells drawn.
			// --------------------------------------------------------
			cards.Add("GIL_548", new Power {
				//PowerTask = ComplexTask.Create(
				//	new DrawTask(true, 3),
				//	new FilterStackTask(SelfCondition.IsSpell),
				//	new DiscardTask(EntityType.STACK))
				PowerTask = new EnqueueTask(3, ComplexTask.Create(
					new DrawTask(true),
					new ConditionTask(EntityType.STACK, SelfCondition.IsSpell, SelfCondition.IsInZone(Zone.HAND)),
					new FlagTask(true, new DiscardTask(EntityType.STACK))))
			});

			// ------------------------------------------- SPELL - MAGE
			// [GIL_801] Snap Freeze - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion.
			//       If it's already <b>Frozen</b>, destroy it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("GIL_801", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.TARGET, SelfCondition.IsFrozen),
					new FlagTask(false, ComplexTask.Freeze(EntityType.TARGET)),
					new FlagTask(true, new DestroyTask(EntityType.TARGET)))
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [GIL_545] Ghostly Charger - COST:5 [ATK:3/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_545", null);

			// --------------------------------------- MINION - PALADIN
			// [GIL_634] Bellringer Sentry - COST:4 [ATK:3/HP:4] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b> Put a <b>Secret</b> from your deck into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GIL_634", new Power {
				PowerTask = ComplexTask.PutSecretFromDeck,
				DeathrattleTask = ComplexTask.PutSecretFromDeck
			});

			// --------------------------------------- MINION - PALADIN
			// [GIL_635] Cathedral Gargoyle - COST:2 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain <b>Taunt</b> and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GIL_635", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, ComplexTask.Create(
						ComplexTask.Taunt(EntityType.SOURCE),
						ComplexTask.DivineShield(EntityType.SOURCE))))
			});

			// --------------------------------------- MINION - PALADIN
			// [GIL_685] Paragon of Light - COST:3 [ATK:2/HP:5] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: While this minion has 3 or more Attack, it has <b>Taunt</b> and <b>Lifesteal</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_685", new Power {
				//Aura = new AdaptiveEffect(SelfCondition.IsTagValue(GameTag.ATK, 3, RelaSign.GEQ), GameTag.TAUNT, GameTag.LIFESTEAL)
				Aura = new MultiAura(
					new AdaptiveEffect(SelfCondition.IsTagValue(GameTag.ATK, 3, RelaSign.GEQ), GameTag.TAUNT),
					new AdaptiveEffect(SelfCondition.IsTagValue(GameTag.ATK, 3, RelaSign.GEQ), GameTag.LIFESTEAL))
			});

			// --------------------------------------- MINION - PALADIN
			// [GIL_694] Prince Liam - COST:5 [ATK:5/HP:5] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Transform all
			//       1-Cost cards in your deck
			//       _into <b>Legendary</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_694", new Power {
				PowerTask = new FuncNumberTask(p =>
				{
					IReadOnlyList<Card> legendaries = RandomCardTask.GetCardList(p, CardType.MINION, rarity: Rarity.LEGENDARY);
					//p.Controller.DeckZone.ForEach((q, c, ls) =>
					//{
					//	if (q.Cost != 1) return;

					//	Generic.ChangeEntityBlock.Invoke(c, q, Util.Choose(ls));
					//}, p.Controller, legendaries);
					Random rnd = Util.Random;
					Controller c = p.Controller;
					DeckZone deck = c.DeckZone;

					for (int i = 0; i < deck.Count; i++)
					{
						if (deck[i].Cost != 1) continue;

						deck.SetEntity(i,
							Generic.ChangeEntityBlock.Invoke(c, deck[i], legendaries[rnd.Next(legendaries.Count)], false));
					}

					return 0;
				})
			});

			// --------------------------------------- MINION - PALADIN
			// [GIL_817] The Glass Knight - COST:4 [ATK:4/HP:3] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>
			//       Whenever you restore Health,
			//       gain <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GIL_817", new Power {
				Trigger = new Trigger(TriggerType.HEAL)
				{
					Condition = SelfCondition.IsEventSourceFriendly,
					SingleTask = ComplexTask.DivineShield(EntityType.SOURCE)
				}
			});

			// ---------------------------------------- SPELL - PALADIN
			// [GIL_145] Sound the Bells! - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       Give a minion +1/+2.
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_145", new Power {
				PowerTask = new AddEnchantmentTask("GIL_145e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - PALADIN
			// [GIL_203] Rebuke - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Enemy spells cost (5) more next turn.
			// --------------------------------------------------------
			cards.Add("GIL_203", new Power {
				PowerTask = new AddEnchantmentTask("GIL_203e", EntityType.OP_CONTROLLER)
			});

			// ---------------------------------------- SPELL - PALADIN
			// [GIL_903] Hidden Wisdom - COST:1 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Secret:</b> After your
			//       opponent plays three
			//       cards in a turn, draw
			//       2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GIL_903", new Power {
				Trigger = new Trigger(TriggerType.AFTER_PLAY_CARD)
				{
					Condition = new SelfCondition(p => p.Controller.NumCardsPlayedThisTurn == 3),
					SingleTask = ComplexTask.Secret(new DrawTask(2))
				}
			});

			// --------------------------------------- WEAPON - PALADIN
			// [GIL_596] Silver Sword - COST:8 [ATK:3/HP:0] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: After your hero attacks, give your minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			cards.Add("GIL_596", new Power {
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = new AddEnchantmentTask("GIL_596e", EntityType.MINIONS)

				}
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [GIL_145e] DING DONG! (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1/+2.
			// --------------------------------------------------------
			cards.Add("GIL_145e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_145e")
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [GIL_142] Chameleos - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: Each turn this is in your hand, transform it into a card your opponent is holding.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GIL_142", new Power {
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = new FuncNumberTask(p =>
					{
						if (p.Zone?.Type != Zone.HAND)
							return 0;

						Card pick = p.Controller.Opponent.HandZone.Random?.Card;
						if (pick == null) return 0;
						IPlayable result = Generic.ChangeEntityBlock.Invoke(p.Controller, p, pick, true);
						Generic.AddEnchantmentBlock.Invoke(p.Controller, Cards.FromId("GIL_142e"), p, result, 0, 0, false);
						return 0;
					}),
					FastExecution = true
				}
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_156] Quartz Elemental - COST:5 [ATK:5/HP:8] 
			// - Race: elemental, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Can't attack while damaged.
			// --------------------------------------------------------
			cards.Add("GIL_156", new Power {
				Aura = new AdaptiveEffect(SelfCondition.IsDamaged, GameTag.CANT_ATTACK)
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_190] Nightscale Matriarch - COST:7 [ATK:4/HP:9] 
			// - Race: dragon, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a friendly minion is healed, summon a 3/3_Whelp.
			// --------------------------------------------------------
			cards.Add("GIL_190", new Power {
				Trigger = new Trigger(TriggerType.HEAL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new SummonTask("GIL_190t")
				}
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_805] Coffin Crasher - COST:6 [ATK:6/HP:5] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a <b>Deathrattle</b> minion from your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_805", new Power {
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsDeathrattleMinion),
					new RandomTask(1, EntityType.STACK),
					new RemoveFromHand(EntityType.STACK),
					new SummonTask())
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_835] Squashling - COST:2 [ATK:2/HP:1] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Echo</b>
			//       <b>Battlecry:</b> Restore 2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - ECHO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GIL_835", new Power {
				PowerTask = new HealTask(2, EntityType.TARGET)
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_837] Glitter Moth - COST:5 [ATK:4/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has only odd-Cost cards, double the Health of your other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_837", new Power {
				// TODO Test: Glitter Moth_GIL_837
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasNoEvenCostInDeck),
					new AddEnchantmentTask("GIL_837e", EntityType.MINIONS_NOSOURCE))
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_840] Lady in White - COST:6 [ATK:5/HP:5] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Cast 'Inner Fire'
			//       _on every minion in your deck_
			//       <i>(set Attack equal to Health).</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_840", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.SOURCE),
					new IncludeTask(EntityType.DECK, null, true),
					new FilterStackTask(SelfCondition.IsMinion),
					new FuncPlayablesTask(list =>
					{
						IPlayable source = list[0];
						Controller c = source.Controller;
						Card enchantment = Cards.FromId("GIL_840e");
						for (int i = 0; i < list.Count; i++)
							Generic.AddEnchantmentBlock(c, enchantment, source, list[i], list[i].Card.Health, 0, false);
						return null;
					}))
			});

			// ----------------------------------------- SPELL - PRIEST
			// [GIL_134] Holy Water - COST:5 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $4 damage to a minion. If that kills it, add a copy of it to your_hand. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_134", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(4, EntityType.TARGET, true),
					new ConditionTask(EntityType.TARGET, SelfCondition.IsDead),
					new FlagTask(true, new CopyTask(EntityType.TARGET, Zone.HAND)))
			});

			// ----------------------------------------- SPELL - PRIEST
			// [GIL_661] Divine Hymn - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #6 Health to all friendly characters.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_661", new Power {
				PowerTask = new HealTask(6, EntityType.FRIENDS)
			});

			// ----------------------------------------- SPELL - PRIEST
			// [GIL_813] Vivid Nightmare - COST:3 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Choose a friendly minion.
			//       Summon a copy of it with
			//       1 Health remaining.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_813", new Power {
				PowerTask = ComplexTask.Create(
					new SummonCopyTask(EntityType.TARGET, false, true),
					new GetGameTagTask(GameTag.HEALTH, EntityType.STACK),
					new MathSubstractionTask(1),
					new SetGameTagNumberTask(GameTag.DAMAGE, EntityType.STACK))
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [GIL_840e] Angelic Fortitude (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Has Attack equal to its Health.
			// --------------------------------------------------------
			cards.Add("GIL_840e", new Power {
				Enchant = Enchants.Enchants.SetAttackScriptTag
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_190t] Nightscale Whelp (*) - COST:3 [ATK:3/HP:3] 
			// - Race: dragon, Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_190t", null);

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [GIL_510] Mistwraith - COST:4 [ATK:3/HP:5] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you play an <b>Echo</b>_card, gain +1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_510", new Power {
				Trigger = new Trigger(TriggerType.PLAY_CARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsEchoCard,
					SingleTask = new AddEnchantmentTask("GIL_510e", EntityType.SOURCE)
				}
			});

			// ----------------------------------------- MINION - ROGUE
			// [GIL_557] Cursed Castaway - COST:6 [ATK:5/HP:3] 
			// - Race: pirate, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Deathrattle:</b> Draw a <b>Combo</b> card from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			// RefTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("GIL_557", new Power {
				DeathrattleTask = ComplexTask.DrawFromDeck(1, SelfCondition.IsComboCard)
			});

			// ----------------------------------------- MINION - ROGUE
			// [GIL_598] Tess Greymane - COST:8 [ATK:6/HP:6] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Replay every card
			//       from another class you've
			//       played this game <i>(targets
			//       chosen randomly)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_598", new Power {
				// TODO Test: Tess Greymane_GIL_598
				// see SabberStoneCoreConsole/Program.cs/TessGreymane()
				PowerTask = SpecificTask.TessGreymane
			});

			// ----------------------------------------- MINION - ROGUE
			// [GIL_677] Face Collector - COST:3 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       <b>Battlecry:</b> Add a random <b>Legendary</b> minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_677", new Power {
				PowerTask = ComplexTask.Create(
					new RandomCardTask(CardType.MINION, CardClass.INVALID, rarity: Rarity.LEGENDARY),
					new AddStackTo(EntityType.HAND))
			});

			// ----------------------------------------- MINION - ROGUE
			// [GIL_827] Blink Fox - COST:3 [ATK:3/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random card to your hand <i>(from your opponent's class).</i>
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_827", new Power {
				PowerTask = ComplexTask.AddRandomOpClassCardToHand
			});

			// ----------------------------------------- MINION - ROGUE
			// [GIL_902] Cutthroat Buccaneer - COST:3 [ATK:2/HP:4] 
			// - Race: pirate, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Give your weapon +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("GIL_902", new Power {
				ComboTask = new AddEnchantmentTask("GIL_902e", EntityType.WEAPON)
			});

			// ------------------------------------------ SPELL - ROGUE
			// [GIL_506] Cheap Shot - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//        Deal $2 damage to a_minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_506", new Power {
				PowerTask = new DamageTask(2, EntityType.TARGET, true)
			});

			// ------------------------------------------ SPELL - ROGUE
			// [GIL_687] WANTED! - COST:4 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $3 damage to a minion. If that kills it, add a Coin to your hand. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_687", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(3, EntityType.TARGET, true),
					new ConditionTask(EntityType.TARGET, SelfCondition.IsDead),
					new FlagTask(true, new AddCardTo("GAME_005", EntityType.HAND)))
			});

			// ------------------------------------------ SPELL - ROGUE
			// [GIL_696] Pick Pocket - COST:2 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       Add a random card to your hand <i>(from your opponent's class).</i>
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_696", new Power {
				PowerTask = ComplexTask.AddRandomOpClassCardToHand
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [GIL_672] Spectral Cutlass - COST:4 [ATK:2/HP:0] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Lifesteal</b>
			//       Whenever you play a card
			//       from another class,
			//       gain +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_672", new Power {
				Trigger = new Trigger(TriggerType.PLAY_CARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = new SelfCondition(p => p.Card.Class != p.Controller.Hero.Card.Class),
					SingleTask = new AddEnchantmentTask("GIL_672e", EntityType.SOURCE)
				}
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [GIL_827e1] Pounce (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			cards.Add("GIL_827e1", new Power {
				// TODO [GIL_827e1] Pounce && Test: Pounce_GIL_827e1
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [GIL_827e2] Bite (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			cards.Add("GIL_827e2", new Power {
				// TODO [GIL_827e2] Bite && Test: Bite_GIL_827e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [GIL_827e3] Rabid (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("GIL_827e3", new Power {
				// TODO [GIL_827e3] Rabid && Test: Rabid_GIL_827e3
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [GIL_827e4] Flurry (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			cards.Add("GIL_827e4", new Power {
				// TODO [GIL_827e4] Flurry && Test: Flurry_GIL_827e4
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [GIL_530] Murkspark Eel - COST:2 [ATK:2/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has only even-Cost cards, deal_2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_DRAG_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GIL_530", new Power {
				// TODO Test: Murkspark Eel_GIL_530
				// play requirement?
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasNoOddCostInDeck),
					new FlagTask(true, new DamageTask(2, EntityType.TARGET)))
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GIL_531] Witch's Apprentice - COST:1 [ATK:0/HP:1] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Add a random Shaman spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_531", new Power {
				PowerTask = ComplexTask.AddRandomShamanSpell
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GIL_583] Totem Cruncher - COST:4 [ATK:2/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Destroy your Totems. Gain +2/+2 for each destroyed.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_583", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.TOTEM)),
					new CountTask(EntityType.STACK),
					new DestroyTask(EntityType.STACK, true),
					new MathMultiplyTask(2),
					new AddEnchantmentTask("GIL_583e", EntityType.SOURCE, true))

			});

			// ---------------------------------------- MINION - SHAMAN
			// [GIL_678] Ghost Light Angler - COST:2 [ATK:2/HP:2] 
			// - Race: murloc, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_678", null);

			// ---------------------------------------- MINION - SHAMAN
			// [GIL_807] Bogshaper - COST:7 [ATK:4/HP:8] 
			// - Race: elemental, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, draw a minion from your_deck.
			// --------------------------------------------------------
			cards.Add("GIL_807", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = ComplexTask.DrawFromDeck(1, SelfCondition.IsMinion)
				}
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GIL_820] Shudderwock - COST:9 [ATK:6/HP:6] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Repeat all other
			//       <b>Battlecries</b> from cards you
			//       played this game <i>(targets
			//       chosen randomly)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - 960 = 1
			// --------------------------------------------------------
			cards.Add("GIL_820", new Power {
				// TODO Test: Shudderwock_GIL_820
				PowerTask = SpecificTask.Shudderwock
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [GIL_586] Earthen Might - COST:2 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Give a minion +2/+2.
			//       If it's an Elemental, add
			//       a random Elemental
			//       to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_586", new Power {
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("GIL_586e", EntityType.TARGET),
					new ConditionTask(EntityType.TARGET, SelfCondition.IsRace(Race.ELEMENTAL)),
					new FlagTask(true, ComplexTask.Create(
						new RandomCardTask(CardType.MINION, CardClass.INVALID, Race.ELEMENTAL),
						new AddStackTo(EntityType.HAND))))
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [GIL_600] Zap! - COST:0 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. <b>Overload:</b> (1) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_600", new Power {
				PowerTask = new DamageTask(2, EntityType.TARGET, true)
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [GIL_836] Blazing Invocation - COST:1 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Battlecry</b> minion.
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("GIL_836", new Power {
				PowerTask = new DiscoverTask(DiscoverType.BATTLECRY)
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [GIL_508] Duskbat - COST:3 [ATK:2/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your hero took damage this turn, summon two 1/1 Bats.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_508", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsMyHeroDamagedThisTurn),
					new FlagTask(true, new SummonTask("GIL_508t", 2)))
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_515] Ratcatcher - COST:3 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Battlecry:</b> Destroy a friendly minion and gain its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("GIL_515", new Power {
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.TARGET),
					new GetGameTagTask(GameTag.HEALTH, EntityType.TARGET, 0, 1),
					new DestroyTask(EntityType.TARGET, true),
					new AddEnchantmentTask("GIL_515e", EntityType.SOURCE, true))
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_565] Deathweb Spider - COST:5 [ATK:4/HP:6] 
			// - Race: beast, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your hero
			//       took damage this turn, gain <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_565", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsMyHeroDamagedThisTurn),
					new FlagTask(true, new SetGameTagTask(GameTag.LIFESTEAL, 1, EntityType.SOURCE)))
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_608] Witchwood Imp - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>
			//       <b>Deathrattle:</b> Give a random
			//         friendly minion +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_608", new Power {
				DeathrattleTask = ComplexTask.Create(
					new RandomTask(1, EntityType.MINIONS),
					new AddEnchantmentTask("GIL_608e", EntityType.STACK))
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_618] Glinda Crowskin - COST:6 [ATK:3/HP:7] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: Minions in your hand have_<b>Echo</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_618", new Power {
				Aura = new Aura(AuraType.HAND, new Effect(GameTag.ECHO, EffectOperator.SET, 1))
				{
					Condition = SelfCondition.IsMinion
				}
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_693] Blood Witch - COST:4 [ATK:3/HP:6] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 1 damage to your_hero.
			// --------------------------------------------------------
			cards.Add("GIL_693", new Power {
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = new DamageTask(1, EntityType.HERO)
				}
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_825] Lord Godfrey - COST:7 [ATK:4/HP:4] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 2 damage to
			//       all other minions. If any die,
			//       repeat this <b>Battlecry</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_825", new Power {
				// TODO Test: Lord Godfrey_GIL_825
				PowerTask = ComplexTask.RecursiveTask(
					new ConditionTask(EntityType.SOURCE, new SelfCondition(p => p.Game.DeadMinions.Count > 0)),
					new FuncNumberTask(p =>
					{
						p.Game.DeathProcessingAndAuraUpdate();
						return 0;
					}),
					new DamageTask(2, EntityType.ALLMINIONS_NOSOURCE))
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [GIL_191] Fiendish Circle - COST:4 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Summon four 1/1 Imps.
			// --------------------------------------------------------
			cards.Add("GIL_191", new Power {
				PowerTask = new SummonTask("GIL_191t", 4)
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [GIL_543] Dark Possession - COST:1 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to a friendly character. <b>Discover</b> a Demon. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("GIL_543", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(2, EntityType.TARGET, true),
					new DiscoverTask(DiscoverType.DEMON))
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [GIL_665] Curse of Weakness - COST:2 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       Give all enemy minions -2_Attack until your next_turn.
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_665", new Power {
				PowerTask = new AddEnchantmentTask("GIL_665e", EntityType.OP_MINIONS)
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [GIL_608e] Infusion (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("GIL_608e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_608e")
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_191t] Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_191t", null);

			// --------------------------------------- MINION - WARLOCK
			// [GIL_508t] Bat (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_508t", null);

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [GIL_113] Rabid Worgen - COST:3 [ATK:3/HP:3] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_113", null);

			// --------------------------------------- MINION - WARRIOR
			// [GIL_152] Blackhowl Gunspire - COST:7 [ATK:3/HP:8] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Can't attack. Whenever
			//       this minion takes damage,
			//       deal 3 damage to a
			//       random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("GIL_152", new Power {
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 3)
				}
			});

			// --------------------------------------- MINION - WARRIOR
			// [GIL_155] Redband Wasp - COST:2 [ATK:1/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       Has +3 Attack while damaged.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_155", new Power {
				//Trigger = Triggers.EnrageTrigger("GIL_155e")
				Aura = new EnrageEffect(AuraType.SELF, "GIL_155e")
			});

			// --------------------------------------- MINION - WARRIOR
			// [GIL_547] Darius Crowley - COST:5 [ATK:4/HP:4] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       After this attacks and kills
			//       a minion, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_547", new Power {
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					Condition = SelfCondition.IsDefenderDead,
					SingleTask = new AddEnchantmentTask("GIL_547e", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - WARRIOR
			// [GIL_580] Town Crier - COST:1 [ATK:1/HP:2] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a <b>Rush</b> minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_580", new Power {
				PowerTask = ComplexTask.DrawFromDeck(1, SelfCondition.HasRush)
			});

			// --------------------------------------- MINION - WARRIOR
			// [GIL_655] Festeroot Hulk - COST:5 [ATK:2/HP:7] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: After a friendly minion attacks, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("GIL_655", new Power {
				// TODO
				//Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				//{
				//	TriggerSource = TriggerSource.MINIONS,
				//	SingleTask = new AddEnchantmentTask("GIL_655e", EntityType.SOURCE)
				//}
			});

			// --------------------------------------- MINION - WARRIOR
			// [GIL_803] Militia Commander - COST:4 [ATK:2/HP:5] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Battlecry:</b> Gain +3_Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_803", new Power {
				PowerTask = new AddEnchantmentTask("GIL_803e", EntityType.SOURCE)
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [GIL_537] Deadly Arsenal - COST:6 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: Reveal a weapon from your deck. Deal its Attack to all minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("GIL_537", new Power {
				// TODO [GIL_537] Deadly Arsenal && Test: Deadly Arsenal_GIL_537
				// RevealCardBlock
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsWeapon),
					new RandomTask(1, EntityType.STACK),
					new GetGameTagTask(GameTag.ATK, EntityType.STACK),
					new DamageNumberTask(EntityType.ALLMINIONS, true))
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [GIL_654] Warpath - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       Deal $1 damage to all_minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_654", new Power {
				PowerTask = new DamageTask(1, EntityType.ALLMINIONS, true)
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [GIL_653] Woodcutter's Axe - COST:2 [ATK:2/HP:0] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give +2/+1 to a random friendly <b>Rush</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_653", new Power {
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.HasRush),
					new RandomTask(1, EntityType.STACK),
					new AddEnchantmentTask("GIL_653e", EntityType.STACK))
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [GIL_803e] Reckless (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("GIL_803e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_803e")
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [GIL_117] Worgen Abomination - COST:7 [ATK:6/HP:6] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 2 damage to all other damaged minions.
			// --------------------------------------------------------
			cards.Add("GIL_117", new Power {
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.ALLMINIONS_NOSOURCE),
						new FilterStackTask(SelfCondition.IsDamaged),
						new DamageTask(2, EntityType.STACK))
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_118] Deranged Doctor - COST:8 [ATK:8/HP:8] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Restore 8 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_118", new Power {
				DeathrattleTask = new HealTask(8, EntityType.HERO)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_119] Cauldron Elemental - COST:8 [ATK:7/HP:7] 
			// - Race: elemental, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Your other Elementals have +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GIL_119", new Power {
				Aura = new Aura(AuraType.BOARD_EXCEPT_SOURCE, "GIL_119e")
				{
					Condition = SelfCondition.IsRace(Race.ELEMENTAL)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_120] Furious Ettin - COST:7 [ATK:5/HP:9] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GIL_120", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_121] Darkmire Moonkin - COST:7 [ATK:2/HP:8] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +2</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 2
			// --------------------------------------------------------
			cards.Add("GIL_121", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_124] Mossy Horror - COST:6 [ATK:2/HP:7] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all other_minions with 2_or_less_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_124", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS_NOSOURCE),
					new FilterStackTask(SelfCondition.IsTagValue(GameTag.ATK, 2, RelaSign.LEQ)),
					new DestroyTask(EntityType.STACK))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_125] Mad Hatter - COST:4 [ATK:3/HP:2] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Randomly toss
			//       3 hats to other minions.
			//       Each hat gives +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 11
			// --------------------------------------------------------
			cards.Add("GIL_125", new Power {
				PowerTask = ComplexTask.Create(
					new RandomTask(3, EntityType.ALLMINIONS_NOSOURCE),
					new AddEnchantmentTask("GIL_125e", EntityType.STACK))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_143] Vicious Scalehide - COST:2 [ATK:1/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_143", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_198] Azalina Soulthief - COST:7 [ATK:3/HP:3] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Replace your hand with a copy of your_opponent's.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_198", new Power {
				// TODO [GIL_198] Azalina Soulthief && Test: Azalina Soulthief_GIL_198
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_201] Pumpkin Peasant - COST:3 [ATK:2/HP:4] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Lifesteal</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_201", new Power {
				Trigger = Triggers.WorgenTransform("GIL_201t", "GIL_200e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_202] Gilnean Royal Guard - COST:8 [ATK:3/HP:8] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>, <b>Rush</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_202", new Power {
				Trigger = Triggers.WorgenTransform("GIL_202t", "GIL_200e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_207] Phantom Militia - COST:3 [ATK:2/HP:4] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_207", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_212] Ravencaller - COST:3 [ATK:2/HP:1] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Add two
			//       random 1-Cost minions
			//       to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_212", new Power {
				PowerTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.COST, 1, 2),
					new AddStackTo(EntityType.HAND))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_213] Tanglefur Mystic - COST:3 [ATK:3/HP:4] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random
			//       2-Cost minion to each player's hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_213", new Power {
				PowerTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.COST, 2),
					new AddStackTo(EntityType.HAND),
					new RandomMinionTask(GameTag.COST, 2, opponent: true),
					new AddStackTo(EntityType.OP_HAND))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_513] Lost Spirit - COST:2 [ATK:1/HP:1] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give your minions +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_513", new Power {
				DeathrattleTask = new AddEnchantmentTask("GIL_513e", EntityType.MINIONS)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_526] Wyrmguard - COST:7 [ATK:3/HP:11] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GIL_526", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, new AddEnchantmentTask("GIL_526e", EntityType.SOURCE)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_527] Felsoul Inquisitor - COST:4 [ATK:1/HP:6] 
			// - Race: demon, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_527", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_528] Swift Messenger - COST:4 [ATK:2/HP:6] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_528", new Power {
				Trigger = Triggers.WorgenTransform("GIL_528t", "GIL_200e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_529] Spellshifter - COST:2 [ATK:1/HP:4] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Spell Damage +1</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("GIL_529", new Power {
				Trigger = Triggers.WorgenTransform("GIL_529t", "GIL_200e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_534] Hench-Clan Thug - COST:3 [ATK:3/HP:3] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: After your hero attacks, give this minion +1/+1.
			// --------------------------------------------------------
			cards.Add("GIL_534", new Power {
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = new AddEnchantmentTask("GIL_534t", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_558] Swamp Leech - COST:1 [ATK:2/HP:1] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_558", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_561] Blackwald Pixie - COST:3 [ATK:3/HP:4] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Refresh your Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_561", new Power {
				PowerTask = new SetGameTagTask(GameTag.EXHAUSTED, 0, EntityType.HERO_POWER)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_578] Countess Ashmore - COST:7 [ATK:6/HP:6] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw a <b>Rush</b>,
			//       <b>Lifesteal</b>, and <b>Deathrattle</b>
			//       card from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - LIFESTEAL = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_578", new Power {
				PowerTask = ComplexTask.Create(
					ComplexTask.DrawFromDeck(1, SelfCondition.HasRush),
					ComplexTask.DrawFromDeck(1, SelfCondition.IsLifestealCard),
					ComplexTask.DrawFromDeck(1, SelfCondition.IsDeathrattleCard))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_581] Sandbinder - COST:4 [ATK:2/HP:4] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw an Elemental from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_581", new Power {
				PowerTask = ComplexTask.DrawFromDeck(1, SelfCondition.IsRace(Race.ELEMENTAL))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_584] Witchwood Piper - COST:4 [ATK:3/HP:3] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw the lowest
			//       Cost minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_584", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FuncPlayablesTask(deck =>
					{
						IPlayable[] ordered = deck.Where(p => p is Minion).OrderBy(p => p.Cost).ToArray();
						if (ordered.Length == 0) return new List<IPlayable>();
						int lowest = ordered[0].Cost;
						return ordered.TakeWhile(p => p.Cost == lowest).ToList();
					}),
					new RandomTask(1, EntityType.STACK),
					new DrawTask())
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_601] Scaleworm - COST:4 [ATK:4/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_601", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new AddEnchantmentTask("GIL_601e", EntityType.SOURCE))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_614] Voodoo Doll - COST:3 [ATK:1/HP:1] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a minion. <b>Deathrattle:</b> Destroy the chosen minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_614", new Power {
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ENTITY_ID, EntityType.TARGET),
					new AddEnchantmentTask("GIL_614e2", EntityType.SOURCE, true),
					new AddEnchantmentTask("GIL_614e1", EntityType.TARGET))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_616] Splitting Festeroot - COST:8 [ATK:4/HP:4] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 2/2 Splitting Saplings.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_616", new Power {
				DeathrattleTask = new SummonTask("GIL_616t", 2)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_620] Dollmaster Dorian - COST:5 [ATK:2/HP:6] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you draw a minion, summon a 1/1 copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GIL_620", new Power {
				Trigger = new Trigger(TriggerType.DRAW)
				{
					Condition = SelfCondition.IsMinion,
					SingleTask = ComplexTask.Create(
						new CopyTask(EntityType.TARGET, Zone.PLAY, addToStack: true),
						new AddEnchantmentTask("GIL_620e", EntityType.STACK))
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_622] Lifedrinker - COST:4 [ATK:3/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 3 damage to
			//       the enemy hero. Restore
			//       3 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_622", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(3, EntityType.OP_HERO),
					new HealTask(3, EntityType.HERO))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_623] Witchwood Grizzly - COST:5 [ATK:3/HP:12] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Lose 1 Health
			//       for each card in your
			//       opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_623", new Power {
				PowerTask = ComplexTask.Create(
					new CountTask(EntityType.OP_HAND),
					new AddEnchantmentTask("GIL_623e", EntityType.SOURCE, true))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_624] Night Prowler - COST:4 [ATK:3/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If this is the only minion in the battlefield, gain +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_624", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsBoardCount(1)),
					new FlagTask(true, new AddEnchantmentTask("GIL_624e", EntityType.SOURCE)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_646] Clockwork Automaton - COST:5 [ATK:4/HP:4] 
			// - Race: mechanical, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Double the damage and_healing of your Hero_Power.
			// --------------------------------------------------------
			cards.Add("GIL_646", new Power {
				Aura = new Aura(AuraType.CONTROLLER, new Effect(GameTag.HERO_POWER_DOUBLE, EffectOperator.ADD, 1))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_648] Chief Inspector - COST:5 [ATK:4/HP:6] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all enemy <b>Secrets</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GIL_648", new Power {
				PowerTask = new MoveToGraveYard(EntityType.OP_SECRETS)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_667] Rotten Applebaum - COST:5 [ATK:4/HP:5] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Restore 4 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_667", new Power {
				DeathrattleTask = new HealTask(4, EntityType.HERO)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_680] Walnut Sprite - COST:3 [ATK:3/HP:3] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_680", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_681] Nightmare Amalgam - COST:3 [ATK:3/HP:4] 
			// - Race: all, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<i>This is an Elemental, Mech,
			//       Demon, Murloc, Dragon,
			//       Beast, Pirate and Totem.</i>
			// --------------------------------------------------------
			cards.Add("GIL_681", new Power {
				// TODO [GIL_681] Nightmare Amalgam && Test: Nightmare Amalgam_GIL_681
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_682] Muck Hunter - COST:5 [ATK:5/HP:8] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Battlecry:</b> Summon two 2/1_Mucklings for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_682", new Power {
				PowerTask = new SummonTask("GIL_682t", 2)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_683] Marsh Drake - COST:3 [ATK:5/HP:4] 
			// - Race: dragon, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/1 <b>Poisonous</b> Drakeslayer for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("GIL_683", new Power {
				PowerTask = new SummonOpTask("GIL_683t")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_692] Genn Greymane - COST:6 [ATK:6/HP:5] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Start of Game:</b>
			//       If your deck has only even-
			//       Cost cards, your starting
			//       Hero Power costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - COLLECTIONMANAGER_FILTER_MANA_EVEN = 1
			// - START_OF_GAME = 1
			// --------------------------------------------------------
			cards.Add("GIL_692", new Power {
				Trigger = new Trigger(TriggerType.GAME_START)
				{
					TriggerActivation = TriggerActivation.DECK,
					Condition = SelfCondition.HasNoOddCostInDeck,
					SingleTask = new AddEnchantmentTask("GIL_692e", EntityType.HERO_POWER),
					RemoveAfterTriggered = true
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_809] Unpowered Steambot - COST:4 [ATK:0/HP:9] 
			// - Race: mechanical, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GIL_809", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_815] Baleful Banker - COST:2 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Shuffle a copy of it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_815", new Power {
				PowerTask = new CopyTask(EntityType.TARGET, Zone.DECK)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_816] Swamp Dragon Egg - COST:1 [ATK:0/HP:3] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Dragon to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_816", new Power {
				DeathrattleTask = ComplexTask.Create(
					new RandomCardTask(CardType.INVALID, CardClass.INVALID, Race.DRAGON),
					new AddStackTo(EntityType.HAND))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_819] Witch's Cauldron - COST:3 [ATK:0/HP:4] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: After a friendly minion dies, add a random Shaman spell to your hand.
			// --------------------------------------------------------
			cards.Add("GIL_819", new Power {
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = ComplexTask.AddRandomShamanSpell
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_826] Baku the Mooneater - COST:9 [ATK:7/HP:8] 
			// - Race: beast, Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Start of Game:</b>
			//       If your deck has only odd-
			//       Cost cards, upgrade
			//       your Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - COLLECTIONMANAGER_FILTER_MANA_ODD = 1
			// - START_OF_GAME = 1
			// --------------------------------------------------------
			cards.Add("GIL_826", new Power {
				Trigger = new Trigger(TriggerType.GAME_START)
				{
					TriggerActivation = TriggerActivation.DECK,
					Condition = SelfCondition.HasNoEvenCostInDeck,
					SingleTask = SpecificTask.JusticarTrueheart,
					RemoveAfterTriggered = true
				}
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_000] Echo Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Destroy card if in hand at the end of turn.
			// --------------------------------------------------------
			// GameTag:
			// - GHOSTLY = 1
			// --------------------------------------------------------
			cards.Add("GIL_000", new Power {
				// TODO [GIL_000] Echo Enchant && Test: Echo Enchant_GIL_000
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_119e] Toil and Trouble (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Cauldron Elemental is granting this +2 Attack.
			// --------------------------------------------------------
			cards.Add("GIL_119e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_119e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_125e] Hat (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("GIL_125e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_125e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_128e] Mark of Emeriss (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Doubled Attack and Health.
			// --------------------------------------------------------
			cards.Add("GIL_128e", new Power {
				Enchant = new Enchant(
					ATK.Effect(EffectOperator.MUL, 2),
					Health.Effect(EffectOperator.MUL, 2))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_130e] Fable (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("GIL_130e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_130e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_142e] Shifting (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Transforming into random card from your opponent's hand.
			// --------------------------------------------------------
			cards.Add("GIL_142e", new Power {
				Enchant = new Enchant(GameTag.SHIFTING, EffectOperator.SET, 1)
				{
					RemoveWhenPlayed = true
				},
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					FastExecution = true,
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.SOURCE),
						new IncludeTask(EntityType.TARGET, addFlag: true),
						new FuncPlayablesTask(list =>
						{
							IPlayable p = list[1];

							if (p.Zone != p.Controller.HandZone)
								return null;

							Card pick = p.Controller.Opponent.HandZone.Random?.Card;
							if (pick == null) return null;
							IPlayable result = Generic.ChangeEntityBlock.Invoke(p.Controller, p, pick, true);
							Generic.AddEnchantmentBlock(p.Controller, Cards.FromId("GIL_142e"), list[0], result, 0, 0,
								false);
							return null;
						}))
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_155e] Enraged (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("GIL_155e", new Power {
				//Aura = new EnrageEffect(AuraType.SELF, Effects.Attack_N(3))
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_155e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_200e] Swapped Stats (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_200e", new Power {
				Enchant = Enchants.Enchants.SetAttackHealthScriptTag
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_203e] Rebuked (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Your spells cost (5) more this turn.
			// --------------------------------------------------------
			cards.Add("GIL_203e", new Power {
				Aura = new Aura(AuraType.OP_HAND, Effects.AddCost(5))
				{
					Condition = SelfCondition.IsSpell,
					RemoveTrigger = (TriggerType.TURN_END, SelfCondition.IsOpTurn)
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_507e] Bewitched (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("GIL_507e", new Power {
				Enchant = Enchants.Enchants.AddHealthScriptTag
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_510e] Misty (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_510e", new Power {
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_513e] Spooky Sacrifice (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GIL_513e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_513e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_515e] Engorged (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_515e", new Power {
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_526e] For the Dragonhoard! (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("GIL_526e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_526e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_534t] Reinforced (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_534t", new Power {
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_547e] Bloodfang (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_547e", new Power {
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(2))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_583e] Crunched (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_583e", new Power {
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_586e] Storm Hardened (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("GIL_586e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_586e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_596e] Sterling (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("GIL_596e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_596e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_601e] Bold Worm (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("GIL_601e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_601e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_607e] Viletoxin (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("GIL_607e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_607e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_614e1] Voodoo Doll Cursed (*) - COST:0 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroyed when Voodoo Doll is destroyed.
			// --------------------------------------------------------
			cards.Add("GIL_614e1", new Power {
				// TODO: must check the real log
				Enchant = new Enchant(GameTag.VOODOO_LINK, EffectOperator.SET, 1),
				
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_614e2] Voodoo Doll Cursing (*) - COST:0 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Destroy {0}.
			// --------------------------------------------------------
			cards.Add("GIL_614e2", new Power {
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.TARGET),
					new FuncPlayablesTask(p => new List<IPlayable>{p[0].Game.IdEntityDic[p[0][GameTag.TAG_SCRIPT_DATA_NUM_1]]}),
					new DestroyTask(EntityType.STACK))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_620e] Creepy Doll (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Dollmaster Dorian made a 1/1 copy.
			// --------------------------------------------------------
			cards.Add("GIL_620e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_620e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_623e] Grizzled (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Decreased Health.
			// --------------------------------------------------------
			cards.Add("GIL_623e", new Power {
				Enchant = new Enchant(Health.Effect(EffectOperator.SUB, 0))
				{
					UseScriptTag = true
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_624e] Stalking (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("GIL_624e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_624e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_640e] Rare Find! (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_640e", new Power {
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_650e] Hounded! (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Houndmaster Shaw grants <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("GIL_650e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_650e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_653e] Woodcutter (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2/+1.
			// --------------------------------------------------------
			cards.Add("GIL_653e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_653e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_655e] Grown (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("GIL_655e", new Power {
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_658e] Splintergrafted (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Splintergraft made this 10/10.
			// --------------------------------------------------------
			cards.Add("GIL_658e", new Power {
				Enchant = new Enchant(
					Effects.SetAttack(10),
					Effects.SetMaxHealth(10),
					Effects.SetCost(10))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_665e] Curse of Weakness (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: -2 Attack until next turn.
			// --------------------------------------------------------
			cards.Add("GIL_665e", new Power {
				Enchant = new Enchant(ATK.Effect(EffectOperator.SUB, 2))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_672e] Spooky (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Durability.
			// --------------------------------------------------------
			cards.Add("GIL_672e", new Power {
				Enchant = new Enchant(GameTag.DURABILITY, EffectOperator.ADD, 1)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_692e] Curse of Ur (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Your <b>Hero Power</b> costs (1).
			// --------------------------------------------------------
			cards.Add("GIL_692e", new Power {
				Enchant = new Enchant(Effects.SetCost(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_800e2] Badsong (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			cards.Add("GIL_800e2", new Power {
				Enchant = new Enchant(Effects.SetCost(0))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_828e] Dire Frenzy (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("GIL_828e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_828e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_837e] Moth Dust (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Doubled Health.
			// --------------------------------------------------------
			cards.Add("GIL_837e", new Power {
				Enchant = new Enchant(Health.Effect(EffectOperator.MUL, 2))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_902e] Sharpened (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GIL_902e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_902e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_905e] Corrosive Breath (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("GIL_905e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("GIL_905e")
				});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_201t] Pumpkin Peasant (*) - COST:3 [ATK:4/HP:2] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Lifesteal</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_201t", new Power {
				Trigger = Triggers.WorgenTransform("GIL_201", "GIL_200e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_202t] Gilnean Royal Guard (*) - COST:8 [ATK:8/HP:3] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>, <b>Rush</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_202t", new Power {
				Trigger = Triggers.WorgenTransform("GIL_202", "GIL_200e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_528t] Swift Messenger (*) - COST:4 [ATK:6/HP:2] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_528t", new Power {
				Trigger = Triggers.WorgenTransform("GIL_528", "GIL_200e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_529t] Spellshifter (*) - COST:2 [ATK:4/HP:1] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Spell Damage +1</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("GIL_529t", new Power {
				Trigger = Triggers.WorgenTransform("GIL_529", "GIL_200e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_616t] Splitting Sapling (*) - COST:3 [ATK:2/HP:2] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 1/1 Woodchips.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_616t", new Power {
				DeathrattleTask = new SummonTask("GIL_616t2",  2)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_616t2] Woodchip (*) - COST:1 [ATK:1/HP:1] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_616t2", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_682t] Muckling (*) - COST:1 [ATK:2/HP:1] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_682t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_683t] Drakeslayer (*) - COST:1 [ATK:2/HP:1] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("GIL_683t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_828t7] Vicious Scalehide (*) - COST:2 [ATK:1/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       <b>Rush</b>@<b>Lifesteal</b>, <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ICC_828t7", null);

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
			Paladin(cards);
			PaladinNonCollect(cards);
			Priest(cards);
			PriestNonCollect(cards);
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
