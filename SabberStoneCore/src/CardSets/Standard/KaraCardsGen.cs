using System.Collections.Generic;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Standard
{
    public class KaraCardsGen
    {
        private static void Heroes(IDictionary<string, List<Enchantment>> cards)
        {
        }

        private static void HeroPowers(IDictionary<string, List<Enchantment>> cards)
        {
        }

        private static void Druid(IDictionary<string, List<Enchantment>> cards)
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
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_WITH_RACE = 20
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("KAR_065", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new CopyTask(EEntityType.TARGET, 1),
                        new SummonTask())
                },
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
            cards.Add("KAR_075", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new HealTask(6, EEntityType.TARGET),
                        ComplexTask.SummonRandomMinion(EGameTag.COST, 6))
                }
            });
        }

        private static void Hunter(IDictionary<string, List<Enchantment>> cards)
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
            cards.Add("KAR_005", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = new SummonTask("KAR_005a"),
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [KAR_006] Cloaked Huntress - COST:3 [ATK:3/HP:4]
            // - Set: kara, Rarity: common
            // --------------------------------------------------------
            // Text: Your <b>Secrets</b> cost (0).
            // --------------------------------------------------------
            // RefTag:
            // - SECRET_OR_QUEST = 1
            // --------------------------------------------------------
            cards.Add("KAR_006", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BOARD,
                    SingleTask =
                        new AuraTask(
                            Auras.Cost(-99, RelaCondition.IsOther(SelfCondition.IsTagValue(EGameTag.SECRET, 1))),
                            EAuraArea.HAND)
                }
            });

            // ----------------------------------------- SPELL - HUNTER
            // [KAR_004] Cat Trick - COST:2
            // - Set: kara, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Secret:</b> After your opponent casts a spell, summon a 4/2 Panther with <b>Stealth</b>.
            // --------------------------------------------------------
            // GameTag:
            // - SECRET_OR_QUEST = 1
            // --------------------------------------------------------
            // RefTag:
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("KAR_004", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.OP_HAND,
                    Activation = EEnchantmentActivation.SECRET_OR_QUEST,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretOrQuestActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(ComplexTask.Secret(
                            new SummonTask("KAR_004a")))
                        .Build()
                }
            });
        }

        private static void HunterNonCollect(IDictionary<string, List<Enchantment>> cards)
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

        private static void Mage(IDictionary<string, List<Enchantment>> cards)
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
            cards.Add("KAR_009", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RandomCardTask(ECardType.SPELL, ECardClass.MAGE),
                        new AddStackTo(EEntityType.HAND))
                }
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
            // - SECRET_OR_QUEST = 1
            // --------------------------------------------------------
            cards.Add("KAR_092", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(3, EEntityType.TARGET)
                },
            });

            // ------------------------------------------- SPELL - MAGE
            // [KAR_076] Firelands Portal - COST:7
            // - Set: kara, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $5 damage. Summon a random
            //       5-Cost minion. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("KAR_076", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(5, EEntityType.TARGET),
                        ComplexTask.SummonRandomMinion(EGameTag.COST, 5)),
                },
            });
        }

        private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
        }

        private static void Paladin(IDictionary<string, List<Enchantment>> cards)
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
            cards.Add("KAR_010", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.IsDragonInHand),
                        new FlagTask(true, new EnqueueTask(2, new SummonTask("KAR_010a")))),
                },
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
            // - TREASURE = 1
            // --------------------------------------------------------
            cards.Add("KAR_057", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BOARD,
                    SingleTask = new DiscoverTask(EDiscoverType.SPELL,
                        new Enchantment()
                        {
                            Activation = EEnchantmentActivation.HAND,
                            SingleTask = ComplexTask.Create(
                                new GetGameTagTask(EGameTag.COST, EEntityType.SOURCE),
                                new HealNumberTask(EEntityType.HERO)),
                            RemoveAfterActivation = true
                        }),
                },
            });

            // ---------------------------------------- SPELL - PALADIN
            // [KAR_077] Silvermoon Portal - COST:4
            // - Set: kara, Rarity: common
            // --------------------------------------------------------
            // Text: Give a minion +2/+2. Summon a random
            //       2-Cost minion.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("KAR_077", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new BuffTask(Buffs.AttackHealth(2), EEntityType.TARGET),
                        ComplexTask.SummonRandomMinion(EGameTag.COST, 2)),
                },
            });
        }

        private static void PaladinNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // --------------------------------------- MINION - PALADIN
            // [KAR_010a] Whelp (*) - COST:1 [ATK:1/HP:1]
            // - Race: dragon, Set: kara,
            // --------------------------------------------------------
            cards.Add("KAR_010a", null);
        }

        private static void Priest(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------------- MINION - PRIEST
            // [KAR_035] Priest of the Feast - COST:4 [ATK:3/HP:6]
            // - Fac: neutral, Set: kara, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever you cast a spell, restore 3 Health to
            //       your hero.
            // --------------------------------------------------------
            cards.Add("KAR_035", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.HAND,
                    Activation = EEnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(new HealTask(3, EEntityType.HERO))
                        .Build()
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
            cards.Add("KAR_204", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.SummonRandomMinionThatDied()
                },
            });
            // ----------------------------------------- SPELL - PRIEST
            // [KAR_013] Purify - COST:2
            // - Set: kara, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Silence</b> a friendly minion. Draw a card.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            // RefTag:
            // - SILENCE = 1
            // --------------------------------------------------------
            cards.Add("KAR_013", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new SilenceTask(EEntityType.TARGET),
                        new DrawTask()),
                },
            });
        }

        private static void Rogue(IDictionary<string, List<Enchantment>> cards)
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
            cards.Add("KAR_069", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RandomCardTask(EEntityType.OP_HERO),
                        new AddStackTo(EEntityType.HAND))
                },
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
            cards.Add("KAR_070", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.AnyNonClassCardInHand(ECardClass.ROGUE)),
                        new FlagTask(true, ComplexTask.Create(
                            new IncludeTask(EEntityType.HAND),
                            new FilterStackTask(SelfCondition.IsNotCardClass(ECardClass.ROGUE)),
                            new BuffTask(Buffs.Cost(-2), EEntityType.STACK))))
                },
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
            cards.Add("KAR_094", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = new AddCardTo("KAR_094a", EEntityType.HAND)
                },
            });
        }

        private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
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

        private static void Shaman(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------------- MINION - SHAMAN
            // [KAR_021] Wicked Witchdoctor - COST:4 [ATK:3/HP:4]
            // - Set: kara, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever you cast a spell, summon a random basic_Totem.
            // --------------------------------------------------------
            cards.Add("KAR_021", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.HAND,
                    Activation = EEnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(ComplexTask.Create(
                            new IncludeTask(EEntityType.SOURCE),
                            new FuncPlayablesTask(list =>
                            {
                                var controller = list[0].Controller;
                                var basicTotem = new List<string>
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
                            new SummonTask()
                        ))
                        .Build()
                }
            });

            // ----------------------------------------- SPELL - SHAMAN
            // [KAR_073] Maelstrom Portal - COST:2
            // - Set: kara, Rarity: rare
            // --------------------------------------------------------
            // Text: Deal_$1_damage to_all_enemy_minions. Summon_a_random
            //       1-Cost minion. *spelldmg
            // --------------------------------------------------------
            cards.Add("KAR_073", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(1, EEntityType.OP_MINIONS, true),
                        ComplexTask.SummonRandomMinion(EGameTag.COST, 1)),
                },
            });

            // ---------------------------------------- WEAPON - SHAMAN
            // [KAR_063] Spirit Claws - COST:1 [ATK:1/HP:0]
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
            cards.Add("KAR_063", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.SELF,
                    Activation = EEnchantmentActivation.WEAPON,
                    Enchant = Auras.WeaponAttack(2, RelaCondition.IsMe(SelfCondition.IsSpellDmgOnHero))
                },
            });
        }

        private static void Warlock(IDictionary<string, List<Enchantment>> cards)
        {
            // --------------------------------------- MINION - WARLOCK
            // [KAR_089] Malchezaar's Imp - COST:1 [ATK:1/HP:3]
            // - Race: demon, Set: kara, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever you discard a card, draw a card.
            // --------------------------------------------------------
            cards.Add("KAR_089", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.CONTROLLER,
                    Activation = EEnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsNotDead, SelfCondition.IsNotSilenced)
                        .TriggerEffect(EGameTag.LAST_CARD_DISCARDED, 0)
                        .SingleTask(new DrawTask())
                        .Build()
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
            cards.Add("KAR_205", new List<Enchantment>
            {
                // TODO [KAR_205] Silverware Golem && Test: Silverware Golem_KAR_205
                new Enchantment
                (
                    //Activation = null,
                    //SingleTask = null,
                )
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
            cards.Add("KAR_025", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new SummonTask("KAR_025a"),
                        new SummonTask("KAR_025b"),
                        new SummonTask("KAR_025c")),
                },
            });
        }

        private static void WarlockNonCollect(IDictionary<string, List<Enchantment>> cards)
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

            // --------------------------------------- MINION - WARLOCK
            // [KARA_00_02a] Abyssal (*) - COST:6 [ATK:6/HP:6]
            // - Race: demon, Set: kara,
            // --------------------------------------------------------
            cards.Add("KARA_00_02a", null);

            // --------------------------------------- MINION - WARLOCK
            // [KARA_09_08] Kil'rek (*) - COST:4 [ATK:2/HP:6]
            // - Race: demon, Set: kara,
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("KARA_09_08", null);

            // --------------------------------------- MINION - WARLOCK
            // [KARA_09_08_heroic] Kil'rek (*) - COST:4 [ATK:4/HP:8]
            // - Race: demon, Set: kara,
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("KARA_09_08_heroic", null);
        }

        private static void Warrior(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------------- SPELL - WARRIOR
            // [KAR_026] Protect the King! - COST:3
            // - Set: kara, Rarity: rare
            // --------------------------------------------------------
            // Text: For each enemy minion, summon a 1/1 Pawn with <b>Taunt</b>.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NUM_MINION_SLOTS = 1
            // - REQ_MINIMUM_ENEMY_MINIONS = 1
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("KAR_026", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new CountTask(EEntityType.OP_MINIONS),
                        new EnqueueNumberTask(new SummonTask("KAR_026t")))
                },
            });

            // ---------------------------------------- SPELL - WARRIOR
            // [KAR_091] Ironforge Portal - COST:5
            // - Set: kara, Rarity: common
            // --------------------------------------------------------
            // Text: Gain 4 Armor.
            //       Summon a random
            //       4-Cost minion.
            // --------------------------------------------------------
            cards.Add("KAR_091", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new ArmorTask(4),
                        ComplexTask.SummonRandomMinion(EGameTag.COST, 4)),
                },
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
            cards.Add("KAR_028", new List<Enchantment>
            {
                // TODO [KAR_028] Fool's Bane && Test: Fool's Bane_KAR_028
                new Enchantment
                {
                    Activation = EEnchantmentActivation.WEAPON,
                    SingleTask = null,
                },
            });
        }

        private static void WarriorNonCollect(IDictionary<string, List<Enchantment>> cards)
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

            // --------------------------------------- MINION - WARRIOR
            // [KARA_13_03] Orc Warrior (*) - COST:2 [ATK:3/HP:2]
            // - Set: kara,
            // --------------------------------------------------------
            cards.Add("KARA_13_03", null);

            // --------------------------------------- MINION - WARRIOR
            // [KARA_13_03H] Orc Warrior (*) - COST:2 [ATK:3/HP:3]
            // - Set: kara,
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("KARA_13_03H", null);
        }

        private static void Neutral(IDictionary<string, List<Enchantment>> cards)
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
            cards.Add("KAR_029", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = new DrawTask()
                },
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
            cards.Add("KAR_030a", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new SummonTask("KAR_030"),
                },
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
            // - REQ_TARGET_MAX_ATTACK = 3
            // - REQ_NONSELF_TARGET = 0
            // - REQ_ENEMY_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
            // - REQ_MINION_TARGET = 0
            // --------------------------------------------------------
            cards.Add("KAR_033", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.IsDragonInHand),
                        new FlagTask(true, new DestroyTask(EEntityType.TARGET)))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [KAR_036] Arcane Anomaly - COST:1 [ATK:2/HP:1]
            // - Race: elemental, Fac: neutral, Set: kara, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever you cast a spell, give this minion
            //       +1 Health.
            // --------------------------------------------------------
            cards.Add("KAR_036", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.HAND,
                    Activation = EEnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(new BuffTask(Buffs.Health(1), EEntityType.SOURCE))
                        .Build()
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
            // - SECRET_OR_QUEST = 1
            // --------------------------------------------------------
            cards.Add("KAR_037", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "KAR_037t",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.IsControllingSecret),
                        new FlagTask(true, ComplexTask.Create(
                            new BuffTask(Buffs.AttackHealth(1), EEntityType.SOURCE),
                            ComplexTask.Taunt(EEntityType.SOURCE)))),
                },
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
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("KAR_041", new List<Enchantment>
            {
                // TODO [KAR_041] Moat Lurker && Test: Moat Lurker_KAR_041
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new DestroyTask(EEntityType.TARGET)
                },
                new Enchantment
                {
                    Activation = EEnchantmentActivation.DEATHRATTLE,
                    SingleTask = null,
                },
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
            cards.Add("KAR_044", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.CONTROLLER,
                    Activation = EEnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(EGameTag.TURN_START, -1)
                        .SingleTask(new SummonTask("KAR_044a"))
                        .Build()
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
            cards.Add("KAR_061", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        ComplexTask.DrawFromDeck(SelfCondition.IsRace(ERace.BEAST)),
                        ComplexTask.DrawFromDeck(SelfCondition.IsRace(ERace.DRAGON)),
                        ComplexTask.DrawFromDeck(SelfCondition.IsRace(ERace.MURLOC)))
                },
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
            cards.Add("KAR_062", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.IsDragonInHand),
                        new FlagTask(true, new DiscoverTask(EDiscoverType.DRAGON)))
                },
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
            cards.Add("KAR_095", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "KAR_095e",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.MINIONS),
                        new FilterStackTask(SelfCondition.IsRace(ERace.MURLOC, ERace.DRAGON, ERace.MURLOC)),
                        new RandomTask(1, EEntityType.STACK),
                        new BuffTask(Buffs.AttackHealth(1), EEntityType.STACK))
                },
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
            cards.Add("KAR_096", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.GAME,
                    Activation = EEnchantmentActivation.DECK,
                    Trigger = new TriggerBuilder().Create()
                        //.EnableConditions(SelfCondition.IsInZone(Zone.DECK))
                        //.ApplyConditions(RelaCondition.IsSameRace)
                        .TriggerEffect(EGameTag.STEP, 0)
                        .MaxExecution(1)
                        .SingleTask(ComplexTask.Create(
                            new RandomMinionTask(EGameTag.RARITY, (int) ERarity.LEGENDARY, 5),
                            new AddStackTo(EEntityType.DECK)))
                        .Build()
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
            cards.Add("KAR_097", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new WeaponTask("KAR_097t")
                },
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
            cards.Add("KAR_114", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "KAR_114e",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.DECK),
                        new FilterStackTask(SelfCondition.IsMinion),
                        new RandomTask(1, EEntityType.STACK),
                        new ConditionTask(EEntityType.SOURCE, SelfCondition.IsNotBoardFull),
                        new FlagTask(true, ComplexTask.Create(
                            new CopyTask(EEntityType.STACK, 1),
                            new SetGameTagTask(EGameTag.ATK, 1, EEntityType.STACK),
                            new SetGameTagTask(EGameTag.HEALTH, 1, EEntityType.STACK),
                            new SummonTask())))
                }
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
            cards.Add("KAR_702", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "KAR_702e",
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EEntityType.MINIONS),
                        new FilterStackTask(SelfCondition.IsRace(ERace.BEAST, ERace.DRAGON, ERace.MURLOC)),
                        new RandomTask(1, EEntityType.STACK),
                        new BuffTask(Buffs.AttackHealth(2), EEntityType.STACK))
                },
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
            cards.Add("KAR_710", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EEnchantmentActivation.BATTLECRY,
                    SingleTask = new SummonTask("KAR_710m"),
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [KAR_711] Arcane Giant - COST:12 [ATK:8/HP:8]
            // - Set: kara, Rarity: epic
            // --------------------------------------------------------
            // Text: [x]Costs (1) less for each spell
            //       you've cast this game.
            // --------------------------------------------------------
            cards.Add("KAR_711", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.SELF,
                    Activation = EEnchantmentActivation.HAND,
                    Enchant = new Enchant
                    {
                        EnableConditions = new List<SelfCondition>
                        {
                            SelfCondition.IsInZone(EZone.HAND)
                        },
                        Effects = new Dictionary<EGameTag, int>
                        {
                            [EGameTag.COST] = 0
                        },
                        ValueFunc = owner => -owner.Controller.NumSpellsPlayedThisGame
                    }
                }
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
            cards.Add("KAR_712", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.HERO,
                    Activation = EEnchantmentActivation.BOARD,
                    Enchant = Auras.SimpleInclSelf(EGameTag.IMMUNE, 1, RelaCondition.IsMe(SelfCondition.IsCurrentPlayer))
                }
            });
        }

        private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KAR_036e] Eating (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: Increased Health.
            // --------------------------------------------------------
            cards.Add("KAR_036e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KAR_037t] Secrets of Karazhan (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: +1/+1 and <b>Taunt</b>.
            // --------------------------------------------------------
            cards.Add("KAR_037t", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KAR_077e] Silver Might (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("KAR_077e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KAR_095e] Well Fed (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("KAR_095e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KAR_114e] Incredible Impression (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: Attack and Health set to 1.
            // --------------------------------------------------------
            cards.Add("KAR_114e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KAR_702e] A Simple Trick (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("KAR_702e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KAR_A01_02e] Reflection (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: 1/1.
            // --------------------------------------------------------
            cards.Add("KAR_A01_02e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KAR_A02_06e2] Filled Up (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("KAR_A02_06e2", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KAR_A02_06He] Filled Up (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: +3/+3.
            // --------------------------------------------------------
            cards.Add("KAR_A02_06He", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KAR_A02_09e] Table Set (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("KAR_A02_09e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KAR_A02_09eH] Table Set (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("KAR_A02_09eH", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_00_05e] Insightful (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: Your spells cost (0).
            // --------------------------------------------------------
            // GameTag:
            // - TAG_ONE_TURN_EFFECT = 1
            // --------------------------------------------------------
            cards.Add("KARA_00_05e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_00_06e] Arcanely Powerful (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: +5 Spell Damage.
            // --------------------------------------------------------
            // GameTag:
            // - TAG_ONE_TURN_EFFECT = 1
            // --------------------------------------------------------
            // RefTag:
            // - SPELLPOWER = 1
            // --------------------------------------------------------
            cards.Add("KARA_00_06e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_05_01e] Trembling Before the Wolf (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: Shrunk to a 1/1.
            // --------------------------------------------------------
            cards.Add("KARA_05_01e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_06_01e] Death-Marked Love (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: Julianne is <b>immune</b>.
            // --------------------------------------------------------
            cards.Add("KARA_06_01e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_07_02e] Protecting the Gallery (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            cards.Add("KARA_07_02e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_08_02e] Nether Rage (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: +3 Attack.
            // --------------------------------------------------------
            cards.Add("KARA_08_02e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_08_02eH] Nether Rage (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: +8 Attack.
            // --------------------------------------------------------
            cards.Add("KARA_08_02eH", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_08_03e] Nether Breath (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: Health changed to 1.
            // --------------------------------------------------------
            cards.Add("KARA_08_03e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_08_06e2] Blue Beam (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: Only take 1 damage at a time.
            // --------------------------------------------------------
            cards.Add("KARA_08_06e2", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_08_08e2] Red Beam (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: Has <b>Windfury</b>.
            // --------------------------------------------------------
            cards.Add("KARA_08_08e2", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_13_11e] Enfeeble (*) - COST:0
            // - Set: kara,
            // --------------------------------------------------------
            // Text: Health changed to 1.
            // --------------------------------------------------------
            cards.Add("KARA_13_11e", null);

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

            // --------------------------------------- MINION - NEUTRAL
            // [KAR_A02_01] Plate (*) - COST:1 [ATK:1/HP:1]
            // - Set: kara,
            // --------------------------------------------------------
            cards.Add("KAR_A02_01", null);

            // --------------------------------------- MINION - NEUTRAL
            // [KAR_A02_01H] Plate (*) - COST:1 [ATK:2/HP:2]
            // - Set: kara,
            // --------------------------------------------------------
            cards.Add("KAR_A02_01H", null);

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
            // - DURABILITY = 3
            // --------------------------------------------------------
            cards.Add("KAR_097t", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EEnchantmentArea.HAND,
                    Activation = EEnchantmentActivation.WEAPON,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsThisWeaponEquiped)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                        .SingleTask(ComplexTask.Create(
                            new RandomMinionNumberTask(EGameTag.COST),
                            new SummonTask(),
                            ComplexTask.Create(
                                new GetGameTagTask(EGameTag.DURABILITY, EEntityType.WEAPON),
                                new MathSubstractionTask(1),
                                new SetGameTagNumberTask(EGameTag.DURABILITY, EEntityType.WEAPON))
                        ))
                        .Build()
                }
            });
        }

        public static void AddAll(Dictionary<string, List<Enchantment>> cards)
        {
            Heroes(cards);
            HeroPowers(cards);
            Druid(cards);
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
            Warlock(cards);
            WarlockNonCollect(cards);
            Warrior(cards);
            WarriorNonCollect(cards);
            Neutral(cards);
            NeutralNonCollect(cards);
        }
    }
}