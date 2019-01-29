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
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets.Standard
{
	public class UngoroCardsGen
	{
		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ------------------------------------ HERO_POWER - HUNTER
			// [UNG_917t1] Dinomancy (*) - COST:2 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a Beast +2/+2.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_TARGET_WITH_RACE = 20
			// --------------------------------------------------------
			cards.Add("UNG_917t1", new Power {
				PowerTask = new AddEnchantmentTask("UNG_917e", EntityType.TARGET)
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [UNG_934t2] DIE, INSECT! (*) - COST:2 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $8 damage to a random enemy. @spelldmg
			// --------------------------------------------------------
			cards.Add("UNG_934t2", new Power {
				PowerTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 8)
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [UNG_078] Tortollan Forager - COST:2 [ATK:2/HP:2] 
			// - Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random miterrornion with 5 or more Attack to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_078", new Power {
				PowerTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.ATK, 5, 1, RelaSign.GEQ),
					new AddStackTo(EntityType.HAND))
			});

			// ----------------------------------------- MINION - DRUID
			// [UNG_086] Giant Anaconda - COST:7 [ATK:5/HP:3] 
			// - Race: beast, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a minion from your hand with 5 or more Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_086", new Power {
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsMinion, SelfCondition.IsTagValue(GameTag.ATK, 5, RelaSign.GEQ)),
					new RandomTask(1, EntityType.STACK),
					new RemoveFromHand(EntityType.STACK),
					new SummonTask()),
			});

			// ----------------------------------------- MINION - DRUID
			// [UNG_100] Verdant Longneck - COST:5 [ATK:5/HP:4] 
			// - Race: beast, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Adapt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_100", new Power {
				PowerTask = new AdaptTask(EntityType.SOURCE)
			});

			// ----------------------------------------- MINION - DRUID
			// [UNG_101] Shellshifter - COST:4 [ATK:3/HP:3] 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Choose One - </b>Transform
			//       into a 5/3 with <b>Stealth</b>;
			//       or a 3/5 with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("UNG_101", new Power {
				// CHOOSE_ONE, Choose Both option
				PowerTask = new TransformTask("UNG_101t3", EntityType.SOURCE)
			});

			// ----------------------------------------- MINION - DRUID
			// [UNG_109] Elder Longneck - COST:3 [ATK:5/HP:1] 
			// - Race: beast, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a minion with 5 or more Attack, <b>Adapt</b>.
			// --------------------------------------------------------
			// Entourage: UNG_999t10, UNG_999t2, UNG_999t3, UNG_999t4, UNG_999t5, UNG_999t6, UNG_999t7, UNG_999t8, UNG_999t13, UNG_999t14
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_109", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.Is5PlusAtkInHand),
					new FlagTask(true, new AdaptTask(EntityType.SOURCE)))
			});

			// ----------------------------------------- MINION - DRUID
			// [UNG_852] Tyrantus - COST:10 [ATK:12/HP:12] 
			// - Race: beast, Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("UNG_852", null);

			// ------------------------------------------ SPELL - DRUID
			// [UNG_103] Evolving Spores - COST:4 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Adapt</b> your minions.
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_103", new Power {
				PowerTask = new AdaptTask(EntityType.MINIONS)
			});

			// ------------------------------------------ SPELL - DRUID
			// [UNG_108] Earthen Scales - COST:1 
			// - Fac: neutral, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a friendly minion +1/+1, then gain Armor equal to its Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_108", new Power {
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("UNG_108e", EntityType.TARGET),
					new GetGameTagTask(GameTag.ATK, EntityType.TARGET),
					new ArmorTask())
			});

			// ------------------------------------------ SPELL - DRUID
			// [UNG_111] Living Mana - COST:5 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: Transform your Mana Crystals into 2/2 minions. Recover the mana when they die.
			// --------------------------------------------------------
			cards.Add("UNG_111", new Power {
				PowerTask = SpecificTask.LivingMana
			});

			// ------------------------------------------ SPELL - DRUID
			// [UNG_116] Jungle Giants - COST:1 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Summon
			//       5 minions with
			//       5 or more Attack.
			//       <b>Reward:</b> Barnabus.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 5
			// - 676 = 1
			// --------------------------------------------------------
			cards.Add("UNG_116", new Power {
				Trigger = new Trigger(TriggerType.AFTER_SUMMON)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsTagValue(GameTag.ATK, 5, RelaSign.GEQ),
					SingleTask = new QuestProgressTask("UNG_116t")
				}
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [UNG_108e] It's All Scaley... (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("UNG_108e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_108e")
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [UNG_116te] Romper Stompers (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			cards.Add("UNG_116te", new Power {
				Enchant = new Enchant(Effects.SetCost(0))
			});

			// ----------------------------------------- MINION - DRUID
			// [UNG_101t] Shellshifter (*) - COST:4 [ATK:5/HP:3] 
			// - Race: beast, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("UNG_101t", null);

			// ----------------------------------------- MINION - DRUID
			// [UNG_101t2] Shellshifter (*) - COST:4 [ATK:3/HP:5] 
			// - Race: beast, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_101t2", null);

			// ----------------------------------------- MINION - DRUID
			// [UNG_101t3] Shellshifter (*) - COST:4 [ATK:5/HP:5] 
			// - Race: beast, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("UNG_101t3", null);

			// ----------------------------------------- MINION - DRUID
			// [UNG_111t1] Mana Treant (*) - COST:2 [ATK:2/HP:2] 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Gain an empty Mana Crystal.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_111t1", new Power {
				DeathrattleTask = new ManaCrystalEmptyTask(1)
			});

			// ----------------------------------------- MINION - DRUID
			// [UNG_116t] Barnabus the Stomper (*) - COST:5 [ATK:8/HP:8] 
			// - Race: beast, Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reduce the
			//       Cost of minions in your deck to (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_116t", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new AddEnchantmentTask("UNG_116te", EntityType.STACK))
			});

			// ------------------------------------------ SPELL - DRUID
			// [UNG_101a] Raptor Form (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +2 Attack and <b>Stealth</b>
			// --------------------------------------------------------
			cards.Add("UNG_101a", new Power {
				PowerTask = new TransformTask("UNG_101t", EntityType.SOURCE)
			});

			// ------------------------------------------ SPELL - DRUID
			// [UNG_101b] Direhorn Form (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("UNG_101b", new Power {
				PowerTask = new TransformTask("UNG_101t2", EntityType.SOURCE)
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [UNG_800] Terrorscale Stalker - COST:3 [ATK:3/HP:3] 
			// - Fac: neutral, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Trigger a friendly minion's <b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_800", new Power {
				PowerTask = new ActivateDeathrattleTask(EntityType.TARGET)
			});

			// ---------------------------------------- MINION - HUNTER
			// [UNG_912] Jeweled Macaw - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Beast to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_912", new Power {
				PowerTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.CARDRACE, (int)Race.BEAST),
					new AddStackTo(EntityType.HAND))
			});

			// ---------------------------------------- MINION - HUNTER
			// [UNG_913] Tol'vir Warden - COST:5 [ATK:3/HP:5] 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw two 1-Cost minions from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_913", new Power {
				PowerTask = ComplexTask.DrawFromDeck(2, SelfCondition.IsTagValue(GameTag.COST, 1), SelfCondition.IsMinion)
			});

			// ---------------------------------------- MINION - HUNTER
			// [UNG_914] Raptor Hatchling - COST:1 [ATK:2/HP:1] 
			// - Race: beast, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle a 4/3 Raptor into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_914", new Power {
				DeathrattleTask = new AddCardTo("UNG_914t1", EntityType.DECK)
			});

			// ---------------------------------------- MINION - HUNTER
			// [UNG_915] Crackling Razormaw - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Adapt</b> a friendly_Beast.
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
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_915", new Power {
				PowerTask = new AdaptTask(EntityType.TARGET)
			});

			// ---------------------------------------- MINION - HUNTER
			// [UNG_919] Swamp King Dred - COST:7 [ATK:9/HP:9] 
			// - Race: beast, Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: After your opponent plays a minion, attack_it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("UNG_919", new Power {
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.SOURCE),
						new IncludeTask(EntityType.EVENT_SOURCE, addFlag: true),
						new FuncPlayablesTask(plist =>
						{
							if (plist.Count < 2) return null;
							var source = (ICharacter)plist[0];
							var target = (ICharacter)plist[1];
							if (target.Card.Untouchable)
								return null;
							EventMetaData temp = source.Game.CurrentEventData;
							Generic.AttackBlock.Invoke(source.Controller, source, target, true);
							source.Game.CurrentEventData = temp;
							source.Controller.NumOptionsPlayedThisTurn--;
							return null;
						}))
				}
			});

			// ----------------------------------------- SPELL - HUNTER
			// [UNG_910] Grievous Bite - COST:2 
			// - Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion and $1 damage to adjacent ones. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_910", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS),
					new FilterStackTask(EntityType.TARGET, RelaCondition.IsSideBySide),
					new DamageTask(2, EntityType.TARGET, true),
					new DamageTask(1, EntityType.STACK, true))
			});

			// ----------------------------------------- SPELL - HUNTER
			// [UNG_916] Stampede - COST:1 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: Each time you play a Beast this turn, add_a_random Beast to_your hand.
			// --------------------------------------------------------
			cards.Add("UNG_916", new Power {
				PowerTask = new AddEnchantmentTask("UNG_916e", EntityType.CONTROLLER),
			});

			// ----------------------------------------- SPELL - HUNTER
			// [UNG_917] Dinomancy - COST:2 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: Your Hero Power becomes 'Give a Beast +2/+2.'
			// --------------------------------------------------------
			cards.Add("UNG_917", new Power {
				PowerTask = new ReplaceHeroPower(Cards.FromId("UNG_917t1"))
			});

			// ----------------------------------------- SPELL - HUNTER
			// [UNG_920] The Marsh Queen - COST:1 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Play seven
			//       1-Cost minions.
			//       <b>Reward:</b> Queen Carnassa.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 7
			// - 676 = 1
			// --------------------------------------------------------
			cards.Add("UNG_920", new Power {
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = new SelfCondition(p => p.Cost == 1),
					SingleTask = new QuestProgressTask("UNG_920t1")
				}
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [UNG_916e] Stampeding (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("UNG_916e", new Power {
				Trigger = new Trigger(TriggerType.PLAY_MINION)
				{
					Condition = SelfCondition.IsRace(Race.BEAST),
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.TARGET, SelfCondition.IsHandFull),
						new FlagTask(false, ComplexTask.Create(
						new RandomCardTask(CardType.MINION, CardClass.INVALID, Race.BEAST),
						new AddStackTo(EntityType.HAND))))
				}
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [UNG_917e] Well Fed (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("UNG_917e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_917e")
			});

			// ---------------------------------------- MINION - HUNTER
			// [UNG_914t1] Raptor Patriarch (*) - COST:1 [ATK:4/HP:3] 
			// - Race: beast, Set: ungoro, 
			// --------------------------------------------------------
			cards.Add("UNG_914t1", null);

			// ---------------------------------------- MINION - HUNTER
			// [UNG_920t1] Queen Carnassa (*) - COST:5 [ATK:8/HP:8] 
			// - Race: beast, Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle 15 Raptors into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_920t1", new Power {
				PowerTask = new AddCardTo("UNG_076t1", EntityType.DECK, 15)
			});

			// ---------------------------------------- MINION - HUNTER
			// [UNG_920t2] Carnassa's Brood (*) - COST:1 [ATK:3/HP:2] 
			// - Race: beast, Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_920t2", new Power {
				PowerTask = new DrawTask()
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [UNG_020] Arcanologist - COST:2 [ATK:2/HP:3] 
			// - Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a <b>Secret</b> from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("UNG_020", new Power {
				PowerTask = ComplexTask.DrawFromDeck(1, SelfCondition.IsSecret)
			});

			// ------------------------------------------ MINION - MAGE
			// [UNG_021] Steam Surger - COST:4 [ATK:5/HP:4] 
			// - Race: elemental, Fac: neutral, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you played
			//       an Elemental last turn,
			//       add a 'Flame Geyser'
			//       to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_021", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
					new FlagTask(true, new AddCardTo("UNG_018", EntityType.HAND))),
			});

			// ------------------------------------------ MINION - MAGE
			// [UNG_027] Pyros - COST:2 [ATK:2/HP:2] 
			// - Race: elemental, Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return this to_your hand as a 6/6 that costs (6).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_027", new Power {
				DeathrattleTask = ComplexTask.Create(
					new MoveToSetaside(EntityType.SOURCE),
					new AddCardTo("UNG_027t2", EntityType.HAND))
			});

			// ------------------------------------------ MINION - MAGE
			// [UNG_846] Shimmering Tempest - COST:2 [ATK:2/HP:1] 
			// - Race: elemental, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Mage spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_846", new Power {
				DeathrattleTask = ComplexTask.Create(
					new RandomCardTask(CardType.SPELL, CardClass.MAGE),
					new AddStackTo(EntityType.HAND))
			});

			// ------------------------------------------- SPELL - MAGE
			// [UNG_018] Flame Geyser - COST:2 
			// - Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage.
			//       Add a 1/2 Elemental to_your hand. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("UNG_018", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(2, EntityType.TARGET, true),
					new AddCardTo("UNG_809t1", EntityType.HAND))
			});

			// ------------------------------------------- SPELL - MAGE
			// [UNG_024] Mana Bind - COST:3 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent casts a spell, add a copy to your hand that costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("UNG_024", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsHandFull),
						new FlagTask(false, ComplexTask.Secret(
						new CopyTask(EntityType.TARGET, Zone.HAND, addToStack: true),
						new AddAuraEffect(Effects.SetCost(0), EntityType.STACK))))
				}
			});

			// ------------------------------------------- SPELL - MAGE
			// [UNG_028] Open the Waygate - COST:1 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Cast 6 spells that
			//       didn't start in your deck.
			//       <b>Reward:</b> Time Warp.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 6
			// - 676 = 1
			// --------------------------------------------------------
			cards.Add("UNG_028", new Power {
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsNotStartInDeck,
					SingleTask = new QuestProgressTask("UNG_028t")
				}
			});

			// ------------------------------------------- SPELL - MAGE
			// [UNG_941] Primordial Glyph - COST:2 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a spell. Reduce its Cost by (2).
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_941", new Power {
				PowerTask = new DiscoverTask(DiscoverType.SPELL, "UNG_941e")
			});

			// ------------------------------------------- SPELL - MAGE
			// [UNG_948] Molten Reflection - COST:4 
			// - Fac: neutral, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: Choose a friendly minion. Summon a copy of it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_948", new Power {
				PowerTask = new SummonCopyTask(EntityType.TARGET)
			});

			// ------------------------------------------- SPELL - MAGE
			// [UNG_955] Meteor - COST:6 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $15 damage to a minion and $3 damage to adjacent ones. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_955", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS),
					new FilterStackTask(EntityType.TARGET, RelaCondition.IsSideBySide),
					new DamageTask(15, EntityType.TARGET, true),
					new DamageTask(3, EntityType.STACK, true))
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [UNG_028e] Insightful (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Take an extra turn.
			// --------------------------------------------------------
			cards.Add("UNG_028e", new Power {
				// TODO [UNG_028e] Insightful && Test: Insightful_UNG_028e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- ENCHANTMENT - MAGE
			// [UNG_941e] Primal Magic (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Cost reduced.
			// --------------------------------------------------------
			cards.Add("UNG_941e", new Power {
				Enchant = new Enchant(Effects.ReduceCost(2))
			});

			// ------------------------------------------ MINION - MAGE
			// [UNG_027t2] Pyros (*) - COST:6 [ATK:6/HP:6] 
			// - Race: elemental, Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return this to_your hand as a 10/10 that costs (10).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_027t2", new Power {
				DeathrattleTask = ComplexTask.Create(
					new MoveToSetaside(EntityType.SOURCE),
					new AddCardTo("UNG_027t4", EntityType.HAND))
			});

			// ------------------------------------------ MINION - MAGE
			// [UNG_027t4] Pyros (*) - COST:10 [ATK:10/HP:10] 
			// - Race: elemental, Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("UNG_027t4", null);

			// ------------------------------------------- SPELL - MAGE
			// [UNG_028t] Time Warp (*) - COST:5 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Take an extra turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("UNG_028t", new Power {
				PowerTask = new ExtraTurnEffectTask()
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [UNG_011] Hydrologist - COST:2 [ATK:2/HP:2] 
			// - Race: murloc, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a <b>Secret</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_011", new Power {
				PowerTask = new DiscoverTask(DiscoverType.SECRET)
			});

			// --------------------------------------- MINION - PALADIN
			// [UNG_015] Sunkeeper Tarim - COST:6 [ATK:3/HP:7] 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Set all other minions' Attack and Health to 3.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_015", new Power {
				InfoCardId = "UNG_015e",
				PowerTask = new AddEnchantmentTask("UNG_015e", EntityType.ALLMINIONS_NOSOURCE)
			});

			// --------------------------------------- MINION - PALADIN
			// [UNG_953] Primalfin Champion - COST:2 [ATK:1/HP:2] 
			// - Race: murloc, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return any spells you cast on this minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 537 = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("UNG_953", new Power {
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY_SPELL_CASTED_ON_THE_OWNER,
					SingleTask = ComplexTask.Create(
						new GetGameTagTask(GameTag.ENTITY_ID, EntityType.TARGET),
						new AddEnchantmentTask("UNG_953e", EntityType.SOURCE, true, true))
				}
			});

			// --------------------------------------- MINION - PALADIN
			// [UNG_962] Lightfused Stegodon - COST:4 [ATK:3/HP:4] 
			// - Race: beast, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Adapt</b> your Silver_Hand Recruits.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_962", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS_NOSOURCE),
					new FilterStackTask(SelfCondition.IsSilverHandRecruit),
					new ConditionTask(EntityType.STACK, SelfCondition.IsNotDead),
					new FlagTask(true, new AdaptTask(EntityType.STACK)))
			});

			// ---------------------------------------- SPELL - PALADIN
			// [UNG_004] Dinosize - COST:8 
			// - Fac: neutral, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: Set a minion's Attack and Health to 10.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_004", new Power {
				PowerTask = new AddEnchantmentTask("UNG_004e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - PALADIN
			// [UNG_952] Spikeridged Steed - COST:6 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion +2/+6 and <b>Taunt</b>. When it dies, summon a Stegodon.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_952", new Power {
				PowerTask = new AddEnchantmentTask("UNG_952e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - PALADIN
			// [UNG_954] The Last Kaleidosaur - COST:1 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Quest:</b> Cast 6 spells
			//       on your minions.
			//       <b>Reward:</b> Galvadon.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 6
			// - 676 = 1
			// --------------------------------------------------------
			cards.Add("UNG_954", new Power {
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY_SPELL_CASTED_ON_OWN_MINIONS,
					SingleTask = new QuestProgressTask("UNG_954t1")
				}
			});

			// ---------------------------------------- SPELL - PALADIN
			// [UNG_960] Lost in the Jungle - COST:1 
			// - Fac: alliance, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: Summon two 1/1 Silver Hand Recruits.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("UNG_960", new Power {
				PowerTask = new SummonTask("CS2_101t", 2)
			});

			// ---------------------------------------- SPELL - PALADIN
			// [UNG_961] Adaptation - COST:1 
			// - Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Adapt</b> a friendly minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_961", new Power {
				PowerTask = new AdaptTask(EntityType.TARGET)
			});

			// --------------------------------------- WEAPON - PALADIN
			// [UNG_950] Vinecleaver - COST:7 [ATK:4/HP:0] 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]After your hero attacks,
			//       summon two 1/1 Silver
			//       Hand Recruits.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("UNG_950", new Power {
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = new SummonTask("CS2_101t", 2)
				}
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [UNG_004e] RAAAAR! (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Stats changed to 10/10.
			// --------------------------------------------------------
			cards.Add("UNG_004e", new Power {
				Enchant = new Enchant(Effects.SetAttackHealth(10))
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [UNG_015e] Watched (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Stats changed to 3/3.
			// --------------------------------------------------------
			cards.Add("UNG_015e", new Power {
				Enchant = new Enchant(Effects.SetAttackHealth(3))
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [UNG_952e] On a Stegodon (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +2/+6 and <b>Taunt</b>.
			//       <b>Deathrattle:</b> Summon a Stegodon.
			// --------------------------------------------------------
			cards.Add("UNG_952e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_952e"),
				DeathrattleTask = new SummonTask("UNG_810", SummonSide.DEATHRATTLE)
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [UNG_953e] Inspired (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Storing spell.
			// --------------------------------------------------------
			cards.Add("UNG_953e", new Power {
				DeathrattleTask = ComplexTask.Create(
					GetCapturedCardTask.Task,
					new AddStackTo(EntityType.HAND))
			});

			// --------------------------------------- MINION - PALADIN
			// [UNG_954t1] Galvadon (*) - COST:5 [ATK:5/HP:5] 
			// - Race: beast, Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Adapt</b> 5 times.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_954t1", new Power {
				PowerTask = new EnqueueTask(5, new AdaptTask(EntityType.SOURCE))
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [UNG_022] Mirage Caller - COST:3 [ATK:2/HP:3] 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Summon a 1/1 copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_022", new Power {
				PowerTask = ComplexTask.Create(
					new CopyTask(EntityType.TARGET, Zone.PLAY, addToStack: true),
					new AddEnchantmentTask("UNG_022e", EntityType.STACK))

			});

			// ---------------------------------------- MINION - PRIEST
			// [UNG_032] Crystalline Oracle - COST:1 [ATK:1/HP:1] 
			// - Race: elemental, Fac: horde, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Copy a card
			//       from your opponent's deck
			//       _and add it to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_032", new Power {
				DeathrattleTask = ComplexTask.RandomCardCopyToHandFrom(EntityType.OP_DECK)
			});

			// ---------------------------------------- MINION - PRIEST
			// [UNG_034] Radiant Elemental - COST:2 [ATK:2/HP:3] 
			// - Race: elemental, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: Your spells cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("UNG_034", new Power {
				Aura = new Aura(AuraType.HAND, Effects.ReduceCost(1))
				{
					Condition = SelfCondition.IsSpell
				}
			});

			// ---------------------------------------- MINION - PRIEST
			// [UNG_035] Curious Glimmerroot - COST:3 [ATK:3/HP:3] 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Look at 3 cards.
			//       Guess which one started
			//       in your opponent's deck
			//       to get a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_035", new Power {
				PowerTask = SpecificTask.CuriousGlimmerroot
			});

			// ---------------------------------------- MINION - PRIEST
			// [UNG_037] Tortollan Shellraiser - COST:4 [ATK:2/HP:6] 
			// - Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Deathrattle:</b> Give a random
			//       _friendly minion +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_037", new Power {
				DeathrattleTask = ComplexTask.BuffRandomMinion(EntityType.MINIONS, "UNG_037e")
			});

			// ---------------------------------------- MINION - PRIEST
			// [UNG_963] Lyra the Sunshard - COST:5 [ATK:3/HP:5] 
			// - Race: elemental, Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, add a random Priest spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("UNG_963", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = ComplexTask.Create(
						new RandomCardTask(CardType.SPELL, CardClass.PRIEST),
						new AddStackTo(EntityType.HAND))
				}
			});

			// ----------------------------------------- SPELL - PRIEST
			// [UNG_029] Shadow Visions - COST:2 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a copy of a spell in your deck.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_029", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasSpellInDeck),
					new FlagTask(true, new DiscoverTask(DiscoverType.OWN_SPELL)))
			});

			// ----------------------------------------- SPELL - PRIEST
			// [UNG_030] Binding Heal - COST:1 
			// - Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #5 Health to a minion and your hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_030", new Power {
				PowerTask = ComplexTask.Create(
					new HealTask(5, EntityType.TARGET),
					new HealTask(5, EntityType.HERO))
			});

			// ----------------------------------------- SPELL - PRIEST
			// [UNG_854] Free From Amber - COST:8 
			// - Fac: neutral, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Discover</b> a minion that costs (8) or more. Summon it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_854", new Power {
				PowerTask = new DiscoverTask(DiscoverType.COST_8_MORE_SUMMON)
			});

			// ----------------------------------------- SPELL - PRIEST
			// [UNG_940] Awaken the Makers - COST:1 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Quest:</b> Summon
			//       7 <b>Deathrattle</b> minions.<b>
			//       Reward:</b> Amara, Warden of Hope.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 7
			// - 676 = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_940", new Power {
				Trigger = new Trigger(TriggerType.AFTER_SUMMON)
				{
					Condition = SelfCondition.IsDeathrattleMinion,
					SingleTask = new QuestProgressTask("UNG_940t8")
				}
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [UNG_022e] Mirage (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("UNG_022e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_022e")
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [UNG_037e] Shellshield (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("UNG_037e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_037e")
			});

			// ---------------------------------------- MINION - PRIEST
			// [UNG_940t8] Amara, Warden of Hope (*) - COST:5 [ATK:8/HP:8] 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Set your
			//       hero's Health to 40.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_940t8", new Power {
				PowerTask = ComplexTask.Create(
					new SetGameTagTask(GameTag.HEALTH, 40, EntityType.HERO),
					new SetGameTagTask(GameTag.DAMAGE, 0, EntityType.HERO))
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [UNG_058] Razorpetal Lasher - COST:2 [ATK:2/HP:2] 
			// - Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Add a
			//       Razorpetal to your hand
			//       that deals 1 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_058", new Power {
				PowerTask = new AddCardTo("UNG_057t1", EntityType.HAND)
			});

			// ----------------------------------------- MINION - ROGUE
			// [UNG_063] Biteweed - COST:2 [ATK:1/HP:1] 
			// - Fac: neutral, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Gain +1/+1 for each other card you've played this turn.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("UNG_063", new Power {
				InfoCardId = "UNG_063e",
				ComboTask = ComplexTask.Create(
					new GetGameTagControllerTask(GameTag.NUM_CARDS_PLAYED_THIS_TURN),
					new MathSubstractionTask(1),
					new AddEnchantmentTask("UNG_063e", EntityType.SOURCE, true))
			});

			// ----------------------------------------- MINION - ROGUE
			// [UNG_064] Vilespine Slayer - COST:5 [ATK:3/HP:4] 
			// - Fac: neutral, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Destroy a minion.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_FOR_COMBO = 0
			// --------------------------------------------------------
			cards.Add("UNG_064", new Power {
				ComboTask = new DestroyTask(EntityType.TARGET)
			});

			// ----------------------------------------- MINION - ROGUE
			// [UNG_065] Sherazin, Corpse Flower - COST:4 [ATK:5/HP:3] 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Go dormant. Play 4 cards in a turn to revive this minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_065", new Power {
				DeathrattleTask = new SummonTask("UNG_065t", SummonSide.DEATHRATTLE)
			});

			// ------------------------------------------ SPELL - ROGUE
			// [UNG_057] Razorpetal Volley - COST:2 
			// - Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: Add two Razorpetals to_your hand that deal_1 damage.
			// --------------------------------------------------------
			cards.Add("UNG_057", new Power {
				PowerTask = new AddCardTo("UNG_057t1", EntityType.HAND, 2)
			});

			// ------------------------------------------ SPELL - ROGUE
			// [UNG_060] Mimic Pod - COST:3 
			// - Fac: neutral, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw a card, then add a copy of it to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_060", new Power {
				PowerTask = ComplexTask.Create(
					new DrawTask(true),
					new CopyTask(EntityType.STACK, Zone.HAND))
			});

			// ------------------------------------------ SPELL - ROGUE
			// [UNG_067] The Caverns Below - COST:1 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Play five minions
			//       with the same name.
			//       <b>Reward:</b> Crystal Core.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 5
			// - 676 = 1
			// --------------------------------------------------------
			cards.Add("UNG_067", new Power {
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new FuncNumberTask(p =>
					{
						Card justPlayed = p.Game.CurrentEventData.EventSource.Card;
						List<PlayHistoryEntry> history = p.Controller.PlayHistory;
						int count = 0;
						for (int i = history.FindIndex(x => x.SourceCard.AssetId == 41222) + 1; i < history.Count; i++)
							if (history[i].SourceCard.Name == justPlayed.Name)
								count++;

						if (count <= p[GameTag.QUEST_PROGRESS]) return 0;

						p[GameTag.QUEST_CONTRIBUTOR] = justPlayed.AssetId;
						p.Game.TaskQueue.Enqueue(new QuestProgressTask("UNG_067t1"), p.Controller, p, null);

						return 0;
					})
				}
			});

			// ------------------------------------------ SPELL - ROGUE
			// [UNG_823] Envenom Weapon - COST:3 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your weapon <b>Poisonous</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("UNG_823", new Power {
				PowerTask = new AddEnchantmentTask("UNG_823e", EntityType.WEAPON)
			});

			// ------------------------------------------ SPELL - ROGUE
			// [UNG_856] Hallucination - COST:1 
			// - Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a card from your opponent's class.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_856", new Power {
				PowerTask = new DiscoverTask(DiscoverType.OP_HERO)
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [UNG_061] Obsidian Shard - COST:4 [ATK:3/HP:0] 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Costs (1) less for each
			//       card you've played from
			//       another class.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3a
			// --------------------------------------------------------
			cards.Add("UNG_061", new Power {
				// TODO: possible performance hit
				Aura = new AdaptiveCostEffect(p =>
				{
					List<PlayHistoryEntry> history = p.Controller.PlayHistory;
					CardClass heroClass = p.Controller.HeroClass;
					int count = 0;
					for (int i = 0; i < history.Count; i++)
						if (history[i].SourceCard.Class != heroClass)
							count++;
					return count;
				})
				//{
				//	UpdateTrigger = (TriggerType.AFTER_PLAY_CARD, TriggerSource.FRIENDLY, null)
				//}
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [UNG_063e] Sprout (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("UNG_063e", new Power {
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			});

			// ----------------------------------------- MINION - ROGUE
			// [UNG_065t] Sherazin, Seed (*) - COST:11 [ATK:0/HP:1] 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: When you play 4 cards in a_turn, revive this minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_065t", new Power {
				Trigger = new MultiTrigger(
					new Trigger(TriggerType.AFTER_PLAY_CARD)
					{
						TriggerSource = TriggerSource.FRIENDLY,
						SingleTask = ComplexTask.Create(
							new ConditionTask(EntityType.SOURCE, SelfCondition.IsTagValue(GameTag.TAG_SCRIPT_DATA_NUM_1, 2, RelaSign.LEQ)),
							new FlagTask(true, ComplexTask.Create(
								new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),           // and also CUSTOM_KEYWORD_EFFECT and ATK
								new MathAddTask(1),
								new SetGameTagNumberTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE))),
							new FlagTask(false, ComplexTask.Create(
								new SetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, 4, EntityType.SOURCE),
								new TransformTask("UNG_065", EntityType.SOURCE))))
					},
					new Trigger(TriggerType.TURN_END)
					{
						SingleTask = new SetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, 0, EntityType.SOURCE)
					})
			});

			// ------------------------------------------ SPELL - ROGUE
			// [UNG_057t1] Razorpetal (*) - COST:1 
			// - Fac: neutral, Set: ungoro, 
			// --------------------------------------------------------
			// Text: Deal $1 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("UNG_057t1", new Power {
				PowerTask = new DamageTask(1, EntityType.TARGET, true)
			});

			// ------------------------------------------ SPELL - ROGUE
			// [UNG_067t1] Crystal Core (*) - COST:5 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: For the rest of the game, your minions are 4/4.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - RITUAL = 1
			// --------------------------------------------------------
			cards.Add("UNG_067t1", new Power {
				PowerTask = new AddEnchantmentTask("UNG_067t1e", EntityType.CONTROLLER)
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [UNG_019] Air Elemental - COST:1 [ATK:2/HP:1] 
			// - Race: elemental, Fac: horde, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("UNG_019", null);

			// ---------------------------------------- MINION - SHAMAN
			// [UNG_201] Primalfin Totem - COST:2 [ATK:0/HP:3] 
			// - Race: totem, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a 1/1 Murloc.
			// --------------------------------------------------------
			cards.Add("UNG_201", new Power {
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new SummonTask("UNG_201t", SummonSide.RIGHT)
				}
			});

			// ---------------------------------------- MINION - SHAMAN
			// [UNG_202] Fire Plume Harbinger - COST:2 [ATK:1/HP:1]
			// - Race: elemental, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reduce the Cost of Elementals in your hand_by (1).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_202", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsRace(Race.ELEMENTAL)),
					new AddEnchantmentTask("UNG_202e", EntityType.STACK))
			});

			// ---------------------------------------- MINION - SHAMAN
			// [UNG_208] Stone Sentinel - COST:7 [ATK:4/HP:4] 
			// - Race: elemental, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you played an Elemental last turn, summon two 2/3 Elementals with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_208", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
					new FlagTask(true, ComplexTask.Create(
						new SummonTask("UNG_809t1", SummonSide.LEFT),
						new SummonTask("UNG_809t1", SummonSide.RIGHT)))),
			});

			// ---------------------------------------- MINION - SHAMAN
			// [UNG_211] Kalimos, Primal Lord - COST:8 [ATK:7/HP:7] 
			// - Race: elemental, Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you played an
			//       Elemental last turn, cast an
			//       Elemental Invocation.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_211", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
					new FlagTask(true, new DiscoverTask(DiscoverType.ELEMENTAL_INVOCATION, numberOfChoices: 4)))
			});

			// ---------------------------------------- MINION - SHAMAN
			// [UNG_938] Hot Spring Guardian - COST:3 [ATK:2/HP:4] 
			// - Race: elemental, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Restore 3_Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("UNG_938", new Power {
				PowerTask = new HealTask(3, EntityType.TARGET)
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [UNG_025] Volcano - COST:5 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $15 damage randomly split among all_minions.
			//       <b>Overload:</b> (2) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("UNG_025", new Power {
				// TODO: Velen
				PowerTask = new EnqueueTask(15, ComplexTask.DamageRandomTargets(1, EntityType.ALL, 1), true)
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [UNG_817] Tidal Surge - COST:4 
			// - Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage to a minion. Restore #4 Health to your hero. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("UNG_817", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(4, EntityType.TARGET, true),
					new HealTask(4, EntityType.HERO))
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [UNG_942] Unite the Murlocs - COST:1 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Summon
			//       10 Murlocs.
			//       <b>Reward:</b> Megafin.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 10
			// - 676 = 1
			// --------------------------------------------------------
			cards.Add("UNG_942", new Power {
				Trigger = new Trigger(TriggerType.AFTER_SUMMON)
				{
					Condition = SelfCondition.IsRace(Race.MURLOC),
					SingleTask = new QuestProgressTask("UNG_942t")
				}
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [UNG_956] Spirit Echo - COST:3 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: Give your minions "<b>Deathrattle:</b> Return _this to your hand."
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_956", new Power {
				PowerTask = new AddEnchantmentTask("UNG_956e", EntityType.MINIONS)
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [UNG_956e] Echoed Spirit (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return to your hand.
			// --------------------------------------------------------
			cards.Add("UNG_956e", new Power {
				DeathrattleTask = new ReturnHandTask(EntityType.SOURCE)
			});

			// ---------------------------------------- MINION - SHAMAN
			// [UNG_208t] Rock Elemental (*) - COST:2 [ATK:2/HP:3] 
			// - Race: elemental, Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_208t", null);

			// ---------------------------------------- MINION - SHAMAN
			// [UNG_211aa] Stone Elemental (*) - COST:1 [ATK:1/HP:1] 
			// - Race: elemental, Fac: neutral, Set: ungoro, 
			// --------------------------------------------------------
			cards.Add("UNG_211aa", null);

			// ---------------------------------------- MINION - SHAMAN
			// [UNG_942t] Megafin (*) - COST:5 [ATK:8/HP:8] 
			// - Race: murloc, Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Fill your hand with random Murlocs.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_942t", new Power {
				PowerTask = new EnqueueTask(10, ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsHandFull),
					new FlagTask(false, ComplexTask.Create(
						new RandomMinionTask(GameTag.CARDRACE, (int)Race.MURLOC),
						new AddStackTo(EntityType.HAND)))))
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [UNG_211a] Invocation of Earth (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Fill your board with 1/1 Elementals.
			// --------------------------------------------------------
			cards.Add("UNG_211a", new Power {
				PowerTask = new SummonTask("UNG_211aa", 7)
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [UNG_211b] Invocation of Water (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Restore 12 Health to your hero.
			// --------------------------------------------------------
			cards.Add("UNG_211b", new Power {
				PowerTask = new HealTask(12, EntityType.HERO)
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [UNG_211c] Invocation of Fire (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Deal 6 damage to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("UNG_211c", new Power {
				PowerTask = new DamageTask(6, EntityType.OP_HERO),
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [UNG_211d] Invocation of Air (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Deal 3 damage to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("UNG_211d", new Power {
				PowerTask = new DamageTask(3, EntityType.OP_MINIONS)
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [UNG_047] Ravenous Pterrordax - COST:4 [ATK:4/HP:4] 
			// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a friendly minion to <b>Adapt</b>_twice.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_047", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.TARGET, SelfCondition.IsMinion),
					new FlagTask(true, new DestroyTask(EntityType.TARGET, true)),
					new EnqueueTask(1, ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsNotDead, SelfCondition.IsNotSilenced),
						new FlagTask(true, new EnqueueTask(2, new AdaptTask(EntityType.SOURCE))))))
			});

			// --------------------------------------- MINION - WARLOCK
			// [UNG_049] Tar Lurker - COST:5 [ATK:1/HP:7] 
			// - Race: elemental, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Has +3 Attack during your opponent's turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_049", new Power {
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.ADD, p => p.Controller == p.Game.CurrentOpponent ? 3 : 0)
			});

			// --------------------------------------- MINION - WARLOCK
			// [UNG_830] Cruel Dinomancer - COST:6 [ATK:5/HP:5] 
			// - Fac: neutral, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Summon a
			//       random minion you
			//       discarded this game.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_830", new Power {
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.SOURCE),
					new FuncPlayablesTask(p =>
					{
						Controller c = p[0].Controller;
						if (c.DiscardedEntities.Count == 0)
							return new List<IPlayable>(0);
						var minions = new List<IPlayable>(c.DiscardedEntities.Count);
						c.DiscardedEntities.ForEach(q =>
						{
							if (c.Game.IdEntityDic[q] is Minion m)
								minions.Add(m);
						});
						return minions.Count > 0
							? new List<IPlayable>{Entity.FromCard(c, Util.Choose(list: minions).Card)}
							: new List<IPlayable>(0);
					}),
					new SummonTask())
			});

			// --------------------------------------- MINION - WARLOCK
			// [UNG_833] Lakkari Felhound - COST:4 [ATK:3/HP:8] 
			// - Race: demon, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Discard two random cards.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// - 890 = 2
			// --------------------------------------------------------
			cards.Add("UNG_833", new Power {
				PowerTask = ComplexTask.DiscardRandomCard(2)
			});

			// --------------------------------------- MINION - WARLOCK
			// [UNG_835] Chittering Tunneler - COST:3 [ATK:3/HP:3] 
			// - Race: beast, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a spell. Deal damage to your hero equal to its Cost.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_835", new Power {
				PowerTask = new DiscoverTask(DiscoverType.SPELL,
					ComplexTask.Create(
						new GetGameTagTask(GameTag.COST, EntityType.TARGET),
						new DamageNumberTask(EntityType.HERO)))
			});

			// --------------------------------------- MINION - WARLOCK
			// [UNG_836] Clutchmother Zavas - COST:2 [ATK:2/HP:2] 
			// - Race: beast, Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you discard this, give it +2/+2 and return it to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("UNG_836", new Power {
				// TODO [UNG_836] Clutchmother Zavas
				Trigger = new Trigger(TriggerType.DISCARD)
				{
					TriggerSource = TriggerSource.SELF,
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.SOURCE),
						new FuncPlayablesTask(list =>
						{
							var p = (Minion) list[0];
							var newEntity = (Minion) Entity.FromCard(p.Controller, p.Card);
							p[GameTag.TAG_SCRIPT_DATA_ENT_1] = newEntity.Id;
							newEntity[GameTag.TAG_SCRIPT_DATA_ENT_1] = newEntity.Id;
							Generic.AddEnchantmentBlock.Invoke(p.Controller, Cards.FromId("UNG_836e"), newEntity, newEntity, 0, 0, false);
							//newEntity[GameTag.ATK] = p[GameTag.ATK] + 2;
							//newEntity[GameTag.HEALTH] = p[GameTag.HEALTH] + 2;
							newEntity.AttackDamage = p.AttackDamage + 2;
							newEntity.BaseHealth = p.BaseHealth + 2;

							// separated trigger actually
							newEntity[GameTag.REVEALED] = 1;
							newEntity.Controller.HandZone.Add(newEntity);
							newEntity[GameTag.REVEALED] = 0;
							return null;
						}))
				}
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [UNG_829] Lakkari Sacrifice - COST:1 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Discard 6 cards.
			//       <b>Reward:</b> Nether Portal.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 6
			// - 676 = 1
			// --------------------------------------------------------
			cards.Add("UNG_829", new Power {
				Trigger = new Trigger(TriggerType.DISCARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new QuestProgressTask("UNG_829t1")
				}
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [UNG_831] Corrupting Mist - COST:2 
			// - Fac: neutral, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: Corrupt every minion. Destroy them at the start of your next turn.
			// --------------------------------------------------------
			cards.Add("UNG_831", new Power {
				PowerTask = new AddEnchantmentTask("UNG_831e", EntityType.ALLMINIONS)
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [UNG_832] Bloodbloom - COST:2 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs Health instead of Mana.
			// --------------------------------------------------------
			// Entourage: UNG_999t10, UNG_999t2, UNG_999t3, UNG_999t4, UNG_999t5, UNG_999t6, UNG_999t7, UNG_999t8, UNG_999t13, UNG_999t14
			// --------------------------------------------------------
			cards.Add("UNG_832", new Power {
				PowerTask = new AddEnchantmentTask("UNG_832e", EntityType.CONTROLLER)
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [UNG_834] Feeding Time - COST:5 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $3 damage to a minion. Summon three 1/1 Pterrordaxes. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_834", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(3, EntityType.TARGET, true),
					new SummonTask("UNG_834t1", 3))
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [UNG_831e] Corrupting Mist (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: At the start of the corrupting player's turn, destroy this minion.
			// --------------------------------------------------------
			cards.Add("UNG_831e", new Power {
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = new DestroyTask(EntityType.TARGET)
				}
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [UNG_836e] Remembrance (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +2/+2 each time this is discarded.
			// --------------------------------------------------------
			cards.Add("UNG_836e", new Power {
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(0))
			});

			// --------------------------------------- MINION - WARLOCK
			// [UNG_829t2] Nether Portal (*) - COST:11 [ATK:0/HP:1] 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: At the end of your turn, summon two 3/2 Imps.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_829t2", new Power {
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new SummonTask("UNG_829t3", SummonSide.LEFT),
						new SummonTask("UNG_829t3", SummonSide.RIGHT))
				}
			});

			// --------------------------------------- MINION - WARLOCK
			// [UNG_829t3] Nether Imp (*) - COST:2 [ATK:3/HP:2] 
			// - Race: demon, Set: ungoro, 
			// --------------------------------------------------------
			cards.Add("UNG_829t3", null);

			// --------------------------------------- MINION - WARLOCK
			// [UNG_834t1] Pterrordax (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: ungoro, 
			// --------------------------------------------------------
			cards.Add("UNG_834t1", null);

			// ---------------------------------------- SPELL - WARLOCK
			// [UNG_829t1] Nether Portal (*) - COST:5 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Open a permanent portal that summons 3/2 Imps.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("UNG_829t1", new Power {
				// @darkfriend77 Please confirm this!
				PowerTask = new SummonTask("UNG_829t2", SummonSide.SPELL)
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [UNG_838] Tar Lord - COST:7 [ATK:1/HP:11] 
			// - Race: elemental, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Has +4 Attack during your opponent’s turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_838", new Power {
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.ADD, p => p.Controller == p.Game.CurrentOpponent ? 4 : 0)
			});

			// --------------------------------------- MINION - WARRIOR
			// [UNG_925] Ornery Direhorn - COST:6 [ATK:5/HP:5] 
			// - Race: beast, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> <b>Adapt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_925", new Power {
				PowerTask = new AdaptTask(EntityType.SOURCE)
			});

			// --------------------------------------- MINION - WARRIOR
			// [UNG_926] Cornered Sentry - COST:2 [ATK:2/HP:6] 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Battlecry:</b> Summon three 1/1 Raptors for your_opponent.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_926", new Power {
				// TODO [UNG_926] Cornered Sentry && Test: Cornered Sentry_UNG_926
				PowerTask = new EnqueueTask(3, new SummonOpTask("UNG_076t1"))
			});

			// --------------------------------------- MINION - WARRIOR
			// [UNG_933] King Mosh - COST:9 [ATK:9/HP:7] 
			// - Race: beast, Fac: neutral, Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all damaged minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_933", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS),
					new FilterStackTask(SelfCondition.IsDamaged),
					new DestroyTask(EntityType.STACK)),
			});

			// --------------------------------------- MINION - WARRIOR
			// [UNG_957] Direhorn Hatchling - COST:5 [ATK:3/HP:6] 
			// - Race: beast, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Shuffle a 6/9 Direhorn with <b>Taunt</b> into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_957", new Power {
				DeathrattleTask = new AddCardTo("UNG_957t1", EntityType.DECK)
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [UNG_922] Explore Un'Goro - COST:2 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: Replace your deck with_copies of "<b>Discover</b> a card."
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_922", new Power {
				PowerTask = new ReplaceTask(EntityType.DECK, "UNG_922t1")
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [UNG_923] Iron Hide - COST:1 
			// - Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			// --------------------------------------------------------
			cards.Add("UNG_923", new Power {
				PowerTask = new ArmorTask(5)
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [UNG_927] Sudden Genesis - COST:5 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon copies of your damaged minions.
			// --------------------------------------------------------
			cards.Add("UNG_927", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsDamaged),
					new SummonCopyTask(EntityType.STACK))
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [UNG_934] Fire Plume's Heart - COST:1 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> Play
			//       7 <b>Taunt</b> minions.
			//       <b>Reward:</b> Sulfuras.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 7
			// - 676 = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_934", new Power {
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.HasTaunt,
					SingleTask = new QuestProgressTask("UNG_934t1")
				}
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [UNG_929] Molten Blade - COST:1 [ATK:1/HP:0] 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: Each turn this is in your hand, transform it into a new weapon.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 1
			// --------------------------------------------------------
			cards.Add("UNG_929", new Power {
				// TODO Test: Molten Blade_UNG_929
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = ComplexTask.Create(
						new ChangeEntityTask(EntityType.SOURCE, CardType.WEAPON, removeEnchantments: true),
						new AddEnchantmentTask("UNG_929e", EntityType.SOURCE))
				}
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [UNG_929e] Magmic (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Transforming into random weapons.
			// --------------------------------------------------------
			cards.Add("UNG_929e", new Power {
				Enchant = new Enchant(GameTag.SHIFTING_WEAPON, EffectOperator.SET, 1)
				{
					RemoveWhenPlayed = true
				},
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = ComplexTask.Create(
						new ChangeEntityTask(EntityType.TARGET, CardType.WEAPON, removeEnchantments: true),
						new AddEnchantmentTask("UNG_929e", EntityType.TARGET))
				}
			});

			// --------------------------------------- MINION - WARRIOR
			// [UNG_957t1] Direhorn Matriarch (*) - COST:5 [ATK:6/HP:9] 
			// - Race: beast, Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_957t1", null);

			// ---------------------------------------- SPELL - WARRIOR
			// [UNG_922t1] Choose Your Path (*) - COST:1 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a card.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_922t1", new Power {
				PowerTask = new DiscoverTask(DiscoverType.ALL)
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [UNG_934t1] Sulfuras (*) - COST:3 [ATK:4/HP:0] 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your Hero Power becomes 'Deal 8_damage to a random enemy.'
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_934t1", new Power {
				PowerTask = new ReplaceHeroPower(Cards.FromId("UNG_934t2"))
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [UNG_001] Pterrordax Hatchling - COST:3 [ATK:2/HP:2] 
			// - Race: beast, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b><b>Battlecry:</b> Adapt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_001", new Power {
				PowerTask = new AdaptTask(EntityType.SOURCE)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_002] Volcanosaur - COST:7 [ATK:5/HP:6] 
			// - Race: beast, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Adapt</b>, then_<b>Adapt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_002", new Power {
				PowerTask = new EnqueueTask(2, new AdaptTask(EntityType.SOURCE))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_009] Ravasaur Runt - COST:2 [ATK:2/HP:2] 
			// - Race: beast, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control at_least 2 other minions, <b>Adapt.</b>
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_009", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsBoardCount(3, RelaSign.GEQ)),
					new FlagTask(true, new AdaptTask(EntityType.SOURCE))),
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_010] Sated Threshadon - COST:7 [ATK:5/HP:7] 
			// - Race: beast, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon three 1/1 Murlocs.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_010", new Power {
				DeathrattleTask = new SummonTask("CFM_310t", 3)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_070] Tol'vir Stoneshaper - COST:4 [ATK:3/HP:5] 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you played an
			//       Elemental last turn, gain
			//       _<b>Taunt</b> and <b>Divine_Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("UNG_070", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
					new FlagTask(true, new AddEnchantmentTask("UNG_070e", EntityType.SOURCE)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_071] Giant Mastodon - COST:9 [ATK:6/HP:10] 
			// - Race: beast, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_071", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_072] Stonehill Defender - COST:3 [ATK:1/HP:4] 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> <b>Discover</b> a <b>Taunt</b>_minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_072", new Power {
				PowerTask = new DiscoverTask(DiscoverType.TAUNT)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_073] Rockpool Hunter - COST:2 [ATK:2/HP:3] 
			// - Race: murloc, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Murloc +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 14
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_073", new Power {
				PowerTask = new AddEnchantmentTask("UNG_073e", EntityType.TARGET)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_075] Vicious Fledgling - COST:3 [ATK:3/HP:3] 
			// - Race: beast, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: After this minion attacks a_hero, <b>Adapt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_075", new Power {
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					//Condition = new SelfCondition(p => p.Game.IdEntityDic[p.Game.ProposedDefender] is Hero),
					Condition = SelfCondition.IsEventTargetIs(CardType.HERO),
					SingleTask = new AdaptTask(EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_076] Eggnapper - COST:3 [ATK:3/HP:1] 
			// - Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 1/1 Raptors.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_076", new Power {
				DeathrattleTask = new SummonTask(SummonSide.DEATHRATTLE, Cards.FromId("UNG_076t1"), false, false, 2)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_079] Frozen Crusher - COST:6 [ATK:8/HP:8] 
			// - Race: elemental, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: After this minion attacks, <b>Freeze</b> it.
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("UNG_079", new Power {
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = new SetGameTagTask(GameTag.FROZEN, 1, EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_082] Thunder Lizard - COST:3 [ATK:3/HP:3] 
			// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: If you played an_Elemental last turn, <b>Adapt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_082", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
					new FlagTask(true, new AdaptTask(EntityType.SOURCE)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_083] Devilsaur Egg - COST:3 [ATK:0/HP:3] 
			// - Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 5/5 Devilsaur.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_083", new Power {
				DeathrattleTask = new SummonTask("UNG_083t1", SummonSide.DEATHRATTLE)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_084] Fire Plume Phoenix - COST:4 [ATK:3/HP:3] 
			// - Race: elemental, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_084", new Power {
				PowerTask = new DamageTask(2, EntityType.TARGET)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_085] Emerald Hive Queen - COST:1 [ATK:2/HP:3] 
			// - Race: beast, Fac: horde, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: Your minions cost (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("UNG_085", new Power {
				Aura = new Aura(AuraType.HAND, Effects.AddCost(2))
				{
					Condition = SelfCondition.IsMinion
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_087] Bittertide Hydra - COST:5 [ATK:8/HP:8] 
			// - Race: beast, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, deal 3 damage to_your hero.
			// --------------------------------------------------------
			cards.Add("UNG_087", new Power {
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = new DamageTask(3, EntityType.HERO)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_088] Tortollan Primalist - COST:8 [ATK:5/HP:4] 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a spell_and cast it with random targets.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_088", new Power {
				// TODO Test: Tortollan Primalist_UNG_088
				PowerTask = new DiscoverTask(DiscoverType.SPELL_RANDOM)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_089] Gentle Megasaur - COST:4 [ATK:5/HP:4] 
			// - Race: beast, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Adapt</b> your_Murlocs.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("UNG_089", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingRace(Race.MURLOC)),
					new IncludeTask(EntityType.MINIONS_NOSOURCE),
					new FlagTask(true, new FilterStackTask(SelfCondition.IsRace(Race.MURLOC))),
					new FlagTask(true, new AdaptTask(EntityType.STACK)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_099] Charged Devilsaur - COST:8 [ATK:7/HP:7] 
			// - Race: beast, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Battlecry:</b> Can't attack heroes this turn.
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_099", new Power {
				// TODO [UNG_099] Charged Devilsaur
				PowerTask = new SetGameTagTask(GameTag.CANNOT_ATTACK_HEROES, 1, EntityType.SOURCE),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsTagValue(GameTag.CANNOT_ATTACK_HEROES, 1)),
						new FlagTask(true,
						new SetGameTagTask(GameTag.CANNOT_ATTACK_HEROES, 0, EntityType.SOURCE))),
					RemoveAfterTriggered = true
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_113] Bright-Eyed Scout - COST:4 [ATK:3/HP:4] 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a card. Change its Cost to (5).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_113", new Power {
				PowerTask = ComplexTask.Create(
					new DrawTask(true),
					new AddEnchantmentTask("UNG_113e", EntityType.STACK))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_205] Glacial Shard - COST:1 [ATK:2/HP:1] 
			// - Race: elemental, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Freeze</b> an_enemy.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("UNG_205", new Power {
				PowerTask = ComplexTask.Freeze(EntityType.TARGET)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_801] Nesting Roc - COST:5 [ATK:4/HP:7] 
			// - Race: beast, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control at_least 2 other minions, gain <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_801", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsBoardCount(3, RelaSign.GEQ)),
					new FlagTask(true, ComplexTask.Taunt(EntityType.SOURCE)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_803] Emerald Reaver - COST:1 [ATK:2/HP:1] 
			// - Race: beast, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_803", new Power {
				PowerTask = new DamageTask(1, EntityType.HEROES)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_806] Ultrasaur - COST:10 [ATK:7/HP:14] 
			// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			cards.Add("UNG_806", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_807] Golakka Crawler - COST:2 [ATK:2/HP:3] 
			// - Race: beast, Fac: neutral, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a Pirate and gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_WITH_RACE = 23
			// --------------------------------------------------------
			cards.Add("UNG_807", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.TARGET, SelfCondition.IsRace(Race.PIRATE)),
					new FlagTask(true, new DestroyTask(EntityType.TARGET)),
					new FlagTask(true, new AddEnchantmentTask("UNG_807e", EntityType.SOURCE)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_808] Stubborn Gastropod - COST:2 [ATK:1/HP:2] 
			// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//         <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("UNG_808", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_809] Fire Fly - COST:1 [ATK:1/HP:2] 
			// - Race: elemental, Fac: alliance, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: Add a 1/2 Elemental to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_809", new Power {
				PowerTask = new AddCardTo("UNG_809t1", EntityType.HAND)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_810] Stegodon - COST:4 [ATK:2/HP:6] 
			// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_810", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_812] Sabretooth Stalker - COST:6 [ATK:8/HP:2] 
			// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("UNG_812", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_813] Stormwatcher - COST:7 [ATK:4/HP:8] 
			// - Race: elemental, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("UNG_813", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_814] Giant Wasp - COST:3 [ATK:2/HP:2] 
			// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//        <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("UNG_814", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_816] Servant of Kalimos - COST:5 [ATK:4/HP:5] 
			// - Race: elemental, Fac: neutral, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you played
			//       an Elemental last turn,
			//       _<b>Discover</b> an Elemental.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_816", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
					new FlagTask(true, new DiscoverTask(DiscoverType.ELEMENTAL)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_818] Volatile Elemental - COST:2 [ATK:1/HP:1] 
			// - Race: elemental, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 3 damage to a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_818", new Power {
				DeathrattleTask = ComplexTask.DamageRandomTargets(1, EntityType.OP_MINIONS, 3)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_840] Hemet, Jungle Hunter - COST:6 [ATK:6/HP:6] 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all cards in your deck that cost (3)_or less.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_840", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsTagValue(GameTag.COST, 3, RelaSign.LEQ)),
					new MoveToSetaside(EntityType.STACK))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_843] The Voraxx - COST:4 [ATK:3/HP:3] 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]After you cast a spell on
			//       this minion, summon a
			//       1/1 Plant and cast
			//       another copy on it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("UNG_843", new Power {
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY_SPELL_CASTED_ON_THE_OWNER,
					SingleTask = ComplexTask.Create(
						new SummonTask("UNG_999t2t1", SummonSide.RIGHT, true),
						new IncludeTask(EntityType.TARGET, null, true),
						new FuncPlayablesTask(list =>
						{
							//Generic.CastSpell(list[1].Controller, (Spell)list[1], (ICharacter)list[0], 0);
							list[1].ActivateTask(PowerActivation.POWER, (ICharacter)list[0]);
							return null;
						}))
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_844] Humongous Razorleaf - COST:3 [ATK:4/HP:8] 
			// - Fac: alliance, Set: ungoro, Rarity: rare
			// --------------------------------------------------------
			// Text: Can't attack.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("UNG_844", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_845] Igneous Elemental - COST:3 [ATK:2/HP:3] 
			// - Race: elemental, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add two 1/2 Elementals to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_845", new Power {
				DeathrattleTask = new AddCardTo("UNG_809t1", EntityType.HAND, 2)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_847] Blazecaller - COST:7 [ATK:6/HP:6] 
			// - Race: elemental, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you played an_Elemental last turn, deal 5 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NONSELF_TARGET = 0
			// - REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN = 0
			// --------------------------------------------------------
			cards.Add("UNG_847", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
					new FlagTask(true, new DamageTask(5, EntityType.TARGET)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_848] Primordial Drake - COST:8 [ATK:4/HP:8] 
			// - Race: dragon, Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Deal 2 damage
			//       to all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_848", new Power {
				PowerTask = new DamageTask(2, EntityType.ALLMINIONS_NOSOURCE)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_851] Elise the Trailblazer - COST:5 [ATK:5/HP:5] 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle a sealed_<b>Un'Goro</b> pack into_your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_851", new Power {
				PowerTask = new AddCardTo("UNG_851t1", EntityType.DECK)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_900] Spiritsinger Umbra - COST:4 [ATK:3/HP:4] 
			// - Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you summon a minion, trigger its <b>Deathrattle</b> effect.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("UNG_900", new Power {
				Trigger = new Trigger(TriggerType.AFTER_SUMMON)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsDeathrattleMinion,
					SingleTask = new ActivateDeathrattleTask(EntityType.TARGET)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_907] Ozruk - COST:9 [ATK:5/HP:5] 
			// - Race: elemental, Set: ungoro, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Gain +5 Health
			//       for each Elemental you
			//       played last turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("UNG_907", new Power {
				PowerTask = ComplexTask.Create(
					new GetGameTagControllerTask(GameTag.NUM_ELEMENTAL_PLAYED_LAST_TURN),
					new EnqueueNumberTask(new AddEnchantmentTask("UNG_907e", EntityType.SOURCE)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_928] Tar Creeper - COST:3 [ATK:1/HP:5] 
			// - Race: elemental, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Has +2 Attack during your opponent's turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("UNG_928", new Power {
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.ADD, p => p.Controller == p.Game.CurrentOpponent ? 2 : 0)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_937] Primalfin Lookout - COST:3 [ATK:3/HP:2] 
			// - Race: murloc, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control another Murloc, <b>Discover</b> a_Murloc.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("UNG_937", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.MINIONS_NOSOURCE, SelfCondition.IsControllingRace(Race.MURLOC)),
					new FlagTask(true, new DiscoverTask(DiscoverType.MURLOC)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_946] Gluttonous Ooze - COST:3 [ATK:3/HP:3] 
			// - Set: ungoro, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your opponent's weapon and gain Armor equal to its Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			cards.Add("UNG_946", new Power {
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.OP_WEAPON),
					new DestroyTask(EntityType.OP_WEAPON),
					new ArmorTask())
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_067t1e] Crystallized (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Your minions are 4/4.
			// --------------------------------------------------------
			// GameTag:
			// - 758 = 1
			// --------------------------------------------------------
			cards.Add("UNG_067t1e", new Power {
				Aura = new Aura(AuraType.HAND_AND_BOARD, "UNG_067t1e2")
				{
					Condition = SelfCondition.IsMinion
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_067t1e2] Crystallized (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: 4/4.
			// --------------------------------------------------------
			// GameTag:
			// - 758 = 1
			// --------------------------------------------------------
			cards.Add("UNG_067t1e2", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_067t1e2")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_070e] Stonewall (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b> and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("UNG_070e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_070e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_073e] Trained (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +1/+1
			// --------------------------------------------------------
			cards.Add("UNG_073e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_073e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_113e] Scouted (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Costs (5).
			// --------------------------------------------------------
			cards.Add("UNG_113e", new Power {
				Enchant = new Enchant(Effects.SetCost(5))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_202e] Fiery (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("UNG_202e", new Power {
				Enchant = new Enchant(Effects.ReduceCost(1))
				{
					RemoveWhenPlayed = true
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_807e] Overfull Belly (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("UNG_807e", new Power {
				Enchant = new Enchant(Effects.AttackHealth_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_823e] Envenomed (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("UNG_823e", new Power {
				InfoCardId = "UNG_823ed",
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_823e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_823ed] Envenomed (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("UNG_823ed", new Power {

			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_832e] Dark Power (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Your next spell costs Health instead of Mana.
			// --------------------------------------------------------
			cards.Add("UNG_832e", new Power {
				Aura = new Aura(AuraType.CONTROLLER, new Effect(GameTag.SPELLS_COST_HEALTH, EffectOperator.SET, 1))
				{
					RemoveTrigger = (TriggerType.CAST_SPELL, null)
				},
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new RemoveEnchantmentTask()
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_907e] Just Blaze (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +5 Health
			// --------------------------------------------------------
			cards.Add("UNG_907e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_907e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_999t10e] Shrouding Mist (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Stealthed until your next turn.
			// --------------------------------------------------------
			cards.Add("UNG_999t10e", Power.OneTurnStealthEnchantmentPower);

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_999t13e] Poison Spit (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("UNG_999t13e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_999t13e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_999t14e] Volcanic Might (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("UNG_999t14e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_999t14e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_999t2e] Living Spores (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 1/1 Plants.
			// --------------------------------------------------------
			cards.Add("UNG_999t2e", new Power {
				DeathrattleTask = new SummonTask("UNG_999t2t1", 2)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_999t3e] Flaming Claws (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("UNG_999t3e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_999t3e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_999t4e] Rocky Carapace (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("UNG_999t4e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_999t4e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_999t5e] Liquid Membrane (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("UNG_999t5e", new Power {
				Enchant = new Enchant(Effects.CantBeTargetedBySpellsAndHeroPowers)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_999t6e] Massive (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			cards.Add("UNG_999t6e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_999t6e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_999t7e] Lightning Speed (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			cards.Add("UNG_999t7e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_999t7e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [UNG_999t8e] Crackling Shield (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			cards.Add("UNG_999t8e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("UNG_999t8e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_828t2] Stubborn Gastropod (*) - COST:2 [ATK:1/HP:2] 
			// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//         <b>Poisonous</b>@<b>Taunt</b>, <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_828t2", null);

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_828t3] Giant Wasp (*) - COST:3 [ATK:2/HP:2] 
			// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//        <b>Poisonous</b>@<b>Stealth</b>, <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_828t3", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_076t1] Raptor (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: ungoro, 
			// --------------------------------------------------------
			cards.Add("UNG_076t1", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_083t1] Devilsaur (*) - COST:5 [ATK:5/HP:5] 
			// - Race: beast, Set: ungoro, 
			// --------------------------------------------------------
			cards.Add("UNG_083t1", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_201t] Primalfin (*) - COST:1 [ATK:1/HP:1] 
			// - Race: murloc, Set: ungoro, 
			// --------------------------------------------------------
			cards.Add("UNG_201t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_809t1] Flame Elemental (*) - COST:1 [ATK:1/HP:2] 
			// - Race: elemental, Fac: alliance, Set: ungoro, 
			// --------------------------------------------------------
			cards.Add("UNG_809t1", null);

			// --------------------------------------- MINION - NEUTRAL
			// [UNG_999t2t1] Plant (*) - COST:1 [ATK:1/HP:1] 
			// - Set: ungoro, 
			// --------------------------------------------------------
			cards.Add("UNG_999t2t1", null);

			// ---------------------------------------- SPELL - NEUTRAL
			// [UNG_851t1] Un'Goro Pack (*) - COST:2 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Add 5 <b>Journey to Un'Goro</b> cards to your hand.
			// --------------------------------------------------------
			cards.Add("UNG_851t1", new Power {
				PowerTask = SpecificTask.UngoroPack
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [UNG_999t10] Shrouding Mist (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_999t10", new Power {
				PowerTask = new AddEnchantmentTask("UNG_999t10e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [UNG_999t13] Poison Spit (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_999t13", new Power {
				PowerTask = new AddEnchantmentTask("UNG_999t13e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [UNG_999t14] Volcanic Might (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +1/+1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_999t14", new Power {
				PowerTask = new AddEnchantmentTask("UNG_999t14e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [UNG_999t2] Living Spores (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 1/1 Plants.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_999t2", new Power {
				PowerTask = new AddEnchantmentTask("UNG_999t2e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [UNG_999t3] Flaming Claws (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +3 Attack
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_999t3", new Power {
				PowerTask = new AddEnchantmentTask("UNG_999t3e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [UNG_999t4] Rocky Carapace (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: +3 Health
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_999t4", new Power {
				PowerTask = new AddEnchantmentTask("UNG_999t4e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [UNG_999t5] Liquid Membrane (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_999t5", new Power {
				PowerTask = new AddEnchantmentTask("UNG_999t5e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [UNG_999t6] Massive (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_999t6", new Power {
				PowerTask = new AddEnchantmentTask("UNG_999t6e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [UNG_999t7] Lightning Speed (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_999t7", new Power {
				PowerTask = new AddEnchantmentTask("UNG_999t7e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [UNG_999t8] Crackling Shield (*) - COST:0 
			// - Set: ungoro, 
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("UNG_999t8", new Power {
				PowerTask = new AddEnchantmentTask("UNG_999t8e", EntityType.TARGET)
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
