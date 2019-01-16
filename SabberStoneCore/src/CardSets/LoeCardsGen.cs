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
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets
{
	public class LoeCardsGen
	{
		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [LOE_050] Mounted Raptor - COST:3 [ATK:3/HP:2] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random 1-Cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_050", new Power {
				PowerTask = ComplexTask.SummonRandomMinion(GameTag.COST, 1)
			});

			// ----------------------------------------- MINION - DRUID
			// [LOE_051] Jungle Moonkin - COST:4 [ATK:4/HP:4] 
			// - Race: beast, Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Both players have
			//       <b>Spell Damage +2</b>.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 2
			// --------------------------------------------------------
			cards.Add("LOE_051", new Power {
				// TODO [LOE_051] Jungle Moonkin && Test: Jungle Moonkin_LOE_051
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOE_115] Raven Idol - COST:1 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b>
			//       <b>Discover</b> a minion; or <b>Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("LOE_115",
				//CHOOSE_ONE
				null);

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [LOE_115a] Raven Idol (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a minion.
			// --------------------------------------------------------
			cards.Add("LOE_115a", new Power {
				PowerTask = new DiscoverTask(DiscoverType.MINION),
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOE_115b] Raven Idol (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a spell.
			// --------------------------------------------------------
			cards.Add("LOE_115b", new Power {
				PowerTask = new DiscoverTask(DiscoverType.SPELL),
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [LOE_020] Desert Camel - COST:3 [ATK:2/HP:4] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Put a 1-Cost minion from each deck into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_020", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsNotBoardFull),
					new FlagTask(true, ComplexTask.Create(
						new IncludeTask(EntityType.DECK),
						new FilterStackTask(SelfCondition.IsTagValue(GameTag.COST, 1)),
						new RandomTask(1, EntityType.STACK),
						new RemoveFromDeck(EntityType.STACK),
						new SummonTask())),
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsOpNotBoardFull),
					new FlagTask(true, ComplexTask.Create(
						new IncludeTask(EntityType.OP_DECK),
						new FilterStackTask(SelfCondition.IsTagValue(GameTag.COST, 1)),
						new RandomTask(1, EntityType.STACK),
						new RemoveFromDeck(EntityType.STACK),
						new SummonOpTask())))
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOE_021] Dart Trap - COST:2 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After an opposing Hero Power is used, deal $5 damage to a random enemy. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOE_021", new Power {
				Trigger = new Trigger(TriggerType.INSPIRE)
				{
					EitherTurn =  true,
					SingleTask = ComplexTask.Secret(ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 5, true))
				}
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOE_105] Explorer's Hat - COST:2 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion +1/+1 and "<b>Deathrattle:</b> Add an Explorer's Hat to your hand."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_105", new Power {
				PowerTask = new AddEnchantmentTask("LOE_105e", EntityType.TARGET)
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [LOE_105e] Explorer's Hat (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +1/+1. <b>Deathrattle:</b> Add an Explorer's Hat to your hand.
			// --------------------------------------------------------
			cards.Add("LOE_105e", new Power {
				Enchant = new Enchant(Effects.AttackHealth_N(1)),
				DeathrattleTask = new AddCardTo("LOE_105", EntityType.HAND)
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [LOE_003] Ethereal Conjurer - COST:5 [ATK:6/HP:3] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("LOE_003", new Power {
				PowerTask = new DiscoverTask(DiscoverType.SPELL)
			});

			// ------------------------------------------ MINION - MAGE
			// [LOE_119] Animated Armor - COST:4 [ATK:4/HP:4] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Your hero can only take 1 damage at a time.
			// --------------------------------------------------------
			cards.Add("LOE_119", new Power {
				// TODO [LOE_119] Animated Armor && Test: Animated Armor_LOE_119
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOE_002] Forgotten Torch - COST:3 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage. Shuffle a 'Roaring Torch' into your deck that deals 6 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOE_002", new Power {
					PowerTask = ComplexTask.Create(
						new DamageTask(3, EntityType.TARGET, true),
						new AddCardTo("LOE_002t", EntityType.DECK)),
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [LOE_002t] Roaring Torch (*) - COST:3 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Deal $6 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOE_002t", new Power {
				PowerTask = new DamageTask(6, EntityType.TARGET, true),
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [LOE_017] Keeper of Uldaman - COST:4 [ATK:3/HP:4] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Set a minion's Attack and Health to 3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOE_017", new Power {
				PowerTask = new AddEnchantmentTask("LOE_017e", EntityType.TARGET)
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOE_026] Anyfin Can Happen - COST:10 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 7 Murlocs that died this game.
			// --------------------------------------------------------
			cards.Add("LOE_026", new Power {
					PowerTask = ComplexTask.Create(
						new IncludeTask(EntityType.GRAVEYARD),
						new FilterStackTask(SelfCondition.IsMinion, SelfCondition.IsRace(Race.MURLOC)),
						new RandomTask(7, EntityType.STACK),
                        //new CopyTask(EntityType.STACK, 1),
                        new SummonCopyTask(EntityType.STACK))
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOE_027] Sacred Trial - COST:1 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent has at least 3 minions and plays another, destroy it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOE_027", new Power {
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsOpBoardCount(4, RelaSign.GEQ)),
						new FlagTask(true, ComplexTask.Secret(new DestroyTask(EntityType.TARGET))))
				}
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [LOE_017e] Watched (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Stats changed to 3/3.
			// --------------------------------------------------------
			cards.Add("LOE_017e", new Power {
				Enchant = new Enchant(Effects.SetAttackHealth(3))
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [LOE_006] Museum Curator - COST:2 [ATK:1/HP:2] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a <b>Deathrattle</b> card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("LOE_006", new Power {
				PowerTask = new DiscoverTask(DiscoverType.DEATHRATTLE)
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOE_104] Entomb - COST:6 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Choose an enemy minion.
			//       Shuffle it into your deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOE_104", new Power {
				PowerTask = new MoveToDeck(EntityType.TARGET)
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOE_111] Excavated Evil - COST:5 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $3 damage to all minions.
			//       Shuffle this card into your opponent's deck. @spelldmg
			// --------------------------------------------------------
			cards.Add("LOE_111", new Power {
					PowerTask = ComplexTask.Create(
						new DamageTask(3, EntityType.ALLMINIONS, true),
						new AddCardTo("LOE_111", EntityType.OP_DECK)),
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [LOE_010] Pit Snake - COST:1 [ATK:2/HP:1] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("LOE_010", null);

			// ----------------------------------------- MINION - ROGUE
			// [LOE_012] Tomb Pillager - COST:4 [ATK:5/HP:4] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a Coin to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_012", new Power {
				DeathrattleTask = new AddCardTo("GAME_005", EntityType.HAND),
			});

			// ----------------------------------------- MINION - ROGUE
			// [LOE_019] Unearthed Raptor - COST:3 [ATK:3/HP:4] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Gain a copy of its_<b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_019", new Power {
				PowerTask = ComplexTask.Create(
					new GetGameTagTask(GameTag.ENTITY_ID, EntityType.TARGET),
					new AddEnchantmentTask("LOE_019e", EntityType.SOURCE, true, true))
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [LOE_019e] Unearthed Raptor (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Copied Deathrattle from {0}.
			// --------------------------------------------------------
			cards.Add("LOE_019e", new Power {
				//DeathrattleTask = ComplexTask.Create(
				//	new IncludeTask(EntityType.SOURCE),
				//	new IncludeTask(EntityType.TARGET, null, true),
				//	new FuncPlayablesTask(p =>
				//	{
				//		p[0].Game.IdEntityDic[p[1][GameTag.TAG_SCRIPT_DATA_NUM_1]].ActivateTask(PowerActivation.DEATHRATTLE, null, 0, p[0]);
				//		return null;
				//	}))
				DeathrattleTask = ActivateCapturedDeathrattleTask.Task
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [LOE_016] Rumbling Elemental - COST:4 [ATK:2/HP:6] 
			// - Race: elemental, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: After you play a <b>Battlecry</b> minion, deal 2 damage to a random enemy.
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_016", new Power {
				Trigger = new Trigger(TriggerType.AFTER_PLAY_MINION)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsBattlecryMinion,
					SingleTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 2)
				}
			});

			// ---------------------------------------- MINION - SHAMAN
			// [LOE_018] Tunnel Trogg - COST:1 [ATK:1/HP:3] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you <b>Overload</b>, gain +1 Attack per locked Mana Crystal.
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("LOE_018", new Power {
				Trigger = new Trigger(TriggerType.PLAY_CARD)
				{
					Condition = SelfCondition.IsOverloadCard,
					SingleTask = ComplexTask.Create(
						new GetGameTagTask(GameTag.OVERLOAD, EntityType.TARGET),
						new AddEnchantmentTask("LOE_018e", EntityType.SOURCE, true))
				}
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOE_113] Everyfin is Awesome - COST:7 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your minions +2/+2.
			//       Costs (1) less for each Murloc you control.
			// --------------------------------------------------------
			cards.Add("LOE_113", new Power {
				Aura = new AdaptiveCostEffect(p => p.Controller.BoardZone.GetAll(q => q.Race == Race.MURLOC).Length),
				PowerTask = new AddEnchantmentTask("LOE_113e", EntityType.ALLMINIONS)
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [LOE_018e] Trogg No Stupid (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("LOE_018e", new Power {
				// TODO: revise this
				Enchant = Enchants.Enchants.AddAttackScriptTag
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [LOE_023] Dark Peddler - COST:2 [ATK:2/HP:2] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a
			//       1-Cost card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("LOE_023", new Power {
				// TODO [LOE_023] Dark Peddler && Test: Dark Peddler_LOE_023
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOE_116] Reliquary Seeker - COST:1 [ATK:1/HP:1] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have 6 other minions, gain +4/+4.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_116", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsBoardFull),
					new FlagTask(true, new AddEnchantmentTask("LOE_009e", EntityType.SOURCE)))
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOE_007] Curse of Rafaam - COST:2 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Give your opponent a 'Cursed!' card.
			//       While they hold it, they take 2 damage on their turn.
			// --------------------------------------------------------
			cards.Add("LOE_007", new Power {
				PowerTask = new AddCardTo("LOE_007t", EntityType.OP_HAND)
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [LOE_009e] Sinister Power (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			cards.Add("LOE_009e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOE_009e")
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOE_007t] Cursed! (*) - COST:2 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: While this is in your hand, take 2 damage at the start of your turn.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - EVIL_GLOW = 1
			// --------------------------------------------------------
			cards.Add("LOE_007t", new Power {
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					TriggerActivation = TriggerActivation.HAND,
					SingleTask = new DamageTask(2, EntityType.HERO)
				}
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [LOE_009] Obsidian Destroyer - COST:7 [ATK:7/HP:7] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a 1/1 Scarab with <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOE_009", new Power {
				// TODO [LOE_009] Obsidian Destroyer && Test: Obsidian Destroyer_LOE_009
				InfoCardId = "LOE_009e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [LOE_022] Fierce Monkey - COST:3 [ATK:3/HP:4] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOE_022", new Power {
				// TODO [LOE_022] Fierce Monkey && Test: Fierce Monkey_LOE_022
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [LOE_118] Cursed Blade - COST:1 [ATK:2/HP:0] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Double all damage dealt to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("LOE_118", new Power {
				// TODO [LOE_118] Cursed Blade && Test: Cursed Blade_LOE_118
				InfoCardId = "LOE_118e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [LOE_118e] Cursed Blade (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Double all damage dealt to your hero.
			// --------------------------------------------------------
			cards.Add("LOE_118e", new Power {
				// TODO [LOE_118e] Cursed Blade && Test: Cursed Blade_LOE_118e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [LOE_009t] Scarab (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOE_009t", new Power {
				// TODO [LOE_009t] Scarab && Test: Scarab_LOE_009t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [LOE_011] Reno Jackson - COST:6 [ATK:4/HP:6] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no duplicates, fully heal your hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_011", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsNoDupeInDeck),
					new FlagTask(true, new HealFullTask(EntityType.HERO)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_029] Jeweled Scarab - COST:2 [ATK:1/HP:1] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a
			//       3-Cost card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("LOE_029", new Power {
				// TODO [LOE_029] Jeweled Scarab && Test: Jeweled Scarab_LOE_029
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_038] Naga Sea Witch - COST:8 [ATK:5/HP:5] 
			// - Set: loe, Rarity: epic
			// --------------------------------------------------------
			// Text: Your cards cost (5).
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("LOE_038", new Power {
				Aura = new Aura(AuraType.HAND, Effects.SetCost(5))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_039] Gorillabot A-3 - COST:4 [ATK:3/HP:4] 
			// - Race: mechanical, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control another Mech, <b>Discover</b> a Mech.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("LOE_039", new Power {
				PowerTask = ComplexTask.Create(
					new ConditionTask(EntityType.SOURCE, new SelfCondition(p => p.Controller.BoardZone.Any(q => q != p && q.Race == Race.MECHANICAL))),
					new FlagTask(true, new DiscoverTask(DiscoverType.MECHANICAL)))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_046] Huge Toad - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 1 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_046", new Power {
				// TODO [LOE_046] Huge Toad && Test: Huge Toad_LOE_046
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_047] Tomb Spider - COST:4 [ATK:3/HP:3] 
			// - Race: beast, Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a Beast.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("LOE_047", new Power {
				// TODO [LOE_047] Tomb Spider && Test: Tomb Spider_LOE_047
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_053] Djinni of Zephyrs - COST:5 [ATK:4/HP:6] 
			// - Race: elemental, Set: loe, Rarity: epic
			// --------------------------------------------------------
			// Text: After you cast a spell on another friendly minion, cast a copy of it on this one.
			// --------------------------------------------------------
			cards.Add("LOE_053", new Power {
				// TODO [LOE_053] Djinni of Zephyrs && Test: Djinni of Zephyrs_LOE_053
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_061] Anubisath Sentinel - COST:5 [ATK:4/HP:4] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give a random friendly minion +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_061", new Power {
				// TODO [LOE_061] Anubisath Sentinel && Test: Anubisath Sentinel_LOE_061
				InfoCardId = "LOE_061e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_073] Fossilized Devilsaur - COST:8 [ATK:8/HP:8] 
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a Beast, gain <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOE_073", new Power {
				// TODO [LOE_073] Fossilized Devilsaur && Test: Fossilized Devilsaur_LOE_073
				InfoCardId = "LOE_073e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_076] Sir Finley Mrrgglton - COST:1 [ATK:1/HP:3] 
			// - Race: murloc, Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a new basic Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("LOE_076", new Power {
				PowerTask = new DiscoverTask(DiscoverType.BASIC_HEROPOWERS)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_077] Brann Bronzebeard - COST:3 [ATK:2/HP:4] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your <b>Battlecries</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_077", new Power {
				Aura = new Aura(AuraType.CONTROLLER, new Effect(GameTag.EXTRA_BATTLECRIES_BASE, EffectOperator.SET, 1))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_079] Elise Starseeker - COST:4 [ATK:3/HP:5] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle the 'Map to the Golden Monkey'   into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOE_079", new Power {
				PowerTask = new AddCardTo("LOE_019t", EntityType.DECK)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_086] Summoning Stone - COST:5 [ATK:0/HP:6] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a random minion of the same Cost.
			// --------------------------------------------------------
			cards.Add("LOE_086", new Power {
				Trigger = new Trigger(TriggerType.CAST_SPELL)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = ComplexTask.Create(
						new GetGameTagTask(GameTag.TAG_LAST_KNOWN_COST_IN_HAND, EntityType.TARGET),
						new RandomMinionNumberTask(GameTag.COST),
						new SummonTask())
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_089] Wobbling Runts - COST:6 [ATK:2/HP:6] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon three 2/2 Runts.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOE_089", new Power {
				PowerTask = ComplexTask.Create(
							new SummonTask("LOE_089t", SummonSide.DEATHRATTLE),
							new SummonTask("LOE_089t2", SummonSide.DEATHRATTLE),
							new SummonTask("LOE_089t3", SummonSide.DEATHRATTLE))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_092] Arch-Thief Rafaam - COST:9 [ATK:7/HP:8] 
			// - Set: loe, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry: Discover</b> a powerful Artifact.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("LOE_092", new Power {
				// TODO [LOE_092] Arch-Thief Rafaam && Test: Arch-Thief Rafaam_LOE_092
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_107] Eerie Statue - COST:4 [ATK:7/HP:7] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: Can’t attack unless it’s the only minion in the battlefield.
			// --------------------------------------------------------
			cards.Add("LOE_107", new Power {
				// TODO [LOE_107] Eerie Statue && Test: Eerie Statue_LOE_107
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_110] Ancient Shade - COST:4 [ATK:7/HP:4] 
			// - Set: loe, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle an 'Ancient Curse' into your deck that deals 7 damage to you when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_110", new Power {
				PowerTask = new AddCardTo("LOE_110t", EntityType.DECK)
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOE_030e] Hollow (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Stats copied.
			// --------------------------------------------------------
			cards.Add("LOE_030e", new Power {
				// TODO [LOE_030e] Hollow && Test: Hollow_LOE_030e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOE_061e] Power of the Titans (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("LOE_061e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOE_061e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOE_073e] Fossilized (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Has <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("LOE_073e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOE_073e")
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOE_113e] Mrglllraawrrrglrur! (*) - COST:0 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("LOE_113e", new Power {
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOE_113e")
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_016t] Rock (*) - COST:1 [ATK:0/HP:6] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOE_016t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_019t2] Golden Monkey (*) - COST:4 [ATK:6/HP:6] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Replace your hand and deck with <b>Legendary</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOE_019t2", new Power {
				PowerTask = ComplexTask.Create(
					new ChangeEntityTask(EntityType.HAND, CardType.MINION, CardClass.INVALID, Rarity.LEGENDARY),
					new ChangeEntityTask(EntityType.DECK, CardType.MINION, CardClass.INVALID, Rarity.LEGENDARY))
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_024t] Rolling Boulder (*) - COST:4 [ATK:0/HP:4] 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: At the end of your turn, destroy the minion to the left.
			// --------------------------------------------------------
			cards.Add("LOE_024t", new Power {
				// TODO [LOE_024t] Rolling Boulder && Test: Rolling Boulder_LOE_024t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_089t] Rascally Runt (*) - COST:2 [ATK:2/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOE_089t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_089t2] Wily Runt (*) - COST:2 [ATK:2/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOE_089t2", null);

			// --------------------------------------- MINION - NEUTRAL
			// [LOE_089t3] Grumbly Runt (*) - COST:2 [ATK:2/HP:2] 
			// - Set: loe, 
			// --------------------------------------------------------
			cards.Add("LOE_089t3", null);

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOE_008] Eye of Hakkar (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Take a secret from your opponent's deck and put it into the battlefield.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOE_008", new Power {
				// TODO [LOE_008] Eye of Hakkar && Test: Eye of Hakkar_LOE_008
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOE_008H] Eye of Hakkar (*) - COST:1 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Take a secret from your opponent's deck and put it into the battlefield.
			// --------------------------------------------------------
			cards.Add("LOE_008H", new Power {
				// TODO [LOE_008H] Eye of Hakkar && Test: Eye of Hakkar_LOE_008H
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOE_019t] Map to the Golden Monkey (*) - COST:2 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: Shuffle the Golden Monkey into your deck. Draw a card.
			// --------------------------------------------------------
			cards.Add("LOE_019t", new Power {
				PowerTask = ComplexTask.Create(
					new AddCardTo("LOE_019t2", EntityType.DECK),
					new DrawTask())
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOE_110t] Ancient Curse (*) - COST:4 
			// - Set: loe, 
			// --------------------------------------------------------
			// Text: [x]You take 7 damage.
			//       Draw a card.
			//       Cast this when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("LOE_110t", new Power {
				TopdeckTask = ComplexTask.Create(
					new DamageTask(7, EntityType.HERO),
					new DrawTask()),
				PowerTask = ComplexTask.Create(
					new DamageTask(7, EntityType.HERO),
					new DrawTask())
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
