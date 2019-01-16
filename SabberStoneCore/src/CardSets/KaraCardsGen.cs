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
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets
{
	public class KaraCardsGen
	{
		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [KAR_065] Menagerie Warden - COST:6 [ATK:5/HP:5] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly Beast. Summon a_copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 20
			// --------------------------------------------------------
			cards.Add("KAR_065", new Power {
				PowerTask = new CopyTask(EntityType.TARGET, Zone.PLAY)
			});

			// ----------------------------------------- MINION - DRUID
			// [KAR_300] Enchanted Raven - COST:1 [ATK:2/HP:2] 
			// - Race: beast, Set: kara, Rarity: common
			// --------------------------------------------------------
			cards.Add("KAR_300", null);

			// ------------------------------------------ SPELL - DRUID
			// [KAR_075] Moonglade Portal - COST:6 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: Restore #6 Health. Summon a random
			//       6-Cost minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("KAR_075", new Power {
				PowerTask = ComplexTask.Create(
					new HealTask(6, EntityType.TARGET),
					ComplexTask.SummonRandomMinion(GameTag.COST, 6))
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [KAR_005] Kindly Grandmother - COST:2 [ATK:1/HP:1] 
			// - Race: beast, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 3/2 Big Bad Wolf.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("KAR_005", new Power {
				DeathrattleTask = new SummonTask("KAR_005a", SummonSide.DEATHRATTLE)
			});

			// ---------------------------------------- MINION - HUNTER
			// [KAR_006] Cloaked Huntress - COST:3 [ATK:3/HP:4] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Your <b>Secrets</b> cost (0).
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("KAR_006", new Power {
				Aura = new Aura(AuraType.HAND, Effects.SetCost(0))
				{
					Condition = SelfCondition.IsSecret
				}
			});

			// ----------------------------------------- SPELL - HUNTER
			// [KAR_004] Cat Trick - COST:2 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent casts a spell, summon a 4/2 Panther with <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("KAR_004", new Power {
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = ComplexTask.Secret(
						new SummonTask("KAR_004a", SummonSide.SPELL))
				}
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [KAR_004a] Cat in a Hat (*) - COST:3 [ATK:4/HP:2] 
			// - Race: beast, Fac: horde, Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("KAR_004a", null);

			// ---------------------------------------- MINION - HUNTER
			// [KAR_005a] Big Bad Wolf (*) - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_005a", null);

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [KAR_009] Babbling Book - COST:1 [ATK:1/HP:1] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Mage spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_009", new Power {
				PowerTask = ComplexTask.Create(
					new RandomCardTask(CardType.SPELL, CardClass.MAGE),
					new AddStackTo(EntityType.HAND))
			});

			// ------------------------------------------ MINION - MAGE
			// [KAR_092] Medivh's Valet - COST:2 [ATK:2/HP:3] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, deal 3 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("KAR_092", new Power {
				PowerTask = new DamageTask(3, EntityType.TARGET)
			});

			// ------------------------------------------- SPELL - MAGE
			// [KAR_076] Firelands Portal - COST:7 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $5 damage. Summon a random
			//       5-Cost minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("KAR_076", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(5, EntityType.TARGET),
					ComplexTask.SummonRandomMinion(GameTag.COST, 5)),
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [KAR_010] Nightbane Templar - COST:3 [ATK:2/HP:3] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, summon two 1/1 Whelps.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_010", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, ComplexTask.Create(
						new SummonTask("KAR_010a", SummonSide.LEFT),
						new SummonTask("KAR_010a", SummonSide.RIGHT)))),
			});

			// --------------------------------------- MINION - PALADIN
			// [KAR_057] Ivory Knight - COST:6 [ATK:4/HP:4] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Discover</b> a spell.
			//       Restore Health to your hero
			//       equal to its Cost.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("KAR_057", new Power {
				PowerTask = new DiscoverTask(DiscoverType.SPELL,
					ComplexTask.Create(
						new GetGameTagTask(GameTag.COST, EntityType.TARGET),
						new HealNumberTask(EntityType.HERO)))
			});

			// ---------------------------------------- SPELL - PALADIN
			// [KAR_077] Silvermoon Portal - COST:4 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2/+2. Summon a random
			//       2-Cost minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("KAR_077", new Power {
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("KAR_077e", EntityType.TARGET),
					ComplexTask.SummonRandomMinion(GameTag.COST, 2))
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [KAR_010a] Whelp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: dragon, Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_010a", null);

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [KAR_035] Priest of the Feast - COST:4 [ATK:3/HP:6] 
			// - Fac: neutral, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, restore 3 Health to
			//       your hero.
			// --------------------------------------------------------
			cards.Add("KAR_035", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new HealTask(3, EntityType.HERO)
				}
			});

			// ---------------------------------------- MINION - PRIEST
			// [KAR_204] Onyx Bishop - COST:5 [ATK:3/HP:4] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a friendly minion that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_204", new Power {
				PowerTask = ComplexTask.SummonRandomMinionThatDied()
			});

			// ----------------------------------------- SPELL - PRIEST
			// [KAR_013] Purify - COST:2 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Silence</b> a friendly minion. Draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("KAR_013", new Power {
				PowerTask = ComplexTask.Create(
					new SilenceTask(EntityType.TARGET),
					new DrawTask()),
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [KAR_069] Swashburglar - COST:1 [ATK:1/HP:1] 
			// - Race: pirate, Fac: neutral, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random class card to your hand <i>(from your opponent's class).</i>
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_069", new Power {
				PowerTask = ComplexTask.Create(
					new RandomCardTask(EntityType.OP_HERO),
					new AddStackTo(EntityType.HAND))
			});

			// ----------------------------------------- MINION - ROGUE
			// [KAR_070] Ethereal Peddler - COST:5 [ATK:5/HP:6] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you're holding
			//       any non-Rogue class cards,
			//       _reduce their Cost by (2).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_070", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.AnyNonClassCardInHand(CardClass.ROGUE)),
					new FlagTask(true, ComplexTask.Create(
						new IncludeTask(EntityType.HAND),
						new FilterStackTask(SelfCondition.IsNotCardClass(CardClass.ROGUE)),
						new AddAuraEffect(Effects.ReduceCost(2), EntityType.STACK))))
			});

			// ----------------------------------------- MINION - ROGUE
			// [KAR_094] Deadly Fork - COST:3 [ATK:3/HP:2] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a 3/2 weapon to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("KAR_094", new Power {
				DeathrattleTask = new AddCardTo("KAR_094a", EntityType.HAND)
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- WEAPON - ROGUE
			// [KAR_094a] Sharp Fork (*) - COST:3 [ATK:3/HP:0] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("KAR_094a", null);

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [KAR_021] Wicked Witchdoctor - COST:4 [ATK:3/HP:4] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a random basic_Totem.
			// --------------------------------------------------------
			cards.Add("KAR_021", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.SOURCE),
						new FuncPlayablesTask(list =>
						{
							Controller controller = list[0].Controller;
							string[] basicTotem = 
							{
								"CS2_050",
								"CS2_051",
								"CS2_052",
								"NEW1_009"
							};
							return new List<IPlayable>
							{
								Entity.FromCard(controller, Cards.FromId(Util.Choose(basicTotem)))
							};
						}),
						new SummonTask())
				}
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [KAR_073] Maelstrom Portal - COST:2 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal_$1_damage to_all_enemy_minions. Summon_a_random
			//       1-Cost minion. @spelldmg
			// --------------------------------------------------------
			cards.Add("KAR_073", new Power {
				PowerTask = ComplexTask.Create(
					new DamageTask(1, EntityType.OP_MINIONS, true),
					ComplexTask.SummonRandomMinion(GameTag.COST, 1))
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [KAR_063] Spirit Claws - COST:2 [ATK:1/HP:0] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Has +2 Attack while you
			//       have <b>Spell Damage</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("KAR_063", new Power {
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.ADD, p => p.Controller.CurrentSpellPower > 0 ? 2 : 0)
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [KAR_089] Malchezaar's Imp - COST:1 [ATK:1/HP:3] 
			// - Race: demon, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you discard a card, draw a card.
			// --------------------------------------------------------
			cards.Add("KAR_089", new Power {
				Trigger = new Trigger(TriggerType.DISCARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new DrawTask()
				}
			});

			// --------------------------------------- MINION - WARLOCK
			// [KAR_205] Silverware Golem - COST:3 [ATK:3/HP:3] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: If you discard this minion, summon it.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("KAR_205", new Power {
				Trigger = new Trigger(TriggerType.DISCARD)
				{
					TriggerActivation = TriggerActivation.HAND,
					TriggerSource = TriggerSource.SELF,
					SingleTask = new SummonTask("KAR_205")
				}
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [KAR_025] Kara Kazham! - COST:5 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Summon a 1/1 Candle, 2/2 Broom, and 3/3 Teapot.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KAR_025", new Power {
				PowerTask = ComplexTask.Create(
					new SummonTask("KAR_025a", SummonSide.SPELL),
					new SummonTask("KAR_025b", SummonSide.SPELL),
					new SummonTask("KAR_025c", SummonSide.SPELL))
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [KAR_025a] Candle (*) - COST:1 [ATK:1/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_025a", null);

			// --------------------------------------- MINION - WARLOCK
			// [KAR_025b] Broom (*) - COST:2 [ATK:2/HP:2] 
			// - Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_025b", null);

			// --------------------------------------- MINION - WARLOCK
			// [KAR_025c] Teapot (*) - COST:3 [ATK:3/HP:3] 
			// - Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_025c", null);

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [KAR_026] Protect the King! - COST:3 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: For each enemy minion, summon a 1/1 Pawn with <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_026", new Power {
				PowerTask = ComplexTask.Create(
					new CountTask(EntityType.OP_MINIONS),
					new EnqueueNumberTask(new SummonTask("KAR_026t", SummonSide.SPELL)))
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [KAR_091] Ironforge Portal - COST:5 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 4 Armor.
			//       Summon a random
			//       4-Cost minion.
			// --------------------------------------------------------
			cards.Add("KAR_091", new Power {
				PowerTask = ComplexTask.Create(
					new ArmorTask(4),
					ComplexTask.SummonRandomMinion(GameTag.COST, 4))
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [KAR_028] Fool's Bane - COST:5 [ATK:3/HP:0] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Unlimited attacks each turn. Can't attack heroes.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			cards.Add("KAR_028", new Power {
				Aura = new Aura(AuraType.HERO, new Effect(GameTag.CANNOT_ATTACK_HEROES, EffectOperator.SET, 1)),
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = new SetGameTagTask(GameTag.EXHAUSTED, 0, EntityType.HERO)
				}
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [KAR_026t] Pawn (*) - COST:1 [ATK:1/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_026t", null);

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [KAR_011] Pompous Thespian - COST:2 [ATK:3/HP:2] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_011", null);

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_029] Runic Egg - COST:1 [ATK:0/HP:2] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("KAR_029", new Power {
				DeathrattleTask = new DrawTask()
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_030a] Pantry Spider - COST:3 [ATK:1/HP:3] 
			// - Race: beast, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a
			//       1/3 Spider.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_030a", new Power {
				PowerTask = new SummonTask("KAR_030", SummonSide.RIGHT)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_033] Book Wyrm - COST:6 [ATK:3/HP:6] 
			// - Race: dragon, Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy an enemy minion with 3 or less Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NONSELF_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_MAX_ATTACK = 3
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// --------------------------------------------------------
			cards.Add("KAR_033", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, new DestroyTask(EntityType.TARGET)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_036] Arcane Anomaly - COST:1 [ATK:2/HP:1] 
			// - Race: elemental, Fac: neutral, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, give this minion
			//       +1 Health.
			// --------------------------------------------------------
			cards.Add("KAR_036", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("KAR_036e", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_037] Avian Watcher - COST:5 [ATK:3/HP:6] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, gain +1/+1
			//       and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("KAR_037", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingSecret),
					new FlagTask(true, ComplexTask.Create(
						new AddEnchantmentTask("KAR_037t", EntityType.SOURCE),
						ComplexTask.Taunt(EntityType.SOURCE))))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_041] Moat Lurker - COST:6 [ATK:3/HP:3] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a minion. <b>Deathrattle:</b> Resummon it.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("KAR_041", new Power {
				InfoCardId = "KAR_041e",
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ENTITY_ID, EntityType.TARGET),
					new DestroyTask(EntityType.TARGET),
					new SetGameTagNumberTask(GameTag.MOAT_LURKER_MINION, EntityType.SOURCE)),
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.SOURCE),
					new FuncPlayablesTask(p =>
					{
						int id = p[0][GameTag.MOAT_LURKER_MINION];
						if (id == 0)
							return new List<IPlayable>();

						IPlayable originalTarget = p[0].Game.IdEntityDic[id];
						if (originalTarget.Controller.BoardZone.IsFull)
							return null;
						Entity.FromCard(originalTarget.Controller, originalTarget.Card, null, originalTarget.Controller.BoardZone);
						return null;
					}))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_044] Moroes - COST:3 [ATK:1/HP:1] 
			// - Set: kara, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       At the end of your turn, summon a 1/1 Steward.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("KAR_044", new Power {
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new SummonTask("KAR_044a", SummonSide.RIGHT)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_061] The Curator - COST:7 [ATK:4/HP:6] 
			// - Race: mechanical, Set: kara, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Draw a Beast, Dragon, and Murloc from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_061", new Power {
				PowerTask = ComplexTask.Create(
					ComplexTask.DrawFromDeck(1, SelfCondition.IsRace(Race.BEAST)),
					ComplexTask.DrawFromDeck(1, SelfCondition.IsRace(Race.DRAGON)),
					ComplexTask.DrawFromDeck(1, SelfCondition.IsRace(Race.MURLOC)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_062] Netherspite Historian - COST:2 [ATK:1/HP:3] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, <b>Discover</b>
			//       a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("KAR_062", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
					new FlagTask(true, new DiscoverTask(DiscoverType.DRAGON)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_095] Zoobot - COST:3 [ATK:3/HP:3] 
			// - Race: mechanical, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_095", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.BEAST)),
					new RandomTask(1, EntityType.STACK),
					new AddEnchantmentTask("KAR_095e", EntityType.STACK),
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.DRAGON)),
					new RandomTask(1, EntityType.STACK),
					new AddEnchantmentTask("KAR_095e", EntityType.STACK),
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.MURLOC)),
					new RandomTask(1, EntityType.STACK),
					new AddEnchantmentTask("KAR_095e", EntityType.STACK))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_096] Prince Malchezaar - COST:5 [ATK:5/HP:6] 
			// - Race: demon, Set: kara, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]When the game starts,
			//       add 5 extra <b>Legendary</b>
			//       minions to your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("KAR_096", new Power {
				Trigger = new Trigger(TriggerType.GAME_START)
				{
					TriggerActivation = TriggerActivation.DECK,
					RemoveAfterTriggered = true,
					SingleTask = ComplexTask.Create(
						new RandomMinionTask(GameTag.RARITY, (int) Rarity.LEGENDARY, 5, RelaSign.EQ, true, true),
						new AddStackTo(EntityType.DECK))
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_097] Medivh, the Guardian - COST:8 [ATK:7/HP:7] 
			// - Set: kara, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip Atiesh, Greatstaff of the Guardian.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_097", new Power {
				PowerTask = new WeaponTask("KAR_097t")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_114] Barnes - COST:4 [ATK:3/HP:4] 
			// - Set: kara, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 1/1 copy of a random minion in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_114", new Power {
				InfoCardId = "KAR_114e",
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsNotBoardFull),
					new FlagTask(true, ComplexTask.Create(
						new IncludeTask(EntityType.DECK),
						new FilterStackTask(SelfCondition.IsMinion),
						new RandomTask(1, EntityType.STACK),
						new CopyTask(EntityType.STACK, Zone.PLAY, addToStack: true),
						new AddEnchantmentTask("KAR_114e", EntityType.STACK))))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_702] Menagerie Magician - COST:5 [ATK:4/HP:4] 
			// - Fac: neutral, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_702", new Power {
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.BEAST)),
					new RandomTask(1, EntityType.STACK),
					new AddEnchantmentTask("KAR_702e", EntityType.STACK),
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.DRAGON)),
					new RandomTask(1, EntityType.STACK),
					new AddEnchantmentTask("KAR_702e", EntityType.STACK),
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.MURLOC)),
					new RandomTask(1, EntityType.STACK),
					new AddEnchantmentTask("KAR_702e", EntityType.STACK))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_710] Arcanosmith - COST:4 [ATK:3/HP:2] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 0/5 minion with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_710", new Power {
				PowerTask = new SummonTask("KAR_710m", SummonSide.RIGHT)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_711] Arcane Giant - COST:12 [ATK:8/HP:8] 
			// - Set: kara, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Costs (1) less for each spell
			//       you've cast this game.
			// --------------------------------------------------------
			cards.Add("KAR_711", new Power {
				Aura = new AdaptiveCostEffect(p => p.Controller.NumSpellsPlayedThisGame)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_712] Violet Illusionist - COST:3 [ATK:4/HP:3] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: During your turn, your hero is <b>Immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("KAR_712", new Power {
				Aura = new Aura(AuraType.HERO, Effects.Immune)
				{
					Condition = SelfCondition.IsMyTurn,
					Restless = true
				},
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_036e] Eating (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("KAR_036e", new Power {
				Enchant = new OngoingEnchant(Effects.Health_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_037t] Secrets of Karazhan (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("KAR_037t", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_037t")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_041e] Moat Lurker (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Destroyed {0}.
			// --------------------------------------------------------
			cards.Add("KAR_041e", new Power {
				// TODO [KAR_041e] Moat Lurker && Test: Moat Lurker_KAR_041e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_077e] Silver Might (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("KAR_077e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_077e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_095e] Well Fed (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("KAR_095e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_095e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_114e] Incredible Impression (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Attack and Health set to 1.
			// --------------------------------------------------------
			cards.Add("KAR_114e", new Power {
				Enchant = new Enchant(Effects.SetAttackHealth(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_702e] A Simple Trick (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("KAR_702e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_702e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_030] Cellar Spider (*) - COST:3 [ATK:1/HP:3] 
			// - Race: beast, Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_030", null);

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_044a] Steward (*) - COST:1 [ATK:1/HP:1] 
			// - Fac: neutral, Set: kara, 
			// --------------------------------------------------------
			cards.Add("KAR_044a", null);

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_710m] Animated Shield (*) - COST:2 [ATK:0/HP:5] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_710m", null);

			// --------------------------------------- WEAPON - NEUTRAL
			// [KAR_097t] Atiesh (*) - COST:3 [ATK:1/HP:0] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: [x]After you cast a spell,
			//       summon a random
			//       minion of that Cost.
			//       Lose 1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("KAR_097t", new Power {
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = ComplexTask.Create(
						new GetGameTagTask(GameTag.TAG_LAST_KNOWN_COST_IN_HAND, EntityType.TARGET),
						new RandomMinionNumberTask(GameTag.COST),
						new SummonTask(),
						new DamageWeaponTask(false))
				}
			});
		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			Druid(cards);
			Hunter(cards);
			HunterNonCollect(cards);
			Mage(cards);
			Paladin(cards);
			PaladinNonCollect(cards);
			Priest(cards);
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
