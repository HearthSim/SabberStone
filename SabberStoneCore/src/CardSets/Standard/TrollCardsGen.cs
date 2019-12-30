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

#if NOSPAN
using SabberStoneCore.Model.Zones;
#else
using System;
#endif
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;
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
using SabberStoneCore.Triggers;
using SabberStoneCore.src.Loader;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets.Standard
{
	public class TrollCardsGen
	{
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ HERO - HUNTER
			// [TRL_065] Zul'jin - COST:10 [ATK:0/HP:30]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Cast all spells
			//       you've played this game
			//       <i>(targets chosen randomly)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 50579
			// --------------------------------------------------------
			cards.Add("TRL_065", new CardDef(new Power
			{
				PowerTask = SpecificTask.Zuljin
			}));

		}

		private static void HeroPowers(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ HERO_POWER - HUNTER
			// [TRL_065h] Berserker Throw (*) - COST:2
			// - Set: troll,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_065h", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET)
			}));

		}

		private static void Druid(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [TRL_223] Spirit of the Raptor - COST:1 [ATK:0/HP:3]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       After your hero attacks and
			//       __kills a minion, draw a card.__
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_223", new CardDef(new Power
			{
				Trigger = TriggerLibrary.SpiritTrigger(TriggerBuilder.Type(TriggerType.AFTER_ATTACK)
					.SetTask(new DrawTask())
					.SetCondition(SelfCondition.IsDefenderDead)
					.SetSource(TriggerSource.HERO))
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRL_232] Ironhide Direhorn - COST:7 [ATK:7/HP:7]
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Summon a 5/5_Ironhide Runt.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_232", new CardDef(new Power
			{
				OverkillTask = new SummonTask("TRL_232t")
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRL_240] Savage Striker - COST:2 [ATK:2/HP:3]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal damage to an enemy minion equal to your hero's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE_AND_HERO_HAS_ATTACK = 0
			// --------------------------------------------------------
			cards.Add("TRL_240", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE_AND_HERO_HAS_ATTACK,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.HERO),
					new DamageNumberTask(EntityType.TARGET))
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRL_241] Gonk, the Raptor - COST:7 [ATK:4/HP:9]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: After your hero attacks and_kills a minion, it may_attack again.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TRL_241", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_ATTACK)
					.SetTask(ComplexTask.ExtraAttacksThisTurn(EntityType.HERO))
					.SetCondition(SelfCondition.IsDefenderDead)
					.SetSource(TriggerSource.HERO)
					.GetTrigger()
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRL_341] Treespeaker - COST:5 [ATK:4/HP:4]
			// - Fac: neutral, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform your Treants into 5/5 Ancients.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_341", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsTreant),
					new ChangeEntityTask("TRL_341t", EntityType.STACK))
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRL_343] Wardruid Loti - COST:3 [ATK:1/HP:2]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Choose One - </b>Transform into one of Loti's four dinosaur forms.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("TRL_343", new CardDef());

			// ------------------------------------------ SPELL - DRUID
			// [TRL_243] Pounce - COST:0
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Give your hero +2_Attack this turn.
			// --------------------------------------------------------
			cards.Add("TRL_243", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("TRL_243e", EntityType.HERO)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRL_244] Predatory Instincts - COST:4
			// - Fac: neutral, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Draw a Beast from your
			//       deck. Double its Health.
			// --------------------------------------------------------
			cards.Add("TRL_244", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsRace(Race.BEAST)),
					new RandomTask(1, EntityType.STACK),
					new DrawStackTask(),
					new AddEnchantmentTask("TRL_244e", EntityType.STACK))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRL_254] Mark of the Loa - COST:4
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One</b> -
			//       Give a minion +2/+4
			//       and <b>Taunt</b>; or Summon
			//       two 3/2 Raptors.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_254", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0}}));

			// ------------------------------------------ SPELL - DRUID
			// [TRL_255] Stampeding Roar - COST:6
			// - Fac: neutral, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon a random Beast from your hand and give it <b>Rush</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINION_OF_RACE_IN_HAND = 20
			// --------------------------------------------------------
			cards.Add("TRL_255", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1},{PlayReq.REQ_FRIENDLY_MINION_OF_RACE_IN_HAND,20}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsRace(Race.BEAST)),
						new RandomTask(1, EntityType.STACK),
					new SummonStackTask(true),
					new AddEnchantmentTask("TRL_255e", EntityType.STACK))
			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [TRL_254ae] Mark of the Loa (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +2/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("TRL_254ae", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_254ae")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [TRL_255e] Stampede! (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Has <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("TRL_255e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_255e")
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRL_232t] Ironhide Runt (*) - COST:5 [ATK:5/HP:5]
			// - Race: beast, Set: troll,
			// --------------------------------------------------------
			cards.Add("TRL_232t", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [TRL_254t] Raptor (*) - COST:2 [ATK:3/HP:2]
			// - Race: beast, Set: troll,
			// --------------------------------------------------------
			cards.Add("TRL_254t", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [TRL_341t] Ancient (*) - COST:5 [ATK:5/HP:5]
			// - Set: troll,
			// --------------------------------------------------------
			cards.Add("TRL_341t", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [TRL_343at1] Ankylodon (*) - COST:3 [ATK:1/HP:6]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_343at1", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [TRL_343at2] Wardruid Loti (*) - COST:3 [ATK:1/HP:6]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_343at2", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [TRL_343bt1] Sabertusk (*) - COST:3 [ATK:4/HP:2]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_343bt1", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [TRL_343bt2] Wardruid Loti (*) - COST:3 [ATK:4/HP:2]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_343bt2", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [TRL_343ct1] Pterrordax (*) - COST:3 [ATK:1/HP:4]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("TRL_343ct1", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [TRL_343ct2] Wardruid Loti (*) - COST:3 [ATK:1/HP:4]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			cards.Add("TRL_343ct2", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [TRL_343dt1] Ravasaur (*) - COST:3 [ATK:1/HP:2]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>, <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - STEALTH = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("TRL_343dt1", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [TRL_343dt2] Wardruid Loti (*) - COST:3 [ATK:1/HP:2]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>, <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("TRL_343dt2", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [TRL_343et1] Wardruid Loti (*) - COST:3 [ATK:4/HP:6]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>, <b>Rush</b>, <b>Poisonous</b>, <b>Stealth</b>, <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - STEALTH = 1
			// - SPELLPOWER = 1
			// - POISONOUS = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_343et1", new CardDef());

			// ------------------------------------------ SPELL - DRUID
			// [TRL_254a] Gonk's Resilience (*) - COST:0
			// - Fac: neutral, Set: troll,
			// --------------------------------------------------------
			// Text: Give a minion +2/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_254a", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("TRL_254ae", EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRL_254b] Raptor Pack (*) - COST:0
			// - Fac: neutral, Set: troll,
			// --------------------------------------------------------
			// Text: Summon two 3/2 Raptors.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("TRL_254b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("TRL_254b", 2)
			}));

		}

		private static void Hunter(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [TRL_348] Springpaw - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       <b>Battlecry:</b> Add a 1/1 Lynx
			//       with <b>Rush</b> to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_348", new CardDef(new Power
			{
				PowerTask = new AddCardTo("TRL_348t", EntityType.HAND)
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRL_349] Bloodscalp Strategist - COST:3 [ATK:2/HP:4]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a weapon equipped, <b>Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_349", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.IsWeaponEquiped,
					new DiscoverTask(DiscoverType.SPELL))
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRL_900] Halazzi, the Lynx - COST:5 [ATK:3/HP:2]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Fill your hand with 1/1 Lynxes that have_<b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_900", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new FuncNumberTask(p => p.Controller.HandZone.FreeSpace),
					new EnqueueNumberTask(new AddCardTo("TRL_348t", EntityType.HAND)))
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRL_901] Spirit of the Lynx - COST:3 [ATK:0/HP:3]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       Whenever you summon a
			//       Beast, give it +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_901", new CardDef(new Power
			{
				Trigger = TriggerLibrary.SpiritTrigger(TriggerBuilder.Type(TriggerType.SUMMON)
					.SetTask(new AddEnchantmentTask("TRL_901e", EntityType.TARGET))
					.SetCondition(SelfCondition.IsRace(Race.BEAST))
					.SetSource(TriggerSource.FRIENDLY)
					.GetTrigger())
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRL_119] The Beast Within - COST:1
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a friendly Beast +1/+1, then it attacks a random enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_TARGET_WITH_RACE = 20
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_119", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_TARGET_WITH_RACE,20},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("TRL_119e", EntityType.TARGET),
					new RandomTask(1, EntityType.OP_MINIONS),
					new AttackTask(EntityType.TARGET, EntityType.STACK))

			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRL_339] Master's Call - COST:3
			// - Fac: neutral, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a minion in your deck.
			//       If all 3 are Beasts,
			//       draw them all.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_339", new CardDef(new Power
			{
				PowerTask = SpecificTask.MastersCall
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRL_347] Baited Arrow - COST:5
			// - Fac: neutral, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage. <b>Overkill:</b> Summon a 5/5 Devilsaur. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_347", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(3, EntityType.TARGET, true),
				OverkillTask = new SummonTask("TRL_347t")
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRL_566] Revenge of the Wild - COST:2
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon your Beasts that died this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_MINION_OF_RACE_DIED_THIS_TURN = 20
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("TRL_566", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_MINION_OF_RACE_DIED_THIS_TURN,20},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.SummonAllFriendlyDiedThisTurn(SelfCondition.IsRace(Race.BEAST))
			}));
			// ---------------------------------------- WEAPON - HUNTER
			// [TRL_111] Headhunter's Hatchet - COST:2 [ATK:2/HP:0]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you
			//       control a Beast, gain
			//       +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_111", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.IsControllingRace(Race.BEAST),
					new AddEnchantmentTask("TRL_111e1", EntityType.SOURCE))
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [TRL_347t] Devilsaur (*) - COST:5 [ATK:5/HP:5]
			// - Race: beast, Set: troll,
			// --------------------------------------------------------
			cards.Add("TRL_347t", new CardDef());

			// ---------------------------------------- MINION - HUNTER
			// [TRL_348t] Lynx (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Fac: neutral, Set: troll,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_348t", new CardDef());

		}

		private static void Mage(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [TRL_311] Arcanosaur - COST:6 [ATK:3/HP:3]
			// - Race: elemental, Fac: neutral, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you played an_Elemental last turn, deal_3_damage_to_all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_311", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.ElementalPlayedLastTurn,
					new DamageTask(3, EntityType.ALLMINIONS_NOSOURCE))
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRL_315] Pyromaniac - COST:3 [ATK:3/HP:4]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever your Hero Power_kills a minion, draw a card.
			// --------------------------------------------------------
			cards.Add("TRL_315", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.INSPIRE)
					.SetTask(new DrawTask())
					.SetCondition(SelfCondition.IsDefenderDead)
					.GetTrigger()
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRL_316] Jan'alai, the Dragonhawk - COST:7 [ATK:4/HP:4]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your Hero Power
			//       dealt 8 damage this game,
			//       summon Ragnaros the
			//       Firelord.@ <i>({0} left!)</i>@ <i>(Ready!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - PLAYER_TAG_THRESHOLD_TAG_ID = 1025
			// - PLAYER_TAG_THRESHOLD_VALUE = 8
			// --------------------------------------------------------
			cards.Add("TRL_316", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.CheckThreshold(RelaSign.EQ),
					new SummonTask("TRL_316t"))

			}));

			// ------------------------------------------ MINION - MAGE
			// [TRL_318] Hex Lord Malacrass - COST:8 [ATK:5/HP:5]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: Add a copy of your opening hand to your hand <i>(except this card)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_318", new CardDef(new Power
			{
				// TODO [TRL_318] Hex Lord Malacrass && Test: Hex Lord Malacrass_TRL_318
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRL_319] Spirit of the Dragonhawk - COST:2 [ATK:0/HP:3]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       Your Hero Power also targets
			//        adjacent minions.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("TRL_319", new CardDef(new Power
			{
				// TODO [TRL_319] Spirit of the Dragonhawk
				InfoCardId = "TRL_319e",
				Trigger = TriggerLibrary.SpiritTrigger(
					TriggerBuilder.Type(TriggerType.TARGET)
						.SetTask(ComplexTask.Create(
							new IncludeAdjacentTask(EntityType.EVENT_TARGET),
							new EnqueuePendingTask(EntityType.STACK)))
						.SetCondition(SelfCondition.IsHeroPowerTargetingMinion)
						.SetSource(TriggerSource.FRIENDLY))
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRL_390] Daring Fire-Eater - COST:1 [ATK:1/HP:1]
			// - Fac: neutral, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your next Hero Power this turn deals 2_more damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_390", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("TRL_390e2", EntityType.HERO)
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRL_310] Elemental Evocation - COST:0
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: The next Elemental you_play this turn costs (2) less.
			// --------------------------------------------------------
			cards.Add("TRL_310", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("TRL_310e", EntityType.CONTROLLER)
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRL_313] Scorch - COST:4
			// - Fac: neutral, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Deal $4 damage to a
			//       minion. Costs (1) if you
			//       played an Elemental
			//       last turn. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_313", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DamageTask(4, EntityType.TARGET),
				Aura = new AdaptiveCostEffect(1, TriggerType.TURN_START, triggerCondition: SelfCondition.ElementalPlayedLastTurn)
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRL_317] Blast Wave - COST:5
			// - Fac: neutral, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to_all minions.
			//       <b>Overkill</b>: Add a random Mage spell to your hand. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_317", new CardDef(new Power
			{
				PowerTask = new DamageTask(2, EntityType.ALLMINIONS, true),
				OverkillTask = ComplexTask.AddRandomMageSpellToHand
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRL_400] Splitting Image - COST:3
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions is attacked, summon a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TRL_400", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.ATTACK)
					.SetSecretTasks(new SummonCopyTask(EntityType.EVENT_TARGET))
					.SetSource(TriggerSource.ENEMY)
					.SetCondition(SelfCondition.IsEventTargetIs(CardType.MINION))
					.GetTrigger()
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [TRL_310e] Elemental Evocation (*) - COST:0
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: The next Elemental you play this turn costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_310e", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HAND, Effects.ReduceCost(2))
				{
					Condition = SelfCondition.IsRace(Race.ELEMENTAL),
					RemoveTrigger = (TriggerType.PLAY_MINION, SelfCondition.IsRace(Race.ELEMENTAL))
				}
			}));

		}

		private static void Paladin(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [TRL_300] Shirvallah, the Tiger - COST:25 [ATK:7/HP:5]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>, <b>Rush</b>, <b>Lifesteal</b>
			//        Costs (1) less for each Mana
			//       you've spent on spells.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DIVINE_SHIELD = 1
			// - LIFESTEAL = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_300", new CardDef(new Power
			{
				Aura = new AdaptiveCostEffect(
					initialisationFunction: p =>
					{
						int sum = 0;
						for (int i = 0; i < p.Controller.PlayHistory.Count; i++)
							if (p.Controller.PlayHistory[i].SourceCard.Type == CardType.SPELL)
								sum += p.Game.IdEntityDic[p.Controller.PlayHistory[i].SourceId][
									GameTag.TAG_LAST_KNOWN_COST_IN_HAND];

						return -sum;
					},
					triggerValueFunction: p => -p[GameTag.TAG_LAST_KNOWN_COST_IN_HAND],
					trigger: TriggerType.CAST_SPELL,
					triggerSource: TriggerSource.FRIENDLY)
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRL_306] Immortal Prelate - COST:2 [ATK:1/HP:3]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle this into your deck. It keeps any enchantments.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("TRL_306", new CardDef(new Power
			{
				// TODO [TRL_306] Immortal Prelate && Test: Immortal Prelate_TRL_306
				DeathrattleTask = SpecificTask.ImmortalPrelate
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRL_308] High Priest Thekal - COST:3 [ATK:3/HP:4]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Convert all but 1_of your Hero's Health into Armor.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_308", new CardDef(new Power
			{
				PowerTask = new CustomTask((g, c, s, t, stack) =>
				{
					c.Hero.Armor += c.Hero.Health - 1;
					c.Hero.Damage = c.Hero.BaseHealth - 1;
				})
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRL_309] Spirit of the Tiger - COST:4 [ATK:0/HP:3]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       After you cast a spell,
			//       summon a Tiger with stats
			//       equal to its Cost.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_309", new CardDef(new Power
			{
				Trigger = TriggerLibrary.SpiritTrigger(TriggerBuilder.Type(TriggerType.AFTER_CAST)
					.SetTask(new CustomTask((g, c, s, t, stack) =>
					{
						if (c.BoardZone.IsFull) return;
						Card instance = Card.GetTigerCard(t[GameTag.TAG_LAST_KNOWN_COST_IN_HAND], g.History);
						Entity.FromCard(in c, in instance, zone: c.BoardZone, creator: in s);
					}))
					.SetSource(TriggerSource.FRIENDLY)
					.GetTrigger())
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRL_545] Zandalari Templar - COST:4 [ATK:4/HP:4]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you've restored
			//       10 Health this game, gain
			//       +4/+4 and <b>Taunt</b>.@ <i>({0} left!)</i>@ <i>(Ready!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - PLAYER_TAG_THRESHOLD_TAG_ID = 958
			// - PLAYER_TAG_THRESHOLD_VALUE = 10
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_545", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.CheckThreshold(RelaSign.GEQ),
					new AddEnchantmentTask("TRL_545e", EntityType.SOURCE))
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRL_302] Time Out! - COST:3
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Your hero is <b>Immune</b> until your next turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("TRL_302", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("TRL_302e", EntityType.HERO)
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRL_305] A New Challenger... - COST:7
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a 6-Cost minion. Summon it with <b>Taunt</b> and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_305", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.SIX_COST_SUMMON, ComplexTask.Create(
					ComplexTask.DivineShield(EntityType.TARGET),
					ComplexTask.Taunt(EntityType.TARGET)))
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRL_307] Flash of Light - COST:2
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #4 Health.
			//       Draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_307", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new HealTask(4, EntityType.TARGET),
					new DrawTask())
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [TRL_304] Farraki Battleaxe - COST:5 [ATK:3/HP:0]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Give a minion in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_304", new CardDef(new Power
			{
				OverkillTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "TRL_304e")
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [TRL_543] Bloodclaw - COST:1 [ATK:2/HP:0]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 5 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_543", new CardDef(new Power
			{
				PowerTask = new DamageTask(5, EntityType.HERO)
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [TRL_302e] Time Out! (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: <b>Immune</b> until your next turn.
			// --------------------------------------------------------
			cards.Add("TRL_302e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.Immune),
				Trigger = TriggerBuilder.Type(TriggerType.TURN_START)
					.SetTask(RemoveEnchantmentTask.Task)
					.GetTrigger()
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRL_309t] Tiger (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: troll,
			// --------------------------------------------------------
			cards.Add("TRL_309t", new CardDef());

		}

		private static void Priest(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [TRL_131] Sand Drudge - COST:3 [ATK:3/HP:3]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a 1/1 Zombie with <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_131", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.CAST_SPELL)
					.SetTask(new SummonTask("TRL_131t"))
					.GetTrigger()
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRL_259] Princess Talanji - COST:8 [ATK:7/HP:5]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon all minions from your hand that_didn't start in your_deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_259", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsTagValue(GameTag.ENTITY_ID, 68, RelaSign.GEQ), SelfCondition.IsMinion),
					new SummonStackTask(true))
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRL_260] Bwonsamdi, the Dead - COST:7 [ATK:7/HP:7]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw 1-Cost
			//       minions from your deck
			//       until your hand is full.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_260", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsCost(1), SelfCondition.IsMinion),
					new FuncPlayablesTask(stack =>
					{
						if (stack.Count == 0)
							return stack;
						Controller c = stack[0].Controller;
						int count = c.HandZone.FreeSpace;
						for (int i = 0; i < stack.Count && i < count; i++)
							Generic.Draw(c, stack[i]);
						return stack;
					}))
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRL_408] Grave Horror - COST:12 [ATK:7/HP:8]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       Costs (1) less for each spell
			//       you've cast this game.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_408", new CardDef(new Power
			{
				Aura = new AdaptiveCostEffect(
					initialisationFunction: p => -p.Controller.PlayHistory.Count(h => h.SourceCard.Type == CardType.SPELL),
					triggerValueFunction: p => -1,
					trigger: TriggerType.AFTER_CAST,
					triggerSource: TriggerSource.FRIENDLY)
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRL_501] Auchenai Phantasm - COST:2 [ATK:3/HP:2]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> This turn, your healing effects deal damage instead.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_501", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("TRL_501e", EntityType.CONTROLLER)
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRL_502] Spirit of the Dead - COST:1 [ATK:0/HP:3]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       After a friendly minion dies,
			//       shuffle a 1-Cost copy of it
			//       into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_502", new CardDef(new Power
			{
				Trigger = TriggerLibrary.SpiritTrigger(TriggerBuilder.Type(TriggerType.DEATH)
					.SetTask(ComplexTask.Create(
						new CopyTask(EntityType.TARGET, Zone.DECK, addToStack: true),
						new AddEnchantmentTask("TRL_502e", EntityType.STACK)))
					.SetSource(TriggerSource.FRIENDLY)
					.GetTrigger())
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRL_097] Seance - COST:2
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Choose a minion. Add_a copy of it to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_097", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new CopyTask(EntityType.TARGET, Zone.HAND)
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRL_128] Regenerate - COST:0
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #3 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_128", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new HealTask(3, EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRL_258] Mass Hysteria - COST:5
			// - Fac: neutral, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Force each minion to_attack another random minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_258", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				PowerTask = new CustomTask((g, c, s, t, stack) =>
				{
					Minion[] allMinions = (Minion[])IncludeTask.GetEntities(EntityType.ALLMINIONS,
						in c, s, t, null);

					if (allMinions.Length < 2)
						return;

					EventMetaData temp = g.CurrentEventData;

					if (allMinions.Length == 2)
					{
						Generic.AttackBlock(c, allMinions[0], allMinions[1], true, true);
						if (!allMinions[1].IsDead && !allMinions[0].IsDead)
							Generic.AttackBlock(c, allMinions[1], allMinions[0], true, true);
						g.DeathProcessingAndAuraUpdate();
						g.CurrentEventData = temp;
						return;
					}

					Util.DeepCloneableRandom rnd = g.Random;
					g.OnRandomHappened(true);
					allMinions.Shuffle(rnd);

					List<Minion> targets = new List<Minion>(allMinions);
					//targets.Shuffle(rnd);

					for (int i = 0; i < allMinions.Length; i++)
					{
						if (allMinions[i].IsDead) continue;

						Minion target = null;
						//int roll;
						//do
						//{
						//	roll = rnd.Next(allMinions.Length);
						//	target = allMinions[roll];
						//} while (roll == i || target.IsDead);

						targets.Shuffle(rnd);
						for (int j = targets.Count - 1; j >= 0; j--)
						{
							if (targets[j].IsDead)
							{
								targets.RemoveAt(j);
								continue;
							}

							target = targets[j];
							break;
						}

						if (target == null)
							break;

						Generic.AttackBlock(c, allMinions[i], target, true, true);
						c.NumOptionsPlayedThisTurn--;
					}
					g.DeathProcessingAndAuraUpdate();
					g.CurrentEventData = temp;
				})
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRL_500] Surrender to Madness - COST:3
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Destroy 3 of your Mana
			//       Crystals. Give all minions
			//       in your deck +2/+2.
			// --------------------------------------------------------
			cards.Add("TRL_500", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ManaCrystalEmptyTask(-3),
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new AddEnchantmentTask("TRL_500e", EntityType.STACK))

			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [TRL_500e] Absolutely Mad! (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("TRL_500e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_500e")
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [TRL_502e] Prayer to Bwonsamdi (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Bwonsamdi made this cost (1).
			// --------------------------------------------------------
			cards.Add("TRL_502e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetCost(1))
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRL_131t] Zombie (*) - COST:1 [ATK:1/HP:1]
			// - Set: troll,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_131t", new CardDef());

		}

		private static void Rogue(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [TRL_071] Bloodsail Howler - COST:2 [ATK:1/HP:1]
			// - Race: pirate, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       <b>Battlecry:</b> Gain +1/+1
			//       for each other Pirate
			//       you control.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_071", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS_NOSOURCE),
					new FilterStackTask(SelfCondition.IsRace(Race.PIRATE)),
					new CountTask(EntityType.STACK),
					new AddEnchantmentTask("TRL_071e", EntityType.SOURCE, true))
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRL_077] Gurubashi Hypemon - COST:7 [ATK:5/HP:7]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a 1/1 copy of a <b>Battlecry</b> minion. It costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_077", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.BATTLECRY, new AddEnchantmentTask("TRL_077e", EntityType.TARGET))
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRL_092] Spirit of the Shark - COST:4 [ATK:0/HP:3]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       Your minions' <b>Battlecries</b>
			//       __and <b>Combos</b> trigger twice._
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("TRL_092", new CardDef(new Power
			{
				Aura = new Aura(AuraType.CONTROLLER, "TRL_092e"),
				Trigger = TriggerLibrary.OneTurnStealth
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRL_126] Captain Hooktusk - COST:8 [ATK:6/HP:3]
			// - Race: pirate, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon 3 Pirates from your deck. Give them <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_126", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsRace(Race.PIRATE)),
					new RandomTask(3, EntityType.STACK),
					new SummonStackTask(true),
					new ApplyEffectTask(EntityType.STACK, Effects.Rush))
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRL_409] Gral, the Shark - COST:5 [ATK:2/HP:2]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Eat a minion in
			//       your deck and gain its stats.
			//       <b>Deathrattle:</b> Add it to
			//       your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_409", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new GetGameTagTask(GameTag.ATK, EntityType.STACK),
					new GetGameTagTask(GameTag.HEALTH, EntityType.STACK, numberIndex: 1),
					new MoveToSetaside(EntityType.STACK),
					new AddEnchantmentTask("TRL_409e", EntityType.SOURCE, true, true))
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRL_124] Raiding Party - COST:3
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw 2 Pirates from_your deck.
			//       <b>Combo:</b> And a weapon.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("TRL_124", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsRace(Race.PIRATE)),
					new RandomTask(2, EntityType.STACK),
					new DrawStackTask()),
				ComboTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsRace(Race.PIRATE)),
					new RandomTask(2, EntityType.STACK),
					new DrawStackTask(),
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsWeapon),
					new RandomTask(1, EntityType.STACK),
					new DrawStackTask())
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRL_127] Cannon Barrage - COST:6
			// - Fac: neutral, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Deal $3 damage to a
			//       random enemy. Repeat
			//       for each of your Pirates. @spelldmg
			// --------------------------------------------------------
			cards.Add("TRL_127", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 3, true),
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.PIRATE)),
					new CountTask(EntityType.STACK),
					new EnqueueNumberTask(ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 3, true)))
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRL_156] Stolen Steel - COST:2
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a weapon <i>(from another class)</i>.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_156", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.WEAPON_ANOTHERCLASS)
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRL_157] Walk the Plank - COST:4
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy an undamaged minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_UNDAMAGED_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_157", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_UNDAMAGED_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DestroyTask(EntityType.TARGET)
			}));

			// ----------------------------------------- WEAPON - ROGUE
			// [TRL_074] Serrated Tooth - COST:1 [ATK:1/HP:0]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give your minions <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_074", new CardDef(new Power
			{
				DeathrattleTask = new AddEnchantmentTask("TRL_074e", EntityType.MINIONS)
			}));

		}

		private static void RogueNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TRL_409e] Blood in the Water (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Destroyed {0} and gained its stats.
			// --------------------------------------------------------
			cards.Add("TRL_409e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag,
				DeathrattleTask = ComplexTask.Create(
					GetCapturedCardTask.Task,
					new AddStackTo(EntityType.HAND))
			}));

		}

		private static void Shaman(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [TRL_059] Bog Slosher - COST:3 [ATK:3/HP:3]
			// - Race: elemental, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return a friendly minion to your hand and give it +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_059", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ReturnHandTask(EntityType.TARGET),
					new AddEnchantmentTask("TRL_059e", EntityType.TARGET))
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRL_060] Spirit of the Frog - COST:3 [ATK:0/HP:3]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b> for 1 turn.
			//       Whenever you cast a spell,
			//       draw a spell from your deck
			//       that costs (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_060", new CardDef(new Power
			{
				Trigger = TriggerLibrary.SpiritTrigger(TriggerBuilder.Type(TriggerType.CAST_SPELL)
					.SetTask(new CustomTask((g, c, s, t, stack) =>
					{
						int cost = t[GameTag.TAG_LAST_KNOWN_COST_IN_HAND] + 1;
						ReadOnlySpan<IPlayable> deck = c.DeckZone.GetSpan();
						List<int> indices = new List<int>();
						for (int i = 0; i < deck.Length; i++)
							if (deck[i].Card.Type == CardType.SPELL && deck[i].Cost == cost)
								indices.Add(i);
						if (indices.Count == 0) return;
						if (indices.Count == 1)
						{
							Generic.Draw(c, deck[indices[0]]);
							return;
						}

						g.OnRandomHappened(true);
						Generic.Draw(c, deck[indices.Choose(g.Random)]);
					}))
					.SetSource(TriggerSource.FRIENDLY)
					.GetTrigger())
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRL_085] Zentimo - COST:3 [ATK:1/HP:3]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Whenever you target a
			//       minion with a spell, it also
			//       targets adjacent ones.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TRL_085", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.TARGET)
					.SetTask(ComplexTask.Create(
						new IncludeAdjacentTask(EntityType.EVENT_TARGET),
						new EnqueuePendingTask(EntityType.STACK)))
					.SetCondition(SelfCondition.IsSpellTargetingMinion)
					.SetSource(TriggerSource.FRIENDLY)
					.GetTrigger()
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRL_345] Krag'wa, the Frog - COST:6 [ATK:4/HP:6]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return all spells you played last turn to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_345", new CardDef(new Power
			{
				// TODO [TRL_345] Krag'wa, the Frog && Test: Krag'wa, the Frog_TRL_345
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRL_522] Wartbringer - COST:1 [ATK:2/HP:1]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you played 2_spells this turn, deal 2_damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_SPELLS_PLAYED_THIS_TURN = 2
			// --------------------------------------------------------
			cards.Add("TRL_522", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_SPELLS_PLAYED_THIS_TURN,2}}, new Power
			{
				// TODO [TRL_522] Wartbringer && Test: Wartbringer_TRL_522
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRL_012] Totemic Smash - COST:1
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage. <b>Overkill</b>: Summon a basic Totem. @spelldmg
			// --------------------------------------------------------
			// Entourage: CS2_052, CS2_050, NEW1_009, CS2_051
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_012", new CardDef(new[] {"CS2_052","CS2_050","NEW1_009","CS2_051"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET, true),
				OverkillTask = ComplexTask.SummonRandomBasicTotem
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRL_058] Haunting Visions - COST:3
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (3) less. <b>Discover</b> a spell.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_058", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("TRL_058e", EntityType.CONTROLLER),
					new DiscoverTask(DiscoverType.SPELL))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRL_082] Big Bad Voodoo - COST:2
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a friendly minion "<b>Deathrattle:</b> Summon a random minion that costs (1) more."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_082", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("TRL_082e", EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRL_351] Rain of Toads - COST:6
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Summon three 2/4 Toads with <b>Taunt</b>. <b>Overload:</b> (3)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 3
			// - OVERLOAD_OWED = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_351", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("TRL_351t", 3)
			}));

			// ---------------------------------------- WEAPON - SHAMAN
			// [TRL_352] Likkim - COST:2 [ATK:1/HP:0]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Has +2 Attack while you have <b>Overloaded</b> Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("TRL_352", new CardDef(new Power
			{
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.ADD,
					p => p.Controller.OverloadLocked > 0 || p.Controller.OverloadOwed > 0 ? 2 : 0)
			}));

		}

		private static void ShamanNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [TRL_059e] Sloshed (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("TRL_059e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_059e")
			}));

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [TRL_082e] Voodoo (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a minion that costs (1) more.
			// --------------------------------------------------------
			cards.Add("TRL_082e", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.COST, EntityType.SOURCE),
					new MathAddTask(1),
					new RandomMinionNumberTask(GameTag.COST),
					new SummonTask(SummonSide.DEATHRATTLE))
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRL_351t] Toad (*) - COST:3 [ATK:2/HP:4]
			// - Race: beast, Set: troll,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_351t", new CardDef());

		}

		private static void Warlock(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [TRL_247] Soulwarden - COST:6 [ATK:6/HP:6]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add 3 random cards you discarded this game to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_247", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(3, EntityType.DISCARDED),
					new CopyTask(EntityType.STACK, Zone.HAND))
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRL_251] Spirit of the Bat - COST:2 [ATK:0/HP:3]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Stealth</b> for 1 turn.
			//       After a friendly minion dies, give a minion in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRL_251", new CardDef(new Power
			{
				Trigger = TriggerLibrary.SpiritTrigger(TriggerBuilder.Type(TriggerType.DEATH)
					.SetTask(ComplexTask.BuffRandomMinion(EntityType.HAND, "TRL_251e"))
					.SetSource(TriggerSource.FRIENDLY)
					.GetTrigger())
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRL_252] High Priestess Jeklik - COST:4 [ATK:3/HP:4]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>, <b>Lifesteal</b>
			//       When you discard this,
			//       add 2 copies of it to
			//       your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - InvisibleDeathrattle = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("TRL_252", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.DISCARD)
					.SetTask(new AddCardTo("TRL_252", EntityType.HAND, 2))
					.SetSource(TriggerSource.SELF)
					.SetActivation(TriggerActivation.HAND)
					.GetTrigger()

			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRL_253] Hir'eek, the Bat - COST:8 [ATK:1/HP:1]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Fill your board with copies of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_253", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new FuncNumberTask(p => p.Controller.BoardZone.FreeSpace),
					new EnqueueNumberTask(new CopyTask(EntityType.SOURCE, Zone.PLAY)))
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRL_257] Blood Troll Sapper - COST:7 [ATK:5/HP:8]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: After a friendly minion dies, deal 2 damage to the enemy hero.
			// --------------------------------------------------------
			cards.Add("TRL_257", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.DEATH)
					.SetTask(new DamageTask(2, EntityType.OP_HERO))
					.SetSource(TriggerSource.FRIENDLY)
					.GetTrigger()
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRL_551] Reckless Diretroll - COST:3 [ATK:2/HP:6]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Discard your lowest Cost card.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// - DISCARD_CARDS = 1
			// --------------------------------------------------------
			cards.Add("TRL_551", new CardDef(new Power
			{
				PowerTask = ComplexTask.DiscardLowestCostCard
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRL_245] Shriek - COST:1
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Discard your lowest Cost card. Deal $2 damage to all minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - DISCARD_CARDS = 1
			// --------------------------------------------------------
			cards.Add("TRL_245", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					ComplexTask.DiscardLowestCostCard,
					new DamageTask(2, EntityType.ALLMINIONS, true))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRL_246] Void Contract - COST:8
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy half of each player's deck.
			// --------------------------------------------------------
			cards.Add("TRL_246", new CardDef(new Power
			{
				PowerTask = new CustomTask((g, c, s, t, stack) =>
				{
					DeckZone deck = c.DeckZone;
					SetasideZone setaside = c.SetasideZone;
					for (int i = (int)Math.Ceiling(deck.Count / 2.0) - 1; i >= 0; i--)
						setaside.Add(deck.Remove(i));

					deck = c.Opponent.DeckZone;
					setaside = c.Opponent.SetasideZone;
					for (int i = (int)Math.Ceiling(deck.Count / 2.0) - 1; i >= 0; i--)
						setaside.Add(deck.Remove(i));
				})
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRL_249] Grim Rally - COST:1
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a friendly minion. Give your minions +1/+1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRL_249", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.TARGET),
					new AddEnchantmentTask("TRL_249e", EntityType.ALLMINIONS))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRL_555] Demonbolt - COST:8
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a minion. Costs (1) less for each minion you control.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_555", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DestroyTask(EntityType.TARGET),
				Aura = new AdaptiveCostEffect(p => p.Controller.BoardZone.Count)
			}));

		}

		private static void Warrior(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [TRL_323] Emberscale Drake - COST:5 [ATK:5/HP:5]
			// - Race: dragon, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain 5 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_323", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, new ArmorTask(5)))
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRL_326] Smolderthorn Lancer - COST:3 [ATK:3/HP:2]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy a damaged enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// - REQ_DAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_326", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND,0},{PlayReq.REQ_DAMAGED_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, new DestroyTask(EntityType.TARGET)))
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRL_327] Spirit of the Rhino - COST:1 [ATK:0/HP:3]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Stealth</b> for 1 turn.
			//       Your <b>Rush</b> minions are <b>Immune</b> the turn they're summoned.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_327", new CardDef(new Power
			{
				Trigger = TriggerLibrary.SpiritTrigger(TriggerBuilder.Type(TriggerType.SUMMON)
					.SetTask(new AddEnchantmentTask("TRL_327e", EntityType.TARGET))
					.SetSource(TriggerSource.FRIENDLY)
					.SetCondition(SelfCondition.IsTagValue(GameTag.RUSH, 1))
					.GetTrigger())
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRL_328] War Master Voone - COST:4 [ATK:4/HP:3]
			// - Fac: neutral, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Copy all
			//       Dragons in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_328", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsRace(Race.DRAGON)),
					new CopyTask(EntityType.STACK, Zone.HAND))
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRL_329] Akali, the Rhino - COST:8 [ATK:5/HP:5]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill:</b> Draw a <b>Rush</b> minion from your deck. Give it +5/+5.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - RUSH = 1
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_329", new CardDef(new Power
			{
				OverkillTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.HasRush),
					new RandomTask(1, EntityType.STACK),
					new DrawStackTask(),
					new AddEnchantmentTask("TRL_329e", EntityType.STACK))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRL_321] Devastate - COST:1
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage to a damaged minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_DAMAGED_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_321", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_DAMAGED_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DamageTask(4, EntityType.TARGET, true)
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRL_324] Heavy Metal! - COST:6
			// - Fac: neutral, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Summon a random
			//       minion with Cost equal
			//       to your Armor <i>(up to 10).</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("TRL_324", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ARMOR, EntityType.HERO),
					new NumberConditionTask(11, RelaSign.GEQ),
					new FlagTask(true, new FuncNumberTask((IPlayable p) => 10)),
					new RandomMinionNumberTask(GameTag.COST),
					new SummonTask())
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRL_362] Dragon Roar - COST:2
			// - Fac: neutral, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Add 2 random Dragons to your hand.
			// --------------------------------------------------------
			cards.Add("TRL_362", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(2, ComplexTask.Create(
					new RandomCardTask(CardType.MINION, CardClass.INVALID, Race.DRAGON),
					new AddStackTo(EntityType.HAND)))
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [TRL_325] Sul'thraze - COST:6 [ATK:4/HP:0]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Overkill</b>: You may attack again.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_325", new CardDef(new Power
			{
				// TODO [TRL_325] Sul'thraze && Test: Sul'thraze_TRL_325
				OverkillTask = ComplexTask.ExtraAttacksThisTurn(EntityType.HERO)
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [TRL_360] Overlord's Whip - COST:3 [ATK:2/HP:0]
			// - Fac: neutral, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: After you play a minion, deal 1 damage to it.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			cards.Add("TRL_360", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_PLAY_MINION)
					.SetTask(new DamageTask(1, EntityType.TARGET))
			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [TRL_329e] Rhino Skin (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +5/+5.
			// --------------------------------------------------------
			cards.Add("TRL_329e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_329e")
			}));

		}

		private static void Neutral(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [TRL_010] Half-Time Scavenger - COST:4 [ATK:3/HP:5]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Overkill</b>: Gain 3 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_010", new CardDef(new Power
			{
				OverkillTask = new ArmorTask(3)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_015] Ticket Scalper - COST:4 [ATK:5/HP:3]
			// - Race: pirate, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Overkill</b>: Draw 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_015", new CardDef(new Power
			{
				OverkillTask = new DrawTask(2)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_020] Sightless Ranger - COST:5 [ATK:3/HP:4]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill</b>: Summon two 1/1_Bats.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_020", new CardDef(new Power
			{
				OverkillTask = new SummonTask("TRL_020t", 2, SummonSide.ALTERNATE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_057] Serpent Ward - COST:2 [ATK:0/HP:2]
			// - Race: totem, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn,
			//       deal 2 damage to the enemy hero.
			// --------------------------------------------------------
			cards.Add("TRL_057", new CardDef(new Power
			{
				Trigger = TriggerBuilder
					.Type(TriggerType.TURN_END)
					.SetTask(new DamageTask(2, EntityType.OP_HERO))
					.GetTrigger()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_096] Griftah - COST:4 [ATK:4/HP:5]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Discover</b> two
			//       cards. Give one to your
			//       opponent at random.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_096", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(choiceAction: ChoiceAction.STACK,
					afterDiscoverTask: new CustomTask((g, c, s, t, stack) =>
					{
						for (int i = stack.Playables.Count - 1; i >= 0; i--)
						{
							IPlayable p = stack.Playables[i];
							c.SetasideZone.Remove(p);
						}

						g.OnRandomHappened(true);
						int pick = g.Random.Next(2);
						IPlayable giveaway = stack.Playables[pick];
						giveaway.Controller = c.Opponent;
						giveaway[GameTag.CONTROLLER] = c.Opponent.PlayerId;
						Generic.AddHandPhase(c.Opponent, giveaway);
						Generic.AddHandPhase(c, stack.Playables[(pick + 1) % 2]);
					}),
					repeat: 2)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_151] Former Champ - COST:5 [ATK:1/HP:1]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 5/5_Hotshot.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_151", new CardDef(new Power
			{
				PowerTask = new SummonTask("TRL_151t")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_312] Spellzerker - COST:2 [ATK:2/HP:3]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Has <b>Spell Damage +2</b> while damaged.
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("TRL_312", new CardDef(new Power
			{
				Aura = new EnrageEffect(AuraType.SELF, "TRL_312e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_363] Saronite Taskmaster - COST:1 [ATK:2/HP:3]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 0/3 Free Agent with <b>Taunt</b> for_your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_363", new CardDef(new Power
			{
				DeathrattleTask = new SummonOpTask("TRL_363t")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_405] Untamed Beastmaster - COST:3 [ATK:3/HP:4]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you draw a Beast, give it +2/+2.
			// --------------------------------------------------------
			cards.Add("TRL_405", new CardDef(new Power
			{
				// TODO [TRL_405] Untamed Beastmaster && Test: Untamed Beastmaster_TRL_405
				InfoCardId = "TRL_405e",
				Trigger = TriggerBuilder
					.Type(TriggerType.DRAW)
					.SetTask(new AddEnchantmentTask("TRL_405e", EntityType.TARGET))
					.SetCondition(SelfCondition.IsRace(Race.BEAST))
					.GetTrigger()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_406] Dozing Marksman - COST:2 [ATK:0/HP:4]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: Has +4 Attack while damaged.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("TRL_406", new CardDef(new Power
			{
				Aura = new EnrageEffect(AuraType.SELF, "TRL_406e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_407] Waterboy - COST:2 [ATK:2/HP:1]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your next Hero Power this turn costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_407", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("TRL_407e", EntityType.CONTROLLER)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_503] Scarab Egg - COST:2 [ATK:0/HP:2]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon three 1/1 Scarabs.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_503", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("TRL_503t", 3)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_504] Booty Bay Bookie - COST:2 [ATK:3/HP:3]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your opponent a Coin.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_504", new CardDef(new Power
			{
				PowerTask = new AddCardTo("GAME_005", EntityType.OP_HAND)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_505] Helpless Hatchling - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Reduce the Cost of a Beast in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_505", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsRace(Race.BEAST)),
					new AddEnchantmentTask("TRL_505e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_506] Gurubashi Chicken - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Gain +5 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_506", new CardDef(new Power
			{
				OverkillTask = new AddEnchantmentTask("TRL_506e", EntityType.SOURCE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_507] Sharkfin Fan - COST:2 [ATK:2/HP:2]
			// - Race: pirate, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: After your hero attacks, summon a 1/1 Pirate.
			// --------------------------------------------------------
			cards.Add("TRL_507", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_ATTACK)
					.SetTask(new SummonTask("TRL_507t"))
					.SetSource(TriggerSource.HERO)
					.GetTrigger()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_508] Regeneratin' Thug - COST:4 [ATK:3/HP:5]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of your turn, restore #2 Health to this_minion.
			// --------------------------------------------------------
			cards.Add("TRL_508", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.TURN_START)
					.SetTask(new HealTask(2, EntityType.SOURCE))
					.GetTrigger()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_509] Banana Buffoon - COST:3 [ATK:2/HP:2]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add 2 Bananas to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_509", new CardDef(new Power
			{
				PowerTask = new AddCardTo("TRL_509t", EntityType.HAND, 2)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_512] Cheaty Anklebiter - COST:2 [ATK:2/HP:1]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       <b>Battlecry:</b> Deal 1 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("TRL_512", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				PowerTask = new DamageTask(1, EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_513] Mosh'ogg Enforcer - COST:8 [ATK:2/HP:14]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("TRL_513", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_514] Belligerent Gnome - COST:2 [ATK:1/HP:4]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> If your opponent
			//       has 2 or more minions,
			//       gain +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_514", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsOpBoardCount(2, RelaSign.GEQ)),
					new FlagTask(true, new AddEnchantmentTask("TRL_514e", EntityType.SOURCE)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_515] Rabble Bouncer - COST:7 [ATK:2/HP:7]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Costs (1) less for each enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_515", new CardDef(new Power
			{
				Aura = new AdaptiveCostEffect(p => p.Controller.Opponent.BoardZone.Count)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_516] Gurubashi Offering - COST:1 [ATK:0/HP:2]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy this and gain 8_Armor.
			// --------------------------------------------------------
			// GameTag:
			// - 886 = 1
			// --------------------------------------------------------
			cards.Add("TRL_516", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.TURN_START)
					.SetTask(ComplexTask.Create(
						new DestroyTask(EntityType.SOURCE),
						new ArmorTask(8)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_517] Arena Fanatic - COST:4 [ATK:2/HP:3]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all minions in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_517", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new AddEnchantmentTask("TRL_517e2", EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_520] Murloc Tastyfin - COST:4 [ATK:3/HP:2]
			// - Race: murloc, Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Draw 2 Murlocs
			//       from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_520", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsRace(Race.MURLOC)),
					new RandomTask(2, EntityType.STACK),
					new DrawStackTask())
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_521] Arena Patron - COST:5 [ATK:3/HP:3]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Summon another Arena Patron.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_521", new CardDef(new Power
			{
				OverkillTask = new SummonTask("TRL_521")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_523] Firetree Witchdoctor - COST:2 [ATK:2/HP:2]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you're holding
			//       a Dragon, <b>Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TRL_523", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, new DiscoverTask(DiscoverType.SPELL)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_524] Shieldbreaker - COST:2 [ATK:2/HP:1]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b> an enemy minion with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_MUST_TARGET_TAUNTER = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("TRL_524", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_MUST_TARGET_TAUNTER,0}}, new Power
			{
				PowerTask = new SilenceTask(EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_525] Arena Treasure Chest - COST:4 [ATK:0/HP:4]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_525", new CardDef(new Power
			{
				DeathrattleTask = new DrawTask(2)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_526] Dragonmaw Scorcher - COST:5 [ATK:3/HP:6]
			// - Race: dragon, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage to all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_526", new CardDef(new Power
			{
				PowerTask = new DamageTask(1, EntityType.ALLMINIONS_NOSOURCE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_527] Drakkari Trickster - COST:3 [ATK:3/HP:4]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Give each player a
			//       copy of a random card from
			//       their opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_527", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(1, EntityType.DECK),
					new CopyTask(EntityType.STACK, Zone.HAND, toOpponent: true),
					new RandomTask(1, EntityType.OP_DECK),
					new CopyTask(EntityType.STACK, Zone.HAND))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_528] Linecracker - COST:7 [ATK:5/HP:10]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Double this minion's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_528", new CardDef(new Power
			{
				OverkillTask = new AddEnchantmentTask("TRL_528e", EntityType.SOURCE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_530] Masked Contender - COST:3 [ATK:2/HP:4]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a_<b>Secret</b>, play a <b>Secret</b> from_your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TRL_530", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingSecret),
					new FlagTask(true, ComplexTask.PutSecretFromDeck))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_531] Rumbletusk Shaker - COST:4 [ATK:3/HP:2]
			// - Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 3/2 Rumbletusk Breaker.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_531", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("TRL_531t", SummonSide.DEATHRATTLE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_532] Mosh'Ogg Announcer - COST:5 [ATK:6/HP:5]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Enemies attacking this
			//       have a 50% chance to
			//       attack someone else.
			// --------------------------------------------------------
			cards.Add("TRL_532", new CardDef(new Power
			{
				// TODO [TRL_532] Mosh'Ogg Announcer && Test: Mosh'Ogg Announcer_TRL_532
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_533] Ice Cream Peddler - COST:4 [ATK:3/HP:5]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a_<b>Frozen</b> minion, gain 8_Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("TRL_533", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingFrozen),
					new FlagTask(true, new ArmorTask(8)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_535] Snapjaw Shellfighter - COST:5 [ATK:3/HP:8]
			// - Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Whenever an adjacent
			//       minion takes damage, this
			//       _minion takes it instead.
			// --------------------------------------------------------
			cards.Add("TRL_535", new CardDef(new Power
			{
				// TODO [TRL_535] Snapjaw Shellfighter && Test: Snapjaw Shellfighter_TRL_535
				//Trigger = TriggerBuilder.Type(TriggerType.PREDAMAGE)
				//	.SetTask(ComplexTask.Create(
				//		new GetEventNumberTask(),
				//		new DamageNumberTask(EntityType.SOURCE),
				//		new SetEventNumberTask(0)))
				//	.SetSource(TriggerSource.ADJACENT_TO_THE_OWNER)
				//	.GetTrigger()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_537] Da Undatakah - COST:8 [ATK:8/HP:5]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain the
			//       <b>Deathrattle</b> effects of
			//       3 friendly minions that
			//       died this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_537", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.GRAVEYARD),
					new FilterStackTask(SelfCondition.IsDeathrattleCard, SelfCondition.IsDead),
					new RandomTask(3, EntityType.STACK),
					new CustomTask((g, c, s, t, stack) =>
					{
						Card eCard = Cards.FromId("TRL_537e");
						IPlayable source = (IPlayable)s;

						for (int i = 0; i < stack.Playables.Count; i++)
							Generic.AddEnchantmentBlock(g, eCard, source, s, 0, 0, stack.Playables[i].Id);
					}))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_541] Hakkar, the Soulflayer - COST:10 [ATK:9/HP:6]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle a Corrupted Blood into each player's deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRL_541", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new AddCardTo("TRL_541t", EntityType.OP_DECK),
					new AddCardTo("TRL_541t", EntityType.DECK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_542] Oondasta - COST:9 [ATK:7/HP:7]
			// - Race: beast, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill:</b> Summon a Beast from your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - RUSH = 1
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRL_542", new CardDef(new Power
			{
				OverkillTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsRace(Race.BEAST)),
					new RandomTask(1, EntityType.STACK),
					new SummonStackTask(true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_546] Ornery Tortoise - COST:3 [ATK:3/HP:5]
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 5 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_546", new CardDef(new Power
			{
				PowerTask = new DamageTask(5, EntityType.HERO)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_550] Amani War Bear - COST:7 [ATK:5/HP:7]
			// - Race: beast, Set: troll, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRL_550", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_564] Mojomaster Zihi - COST:6 [ATK:5/HP:5]
			// - Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Set each player to 5 Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRL_564", new CardDef(new Power
			{
				PowerTask = new ManaCrystalSetTask(5)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_569] Crowd Roaster - COST:7 [ATK:7/HP:4]
			// - Race: dragon, Set: troll, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you're holding
			//       a Dragon, deal 7 damage
			//       to an enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// --------------------------------------------------------
			cards.Add("TRL_569", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND,0}}, new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.IsDragonInHand,
					new DamageTask(7, EntityType.TARGET))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_570] Soup Vendor - COST:2 [ATK:1/HP:4]
			// - Set: troll, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you restore 3 or more Health to your hero, draw a card.
			// --------------------------------------------------------
			cards.Add("TRL_570", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.HEAL)
					.SetTask(new DrawTask())
					.SetSource(TriggerSource.HERO)
					.SetCondition(
						SelfCondition.IsCurrentEventNumber(3, RelaSign.GEQ) +
						SelfCondition.IsEventSourceFriendly)
					.GetTrigger()
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_058e] Visions (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_058e", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HAND, Effects.ReduceCost(3))
				{
					RemoveTrigger = (TriggerType.CAST_SPELL, null)
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_071e] Bloody Sails (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("TRL_071e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_074e] Carnassial (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("TRL_074e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_074e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_077e] Hype! (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Gurubashi Hypemon made this 1/1.
			// --------------------------------------------------------
			cards.Add("TRL_077e", new CardDef(new Power
			{
				Enchant = new Enchant(
					Effects.SetAttack(1),
					Effects.SetMaxHealth(1),
					Effects.SetCost(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_092e] Power of the Shark (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Your minions' <b>Battlecries</b>
			//       __and <b>Combos</b> trigger twice._
			// --------------------------------------------------------
			cards.Add("TRL_092e", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.EXTRA_MINION_BATTLECRIES_BASE, EffectOperator.SET, 1)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_096e] Guess the Card! (*) - COST:4 [ATK:4/HP:5]
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Guess the card your opponent chose to get a copy.
			// --------------------------------------------------------
			cards.Add("TRL_096e", new CardDef(new Power
			{
				// TODO [TRL_096e] Guess the Card! && Test: Guess the Card!_TRL_096e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_096e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_111e1] Headhunter's Hatchet (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Increased Durability.
			// --------------------------------------------------------
			cards.Add("TRL_111e1", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.DURABILITY, EffectOperator.ADD, 1)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_119e] The Beast Within (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("TRL_119e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_119e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_243e] Pounce (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_243e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_243e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_244e] Predatory Instincts (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Doubled Health.
			// --------------------------------------------------------
			cards.Add("TRL_244e", new CardDef(new Power
			{
				Enchant = new Enchant(Health.Effect(EffectOperator.MUL, 2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_249e] Grim Rally (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("TRL_249e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_249e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_251e] Hir'eek's Offering (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Increased stats from Spirit of the Bat.
			// --------------------------------------------------------
			cards.Add("TRL_251e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.AttackHealth_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_304e] Battle Ready (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +2/+2 from Farraki Battleaxe.
			// --------------------------------------------------------
			cards.Add("TRL_304e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_304e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_312e] Power of Gurubashi (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: <b>Spell Damage +2</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("TRL_312e", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.SPELLPOWER, EffectOperator.ADD, 2)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_319e] Power of the Dragonhawk (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Your Hero Power also hits adjacent minions.
			// --------------------------------------------------------
			cards.Add("TRL_319e", new CardDef(new Power
			{
				// TODO [TRL_319e] Power of the Dragonhawk && Test: Power of the Dragonhawk_TRL_319e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_319e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_327e] Protected by Spirit of the Rhino (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_327e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_327e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_390e2] Flameweaving (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Your next Hero Power deals 2 more damage.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_390e2", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.HEROPOWER_DAMAGE, EffectOperator.ADD, 2)
				{
					IsOneTurnEffect = true
				},
				Trigger = TriggerBuilder
					.Type(TriggerType.INSPIRE)
					.SetTask(RemoveEnchantmentTask.Task)
					.SetRemoveAfterTriggered()
					.GetTrigger()
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_405e] Warpaint (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("TRL_405e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_405e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_406e] Wrong Side of Da Bed (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +4 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("TRL_406e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_406e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_407e] High Quality H2O (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Your Hero Power costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_407e", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HEROPOWER, Effects.SetCost(0))
				{
					RemoveTrigger = (TriggerType.INSPIRE, null)
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_501e] Dark Soul (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Your healing effects are dealing damage.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TRL_501e", new CardDef(new Power
			{
				Aura = new Aura(AuraType.CONTROLLER, new Effect(GameTag.HEALING_DOES_DAMAGE, EffectOperator.SET, 1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_505e] Avenger (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("TRL_505e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.ReduceCost(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_506e] Ready to Strike (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +5 Attack.
			// --------------------------------------------------------
			cards.Add("TRL_506e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_506e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_509te] Bananas (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Has +1/+1.
			// --------------------------------------------------------
			cards.Add("TRL_509te", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_509te")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_514e] Belligerent (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("TRL_514e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_514e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_517e2] WHOOOOO! (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("TRL_517e2", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_517e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_528e] Crazed (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Doubled Attack.
			// --------------------------------------------------------
			cards.Add("TRL_528e", new CardDef(new Power
			{
				Enchant = new Enchant(ATK.Effect(EffectOperator.MUL, 2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_537e] Undatakah Deathrattles (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			cards.Add("TRL_537e", new CardDef(new Power
			{
				DeathrattleTask = ActivateCapturedDeathrattleTask.Task
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_545e] Rejuvenated (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +4/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("TRL_545e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_545e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRL_901e] Blessing of Halazzi (*) - COST:0
			// - Set: troll,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("TRL_901e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRL_901e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_020t] Bat (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: troll,
			// --------------------------------------------------------
			cards.Add("TRL_020t", new CardDef(new Power
			{
				// TODO [TRL_020t] Bat && Test: Bat_TRL_020t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_151t] Hotshot (*) - COST:5 [ATK:5/HP:5]
			// - Set: troll,
			// --------------------------------------------------------
			cards.Add("TRL_151t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_316t] Ragnaros the Firelord (*) - COST:8 [ATK:8/HP:8]
			// - Race: elemental, Fac: neutral, Set: troll, Rarity: legendary
			// --------------------------------------------------------
			// Text: Can't attack. At the end of your turn, deal 8 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("TRL_316t", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 8)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_363t] Free Agent (*) - COST:1 [ATK:0/HP:3]
			// - Set: troll,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRL_363t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_503t] Scarab (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: troll,
			// --------------------------------------------------------
			cards.Add("TRL_503t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_507t] Swabbie (*) - COST:1 [ATK:1/HP:1]
			// - Race: pirate, Set: troll,
			// --------------------------------------------------------
			cards.Add("TRL_507t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [TRL_531t] Rumbletusk Breaker (*) - COST:2 [ATK:3/HP:2]
			// - Set: troll,
			// --------------------------------------------------------
			cards.Add("TRL_531t", new CardDef());

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRL_509t] Bananas (*) - COST:1
			// - Set: troll,
			// --------------------------------------------------------
			// Text: Give a minion +1/+1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRL_509t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("TRL_509te", EntityType.TARGET)
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRL_541t] Corrupted Blood (*) - COST:1
			// - Set: troll,
			// --------------------------------------------------------
			// Text: <b>Casts When Drawn</b>
			//       Take 3 damage. After you draw, shuffle two copies of this into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			// RefTag:
			// - CASTSWHENDRAWN = 1
			// --------------------------------------------------------
			cards.Add("TRL_541t", new CardDef(new Power
			{
				TopdeckTask = ComplexTask.Create(
					new DamageTask(3, EntityType.HERO),
					new DrawTask(),
					new CopyTask(EntityType.SOURCE, Zone.DECK, 2))
			}));

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
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
			PriestNonCollect(cards);
			Rogue(cards);
			RogueNonCollect(cards);
			Shaman(cards);
			ShamanNonCollect(cards);
			Warlock(cards);
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
