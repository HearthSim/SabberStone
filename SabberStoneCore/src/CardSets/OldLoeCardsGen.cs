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

//using System.Collections.Generic;
//using System.Linq;
//using SabberStoneCore.Conditions;
//using SabberStoneCore.Enchants;
//using SabberStoneCore.Enums;
//using SabberStoneCore.Tasks;
//using SabberStoneCore.Tasks.SimpleTasks;

//namespace SabberStoneCore.CardSets
//{
//	/// <summary>
//	/// League of Explorers cardset.
//	/// </summary>
//	public class LoeCardsGen
//	{
//		private static void Heroes(IDictionary<string, List<Power>> cards)
//		{
//		}

//		private static void HeroPowers(IDictionary<string, List<Power>> cards)
//		{
//		}

//		private static void Druid(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------------ SPELL - DRUID
//			// [LOE_115] Raven Idol - COST:1 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Choose One -</b>
//			//       <b>Discover</b> a minion; or <b>Discover</b> a spell.
//			// --------------------------------------------------------
//			// GameTag:
//			// - CHOOSE_ONE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TREASURE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_115",
//				//CHOOSE_ONE
//				null);

//			// ----------------------------------------- MINION - DRUID
//			// [LOE_050] Mounted Raptor - COST:3 [ATK:3/HP:2] 
//			// - Race: beast, Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Summon a random 1-Cost minion.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_050", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = ComplexTask.SummonRandomMinion(GameTag.COST, 1)
//				},
//			});

//			// ----------------------------------------- MINION - DRUID
//			// [LOE_051] Jungle Moonkin - COST:4 [ATK:4/HP:4] 
//			// - Race: beast, Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: Both players have
//			//       <b>Spell Damage +2</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - SPELLPOWER = 2
//			// --------------------------------------------------------
//			cards.Add("LOE_051", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.HEROES,
//					Activation = PowerActivation.BOARD_ZONE,
//					OldEnchant = Auras.SpellPowerDamage(2)
//				},
//			});

//		}

//		private static void DruidNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------------ SPELL - DRUID
//			// [LOE_115a] Raven Idol (*) - COST:0 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Discover</b> a minion.
//			// --------------------------------------------------------
//			cards.Add("LOE_115a", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = new DiscoverTask(DiscoverType.MINION),
//				}
//			});

//			// ------------------------------------------ SPELL - DRUID
//			// [LOE_115b] Raven Idol (*) - COST:0 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Discover</b> a spell.
//			// --------------------------------------------------------
//			cards.Add("LOE_115b", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = new DiscoverTask(DiscoverType.SPELL),
//				}
//			});

//		}

//		private static void Hunter(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------------- SPELL - HUNTER
//			// [LOE_021] Dart Trap - COST:2 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> After an opposing <b>Hero Power</b> is used, deal $5 damage to a random enemy. *spelldmg
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET_OR_QUEST = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_021", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.OP_CONTROLLER,
//					Activation = PowerActivation.SECRET_OR_QUEST,
//					OldTrigger = new TriggerBuilder().Create()
//						.EnableConditions(SelfCondition.IsSecretOrQuestActive)
//						.TriggerEffect(GameTag.HEROPOWER_ACTIVATIONS_THIS_TURN, 1)
//						.SingleTask(ComplexTask.Secret(
//							ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 5, true)))
//						.Build()
//				}
//			});

//			// ----------------------------------------- SPELL - HUNTER
//			// [LOE_105] Explorer's Hat - COST:2 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: Give a minion +1/+1 and "<b>Deathrattle:</b> Add an Explorer's Hat to your hand."
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			// RefTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_105", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = ComplexTask.Create(
//						new BuffTask(Buffs.AttackHealth(1), EntityType.TARGET),
//						new AddPowerTask(EntityType.TARGET, new Power
//						{
//							Activation = PowerActivation.DEATHRATTLE,
//							PowerTask = new AddCardTo("LOE_105", EntityType.HAND)
//						}))
//				},
//			});

