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
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Auras;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Triggers;
using SabberStoneCore.src.Loader;

// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets.Standard
{
	public class BoomsdayCardsGen
	{
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- HERO - WARRIOR
			// [BOT_238] Dr. Boom, Mad Genius - COST:9 [ATK:0/HP:30]
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> For the rest of the game, your Mechs have <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 7
			// - HERO_POWER = 48145
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_238", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("BOT_238e", EntityType.CONTROLLER),
					SpecificTask.GetRandomDrBoomHeroPower)
			}));

			// ---------------------------------------- HERO - WHIZBANG
			// [BOT_914h] Whizbang the Wonderful (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday, Rarity: free
			// --------------------------------------------------------
			cards.Add("BOT_914h", new CardDef(new Power
			{
				// TODO [BOT_914h] Whizbang the Wonderful && Test: Whizbang the Wonderful_BOT_914h
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HeroPowers(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p] Big Red Button (*) - COST:2
			// - Fac: neutral, Set: boomsday,
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Activate this turn's
			//       Mech Suit power!
			// --------------------------------------------------------
			// Entourage: BOT_238p1, BOT_238p2, BOT_238p3, BOT_238p4, BOT_238p6
			// --------------------------------------------------------
			cards.Add("BOT_238p", new CardDef(new[] {"BOT_238p1","BOT_238p2","BOT_238p3","BOT_238p4","BOT_238p6"}, new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = SpecificTask.GetRandomDrBoomHeroPower
				}
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p1] Zap Cannon (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $3 damage.
			//       Swaps each turn. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BOT_238p1", new CardDef(new Dictionary<PlayReq, int>() {{ PlayReq.REQ_TARGET_TO_PLAY, 0 }}, new Power
			{
				PowerTask = new DamageTask(3, EntityType.TARGET),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = SpecificTask.GetRandomDrBoomHeroPower
				}
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p2] Blast Shield (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 7 Armor.
			//       Swaps each turn.
			// --------------------------------------------------------
			cards.Add("BOT_238p2", new CardDef(new Power
			{
				PowerTask = new ArmorTask(7),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = SpecificTask.GetRandomDrBoomHeroPower
				}
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p3] KABOOM! (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $1 damage to all enemies. Swaps each turn. @spelldmg
			// --------------------------------------------------------
			cards.Add("BOT_238p3", new CardDef(new Power
			{
				PowerTask = new DamageTask(1, EntityType.ENEMIES),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = SpecificTask.GetRandomDrBoomHeroPower
				}
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p4] Delivery Drone (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Discover</b> a Mech.
			//       Swaps_each_turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// - GEARS = 1
			// --------------------------------------------------------
			cards.Add("BOT_238p4", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.MECHANICAL),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = SpecificTask.GetRandomDrBoomHeroPower
				}
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p6] Micro-Squad (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon three 1/1 Microbots.
			//       Swaps_each_turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_238p6", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("BOT_312t", 3),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = SpecificTask.GetRandomDrBoomHeroPower
				}
			}));

		}

		private static void Druid(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [BOT_419] Dendrologist - COST:2 [ATK:2/HP:3]
			// - Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a Treant, <b>Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("BOT_419", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE,
						SelfCondition.IsControllingTreant),
					new FlagTask(true, new DiscoverTask(DiscoverType.SPELL)))
			}));

			// ----------------------------------------- MINION - DRUID
			// [BOT_422] Tending Tauren - COST:6 [ATK:3/HP:4]
			// - Set: boomsday, Rarity: rare
			// ------------------------------la--------------------------
			// Text: [x]<b>Choose One -</b> Give your
			//       other minions +1/+1;
			//       or Summon two
			//       2/2 Treants.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("BOT_422", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonTask("EX1_158t", SummonSide.RIGHT),
					new SummonTask("EX1_158t", SummonSide.LEFT),
					new AddEnchantmentTask("BOT_422ae", EntityType.MINIONS_NOSOURCE))
			}));

			// ----------------------------------------- MINION - DRUID
			// [BOT_423] Dreampetal Florist - COST:7 [ATK:4/HP:4]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of your turn, reduce the Cost of a random minion in your hand by (7).
			// --------------------------------------------------------
			cards.Add("BOT_423", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "BOT_423e")
				}
			}));

			// ----------------------------------------- MINION - DRUID
			// [BOT_434] Flobbidinous Floop - COST:4 [ATK:3/HP:4]
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: While in your hand, this is a 3/4 copy of the last minion you played.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_434", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_CARD)
				{
					TriggerActivation = TriggerActivation.HAND,
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.SOURCE),
						new IncludeTask(EntityType.TARGET, addFlag: true),
						new FuncPlayablesTask(list =>
						{
							IPlayable s = list[0];
							IPlayable t = list[1];
							Generic.ChangeEntityBlock.Invoke(s.Controller, s, t.Card, false);
							return null;
						}),
						new AddEnchantmentTask("BOT_434e", EntityType.SOURCE),
						new AddEnchantmentTask("BOT_434e2", EntityType.SOURCE))
				}
			}));

			// ----------------------------------------- MINION - DRUID
			// [BOT_507] Gloop Sprayer - COST:8 [ATK:4/HP:4]
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a copy of each adjacent minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_507", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeAdjacentTask(EntityType.SOURCE),
					new SummonCopyTask(EntityType.STACK, side: SummonSide.ALTERNATE))
			}));

			// ----------------------------------------- MINION - DRUID
			// [BOT_523] Mulchmuncher - COST:10 [ATK:8/HP:8]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>. Costs (1) less for each friendly Treant that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_523", new CardDef(new Power
			{
				Aura = new AdaptiveCostEffect(
					p => p.Controller.GraveyardZone.Count(q => q.Card.Name == "Treant" && q.ToBeDestroyed))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [BOT_054] Biology Project - COST:1
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Each player gains 2_Mana Crystals.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_054", new CardDef(new Power
			{
				PowerTask = new ManaCrystalFullTask(2, true)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [BOT_404] Juicy Psychmelon - COST:4
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw a 7, 8, 9, and
			//       10-Cost minion
			//        from your deck.
			// --------------------------------------------------------
			cards.Add("BOT_404", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					ComplexTask.DrawFromDeck(1, SelfCondition.IsCost(7)),
					ComplexTask.DrawFromDeck(1, SelfCondition.IsCost(8)),
					ComplexTask.DrawFromDeck(1, SelfCondition.IsCost(9)))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [BOT_420] Landscaping - COST:3
			// - Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Summon two 2/2 Treants.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_420", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("EX1_158t", 2)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [BOT_444] Floop's Glorious Gloop - COST:1
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever a minion dies this turn, gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_444", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("BOT_444e", EntityType.CONTROLLER)

			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [BOT_423e] Floral Arrangement (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Costs (7) less.
			// --------------------------------------------------------
			cards.Add("BOT_423e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.ReduceCost(7))
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [BOT_434e] Floopy (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Transforming into recent minions.
			// --------------------------------------------------------
			cards.Add("BOT_434e", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_CARD)
				{
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.SOURCE),
						new IncludeTask(EntityType.TARGET, addFlag: true),
						new FuncPlayablesTask(list =>
						{
							IPlayable t = (IPlayable)((Enchantment)list[0]).Target;
							IPlayable s = list[1];
							Generic.ChangeEntityBlock.Invoke(s.Controller, t, s.Card, false);
							return null;
						}))
				}
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [BOT_434e2] Floopy (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: 3/4.
			// --------------------------------------------------------
			cards.Add("BOT_434e2", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetAttack(3), Effects.SetMaxHealth(4)),
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [BOT_444e] Gloopy (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Whenever a minion dies this turn, gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_444e", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					SingleTask = new TempManaTask(1)
				}
			}));

			// ------------------------------------------ SPELL - DRUID
			// [BOT_422a] Old Growth (*) - COST:0
			// - Fac: neutral, Set: boomsday,
			// --------------------------------------------------------
			// Text: Give your other minions +1/+1.
			// --------------------------------------------------------
			cards.Add("BOT_422a", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("BOT_422ae", EntityType.MINIONS_NOSOURCE)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [BOT_422b] New Growth (*) - COST:0
			// - Fac: neutral, Set: boomsday,
			// --------------------------------------------------------
			// Text: Summon two 2/2 Treants.
			// --------------------------------------------------------
			cards.Add("BOT_422b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,2}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonTask("EX1_158t", SummonSide.RIGHT),
					new SummonTask("EX1_158t", SummonSide.LEFT))
			}));

		}

		private static void Hunter(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [BOT_034] Boommaster Flark - COST:7 [ATK:5/HP:5]
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon four 0/2 Goblin Bombs.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_034", new CardDef(new Power
			{
				PowerTask = new SummonTask("BOT_031", 4, SummonSide.ALTERNATE)
			}));

			// ---------------------------------------- MINION - HUNTER
			// [BOT_035] Venomizer - COST:2 [ATK:2/HP:2]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_035", new CardDef(new Power
			{
				PowerTask = new MagneticTask()
			}));

			// ---------------------------------------- MINION - HUNTER
			// [BOT_038] Fireworks Tech - COST:2 [ATK:2/HP:1]
			// - Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Give a friendly
			//       Mech +1/+1. If it has
			//       <b>Deathrattle</b>, trigger it.
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
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_038", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_WITH_RACE,17}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("BOT_038e", EntityType.TARGET),
					new ConditionTask(EntityType.TARGET, SelfCondition.IsDeathrattleMinion),
					new FlagTask(true,
						new ActivateDeathrattleTask(EntityType.TARGET)))
			}));

			// ---------------------------------------- MINION - HUNTER
			// [BOT_039] Necromechanic - COST:5 [ATK:3/HP:6]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Your <b>Deathrattles</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_039", new CardDef(new Power
			{
				Aura = new Aura(AuraType.CONTROLLER, "BOT_039e")
			}));

			// ---------------------------------------- MINION - HUNTER
			// [BOT_251] Spider Bomb - COST:3 [ATK:2/HP:2]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Deathrattle:</b> Destroy a random_enemy_minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_251", new CardDef(new Power
			{
				PowerTask = new MagneticTask(),
				DeathrattleTask = ComplexTask.DestroyRandomTargets(1, EntityType.OP_MINIONS)
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [BOT_033] Bomb Toss - COST:2
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage. Summon a 0/2 Goblin_Bomb. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BOT_033", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(2, EntityType.TARGET, true),
					new SummonTask("BOT_031"))
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [BOT_402] Secret Plan - COST:1
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Secret</b>.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("BOT_402", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.SECRET)
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [BOT_429] Flark's Boom-Zooka - COST:8
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Summon 3 minions from
			//       your deck. They attack
			//       enemy minions, then die.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_429", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new RecruitTask(3, true),
					new FuncPlayablesTask(list =>
					{
						Controller c = list[0].Controller;
						EventMetaData temp = c.Game.CurrentEventData;
						for (int i = 0; i < list.Count; i++)
						{
							Minion defender = c.Opponent.BoardZone.Random;

							if (defender == null) break;
							Generic.AttackBlock.Invoke(c, (ICharacter)list[i], defender, true, true);
							c.NumOptionsPlayedThisTurn--;
						}

						c.Game.DeathProcessingAndAuraUpdate();
						c.Game.CurrentEventData = temp;

						return null;
					}))

			}));

			// ----------------------------------------- SPELL - HUNTER
			// [BOT_437] Goblin Prank - COST:2
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a friendly minion +3/+3 and <b>Rush</b>. It_dies at end of turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_437", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("BOT_437e", EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [BOT_438] Cybertech Chip - COST:2
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your minions "<b>Deathrattle:</b> Add a random Mech to your_hand."
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_438", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("BOT_438e", EntityType.MINIONS)
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [BOT_038e] Primed (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("BOT_038e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_038e")
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [BOT_251e] Spider Bomb (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Destroy a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_251e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_251e"),
				DeathrattleTask = ComplexTask.DestroyRandomTargets(1, EntityType.OP_MINIONS)
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [BOT_438e] Chipped (*) - COST:0
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Mech to your_hand.
			// --------------------------------------------------------
			cards.Add("BOT_438e", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomCardTask(CardType.MINION, CardClass.INVALID, Race.MECHANICAL),
					new AddStackTo(EntityType.HAND))
			}));

		}

		private static void Mage(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [BOT_103] Stargazer Luna - COST:3 [ATK:2/HP:4]
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you play the
			//       right-most card in your hand, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_103", new CardDef(new Power
			{
				// TODO: tag=LUNAHIGHLIGHTHINT
				Trigger = new Trigger(TriggerType.AFTER_PLAY_CARD)
				{
					Condition = new SelfCondition(p => p.ZonePosition == p.Controller.HandZone.Count),
					SingleTask = new DrawTask()
				}
			}));

			// ------------------------------------------ MINION - MAGE
			// [BOT_256] Astromancer - COST:7 [ATK:5/HP:5]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon a
			//       random minion with Cost
			//       equal to your hand size.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_256", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new CountTask(EntityType.HAND),
					new RandomMinionNumberTask(GameTag.COST),
					new SummonTask())
			}));

			// ------------------------------------------ MINION - MAGE
			// [BOT_531] Celestial Emissary - COST:2 [ATK:2/HP:1]
			// - Race: elemental, Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your next spell_this turn has <b>Spell_Damage +2</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("BOT_531", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("BOT_531e", EntityType.CONTROLLER)
			}));

			// ------------------------------------------ MINION - MAGE
			// [BOT_601] Meteorologist - COST:6 [ATK:3/HP:3]
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> For each card in your hand, deal 1 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_601", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new CountTask(EntityType.HAND),
					new EnqueueNumberTask(
						ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1)))
			}));

			// ------------------------------------------ MINION - MAGE
			// [BOT_604] Cosmic Anomaly - COST:4 [ATK:4/HP:3]
			// - Race: elemental, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +2</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 2
			// --------------------------------------------------------
			cards.Add("BOT_604", new CardDef());

			// ------------------------------------------- SPELL - MAGE
			// [BOT_101] Astral Rift - COST:2
			// - Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Add 2 random minions to your hand.
			// --------------------------------------------------------
			cards.Add("BOT_101", new CardDef(new Power
			{
				PowerTask = ComplexTask.Repeat(ComplexTask.Create(
					new RandomCardTask(CardType.MINION, CardClass.INVALID),
					new AddStackTo(EntityType.HAND)), 2)
			}));

			// ------------------------------------------- SPELL - MAGE
			// [BOT_254] Unexpected Results - COST:4
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Summon two random
			//       $2-Cost minions <i>(improved
			//       by <b>Spell Damage</b>)</i>. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_254", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new EnqueueTask(2,
					ComplexTask.Create(
						new FuncNumberTask(p => 2 + p.Controller.CurrentSpellPower),
						new RandomMinionNumberTask(GameTag.COST),
						new SummonTask()))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [BOT_257] Luna's Pocket Galaxy - COST:7
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Change the Cost of minions in your
			//       deck to (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_257", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new AddEnchantmentTask("BOT_257e", EntityType.STACK))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [BOT_453] Shooting Star - COST:1
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage to a minion and the minions next to it. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_453", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeAdjacentTask(EntityType.TARGET, true),
					new DamageTask(1, EntityType.STACK, true))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [BOT_600] Research Project - COST:2
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Each player draws 2_cards.
			// --------------------------------------------------------
			cards.Add("BOT_600", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new EnqueueTask(2, new DrawTask()),
					new EnqueueTask(2, new DrawOpTask()))
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [BOT_257e] Starstruck (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("BOT_257e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetCost(1))
			}));

			// ------------------------------------- ENCHANTMENT - MAGE
			// [BOT_531e] Celestial Power (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: You have <b>Spell Damage +2</b> for your next spell this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_531e", new CardDef(new Power
			{
				// Seems like there are some problems with Enchant SPELLPOWER effects not being removed
				Aura = new Aura(AuraType.CONTROLLER, new Effect(GameTag.SPELLPOWER, EffectOperator.ADD, 2))
				{
					RemoveTrigger = (TriggerType.TURN_END, null),
				},
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					SingleTask = RemoveEnchantmentTask.Task
				}

				//Enchant = new Enchant(new Effect(GameTag.SPELLPOWER, EffectOperator.ADD, 2)),
				//{
				//	IsOneTurnEffect = true
				//},
				//Trigger = new Trigger(TriggerType.AFTER_CAST)
				//{
				//	SingleTask = new RemoveEnchantmentTask()
				//}
			}));

			// ------------------------------------- ENCHANTMENT - MAGE
			// [BOT_531e2] Celestial Power (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: You have <b>Spell Damage +2</b> for your next spell this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_531e2", new CardDef(new Power
			{
				// TODO [BOT_531e2] Celestial Power && Test: Celestial Power_BOT_531e2
				// Enchantment for indicating activation.
			}));

		}

		private static void Paladin(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [BOT_236] Crystalsmith Kangor - COST:2 [ATK:1/HP:2]
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>, <b>Lifesteal</b>
			//       Your healing is doubled.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DIVINE_SHIELD = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("BOT_236", new CardDef(new Power
			{
				Aura = new Aura(AuraType.CONTROLLER, new Effect(GameTag.ALL_HEALING_DOUBLE, EffectOperator.ADD, 1))
			}));

			// --------------------------------------- MINION - PALADIN
			// [BOT_537] Mechano-Egg - COST:5 [ATK:0/HP:5]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon an 8/8 Robosaur.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_537", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("BOT_537t", 1)
			}));

			// --------------------------------------- MINION - PALADIN
			// [BOT_906] Glow-Tron - COST:1 [ATK:1/HP:3]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_906", new CardDef(new Power
			{
				PowerTask = new MagneticTask()
			}));

			// --------------------------------------- MINION - PALADIN
			// [BOT_910] Glowstone Technician - COST:6 [ATK:3/HP:4]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all minions in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_910", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new AddEnchantmentTask("BOT_910e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - PALADIN
			// [BOT_911] Annoy-o-Module - COST:4 [ATK:2/HP:4]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Divine Shield</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_911", new CardDef(new Power
			{
				PowerTask = new MagneticTask()
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [BOT_234] Shrink Ray - COST:5
			// - Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Set the Attack and Health of all minions
			//       to 1.
			// --------------------------------------------------------
			cards.Add("BOT_234", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("BOT_234e", EntityType.ALLMINIONS)
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [BOT_436] Prismatic Lens - COST:4
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw a minion and a spell from your deck. Swap their Costs.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_436", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [BOT_436] Prismatic Lens && Test: Prismatic Lens_BOT_436
				InfoCardId = "BOT_436e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [BOT_908] Autodefense Matrix - COST:1
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions is attacked, give it <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("BOT_908", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					Condition = SelfCondition.IsEventTargetIs(CardType.MINION),
					SingleTask = ComplexTask.Secret(
						ComplexTask.DivineShield(EntityType.EVENT_TARGET))
				}
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [BOT_909] Crystology - COST:2
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Draw two 1-Attack
			//       minions from your deck.
			// --------------------------------------------------------
			cards.Add("BOT_909", new CardDef(new Power
			{
				PowerTask = ComplexTask.DrawFromDeck(2, SelfCondition.IsTagValue(GameTag.ATK, 1))
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [BOT_912] Kangor's Endless Army - COST:7
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Resurrect 3 friendly Mechs. They keep any <b>Magnetic</b> upgrades.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINIONS_OF_RACE_DIED_THIS_GAME = 17
			// --------------------------------------------------------
			// RefTag:
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_912", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1},{PlayReq.REQ_FRIENDLY_MINIONS_OF_RACE_DIED_THIS_GAME,17}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.GRAVEYARD),
					new FilterStackTask(SelfCondition.IsRace(Race.MECHANICAL), SelfCondition.IsDead),
					new RandomTask(3, EntityType.STACK),
					new CustomTask((g, c, s, t, stack) =>
					{
						foreach (IPlayable deadMech in stack.Playables)
						{
							if (c.BoardZone.IsFull)
								break;

							// copy and summon the base card
							IPlayable copied = Generic.Copy(in c, in s, in deadMech, Zone.PLAY);
							if (deadMech.AppliedEnchantments == null) continue;
							foreach (Enchantment magneticUpgrade in deadMech.AppliedEnchantments)
							{   // copy magnetic enchantments
								Generic.AddEnchantmentBlock(in g, magneticUpgrade.Card, (IPlayable)s, copied,
									magneticUpgrade.ScriptTag1, magneticUpgrade.ScriptTag2);
							}
						}
					}))
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [BOT_436e] Swapped Cost (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Cost swapped.
			// --------------------------------------------------------
			cards.Add("BOT_436e", new CardDef(new Power
			{
				// TODO [BOT_436e] Swapped Cost && Test: Swapped Cost_BOT_436e
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [BOT_910e] Light Infused (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("BOT_910e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_910e")
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [BOT_911e] Annoy-o-Module (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>, <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_911e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_911e")
			}));

			// --------------------------------------- MINION - PALADIN
			// [BOT_537t] Robosaur (*) - COST:8 [ATK:8/HP:8]
			// - Race: mechanical, Set: boomsday,
			// --------------------------------------------------------
			cards.Add("BOT_537t", new CardDef());

		}

		private static void Priest(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [BOT_216] Omega Medic - COST:3 [ATK:3/HP:4]
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have 10 Mana Crystals, restore #10 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_216", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsManaCrystalFull),
					new FlagTask(true, new HealTask(10, EntityType.HERO)))
			}));

			// ---------------------------------------- MINION - PRIEST
			// [BOT_258] Zerek, Master Cloner - COST:6 [ATK:5/HP:5]
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If you've cast any spells on this minion, resummon it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - 537 = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("BOT_258", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY_SPELL_CASTED_ON_THE_OWNER,
					SingleTask = new AddEnchantmentTask("BOT_258e", EntityType.SOURCE),
					RemoveAfterTriggered = true
				}
			}));

			// ---------------------------------------- MINION - PRIEST
			// [BOT_509] Dead Ringer - COST:2 [ATK:2/HP:1]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a <b>Deathrattle</b> minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_509", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.DrawFromDeck(1, SelfCondition.IsDeathrattleMinion)
			}));

			// ---------------------------------------- MINION - PRIEST
			// [BOT_558] Test Subject - COST:1 [ATK:0/HP:2]
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Return any
			//       spells you cast on this
			//       minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 537 = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("BOT_558", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY_SPELL_CASTED_ON_THE_OWNER,
					SingleTask = ComplexTask.Create(
						new GetGameTagTask(GameTag.ENTITY_ID, EntityType.TARGET),
						new AddEnchantmentTask("BOT_558e", EntityType.SOURCE, false, true))
				}
			}));

			// ---------------------------------------- MINION - PRIEST
			// [BOT_566] Reckless Experimenter - COST:5 [ATK:4/HP:6]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle</b> minions you
			//       play cost (3) less, but die
			//       at the end of the turn.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_566", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HAND, "BOT_566e2")
				{
					Condition = SelfCondition.IsDeathrattleMinion
				},
				Trigger = new Trigger(TriggerType.PLAY_MINION)
				{
					Condition = SelfCondition.IsDeathrattleMinion,
					SingleTask = new AddEnchantmentTask("BOT_566e", EntityType.TARGET)
				}
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_219] Extra Arms - COST:3
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Give a minion +2/+2.
			//       Add 'More Arms!' to your
			//       hand that gives +2/+2.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_219", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("BOT_219e", EntityType.TARGET),
					new AddCardTo("BOT_219t", EntityType.HAND))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_435] Cloning Device - COST:2
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a copy of a minion in your opponent's deck.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("BOT_435", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.OP_DECK_MINION)
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_517] Topsy Turvy - COST:0
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Swap a minion's Attack and Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_517", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new SwapAttackHealthTask(EntityType.TARGET, "BOT_517e")
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_529] Power Word: Replicate - COST:5
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Choose a friendly minion. Summon a 5/5 copy of it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_529", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonCopyTask(EntityType.TARGET, addToStack: true),
					new AddEnchantmentTask("BOT_529e", EntityType.STACK))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_567] Zerek's Cloning Gallery - COST:9
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Summon a 1/1 copy of_each minion in your_deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_567", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new SummonCopyTask(EntityType.STACK, true, true),
					new AddEnchantmentTask("BOT_567e", EntityType.STACK))
			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_219e] Armed (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("BOT_219e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_219e")
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_219te] More Armed (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("BOT_219te", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_219te")
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_258e] Cloning Vector (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Prepared to summon Zerek, Master Cloner
			// --------------------------------------------------------
			cards.Add("BOT_258e", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("BOT_258", 1)
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_529e] Replicated (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: 5/5.
			// --------------------------------------------------------
			cards.Add("BOT_529e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_529e")
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_558e] Stored Data (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Storing spell.
			// --------------------------------------------------------
			cards.Add("BOT_558e", new CardDef(new Power
			{
				//DeathrattleTask = ComplexTask.Create(
				//	new IncludeTask(EntityType.TARGET),
				//	new FuncPlayablesTask(list =>
				//	{
				//		IPlayable t = list[0];
				//		return new List<IPlayable>
				//		{
				//			Entity.FromCard(t.Controlle5r,
				//				t.Game.IdEntityDic[t[GameTag.TAG_SCRIPT_DATA_NUM_1]]
				//					.Card)
				//		};
				//	}),
				//	new AddStackTo(EntityType.HAND))
				DeathrattleTask = ComplexTask.Create(
					GetCapturedCardTask.Task,
					new AddStackTo(EntityType.HAND))
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_566e] Reckless Experiment (*) - COST:0
			// - Fac: neutral, Set: boomsday,
			// --------------------------------------------------------
			// Text: This minion will die a reckless death at the end of the turn.
			// --------------------------------------------------------
			cards.Add("BOT_566e", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new DestroyTask(EntityType.TARGET)
				}
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_566e2] Reckless Experiment (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Costs (3) less.
			// --------------------------------------------------------
			cards.Add("BOT_566e2", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.ReduceCost(3))
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_567e] Cloned (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("BOT_567e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_567e")
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_219t] More Arms! (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Give a minion +2/+2.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_219t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("BOT_219te", EntityType.TARGET)
			}));

		}

		private static void Rogue(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [BOT_243] Myra Rotspring - COST:5 [ATK:4/HP:2]
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Discover</b> a
			//       <b>Deathrattle</b> minion. Also
			//       gain its <b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("BOT_243", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.DEATHRATTLE_MINIONS,
					ComplexTask.Create(
						new GetGameTagTask(GameTag.ENTITY_ID, EntityType.TARGET),
						new AddEnchantmentTask("BOT_243e", EntityType.SOURCE, false, true)))
			}));

			// ----------------------------------------- MINION - ROGUE
			// [BOT_283] Pogo-Hopper - COST:2 [ATK:1/HP:1]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain +2/+2 for
			//       each other Pogo-Hopper
			//       you played this game.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_283", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new FuncNumberTask(p =>
					{
						int count = p.Controller.PlayHistory.Count(h => h.SourceCard.AssetId == 48471) - 1;

						return count < 0 ? 0 : count * 2;
					}),
					new AddEnchantmentTask("BOT_283e", EntityType.SOURCE, true))
			}));

			// ----------------------------------------- MINION - ROGUE
			// [BOT_288] Lab Recruiter - COST:2 [ATK:3/HP:2]
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle 3 copies of a friendly minion into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_288", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new CopyTask(EntityType.TARGET, Zone.DECK, 3)
			}));

			// ----------------------------------------- MINION - ROGUE
			// [BOT_565] Blightnozzle Crawler - COST:4 [ATK:2/HP:4]
			// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 1/1 Ooze with <b>Poisonous</b> and <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_565", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("BOT_565t")
			}));

			// ----------------------------------------- MINION - ROGUE
			// [BOT_576] Crazed Chemist - COST:5 [ATK:4/HP:4]
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Give a friendly minion +4 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_FOR_COMBO = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_576", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_FOR_COMBO,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				ComboTask = new AddEnchantmentTask("BOT_576e", EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [BOT_084] Violet Haze - COST:3
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Add 2 random <b>Deathrattle</b> cards to_your hand.
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_084", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(2,
					ComplexTask.Create(
					new RandomCardTask(CardType.INVALID, CardClass.INVALID, gameTagFilter: new[] { GameTag.DEATHRATTLE }),
					new AddStackTo(EntityType.HAND)))
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [BOT_087] Academic Espionage - COST:4
			// - Fac: neutral, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle 10 cards from your opponent's class into your deck. They_cost (1).
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_087", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Repeat(
					ComplexTask.Create(
						new RandomCardTask(EntityType.OP_HERO),
						new AddEnchantmentTask("BOT_087e", EntityType.STACK),
						new AddStackTo(EntityType.DECK)), 10)
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [BOT_242] Myra's Unstable Element - COST:5
			// - Fac: neutral, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Draw the rest of
			//       your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_242", new CardDef(new Power
			{
				// TODO Test: Myra's Unstable Element_BOT_242
				//PowerTask = new FuncNumberTask(p =>
				//{
				//	Controller c = p.Controller;
				//	while (!c.DeckZone.IsEmpty)
				//		Generic.Draw(c);
				//	return 0;
				//})
				PowerTask = new CustomTask((g, c, s, t, stack) =>
				{
					int count = c.HandZone.FreeSpace;
					for (int i = 0; i < count; i++)
						Generic.Draw(c);
					for (int i = c.DeckZone.Count - 1; i >= 0; i--)
						c.SetasideZone.Add(c.DeckZone.Remove(i));
				})
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [BOT_508] Necrium Vial - COST:5
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Trigger a friendly minion's <b>Deathrattle</b> twice.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_508", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_TARGET_WITH_DEATHRATTLE,0}}, new Power
			{
				// TODO Test: Necrium Vial_BOT_508
				PowerTask = new EnqueueTask(2, new ActivateDeathrattleTask(EntityType.TARGET))
			}));

			// ----------------------------------------- WEAPON - ROGUE
			// [BOT_286] Necrium Blade - COST:3 [ATK:3/HP:0]
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Trigger the <b>Deathrattle</b> of a random friendly minion.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_286", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsDeathrattleMinion),
					new RandomTask(1, EntityType.STACK),
					new ActivateDeathrattleTask(EntityType.STACK))
			}));

		}

		private static void RogueNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [BOT_087e] Academic Espionage (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("BOT_087e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetCost(1))
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [BOT_243e] Necroalchemy (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Copied Deathrattle from {0}.
			// --------------------------------------------------------
			cards.Add("BOT_243e", new CardDef(new Power
			{
				//DeathrattleTask = ComplexTask.Create(
				//	new IncludeTask(EntityType.SOURCE),
				//	new IncludeTask(EntityType.TARGET, null, true),
				//	new FuncPlayablesTask(p =>
				//	{
				//		p[0].Game.IdEntityDic[p[1][GameTag.TAG_SCRIPT_DATA_NUM_1]].ActivateTask(PowerActivation.DEATHRATTLE, null, 0, p[0]);
				//		return null;
				//	}))
				DeathrattleTask = ActivateCapturedDeathrattleTask.Task
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [BOT_283e] Kinetic Energy (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("BOT_283e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [BOT_576e] Overcharged (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +4 Attack.
			// --------------------------------------------------------
			cards.Add("BOT_576e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_576e")

			}));

			// ----------------------------------------- MINION - ROGUE
			// [BOT_565t] Radioactive Ooze (*) - COST:1 [ATK:1/HP:1]
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_565t", new CardDef());

		}

		private static void Shaman(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [BOT_291] Storm Chaser - COST:4 [ATK:3/HP:4]
			// - Race: elemental, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a spell from your deck that costs_(5) or more.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_291", new CardDef(new Power
			{
				PowerTask = ComplexTask.DrawFromDeck(1, SelfCondition.IsTagValue(GameTag.COST, 5, RelaSign.GEQ))
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [BOT_407] Thunderhead - COST:4 [ATK:3/HP:5]
			// - Race: elemental, Fac: neutral, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]After you play a card with
			//       <b>Overload</b>, summon two
			//       1/1 Sparks with <b>Rush</b>.
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_407", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_CARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsOverloadCard,
					SingleTask = new SummonTask("BOT_102t", 2, SummonSide.ALTERNATE)
				}
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [BOT_411] Electra Stormsurge - COST:3 [ATK:3/HP:3]
			// - Race: elemental, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your next spell this turn casts twice.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_411", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("BOT_411e", EntityType.CONTROLLER)
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [BOT_533] Menacing Nimbus - COST:2 [ATK:2/HP:2]
			// - Race: elemental, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Elemental to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_533", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomCardTask(CardType.MINION, CardClass.INVALID, Race.ELEMENTAL),
					new AddStackTo(EntityType.HAND))
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [BOT_543] Omega Mind - COST:2 [ATK:2/HP:3]
			// - Fac: neutral, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you have 10
			//       Mana Crystals, your spells
			//        have <b>Lifesteal</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("BOT_543", new CardDef(new Power
			{
				// TODO [BOT_543] Omega Mind && Test: Omega Mind_BOT_543
				InfoCardId = "BOT_543e",
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsManaCrystalFull),
					new FlagTask(true,
						new AddEnchantmentTask("BOT_543e", EntityType.CONTROLLER)))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [BOT_093] Elementary Reaction - COST:2
			// - Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Draw a card. Copy it if_you played an Elemental last turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			cards.Add("BOT_093", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DrawTask(true),
					new ConditionTask(EntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
					new FlagTask(true, new CopyTask(EntityType.STACK, Zone.HAND)))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [BOT_099] Eureka! - COST:6
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a copy of_a_random minion from your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_099", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new SummonCopyTask(EntityType.STACK))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [BOT_245] The Storm Bringer - COST:7
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Transform your minions into random <b>Legendary</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_245", new CardDef(new Power
			{
				//PowerTask = ComplexTask.Create(
				//	new IncludeTask(EntityType.MINIONS),
				//	new FuncPlayablesTask(minions =>
				//	{
				//		if (minions.Count == 0)
				//			return null;

				//		IReadOnlyList<Card> legendaries = RandomCardTask.GetCardList(minions[0], CardType.MINION,
				//			rarity: Rarity.LEGENDARY);
				//		foreach (IPlayable p in minions)
				//			Generic.TransformBlock.Invoke(p.Controller, Util.Choose(legendaries), (Minion)p);

				//		minions[0].Game.OnRandomHappened(true);

				//		return null;
				//	}))
				PowerTask = new ChangeEntityTask(EntityType.MINIONS, CardType.MINION,
					rarity: Rarity.LEGENDARY,
					removeEnchantments: true)
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [BOT_246] Beakered Lightning - COST:0
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage to all minions. <b>Overload:</b> (2) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			cards.Add("BOT_246", new CardDef(new Power
			{
				PowerTask = new DamageTask(1, EntityType.ALLMINIONS)
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [BOT_451] Voltaic Burst - COST:1
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon two 1/1 Sparks with <b>Rush</b>. <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_451", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("BOT_102t", 2)
			}));

		}

		private static void ShamanNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [BOT_411e] Electric (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Your next spell this turn casts twice.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_411e", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.TARGET),
						new PlayTask(PlayType.SPELL, EntityType.EVENT_TARGET),
						RemoveEnchantmentTask.Task)
				}
			}));

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [BOT_411e2] Electricking (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Your next spell this turn casts twice.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_411e2", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.CUSTOM_KEYWORD_EFFECT, EffectOperator.SET, 1)
				{
					IsOneTurnEffect = true,
				},
				Trigger = new Trigger(TriggerType.AFTER_PLAY_CARD)
				{
					Condition = SelfCondition.IsSpell,
					SingleTask = RemoveEnchantmentTask.Task
				}
			}));

		}

		private static void Warlock(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [BOT_224] Doubling Imp - COST:3 [ATK:2/HP:2]
			// - Race: demon, Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a copy of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_224", new CardDef(new Power
			{
				PowerTask = new SummonCopyTask(EntityType.SOURCE, side: SummonSide.RIGHT)
			}));

			// --------------------------------------- MINION - WARLOCK
			// [BOT_226] Nethersoul Buster - COST:3 [ATK:1/HP:5]
			// - Race: demon, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1 Attack for each damage your hero has taken this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_226", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new FuncNumberTask(p => p.Controller.Hero.DamageTakenThisTurn),
					new AddEnchantmentTask("BOT_226e", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - WARLOCK
			// [BOT_433] Dr. Morrigan - COST:8 [ATK:5/HP:5]
			// - Fac: neutral, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Swap this with a minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("BOT_433", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasMinionInDeck()),
					new FlagTask(true, ComplexTask.Create(
						new IncludeTask(EntityType.DECK),
						new FilterStackTask(SelfCondition.IsMinion),
						new RandomTask(1, EntityType.STACK),
						new RemoveFromDeck(EntityType.STACK),
						new FuncNumberTask(p =>
						{
							if (p.Zone != null)
								Generic.RemoveFromZone(p.Controller, p);
							return 0;
						}),
						new SummonTask(),
						new MoveToDeck(EntityType.SOURCE))))
			}));

			// --------------------------------------- MINION - WARLOCK
			// [BOT_443] Void Analyst - COST:2 [ATK:2/HP:2]
			// - Race: demon, Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give all Demons in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_443", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsRace(Race.DEMON)),
					new AddEnchantmentTask("BOT_443e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - WARLOCK
			// [BOT_536] Omega Agent - COST:5 [ATK:4/HP:5]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you have 10
			//       Mana Crystals, summon
			//       _2 copies of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_536", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsManaCrystalFull),
					new FlagTask(true, new EnqueueTask(2,
						new SummonCopyTask(EntityType.SOURCE, side: SummonSide.RIGHT))))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [BOT_222] Spirit Bomb - COST:2
			// - Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage to a minion and your hero. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_222", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.TARGET),
					new IncludeTask(EntityType.HERO, addFlag: true),
					new DamageTask(4, EntityType.STACK, true))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [BOT_263] Soul Infusion - COST:1
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Give the
			//       left-most minion in your hand +2/+2.
			// --------------------------------------------------------
			cards.Add("BOT_263", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.SOURCE),
					new FuncPlayablesTask(sourceArray =>
					{
						ReadOnlySpan<IPlayable> hand = sourceArray[0].Controller.HandZone.GetSpan();

						for (int i = 0; i < hand.Length; i++)
							if (hand[i].Card.Type == CardType.MINION)
								return new[] { hand[i] };

						return new IPlayable[0];
					}),
					new AddEnchantmentTask("BOT_263e", EntityType.STACK))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [BOT_521] Ectomancy - COST:6
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon copies of all Demons you control.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_521", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO Test: Ectomancy_BOT_521
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.DEMON)),
					new SummonCopyTask(EntityType.STACK))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [BOT_568] The Soularium - COST:1
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			//       At the end of your turn, discard them.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_568", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DrawTask(true, 3),
					new FilterStackTask(SelfCondition.IsInZone(Zone.HAND)),
					new AddEnchantmentTask("BOT_568e", EntityType.STACK))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [BOT_913] Demonic Project - COST:2
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Each player transforms a random minion in their hand into a Demon.
			// --------------------------------------------------------
			cards.Add("BOT_913", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new ChangeEntityTask(EntityType.STACK, CardType.MINION, race: Race.DEMON),
					new IncludeTask(EntityType.OP_HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new ChangeEntityTask(EntityType.STACK, CardType.MINION, race: Race.DEMON))
			}));

		}

		private static void WarlockNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [BOT_226e] Nethercharged (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Attack increased.
			// --------------------------------------------------------
			cards.Add("BOT_226e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [BOT_263e] Infused (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("BOT_263e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_263e")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [BOT_443e] Well-Studied (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +1/+1 from Void Analyst.
			// --------------------------------------------------------
			cards.Add("BOT_443e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_443e")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [BOT_568e] Fleeting Soul (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Discards at the end of your turn.
			// --------------------------------------------------------
			cards.Add("BOT_568e", new CardDef(new Power
			{
				Enchant = new Enchant()
				{
					RemoveWhenPlayed = true
				},
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new DiscardTask(EntityType.TARGET)
				}
			}));

		}

		private static void Warrior(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [BOT_059] Eternium Rover - COST:1 [ATK:1/HP:3]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, gain 2_Armor.
			// --------------------------------------------------------
			cards.Add("BOT_059", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = new ArmorTask(2)
				}
			}));

			// --------------------------------------- MINION - WARRIOR
			// [BOT_104] Dyn-o-matic - COST:5 [ATK:3/HP:4]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 5 damage randomly split among all minions_except_Mechs.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_104", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS),
					new FilterStackTask(SelfCondition.IsNotRace(Race.MECHANICAL)),
					ComplexTask.Repeat(ComplexTask.DamageRandomTargets(1, EntityType.STACK, 1), 5))
			}));

			// --------------------------------------- MINION - WARRIOR
			// [BOT_218] Security Rover - COST:6 [ATK:2/HP:5]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Whenever this minion
			//       takes damage, summon a
			//       2/3 Mech with <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BOT_218", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = new SummonTask("BOT_218t", 1)
				}
			}));

			// --------------------------------------- MINION - WARRIOR
			// [BOT_237] Beryllium Nullifier - COST:7 [ATK:3/HP:8]
			// - Race: mechanical, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_237", new CardDef(new Power
			{
				PowerTask = new MagneticTask()
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [BOT_042] Weapons Project - COST:2
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Each player equips a 2/3 Weapon and
			//       gains 6 Armor.
			// --------------------------------------------------------
			cards.Add("BOT_042", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new WeaponTask("BOT_042t"),
					new ArmorTask(6),
					new WeaponTask("BOT_042t", true),
					new ArmorTask(6, true))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [BOT_067] Rocket Boots - COST:2
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion <b>Rush</b>. Draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_067", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("BOT_067e", EntityType.TARGET),
					new DrawTask())
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [BOT_069] The Boomship - COST:9
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Summon 3 random minions from your hand. Give them <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_069", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(3, EntityType.STACK),
					new SummonStackTask(removeFromZone: true),
					new AddEnchantmentTask("BOT_069e", EntityType.STACK))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [BOT_299] Omega Assembly - COST:1
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Discover</b> a Mech. If you
			//       have 10 Mana Crystals,
			//       keep all 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			// RefTag:
			// - GEARS = 1
			// --------------------------------------------------------
			cards.Add("BOT_299", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.IsManaCrystalFull,
					new DiscoverTask(DiscoverType.MECHANICAL, c => true),
					new DiscoverTask(DiscoverType.MECHANICAL))
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [BOT_406] Supercollider - COST:5 [ATK:1/HP:0]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]After you attack a minion,
			//       force it to attack one
			//       of its neighbors.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - FINISH_ATTACK_SPELL_ON_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("BOT_406", new CardDef(new Power
			{
				Trigger = TriggerBuilder
					.Type(TriggerType.AFTER_ATTACK)
					.SetTask(ComplexTask.Create(
						new ConditionTask(EntityType.EVENT_TARGET, SelfCondition.IsDead),
						new FlagTask(false, ComplexTask.Create(
						new IncludeAdjacentTask(EntityType.EVENT_TARGET),
							new RandomTask(1, EntityType.STACK),
							new AttackTask(EntityType.EVENT_TARGET, EntityType.STACK)))))
					.SetSource(TriggerSource.HERO)
					.SetCondition(SelfCondition.IsEventTargetIs(CardType.MINION))
					.GetTrigger()

			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [BOT_067e] Rocket Boots (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("BOT_067e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_067e")
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [BOT_069e] Rocketeer (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("BOT_069e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_069e")
			}));

			// --------------------------------------- MINION - WARRIOR
			// [BOT_218t] Guard Bot (*) - COST:2 [ATK:2/HP:3]
			// - Race: mechanical, Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BOT_218t", new CardDef(new Power
			{
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [BOT_042t] Gearblade (*) - COST:2 [ATK:2/HP:0]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("BOT_042t", new CardDef());

		}

		private static void Neutral(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [BOT_020] Skaterbot - COST:1 [ATK:1/HP:1]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_020", new CardDef(new Power
			{
				PowerTask = new MagneticTask()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_021] Bronze Gatekeeper - COST:3 [ATK:1/HP:5]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_021", new CardDef(new Power
			{
				PowerTask = new MagneticTask()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_031] Goblin Bomb - COST:1 [ATK:0/HP:2]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Deal 2 damage
			//       to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_031", new CardDef(new Power
			{
				DeathrattleTask = new DamageTask(2, EntityType.OP_HERO)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_050] Rusty Recycler - COST:5 [ATK:2/HP:6]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("BOT_050", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_066] Mechanical Whelp - COST:6 [ATK:2/HP:2]
			// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 7/7 Mechanical Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_066", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("BOT_066t")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_079] Faithful Lumi - COST:1 [ATK:1/HP:1]
			// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Mech +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_WITH_RACE = 17
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_079", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_TARGET_WITH_RACE,17},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("BOT_079e", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_083] Toxicologist - COST:2 [ATK:2/HP:2]
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your weapon +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_083", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("BOT_083e", EntityType.WEAPON)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_098] Unpowered Mauler - COST:2 [ATK:2/HP:4]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Can only attack if you cast a spell this turn.
			// --------------------------------------------------------
			cards.Add("BOT_098", new CardDef(new Power
			{
				Aura = new AdaptiveEffect(SelfCondition.NotPlayedAnySpellThisTurn, GameTag.CANT_ATTACK)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_102] Spark Drill - COST:6 [ATK:5/HP:1]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Deathrattle:</b> Add two
			//       1/1 Sparks with <b>Rush</b> to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_102", new CardDef(new Power
			{
				DeathrattleTask = new AddCardTo("BOT_102t", EntityType.HAND, 2)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_107] Missile Launcher - COST:6 [ATK:4/HP:4]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Magnetic</b>
			//       At the end of your turn,
			//       deal 1 damage to all
			//       other characters.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_107", new CardDef(new Power
			{
				PowerTask = new MagneticTask(),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new DamageTask(1, EntityType.ALL_NOSOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_267] Piloted Reaper - COST:4 [ATK:4/HP:3]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random minion from
			//       your hand that costs (2) or less.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_267", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsTagValue(GameTag.COST, 2, RelaSign.LEQ), SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new RemoveFromHand(EntityType.STACK),
					new SummonTask())
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_270] Giggling Inventor - COST:5 [ATK:2/HP:1]
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/2 Mechs with <b>Taunt</b> and_<b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("BOT_270", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
						new SummonTask("BOT_270t", SummonSide.LEFT),
						new SummonTask("BOT_270t", SummonSide.RIGHT))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_280] Holomancer - COST:5 [ATK:3/HP:3]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: After your opponent plays a minion, summon a 1/1_copy of it.
			// --------------------------------------------------------
			cards.Add("BOT_280", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = ComplexTask.Create(
						new SummonCopyTask(EntityType.TARGET, false, true, SummonSide.RIGHT),
						new AddEnchantmentTask("BOT_280e", EntityType.STACK))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_296] Omega Defender - COST:4 [ATK:2/HP:6]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> If you have
			//       10 Mana Crystals,
			//       gain +10 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_296", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsManaCrystalFull),
					new FlagTask(true, new AddEnchantmentTask("BOT_296e", EntityType.SOURCE)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_308] Spring Rocket - COST:3 [ATK:2/HP:1]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("BOT_308", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_309] Upgradeable Framebot - COST:2 [ATK:1/HP:5]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			cards.Add("BOT_309", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_312] Replicating Menace - COST:4 [ATK:3/HP:1]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Deathrattle:</b> Summon three 1/1 Microbots.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - MODULAR = 1
			// - 853 = 48548
			// --------------------------------------------------------
			cards.Add("BOT_312", new CardDef(new Power
			{
				PowerTask = new MagneticTask(),
				DeathrattleTask = new SummonTask("BOT_312t", 3)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_401] Weaponized Piñata - COST:4 [ATK:4/HP:3]
			// - Race: mechanical, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random <b>Legendary</b> minion to your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_401", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomCardTask(CardType.MINION, CardClass.INVALID, rarity: Rarity.LEGENDARY),
					new AddStackTo(EntityType.HAND))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_413] Brainstormer - COST:3 [ATK:3/HP:1]
			// - Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain +1 Health
			//       for each spell in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_413", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsSpell),
					new CountTask(EntityType.STACK),
					new AddEnchantmentTask("BOT_413e", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_414] Cloakscale Chemist - COST:2 [ATK:1/HP:2]
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("BOT_414", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_424] Mecha'thun - COST:10 [ATK:10/HP:10]
			// - Race: mechanical, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> If you have no
			//       cards in your deck, hand,
			//       and battlefield, destroy
			//       the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_424", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE,
						SelfCondition.IsZoneCount(Zone.DECK, 0),
						SelfCondition.IsZoneCount(Zone.HAND, 0),
						SelfCondition.IsZoneCount(Zone.PLAY, 0)),
					new FlagTask(true,
						new DestroyTask(EntityType.OP_HERO, true)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_431] Whirliglider - COST:2 [ATK:2/HP:1]
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 0/2_Goblin Bomb.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_431", new CardDef(new Power
			{
				PowerTask = new SummonTask("BOT_031", 1, SummonSide.RIGHT)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_445] Mecharoo - COST:1 [ATK:1/HP:1]
			// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 1/1 Jo-E Bot.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_445", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("BOT_445t", 1)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_447] Crystallizer - COST:1 [ATK:1/HP:3]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 5 damage
			//       to your hero. Gain 5 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_447", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(5, EntityType.HERO),
					new ArmorTask(5))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_448] Damaged Stegotron - COST:6 [ATK:5/HP:12]
			// - Race: mechanical, Fac: horde, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Deal 6 damage to this minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_448", new CardDef(new Power
			{
				PowerTask = new DamageTask(6, EntityType.SOURCE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_511] Seaforium Bomber - COST:5 [ATK:5/HP:5]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Shuffle a Bomb
			//       into your opponent's deck.
			//       When drawn, it explodes
			//       for 5 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_511", new CardDef(new Power
			{
				PowerTask = new AddCardTo("BOT_511t", EntityType.OP_DECK)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_532] Explodinator - COST:4 [ATK:3/HP:2]
			// - Race: mechanical, Fac: horde, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 0/2 Goblin Bombs.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_532", new CardDef(new Power
			{
				PowerTask = new SummonTask("BOT_031", 2, SummonSide.ALTERNATE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_534] Bull Dozer - COST:9 [ATK:9/HP:7]
			// - Race: mechanical, Fac: alliance, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("BOT_534", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_535] Microtech Controller - COST:3 [ATK:2/HP:1]
			// - Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/1 Microbots.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_535", new CardDef(new Power
			{
				PowerTask = new SummonTask("BOT_312t", 2, SummonSide.ALTERNATE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_538] Spark Engine - COST:2 [ATK:2/HP:1]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a
			//       1/1 Spark with <b>Rush</b> to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_538", new CardDef(new Power
			{
				PowerTask = new AddCardTo("BOT_102t", EntityType.HAND)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_539] Arcane Dynamo - COST:6 [ATK:3/HP:4]
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a spell that costs (5) or more.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("BOT_539", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.SPELL_COSTS_5_OR_MORE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_540] E.M.P. Operative - COST:5 [ATK:3/HP:3]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a Mech.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_WITH_RACE = 17
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_540", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_TARGET_WITH_RACE,17},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DestroyTask(EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_544] Loose Specimen - COST:5 [ATK:6/HP:6]
			// - Race: beast, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 6 damage randomly split among other friendly minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_544", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(6, ComplexTask.DamageRandomTargets(1, EntityType.MINIONS_NOSOURCE, 1))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_548] Zilliax - COST:5 [ATK:3/HP:2]
			// - Race: mechanical, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b><b>Divine Shield</b>, <b>Taunt</b>, Lifesteal, Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - LIFESTEAL = 1
			// - RUSH = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_548", new CardDef(new Power
			{
				PowerTask = new MagneticTask()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_550] Electrowright - COST:3 [ATK:3/HP:3]
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a spell that costs (5) or more, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_550", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, new SelfCondition(p => p.Controller.HandZone.Any(i => i is Spell && p.Cost >= 5))),
					new FlagTask(true, new AddEnchantmentTask("BOT_550e", EntityType.SOURCE)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_552] Star Aligner - COST:7 [ATK:7/HP:7]
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you control 3
			//       minions with 7 Health, deal
			//       7 damage to all enemies.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_552", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE,
						new SelfCondition(p =>
							p.Controller.BoardZone.Count(m => m.Health == 7) == 3)),
					new FlagTask(true, new DamageTask(7, EntityType.ENEMIES)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_555] Harbinger Celestia - COST:4 [ATK:5/HP:6]
			// - Fac: neutral, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>
			//       After your opponent plays
			//       a minion, become a
			//       copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("BOT_555", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = new TransformCopyTask()
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_559] Augmented Elekk - COST:3 [ATK:3/HP:4]
			// - Race: beast, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you shuffle a card into a deck, shuffle in_an extra copy.
			// --------------------------------------------------------
			cards.Add("BOT_559", new CardDef(new Power
			{
				InfoCardId = "BOT_559e",
				Trigger = new Trigger(TriggerType.SHUFFLE_INTO_DECK)
				{
					TriggerSource = TriggerSource.FRIENDLY_EVENT_SOURCE,
					SingleTask = new CopyTask(EntityType.TARGET, Zone.DECK)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_562] Coppertail Imposter - COST:4 [ATK:4/HP:4]
			// - Race: mechanical, Fac: horde, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("BOT_562", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("BOT_562e", EntityType.SOURCE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_563] Wargear - COST:5 [ATK:5/HP:5]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_563", new CardDef(new Power
			{
				PowerTask = new MagneticTask()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_573] Subject 9 - COST:5 [ATK:4/HP:4]
			// - Race: beast, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw 5 different <b>Secrets</b> from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("BOT_573", new CardDef(new Power
			{
				PowerTask = new FuncNumberTask(source =>
				{
					Dictionary<int, Spell> secrets = new Dictionary<int, Spell>();
					ReadOnlySpan<IPlayable> deck = source.Controller.DeckZone.GetSpan();
					for (int i = 0; i < deck.Length; i++)
						if (deck[i] is Spell s && s.IsSecret && !secrets.ContainsKey(s.Card.AssetId))
							secrets.Add(s.Card.AssetId, s);
					foreach (KeyValuePair<int, Spell> item in secrets)
						Generic.DrawBlock.Invoke(source.Controller, item.Value);
					return 0;
				})
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_603] Steel Rager - COST:4 [ATK:5/HP:1]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_603", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_606] Kaboom Bot - COST:3 [ATK:2/HP:2]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 4_damage to a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_606", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.DamageRandomTargets(1, EntityType.OP_MINIONS, 4)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_700] SN1P-SN4P - COST:3 [ATK:2/HP:3]
			// - Race: mechanical, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>, <b>Echo</b>
			//       <b>Deathrattle:</b> Summon two 1/1 Microbots.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - ECHO = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_700", new CardDef(new Power
			{
				PowerTask = new MagneticTask(),
				DeathrattleTask = new SummonTask("BOT_312t", 2)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_907] Galvanizer - COST:2 [ATK:1/HP:2]
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Reduce the
			//       Cost of Mechs in your
			//       hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_907", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsRace(Race.MECHANICAL)),
					new AddEnchantmentTask("BOT_907e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_914] Whizbang the Wonderful - COST:4 [ATK:4/HP:5]
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: You start the game with one of Whizbang's Wonderful Decks!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DECK_RULE_MOD_DECK_SIZE = 1
			// --------------------------------------------------------
			cards.Add("BOT_914", new CardDef(new Power
			{
				// TODO [BOT_914] Whizbang the Wonderful && Test: Whizbang the Wonderful_BOT_914
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_020e] Skaterbot (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_020e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_020e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_021e] Bronze Gatekeeper (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_021e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_021e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_035e] Venomizer (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_035e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_035e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_039e] Necromechanical (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Your <b>Deathrattles</b> trigger twice.
			// --------------------------------------------------------
			cards.Add("BOT_039e", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.EXTRA_DEATHRATTLES_BASE, EffectOperator.ADD, 1)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_079e] Illuminated (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("BOT_079e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_079e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_083e] Toxic (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("BOT_083e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_083e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_107e] Missile Launcher (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: When your turn ends, deal 1 damage to other characters.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_107e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_107e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_234e] Shrink Ray (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("BOT_234e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_234e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_237e] Beryllium Nullifier (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_237e", new CardDef(new Power
			{
				Enchant = new Enchant(
					Effects.Attack_N(0),
					Effects.Health_N(0),
					Effects.CantBeTargetedBySpellsAndHeroPowers)
				{
					UseScriptTag = true
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_238e] Boomtastic (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Your Mechs have <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("BOT_238e", new CardDef(new Power
			{
				Aura = new Aura(AuraType.BOARD, "BOT_238e2")
				{
					Condition = SelfCondition.IsRace(Race.MECHANICAL)
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_238e2] Boomtastic (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Dr. Boom is granting your Mechs <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_238e2", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.RUSH, EffectOperator.SET, 1)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_280e] Hologram (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("BOT_280e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_280e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_296e] Omega Surge (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +10 Attack.
			// --------------------------------------------------------
			cards.Add("BOT_296e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_296e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_312e] Replicating Menace (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon three 1/1 Microbots.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_312e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_312e"),
				DeathrattleTask = new SummonTask("BOT_312t", 3, SummonSide.DEATHRATTLE)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_413e] Brain Power (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("BOT_413e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_422ae] Old Growth (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("BOT_422ae", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_422ae")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_437e] Slimed (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +3/+3 and <b>Rush</b>. Dies a slimy death at the end of the turn.
			// --------------------------------------------------------
			cards.Add("BOT_437e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_437e"),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new DestroyTask(EntityType.TARGET)
				}

			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_517e] Downside Up (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Topsy Turvy.
			// --------------------------------------------------------
			cards.Add("BOT_517e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.SetAttackHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_543e] Mind Meld (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Your spells have <b>Lifesteal</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_543e", new CardDef(new Power
			{
				// TODO [BOT_543e] Mind Meld && Test: Mind Meld_BOT_543e
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_548e] Zilliax (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b><b>Divine Shield</b>, <b>Taunt</b>, Lifesteal, Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_548e", new CardDef(new Power
			{
				Enchant = new Enchant(
					Effects.Attack_N(0),
					Effects.Health_N(0),
					new Effect(GameTag.DIVINE_SHIELD, EffectOperator.SET, 1),
					Effects.TauntEff,
					Effects.Lifesteal,
					Effects.Rush)
				{
					UseScriptTag = true
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_550e] Electrified (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("BOT_550e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_550e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_559e] Dealing (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_559e", new CardDef(new Power
			{
				// TODO [BOT_559e] Dealing && Test: Dealing_BOT_559e
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_562e] Disguised (*) - COST:0
			// - Fac: horde, Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Stealthed</b> until your next turn.
			// --------------------------------------------------------
			cards.Add("BOT_562e", new CardDef(Power.OneTurnStealthEnchantmentPower));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_563e] Wargear (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_563e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_563e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_700e] SN1P-SN4P (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 1/1 Microbots.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_700e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_700e"),
				DeathrattleTask = new SummonTask("BOT_312t", 3, SummonSide.DEATHRATTLE)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_906e] Glow-Tron (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_906e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("BOT_906e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_907e] Galvanized (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("BOT_907e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.ReduceCost(1))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_066t] Mechanical Dragon (*) - COST:7 [ATK:7/HP:7]
			// - Race: mechanical, Fac: neutral, Set: boomsday,
			// --------------------------------------------------------
			cards.Add("BOT_066t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_102t] Spark (*) - COST:1 [ATK:1/HP:1]
			// - Race: elemental, Fac: neutral, Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_102t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_270t] Annoy-o-Tron (*) - COST:2 [ATK:1/HP:2]
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("BOT_270t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_312t] Microbot (*) - COST:1 [ATK:1/HP:1]
			// - Race: mechanical, Set: boomsday,
			// --------------------------------------------------------
			cards.Add("BOT_312t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_445t] Jo-E Bot (*) - COST:1 [ATK:1/HP:1]
			// - Race: mechanical, Fac: neutral, Set: boomsday,
			// --------------------------------------------------------
			cards.Add("BOT_445t", new CardDef());

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOT_511t] Bomb (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: [x]You take 5 damage.
			//       Draw a card. This
			//       explodes when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("BOT_511t", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(5, EntityType.HERO),
					new DrawTask()),
				TopdeckTask = ComplexTask.Create(
					new DamageTask(5, EntityType.HERO),
					new DrawTask())
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
			WarlockNonCollect(cards);
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
