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
using SabberStoneCore.Auras;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets
{
	public class BrmCardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- HERO - NEUTRAL
			// [BRM_027h] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:8] 
			// - Set: brm, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2319
			// --------------------------------------------------------
			cards.Add("BRM_027h", null);

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRM_027p] DIE, INSECT! (*) - COST:2 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $8 damage to a random enemy. @spelldmg
			// --------------------------------------------------------
			cards.Add("BRM_027p", new Power {
				PowerTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 8)
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRM_027pH] DIE, INSECTS! (*) - COST:2 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $8 damage to a random enemy. TWICE. @spelldmg
			// --------------------------------------------------------
			cards.Add("BRM_027pH", new Power {
				PowerTask = new EnqueueTask(2, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 8))
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [BRM_009] Volcanic Lumberer - COST:9 [ATK:7/HP:8] 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Costs (1) less for each minion that died this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BRM_009", new Power {
				Aura = AdaptiveCostEffect.NumEachMinionDiedThisTurn
			});

			// ----------------------------------------- MINION - DRUID
			// [BRM_010] Druid of the Flame - COST:3 [ATK:2/HP:2] 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Transform into a 5/2 minion; or a 2/5 minion.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("BRM_010", new Power {
				PowerTask = new TransformTask("OG_044b", EntityType.SOURCE)
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [BRM_010t] Druid of the Flame (*) - COST:3 [ATK:5/HP:2] 
			// - Race: beast, Set: brm, Rarity: common
			// --------------------------------------------------------
			cards.Add("BRM_010t", null);

			// ----------------------------------------- MINION - DRUID
			// [BRM_010t2] Druid of the Flame (*) - COST:3 [ATK:2/HP:5] 
			// - Race: beast, Set: brm, Rarity: common
			// --------------------------------------------------------
			cards.Add("BRM_010t2", null);

			// ----------------------------------------- MINION - DRUID
			// [OG_044b] Druid of the Flame (*) - COST:3 [ATK:5/HP:5] 
			// - Race: beast, Set: brm, Rarity: common
			// --------------------------------------------------------
			cards.Add("OG_044b", null);

			// ------------------------------------------ SPELL - DRUID
			// [BRM_010a] Firecat Form (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Transform into a 5/2 minion.
			// --------------------------------------------------------
			cards.Add("BRM_010a", new Power {
				PowerTask = new TransformTask("BRM_010t", EntityType.SOURCE)
			});

			// ------------------------------------------ SPELL - DRUID
			// [BRM_010b] Fire Hawk Form (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Transform into a 2/5 minion.
			// --------------------------------------------------------
			cards.Add("BRM_010b", new Power {
				PowerTask = new TransformTask("BRM_010t2", EntityType.SOURCE)
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [BRM_014] Core Rager - COST:4 [ATK:4/HP:4] 
			// - Race: beast, Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your hand is empty, gain +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_014", new Power {
				PowerTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsHandEmpty),
						new FlagTask(true, new AddEnchantmentTask("BRM_014e", EntityType.SOURCE))),
			});

			// ----------------------------------------- SPELL - HUNTER
			// [BRM_013] Quick Shot - COST:2 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage.
			//       If your hand is empty, draw a card. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BRM_013", new Power {
				PowerTask = ComplexTask.Create(
						new DamageTask(3, EntityType.TARGET, true),
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsHandEmpty),
						new FlagTask(true, new DrawTask()))
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [BRM_014e] Power Rager (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: +3/+3
			// --------------------------------------------------------
			cards.Add("BRM_014e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BRM_014e")
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [BRM_002] Flamewaker - COST:3 [ATK:2/HP:4] 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: After you cast a spell, deal 2 damage randomly split among all enemies.
			// --------------------------------------------------------
			cards.Add("BRM_002", new Power {
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new EnqueueTask(2, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1))
				}
			});

			// ------------------------------------------- SPELL - MAGE
			// [BRM_003] Dragon's Breath - COST:5 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage. Costs (1) less for each minion that died this turn. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BRM_003", new Power {
				Aura = AdaptiveCostEffect.NumEachMinionDiedThisTurn,
				PowerTask = ComplexTask.Create(
					new DamageTask(4, EntityType.TARGET, true))
			});

		}

		//private static void MageNonCollect(IDictionary<string, Power> cards)
		//{

		//}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [BRM_018] Dragon Consort - COST:5 [ATK:5/HP:5] 
			// - Race: dragon, Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> The next Dragon you play costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_018", new Power {
				PowerTask = new AddEnchantmentTask("BRM_018e", EntityType.SOURCE)
			});

			// ---------------------------------------- SPELL - PALADIN
			// [BRM_001] Solemn Vigil - COST:5 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 cards. Costs (1) less for each minion that died this turn.
			// --------------------------------------------------------
			cards.Add("BRM_001", new Power {
				Aura = AdaptiveCostEffect.NumEachMinionDiedThisTurn,
				PowerTask = new EnqueueTask(2, new DrawTask())
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [BRM_018e] Unchained! (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Your next Dragon costs (2) less.
			// --------------------------------------------------------
			cards.Add("BRM_018e", new Power {
				Aura = new Aura(AuraType.HAND, Effects.ReduceCost(2))
				{
					Condition = SelfCondition.IsRace(Race.DRAGON),
					RemoveTrigger = (TriggerType.PLAY_MINION, SelfCondition.IsRace(Race.DRAGON))
				}
			});
		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [BRM_004] Twilight Whelp - COST:1 [ATK:2/HP:1] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_004", new Power {
				PowerTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
						new FlagTask(true, new AddEnchantmentTask("BRM_004e", EntityType.SOURCE)))
			});

			// ----------------------------------------- SPELL - PRIEST
			// [BRM_017] Resurrect - COST:2 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a random friendly minion that died this game.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			cards.Add("BRM_017", new Power {
				PowerTask = ComplexTask.SummonRandomMinionThatDied()
			});

		}

		//private static void PriestNonCollect(IDictionary<string, Power> cards)
		//{
		//}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [BRM_008] Dark Iron Skulker - COST:5 [ATK:4/HP:3] 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage to all undamaged enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_008", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.OP_MINIONS),
					new FilterStackTask(SelfCondition.IsUndamaged),
					new DamageTask(2, EntityType.STACK))
			});

			// ------------------------------------------ SPELL - ROGUE
			// [BRM_007] Gang Up - COST:2 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Choose a minion. Shuffle 3 copies of it into your deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BRM_007", new Power {
				PowerTask = new CopyTask(EntityType.TARGET, Zone.DECK, 3)
			});
		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [BRM_012] Fireguard Destroyer - COST:4 [ATK:3/HP:6] 
			// - Race: elemental, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain 1-4 Attack. <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - BATTLECRY = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			cards.Add("BRM_012", new Power {
				PowerTask = ComplexTask.Create(
					new MathRandTask(1,4),
					new AddEnchantmentTask("BRM_012e", EntityType.SOURCE))
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [BRM_011] Lava Shock - COST:2 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage.
			//       Unlock your <b>Overloaded</b> Mana Crystals. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("BRM_011", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(2, EntityType.TARGET),
					new SetControllerGameTagTask(GameTag.OVERLOAD_LOCKED, 0),
					new SetControllerGameTagTask(GameTag.OVERLOAD_OWED, 0))
			});

		}

		//private static void ShamanNonCollect(IDictionary<string, Power> cards)
		//{

		//}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [BRM_006] Imp Gang Boss - COST:3 [ATK:2/HP:4] 
			// - Race: demon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, summon a 1/1 Imp.
			// --------------------------------------------------------
			cards.Add("BRM_006", new Power {
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = new SummonTask("BRM_006t", SummonSide.RIGHT)
				}
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [BRM_005] Demonwrath - COST:3 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Deal $2 damage to all
			//       minions except Demons. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("BRM_005", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS),
					new FilterStackTask(SelfCondition.IsNotRace(Race.DEMON)),
					new DamageTask(2, EntityType.STACK, true))
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [BRM_006t] Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Set: brm, 
			// --------------------------------------------------------
			cards.Add("BRM_006t", null);
		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [BRM_016] Axe Flinger - COST:4 [ATK:2/HP:5] 
			// - Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, deal 2 damage to the enemy hero.
			// --------------------------------------------------------
			cards.Add("BRM_016", new Power {
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = new DamageTask(2, EntityType.OP_HERO)
				}
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [BRM_015] Revenge - COST:2 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $1 damage to all minions. If you have 12 or less Health, deal $3 damage instead. @spelldmg
			// --------------------------------------------------------
			cards.Add("BRM_015", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.HERO, SelfCondition.IsHealth(12, RelaSign.LEQ)),
					new FlagTask(true, new DamageTask(3, EntityType.ALLMINIONS, true)),
					new FlagTask(false, new DamageTask(1, EntityType.ALLMINIONS, true)))
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [BRM_019] Grim Patron - COST:5 [ATK:3/HP:3] 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: After this minion survives damage, summon another Grim Patron.
			// --------------------------------------------------------
			cards.Add("BRM_019", new Power {
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					Condition = SelfCondition.IsNotDead,
					SingleTask = new SummonTask("BRM_019", SummonSide.RIGHT),
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_020] Dragonkin Sorcerer - COST:4 [ATK:3/HP:5] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever <b>you</b> target this minion with a spell, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("BRM_020", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY_SPELL_CASTED_ON_THE_OWNER,
					SingleTask = new AddEnchantmentTask("BRM_020e", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_022] Dragon Egg - COST:1 [ATK:0/HP:2] 
			// - Set: brm, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, summon a 2/1 Whelp.
			// --------------------------------------------------------
			cards.Add("BRM_022", new Power {
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = new SummonTask("BRM_004t", SummonSide.RIGHT)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_024] Drakonid Crusher - COST:6 [ATK:6/HP:6] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your opponent has 15 or less Health, gain +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_024", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.OP_HERO, SelfCondition.IsHealth(15, RelaSign.LEQ)),
					new FlagTask(true, new AddEnchantmentTask("BRM_024e", EntityType.SOURCE))),
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_025] Volcanic Drake - COST:6 [ATK:6/HP:4] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: Costs (1) less for each minion that died this turn.
			// --------------------------------------------------------
			cards.Add("BRM_025", new Power {
				Aura = AdaptiveCostEffect.NumEachMinionDiedThisTurn,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_026] Hungry Dragon - COST:4 [ATK:5/HP:6] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a random 1-Cost minion for_your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_026", new Power {
				PowerTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.COST, 1, opponent: true),
					new SummonOpTask()),
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_027] Majordomo Executus - COST:9 [ATK:9/HP:7] 
			// - Set: brm, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Replace your hero with Ragnaros, the Firelord.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BRM_027", new Power {
				PowerTask = new ReplaceHeroTask("BRM_027h", "BRM_027p"),
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_028] Emperor Thaurissan - COST:6 [ATK:5/HP:5] 
			// - Set: brm, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, reduce the Cost of cards in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRM_028", new Power {
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new AddEnchantmentTask("BRM_028e", EntityType.HAND)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_029] Rend Blackhand - COST:7 [ATK:8/HP:4] 
			// - Set: brm, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy a <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// - REQ_LEGENDARY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BRM_029", new Power {
				PowerTask = new DestroyTask(EntityType.TARGET)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_030] Nefarian - COST:9 [ATK:8/HP:8] 
			// - Race: dragon, Set: brm, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add 2 random spells to your hand <i>(from your opponent's class)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_030", new Power {
				PowerTask = new EnqueueTask(2, ComplexTask.Create(
					new RandomCardTask(EntityType.OP_HERO),
					new AddStackTo(EntityType.HAND))),
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_031] Chromaggus - COST:8 [ATK:6/HP:8] 
			// - Race: dragon, Set: brm, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you draw a card, put another copy into your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRM_031", new Power {
				Trigger = new Trigger(TriggerType.DRAW)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new CopyTask(EntityType.TARGET, Zone.HAND)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_033] Blackwing Technician - COST:3 [ATK:2/HP:4] 
			// - Fac: neutral, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_033", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, new AddEnchantmentTask("BRM_033e", EntityType.SOURCE)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_034] Blackwing Corruptor - COST:5 [ATK:5/HP:4] 
			// - Fac: neutral, Set: brm, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, deal 3 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// --------------------------------------------------------
			cards.Add("BRM_034", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, new DamageTask(3, EntityType.TARGET)))
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_004e] Twilight Endurance (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("BRM_004e", new Power {
				Enchant = new Enchant(Effects.Health_N(2))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_012e] On Fire! (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("BRM_012e", new Power {
				Enchant = Enchants.Enchants.AddAttackScriptTag
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_020e] Draconic Power (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("BRM_020e", new Power {
				Enchant = new Enchant(Effects.AttackHealth_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_024e] Large Talons (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("BRM_024e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BRM_024e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_028e] Imperial Favor (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("BRM_028e", new Power {
				Enchant = new Enchant(Effects.ReduceCost(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRM_033e] Dragon Blood (*) - COST:0 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: +1/+1
			// --------------------------------------------------------
			cards.Add("BRM_033e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BRM_033e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_004t] Whelp (*) - COST:1 [ATK:1/HP:1] 
			// - Set: brm, 
			// --------------------------------------------------------
			cards.Add("BRM_004t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_022t] Black Whelp (*) - COST:1 [ATK:2/HP:1] 
			// - Race: dragon, Set: brm, Rarity: common
			// --------------------------------------------------------
			cards.Add("BRM_022t", null);

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRM_030t] Tail Swipe (*) - COST:4 
			// - Set: brm, 
			// --------------------------------------------------------
			// Text: Deal $4 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BRM_030t", new Power {
				PowerTask = new DamageTask(4, EntityType.TARGET, true)
			});

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
			//MageNonCollect(cards);
			Paladin(cards);
			PaladinNonCollect(cards);
			Priest(cards);
			//PriestNonCollect(cards);
			Rogue(cards);
			Shaman(cards);
			//ShamanNonCollect(cards);
			Warlock(cards);
			WarlockNonCollect(cards);
			Warrior(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