//			// ---------------------------------------- MINION - HUNTER
//			// [LOE_020] Desert Camel - COST:3 [ATK:2/HP:4] 
//			// - Race: beast, Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Put a 1-Cost minion from each deck into the battlefield.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_020", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = ComplexTask.Create(
//						ComplexTask.SummonRandomMinion(EntityType.DECK, RelaCondition.IsOther(SelfCondition.IsMinion),
//							RelaCondition.IsOther(SelfCondition.IsTagValue(GameTag.COST, 1))),
//						ComplexTask.SummonOpRandomMinion(EntityType.OP_DECK, RelaCondition.IsOther(SelfCondition.IsMinion),
//							RelaCondition.IsOther(SelfCondition.IsTagValue(GameTag.COST, 1)))),
//				},
//			});

//		}

//		private static void HunterNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------- ENCHANTMENT - HUNTER
//			// [LOE_105e] Explorer's Hat (*) - COST:0 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: +1/+1. <b>Deathrattle:</b> Add an Explorer's Hat to your hand.
//			// --------------------------------------------------------
//			cards.Add("LOE_105e", null);
//		}

//		private static void Mage(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------------- SPELL - MAGE
//			// [LOE_002] Forgotten Torch - COST:3 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: Deal $3 damage. Shuffle a 'Roaring Torch' into your deck that deals 6 damage. *spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("LOE_002", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = ComplexTask.Create(
//						new DamageTask(3, EntityType.TARGET, true),
//						new AddCardTo("LOE_002t", EntityType.DECK)),
//				},
//			});

//			// ------------------------------------------ MINION - MAGE
//			// [LOE_003] Ethereal Conjurer - COST:5 [ATK:6/HP:3] 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Battlecry: Discover</b> a spell.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TREASURE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_003", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = new DiscoverTask(DiscoverType.SPELL)
//				},
//			});

//			// ------------------------------------------ MINION - MAGE
//			// [LOE_119] Animated Armor - COST:4 [ATK:4/HP:4] 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: Your hero can only take 1 damage at a time.
//			// --------------------------------------------------------
//			cards.Add("LOE_119", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.HERO,
//					Activation = PowerActivation.BOARD_ZONE,
//					OldTrigger = new TriggerBuilder().Create()
//						.EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
//						.FastExecution(true)
//						.TriggerEffect(GameTag.PREDAMAGE, 1)
//						.SingleTask(new SetGameTagTask(GameTag.PREDAMAGE, 1, EntityType.HERO))
//						.Build()
//				}
//			});

//		}

//		private static void MageNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------------- SPELL - MAGE
//			// [LOE_002t] Roaring Torch (*) - COST:3 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: Deal $6 damage. *spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("LOE_002t", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = new DamageTask(6, EntityType.TARGET, true),
//				},
//			});

//		}

//		private static void Paladin(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------------- SPELL - PALADIN
//			// [LOE_026] Anyfin Can Happen - COST:10 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: Summon 7 Murlocs that died this game.
//			// --------------------------------------------------------
//			cards.Add("LOE_026", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = ComplexTask.Create(
//						new IncludeTask(EntityType.GRAVEYARD),
//						new FilterStackTask(SelfCondition.IsMinion, SelfCondition.IsRace(Race.MURLOC)),
//						new RandomTask(7, EntityType.STACK),
//                        //new CopyTask(EntityType.STACK, 1),
//                        new SummonCopyTask(EntityType.STACK))}
//			});

//			// ---------------------------------------- SPELL - PALADIN
//			// [LOE_027] Sacred Trial - COST:1 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> After your opponent has at least 3 minions and plays another, destroy it.
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET_OR_QUEST = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_027", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.OP_BOARD,
//					Activation = PowerActivation.SECRET_OR_QUEST,
//					OldTrigger = new TriggerBuilder().Create()
//						.EnableConditions(SelfCondition.IsSecretOrQuestActive)
//						.ApplyConditions(RelaCondition.IsOther(SelfCondition.IsBoardCount(4)))
//						.TriggerEffect(GameTag.JUST_PLAYED, -1)
//						.SingleTask(ComplexTask.Secret(
//							new DestroyTask(EntityType.TARGET)))
//						.Build()
//				},
//			});

