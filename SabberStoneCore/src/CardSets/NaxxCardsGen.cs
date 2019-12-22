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
using SabberStoneCore.Actions;
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

namespace SabberStoneCore.CardSets
{
	public class NaxxCardsGen
	{
		private static void Druid(Dictionary<string, CardDef> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [FP1_019] Poison Seeds - COST:4
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy all minions and summon 2/2 Treants to replace them.
			// --------------------------------------------------------
			cards.Add("FP1_019", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new CountTask(EntityType.MINIONS),
					new CountTask(EntityType.OP_MINIONS, 1),
					new DestroyTask(EntityType.ALLMINIONS, true),
					new EnqueueNumberTask(new SummonTask("FP1_019t")),
					new MathMultiplyTask(0),
					new MathNumberIndexTask(0, 1, MathOperation.ADD),
					new EnqueueNumberTask(new SummonOpTask("FP1_019t")))
			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [FP1_019t] Treant (*) - COST:1 [ATK:2/HP:2]
			// - Set: naxx,
			// --------------------------------------------------------
			cards.Add("FP1_019t", new CardDef());

		}

		private static void Hunter(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [FP1_011] Webspinner - COST:1 [ATK:1/HP:1]
			// - Race: beast, Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Beast card to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_011", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomMinionTask(GameTag.CARDRACE, (int)Race.BEAST),
					new AddStackTo(EntityType.HAND))
			}));

		}

		private static void Mage(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [FP1_018] Duplicate - COST:3
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a friendly minion dies, put 2 copies of it into your hand.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("FP1_018", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsHandFull),
						new FlagTask(false, ComplexTask.Secret(
							new CopyTask(EntityType.TARGET, Zone.HAND, 2))))
				}
			}));

		}

		private static void Paladin(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- SPELL - PALADIN
			// [FP1_020] Avenge - COST:1
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions dies, give a random friendly minion +3/+2.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("FP1_020", new CardDef(new Power
			{
				InfoCardId = "FP1_020e",
				Trigger = new Trigger(TriggerType.DEATH)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsBoardCount(0)),
						new FlagTask(false, ComplexTask.Secret(
							new RandomTask(1, EntityType.MINIONS),
							new AddEnchantmentTask("FP1_020e", EntityType.STACK))))
				}
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [FP1_020e] Vengeance (*) - COST:0
			// - Set: naxx,
			// --------------------------------------------------------
			// Text: +3/+2.
			// --------------------------------------------------------
			cards.Add("FP1_020e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("FP1_020e")
			}));

		}

		private static void Priest(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [FP1_023] Dark Cultist - COST:3 [ATK:3/HP:4]
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give a random friendly minion +3 Health.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_023", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new RandomTask(1, EntityType.MINIONS),
					new AddEnchantmentTask("FP1_023e", EntityType.TARGET))
			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [FP1_023e] Power of the Ziggurat (*) - COST:0
			// - Set: naxx,
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("FP1_023e", new CardDef(new Power
			{
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("FP1_023e")
			}));

		}

		private static void Rogue(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [FP1_026] Anub'ar Ambusher - COST:4 [ATK:5/HP:5]
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return a random friendly minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_026", new CardDef(new Power
			{
				// TODO AnubarAmbusher_FP1_026 test
				DeathrattleTask = ComplexTask.Create(
					new RandomTask(1, EntityType.MINIONS),
					new ReturnHandTask(EntityType.STACK))
			}));

		}

		private static void Shaman(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- SPELL - SHAMAN
			// [FP1_025] Reincarnate - COST:2
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a minion, then return it to life with full Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("FP1_025", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				PowerTask = ComplexTask.Create(
					new DestroyTask(EntityType.TARGET, true),
					new CopyTask(EntityType.TARGET, Zone.PLAY))
			}));

		}

		private static void Warlock(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [FP1_022] Voidcaller - COST:4 [ATK:3/HP:4]
			// - Race: demon, Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Put a random Demon from your hand into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_022", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.HAND),
					new FilterStackTask(SelfCondition.IsRace(Race.DEMON)),
					new RandomTask(1, EntityType.STACK),
					new SummonTask())
			}));

		}

		private static void Warrior(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- WEAPON - WARRIOR
			// [FP1_021] Death's Bite - COST:4 [ATK:4/HP:0]
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 1 damage to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_021", new CardDef(new Power
			{
				DeathrattleTask = new DamageTask(1, EntityType.ALLMINIONS)
			}));

		}

		private static void Neutral(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [FP1_001] Zombie Chow - COST:1 [ATK:2/HP:3]
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Restore 5 Health to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_001", new CardDef(new Power
			{
				DeathrattleTask = new HealTask(5, EntityType.OP_HERO)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_002] Haunted Creeper - COST:2 [ATK:1/HP:2]
			// - Race: beast, Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 1/1 Spectral Spiders.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_002", new CardDef(new Power
			{
				DeathrattleTask = new EnqueueTask(2, new SummonTask("FP1_002t", SummonSide.DEATHRATTLE))
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_003] Echoing Ooze - COST:2 [ATK:1/HP:2]
			// - Set: naxx, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon an exact copy of this minion at the end of the turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("FP1_003", new CardDef(new Power
			{
				PowerTask = ComplexTask.Create(
					new SetGameTagTask(GameTag.CUSTOM_KEYWORD_EFFECT, 1, EntityType.SOURCE),
					new SetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, 1, EntityType.SOURCE),
					new SetGameTagTask(GameTag.MULTIPLY_BUFF_VALUE, 1, EntityType.SOURCE)),
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					SingleTask = ComplexTask.Create(
						new ConditionTask(EntityType.SOURCE, SelfCondition.IsTagValue(GameTag.CUSTOM_KEYWORD_EFFECT, 1)),
						new FlagTask(true, ComplexTask.Create(
							new SetGameTagTask(GameTag.CUSTOM_KEYWORD_EFFECT, 0, EntityType.SOURCE),
							new SummonCopyTask(EntityType.SOURCE, side: SummonSide.RIGHT)))),
					RemoveAfterTriggered = true
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_004] Mad Scientist - COST:2 [ATK:2/HP:2]
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Put a <b>Secret</b> from your deck into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("FP1_004", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.PutSecretFromDeck
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_005] Shade of Naxxramas - COST:3 [ATK:2/HP:2]
			// - Set: naxx, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Stealth.</b> At the start of your turn, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("FP1_005", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = new AddEnchantmentTask("FP1_005e", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_007] Nerubian Egg - COST:2 [ATK:0/HP:2]
			// - Set: naxx, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 4/4 Nerubian.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_007", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("FP1_007t", SummonSide.DEATHRATTLE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_008] Spectral Knight - COST:5 [ATK:4/HP:6]
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("FP1_008", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_009] Deathlord - COST:3 [ATK:2/HP:8]
			// - Set: naxx, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt. Deathrattle:</b> Your opponent puts a minion from their deck into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_009", new CardDef(new Power
			{
				DeathrattleTask = ComplexTask.Create(
					new IncludeTask(EntityType.OP_DECK),
					new FilterStackTask(SelfCondition.IsMinion),
					new RandomTask(1, EntityType.STACK),
					new SummonStackTask())
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_010] Maexxna - COST:6 [ATK:2/HP:8]
			// - Race: beast, Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("FP1_010", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_012] Sludge Belcher - COST:5 [ATK:3/HP:5]
			// - Set: naxx, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt
			//       Deathrattle:</b> Summon a 1/2 Slime with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_012", new CardDef(new Power
			{
				DeathrattleTask = new SummonTask("FP1_012t", SummonSide.DEATHRATTLE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_013] Kel'Thuzad - COST:8 [ATK:6/HP:8]
			// - Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of each turn, summon all friendly minions that died this turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("FP1_013", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_END)
				{
					EitherTurn = true,
					SingleTask = ComplexTask.SummonAllFriendlyDiedThisTurn()
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_014] Stalagg - COST:5 [ATK:7/HP:4]
			// - Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If Feugen also died this game, summon Thaddius.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_014", new CardDef(new Power
			{
				DeathrattleTask = new FuncNumberTask(src =>
				{
					Controller c = src.Controller;
					if ((c.GraveyardZone.Any(p => p.Card.AssetId == 1797 && p.ToBeDestroyed) ||
						 c.Opponent.GraveyardZone.Any(p => p.Card.AssetId == 1797 && p.ToBeDestroyed)) &&
						!c.BoardZone.IsFull)
						Generic.SummonBlock.Invoke(c.Game, (Minion)Entity.FromCard(c, Cards.FromId("FP1_014t")), -1, src);

					return 0;
				})
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_015] Feugen - COST:5 [ATK:4/HP:7]
			// - Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If Stalagg also died this game, summon Thaddius.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_015", new CardDef(new Power
			{
				DeathrattleTask = new FuncNumberTask(src =>
				{
					Controller c = src.Controller;
					if ((c.GraveyardZone.Any(p => p.Card.AssetId == 1796 && p.ToBeDestroyed) ||
						 c.Opponent.GraveyardZone.Any(p => p.Card.AssetId == 1796 && p.ToBeDestroyed)) &&
						!c.BoardZone.IsFull)
						Generic.SummonBlock.Invoke(c.Game, (Minion)Entity.FromCard(c, Cards.FromId("FP1_014t")), -1, src);

					return 0;
				})
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_016] Wailing Soul - COST:4 [ATK:3/HP:5]
			// - Set: naxx, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry: Silence</b> your other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("FP1_016", new CardDef(new Power
			{
				PowerTask = new SilenceTask(EntityType.MINIONS_NOSOURCE)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_017] Nerub'ar Weblord - COST:2 [ATK:1/HP:4]
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: Minions with <b>Battlecry</b> cost (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("FP1_017", new CardDef(new Power
			{
				Aura = new Aura(AuraType.HANDS, Effects.AddCost(2))
				{
					Condition = SelfCondition.IsBattlecryMinion
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_024] Unstable Ghoul - COST:2 [ATK:1/HP:3]
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Deathrattle:</b> Deal 1 damage to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_024", new CardDef(new Power
			{
				DeathrattleTask = new DamageTask(1, EntityType.ALLMINIONS)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_027] Stoneskin Gargoyle - COST:3 [ATK:1/HP:4]
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of your turn, restore this minion to full Health.
			// --------------------------------------------------------
			cards.Add("FP1_027", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = new HealFullTask(EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_028] Undertaker - COST:1 [ATK:1/HP:2]
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you summon a minion with <b>Deathrattle</b>, gain +1 Attack.
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_028", new CardDef(new Power
			{
				Trigger = new Trigger(TriggerType.SUMMON)
				{
					TriggerSource = TriggerSource.FRIENDLY,
					Condition = SelfCondition.IsDeathrattleMinion,
					SingleTask = new AddEnchantmentTask("FP1_028e", EntityType.SOURCE)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_029] Dancing Swords - COST:3 [ATK:4/HP:4]
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Your opponent draws a card.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_029", new CardDef(new Power
			{
				DeathrattleTask = new DrawOpTask()
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_030] Loatheb - COST:5 [ATK:5/HP:5]
			// - Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Enemy spells cost (5) more next turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("FP1_030", new CardDef(new Power
			{
				PowerTask = new AddEnchantmentTask("FP1_030e", EntityType.OP_CONTROLLER)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_031] Baron Rivendare - COST:4 [ATK:1/HP:7]
			// - Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your minions trigger their <b>Deathrattles</b> twice.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_031", new CardDef(new Power
			{
				Aura = new Aura(AuraType.CONTROLLER, new Effect(GameTag.EXTRA_MINION_DEATHRATTLES_BASE, EffectOperator.SET, 1))
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FP1_005e] Consume (*) - COST:0
			// - Set: naxx,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("FP1_005e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.AttackHealth_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FP1_028e] Darkness Calls (*) - COST:0
			// - Set: naxx,
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("FP1_028e", new CardDef(new Power
			{
				Enchant = new OngoingEnchant(Effects.Attack_N(1))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FP1_030e] Necrotic Aura (*) - COST:0
			// - Set: naxx,
			// --------------------------------------------------------
			// Text: Your spells cost (5) more this turn.
			// --------------------------------------------------------
			cards.Add("FP1_030e", new CardDef(new Power
			{
				Aura = new Aura(AuraType.OP_HAND, Effects.AddCost(5))
				{
					Condition = SelfCondition.IsSpell,
					RemoveTrigger = (TriggerType.TURN_END, SelfCondition.IsOpTurn)
				}
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_002t] Spectral Spider (*) - COST:1 [ATK:1/HP:1]
			// - Set: naxx,
			// --------------------------------------------------------
			cards.Add("FP1_002t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_006] Deathcharger (*) - COST:1 [ATK:2/HP:3]
			// - Set: naxx,
			// --------------------------------------------------------
			// Text: <b>Charge. Deathrattle:</b> Deal 3 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_006", new CardDef(new Power
			{
				DeathrattleTask = new DamageTask(3, EntityType.HERO)
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_007t] Nerubian (*) - COST:4 [ATK:4/HP:4]
			// - Set: naxx,
			// --------------------------------------------------------
			cards.Add("FP1_007t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_012t] Slime (*) - COST:1 [ATK:1/HP:2]
			// - Set: naxx,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("FP1_012t", new CardDef());

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_014t] Thaddius (*) - COST:10 [ATK:11/HP:11]
			// - Set: naxx,
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("FP1_014t", new CardDef());

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
		{
			Druid(cards);
			DruidNonCollect(cards);
			Hunter(cards);
			Mage(cards);
			Paladin(cards);
			PaladinNonCollect(cards);
			Priest(cards);
			PriestNonCollect(cards);
			Rogue(cards);
			Shaman(cards);
			Warlock(cards);
			Warrior(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
