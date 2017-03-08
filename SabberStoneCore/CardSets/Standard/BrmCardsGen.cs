using System.Collections.Generic;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Model;

namespace SabberStoneCore.CardSets.Standard
{
	public class BrmCardsGen
	{
		private static void Heroes(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- HERO - NEUTRAL
			// [BRM_027h] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:8] 
			// - Set: fp2, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2319
			// --------------------------------------------------------
			cards.Add("BRM_027h", null);

		}

		private static void HeroPowers(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRM_027p] DIE, INSECT! (*) - COST:2 
			// - Set: fp2, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $8 damage to a random enemy. *spelldmg
			// --------------------------------------------------------
			cards.Add("BRM_027p", new List<Enchantment> {
				new Enchantment
                {
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 8)
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRM_027pH] DIE, INSECTS! (*) - COST:2 
			// - Set: fp2, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $8 damage to a random enemy. TWICE. *spelldmg
			// --------------------------------------------------------
			cards.Add("BRM_027pH", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(2, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 8))
                }
            });

		}

		private static void Druid(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [BRM_009] Volcanic Lumberer - COST:9 [ATK:7/HP:8] 
			// - Set: fp2, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Costs (1) less for each minion that died this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BRM_009", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.HAND,
                    Enchant = Auras.CostFunc(
                        owner => -(owner.Controller.NumFriendlyMinionsThatDiedThisTurn +
                                   owner.Controller.Opponent.NumFriendlyMinionsThatDiedThisTurn))
                }
            });

			// ----------------------------------------- MINION - DRUID
			// [BRM_010] Druid of the Flame - COST:3 [ATK:2/HP:2] 
			// - Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Transform into a 5/2 minion; or a 2/5 minion.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("BRM_010",
                //CHOOSE_ONE
                null);

        }

		private static void DruidNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [BRM_010a] Firecat Form (*) - COST:0 
			// - Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: Transform into a 5/2 minion.
			// --------------------------------------------------------
			cards.Add("BRM_010a", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new TransformTask("BRM_010t", EntityType.SOURCE)
                },
            });

			// ------------------------------------------ SPELL - DRUID
			// [BRM_010b] Fire Hawk Form (*) - COST:0 
			// - Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: Transform into a 2/5 minion.
			// --------------------------------------------------------
			cards.Add("BRM_010b", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new TransformTask("BRM_010t2", EntityType.SOURCE)
                }
            });

			// ----------------------------------------- MINION - DRUID
			// [BRM_010t] Druid of the Flame (*) - COST:3 [ATK:5/HP:2] 
			// - Race: beast, Set: fp2, Rarity: common
			// --------------------------------------------------------
			cards.Add("BRM_010t", null);

			// ----------------------------------------- MINION - DRUID
			// [BRM_010t2] Druid of the Flame (*) - COST:3 [ATK:2/HP:5] 
			// - Race: beast, Set: fp2, Rarity: common
			// --------------------------------------------------------
			cards.Add("BRM_010t2", null);

            // ----------------------------------------- MINION - DRUID
            // [OG_044b] Druid of the Flame (*) - COST:3 [ATK:5/HP:5] 
            // - Race: beast, Set: fp2, Rarity: common
            // --------------------------------------------------------
            cards.Add("OG_044b", new List<Enchantment> {
				// TODO [OG_044b] Druid of the Flame && Test: Druid of the Flame_OG_044b
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Hunter(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - HUNTER
			// [BRM_013] Quick Shot - COST:2 
			// - Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage.
			//       If your hand is empty, draw a card. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BRM_013", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DamageTask(3, EntityType.TARGET, true),
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsHandEmpty),
                        new FlagTask(true, new DrawTask()))
				},
			});

			// ---------------------------------------- MINION - HUNTER
			// [BRM_014] Core Rager - COST:4 [ATK:4/HP:4] 
			// - Race: beast, Set: fp2, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your hand is empty, gain +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_014", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsHandEmpty),
                        new FlagTask(true, new BuffTask(Buffs.AttackHealth(3), EntityType.SOURCE)))
				},
			});

		}

		private static void HunterNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [BRM_014e] Power Rager (*) - COST:0 
			// - Set: fp2, 
			// --------------------------------------------------------
			// Text: +3/+3
			// --------------------------------------------------------
			cards.Add("BRM_014e", null);

		}

		private static void Mage(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [BRM_003] Dragon's Breath - COST:5 
			// - Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage. Costs (1) less for each minion that died this turn. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BRM_003", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.HAND,
                    Enchant = Auras.CostFunc(
                        owner => -(owner.Controller.NumFriendlyMinionsThatDiedThisTurn +
                                   owner.Controller.Opponent.NumFriendlyMinionsThatDiedThisTurn))
                },
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(4, EntityType.TARGET, true)
                }
            });

			// ------------------------------------------ MINION - MAGE
			// [BRM_002] Flamewaker - COST:3 [ATK:2/HP:4] 
			// - Set: fp2, Rarity: rare
			// --------------------------------------------------------
			// Text: After you cast a spell, deal 2 damage randomly split among all enemies.
			// --------------------------------------------------------
			cards.Add("BRM_002", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new EnqueueTask(2, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1)))
                        .Build()
                }
            });

		}

		private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [BRM_003e] Dragon's Might (*) - COST:0 
			// - Set: fp2, 
			// --------------------------------------------------------
			// Text: Costs (3) less this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("BRM_003e", null);

        }

		private static void Paladin(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - PALADIN
			// [BRM_001] Solemn Vigil - COST:5 
			// - Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 cards. Costs (1) less for each minion that died this turn.
			// --------------------------------------------------------
			cards.Add("BRM_001", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.HAND,
                    Enchant = Auras.CostFunc(
                        owner => -(owner.Controller.NumFriendlyMinionsThatDiedThisTurn +
                                   owner.Controller.Opponent.NumFriendlyMinionsThatDiedThisTurn))
                },
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(2, new DrawTask())
                },
            });

			// --------------------------------------- MINION - PALADIN
			// [BRM_018] Dragon Consort - COST:5 [ATK:5/HP:5] 
			// - Race: dragon, Set: fp2, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> The next Dragon you play costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_018", new List<Enchantment> {
				// TODO [BRM_018] Dragon Consort && Test: Dragon Consort_BRM_018
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void PaladinNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [BRM_018e] Unchained! (*) - COST:0 
			// - Set: fp2, 
			// --------------------------------------------------------
			// Text: Your next Dragon costs (2) less.
			// --------------------------------------------------------
			cards.Add("BRM_018e", null);

        }

		private static void Priest(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - PRIEST
			// [BRM_017] Resurrect - COST:2 
			// - Set: fp2, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a random friendly minion that died this game.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			cards.Add("BRM_017", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.SummonRandomMinionThatDied(),
				},
			});

			// ---------------------------------------- MINION - PRIEST
			// [BRM_004] Twilight Whelp - COST:1 [ATK:2/HP:1] 
			// - Race: dragon, Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_004", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
                        new FlagTask(true, new BuffTask(Buffs.Health(2), EntityType.SOURCE)))
				},
			});

		}

		private static void PriestNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BRM_001e] Melt (*) - COST:0 
			// - Set: fp2, 
			// --------------------------------------------------------
			// Text: Attack changed to 0 this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("BRM_001e", null);

		}

		private static void Rogue(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [BRM_007] Gang Up - COST:2 
			// - Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: Choose a minion. Shuffle 3 copies of it into your deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BRM_007", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new CopyTask(EntityType.TARGET, 3),
                        new AddStackTo(EntityType.DECK))
				},
			});

			// ----------------------------------------- MINION - ROGUE
			// [BRM_008] Dark Iron Skulker - COST:5 [ATK:4/HP:3] 
			// - Set: fp2, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage to all undamaged enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_008", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.OP_MINIONS),
                        new FilterStackTask(SelfCondition.IsUndamaged),
                        new DamageTask(2, EntityType.STACK))
				},
			});

		}

		private static void Shaman(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - SHAMAN
			// [BRM_011] Lava Shock - COST:2 
			// - Set: fp2, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage.
			//       Unlock your <b>Overloaded</b> Mana Crystals. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("BRM_011", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DamageTask(2, EntityType.TARGET),
                        new SetControllerGameTagTask(GameTag.OVERLOAD_LOCKED, 0)),
				},
			});

			// ---------------------------------------- MINION - SHAMAN
			// [BRM_012] Fireguard Destroyer - COST:4 [ATK:3/HP:6] 
			// - Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain 1-4 Attack. <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - BATTLECRY = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			cards.Add("BRM_012", new List<Enchantment> {
				// TODO [BRM_012] Fireguard Destroyer && Test: Fireguard Destroyer_BRM_012
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void ShamanNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [BRM_011t] Lava Shock (*) - COST:0 
			// - Set: fp2, 
			// --------------------------------------------------------
			// Text: Cards you play this turn don't cause <b>Overload</b>.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("BRM_011t", null);

        }

		private static void Warlock(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARLOCK
			// [BRM_005] Demonwrath - COST:3 
			// - Set: fp2, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to all non-Demon minions. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("BRM_005", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.ALLMINIONS),
                        new FilterStackTask(SelfCondition.IsNotRace(Race.DEMON)),
                        new DamageTask(2, EntityType.STACK, true))
				},
			});

			// --------------------------------------- MINION - WARLOCK
			// [BRM_006] Imp Gang Boss - COST:3 [ATK:2/HP:4] 
			// - Race: demon, Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, summon a 1/1 Imp.
			// --------------------------------------------------------
			cards.Add("BRM_006", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsTagValue(GameTag.TO_BE_DESTROYED, 0)))
                        .TriggerEffect(GameTag.DAMAGE, 1)
                        .SingleTask(new SummonTask("BRM_006t"))
                        .Build()
                }
            });

		}

		private static void WarlockNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [BRM_006t] Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Set: fp2, 
			// --------------------------------------------------------
			cards.Add("BRM_006t", null);

		}

		private static void Warrior(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [BRM_015] Revenge - COST:2 
			// - Set: fp2, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $1 damage to all minions. If you have 12 or less Health, deal $3 damage instead. *spelldmg
			// --------------------------------------------------------
			cards.Add("BRM_015", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new ConditionTask(EntityType.HERO, SelfCondition.IsHealth(12, RelaSign.LEQ))),
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [BRM_016] Axe Flinger - COST:4 [ATK:2/HP:5] 
			// - Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, deal 2 damage to the enemy hero.
			// --------------------------------------------------------
			cards.Add("BRM_016", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsTagValue(GameTag.TO_BE_DESTROYED, 0)))
                        .TriggerEffect(GameTag.DAMAGE, 1)
                        .SingleTask(new DamageTask(2, EntityType.OP_HERO))
                        .Build()
                }
            });

		}

		private static void Neutral(IDictionary<string, List<Enchantment>> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [BRM_019] Grim Patron - COST:5 [ATK:3/HP:3] 
			// - Set: fp2, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever this minion survives damage, summon another Grim Patron.
			// --------------------------------------------------------
			cards.Add("BRM_019", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsTagValue(GameTag.TO_BE_DESTROYED, 0)))
                        .TriggerEffect(GameTag.DAMAGE, 1)
                        .SingleTask(new SummonTask("BRM_019"))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_020] Dragonkin Sorcerer - COST:4 [ATK:3/HP:5] 
			// - Race: dragon, Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever <b>you</b> target this minion with a spell, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("BRM_020", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = Triggers.FriendlySpellTargetingMe(new BuffTask(Buffs.AttackHealth(1), EntityType.SOURCE))
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_022] Dragon Egg - COST:1 [ATK:0/HP:2] 
			// - Set: fp2, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, summon a 2/1 Whelp.
			// --------------------------------------------------------
			cards.Add("BRM_022", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.DAMAGE, 1)
                        .SingleTask(new SummonTask("BRM_004t"))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_024] Drakonid Crusher - COST:6 [ATK:6/HP:6] 
			// - Race: dragon, Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your opponent has 15 or less Health, gain +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_024", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new ConditionTask(EntityType.OP_HERO, SelfCondition.IsHealth(15, RelaSign.LEQ)),
                        new FlagTask(true, new BuffTask(Buffs.AttackHealth(2), EntityType.SOURCE)))
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_025] Volcanic Drake - COST:6 [ATK:6/HP:4] 
			// - Race: dragon, Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: Costs (1) less for each minion that died this turn.
			// --------------------------------------------------------
			cards.Add("BRM_025", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.HAND,
                    Enchant = Auras.CostFunc(
                        owner => -(owner.Controller.NumFriendlyMinionsThatDiedThisTurn +
                                   owner.Controller.Opponent.NumFriendlyMinionsThatDiedThisTurn))
                }
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_026] Hungry Dragon - COST:4 [ATK:5/HP:6] 
			// - Race: dragon, Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a random 1-Cost minion for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_026", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new RandomMinionTask(GameTag.COST, 1),
                        new SummonOpTask()),
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_027] Majordomo Executus - COST:9 [ATK:9/HP:7] 
			// - Set: fp2, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Replace your hero with Ragnaros, the Firelord.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BRM_027", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = new ReplaceHeroTask("BRM_027h", "BRM_027p"),
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_028] Emperor Thaurissan - COST:6 [ATK:5/HP:5] 
			// - Set: fp2, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, reduce the Cost of cards in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRM_028", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(new BuffTask(Buffs.Cost(-1), EntityType.HAND))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_029] Rend Blackhand - COST:7 [ATK:8/HP:4] 
			// - Set: fp2, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy a <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// - REQ_LEGENDARY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BRM_029", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new DestroyTask(EntityType.TARGET)
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_030] Nefarian - COST:9 [ATK:8/HP:8] 
			// - Race: dragon, Set: fp2, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add 2 random spells to your hand <i>(from your opponent's class)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_030", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new EnqueueTask(2, ComplexTask.Create(
                        new RandomCardTask(EntityType.OP_HERO),
                        new AddStackTo(EntityType.HAND))),
                }
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_031] Chromaggus - COST:8 [ATK:6/HP:8] 
			// - Race: dragon, Set: fp2, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you draw a card, put another copy into your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRM_031", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsNotDead, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.LAST_CARD_DRAWN, 0)
                        .SingleTask(ComplexTask.Create(
                            new IncludeTask(EntityType.SOURCE),
                            new FuncPlayablesTask(p =>
                            {
                                var controller = p[0].Controller;
                                return new List<IPlayable> { controller.Game.IdEntityDic[controller.LastCardDrawn] };
                            }),
                            new CopyTask(EntityType.STACK, 1),
                            new AddStackTo(EntityType.HAND)))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_033] Blackwing Technician - COST:3 [ATK:2/HP:4] 
			// - Fac: neutral, Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRM_033", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
                        new FlagTask(true, new BuffTask(Buffs.AttackHealth(1), EntityType.SOURCE)))
                },
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_034] Blackwing Corruptor - COST:5 [ATK:5/HP:4] 
			// - Fac: neutral, Set: fp2, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, deal 3 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// --------------------------------------------------------
			cards.Add("BRM_034", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
                        new FlagTask(true, new DamageTask(3, EntityType.TARGET)))
                },
			});

		}

		private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [BRM_004t] Whelp (*) - COST:1 [ATK:1/HP:1] 
			// - Set: fp2, 
			// --------------------------------------------------------
			cards.Add("BRM_004t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [BRM_022t] Black Whelp (*) - COST:1 [ATK:2/HP:1] 
			// - Race: dragon, Set: fp2, Rarity: common
			// --------------------------------------------------------
			cards.Add("BRM_022t", null);

		}

		public static void AddAll(Dictionary<string, List<Enchantment>> cards)
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
			Shaman(cards);
			ShamanNonCollect(cards);
			Warlock(cards);
			WarlockNonCollect(cards);
			Warrior(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