//			// --------------------------------------- MINION - PALADIN
//			// [LOE_017] Keeper of Uldaman - COST:4 [ATK:3/HP:4] 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Set a minion's Attack and Health to 3.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_IF_AVAILABLE = 0
//			// --------------------------------------------------------
//			cards.Add("LOE_017", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = ComplexTask.Create(
//						new SetAttackTask(3, EntityType.TARGET),
//						new SetHealthTask(3, EntityType.TARGET))
//				},
//			});

//		}

//		private static void PaladinNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------- ENCHANTMENT - PALADIN
//			// [LOE_017e] Watched (*) - COST:0 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: Stats changed to 3/3.
//			// --------------------------------------------------------
//			cards.Add("LOE_017e", null);

//		}

//		private static void Priest(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------------- SPELL - PRIEST
//			// [LOE_104] Entomb - COST:6 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: Choose an enemy minion.
//			//       Shuffle it into your deck.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_ENEMY_TARGET = 0
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("LOE_104", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = new MoveToDeck(EntityType.TARGET)
//				},
//			});

//			// ----------------------------------------- SPELL - PRIEST
//			// [LOE_111] Excavated Evil - COST:5 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: Deal $3 damage to all minions.
//			//       Shuffle this card into your opponent's deck. *spelldmg
//			// --------------------------------------------------------
//			cards.Add("LOE_111", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = ComplexTask.Create(
//						new DamageTask(3, EntityType.ALLMINIONS, true),
//						new AddCardTo("LOE_111", EntityType.OP_DECK)),
//				},
//			});

//			// ---------------------------------------- MINION - PRIEST
//			// [LOE_006] Museum Curator - COST:2 [ATK:1/HP:2] 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Battlecry: Discover</b> a <b>Deathrattle</b> card.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - DEATHRATTLE = 1
//			// - TREASURE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_006", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = new DiscoverTask(DiscoverType.DEATHRATTLE)
//				},
//			});

//		}

//		private static void Rogue(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------------- MINION - ROGUE
//			// [LOE_010] Pit Snake - COST:1 [ATK:2/HP:1] 
//			// - Race: beast, Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: Destroy any minion damaged by this minion.
//			// --------------------------------------------------------
//			// GameTag:
//			// - POISONOUS = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_010", null);

//			// ----------------------------------------- MINION - ROGUE
//			// [LOE_012] Tomb Pillager - COST:4 [ATK:5/HP:4] 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Add a Coin to your hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_012", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = new AddCardTo("GAME_005", EntityType.HAND),
//				},
//			});

//			// ----------------------------------------- MINION - ROGUE
//			// [LOE_019] Unearthed Raptor - COST:3 [ATK:3/HP:4] 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Choose a friendly minion. Gain a copy of its <b>Deathrattle</b> effect.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_FRIENDLY_TARGET = 0
//			// - REQ_TARGET_WITH_DEATHRATTLE = 0
//			// - REQ_TARGET_IF_AVAILABLE = 0
//			// --------------------------------------------------------
//			// RefTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_019", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = ComplexTask.Create(
//						new ConditionTask(EntityType.TARGET, SelfCondition.IsDeathrattleMinion),
//						new FlagTask(true, new CopyDeathrattleTask()))
//				},
//			});

//		}

//		private static void RogueNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------ ENCHANTMENT - ROGUE
//			// [LOE_019e] Unearthed Raptor (*) - COST:0 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			cards.Add("LOE_019e", null);

//		}

//		private static void Shaman(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------------- SPELL - SHAMAN
//			// [LOE_113] Everyfin is Awesome - COST:7 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: Give your minions +2/+2.
//			//       Costs (1) less for each Murloc you control.
//			// --------------------------------------------------------
//			cards.Add("LOE_113", new List<Power> {

//				new Power
//				{
//					Area = PowerArea.SELF,
//					Activation = PowerActivation.HAND_ZONE,
//					OldEnchant = new OldEnchant
//					{
//						EnableConditions = new List<SelfCondition>
//						{
//							SelfCondition.IsInZone(Zone.HAND)
//						},
//						Effects = new Dictionary<GameTag, int>
//						{
//							[GameTag.COST] = 0
//						},
//						ValueFunc = owner => -owner.Controller.BoardZone.Count(p => p.Card.Race == Race.MURLOC)
//					}
//				},
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = new BuffTask(Buffs.AttackHealth(2), EntityType.MINIONS)
//				},
//			});

//			// ---------------------------------------- MINION - SHAMAN
//			// [LOE_016] Rumbling Elemental - COST:4 [ATK:2/HP:6] 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: After you play a <b>Battlecry</b> minion, deal 2 damage to a random enemy.
//			// --------------------------------------------------------
//			// RefTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_016", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.BOARD,
//					Activation = PowerActivation.BOARD_ZONE,
//					OldTrigger = new TriggerBuilder().Create()
//						.EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
//						.ApplyConditions(RelaCondition.IsOther(SelfCondition.IsTagValue(GameTag.DEATHRATTLE, 1)))
//						.TriggerEffect(GameTag.SUMMONED, 1)
//						.SingleTask(ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 2))
//						.Build()
//				}
//			});

//			// ---------------------------------------- MINION - SHAMAN
//			// [LOE_018] Tunnel Trogg - COST:1 [ATK:1/HP:3] 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: Whenever you <b>Overload</b>, gain +1 Attack per locked Mana Crystal.
//			// --------------------------------------------------------
//			// RefTag:
//			// - OVERLOAD = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_018", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.CONTROLLER,
//					Activation = PowerActivation.BOARD_ZONE,
//					OldTrigger = new TriggerBuilder().Create()
//						.EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
//						.TriggerEffect(GameTag.OVERLOAD_OWED, 1)
//						.SingleTask(new BuffAttackNumberTask(EntityType.SOURCE))
//						.Build()
//				}
//			});

//		}

//		private static void ShamanNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------- ENCHANTMENT - SHAMAN
//			// [LOE_018e] Trogg No Stupid (*) - COST:0 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: Increased Attack.
//			// --------------------------------------------------------
//			cards.Add("LOE_018e", null);

//		}

//		private static void Warlock(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------------- SPELL - WARLOCK
//			// [LOE_007] Curse of Rafaam - COST:2 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: Give your opponent a 'Cursed!' card.
//			//       While they hold it, they take 2 damage on their turn.
//			// --------------------------------------------------------
//			cards.Add("LOE_007", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = new AddCardTo("LOE_007t", EntityType.OP_HAND)
//				},
//			});

//			// --------------------------------------- MINION - WARLOCK
//			// [LOE_023] Dark Peddler - COST:2 [ATK:2/HP:2] 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Battlecry: Discover</b> a
//			//       1-Cost card.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TREASURE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_023", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = new DiscoverTask(DiscoverType.ONE_COST),
//				},
//			});

//			// --------------------------------------- MINION - WARLOCK
//			// [LOE_116] Reliquary Seeker - COST:1 [ATK:1/HP:1] 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> If you have 6 other minions, gain +4/+4.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_116", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = ComplexTask.Create(
//						new ConditionTask(EntityType.SOURCE, SelfCondition.IsBoardCount(7)),
//						new FlagTask(true, new BuffTask(Buffs.AttackHealth(4), EntityType.SOURCE)))
//				}
//			});

//		}

//		private static void WarlockNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------------- SPELL - WARLOCK
//			// [LOE_007t] Cursed! (*) - COST:2 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: While this is in your hand, take 2 damage at the start of your turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ImmuneToSpellpower = 1
//			// - EVIL_GLOW = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_007t", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.CONTROLLER,
//					Activation = PowerActivation.HAND_ZONE,
//					OldTrigger = new TriggerBuilder().Create()
//						.EnableConditions(SelfCondition.IsInZone(Zone.HAND))
//						.TriggerEffect(GameTag.TURN_START, 1)
//						.SingleTask(new DamageTask(2, EntityType.HERO))
//						.Build()
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - WARLOCK
//			// [LOE_009e] Sinister Power (*) - COST:0 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: +4/+4.
//			// --------------------------------------------------------
//			cards.Add("LOE_009e", null);

//		}

//		private static void Warrior(IDictionary<string, List<Power>> cards)
//		{
//			// --------------------------------------- MINION - WARRIOR
//			// [LOE_009] Obsidian Destroyer - COST:7 [ATK:7/HP:7] 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: At the end of your turn, summon a 1/1 Scarab with <b>Taunt</b>.
//			// --------------------------------------------------------
//			// RefTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_009", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.CONTROLLER,
//					Activation = PowerActivation.BOARD_ZONE,
//					OldTrigger = new TriggerBuilder().Create()
//						.EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
//						.TriggerEffect(GameTag.TURN_START, -1)
//						.SingleTask(new SummonTask("LOE_009t", SummonSide.RIGHT))
//						.Build()
//				}
//			});

//			// --------------------------------------- MINION - WARRIOR
//			// [LOE_022] Fierce Monkey - COST:3 [ATK:3/HP:4] 
//			// - Race: beast, Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_022", null);

//			// --------------------------------------- WEAPON - WARRIOR
//			// [LOE_118] Cursed Blade - COST:1 [ATK:2/HP:0] 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: Double all damage dealt to your hero.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 3
//			// --------------------------------------------------------
//			cards.Add("LOE_118", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.HERO,
//					Activation = PowerActivation.WEAPON,
//					OldTrigger = new TriggerBuilder().Create()
//						.EnableConditions(SelfCondition.IsThisWeaponEquiped)
//						.FastExecution(true)
//						.TriggerEffect(GameTag.PREDAMAGE, 1)
//						.SingleTask(ComplexTask.Create(
//							new GetGameTagTask(GameTag.PREDAMAGE, EntityType.HERO),
//							new MathMultiplyTask(2),
//							new SetGameTagNumberTask(GameTag.PREDAMAGE, EntityType.HERO, true)))
//						.Build()
//				}
//			});

//		}

//		private static void WarriorNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------- ENCHANTMENT - WARRIOR
//			// [LOE_118e] Cursed Blade (*) - COST:0 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: Double all damage dealt to your hero.
//			// --------------------------------------------------------
//			cards.Add("LOE_118e", null);

//			// --------------------------------------- MINION - WARRIOR
//			// [LOE_009t] Scarab (*) - COST:1 [ATK:1/HP:1] 
//			// - Race: beast, Set: loe, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_009t", null);

//		}

//		private static void Neutral(IDictionary<string, List<Power>> cards)
//		{
//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_011] Reno Jackson - COST:6 [ATK:4/HP:6] 
//			// - Set: loe, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> If your deck has no duplicates, fully heal your hero.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_011", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = ComplexTask.Create(
//						new ConditionTask(EntityType.SOURCE, SelfCondition.IsNoDupeInDeck),
//						new FlagTask(true, new HealFullTask(EntityType.HERO)))
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_029] Jeweled Scarab - COST:2 [ATK:1/HP:1] 
//			// - Race: beast, Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Battlecry: Discover</b> a
//			//       3-Cost card.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TREASURE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_029", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = new DiscoverTask(DiscoverType.THREE_COST),
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_038] Naga Sea Witch - COST:8 [ATK:5/HP:5] 
//			// - Set: loe, Rarity: epic
//			// --------------------------------------------------------
//			// Text: Your cards cost (5).
//			// --------------------------------------------------------
//			// GameTag:
//			// - AURA = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_038", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.HAND,
//					Activation = PowerActivation.BOARD_ZONE,
//					OldEnchant = new OldEnchant
//					{
//						EnableConditions = new List<SelfCondition>
//						{
//							SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced
//						},
//						Effects = new Dictionary<GameTag, int>
//						{
//							[GameTag.COST] = 0
//						},
//						FixedValueFunc = owner => 5
//					}
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_039] Gorillabot A-3 - COST:4 [ATK:3/HP:4] 
//			// - Race: mechanical, Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> If you control another Mech, <b>Discover</b> a Mech.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TREASURE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_039", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = ComplexTask.Create(
//						new ConditionTask(EntityType.MINIONS_NOSOURCE, SelfCondition.IsControllingRace(Race.MECHANICAL)),
//						new FlagTask(true, new DiscoverTask(DiscoverType.MECHANICAL)))
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_046] Huge Toad - COST:2 [ATK:3/HP:2] 
//			// - Race: beast, Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Deal 1 damage to a random enemy.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_046", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1)
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_047] Tomb Spider - COST:4 [ATK:3/HP:3] 
//			// - Race: beast, Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Battlecry: Discover</b> a Beast.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TREASURE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_047", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = new DiscoverTask(DiscoverType.BEAST)
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_053] Djinni of Zephyrs - COST:5 [ATK:4/HP:6] 
//			// - Set: loe, Rarity: epic
//			// --------------------------------------------------------
//			// Text: After you cast a spell on another friendly minion, cast a copy of it on this one.
//			// --------------------------------------------------------
//			cards.Add("LOE_053", new List<Power> {
//				// TODO [LOE_053] Djinni of Zephyrs && Test: Djinni of Zephyrs_LOE_053
//				new Power
//				(
//					//Activation = null,
//					//SingleTask = null,
//				)
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_061] Anubisath Sentinel - COST:5 [ATK:4/HP:4] 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Give a random friendly minion +3/+3.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_061", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = ComplexTask.BuffRandomMinion(EntityType.MINIONS, Buffs.AttackHealth(3), new SelfCondition[] {})
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_073] Fossilized Devilsaur - COST:8 [ATK:8/HP:8] 
//			// - Set: loe, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> If you control a Beast, gain <b>Taunt</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_073", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = ComplexTask.Create(
//						new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingRace(Race.BEAST)),
//						new FlagTask(true, ComplexTask.Taunt(EntityType.SOURCE)))
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_076] Sir Finley Mrrgglton - COST:1 [ATK:1/HP:3] 
//			// - Race: murloc, Set: loe, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Battlecry: Discover</b> a new basic Hero Power.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TREASURE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_076", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = new DiscoverTask(DiscoverType.BASIC_HEROPOWERS)
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_077] Brann Bronzebeard - COST:3 [ATK:2/HP:4] 
//			// - Set: loe, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Your <b>Battlecries</b> trigger twice.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - AURA = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_077", new List<Power> {
//				new Power
//				{
//                    //Area = PowerArea.BOARD,
//                    //Activation = EnchantmentActivation.BOARD,
//                    //Enchant = Auras.SimpleInclSelf(GameTag.BATTLECRY, 1)
//                    Area = PowerArea.CONTROLLER,
//					Activation = PowerActivation.BOARD_ZONE,
//					OldEnchant = Auras.SimpleInclSelf(GameTag.EXTRA_BATTLECRY, 1)
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_079] Elise Starseeker - COST:4 [ATK:3/HP:5] 
//			// - Set: loe, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Shuffle the 'Map to the Golden Monkey'   into your deck.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_FRIENDLY_TARGET = 0
//			// --------------------------------------------------------
//			cards.Add("LOE_079", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = new AddCardTo("LOE_019t", EntityType.DECK),
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_086] Summoning Stone - COST:5 [ATK:0/HP:6] 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: Whenever you cast a spell, summon a random minion of the same Cost.
//			// --------------------------------------------------------
//			cards.Add("LOE_086", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.HAND,
//					Activation = PowerActivation.BOARD_ZONE,
//					OldTrigger = new TriggerBuilder().Create()
//						.EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
//						.ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsSpell))
//						.TriggerEffect(GameTag.JUST_PLAYED, 1)
//						.SingleTask(ComplexTask.Create(
//							new RandomMinionTask(GameTag.COST, EntityType.TARGET),
//							new SummonTask()))
//						.Build()
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_089] Wobbling Runts - COST:6 [ATK:2/HP:6] 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Summon three 2/2 Runts.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_089", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = ComplexTask.Create(
//							new SummonTask("LOE_089t", SummonSide.DEATHRATTLE),
//							new SummonTask("LOE_089t2", SummonSide.DEATHRATTLE),
//							new SummonTask("LOE_089t3", SummonSide.DEATHRATTLE))
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_092] Arch-Thief Rafaam - COST:9 [ATK:7/HP:8] 
//			// - Set: loe, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Battlecry: Discover</b> a powerful Artifact.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TREASURE = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_092", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = new DiscoverTask(DiscoverType.ARTIFACT)
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_107] Eerie Statue - COST:4 [ATK:7/HP:7] 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: Can't attack unless it's the only minion in the battlefield.
//			// --------------------------------------------------------
//			cards.Add("LOE_107", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BOARD_ZONE,
//					PowerTask = new AuraTask(
//						Auras.SimpleInclSelf(GameTag.CANT_ATTACK, 1,
//						RelaCondition.IsOther(SelfCondition.IsBoardCount(2, RelaSign.GEQ))),
//						AuraArea.SELF)
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_110] Ancient Shade - COST:4 [ATK:7/HP:4] 
//			// - Set: loe, Rarity: rare
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Shuffle an 'Ancient Curse' into your deck that deals 7 damage to you when drawn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_110", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = new AddCardTo("LOE_110t", EntityType.OP_DECK)
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOEA10_3] Murloc Tinyfin - COST:0 [ATK:1/HP:1] 
//			// - Race: murloc, Set: loe, Rarity: common
//			// --------------------------------------------------------
//			cards.Add("LOEA10_3", null);

