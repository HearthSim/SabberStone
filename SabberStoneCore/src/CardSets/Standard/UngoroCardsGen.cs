using System.Collections.Generic;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCore.CardSets.Standard
{
    public class UngoroCardsGen
    {
        private static void HeroPowers(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------ HERO_POWER - HUNTER
            // [UNG_917t1] Dinomancy (*) - COST:2 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Give a Beast +2/+2.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_WITH_RACE = 20
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_917t1", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackHealth(2), EEntityType.TARGET)
                }
            });

            // ----------------------------------- HERO_POWER - NEUTRAL
            // [UNG_934t2] DIE, INSECT! (*) - COST:2 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Deal 8 damage to a random enemy.
            // --------------------------------------------------------
            cards.Add("UNG_934t2", new List<Enchantment> {
				new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.DamageRandomTargets(1, EEntityType.ENEMIES, 8)
				}
			});

		}

        private static void Druid(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------------- MINION - DRUID
            // [UNG_078] Tortollan Forager - COST:2 [ATK:2/HP:2] 
            // - Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Add a random minion with 5 or more Attack to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_078", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RandomMinionTask(EGameTag.ATK, 5, 1, ERelaSign.GEQ),
                        new AddStackTo(EEntityType.HAND))
                },
            });

            // ----------------------------------------- MINION - DRUID
            // [UNG_086] Giant Anaconda - COST:7 [ATK:5/HP:3] 
            // - Race: beast, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Summon a minion from your hand with 5 or more Attack.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_086", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.HAND),
                        new FilterStackTask(SelfCondition.IsMinion, SelfCondition.IsTagValue(EGameTag.ATK, 5, ERelaSign.GEQ)),
                        new RandomTask(1, EEntityType.STACK),
                        new RemoveFromHand(EEntityType.STACK),
                        new SummonTask()),
                },
            });

            // ----------------------------------------- MINION - DRUID
            // [UNG_100] Verdant Longneck - COST:5 [ATK:5/HP:4] 
            // - Race: beast, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> <b>Adapt</b>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_100", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new AdaptTask(EEntityType.SOURCE)
                },
            });

            // ----------------------------------------- MINION - DRUID
            // [UNG_101] Shellshifter - COST:4 [ATK:3/HP:3] 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: [x]<b>Choose One - </b>Transform
            //       into a 5/3 with <b>Stealth</b>;
            //       or a 3/5 with <b>Taunt</b>.
            // --------------------------------------------------------
            // GameTag:
            // - CHOOSE_ONE = 1
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("UNG_101", new List<Enchantment>
            {
                new Enchantment
                {
                    // CHOOSE_ONE, Choose Both option
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new TransformTask("UNG_101t3", EEntityType.SOURCE)
                }
            });

            // ----------------------------------------- MINION - DRUID
            // [UNG_109] Elder Longneck - COST:3 [ATK:5/HP:1] 
            // - Race: beast, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If you're holding a minion with 5 or more Attack, <b>Adapt</b>.
            // --------------------------------------------------------
            // Entourage: UNG_999t10, UNG_999t2, UNG_999t3, UNG_999t4, UNG_999t5, UNG_999t6, UNG_999t7, UNG_999t8, UNG_999t13, UNG_999t14
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_109", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.Is5PlusAtkInHand),
                        new FlagTask(true, new AdaptTask(EEntityType.SOURCE)))
                },
            });

            // ----------------------------------------- MINION - DRUID
            // [UNG_852] Tyrantus - COST:10 [ATK:12/HP:12] 
            // - Race: beast, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: Can't be targeted by spells or Hero Powers.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - CANT_BE_TARGETED_BY_SPELLS = 1
            // - CANT_BE_TARGETED_BY_HERO_POWERS = 1
            // --------------------------------------------------------
            cards.Add("UNG_852", null);

            // ------------------------------------------ SPELL - DRUID
            // [UNG_103] Evolving Spores - COST:4 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Adapt</b> your minions.
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_103", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new AdaptTask(EEntityType.MINIONS)
                },
            });

            // ------------------------------------------ SPELL - DRUID
            // [UNG_108] Earthen Scales - COST:1 
            // - Fac: neutral, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: Give a friendly minion +1/+1, then gain Armor equal to its Attack.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_108", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_108e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new BuffTask(Buffs.AttackHealth(1), EEntityType.TARGET),
                        new GetGameTagTask(EGameTag.ATK, EEntityType.TARGET),
                        new ArmorTask())

                },
            });

            // ------------------------------------------ SPELL - DRUID
            // [UNG_111] Living Mana - COST:5 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: Transform your Mana Crystals into 2/2 minions. Recover the mana when they die.
            // --------------------------------------------------------
            cards.Add("UNG_111", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = SpecificTask.LivingMana
                },
            });

            // ------------------------------------------ SPELL - DRUID
            // [UNG_116] Jungle Giants - COST:1 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]<b>Quest:</b> Summon
            //       5 minions with
            //       5 or more Attack.
            //       <b>Reward:</b> Barnabus.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - QUEST = 1
            // - QUEST_PROGRESS_TOTAL = 5
            // - 676 = 1
            // --------------------------------------------------------
            cards.Add("UNG_116", new List<Enchantment>
            {
                // TODO Write test for it ...
                // Quest Contributor Trigger
                new Enchantment
                {
                    Area = EEnchantmentArea.HAND,
                    Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.HAND),
                        new FilterStackTask(SelfCondition.IsTagValue(EGameTag.ATK, 5, ERelaSign.GEQ)),
                        new SetGameTagTask(EGameTag.QUEST_CONTRIBUTOR, 1, EEntityType.STACK)),
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsTagValue(EGameTag.ATK, 5, ERelaSign.GEQ)))
                        .TriggerEffect(EGameTag.ZONE_POSITION, 0)
                        .SingleTask(new SetGameTagTask(EGameTag.QUEST_CONTRIBUTOR, 1, EEntityType.TARGET))
                        .Build()
                },
                // Quest Progress Trigger
                new Enchantment
                {
                    Area = EEnchantmentArea.HAND_AND_BOARD,
                    Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsTagValue(EGameTag.QUEST_CONTRIBUTOR, 1)))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(new QuestProgressTask())
                        .Build()
                },
                // Quest Reward Trigger
                new Enchantment
                {
                    Area = EEnchantmentArea.SELF,
                    Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsQuestDone))
                        .TriggerEffect(EGameTag.QUEST_PROGRESS, 1)
                        .SingleTask(new QuestRewardTask("UNG_116t"))
                        .Build()
                },
            });
        }

        private static void DruidNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------ ENCHANTMENT - DRUID
            // [UNG_108e] It's All Scaley... (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("UNG_108e", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [UNG_116te] Romper Stompers (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Costs (0).
            // --------------------------------------------------------
            cards.Add("UNG_116te", null);

            // ----------------------------------------- MINION - DRUID
            // [UNG_101t] Shellshifter (*) - COST:4 [ATK:5/HP:3] 
            // - Race: beast, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Stealth</b>
            // --------------------------------------------------------
            // GameTag:
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("UNG_101t", null);

            // ----------------------------------------- MINION - DRUID
            // [UNG_101t2] Shellshifter (*) - COST:4 [ATK:3/HP:5] 
            // - Race: beast, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_101t2", null);

            // ----------------------------------------- MINION - DRUID
            // [UNG_101t3] Shellshifter (*) - COST:4 [ATK:5/HP:5] 
            // - Race: beast, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Stealth</b>
            //       <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("UNG_101t3", null);

            // ----------------------------------------- MINION - DRUID
            // [UNG_111t1] Mana Treant (*) - COST:2 [ATK:2/HP:2] 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Gain an empty Mana Crystal.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_111t1", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = new ManaCrystalEmptyTask(1)
                },
            });

            // ----------------------------------------- MINION - DRUID
            // [UNG_116t] Barnabus the Stomper (*) - COST:5 [ATK:8/HP:8] 
            // - Race: beast, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Reduce the
            //       Cost of minions in your deck to (0).
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_116t", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_116te",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.DECK),
                        new BuffTask(Buffs.CostFix(0), EEntityType.STACK, SelfCondition.IsMinion))
                },
            });

            // ------------------------------------------ SPELL - DRUID
            // [UNG_101a] Raptor Form (*) - COST:0 
            // - Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: +2 Attack and <b>Stealth</b>
            // --------------------------------------------------------
            cards.Add("UNG_101a", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new TransformTask("UNG_101t", EEntityType.SOURCE)
                },
            });

            // ------------------------------------------ SPELL - DRUID
            // [UNG_101b] Direhorn Form (*) - COST:0 
            // - Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: +2 Health and <b>Taunt</b>.
            // --------------------------------------------------------
            cards.Add("UNG_101b", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new TransformTask("UNG_101t2", EEntityType.SOURCE)
                },
            });
        }

        private static void Hunter(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------------- MINION - HUNTER
            // [UNG_800] Terrorscale Stalker - COST:3 [ATK:3/HP:3] 
            // - Fac: neutral, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Trigger a friendly minion's <b>Deathrattle</b>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_WITH_DEATHRATTLE = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            // RefTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_800", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new ActivateEnchantment(EEntityType.TARGET, EEnchantmentActivation.DEATHRATTLE)
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [UNG_912] Jeweled Macaw - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Add a random Beast to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_912", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RandomMinionTask(EGameTag.CARDRACE, (int)ERace.BEAST),
                        new AddStackTo(EEntityType.HAND))
                }
            });

            // ---------------------------------------- MINION - HUNTER
            // [UNG_913] Tol'vir Warden - COST:5 [ATK:3/HP:5] 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Draw two 1-Cost minions from your deck.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_913", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new EnqueueTask(2, 
                        ComplexTask.DrawFromDeck(SelfCondition.IsTagValue(EGameTag.COST, 1), SelfCondition.IsMinion)),
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [UNG_914] Raptor Hatchling - COST:1 [ATK:2/HP:1] 
            // - Race: beast, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Shuffle a 4/3 Raptor into your deck.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_914", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = new AddCardTo("UNG_914t1", EEntityType.DECK)
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [UNG_915] Crackling Razormaw - COST:2 [ATK:3/HP:2] 
            // - Race: beast, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> <b>Adapt</b> a friendly_Beast.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_WITH_RACE = 20
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_915", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new AdaptTask(EEntityType.TARGET)
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [UNG_919] Swamp King Dred - COST:7 [ATK:9/HP:9] 
            // - Race: beast, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: After your opponent plays a minion, attack_it.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("UNG_919", new List<Enchantment>
            {
                // TODO [UNG_919] Swamp King Dred && Test: Swamp King Dred_UNG_919
                new Enchantment
                {
                    //Activation = null,
                    //SingleTask = null,
                }
            });

            // ----------------------------------------- SPELL - HUNTER
            // [UNG_910] Grievous Bite - COST:2 
            // - Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $2 damage to a minion and $1 damage to adjacent ones. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_910", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.OP_MINIONS),
                        new FilterStackTask(EEntityType.TARGET, RelaCondition.IsSideBySide),
                        new DamageTask(2, EEntityType.TARGET, true),
                        new DamageTask(1, EEntityType.STACK, true))
                },
            });

            // ----------------------------------------- SPELL - HUNTER
            // [UNG_916] Stampede - COST:1 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: Each time you play a Beast this turn, add_a_random Beast to_your hand.
            // --------------------------------------------------------
            cards.Add("UNG_916", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_916e",
                    Area = EEnchantmentArea.BOARD,
                    Activation = EEnchantmentActivation.SPELL,
                    Trigger = new TriggerBuilder().Create()
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsRace(ERace.BEAST)))
                        .TurnsActive(0)
                        .FastExecution(true)
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(ComplexTask.Create(
                            new RandomMinionTask(EGameTag.CARDRACE, (int)ERace.BEAST),
                            new AddStackTo(EEntityType.HAND)))
                        .Build()
                },
            });

            // ----------------------------------------- SPELL - HUNTER
            // [UNG_917] Dinomancy - COST:2 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: Your Hero Power becomes 'Give a Beast +2/+2.'
            // --------------------------------------------------------
            cards.Add("UNG_917", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_917e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new ReplaceHeroPower(Cards.FromId("UNG_917t1")),
                },
            });

            // ----------------------------------------- SPELL - HUNTER
            // [UNG_920] The Marsh Queen - COST:1 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]<b>Quest:</b> Play seven
            //       1-Cost minions.
            //       <b>Reward:</b> Queen Carnassa.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - QUEST = 1
            // - QUEST_PROGRESS_TOTAL = 7
            // - 676 = 1
            // --------------------------------------------------------
            cards.Add("UNG_920", new List<Enchantment>
            {
                // Quest Progress Contributor
                new Enchantment
                {
                    InfoCardId = "UNG_920t1",
                    Area = EEnchantmentArea.HAND,
                    Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.HAND),
                        new FilterStackTask(SelfCondition.IsTagValue(EGameTag.COST, 1)),
                        new SetGameTagTask(EGameTag.QUEST_CONTRIBUTOR, 1, EEntityType.STACK)),
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsTagValue(EGameTag.COST, 1)))
                        .TriggerEffect(EGameTag.ZONE_POSITION, 0)
                        .SingleTask(new SetGameTagTask(EGameTag.QUEST_CONTRIBUTOR, 1, EEntityType.TARGET))
                        .Build()
                 },
                 // Quest Progress Trigger
                 new Enchantment
                 {
                     Area = EEnchantmentArea.HAND_AND_BOARD,
                     Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                     Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsTagValue(EGameTag.QUEST_CONTRIBUTOR, 1)))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(new QuestProgressTask())
                        .Build()
                 },
                 // Quest Reward Trigger
                 new Enchantment
                 {
                     Area = EEnchantmentArea.SELF,
                     Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                     Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsQuestDone))
                        .TriggerEffect(EGameTag.QUEST_PROGRESS, 1)
                        .SingleTask(new QuestRewardTask("UNG_920t1"))
                        .Build()
                 },
            });
        }

        private static void HunterNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------- ENCHANTMENT - HUNTER
            // [UNG_916e] Stampeding (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // GameTag:
            // - TAG_ONE_TURN_EFFECT = 1
            // --------------------------------------------------------
            cards.Add("UNG_916e", null);

            // ----------------------------------- ENCHANTMENT - HUNTER
            // [UNG_917e] Well Fed (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("UNG_917e", null);

            // ---------------------------------------- MINION - HUNTER
            // [UNG_914t1] Raptor Patriarch (*) - COST:1 [ATK:4/HP:3] 
            // - Race: beast, Set: ungoro, 
            // --------------------------------------------------------
            cards.Add("UNG_914t1", null);

            // ---------------------------------------- MINION - HUNTER
            // [UNG_920t1] Queen Carnassa (*) - COST:5 [ATK:8/HP:8] 
            // - Race: beast, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Shuffle 15 Raptors into your deck.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_920t1", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new EnqueueTask(15, new AddCardTo("UNG_076t1", EEntityType.DECK))
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [UNG_920t2] Carnassa's Brood (*) - COST:1 [ATK:3/HP:2] 
            // - Race: beast, Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Draw a card.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_920t2", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new DrawTask()
                },
            });
        }

        private static void Mage(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------------ MINION - MAGE
            // [UNG_020] Arcanologist - COST:2 [ATK:2/HP:3] 
            // - Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Draw a <b>Secret</b> from your deck.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - SECRET_OR_QUEST = 1
            // --------------------------------------------------------
            cards.Add("UNG_020", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.DrawFromDeck(SelfCondition.IsSecret)
                },
            });

            // ------------------------------------------ MINION - MAGE
            // [UNG_021] Steam Surger - COST:4 [ATK:5/HP:4] 
            // - Race: elemental, Fac: neutral, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: [x]<b>Battlecry:</b> If you played
            //       an Elemental last turn,
            //       add a 'Flame Geyser'
            //       to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_021", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
                        new FlagTask(true, new AddCardTo("UNG_018", EEntityType.HAND))),
                },
            });

            // ------------------------------------------ MINION - MAGE
            // [UNG_027] Pyros - COST:2 [ATK:2/HP:2] 
            // - Race: elemental, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Return this to_your hand as a 6/6 that costs (6).
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_027", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = new AddCardTo("UNG_027t2", EEntityType.HAND)
                },
            });

            // ------------------------------------------ MINION - MAGE
            // [UNG_846] Shimmering Tempest - COST:2 [ATK:2/HP:1] 
            // - Race: elemental, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Add a random Mage spell to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_846", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.Create(
                        new RandomCardTask(ECardType.SPELL, ECardClass.MAGE),
                        new AddStackTo(EEntityType.HAND))
                }
            });

            // ------------------------------------------- SPELL - MAGE
            // [UNG_018] Flame Geyser - COST:2 
            // - Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $2 damage.
            //       Add a 1/2 Elemental to_your hand. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_018", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(2, EEntityType.TARGET, true),
                        new AddCardTo("UNG_809t1", EEntityType.HAND))

                },
            });

            // ------------------------------------------- SPELL - MAGE
            // [UNG_024] Mana Bind - COST:3 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Secret:</b> When your opponent casts a spell, add a copy to your hand that costs (0).
            // --------------------------------------------------------
            // GameTag:
            // - SECRET_OR_QUEST = 1
            // --------------------------------------------------------
            cards.Add("UNG_024", new List<Enchantment>
            {
                // TODO [UNG_024] Mana Bind && Test: Mana Bind_UNG_024
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });

            // ------------------------------------------- SPELL - MAGE
            // [UNG_028] Open the Waygate - COST:1 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]<b>Quest:</b> Cast 6 spells that
            //       didn't start in your deck.
            //       <b>Reward:</b> Time Warp.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - QUEST = 1
            // - QUEST_PROGRESS_TOTAL = 6
            // - 676 = 1
            // --------------------------------------------------------
            cards.Add("UNG_028", new List<Enchantment>
            {
                // TODO [UNG_028] Open the Waygate && Test: Open the Waygate_UNG_028
                new Enchantment
                {
                    InfoCardId = "UNG_028e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });

            // ------------------------------------------- SPELL - MAGE
            // [UNG_941] Primordial Glyph - COST:2 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Discover</b> a spell. Reduce its Cost by (2).
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_941", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_941e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new DiscoverTask(EDiscoverType.SPELL,
                        new Enchantment()
                        {
                            Activation = EEnchantmentActivation.HAND,
                            SingleTask = new BuffTask(Buffs.Cost(-2), EEntityType.SOURCE)
                        }),
                },
            });

            // ------------------------------------------- SPELL - MAGE
            // [UNG_948] Molten Reflection - COST:4 
            // - Fac: neutral, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: Choose a friendly minion. Summon a copy of it.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_948", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new CopyTask(EEntityType.TARGET, 1),
                        new SummonTask())
                },
            });

            // ------------------------------------------- SPELL - MAGE
            // [UNG_955] Meteor - COST:6 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: Deal $15 damage to a minion and $3 damage to adjacent ones. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_955", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.OP_MINIONS),
                        new FilterStackTask(EEntityType.TARGET, RelaCondition.IsSideBySide),
                        new DamageTask(15, EEntityType.TARGET, true),
                        new DamageTask(3, EEntityType.STACK, true))
                },
            });
        }

        private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------- ENCHANTMENT - MAGE
            // [UNG_028e] Insightful (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Take an extra turn.
            // --------------------------------------------------------
            cards.Add("UNG_028e", null);

            // ------------------------------------- ENCHANTMENT - MAGE
            // [UNG_941e] Primal Magic (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Cost reduced.
            // --------------------------------------------------------
            cards.Add("UNG_941e", null);

            // ------------------------------------------ MINION - MAGE
            // [UNG_027t2] Pyros (*) - COST:6 [ATK:6/HP:6] 
            // - Race: elemental, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Return this to_your hand as a 10/10 that costs (10).
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_027t2", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = new AddCardTo("UNG_027t4", EEntityType.HAND),
                },
            });

            // ------------------------------------------ MINION - MAGE
            // [UNG_027t4] Pyros (*) - COST:10 [ATK:10/HP:10] 
            // - Race: elemental, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("UNG_027t4", null);

            // ------------------------------------------- SPELL - MAGE
            // [UNG_028t] Time Warp (*) - COST:5 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: Take an extra turn.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("UNG_028t", new List<Enchantment>
            {
                // TODO [UNG_028t] Time Warp && Test: Time Warp_UNG_028t
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });
        }

        private static void Paladin(IDictionary<string, List<Enchantment>> cards)
        {
            // --------------------------------------- MINION - PALADIN
            // [UNG_011] Hydrologist - COST:2 [ATK:2/HP:2] 
            // - Race: murloc, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> <b>Discover</b> a <b>Secret</b>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - SECRET_OR_QUEST = 1
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_011", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new DiscoverTask(EDiscoverType.SECRET)
                },
            });

            // --------------------------------------- MINION - PALADIN
            // [UNG_015] Sunkeeper Tarim - COST:6 [ATK:3/HP:7] 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       <b>Battlecry:</b> Set all other minions' Attack and Health to 3.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_015", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_015e",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.ALLMINIONS),
                        new SetAttackTask(3, EEntityType.STACK),
                        new SetHealthTask(3, EEntityType.STACK))
                },
            });

            // --------------------------------------- MINION - PALADIN
            // [UNG_953] Primalfin Champion - COST:2 [ATK:1/HP:2] 
            // - Race: murloc, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Return any spells you cast on this minion to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // - 537 = 1
            // - 542 = 1
            // --------------------------------------------------------
            cards.Add("UNG_953", new List<Enchantment>
            {
                // TODO [UNG_953] Primalfin Champion && Test: Primalfin Champion_UNG_953
                new Enchantment
                {
                    InfoCardId = "UNG_953e",
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = null,
                },
            });

            // --------------------------------------- MINION - PALADIN
            // [UNG_962] Lightfused Stegodon - COST:4 [ATK:3/HP:4] 
            // - Race: beast, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> <b>Adapt</b> your Silver_Hand Recruits.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_962", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.MINIONS),
                        new FilterStackTask(SelfCondition.IsSilverHandRecruit),
                        new AdaptTask(EEntityType.STACK)),
                },
            });

            // ---------------------------------------- SPELL - PALADIN
            // [UNG_004] Dinosize - COST:8 
            // - Fac: neutral, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: Set a minion's Attack and Health to 10.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_004", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_004e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new SetAttackTask(10, EEntityType.TARGET),
                        new SetHealthTask(10, EEntityType.TARGET)),
                },
            });

            // ---------------------------------------- SPELL - PALADIN
            // [UNG_952] Spikeridged Steed - COST:6 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: Give a minion +2/+6 and <b>Taunt</b>. When it dies, summon a Stegodon.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_952", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_952e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        ComplexTask.Taunt(EEntityType.STACK),
                        new BuffTask(Buffs.AttackHealth(2, 6), EEntityType.TARGET),
                        new AddEnchantmentTask(EEntityType.TARGET,
                            new Enchantment
                            {
                                Activation = EEnchantmentActivation.DEATHRATTLE,
                                SingleTask = new SummonTask("UNG_810")
                            }))
                },
            });

            // ---------------------------------------- SPELL - PALADIN
            // [UNG_954] The Last Kaleidosaur - COST:1 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Quest:</b> Cast 6 spells
            //       on your minions.
            //       <b>Reward:</b> Galvadon.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - QUEST = 1
            // - QUEST_PROGRESS_TOTAL = 6
            // - 676 = 1
            // --------------------------------------------------------
            cards.Add("UNG_954", new List<Enchantment>
            {
                // TODO [UNG_954] The Last Kaleidosaur && Test: The Last Kaleidosaur_UNG_954
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });

            // ---------------------------------------- SPELL - PALADIN
            // [UNG_960] Lost in the Jungle - COST:1 
            // - Fac: alliance, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: Summon two 1/1 Silver Hand Recruits.
            // --------------------------------------------------------
            cards.Add("UNG_960", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(2, new SummonTask("CS2_101t")),
                },
            });

            // ---------------------------------------- SPELL - PALADIN
            // [UNG_961] Adaptation - COST:1 
            // - Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Adapt</b> a friendly minion.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_961", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new AdaptTask(EEntityType.TARGET),
                },
            });

            // --------------------------------------- WEAPON - PALADIN
            // [UNG_950] Vinecleaver - COST:7 [ATK:4/HP:0] 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: [x]After your hero attacks,
            //       summon two 1/1 Silver
            //       Hand Recruits.
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 3
            // --------------------------------------------------------
            cards.Add("UNG_950", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.HERO,
                    Activation = EEnchantmentActivation.WEAPON,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsThisWeaponEquiped)
                        .TriggerEffect(EGameTag.ATTACKING, -1)
                        .SingleTask(new EnqueueTask(2, new SummonTask("CS2_101t")))
                        .Build()
                },
            });
        }

        private static void PaladinNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------- ENCHANTMENT - PALADIN
            // [UNG_004e] RAAAAR! (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Stats changed to 10/10.
            // --------------------------------------------------------
            cards.Add("UNG_004e", null);

            // ---------------------------------- ENCHANTMENT - PALADIN
            // [UNG_015e] Watched (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Stats changed to 3/3.
            // --------------------------------------------------------
            cards.Add("UNG_015e", null);

            // ---------------------------------- ENCHANTMENT - PALADIN
            // [UNG_952e] On a Stegodon (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: +2/+6 and <b>Taunt</b>.
            //       <b>Deathrattle:</b> Summon a Stegodon.
            // --------------------------------------------------------
            cards.Add("UNG_952e", null);

            // ---------------------------------- ENCHANTMENT - PALADIN
            // [UNG_953e] Inspired (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Storing spell.
            // --------------------------------------------------------
            cards.Add("UNG_953e", null);

            // --------------------------------------- MINION - PALADIN
            // [UNG_954t1] Galvadon (*) - COST:5 [ATK:5/HP:5] 
            // - Race: beast, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> <b>Adapt</b> 5 times.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_954t1", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new EnqueueTask(5, new AdaptTask(EEntityType.SOURCE))
                },
            });
        }

        private static void Priest(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------------- MINION - PRIEST
            // [UNG_022] Mirage Caller - COST:3 [ATK:2/HP:3] 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Choose a friendly minion. Summon a 1/1 copy of it.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("UNG_022", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_022e",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new CopyTask(EEntityType.TARGET, 1),
                        new SetAttackTask(1, EEntityType.TARGET),
                        new SetHealthTask(1, EEntityType.TARGET),
                        new SummonTask())
                },
            });

            // ---------------------------------------- MINION - PRIEST
            // [UNG_032] Crystalline Oracle - COST:1 [ATK:1/HP:1] 
            // - Race: elemental, Fac: horde, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: [x]<b>Deathrattle:</b> Copy a card
            //       from your opponent's deck
            //       _and add it to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_032", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.RandomCardCopyToHandFrom(EEntityType.OP_DECK)
                },
            });

            // ---------------------------------------- MINION - PRIEST
            // [UNG_034] Radiant Elemental - COST:2 [ATK:2/HP:3] 
            // - Race: elemental, Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: Your spells cost (1) less.
            // --------------------------------------------------------
            // GameTag:
            // - AURA = 1
            // --------------------------------------------------------
            cards.Add("UNG_034", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.Cost(-1, RelaCondition.IsOther(SelfCondition.IsSpell)), EAuraArea.HAND)
                }
            });

            // ---------------------------------------- MINION - PRIEST
            // [UNG_035] Curious Glimmerroot - COST:3 [ATK:3/HP:3] 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: [x]<b>Battlecry:</b> Look at 3 cards.
            //       Guess which one started
            //       in your opponent's deck
            //       to get a copy of it.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // --------------------------------------------------------
            cards.Add("UNG_035", new List<Enchantment>
            {
                // TODO [UNG_035] Curious Glimmerroot && Test: Curious Glimmerroot_UNG_035
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = null,
                },
            });

            // ---------------------------------------- MINION - PRIEST
            // [UNG_037] Tortollan Shellraiser - COST:4 [ATK:2/HP:6] 
            // - Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: [x]<b>Taunt</b>
            //       <b>Deathrattle:</b> Give a random
            //       _friendly minion +1/+1.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_037", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_037e",
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.BuffRandomMinion(EEntityType.MINIONS, Buffs.AttackHealth(1), new SelfCondition[] {})
                },
            });

            // ---------------------------------------- MINION - PRIEST
            // [UNG_963] Lyra the Sunshard - COST:5 [ATK:3/HP:5] 
            // - Race: elemental, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: Whenever you cast a spell, add a random Priest spell to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("UNG_963", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.HAND,
                    Activation = EEnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(ComplexTask.Create(
                            new RandomCardTask(ECardType.SPELL, ECardClass.PRIEST),
                            new AddStackTo(EEntityType.HAND)))
                        .Build()
                }
            });

            // ----------------------------------------- SPELL - PRIEST
            // [UNG_029] Shadow Visions - COST:2 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Discover</b> a copy of a spell in your deck.
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_029", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.HasSpellInDeck),
                        new FlagTask(true, new DiscoverTask(EDiscoverType.OWN_SPELL)))
                },
            });

            // ----------------------------------------- SPELL - PRIEST
            // [UNG_030] Binding Heal - COST:1 
            // - Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: Restore #5 Health to a minion and your hero.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_030", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new HealTask(5, EEntityType.TARGET),
                        new HealTask(5, EEntityType.HERO))
                },
            });

            // ----------------------------------------- SPELL - PRIEST
            // [UNG_854] Free From Amber - COST:8 
            // - Fac: neutral, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Discover</b> a minion that costs (8) or more. Summon it.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_NUM_MINION_SLOTS = 1
            // - REQ_TARGET_WITH_DEATHRATTLE = 0
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_854", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new DiscoverTask(EDiscoverType.COST_8_MORE_SUMMON)
                },
            });

            // ----------------------------------------- SPELL - PRIEST
            // [UNG_940] Awaken the Makers - COST:1 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Quest:</b> Summon
            //       7 <b>Deathrattle</b> minions.<b>
            //       Reward:</b> Amara, Warden of Hope.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - QUEST = 1
            // - QUEST_PROGRESS_TOTAL = 7
            // - 676 = 1
            // --------------------------------------------------------
            // RefTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_940", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_940t8",
                    Area = EEnchantmentArea.HAND,
                    Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.HAND),
                        new FilterStackTask(SelfCondition.IsTagValue(EGameTag.DEATHRATTLE, 1)),
                        new SetGameTagTask(EGameTag.QUEST_CONTRIBUTOR, 1, EEntityType.STACK)),
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsTagValue(EGameTag.DEATHRATTLE, 1)))
                        .TriggerEffect(EGameTag.ZONE_POSITION, 0)
                        .SingleTask(new SetGameTagTask(EGameTag.QUEST_CONTRIBUTOR, 1, EEntityType.TARGET))
                        .Build()
                 },
                 // Quest Progress Trigger
                 new Enchantment
                 {
                     Area = EEnchantmentArea.HAND_AND_BOARD,
                     Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                     Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsTagValue(EGameTag.QUEST_CONTRIBUTOR, 1)))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(new QuestProgressTask())
                        .Build()
                 },
                 // Quest Reward Trigger
                 new Enchantment
                 {
                     Area = EEnchantmentArea.SELF,
                     Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                     Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsQuestDone))
                        .TriggerEffect(EGameTag.QUEST_PROGRESS, 1)
                        .SingleTask(new QuestRewardTask("UNG_940t8"))
                        .Build()
                 },
            });
        }

        private static void PriestNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------- ENCHANTMENT - PRIEST
            // [UNG_022e] Mirage (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: 1/1.
            // --------------------------------------------------------
            cards.Add("UNG_022e", null);

            // ----------------------------------- ENCHANTMENT - PRIEST
            // [UNG_037e] Shellshield (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("UNG_037e", null);

            // ---------------------------------------- MINION - PRIEST
            // [UNG_940t8] Amara, Warden of Hope (*) - COST:5 [ATK:8/HP:8] 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]<b>Taunt</b>
            //       <b>Battlecry:</b> Set your
            //       hero's Health to 40.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_940t8", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new SetHealthTask(40, EEntityType.HERO)
                },
            });
        }

        private static void Rogue(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------------- MINION - ROGUE
            // [UNG_058] Razorpetal Lasher - COST:2 [ATK:2/HP:2] 
            // - Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: [x]<b>Battlecry:</b> Add a
            //       Razorpetal to your hand
            //       that deals 1 damage.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_058", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new AddCardTo("UNG_057t1", EEntityType.HAND)
                },
            });

            // ----------------------------------------- MINION - ROGUE
            // [UNG_063] Biteweed - COST:2 [ATK:1/HP:1] 
            // - Fac: neutral, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Combo:</b> Gain +1/+1 for each other card you've played this turn.
            // --------------------------------------------------------
            // GameTag:
            // - COMBO = 1
            // --------------------------------------------------------
            cards.Add("UNG_063", new List<Enchantment>
            {
                // Combo
                new Enchantment
                {
                    InfoCardId = "UNG_063e",
                    Activation = EEnchantmentActivation.BOARD,
                    SingleTask = ComplexTask.Create(
                        new GetGameTagControllerTask(EGameTag.NUM_CARDS_PLAYED_THIS_TURN),
                        new MathSubstractionTask(1),
                        new MathMultiplyTask(1),
                        new BuffAttackHealthNumberTask(EEntityType.SOURCE))
                }
            });

            // ----------------------------------------- MINION - ROGUE
            // [UNG_064] Vilespine Slayer - COST:5 [ATK:3/HP:4] 
            // - Fac: neutral, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Combo:</b> Destroy a minion.
            // --------------------------------------------------------
            // GameTag:
            // - COMBO = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_FOR_COMBO = 0
            // - REQ_MINION_TARGET = 0
            // --------------------------------------------------------
            cards.Add("UNG_064", new List<Enchantment>
            {
                // Combo
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new DestroyTask(EEntityType.TARGET)
                }
            });

            // ----------------------------------------- MINION - ROGUE
            // [UNG_065] Sherazin, Corpse Flower - COST:4 [ATK:5/HP:3] 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Go dormant. Play 4 cards in a turn to revive this minion.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_065", new List<Enchantment>
            {
                // TODO [UNG_065] Sherazin, Corpse Flower && Test: Sherazin, Corpse Flower_UNG_065
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = null,
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [UNG_057] Razorpetal Volley - COST:2 
            // - Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: Add two Razorpetals to_your hand that deal_1 damage.
            // --------------------------------------------------------
            cards.Add("UNG_057", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(2, new AddCardTo("UNG_057t1", EEntityType.HAND))
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [UNG_060] Mimic Pod - COST:3 
            // - Fac: neutral, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: Draw a card, then add a copy of it to your hand.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // --------------------------------------------------------
            cards.Add("UNG_060", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DrawTask(true),
                        new CopyTask(EEntityType.STACK, 1),
                        new AddStackTo(EEntityType.HAND)),
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [UNG_067] The Caverns Below - COST:1 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]<b>Quest:</b> Play four minions
            //       with the same name.
            //       <b>Reward:</b> Crystal Core.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - QUEST = 1
            // - QUEST_PROGRESS_TOTAL = 4
            // - 676 = 1
            // --------------------------------------------------------
            cards.Add("UNG_067", new List<Enchantment>
            {
                // TODO [UNG_067] The Caverns Below && Test: The Caverns Below_UNG_067
                new Enchantment
                {
                    InfoCardId = "UNG_067t1e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [UNG_823] Envenom Weapon - COST:3 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: Give your weapon <b>Poisonous</b>.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_WEAPON_EQUIPPED = 0
            // --------------------------------------------------------
            // RefTag:
            // - POISONOUS = 1
            // --------------------------------------------------------
            cards.Add("UNG_823", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new SetGameTagTask(EGameTag.POISONOUS, 1, EEntityType.WEAPON)
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [UNG_856] Hallucination - COST:1 
            // - Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Discover</b> a card from your opponent's class.
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_856", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new DiscoverTask(EDiscoverType.OP_HERO),
                },
            });

            // ----------------------------------------- WEAPON - ROGUE
            // [UNG_061] Obsidian Shard - COST:4 [ATK:3/HP:0] 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: [x]Costs (1) less for each
            //       card you've played from
            //       another class.
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 3
            // --------------------------------------------------------
            cards.Add("UNG_061", new List<Enchantment>
            {
                // TODO [UNG_061] Obsidian Shard && Test: Obsidian Shard_UNG_061
                new Enchantment
                {
                    Activation = EEnchantmentActivation.WEAPON,
                    SingleTask = null,
                },
            });
        }

        private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------ ENCHANTMENT - ROGUE
            // [UNG_063e] Sprout (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("UNG_063e", null);

            // ----------------------------------------- MINION - ROGUE
            // [UNG_065t] Sherazin, Seed (*) - COST:11 [ATK:0/HP:1] 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: When you play 4 cards in a_turn, revive this minion.
            // --------------------------------------------------------
            // GameTag:
            // - HIDE_STATS = 1
            // - UNTOUCHABLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_065t", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.HAND_AND_BOARD,
                    Activation = EEnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsSilenced)
                        .ApplyConditions(RelaCondition.IsMe(SelfCondition.MinionsPlayedThisTurn(4)))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(ComplexTask.Create(
                            new SummonTask("UNG_065"),
                            new MoveToSetaside(EEntityType.SOURCE)))
                        .Build()
                }
            });

            // ------------------------------------------ SPELL - ROGUE
            // [UNG_057t1] Razorpetal (*) - COST:1 
            // - Fac: neutral, Set: ungoro, 
            // --------------------------------------------------------
            // Text: Deal $1 damage. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_057t1", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(1, EEntityType.TARGET, true)
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [UNG_067t1] Crystal Core (*) - COST:5 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: For the rest of the game, your minions are 5/5.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("UNG_067t1", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_067t1e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.MINIONS),
                        new IncludeTask(EEntityType.DECK, null, true),
                        new IncludeTask(EEntityType.HAND, null, true),
                        new FilterStackTask(SelfCondition.IsMinion),
                        new BuffTask(Buffs.AttackHealthFix(5), EEntityType.STACK))
                },
            });
        }

        private static void Shaman(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------------- MINION - SHAMAN
            // [UNG_019] Air Elemental - COST:1 [ATK:2/HP:1] 
            // - Race: elemental, Fac: horde, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: Can't be targeted by spells or Hero Powers.
            // --------------------------------------------------------
            // GameTag:
            // - CANT_BE_TARGETED_BY_SPELLS = 1
            // - CANT_BE_TARGETED_BY_HERO_POWERS = 1
            // --------------------------------------------------------
            cards.Add("UNG_019", null);

            // ---------------------------------------- MINION - SHAMAN
            // [UNG_201] Primalfin Totem - COST:2 [ATK:0/HP:3] 
            // - Race: totem, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: At the end of your turn, summon a 1/1 Murloc.
            // --------------------------------------------------------
            cards.Add("UNG_201", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.CONTROLLER,
                    Activation = EEnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(EGameTag.TURN_START, -1)
                        .SingleTask(new SummonTask("UNG_201t"))
                        .Build()
                }
            });

            // ---------------------------------------- MINION - SHAMAN
            // [UNG_202] Fire Plume Harbinger - COST:2 [ATK:1/HP:1] 
            // - Race: elemental, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Reduce the Cost of Elementals in your hand_by (1).
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_202", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.HAND),
                        new FilterStackTask(SelfCondition.IsRace(ERace.ELEMENTAL)),
                        new BuffTask(Buffs.Cost(-1), EEntityType.STACK))
                },
            });

            // ---------------------------------------- MINION - SHAMAN
            // [UNG_208] Stone Sentinel - COST:7 [ATK:4/HP:4] 
            // - Race: elemental, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If you played an Elemental last turn, summon two 2/3 Elementals with <b>Taunt</b>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_WITH_DEATHRATTLE = 0
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_208", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
                        new FlagTask(true, new EnqueueTask(2, new SummonTask("UNG_809t1")))),
                },
            });

            // ---------------------------------------- MINION - SHAMAN
            // [UNG_211] Kalimos, Primal Lord - COST:8 [ATK:7/HP:7] 
            // - Race: elemental, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]<b>Battlecry:</b> If you played an
            //       Elemental last turn, cast an
            //       Elemental Invocation.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_211", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
                        new FlagTask(true, new DiscoverTask(EDiscoverType.ELEMENTAL_INVOCATION)))
                },
            });

            // ---------------------------------------- MINION - SHAMAN
            // [UNG_938] Hot Spring Guardian - COST:3 [ATK:2/HP:4] 
            // - Race: elemental, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       <b>Battlecry:</b> Restore 3_Health.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("UNG_938", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new HealTask(3, EEntityType.TARGET)
                },
            });

            // ----------------------------------------- SPELL - SHAMAN
            // [UNG_025] Volcano - COST:5 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: Deal $15 damage randomly split among all_minions.
            //       <b>Overload:</b> (2) *spelldmg
            // --------------------------------------------------------
            // GameTag:
            // - OVERLOAD = 2
            // - OVERLOAD_OWED = 2
            // - ImmuneToSpellpower = 1
            // --------------------------------------------------------
            cards.Add("UNG_025", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(15, ComplexTask.DamageRandomTargets(1, EEntityType.ALL, 1), true)
                },
            });

            // ----------------------------------------- SPELL - SHAMAN
            // [UNG_817] Tidal Surge - COST:4 
            // - Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $4 damage to a minion. Restore #4 Health to your hero. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_817", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                   SingleTask = ComplexTask.Create(
                        new DamageTask(4, EEntityType.TARGET, true),
                        new HealTask(5, EEntityType.HERO))
                },
            });

            // ----------------------------------------- SPELL - SHAMAN
            // [UNG_942] Unite the Murlocs - COST:1 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]<b>Quest:</b> Summon
            //       10 Murlocs.
            //       <b>Reward:</b> Megafin.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - QUEST = 1
            // - QUEST_PROGRESS_TOTAL = 10
            // - 676 = 1
            // --------------------------------------------------------
            cards.Add("UNG_942", new List<Enchantment>
            {
                // Quest Contributor Trigger
                new Enchantment
                {
                    InfoCardId = "UNG_942t",
                    Area = EEnchantmentArea.HAND,
                    Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.HAND),
                        new FilterStackTask(SelfCondition.IsTagValue(EGameTag.CARDRACE, (int)ERace.MURLOC)),
                        new SetGameTagTask(EGameTag.QUEST_CONTRIBUTOR, 1, EEntityType.STACK)),
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsTagValue(EGameTag.CARDRACE, (int)ERace.MURLOC)))
                        .TriggerEffect(EGameTag.ZONE_POSITION, 0)
                        .SingleTask(new SetGameTagTask(EGameTag.QUEST_CONTRIBUTOR, 1, EEntityType.TARGET))
                        .Build()
                 },
                 // Quest Progress Trigger
                 new Enchantment
                 {
                     Area = EEnchantmentArea.HAND_AND_BOARD,
                     Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                     Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsTagValue(EGameTag.QUEST_CONTRIBUTOR, 1)))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(new QuestProgressTask())
                        .Build()
                 },
                 // Quest Reward Trigger
                 new Enchantment
                 {
                     Area = EEnchantmentArea.SELF,
                     Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                     Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsQuestDone))
                        .TriggerEffect(EGameTag.QUEST_PROGRESS, 1)
                        .SingleTask(new QuestRewardTask("UNG_942t"))
                        .Build()
                 },
            });

            // ----------------------------------------- SPELL - SHAMAN
            // [UNG_956] Spirit Echo - COST:3 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: Give your minions "<b>Deathrattle:</b> Return _this to your hand."
            // --------------------------------------------------------
            // RefTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_956", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_956e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new AddEnchantmentTask(EEntityType.MINIONS,
                        new Enchantment
                        {
                            Activation = EEnchantmentActivation.DEATHRATTLE,
                            SingleTask = new ReturnHandTask(EEntityType.TARGET)
                        })
                },
            });
        }

        private static void ShamanNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------- ENCHANTMENT - SHAMAN
            // [UNG_956e] Echoed Spirit (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Return to your hand.
            // --------------------------------------------------------
            cards.Add("UNG_956e", null);

            // ---------------------------------------- MINION - SHAMAN
            // [UNG_208t] Rock Elemental (*) - COST:2 [ATK:2/HP:3] 
            // - Race: elemental, Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_208t", null);

            // ---------------------------------------- MINION - SHAMAN
            // [UNG_211aa] Stone Elemental (*) - COST:1 [ATK:1/HP:1] 
            // - Race: elemental, Fac: neutral, Set: ungoro, 
            // --------------------------------------------------------
            cards.Add("UNG_211aa", null);

            // ---------------------------------------- MINION - SHAMAN
            // [UNG_942t] Megafin (*) - COST:5 [ATK:8/HP:8] 
            // - Race: murloc, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Fill your hand with random Murlocs.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_942t", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new EnqueueTask(10, ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.IsHandFull),
                        new FlagTask(false, ComplexTask.Create(
                        new RandomMinionTask(EGameTag.CARDRACE, (int)ERace.MURLOC),
                        new AddStackTo(EEntityType.HAND)))))
                },
            });

            // ----------------------------------------- SPELL - SHAMAN
            // [UNG_211a] Invocation of Earth (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Fill your board with 1/1 Elementals.
            // --------------------------------------------------------
            cards.Add("UNG_211a", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(7, new SummonTask("UNG_211aa"))
                },
            });

            // ----------------------------------------- SPELL - SHAMAN
            // [UNG_211b] Invocation of Water (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Restore 12 Health to your hero.
            // --------------------------------------------------------
            cards.Add("UNG_211b", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new HealTask(12, EEntityType.HERO)
                },
            });

            // ----------------------------------------- SPELL - SHAMAN
            // [UNG_211c] Invocation of Fire (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Deal 6 damage to the enemy hero.
            // --------------------------------------------------------
            // GameTag:
            // - ImmuneToSpellpower = 1
            // --------------------------------------------------------
            cards.Add("UNG_211c", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(6, EEntityType.OP_HERO),
                },
            });

            // ----------------------------------------- SPELL - SHAMAN
            // [UNG_211d] Invocation of Air (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Deal 3 damage to all enemy minions.
            // --------------------------------------------------------
            // GameTag:
            // - ImmuneToSpellpower = 1
            // --------------------------------------------------------
            cards.Add("UNG_211d", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(3, EEntityType.OP_MINIONS)
                },
            });
        }

        private static void Warlock(IDictionary<string, List<Enchantment>> cards)
        {
            // --------------------------------------- MINION - WARLOCK
            // [UNG_047] Ravenous Pterrordax - COST:4 [ATK:4/HP:4] 
            // - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Destroy a friendly minion to <b>Adapt</b>_twice.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_047", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new DestroyTask(EEntityType.TARGET),
                        new EnqueueTask(2, new AdaptTask(EEntityType.SOURCE)))
                },
            });

            // --------------------------------------- MINION - WARLOCK
            // [UNG_049] Tar Lurker - COST:5 [ATK:1/HP:7] 
            // - Race: elemental, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       Has +3 Attack during your opponent's turn.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_049", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BOARD,
                    SingleTask = new BuffTask(Buffs.OnlyOpponentTurn(EGameTag.ATK, 3), EEntityType.SOURCE)
                }
            });

            // --------------------------------------- MINION - WARLOCK
            // [UNG_830] Cruel Dinomancer - COST:6 [ATK:5/HP:5] 
            // - Fac: neutral, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: [x]<b>Deathrattle:</b> Summon a
            //       random minion you
            //       discarded this game.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_830", new List<Enchantment>
            {
                // TODO [UNG_830] Cruel Dinomancer && Test: Cruel Dinomancer_UNG_830
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = null,
                },
            });

            // --------------------------------------- MINION - WARLOCK
            // [UNG_833] Lakkari Felhound - COST:4 [ATK:3/HP:8] 
            // - Race: demon, Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       <b>Battlecry:</b> Discard two random cards.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_833", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.DiscardRandomCard(2)
                },
            });

            // --------------------------------------- MINION - WARLOCK
            // [UNG_835] Chittering Tunneler - COST:3 [ATK:3/HP:3] 
            // - Race: beast, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> <b>Discover</b> a spell. Deal damage to your hero equal to its Cost.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_835", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new DiscoverTask(EDiscoverType.SPELL,
                        new Enchantment()
                        {
                            Activation = EEnchantmentActivation.HAND,
                            SingleTask = ComplexTask.Create(
                                new GetGameTagTask(EGameTag.COST, EEntityType.SOURCE),
                                new DamageNumberTask(EEntityType.HERO)),
                            RemoveAfterActivation = true
                        })
                },
            });

            // --------------------------------------- MINION - WARLOCK
            // [UNG_836] Clutchmother Zavas - COST:2 [ATK:2/HP:2] 
            // - Race: beast, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: Whenever you discard this, give it +2/+2 and return it to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - InvisibleDeathrattle = 1
            // --------------------------------------------------------
            cards.Add("UNG_836", new List<Enchantment>
            {
                // TODO [UNG_836] Clutchmother Zavas && Test: Clutchmother Zavas_UNG_836
                new Enchantment
                {
                    InfoCardId = "UNG_836e",
                    //Activation = null,
                    //SingleTask = null,
                }
            });

            // ---------------------------------------- SPELL - WARLOCK
            // [UNG_829] Lakkari Sacrifice - COST:1 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]<b>Quest:</b> Discard 6 cards.
            //       <b>Reward:</b> Nether Portal.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - QUEST = 1
            // - QUEST_PROGRESS_TOTAL = 6
            // - 676 = 1
            // --------------------------------------------------------
            cards.Add("UNG_829", new List<Enchantment>
            {
                // TODO [UNG_829] Lakkari Sacrifice && Test: Lakkari Sacrifice_UNG_829
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });

            // ---------------------------------------- SPELL - WARLOCK
            // [UNG_831] Corrupting Mist - COST:2 
            // - Fac: neutral, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: Corrupt every minion. Destroy them at the start of your next turn.
            // --------------------------------------------------------
            cards.Add("UNG_831", new List<Enchantment>
            {
                // TODO [UNG_831] Corrupting Mist && Test: Corrupting Mist_UNG_831
                new Enchantment
                {
                    InfoCardId = "UNG_831e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });

            // ---------------------------------------- SPELL - WARLOCK
            // [UNG_832] Bloodbloom - COST:2 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: The next spell you cast this turn costs Health instead of Mana.
            // --------------------------------------------------------
            // Entourage: UNG_999t10, UNG_999t2, UNG_999t3, UNG_999t4, UNG_999t5, UNG_999t6, UNG_999t7, UNG_999t8, UNG_999t13, UNG_999t14
            // --------------------------------------------------------
            cards.Add("UNG_832", new List<Enchantment>
            {
                // TODO [UNG_832] Bloodbloom && Test: Bloodbloom_UNG_832
                new Enchantment
                {
                    InfoCardId = "UNG_832e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });

            // ---------------------------------------- SPELL - WARLOCK
            // [UNG_834] Feeding Time - COST:5 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: Deal $3 damage to a minion. Summon three 1/1 Pterrordaxes. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_834", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(3, EEntityType.TARGET, true),
                        new EnqueueTask(3, new SummonTask("UNG_834t1")))
                },
            });
        }

        private static void WarlockNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------- ENCHANTMENT - WARLOCK
            // [UNG_831e] Corrupting Mist (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: At the start of the corrupting player's turn, destroy this minion.
            // --------------------------------------------------------
            cards.Add("UNG_831e", null);

            // ---------------------------------- ENCHANTMENT - WARLOCK
            // [UNG_836e] Remembrance (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: +2/+2 each time this is discarded.
            // --------------------------------------------------------
            cards.Add("UNG_836e", null);

            // --------------------------------------- MINION - WARLOCK
            // [UNG_829t2] Nether Portal (*) - COST:11 [ATK:0/HP:1] 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: At the end of your turn, summon two 3/2 Imps.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - HIDE_STATS = 1
            // - UNTOUCHABLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_829t2", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.CONTROLLER,
                    Activation = EEnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(EGameTag.TURN_START, -1)
                        .SingleTask(new EnqueueTask(2, new SummonTask("UNG_829t3")))
                        .Build()
                }
            });

            // --------------------------------------- MINION - WARLOCK
            // [UNG_829t3] Nether Imp (*) - COST:2 [ATK:3/HP:2] 
            // - Race: demon, Set: ungoro, 
            // --------------------------------------------------------
            cards.Add("UNG_829t3", null);

            // --------------------------------------- MINION - WARLOCK
            // [UNG_834t1] Pterrordax (*) - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Set: ungoro, 
            // --------------------------------------------------------
            cards.Add("UNG_834t1", null);

            // ---------------------------------------- SPELL - WARLOCK
            // [UNG_829t1] Nether Portal (*) - COST:5 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: Open a permanent portal that summons 3/2 Imps.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NUM_MINION_SLOTS = 1
            // --------------------------------------------------------
            cards.Add("UNG_829t1", new List<Enchantment>
            {
                // @darkfriend77 Please confirm this!
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new SummonTask("UNG_829t2")
                },
            });
        }

        private static void Warrior(IDictionary<string, List<Enchantment>> cards)
        {
            // --------------------------------------- MINION - WARRIOR
            // [UNG_838] Tar Lord - COST:7 [ATK:1/HP:11] 
            // - Race: elemental, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       Has +4 Attack during your opponent’s turn.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_838", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BOARD,
                    SingleTask = new BuffTask(Buffs.OnlyOpponentTurn(EGameTag.ATK, 4), EEntityType.SOURCE)
                },
            });

            // --------------------------------------- MINION - WARRIOR
            // [UNG_925] Ornery Direhorn - COST:6 [ATK:5/HP:5] 
            // - Race: beast, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       <b>Battlecry:</b> <b>Adapt</b>.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_925", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new AdaptTask(EEntityType.SOURCE)
                },
            });

            // --------------------------------------- MINION - WARRIOR
            // [UNG_926] Cornered Sentry - COST:2 [ATK:2/HP:6] 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Taunt</b>. <b>Battlecry:</b> Summon three 1/1 Raptors for your_opponent.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_926", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new EnqueueTask(3, new SummonTask("UNG_076t1"))
                },
            });

            // --------------------------------------- MINION - WARRIOR
            // [UNG_933] King Mosh - COST:9 [ATK:9/HP:7] 
            // - Race: beast, Fac: neutral, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Destroy all damaged minions.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_933", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.ALLMINIONS),
                        new FilterStackTask(SelfCondition.IsDamaged),
                        new DestroyTask(EEntityType.STACK)),
                },
            });

            // --------------------------------------- MINION - WARRIOR
            // [UNG_957] Direhorn Hatchling - COST:5 [ATK:3/HP:6] 
            // - Race: beast, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       <b>Deathrattle:</b> Shuffle a 6/9 Direhorn with <b>Taunt</b> into your deck.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_957", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = new AddCardTo("UNG_957t1", EEntityType.DECK)
                },
            });

            // ---------------------------------------- SPELL - WARRIOR
            // [UNG_922] Explore Un'Goro - COST:2 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: Replace your deck with_copies of "<b>Discover</b> a card."
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_922", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new ReplaceTask(EEntityType.DECK, "UNG_922t1")
                },
            });

            // ---------------------------------------- SPELL - WARRIOR
            // [UNG_923] Iron Hide - COST:1 
            // - Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: Gain 5 Armor.
            // --------------------------------------------------------
            cards.Add("UNG_923", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new ArmorTask(5),
                },
            });

            // ---------------------------------------- SPELL - WARRIOR
            // [UNG_927] Sudden Genesis - COST:5 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: Summon copies of your damaged minions.
            // --------------------------------------------------------
            cards.Add("UNG_927", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.MINIONS),
                        new FilterStackTask(SelfCondition.IsDamaged),
                        new SummonCopyTask(EEntityType.STACK))
                },
            });

            // ---------------------------------------- SPELL - WARRIOR
            // [UNG_934] Fire Plume's Heart - COST:1 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]<b>Quest:</b> Play
            //       7 <b>Taunt</b> minions.
            //       <b>Reward:</b> Sulfuras.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - QUEST = 1
            // - QUEST_PROGRESS_TOTAL = 7
            // - 676 = 1
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_934", new List<Enchantment>
            {
                // Quest Contributor Trigger
                new Enchantment
                {
                    Area = EEnchantmentArea.HAND,
                    Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.HAND),
                        new FilterStackTask(SelfCondition.IsTagValue(EGameTag.TAUNT, 1)),
                        new SetGameTagTask(EGameTag.QUEST_CONTRIBUTOR, 1, EEntityType.STACK)),
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsTagValue(EGameTag.TAUNT, 1)))
                        .TriggerEffect(EGameTag.ZONE_POSITION, 0)
                        .SingleTask(new SetGameTagTask(EGameTag.QUEST_CONTRIBUTOR, 1, EEntityType.TARGET))
                        .Build()
                },
                // Quest Progress Trigger
                new Enchantment
                {
                    Area = EEnchantmentArea.HAND_AND_BOARD,
                    Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsTagValue(EGameTag.QUEST_CONTRIBUTOR, 1)))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(new QuestProgressTask())
                        .Build()
                },
                // Quest Reward Trigger
                new Enchantment
                {
                    Area = EEnchantmentArea.SELF,
                    Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsQuestDone))
                        .TriggerEffect(EGameTag.QUEST_PROGRESS, 1)
                        .SingleTask(new QuestRewardTask("UNG_934t1"))
                        .Build()
                },

            });

            // --------------------------------------- WEAPON - WARRIOR
            // [UNG_929] Molten Blade - COST:1 [ATK:1/HP:0] 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: Each turn this is in your hand, transform it into a new weapon.
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 1
            // --------------------------------------------------------
            cards.Add("UNG_929", new List<Enchantment>
            {
                // TODO [UNG_929] Molten Blade && Test: Molten Blade_UNG_929
                new Enchantment
                {
                    InfoCardId = "UNG_929e",
                    Activation = EEnchantmentActivation.WEAPON,
                    SingleTask = null,
                },
            });
        }

        private static void WarriorNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [UNG_929e] Magmic (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Transforming into random weapons.
            // --------------------------------------------------------
            cards.Add("UNG_929e", null);

            // --------------------------------------- MINION - WARRIOR
            // [UNG_957t1] Direhorn Matriarch (*) - COST:5 [ATK:6/HP:9] 
            // - Race: beast, Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_957t1", null);

            // ---------------------------------------- SPELL - WARRIOR
            // [UNG_922t1] Choose Your Path (*) - COST:1 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Discover</b> a card.
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_922t1", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new DiscoverTask(EDiscoverType.ALL)
                },
            });

            // --------------------------------------- WEAPON - WARRIOR
            // [UNG_934t1] Sulfuras (*) - COST:3 [ATK:4/HP:0] 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Your Hero Power becomes 'Deal 8 damage to a random enemy.'
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 2
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_934t1", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new ReplaceHeroPower(Cards.FromId("UNG_934t2")),
                },
            });
        }

        private static void Neutral(IDictionary<string, List<Enchantment>> cards)
        {
            // --------------------------------------- MINION - NEUTRAL
            // [UNG_001] Pterrordax Hatchling - COST:3 [ATK:2/HP:2] 
            // - Race: beast, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b><b>Battlecry:</b> Adapt</b>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_001", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new AdaptTask(EEntityType.SOURCE)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_002] Volcanosaur - COST:7 [ATK:5/HP:6] 
            // - Race: beast, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> <b>Adapt</b>, then_<b>Adapt</b>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_002", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new EnqueueTask(2, new AdaptTask(EEntityType.SOURCE))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_009] Ravasaur Runt - COST:2 [ATK:2/HP:2] 
            // - Race: beast, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If you control at_least 2 other minions, <b>Adapt.</b>
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_009", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.IsBoardCount(3, ERelaSign.GEQ)),
                        new FlagTask(true, new AdaptTask(EEntityType.SOURCE))),
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_010] Sated Threshadon - COST:7 [ATK:5/HP:7] 
            // - Race: beast, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Summon three 1/1 Murlocs.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_010", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(3, new SummonTask("CFM_310t")),
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_070] Tol'vir Stoneshaper - COST:4 [ATK:3/HP:5] 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: [x]<b>Battlecry:</b> If you played an
            //       Elemental last turn, gain
            //       _<b>Taunt</b> and <b>Divine_Shield</b>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // - DIVINE_SHIELD = 1
            // --------------------------------------------------------
            cards.Add("UNG_070", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_070e",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
                        new FlagTask(true, ComplexTask.Create(
                            ComplexTask.Taunt(EEntityType.SOURCE),
                            ComplexTask.DivineShield(EEntityType.SOURCE))))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_071] Giant Mastodon - COST:9 [ATK:6/HP:10] 
            // - Race: beast, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_071", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_072] Stonehill Defender - COST:3 [ATK:1/HP:4] 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       <b>Battlecry:</b> <b>Discover</b> a <b>Taunt</b>_minion.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_072", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new DiscoverTask(EDiscoverType.TAUNT)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_073] Rockpool Hunter - COST:2 [ATK:2/HP:3] 
            // - Race: murloc, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Give a friendly Murloc +1/+1.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_WITH_RACE = 14
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("UNG_073", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_073e",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new BuffTask(Buffs.AttackHealth(1), EEntityType.TARGET)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_075] Vicious Fledgling - COST:3 [ATK:3/HP:3] 
            // - Race: beast, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: After this minion attacks a_hero, <b>Adapt</b>.
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_075", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.BOARD,
                    Activation = EEnchantmentActivation.DECK,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced, SelfCondition.IsAttacking)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsHero))
                        .TriggerEffect(EGameTag.ATTACKING, 1)
                        .FastExecution(true)
                        .SingleTask(new AdaptTask(EEntityType.SOURCE))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_076] Eggnapper - COST:3 [ATK:3/HP:1] 
            // - Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Summon two 1/1 Raptors.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_076", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = new EnqueueTask(2, new SummonTask("UNG_076t1"))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_079] Frozen Crusher - COST:6 [ATK:8/HP:8] 
            // - Race: elemental, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: After this minion attacks, <b>Freeze</b> it.
            // --------------------------------------------------------
            // RefTag:
            // - FREEZE = 1
            // --------------------------------------------------------
            cards.Add("UNG_079", new List<Enchantment>
            {
                // TODO [UNG_079] Frozen Crusher && Test: Frozen Crusher_UNG_079
                new Enchantment
                {
                    //Activation = null,
                    //SingleTask = null,
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_082] Thunder Lizard - COST:3 [ATK:3/HP:3] 
            // - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry</b>: If you played an_Elemental last turn, <b>Adapt</b>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_082", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
                        new FlagTask(true, new AdaptTask(EEntityType.SOURCE)))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_083] Devilsaur Egg - COST:3 [ATK:0/HP:3] 
            // - Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Summon a 5/5 Devilsaur.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_083", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = new SummonTask("UNG_083t1"),
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_084] Fire Plume Phoenix - COST:4 [ATK:3/HP:3] 
            // - Race: elemental, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal 2 damage.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NONSELF_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("UNG_084", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(2, EEntityType.TARGET),
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_085] Emerald Hive Queen - COST:1 [ATK:2/HP:3] 
            // - Race: beast, Fac: horde, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: Your minions cost (2) more.
            // --------------------------------------------------------
            // GameTag:
            // - AURA = 1
            // --------------------------------------------------------
            cards.Add("UNG_085", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.Cost(2), EAuraArea.HAND)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_087] Bittertide Hydra - COST:5 [ATK:8/HP:8] 
            // - Race: beast, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: Whenever this minion takes damage, deal 3 damage to_your hero.
            // --------------------------------------------------------
            cards.Add("UNG_087", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.SELF,
                    Activation = EEnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(EGameTag.DAMAGE, 1)
                        .SingleTask(new DamageTask(3, EEntityType.HERO))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_088] Tortollan Primalist - COST:8 [ATK:5/HP:4] 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> <b>Discover</b> a spell_and cast it with random targets.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_088", new List<Enchantment>
            {
                // TODO [UNG_088] Tortollan Primalist && Test: Tortollan Primalist_UNG_088
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = null,
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_089] Gentle Megasaur - COST:4 [ATK:5/HP:4] 
            // - Race: beast, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> <b>Adapt</b> your_Murlocs.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - ADAPT = 1
            // --------------------------------------------------------
            cards.Add("UNG_089", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.MINIONS),
                        new FilterStackTask(SelfCondition.IsRace(ERace.MURLOC)),
                        new AdaptTask(EEntityType.STACK))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_099] Charged Devilsaur - COST:8 [ATK:7/HP:7] 
            // - Race: beast, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            //       <b>Battlecry:</b> Can't attack heroes this turn.
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_099", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new BuffTask(Buffs.Simple(EGameTag.CANNOT_ATTACK_HEROES, 1, true), EEntityType.SOURCE)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_113] Bright-Eyed Scout - COST:4 [ATK:3/HP:4] 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Draw a card. Change its Cost to (5).
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_113", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_113e",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new DrawTask(true),
                        new BuffTask(Buffs.SimpleFix(EGameTag.COST, 5), EEntityType.STACK))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_205] Glacial Shard - COST:1 [ATK:2/HP:1] 
            // - Race: elemental, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> <b>Freeze</b> an_enemy.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_ENEMY_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            // RefTag:
            // - FREEZE = 1
            // --------------------------------------------------------
            cards.Add("UNG_205", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Freeze(EEntityType.TARGET)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_801] Nesting Roc - COST:5 [ATK:4/HP:7] 
            // - Race: beast, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If you control at_least 2 other minions, gain <b>Taunt</b>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_801", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.IsBoardCount(3, ERelaSign.GEQ)),
                        new FlagTask(true, ComplexTask.Taunt(EEntityType.SOURCE)))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_803] Emerald Reaver - COST:1 [ATK:2/HP:1] 
            // - Race: beast, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal 1 damage to each hero.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_803", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(1, EEntityType.HEROES),
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_806] Ultrasaur - COST:10 [ATK:7/HP:14] 
            // - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            cards.Add("UNG_806", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_807] Golakka Crawler - COST:2 [ATK:2/HP:3] 
            // - Race: beast, Fac: neutral, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Destroy a Pirate and gain +1/+1.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_WITH_RACE = 23
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("UNG_807", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_807e",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.TARGET, SelfCondition.IsRace(ERace.PIRATE)),
                        new FlagTask(true, new DestroyTask(EEntityType.TARGET)),
                        new FlagTask(true, new BuffTask(Buffs.AttackHealth(1), EEntityType.SOURCE)))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_808] Stubborn Gastropod - COST:2 [ATK:1/HP:2] 
            // - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       <b>Poisonous</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - POISONOUS = 1
            // --------------------------------------------------------
            cards.Add("UNG_808", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_809] Fire Fly - COST:1 [ATK:1/HP:2] 
            // - Race: elemental, Fac: alliance, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry</b>: Add a 1/2 Elemental to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_809", new List<Enchantment>
            {
                 new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new AddCardTo("UNG_809t1", EEntityType.HAND)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_810] Stegodon - COST:4 [ATK:2/HP:6] 
            // - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_810", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_812] Sabretooth Stalker - COST:6 [ATK:8/HP:2] 
            // - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Stealth</b>
            // --------------------------------------------------------
            // GameTag:
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("UNG_812", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_813] Stormwatcher - COST:7 [ATK:4/HP:8] 
            // - Race: elemental, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Windfury</b>
            // --------------------------------------------------------
            // GameTag:
            // - WINDFURY = 1
            // --------------------------------------------------------
            cards.Add("UNG_813", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_814] Giant Wasp - COST:3 [ATK:2/HP:2] 
            // - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Stealth</b>
            //       <b>Poisonous</b>
            // --------------------------------------------------------
            // GameTag:
            // - STEALTH = 1
            // - POISONOUS = 1
            // --------------------------------------------------------
            cards.Add("UNG_814", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_816] Servant of Kalimos - COST:5 [ATK:4/HP:5] 
            // - Race: elemental, Fac: neutral, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: [x]<b>Battlecry:</b> If you played
            //       an Elemental last turn,
            //       _<b>Discover</b> an Elemental.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_WITH_DEATHRATTLE = 0
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_816", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
                        new FlagTask(true, new DiscoverTask(EDiscoverType.ELEMENTAL)))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_818] Volatile Elemental - COST:2 [ATK:1/HP:1] 
            // - Race: elemental, Fac: neutral, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Deal 3 damage to a random enemy minion.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_818", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.DamageRandomTargets(1, EEntityType.OP_MINIONS, 3)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_840] Hemet, Jungle Hunter - COST:6 [ATK:6/HP:6] 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Destroy all cards in your deck that cost (3)_or less.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_840", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.DECK),
                        new FilterStackTask(SelfCondition.IsTagValue(EGameTag.COST, 3, ERelaSign.LEQ)),
                        new MoveToSetaside(EEntityType.STACK))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_843] The Voraxx - COST:4 [ATK:3/HP:3] 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]After you cast a spell on
            //       this minion, summon a
            //       1/1 Plant and cast
            //       another copy on it.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("UNG_843", new List<Enchantment>
            {
                // TODO [UNG_843] The Voraxx && Test: The Voraxx_UNG_843
                new Enchantment
                {
                    //Activation = null,
                    //SingleTask = null,
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_844] Humongous Razorleaf - COST:3 [ATK:4/HP:8] 
            // - Fac: alliance, Set: ungoro, Rarity: rare
            // --------------------------------------------------------
            // Text: Can't attack.
            // --------------------------------------------------------
            // GameTag:
            // - CANT_ATTACK = 1
            // --------------------------------------------------------
            cards.Add("UNG_844", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_845] Igneous Elemental - COST:3 [ATK:2/HP:3] 
            // - Race: elemental, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Add two 1/2 Elementals to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("UNG_845", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = new EnqueueTask(2, new AddCardTo("UNG_809t1", EEntityType.HAND))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_847] Blazecaller - COST:7 [ATK:6/HP:6] 
            // - Race: elemental, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If you played an_Elemental last turn, deal 5 damage.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NONSELF_TARGET = 0
            // - REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN = 0
            // --------------------------------------------------------
            cards.Add("UNG_847", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.ElementalPlayedLastTurn),
                        new FlagTask(true, new DamageTask(5, EEntityType.TARGET)))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_848] Primordial Drake - COST:8 [ATK:4/HP:8] 
            // - Race: dragon, Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: [x]<b>Taunt</b>
            //       <b>Battlecry:</b> Deal 2 damage
            //       to all other minions.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_848", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(2, EEntityType.ALLMINIONS_NOSOURCE)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_851] Elise the Trailblazer - COST:5 [ATK:5/HP:5] 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Shuffle a sealed_<b>Un'Goro</b> pack into_your deck.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_851", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new AddCardTo("UNG_851t1", EEntityType.DECK)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_900] Spiritsinger Umbra - COST:4 [ATK:3/HP:4] 
            // - Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: After you summon a minion, trigger its <b>Deathrattle</b> effect.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            // RefTag:
            // - DEATHRATTLE = 1 
            // --------------------------------------------------------
            cards.Add("UNG_900", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.BOARD,
                    Activation = EEnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.HAND), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsDeathrattleMinion))
                        .TriggerEffect(EGameTag.SUMMONED, 1)
                        .SingleTask(new ActivateEnchantment(EEntityType.TARGET, EEnchantmentActivation.DEATHRATTLE))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_907] Ozruk - COST:9 [ATK:5/HP:5] 
            // - Race: elemental, Set: ungoro, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]<b>Taunt</b>
            //       <b>Battlecry:</b> Gain +5 Health
            //       for each Elemental you
            //       played last turn.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("UNG_907", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_907e",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new GetGameTagControllerTask(EGameTag.NUM_ELEMENTAL_PLAYED_LAST_TURN),
                        new MathMultiplyTask(5),
                        new BuffHealthNumberTask(EEntityType.SOURCE))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_928] Tar Creeper - COST:3 [ATK:1/HP:5] 
            // - Race: elemental, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       Has +2 Attack during your opponent's turn.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("UNG_928", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BOARD,
                    SingleTask = new BuffTask(Buffs.OnlyOpponentTurn(EGameTag.ATK, 2), EEntityType.SOURCE)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_937] Primalfin Lookout - COST:3 [ATK:3/HP:2] 
            // - Race: murloc, Set: ungoro, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If you control another Murloc, <b>Discover</b> a_Murloc.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("UNG_937", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.MINIONS_NOSOURCE, SelfCondition.IsControllingRace(ERace.MURLOC)),
                        new FlagTask(true, new DiscoverTask(EDiscoverType.MURLOC)))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_946] Gluttonous Ooze - COST:3 [ATK:3/HP:3] 
            // - Set: ungoro, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Destroy your opponent's weapon and gain Armor equal to its Attack.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_WITH_DEATHRATTLE = 0
            // --------------------------------------------------------
            cards.Add("UNG_946", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new GetGameTagTask(EGameTag.ATK, EEntityType.OP_WEAPON),
                        new DestroyTask(EEntityType.OP_WEAPON),
                        new ArmorTask())
                },
            });
        }

        private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [UNG_067t1e] Crystallized (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Your minions are 5/5.
            // --------------------------------------------------------
            cards.Add("UNG_067t1e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [UNG_067t1e2] Crystallized (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: 5/5.
            // --------------------------------------------------------
            cards.Add("UNG_067t1e2", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [UNG_070e] Stonewall (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Divine Shield</b> and <b>Taunt</b>.
            // --------------------------------------------------------
            cards.Add("UNG_070e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [UNG_073e] Trained (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: +1/+1
            // --------------------------------------------------------
            cards.Add("UNG_073e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [UNG_113e] Scouted (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Costs (5).
            // --------------------------------------------------------
            cards.Add("UNG_113e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [UNG_807e] Overfull Belly (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("UNG_807e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [UNG_832e] Dark Power (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Your next spell costs Health instead of Mana.
            // --------------------------------------------------------
            cards.Add("UNG_832e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [UNG_907e] Just Blaze (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: +5 Health
            // --------------------------------------------------------
            cards.Add("UNG_907e", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_076t1] Raptor (*) - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Set: ungoro, 
            // --------------------------------------------------------
            cards.Add("UNG_076t1", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_083t1] Devilsaur (*) - COST:5 [ATK:5/HP:5] 
            // - Race: beast, Set: ungoro, 
            // --------------------------------------------------------
            cards.Add("UNG_083t1", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_201t] Primalfin (*) - COST:1 [ATK:1/HP:1] 
            // - Race: murloc, Set: ungoro, 
            // --------------------------------------------------------
            cards.Add("UNG_201t", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_809t1] Flame Elemental (*) - COST:1 [ATK:1/HP:2] 
            // - Race: elemental, Fac: alliance, Set: ungoro, 
            // --------------------------------------------------------
            cards.Add("UNG_809t1", null);

            // --------------------------------------- MINION - NEUTRAL
            // [UNG_999t2t1] Plant (*) - COST:1 [ATK:1/HP:1] 
            // - Set: ungoro, 
            // --------------------------------------------------------
            cards.Add("UNG_999t2t1", null);

            // ---------------------------------------- SPELL - NEUTRAL
            // [UNG_851t1] Un'Goro Pack (*) - COST:2 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Add 5 <b>Journey to Un'Goro</b> cards to your hand.
            // --------------------------------------------------------
            cards.Add("UNG_851t1", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(5, ComplexTask.Create(
                        new RandomCardTask(ECardSet.UNGORO),
                        new AddStackTo(EEntityType.HAND)))
                },
            });

            // ---------------------------------------- SPELL - NEUTRAL
            // [UNG_999t10] Shrouding Mist (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Stealth</b> until your next turn.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_999t10", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_999t10e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new BuffStealthTask(EEntityType.TARGET)
                },
            });

            // ---------------------------------------- SPELL - NEUTRAL
            // [UNG_999t13] Poison Spit (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Poisonous</b>
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_999t13", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_999t13e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new SetGameTagTask(EGameTag.POISONOUS, 1, EEntityType.TARGET)
                },
            });

            // ---------------------------------------- SPELL - NEUTRAL
            // [UNG_999t14] Volcanic Might (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: +1/+1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_999t14", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_999t14e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackHealth(1), EEntityType.TARGET)
                },
            });

            // ---------------------------------------- SPELL - NEUTRAL
            // [UNG_999t2] Living Spores (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Summon two 1/1 Plants.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_999t2", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_999t2e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new AddEnchantmentTask(EEntityType.TARGET,
                            new Enchantment
                            {
                                Activation = EEnchantmentActivation.DEATHRATTLE,
                                SingleTask = new EnqueueTask(2, new SummonTask("UNG_999t2t1"))
                            })
                }
            });

            // ---------------------------------------- SPELL - NEUTRAL
            // [UNG_999t3] Flaming Claws (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: +3 Attack
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_999t3", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_999t3e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.Attack(3), EEntityType.TARGET)
                },
            });

            // ---------------------------------------- SPELL - NEUTRAL
            // [UNG_999t4] Rocky Carapace (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: +3 Health
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_999t4", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_999t4e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.Health(3), EEntityType.TARGET)
                },
            });

            // ---------------------------------------- SPELL - NEUTRAL
            // [UNG_999t5] Liquid Membrane (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: Can't be targeted by spells or Hero Powers.
            // --------------------------------------------------------
            // GameTag:
            // - CANT_BE_TARGETED_BY_SPELLS = 1
            // - CANT_BE_TARGETED_BY_HERO_POWERS = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_999t5", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_999t5e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new SetGameTagTask(EGameTag.CANT_BE_TARGETED_BY_SPELLS, 1, EEntityType.TARGET),
                        new SetGameTagTask(EGameTag.CANT_BE_TARGETED_BY_HERO_POWERS, 1, EEntityType.TARGET)),
                },
            });

            // ---------------------------------------- SPELL - NEUTRAL
            // [UNG_999t6] Massive (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_999t6", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_999t6e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Taunt(EEntityType.TARGET),
                },
            });

            // ---------------------------------------- SPELL - NEUTRAL
            // [UNG_999t7] Lightning Speed (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Windfury</b>
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_999t7", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_999t7e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.WindFury(EEntityType.TARGET),
                },
            });

            // ---------------------------------------- SPELL - NEUTRAL
            // [UNG_999t8] Crackling Shield (*) - COST:0 
            // - Set: ungoro, 
            // --------------------------------------------------------
            // Text: <b>Divine Shield</b>
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("UNG_999t8", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "UNG_999t8e",
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.DivineShield(EEntityType.TARGET),
                },
            });
        }

        public static void AddAll(Dictionary<string, List<Enchantment>> cards)
        {
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
            Neutral(cards);
            NeutralNonCollect(cards);
        }
    }
}