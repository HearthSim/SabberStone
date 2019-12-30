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

namespace SabberStoneCore.CardSets
{
	public static class IcecrownCardsGen
	{
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ HERO - SHAMAN
			// [ICC_481] Thrall, Deathseer - COST:5 [ATK:0/HP:30]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform your minions into random ones that cost (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 42982
			// --------------------------------------------------------
			cards.Add("ICC_481", new CardDef(new Power
			{
				PowerTask = new TransformMinionTask(EntityType.MINIONS, 2)
			}));

			// ------------------------------------------- HERO - ROGUE
			// [ICC_827] Valeera the Hollow - COST:9 [ATK:0/HP:30]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 43188
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("ICC_827", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_827e3", EntityType.HERO)
			}));

			// ------------------------------------------ HERO - HUNTER
			// [ICC_828] Deathstalker Rexxar - COST:6 [ATK:0/HP:30]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 2 damage
			//       to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 43183
			// --------------------------------------------------------
			cards.Add("ICC_828", new CardDef(new Power
			{
				PowerTask = new DamageTask(2, EntityType.OP_MINIONS)
			}));

			// ----------------------------------------- HERO - PALADIN
			// [ICC_829] Uther of the Ebon Blade - COST:9 [ATK:0/HP:30]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip a 5/3 <b>Lifesteal</b> weapon.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 43013
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_829", new CardDef(new Power
			{
				PowerTask = new WeaponTask("ICC_829t"),
			}));

			// ------------------------------------------ HERO - PRIEST
			// [ICC_830] Shadowreaper Anduin - COST:8 [ATK:0/HP:30]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all minions with 5 or more_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 45397
			// --------------------------------------------------------
			cards.Add("ICC_830", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS),
					new FilterStackTask(SelfCondition.IsTagValue(GameTag.ATK, 5, RelaSign.GEQ)),
					new DestroyTask(EntityType.STACK))
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [ICC_831] Bloodreaver Gul'dan - COST:10 [ATK:0/HP:30]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon all friendly Demons that_died_this_game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 43181
			// --------------------------------------------------------
			cards.Add("ICC_831", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.GRAVEYARD),
					new FilterStackTask(SelfCondition.IsRace(Race.DEMON), SelfCondition.IsDead),
					//new CopyTask(EntityType.STACK, 1),
					new SummonCopyTask(EntityType.STACK, true))
			}));

			// ------------------------------------------- HERO - DRUID
			// [ICC_832] Malfurion the Pestilent - COST:7 [ATK:0/HP:30]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Choose One -</b>
			//       Summon 2 <b>Poisonous</b>
			//       Spiders; or 2 Scarabs
			//       with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - ARMOR = 5
			// - HERO_POWER = 43182
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_832",
				//CHOOSE_ONE
				new CardDef());

			// -------------------------------------------- HERO - MAGE
			// [ICC_833] Frost Lich Jaina - COST:9 [ATK:0/HP:30]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon a
			//       3/6 Water Elemental.
			//       Your Elementals have
			//       <b>Lifesteal</b> this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 42944
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_833", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("ICC_833e", EntityType.CONTROLLER),
					new SummonTask("ICC_833t"))
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [ICC_834] Scourgelord Garrosh - COST:8 [ATK:0/HP:30]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: Equip a 4/3_Shadowmourne that also damages adjacent minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 45585
			// --------------------------------------------------------
			cards.Add("ICC_834", new CardDef(new Power
			{
				PowerTask = new WeaponTask("ICC_834w")
			}));

		}

		private static void HeroPowers(Dictionary<string, CardDef> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_481p] Transmute Spirit (*) - COST:2
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Hero Power:</b> Transform a friendly minion into a random one that costs (1) more.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_481p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new TransformMinionTask(EntityType.TARGET, 1)
			}));

			// ------------------------------------- HERO_POWER - ROGUE
			// [ICC_827p] Death's Shadow (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       During your turn, add a 'Shadow Reflection' to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("ICC_827p", new CardDef(new Power
			{
				PowerTask = SpecificTask.DeathsShadow,
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = SpecificTask.DeathsShadow
				}
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_828p] Build-A-Beast (*) - COST:2
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Craft a custom Zombeast.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("ICC_828p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				PowerTask = SpecificTask.BuildABeast
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_829p] The Four Horsemen (*) - COST:2
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Summon a 2/2 Horseman.
			//       If you have all 4, destroy
			//       the enemy hero.
			// --------------------------------------------------------
			// Entourage: ICC_829t2, ICC_829t3, ICC_829t4, ICC_829t5
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("ICC_829p", new CardDef(new[] {"ICC_829t2","ICC_829t3","ICC_829t4","ICC_829t5"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = SpecificTask.TotemicCall,
				Trigger = new Trigger(TriggerType.AFTER_SUMMON)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = new SelfCondition(p =>
					{
						if (p.Controller.BoardZone.Count < 4)
							return false;
						string[] boards = p.Controller.BoardZone.Select(m => m.Card.Id).OrderBy(x => x).ToArray();
						for (int i = 0; i < boards.Length - 3; i++)
							if (boards[i] == "ICC_829t2")
								return boards[i + 3] == "ICC_829t5";
						return false;
					}),
					SingleTask = new DestroyTask(EntityType.OP_HERO)
				}
			}));

			// ------------------------------------ HERO_POWER - PRIEST
			// [ICC_830p] Voidform (*) - COST:2
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage.
			//       After you play a card,
			//       refresh this. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_830p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET),
				Trigger = new Trigger(TriggerType.AFTER_PLAY_CARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new SetGameTagTask(GameTag.EXHAUSTED, 0, EntityType.SOURCE)
				}
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_831p] Siphon Life (*) - COST:2
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Lifesteal</b>
			//       Deal $3 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_831p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(3, EntityType.TARGET)
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_832p] Plague Lord (*) - COST:2
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       <b>Choose One -</b> +3 Attack
			//       this turn; or Gain 3 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_832p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_833h] Icy Touch (*) - COST:2
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Deal $1 damage. If this kills a minion, summon a Water Elemental. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_833h", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(1, EntityType.TARGET),
					new ConditionTask(EntityType.TARGET, SelfCondition.IsDead),
					new FlagTask(true, new SummonTask("ICC_833t")))
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [ICC_834h] Bladestorm (*) - COST:2
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Deal $1 damage to all_minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("ICC_834h", new CardDef(new Power
			{
				PowerTask = new DamageTask(1, EntityType.ALLMINIONS)
			}));

		}

		private static void DeathknightNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t2] Army of the Dead (*) - COST:6
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Remove the top 5 cards of your deck. Summon any minions removed.
			// --------------------------------------------------------
			cards.Add("ICC_314t2", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(5, ComplexTask.Create(
					new IncludeTask(EntityType.TOPCARDFROMDECK),
					new ConditionTask(EntityType.STACK, SelfCondition.IsMinion),
					new FlagTask(true, new RemoveFromDeck(EntityType.STACK)),
					new FlagTask(true, new SummonTask(SummonSide.DEFAULT, null, true)),
					new FlagTask(false, new MoveToGraveYard(EntityType.STACK))))
			}));


			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t3] Doom Pact (*) - COST:5
			// - Fac: neutral, Set: icecrown,
			// --------------------------------------------------------
			// Text: [x]Destroy all minions.
			//       Remove the top card
			//       from your deck for each
			//       minion destroyed.
			// --------------------------------------------------------
			cards.Add("ICC_314t3", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new CountTask(EntityType.ALLMINIONS),
					new DestroyTask(EntityType.ALLMINIONS),
					new EnqueueNumberTask(ComplexTask.Create(
						new IncludeTask(EntityType.TOPCARDFROMDECK),
						new MoveToGraveYard(EntityType.STACK))))
			}));

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t4] Death Grip (*) - COST:2
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Steal a minion from your opponent's deck and add it to your hand.
			// --------------------------------------------------------
			cards.Add("ICC_314t4", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.OP_DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new FuncPlayablesTask(p =>
					{
						if (p.Count == 0)
							return new List<IPlayable>();
						// reveal ?
						p[0].Controller.DeckZone.Remove(p[0]);
						p[0].Controller = p[0].Controller.Opponent;
						p[0][GameTag.CONTROLLER] = p[0].Controller.PlayerId;
						return new List<IPlayable>() { p[0] };
					}),
					new AddStackTo(EntityType.HAND))
			}));

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t5] Death Coil (*) - COST:2
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Deal $5 damage to an enemy, or restore #5 Health to a friendly character. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_314t5", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.TARGET, RelaCondition.IsFriendly),
					new FlagTask(false, new DamageTask(5, EntityType.TARGET, true)),
					new FlagTask(true, new HealTask(5, EntityType.TARGET)))
			}));

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t6] Obliterate (*) - COST:2
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Destroy a minion. Your hero takes damage equal to its Health.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_314t6", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.HEALTH, EntityType.TARGET),
					new GetGameTagTask(GameTag.DAMAGE, EntityType.TARGET, 0, 1),
					new MathNumberIndexTask(0, 1, MathOperation.SUB),
					new DestroyTask(EntityType.TARGET),
					new DamageNumberTask(EntityType.HERO))
			}));

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t7] Anti-Magic Shell (*) - COST:4
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Give your minions +2/+2 and "Can't be targeted by spells or Hero Powers."
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("ICC_314t7", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_314t7e", EntityType.MINIONS)
			}));

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t8] Death and Decay (*) - COST:3
			// - Fac: neutral, Set: icecrown,
			// --------------------------------------------------------
			// Text: Deal $3 damage to all enemies. @spelldmg
			// --------------------------------------------------------
			cards.Add("ICC_314t8", new CardDef(new Power
			{
				PowerTask = new DamageTask(3, EntityType.ENEMIES, true)
			}));

			// ----------------------------------- WEAPON - DEATHKNIGHT
			// [ICC_314t1] Frostmourne (*) - COST:7 [ATK:5/HP:0]
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon every minion killed by this weapon.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_314t1", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					Condition = SelfCondition.IsDefenderDead,
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.EVENT_TARGET, SelfCondition.IsMinion),
						new FlagTask(true, ComplexTask.Create(
						new GetGameTagTask(GameTag.ENTITY_ID, EntityType.EVENT_TARGET),
						new AddEnchantmentTask("ICC_314t1e", EntityType.SOURCE, false, true))))
				}
			}));

		}

		private static void Druid(Dictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [ICC_047] Fatespinner - COST:5 [ATK:5/HP:3]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Choose a Deathrattle (Secretly) -</b> Deal 3 damage to all minions; or Give them +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// - 818 = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_047", new CardDef(new Power
			{
				PowerTask = new SetGameTagTask(GameTag.DEATHRATTLE, 1, EntityType.SOURCE),
				DeathrattleTask = ComplexTask.Create(
					new DamageTask(3, EntityType.ALLMINIONS),
					new AddEnchantmentTask("ICC_047e", EntityType.ALLMINIONS))
			}));

			// ----------------------------------------- MINION - DRUID
			// [ICC_051] Druid of the Swarm - COST:2 [ATK:1/HP:2]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Transform into a 1/2 with <b>Poisonous</b>; or a 1/5 with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_051", new CardDef(new Power
			{
				PowerTask = new TransformTask("ICC_051t3", EntityType.SOURCE)
			}));

			// ----------------------------------------- MINION - DRUID
			// [ICC_807] Strongshell Scavenger - COST:4 [ATK:2/HP:3]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your <b>Taunt</b> minions +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_807", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS_NOSOURCE),
					new FilterStackTask(SelfCondition.IsTagValue(GameTag.TAUNT, 1)),
					new AddEnchantmentTask("ICC_807e", EntityType.STACK))
			}));

			// ----------------------------------------- MINION - DRUID
			// [ICC_808] Crypt Lord - COST:3 [ATK:1/HP:6]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       After you summon a minion,
			//        gain +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_808", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_SUMMON)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("ICC_808e", EntityType.SOURCE)
				}
			}));

			// ----------------------------------------- MINION - DRUID
			// [ICC_835] Hadronox - COST:9 [ATK:3/HP:7]
			// - Race: beast, Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon your <b>Taunt</b> minions that
			//       died this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_835", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.GRAVEYARD),
					new FilterStackTask(SelfCondition.IsTagValue(GameTag.TAUNT, 1), SelfCondition.IsTagValue(GameTag.TO_BE_DESTROYED, 1)),
					new SummonCopyTask(EntityType.STACK, true))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ICC_050] Webweave - COST:5
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Summon two 1/2 <b>Poisonous</b> Spiders.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_050", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("ICC_832t3", 2)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ICC_054] Spreading Plague - COST:6
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 1/5 Scarab with <b>Taunt</b>. If your_opponent has more minions, cast this again.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_054", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.RecursiveTask(
					new ConditionTask(EntityType.SOURCE, SelfCondition.DoesOpHasMoresMinions),
					new SummonTask("ICC_832t4"))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ICC_079] Gnash - COST:3
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Give your hero +3_Attack this turn. Gain 3 Armor.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_079", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("ICC_079e", EntityType.HERO),
					new ArmorTask(3))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ICC_085] Ultimate Infestation - COST:10
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Deal $5 damage. Draw
			//       5 cards. Gain 5 Armor.
			//       Summon a 5/5 Ghoul. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_085", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(5, EntityType.TARGET, true),
					new DrawTask(5),
					new ArmorTask(5),
					new SummonTask("ICC_085t", SummonSide.SPELL))
			}));

		}

		private static void DruidNonCollect(Dictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [ICC_047e] Growth (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("ICC_047e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_047e")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [ICC_079e] Gnash (*) - COST:0
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: +3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("ICC_079e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_079e")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [ICC_808e] Might of Ner'ub (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("ICC_808e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.Health_N(1))
			}));

			// ----------------------------------------- MINION - DRUID
			// [ICC_047t] Fatespinner (*) - COST:5 [ATK:5/HP:3]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret Deathrattle:</b> Deal 3 damage to all minions; or Give them +2/+2.@<b>Secret Deathrattle:</b> Give +2/+2 to all minions.@<b>Secret Deathrattle:</b> Deal 3 damage to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_047t", new CardDef(new Power
			{
				DeathrattleTask = new DamageTask(3, EntityType.ALLMINIONS)
			}));

			// ----------------------------------------- MINION - DRUID
			// [ICC_047t2] Fatespinner (*) - COST:5 [ATK:5/HP:3]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 3 damage to all minions and give them +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_047t2", new CardDef(new Power
			{
				DeathrattleTask = new AddEnchantmentTask("ICC_047e", EntityType.ALLMINIONS)
			}));

			// ----------------------------------------- MINION - DRUID
			// [ICC_051t] Druid of the Swarm (*) - COST:2 [ATK:1/HP:2]
			// - Race: beast, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_051t", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [ICC_051t2] Druid of the Swarm (*) - COST:2 [ATK:1/HP:5]
			// - Race: beast, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_051t2", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [ICC_051t3] Druid of the Swarm (*) - COST:2 [ATK:1/HP:5]
			// - Race: beast, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_051t3", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [ICC_085t] Ghoul Infestor (*) - COST:5 [ATK:5/HP:5]
			// - Set: icecrown,
			// --------------------------------------------------------
			cards.Add("ICC_085t", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [ICC_832t3] Frost Widow (*) - COST:1 [ATK:1/HP:2]
			// - Race: beast, Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_832t3", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [ICC_832t4] Scarab Beetle (*) - COST:2 [ATK:1/HP:5]
			// - Race: beast, Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_832t4", new CardDef());

			// ------------------------------------------ SPELL - DRUID
			// [ICC_047a] Growth (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give all minions +2/+2.
			// --------------------------------------------------------
			cards.Add("ICC_047a", new CardDef(new Power
			{
				PowerTask = new ChangeEntityTask("ICC_047t")
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ICC_047b] Decay (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 3 damage to all minions.
			// --------------------------------------------------------
			cards.Add("ICC_047b", new CardDef(new Power
			{
				PowerTask = new ChangeEntityTask("ICC_047t2")
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ICC_051a] Spider Form (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("ICC_051a", new CardDef(new Power
			{
				PowerTask = new TransformTask("ICC_051t", EntityType.SOURCE)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ICC_051b] Scarab Form (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +3 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ICC_051b", new CardDef(new Power
			{
				PowerTask = new TransformTask("ICC_051t2", EntityType.SOURCE)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832a] Scarab Plague (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Summon two 1/5 Scarabs with <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ICC_832a", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(2, new SummonTask("ICC_832t4"))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832b] Spider Plague (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: [x]Summon two 1/2
			//       Spiders with <b>Poisonous</b>.
			// --------------------------------------------------------
			cards.Add("ICC_832b", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(2, new SummonTask("ICC_832t3"))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832pa] Scarab Shell (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +3 Armor.
			// --------------------------------------------------------
			cards.Add("ICC_832pa", new CardDef(new Power
			{
				PowerTask = new ArmorTask(3),
			}));

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832pb] Spider Fangs (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_832pb", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_832e", EntityType.HERO)
			}));

		}

		private static void Hunter(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [ICC_021] Exploding Bloatbat - COST:4 [ATK:2/HP:1]
			// - Race: beast, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b>
			//       Deal 2 damage to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_021", new CardDef(new Power
			{
				DeathrattleTask = new DamageTask(2, EntityType.OP_MINIONS)
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ICC_204] Professor Putricide - COST:4 [ATK:5/HP:4]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you play a <b>Secret</b>,
			//       put a random Hunter <b>Secret</b> into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ICC_204", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsSecret,
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsZoneCount(Zone.SECRET, 4, RelaSign.LEQ)),
						new FlagTask(true, SpecificTask.CastRandomSecret(CardClass.HUNTER)))

				}
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ICC_243] Corpse Widow - COST:5 [ATK:4/HP:6]
			// - Race: beast, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Your <b>Deathrattle</b> cards cost_(2) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_243", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HAND, Effects.ReduceCost(2))
				{
					Condition = SelfCondition.IsDeathrattleMinion
				}
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ICC_415] Stitched Tracker - COST:3 [ATK:2/HP:2]
			// - Fac: neutral, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a copy of a minion in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("ICC_415", new CardDef(new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.DECK_MINION)
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ICC_419] Bearshark - COST:3 [ATK:4/HP:3]
			// - Race: beast, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("ICC_419", new CardDef());

			// ---------------------------------------- MINION - HUNTER
			// [ICC_825] Abominable Bowman - COST:7 [ATK:6/HP:7]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Summon
			//       a random friendly Beast
			//       that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_825", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.SummonRandomMinionThatDied(SelfCondition.IsRace(Race.BEAST))
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [ICC_049] Toxic Arrow - COST:2
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If it survives, give it <b>Poisonous</b>. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_049", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(2, EntityType.TARGET, true),
					new ConditionTask(EntityType.TARGET, SelfCondition.IsNotDead),
					new FlagTask(true, new AddEnchantmentTask("ICC_049e", EntityType.TARGET)))
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [ICC_052] Play Dead - COST:1
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Trigger a friendly minion's <b>Deathrattle</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_052", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_WITH_DEATHRATTLE,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new ActivateDeathrattleTask(EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [ICC_200] Venomstrike Trap - COST:2
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions is attacked, summon a 2/3_<b>Poisonous</b> Cobra.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_200", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					//Condition = new SelfCondition(p =>
					//{
					//	IPlayable target = p.Game.IdEntityDic[p.Game.ProposedDefender];
					//	return target is Minion && target.Controller != p.Controller;
					//}),
					Condition = SelfCondition.IsEventTargetIs(CardType.MINION),
					SingleTask = ComplexTask.Secret(
						new SummonTask("EX1_170"))
				}
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [ICC_828e] Stitched (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: {0} and {1}.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// --------------------------------------------------------
			cards.Add("ICC_828e", new CardDef(new Power
			{
				// TODO [ICC_828e] Stitched && Test: Stitched_ICC_828e
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [ICC_828t] Zombeast (*) - COST:0 [ATK:1/HP:1]
			// - Race: beast, Set: icecrown,
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("ICC_828t", new CardDef(new Power
			{
				// TODO [ICC_828t] Zombeast && Test: Zombeast_ICC_828t
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Mage(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [ICC_068] Ice Walker - COST:2 [ATK:1/HP:3]
			// - Race: elemental, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Your Hero Power also <b><b>Freeze</b>s</b> the target.
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_068", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.INSPIRE)
				{
					//Condition = new SelfCondition(p => p != null),
					SingleTask = ComplexTask.Freeze(EntityType.EVENT_TARGET)
				}
			}));

			// ------------------------------------------ MINION - MAGE
			// [ICC_069] Ghastly Conjurer - COST:4 [ATK:2/HP:6]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a 'Mirror Image' spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_069", new CardDef(new Power
			{
				PowerTask = new AddCardTo("CS2_027", EntityType.HAND)
			}));

			// ------------------------------------------ MINION - MAGE
			// [ICC_083] Doomed Apprentice - COST:3 [ATK:3/HP:2]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Your opponent's spells cost (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("ICC_083", new CardDef(new Power
			{
				Aura = new Aura(AuraType.OP_HAND, Effects.AddCost(1))
				{
					Condition = SelfCondition.IsSpell
				}
			}));

			// ------------------------------------------ MINION - MAGE
			// [ICC_252] Coldwraith - COST:3 [ATK:3/HP:4]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If an enemy is <b>Frozen</b>, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FROZEN_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_252", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FROZEN_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasOp(GameTag.FROZEN, 1)),
					new FlagTask(true, new DrawTask()))
			}));

			// ------------------------------------------ MINION - MAGE
			// [ICC_838] Sindragosa - COST:8 [ATK:8/HP:8]
			// - Race: dragon, Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 0/1 Frozen Champions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_838", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonTask("ICC_838t", SummonSide.LEFT),
					new SummonTask("ICC_838t", SummonSide.RIGHT))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [ICC_082] Frozen Clone - COST:3
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, add two copies of it to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ICC_082", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsHandFull),
						new FlagTask(false, ComplexTask.Secret(
							new CopyTask(EntityType.EVENT_SOURCE, Zone.HAND, 2))))
				}
			}));

			// ------------------------------------------- SPELL - MAGE
			// [ICC_086] Glacial Mysteries - COST:8
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Put one of each <b>Secret</b> from your deck into
			//       the battlefield.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ICC_086", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_SECRET_ZONE_CAP_FOR_NON_SECRET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new FuncNumberTask(p =>
					{
						Controller c = p.Controller;
						Game g = p.Game;
						if (c.SecretZone.IsFull) return 0;
						IPlayable[] entities = c.DeckZone.GetAll(x => x.Card.IsSecret);
						List<int> ids = c.SecretZone.Select(x => x.Card.AssetId).ToList();
						for (int i = 0; i < entities.Length; i++)
						{
							IPlayable e = entities[i];
							if (ids.Contains(e.Card.AssetId)) continue;

							c.DeckZone.Remove(e);
							Generic.CastSpell(c, g, (Spell)e, null, 0);
							ids.Add(e.Card.AssetId);

							if (c.SecretZone.IsFull) return 0;
						}
						return 0;
					}))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [ICC_823] Simulacrum - COST:3
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Copy the lowest Cost minion in your hand.
			// --------------------------------------------------------
			cards.Add("ICC_823", new CardDef(new Power
			{
				PowerTask = SpecificTask.Simulacrum
			}));

			// ------------------------------------------- SPELL - MAGE
			// [ICC_836] Breath of Sindragosa - COST:1
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a random enemy minion and <b>Freeze</b> it. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_836", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(1, EntityType.OP_MINIONS),
					new DamageTask(2, EntityType.STACK, true),
					ComplexTask.Freeze(EntityType.STACK))
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [ICC_833t] Water Elemental (*) - COST:4 [ATK:3/HP:6]
			// - Race: elemental, Fac: neutral, Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Freeze</b> any character damaged by this minion.
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_833t", new CardDef());

			// ------------------------------------------ MINION - MAGE
			// [ICC_838t] Frozen Champion (*) - COST:1 [ATK:0/HP:1]
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Add a
			//       random <b>Legendary</b> minion
			//       to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_838t", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.RARITY, (int)Rarity.LEGENDARY),
					new AddStackTo(EntityType.HAND))
			}));

		}

		private static void Paladin(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [ICC_034] Arrogant Crusader - COST:4 [ATK:5/HP:2]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If it's your opponent's turn, summon a 2/2 Ghoul.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_034", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new ConditionTask(EntityType.HERO, SelfCondition.IsOpTurn),
					new FlagTask(true, new SummonTask("ICC_900t", SummonSide.DEATHRATTLE)))
			}));

			// --------------------------------------- MINION - PALADIN
			// [ICC_038] Righteous Protector - COST:1 [ATK:1/HP:1]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ICC_038", new CardDef());

			// --------------------------------------- MINION - PALADIN
			// [ICC_245] Blackguard - COST:6 [ATK:3/HP:9]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever your hero is healed, deal that much damage to a random enemy minion.
			// --------------------------------------------------------
			cards.Add("ICC_245", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.HEAL)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = ComplexTask.Create(
						new RandomTask(1, EntityType.OP_MINIONS),
						new GetEventNumberTask(),
						new DamageNumberTask(EntityType.STACK))
				}
			}));

			// --------------------------------------- MINION - PALADIN
			// [ICC_801] Howling Commander - COST:3 [ATK:2/HP:2]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a <b>Divine_Shield</b> minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ICC_801", new CardDef(new Power
			{
				PowerTask = ComplexTask.DrawFromDeck(1, SelfCondition.IsTagValue(GameTag.DIVINE_SHIELD, 1), SelfCondition.IsMinion)
			}));

			// --------------------------------------- MINION - PALADIN
			// [ICC_820] Chillblade Champion - COST:4 [ATK:3/HP:2]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_820", new CardDef());

			// --------------------------------------- MINION - PALADIN
			// [ICC_858] Bolvar, Fireblood - COST:5 [ATK:1/HP:7]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			//       After a friendly minion loses_<b>Divine Shield</b>, gain +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ICC_858", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.LOSE_DIVINE_SHIELD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("ICC_858e", EntityType.SOURCE)
				}
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [ICC_039] Dark Conviction - COST:2
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Set a minion's Attack and Health to 3.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_039", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_039e", EntityType.TARGET)
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [ICC_244] Desperate Stand - COST:2
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion "<b>Deathrattle:</b> Return this to life with 1 Health."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_244", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_244e", EntityType.TARGET)
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [ICC_071] Light's Sorrow - COST:4 [ATK:1/HP:0]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: After a friendly minion loses <b>Divine Shield</b>, gain +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ICC_071", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.LOSE_DIVINE_SHIELD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("ICC_071e", EntityType.SOURCE)
				}
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ICC_071e] Dying Light (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_071e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ICC_244e] Redeemed (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return this to life with 1 Health.
			// --------------------------------------------------------
			cards.Add("ICC_244e", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new CopyTask(EntityType.SOURCE, Zone.PLAY, addToStack: true),
					new SetGameTagTask(GameTag.HEALTH, 1, EntityType.STACK))    //	START_WITH_1_HEALTH ?
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ICC_858e] Fading Light (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_858e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(2))
			}));

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t2] Deathlord Nazgrim (*) - COST:2 [ATK:2/HP:2]
			// - Set: icecrown,
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t2", new CardDef());

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t3] Thoras Trollbane (*) - COST:2 [ATK:2/HP:2]
			// - Set: icecrown,
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t3", new CardDef());

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t4] Inquisitor Whitemane (*) - COST:2 [ATK:2/HP:2]
			// - Set: icecrown,
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t4", new CardDef());

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t5] Darion Mograine (*) - COST:2 [ATK:2/HP:2]
			// - Set: icecrown,
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t5", new CardDef());

			// --------------------------------------- WEAPON - PALADIN
			// [ICC_829t] Grave Vengeance (*) - COST:8 [ATK:5/HP:0]
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t", new CardDef());

		}

		private static void Priest(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [ICC_210] Shadow Ascendant - COST:2 [ATK:2/HP:2]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: [x]At the end of your turn,
			//       give another random
			//       friendly minion +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_210", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.BuffRandomMinion(EntityType.MINIONS_NOSOURCE, "ICC_210e")
				}
			}));

			// ---------------------------------------- MINION - PRIEST
			// [ICC_212] Acolyte of Agony - COST:3 [ATK:3/HP:3]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_212", new CardDef());

			// ---------------------------------------- MINION - PRIEST
			// [ICC_214] Obsidian Statue - COST:9 [ATK:4/HP:8]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Taunt, Lifesteal</b>
			//       <b>Deathrattle:</b> Destroy a
			//        random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_214", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.DestroyRandomTargets(1, EntityType.OP_MINIONS)
			}));

			// ---------------------------------------- MINION - PRIEST
			// [ICC_215] Archbishop Benedictus - COST:7 [ATK:4/HP:6]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle a copy of_your opponent's deck into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_215", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.OP_DECK),
					new CopyTask(EntityType.STACK, Zone.DECK))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_207] Devour Mind - COST:5
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Copy 3 cards in your opponent's deck and add them to your hand.
			// --------------------------------------------------------
			cards.Add("ICC_207", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(3, EntityType.OP_DECK),
					new CopyTask(EntityType.STACK, Zone.HAND))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_213] Eternal Servitude - COST:4
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Discover</b> a friendly minion that died this game. Summon it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("ICC_213", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_MINION_DIED_THIS_GAME,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.DIED_THIS_GAME)
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_235] Shadow Essence - COST:6
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 5/5 copy of_a random minion in_your deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("ICC_235", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new CopyTask(EntityType.STACK, Zone.PLAY, addToStack: true),
					new AddEnchantmentTask("ICC_235e", EntityType.STACK))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_802] Spirit Lash - COST:2
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       Deal $1 damage to_all_minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_802", new CardDef(new Power
			{
				PowerTask = new DamageTask(1, EntityType.ALLMINIONS, true)
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_849] Embrace Darkness - COST:6
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Choose an enemy minion.
			//       At the start of your turn,
			//       gain control of it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_849", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_849e", EntityType.TARGET)
			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [ICC_210e] Ascended (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Stats increased.
			// --------------------------------------------------------
			cards.Add("ICC_210e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.AttackHealth_N(1))
			}));

		}

		private static void Rogue(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [ICC_065] Bone Baron - COST:5 [ATK:5/HP:5]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add two 1/1 Skeletons to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_065", new CardDef(new Power
			{
				DeathrattleTask = new AddCardTo("ICC_026t", EntityType.HAND, 2)
			}));

			// ----------------------------------------- MINION - ROGUE
			// [ICC_240] Runeforge Haunter - COST:4 [ATK:5/HP:3]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: During your turn, your weapon doesn't lose Durability.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("ICC_240", new CardDef(new Power
			{
				Aura = new Aura(AuraType.WEAPON, "ICC_240e")
				{
					Condition = SelfCondition.IsMyTurn,
					Restless = true
				}
			}));

			// ----------------------------------------- MINION - ROGUE
			// [ICC_809] Plague Scientist - COST:3 [ATK:2/HP:3]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Give a friendly minion <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_FOR_COMBO = 0
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_809", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_TARGET_FOR_COMBO,0}}, new Power
			{
				ComboTask = new AddEnchantmentTask("ICC_809e", EntityType.TARGET)
			}));

			// ----------------------------------------- MINION - ROGUE
			// [ICC_811] Lilian Voss - COST:4 [ATK:4/HP:5]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Replace spells in your hand with random spells <i>(from your opponent's class).</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_811", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsSpell),
					new ChangeEntityTask(EntityType.STACK, CardType.SPELL, opClass: true))
			}));

			// ----------------------------------------- MINION - ROGUE
			// [ICC_910] Spectral Pillager - COST:6 [ATK:5/HP:5]
			// - Fac: neutral, Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Combo:</b> Deal damage equal
			//       to the number of other cards
			//       you've played this turn.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_FOR_COMBO = 0
			// --------------------------------------------------------
			cards.Add("ICC_910", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_FOR_COMBO,0}}, new Power
			{
				ComboTask = ComplexTask.Create(
					new GetGameTagControllerTask(GameTag.NUM_CARDS_PLAYED_THIS_TURN),
					new MathSubstractionTask(1),
					new DamageNumberTask(EntityType.TARGET))
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [ICC_201] Roll the Bones - COST:2
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw a card.
			//       If it has <b>Deathrattle</b>, cast this again.
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_201", new CardDef(new Power
			{
				PowerTask = ComplexTask.RecursiveTask(
					new ConditionTask(EntityType.STACK, SelfCondition.IsDeathrattleCard),
					new DrawTask(true))
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [ICC_221] Leeching Poison - COST:1
			// - Fac: neutral, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Give your weapon <b>Lifesteal</b> this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_221", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_WEAPON_EQUIPPED,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_221e", EntityType.WEAPON)
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [ICC_233] Doomerang - COST:1
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Throw your weapon at a minion. It deals its damage, then returns to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			cards.Add("ICC_233", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_WEAPON_EQUIPPED,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.WEAPON),
					new IncludeTask(EntityType.TARGET, null, true),
					new FuncPlayablesTask(list =>
					{
						if (list.Count < 2)         //	Can Grand Archivist play this ?
							return null;
						var source = (Weapon)list[0];
						var target = (Minion)list[1];
						target.TakeDamage(source, source.AttackDamage);
						source.Controller.Hero.ClearWeapon();
						Generic.AddHandPhase(source.Controller, source);
						return null;
					}))
			}));

			// ----------------------------------------- WEAPON - ROGUE
			// [ICC_850] Shadowblade - COST:3 [ATK:3/HP:0]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your hero is <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("ICC_850", new CardDef(new Power
			{
				InfoCardId = "ICC_850e",
				PowerTask = new AddEnchantmentTask("ICC_850e", EntityType.HERO)
			}));

		}

		private static void RogueNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_018e] Witty Weaponplay (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_018e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_221e] Leeching Poison (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Has <b>Lifesteal</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_221e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.Lifesteal)
				{
					IsOneTurnEffect = true
				}
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_240e] Resilient Weapon (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: No durability loss.
			// --------------------------------------------------------
			cards.Add("ICC_240e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.Immune)
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_809e] Test Subject (*) - COST:0
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_809e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_809e")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_827e] Shadow Reflection (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Always copy your last played card.
			// --------------------------------------------------------
			cards.Add("ICC_827e", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.VALEERASHADOW, EffectOperator.SET, 1)
				{
					RemoveWhenPlayed = true
				},
				Trigger = new MultiTrigger(
					new Trigger(TriggerType.PLAY_CARD)
					{
						SingleTask = SpecificTask.ShadowReflection
					},
					new Trigger(TriggerType.TURN_END)
					{
						SingleTask = ComplexTask.Create(
							RemoveEnchantmentTask.Task,
							new MoveToSetaside(EntityType.TARGET))
					})

				// Trigger 1 : PlayCard => ChangeEntity
				// Trigger 2 : PlayCard => Self? => Dispose
				// Trigger 3 : EndTurn => RemoveEnchantment, MoveToSetaside
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_827e3] Veil of Shadows (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			cards.Add("ICC_827e3", new CardDef(Power.OneTurnStealthEnchantmentPower));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_850e] Shaded (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("ICC_850e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_850e")
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [ICC_827t] Shadow Reflection (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Each time you play a card, transform this into a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MUST_PLAY_OTHER_CARD_FIRST = 0
			// --------------------------------------------------------
			cards.Add("ICC_827t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MUST_PLAY_OTHER_CARD_FIRST,0}}));

		}

		private static void Shaman(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [ICC_058] Brrrloc - COST:2 [ATK:2/HP:2]
			// - Race: murloc, Set: icecrown, Rarity: common
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
			cards.Add("ICC_058", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Freeze(EntityType.TARGET)
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [ICC_081] Drakkari Defender - COST:3 [ATK:2/HP:8]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Overload:</b> (3)
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - OVERLOAD = 3
			// - OVERLOAD_OWED = 3
			// --------------------------------------------------------
			cards.Add("ICC_081", new CardDef());

			// ---------------------------------------- MINION - SHAMAN
			// [ICC_088] Voodoo Hexxer - COST:5 [ATK:2/HP:7]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Freeze</b> any character damaged by this minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_088", new CardDef());

			// ---------------------------------------- MINION - SHAMAN
			// [ICC_090] Snowfury Giant - COST:11 [ATK:8/HP:8]
			// - Race: elemental, Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each Mana Crystal you've <b><b>Overload</b>ed</b> this game.
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("ICC_090", new CardDef(new Power
			{
				Aura = new AdaptiveCostEffect(
					initialisationFunction: p => -p.Controller.OverloadThisGame,
					triggerValueFunction: p => -p.Card.Overload,
					trigger: TriggerType.OVERLOAD,
					triggerSource: TriggerSource.FRIENDLY)
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [ICC_289] Moorabi - COST:6 [ATK:4/HP:4]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever another minion is <b>Frozen</b>, add a copy of it to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_289", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.FROZEN)
				{
					TriggerSource = TriggerSource.ALL_MINIONS_EXCEPT_SELF,
					SingleTask = new CopyTask(EntityType.TARGET, Zone.HAND)
				}
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [ICC_056] Cryostasis - COST:2
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a minion +3/+3 and <b>Freeze</b> it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_056", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("ICC_056e", EntityType.TARGET),
					ComplexTask.Freeze(EntityType.TARGET))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [ICC_078] Avalanche - COST:4
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion and deal $3 damage to adjacent ones. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_078", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					ComplexTask.Freeze(EntityType.TARGET),
					new IncludeAdjacentTask(EntityType.TARGET),
					new DamageTask(3, EntityType.STACK, true))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [ICC_089] Ice Fishing - COST:2
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 Murlocs from your deck.
			// --------------------------------------------------------
			cards.Add("ICC_089", new CardDef(new Power
			{
				PowerTask = ComplexTask.DrawFromDeck(2, SelfCondition.IsRace(Race.MURLOC))
			}));

			// ---------------------------------------- WEAPON - SHAMAN
			// [ICC_236] Ice Breaker - COST:3 [ATK:1/HP:0]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy any <b>Frozen</b> minion damaged by_this.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_236", new CardDef(new Power
			{
				// TODO: Should change all similar effects
				// Actual log says the source of damage is the equipped weapon, not hero
				//Trigger = new Trigger(TriggerType.DEAL_DAMAGE)
				//{
				//	TriggerSource = TriggerSource.HERO,
				//	// Don't like this condtion too... should make fields for proposed entities?
				//	Condition = new SelfCondition(p =>
				//	{
				//		IPlayable target = p.Game.IdEntityDic[p.Game.ProposedDefender];
				//		return target[GameTag.FROZEN] > 0;
				//	}),
				//	SingleTask = ComplexTask.Create(
				//		new IncludeTask(EntityType.SOURCE),
				//		new FuncPlayablesTask(p =>
				//			new List<IPlayable> { p[0].Game.IdEntityDic[p[0].Game.ProposedDefender]}),
				//		new DestroyTask(EntityType.STACK))
				//}
				Trigger = new Trigger(TriggerType.DEAL_DAMAGE)
				{
					TriggerSource = TriggerSource.HERO,
					Condition = new SelfCondition(p => p.Game.CurrentEventData.EventTarget[GameTag.FROZEN] > 0),
					SingleTask = new DestroyTask(EntityType.EVENT_TARGET)
				}
			}));

		}

		private static void Warlock(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [ICC_075] Despicable Dreadlord - COST:5 [ATK:4/HP:5]
			// - Race: demon, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 1 damage to all enemy minions.
			// --------------------------------------------------------
			cards.Add("ICC_075", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new DamageTask(1, EntityType.OP_MINIONS)
				}
			}));

			// --------------------------------------- MINION - WARLOCK
			// [ICC_218] Howlfiend - COST:3 [ATK:3/HP:6]
			// - Race: demon, Fac: neutral, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, discard a_random card.
			// --------------------------------------------------------
			cards.Add("ICC_218", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = ComplexTask.Create(
						new RandomTask(1, EntityType.HAND),
						new DiscardTask(EntityType.STACK))
				}
			}));

			// --------------------------------------- MINION - WARLOCK
			// [ICC_407] Gnomeferatu - COST:2 [ATK:2/HP:3]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Remove
			//       the top card of your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_407", new CardDef(new Power
			{
				PowerTask = new MoveToGraveYard(EntityType.OP_TOPDECK)
			}));

			// --------------------------------------- MINION - WARLOCK
			// [ICC_841] Blood-Queen Lana'thel - COST:5 [ATK:1/HP:6]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Lifesteal</b>
			//       Has +1 Attack for each
			//       card you've discarded
			//       this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_841", new CardDef(new Power
			{
				// TODO [ICC_841] Blood-Queen Lana'thel && Test: Blood-Queen Lana'thel_ICC_841
				InfoCardId = "ICC_841e",
				//PowerTask = ComplexTask.Create(
				//	new IncludeTask(EntityType.SOURCE),
				//	new FuncNumberTask(p => p.Controller.DiscardedEntities.Count),
				//	new AddEnchantmentTask("ICC_841e", EntityType.SOURCE, true))
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.ADD, p => p.Controller.NumDiscardedThisGame)
			}));

			// --------------------------------------- MINION - WARLOCK
			// [ICC_903] Sanguine Reveler - COST:1 [ATK:1/HP:1]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a friendly minion and gain_+2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_903", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.TARGET),
					new AddEnchantmentTask("ICC_903t", EntityType.SOURCE))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_041] Defile - COST:2
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $1 damage to all minions. If any die, cast this again. @spelldmg
			// --------------------------------------------------------
			cards.Add("ICC_041", new CardDef(new Power
			{
				PowerTask = ComplexTask.RecursiveTask(
					new ConditionTask(EntityType.SOURCE, new SelfCondition(p => p.Game.DeadMinions.Count > 0)),
					new FuncNumberTask(p =>
					{
						p.Game.DeathProcessingAndAuraUpdate();
						return 0;
					}),
					new DamageTask(1, EntityType.ALLMINIONS, true))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_055] Drain Soul - COST:2
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       Deal $2 damage
			//       to a minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_055", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET, true)
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_206] Treachery - COST:3
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Choose a friendly minion and give it to_your opponent.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_206", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new ControlTask(EntityType.TARGET, true)
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_469] Unwilling Sacrifice - COST:3
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Choose a friendly minion. Destroy it and a random enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_469", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.TARGET),
					ComplexTask.DestroyRandomTargets(1, EntityType.OP_MINIONS))
			}));

		}

		private static void Warrior(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [ICC_062] Mountainfire Armor - COST:3 [ATK:4/HP:3]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If it's your opponent's turn,
			//       gain 6 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_062", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsOpTurn),
					new FlagTask(true, new ArmorTask(6))),
			}));

			// --------------------------------------- MINION - WARRIOR
			// [ICC_238] Animated Berserker - COST:1 [ATK:1/HP:3]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: After you play a minion, deal 1 damage to it.
			// --------------------------------------------------------
			cards.Add("ICC_238", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new DamageTask(1, EntityType.EVENT_SOURCE)
				}
			}));

			// --------------------------------------- MINION - WARRIOR
			// [ICC_405] Rotface - COST:8 [ATK:4/HP:6]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Whenever this minion
			//       survives damage,
			//       summon a random
			//       <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_405", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					Condition = SelfCondition.IsNotDead,
					SingleTask = ComplexTask.Create(
						new RandomMinionTask(GameTag.RARITY, (int)Rarity.LEGENDARY),
						new SummonTask())
				}
			}));

			// --------------------------------------- MINION - WARRIOR
			// [ICC_408] Val'kyr Soulclaimer - COST:3 [ATK:1/HP:4]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Whenever this minion
			//       survives damage,
			//       summon a 2/2 Ghoul.
			// --------------------------------------------------------
			cards.Add("ICC_408", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					Condition = SelfCondition.IsNotDead,
					SingleTask = new SummonTask("ICC_900t")
				}
			}));

			// --------------------------------------- MINION - WARRIOR
			// [ICC_450] Death Revenant - COST:5 [ATK:3/HP:3]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1/+1 for each damaged minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_450", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.FRIENDS),
					new FilterStackTask(SelfCondition.IsDamaged),
					new CountTask(EntityType.STACK),
					new AddEnchantmentTask("ICC_450e", EntityType.SOURCE, true))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [ICC_091] Dead Man's Hand - COST:2
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle a copy of your hand into your deck.
			// --------------------------------------------------------
			cards.Add("ICC_091", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new CopyTask(EntityType.STACK, Zone.DECK))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [ICC_281] Forge of Souls - COST:2
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 weapons from your deck.
			// --------------------------------------------------------
			cards.Add("ICC_281", new CardDef(new Power
			{
				PowerTask = ComplexTask.DrawFromDeck(2, SelfCondition.IsWeapon)
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [ICC_837] Bring It On! - COST:2
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Gain 10 Armor. Reduce the Cost of minions in your opponent's hand by (2).
			// --------------------------------------------------------
			cards.Add("ICC_837", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ArmorTask(10),
					new IncludeTask(EntityType.OP_HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new AddEnchantmentTask("ICC_837e", EntityType.STACK))
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [ICC_064] Blood Razor - COST:4 [ATK:2/HP:0]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b>
			//       Deal 1 damage to all_minions.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_064", new CardDef(new Power
			{
				PowerTask = new DamageTask(1, EntityType.ALLMINIONS),
				DeathrattleTask = new DamageTask(1, EntityType.ALLMINIONS)
			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- WEAPON - WARRIOR
			// [ICC_834w] Shadowmourne (*) - COST:8 [ATK:4/HP:0]
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever your hero_attacks.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("ICC_834w", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					Condition = SelfCondition.IsProposedDefender(CardType.MINION),
					TriggerSource = TriggerSource.HERO,
					SingleTask = ComplexTask.Create(
						new FuncNumberTask(p =>
						{
							//Minion target = (Minion) p.Game.IdEntityDic[p.Game.ProposedDefender];
							Minion target = (Minion)p.Game.CurrentEventData.EventTarget;
							foreach (Minion adjacent in target.GetAdjacentMinions())
								adjacent.TakeDamage(p, p.Controller.Hero.AttackDamage);
							return 0;
						}))
				}
			}));

		}

		private static void Neutral(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [ICC_018] Phantom Freebooter - COST:4 [ATK:3/HP:3]
			// - Race: pirate, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain stats equal to your weapon's.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_018", new CardDef(new Power
			{
				InfoCardId = "ICC_018e",
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.WEAPON),
					new GetGameTagTask(GameTag.DURABILITY, EntityType.WEAPON, 0, 1),
					new GetGameTagTask(GameTag.DAMAGE, EntityType.WEAPON, 0, 2),
					new MathNumberIndexTask(1, 2, MathOperation.SUB, 1),
					new AddEnchantmentTask("ICC_018e", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_019] Skelemancer - COST:5 [ATK:2/HP:2]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If it's your opponent's turn, summon an 8/8 Skeleton.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_019", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsOpTurn),
					new FlagTask(true, new SummonTask("ICC_019t", SummonSide.DEATHRATTLE))),
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_023] Snowflipper Penguin - COST:0 [ATK:1/HP:1]
			// - Race: beast, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			cards.Add("ICC_023", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_025] Rattling Rascal - COST:4 [ATK:2/HP:2]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon a
			//       5/5 Skeleton.
			//       <b>Deathrattle:</b> Summon one
			//       for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_025", new CardDef(new Power
			{
				PowerTask = new SummonTask("ICC_025t", SummonSide.RIGHT),
				DeathrattleTask = new SummonOpTask("ICC_025t")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_026] Grim Necromancer - COST:4 [ATK:2/HP:4]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/1 Skeletons.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_026", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new SummonTask("ICC_026t", SummonSide.LEFT),
					new SummonTask("ICC_026t", SummonSide.RIGHT))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_027] Bone Drake - COST:6 [ATK:6/HP:5]
			// - Race: dragon, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Dragon to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_027", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomCardTask(CardType.INVALID, CardClass.INVALID, Race.DRAGON),
					new AddStackTo(EntityType.HAND))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_028] Sunborne Val'kyr - COST:5 [ATK:5/HP:4]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give adjacent minions +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_028", new CardDef(new Power
			{
				// TODO Test: Sunborne Val'kyr_ICC_028
				InfoCardId = "ICC_028e",
				PowerTask = ComplexTask.Create(
					new IncludeAdjacentTask(EntityType.SOURCE),
					new AddEnchantmentTask("ICC_028e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_029] Cobalt Scalebane - COST:5 [ATK:5/HP:5]
			// - Race: dragon, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, give another random friendly minion +3 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_029", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.BuffRandomMinion(EntityType.MINIONS_NOSOURCE, "ICC_029e")
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_031] Night Howler - COST:4 [ATK:3/HP:4]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes
			//       damage, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_031", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = new AddEnchantmentTask("ICC_031e", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_032] Venomancer - COST:5 [ATK:2/HP:5]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_032", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_067] Vryghoul - COST:3 [ATK:3/HP:1]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> If it's your
			//       opponent's turn,
			//       summon a 2/2 Ghoul.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_067", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsOpTurn),
					new FlagTask(true, new SummonTask("ICC_900t", SummonSide.DEATHRATTLE))),
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_092] Acherus Veteran - COST:1 [ATK:2/HP:1]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_092", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_092e", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_093] Tuskarr Fisherman - COST:2 [ATK:2/HP:3]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion <b>Spell Damage +1</b>.
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
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("ICC_093", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_093e", EntityType.TARGET)
			}));
			// --------------------------------------- MINION - NEUTRAL
			// [ICC_094] Fallen Sun Cleric - COST:2 [ATK:2/HP:1]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_094", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_094e", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_096] Furnacefire Colossus - COST:6 [ATK:6/HP:6]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Discard all weapons from your hand and gain their stats.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_096", new CardDef(new Power
			{
				InfoCardId = "ICC_096e",
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsWeapon),
					new FuncNumberTask(p => p.Sum(w => w[GameTag.DURABILITY]) + 1),
					new MathNumberIndexTask(1, 0, MathOperation.ADD, 1),
					new FuncNumberTask(p => p.Sum(w => w[GameTag.ATK])),
					new DiscardTask(EntityType.STACK),
					new AddEnchantmentTask("ICC_096e", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_097] Grave Shambler - COST:4 [ATK:4/HP:4]
			// - Race: elemental, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your weapon is destroyed, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_097", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.WEAPON,
					SingleTask = new AddEnchantmentTask("ICC_097e", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_098] Tomb Lurker - COST:5 [ATK:5/HP:3]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Add a random
			//       <b>Deathrattle</b> minion that died
			//       this game to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_098", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.GRAVEYARD),
					new FilterStackTask(SelfCondition.IsDeathrattleMinion),
					new RandomTask(1, EntityType.STACK),
					new CopyTask(EntityType.STACK, Zone.HAND))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_099] Ticking Abomination - COST:4 [ATK:5/HP:6]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 5 damage to your minions.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_099", new CardDef(new Power
			{
				DeathrattleTask = new DamageTask(5, EntityType.MINIONS)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_220] Deadscale Knight - COST:1 [ATK:1/HP:1]
			// - Race: murloc, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_220", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_257] Corpse Raiser - COST:5 [ATK:3/HP:3]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Give a friendly
			//       minion "<b>Deathrattle:</b>
			//         Resummon this minion."
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - DEATH_KNIGHT = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_257", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_257e", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_314] The Lich King - COST:8 [ATK:8/HP:8]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       At the end of your turn,
			//       add a random <b>Death Knight</b>
			//       card to your hand.
			// --------------------------------------------------------
			// Entourage: ICC_314t3, ICC_314t2, ICC_314t7, ICC_314t4, ICC_314t5, ICC_314t6, ICC_314t8, ICC_314t1
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_314", new CardDef(new[] {"ICC_314t3","ICC_314t2","ICC_314t7","ICC_314t4","ICC_314t5","ICC_314t6","ICC_314t8","ICC_314t1"}, new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new RandomEntourageTask(),
						new AddStackTo(EntityType.HAND))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_466] Saronite Chain Gang - COST:4 [ATK:2/HP:3]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Summon a copy of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_466", new CardDef(new Power
			{
				PowerTask = new SummonTask("ICC_466", SummonSide.RIGHT)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_467] Deathspeaker - COST:3 [ATK:2/HP:4]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("ICC_467", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_467e", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_468] Wretched Tiller - COST:1 [ATK:1/HP:1]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion attacks, deal 2 damage to_the enemy hero.
			// --------------------------------------------------------
			cards.Add("ICC_468", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = new DamageTask(2, EntityType.OP_HERO)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_700] Happy Ghoul - COST:3 [ATK:3/HP:3]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Costs (0) if your hero was healed this turn.
			// --------------------------------------------------------
			cards.Add("ICC_700", new CardDef(new Power
			{
				Aura = new AdaptiveCostEffect(0, TriggerType.HEAL, TriggerSource.FRIENDLY, SelfCondition.IsHero)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_701] Skulking Geist - COST:6 [ATK:4/HP:6]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all
			//       1-Cost spells in both hands and decks.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_701", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsBaseTagValue(GameTag.COST, 1), SelfCondition.IsSpell),
					new MoveToGraveYard(EntityType.STACK),
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsBaseTagValue(GameTag.COST, 1), SelfCondition.IsSpell),
					new MoveToGraveYard(EntityType.STACK),
					new IncludeTask(EntityType.OP_DECK),
					new FilterStackTask(SelfCondition.IsBaseTagValue(GameTag.COST, 1), SelfCondition.IsSpell),
					new MoveToGraveYard(EntityType.STACK),
					new IncludeTask(EntityType.OP_HAND),
					new FilterStackTask(SelfCondition.IsBaseTagValue(GameTag.COST, 1), SelfCondition.IsSpell),
					new MoveToGraveYard(EntityType.STACK)),
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_702] Shallow Gravedigger - COST:3 [ATK:3/HP:1]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random <b>Deathrattle</b> minion to your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_702", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomCardTask(CardType.INVALID, CardClass.INVALID, Race.INVALID, Rarity.INVALID, new[] { GameTag.DEATHRATTLE }),
					new AddStackTo(EntityType.HAND))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_705] Bonemare - COST:7 [ATK:5/HP:5]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +4/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_705", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("ICC_705e", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_706] Nerubian Unraveler - COST:6 [ATK:5/HP:5]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Spells cost (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("ICC_706", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HANDS, Effects.AddCost(2))
				{
					Condition = SelfCondition.IsSpell
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_810] Deathaxe Punisher - COST:4 [ATK:3/HP:3]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random <b>Lifesteal</b> minion in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_810", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(
						SelfCondition.IsTagValue(GameTag.LIFESTEAL, 1),
						SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new AddEnchantmentTask("ICC_810e", EntityType.STACK)),
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_812] Meat Wagon - COST:4 [ATK:1/HP:4]
			// - Race: mechanical, Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Summon a
			//       minion from your deck
			//       with less Attack than
			//       this minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_812", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.SOURCE),
					new IncludeTask(EntityType.DECK, null, true),
					new FuncPlayablesTask(list =>
					{
						int atk = ((Character)list[0]).AttackDamage;
						return list.Where(p => p is Minion m && m.AttackDamage < atk).ToList();
					}),
					new RandomTask(1, EntityType.STACK),
					new RemoveFromDeck(EntityType.STACK),
					new SummonTask())
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_851] Prince Keleseth - COST:2 [ATK:2/HP:2]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has_no 2-Cost cards, give_all minions in your deck +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_851", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasNoSpecficCostCardsInDeck(2)),
					new FlagTask(true, ComplexTask.Create(
						new IncludeTask(EntityType.DECK),
						new FilterStackTask(SelfCondition.IsMinion),
						new AddEnchantmentTask("ICC_851e", EntityType.STACK))))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_852] Prince Taldaram - COST:3 [ATK:3/HP:3]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has_no 3-Cost cards, transform into a 3/3 copy of a minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_DRAG_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_852", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE_AND_NO_3_COST_CARD_IN_DECK,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasNoSpecficCostCardsInDeck(3)),
					new FlagTask(true, ComplexTask.Create(
					new TransformCopyTask(true),
					new AddEnchantmentTask("ICC_852e", EntityType.STACK))))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_853] Prince Valanar - COST:4 [ATK:4/HP:4]
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no 4-Cost cards, gain <b>Lifesteal</b> and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_853", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasNoSpecficCostCardsInDeck(4)),
					new FlagTask(true, ComplexTask.Create(
						new SetGameTagTask(GameTag.LIFESTEAL, 1, EntityType.SOURCE),
						new SetGameTagTask(GameTag.TAUNT, 1, EntityType.SOURCE))))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_854] Arfus - COST:4 [ATK:2/HP:2]
			// - Race: beast, Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random <b>Death Knight</b> card to your_hand.
			// --------------------------------------------------------
			// Entourage: ICC_314t2, ICC_314t3, ICC_314t4, ICC_314t5, ICC_314t7, ICC_314t8, ICC_314t6, ICC_314t1
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_854", new CardDef(new[] {"ICC_314t2","ICC_314t3","ICC_314t4","ICC_314t5","ICC_314t7","ICC_314t8","ICC_314t6","ICC_314t1"}, new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomEntourageTask(),
					new AddStackTo(EntityType.HAND))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_855] Hyldnir Frostrider - COST:3 [ATK:4/HP:4]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Freeze</b> your other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_855", new CardDef(new Power
			{
				PowerTask = ComplexTask.Freeze(EntityType.MINIONS_NOSOURCE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_856] Spellweaver - COST:6 [ATK:4/HP:4]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +2</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 2
			// --------------------------------------------------------
			cards.Add("ICC_856", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_900] Necrotic Geist - COST:6 [ATK:5/HP:3]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever one of your other minions dies, summon a 2/2 Ghoul.
			// --------------------------------------------------------
			cards.Add("ICC_900", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = new SummonTask("ICC_900t")
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_901] Drakkari Enchanter - COST:3 [ATK:1/HP:5]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Your end of turn effects trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("ICC_901", new CardDef(new Power
			{
				Aura = new Aura(AuraType.CONTROLLER, new Effect(GameTag.EXTRA_END_TURN_EFFECT, EffectOperator.ADD, 1))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_902] Mindbreaker - COST:3 [ATK:2/HP:5]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Hero Powers are disabled.
			// --------------------------------------------------------
			cards.Add("ICC_902", new CardDef(new Power
			{
				Aura = new Aura(AuraType.CONTROLLERS, new Effect(GameTag.HERO_POWER_DISABLED, EffectOperator.ADD, 1))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_904] Wicked Skeleton - COST:4 [ATK:1/HP:1]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1/+1 for_each minion that died_this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_904", new CardDef(new Power
			{
				// TODO Test: Wicked Skeleton_ICC_904
				PowerTask = ComplexTask.Create(
					new GetGameTagGameTask(GameTag.NUM_MINIONS_KILLED_THIS_TURN),
					new AddEnchantmentTask("ICC_904e", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_905] Bloodworm - COST:5 [ATK:4/HP:4]
			// - Race: beast, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_905", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_911] Keening Banshee - COST:4 [ATK:5/HP:5]
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you play a card, remove the top 3 cards of_your deck.
			// --------------------------------------------------------
			cards.Add("ICC_911", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.PLAY_CARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new EnqueueTask(3, new MoveToGraveYard(EntityType.TOPCARDFROMDECK))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_912] Corpsetaker - COST:4 [ATK:3/HP:3]
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain <b>Taunt</b> if your
			//       deck has a <b>Taunt</b> minion.
			//       Repeat for <b>Divine Shield</b>,
			//       <b>Lifesteal</b>, <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_912", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasMinionInDeck(GameTag.TAUNT)),
					new FlagTask(true, ComplexTask.Taunt(EntityType.SOURCE)),
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasMinionInDeck(GameTag.DIVINE_SHIELD)),
					new FlagTask(true, ComplexTask.DivineShield(EntityType.SOURCE)),
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasMinionInDeck(GameTag.LIFESTEAL)),
					new FlagTask(true, ComplexTask.LifeSteal(EntityType.SOURCE)),
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasMinionInDeck(GameTag.WINDFURY)),
					new FlagTask(true, ComplexTask.WindFury(EntityType.SOURCE)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_913] Tainted Zealot - COST:2 [ATK:1/HP:1]
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			//       <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ICC_913", new CardDef());

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_028e] Blessing of the Val'kyr (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("ICC_028e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_028e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_029e] Dragonscales (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Attack increased.
			// --------------------------------------------------------
			cards.Add("ICC_029e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.Attack_N(3))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_031e] Awooooo! (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: This minion has increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_031e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.Attack_N(2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_039e] Convinced (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Stats changed to 3/3.
			// --------------------------------------------------------
			cards.Add("ICC_039e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_039e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_049e] Toxic Arrow (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Poisonous.
			// --------------------------------------------------------
			cards.Add("ICC_049e", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.POISONOUS, EffectOperator.SET, 1)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_056e] Frozen Blood (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("ICC_056e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_056e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_092e] Veteran's Favor (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_092e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_092e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_093e] Fresh Fish! (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			cards.Add("ICC_093e", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.SPELLPOWER, EffectOperator.ADD, 1)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_094e] Cleric's Blessing (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_094e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_094e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_096e] Me Bigger (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_096e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_097e] Armed and Dangerous (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_097e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_235e] Shadow Essence (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Attack and Health set to 5.
			// --------------------------------------------------------
			cards.Add("ICC_235e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetAttackHealth(5))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_257e] Ready to Return (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Resummon this minion.
			// --------------------------------------------------------
			cards.Add("ICC_257e", new CardDef(new Power
			{
				DeathrattleTask = new CopyTask(EntityType.SOURCE, Zone.PLAY)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_314t1e] Trapped Soul (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: {0}
			// --------------------------------------------------------
			cards.Add("ICC_314t1e", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					GetCapturedCardTask.Task,
					new SummonTask())
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_314t7e] Anti-Magic Shell (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +2/+2 and "Can't be targeted by spells or Hero Powers."
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("ICC_314t7e", new CardDef(new Power
			{
				Enchant = new Enchant(
					Effects.Attack_N(2),
					Effects.Health_N(2),
					Effects.CantBeTargetedBySpellsAndHeroPowers)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_450e] Bloodthirsty (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_450e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_467e] Deathward (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("ICC_467e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_467e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_483e] Frostmourne Enchantment (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			cards.Add("ICC_483e", new CardDef(new Power
			{
				// TODO [ICC_483e] Frostmourne Enchantment && Test: Frostmourne Enchantment_ICC_483e
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_705e] Bonemare's Boon (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +4/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ICC_705e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_705e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_807e] Strongshell (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("ICC_807e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_807e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_810e] Bloodthirsty (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +2/+2 from Deathaxe Punisher.
			// --------------------------------------------------------
			cards.Add("ICC_810e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_810e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_832e] Fangs (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("ICC_832e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_832e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_833e] Frost Lich (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Your Elementals have <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("ICC_833e", new CardDef(new Power
			{
				Aura = new Aura(AuraType.BOARD, "ICC_833e2")
				{
					Condition = SelfCondition.IsRace(Race.ELEMENTAL)
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_833e2] Icy Veins (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Frost Lich Jaina is granting your Elementals <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_833e2", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.LIFESTEAL, EffectOperator.SET, 1)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_837e] Challenged (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Minion cost reduced by (2).
			// --------------------------------------------------------
			cards.Add("ICC_837e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.ReduceCost(2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_841e] Vampiric Bite (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_841e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_849e] Embraced (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: At the start of the next turn, lose control of this minion.
			// --------------------------------------------------------
			cards.Add("ICC_849e", new CardDef(new Power
			{
				//Enchant = new Enchant(GameTag.CONTROLLER_CHANGED_THIS_TURN, EffectOperator.SET, 1),
				// 333, 887 = Controller.PlayerId ?
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = ComplexTask.Create(
						RemoveEnchantmentTask.Task,
						new ControlTask(EntityType.TARGET))
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_851e] Keleseth's Blessing (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_851e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_851e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_852e] Taldaram's Visage (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: 3/3.
			// --------------------------------------------------------
			cards.Add("ICC_852e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("ICC_852e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_903t] Bloodthirst (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_903t", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.AttackHealth_N(2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_904e] Extra Calcium (*) - COST:0
			// - Set: icecrown,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_904e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_019t] Skeletal Flayer (*) - COST:8 [ATK:8/HP:8]
			// - Set: icecrown,
			// --------------------------------------------------------
			cards.Add("ICC_019t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_025t] Skeletal Enforcer (*) - COST:5 [ATK:5/HP:5]
			// - Set: icecrown,
			// --------------------------------------------------------
			cards.Add("ICC_025t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_026t] Skeleton (*) - COST:1 [ATK:1/HP:1]
			// - Set: icecrown,
			// --------------------------------------------------------
			cards.Add("ICC_026t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_800h3t] Zombeast (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: icecrown,
			// --------------------------------------------------------
			cards.Add("ICC_800h3t", new CardDef(new Power
			{
				// TODO [ICC_800h3t] Zombeast && Test: Zombeast_ICC_800h3t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_900t] Ghoul (*) - COST:2 [ATK:2/HP:2]
			// - Set: icecrown,
			// --------------------------------------------------------
			cards.Add("ICC_900t", new CardDef());

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			DeathknightNonCollect(cards);
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
			Warlock(cards);
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