//		}

//		private static void NeutralNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------------- SPELL - NEUTRAL
//			// [LOE_019t] Map to the Golden Monkey (*) - COST:2 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: Shuffle the Golden Monkey into your deck. Draw a card.
//			// --------------------------------------------------------
//			cards.Add("LOE_019t", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = new AddCardTo("LOE_019t2", EntityType.DECK),
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [LOE_110t] Ancient Curse (*) - COST:0 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: When you draw this, take 7 damage and draw a card.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ImmuneToSpellpower = 1
//			// - TOPDECK = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_110t", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.HAND_ZONE,
//					PowerTask = ComplexTask.Create(
//						new DamageTask(7, EntityType.HERO),
//						new MoveToGraveYard(EntityType.SOURCE),
//						new DrawTask())
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL		
//			// [LOEA16_3] Lantern of Power (*) - COST:10 		
//			// - Set: loe, 		
//			// --------------------------------------------------------		
//			// Text: Give a minion +10/+10.		
//			// --------------------------------------------------------		
//			// PlayReq:		
//			// - REQ_MINION_TARGET = 0		
//			// - REQ_TARGET_TO_PLAY = 0		
//			// --------------------------------------------------------		
//			cards.Add("LOEA16_3", new List<Power> {
//			   new Power
//			   {
//				   Activation = PowerActivation.SPELL,
//				   PowerTask = new BuffTask(Buffs.AttackHealth(10), EntityType.TARGET)
//			   },
//			});

