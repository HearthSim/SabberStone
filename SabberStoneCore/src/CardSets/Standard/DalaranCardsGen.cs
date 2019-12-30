using System;
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
using SabberStoneCore.Triggers;
using SabberStoneCore.src.Loader;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets.Standard
{
	public class DalaranCardsGen
	{
		private static void Druid(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [DAL_354] Acornbearer - COST:1 [ATK:2/HP:1]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add two 1/1 Squirrels to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_354", new CardDef(new Power
			{
				DeathrattleTask = new AddCardTo("DAL_354t", EntityType.HAND, 2)
			}));

			// ----------------------------------------- MINION - DRUID
			// [DAL_355] Lifeweaver - COST:3 [ATK:2/HP:5]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you restore Health, add a random Druid spell to your hand.
			// --------------------------------------------------------
			cards.Add("DAL_355", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.HEAL)
					.SetTask(ComplexTask.Create(
						new RandomCardTask(CardType.SPELL, CardClass.DRUID),
						new AddStackTo(EntityType.HAND)))
					.SetCondition(SelfCondition.IsEventSourceFriendly)
					.GetTrigger()
			}));

			// ----------------------------------------- MINION - DRUID
			// [DAL_357] Lucentbark - COST:8 [ATK:4/HP:8]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Go dormant. Restore 5 Health to awaken this minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_357", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("DAL_357t", SummonSide.DEATHRATTLE)
			}));

			// ----------------------------------------- MINION - DRUID
			// [DAL_732] Keeper Stalladris - COST:2 [ATK:2/HP:3]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you cast a <b>Choose One</b> spell, add copies of both choices_to_your_hand.
			// --------------------------------------------------------
			// GameTag:f
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DAL_732", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_CAST)
					.SetTask(new CustomTask((g, c, s, t, stack) =>
					{
						GenericEffect<Cost, Playable> costEffect = Cost.Effect(EffectOperator.SET, t.Card.Cost);

						for (int i = 0; i < t.ChooseOnePlayables.Length; i++)
						{
							Playable copy = (Playable)Generic.Copy(in c, in s, t.ChooseOnePlayables[i], Zone.HAND);
							costEffect.ApplyTo(copy);
						}
					}))
					.SetCondition(SelfCondition.IsChooseOneCard)
					.SetSource(TriggerSource.FRIENDLY)
			}));

			// ----------------------------------------- MINION - DRUID
			// [DAL_799] Crystal Stag - COST:5 [ATK:4/HP:4]
			// - Race: beast, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Rush</b>. <b>Battlecry:</b> If you've restored 5 Health this game, summon a copy of this.@ <i>({0} left!)</i>@ <i>(Ready!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// - PLAYER_TAG_THRESHOLD_TAG_ID = 958
			// - PLAYER_TAG_THRESHOLD_VALUE = 5
			// --------------------------------------------------------
			cards.Add("DAL_799", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.CheckThreshold(RelaSign.GEQ),
					new SummonCopyTask(EntityType.SOURCE, side: SummonSide.RIGHT))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DAL_256] The Forest's Aid - COST:8
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Summon five 2/2 Treants.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 52821
			// - TWINSPELL = 1
			// --------------------------------------------------------
			cards.Add("DAL_256", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("DAL_256t2", 5)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DAL_350] Crystal Power - COST:1
			// - Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Deal $2 damage to a minion; or_Restore #5 Health. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_350", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}));

			// ------------------------------------------ SPELL - DRUID
			// [DAL_351] Blessing of the Ancients - COST:3
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Give your minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54128
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_351", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("DAL_351e", EntityType.MINIONS)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DAL_352] Crystalsong Portal - COST:2
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a Druid minion. If your hand has no minions, keep all 3.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_352", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.HasMinionInHand,
					new DiscoverTask(CardType.MINION, CardClass.DRUID),
					new DiscoverTask(CardType.MINION, CardClass.DRUID, keepAllCondition: c => true))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DAL_733] Dreamway Guardians - COST:2
			// - Fac: neutral, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon two 1/2 Dryads with <b>Lifesteal</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("DAL_733", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("DAL_733t", 2)
			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [DAL_256t2] Treant (*) - COST:2 [ATK:2/HP:2]
			// - Set: dalaran,
			// --------------------------------------------------------
			cards.Add("DAL_256t2", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [DAL_354t] Squirrel (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: dalaran,
			// --------------------------------------------------------
			cards.Add("DAL_354t", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [DAL_357t] Spirit of Lucentbark (*) - COST:11 [ATK:0/HP:1]
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: When you restore 5 Health, awaken this minion.
			//       <i>(@ left!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 5
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 5
			// --------------------------------------------------------
			cards.Add("DAL_357t", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.HEAL)
						.SetTask(ComplexTask.Create(
							new GetEventNumberTask(),
							new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_2, EntityType.SOURCE, numberIndex: 1),
							new MathNumberIndexTask(0, 1, MathOperation.ADD),
							new NumberConditionTask(5, RelaSign.GEQ),
							new FlagTask(true, new ChangeEntityTask("DAL_357")),
							new FlagTask(false, new SetGameTagNumberTask(GameTag.TAG_SCRIPT_DATA_NUM_2, EntityType.SOURCE))))
						.SetCondition(SelfCondition.IsEventSourceFriendly)
						.GetTrigger()
			}));

			// ----------------------------------------- MINION - DRUID
			// [DAL_733t] Crystal Dryad (*) - COST:1 [ATK:1/HP:2]
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("DAL_733t", new CardDef());

			// ------------------------------------------ SPELL - DRUID
			// [DAL_256ts] The Forest's Aid (*) - COST:8
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon five 2/2 Treants.
			// --------------------------------------------------------
			cards.Add("DAL_256ts", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("DAL_256t2", 5)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DAL_350a] Piercing Thorns (*) - COST:1
			// - Fac: neutral, Set: dalaran,
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_350a", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET, true)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DAL_350b] Healing Blossom (*) - COST:1
			// - Fac: neutral, Set: dalaran,
			// --------------------------------------------------------
			// Text: Restore #5 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_350b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new HealTask(5, EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DAL_351ts] Blessing of the Ancients (*) - COST:3
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions +1/+1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_351ts", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("DAL_351e", EntityType.MINIONS)
			}));

		}

		private static void Hunter(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [DAL_372] Arcane Fletcher - COST:4 [ATK:3/HP:3]
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Whenever you play a
			//       1-Cost minion, draw a
			//       spell from your deck.
			// --------------------------------------------------------
			cards.Add("DAL_372", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.PLAY_MINION)
					.SetTask(ComplexTask.Create(
						new IncludeTask(EntityType.DECK),
						new FilterStackTask(SelfCondition.IsSpell),
						new RandomTask(1, EntityType.STACK),
						new DrawStackTask()))
					.SetSource(TriggerSource.FRIENDLY)
					.SetCondition(SelfCondition.IsCost(1))
					.GetTrigger()
			}));

			// ---------------------------------------- MINION - HUNTER
			// [DAL_376] Oblivitron - COST:6 [ATK:3/HP:4]
			// - Race: mechanical, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Summon a
			//       Mech from your hand and
			//       trigger its <b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_376", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsRace(Race.MECHANICAL)),
					new RandomTask(1, EntityType.STACK),
					new SummonStackTask(true),
					new ActivateDeathrattleTask(EntityType.STACK))
			}));

			// ---------------------------------------- MINION - HUNTER
			// [DAL_379] Vereesa Windrunner - COST:7 [ATK:5/HP:6]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip Thori'dal, the Stars' Fury.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_379", new CardDef(new Power
			{
				PowerTask = new WeaponTask("DAL_379t")
			}));

			// ---------------------------------------- MINION - HUNTER
			// [DAL_587] Shimmerfly - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Hunter spell to your hand.
			// --------------------------------------------------------
			// Entourage: NEW1_032, NEW1_033, NEW1_034
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_587", new CardDef(new[] {"NEW1_032","NEW1_033","NEW1_034"}, new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomCardTask(CardType.SPELL, CardClass.HUNTER),
					new AddStackTo(EntityType.HAND))
			}));

			// ---------------------------------------- MINION - HUNTER
			// [DAL_604] Ursatron - COST:3 [ATK:3/HP:3]
			// - Race: mechanical, Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a Mech from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_604", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsRace(Race.MECHANICAL)),
					new RandomTask(1, EntityType.STACK),
					new DrawStackTask())
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_371] Marked Shot - COST:4
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage to_a_minion. <b>Discover</b>_a_spell. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_371", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(4, EntityType.TARGET),
					new DiscoverTask(DiscoverType.SPELL))
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_373] Rapid Fire - COST:1
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Deal $1 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54143
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_373", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(1, EntityType.TARGET, true)
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_377] Nine Lives - COST:3
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a friendly <b>Deathrattle</b> minion that died this game. Also trigger its <b>Deathrattle</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_DEATHRATTLE_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_377", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_DEATHRATTLE_MINION_DIED_THIS_GAME,0}}, new Power
			{
				// TODO [DAL_377] Nine Lives && Test: Nine Lives_DAL_377
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_378] Unleash the Beast - COST:6
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Summon a 5/5 Wyvern with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54145
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_378", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("DAL_378t1")
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_589] Hunting Party - COST:5
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Copy all Beasts in your_hand.
			// --------------------------------------------------------
			cards.Add("DAL_589", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsRace(Race.BEAST)),
					new CopyTask(EntityType.STACK, Zone.HAND))
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [DAL_379e] Stars' Fury (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: You have <b>Spell Damage +2</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("DAL_379e", new CardDef(new Power
			{
				Enchant = new Enchant(new Effect(GameTag.SPELLPOWER, EffectOperator.ADD, 2))
				{
					IsOneTurnEffect = true
				}
			}));

			// ---------------------------------------- MINION - HUNTER
			// [DAL_378t1] Wyvern (*) - COST:5 [ATK:5/HP:5]
			// - Race: beast, Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_378t1", new CardDef());

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_373ts] Rapid Fire (*) - COST:1
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_373ts", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(1, EntityType.TARGET, true)
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DAL_378ts] Unleash the Beast (*) - COST:6
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 5/5 Wyvern with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_ATTACK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_378ts", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("DAL_378t1")
			}));

			// ---------------------------------------- WEAPON - HUNTER
			// [DAL_379t] Thori'dal, the Stars' Fury (*) - COST:3 [ATK:2/HP:0]
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: After your hero attacks, gain <b>Spell Damage +2</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_379t", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_ATTACK)
					.SetTask(new AddEnchantmentTask("DAL_379e", EntityType.HERO))
					.SetSource(TriggerSource.HERO)
			}));

		}

		private static void Mage(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [DAL_163] Messenger Raven - COST:3 [ATK:3/HP:2]
			// - Race: beast, Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a
			//       Mage minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_163", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(CardType.MINION, CardClass.MAGE)
			}));

			// ------------------------------------------ MINION - MAGE
			// [DAL_182] Magic Dart Frog - COST:2 [ATK:1/HP:3]
			// - Race: beast, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: After you cast a spell, deal 1 damage to a random enemy minion.
			// --------------------------------------------------------
			cards.Add("DAL_182", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_CAST)
					.SetTask(ComplexTask.DamageRandomTargets(1, EntityType.OP_MINIONS, 1))
					.SetSource(TriggerSource.FRIENDLY)
			}));

			// ------------------------------------------ MINION - MAGE
			// [DAL_575] Khadgar - COST:2 [ATK:2/HP:2]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your cards that summon minions summon twice_as_many.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DAL_575", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_SUMMON)
					.SetTask(new CustomTask((g, c, s, t, stack) =>
						{
							if (t.Controller.BoardZone.IsFull) return;

							Entity.FromCard(t.Controller, t.Card,
								new EntityData { { GameTag.COPIED_BY_KHADGAR, 1 } },
								c.BoardZone, zonePos: t.ZonePosition + 1, creator: in s);
						}))
					.SetCondition(new SelfCondition(p => p.Game.CurrentEventData.EventSource != p
														 && p[GameTag.COPIED_BY_KHADGAR] != 1))
					.SetSource(TriggerSource.FRIENDLY_EVENT_SOURCE)
			}));

			// ------------------------------------------ MINION - MAGE
			// [DAL_576] Kirin Tor Tricaster - COST:4 [ATK:3/HP:3]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Spell Damage +3</b>
			//       Your spells cost (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 3
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("DAL_576", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HAND, "DAL_576e")
				{
					Condition = SelfCondition.IsSpell
				}
			}));

			// ------------------------------------------ MINION - MAGE
			// [DAL_603] Mana Cyclone - COST:2 [ATK:2/HP:2]
			// - Race: elemental, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> For each spell
			//       you've cast this turn, add
			//       a random Mage spell
			//       to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_603", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new FuncNumberTask(p =>
					{
						int count = 0;
						foreach (Card card in p.Controller.CardsPlayedThisTurn)
							if (card.Type == CardType.SPELL)
								count++;
						return count;
					}),
					new EnqueueNumberTask(ComplexTask.AddRandomMageSpellToHand))
			}));

			// ------------------------------------------ MINION - MAGE
			// [DAL_609] Kalecgos - COST:10 [ATK:4/HP:12]
			// - Race: dragon, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your first spell each
			//       turn costs (0).
			//       <b>Battlecry:</b> <b>Discover</b>
			//       a spell.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - AURA = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_609", new CardDef(new Power
			{
				Aura = new SwitchingAura(AuraType.HAND, SelfCondition.SpellsPlayedThisTurn(0),
					TriggerType.CAST_SPELL, Effects.SetCost(0))
				{
					Condition = SelfCondition.IsSpell
				},
				PowerTask = new DiscoverTask(CardType.SPELL)
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DAL_177] Conjurer's Calling - COST:3
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Destroy a minion. Summon 2 minions of the same Cost to replace it.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 52637
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_177", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO Position
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.COST, EntityType.TARGET),
					new DestroyTask(EntityType.TARGET, true),
					new EnqueueTask(2, ComplexTask.Create(
						new RandomMinionNumberTask(GameTag.COST),
						new SummonTask())))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DAL_577] Ray of Frost - COST:1
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       <b>Freeze</b> a minion.
			//       If it's already <b>Frozen</b>,
			//       deal $2 damage to it. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54193
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("DAL_577", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.TARGET, SelfCondition.IsFrozen),
					new FlagTask(true, new DamageTask(2, EntityType.TARGET, true)),
					new FlagTask(false, ComplexTask.Freeze(EntityType.TARGET)))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DAL_578] Power of Creation - COST:8
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a 6-Cost minion. Summon two copies of it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_578", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.SIX_COST_SUMMON,
					new CopyTask(EntityType.TARGET, Zone.PLAY))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DAL_608] Magic Trick - COST:1
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Discover</b> a spell that costs (3) or less.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_608", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(CardType.SPELL, tagValueCriteria: (GameTag.COST, RelaSign.LEQ, 3))
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [DAL_177ts] Conjurer's Calling (*) - COST:3
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a minion. Summon 2 minions of the same Cost to replace it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_177ts", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.COST, EntityType.TARGET),
					new DestroyTask(EntityType.TARGET, true),
					new EnqueueTask(2, ComplexTask.Create(
						new RandomMinionNumberTask(GameTag.COST),
						new SummonTask())))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DAL_577ts] Ray of Frost (*) - COST:1
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion.
			//       If it's already <b>Frozen</b>,
			//       deal $2 damage to it. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("DAL_577ts", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.TARGET, SelfCondition.IsFrozen),
					new FlagTask(true, new DamageTask(2, EntityType.TARGET, true)),
					new FlagTask(false, ComplexTask.Freeze(EntityType.TARGET)))
			}));

		}

		private static void Paladin(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [DAL_146] Bronze Herald - COST:3 [ATK:3/HP:2]
			// - Race: dragon, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add two 4/4 Dragons to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_146", new CardDef(new Power
			{
				DeathrattleTask = new AddCardTo("DAL_146t", EntityType.HAND, 2)
			}));

			// --------------------------------------- MINION - PALADIN
			// [DAL_147] Dragon Speaker - COST:5 [ATK:3/HP:5]
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all Dragons in your hand +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_147", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsRace(Race.DRAGON)),
					new AddEnchantmentTask("DAL_147e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - PALADIN
			// [DAL_573] Commander Rhyssa - COST:3 [ATK:4/HP:3]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your <b>Secrets</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_573", new CardDef(new Power
			{
				// TODO [DAL_573] Commander Rhyssa && Test: Commander Rhyssa_DAL_573
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [DAL_581] Nozari - COST:10 [ATK:4/HP:12]
			// - Race: dragon, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore both heroes to full Health.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("DAL_581", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new HealFullTask(EntityType.HERO),
					new HealFullTask(EntityType.OP_HERO))
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_141] Desperate Measures - COST:1
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Cast a random Paladin <b>Secret</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54129
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_141", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_SECRET_ZONE_CAP_FOR_NON_SECRET,0}}, new Power
			{
				PowerTask = SpecificTask.CastRandomSecret(CardClass.PALADIN)
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_568] Lightforged Blessing - COST:2
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Twinspell</b>
			//       Give a friendly minion <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TWINSPELL_COPY = 54189
			// - TWINSPELL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("DAL_568", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("DAL_568e", EntityType.TARGET)
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_570] Never Surrender! - COST:1
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent casts a spell, give your minions +2_Health.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_570", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.CAST_SPELL)
					.SetSecretTasks(new AddEnchantmentTask("DAL_570e", EntityType.MINIONS))
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_727] Call to Adventure - COST:3
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw the lowest Cost minion from your deck. Give it +2/+2.
			// --------------------------------------------------------
			cards.Add("DAL_727", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DrawMinionTask(true, 1, true),
					new AddEnchantmentTask("DAL_727e", EntityType.STACK))
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_731] Duel! - COST:5
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon a minion from each player's deck.
			//       They fight!
			// --------------------------------------------------------
			cards.Add("DAL_731", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_BOARD_NOT_COMPLETELY_FULL,0}}, new Power
			{
				// TODO [DAL_731] Duel! && Test: Duel!_DAL_731
				//PowerTask = null,
				//Trigger = null,

			}));

			// --------------------------------------- WEAPON - PALADIN
			// [DAL_571] Mysterious Blade - COST:2 [ATK:2/HP:0]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a
			//       <b>Secret</b>, gain +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_571", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.IsControllingSecret,
					new AddEnchantmentTask("DAL_571e", EntityType.SOURCE))
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [DAL_568e] Lightforged Blessing (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			cards.Add("DAL_568e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_568e")
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [DAL_571e] Mysterious (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("DAL_571e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_571e")
			}));

			// --------------------------------------- MINION - PALADIN
			// [DAL_146t] Bronze Dragon (*) - COST:4 [ATK:4/HP:4]
			// - Race: dragon, Set: dalaran,
			// --------------------------------------------------------
			cards.Add("DAL_146t", new CardDef());

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_141ts] Desperate Measures (*) - COST:1
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Cast a random Paladin <b>Secret</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_141ts", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_SECRET_ZONE_CAP_FOR_NON_SECRET,0}}, new Power
			{
				PowerTask = SpecificTask.CastRandomSecret(CardClass.PALADIN)
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DAL_568ts] Lightforged Blessing (*) - COST:2
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Give a friendly minion <b>Lifesteal</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("DAL_568ts", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("DAL_568e", EntityType.TARGET)
			}));

		}

		private static void Priest(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [DAL_030] Shadowy Figure - COST:2 [ATK:2/HP:2]
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform into a_2/2 copy of a friendly <b>Deathrattle</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_030", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_TARGET_WITH_DEATHRATTLE,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new TransformCopyTask(true),
					new AddEnchantmentTask("DAL_030e", EntityType.STACK))
			}));

			// ---------------------------------------- MINION - PRIEST
			// [DAL_039] Convincing Infiltrator - COST:5 [ATK:2/HP:6]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b><b>Taunt</b></b>
			//       <b>Deathrattle:</b> Destroy a
			//        random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_039", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.DestroyRandomTargets(1, EntityType.OP_MINIONS)
			}));

			// ---------------------------------------- MINION - PRIEST
			// [DAL_040] Hench-Clan Shadequill - COST:4 [ATK:4/HP:7]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Restore 5 Health to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("DAL_040", new CardDef(new Power
			{
				DeathrattleTask = new HealTask(5, EntityType.OP_HERO)
			}));

			// ---------------------------------------- MINION - PRIEST
			// [DAL_413] EVIL Conscripter - COST:2 [ATK:2/HP:2]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a <b>Lackey</b> to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_413", new CardDef(new Power
			{
				DeathrattleTask = new AddLackeyTask(1)
			}));

			// ---------------------------------------- MINION - PRIEST
			// [DAL_721] Catrina Muerte - COST:8 [ATK:6/HP:8]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]At the end of your turn,
			//       summon a friendly minion
			//       that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DAL_721", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.TURN_END)
					.SetTask(ComplexTask.SummonRandomMinionThatDied())
			}));

			// ---------------------------------------- MINION - PRIEST
			// [DAL_729] Madame Lazul - COST:3 [ATK:3/HP:2]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Discover</b> a
			//       copy of a card in your
			//       opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_729", new CardDef(new Power
			{
				// TODO [DAL_729] Madame Lazul && Test: Madame Lazul_DAL_729
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DAL_011] Lazul's Scheme - COST:0
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Reduce the Attack of an enemy minion by
			//       @ until your next turn. <i>(Upgrades each turn!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_011", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Scheme(
					new AddEnchantmentTask("DAL_011e", EntityType.TARGET, true)),
				Trigger = TriggerLibrary.UpgradeEachTurn
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DAL_065] Unsleeping Soul - COST:4
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Silence</b> a friendly minion, then summon a copy of it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("DAL_065", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO SummonSide
				PowerTask = ComplexTask.Create(
					new SilenceTask(EntityType.TARGET),
					new SummonCopyTask(EntityType.TARGET))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DAL_723] Forbidden Words - COST:0
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Spend all your Mana.
			//       Destroy a minion with that
			//       much Attack or less.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ85 = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_723", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ85,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.SpendAllManaTask(ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.TARGET, 0, 1),
					new NumberConditionTask(RelaSign.GEQ),
					new FlagTask(true, new DestroyTask(EntityType.TARGET))))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DAL_724] Mass Resurrection - COST:9
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 3 friendly minions that died
			//       this game.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			cards.Add("DAL_724", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1},{PlayReq.REQ_FRIENDLY_MINION_DIED_THIS_GAME,0}}, new Power
			{
				PowerTask = ComplexTask.SummonRandomMinionThatDied(amount: 3)
			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [DAL_030e] Shade (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: 2/2.
			// --------------------------------------------------------
			cards.Add("DAL_030e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_030e")
			}));

		}

		private static void Rogue(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [DAL_415] EVIL Miscreant - COST:3 [ATK:1/HP:5]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Add two random <b>Lackeys</b> to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_415", new CardDef(new Power
			{
				ComboTask = new AddLackeyTask(2)
			}));

			// ----------------------------------------- MINION - ROGUE
			// [DAL_416] Hench-Clan Burglar - COST:4 [ATK:4/HP:3]
			// - Race: pirate, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a spell from another class.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_416", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(CardType.SPELL, CardClass.ANOTHER_CLASS)
			}));

			// ----------------------------------------- MINION - ROGUE
			// [DAL_417] Heistbaron Togwaggle - COST:6 [ATK:5/HP:5]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a_<b>Lackey</b>, choose a fantastic treasure.
			// --------------------------------------------------------
			// Entourage: LOOT_998h, LOOT_998j, LOOT_998l, LOOT_998k
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - MULTIPLY_BUFF_VALUE = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_417", new CardDef(new[] {"LOOT_998h","LOOT_998j","LOOT_998l","LOOT_998k"}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE,
						SelfCondition.IsControllingLackey),
					new FlagTask(true, new DiscoverTask(DiscoverType.HEISTBARON_TOGWAGGLE, numberOfChoices: 4)))
			}));

			// ----------------------------------------- MINION - ROGUE
			// [DAL_714] Underbelly Fence - COST:2 [ATK:2/HP:3]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you're holding
			//       a card from another class,
			//       _gain +1/+1 and <b><b>Rush</b>.</b>
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_714", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.HoldingAnotherClassCard,
					new AddEnchantmentTask("DAL_714e", EntityType.SOURCE))
			}));

			// ----------------------------------------- MINION - ROGUE
			// [DAL_719] Tak Nozwhisker - COST:7 [ATK:6/HP:6]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Whenever you shuffle a
			//       card into your deck, add
			//       a copy to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DAL_719", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.SHUFFLE_INTO_DECK)
					.SetTask(new CopyTask(EntityType.TARGET, Zone.HAND))
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_010] Togwaggle's Scheme - COST:1
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Choose a minion. Shuffle @ |4(copy, copies) of it into your deck.
			//       <i>(Upgrades each turn!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_010", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Scheme(
					new EnqueueNumberTask(new CopyTask(EntityType.TARGET, Zone.DECK))),
				Trigger = TriggerLibrary.UpgradeEachTurn
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_366] Unidentified Contract - COST:6
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. Gains a bonus effect in_your hand.
			// --------------------------------------------------------
			// Entourage: DAL_366t1, DAL_366t2, DAL_366t3, DAL_366t4
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_366", new CardDef(new[] {"DAL_366t1","DAL_366t2","DAL_366t3","DAL_366t4"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DestroyTask(EntityType.TARGET),
				Trigger = TriggerLibrary.RevealUnidentifiedItem
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_716] Vendetta - COST:4
			// - Fac: neutral, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $4 damage to a minion. Costs (0) if you're holding a card from another class. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_716", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DamageTask(4, EntityType.TARGET),
				Aura = new AdaptiveCostEffect(
					p => 0,
					@operator: EffectOperator.SET,
					condition: SelfCondition.HoldingAnotherClassCard)
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_728] Daring Escape - COST:1
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Return all friendly minions to your hand.
			// --------------------------------------------------------
			cards.Add("DAL_728", new CardDef(new Power
			{
				PowerTask = new ReturnHandTask(EntityType.MINIONS)
			}));

			// ----------------------------------------- WEAPON - ROGUE
			// [DAL_720] Waggle Pick - COST:4 [ATK:4/HP:0]
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Return
			//       a random friendly
			//       minion to your hand.
			//       It costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_720", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomTask(1, EntityType.MINIONS),
					new ReturnHandTask(EntityType.STACK),
					new ApplyEffectTask(EntityType.STACK, Effects.ReduceCost(2)))
			}));

		}

		private static void RogueNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [DAL_366t1] Assassin's Contract (*) - COST:6
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. Summon a 1/1 Patient Assassin.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_366t1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.TARGET),
					new SummonTask("EX1_522"))
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_366t2] Recruitment Contract (*) - COST:6
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. Add_a copy of it to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_366t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.TARGET),
					new CopyTask(EntityType.TARGET, Zone.HAND))
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_366t3] Lucrative Contract (*) - COST:6
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. Add 2 Coins to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_366t3", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.TARGET),
					new AddCardTo("GAME_005", EntityType.HAND, 2))
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DAL_366t4] Turncoat Contract (*) - COST:6
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion. It_deals its damage to adjacent minions.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_366t4", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.TARGET),
					SpecificTask.Betrayal)
			}));

		}

		private static void Shaman(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [DAL_047] Walking Fountain - COST:8 [ATK:4/HP:8]
			// - Race: elemental, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>, <b>Rush</b>, <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// - LIFESTEAL = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_047", new CardDef());

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_049] Underbelly Angler - COST:2 [ATK:2/HP:3]
			// - Race: murloc, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: After you play a Murloc, add a random Murloc to your hand.
			// --------------------------------------------------------
			cards.Add("DAL_049", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_PLAY_MINION)
					.SetTask(ComplexTask.Create(
						new RandomCardTask(CardType.MINION, CardClass.INVALID, Race.MURLOC),
						new AddStackTo(EntityType.HAND)))
					.SetCondition(SelfCondition.IsRace(Race.MURLOC))
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_052] Muckmorpher - COST:5 [ATK:4/HP:4]
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Transform into
			//       a 4/4 copy of a different
			//       minion in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_052", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new ChangeEntityTask(EntityType.SOURCE, EntityType.STACK),
					new AddEnchantmentTask("DAL_052e", EntityType.SOURCE))
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_431] Swampqueen Hagatha - COST:7 [ATK:5/HP:5]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Add a 5/5
			//       Horror to your hand. Teach
			//       it two Shaman spells.
			// --------------------------------------------------------
			// Entourage: DAL_431t
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_431", new CardDef(new[] {"DAL_431t"}, new Power
			{
				// TODO [DAL_431] Swampqueen Hagatha && Test: Swampqueen Hagatha_DAL_431
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_433] Sludge Slurper - COST:1 [ATK:2/HP:1]
			// - Race: murloc, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a <b>Lackey</b> to your hand. <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_433", new CardDef(new Power
			{
				PowerTask = new AddLackeyTask(1)
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_726] Scargil - COST:4 [ATK:4/HP:4]
			// - Race: murloc, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your Murlocs cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("DAL_726", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HAND, "DAL_726e")
				{
					Condition = SelfCondition.IsRace(Race.MURLOC)
				}
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DAL_009] Hagatha's Scheme - COST:5
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $@ damage
			//       to all minions.
			//       <i>(Upgrades each turn!)</i> @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			cards.Add("DAL_009", new CardDef(new Power
			{
				PowerTask = ComplexTask.Scheme(new DamageNumberTask(EntityType.ALLMINIONS)),
				Trigger = TriggerLibrary.UpgradeEachTurn
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DAL_071] Mutate - COST:0
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Transform a friendly minion into a random one that costs (1) more.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_071", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new TransformMinionTask(EntityType.TARGET, 1)
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DAL_432] Witch's Brew - COST:2
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Restore #4 Health. Repeatable this turn.
			// --------------------------------------------------------
			// GameTag:
			// - NON_KEYWORD_ECHO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_432", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new HealTask(4, EntityType.TARGET),
					new CustomTask((g, c, s, t, stack) =>
					{
						var echoTags = new EntityData
						{
							{GameTag.GHOSTLY, 1}
						};
						IPlayable echoPlayable = Entity.FromCard(in c, s.Card, echoTags, c.HandZone);
						echoPlayable[GameTag.DISPLAYED_CREATOR] = s.Id;
						c.Game.AuraUpdate();
						c.Game.GhostlyCards.Add(echoPlayable.Id);
					}))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DAL_710] Soul of the Murloc - COST:2
			// - Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions "<b>Deathrattle:</b> Summon a 1/1 Murloc."
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_710", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("DAL_710e", EntityType.MINIONS)
			}));

		}

		private static void ShamanNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [DAL_710e] Soul of the Murloc (*) - COST:0
			// - Fac: neutral, Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 1/1 Murloc.
			// --------------------------------------------------------
			cards.Add("DAL_710e", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("EX1_506a", side: SummonSide.DEATHRATTLE)
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DAL_431t] Drustvar Horror (*) - COST:5 [ATK:5/HP:5]
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Cast {0} and {1}.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_431t", new CardDef(new Power
			{
				// TODO [DAL_431t] Drustvar Horror && Test: Drustvar Horror_DAL_431t
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Warlock(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [DAL_185] Aranasi Broodmother - COST:6 [ATK:4/HP:6]
			// - Race: demon, Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       When you draw this, restore
			//       4 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("DAL_185", new CardDef(new Power
			{
				TopdeckTask = new HealTask(4, EntityType.HERO)
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DAL_422] Arch-Villain Rafaam - COST:7 [ATK:7/HP:8]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b><b>Taunt</b>
			//       Battlecry:</b> Replace your hand and deck with <b>Legendary</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_422", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new IncludeTask(EntityType.DECK, addFlag: true),
					new ChangeEntityTask(EntityType.STACK, CardType.MINION, rarity: Rarity.LEGENDARY))
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DAL_561] Jumbo Imp - COST:10 [ATK:8/HP:8]
			// - Race: demon, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less whenever a friendly Demon dies while this is in your hand.
			// --------------------------------------------------------
			cards.Add("DAL_561", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.DEATH)
					.SetTask(new AddEnchantmentTask("DAL_561e", EntityType.SOURCE))
					.SetCondition(SelfCondition.IsRace(Race.DEMON))
					.SetSource(TriggerSource.FRIENDLY)
					.SetActivation(TriggerActivation.HAND)
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DAL_563] Eager Underling - COST:4 [ATK:2/HP:2]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give two random friendly minions +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_563", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomTask(2, EntityType.MINIONS),
					new AddEnchantmentTask("DAL_563e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DAL_606] EVIL Genius - COST:2 [ATK:2/HP:2]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a friendly minion to add 2 random <b>Lackeys</b>_to_your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_606", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.HasTarget, ComplexTask.Create(
					new DestroyTask(EntityType.TARGET),
					new AddLackeyTask(2)))

			}));

			// --------------------------------------- MINION - WARLOCK
			// [DAL_607] Fel Lord Betrug - COST:8 [ATK:5/HP:7]
			// - Race: demon, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Whenever you draw a
			//       minion, summon a copy
			//        with <b>Rush</b> that dies at
			//       end of turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_607", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.DRAW)
					.SetTask(ComplexTask.Create(
						new CopyTask(EntityType.TARGET, Zone.PLAY, addToStack: true),
						new AddEnchantmentTask("DAL_607e", EntityType.STACK)))
					.SetCondition(SelfCondition.IsMinion)
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DAL_007] Rafaam's Scheme - COST:3
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Summon @ 1/1 |4(Imp, Imps). <i>(Upgrades each turn!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			cards.Add("DAL_007", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Scheme(new SummonNumberTask("DAL_751t", false)),
				Trigger = TriggerLibrary.UpgradeEachTurn
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DAL_173] Darkest Hour - COST:6
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all friendly minions. For each one, summon a random minion from your deck.
			// --------------------------------------------------------
			cards.Add("DAL_173", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new CountTask(EntityType.STACK),
					new DestroyTask(EntityType.STACK, true),
					new EnqueueNumberTask(ComplexTask.Create(
							new IncludeTask(EntityType.DECK),
							new FilterStackTask(SelfCondition.IsMinion),
							new RandomTask(1, EntityType.STACK),
							new SummonStackTask(true))))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DAL_602] Plot Twist - COST:2
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Shuffle your hand
			//       into your deck.
			//       Draw that many cards.
			// --------------------------------------------------------
			cards.Add("DAL_602", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new CountTask(EntityType.STACK),
					new MoveToDeck(EntityType.STACK),
					new DrawNumberTask())
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DAL_605] Impferno - COST:3
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your Demons +1 Attack. Deal $1 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 15
			// --------------------------------------------------------
			cards.Add("DAL_605", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_WITH_RACE,15}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.DEMON)),
					new AddEnchantmentTask("DAL_605e", EntityType.STACK),
					new DamageTask(1, EntityType.OP_MINIONS, true))
			}));

		}

		private static void WarlockNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [DAL_605e] Imptastic (*) - COST:2
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("DAL_605e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_605e")
			}));

		}

		private static void Warrior(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [DAL_060] Clockwork Goblin - COST:3 [ATK:3/HP:3]
			// - Race: mechanical, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Shuffle a Bomb
			//       into your opponent's deck.
			//       When drawn, it explodes
			//       for 5 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_060", new CardDef(new Power
			{
				PowerTask = new AddCardTo("BOT_511t", EntityType.OP_DECK)
			}));

			// --------------------------------------- MINION - WARRIOR
			// [DAL_064] Blastmaster Boom - COST:7 [ATK:7/HP:7]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon two 1/1
			//       Boom Bots for each Bomb
			//       in your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_064", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.OP_DECK),
					new FilterStackTask(SelfCondition.IsCardId("BOT_511t")),
					new CountTask(EntityType.STACK),
					new NumberConditionTask(4, RelaSign.GEQ),
					new FlagTask(true, new FuncNumberTask((IPlayable p) => 3)),
					new EnqueueNumberTask(new SummonTask("GVG_110t", 2, side: SummonSide.ALTERNATE)))
			}));

			// --------------------------------------- MINION - WARRIOR
			// [DAL_070] The Boom Reaver - COST:10 [ATK:7/HP:9]
			// - Race: mechanical, Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a copy of a minion in your deck. Give it <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_070", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new CopyTask(EntityType.STACK, Zone.PLAY, addToStack: true),
					new AddEnchantmentTask("DAL_070e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - WARRIOR
			// [DAL_759] Vicious Scraphound - COST:2 [ATK:2/HP:2]
			// - Race: mechanical, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion
			//       deals damage, gain that much Armor.
			// --------------------------------------------------------
			cards.Add("DAL_759", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.DEAL_DAMAGE)
					.SetTask(ComplexTask.Create(
						new GetEventNumberTask(),
						new ArmorTask()))
					.SetSource(TriggerSource.SELF)
			}));

			// --------------------------------------- MINION - WARRIOR
			// [DAL_770] Omega Devastator - COST:4 [ATK:4/HP:5]
			// - Race: mechanical, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you have 10
			//       Mana Crystals, deal 10
			//       damage to a minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_MANA_CRYSTAL = 10
			// --------------------------------------------------------
			cards.Add("DAL_770", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_MANA_CRYSTAL,10}}, new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.IsManaCrystalFull, new DamageTask(10, EntityType.TARGET))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DAL_008] Dr. Boom's Scheme - COST:4
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Gain @ Armor.
			//       <i>(Upgrades each turn!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			cards.Add("DAL_008", new CardDef(new Power
			{
				PowerTask = ComplexTask.Scheme(new ArmorTask()),
				Trigger = TriggerLibrary.UpgradeEachTurn
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DAL_059] Dimensional Ripper - COST:10
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 2 copies of a minion in your deck.
			// --------------------------------------------------------
			cards.Add("DAL_059", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new CopyTask(EntityType.STACK, Zone.PLAY, 2))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DAL_062] Sweeping Strikes - COST:2
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion "Also damages minions next to whomever this attacks."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_062", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("DAL_062e", EntityType.TARGET)
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DAL_769] Improve Morale - COST:1
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Deal $1 damage
			//       to a minion.
			//       If it survives, add a
			//       <b>Lackey</b> to your hand. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_769", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(1, EntityType.TARGET, true),
					new ConditionTask(EntityType.TARGET, SelfCondition.IsNotDead),
					new FlagTask(true, new AddLackeyTask(1)))
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [DAL_063] Wrenchcalibur - COST:4 [ATK:3/HP:0]
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: After your hero attacks, shuffle a Bomb into your [x]opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("DAL_063", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_ATTACK)
					.SetTask(new AddCardTo("BOT_511t", EntityType.OP_DECK))
					.SetSource(TriggerSource.HERO)
			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [DAL_062e] Sweeping Strikes (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Damages minions adjacent to defender.
			// --------------------------------------------------------
			cards.Add("DAL_062e", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_ATTACK)
					.SetTask(ComplexTask.Create(
						new IncludeAdjacentTask(EntityType.EVENT_TARGET),
						new GetGameTagTask(GameTag.ATK, EntityType.TARGET),
						new DamageNumberTask(EntityType.STACK)))
					.SetSource(TriggerSource.ENCHANTMENT_TARGET)
					.SetCondition(SelfCondition.IsEventTargetIs(CardType.MINION))
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [DAL_070e] Reaving (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Has <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("DAL_070e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_070e")
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [DAL_742e] Whirling (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Mega-Windfury</b>
			// --------------------------------------------------------
			cards.Add("DAL_742e", new CardDef(new Power
			{
				// TODO [DAL_742e] Whirling && Test: Whirling_DAL_742e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_742e")
			}));

		}

		private static void Neutral(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [DAL_058] Hecklebot - COST:4 [ATK:3/HP:8]
			// - Race: mechanical, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Your opponent summons a minion from their deck.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_058", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.OP_DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new SummonStackTask(true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_077] Toxfin - COST:1 [ATK:1/HP:2]
			// - Race: murloc, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Murloc <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 14
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("DAL_077", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_TARGET_WITH_RACE,14}}, new Power
			{
				PowerTask = new AddEnchantmentTask("DAL_077e", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_078] Travelling Healer - COST:4 [ATK:3/HP:2]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>
			//       <b>Battlecry:</b> Restore #3 Health.
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("DAL_078", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				PowerTask = new HealTask(3, EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_081] Spellward Jeweler - COST:3 [ATK:3/HP:4]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Your hero can't
			//       be targeted by spells or
			//       Hero Powers until your
			//       next turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_081", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("DAL_081e", EntityType.HERO)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_085] Dalaran Crusader - COST:5 [ATK:5/HP:4]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("DAL_085", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_086] Sunreaver Spy - COST:2 [ATK:2/HP:3]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DAL_086", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.IsControllingSecret,
					new AddEnchantmentTask("DAL_086e", EntityType.SOURCE))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_087] Hench-Clan Hag - COST:4 [ATK:3/HP:3]
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/1 Amalgams with all minion types.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_087", new CardDef(new Power
			{
				PowerTask = new SummonTask("DAL_087t", 2, SummonSide.ALTERNATE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_088] Safeguard - COST:6 [ATK:4/HP:5]
			// - Race: mechanical, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Deathrattle:</b> Summon a 0/5
			//       Vault Safe with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_088", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("DAL_088t2", SummonSide.DEATHRATTLE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_089] Spellbook Binder - COST:2 [ATK:3/HP:2]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have <b>Spell Damage</b>, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_089", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.IsSpellDmgOnHero, new DrawTask())
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_090] Hench-Clan Sneak - COST:3 [ATK:3/HP:3]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("DAL_090", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_092] Arcane Servant - COST:2 [ATK:2/HP:3]
			// - Race: elemental, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			cards.Add("DAL_092", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_095] Violet Spellsword - COST:4 [ATK:1/HP:6]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain +1 Attack
			//       for each spell in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_095", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsSpell),
					new CountTask(EntityType.STACK),
					new AddEnchantmentTask("DAL_095e", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_096] Violet Warden - COST:6 [ATK:4/HP:7]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_096", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_400] EVIL Cable Rat - COST:2 [ATK:1/HP:1]
			// - Race: beast, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a <b>Lackey</b> to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_400", new CardDef(new Power
			{
				PowerTask = new AddLackeyTask(1)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_434] Arcane Watcher - COST:3 [ATK:5/HP:6]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Can't attack unless you have <b>Spell Damage</b>.
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_434", new CardDef(new Power
			{
				Aura = new AdaptiveEffect(SelfCondition.IsntSpellDmgOnHero, GameTag.CANT_ATTACK)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_538] Unseen Saboteur - COST:6 [ATK:5/HP:6]
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your opponent casts a random spell from their hand <i>(targets chosen randomly)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_538", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.OP_HAND),
					new FilterStackTask(SelfCondition.IsSpell),
					new RandomTask(1, EntityType.STACK),
					new PlayTask(PlayType.SPELL, true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_539] Sunreaver Warmage - COST:5 [ATK:4/HP:4]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a spell that costs (5) or more, deal 4 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_DRAG_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_539", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_DRAG_TO_PLAY_PRE31761,0}}, new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.Has5PlusCostSpellInHand,
					new DamageTask(4, EntityType.TARGET))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_544] Potion Vendor - COST:1 [ATK:1/HP:1]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore #2 Health to all friendly characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_544", new CardDef(new Power
			{
				PowerTask = new HealTask(2, EntityType.FRIENDS)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_546] Barista Lynchen - COST:5 [ATK:4/HP:5]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a copy of each of your other <b>Battlecry</b> minions_to_your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_546", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS_NOSOURCE),
					new FilterStackTask(SelfCondition.IsBattleCryCard),
					new CopyTask(EntityType.STACK, Zone.HAND))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_548] Azerite Elemental - COST:5 [ATK:2/HP:7]
			// - Race: elemental, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: At the start of your turn, gain <b>Spell Damage +2</b>.
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_548", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.TURN_START)
					.SetTask(new AddEnchantmentTask("DAL_548e", EntityType.SOURCE))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_550] Underbelly Ooze - COST:7 [ATK:3/HP:5]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: After this minion survives damage, summon a copy_of it.
			// --------------------------------------------------------
			cards.Add("DAL_550", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.TAKE_DAMAGE)
					.SetTask(new CopyTask(EntityType.SOURCE, Zone.PLAY))
					.SetSource(TriggerSource.SELF)
					.SetCondition(SelfCondition.IsNotDead)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_551] Proud Defender - COST:4 [ATK:2/HP:6]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Has +2 Attack while you [x]have no other minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DAL_551", new CardDef(new Power
			{
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.ADD,
					p => p.Controller.BoardZone.Count == 1 ? 2 : 0)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_553] Big Bad Archmage - COST:10 [ATK:6/HP:6]
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a random
			//       6-Cost minion.
			// --------------------------------------------------------
			cards.Add("DAL_553", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.TURN_END)
					.SetTask(ComplexTask.SummonRandomMinion(GameTag.COST, 6))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_554] Chef Nomi - COST:7 [ATK:6/HP:6]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck is empty, summon six 6/6 Greasefire_Elementals.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_554", new CardDef(new Power
			{
				PowerTask = ComplexTask.Conditional(SelfCondition.IsHandEmpty,
					new SummonTask("DAL_554t", 6, SummonSide.ALTERNATE))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_558] Archmage Vargoth - COST:4 [ATK:2/HP:6]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]At the end of your turn, cast
			//       a spell you've cast this turn
			//       <i>(targets are random)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DAL_558", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.TURN_END)
					.SetTask(SpecificTask.ArchmageVargoth)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_560] Heroic Innkeeper - COST:8 [ATK:4/HP:4]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt.</b> <b>Battlecry:</b> Gain +2/+2 for each other friendly minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_560", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new FuncNumberTask(p => 2 * (p.Controller.BoardZone.Count - 1)),
					new AddEnchantmentTask("DAL_560e2", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_565] Portal Overfiend - COST:6 [ATK:5/HP:6]
			// - Race: demon, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Shuffle 3 Portals
			//       into your deck. When drawn,
			//       summon a 2/2 Demon
			//       with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_565", new CardDef(new Power
			{
				PowerTask = new AddCardTo("DAL_582t", EntityType.DECK, 3)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_566] Eccentric Scribe - COST:6 [ATK:6/HP:4]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon
			//       four 1/1 Vengeful Scrolls.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_566", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("DAL_566t", 4, SummonSide.DEATHRATTLE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_582] Portal Keeper - COST:4 [ATK:5/HP:2]
			// - Race: demon, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Shuffle 3 Portals
			//       into your deck. When drawn,
			//       summon a 2/2 Demon
			//       with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_582", new CardDef(new Power
			{
				PowerTask = new AddCardTo("DAL_582t", EntityType.DECK, 3)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_592] Batterhead - COST:8 [ATK:3/HP:12]
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Rush</b>. After this attacks and kills a minion, it may_attack again.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_592", new CardDef(new Power
			{
				// TODO: Extra_Attacks_This_Turn
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_ATTACK)
					.SetTask(new SetGameTagTask(GameTag.EXHAUSTED, 0, EntityType.SOURCE))
					.SetCondition(SelfCondition.IsDefenderDead)
					.SetSource(TriggerSource.SELF)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_735] Dalaran Librarian - COST:2 [ATK:2/HP:3]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b>
			//       adjacent minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("DAL_735", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeAdjacentTask(EntityType.SOURCE),
					new SilenceTask(EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_736] Archivist Elysiana - COST:8 [ATK:7/HP:7]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> 5 cards. Replace your deck with 2_copies of each.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_736", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(choiceAction: ChoiceAction.STACK,
					afterDiscoverTask: ComplexTask.Create(
						new MoveToSetaside(EntityType.DECK),
						new CopyTask(EntityType.STACK, Zone.DECK, 2)),
					repeat: 5)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_742] Whirlwind Tempest - COST:8 [ATK:6/HP:6]
			// - Race: elemental, Fac: neutral, Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: Your minions with <b>Windfury</b> have <b>Mega-Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// - MEGA_WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("DAL_742", new CardDef(new Power
			{
				// TODO [DAL_742] Whirlwind Tempest && Test: Whirlwind Tempest_DAL_742
				InfoCardId = "DAL_742e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_743] Hench-Clan Hogsteed - COST:2 [ATK:2/HP:1]
			// - Race: beast, Fac: neutral, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Deathrattle:</b> Summon a 1/1 Murloc.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_743", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("DAL_743t", SummonSide.DEATHRATTLE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_744] Faceless Rager - COST:3 [ATK:5/HP:1]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Copy a friendly minion's Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_744", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.HEALTH, EntityType.TARGET),
					new GetGameTagTask(GameTag.DAMAGE, EntityType.TARGET, 0, 1),
					new MathNumberIndexTask(0, 1, MathOperation.SUB),
					new AddEnchantmentTask("DAL_744e", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_747] Flight Master - COST:3 [ATK:3/HP:4]
			// - Fac: alliance, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/2 Gryphon for each player.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_747", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonTask("DAL_747t"),
					new SummonOpTask("DAL_747t"))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_748] Mana Reservoir - COST:2 [ATK:0/HP:6]
			// - Race: elemental, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DAL_748", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_749] Recurring Villain - COST:5 [ATK:3/HP:6]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If this minion has 4 or more Attack, resummon it.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_749", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsTagValue(GameTag.ATK, 4, RelaSign.GEQ)),
					new FlagTask(true, new SummonTask("DAL_749", 1, SummonSide.DEATHRATTLE)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_751] Mad Summoner - COST:6 [ATK:4/HP:4]
			// - Race: demon, Fac: alliance, Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Fill each player's
			//       board with 1/1 Imps.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_751", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new CountTask(Zone.PLAY, true, false),
					new SummonNumberTask("DAL_751t", false),
					new CountTask(Zone.PLAY, true, true),
					new SummonNumberTask("DAL_751t", true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_752] Jepetto Joybuzz - COST:8 [ATK:6/HP:6]
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw 2 minions from your deck. Set their Attack, Health, and Cost to 1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DAL_752", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DrawMinionTask(false, 2, true),
					new AddEnchantmentTask("DAL_752e", EntityType.STACK),
					new AddEnchantmentTask("DAL_752e2", EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_760] Burly Shovelfist - COST:9 [ATK:9/HP:9]
			// - Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_760", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_771] Soldier of Fortune - COST:4 [ATK:5/HP:6]
			// - Race: elemental, Set: dalaran, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion attacks, give your opponent a Coin.
			// --------------------------------------------------------
			cards.Add("DAL_771", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.ATTACK)
					.SetTask(new AddCardTo("GAME_005", EntityType.OP_HAND, 2))
					.SetSource(TriggerSource.SELF)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_773] Magic Carpet - COST:3 [ATK:1/HP:6]
			// - Set: dalaran, Rarity: epic
			// --------------------------------------------------------
			// Text: After you play a 1-Cost minion, give it +1 Attack and <b>Rush</b>.
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_773", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.AFTER_PLAY_MINION)
					.SetTask(new AddEnchantmentTask("DAL_773e", EntityType.TARGET))
					.SetCondition(SelfCondition.IsTagValue(GameTag.TAG_LAST_KNOWN_COST_IN_HAND, 1))
					.SetSource(TriggerSource.FRIENDLY)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_774] Exotic Mountseller - COST:7 [ATK:5/HP:8]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a random
			//       3-Cost Beast.
			// --------------------------------------------------------
			cards.Add("DAL_774", new CardDef(new Power
			{
				Trigger = TriggerBuilder.Type(TriggerType.CAST_SPELL)
					.SetTask(ComplexTask.SummonRandomMinion(GameTag.COST, 3))
					.SetSource(TriggerSource.FRIENDLY)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_775] Tunnel Blaster - COST:7 [ATK:3/HP:7]
			// - Set: dalaran, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Deathrattle:</b> Deal 3 damage
			//       to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DAL_775", new CardDef(new Power
			{
				DeathrattleTask = new DamageTask(3, EntityType.ALLMINIONS)
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_011e] Lazul's Curse (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Reduced Attack.
			// --------------------------------------------------------
			cards.Add("DAL_011e", new CardDef(new Power
			{
				Enchant = new Enchant(ATK.Effect(EffectOperator.SUB, 0))
				{
					UseScriptTag = true
				},
				Trigger = TriggerBuilder.Type(TriggerType.TURN_START)
					.SetTask(RemoveEnchantmentTask.Task)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_052e] Muckmorphing (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: 4/4.
			// --------------------------------------------------------
			cards.Add("DAL_052e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_052e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_077e] Toxic Fin (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("DAL_077e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_077e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_081e] Sparkly (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("DAL_081e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.CantBeTargetedBySpellsAndHeroPowers),
				Trigger = TriggerBuilder.Type(TriggerType.TURN_START)
					.SetTask(RemoveEnchantmentTask.Task)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_086e] Stolen Secrets (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: +1/+1
			// --------------------------------------------------------
			cards.Add("DAL_086e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_086e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_095e] Pizzazz (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("DAL_095e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_147e] Dragon Shout (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("DAL_147e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_147e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_351e] Ancient Blessings (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("DAL_351e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_351e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_548e] Arcane Expansion (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Increased <b>Spell Damage</b>.
			// --------------------------------------------------------
			cards.Add("DAL_548e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(new Effect(GameTag.SPELLPOWER, EffectOperator.ADD, 2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_560e2] Protect the Brews! (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("DAL_560e2", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_561e] Imp-onomical (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("DAL_561e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.ReduceCost(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_563e] Power of EVIL (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("DAL_563e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_563e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_570e] Never Surrender! (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("DAL_570e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_570e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_576e] Kirin Tor's Curse (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Costs (1) more.
			// --------------------------------------------------------
			cards.Add("DAL_576e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.AddCost(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_589e] Hunting Party (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("DAL_589e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_589e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_607e] Fleeting Fel (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Rush</b>. Dies at end of turn.
			// --------------------------------------------------------
			cards.Add("DAL_607e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.Rush),
				Trigger = TriggerBuilder.Type(TriggerType.TURN_END)
					.SetTask(new DestroyTask(EntityType.TARGET))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_714e] Street Smarts (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("DAL_714e", new CardDef(new Power
			{
				Enchant = new Enchant(
					Effects.Attack_N(1),
					Effects.Health_N(1),
					Effects.Rush)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_726e] Scargil's Blessing (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("DAL_726e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetCost(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_727e] Heroic (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("DAL_727e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_727e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_739e] Short Fuse (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("DAL_739e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_739e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_744e] Familiar Faces (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Copied health.
			// --------------------------------------------------------
			cards.Add("DAL_744e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.SetHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_752e] Toy-sized (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Jepetto Joybuzz made this 1/1.
			// --------------------------------------------------------
			cards.Add("DAL_752e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_752e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_752e2] On Sale (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("DAL_752e2", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetCost(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DAL_773e] Flying High (*) - COST:0
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("DAL_773e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DAL_773e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_087t] Amalgam (*) - COST:1 [ATK:1/HP:1]
			// - Race: all, Set: dalaran,
			// --------------------------------------------------------
			// Text: [x]<i>This is an Elemental, Mech,
			//       Demon, Murloc, Dragon,
			//       Beast, Pirate and Totem.</i>
			// --------------------------------------------------------
			cards.Add("DAL_087t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_088t2] Vault Safe (*) - COST:2 [ATK:0/HP:5]
			// - Race: mechanical, Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DAL_088t2", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_554t] Greasefire Elemental (*) - COST:6 [ATK:6/HP:6]
			// - Race: elemental, Fac: neutral, Set: dalaran,
			// --------------------------------------------------------
			cards.Add("DAL_554t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_566t] Vengeful Scroll (*) - COST:1 [ATK:1/HP:1]
			// - Set: dalaran,
			// --------------------------------------------------------
			cards.Add("DAL_566t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_582t2] Felhound (*) - COST:2 [ATK:2/HP:2]
			// - Race: demon, Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_582t2", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_613] Faceless Lackey (*) - COST:1 [ATK:1/HP:1]
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a random 2-Cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DAL_613", new CardDef(new Power
			{
				PowerTask = ComplexTask.SummonRandomMinionNumberTag(GameTag.COST)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_614] Kobold Lackey (*) - COST:1 [ATK:1/HP:1]
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DAL_614", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_615] Witchy Lackey (*) - COST:1 [ATK:1/HP:1]
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform a friendly minion into one that costs (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DAL_615", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new TransformMinionTask(EntityType.TARGET, 1)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_739] Goblin Lackey (*) - COST:1 [ATK:1/HP:1]
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +1 Attack and_<b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DAL_739", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("DAL_739e", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_741] Ethereal Lackey (*) - COST:1 [ATK:1/HP:1]
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("DAL_741", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.SPELL)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_743t] Hench-Clan Squire (*) - COST:1 [ATK:1/HP:1]
			// - Race: murloc, Set: dalaran,
			// --------------------------------------------------------
			cards.Add("DAL_743t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_747t] Gryphon (*) - COST:2 [ATK:2/HP:2]
			// - Race: beast, Fac: alliance, Set: dalaran,
			// --------------------------------------------------------
			cards.Add("DAL_747t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [DAL_751t] Imp (*) - COST:1 [ATK:1/HP:1]
			// - Race: demon, Fac: neutral, Set: dalaran,
			// --------------------------------------------------------
			cards.Add("DAL_751t", new CardDef());

			// ---------------------------------------- SPELL - NEUTRAL
			// [DAL_582t] Felhound Portal (*) - COST:2
			// - Set: dalaran,
			// --------------------------------------------------------
			// Text: <b>Casts When Drawn</b>
			//       Summon a 2/2 Felhound with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// - CASTSWHENDRAWN = 1
			// --------------------------------------------------------
			cards.Add("DAL_582t", new CardDef(new Power
			{
				TopdeckTask = new SummonTask("DAL_582t2"),
				PowerTask = new SummonTask("DAL_582t2")
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
