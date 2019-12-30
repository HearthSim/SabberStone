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
using SabberStoneCore.Triggers;
using SabberStoneCore.src.Loader;

// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets.Standard
{
	public class Expert1CardsGen
	{
		/// <summary>
		/// Expert cardset.
		/// </summary>
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- HERO - WARLOCK
			// [EX1_323h] Lord Jaraxxus (*) - COST:0 [ATK:0/HP:15]
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 1178
			// --------------------------------------------------------
			cards.Add("EX1_323h", new CardDef());

		}

		private static void HeroPowers(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ HERO_POWER - PRIEST
			// [EX1_625t] Mind Spike (*) - COST:2
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_625t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET)
			}));

			// ------------------------------------ HERO_POWER - PRIEST
			// [EX1_625t2] Mind Shatter (*) - COST:2
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $3 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_625t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(3, EntityType.TARGET)
			}));

			// ----------------------------------- HERO_POWER - WARLOCK
			// [EX1_tk33] INFERNO! (*) - COST:2
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 6/6 Infernal.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("EX1_tk33", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("EX1_tk34")
			}));

		}

		private static void Druid(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [EX1_165] Druid of the Claw - COST:5 [ATK:4/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Choose One -</b> Transform
			//       into a 4/4 with <b>Charge</b>;
			//       or a 4/6 with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_165", new CardDef(new Power
			{
				// CHOOSE_ONE, Choose Both option
				PowerTask = new TransformTask("OG_044a", EntityType.SOURCE)
			}));

			// ----------------------------------------- MINION - DRUID
			// [EX1_166] Keeper of the Grove - COST:4 [ATK:2/HP:2]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Deal_2_damage; or <b>Silence</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("EX1_166", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
			}));

			// ----------------------------------------- MINION - DRUID
			// [EX1_178] Ancient of War - COST:7 [ATK:5/HP:5]
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Choose One -</b>
			//       +5 Attack; or +5 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_178", new CardDef(new Power
			{
			}));

			// ----------------------------------------- MINION - DRUID
			// [EX1_573] Cenarius - COST:9 [ATK:5/HP:8]
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Give your other minions +2/+2; or Summon two 2/2 Treants with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_573", new CardDef(new Power
			{
			}));

			// ----------------------------------------- MINION - DRUID
			// [NEW1_008] Ancient of Lore - COST:7 [ATK:5/HP:5]
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Draw a card; or Restore 5 Health.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("NEW1_008", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_154] Wrath - COST:2
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b>
			//       Deal $3 damage to a minion; or $1 damage
			//       and draw a card. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_154", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_155] Mark of Nature - COST:3
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Give a minion +4 Attack; or +4 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_155", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_158] Soul of the Forest - COST:4
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions "<b>Deathrattle:</b> Summon a 2/2 Treant."
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_158", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_158e", EntityType.MINIONS)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_160] Power of the Wild - COST:2
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Give your minions +1/+1; or Summon a 3/2 Panther.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("EX1_160", new CardDef(new Power
			{
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_164] Nourish - COST:5
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Gain 2_Mana Crystals; or Draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("EX1_164", new CardDef(new Power
			{
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_183] Gift of the Wild - COST:8
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions +2/+2 and <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_183", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_183e", EntityType.MINIONS)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_570] Bite - COST:4
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your hero +4_Attack this turn. Gain 4 Armor.
			// --------------------------------------------------------
			cards.Add("EX1_570", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("EX1_570e", EntityType.HERO),
					new ArmorTask(4))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_571] Force of Nature - COST:5
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon three 2/2 Treants.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("EX1_571", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("EX1_158t", 3)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_578] Savagery - COST:1
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal damage equal to your hero's Attack to a minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_578", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.HERO),
					new DamageNumberTask(EntityType.TARGET))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_007] Starfall - COST:5
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b>
			//       Deal $5 damage to a minion; or $2 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("NEW1_007", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_155ae] Mark of Nature (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: This minion has +4 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_155ae", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_155ae")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_155be] Mark of Nature (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: This minion has +4 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_155be", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_155be")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_158e] Soul of the Forest (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Deathrattle: Summon a 2/2 Treant.
			// --------------------------------------------------------
			cards.Add("EX1_158e", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("EX1_158t")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_160be] Leader of the Pack (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_160be", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_160be")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_178ae] Rooted (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +5 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_178ae", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_178ae")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_178be] Uprooted (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +5 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_178be", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_178be")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_183e] Gift of the Wild (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +2/+2 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_183e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_183e")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_573ae] Demigod's Favor (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("EX1_573ae", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_573ae")
			}));

			// ----------------------------------------- MINION - DRUID
			// [EX1_158t] Treant (*) - COST:2 [ATK:2/HP:2]
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			cards.Add("EX1_158t", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [EX1_160t] Panther (*) - COST:2 [ATK:3/HP:2]
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_160t", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [EX1_165t1] Druid of the Claw (*) - COST:5 [ATK:4/HP:4]
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_165t1", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [EX1_165t2] Druid of the Claw (*) - COST:5 [ATK:4/HP:6]
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_165t2", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [EX1_573t] Treant (*) - COST:2 [ATK:2/HP:2]
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_573t", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [EX1_tk9] Treant (*) - COST:2 [ATK:2/HP:2]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_tk9", new CardDef());

			// ----------------------------------------- MINION - DRUID
			// [OG_044a] Druid of the Claw (*) - COST:5 [ATK:4/HP:6]
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("OG_044a", new CardDef());

			// ------------------------------------------ SPELL - DRUID
			// [EX1_154a] Wrath (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: Deal $3 damage to a minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_154a", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DamageTask(3, EntityType.TARGET, true)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_154b] Wrath (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: Deal $1 damage to a minion. Draw a card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_154b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(1, EntityType.TARGET, true),
					new DrawTask())
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_155a] Mark of Nature (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: +4 Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_155a", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_155ae", EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_155b] Mark of Nature (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: +4 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_155b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_155be", EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_160a] Summon a Panther (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: Summon a 3/2 Panther.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("EX1_160a", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new SummonTask("EX1_160t", SummonSide.SPELL)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_160b] Leader of the Pack (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: Give your minions +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_160b", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_160be", EntityType.MINIONS)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_164a] Nourish (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: Gain 2 Mana Crystals.
			// --------------------------------------------------------
			cards.Add("EX1_164a", new CardDef(new Power
			{
				PowerTask = new ManaCrystalFullTask(2)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_164b] Nourish (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			// --------------------------------------------------------
			cards.Add("EX1_164b", new CardDef(new Power
			{
				PowerTask = new DrawTask(count: 3)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_165a] Cat Form (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			cards.Add("EX1_165a", new CardDef(new Power
			{
				PowerTask = new TransformTask("EX1_165t1", EntityType.SOURCE)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_165b] Bear Form (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_165b", new CardDef(new Power
			{
				PowerTask = new TransformTask("EX1_165t2", EntityType.SOURCE)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_166a] Moonfire (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: Deal 2 damage.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_166a", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_166b] Dispel (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: <b>Silence</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_166b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new SilenceTask(EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_178a] Rooted (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: +5 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_178a", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_178ae", EntityType.SOURCE)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_178b] Uproot (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: +5 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_178b", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_178be", EntityType.SOURCE)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_573a] Demigod's Favor (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: Give your other minions +2/+2.
			// --------------------------------------------------------
			cards.Add("EX1_573a", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_573ae", EntityType.MINIONS_NOSOURCE)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [EX1_573b] Shan'do's Lesson (*) - COST:0
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// Text: Summon two 2/2 Treants with <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_573b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,2}}, new Power
			{
				PowerTask = new EnqueueTask(2, new SummonTask("EX1_573t", SummonSide.SPELL))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_007a] Starfall (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Deal $2 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("NEW1_007a", new CardDef(new Power
			{
				PowerTask = new DamageTask(2, EntityType.OP_MINIONS)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_007b] Starfall (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Deal $5 damage to a minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("NEW1_007b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new DamageTask(5, EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_008a] Ancient Teachings (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Draw a card.
			// --------------------------------------------------------
			cards.Add("NEW1_008a", new CardDef(new Power
			{
				PowerTask = new DrawTask()
			}));

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_008b] Ancient Secrets (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Restore 5 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("NEW1_008b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new HealTask(5, EntityType.TARGET),
			}));

		}

		private static void Hunter(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [EX1_531] Scavenging Hyena - COST:2 [ATK:2/HP:2]
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever a friendly Beast dies, gain +2/+1.
			// --------------------------------------------------------
			cards.Add("EX1_531", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsRace(Race.BEAST),
					SingleTask = new AddEnchantmentTask("EX1_531e", EntityType.SOURCE)
				}
			}));

			// ---------------------------------------- MINION - HUNTER
			// [EX1_534] Savannah Highmane - COST:6 [ATK:6/HP:5]
			// - Race: beast, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 2/2 Hyenas.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_534", new CardDef(new Power
			{
				DeathrattleTask = new EnqueueTask(2, new SummonTask("EX1_534t", SummonSide.DEATHRATTLE))
			}));

			// ---------------------------------------- MINION - HUNTER
			// [EX1_543] King Krush - COST:9 [ATK:8/HP:8]
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_543", new CardDef());

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_533] Misdirection - COST:2
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy attacks your hero, instead it attacks another random character.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_533", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					Condition = SelfCondition.IsProposedDefender(CardType.HERO),
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.ALL, new[] { EntityType.TARGET, EntityType.HERO }),
						new FilterStackTask(SelfCondition.IsNotDead, SelfCondition.IsNotImmune),
						new ConditionTask(EntityType.STACK, SelfCondition.IsInZone(Zone.PLAY)),
						new FlagTask(true, new ConditionTask(EntityType.TARGET, SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotDead)),
						new FlagTask(true, ComplexTask.Secret(
							new RandomTask(1, EntityType.STACK),
							new ChangeAttackingTargetTask(EntityType.TARGET, EntityType.STACK))))
				}
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_537] Explosive Shot - COST:5
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage to a minion and $2 damage to adjacent ones. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_537", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(5, EntityType.TARGET, true),
					new IncludeAdjacentTask(EntityType.TARGET),
					new DamageTask(2, EntityType.STACK, true))
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_538] Unleash the Hounds - COST:3
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: For each enemy minion, summon a 1/1 Hound with <b>Charge</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_538", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new CountTask(EntityType.OP_MINIONS),
					new EnqueueNumberTask(new SummonTask("EX1_538t", SummonSide.SPELL))),
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_544] Flare - COST:2
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: All minions lose <b>Stealth</b>. Destroy all enemy <b>Secrets</b>. Draw a card.
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_544", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RevealStealthTask(EntityType.ALLMINIONS),
					new MoveToGraveYard(EntityType.OP_SECRETS),
					new DrawTask())
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_549] Bestial Wrath - COST:1
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a friendly Beast +2 Attack and <b>Immune</b> this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_TARGET_WITH_RACE = 20
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("EX1_549", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_TARGET_WITH_RACE,20},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_549o", EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_554] Snake Trap - COST:2
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions is attacked, summon three 1/1 Snakes.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_554", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					Condition = SelfCondition.IsProposedDefender(CardType.MINION),
					SingleTask = ComplexTask.Secret(new SummonTask("EX1_554t", 3))
				}
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_609] Snipe - COST:2
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, deal $4 damage to it. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_609", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.EVENT_SOURCE, SelfCondition.IsNotDead, SelfCondition.IsNotUntouchable),
						new FlagTask(true, ComplexTask.Secret(
							new DamageTask(4, EntityType.TARGET, true))))
				}
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_610] Explosive Trap - COST:2
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your hero is attacked, deal $2 damage to all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_610", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					Condition = SelfCondition.IsProposedDefender(CardType.HERO),
					SingleTask = ComplexTask.Secret(new DamageTask(2, EntityType.ENEMIES, true))
				}
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_611] Freezing Trap - COST:2
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy minion attacks, return it to its owner's hand. It costs (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_611", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					TriggerSource = TriggerSource.OP_MINIONS,
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.TARGET, SelfCondition.IsNotDead),
						new FlagTask(true, ComplexTask.Secret(
							new ReturnHandTask(EntityType.TARGET),
							new AddAuraEffect(Effects.AddCost(2), EntityType.TARGET))))
				}
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_617] Deadly Shot - COST:3
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a random enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("EX1_617", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				PowerTask = ComplexTask.DestroyRandomTargets(1, EntityType.OP_MINIONS)
			}));

			// ---------------------------------------- WEAPON - HUNTER
			// [DS1_188] Gladiator's Longbow - COST:7 [ATK:5/HP:0]
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your hero is <b>Immune</b> while attacking.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("DS1_188", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TARGET)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = new AddEnchantmentTask("DS1_188e", EntityType.HERO)
				}
			}));

			// ---------------------------------------- WEAPON - HUNTER
			// [EX1_536] Eaglehorn Bow - COST:3 [ATK:3/HP:0]
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Whenever a friendly
			//       <b>Secret</b> is revealed,
			//       gain +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_536", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.SECRET_REVEALED)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("EX1_536e", EntityType.WEAPON)
				}
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [DS1_188e] Gladiator's Longbow enchantment (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			cards.Add("DS1_188e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.Immune),
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = RemoveEnchantmentTask.Task
				}
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [EX1_531e] Well Fed (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Attack and Health.
			// --------------------------------------------------------
			cards.Add("EX1_531e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(2), Effects.Health_N(1))
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [EX1_536e] Upgraded (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Durability.
			// --------------------------------------------------------
			cards.Add("EX1_536e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(new Effect(GameTag.DURABILITY, EffectOperator.ADD, 1))
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [EX1_549o] Bestial Wrath (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +2 Attack and <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_549o", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_549o"),
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [EX1_611e] Trapped (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Will be <b>Frozen</b> again at the start of the next turn.
			// --------------------------------------------------------
			cards.Add("EX1_611e", new CardDef(new Power
			{
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [EX1_534t] Hyena (*) - COST:2 [ATK:2/HP:2]
			// - Race: beast, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			cards.Add("EX1_534t", new CardDef());

			// ---------------------------------------- MINION - HUNTER
			// [EX1_538t] Hound (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: expert1,
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_538t", new CardDef());

			// ---------------------------------------- MINION - HUNTER
			// [EX1_554t] Snake (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_554t", new CardDef());

		}

		private static void Mage(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [EX1_274] Ethereal Arcanist - COST:4 [ATK:3/HP:3]
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: If you control a <b>Secret</b> at_the end of your turn, gain +2/+2.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_274", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					Condition = SelfCondition.IsControllingSecret,
					SingleTask = new AddEnchantmentTask("EX1_274e", EntityType.SOURCE)
				}
			}));

			// ------------------------------------------ MINION - MAGE
			// [EX1_559] Archmage Antonidas - COST:7 [ATK:5/HP:7]
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, add a 'Fireball' spell to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_559", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddCardTo("CS2_029", EntityType.HAND)
				}
			}));

			// ------------------------------------------ MINION - MAGE
			// [EX1_608] Sorcerer's Apprentice - COST:2 [ATK:3/HP:2]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Your spells cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_608", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HAND, Effects.ReduceCost(1))
				{
					Condition = SelfCondition.IsSpell
				}
			}));

			// ------------------------------------------ MINION - MAGE
			// [EX1_612] Kirin Tor Mage - COST:3 [ATK:4/HP:3]
			// - Fac: neutral, Set: expert1, Rarity: rare
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
			cards.Add("EX1_612", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_612o", EntityType.CONTROLLER)
			}));

			// ------------------------------------------ MINION - MAGE
			// [NEW1_012] Mana Wyrm - COST:1 [ATK:1/HP:3]
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("NEW1_012", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("NEW1_012o", EntityType.SOURCE)
				}
			}));

			// ------------------------------------------- SPELL - MAGE
			// [CS2_028] Blizzard - COST:6
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to all enemy minions and <b>Freeze</b> them. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CS2_028", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(2, EntityType.OP_MINIONS, true),
					ComplexTask.Freeze(EntityType.OP_MINIONS))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [EX1_179] Icicle - COST:2
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If it's <b>Frozen</b>, draw a card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("EX1_179", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(2, EntityType.TARGET, true),
					new ConditionTask(EntityType.TARGET, SelfCondition.IsFrozen),
					new FlagTask(true, new DrawTask()))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [EX1_180] Tome of Intellect - COST:1
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Add a random Mage spell to your hand.
			// --------------------------------------------------------
			cards.Add("EX1_180", new CardDef(new Power
			{
				PowerTask = ComplexTask.AddRandomMageSpellToHand
			}));

			// ------------------------------------------- SPELL - MAGE
			// [EX1_275] Cone of Cold - COST:4
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion and the minions next to it, and deal $1 damage to them. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_275", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeAdjacentTask(EntityType.TARGET, true),
					ComplexTask.Freeze(EntityType.STACK),
					new DamageTask(1, EntityType.STACK, true))
			}));

			// ------------------------------------------- SPELL - MAGE
			// [EX1_279] Pyroblast - COST:10
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $10 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_279", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(10, EntityType.TARGET, true)
			}));

			// ------------------------------------------- SPELL - MAGE
			// [EX1_287] Counterspell - COST:3
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent casts a spell, <b>Counter</b> it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			// RefTag:
			// - COUNTER = 1
			// --------------------------------------------------------
			cards.Add("EX1_287", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					SingleTask = ComplexTask.Secret(
						new SetGameTagTask(GameTag.CANT_PLAY, 1, EntityType.TARGET),
						new FuncNumberTask((IPlayable p) =>
						{
							Trigger.InvalidateAll(p.Game);
							return 0;
						})),
					FastExecution = true,
				}
			}));

			// ------------------------------------------- SPELL - MAGE
			// [EX1_289] Ice Barrier - COST:3
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your
			//       hero is attacked,
			//       gain 8 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_289", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					Condition = SelfCondition.IsProposedDefender(CardType.HERO),
					SingleTask = ComplexTask.Secret(new ArmorTask(8))
				}
			}));

			// ------------------------------------------- SPELL - MAGE
			// [EX1_294] Mirror Entity - COST:3
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, summon a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_294", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.EVENT_SOURCE, SelfCondition.IsNotDead, SelfCondition.IsNotUntouchable),
						new FlagTask(true, ComplexTask.Secret(
							new SummonCopyTask(EntityType.EVENT_SOURCE))))
				}
			}));

			// ------------------------------------------- SPELL - MAGE
			// [EX1_594] Vaporize - COST:3
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a minion attacks your hero, destroy it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_594", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					TriggerSource = TriggerSource.OP_MINIONS,
					Condition = SelfCondition.IsProposedDefender(CardType.HERO),
					FastExecution = true,
					SingleTask = ComplexTask.Secret(new DestroyTask(EntityType.TARGET))
				}
			}));

			// ------------------------------------------- SPELL - MAGE
			// [tt_010] Spellbender - COST:3
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy casts a spell on a minion, summon a 1/3 as the new target.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("tt_010", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TARGET)
				{
					Condition = SelfCondition.IsSpellTargetingMinion,
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsNotBoardFull, SelfCondition.IsTagValue(GameTag.CANT_PLAY, 0)),
						new FlagTask(true, ComplexTask.Secret(
							new SummonTask("tt_010a", SummonSide.DEFAULT, true),
							new IncludeTask(EntityType.SOURCE, null, true),
							new IncludeTask(EntityType.TARGET, null, true),
							new FuncPlayablesTask(p =>
							{
								p[2].CardTarget = p[0].Id;
								return p;
							}))))
				}
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [EX1_274e] Raw Power! (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_274e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(2))
			}));

			// ------------------------------------- ENCHANTMENT - MAGE
			// [EX1_612o] Power of the Kirin Tor (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Your next Secret costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_612o", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HAND, Effects.SetCost(0))
				{
					Condition = SelfCondition.IsSecret,
					RemoveTrigger = (TriggerType.CAST_SPELL, SelfCondition.IsSecret)
				}
			}));

			// ------------------------------------- ENCHANTMENT - MAGE
			// [NEW1_012o] Mana Gorged (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased attack.
			// --------------------------------------------------------
			cards.Add("NEW1_012o", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			}));

			// ------------------------------------------ MINION - MAGE
			// [tt_010a] Spellbender (*) - COST:1 [ATK:1/HP:3]
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			cards.Add("tt_010a", new CardDef());

		}

		private static void Paladin(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [EX1_362] Argent Protector - COST:2 [ATK:2/HP:2]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_362", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_NONSELF_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.DivineShield(EntityType.TARGET)
			}));

			// --------------------------------------- MINION - PALADIN
			// [EX1_382] Aldor Peacekeeper - COST:3 [ATK:3/HP:3]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Change an_enemy minion's Attack to 1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_382", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_382e", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - PALADIN
			// [EX1_383] Tirion Fordring - COST:8 [ATK:6/HP:6]
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b><b>Divine Shield</b>,</b> <b>Taunt</b> <b>Deathrattle:</b> Equip a 5/3_Ashbringer.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_383", new CardDef(new Power
			{
				DeathrattleTask = new WeaponTask("EX1_383t")
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_130] Noble Sacrifice - COST:1
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy attacks, summon a 2/1 Defender as the new target.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_130", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					TriggerSource = TriggerSource.ENEMY,
					SingleTask = ComplexTask.Secret(
						new SummonTask("EX1_130a", SummonSide.SPELL, true),
						new ChangeAttackingTargetTask(EntityType.TARGET, EntityType.STACK))
				}
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_132] Eye for an Eye - COST:1
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your hero takes damage, deal_that much damage to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_132", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.HERO,
					SingleTask = ComplexTask.Secret(
						new GetEventNumberTask(),
						new DamageNumberTask(EntityType.OP_HERO, true))
				}
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_136] Redemption - COST:1
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a friendly minion dies, return it to life with 1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_136", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = ComplexTask.Secret(
						new CopyTask(EntityType.TARGET, Zone.PLAY, addToStack: true),
						new FuncPlayablesTask(list =>
						{
							var target = list[0] as ICharacter;
							if (target == null)
								return list;
							target.Damage = target.Health - 1;
							target.IsIgnoreDamage = false;
							return list;
						})),
					RemoveAfterTriggered = true,
				}
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_184] Righteousness - COST:5
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your minions <b>Divine Shield</b>.
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_184", new CardDef(new Power
			{
				PowerTask = ComplexTask.DivineShield(EntityType.MINIONS)
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_354] Lay on Hands - COST:8
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Restore #8 Health. Draw_3 cards.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_354", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new HealTask(8, EntityType.TARGET),
					new DrawTask(count: 3))
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_355] Blessed Champion - COST:5
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Double a minion's Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_355", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_355e", EntityType.TARGET)
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_363] Blessing of Wisdom - COST:1
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Choose a minion. Whenever it attacks, draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_363", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_363e", EntityType.TARGET)
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_365] Holy Wrath - COST:5
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw a card and deal_damage equal to_its Cost. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_365", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DrawTask(true),
					new GetGameTagTask(GameTag.COST, EntityType.STACK),
					new DamageNumberTask(EntityType.TARGET, true))
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_379] Repentance - COST:1
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, reduce its Health to 1.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_379", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.EVENT_SOURCE, SelfCondition.IsNotDead, SelfCondition.IsNotUntouchable),
						new FlagTask(true, ComplexTask.Secret(
							new AddEnchantmentTask("EX1_379e", EntityType.EVENT_SOURCE))))
				}
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_384] Avenging Wrath - COST:6
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $8 damage randomly split among all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("EX1_384", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(8, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1), true)
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_619] Equality - COST:2
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Change the Health of ALL minions to 1.
			// --------------------------------------------------------
			cards.Add("EX1_619", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_619e", EntityType.ALLMINIONS)
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [EX1_366] Sword of Justice - COST:3 [ATK:1/HP:0]
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: After you summon a minion, give it +1/+1 and this loses 1_Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 5
			// --------------------------------------------------------
			cards.Add("EX1_366", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_SUMMON)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = ComplexTask.Create(
						new AddEnchantmentTask("EX1_366e", EntityType.TARGET),
						new DamageWeaponTask(false))
				}
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_355e] Blessed Champion (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: This minion's Attack has been doubled.
			// --------------------------------------------------------
			cards.Add("EX1_355e", new CardDef(new Power
			{
				Enchant = new Enchant(ATK.Effect(EffectOperator.MUL, 2))
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_363e] Blessing of Wisdom (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: When this minion attacks, the player who blessed it draws a card.
			// --------------------------------------------------------
			cards.Add("EX1_363e", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.ATTACK)
				{
					TriggerSource = TriggerSource.ENCHANTMENT_TARGET,
					SingleTask = new DrawTask()
				}
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_363e2] Blessing of Wisdom (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: When this minion attacks, the enemy player draws a card.
			// --------------------------------------------------------
			cards.Add("EX1_363e2", new CardDef());

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_366e] Justice Served (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Has +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_366e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_366e")
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_379e] Repentance (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Health reduced to 1.
			// --------------------------------------------------------
			cards.Add("EX1_379e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetMaxHealth(1))
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_382e] Stand Down! (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Attack changed to 1.
			// --------------------------------------------------------
			cards.Add("EX1_382e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetAttack(1))
			}));

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_619e] Equality (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Health changed to 1.
			// --------------------------------------------------------
			cards.Add("EX1_619e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetMaxHealth(1))
			}));

			// --------------------------------------- MINION - PALADIN
			// [EX1_130a] Defender (*) - COST:1 [ATK:2/HP:1]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_130a", new CardDef());

			// --------------------------------------- WEAPON - PALADIN
			// [EX1_383t] Ashbringer (*) - COST:5 [ATK:5/HP:0]
			// - Set: expert1,
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("EX1_383t", new CardDef());

		}

		private static void Priest(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [EX1_091] Cabal Shadow Priest - COST:6 [ATK:4/HP:5]
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Take control of an enemy minion that has 2 or less Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_MAX_ATTACK = 2
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_091", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_TARGET_MAX_ATTACK,2},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				PowerTask = new ControlTask(EntityType.TARGET)
			}));

			// ---------------------------------------- MINION - PRIEST
			// [EX1_335] Lightspawn - COST:4 [ATK:0/HP:5]
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: This minion's Attack is always equal to its Health.
			// --------------------------------------------------------
			cards.Add("EX1_335", new CardDef(new Power
			{
				Aura = new AdaptiveEffect(GameTag.ATK, EffectOperator.SET, p => ((Minion)p).Health)
			}));

			// ---------------------------------------- MINION - PRIEST
			// [EX1_341] Lightwell - COST:2 [ATK:0/HP:5]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, restore 3 Health to a damaged friendly character.
			// --------------------------------------------------------
			cards.Add("EX1_341", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.FRIENDS),
						new FilterStackTask(SelfCondition.IsDamaged),
						new RandomTask(1, EntityType.STACK),
						new HealTask(3, EntityType.STACK))
				}
			}));

			// ---------------------------------------- MINION - PRIEST
			// [EX1_350] Prophet Velen - COST:7 [ATK:7/HP:7]
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Double the damage and healing of your spells and Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_350", new CardDef(new Power
			{
				Aura = new Aura(AuraType.CONTROLLER,
					new Effect(GameTag.SPELLPOWER_DOUBLE, EffectOperator.ADD, 1))
			}));

			// ---------------------------------------- MINION - PRIEST
			// [EX1_591] Auchenai Soulpriest - COST:4 [ATK:3/HP:5]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Your cards and powers that restore Health now deal damage instead.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_591", new CardDef(new Power
			{
				Aura = new Aura(AuraType.CONTROLLER, new Effect(GameTag.HEALING_DOES_DAMAGE, EffectOperator.SET, 1))
			}));

			// ---------------------------------------- MINION - PRIEST
			// [EX1_623] Temple Enforcer - COST:6 [ATK:6/HP:6]
			// - Set: expert1, Rarity: common
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
			cards.Add("EX1_623", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_623e", EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [CS1_129] Inner Fire - COST:1
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Change a minion's Attack to be equal to its Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS1_129", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.HEALTH, EntityType.TARGET),
					new GetGameTagTask(GameTag.DAMAGE, EntityType.TARGET, 0, 1),
					new MathNumberIndexTask(0, 1, MathOperation.SUB),
					new AddEnchantmentTask("CS1_129e", EntityType.TARGET, true))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_332] Silence - COST:0
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Silence</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_332", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new SilenceTask(EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_334] Shadow Madness - COST:4
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Gain control of an enemy minion with 3 or less Attack until end of turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_TARGET_MAX_ATTACK = 3
			// --------------------------------------------------------
			cards.Add("EX1_334", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1},{PlayReq.REQ_TARGET_MAX_ATTACK,3}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ControlTask(EntityType.TARGET),
					new AddEnchantmentTask("EX1_334e", EntityType.TARGET))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_339] Thoughtsteal - COST:3
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Copy 2 cards in your opponent's deck and add them to your hand.
			// --------------------------------------------------------
			cards.Add("EX1_339", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(2, EntityType.OP_DECK),
					new CopyTask(EntityType.STACK, Zone.HAND))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_345] Mindgames - COST:4
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Put a copy of
			//       a random minion from
			//       your opponent's deck into the battlefield.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("EX1_345", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO: When No minions exist
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.OP_DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new CopyTask(EntityType.STACK, Zone.PLAY)),
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_621] Circle of Healing - COST:0
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #4 Health to ALL_minions.
			// --------------------------------------------------------
			cards.Add("EX1_621", new CardDef(new Power
			{
				PowerTask = new HealTask(4, EntityType.ALLMINIONS)
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_624] Holy Fire - COST:6
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage. Restore #5 Health to your hero. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_624", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(5, EntityType.TARGET),
					new HealTask(5, EntityType.HERO))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_625] Shadowform - COST:3
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your Hero Power becomes 'Deal 2 damage'. If already in Shadowform: 3 damage.
			// --------------------------------------------------------
			cards.Add("EX1_625", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsHeroPowerCard("EX1_625t")),
					ComplexTask.True(new ReplaceHeroPower(Cards.FromId("EX1_625t2"))),
					new FlagTask(false, new ConditionTask(EntityType.SOURCE, SelfCondition.IsHeroPowerCard("ICC_830p"))),
					ComplexTask.True(new ReplaceHeroPower(Cards.FromId("EX1_625t2"))),
					ComplexTask.False(new ReplaceHeroPower(Cards.FromId("EX1_625t"))))
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_626] Mass Dispel - COST:4
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Silence</b> all enemy minions. Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("EX1_626", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new SilenceTask(EntityType.OP_MINIONS),
					new DrawTask())
			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CS1_129e] Inner Fire (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: This minion's Attack is equal to its Health.
			// --------------------------------------------------------
			cards.Add("CS1_129e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.SetAttackScriptTag
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [EX1_334e] Shadow Madness (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: This minion has switched controllers this turn.
			// --------------------------------------------------------
			cards.Add("EX1_334e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.Charge, new Effect(GameTag.CONTROLLER_CHANGED_THIS_TURN, EffectOperator.SET, 1)),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					EitherTurn = true,
					SingleTask = ComplexTask.Create(
						RemoveEnchantmentTask.Task,
						new ControlTask(EntityType.TARGET, true))
				}
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [EX1_623e] Infusion (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("EX1_623e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_623e")
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [EX1_tk31] Mind Controlling (*) - COST:0
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// GameTag:
			// - SUMMONED = 1
			// --------------------------------------------------------
			cards.Add("EX1_tk31", new CardDef());

			// ---------------------------------------- MINION - PRIEST
			// [EX1_345t] Shadow of Nothing (*) - COST:0 [ATK:0/HP:1]
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Mindgames whiffed! Your opponent had no minions!
			// --------------------------------------------------------
			cards.Add("EX1_345t", new CardDef());

		}

		private static void Rogue(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [EX1_131] Defias Ringleader - COST:2 [ATK:2/HP:2]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Summon a 2/1 Defias Bandit.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("EX1_131", new CardDef(new Power
			{
				ComboTask = new SummonTask("EX1_131t", SummonSide.RIGHT)
			}));

			// ----------------------------------------- MINION - ROGUE
			// [EX1_134] SI:7 Agent - COST:3 [ATK:3/HP:3]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Deal 2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_FOR_COMBO = 0
			// --------------------------------------------------------
			cards.Add("EX1_134", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_FOR_COMBO,0}}, new Power
			{
				ComboTask = new DamageTask(2, EntityType.TARGET)
			}));

			// ----------------------------------------- MINION - ROGUE
			// [EX1_522] Patient Assassin - COST:2 [ATK:1/HP:1]
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//        <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("EX1_522", new CardDef());

			// ----------------------------------------- MINION - ROGUE
			// [EX1_613] Edwin VanCleef - COST:3 [ATK:2/HP:2]
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Gain +2/+2 for each other card you've played this turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("EX1_613", new CardDef(new Power
			{
				ComboTask = ComplexTask.Create(
					new GetGameTagControllerTask(GameTag.NUM_CARDS_PLAYED_THIS_TURN),
					new MathSubstractionTask(1),
					new MathMultiplyTask(2),
					new AddEnchantmentTask("EX1_613e", EntityType.SOURCE, true))
			}));

			// ----------------------------------------- MINION - ROGUE
			// [NEW1_005] Kidnapper - COST:6 [ATK:5/HP:3]
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Return a minion to_its owner's hand.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_FOR_COMBO = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("NEW1_005", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_FOR_COMBO,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				ComboTask = new ReturnHandTask(EntityType.TARGET)
			}));

			// ----------------------------------------- MINION - ROGUE
			// [NEW1_014] Master of Disguise - COST:4 [ATK:4/HP:4]
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("NEW1_014", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_NONSELF_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("NEW1_014e", EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_073] Cold Blood - COST:1
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2 Attack. <b>Combo:</b> +4 Attack instead.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_073", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("CS2_073e", EntityType.TARGET),
				ComboTask = new AddEnchantmentTask("CS2_073e2", EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_233] Blade Flurry - COST:4
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy your weapon and deal its damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			cards.Add("CS2_233", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_WEAPON_EQUIPPED,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.WEAPON),
					new DamageNumberTask(EntityType.OP_MINIONS, true),
					new DestroyTask(EntityType.WEAPON)),
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_124] Eviscerate - COST:2
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage. <b>Combo:</b> Deal $4 damage instead. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_124", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(2, EntityType.TARGET),
				ComboTask = new DamageTask(4, EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_126] Betrayal - COST:2
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Force an enemy minion to deal its damage to the minions next to it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_126", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				PowerTask = SpecificTask.Betrayal
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_137] Headcrack - COST:3
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to the enemy hero. <b>Combo:</b> Return this to your hand next turn. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("EX1_137", new CardDef(new Power
			{
				PowerTask = new DamageTask(2, EntityType.OP_HERO),
				ComboTask = ComplexTask.Create(
					new DamageTask(2, EntityType.OP_HERO),
					new SetGameTagTask(GameTag.HEADCRACK_COMBO, 1, EntityType.SOURCE)),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsTagValue(GameTag.HEADCRACK_COMBO, 1)),
						new FlagTask(true, ComplexTask.Create(
							new IncludeTask(EntityType.SOURCE),
							new FuncPlayablesTask(p =>
							{
								IPlayable source = p[0];
								source.Zone.Remove(source);
								source[GameTag.HEADCRACK_COMBO] = 0;
								return p;
							}),
							new AddStackTo(EntityType.HAND)))),
					RemoveAfterTriggered = true
				}
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_144] Shadowstep - COST:0
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Return a friendly minion to your hand. It_costs (2) less.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_144", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ReturnHandTask(EntityType.TARGET),
					new AddAuraEffect(Effects.ReduceCost(2), EntityType.TARGET))
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_145] Preparation - COST:0
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (3) less.
			// --------------------------------------------------------
			cards.Add("EX1_145", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_145o", EntityType.CONTROLLER)
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_182] Pilfer - COST:1
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Add a random card to your hand <i>(from your opponent's class)</i>.
			// --------------------------------------------------------
			cards.Add("EX1_182", new CardDef(new Power
			{
				PowerTask = ComplexTask.AddRandomOpClassCardToHand
			}));

			// ----------------------------------------- WEAPON - ROGUE
			// [EX1_133] Perdition's Blade - COST:3 [ATK:2/HP:0]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage. <b>Combo:</b> Deal 2 instead.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_133", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				PowerTask = new DamageTask(1, EntityType.TARGET),
				ComboTask = new DamageTask(2, EntityType.TARGET)
			}));

		}

		private static void RogueNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CS2_073e] Cold Blood (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_073e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CS2_073e")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CS2_073e2] Cold Blood (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +4 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_073e2", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CS2_073e2")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [EX1_145o] Preparation (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_145o", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HAND, Effects.ReduceCost(3))
				{
					Condition = SelfCondition.IsSpell,
					RemoveTrigger = (TriggerType.CAST_SPELL, null)
				}
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [EX1_613e] VanCleef's Vengeance (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_613e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [NEW1_014e] Disguised (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Stealthed until your next turn.
			// --------------------------------------------------------
			cards.Add("NEW1_014e", new CardDef(Power.OneTurnStealthEnchantmentPower));

			// ----------------------------------------- MINION - ROGUE
			// [EX1_131t] Defias Bandit (*) - COST:1 [ATK:2/HP:1]
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			cards.Add("EX1_131t", new CardDef());

		}

		private static void Shaman(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [EX1_243] Dust Devil - COST:1 [ATK:3/HP:1]
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>. <b>Overload:</b> (2)
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			cards.Add("EX1_243", new CardDef());

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_250] Earth Elemental - COST:5 [ATK:7/HP:8]
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b><b>Overload</b>:</b> (3)
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - OVERLOAD = 3
			// - OVERLOAD_OWED = 3
			// --------------------------------------------------------
			cards.Add("EX1_250", new CardDef());

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_258] Unbound Elemental - COST:3 [ATK:2/HP:4]
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you play a card_with <b>Overload</b>, gain_+1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("EX1_258", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.PLAY_CARD)
				{
					Condition = SelfCondition.IsOverloadCard,
					SingleTask = new AddEnchantmentTask("EX1_258e", EntityType.SOURCE)
				}
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_575] Mana Tide Totem - COST:3 [ATK:0/HP:3]
			// - Race: totem, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, draw a card.
			// --------------------------------------------------------
			cards.Add("EX1_575", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new DrawTask()
				}
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [NEW1_010] Al'Akir the Windlord - COST:8 [ATK:3/HP:5]
			// - Race: elemental, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge, Divine Shield, Taunt, Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - WINDFURY = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("NEW1_010", new CardDef());

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_038] Ancestral Spirit - COST:2
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion "<b>Deathrattle:</b> Resummon this minion."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CS2_038", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("CS2_038e", EntityType.TARGET)
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_053] Far Sight - COST:3
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw a card. That card costs (3) less.
			// --------------------------------------------------------
			cards.Add("CS2_053", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DrawTask(true),
					new AddEnchantmentTask("CS2_053e", EntityType.STACK))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_238] Lightning Bolt - COST:1
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage. <b>Overload:</b> (1) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_238", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(3, EntityType.TARGET, true)
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_241] Lava Burst - COST:3
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage. <b>Overload:</b> (2) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_241", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = new DamageTask(5, EntityType.TARGET, true),
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_245] Earth Shock - COST:1
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Silence</b> a minion, then deal $1 damage to it. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_245", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new SilenceTask(EntityType.TARGET),
					new DamageTask(1, EntityType.TARGET, true)),
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_248] Feral Spirit - COST:3
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon two 2/3 Spirit Wolves with <b>Taunt</b>. <b>Overload:</b> (2)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_248", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				PowerTask = new EnqueueTask(2, new SummonTask("EX1_tk11", SummonSide.SPELL))
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_251] Forked Lightning - COST:1
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to 2_random enemy minions. <b>Overload:</b> (2) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("EX1_251", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				PowerTask = ComplexTask.DamageRandomTargets(2, EntityType.OP_MINIONS, 2, true)
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_259] Lightning Storm - COST:3
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2-$3 damage to all_enemy minions. <b>Overload:</b> (2) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			cards.Add("EX1_259", new CardDef(new Power
			{
				PowerTask = new DamageTask(2, 1, EntityType.OP_MINIONS, true)
			}));

			// ---------------------------------------- WEAPON - SHAMAN
			// [EX1_247] Stormforged Axe - COST:2 [ATK:2/HP:0]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			cards.Add("EX1_247", new CardDef());

			// ---------------------------------------- WEAPON - SHAMAN
			// [EX1_567] Doomhammer - COST:5 [ATK:2/HP:0]
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Windfury, Overload:</b> (2)
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 8
			// - WINDFURY = 1
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			cards.Add("EX1_567", new CardDef());

		}

		private static void ShamanNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [CS2_038e] Ancestral Spirit (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Resummon this minion.
			// --------------------------------------------------------
			cards.Add("CS2_038e", new CardDef(new Power
			{
				DeathrattleTask = new CopyTask(EntityType.SOURCE, Zone.PLAY)
			}));

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [CS2_053e] Far Sight (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: One of your cards costs (3) less.
			// --------------------------------------------------------
			cards.Add("CS2_053e", new CardDef(new Power
			{
				Enchant = new Enchant(
					Effects.ReduceCost(3),
					new Effect(GameTag.DISPLAYED_CREATOR, EffectOperator.SET, 1)),
				Trigger = new Trigger(TriggerType.PLAY_CARD)
				{
					TriggerSource = TriggerSource.ENCHANTMENT_TARGET,
					RemoveAfterTriggered = true,
					SingleTask = RemoveEnchantmentTask.Task
				}
			}));

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [EX1_258e] Overloading (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_258e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_tk11] Spirit Wolf (*) - COST:2 [ATK:2/HP:3]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_tk11", new CardDef());

		}

		private static void Warlock(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [CS2_059] Blood Imp - COST:1 [ATK:0/HP:1]
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: [x]  <b>Stealth</b>. At the end of your
			//       turn, give another random
			//        friendly minion +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CS2_059", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new RandomTask(1, EntityType.MINIONS_NOSOURCE),
						new AddEnchantmentTask("CS2_059o", EntityType.STACK))
				}
			}));

			// --------------------------------------- MINION - WARLOCK
			// [EX1_185] Siegebreaker - COST:7 [ATK:5/HP:8]
			// - Race: demon, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Your other Demons have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_185", new CardDef(new Power
			{
				Aura = new Aura(AuraType.BOARD_EXCEPT_SOURCE, "EX1_185e")
				{
					Condition = SelfCondition.IsRace(Race.DEMON)
				}
			}));

			// --------------------------------------- MINION - WARLOCK
			// [EX1_301] Felguard - COST:3 [ATK:3/HP:5]
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Destroy one of your Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_301", new CardDef(new Power
			{
				PowerTask = new ManaCrystalEmptyTask(-1)
			}));

			// --------------------------------------- MINION - WARLOCK
			// [EX1_304] Void Terror - COST:3 [ATK:3/HP:3]
			// - Race: demon, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Destroy both
			//       adjacent minions and gain
			//        their Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_304", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeAdjacentTask(EntityType.SOURCE),
					new GetGameTagTask(GameTag.ATK, EntityType.STACK, 0, 1),
					new GetGameTagTask(GameTag.ATK, EntityType.STACK, 1, 2),
					new MathNumberIndexTask(1, 2, MathOperation.ADD),
					new GetGameTagTask(GameTag.HEALTH, EntityType.STACK, 0, 3),
					new GetGameTagTask(GameTag.HEALTH, EntityType.STACK, 1, 4),
					new MathNumberIndexTask(3, 4, MathOperation.ADD, 1),
					new DestroyTask(EntityType.STACK),
					new AddEnchantmentTask("EX1_304e", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - WARLOCK
			// [EX1_313] Pit Lord - COST:4 [ATK:5/HP:6]
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 5 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_313", new CardDef(new Power
			{
				PowerTask = new DamageTask(5, EntityType.HERO)
			}));

			// --------------------------------------- MINION - WARLOCK
			// [EX1_315] Summoning Portal - COST:4 [ATK:0/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: common
			// ---------------------------------------------c-----------
			// Text: Your minions cost (2) less, but not less than (1).
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// TODO: re-implement Summoning Portal
			cards.Add("EX1_315", new CardDef(new Power
			{
				//Aura = new Aura(AuraType.SUMMONING_PORTAL, "EX1_315e")
				Aura = new SummoningPortalAura()
			}));

			cards.Add("EX1_315e", new CardDef());

			// --------------------------------------- MINION - WARLOCK
			// [EX1_319] Flame Imp - COST:1 [ATK:3/HP:2]
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_319", new CardDef(new Power
			{
				PowerTask = new DamageTask(3, EntityType.HERO)
			}));

			// --------------------------------------- MINION - WARLOCK
			// [EX1_323] Lord Jaraxxus - COST:9 [ATK:3/HP:15]
			// - Race: demon, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your hero and replace it with Lord Jaraxxus.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_323", new CardDef(new Power
			{
				PowerTask = new ReplaceHeroTask("EX1_323h", "EX1_323w", "EX1_tk33")
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_181] Call of the Void - COST:1
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Add a random Demon to your hand.
			// --------------------------------------------------------
			cards.Add("EX1_181", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomCardTask(CardType.MINION, CardClass.INVALID, Race.DEMON),
					new AddStackTo(EntityType.HAND))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_303] Shadowflame - COST:4
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a friendly minion and deal its Attack damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_303", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.TARGET),
					new DestroyTask(EntityType.TARGET),
					new DamageNumberTask(EntityType.OP_MINIONS, true))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_309] Siphon Soul - COST:6
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a minion. Restore #3 Health to_your hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_309", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.TARGET),
					new HealTask(3, EntityType.HERO))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_312] Twisting Nether - COST:8
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all minions.
			// --------------------------------------------------------
			cards.Add("EX1_312", new CardDef(new Power
			{
				PowerTask = new DestroyTask(EntityType.ALLMINIONS)
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_317] Sense Demons - COST:3
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 Demons
			//       from your deck.
			// --------------------------------------------------------
			cards.Add("EX1_317", new CardDef(new Power
			{
				//	TODO
				PowerTask = ComplexTask.Create(
					ComplexTask.DrawFromDeck(1, SelfCondition.IsRace(Race.DEMON)),
					ComplexTask.DrawFromDeck(1, SelfCondition.IsRace(Race.DEMON)))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_320] Bane of Doom - COST:5
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to_a character. If that kills it, summon a random Demon. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_320", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(2, EntityType.TARGET),
					new ConditionTask(EntityType.TARGET, SelfCondition.IsDead),
					new FlagTask(true, ComplexTask.SummonRandomMinion(GameTag.CARDRACE, (int)Race.DEMON)))
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_596] Demonfire - COST:2
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If it’s a friendly Demon, give it +2/+2 instead. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_596", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.TARGET,
						RelaCondition.IsFriendly,
						RelaCondition.IsOther(SelfCondition.IsRace(Race.DEMON))),
					new FlagTask(true, new AddEnchantmentTask("EX1_596e", EntityType.TARGET)),
					new FlagTask(false, new DamageTask(2, EntityType.TARGET)))
			}));

		}

		private static void WarlockNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [CS2_059o] Blood Pact (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("CS2_059o", new CardDef(new Power
			{
				//Enchant = new OngoingEnchant(Effects.Health_N(1))
				Enchant = new Enchant(Effects.Health_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [EX1_185e] Siegebreaking (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Siegebreaker is granting this minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_185e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_185e")
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [EX1_304e] Consume (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_304e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [EX1_596e] Demonfire (*) - COST:0
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: This Demon has +2/+2.
			// --------------------------------------------------------
			cards.Add("EX1_596e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_596e")
			}));

			// --------------------------------------- MINION - WARLOCK
			// [EX1_317t] Worthless Imp (*) - COST:1 [ATK:1/HP:1]
			// - Race: demon, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <i>You are out of demons! At least there are always imps...</i>
			// --------------------------------------------------------
			cards.Add("EX1_317t", new CardDef());

			// --------------------------------------- MINION - WARLOCK
			// [EX1_tk34] Infernal (*) - COST:6 [ATK:6/HP:6]
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_tk34", new CardDef());

			// --------------------------------------- WEAPON - WARLOCK
			// [EX1_323w] Blood Fury (*) - COST:3 [ATK:3/HP:0]
			// - Set: expert1,
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 8
			// --------------------------------------------------------
			cards.Add("EX1_323w", new CardDef());

		}

		private static void Warrior(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [EX1_398] Arathi Weaponsmith - COST:4 [ATK:3/HP:3]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip a 2/2_weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_398", new CardDef(new Power
			{
				PowerTask = new WeaponTask("EX1_398t")
			}));

			// --------------------------------------- MINION - WARRIOR
			// [EX1_402] Armorsmith - COST:2 [ATK:1/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a friendly minion_takes damage, gain 1 Armor.
			// --------------------------------------------------------
			cards.Add("EX1_402", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = new ArmorTask(1)
				}
			}));

			// --------------------------------------- MINION - WARRIOR
			// [EX1_414] Grommash Hellscream - COST:8 [ATK:4/HP:9]
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Enrage:</b> +6 Attack
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_414", new CardDef(new Power
			{
				//Trigger = Triggers.EnrageTrigger("EX1_414e")
				Aura = new EnrageEffect(AuraType.SELF, "EX1_414e")
			}));

			// --------------------------------------- MINION - WARRIOR
			// [EX1_603] Cruel Taskmaster - COST:2 [ATK:2/HP:2]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage to a minion and give it +2_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_603", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NONSELF_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(1, EntityType.TARGET),
					new AddEnchantmentTask("EX1_603e", EntityType.TARGET))
			}));

			// --------------------------------------- MINION - WARRIOR
			// [EX1_604] Frothing Berserker - COST:3 [ATK:2/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a minion takes damage, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_604", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.ALL_MINIONS,
					SingleTask = new AddEnchantmentTask("EX1_604o", EntityType.SOURCE)
				}
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [CS2_104] Rampage - COST:2
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Give a damaged minion +3/+3.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_DAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_104", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_DAMAGED_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("CS2_104e", EntityType.TARGET)
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_391] Slam - COST:2
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If it survives, draw a card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_391", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(2, EntityType.TARGET, true),
					new ConditionTask(EntityType.TARGET, SelfCondition.IsNotDead),
					new FlagTask(true, new DrawTask()))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_392] Battle Rage - COST:2
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Draw a card for each damaged friendly character.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_392", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.FRIENDS),
					new FilterStackTask(SelfCondition.IsDamaged),
					new CountTask(EntityType.STACK),
					new DrawNumberTask())
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_407] Brawl - COST:5
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all minions except one. <i>(chosen randomly)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("EX1_407", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_TOTAL_MINIONS,2}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(1, EntityType.ALLMINIONS),
					new IncludeTask(EntityType.ALLMINIONS, new[] { EntityType.STACK }),
					new DestroyTask(EntityType.STACK))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_408] Mortal Strike - COST:4
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $4 damage. If you have 12 or less Health, deal $6 instead. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_408", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.HERO, SelfCondition.IsHealth(12, RelaSign.LEQ)),
					new FlagTask(true, new DamageTask(6, EntityType.TARGET, true)),
					new FlagTask(false, new DamageTask(4, EntityType.TARGET, true))),
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_409] Upgrade! - COST:1
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: If you have a weapon, give it +1/+1. Otherwise equip a 1/3 weapon.
			// --------------------------------------------------------
			cards.Add("EX1_409", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.HERO, SelfCondition.IsAnyWeaponEquiped),
					new FlagTask(true, new AddEnchantmentTask("EX1_409e", EntityType.WEAPON)),
					new FlagTask(false, new WeaponTask("EX1_409t")))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_410] Shield Slam - COST:1
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal 1 damage to a minion for each Armor you have. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_410", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ARMOR, EntityType.HERO),
					new DamageNumberTask(EntityType.TARGET, true))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_607] Inner Rage - COST:0
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage to a minion and give it +2_Attack. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_607", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DamageTask(1, EntityType.TARGET),
					new AddEnchantmentTask("EX1_607e", EntityType.TARGET))
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [NEW1_036] Commanding Shout - COST:2
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Your minions can't be reduced below 1 Health this turn. Draw a card.
			// --------------------------------------------------------
			cards.Add("NEW1_036", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new AddEnchantmentTask("NEW1_036e2", EntityType.CONTROLLER),
					new DrawTask())
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [EX1_411] Gorehowl - COST:7 [ATK:7/HP:0]
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Attacking a minion costs 1 Attack instead of 1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 1
			// --------------------------------------------------------
			cards.Add("EX1_411", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TARGET)
				{
					TriggerSource = TriggerSource.HERO,
					Condition = SelfCondition.IsProposedDefender(CardType.MINION),
					FastExecution = true,
					SingleTask = new AddEnchantmentTask("EX1_411e", EntityType.SOURCE)
				},

			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CS2_104e] Rampage (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("CS2_104e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CS2_104e")
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_409e] Upgraded (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +1 Attack and +1 Durability.
			// --------------------------------------------------------
			cards.Add("EX1_409e", new CardDef(new Power
			{
				Enchant = new Enchant(
					new Effect(GameTag.ATK, EffectOperator.ADD, 1),
					new Effect(GameTag.DURABILITY, EffectOperator.ADD, 1))
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_411e] Bloodrage (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: No durability loss.
			// --------------------------------------------------------
			cards.Add("EX1_411e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.Immune),
				Trigger = new Trigger(TriggerType.AFTER_ATTACK)
				{
					TriggerSource = TriggerSource.HERO,
					FastExecution = true,
					SingleTask = ComplexTask.Create(
						RemoveEnchantmentTask.Task,
						new AddEnchantmentTask("EX1_411e2", EntityType.WEAPON))
				}
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_411e2] Needs Sharpening (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Decreased Attack.
			// --------------------------------------------------------
			cards.Add("EX1_411e2", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(new Effect(GameTag.ATK, EffectOperator.SUB, 1))
				//Enchant = new OngoingEnchant(ATK.Effect(EffectOperator.SUB, 1))
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_414e] Enraged (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +6 Attack
			// --------------------------------------------------------
			cards.Add("EX1_414e", new CardDef(new Power
			{
				//Aura = new EnrageEffect(AuraType.SELF, Effects.Attack_N(6))
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_414e")
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_603e] Whipped Into Shape (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_603e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_603e")
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_604o] Berserk (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("EX1_604o", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_607e] Inner Rage (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_607e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_607e")
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [NEW1_036e] Commanding Shout (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Can't be reduced below 1 Health this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("NEW1_036e", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.HEALTH_MINIMUM, EffectOperator.SET, 1)
				{
					IsOneTurnEffect = true,
				},
				// Actual Commaning Shout does not use trigger.
				// Trigger implementation is introduced for performance;
				// otherwise Sabber have to check Character[GameTag.HEALTH_MINIMUM]
				// everytime when the character is damaged.
				Trigger = new Trigger(TriggerType.PREDAMAGE)
				{
					TriggerSource = TriggerSource.ENCHANTMENT_TARGET,
					FastExecution = true,
					SingleTask = ComplexTask.Create(
						new IncludeTask(EntityType.TARGET),
						new FuncPlayablesTask(p =>
						{
							var m = (Minion)p[0];
							if (m.Game.CurrentEventData.EventNumber >= m.Health)
								m.Game.CurrentEventData.EventNumber = m.Health - 1;
							return p;
						}))
				}
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [NEW1_036e2] Commanding Shout (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Your minions can't be reduced below 1 Health this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("NEW1_036e2", new CardDef(new Power
			{
				Aura = new Aura(AuraType.BOARD, "NEW1_036e"),
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [EX1_398t] Battle Axe (*) - COST:1 [ATK:2/HP:0]
			// - Set: expert1,
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("EX1_398t", new CardDef());

			// --------------------------------------- WEAPON - WARRIOR
			// [EX1_409t] Heavy Axe (*) - COST:1 [ATK:1/HP:0]
			// - Set: expert1,
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("EX1_409t", new CardDef());

		}

		private static void DreamNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - DREAM
			// [DREAM_01] Laughing Sister (*) - COST:3 [ATK:3/HP:5]
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("DREAM_01", new CardDef());

			// ----------------------------------------- MINION - DREAM
			// [DREAM_03] Emerald Drake (*) - COST:4 [ATK:7/HP:6]
			// - Race: dragon, Set: expert1,
			// --------------------------------------------------------
			cards.Add("DREAM_03", new CardDef());

			// ------------------------------------------ SPELL - DREAM
			// [DREAM_02] Ysera Awakens (*) - COST:2
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Deal $5 damage to all characters except Ysera. @spelldmg
			// --------------------------------------------------------
			cards.Add("DREAM_02", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALL),
					new FilterStackTask(new SelfCondition(p => p.Card.Name != "Ysera")),
					new DamageTask(5, EntityType.STACK, true))
			}));

			// ------------------------------------------ SPELL - DREAM
			// [DREAM_04] Dream (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Return a minion to its owner's hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DREAM_04", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new ReturnHandTask(EntityType.TARGET)
			}));

			// ------------------------------------------ SPELL - DREAM
			// [DREAM_05] Nightmare (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Give a minion +5/+5. At the start of your next turn, destroy it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DREAM_05", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("DREAM_05e", EntityType.TARGET)
			}));

		}

		private static void Neutral(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [CS1_069] Fen Creeper - COST:5 [ATK:3/HP:6]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS1_069", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_117] Earthen Ring Farseer - COST:3 [ATK:3/HP:3]
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 3_Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CS2_117", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				PowerTask = new HealTask(3, EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_146] Southsea Deckhand - COST:1 [ATK:2/HP:1]
			// - Race: pirate, Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Has <b>Charge</b> while you have a weapon equipped.
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CS2_146", new CardDef(new Power
			{
				Aura = new AdaptiveEffect(SelfCondition.IsWeaponEquiped, GameTag.CHARGE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_151] Silver Hand Knight - COST:5 [ATK:4/HP:4]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/2_Squire.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_151", new CardDef(new Power
			{
				PowerTask = new SummonTask("CS2_152", SummonSide.RIGHT)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_161] Ravenholdt Assassin - COST:7 [ATK:7/HP:5]
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CS2_161", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_169] Young Dragonhawk - COST:1 [ATK:1/HP:1]
			// - Race: beast, Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("CS2_169", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_181] Injured Blademaster - COST:3 [ATK:4/HP:7]
			// - Fac: horde, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 4 damage to HIMSELF.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_181", new CardDef(new Power
			{
				PowerTask = new DamageTask(4, EntityType.SOURCE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_188] Abusive Sergeant - COST:1 [ATK:1/HP:1]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a minion +2_Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_188", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("CS2_188o", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_203] Ironbeak Owl - COST:3 [ATK:2/HP:1]
			// - Race: beast, Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b> a_minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("CS2_203", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new SilenceTask(EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_221] Spiteful Smith - COST:5 [ATK:4/HP:6]
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Enrage:</b> Your weapon has +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("CS2_221", new CardDef(new Power
			{
				//Trigger = Triggers.EnrageTrigger("CS2_221e")
				Aura = new EnrageEffect(AuraType.WEAPON, "CS2_221e")
			}));

			// --------------------------------------- MINION - NEUTRALa
			// [CS2_227] Venture Co. Mercenary - COST:5 [ATK:7/HP:6]
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Your minions cost (3) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("CS2_227", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HAND, Effects.AddCost(3))
				{
					Condition = SelfCondition.IsMinion
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_231] Wisp - COST:0 [ATK:1/HP:1]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("CS2_231", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_001] Lightwarden - COST:1 [ATK:1/HP:2]
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a character is healed, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_001", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.HEAL)
				{
					SingleTask = new AddEnchantmentTask("EX1_001e", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_002] The Black Knight - COST:6 [ATK:4/HP:5]
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy an enemy minion with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_MUST_TARGET_TAUNTER = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_002", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_MUST_TARGET_TAUNTER,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				PowerTask = new DestroyTask(EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_004] Young Priestess - COST:1 [ATK:2/HP:1]
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, give another random friendly minion +1 Health.
			// --------------------------------------------------------
			cards.Add("EX1_004", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new RandomTask(1, EntityType.MINIONS_NOSOURCE),
						new AddEnchantmentTask("EX1_004e", EntityType.STACK))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_005] Big Game Hunter - COST:5 [ATK:4/HP:2]
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a minion with 7 or more Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_MIN_ATTACK = 7
			// --------------------------------------------------------
			cards.Add("EX1_005", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_MIN_ATTACK,7}}, new Power
			{
				PowerTask = new DestroyTask(EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_006] Alarm-o-Bot - COST:3 [ATK:0/HP:3]
			// - Race: mechanical, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]At the start of your turn,
			//       swap this minion with a
			//          random one in your hand.
			// --------------------------------------------------------
			cards.Add("EX1_006", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					Condition = SelfCondition.HasMinionInHand,
					SingleTask = ComplexTask.Create(
						new GetGameTagTask(GameTag.ZONE_POSITION, EntityType.SOURCE),
						new MoveToSetaside(EntityType.SOURCE),
						new IncludeTask(EntityType.HAND),
						new FilterStackTask(SelfCondition.IsMinion),
						new RandomTask(1, EntityType.STACK),
						new RemoveFromHand(EntityType.STACK),
						new SummonTask(SummonSide.NUMBER),
						new ReturnHandTask(EntityType.SOURCE))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_007] Acolyte of Pain - COST:3 [ATK:1/HP:3]
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, draw a_card.
			// --------------------------------------------------------
			cards.Add("EX1_007", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TAKE_DAMAGE)
				{
					TriggerSource = TriggerSource.SELF,
					SingleTask = new DrawTask()
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_008] Argent Squire - COST:1 [ATK:1/HP:1]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_008", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_009] Angry Chicken - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Enrage:</b> +5 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_009", new CardDef(new Power
			{
				//Trigger = Triggers.EnrageTrigger("EX1_009e")
				Aura = new EnrageEffect(AuraType.SELF, "EX1_009e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_010] Worgen Infiltrator - COST:1 [ATK:2/HP:1]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("EX1_010", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_012] Bloodmage Thalnos - COST:2 [ATK:1/HP:1]
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			//       <b>Deathrattle:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - SPELLPOWER = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_012", new CardDef(new Power
			{
				DeathrattleTask = new DrawTask()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_014] King Mukla - COST:3 [ATK:5/HP:5]
			// - Race: beast, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your opponent 2 Bananas.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_014", new CardDef(new Power
			{
				PowerTask = new AddCardTo("EX1_014t", EntityType.OP_HAND, 2)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_017] Jungle Panther - COST:3 [ATK:4/HP:2]
			// - Race: beast, Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("EX1_017", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_020] Scarlet Crusader - COST:3 [ATK:3/HP:1]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_020", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_021] Thrallmar Farseer - COST:3 [ATK:2/HP:3]
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("EX1_021", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_023] Silvermoon Guardian - COST:4 [ATK:3/HP:3]
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_023", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_028] Stranglethorn Tiger - COST:5 [ATK:5/HP:5]
			// - Race: beast, Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("EX1_028", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_029] Leper Gnome - COST:1 [ATK:1/HP:1]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 2 damage to the enemy_hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_029", new CardDef(new Power
			{
				DeathrattleTask = new DamageTask(2, EntityType.OP_HERO)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_032] Sunwalker - COST:6 [ATK:4/HP:5]
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_032", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_033] Windfury Harpy - COST:6 [ATK:4/HP:5]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("EX1_033", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_043] Twilight Drake - COST:4 [ATK:4/HP:1]
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1 Health for each card in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_043", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new CountTask(EntityType.HAND),
					new AddEnchantmentTask("EX1_043e", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_044] Questing Adventurer - COST:3 [ATK:2/HP:2]
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you play a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_044", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.PLAY_CARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("EX1_044e", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_045] Ancient Watcher - COST:2 [ATK:4/HP:5]
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Can't attack.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("EX1_045", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_046] Dark Iron Dwarf - COST:4 [ATK:4/HP:4]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a minion +2_Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_046", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_046e", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_048] Spellbreaker - COST:4 [ATK:4/HP:3]
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b> a_minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("EX1_048", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NONSELF_TARGET,0}}, new Power
			{
				PowerTask = new SilenceTask(EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_049] Youthful Brewmaster - COST:2 [ATK:3/HP:2]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return a friendly minion from the battlefield to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_049", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_NONSELF_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				PowerTask = new ReturnHandTask(EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_055] Mana Addict - COST:2 [ATK:1/HP:3]
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain +2 Attack this turn.
			// --------------------------------------------------------
			cards.Add("EX1_055", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("EX1_055o", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_057] Ancient Brewmaster - COST:4 [ATK:5/HP:4]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return a friendly minion from the battlefield to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_057", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_NONSELF_TARGET,0}}, new Power
			{
				PowerTask = new ReturnHandTask(EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_058] Sunfury Protector - COST:2 [ATK:2/HP:3]
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give adjacent minions <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_058", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeAdjacentTask(EntityType.SOURCE),
					ComplexTask.Taunt(EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_059] Crazed Alchemist - COST:2 [ATK:2/HP:2]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Swap the Attack and Health of a minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_059", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				PowerTask = new SwapAttackHealthTask(EntityType.TARGET, "EX1_059e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_067] Argent Commander - COST:6 [ATK:4/HP:2]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_067", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_076] Pint-Sized Summoner - COST:2 [ATK:2/HP:2]
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: The first minion you play each turn costs (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_076", new CardDef(new Power
			{
				//Aura = new Aura(AuraType.HAND, Effects.ReduceCost(1))
				//{
				//	Condition = SelfCondition.MinionsPlayedThisTurn(0),
				//	Restless = true
				//}
				Aura = new SwitchingAura(AuraType.HAND, SelfCondition.MinionsPlayedThisTurn(0),
					TriggerType.PLAY_MINION, Effects.ReduceCost(1))
				{
					Condition = SelfCondition.IsMinion
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_080] Secretkeeper - COST:1 [ATK:1/HP:2]
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a <b>Secret</b> is played, gain +1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_080", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					Condition = SelfCondition.IsSecret,
					SingleTask = new AddEnchantmentTask("EX1_080o", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_082] Mad Bomber - COST:2 [ATK:3/HP:2]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage randomly split between all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_082", new CardDef(new Power
			{
				PowerTask =
					new EnqueueTask(3, ComplexTask.DamageRandomTargets(1, EntityType.ALL_NOSOURCE, 1))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_083] Tinkmaster Overspark - COST:3 [ATK:3/HP:3]
			// - Fac: alliance, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Transform
			//       another random minion
			//       into a 5/5 Devilsaur
			//        or a 1/1 Squirrel.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_083", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(1, EntityType.ALLMINIONS_NOSOURCE),
					new ChanceTask(true),
					new FlagTask(true, new TransformTask("EX1_tk28", EntityType.STACK)),
					new FlagTask(false, new TransformTask("EX1_tk29", EntityType.STACK))),
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_085] Mind Control Tech - COST:3 [ATK:3/HP:3]
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your opponent
			//       has 4 or more minions, take
			//        control of one at random.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_085", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.OP_MINIONS),
					new FuncPlayablesTask(p => p.Count > 3 ? p : new List<IPlayable>()),
					new RandomTask(1, EntityType.STACK),
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsBoardFull),
					new FlagTask(false, new ControlTask(EntityType.STACK)),
					new FlagTask(true, new DestroyTask(EntityType.STACK)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_089] Arcane Golem - COST:3 [ATK:4/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your opponent a Mana Crystal.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_089", new CardDef(new Power
			{
				PowerTask = new ManaCrystalEmptyTask(1, true)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_093] Defender of Argus - COST:4 [ATK:2/HP:3]
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give adjacent minions +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_093", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeAdjacentTask(EntityType.SOURCE),
					new AddEnchantmentTask("EX1_093e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_095] Gadgetzan Auctioneer - COST:6 [ATK:4/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, draw a card.
			// --------------------------------------------------------
			cards.Add("EX1_095", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new DrawTask()
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_096] Loot Hoarder - COST:2 [ATK:2/HP:1]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_096", new CardDef(new Power
			{
				DeathrattleTask = new DrawTask()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_097] Abomination - COST:5 [ATK:4/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Deathrattle:</b> Deal 2
			//       damage to ALL characters.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_097", new CardDef(new Power
			{
				DeathrattleTask = new DamageTask(2, EntityType.ALL)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_100] Lorewalker Cho - COST:2 [ATK:0/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever a player casts a spell, put a copy into the other player’s hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_100", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.TARGET, RelaCondition.IsFriendly),
						new FlagTask(true, new CopyTask(EntityType.TARGET, Zone.HAND, toOpponent: true)),
						new FlagTask(false, new CopyTask(EntityType.TARGET, Zone.HAND)))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_102] Demolisher - COST:3 [ATK:1/HP:4]
			// - Race: mechanical, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 2 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("EX1_102", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = ComplexTask.Create(
						new RandomTask(1, EntityType.ENEMIES),
						new DamageTask(2, EntityType.STACK))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_103] Coldlight Seer - COST:3 [ATK:2/HP:3]
			// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your other Murlocs +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_103", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.MINIONS),
					new FilterStackTask(SelfCondition.IsRace(Race.MURLOC)),
					new AddEnchantmentTask("EX1_103e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_105] Mountain Giant - COST:12 [ATK:8/HP:8]
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each other card in your hand.
			// --------------------------------------------------------
			cards.Add("EX1_105", new CardDef(new Power
			{
				Aura = new AdaptiveCostEffect(p => p.Controller.HandZone.Count - 1)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_110] Cairne Bloodhoof - COST:6 [ATK:4/HP:5]
			// - Fac: alliance, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 4/5 Baine Bloodhoof.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_110", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("EX1_110t", SummonSide.DEATHRATTLE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_116] Leeroy Jenkins - COST:5 [ATK:6/HP:2]
			// - Fac: alliance, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge</b>. <b>Battlecry:</b> Summon two 1/1 Whelps for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_116", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(2, new SummonOpTask("EX1_116t"))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_162] Dire Wolf Alpha - COST:2 [ATK:2/HP:2]
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Adjacent minions have +1_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ADJACENT_BUFF = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_162", new CardDef(new Power
			{
				//Aura = new Aura(AuraType.ADJACENT, "EX1_162o")
				Aura = new AdjacentAura("EX1_162o")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_170] Emperor Cobra - COST:3 [ATK:2/HP:3]
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("EX1_170", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_186] SI:7 Infiltrator - COST:4 [ATK:5/HP:4]
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a random enemy <b>Secret</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_186", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomTask(1, EntityType.OP_SECRETS),
					new MoveToGraveYard(EntityType.STACK))

			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_187] Arcane Devourer - COST:8 [ATK:5/HP:5]
			// - Race: elemental, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain +2/+2.
			// --------------------------------------------------------
			cards.Add("EX1_187", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new AddEnchantmentTask("EX1_187e", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_188] Barrens Stablehand - COST:7 [ATK:4/HP:4]
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a random Beast.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_188", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.CARDRACE, (int)Race.BEAST),
					new SummonTask())
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_189] Brightwing - COST:3 [ATK:3/HP:2]
			// - Race: dragon, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random <b>Legendary</b> minion to your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_189", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new RandomCardTask(CardType.MINION, CardClass.INVALID, rarity: Rarity.LEGENDARY),
					new AddStackTo(EntityType.HAND))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_190] High Inquisitor Whitemane - COST:7 [ATK:6/HP:8]
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon all friendly minions that died_this turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_190", new CardDef(new Power
			{
				PowerTask = ComplexTask.SummonAllFriendlyDiedThisTurn()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_249] Baron Geddon - COST:7 [ATK:7/HP:5]
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 2 damage to ALL other characters.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_249", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new DamageTask(2, EntityType.ALL_NOSOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_283] Frost Elemental - COST:6 [ATK:5/HP:5]
			// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Freeze</b> a_character.
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_283", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				PowerTask = ComplexTask.Freeze(EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_390] Tauren Warrior - COST:3 [ATK:2/HP:3]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Enrage:</b> +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_390", new CardDef(new Power
			{
				//Trigger = Triggers.EnrageTrigger("EX1_390e")
				Aura = new EnrageEffect(AuraType.SELF, "EX1_390e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_393] Amani Berserker - COST:2 [ATK:2/HP:3]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Enrage:</b> +3 Attack
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_393", new CardDef(new Power
			{
				//Trigger = Triggers.EnrageTrigger("EX1_393e")
				Aura = new EnrageEffect(AuraType.SELF, "EX1_393e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_396] Mogu'shan Warden - COST:4 [ATK:1/HP:7]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_396", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_405] Shieldbearer - COST:1 [ATK:0/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_405", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_412] Raging Worgen - COST:3 [ATK:3/HP:3]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Enrage:</b> <b>Windfury</b> and +1_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("EX1_412", new CardDef(new Power
			{
				//Trigger = Triggers.EnrageTrigger("EX1_412e")
				Aura = new EnrageEffect(AuraType.SELF, "EX1_412e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_507] Murloc Warleader - COST:3 [ATK:3/HP:3]
			// - Race: murloc, Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your other Murlocs have +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_507", new CardDef(new Power
			{
				Aura = new Aura(AuraType.BOARD_EXCEPT_SOURCE, "EX1_507e")
				{
					Condition = SelfCondition.IsRace(Race.MURLOC)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_509] Murloc Tidecaller - COST:1 [ATK:1/HP:2]
			// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you summon a Murloc, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_509", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.SUMMON)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsRace(Race.MURLOC),
					SingleTask = new AddEnchantmentTask("EX1_509e", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_556] Harvest Golem - COST:3 [ATK:2/HP:3]
			// - Race: mechanical, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 2/1 Damaged Golem.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_556", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("skele21", SummonSide.DEATHRATTLE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_557] Nat Pagle - COST:2 [ATK:0/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the start of your turn, you have a 50% chance to draw an extra card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_557", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = ComplexTask.Create(
						new ChanceTask(),
						new DrawTask())
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_558] Harrison Jones - COST:5 [ATK:5/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your opponent's weapon and draw cards equal to its Durability.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_558", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.DURABILITY, EntityType.OP_WEAPON),
					new GetGameTagTask(GameTag.DAMAGE, EntityType.OP_WEAPON, 0, 1),
					new MathNumberIndexTask(0, 1, MathOperation.SUB),
					new DestroyTask(EntityType.OP_WEAPON),
					new DrawNumberTask())
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_560] Nozdormu - COST:9 [ATK:8/HP:8]
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Players only have 15 seconds to take their_turns.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_560", new CardDef(new Power
			{
				Aura = new Aura(AuraType.CONTROLLERS, new Effect(GameTag.TIMEOUT, EffectOperator.SET, -55))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_561] Alexstrasza - COST:9 [ATK:8/HP:8]
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Set a hero's remaining Health to 15.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_HERO_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_561", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_HERO_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_561e", EntityType.TARGET)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_562] Onyxia - COST:9 [ATK:8/HP:8]
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon 1/1 Whelps until your side of the battlefield is full.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_562", new CardDef(new Power
			{
				PowerTask = new EnqueueTask(3,
					ComplexTask.Create(
						new SummonTask("EX1_116t", SummonSide.RIGHT),
						new SummonTask("EX1_116t", SummonSide.LEFT)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_563] Malygos - COST:9 [ATK:4/HP:12]
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Spell Damage +5</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - SPELLPOWER = 5
			// --------------------------------------------------------
			cards.Add("EX1_563", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_564] Faceless Manipulator - COST:5 [ATK:3/HP:3]
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a minion and become a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_564", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_NONSELF_TARGET,0}}, new Power
			{
				PowerTask = new TransformCopyTask()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_572] Ysera - COST:9 [ATK:4/HP:12]
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, add_a Dream Card to_your hand.
			// --------------------------------------------------------
			// Entourage: DREAM_01, DREAM_02, DREAM_03, DREAM_04, DREAM_05
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_572", new CardDef(new[] {"DREAM_01","DREAM_02","DREAM_03","DREAM_04","DREAM_05"}, new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new RandomEntourageTask(),
						new AddStackTo(EntityType.HAND))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_577] The Beast - COST:6 [ATK:9/HP:7]
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 3/3 Finkle Einhorn for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_577", new CardDef(new Power
			{
				DeathrattleTask = new SummonOpTask("EX1_finkle")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_583] Priestess of Elune - COST:6 [ATK:5/HP:4]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 4 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_583", new CardDef(new Power
			{
				PowerTask = new HealTask(4, EntityType.HERO),
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_584] Ancient Mage - COST:4 [ATK:2/HP:5]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give adjacent_minions <b>Spell_Damage +1</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("EX1_584", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeAdjacentTask(EntityType.SOURCE),
					new AddEnchantmentTask("EX1_584e", EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_586] Sea Giant - COST:10 [ATK:8/HP:8]
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each other minion on the battlefield.
			// --------------------------------------------------------
			cards.Add("EX1_586", new CardDef(new Power
			{
				Aura = new AdaptiveCostEffect(p => p.Controller.BoardZone.Count + p.Controller.Opponent.BoardZone.Count)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_590] Blood Knight - COST:3 [ATK:3/HP:3]
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> All minions lose <b>Divine Shield</b>. Gain +3/+3 for each Shield lost.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_590", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.ALLMINIONS),
					new FilterStackTask(SelfCondition.IsTagValue(GameTag.DIVINE_SHIELD, 1)),
					new SetGameTagTask(GameTag.DIVINE_SHIELD, 0, EntityType.STACK),
					new CountTask(EntityType.STACK),
					new MathMultiplyTask(3),
					new AddEnchantmentTask("EX1_590e", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_595] Cult Master - COST:4 [ATK:4/HP:2]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever one of your other minions dies, draw a card.
			// --------------------------------------------------------
			cards.Add("EX1_595", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.MINIONS,
					SingleTask = new DrawTask()
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_597] Imp Master - COST:3 [ATK:1/HP:5]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]At the end of your turn, deal
			//       1 damage to this minion
			//        and summon a 1/1 Imp.
			// --------------------------------------------------------
			cards.Add("EX1_597", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new DamageTask(1, EntityType.SOURCE),
						new SummonTask("EX1_598", SummonSide.RIGHT))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_614] Illidan Stormrage - COST:6 [ATK:7/HP:5]
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you play a card, summon a 2/1 Flame of_Azzinoth.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_614", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.PLAY_CARD)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new SummonTask("EX1_614t", SummonSide.RIGHT)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_616] Mana Wraith - COST:2 [ATK:2/HP:2]
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: ALL minions cost (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_616", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HANDS, Effects.AddCost(1))
				{
					Condition = SelfCondition.IsMinion
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_017] Hungry Crab - COST:1 [ATK:1/HP:2]
			// - Race: beast, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a Murloc and gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_WITH_RACE = 14
			// --------------------------------------------------------
			cards.Add("NEW1_017", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_TARGET_WITH_RACE,14}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.TARGET, SelfCondition.IsRace(Race.MURLOC)),
					new FlagTask(true, new DestroyTask(EntityType.TARGET)),
					new FlagTask(true, new AddEnchantmentTask("NEW1_017e", EntityType.SOURCE)))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_018] Bloodsail Raider - COST:2 [ATK:2/HP:3]
			// - Race: pirate, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain Attack equal to the Attack
			//       of your weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_018", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ATK, EntityType.WEAPON),
					new AddEnchantmentTask("NEW1_018e", EntityType.SOURCE, true))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_019] Knife Juggler - COST:2 [ATK:2/HP:2]
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]After you summon a
			//       minion, deal 1 damage
			//       to a random enemy.
			// --------------------------------------------------------
			cards.Add("NEW1_019", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_SUMMON)
				{
					TriggerSource = TriggerSource.MINIONS_EXCEPT_SELF,
					SingleTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_020] Wild Pyromancer - COST:2 [ATK:3/HP:2]
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: After you cast a spell, deal 1 damage to ALL minions.
			// --------------------------------------------------------
			cards.Add("NEW1_020", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.AFTER_CAST)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new DamageTask(1, EntityType.ALLMINIONS)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_021] Doomsayer - COST:2 [ATK:0/HP:7]
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy ALL minions.
			// --------------------------------------------------------
			// GameTag:
			// - 886 = 1
			// --------------------------------------------------------
			cards.Add("NEW1_021", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = new DestroyTask(EntityType.ALLMINIONS)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_022] Dread Corsair - COST:4 [ATK:3/HP:3]
			// - Race: pirate, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Costs (1) less per Attack of_your weapon.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("NEW1_022", new CardDef(new Power
			{
				Aura = new AdaptiveCostEffect(p => p.Controller.Hero.Weapon?.AttackDamage ?? 0)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_023] Faerie Dragon - COST:2 [ATK:3/HP:2]
			// - Race: dragon, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("NEW1_023", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_024] Captain Greenskin - COST:5 [ATK:5/HP:4]
			// - Race: pirate, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your weapon +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_024", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("NEW1_024o", EntityType.WEAPON)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_025] Bloodsail Corsair - COST:1 [ATK:1/HP:2]
			// - Race: pirate, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Remove
			//       1 Durability from your
			//       opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_025", new CardDef(new Power
			{
				PowerTask = new DamageWeaponTask()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_026] Violet Teacher - COST:4 [ATK:3/HP:5]
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a 1/1 Violet Apprentice.
			// --------------------------------------------------------
			cards.Add("NEW1_026", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = new SummonTask("NEW1_026t", SummonSide.RIGHT)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_027] Southsea Captain - COST:3 [ATK:3/HP:3]
			// - Race: pirate, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your other Pirates have +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("NEW1_027", new CardDef(new Power
			{
				Aura = new Aura(AuraType.BOARD_EXCEPT_SOURCE, "NEW1_027e")
				{
					Condition = SelfCondition.IsRace(Race.PIRATE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_029] Millhouse Manastorm - COST:2 [ATK:4/HP:4]
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Enemy spells cost (0) next turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_029", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("NEW1_029t", EntityType.CONTROLLER)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_030] Deathwing - COST:10 [ATK:12/HP:12]
			// - Race: dragon, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all other minions and discard your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - 890 = 10
			// --------------------------------------------------------
			cards.Add("NEW1_030", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.ALLMINIONS),
					new DiscardTask(EntityType.HAND))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_037] Master Swordsmith - COST:2 [ATK:1/HP:3]
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, give another random friendly minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("NEW1_037", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new RandomTask(1, EntityType.MINIONS_NOSOURCE),
						new AddEnchantmentTask("NEW1_037e", EntityType.STACK))
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_038] Gruul - COST:8 [ATK:7/HP:7]
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of each turn, gain +1/+1 .
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("NEW1_038", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					EitherTurn = true,
					SingleTask = new AddEnchantmentTask("NEW1_038o", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_040] Hogger - COST:6 [ATK:4/HP:4]
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a 2/2 Gnoll with_<b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("NEW1_040", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = new SummonTask("NEW1_040t", SummonSide.RIGHT)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_041] Stampeding Kodo - COST:5 [ATK:3/HP:5]
			// - Race: beast, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a random enemy minion with 2 or less Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_041", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new IncludeTask(EntityType.OP_MINIONS),
					new FilterStackTask(
						SelfCondition.IsTagValue(GameTag.ATK, 2, RelaSign.LEQ),
						SelfCondition.IsNotDead),
					new RandomTask(1, EntityType.STACK),
					new DestroyTask(EntityType.STACK))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [tt_004] Flesheating Ghoul - COST:3 [ATK:2/HP:3]
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever a minion dies, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("tt_004", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.ALL_MINIONS,
					SingleTask = new AddEnchantmentTask("tt_004o", EntityType.SOURCE)
				}
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_181e] Full Strength (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: This minion has +2 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_181e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CS2_181e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_188o] 'Inspired' (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: This minion has +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CS2_188o", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("CS2_188o")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_221e] Sharp! (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +2 Attack from Spiteful Smith.
			// --------------------------------------------------------
			cards.Add("CS2_221e", new CardDef(new Power
			{
				//Aura = new EnrageEffect(AuraType.WEAPON, Effects.Attack_N(2))
				Enchant = new Enchant(new Effect(GameTag.ATK, EffectOperator.ADD, 2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DREAM_05e] Nightmare (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: This minion has +5/+5, but will be destroyed soon.
			// --------------------------------------------------------
			cards.Add("DREAM_05e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DREAM_05e"),
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = new DestroyTask(EntityType.TARGET)
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_001e] Warded (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("EX1_001e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_004e] Elune's Grace (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("EX1_004e", new CardDef(new Power
			{
				//Enchant = new OngoingEnchant(Effects.Health_N(1))
				Enchant = new Enchant(Effects.Health_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_009e] Enraged (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +5 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_009e", new CardDef(new Power
			{
				//Aura = new EnrageEffect(AuraType.SELF, Effects.Attack_N(5))
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_009e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_014te] Bananas (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Has +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_014te", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_014te")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_043e] Hour of Twilight (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("EX1_043e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_044e] Level Up! (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Attack and Health.
			// --------------------------------------------------------
			cards.Add("EX1_044e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_046e] Tempered (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_046e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_046e"),
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_055o] Empowered (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Mana Addict has increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_055o", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(2))
				{
					IsOneTurnEffect = true
				},
				//Trigger = Triggers.OneTurnEffectRemovalTrigger("EX1_055o")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_059e] Experiments! (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Crazed Alchemist.
			// --------------------------------------------------------
			cards.Add("EX1_059e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.SetAttackHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_080o] Keeping Secrets (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_080o", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_093e] Hand of Argus (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_093e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_093e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_103e] Mrghlglhal (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("EX1_103e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_103e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_187e] Arcane Gorged (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_187e", new CardDef(new Power
			{
				//Enchant = new Enchant(Effects.AttackHealth_N(2))
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(2))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_162o] Strength of the Pack (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +1 Attack from Dire Wolf Alpha.
			// --------------------------------------------------------
			cards.Add("EX1_162o", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_162o")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_390e] Enraged (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_390e", new CardDef(new Power
			{
				//Aura = new EnrageEffect(AuraType.SELF, Effects.Attack_N(3))
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_390e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_393e] Enraged (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_393e", new CardDef(new Power
			{
				//Aura = new EnrageEffect(AuraType.SELF, Effects.Attack_N(3))
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_393e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_412e] Enraged (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_412e", new CardDef(new Power
			{
				//Aura = new EnrageEffect(AuraType.SELF, Effects.Attack_N(1), Effects.Windfury),
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_412e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_509e] Blarghghl (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("EX1_509e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_561e] Alexstrasza's Fire (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Health set to 15.
			// --------------------------------------------------------
			cards.Add("EX1_561e", new CardDef(new Power
			{
				Enchant = new Enchant(Effects.SetMaxHealth(15))
			}));



			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_570e] Bite (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +4 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_570e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("EX1_570e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_584e] Teachings of the Kirin Tor (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			cards.Add("EX1_584e", new CardDef(new Power
			{
				Enchant = new Enchant(GameTag.SPELLPOWER, EffectOperator.ADD, 1)
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_590e] Shadows of M'uru (*) - COST:0
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: This minion has consumed Divine Shields and has increased Attack and Health.
			// --------------------------------------------------------
			cards.Add("EX1_590e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackHealthScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_04e] Empowered (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +8 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_04e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_08_04e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_017e] Full Belly (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +2/+2.  Full of Murloc.
			// --------------------------------------------------------
			cards.Add("NEW1_017e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("NEW1_017e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_018e] Treasure Crazed (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("NEW1_018e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.AddAttackScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_024o] Greenskin's Command (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("NEW1_024o", new CardDef(new Power
			{
				Enchant = new Enchant(
					Effects.Attack_N(1),
					new Effect(GameTag.DURABILITY, EffectOperator.ADD, 1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_025e] Bolstered (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("NEW1_025e", new CardDef());

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_029t] Kill Millhouse! (*) - COST:0
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Spells cost (0) this turn!
			// --------------------------------------------------------
			cards.Add("NEW1_029t", new CardDef(new Power
			{
				Aura = new Aura(AuraType.OP_HAND, Effects.SetCost(0))
				{
					Condition = SelfCondition.IsSpell,
					RemoveTrigger = (TriggerType.TURN_END, SelfCondition.IsOpTurn)
				}
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_037e] Equipped (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("NEW1_037e", new CardDef(new Power
			{
				//Enchant = new OngoingEnchant(Effects.Attack_N(1))
				Enchant = new Enchant(Effects.Attack_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_038o] Growth (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Gruul is growing...
			// --------------------------------------------------------
			cards.Add("NEW1_038o", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [tt_004o] Cannibalize (*) - COST:0
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("tt_004o", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_152] Squire (*) - COST:1 [ATK:2/HP:2]
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("CS2_152", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [ds1_whelptoken] Whelp (*) - COST:1 [ATK:1/HP:1]
			// - Race: dragon, Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			cards.Add("ds1_whelptoken", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_110t] Baine Bloodhoof (*) - COST:4 [ATK:4/HP:5]
			// - Set: expert1,
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_110t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_116t] Whelp (*) - COST:1 [ATK:1/HP:1]
			// - Race: dragon, Set: expert1,
			// --------------------------------------------------------
			cards.Add("EX1_116t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_598] Imp (*) - COST:1 [ATK:1/HP:1]
			// - Race: demon, Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			cards.Add("EX1_598", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_614t] Flame of Azzinoth (*) - COST:1 [ATK:2/HP:1]
			// - Race: elemental, Set: expert1,
			// --------------------------------------------------------
			cards.Add("EX1_614t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_finkle] Finkle Einhorn (*) - COST:3 [ATK:3/HP:3]
			// - Fac: neutral, Set: expert1,
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_finkle", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_tk28] Squirrel (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_tk28", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_tk29] Devilsaur (*) - COST:5 [ATK:5/HP:5]
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_tk29", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_026t] Violet Apprentice (*) - COST:1 [ATK:1/HP:1]
			// - Set: expert1,
			// --------------------------------------------------------
			cards.Add("NEW1_026t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_040t] Gnoll (*) - COST:2 [ATK:2/HP:2]
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("NEW1_040t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [skele21] Damaged Golem (*) - COST:1 [ATK:2/HP:1]
			// - Race: mechanical, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("skele21", new CardDef());

			// ---------------------------------------- SPELL - NEUTRAL
			// [EX1_014t] Bananas (*) - COST:1
			// - Set: expert1,
			// --------------------------------------------------------
			// Text: Give a minion +1/+1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_014t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = new AddEnchantmentTask("EX1_014te", EntityType.TARGET)
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
			DreamNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