//			// ---------------------------------------- SPELL - NEUTRAL		
//			// [LOEA16_4] Timepiece of Horror (*) - COST:10 		
//			// - Set: loe, 		
//			// --------------------------------------------------------		
//			// Text: Deal $10 damage randomly split among all enemies. *spelldmg		
//			// --------------------------------------------------------		
//			// GameTag:		
//			// - ImmuneToSpellpower = 1		
//			// --------------------------------------------------------		
//			cards.Add("LOEA16_4", new List<Power> {
//			   new Power
//			   {
//				   Activation = PowerActivation.SPELL,
//				   PowerTask = new EnqueueTask(10, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1), true)
//			   },
//			});

//			// ---------------------------------------- SPELL - NEUTRAL		
//			// [LOEA16_5] Mirror of Doom (*) - COST:10 		
//			// - Set: loe, 		
//			// --------------------------------------------------------		
//			// Text: Fill your board with 3/3 Mummy Zombies.		
//			// --------------------------------------------------------		
//			// PlayReq:		
//			// - REQ_NUM_MINION_SLOTS = 1		
//			// --------------------------------------------------------		
//			cards.Add("LOEA16_5", new List<Power> {

//			   new Power
//			   {
//				   Activation = PowerActivation.SPELL,
//				   PowerTask = new EnqueueTask(7, new SummonTask("LOEA16_5t", SummonSide.SPELL))
//			   },
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [LOE_030e] Hollow (*) - COST:0 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: Stats copied.
//			// --------------------------------------------------------
//			cards.Add("LOE_030e", null);

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [LOE_061e] Power of the Titans (*) - COST:0 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: +3/+3.
//			// --------------------------------------------------------
//			cards.Add("LOE_061e", null);

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [LOE_073e] Fossilized (*) - COST:0 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: Has <b>Taunt</b>.
//			// --------------------------------------------------------
//			cards.Add("LOE_073e", null);

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [LOE_113e] Mrglllraawrrrglrur! (*) - COST:0 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: +2/+2.
//			// --------------------------------------------------------
//			cards.Add("LOE_113e", null);

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_019t2] Golden Monkey (*) - COST:4 [ATK:6/HP:6] 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			//       <b>Battlecry:</b> Replace your hand and deck with <b>Legendary</b> minions.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("LOE_019t2", new List<Power> {
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = ComplexTask.Create(
//						new ReplaceTask(EntityType.DECK, Rarity.LEGENDARY),
//						new ReplaceTask(EntityType.HAND, Rarity.LEGENDARY)),
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_089t] Rascally Runt (*) - COST:2 [ATK:2/HP:2] 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			cards.Add("LOE_089t", null);

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_089t2] Wily Runt (*) - COST:2 [ATK:2/HP:2] 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			cards.Add("LOE_089t2", null);

