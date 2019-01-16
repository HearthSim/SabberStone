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
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets
{
	public class GangsCardsGen
	{
		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [CFM_308] Kun the Forgotten King - COST:10 [ATK:7/HP:7] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Gain 10 Armor; or Refresh your Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("CFM_308",
				//CHOOSE_ONE
				null);

			// ----------------------------------------- MINION - DRUID
			// [CFM_343] Jade Behemoth - COST:6 [ATK:3/HP:6] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Summon a{1}
			//       {0} <b>Jade Golem</b>.@[x]<b>Taunt</b>
			//       <b>Battlecry:</b> Summon a
			//       <b>Jade Golem</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_343", new Power
			{
				PowerTask = ComplexTask.SummonJadeGolem(SummonSide.RIGHT)
			});

			// ----------------------------------------- MINION - DRUID
			// [CFM_617] Celestial Dreamer - COST:3 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you control a
			//       minion with 5 or more
			//       Attack, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_617", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasBoardMinion(GameTag.ATK, 5, RelaSign.GEQ)),
					new FlagTask(true, new AddEnchantmentTask("CFM_617e", EntityType.SOURCE))),
			});

			// ----------------------------------------- MINION - DRUID
			// [CFM_816] Virmen Sensei - COST:5 [ATK:4/HP:5] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Beast +2/+2.
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
			cards.Add("CFM_816", new Power
			{
				PowerTask = new AddEnchantmentTask("CFM_816e", EntityType.TARGET)
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_602] Jade Idol - COST:1 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Summon a{1} {0} <b>Jade Golem</b>; or Shuffle 3 copies of this card into your deck.@<b>Choose One -</b> Summon a <b>Jade Golem</b>; or Shuffle 3 copies of this card into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_602",
				//CHOOSE_ONE
				null);

			// ------------------------------------------ SPELL - DRUID
			// [CFM_614] Mark of the Lotus - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_614", new Power
			{
				PowerTask = new AddEnchantmentTask("CFM_614e", EntityType.MINIONS)
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_616] Pilfered Power - COST:3 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Gain an empty Mana Crystal for each friendly minion.
			// --------------------------------------------------------
			cards.Add("CFM_616", new Power
			{
				PowerTask = ComplexTask.Create(
					ComplexTask.ExcessManaCheck,
					new CountTask(EntityType.MINIONS),
					new ManaCrystalEmptyTask(0, false, true))
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_713] Jade Blossom - COST:3 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Summon a{1} {0} <b>Jade Golem</b>. Gain an empty Mana Crystal.@Summon a <b>Jade Golem</b>. Gain an empty Mana Crystal.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT = 0
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_713", new Power
			{
				PowerTask = ComplexTask.Create(
					ComplexTask.SummonJadeGolem(SummonSide.SPELL),
					new ManaCrystalEmptyTask(1))
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_811] Lunar Visions - COST:5 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw 2 cards. Minions drawn cost (2) less.
			// --------------------------------------------------------
			cards.Add("CFM_811", new Power
			{
				PowerTask = new EnqueueTask(2, ComplexTask.Create(
					new DrawTask(true),
					new FilterStackTask(SelfCondition.IsMinion),
					new AddAuraEffect(Effects.ReduceCost(2), EntityType.STACK)))
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [CFM_308a] Forgotten Armor (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Gain 10 Armor.
			// --------------------------------------------------------
			cards.Add("CFM_308a", new Power
			{
				PowerTask = new ArmorTask(10)
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_308b] Forgotten Mana (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Refresh your Mana Crystals.
			// --------------------------------------------------------
			cards.Add("CFM_308b", new Power
			{
				PowerTask = new SetControllerGameTagTask(GameTag.RESOURCES_USED, 0)
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_602a] Jade Idol (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon a{1} {0} <b>Jade Golem</b>.
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_602a", new Power
			{
				PowerTask = ComplexTask.SummonJadeGolem(SummonSide.SPELL)
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_602b] Jade Idol (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Shuffle 3 Jade Idols into your deck.
			// --------------------------------------------------------
			cards.Add("CFM_602b", new Power
			{
				PowerTask = new AddCardTo("CFM_602", EntityType.DECK, 3)
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [CFM_315] Alleycat - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 1/1_Cat.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_315", new Power
			{
				PowerTask = new SummonTask("CFM_315t", SummonSide.RIGHT)
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_316] Rat Pack - COST:3 [ATK:2/HP:2] 
			// - Race: beast, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Summon a
			//       number of 1/1 Rats equal
			//       _to this minion's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_316", new Power
			{
				// TODO
				DeathrattleTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.SOURCE),
					new EnqueueNumberTask(new SummonTask("CFM_316t", SummonSide.DEATHRATTLE)))
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_333] Knuckles - COST:5 [ATK:3/HP:7] 
			// - Race: beast, Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: After this attacks a
			//       minion, it also hits the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - FINISH_ATTACK_SPELL_ON_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("CFM_333", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					//Condition = new SelfCondition(p => p.Game.IdEntityDic[p.Game.ProposedDefender] is Minion),
					Condition = SelfCondition.IsEventTargetIs(CardType.MINION),
					SingleTask = ComplexTask.Create(
						new GetGameTagTask(GameTag.ATK, EntityType.SOURCE),
						new DamageNumberTask(EntityType.OP_HERO))
				}
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_335] Dispatch Kodo - COST:4 [ATK:2/HP:4] 
			// - Race: beast, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal damage equal to this minion's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CFM_335", new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.SOURCE),
					new DamageNumberTask(EntityType.TARGET))
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_336] Shaky Zipgunner - COST:3 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Give a random
			//       minion in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_336", new Power
			{
				DeathrattleTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "CFM_336e")
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_338] Trogg Beastrager - COST:2 [ATK:3/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random Beast in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_338", new Power
			{
				PowerTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "CFM_338e", SelfCondition.IsRace(Race.BEAST))
			});

			// ----------------------------------------- SPELL - HUNTER
			// [CFM_026] Hidden Cache - COST:2 
			// - Fac: neutral, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, give a random minion in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("CFM_026", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					SingleTask = ComplexTask.Secret(
						ComplexTask.BuffRandomMinion(EntityType.HAND, "CFM_026e"))
				}
			});

			// ----------------------------------------- SPELL - HUNTER
			// [CFM_334] Smuggler's Crate - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Give a random Beast in your hand +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_334", new Power
			{
				PowerTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "CFM_334e", SelfCondition.IsRace(Race.BEAST))
			});

			// ---------------------------------------- WEAPON - HUNTER
			// [CFM_337] Piranha Launcher - COST:5 [ATK:2/HP:0] 
			// - Fac: neutral, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]After your hero attacks,
			//       summon a 1/1 Piranha.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			cards.Add("CFM_337", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = new SummonTask("CFM_337t")
				}
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [CFM_026e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2 from Hidden Cache.
			// --------------------------------------------------------
			cards.Add("CFM_026e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_026e")
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [CFM_338e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Trogg Beastrager.
			// --------------------------------------------------------
			cards.Add("CFM_338e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_338e")
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_315t] Tabbycat (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_315t", null);

			// ---------------------------------------- MINION - HUNTER
			// [CFM_316t] Rat (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_316t", null);

			// ---------------------------------------- MINION - HUNTER
			// [CFM_337t] Piranha (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_337t", null);

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [CFM_066] Kabal Lackey - COST:1 [ATK:2/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> The next <b>Secret</b>
			//       you play this turn costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("CFM_066", new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_612o", EntityType.CONTROLLER)
			});

			// ------------------------------------------ MINION - MAGE
			// [CFM_660] Manic Soulcaster - COST:3 [ATK:3/HP:4] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Shuffle a copy into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_660", new Power
			{
				PowerTask = new CopyTask(EntityType.TARGET, Zone.DECK)
			});

			// ------------------------------------------ MINION - MAGE
			// [CFM_671] Cryomancer - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If an enemy is <b>Frozen</b>, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CFM_671", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasOp(GameTag.FROZEN, 1)),
					new FlagTask(true, new AddEnchantmentTask("CFM_671e", EntityType.SOURCE))),
			});

			// ------------------------------------------ MINION - MAGE
			// [CFM_687] Inkmaster Solia - COST:7 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your deck has
			//       no duplicates, the next
			//       spell you cast this turn
			//       costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_687", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsNoDupeInDeck),
					new FlagTask(true,
						new AddEnchantmentTask("CFM_687e", EntityType.CONTROLLER)))
			});

			// ------------------------------------------ MINION - MAGE
			// [CFM_760] Kabal Crystal Runner - COST:6 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Costs (2) less for each <b>Secret</b> you've played this_game.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("CFM_760", new Power
			{
				Aura = new AdaptiveCostEffect(p => p.Controller.NumSecretsPlayedThisGame * 2)
				//{
				//	UpdateTrigger = (TriggerType.AFTER_CAST, TriggerSource.FRIENDLY, SelfCondition.IsSecret)
				//}
			});

			// ------------------------------------------- SPELL - MAGE
			// [CFM_021] Freezing Potion - COST:0 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> an enemy.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CFM_021", new Power
			{
				PowerTask = ComplexTask.Freeze(EntityType.TARGET)
			});

			// ------------------------------------------- SPELL - MAGE
			// [CFM_065] Volcanic Potion - COST:3 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to all_minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_065", new Power
			{
				PowerTask = new DamageTask(2, EntityType.ALLMINIONS, true)
			});

			// ------------------------------------------- SPELL - MAGE
			// [CFM_620] Potion of Polymorph - COST:3 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, transform it into a
			//       1/1 Sheep.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("CFM_620", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.EVENT_SOURCE, SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotDead, SelfCondition.IsNotUntouchable),
						new FlagTask(true, ComplexTask.Secret(
						new TransformTask("CFM_621_m5", EntityType.EVENT_SOURCE))))
				}
			});

			// ------------------------------------------- SPELL - MAGE
			// [CFM_623] Greater Arcane Missiles - COST:7 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Shoot three missiles at random enemies that deal $3 damage each. @spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_623", new Power
			{
				PowerTask = new EnqueueTask(3, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 3), true)
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [CFM_687e] Free Spell (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CFM_687e", new Power
			{
				Aura = new Aura(AuraType.HAND, Effects.SetCost(0))
				{
					RemoveTrigger = (TriggerType.CAST_SPELL, null)
				}
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [CFM_062] Grimestreet Protector - COST:7 [ATK:6/HP:6] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Give adjacent
			//       _minions <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("CFM_062", new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(EntityType.SOURCE, RelaCondition.IsSideBySide),
					new SetGameTagTask(GameTag.DIVINE_SHIELD, 1, EntityType.STACK))
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_639] Grimestreet Enforcer - COST:5 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, give all minions in your hand +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_639", new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.HAND),
						new FilterStackTask(SelfCondition.IsMinion),
						new AddEnchantmentTask("CFM_639e", EntityType.STACK))
				}
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_650] Grimscale Chum - COST:1 [ATK:2/HP:1] 
			// - Race: murloc, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Give a random
			//       Murloc in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_650", new Power
			{
				PowerTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "CFM_650e", SelfCondition.IsRace(Race.MURLOC))
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_753] Grimestreet Outfitter - COST:2 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all minions in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_753", new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new AddEnchantmentTask("CFM_753e", EntityType.STACK))
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_759] Meanstreet Marshal - COST:1 [ATK:1/HP:2] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If this minion has 2 or more Attack, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_759", new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsTagValue(GameTag.ATK, 2, RelaSign.GEQ)),
					new FlagTask(true, new DrawTask()))
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_815] Wickerflame Burnbristle - COST:3 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Divine Shield, Taunt, Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("CFM_815", null);

			// ---------------------------------------- SPELL - PALADIN
			// [CFM_305] Smuggler's Run - COST:1 
			// - Fac: neutral, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Give all minions in your hand +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_305", new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsMinion),
					new AddEnchantmentTask("CFM_305e", EntityType.STACK))
			});

			// ---------------------------------------- SPELL - PALADIN
			// [CFM_800] Getaway Kodo - COST:1 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a friendly minion dies, return it to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("CFM_800", new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = ComplexTask.Secret(
						new CopyTask(EntityType.TARGET, Zone.HAND)),
					RemoveAfterTriggered = true
				}
			});

			// ---------------------------------------- SPELL - PALADIN
			// [CFM_905] Small-Time Recruits - COST:3 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Draw three 1-Cost
			//       minions from your deck.
			// --------------------------------------------------------
			cards.Add("CFM_905", new Power
			{
				PowerTask = ComplexTask.DrawFromDeck(3, SelfCondition.IsBaseTagValue(GameTag.COST, 1), SelfCondition.IsMinion)
			});
		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [CFM_305e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Smuggler's Run.
			// --------------------------------------------------------
			cards.Add("CFM_305e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_305e")
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [CFM_020] Raza the Chained - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]  <b>Battlecry:</b> If your deck has  
			//       no duplicates, your Hero
			//        Power costs (0) this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_020", new Power
			{
				InfoCardId = "CFM_020e",
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsNoDupeInDeck),
					new AddEnchantmentTask("CFM_020e", EntityType.CONTROLLER))
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_605] Drakonid Operative - COST:5 [ATK:5/HP:6] 
			// - Race: dragon, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you're holding a
			//       Dragon, <b>Discover</b> a card in
			//       _your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("CFM_605", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand, SelfCondition.IsOpDeckNotEmpty),
					new FlagTask(true, new DiscoverTask(DiscoverType.OP_DECK)))
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_606] Mana Geode - COST:2 [ATK:2/HP:3] 
			// - Race: elemental, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever this minion is_healed, summon a 2/2_Crystal.
			// --------------------------------------------------------
			cards.Add("CFM_606", new Power
			{
				Trigger = new Trigger(TriggerType.HEAL)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = new SummonTask("CFM_606t", SummonSide.RIGHT)
				}
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_626] Kabal Talonpriest - COST:3 [ATK:3/HP:4] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +3 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_626", new Power
			{
				PowerTask = new AddEnchantmentTask("CFM_626e", EntityType.TARGET)
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_657] Kabal Songstealer - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Silence</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("CFM_657", new Power
			{
				PowerTask = new SilenceTask(EntityType.TARGET)
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CFM_603] Potion of Madness - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Gain control of an enemy minion with 2 or less Attack until end of turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_TARGET_MAX_ATTACK = 2
			// --------------------------------------------------------
			cards.Add("CFM_603", new Power
			{
				PowerTask = ComplexTask.Create(
					new ControlTask(EntityType.TARGET),
					new AddEnchantmentTask("CFM_603e", EntityType.TARGET))
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CFM_604] Greater Healing Potion - COST:4 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Restore #12 Health to a friendly character.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_604", new Power
			{
				PowerTask = new HealTask(12, EntityType.TARGET)
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CFM_661] Pint-Size Potion - COST:1 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Give all enemy minions
			//       -3 Attack this turn only.
			// --------------------------------------------------------
			cards.Add("CFM_661", new Power
			{
				PowerTask = new AddEnchantmentTask("CFM_661e", EntityType.OP_MINIONS)
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CFM_662] Dragonfire Potion - COST:6 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Deal $5 damage to all
			//       minions except Dragons. @spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_662", new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS),
					new FilterStackTask(SelfCondition.IsNotRace(Race.DRAGON)),
					new DamageTask(5, EntityType.STACK, true))
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CFM_603e] Madness Potion (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: This minion has switched controllers this turn.
			// --------------------------------------------------------
			cards.Add("CFM_603e", new Power
			{
				Enchant = new Enchant(Effects.Charge, new Effect(GameTag.CONTROLLER_CHANGED_THIS_TURN, EffectOperator.SET, 1)),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					EitherTurn = true,
					SingleTask = ComplexTask.Create(
						new RemoveEnchantmentTask(),
						new ControlTask(EntityType.TARGET, true))
				}
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CFM_661e] Shrunk (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: -3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CFM_661e", new Power
			{
				Enchant = new Enchant(ATK.Effect(EffectOperator.SUB, 3))
				{
					IsOneTurnEffect = true
				}
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_606t] Crystal (*) - COST:2 [ATK:2/HP:2] 
			// - Race: elemental, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_606t", null);

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [CFM_342] Luckydo Buccaneer - COST:6 [ATK:5/HP:5] 
			// - Race: pirate, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your weapon has at least 3 Attack, gain +4/+4.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_342", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.WEAPON, SelfCondition.IsTagValue(GameTag.ATK, 3, RelaSign.GEQ)),
					new FlagTask(true, new AddEnchantmentTask("CFM_342e", EntityType.SOURCE)))
			});

			// ----------------------------------------- MINION - ROGUE
			// [CFM_634] Lotus Assassin - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Stealth</b>. Whenever this attacks and kills a minion, gain <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_634", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					//Condition = new SelfCondition(p => p.Game.IdEntityDic[p.Game.ProposedDefender].ToBeDestroyed),
					Condition = SelfCondition.IsDefenderDead,
					SingleTask = new SetGameTagTask(GameTag.STEALTH, 1, EntityType.SOURCE)
				}
			});

			// ----------------------------------------- MINION - ROGUE
			// [CFM_636] Shadow Rager - COST:3 [ATK:5/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_636", null);

			// ----------------------------------------- MINION - ROGUE
			// [CFM_691] Jade Swarmer - COST:2 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Deathrattle:</b> Summon a{1} {0} <b>Jade Golem</b>.@<b>Stealth</b>
			//       <b>Deathrattle:</b> Summon a <b>Jade Golem</b>.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_691", new Power
			{
				DeathrattleTask = ComplexTask.SummonJadeGolem(SummonSide.DEATHRATTLE)
			});

			// ----------------------------------------- MINION - ROGUE
			// [CFM_693] Gadgetzan Ferryman - COST:2 [ATK:2/HP:3] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Return a friendly minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_FOR_COMBO = 0
			// --------------------------------------------------------
			cards.Add("CFM_693", new Power
			{
				ComboTask = new ReturnHandTask(EntityType.TARGET)
			});

			// ----------------------------------------- MINION - ROGUE
			// [CFM_694] Shadow Sensei - COST:4 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a <b>Stealthed</b> minion +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_STEALTHED_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_694", new Power
			{
				PowerTask = new AddEnchantmentTask("CFM_694e", EntityType.TARGET)
			});

			// ----------------------------------------- MINION - ROGUE
			// [CFM_781] Shaku, the Collector - COST:3 [ATK:2/HP:3] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>. Whenever this
			//       attacks, add a random card
			//       to your hand <i>(from your
			//       opponent's class).</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_781", new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = ComplexTask.Create(
						new RandomCardTask(EntityType.OP_HERO),
						new AddStackTo(EntityType.HAND))
				}
			});

			// ------------------------------------------ SPELL - ROGUE
			// [CFM_630] Counterfeit Coin - COST:0 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			cards.Add("CFM_630", new Power
			{
				PowerTask = new TempManaTask(1)
			});

			// ------------------------------------------ SPELL - ROGUE
			// [CFM_690] Jade Shuriken - COST:2 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage.
			//       <b>Combo:</b> Summon a{1} {0} <b>Jade Golem</b>.@Deal $2 damage.
			//       <b>Combo:</b> Summon a <b>Jade Golem</b>. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("CFM_690", new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET),
				ComboTask = ComplexTask.Create(
					new DamageTask(2, EntityType.TARGET),
					ComplexTask.SummonJadeGolem(SummonSide.SPELL))
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CFM_342e] Looted Blade (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			cards.Add("CFM_342e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_342e")
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CFM_694e] Trained (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_694e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_694e")
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [CFM_061] Jinyu Waterspeaker - COST:4 [ATK:3/HP:6] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Restore 6 Health.
			//       <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - BATTLECRY = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_061", new Power
			{
				PowerTask = new HealTask(6, EntityType.TARGET)
			});

			// ---------------------------------------- MINION - SHAMAN
			// [CFM_312] Jade Chieftain - COST:7 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>. Give it <b>Taunt</b>. @<b>Battlecry:</b> Summon a <b>Jade Golem</b>. Give it <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_312", new Power
			{
				PowerTask = ComplexTask.Create(
					ComplexTask.SummonJadeGolem(SummonSide.RIGHT),
					ComplexTask.Taunt(EntityType.STACK))
			});

			// ---------------------------------------- MINION - SHAMAN
			// [CFM_324] White Eyes - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Shuffle
			//       'The Storm Guardian' into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_324", new Power
			{
				DeathrattleTask = new AddCardTo("CFM_324t", EntityType.DECK)
			});

			// ---------------------------------------- MINION - SHAMAN
			// [CFM_697] Lotus Illusionist - COST:4 [ATK:3/HP:5] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]After this minion attacks
			//       a hero, transform it into a
			//       _random 6-Cost minion.
			// --------------------------------------------------------
			cards.Add("CFM_697", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					//Condition = new SelfCondition(p => p.Game.IdEntityDic[p.Game.ProposedDefender] is Hero),
					Condition = SelfCondition.IsEventTargetIs(CardType.HERO),
					SingleTask = new TransformMinionTask(EntityType.SOURCE, 2)
				}
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CFM_310] Call in the Finishers - COST:4 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Summon four 1/1 Murlocs.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("CFM_310", new Power
			{
				PowerTask = new SummonTask("CFM_310t", 4)
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CFM_313] Finders Keepers - COST:1 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a card with_<b>Overload</b>. <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("CFM_313", new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.OVERLOAD)
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CFM_696] Devolve - COST:2 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Transform all enemy minions into random ones that cost (1) less.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HERO_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_696", new Power
			{
				PowerTask = new TransformMinionTask(EntityType.OP_MINIONS, -1)
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CFM_707] Jade Lightning - COST:4 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage. Summon a{1} {0} <b>Jade Golem</b>.@Deal $4 damage. Summon a <b>Jade Golem</b>. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_707", new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(4, EntityType.TARGET, true),
					ComplexTask.SummonJadeGolem(SummonSide.SPELL))
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [CFM_717] Jade Claws - COST:2 [ATK:2/HP:0] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>.
			//       <b><b>Overload</b>:</b> (1)@<b>Battlecry:</b> Summon a <b>Jade Golem</b>.
			//       <b><b>Overload</b>:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - OVERLOAD = 1
			// - BATTLECRY = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_717", new Power
			{
				PowerTask = ComplexTask.SummonJadeGolem(SummonSide.DEFAULT)
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [CFM_310t] Murloc Razorgill (*) - COST:1 [ATK:1/HP:1] 
			// - Race: murloc, Fac: neutral, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_310t", null);

			// ---------------------------------------- MINION - SHAMAN
			// [CFM_324t] The Storm Guardian (*) - COST:5 [ATK:10/HP:10] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_324t", null);

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [CFM_610] Crystalweaver - COST:4 [ATK:5/HP:4] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your Demons +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_610", new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.DEMON)),
					new AddEnchantmentTask("CFM_610e", EntityType.STACK))
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_663] Kabal Trafficker - COST:6 [ATK:6/HP:6] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]At the end of your turn,
			//       add a random Demon
			//       to your hand.
			// --------------------------------------------------------
			cards.Add("CFM_663", new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new RandomMinionTask(GameTag.CARDRACE, (int)Race.DEMON),
						new AddStackTo(EntityType.HAND))
				}
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_699] Seadevil Stinger - COST:4 [ATK:4/HP:2] 
			// - Race: murloc, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> The next Murloc
			//       you play this turn costs
			//       _Health instead of Mana.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_699", new Power
			{
				PowerTask = new AddEnchantmentTask("CFM_699e", EntityType.CONTROLLER)
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_750] Krul the Unshackled - COST:9 [ATK:7/HP:9] 
			// - Race: demon, Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your deck has
			//       no duplicates, summon all
			//       _Demons from your hand._
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_750", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsNoDupeInDeck),
					new FlagTask(true, ComplexTask.Create(
						new IncludeTask(EntityType.HAND),
						new FilterStackTask(SelfCondition.IsRace(Race.DEMON)),
						new SummonStackTask(removeFromZone: true))))
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_751] Abyssal Enforcer - COST:7 [ATK:6/HP:6] 
			// - Race: demon, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_751", new Power
			{
				PowerTask = new DamageTask(3, EntityType.ALL_NOSOURCE)
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_900] Unlicensed Apothecary - COST:3 [ATK:5/HP:5] 
			// - Race: demon, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: After you summon a minion, deal 5 damage to_your hero.
			// --------------------------------------------------------
			cards.Add("CFM_900", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_SUMMON)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new DamageTask(5, EntityType.HERO)
				}
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [CFM_094] Felfire Potion - COST:6 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage to all characters. @spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_094", new Power
			{
				PowerTask = new DamageTask(5, EntityType.ALL, true)
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [CFM_608] Blastcrystal Potion - COST:4 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a minion and one of your Mana Crystals.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_608", new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.TARGET),
					new ManaCrystalEmptyTask(-1))
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [CFM_611] Bloodfury Potion - COST:3 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Give a minion +3 Attack.
			//       If it's a Demon, also
			//       give it +3 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_611", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.TARGET, SelfCondition.IsRace(Race.DEMON)),
					new FlagTask(true, new AddEnchantmentTask("CFM_611e2", EntityType.TARGET)),
					new FlagTask(false, new AddEnchantmentTask("CFM_611e", EntityType.TARGET))),
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [CFM_300] Public Defender - COST:2 [ATK:0/HP:7] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_300", null);

			// --------------------------------------- MINION - WARRIOR
			// [CFM_643] Hobart Grapplehammer - COST:2 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all weapons in your hand and deck +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_643", new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new IncludeTask(EntityType.DECK, null, true),
					new FilterStackTask(SelfCondition.IsWeapon),
					new AddEnchantmentTask("CFM_643e", EntityType.STACK))
			});

			// --------------------------------------- MINION - WARRIOR
			// [CFM_754] Grimy Gadgeteer - COST:4 [ATK:4/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, give a random minion in your hand +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_754", new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "CFM_754e")
				}
			});

			// --------------------------------------- MINION - WARRIOR
			// [CFM_755] Grimestreet Pawnbroker - COST:3 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random weapon in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_755", new Power
			{
				InfoCardId = "CFM_755e",
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsWeapon),
					new RandomTask(1, EntityType.STACK),
					new AddEnchantmentTask("CFM_755e", EntityType.STACK))
		});

			// --------------------------------------- MINION - WARRIOR
			// [CFM_756] Alley Armorsmith - COST:5 [ATK:2/HP:7] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       Whenever this minion
			//       deals damage, gain
			//       that much Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_756", new Power
			{
				Trigger = new Trigger(TriggerType.DEAL_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = ComplexTask.Create(
						new GetEventNumberTask(),
						new ArmorTask())
				}
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CFM_716] Sleep with the Fishes - COST:2 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $3 damage to all damaged minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_716", new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS),
					new FilterStackTask(SelfCondition.IsDamaged),
					new DamageTask(3, EntityType.STACK, true))
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CFM_752] Stolen Goods - COST:2 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a random <b>Taunt</b> minion in your hand +3/+3.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_752", new Power
			{
				PowerTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "CFM_752e", SelfCondition.HasTaunt)
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CFM_940] I Know a Guy - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Taunt</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_940", new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.TAUNT)
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [CFM_631] Brass Knuckles - COST:4 [ATK:2/HP:0] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]After your hero attacks,
			//       give a random minion in
			//       your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("CFM_631", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "CFM_631e")
				}
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CFM_643e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1 Attack from Hobart Grapplehammer.
			// --------------------------------------------------------
			cards.Add("CFM_643e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_643e")
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CFM_643e2] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1 Attack from Hobart Grapplehammer.
			// --------------------------------------------------------
			cards.Add("CFM_643e2", new Power
			{
				// TODO [CFM_643e2] Smuggling && Test: Smuggling_CFM_643e2
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [CFM_025] Wind-up Burglebot - COST:6 [ATK:5/HP:5] 
			// - Race: mechanical, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever this attacks a minion and survives, draw_a card.
			// --------------------------------------------------------
			cards.Add("CFM_025", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					Condition = new SelfCondition(
						p => !p.ToBeDestroyed
						     && p.Game.CurrentEventData.EventTarget is Minion),
					SingleTask = new DrawTask()
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_039] Street Trickster - COST:3 [ATK:0/HP:7] 
			// - Race: demon, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("CFM_039", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_060] Red Mana Wyrm - COST:5 [ATK:2/HP:6] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever  you cast a spell, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_060", new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("CFM_060e", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_063] Kooky Chemist - COST:4 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Swap the Attack and Health of a minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_063", new Power
			{
				PowerTask = new SwapAttackHealthTask(EntityType.TARGET, "CFM_063e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_064] Blubber Baron - COST:3 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you summon a <b>Battlecry</b> minion while this_is in your hand, gain_+1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_064", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_SUMMON)	// PRESUMMON
				{
					TriggerActivation = TriggerActivation.HAND,
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsBattlecryMinion,
					SingleTask = new AddEnchantmentTask("CFM_064e", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_067] Hozen Healer - COST:4 [ATK:2/HP:6] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: Restore a minion to full Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CFM_067", new Power
			{
				PowerTask = new HealFullTask(EntityType.TARGET)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_095] Weasel Tunneler - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle this minion into your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("CFM_095", new Power
			{
				DeathrattleTask = new AddCardTo("CFM_095", EntityType.OP_DECK)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_120] Mistress of Mixtures - COST:1 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Restore 4 Health to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_120", new Power
			{
				DeathrattleTask = new HealTask(4, EntityType.HEROES)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_321] Grimestreet Informant - COST:2 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Discover</b> a
			//       Hunter, Paladin, or Warrior
			//       card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 532
			// - MULTI_CLASS_GROUP = 1
			// - GRIMY_GOONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("CFM_321", new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.HUNTER_PALADIN_WARRIOR)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_325] Small-Time Buccaneer - COST:1 [ATK:1/HP:1] 
			// - Race: pirate, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Has +2 Attack while you have a weapon equipped.
			// --------------------------------------------------------
			cards.Add("CFM_325", new Power
			{
				InfoCardId = "CFM_325e",
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.ADD, p => p.Controller.Hero.Weapon != null ? 2 : 0)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_328] Fight Promoter - COST:6 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you control
			//       a minion with 6 or more
			//       _Health, draw two cards.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_328", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE,
						SelfCondition.HasBoardMinion(GameTag.HEALTH, 6, RelaSign.GEQ)),
					new FlagTask(true, new DrawTask(2)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_341] Sergeant Sally - COST:3 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal damage equal to this minion's Attack to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_341", new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.SOURCE),
					new DamageNumberTask(EntityType.ENEMIES))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_344] Finja, the Flying Star - COST:5 [ATK:2/HP:4] 
			// - Race: murloc, Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>
			//          Whenever this attacks and   
			//       kills a minion, summon 2
			//       _Murlocs from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_344", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					//Condition = new SelfCondition(p => p.Game.IdEntityDic[p.Game.ProposedDefender].ToBeDestroyed),
					Condition = SelfCondition.IsDefenderDead,
					SingleTask = new EnqueueTask(2, ComplexTask.SummonRandomMinion(EntityType.DECK, RelaCondition.IsSameRace))
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_609] Fel Orc Soulfiend - COST:3 [ATK:3/HP:7] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 2 damage to this_minion.
			// --------------------------------------------------------
			cards.Add("CFM_609", new Power
			{
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = new DamageTask(2, EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_619] Kabal Chemist - COST:4 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Potion to your hand.
			// --------------------------------------------------------
			// Entourage: CFM_065, CFM_021, CFM_603, CFM_604, CFM_611, CFM_620, CFM_094, CFM_661, CFM_662, CFM_608
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 296
			// - MULTI_CLASS_GROUP = 3
			// - KABAL = 1
			// --------------------------------------------------------
			cards.Add("CFM_619", new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomEntourageTask(),
					new AddStackTo(EntityType.HAND))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_621] Kazakus - COST:4 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your deck
			//       has no duplicates,
			//       _create a custom spell.
			// --------------------------------------------------------
			// Entourage: CFM_621t11, CFM_621t12, CFM_621t13
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 296
			// - MULTI_CLASS_GROUP = 3
			// - KABAL = 1
			// --------------------------------------------------------
			cards.Add("CFM_621", new Power
			{
				// TODO [CFM_621] Kazakus && Test: Kazakus_CFM_621
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsNoDupeInDeck),
					new FlagTask(true, new PotionGenerating()))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_637] Patches the Pirate - COST:1 [ATK:1/HP:1] 
			// - Race: pirate, Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Charge</b>
			//       After you play a Pirate,
			//       summon this minion
			//       from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CFM_637", new Power
			{
				Trigger = new Trigger(TriggerType.PLAY_MINION)
				{
					TriggerActivation = TriggerActivation.DECK,
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsRace(Race.PIRATE),
					SingleTask = SpecificTask.PatchesThePirate
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_646] Backstreet Leper - COST:3 [ATK:3/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Deal 2 damage
			//       to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_646", new Power
			{
				DeathrattleTask = new DamageTask(2, EntityType.OP_HERO)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_647] Blowgill Sniper - COST:2 [ATK:2/HP:1] 
			// - Race: murloc, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_647", new Power
			{
				PowerTask = new DamageTask(1, EntityType.TARGET)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_648] Big-Time Racketeer - COST:6 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 6/6_Ogre.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_648", new Power
			{
				PowerTask = new SummonTask("CFM_648t", SummonSide.RIGHT)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_649] Kabal Courier - COST:3 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a Mage, Priest, or Warlock card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 296
			// - MULTI_CLASS_GROUP = 3
			// - KABAL = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("CFM_649", new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.MAGE_PRIEST_WARLOCK)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_651] Naga Corsair - COST:4 [ATK:5/HP:4] 
			// - Race: pirate, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your weapon +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_651", new Power
			{
				PowerTask = new AddEnchantmentTask("CFM_651e", EntityType.WEAPON)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_652] Second-Rate Bruiser - COST:5 [ATK:4/HP:5] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       Costs (2) less if your
			//       opponent has at least
			//       three minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_652", new Power
			{
				Aura = new AdaptiveCostEffect(p => p.Controller.Opponent.BoardZone.Count > 2 ? 2 : 0)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_653] Hired Gun - COST:3 [ATK:4/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_653", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_654] Friendly Bartender - COST:2 [ATK:2/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 1 Health to your_hero.
			// --------------------------------------------------------
			cards.Add("CFM_654", new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new HealTask(1, EntityType.HERO)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_655] Toxic Sewer Ooze - COST:3 [ATK:4/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Remove 1 Durability from your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_655", new Power
			{
				PowerTask = new DamageWeaponTask()
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_656] Streetwise Investigator - COST:5 [ATK:4/HP:6] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Enemy minions lose <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_656", new Power
			{
				PowerTask = new RevealStealthTask(EntityType.OP_MINIONS)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_658] Backroom Bouncer - COST:4 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a friendly minion dies, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_658", new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = new AddEnchantmentTask("CFM_658e", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_659] Gadgetzan Socialite - COST:2 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 2_Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CFM_659", new Power
			{
				PowerTask = new HealTask(2, EntityType.TARGET)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_665] Worgen Greaser - COST:4 [ATK:6/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			cards.Add("CFM_665", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_666] Grook Fu Master - COST:5 [ATK:3/HP:5] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("CFM_666", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_667] Bomb Squad - COST:5 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 5 damage
			//       to an enemy minion.
			//       <b>Deathrattle:</b> Deal 5 damage
			//       to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_667", new Power
			{
				PowerTask = new DamageTask(5, EntityType.TARGET),
				DeathrattleTask = new DamageTask(5, EntityType.HERO)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_668] Doppelgangster - COST:5 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon 2 copies of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_668", new Power
			{
				PowerTask = SpecificTask.Doppelgangster
					
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_669] Burgly Bully - COST:5 [ATK:4/HP:6] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, add a Coin to your hand.
			// --------------------------------------------------------
			cards.Add("CFM_669", new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = new AddCardTo("GAME_005", EntityType.HAND)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_670] Mayor Noggenfogger - COST:9 [ATK:5/HP:4] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: All targets are chosen randomly.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CFM_670", new Power
			{
				// TODO [CFM_670] Mayor Noggenfogger && Test: Mayor Noggenfogger_CFM_670
				Trigger = new Trigger(TriggerType.TARGET)
				{
					SingleTask = SpecificTask.MayorNoggenfogger
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_672] Madam Goya - COST:6 [ATK:4/HP:3] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Swap it with a minion in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_672", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasMinionInDeck()),
					new FlagTask(true, ComplexTask.Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new RemoveFromDeck(EntityType.STACK),
					new MoveToDeck(EntityType.TARGET),
					new SummonTask())))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_685] Don Han'Cho - COST:7 [ATK:5/HP:6] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random minion in your hand +5/+5.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 532
			// - MULTI_CLASS_GROUP = 1
			// - GRIMY_GOONS = 1
			// --------------------------------------------------------
			cards.Add("CFM_685", new Power
			{
				PowerTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "CFM_685e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_688] Spiked Hogrider - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If an enemy minion has <b>Taunt</b>, gain_<b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CFM_688", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.HasOpBoardMinion(GameTag.TAUNT, 1)),
					new FlagTask(true, ComplexTask.Charge(EntityType.SOURCE)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_715] Jade Spirit - COST:4 [ATK:2/HP:3] 
			// - Race: elemental, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade_Golem</b>.@<b>Battlecry:</b> Summon a <b>Jade_Golem</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - JADE_GOLEM = 1
			// - MULTIPLE_CLASSES = 194
			// - MULTI_CLASS_GROUP = 2
			// - JADE_LOTUS = 1
			// --------------------------------------------------------
			cards.Add("CFM_715", new Power
			{
				PowerTask = ComplexTask.SummonJadeGolem(SummonSide.SPELL)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_790] Dirty Rat - COST:2 [ATK:2/HP:6] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Your opponent
			//       summons a random minion
			//       from their hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_790", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.OP_HERO, SelfCondition.IsNotBoardFull),
					new FlagTask(true, ComplexTask.Create(
						new IncludeTask(EntityType.OP_HAND),
						new FilterStackTask(SelfCondition.IsMinion),
						new RandomTask(1, EntityType.STACK),
						new RemoveFromHand(EntityType.STACK),
						new SummonOpTask()))),
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_806] Wrathion - COST:6 [ATK:4/HP:5] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Battlecry:</b> Draw cards until you draw one that isn't a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_806", new Power
			{
				PowerTask = ComplexTask.RecursiveTask(
					new ConditionTask(EntityType.STACK, SelfCondition.IsRace(Race.DRAGON)),
					new DrawTask(true))

			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_807] Auctionmaster Beardo - COST:3 [ATK:3/HP:4] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you cast a spell, refresh your Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CFM_807", new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new SetGameTagTask(GameTag.EXHAUSTED, 0, EntityType.HERO_POWER)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_808] Genzo, the Shark - COST:4 [ATK:5/HP:4] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever this attacks, both players draw until they have 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CFM_808", new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = ComplexTask.Create(new FuncNumberTask(p =>
						{
							Controller controller = p.Controller;
							int diffHands = 3 - controller.HandZone.Count;
							return diffHands > 0 ? diffHands : 0;
						}),
						new EnqueueNumberTask(new DrawTask()),
						new ClearStackTask(),
						ComplexTask.Create(new FuncNumberTask(p =>
							{
								Controller controller = p.Controller;
								int diffHands = 3 - controller.Opponent.HandZone.Count;
								return diffHands > 0 ? diffHands : 0;
							}),
							new EnqueueNumberTask(new DrawOpTask())))
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_809] Tanaris Hogchopper - COST:4 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your opponent's
			//       hand is empty, gain <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CFM_809", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsOpHandEmpty),
					new FlagTask(true, ComplexTask.Charge(EntityType.SOURCE))),
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_810] Leatherclad Hogleader - COST:6 [ATK:6/HP:6] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your opponent has 6 or more cards in hand, gain <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CFM_810", new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsOpZoneCount(Zone.HAND, 6, RelaSign.GEQ)),
					new FlagTask(true, ComplexTask.Charge(EntityType.SOURCE)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_851] Daring Reporter - COST:4 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your opponent draws a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_851", new Power
			{
				Trigger = new Trigger(TriggerType.DRAW)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = new AddEnchantmentTask("CFM_851e", EntityType.SOURCE)
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_852] Lotus Agents - COST:5 [ATK:5/HP:3] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a Druid, Rogue, or Shaman card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 194
			// - MULTI_CLASS_GROUP = 2
			// - JADE_LOTUS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("CFM_852", new Power
			{
				PowerTask = new DiscoverTask(DiscoverType.DRUID_ROGUE_SHAMAN)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_853] Grimestreet Smuggler - COST:3 [ATK:2/HP:4] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random minion in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 532
			// - MULTI_CLASS_GROUP = 1
			// - GRIMY_GOONS = 1
			// --------------------------------------------------------
			cards.Add("CFM_853", new Power
			{
				PowerTask = ComplexTask.BuffRandomMinion(EntityType.HAND, "CFM_853e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_854] Ancient of Blossoms - COST:6 [ATK:3/HP:8] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_854", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_855] Defias Cleaner - COST:6 [ATK:5/HP:7] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b> a minion with <b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("CFM_855", new Power
			{
				PowerTask = new SilenceTask(EntityType.TARGET)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_902] Aya Blackpaw - COST:6 [ATK:5/HP:3] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b> Summon a{1} {0} <b>Jade Golem</b>. @ <b>Battlecry and Deathrattle:</b> Summon a <b>Jade Golem</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// - JADE_GOLEM = 1
			// - MULTIPLE_CLASSES = 194
			// - MULTI_CLASS_GROUP = 2
			// - JADE_LOTUS = 1
			// --------------------------------------------------------
			cards.Add("CFM_902", new Power
			{
				PowerTask = ComplexTask.SummonJadeGolem(SummonSide.RIGHT),
				DeathrattleTask = ComplexTask.SummonJadeGolem(SummonSide.DEATHRATTLE)
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_020e] Raza Enchant (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Your <b>Hero Power</b> costs (0).
			// --------------------------------------------------------
			cards.Add("CFM_020e", new Power
			{
				Aura = new Aura(AuraType.HEROPOWER, Effects.SetCost(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_060e] Mana Heist (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("CFM_060e", new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(2))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_063e] Kooky Chemistry (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Kooky Chemist.
			// --------------------------------------------------------
			cards.Add("CFM_063e", new Power
			{
				Enchant = new Enchant(Effects.SetAttackHealth(0))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_064e] Size Increase (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("CFM_064e", new Power
			{
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_325e] Equipped (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_325e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_325e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_334e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2 from Smuggler's Crate.
			// --------------------------------------------------------
			cards.Add("CFM_334e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_334e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_336e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2 from Shaky Zipgunner.
			// --------------------------------------------------------
			cards.Add("CFM_336e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_336e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_610e] Serrated Shadows (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_610e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_610e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_611e] Demonic Draught (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_611e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_611e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_611e2] Demonic Draught (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("CFM_611e2", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_611e2")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_614e] Savage Mark (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_614e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_614e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_617e] Visions of Hypnos (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_617e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_617e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_621e] Goldthorn (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("CFM_621e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_621e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_621e2] Goldthorn (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +4 Health.
			// --------------------------------------------------------
			cards.Add("CFM_621e2", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_621e2")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_621e3] Goldthorn (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +6 Health.
			// --------------------------------------------------------
			cards.Add("CFM_621e3", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_621e3")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_626e] Fortitude (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("CFM_626e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_626e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_631e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased stats from Brass Knuckles.
			// --------------------------------------------------------
			cards.Add("CFM_631e", new Power
			{
				//Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
				Enchant = new Enchant(Effects.AttackHealth_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_639e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased stats from Grimestreet Enforcer.
			// --------------------------------------------------------
			cards.Add("CFM_639e", new Power
			{
				//Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
				Enchant = new Enchant(Effects.AttackHealth_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_650e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Grimscale Chum.
			// --------------------------------------------------------
			cards.Add("CFM_650e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_650e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_651e] Extra Sharp (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_651e", new Power
			{
				Enchant = new Enchant(GameTag.ATK, EffectOperator.ADD, 1)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_658e] Cut Off (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("CFM_658e", new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_671e] We All Scream (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_671e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_671e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_685e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +5/+5 from Don Han'Cho.
			// --------------------------------------------------------
			cards.Add("CFM_685e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_685e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_699e] Seadevil Enchant (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CFM_699e", new Power
			{
				Aura = new Aura(AuraType.HAND, new Effect(GameTag.CARD_COSTS_HEALTH, EffectOperator.SET, 1))
				{
					Condition = SelfCondition.IsRace(Race.MURLOC),
					RemoveTrigger = (TriggerType.PLAY_MINION, SelfCondition.IsRace(Race.MURLOC))
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_752e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +3/+3 from Stolen Goods.
			// --------------------------------------------------------
			cards.Add("CFM_752e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_752e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_753e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Grimestreet Outfitter.
			// --------------------------------------------------------
			cards.Add("CFM_753e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_753e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_754e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased stats from Grimy Gadgeteer.
			// --------------------------------------------------------
			cards.Add("CFM_754e", new Power
			{
				//Enchant = new OngoingEnchant(Effects.AttackHealth_N(2))
				Enchant = new Enchant(Effects.AttackHealth_N(2))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_755e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Grimestreet Pawnbroker.
			// --------------------------------------------------------
			cards.Add("CFM_755e", new Power
			{
				Enchant = new Enchant(Effects.Attack_N(1), new Effect(GameTag.DURABILITY, EffectOperator.ADD, 1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_816e] Get Big (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_816e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_816e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_851e] The Scoop (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("CFM_851e", new Power
			{
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_853e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Grimestreet Smuggler.
			// --------------------------------------------------------
			cards.Add("CFM_853e", new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CFM_853e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_BossRumble001hpe] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2 from Han'Cho
			// --------------------------------------------------------
			cards.Add("TB_BossRumble001hpe", new Power
			{
				// TODO [TB_BossRumble001hpe] Smuggling && Test: Smuggling_TB_BossRumble001hpe
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_HealthAttackSwap_Ench] Putricide's Potion (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Putricide
			// --------------------------------------------------------
			cards.Add("TB_HealthAttackSwap_Ench", new Power
			{
				// TODO [TB_HealthAttackSwap_Ench] Putricide's Potion && Test: Putricide's Potion_TB_HealthAttackSwap_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_621_m2] Kabal Demon (*) - COST:5 [ATK:5/HP:5] 
			// - Race: demon, Fac: neutral, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_621_m2", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_621_m3] Kabal Demon (*) - COST:8 [ATK:8/HP:8] 
			// - Race: demon, Fac: neutral, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_621_m3", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_621_m4] Kabal Demon (*) - COST:2 [ATK:2/HP:2] 
			// - Race: demon, Fac: neutral, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_621_m4", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_621_m5] Sheep (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_621_m5", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_648t] "Little Friend" (*) - COST:6 [ATK:6/HP:6] 
			// - Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_648t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_668t] Doppelgangster (*) - COST:5 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon 2 copies of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_668t", new Power
			{
				PowerTask = SpecificTask.Doppelgangster
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_668t2] Doppelgangster (*) - COST:5 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon 2 copies of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_668t2", new Power
			{
				PowerTask = SpecificTask.Doppelgangster
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t01] Jade Golem (*) - COST:1 [ATK:1/HP:1] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t01", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t02] Jade Golem (*) - COST:2 [ATK:2/HP:2] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t02", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t03] Jade Golem (*) - COST:3 [ATK:3/HP:3] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t03", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t04] Jade Golem (*) - COST:4 [ATK:4/HP:4] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t04", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t05] Jade Golem (*) - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t05", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t06] Jade Golem (*) - COST:6 [ATK:6/HP:6] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t06", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t07] Jade Golem (*) - COST:7 [ATK:7/HP:7] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t07", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t08] Jade Golem (*) - COST:8 [ATK:8/HP:8] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t08", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t09] Jade Golem (*) - COST:9 [ATK:9/HP:9] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t09", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t10] Jade Golem (*) - COST:10 [ATK:10/HP:10] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t10", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t11] Jade Golem (*) - COST:10 [ATK:11/HP:11] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t11", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t12] Jade Golem (*) - COST:10 [ATK:12/HP:12] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t12", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t13] Jade Golem (*) - COST:10 [ATK:13/HP:13] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t13", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t14] Jade Golem (*) - COST:10 [ATK:14/HP:14] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t14", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t15] Jade Golem (*) - COST:10 [ATK:15/HP:15] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t15", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t16] Jade Golem (*) - COST:10 [ATK:16/HP:16] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t16", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t17] Jade Golem (*) - COST:10 [ATK:17/HP:17] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t17", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t18] Jade Golem (*) - COST:10 [ATK:18/HP:18] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t18", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t19] Jade Golem (*) - COST:10 [ATK:19/HP:19] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t19", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t20] Jade Golem (*) - COST:10 [ATK:20/HP:20] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t20", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t21] Jade Golem (*) - COST:10 [ATK:21/HP:21] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t21", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t22] Jade Golem (*) - COST:10 [ATK:22/HP:22] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t22", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t23] Jade Golem (*) - COST:10 [ATK:23/HP:23] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t23", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t24] Jade Golem (*) - COST:10 [ATK:24/HP:24] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t24", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t25] Jade Golem (*) - COST:10 [ATK:25/HP:25] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t25", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t26] Jade Golem (*) - COST:10 [ATK:26/HP:26] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t26", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t27] Jade Golem (*) - COST:10 [ATK:27/HP:27] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t27", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t28] Jade Golem (*) - COST:10 [ATK:28/HP:28] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t28", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t29] Jade Golem (*) - COST:10 [ATK:29/HP:29] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t29", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t30] Jade Golem (*) - COST:10 [ATK:30/HP:30] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t30", null);

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t] Kazakus Potion (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("CFM_621t", new Power
			{
				// TODO [CFM_621t] Kazakus Potion && Test: Kazakus Potion_CFM_621t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t10] Netherbloom (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon a 2/2 Demon.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 2
			// --------------------------------------------------------
			cards.Add("CFM_621t10", new Power
			{
				PowerTask = new SummonTask("CFM_621_m4")
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t11] Lesser Potion (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Create a 1-Cost spell.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1087
			// --------------------------------------------------------
			cards.Add("CFM_621t11", new Power
			{
				// TODO [CFM_621t11] Lesser Potion && Test: Lesser Potion_CFM_621t11
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t12] Greater Potion (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Create a 5-Cost spell.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1088
			// --------------------------------------------------------
			cards.Add("CFM_621t12", new Power
			{
				// TODO [CFM_621t12] Greater Potion && Test: Greater Potion_CFM_621t12
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t13] Superior Potion (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Create a 10-Cost spell.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1089
			// --------------------------------------------------------
			cards.Add("CFM_621t13", new Power
			{
				// TODO [CFM_621t13] Superior Potion && Test: Superior Potion_CFM_621t13
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t14] Kazakus Potion (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("CFM_621t14", new Power
			{
				// TODO [CFM_621t14] Kazakus Potion && Test: Kazakus Potion_CFM_621t14
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t15] Kazakus Potion (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("CFM_621t15", new Power
			{
				// TODO [CFM_621t15] Kazakus Potion && Test: Kazakus Potion_CFM_621t15
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t16] Heart of Fire (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $5 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 5
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_621t16", new Power
			{
				PowerTask = new DamageTask(5, EntityType.TARGET, true)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t17] Stonescale Oil (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Gain 7 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 6
			// --------------------------------------------------------
			cards.Add("CFM_621t17", new Power
			{
				PowerTask = new ArmorTask(7)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t18] Felbloom (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $4 damage to all minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 2
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t18", new Power
			{
				PowerTask = new DamageTask(4, EntityType.ALLMINIONS, true)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t19] Icecap (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: <b>Freeze</b> 2 random enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 8
			// --------------------------------------------------------
			cards.Add("CFM_621t19", new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(2, EntityType.ENEMIES),
					ComplexTask.Freeze(EntityType.STACK))
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t2] Heart of Fire (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $3 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 4
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_621t2", new Power
			{
				PowerTask = new DamageTask(3, EntityType.TARGET, true)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t20] Netherbloom (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon a 5/5 Demon.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 3
			// --------------------------------------------------------
			cards.Add("CFM_621t20", new Power
			{
				PowerTask = new SummonTask("CFM_621_m2", SummonSide.SPELL)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t21] Mystic Wool (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Transform a random enemy minion into a 1/1 Sheep.@Polymorph a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t21", new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(1, EntityType.OP_MINIONS),
					new TransformTask("CFM_621_m5", EntityType.STACK))
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t22] Kingsblood (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Draw 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 9
			// --------------------------------------------------------
			cards.Add("CFM_621t22", new Power
			{
				PowerTask = new DrawTask(2)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t23] Shadow Oil (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Add 2 random Demons to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 10
			// --------------------------------------------------------
			cards.Add("CFM_621t23", new Power
			{
				PowerTask = new EnqueueTask(2, ComplexTask.Create(
					new RandomMinionTask(GameTag.CARDRACE, (int)Race.DEMON),
					new AddStackTo(EntityType.HAND)))
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t24] Goldthorn (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Give your minions +4 Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 7
			// --------------------------------------------------------
			cards.Add("CFM_621t24", new Power
			{
				PowerTask = new AddEnchantmentTask("CFM_621e2", EntityType.MINIONS)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t25] Heart of Fire (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $8 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 5
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_621t25", new Power
			{
				PowerTask = new DamageTask(8, EntityType.TARGET, true)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t26] Stonescale Oil (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Gain 10 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 6
			// --------------------------------------------------------
			cards.Add("CFM_621t26", new Power
			{
				PowerTask = new ArmorTask(10)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t27] Icecap (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: <b>Freeze</b> 3 random enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 8
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t27", new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(3, EntityType.ENEMIES),
					ComplexTask.Freeze(EntityType.STACK))
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t28] Netherbloom (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon an 8/8 Demon.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 3
			// --------------------------------------------------------
			cards.Add("CFM_621t28", new Power
			{
				PowerTask = new SummonTask("CFM_621_m3", SummonSide.SPELL)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t29] Mystic Wool (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Transform all minions into 1/1 Sheep.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t29", new Power
			{
				PowerTask = ComplexTask.Create(
					new TransformTask("CFM_621_m5", EntityType.ALLMINIONS))
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t3] Stonescale Oil (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Gain 4 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 5
			// --------------------------------------------------------
			cards.Add("CFM_621t3", new Power
			{
				PowerTask = new ArmorTask(4)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t30] Kingsblood (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 9
			// --------------------------------------------------------
			cards.Add("CFM_621t30", new Power
			{
				PowerTask = new EnqueueTask(3, new DrawTask())
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t31] Shadow Oil (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Add 3 random Demons to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 10
			// --------------------------------------------------------
			cards.Add("CFM_621t31", new Power
			{
				PowerTask = new EnqueueTask(3, ComplexTask.Create(
					new RandomMinionTask(GameTag.CARDRACE, (int)Race.DEMON),
					new AddStackTo(EntityType.HAND)))
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t32] Goldthorn (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Give your minions +6 Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 7
			// --------------------------------------------------------
			cards.Add("CFM_621t32", new Power
			{
				PowerTask = new AddEnchantmentTask("CFM_621e3", EntityType.MINIONS)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t33] Felbloom (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $6 damage to all minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 2
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t33", new Power
			{
				PowerTask = new DamageTask(6, EntityType.ALLMINIONS, true)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t37] Ichor of Undeath (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon a friendly minion that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 3
			// --------------------------------------------------------
			cards.Add("CFM_621t37", new Power
			{
				PowerTask = ComplexTask.SummonRandomMinionThatDied()
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t38] Ichor of Undeath (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon 2 friendly minions that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 4
			// --------------------------------------------------------
			cards.Add("CFM_621t38", new Power
			{
				PowerTask = ComplexTask.SummonRandomMinionThatDied(amount: 2)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t39] Ichor of Undeath (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon 3 friendly minions that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 4
			// --------------------------------------------------------
			cards.Add("CFM_621t39", new Power
			{
				PowerTask = ComplexTask.SummonRandomMinionThatDied(amount: 3)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t4] Felbloom (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $2 damage to all minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t4", new Power
			{
				PowerTask = new DamageTask(2, EntityType.ALLMINIONS, true)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t5] Icecap (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 7
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t5", new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(1, EntityType.ENEMIES),
					ComplexTask.Freeze(EntityType.STACK))
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t6] Goldthorn (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Give your minions +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 6
			// --------------------------------------------------------
			cards.Add("CFM_621t6", new Power
			{
				PowerTask = new AddEnchantmentTask("CFM_621e", EntityType.MINIONS)
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t8] Kingsblood (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 8
			// --------------------------------------------------------
			cards.Add("CFM_621t8", new Power
			{
				PowerTask = new DrawTask()
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t9] Shadow Oil (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Add a random Demon to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 9
			// --------------------------------------------------------
			cards.Add("CFM_621t9", new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.CARDRACE, (int)Race.DEMON),
					new AddStackTo(EntityType.HAND))
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
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
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
