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
using SabberStoneCore.Auras;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Triggers;
using SabberStoneCore.src.Loader;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets
{
	public static class LootapaloozaCardsGen
	{
		private static void Druid(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [LOOT_048] Ironwood Golem - COST:4 [ATK:3/HP:6]
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Can only attack if you have 3 or more Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_048", new CardDef(new Power
			{
				//Aura = new AdaptiveEffect(GameTag.CANT_ATTACK, EffectOperator.SET, p => p.Controller.Hero.Armor > 2 ? 0 : 1)
				Aura = new AdaptiveEffect(new SelfCondition(p => p.Controller.Hero.Armor <= 3), GameTag.CANT_ATTACK)
			}));

			// ----------------------------------------- MINION - DRUID
			// [LOOT_056] Astral Tiger - COST:4 [ATK:3/HP:5]
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle a
			//        copy of this minion into_your_deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_056", new CardDef(new Power
			{
				DeathrattleTask = new AddCardTo("LOOT_056", EntityType.DECK)
			}));

			// ----------------------------------------- MINION - DRUID
			// [LOOT_314] Grizzled Guardian - COST:8 [ATK:3/HP:5]
			// - Race: beast, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> <b>Recruit</b> 2_minions that cost (4)_or_less.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_314", new CardDef(new Power
			{
				DeathrattleTask = new RecruitTask(2, SelfCondition.IsTagValue(GameTag.COST, 4, RelaSign.LEQ))
			}));

			// ----------------------------------------- MINION - DRUID
			// [LOOT_329] Ixlid, Fungal Lord - COST:5 [ATK:2/HP:4]
			// - Race: elemental, Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you play a minion, summon a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - 717 = 1
			// --------------------------------------------------------
			cards.Add("LOOT_329", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new SummonCopyTask(EntityType.EVENT_SOURCE)
				}
			}));

			// ----------------------------------------- MINION - DRUID
			// [LOOT_351] Greedy Sprite - COST:3 [ATK:3/HP:1]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Gain an empty Mana Crystal.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_351", new CardDef(new Power
			{
				DeathrattleTask = new ManaCrystalEmptyTask(1)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_047] Barkskin - COST:1
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +3 Health. Gain 3 Armor.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOOT_047", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("LOOT_047e", EntityType.TARGET),
					new ArmorTask(3))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_051] Lesser Jasper Spellstone - COST:1
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. @<i>(Gain 3 Armor to upgrade.)</i> @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - ARMOR = 1
			// --------------------------------------------------------
			cards.Add("LOOT_051", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET),
				Trigger = new Trigger(TriggerType.ARMOR)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					TriggerActivation = TriggerActivation.HAND,
					FastExecution = true,
					SingleTask = ComplexTask.ProgressSpellStoneUpdateUsingEventNumber("LOOT_051t1")
				}
			}));

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_054] Branching Paths - COST:4
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Choose Twice -</b> Draw a
			//       card; Give your minions
			//       +1 Attack; Gain 6 Armor.
			// --------------------------------------------------------
			// Entourage: LOOT_054d, LOOT_054b, LOOT_054c
			// --------------------------------------------------------
			cards.Add("LOOT_054", new CardDef(new[] {"LOOT_054d","LOOT_054b","LOOT_054c"}, new Power
			{
				PowerTask = new EnqueueTask(2, new DiscoverTask(DiscoverType.BRANCHING_PATHS))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_309] Oaken Summons - COST:4
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 6 Armor.
			//       <b>Recruit</b> a minion that costs (4) or less.
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_309", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ArmorTask(6),
					new RecruitTask(1, SelfCondition.IsTagValue(GameTag.COST, 4, RelaSign.LEQ)))
			}));

			// ----------------------------------------- WEAPON - DRUID
			// [LOOT_392] Twig of the World Tree - COST:4 [ATK:1/HP:0]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Gain 10 Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 5
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_392", new CardDef(new Power
			{
				DeathrattleTask = new ManaCrystalFullTask(10)
			}));

		}

		private static void DruidNonCollect(Dictionary<string, CardDef> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [LOOT_051t1] Jasper Spellstone (*) - COST:1
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $4 damage to a minion. @ @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - ARMOR = 1
			// --------------------------------------------------------
			cards.Add("LOOT_051t1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(4, EntityType.TARGET),
				Trigger = new Trigger(TriggerType.ARMOR)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					TriggerActivation = TriggerActivation.HAND,
					FastExecution = true,
					SingleTask = ComplexTask.ProgressSpellStoneUpdateUsingEventNumber("LOOT_051t2")
				}
			}));

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_051t2] Greater Jasper Spellstone (*) - COST:1
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $6 damage to a minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOOT_051t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(6, EntityType.TARGET, true)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_054b] Explore the Darkness (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Give your minions +1 Attack.
			// --------------------------------------------------------
			cards.Add("LOOT_054b", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("LOOT_054be", EntityType.MINIONS)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_054c] Loot the Chest (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Gain 6 Armor.
			// --------------------------------------------------------
			cards.Add("LOOT_054c", new CardDef(new Power
			{
				PowerTask = new ArmorTask(6)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_054d] Eat the Mushroom (*) - COST:0
			// - Fac: neutral, Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Draw a card.
			// --------------------------------------------------------
			cards.Add("LOOT_054d", new CardDef(new Power
			{
				PowerTask = new DrawTask()
			}));

		}

		private static void Hunter(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [LOOT_078] Cave Hydra - COST:3 [ATK:2/HP:4]
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever
			//       this attacks.
			// --------------------------------------------------------
			cards.Add("LOOT_078", new CardDef(new Power
			{
				// TODO Test: Cave Hydra_LOOT_078
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					Condition = SelfCondition.IsProposedDefender(CardType.MINION),
					TriggerSource = TriggerSource.SELF,
					SingleTask = ComplexTask.Create(
						new FuncNumberTask(p =>
						{
							//Minion target = (Minion)p.Game.IdEntityDic[p.Game.ProposedDefender];
							Minion target = (Minion)p.Game.CurrentEventData.EventTarget;
							foreach (Minion adjacent in target.GetAdjacentMinions())
								adjacent.TakeDamage(p, ((Minion)p).AttackDamage);
							return 0;
						}))
				}
			}));

			// ---------------------------------------- MINION - HUNTER
			// [LOOT_511] Kathrena Winterwisp - COST:8 [ATK:6/HP:6]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b> <b>Recruit</b> a Beast.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_511", new CardDef(new Power
			{
				PowerTask = new RecruitTask(1, SelfCondition.IsRace(Race.BEAST)),
				DeathrattleTask = new RecruitTask(1, SelfCondition.IsRace(Race.BEAST))
			}));

			// ---------------------------------------- MINION - HUNTER
			// [LOOT_520] Seeping Oozeling - COST:6 [ATK:5/HP:4]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain the <b>Deathrattle</b> of a random minion in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_520", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsDeathrattleMinion),
					new RandomTask(1, EntityType.STACK),
					new CopyTask(EntityType.STACK, Zone.SETASIDE, addToStack: true),
					new GetGameTagTask(GameTag.ENTITY_ID, EntityType.STACK),
					new AddEnchantmentTask("LOOT_520e", EntityType.SOURCE, false, true))
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_077] Flanking Strike - COST:4
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage to a minion. Summon a 3/3 Wolf. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_077", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(3, EntityType.TARGET, true),
					new SummonTask("LOOT_077t", SummonSide.SPELL))
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_079] Wandering Monster - COST:2
			// - Fac: neutral, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy attacks your hero, summon a 3-Cost minion as the new target.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOOT_079", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					Condition = SelfCondition.IsProposedDefender(CardType.HERO),
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsNotBoardFull),
						new FlagTask(true, ComplexTask.Secret(
						new RandomMinionTask(GameTag.COST, 3),
						new SummonTask(),
						new ChangeAttackingTargetTask(EntityType.TARGET, EntityType.STACK))))
				}
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_080] Lesser Emerald Spellstone - COST:5
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon two 3/3_Wolves. <i>(Play a <b>Secret</b> to upgrade.)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_080", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new SummonTask("LOOT_077t", 2),
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsSecret,
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = new ChangeEntityTask("LOOT_080t2"),
					RemoveAfterTriggered = true
				}
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_217] To My Side! - COST:6
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Summon an Animal
			//       Companion, or 2 if your
			//       deck has no minions.
			// --------------------------------------------------------
			// Entourage: NEW1_032, NEW1_033, NEW1_034
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_217", new CardDef(new[] {"NEW1_032","NEW1_033","NEW1_034"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasNoMinionInDeck),
					new FlagTask(true, ComplexTask.Create(
						new RandomEntourageTask(2),
						new SummonStackTask())),
					new FlagTask(false, ComplexTask.Create(
						new RandomEntourageTask(),
						new SummonTask())))
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_522] Crushing Walls - COST:7
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy your opponent's left and right-most minions.
			// --------------------------------------------------------
			cards.Add("LOOT_522", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.SOURCE),
					new FuncPlayablesTask(p =>
					{
						BoardZone board = p[0].Controller.Opponent.BoardZone;
						if (board.Count == 0)
							return new List<IPlayable>(0);
						if (board.Count < 3)
							return board.GetAll().Cast<IPlayable>().ToList();

						var list = new List<IPlayable>(2);
						if (!board[0].Untouchable)
							list.Add(board[0]);
						if (!board[board.Count - 1].Untouchable)
							list.Add(board[board.Count - 1]);

						return list;
					}),
					new DestroyTask(EntityType.STACK))
			}));

			// ---------------------------------------- WEAPON - HUNTER
			// [LOOT_085] Rhok'delar - COST:7 [ATK:4/HP:0]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no minions, fill your_hand with Hunter_spells.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_085", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasNoMinionInDeck),
					new FlagTask(true, ComplexTask.Create(
						new FuncNumberTask(p => p.Controller.HandZone.Count),
						new MathNumberIndexTask(0, 1, MathOperation.ADD, 1),
						new FuncNumberTask(new Func<IPlayable, int>(p => Controller.MaxHandSize)),
						new MathNumberIndexTask(0, 1, MathOperation.SUB),
						new EnqueueNumberTask(
							ComplexTask.Create(
								new RandomCardTask(CardType.SPELL, CardClass.HUNTER),
								new AddStackTo(EntityType.HAND))))))
			}));

			// ---------------------------------------- WEAPON - HUNTER
			// [LOOT_222] Candleshot - COST:1 [ATK:1/HP:0]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Immune</b> while attacking.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("LOOT_222", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = new AddEnchantmentTask("DS1_188e", EntityType.HERO)
				}
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [LOOT_077t] Wolf (*) - COST:3 [ATK:3/HP:3]
			// - Race: beast, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_077t", new CardDef());

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_080t2] Emerald Spellstone (*) - COST:5
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon three 3/3_Wolves. <i>(Play a <b>Secret</b> to upgrade.)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_080t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new SummonTask("LOOT_077t", 3),
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsSecret,
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = new ChangeEntityTask("LOOT_080t3"),
					RemoveAfterTriggered = true
				}
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_080t3] Greater Emerald Spellstone (*) - COST:5
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon four 3/3_Wolves.
			// --------------------------------------------------------
			cards.Add("LOOT_080t3", new CardDef(new Power
			{
				PowerTask = new SummonTask("LOOT_077t", 4)
			}));

		}

		private static void Mage(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [LOOT_170] Raven Familiar - COST:2 [ATK:2/HP:2]
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a spell in each deck. If yours costs more, draw it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1d
			// --------------------------------------------------------
			cards.Add("LOOT_170", new CardDef(new Power
			{
				PowerTask = new RevealTask(new DrawStackTask(), null, CardType.SPELL)
			}));

			// ------------------------------------------ MINION - MAGE
			// [LOOT_231] Arcane Artificer - COST:1 [ATK:1/HP:2]
			// - Race: elemental, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain Armor equal to its_Cost.
			// --------------------------------------------------------
			cards.Add("LOOT_231", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = ComplexTask.Create(
						new GetGameTagTask(GameTag.TAG_LAST_KNOWN_COST_IN_HAND, EntityType.TARGET),
						new ArmorTask())
				}
			}));

			// ------------------------------------------ MINION - MAGE
			// [LOOT_535] Dragoncaller Alanna - COST:9 [ATK:3/HP:3]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 5/5 Dragon for each spell you cast this game that costs (5) or more.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_535", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new FuncNumberTask(p =>
						{
							int number = Math.Min(p.Controller.PlayHistory.Count(x => x.SourceCard.Cost >= 5 && x.SourceCard.Type == CardType.SPELL),
								p.Controller.BoardZone.FreeSpace);
							return number == 0 ? 0 : number % 2 == 0 ? number / 2 : (number / 2) + 1;
						}),
					new EnqueueNumberTask(ComplexTask.Create(
						new SummonTask("LOOT_535t", SummonSide.LEFT),
						new SummonTask("LOOT_535t", SummonSide.RIGHT))))
			}));

			// ------------------------------------------ MINION - MAGE
			// [LOOT_537] Leyline Manipulator - COST:4 [ATK:4/HP:5]
			// - Race: elemental, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding any cards that didn't start in your deck, reduce their Cost by (2).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_537", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsNotStartInDeck),
					new AddAuraEffect(Effects.ReduceCost(2), EntityType.STACK))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_101] Explosive Runes - COST:3
			// - Fac: neutral, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, deal $6 damage to it and any excess to their hero. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("LOOT_101", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					SingleTask = SpecificTask.ExplosiveRunes
				}
			}));

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_103] Lesser Ruby Spellstone - COST:2
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Add 1 random Mage spell to your hand. @<i>(Play 2 Elementals to_upgrade.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// --------------------------------------------------------
			cards.Add("LOOT_103", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomCardTask(CardType.SPELL, CardClass.MAGE),
					new AddStackTo(EntityType.HAND)),
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					TriggerActivation = TriggerActivation.HAND,
					Condition = SelfCondition.IsRace(Race.ELEMENTAL),
					SingleTask = ComplexTask.ProgressSpellStoneUpdate("LOOT_103t1")
				}
			}));

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_104] Shifting Scroll - COST:0
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Each turn this is in your hand, transform it into a random Mage spell.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - 73 = 0
			// --------------------------------------------------------
			cards.Add("LOOT_104", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_CANNOT_PLAY_THIS,0}}, new Power
			{
				// TODO Test: Shifting Scroll_LOOT_104
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = ComplexTask.Create(
						new ChangeEntityTask(EntityType.SOURCE, CardType.SPELL, CardClass.MAGE, removeEnchantments: true),
						new AddEnchantmentTask("LOOT_104e", EntityType.SOURCE))
				}
			}));

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_106] Deck of Wonders - COST:5
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle 5 Scrolls into your deck. When drawn, cast a random spell.
			// --------------------------------------------------------
			cards.Add("LOOT_106", new CardDef(new Power
			{
				PowerTask = new AddCardTo("LOOT_106t", EntityType.DECK, 5)
			}));

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_172] Dragon's Fury - COST:5
			// - Fac: neutral, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Reveal a spell from your deck. Deal damage equal to its Cost to all_minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("LOOT_172", new CardDef(new Power
			{
				// TODO RevealCardBlock
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsSpell),
					new RandomTask(1, EntityType.STACK),
					new GetGameTagTask(GameTag.COST, EntityType.STACK),
					new DamageNumberTask(EntityType.ALLMINIONS, true))
			}));

			// ------------------------------------------ WEAPON - MAGE
			// [LOOT_108] Aluneth - COST:6
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("LOOT_108", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new DrawTask(3)
				}
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [LOOT_104e] Shifting (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Transforming into random Mage spells.
			// --------------------------------------------------------
			cards.Add("LOOT_104e", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.SHIFTING, EffectOperator.SET, 1)
				{
					RemoveWhenPlayed = true
				},
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = ComplexTask.Create(
						new ChangeEntityTask(EntityType.TARGET, CardType.SPELL, CardClass.MAGE, removeEnchantments: true),
						new AddEnchantmentTask("LOOT_104e", EntityType.TARGET))
				}
			}));

			// ------------------------------------------ MINION - MAGE
			// [LOOT_535t] Fire Dragon (*) - COST:5 [ATK:5/HP:5]
			// - Race: dragon, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_535t", new CardDef());

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_103t1] Ruby Spellstone (*) - COST:2
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Add 2 random Mage spells to your hand.
			//       @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// --------------------------------------------------------
			cards.Add("LOOT_103t1", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(2, ComplexTask.Create(
					new RandomCardTask(CardType.SPELL, CardClass.MAGE),
					new AddStackTo(EntityType.HAND))),
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					TriggerActivation = TriggerActivation.HAND,
					Condition = SelfCondition.IsRace(Race.ELEMENTAL),
					SingleTask = ComplexTask.ProgressSpellStoneUpdate("LOOT_103t2")
					//SingleTask = ComplexTask.Create(
					//	new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
					//	new NumberConditionTask(0, RelaSign.EQ),    //	is NUM_1 is equal to 0 ?
					//	new FlagTask(true, new SetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, 1, EntityType.SOURCE)),
					//	new FlagTask(false, ComplexTask.Create(
					//		new SetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, 0, EntityType.SOURCE),
					//		new ChangeEntityTask("LOOT_103t2"))))
				}
			}));

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_103t2] Greater Ruby Spellstone (*) - COST:2
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Add 3 random Mage spells to your hand.
			// --------------------------------------------------------
			cards.Add("LOOT_103t2", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(3, ComplexTask.Create(
					new RandomCardTask(CardType.SPELL, CardClass.MAGE),
					new AddStackTo(EntityType.HAND)))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_106t] Scroll of Wonder (*) - COST:5
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Cast a random spell. Draw a card.
			//       Cast this when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("LOOT_106t", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new CastRandomSpellTask(phaseShift: false),
					new DrawTask()),
				TopdeckTask = ComplexTask.Create(
					new CastRandomSpellTask(phaseShift: false),
					new DrawTask())
			}));

		}

		private static void Paladin(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [LOOT_216] Lynessa Sunsorrow - COST:7 [ATK:1/HP:1]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Cast each spell
			//       you cast on your minions
			//        this game on this one.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_216", new CardDef(new Power
			{
				// TODO Verify with Power.Log
				// TODO Should revise this implementation
				// TODO [LOOT_216] Lynessa Sunsorrow && Test: Lynessa Sunsorrow_LOOT_216
				InfoCardId = "LOOT_216e",
				PowerTask = SpecificTask.LynessaSunsorrow
			}));

			// --------------------------------------- MINION - PALADIN
			// [LOOT_313] Crystal Lion - COST:6 [ATK:5/HP:5]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>
			//       Costs (1) less for each Silver
			//       Hand Recruit you control.
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_313", new CardDef(new Power
			{
				Aura = new AdaptiveCostEffect(p => p.Controller.BoardZone.GetAll(q => q.Card.Id.Equals("CS2_101t")).Length)
			}));

			// --------------------------------------- MINION - PALADIN
			// [LOOT_363] Drygulch Jailor - COST:2 [ATK:1/HP:1]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add 3 Silver_Hand Recruits to_your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_363", new CardDef(new Power
			{
				DeathrattleTask = new AddCardTo("CS2_101t", EntityType.HAND, 3)
			}));

			// --------------------------------------- MINION - PALADIN
			// [LOOT_398] Benevolent Djinn - COST:3 [ATK:2/HP:4]
			// - Race: elemental, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 3 Health to your_hero.
			// --------------------------------------------------------
			cards.Add("LOOT_398", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new HealTask(3, EntityType.HERO)
				}
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_088] Potion of Heroism - COST:2
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion <b>Divine_Shield</b>.
			//       Draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_088", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					ComplexTask.DivineShield(EntityType.TARGET),
					new DrawTask())
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_091] Lesser Pearl Spellstone - COST:2
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 2/2 Spirit with <b>Taunt</b>. @<i>(Restore 3 Health to upgrade.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - HEALTH = 1
			// --------------------------------------------------------
			cards.Add("LOOT_091", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new SummonTask("LOOT_091t"),
				Trigger = new Trigger(TriggerType.HEAL)
				{
					TriggerSource = TriggerSource.HERO,
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = ComplexTask.Create(
						new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
						new GetEventNumberTask(1),
						new MathNumberIndexTask(0, 1, MathOperation.ADD),
						new SetGameTagNumberTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
						new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_2, EntityType.SOURCE, 0, 1),
						new NumberConditionTask(RelaSign.GEQ),
						new FlagTask(true, ComplexTask.Create(
							new SetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, 0, EntityType.SOURCE),
							new ChangeEntityTask("LOOT_091t1"))))
				}
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_093] Call to Arms - COST:5
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Recruit</b> 3 minions that
			//        cost (2) or less.
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_093", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new RecruitTask(3, SelfCondition.IsTagValue(GameTag.COST, 2, RelaSign.LEQ))
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_333] Level Up! - COST:5
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Give your Silver Hand Recruits +2/+2 and_<b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 717 = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_333", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsSilverHandRecruit),
					new AddEnchantmentTask("LOOT_333e", EntityType.STACK))
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_286] Unidentified Maul - COST:3 [ATK:2/HP:0]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Gains a bonus effect in_your hand.
			// --------------------------------------------------------
			// Entourage: LOOT_286t2, LOOT_286t3, LOOT_286t1, LOOT_286t4
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("LOOT_286", new CardDef(new[] {"LOOT_286t2","LOOT_286t3","LOOT_286t1","LOOT_286t4"}, new Power
			{
				// TODO Test: Unidentified Maul_LOOT_286
				InfoCardId = "LOOT_286t3e",
				Trigger = TriggerLibrary.RevealUnidentifiedItem
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_500] Val'anyr - COST:6 [ATK:4/HP:0]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give a minion in your hand +4/+2. When it dies, reequip this.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_500", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "LOOT_500e")
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [LOOT_091t] Guardian Spirit (*) - COST:2 [ATK:2/HP:2]
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_091t", new CardDef());

			// --------------------------------------- MINION - PALADIN
			// [LOOT_091t1t] Guardian Spirit (*) - COST:4 [ATK:4/HP:4]
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_091t1t", new CardDef());

			// --------------------------------------- MINION - PALADIN
			// [LOOT_091t2t] Guardian Spirit (*) - COST:6 [ATK:6/HP:6]
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_091t2t", new CardDef());

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_091t1] Pearl Spellstone (*) - COST:2
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 4/4 Spirit with <b>Taunt</b>. @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - HEALTH = 1
			// --------------------------------------------------------
			cards.Add("LOOT_091t1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new SummonTask("LOOT_091t1t"),
				Trigger = new Trigger(TriggerType.HEAL)
				{
					TriggerSource = TriggerSource.HERO,
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = ComplexTask.Create(
						new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
						new GetEventNumberTask(1),
						new MathNumberIndexTask(0, 1, MathOperation.ADD),
						new SetGameTagNumberTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
						new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_2, EntityType.SOURCE, 0, 1),
						new NumberConditionTask(RelaSign.GEQ),
						new FlagTask(true, ComplexTask.Create(
							new SetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, 0, EntityType.SOURCE),
							new ChangeEntityTask("LOOT_091t2"))))
				}
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_091t2] Greater Pearl Spellstone (*) - COST:2
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 6/6 Spirit with <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_091t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new SummonTask("LOOT_091t2t")
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_286t1] Champion's Maul (*) - COST:3 [ATK:2/HP:0]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/1 Silver Hand Recruits.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_286t1", new CardDef(new Power
			{
				PowerTask = new SummonTask("CS2_101t", 2)
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_286t2] Sacred Maul (*) - COST:3 [ATK:2/HP:0]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your minions <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_286t2", new CardDef(new Power
			{
				PowerTask = ComplexTask.Taunt(EntityType.MINIONS)
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_286t3] Blessed Maul (*) - COST:3 [ATK:2/HP:0]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your minions +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_286t3", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("LOOT_286t3e", EntityType.MINIONS)
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_286t4] Purifier's Maul (*) - COST:3 [ATK:2/HP:0]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your minions <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_286t4", new CardDef(new Power
			{
				PowerTask = ComplexTask.DivineShield(EntityType.MINIONS)
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_500d] Val'anyr Reequip Effect Dummy (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: It is a dummy card for holding a effect to play when reequipping Val'anyr (LOOT_500)
			// --------------------------------------------------------
			cards.Add("LOOT_500d", new CardDef(new Power
			{
				// TODO [LOOT_500d] Val'anyr Reequip Effect Dummy && Test: Val'anyr Reequip Effect Dummy_LOOT_500d
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Priest(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [LOOT_410] Duskbreaker - COST:4 [ATK:3/HP:3]
			// - Race: dragon, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding
			//       a Dragon, deal 3 damage to all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_410", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true,
						new DamageTask(3, EntityType.ALLMINIONS_NOSOURCE)))
			}));

			// ---------------------------------------- MINION - PRIEST
			// [LOOT_528] Twilight Acolyte - COST:3 [ATK:2/HP:4]
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding
			//       a Dragon, swap this minion's Attack with another minion's.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// --------------------------------------------------------
			cards.Add("LOOT_528", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
						new GetGameTagTask(GameTag.ATK, EntityType.SOURCE),
						new GetGameTagTask(GameTag.ATK, EntityType.TARGET, 0, 2),
						new AddEnchantmentTask("LOOT_528e", EntityType.TARGET, true),
						new FuncNumberTask(function: p => 0),
						new MathNumberIndexTask(3, 2, MathOperation.ADD),
						new AddEnchantmentTask("LOOT_528e", EntityType.SOURCE, true))
			}));

			// ---------------------------------------- MINION - PRIEST
			// [LOOT_534] Gilded Gargoyle - COST:3 [ATK:2/HP:2]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a Coin to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_534", new CardDef(new Power
			{
				DeathrattleTask = new AddCardTo("GAME_005", EntityType.HAND)
			}));

			// ---------------------------------------- MINION - PRIEST
			// [LOOT_538] Temporus - COST:7 [ATK:6/HP:6]
			// - Race: dragon, Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your opponent takes two turns. Then you take two turns.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_538", new CardDef(new Power
			{
				PowerTask = new FuncNumberTask(p =>
				{
					p.Controller.TemporusFlag = true;
					p.Controller.Opponent.TemporusFlag = true;
					return 0;
				})
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_008] Psychic Scream - COST:7
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle all minions into your opponent's deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_008", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS),
					new MoveToDeck(EntityType.STACK))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_187] Twilight's Call - COST:3
			// - Fac: neutral, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 1/1 copies of 2 friendly <b>Deathrattle</b> minions
			//       that died this game.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			cards.Add("LOOT_187", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_MINION_DIED_THIS_GAME,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.GRAVEYARD),
					new FilterStackTask(SelfCondition.IsDeathrattleMinion, SelfCondition.IsTagValue(GameTag.TO_BE_DESTROYED, 1)),
					new RandomTask(2, EntityType.STACK),
					new CopyTask(EntityType.STACK, Zone.PLAY, addToStack: true),
					new AddEnchantmentTask("LOOT_187e", EntityType.STACK))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_278] Unidentified Elixir - COST:3
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2/+2. Gains a bonus effect in_your hand.
			// --------------------------------------------------------
			// Entourage: LOOT_278t1, LOOT_278t2, LOOT_278t3, LOOT_278t4
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_278", new CardDef(new[] {"LOOT_278t1","LOOT_278t2","LOOT_278t3","LOOT_278t4"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("LOOT_278e", EntityType.TARGET),
				Trigger = TriggerLibrary.RevealUnidentifiedItem
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_353] Psionic Probe - COST:1
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Copy a spell in your opponent's deck and add it to your hand.
			// --------------------------------------------------------
			cards.Add("LOOT_353", new CardDef(new Power
			{
				// TODO Test: Psionic Probe_LOOT_353
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.OP_DECK),
					new FilterStackTask(SelfCondition.IsSpell),
					new RandomTask(1, EntityType.STACK),
					new CopyTask(EntityType.STACK, Zone.HAND))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_507] Lesser Diamond Spellstone - COST:7
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Resurrect 2 different friendly minions. @<i>(Cast 4 spells to upgrade.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 4
			// --------------------------------------------------------
			cards.Add("LOOT_507", new CardDef(new Power
			{
				// Test: Lesser Diamond Spellstone_LOOT_507
				PowerTask = SpecificTask.DiamondSpellstone(2),
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = ComplexTask.ProgressSpellStoneUpdate("LOOT_507t")
				}
			}));

			// ---------------------------------------- WEAPON - PRIEST
			// [LOOT_209] Dragon Soul - COST:3
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you cast 3 spells in a turn, summon a 5/5 Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("LOOT_209", new CardDef(new Power
			{
				Trigger = new MultiTrigger(
					new Trigger(TriggerType.CAST_SPELL)
					{
						TriggerSource = TriggerSource.FRIENDLY,
						SingleTask = ComplexTask.Create(
							new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
							new MathAddTask(1),
							new SetGameTagNumberTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
							new SetGameTagNumberTask(GameTag.CUSTOM_KEYWORD_EFFECT, EntityType.SOURCE),
							new NumberConditionTask(3, RelaSign.EQ),
							new FlagTask(true, ComplexTask.Create(
								new SummonTask("LOOT_209t"),
								new SetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, 0, EntityType.SOURCE),
								new SetGameTagTask(GameTag.CUSTOM_KEYWORD_EFFECT, 0, EntityType.SOURCE))))
					},
					new Trigger(TriggerType.TURN_END)
					{
						SingleTask = ComplexTask.Create(
							new SetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, 0, EntityType.SOURCE),
							new SetGameTagTask(GameTag.CUSTOM_KEYWORD_EFFECT, 0, EntityType.SOURCE))
					})
			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [LOOT_538e] Time Spiraling (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Take an extra turn.
			// --------------------------------------------------------
			cards.Add("LOOT_538e", new CardDef(new Power
			{
				// TODO [LOOT_538e] Time Spiraling && Test: Time Spiraling_LOOT_538e
				InfoCardId = "LOOT_538e2",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [LOOT_538e2] Revenge (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Take an extra turn.
			// --------------------------------------------------------
			cards.Add("LOOT_538e2", new CardDef(new Power
			{
				// TODO [LOOT_538e2] Revenge && Test: Revenge_LOOT_538e2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [LOOT_209t] Dragon Spirit (*) - COST:5 [ATK:5/HP:5]
			// - Race: dragon, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_209t", new CardDef());

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_278t1] Elixir of Life (*) - COST:3
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2/+2 and <b>Lifesteal</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_278t1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("LOOT_278t1e", EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_278t2] Elixir of Purity (*) - COST:3
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2/+2 and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_278t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("LOOT_278t2e", EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_278t3] Elixir of Shadows (*) - COST:3
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2/+2. Summon a 1/1 copy of_it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_278t3", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("LOOT_278t3e", EntityType.TARGET),
					new CopyTask(EntityType.TARGET, Zone.PLAY, addToStack: true),
					new AddEnchantmentTask("LOOT_278t3e2", EntityType.STACK))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_278t4] Elixir of Hope (*) - COST:3
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Give a minion +2/+2
			//       and "<b>Deathrattle:</b> Return
			//       this minion to your hand."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_278t4", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("LOOT_278t4e", EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_507t] Diamond Spellstone (*) - COST:7
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Resurrect 3 different friendly minions. @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 4
			// --------------------------------------------------------
			cards.Add("LOOT_507t", new CardDef(new Power
			{
				PowerTask = SpecificTask.DiamondSpellstone(3),
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = ComplexTask.ProgressSpellStoneUpdate("LOOT_507t2")
				}
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_507t2] Greater Diamond Spellstone (*) - COST:7
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Resurrect 4 different friendly minions.
			// --------------------------------------------------------
			cards.Add("LOOT_507t2", new CardDef(new Power
			{
				PowerTask = SpecificTask.DiamondSpellstone(4)
			}));

		}

		private static void Rogue(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [LOOT_026] Fal'dorei Strider - COST:4 [ATK:4/HP:4]
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Shuffle 3
			//       Ambushes into your deck.
			//       When drawn, summon
			//       a 4/4 Spider.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// -------------------------------------0-------------------
			cards.Add("LOOT_026", new CardDef(new Power
			{
				// Not sure this implementatio would work in servers
				PowerTask = new AddCardTo("LOOT_026e", EntityType.DECK, 3)
			}));

			// ----------------------------------------- MINION - ROGUE
			// [LOOT_033] Cavern Shinyfinder - COST:2 [ATK:3/HP:1]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a weapon from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_033", new CardDef(new Power
			{
				// TODO Test: Cavern Shinyfinder_LOOT_033
				PowerTask = ComplexTask.DrawFromDeck(1, SelfCondition.IsWeapon)
			}));

			// ----------------------------------------- MINION - ROGUE
			// [LOOT_165] Sonya Shadowdancer - COST:3 [ATK:2/HP:2]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: After a friendly minion dies, add a 1/1 copy of it to your hand. It costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_165", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = ComplexTask.Create(
						new CopyTask(EntityType.TARGET, Zone.HAND, addToStack: true),
						new AddEnchantmentTask("LOOT_165e", EntityType.STACK),
						new AddAuraEffect(Effects.SetCost(1), EntityType.STACK))
				}
			}));

			// ----------------------------------------- MINION - ROGUE
			// [LOOT_211] Elven Minstrel - COST:4 [ATK:3/HP:2]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Draw 2 minions from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_211", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO Test: Elven Minstrel_LOOT_211
				ComboTask = ComplexTask.DrawFromDeck(2, SelfCondition.IsMinion)
			}));

			// ----------------------------------------- MINION - ROGUE
			// [LOOT_412] Kobold Illusionist - COST:4 [ATK:3/HP:3]
			// - Fac: alliance, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 1/1 copy of a minion from your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_412", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new CopyTask(EntityType.STACK, Zone.PLAY, addToStack: true),
					new AddEnchantmentTask("LOOT_412e", EntityType.STACK))
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_204] Cheat Death - COST:2
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a friendly minion dies, return it to your hand.
			//       It costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOOT_204", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = ComplexTask.Secret(
						new ReturnHandTask(EntityType.TARGET),
						new AddEnchantmentTask("LOOT_204e", EntityType.TARGET))
				}
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_210] Sudden Betrayal - COST:2
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a minion attacks your hero, instead it attacks one of_its neighbors.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOOT_210", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					Condition = SelfCondition.IsProposedDefender(CardType.HERO),
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.TARGET, SelfCondition.IsBoardCount(1)),
						new FlagTask(false, ComplexTask.Secret(
							new IncludeAdjacentTask(EntityType.TARGET),
							new RandomTask(1, EntityType.STACK),
							new ChangeAttackingTargetTask(EntityType.TARGET, EntityType.STACK))))
				}
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_214] Evasion - COST:2
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your hero takes damage, become <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOOT_214", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = ComplexTask.Secret(
						new AddEnchantmentTask("LOOT_214e", EntityType.HERO))
				}
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_503] Lesser Onyx Spellstone - COST:5
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy 1 random enemy minion.
			//       @<i>(Play 3 <b>Deathrattle</b> cards to upgrade.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_503", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				// TODO Test: Lesser Onyx Spellstone_LOOT_503
				PowerTask = ComplexTask.DestroyRandomTargets(1, EntityType.OP_MINIONS),
				Trigger = new Trigger(TriggerType.PLAY_CARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					TriggerActivation = TriggerActivation.HAND,
					Condition = SelfCondition.IsDeathrattleCard,
					SingleTask = ComplexTask.ProgressSpellStoneUpdate("LOOT_503t")
				}
			}));

			// ----------------------------------------- WEAPON - ROGUE
			// [LOOT_542] Kingsbane - COST:1 [ATK:1/HP:3]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Shuffle
			//       this into your deck.
			//       It keeps any
			//       enchantments.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// - DEATHRATTLE = 1
			// - 851 = 1
			// --------------------------------------------------------
			cards.Add("LOOT_542", new CardDef(new Power
			{
				DeathrattleTask = SpecificTask.Kingsbane
			}));

		}

		private static void RogueNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [LOOT_542e] Kingsbane Shuffle (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Getting ready to shuffle in.
			// --------------------------------------------------------
			cards.Add("LOOT_542e", new CardDef(new Power
			{
				// Can't find this in logs
			}));

			// ----------------------------------------- MINION - ROGUE
			// [LOOT_026t] Leyline Spider (*) - COST:4 [ATK:4/HP:4]
			// - Race: beast, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_026t", new CardDef());

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_026e] Spider Ambush! (*) - COST:4
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Summon a 4/4 Spider. Draw a card.
			//       Cast this when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("LOOT_026e", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonTask("LOOT_026t"),
					new DrawTask()),
				TopdeckTask = ComplexTask.Create(
					new SummonTask("LOOT_026t"),
					new DrawTask())
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_503t] Onyx Spellstone (*) - COST:5
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy up to 2 random enemy minions.
			//       @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_503t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				PowerTask = ComplexTask.DestroyRandomTargets(2, EntityType.OP_MINIONS),
				Trigger = new Trigger(TriggerType.AFTER_PLAY_CARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					TriggerActivation = TriggerActivation.HAND,
					Condition = SelfCondition.IsDeathrattleCard,
					SingleTask = ComplexTask.ProgressSpellStoneUpdate("LOOT_503t2")
				}
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_503t2] Greater Onyx Spellstone (*) - COST:5
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy up to 3 random enemy minions.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_503t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				PowerTask = ComplexTask.DestroyRandomTargets(3, EntityType.OP_MINIONS)
			}));

		}

		private static void Shaman(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [LOOT_062] Kobold Hermit - COST:2 [ATK:1/HP:1]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a basic Totem. Summon it.
			// --------------------------------------------------------
			// Entourage: CS2_052, CS2_050, NEW1_009, CS2_051
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_062", new CardDef(new[] {"CS2_052","CS2_050","NEW1_009","CS2_051"}, new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.BASIC_TOTEM, 4)
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [LOOT_358] Grumble, Worldshaker - COST:6 [ATK:7/HP:7]
			// - Race: elemental, Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return your other minions to your hand. They cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_358", new CardDef(new Power
			{
				InfoCardId = "LOOT_358e",
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS_NOSOURCE),
					new ReturnHandTask(EntityType.STACK),
					new AddEnchantmentTask("LOOT_358e", EntityType.STACK))
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [LOOT_517] Murmuring Elemental - COST:2 [ATK:1/HP:1]
			// - Race: elemental, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your next <b>Battlecry</b> this turn triggers_twice.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_517", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("LOOT_517e", EntityType.CONTROLLER),
					new AddEnchantmentTask("LOOT_517e2", EntityType.SOURCE))
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [LOOT_518] Windshear Stormcaller - COST:5 [ATK:5/HP:5]
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control all 4 basic Totems, summon Al'Akir_the_Windlord.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_518", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, new SelfCondition(p =>
					{
						BoardZone board = p.Controller.BoardZone;
						if (board.Count < 5) return false;
						string[] ids = board.Select(x => x.Card.Id).OrderBy(x => x).ToArray();
						if (!ids.Contains("NEW1_009")) return false;
						int index = Array.IndexOf(ids, "CS2_050");
						if (index < 0) return false;
						return ids[index + 2] == "CS2_052";
					})),
					new FlagTask(true, new SummonTask("NEW1_010")))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_060] Crushing Hand - COST:2
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $8 damage to a minion. <b><b>Overload</b>:</b> (3) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 3
			// - OVERLOAD_OWED = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_060", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DamageTask(8, EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_064] Lesser Sapphire Spellstone - COST:7
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 1 copy of a friendly minion. @<i>(<b>Overload</b> 3 Mana Crystals to upgrade.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_064", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new SummonCopyTask(EntityType.TARGET),
				//Trigger = new Trigger(TriggerType.PLAY_CARD)
				//{
				//	Condition = SelfCondition.IsOverloadCard,
				//	TriggerActivation = TriggerActivation.HAND,
				//	SingleTask = ComplexTask.ProgressSpellStoneUpdateUsingEventNumber("LOOT_064t1")
				//},
				Trigger = new Trigger(TriggerType.OVERLOAD)
				{
					FastExecution = true,
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = ComplexTask.ProgressSpellStoneUpdateUsingEventNumber("LOOT_064t1")
				}
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_344] Primal Talismans - COST:3
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your minions "<b>Deathrattle:</b> Summon a random basic Totem."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_344", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("LOOT_344e", EntityType.MINIONS)
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_373] Healing Rain - COST:3
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #12 Health randomly split among all friendly characters.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("LOOT_373", new CardDef(new Power
			{
				// TODO: Velen
				PowerTask = new EnqueueTask(12,
					ComplexTask.Create(
						new IncludeTask(EntityType.FRIENDS),
						new FilterStackTask(SelfCondition.IsDamaged),
						new RandomTask(1, EntityType.STACK),
						new HealTask(1, EntityType.STACK)))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_504] Unstable Evolution - COST:1
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Transform a friendly minion into
			//       one that costs (1) more. Repeatable this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_504", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new TransformMinionTask(EntityType.TARGET, 1),
					new AddCardTo("LOOT_504t", EntityType.HAND))
			}));

			// ---------------------------------------- WEAPON - SHAMAN
			// [LOOT_506] The Runespear - COST:8 [ATK:3/HP:0]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: After your hero attacks, <b>Discover</b> a spell
			//       and cast it with random targets.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("LOOT_506", new CardDef(new Power
			{
				// TODO Test: The Runespear_LOOT_506
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = new DiscoverTask(DiscoverType.SPELL_RANDOM)
				}
			}));

		}

		private static void ShamanNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [LOOT_344e] Primal Talisman (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random basic Totem.
			// --------------------------------------------------------
			cards.Add("LOOT_344e", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.SummonRandomBasicTotem
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_064t1] Sapphire Spellstone (*) - COST:7
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 2 copies of a friendly minion. @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_064t1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new EnqueueTask(2, new SummonCopyTask(EntityType.TARGET)),
				//Trigger = new Trigger(TriggerType.PLAY_CARD)
				//{
				//	Condition = SelfCondition.IsOverloadCard,
				//	TriggerActivation = TriggerActivation.HAND,
				//	SingleTask = ComplexTask.ProgressSpellStoneUpdateUsingEventNumber("LOOT_064t2")
				//}
				Trigger = new Trigger(TriggerType.OVERLOAD)
				{
					FastExecution = true,
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = ComplexTask.ProgressSpellStoneUpdateUsingEventNumber("LOOT_064t2")
				}
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_064t2] Greater Sapphire Spellstone (*) - COST:7
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 3 copies of a friendly minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_064t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new EnqueueTask(3, new SummonCopyTask(EntityType.TARGET))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_504t] Unstable Evolution (*) - COST:1
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Transform a friendly minion into
			//       one that costs (1) more. Repeatable this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_504t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new TransformMinionTask(EntityType.TARGET, 1),
					new AddCardTo("LOOT_504t", EntityType.HAND)),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = ComplexTask.Create(
						new MoveToSetaside(EntityType.SOURCE)),
					RemoveAfterTriggered = true
				}
			}));

		}

		private static void Warlock(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [LOOT_013] Vulgar Homunculus - COST:2 [ATK:2/HP:4]
			// - Race: demon, Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Deal 2 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_013", new CardDef(new Power
			{
				PowerTask = new DamageTask(2, EntityType.HERO)
			}));

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_014] Kobold Librarian - COST:1 [ATK:2/HP:1]
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a card. Deal 2 damage to your_hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_014", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DrawTask(),
					new DamageTask(2, EntityType.HERO))
			}));

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_018] Hooked Reaver - COST:4 [ATK:4/HP:4]
			// - Race: demon, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have 15 or_less Health, gain +3/+3_and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_018", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.HERO, SelfCondition.IsHealth(15, RelaSign.LEQ)),
					new FlagTask(true, new AddEnchantmentTask("LOOT_018e", EntityType.SOURCE)))
			}));

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_306] Possessed Lackey - COST:6 [ATK:2/HP:2]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> <b>Recruit</b> a_Demon.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_306", new CardDef(new Power
			{
				DeathrattleTask = new RecruitTask(1, SelfCondition.IsRace(Race.DEMON))
			}));

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_368] Voidlord - COST:9 [ATK:3/HP:9]
			// - Race: demon, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//        <b>Deathrattle:</b> Summon three
			//       1/3 Demons with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_368", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("CS2_065", 3)
			}));

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415] Rin, the First Disciple - COST:6 [ATK:3/HP:6]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Add 'The First Seal' to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415", new CardDef(new Power
			{
				DeathrattleTask = new AddCardTo("LOOT_415t1", EntityType.HAND)
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_017] Dark Pact - COST:1
			// - Fac: alliance, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a friendly minion. Restore #4 Health to your hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_017", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.TARGET),
					new HealTask(4, EntityType.HERO))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_043] Lesser Amethyst Spellstone - COST:4
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Lifesteal.</b> Deal $3 damage to a minion. <i>(Take damage from your cards to upgrade.)</i> @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_043", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DamageTask(3, EntityType.TARGET, true),
				Trigger = new Trigger(TriggerType.DEAL_DAMAGE)
				{
					TriggerActivation = TriggerActivation.HAND,
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = new SelfCondition(p => !(p is HeroPower) && p.Game.CurrentEventData.EventTarget == p.Controller.Hero),
					SingleTask = new ChangeEntityTask("LOOT_043t2")
				}
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_417] Cataclysm - COST:4
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all minions. Discard your hand.
			// --------------------------------------------------------
			// GameTag:
			// - 890 = 10
			// --------------------------------------------------------
			cards.Add("LOOT_417", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.ALLMINIONS),
					new DiscardTask(EntityType.HAND))
			}));

			// --------------------------------------- WEAPON - WARLOCK
			// [LOOT_420] Skull of the Man'ari - COST:5
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the start of your turn, summon a Demon from your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("LOOT_420", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.HAND),
						new FilterStackTask(SelfCondition.IsRace(Race.DEMON)),
						new RandomTask(1, EntityType.STACK),
						new RemoveFromHand(EntityType.STACK),
						new SummonTask())
				}
			}));

		}

		private static void WarlockNonCollect(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t1t] Felhunter (*) - COST:2 [ATK:2/HP:2]
			// - Race: demon, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_415t1t", new CardDef());

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t2t] Felhunter (*) - COST:3 [ATK:3/HP:3]
			// - Race: demon, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_415t2t", new CardDef());

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t3t] Felhunter (*) - COST:4 [ATK:4/HP:4]
			// - Race: demon, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_415t3t", new CardDef());

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t4t] Felhunter (*) - COST:5 [ATK:5/HP:5]
			// - Race: demon, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_415t4t", new CardDef());

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t5t] Felhunter (*) - COST:6 [ATK:6/HP:6]
			// - Race: demon, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_415t5t", new CardDef());

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t6] Azari, the Devourer (*) - COST:10 [ATK:10/HP:10]
			// - Race: demon, Set: lootapalooza,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t6", new CardDef(new Power
			{
				// TODO: Should check the real log file
				PowerTask = new MoveToGraveYard(EntityType.OP_DECK)
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_043t2] Amethyst Spellstone (*) - COST:4
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Lifesteal.</b> Deal $5 damage to a minion. <i>(Take damage from your cards to upgrade.)</i> @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_043t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DamageTask(5, EntityType.TARGET, true),
				Trigger = new Trigger(TriggerType.DEAL_DAMAGE)
				{
					TriggerActivation = TriggerActivation.HAND,
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = new SelfCondition(p => !(p is HeroPower) && p.Game.CurrentEventData.EventTarget == p.Controller.Hero),
					SingleTask = new ChangeEntityTask("LOOT_043t3")
				}
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_043t3] Greater Amethyst Spellstone (*) - COST:4
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Lifesteal.</b> Deal $7 damage to a minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_043t3", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DamageTask(7, EntityType.TARGET)
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_415t1] The First Seal (*) - COST:5
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Summon a 2/2 Demon. Add 'The Second Seal' to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonTask("LOOT_415t1t"),
					new AddCardTo("LOOT_415t2", EntityType.HAND))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_415t2] The Second Seal (*) - COST:5
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Summon a 3/3 Demon. Add 'The Third Seal'
			//       to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonTask("LOOT_415t2t"),
					new AddCardTo("LOOT_415t3", EntityType.HAND))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_415t3] The Third Seal (*) - COST:5
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Summon a 4/4 Demon. Add 'The Fourth Seal' to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t3", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonTask("LOOT_415t3t"),
					new AddCardTo("LOOT_415t4", EntityType.HAND))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_415t4] The Fourth Seal (*) - COST:5
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Summon a 5/5 Demon. Add 'The Final Seal'
			//       to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t4", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonTask("LOOT_415t4t"),
					new AddCardTo("LOOT_415t5", EntityType.HAND))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_415t5] The Final Seal (*) - COST:5
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: [x]Summon a 6/6 Demon.
			//       Add 'Azari, the Devourer'
			//       to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t5", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonTask("LOOT_415t5t"),
					new AddCardTo("LOOT_415t6", EntityType.HAND))
			}));

		}

		private static void Warrior(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [LOOT_041] Kobold Barbarian - COST:3 [ATK:4/HP:4]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, attack a random enemy.
			// --------------------------------------------------------
			cards.Add("LOOT_041", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.OP_MINIONS),
						new RandomTask(1, EntityType.STACK),
						new AttackTask(EntityType.SOURCE, EntityType.STACK))
				}
			}));

			// --------------------------------------- MINION - WARRIOR
			// [LOOT_365] Gemstudded Golem - COST:6 [ATK:5/HP:9]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Can only attack if you have 5 or more Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_365", new CardDef(new Power
			{
				//Aura = new AdaptiveEffect(
				//	GameTag.CANT_ATTACK,
				//	EffectOperator.SET,
				//	p => p.Controller.Hero.Armor > 4 ? 0 : 1)
				Aura = new AdaptiveEffect(SelfCondition.HasArmorLessThan(5), GameTag.CANT_ATTACK)
			}));

			// --------------------------------------- MINION - WARRIOR
			// [LOOT_367] Drywhisker Armorer - COST:2 [ATK:2/HP:2]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> For each enemy minion, gain 2 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_367", new CardDef(new Power
			{
				// TODO Test: Drywhisker Armorer_LOOT_367
				PowerTask = ComplexTask.Create(
					new CountTask(EntityType.OP_MINIONS),
					new MathMultiplyTask(2),
					new ArmorTask())
			}));

			// --------------------------------------- MINION - WARRIOR
			// [LOOT_519] Geosculptor Yip - COST:8 [ATK:4/HP:8]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a random minion with_Cost_equal_to_your Armor <i>(up to 10)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_519", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new FuncNumberTask(p => p.Controller.Hero.Armor > 10 ? 10 : p.Controller.Hero.Armor),
						new RandomMinionNumberTask(GameTag.COST),
						new SummonTask())
				}
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_203] Lesser Mithril Spellstone - COST:7
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon one 5/5 Mithril Golem. <i>(Equip a weapon to upgrade.)</i>
			// --------------------------------------------------------
			cards.Add("LOOT_203", new CardDef(new Power
			{
				PowerTask = new SummonTask("LOOT_203t4"),
				Trigger = new Trigger(TriggerType.EQUIP_WEAPON)
				{
					TriggerActivation = TriggerActivation.HAND,
					TriggerSource = TriggerSource.FRIENDLY,
					FastExecution = true,
					SingleTask = new ChangeEntityTask("LOOT_203t2")
				}
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_285] Unidentified Shield - COST:6
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Gains a bonus effect in_your hand.
			// --------------------------------------------------------
			// Entourage: LOOT_285t, LOOT_285t2, LOOT_285t3, LOOT_285t4
			// --------------------------------------------------------
			cards.Add("LOOT_285", new CardDef(new[] {"LOOT_285t","LOOT_285t2","LOOT_285t3","LOOT_285t4"}, new Power
			{
				// TODO Test: Unidentified Shield_LOOT_285
				PowerTask = new ArmorTask(5),
				Trigger = TriggerLibrary.RevealUnidentifiedItem
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_364] Reckless Flurry - COST:3
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Spend all your Armor. Deal that much damage to all minions.
			// --------------------------------------------------------
			cards.Add("LOOT_364", new CardDef(new Power
			{
				// TODO Test: Reckless Flurry_LOOT_364
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ARMOR, EntityType.HERO),
					new SetGameTagTask(GameTag.ARMOR, 0, EntityType.HERO),
					new DamageNumberTask(EntityType.OP_MINIONS))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_370] Gather Your Party - COST:6
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Recruit</b> a minion.
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_370", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new RecruitTask(1)
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [LOOT_044] Bladed Gauntlet - COST:2
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Has Attack equal to your Armor. Can't attack heroes.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("LOOT_044", new CardDef(new Power
			{
				// TODO Bladed Gauntlet_LOOT_044
				//Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.SET, p => p.Controller.Hero.Armor)
				Aura = new MultiAura(
					new AdaptiveEffect(GameTag.ATK, EffectOperator.SET, p => p.Controller.Hero.Armor),
					new Aura(AuraType.HERO, new Effect(GameTag.CANNOT_ATTACK_HEROES, EffectOperator.SET, 1)))
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [LOOT_380] Woecleaver - COST:8 [ATK:3/HP:0]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: After your hero attacks, <b>Recruit</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_380", new CardDef(new Power
			{
				// TODO Test: Woecleaver_LOOT_380
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = new RecruitTask(1)
				}
			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [LOOT_528e] Twilight Curse (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Attack was swapped.
			// --------------------------------------------------------
			cards.Add("LOOT_528e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.SetAttackScriptTag
			}));

			// --------------------------------------- MINION - WARRIOR
			// [LOOT_203t4] Mithril Golem (*) - COST:5 [ATK:5/HP:5]
			// - Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_203t4", new CardDef());

			// --------------------------------------- MINION - WARRIOR
			// [LOOT_285t3t] Iron Golem (*) - COST:5 [ATK:5/HP:5]
			// - Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_285t3t", new CardDef());

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_203t2] Mithril Spellstone (*) - COST:7
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon two 5/5 Mithril Golems. <i>(Equip a weapon to upgrade.)</i>
			// --------------------------------------------------------
			cards.Add("LOOT_203t2", new CardDef(new Power
			{
				PowerTask = new SummonTask("LOOT_203t4", 2),
				Trigger = new Trigger(TriggerType.EQUIP_WEAPON)
				{
					TriggerActivation = TriggerActivation.HAND,
					TriggerSource = TriggerSource.FRIENDLY,
					FastExecution = true,
					SingleTask = new ChangeEntityTask("LOOT_203t3")
				}
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_203t3] Greater Mithril Spellstone (*) - COST:7
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon three 5/5 Mithril Golems.
			// --------------------------------------------------------
			cards.Add("LOOT_203t3", new CardDef(new Power
			{
				PowerTask = new SummonTask("LOOT_203t4", 3)
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_285t] Tower Shield +10 (*) - COST:6
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Gain 10 more Armor.
			// --------------------------------------------------------
			cards.Add("LOOT_285t", new CardDef(new Power
			{
				PowerTask = new ArmorTask(15)
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_285t2] Serrated Shield (*) - COST:6
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Deal 5 damage.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOOT_285t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ArmorTask(5),
					new DamageTask(5, EntityType.TARGET))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_285t3] Runed Shield (*) - COST:6
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Summon a 5/5 Golem.
			// --------------------------------------------------------
			cards.Add("LOOT_285t3", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ArmorTask(5),
					new SummonTask("LOOT_285t3t"))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_285t4] Spiked Shield (*) - COST:6
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Equip a 5/2 weapon.
			// --------------------------------------------------------
			cards.Add("LOOT_285t4", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ArmorTask(5),
					new WeaponTask("LOOT_285t4t"))
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [LOOT_285t4t] Spiked Shield (*) - COST:5 [ATK:5/HP:0]
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("LOOT_285t4t", new CardDef());

		}

		private static void Neutral(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_069] Sewer Crawler - COST:3 [ATK:1/HP:1]
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/3_Giant Rat.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_069", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new SummonTask("LOOT_069t", SummonSide.RIGHT)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_111] Scorp-o-matic - COST:2 [ATK:1/HP:2]
			// - Race: mechanical, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a minion with 1 or less Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_MAX_ATTACK = 1
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("LOOT_111", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_MAX_ATTACK,1},{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				PowerTask = new DestroyTask(EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_117] Wax Elemental - COST:1 [ATK:0/HP:2]
			// - Race: elemental, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_117", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_118] Ebon Dragonsmith - COST:4 [ATK:3/HP:4]
			// - Race: dragon, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reduce the Cost of a random weapon in your hand by (2).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_118", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsWeapon),
					new RandomTask(1, EntityType.STACK),
					new AddEnchantmentTask("LOOT_118e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_122] Corrosive Sludge - COST:5 [ATK:5/HP:5]
			// - Fac: alliance, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_122", new CardDef(new Power
			{
				PowerTask = new DestroyTask(EntityType.OP_WEAPON),
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_124] Lone Champion - COST:3 [ATK:2/HP:4]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control no other minions, gain <b>Taunt</b> and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_124", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsBoardCount(1)),
					new FlagTask(true, new AddEnchantmentTask("LOOT_124e", EntityType.SOURCE)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_125] Stoneskin Basilisk - COST:3 [ATK:1/HP:1]
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			//        <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_125", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_130] Arcane Tyrant - COST:5 [ATK:4/HP:4]
			// - Race: elemental, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (0) if you've cast a spell that costs (5) or more this turn.
			// --------------------------------------------------------
			cards.Add("LOOT_130", new CardDef(new Power
			{
				Aura = new AdaptiveCostEffect(0, TriggerType.CAST_SPELL, TriggerSource.FRIENDLY,
					SelfCondition.IsCost(5, RelaSign.GEQ))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_131] Green Jelly - COST:5 [ATK:3/HP:3]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a 1/2 Ooze with_<b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_131", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new SummonTask("LOOT_131t1")
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_132] Dragonslayer - COST:3 [ATK:4/HP:3]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 6 damage to a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_WITH_RACE = 24
			// --------------------------------------------------------
			cards.Add("LOOT_132", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_TARGET_WITH_RACE,24}}, new Power
			{
				PowerTask = new DamageTask(6, EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_134] Toothy Chest - COST:3 [ATK:0/HP:4]
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of your turn, set this minion's Attack to 4.
			// --------------------------------------------------------
			cards.Add("LOOT_134", new CardDef(new Power
			{
				// TODO [LOOT_134] Toothy Chest && Test: Toothy Chest_LOOT_134
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = new AddEnchantmentTask("LOOT_134e", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_136] Sneaky Devil - COST:4 [ATK:2/HP:2]
			// - Race: demon, Fac: alliance, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       Your other minions have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("LOOT_136", new CardDef(new Power
			{
				Aura = new Aura(AuraType.BOARD_EXCEPT_SOURCE, "LOOT_136e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_137] Sleepy Dragon - COST:9 [ATK:4/HP:12]
			// - Race: dragon, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_137", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_144] Hoarding Dragon - COST:4 [ATK:5/HP:6]
			// - Race: dragon, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give your opponent two Coins.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_144", new CardDef(new Power
			{
				DeathrattleTask = new AddCardTo("GAME_005", EntityType.OP_HAND, 2)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_149] Corridor Creeper - COST:7 [ATK:5/HP:5]
			// - Race: beast, Fac: neutral, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less whenever a minion dies while this is_in_your hand.
			// --------------------------------------------------------
			cards.Add("LOOT_149", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerActivation = TriggerActivation.HAND,
					TriggerSource = TriggerSource.ALL_MINIONS,
					SingleTask = new AddEnchantmentTask("LOOT_149e", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_150] Furbolg Mossbinder - COST:5 [ATK:1/HP:1]
			// - Fac: alliance, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform a friendly minion into a 6/6_Elemental.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_150", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new TransformTask("LOOT_150t1", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_152] Boisterous Bard - COST:3 [ATK:3/HP:2]
			// - Fac: alliance, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your other minions +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_152", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("LOOT_152e", EntityType.MINIONS_NOSOURCE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_153] Violet Wurm - COST:8 [ATK:7/HP:7]
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon seven 1/1 Grubs.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_153", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("LOOT_153t1", 7)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_154] Gravelsnout Knight - COST:1 [ATK:2/HP:3]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a random 1-Cost minion for_your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_154", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.COST, 1, opponent: true),
					new SummonOpTask())
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_161] Carnivorous Cube - COST:5 [ATK:4/HP:6]
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy
			//       a friendly minion.
			//       <b>Deathrattle:</b> Summon 2 copies of it.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_161", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ENTITY_ID, EntityType.TARGET),
					new AddEnchantmentTask("LOOT_161e", EntityType.SOURCE, false, true),
					new DestroyTask(EntityType.TARGET))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_167] Fungalmancer - COST:5 [ATK:2/HP:2]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give adjacent minions +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_167", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeAdjacentTask(EntityType.SOURCE),
					new AddEnchantmentTask("LOOT_167e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_184] Silver Vanguard - COST:7 [ATK:3/HP:3]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> <b>Recruit</b> an
			//       8-Cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_184", new CardDef(new Power
			{
				DeathrattleTask = new RecruitTask(1, SelfCondition.IsTagValue(GameTag.COST, 8))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_193] Shimmering Courser - COST:4 [ATK:3/HP:3]
			// - Race: beast, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Only you can target
			//       this with spells and
			//       Hero Powers.
			// --------------------------------------------------------
			cards.Add("LOOT_193", new CardDef(new Power
			{
				Aura = new Aura(AuraType.SELF, Effects.CantBeTargetedBySpellsAndHeroPowers)
				{
					Condition = SelfCondition.IsOpTurn,
					Restless = true
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_218] Feral Gibberer - COST:1 [ATK:1/HP:1]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: After this minion attacks a hero, add a copy of it to_your hand.
			// --------------------------------------------------------
			cards.Add("LOOT_218", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					Condition = SelfCondition.IsEventTargetIs(CardType.HERO),
					SingleTask = new AddCardTo("LOOT_218", EntityType.HAND)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_233] Cursed Disciple - COST:4 [ATK:5/HP:1]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 5/1 Revenant.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_233", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("LOOT_233t", 1)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_258] Dire Mole - COST:1 [ATK:1/HP:3]
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			cards.Add("LOOT_258", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_291] Shroom Brewer - COST:4 [ATK:4/HP:4]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 4_Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("LOOT_291", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				PowerTask = new HealTask(4, EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_315] Trogg Gloomeater - COST:5 [ATK:1/HP:5]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_315", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_347] Kobold Apprentice - COST:3 [ATK:2/HP:1]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage randomly split among all_enemies.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_347", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(3, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_357] Marin the Fox - COST:8 [ATK:6/HP:6]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 0/8 Treasure Chest for your opponent. <i>(Break it for awesome loot!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_357", new CardDef(new Power
			{
				PowerTask = new SummonOpTask("LOOT_357l")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_375] Guild Recruiter - COST:5 [ATK:2/HP:4]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Recruit</b> a minion that costs (4) or less.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_375", new CardDef(new Power
			{
				PowerTask = new RecruitTask(1, SelfCondition.IsTagValue(GameTag.COST, 4, RelaSign.LEQ))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_382] Kobold Monk - COST:4 [ATK:3/HP:6]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Your hero can't be targeted by spells or Hero_Powers.
			// --------------------------------------------------------
			cards.Add("LOOT_382", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HERO, Effects.CantBeTargetedBySpellsAndHeroPowers)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_383] Hungry Ettin - COST:6 [ATK:4/HP:10]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Summon a random 2-Cost minion for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_383", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.COST, 2, opponent: true),
					new SummonOpTask())
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_388] Fungal Enchanter - COST:3 [ATK:3/HP:3]
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 2 Health to all friendly characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_388", new CardDef(new Power
			{
				PowerTask = new HealTask(2, EntityType.FRIENDS)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_389] Rummaging Kobold - COST:3 [ATK:1/HP:3]
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return one of your destroyed weapons to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_389", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.GRAVEYARD),
					new FilterStackTask(SelfCondition.IsWeapon, SelfCondition.IsDead),
					new RandomTask(1, EntityType.STACK),
					new CopyTask(EntityType.STACK, Zone.HAND))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_394] Shrieking Shroom - COST:3 [ATK:1/HP:2]
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a random
			//       1-Cost minion.
			// --------------------------------------------------------
			cards.Add("LOOT_394", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new RandomMinionTask(GameTag.COST, 1),
						new SummonTask())
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_413] Plated Beetle - COST:2 [ATK:2/HP:3]
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Gain 3 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_413", new CardDef(new Power
			{
				DeathrattleTask = new ArmorTask(3)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_414] Grand Archivist - COST:8 [ATK:4/HP:7]
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of your turn, cast a spell from your deck <i>(targets chosen randomly)</i>.
			// --------------------------------------------------------
			cards.Add("LOOT_414", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.DECK),
						new FilterStackTask(SelfCondition.IsSpell, SelfCondition.HasProperTargetsInBoard),
						new RandomTask(1, EntityType.STACK),
						new RemoveFromDeck(EntityType.STACK),
						new PlayTask(PlayType.SPELL, true))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_516] Zola the Gorgon - COST:3 [ATK:2/HP:2]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Add a Golden copy of it to your hand.
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
			cards.Add("LOOT_516", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO Test: Zola the Gorgon_LOOT_516
				PowerTask = ComplexTask.Create(
					new CopyTask(EntityType.TARGET, Zone.HAND, addToStack: true),
					new SetGameTagTask(GameTag.PREMIUM, 1, EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_521] Master Oakheart - COST:9 [ATK:5/HP:5]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Recruit</b> a 1, 2, and 3-Attack minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_521", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RecruitTask(1, SelfCondition.IsTagValue(GameTag.ATK, 1)),
					new RecruitTask(1, SelfCondition.IsTagValue(GameTag.ATK, 2)),
					new RecruitTask(1, SelfCondition.IsTagValue(GameTag.ATK, 3)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_526] The Darkness - COST:4 [ATK:20/HP:20]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Starts dormant.
			//       <b>Battlecry:</b> Shuffle 3 Candles
			//       into the enemy deck. When
			//       drawn, this awakens.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_526", new CardDef(new Power
			{
				// TODO [LOOT_526] The Darkness
				PowerTask = new EnqueueTask(3, new AddCardTo("LOOT_526t", EntityType.OP_DECK)),
				Trigger = new Trigger(TriggerType.ZONE)
				{
					SingleTask = new TransformTask("LOOT_526d", EntityType.SOURCE, true)
					//SingleTask = ComplexTask.Create(
					//	new TransformTask("LOOT_526d", EntityType.SOURCE),
					//	new AddEnchantmentTask("LOOT_526et", EntityType.CONTROLLER))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_529] Void Ripper - COST:3 [ATK:3/HP:3]
			// - Race: demon, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Swap the
			//       Attack and Health of all_other_minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_529", new CardDef(new Power
			{

				PowerTask = new SwapAttackHealthTask(EntityType.ALLMINIONS_NOSOURCE, "LOOT_529e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_539] Spiteful Summoner - COST:7 [ATK:4/HP:4]
			// - Fac: neutral, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Reveal a spell
			//       from your deck. Summon
			//        a random minion with
			//       the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_539", new CardDef(new Power
			{
				// TODO [LOOT_539] Spiteful Summoner && Test: Spiteful Summoner_LOOT_539
				// TODO Generic.RevealCardBlock
				// only functional part of the card is implemented for now
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsSpell),
					new RandomTask(1, EntityType.STACK),
					new GetGameTagTask(GameTag.COST, EntityType.STACK),
					new RandomMinionNumberTask(GameTag.COST),
					new SummonTask())
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_540] Dragonhatcher - COST:9 [ATK:2/HP:4]
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of your turn, <b>Recruit</b> a Dragon.
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_540", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new RecruitTask(1, SelfCondition.IsRace(Race.DRAGON))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_541] King Togwaggle - COST:8 [ATK:5/HP:5]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Swap decks
			//       with your opponent.
			//       Give them a Ransom
			//       spell to swap back.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_541", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					SpecificTask.SwapDecks,
					new AddCardTo("LOOT_541t", EntityType.OP_DECK))
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_018e] Hooked Horror (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +3/+3.
			//       <b>Taunt</b>
			// --------------------------------------------------------
			cards.Add("LOOT_018e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_018e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_047e] Barkskin (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("LOOT_047e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_047e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_054be] Fearless (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("LOOT_054be", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_054be")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_118e] Smithing (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Cost reduced.
			// --------------------------------------------------------
			cards.Add("LOOT_118e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.ReduceCost(2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_124e] Lonely (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: <b>Taunt</b> and <b>Divine Shield</b>.
			// --------------------------------------------------------
			cards.Add("LOOT_124e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_124e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_134e] Toothy (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Attack set to 4.
			// --------------------------------------------------------
			cards.Add("LOOT_134e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetAttack(4))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_136e] Devilish Power (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Sneaky Devil is granting this minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("LOOT_136e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.Attack_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_149e] Creepier (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("LOOT_149e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.ReduceCost(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_152e] Inspired (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +1 Health.
			// --------------------------------------------------------
			cards.Add("LOOT_152e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_152e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_161e] Carnivorous Cube (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Destroyed {0}.
			// --------------------------------------------------------
			cards.Add("LOOT_161e", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.TARGET),
					new FuncPlayablesTask(p =>
						new List<IPlayable> { p[0].Game.IdEntityDic[p[0][GameTag.TAG_SCRIPT_DATA_NUM_1]] }),
					new CopyTask(EntityType.STACK, Zone.PLAY, 2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_165e] Sonya's Shadow (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Sonya Shadowdancer made this 1/1.
			// --------------------------------------------------------
			cards.Add("LOOT_165e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_165e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_167e] Magic Mushroom (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("LOOT_167e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_167e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_187e] Shadowy (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("LOOT_187e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_187e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_204e] Close Call (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			cards.Add("LOOT_204e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.ReduceCost(2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_214e] Evasive (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: <b>Immune</b> until end of turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_214e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.Immune)
				{
					IsOneTurnEffect = true
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_216e] Light of the Exarch (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Spell cast on minion.
			// --------------------------------------------------------
			cards.Add("LOOT_216e", new CardDef(new Power
			{
				// TODO [LOOT_216e] Light of the Exarch && Test: Light of the Exarch_LOOT_216e
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_278e] Tastes Like ???? (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("LOOT_278e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_278e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_278t1e] Sanguine (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +2/+2 and <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("LOOT_278t1e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_278t1e")
			}));

			// -------------------------z--------- ENCHANTMENT - NEUTRAL
			// [LOOT_278t2e] Pure (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +2/+2 and <b>Divine Shield</b>.
			// --------------------------------------------------------
			cards.Add("LOOT_278t2e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_278t2e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_278t3e] Shadowtouched (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("LOOT_278t3e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_278t3e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_278t3e2] Shadowy (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("LOOT_278t3e2", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_278t3e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_278t4e] Hopeful (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +2/+2. <b>Deathrattle:</b> Return this minion to your hand.
			// --------------------------------------------------------
			cards.Add("LOOT_278t4e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_278t4e"),
				DeathrattleTask = new ReturnHandTask(EntityType.SOURCE)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_286t3e] Holy Blessings (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("LOOT_286t3e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_286t3e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_333e] +1 Level! (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +2/+2 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("LOOT_333e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_333e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_358e] Grumbly Tumbly (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("LOOT_358e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetCost(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_412e] Shadowy (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("LOOT_412e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_412e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_500e] Wielding Val'anyr (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: +4/+2.
			//       <b>Deathrattle:</b> Equip a 4/2 Val'anyr.
			// --------------------------------------------------------
			cards.Add("LOOT_500e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOOT_500e"),
				DeathrattleTask = new WeaponTask("LOOT_500")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_517e] Murmurs (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Your next <b>Battlecry</b> this turn triggers twice.
			// --------------------------------------------------------
			cards.Add("LOOT_517e", new CardDef(new Power
			{
				//Enchant = new Enchant(GameTag.EXTRA_BATTLECRY, EffectOperator.SET, 1)
				Aura = new Aura(AuraType.CONTROLLER, new Effect(GameTag.EXTRA_BATTLECRIES_BASE, EffectOperator.SET, 1))
				{
					RemoveTrigger = (TriggerType.TURN_END, null),
				},
				Trigger = new Trigger(TriggerType.AFTER_PLAY_CARD)
				{
					Condition = new SelfCondition(p => p.Card.Id != "LOOT_517" && p.Card[GameTag.BATTLECRY] == 1),
					SingleTask = RemoveEnchantmentTask.Task
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_517e2] Murmuring (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Your next <b>Battlecry</b> this turn triggers twice.
			// --------------------------------------------------------
			cards.Add("LOOT_517e2", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.CUSTOM_KEYWORD_EFFECT, EffectOperator.SET, 1)
				{
					IsOneTurnEffect = true,
				},
				Trigger = new Trigger(TriggerType.AFTER_PLAY_CARD)
				{
					Condition = new SelfCondition(p => p.Card.Id != "LOOT_517" && p.Card[GameTag.BATTLECRY] == 1),
					SingleTask = RemoveEnchantmentTask.Task
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_520e] Albino Chameleon (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Copied Deathrattle from {0}.
			// --------------------------------------------------------
			cards.Add("LOOT_520e", new CardDef(new Power
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

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_526et] Darkness Candle Detect (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_526et", new CardDef(new Power
			{
				// TODO ??
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_529e] Void Shift (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped.
			// --------------------------------------------------------
			cards.Add("LOOT_529e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.SetAttackHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_998le] Wand's Wonder (*) - COST:0
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			cards.Add("LOOT_998le", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetCost(0))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_069t] Giant Rat (*) - COST:3 [ATK:2/HP:3]
			// - Race: beast, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_069t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_131t1] Green Ooze (*) - COST:2 [ATK:1/HP:2]
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_131t1", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_150t1] Moss Elemental (*) - COST:6 [ATK:6/HP:6]
			// - Race: elemental, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_150t1", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_153t1] Grub (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_153t1", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_233t] Cursed Revenant (*) - COST:4 [ATK:5/HP:1]
			// - Set: lootapalooza,
			// --------------------------------------------------------
			cards.Add("LOOT_233t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_357l] Master Chest (*) - COST:3 [ATK:0/HP:8]
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give your opponent a fantastic treasure!
			// --------------------------------------------------------
			// Entourage: LOOT_998h, LOOT_998j, LOOT_998l, LOOT_998k
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - MULTIPLY_BUFF_VALUE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_357l", new CardDef(new[] {"LOOT_998h","LOOT_998j","LOOT_998l","LOOT_998k"}, new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomEntourageTask(1, true),
					new AddStackTo(EntityType.OP_HAND))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_526d] The Darkness (*) - COST:4 [ATK:20/HP:20]
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - ELITE = 1
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - IGNORE_HIDE_STATS_FOR_BIG_CARD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_526d", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_998k] Golden Kobold (*) - COST:3 [ATK:6/HP:6]
			// - Set: lootapalooza,
			// ---------------------s-----------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Replace your hand with <b>Legendary</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_998k", new CardDef(new Power
			{
				PowerTask = new ChangeEntityTask(EntityType.HAND, CardType.MINION, CardClass.INVALID, Rarity.LEGENDARY)
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOT_526t] Darkness Candle (*) - COST:4
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Snuff out a candle. Draw a card.
			//       Cast this when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("LOOT_526t", new CardDef(new Power
			{
				PowerTask = SpecificTask.DarknessCandle,
				TopdeckTask = SpecificTask.DarknessCandle
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOT_541t] King's Ransom (*) - COST:5
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Swap decks with your_opponent.
			// --------------------------------------------------------
			cards.Add("LOOT_541t", new CardDef(new Power
			{
				PowerTask = SpecificTask.SwapDecks
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOT_998h] Tolin's Goblet (*) - COST:3
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Draw a card. Fill your hand with copies of it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_998h", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DrawTask(true),
					new FuncPlayablesTask(list =>
					{
						if (list.Count == 0) return null;
						IPlayable drawed = list[0];
						if (drawed == null) return null;
						Controller c = drawed.Controller;
						Card card = drawed.Card;
						int space = drawed.Controller.HandZone.FreeSpace;
						for (int i = 0; i < space; i++)
						{
							IPlayable copied = Entity.FromCard(c, card);
							copied[GameTag.DISPLAYED_CREATOR] = drawed.Id;
							c.HandZone.Add(copied);
						}
						return null;
					}))
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOT_998j] Zarog's Crown (*) - COST:3
			// - Fac: neutral, Set: lootapalooza,
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Legendary</b> minion. Summon two copies of it.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_998j", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.LEGENDARY_MINIONS,
					new CopyTask(EntityType.TARGET, Zone.PLAY))
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOT_998l] Wondrous Wand (*) - COST:3
			// - Set: lootapalooza,
			// --------------------------------------------------------
			// Text: Draw 3 cards. Reduce their Costs to (0).
			// --------------------------------------------------------
			cards.Add("LOOT_998l", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DrawTask(true, 3),
					new AddEnchantmentTask("LOOT_998le", EntityType.STACK))
			}));

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
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