//			// --------------------------------------- MINION - NEUTRAL
//			// [LOE_089t3] Grumbly Runt (*) - COST:2 [ATK:2/HP:2] 
//			// - Set: loe, 
//			// --------------------------------------------------------
//			cards.Add("LOE_089t3", null);

//			// --------------------------------------- MINION - NEUTRAL		
//			// [LOEA16_5t] Mummy Zombie (*) - COST:3 [ATK:3/HP:3] 		
//			// - Set: loe, 		
//			// --------------------------------------------------------		
//			cards.Add("LOEA16_5t", null);
//		}

//#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
//		public static void AddAll(Dictionary<string, Power> cards)
//#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
//		{
//			Heroes(cards);
//			HeroPowers(cards);
//			Druid(cards);
//			DruidNonCollect(cards);
//			Hunter(cards);
//			HunterNonCollect(cards);
//			Mage(cards);
//			MageNonCollect(cards);
//			Paladin(cards);
//			PaladinNonCollect(cards);
//			Priest(cards);
//			Rogue(cards);
//			RogueNonCollect(cards);
//			Shaman(cards);
//			ShamanNonCollect(cards);
//			Warlock(cards);
//			WarlockNonCollect(cards);
//			Warrior(cards);
//			WarriorNonCollect(cards);
//			Neutral(cards);
//			NeutralNonCollect(cards);
//		}
//	}
//}
