using System.Collections.Generic;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Standard
{
    public class OgCardsGen
    {
        private static void HeroPowers(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------- HERO_POWER - PALADIN
            // [OG_006b] The Tidal Hand (*) - COST:2
            // - Set: og,
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Summon a 1/1 Silver Hand Murloc.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NUM_MINION_SLOTS = 1
            // --------------------------------------------------------
            cards.Add("OG_006b", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new SummonTask("OG_006a")
                }
            });
        }

        private static void Druid(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------------- MINION - DRUID
            // [OG_044] Fandral Staghelm - COST:4 [ATK:3/HP:5]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: Your <b>Choose One</b> cards have both effects combined.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - AURA = 1
            // --------------------------------------------------------
            cards.Add("OG_044", new List<Enchantment>
            {
                // TODO [OG_044] Fandral Staghelm && Test: Fandral Staghelm_OG_044
                //[irc] NightKev there's no "choose one" card where you can meet one but not the other playreq
                //[irc] NightKev no wait
                //[irc] NightKev there is an extremely niche case
                //[irc] NightKev you have two uh...
                //[irc] NightKev !card wee spellstopper
                //[irc] boombot7 Wee Spellstopper  [GVG_122 GVG][Mage Minion][4  mana, 2 / 5]:  Adjacent minions can't be targeted by spells or Hero Powers.   Bane of spellcasters and spelling bees everywhere.
                //[irc] NightKev yeah that one
                //[irc] NightKev you have two of those next to each other and place fandral on either end of the board and there are zero other minions on the board
                //[irc] NightKev then you would be unable to play starfall because it has no targets
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SimpleInclSelf(GameTag.CHOOSE_BOTH, 1)
                }
            });

            // ----------------------------------------- MINION - DRUID
            // [OG_051] Forbidden Ancient - COST:1 [ATK:1/HP:1]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Spend all your Mana. Gain +1/+1 for each mana spent.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_051", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.SpendAllManaTask(
                        new BuffAttackHealthNumberTask(EntityType.SOURCE))
                }
            });

            // ----------------------------------------- MINION - DRUID
            // [OG_188] Klaxxi Amber-Weaver - COST:4 [ATK:4/HP:5]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If your C'Thun has at least 10 Attack, gain +5 Health.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_188", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RitualTask(),
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsCthunGameTag(GameTag.ATK, 10, RelaSign.GEQ)),
                        new FlagTask(true, new BuffTask(Buffs.Health(5), EntityType.SOURCE)))
                },
            });

            // ----------------------------------------- MINION - DRUID
            // [OG_202] Mire Keeper - COST:4 [ATK:3/HP:3]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: [x]<b>Choose One -</b> Summon a
            //       2/2 Slime; or Gain an
            //       empty Mana Crystal.
            // --------------------------------------------------------
            // GameTag:
            // - CHOOSE_ONE = 1
            // --------------------------------------------------------
            cards.Add("OG_202",
                //CHOOSE_ONE
                null);

            // ----------------------------------------- MINION - DRUID
            // [OG_293] Dark Arakkoa - COST:6 [ATK:5/HP:7]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: [x]<b>Taunt</b>
            //       <b>Battlecry:</b> Give your C'Thun
            //       +3/+3 <i>(wherever it is).</i>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_293", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new RitualTask(Buffs.CthunAttackHealth(3))
                },
            });

            // ----------------------------------------- MINION - DRUID
            // [OG_313] Addled Grizzly - COST:3 [ATK:2/HP:2]
            // - Race: beast, Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: After you summon a minion, give it +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_313", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.SUMMONED, 1)
                        .SingleTask(new BuffTask(Buffs.AttackHealth(1), EntityType.TARGET))
                        .Build()
                }
            });

            // ------------------------------------------ SPELL - DRUID
            // [OG_047] Feral Rage - COST:3
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Choose One -</b> Give your hero +4 Attack this turn; or Gain 8 Armor.
            // --------------------------------------------------------
            // GameTag:
            // - CHOOSE_ONE = 1
            // --------------------------------------------------------
            cards.Add("OG_047",
                //CHOOSE_ONE
                null);

            // ------------------------------------------ SPELL - DRUID
            // [OG_048] Mark of Y'Shaarj - COST:2
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Give a minion +2/+2.
            //       If it's a Beast, draw
            //       a card.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_048", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new BuffTask(Buffs.AttackHealth(2), EntityType.TARGET),
                        new ConditionTask(EntityType.TARGET, SelfCondition.IsRace(Race.BEAST)),
                        new FlagTask(true, new DrawTask())),
                },
            });

            // ------------------------------------------ SPELL - DRUID
            // [OG_195] Wisps of the Old Gods - COST:7
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Choose One -</b> Summon seven 1/1 Wisps; or Give your minions +2/+2.
            // --------------------------------------------------------
            // GameTag:
            // - CHOOSE_ONE = 1
            // --------------------------------------------------------
            cards.Add("OG_195",
                //CHOOSE_ONE
                null);
        }

        private static void DruidNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------ ENCHANTMENT - DRUID
            // [OG_045a] Nerubian Spores (*) - COST:0
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Get a Beast when this dies.
            // --------------------------------------------------------
            cards.Add("OG_045a", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [OG_047e] Spines (*) - COST:0
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: +4 Attack this turn.
            // --------------------------------------------------------
            // GameTag:
            // - TAG_ONE_TURN_EFFECT = 1
            // --------------------------------------------------------
            cards.Add("OG_047e", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [OG_048e] Mark of Y'Shaarj (*) - COST:0
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("OG_048e", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [OG_051e] Forbidden Power (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("OG_051e", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [OG_202ae] Y'Shaarj's Strength (*) - COST:0
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: +3/+3.
            // --------------------------------------------------------
            cards.Add("OG_202ae", null);


            // ----------------------------------------- MINION - DRUID
            // [OG_195c] Wisp (*) - COST:0 [ATK:1/HP:1]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            cards.Add("OG_195c", null);

            // ----------------------------------------- MINION - DRUID
            // [OG_202c] Slime (*) - COST:2 [ATK:2/HP:2]
            // - Set: og,
            // --------------------------------------------------------
            cards.Add("OG_202c", null);
            // ------------------------------------------ SPELL - DRUID
            // [OG_047a] Evolve Spines (*) - COST:0
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Give your hero +4 Attack this turn.
            // --------------------------------------------------------
            cards.Add("OG_047a", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackTurn(4), EntityType.HERO)
                },
            });

            // ------------------------------------------ SPELL - DRUID
            // [OG_047b] Evolve Scales (*) - COST:0
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Gain 8 Armor.
            // --------------------------------------------------------
            cards.Add("OG_047b", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new ArmorTask(8),
                },
            });

            // ------------------------------------------ SPELL - DRUID
            // [OG_195a] Many Wisps (*) - COST:0
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: Summon seven 1/1 Wisps.
            // --------------------------------------------------------
            cards.Add("OG_195a", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(7, new SummonTask("OG_195c"))
                },
            });

            // ------------------------------------------ SPELL - DRUID
            // [OG_195b] Big Wisps (*) - COST:0
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: Give your minions +2/+2.
            // --------------------------------------------------------
            cards.Add("OG_195b", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackHealth(2), EntityType.MINIONS)
                },
            });

            // ------------------------------------------ SPELL - DRUID
            // [OG_202a] Y'Shaarj's Strength (*) - COST:0
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Summon a 2/2 Slime.
            // --------------------------------------------------------
            cards.Add("OG_202a", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new SummonTask("OG_202c"),
                },
            });

            // ------------------------------------------ SPELL - DRUID
            // [OG_202b] Yogg-Saron's Magic (*) - COST:0
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Gain an empty Mana Crystal.
            // --------------------------------------------------------
            cards.Add("OG_202b", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new ManaCrystalEmptyTask(1)
                },
            });
        }

        private static void Hunter(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------------- MINION - HUNTER
            // [OG_179] Fiery Bat - COST:1 [ATK:2/HP:1]
            // - Race: beast, Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Deal 1 damage to a random enemy.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_179", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1)
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [OG_216] Infested Wolf - COST:4 [ATK:3/HP:3]
            // - Race: beast, Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Summon two 1/1 Spiders.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_216", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new EnqueueTask(2, new SummonTask("OG_216a"))
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [OG_292] Forlorn Stalker - COST:3 [ATK:4/HP:2]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Give all <b>Deathrattle</b> minions in your hand +1/+1.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_292", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.HAND),
                        new FilterStackTask(SelfCondition.IsDeathrattleMinion),
                        new BuffTask(Buffs.AttackHealth(1), EntityType.STACK))
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [OG_308] Giant Sand Worm - COST:8 [ATK:8/HP:8]
            // - Race: beast, Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: Whenever this attacks and kills a minion, it may attack again.
            // --------------------------------------------------------
            cards.Add("OG_308", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = Triggers.MinionAttacksAndTarget(
                        new ConditionTask(EntityType.STACK, SelfCondition.IsMinion, SelfCondition.IsDead),
                        new FlagTask(true, ComplexTask.Create(
                            new ConditionTask(EntityType.SOURCE, SelfCondition.IsTagValue(GameTag.EXHAUSTED, 1)),
                            new FlagTask(true, new SetGameTagTask(GameTag.EXHAUSTED, 0, EntityType.SOURCE)))))
                }
            });

            // ---------------------------------------- MINION - HUNTER
            // [OG_309] Princess Huhuran - COST:5 [ATK:6/HP:5]
            // - Race: beast, Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Trigger a friendly minion's <b>Deathrattle</b> effect.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
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
            cards.Add("OG_309", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new ActivateEnchantment(EntityType.TARGET, EnchantmentActivation.DEATHRATTLE)
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [OG_325] Carrion Grub - COST:3 [ATK:2/HP:5]
            // - Race: beast, Set: og, Rarity: common
            // --------------------------------------------------------
            cards.Add("OG_325", null);

            // ----------------------------------------- SPELL - HUNTER
            // [OG_045] Infest - COST:3
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Give your minions "<b>Deathrattle:</b> Add a random Beast to your hand."
            // --------------------------------------------------------
            // RefTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_045", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new AddEnchantmentTask(EntityType.MINIONS,
                        new Enchantment
                        {
                            Activation = EnchantmentActivation.DEATHRATTLE,
                            SingleTask = ComplexTask.Create(
                                new RandomMinionTask(GameTag.CARDRACE, (int) Race.BEAST),
                                new AddStackTo(EntityType.HAND))
                        })
                }
            });

            // ----------------------------------------- SPELL - HUNTER
            // [OG_061] On the Hunt - COST:1
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $1 damage.
            //       Summon a 1/1 Mastiff. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_061", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(1, EntityType.TARGET, true),
                        new SummonTask("OG_061t"))
                },
            });

            // ----------------------------------------- SPELL - HUNTER
            // [OG_211] Call of the Wild - COST:9
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: Summon all three Animal Companions.
            // --------------------------------------------------------
            cards.Add("OG_211", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new SummonTask("NEW1_034"),
                        new SummonTask("NEW1_033"),
                        new SummonTask("NEW1_032"))
                },
            });
        }

        private static void HunterNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------------- MINION - HUNTER
            // [OG_061t] Mastiff (*) - COST:1 [ATK:1/HP:1]
            // - Race: beast, Set: og,
            // --------------------------------------------------------
            cards.Add("OG_061t", null);

            // ---------------------------------------- MINION - HUNTER
            // [OG_216a] Spider (*) - COST:1 [ATK:1/HP:1]
            // - Race: beast, Set: og,
            // --------------------------------------------------------
            cards.Add("OG_216a", null);
        }

        private static void Mage(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------------ MINION - MAGE
            // [OG_083] Twilight Flamecaller - COST:3 [ATK:2/HP:2]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal 1 damage to all enemy minions.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_083", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(1, EntityType.OP_MINIONS)
                },
            });

            // ------------------------------------------ MINION - MAGE
            // [OG_085] Demented Frostcaller - COST:4 [ATK:2/HP:4]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: After you cast a spell, <b>Freeze</b> a random enemy.
            // --------------------------------------------------------
            // RefTag:
            // - FREEZE = 1
            // --------------------------------------------------------
            cards.Add("OG_085", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(ComplexTask.Create(
                            new RandomTask(2, EntityType.ENEMIES),
                            ComplexTask.Freeze(EntityType.STACK)))
                        .Build()
                }
            });

            // ------------------------------------------ MINION - MAGE
            // [OG_087] Servant of Yogg-Saron - COST:5 [ATK:5/HP:4]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Cast a random spell that costs (5) or less <i>(targets chosen randomly)</i>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_087", new List<Enchantment>
            {
                // TODO [OG_087] Servant of Yogg-Saron && Test: Servant of Yogg-Saron_OG_087
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = null,
                },
            });

            // ------------------------------------------ MINION - MAGE
            // [OG_120] Anomalus - COST:8 [ATK:8/HP:6]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Deal 8 damage to all minions.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_120", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new DamageTask(8, EntityType.ALLMINIONS),
                },
            });

            // ------------------------------------------ MINION - MAGE
            // [OG_207] Faceless Summoner - COST:6 [ATK:5/HP:5]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Summon a random 3-Cost minion.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_207", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.SummonRandomMinion(GameTag.COST, 3)
                },
            });

            // ------------------------------------------ MINION - MAGE
            // [OG_303] Cult Sorcerer - COST:2 [ATK:3/HP:2]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: [x]<b><b>Spell Damage</b> +1</b>
            //       After you cast a spell,
            //       give your C'Thun +1/+1
            //       <i>(wherever it is).</i>
            // --------------------------------------------------------
            // GameTag:
            // - SPELLPOWER = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_303", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellPowerDamage(1)
                },
                new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new RitualTask(Buffs.CthunAttackHealth(1)))
                        .Build()
                }
            });

            // ------------------------------------------- SPELL - MAGE
            // [OG_081] Shatter - COST:2
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Destroy a <b>Frozen</b> minion.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // - REQ_FROZEN_TARGET = 0
            // --------------------------------------------------------
            // RefTag:
            // - FREEZE = 1
            // --------------------------------------------------------
            cards.Add("OG_081", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DestroyTask(EntityType.TARGET)
                },
            });

            // ------------------------------------------- SPELL - MAGE
            // [OG_086] Forbidden Flame - COST:0
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: Spend all your Mana. Deal that much damage to a minion. *spelldmg
            // --------------------------------------------------------
            // GameTag:
            // - AFFECTED_BY_SPELL_POWER = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_086", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.SpendAllManaTask(
                        new DamageNumberTask(EntityType.TARGET, true))
                },
            });

            // ------------------------------------------- SPELL - MAGE
            // [OG_090] Cabalist's Tome - COST:5
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: Add 3 random Mage spells to your hand.
            // --------------------------------------------------------
            cards.Add("OG_090", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(3, ComplexTask.Create(
                        new RandomCardTask(CardType.SPELL, CardClass.MAGE),
                        new AddStackTo(EntityType.HAND)))
                },
            });
        }

        private static void Paladin(IDictionary<string, List<Enchantment>> cards)
        {
            // --------------------------------------- MINION - PALADIN
            // [OG_006] Vilefin Inquisitor - COST:1 [ATK:1/HP:3]
            // - Race: murloc, Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Your Hero Power becomes 'Summon a 1/1 Murloc.'
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_006", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new ReplaceHeroPower(Cards.FromId("OG_006b")),
                },
            });

            // --------------------------------------- MINION - PALADIN
            // [OG_221] Selfless Hero - COST:1 [ATK:2/HP:1]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Give a random friendly minion <b>Divine Shield</b>.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            // RefTag:
            // - DIVINE_SHIELD = 1
            // --------------------------------------------------------
            cards.Add("OG_221", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.MINIONS),
                        new RandomTask(1, EntityType.STACK),
                        new SetGameTagTask(GameTag.DIVINE_SHIELD, 1, EntityType.STACK))
                },
            });

            // --------------------------------------- MINION - PALADIN
            // [OG_229] Ragnaros, Lightlord - COST:8 [ATK:8/HP:8]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: At the end of your turn, restore 8 Health to a damaged friendly character.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("OG_229", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(ComplexTask.Create(
                            new IncludeTask(EntityType.FRIENDS),
                            new FilterStackTask(SelfCondition.IsDamaged),
                            new RandomTask(1, EntityType.STACK),
                            new HealTask(8, EntityType.STACK)))
                        .Build()
                }
            });

            // --------------------------------------- MINION - PALADIN
            // [OG_310] Steward of Darkshire - COST:3 [ATK:3/HP:3]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Whenever you summon a 1-Health minion, give it <b>Divine Shield</b>.
            // --------------------------------------------------------
            // RefTag:
            // - DIVINE_SHIELD = 1
            // --------------------------------------------------------
            cards.Add("OG_310", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf,
                            RelaCondition.IsOther(SelfCondition.IsTagValue(GameTag.HEALTH, 1)))
                        .TriggerEffect(GameTag.SUMMONED, 1)
                        .SingleTask(ComplexTask.DivineShield(EntityType.TARGET))
                        .Build()
                }
            });

            // ---------------------------------------- SPELL - PALADIN
            // [OG_198] Forbidden Healing - COST:0
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: Spend all your Mana. Restore twice that much Health.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_198", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.SpendAllManaTask(
                        ComplexTask.Create(
                            new MathMultiplyTask(2),
                            new HealNumberTask(EntityType.TARGET)))
                },
            });

            // ---------------------------------------- SPELL - PALADIN
            // [OG_223] Divine Strength - COST:1
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Give a minion +1/+2.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_223", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackHealth(1, 2), EntityType.TARGET)
                },
            });

            // ---------------------------------------- SPELL - PALADIN
            // [OG_273] Stand Against Darkness - COST:5
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Summon five 1/1 Silver Hand Recruits.
            // --------------------------------------------------------
            cards.Add("OG_273", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(5, new SummonTask("CS2_101t"))
                },
            });

            // ---------------------------------------- SPELL - PALADIN
            // [OG_311] A Light in the Darkness - COST:2
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Discover</b> a minion.
            //       Give it +1/+1.
            // --------------------------------------------------------
            // RefTag:
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("OG_311", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_311e",
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DiscoverTask(DiscoverType.MINION,
                        new Enchantment()
                        {
                            Activation = EnchantmentActivation.HAND,
                            SingleTask = new BuffTask(Buffs.AttackHealth(1), EntityType.SOURCE),
                            RemoveAfterActivation = true
                        }),
                }
            });

            // --------------------------------------- WEAPON - PALADIN
            // [OG_222] Rallying Blade - COST:3 [ATK:3/HP:0]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Give +1/+1 to your minions with <b>Divine Shield</b>.
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 2
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - DIVINE_SHIELD = 1
            // --------------------------------------------------------
            cards.Add("OG_222", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_222e",
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.MINIONS),
                        new FilterStackTask(SelfCondition.IsTagValue(GameTag.DIVINE_SHIELD, 1)),
                        new BuffTask(Buffs.AttackHealth(1), EntityType.STACK))
                },
            });
        }

        private static void PaladinNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------- ENCHANTMENT - PALADIN
            // [OG_222e] Rally (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_222e", null);

            // --------------------------------------- MINION - PALADIN
            // [OG_006a] Silver Hand Murloc (*) - COST:1 [ATK:1/HP:1]
            // - Race: murloc, Set: og,
            // --------------------------------------------------------
            cards.Add("OG_006a", null);
        }

        private static void Priest(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------------- MINION - PRIEST
            // [OG_096] Twilight Darkmender - COST:5 [ATK:6/HP:5]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If your C'Thun has at least 10 Attack, restore 10 Health to your hero.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_096", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RitualTask(),
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsCthunGameTag(GameTag.ATK, 10, RelaSign.GEQ)),
                        new FlagTask(true, new HealTask(10, EntityType.HERO)))
                },
            });

            // ---------------------------------------- MINION - PRIEST
            // [OG_234] Darkshire Alchemist - COST:5 [ATK:4/HP:5]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Restore 5 Health.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NONSELF_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("OG_234", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new HealTask(5, EntityType.TARGET),
                },
            });

            // ---------------------------------------- MINION - PRIEST
            // [OG_316] Herald Volazj - COST:6 [ATK:5/HP:5]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Summon a 1/1 copy of each of your other minions.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_316", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.MINIONS_NOSOURCE),
                        new FilterStackTask(SelfCondition.IsMinion),
                        new FlagTask(true, ComplexTask.Create(
                            new CopyTask(EntityType.STACK, 1),
                            new SetAttackTask(1, EntityType.STACK),
                            new SetHealthTask(1, EntityType.STACK),
                            new SummonTask())))
                },
            });

            // ---------------------------------------- MINION - PRIEST
            // [OG_334] Hooded Acolyte - COST:4 [ATK:3/HP:6]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever a character is healed, give your
            //       C'Thun +1/+1 <i>(wherever it is).</i>
            // --------------------------------------------------------
            // GameTag:
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_334", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARDS,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(
                            SelfCondition.IsNotDead,
                            SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.DAMAGE, -1)
                        .SingleTask(new RitualTask(Buffs.CthunAttackHealth(1)))
                        .Build()
                }
            });

            // ---------------------------------------- MINION - PRIEST
            // [OG_335] Shifting Shade - COST:4 [ATK:4/HP:3]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Copy a card from your opponent's deck and add it to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_335", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.RandomCardCopyToHandFrom(EntityType.OP_DECK)
                },
            });

            // ----------------------------------------- SPELL - PRIEST
            // [OG_094] Power Word: Tentacles - COST:5
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Give a minion +2/+6.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_094", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_094e",
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackHealth(2, 6), EntityType.TARGET)
                },
            });

            // ----------------------------------------- SPELL - PRIEST
            // [OG_100] Shadow Word: Horror - COST:4
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Destroy all minions with 2 or less Attack.
            // --------------------------------------------------------
            cards.Add("OG_100", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.ALLMINIONS),
                        new FilterStackTask(EntityType.SOURCE,
                            RelaCondition.IsOther(SelfCondition.IsTagValue(GameTag.ATK, 2, RelaSign.LEQ))),
                        new DestroyTask(EntityType.STACK))
                },
            });

            // ----------------------------------------- SPELL - PRIEST
            // [OG_101] Forbidden Shaping - COST:0
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: Spend all your Mana. Summon a random minion that costs that much.
            // --------------------------------------------------------
            cards.Add("OG_101", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.SpendAllManaTask(
                        ComplexTask.SummonRandomMinionNumberTag(GameTag.COST))
                },
            });

            // ----------------------------------------- SPELL - PRIEST
            // [OG_104] Embrace the Shadow - COST:2
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: This turn, your healing effects deal damage instead.
            // --------------------------------------------------------
            cards.Add("OG_104", new List<Enchantment>
            {
                // TODO [OG_104] Embrace the Shadow && Test: Embrace the Shadow_OG_104
                new Enchantment
                {
                    InfoCardId = "OG_104e",
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });
        }

        private static void PriestNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------- ENCHANTMENT - PRIEST
            // [OG_094e] Tentacles (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +2/+6
            // --------------------------------------------------------
            cards.Add("OG_094e", null);
        }

        private static void Rogue(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------------- MINION - ROGUE
            // [OG_070] Bladed Cultist - COST:1 [ATK:1/HP:2]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Combo:</b> Gain +1/+1.
            // --------------------------------------------------------
            // GameTag:
            // - COMBO = 1
            // --------------------------------------------------------
            cards.Add("OG_070", new List<Enchantment>
            {
                // Combo
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new BuffTask(Buffs.AttackHealth(1), EntityType.SOURCE)
                }
            });

            // ----------------------------------------- MINION - ROGUE
            // [OG_080] Xaril, Poisoned Mind - COST:4 [ATK:3/HP:2]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry and Deathrattle:</b> Add a random Toxin card to your hand.
            // --------------------------------------------------------
            // Entourage: OG_080d, OG_080e, OG_080f, OG_080c, OG_080b
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - DEATHRATTLE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_080", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RandomEntourageTask(),
                        new AddStackTo(EntityType.HAND))
                },
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.Create(
                        new RandomEntourageTask(),
                        new AddStackTo(EntityType.HAND))
                },
            });

            // ----------------------------------------- MINION - ROGUE
            // [OG_267] Southsea Squidface - COST:4 [ATK:4/HP:4]
            // - Race: pirate, Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Give your weapon +2 Attack.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_267", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new BuffTask(Buffs.WeaponAtk(2), EntityType.WEAPON)
                },
            });

            // ----------------------------------------- MINION - ROGUE
            // [OG_282] Blade of C'Thun - COST:9 [ATK:4/HP:4]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Destroy a minion. Add its Attack and Health to_your C'Thun's <i>(wherever it is).</i>
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("OG_282", new List<Enchantment>
            {
                new Enchantment
                {
                    // TODO [OG_282] Blade of C'Thun, this implementation would work but I would like a straight implementation ... 
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = null
                        //ComplexTask.Create(
                        //new GetGameTagTask(GameTag.ATK, EntityType.TARGET),
                        //new EnqueueNumberTask(new RitualTask(Buffs.CthunAttack(1))),
                        //new GetGameTagTask(GameTag.HEALTH, EntityType.TARGET),
                        //new EnqueueNumberTask(new RitualTask(Buffs.CthunHealth(1))),
                        //new DestroyTask(EntityType.TARGET))
                },
            });

            // ----------------------------------------- MINION - ROGUE
            // [OG_291] Shadowcaster - COST:5 [ATK:4/HP:4]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Choose a friendly minion. Add a 1/1 copy to_your hand that costs_(1).
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("OG_291", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new CopyTask(EntityType.TARGET, 1),
                        new SetAttackTask(1, EntityType.STACK),
                        new SetHealthTask(1, EntityType.STACK),
                        //new SetGameTagTask(GameTag.COST, 1, EntityType.STACK),
                        new AddStackTo(EntityType.HAND),
                        new BuffTask(Buffs.CostFix(1), EntityType.STACK))
                },
            });

            // ----------------------------------------- MINION - ROGUE
            // [OG_330] Undercity Huckster - COST:2 [ATK:2/HP:2]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Add a random class card to your hand <i>(from your opponent's class)</i>.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_330", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.Create(
                        new RandomCardTask(EntityType.OP_HERO),
                        new AddStackTo(EntityType.HAND)),
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [OG_072] Journey Below - COST:1
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Discover</b> a <b>Deathrattle</b> card.
            // --------------------------------------------------------
            // RefTag:
            // - DEATHRATTLE = 1
            // - DISCOVER = 1
            // --------------------------------------------------------
            cards.Add("OG_072", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DiscoverTask(DiscoverType.DEATHRATTLE)
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [OG_073] Thistle Tea - COST:6
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Draw a card. Add 2 extra copies of it to your hand.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // --------------------------------------------------------
            cards.Add("OG_073", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DrawTask(true),
                        new CopyTask(EntityType.STACK, 2),
                        new AddStackTo(EntityType.HAND)),
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [OG_176] Shadow Strike - COST:3
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $5 damage to an undamaged character. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // - REQ_UNDAMAGED_TARGET = 0
            // --------------------------------------------------------
            cards.Add("OG_176", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(5, EntityType.TARGET, true)
                },
            });
        }

        private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------ ENCHANTMENT - ROGUE
            // [OG_070e] Thirsty Blades (*) - COST:0
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_070e", null);

            // ------------------------------------ ENCHANTMENT - ROGUE
            // [OG_267e] Squid Oil Sheen (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +2 Attack
            // --------------------------------------------------------
            cards.Add("OG_267e", null);
            // ------------------------------------------ SPELL - ROGUE
            // [OG_080b] Kingsblood Toxin (*) - COST:1
            // - Set: og,
            // --------------------------------------------------------
            // Text: Draw a card.
            // --------------------------------------------------------
            cards.Add("OG_080b", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DrawTask(),
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [OG_080c] Bloodthistle Toxin (*) - COST:1
            // - Set: og,
            // --------------------------------------------------------
            // Text: Return a friendly minion to your hand.
            //       It costs (2) less.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_080c", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new ReturnHandTask(EntityType.TARGET),
                        new BuffTask(Buffs.Cost(-2), EntityType.TARGET))
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [OG_080d] Briarthorn Toxin (*) - COST:1
            // - Set: og,
            // --------------------------------------------------------
            // Text: Give a minion +3 Attack.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_080d", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.Attack(3), EntityType.TARGET)
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [OG_080e] Fadeleaf Toxin (*) - COST:1
            // - Set: og,
            // --------------------------------------------------------
            // Text: Give a friendly minion <b>Stealth</b> until your next turn.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            // RefTag:
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("OG_080e", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffStealthTask(EntityType.TARGET)
                },
            });

            // ------------------------------------------ SPELL - ROGUE
            // [OG_080f] Firebloom Toxin (*) - COST:1
            // - Set: og,
            // --------------------------------------------------------
            // Text: Deal $2 damage. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_080f", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(2, EntityType.TARGET, true),
                },
            });
        }

        private static void Shaman(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------------- MINION - SHAMAN
            // [OG_024] Flamewreathed Faceless - COST:4 [ATK:7/HP:7]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Overload:</b> (2)
            // --------------------------------------------------------
            // GameTag:
            // - OVERLOAD = 2
            // - OVERLOAD_OWED = 2
            // --------------------------------------------------------
            cards.Add("OG_024", null);

            // ---------------------------------------- MINION - SHAMAN
            // [OG_026] Eternal Sentinel - COST:2 [ATK:3/HP:2]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Unlock your <b>Overloaded</b> Mana Crystals.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - OVERLOAD = 1
            // --------------------------------------------------------
            cards.Add("OG_026", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SetControllerGameTagTask(GameTag.OVERLOAD_LOCKED, 0),
                },
            });

            // ---------------------------------------- MINION - SHAMAN
            // [OG_028] Thing from Below - COST:6 [ATK:5/HP:5]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: [x]<b>Taunt</b>
            //       Costs (1) less for each
            //       Totem you've summoned
            //       this game.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("OG_028", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.HAND,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.HAND))
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsRace(Race.TOTEM)))
                        .TriggerEffect(GameTag.SUMMONED, 1)
                        .SingleTask(new BuffTask(Buffs.Cost(-1), EntityType.SOURCE))
                        .Build()
                }
            });

            // ---------------------------------------- MINION - SHAMAN
            // [OG_209] Hallazeal the Ascended - COST:5 [ATK:4/HP:6]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: Whenever your spells deal damage, restore that much Health to your hero.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("OG_209", new List<Enchantment>
            {
                // TODO [OG_209] Hallazeal the Ascended && Test: Hallazeal the Ascended_OG_209
                new Enchantment
                {
                    //Activation = null,
                    //SingleTask = null,
                }
            });

            // ---------------------------------------- MINION - SHAMAN
            // [OG_328] Master of Evolution - COST:4 [ATK:4/HP:5]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Transform a friendly minion into a random one that costs (1) more.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("OG_328", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new TransformMinionTask(EntityType.TARGET, 1)
                },
            });
            // ----------------------------------------- SPELL - SHAMAN
            // [OG_023] Primal Fusion - COST:1
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Give a minion +1/+1 for each of your Totems.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_023", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.MINIONS),
                        new FilterStackTask(SelfCondition.IsRace(Race.TOTEM)),
                        new CountTask(EntityType.STACK),
                        new BuffAttackHealthNumberTask(EntityType.TARGET))
                },
            });

            // ----------------------------------------- SPELL - SHAMAN
            // [OG_027] Evolve - COST:1
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Transform your minions into random minions that cost (1) more.
            // --------------------------------------------------------
            cards.Add("OG_027", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new TransformMinionTask(EntityType.MINIONS, 1)
                },
            });

            // ----------------------------------------- SPELL - SHAMAN
            // [OG_206] Stormcrack - COST:2
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $4 damage to a minion. <b>Overload:</b> (1) *spelldmg
            // --------------------------------------------------------
            // GameTag:
            // - OVERLOAD = 1
            // - OVERLOAD_OWED = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_206", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(4, EntityType.TARGET, true)
                },
            });


            // ---------------------------------------- WEAPON - SHAMAN
            // [OG_031] Hammer of Twilight - COST:5 [ATK:4/HP:0]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Summon a 4/2 Elemental.
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 2
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_031", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new SummonTask("OG_031a")
                },
            });
        }

        private static void ShamanNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------------- MINION - SHAMAN
            // [OG_031a] Twilight Elemental (*) - COST:3 [ATK:4/HP:2]
            // - Race: elemental, Set: og, Rarity: epic
            // --------------------------------------------------------
            cards.Add("OG_031a", null);
            // ----------------------------------------- SPELL - SHAMAN
            // [TB_OG_027] Evolve (*) - COST:1
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Transform your minions into random minions that cost (1) more.
            // --------------------------------------------------------
            cards.Add("TB_OG_027", new List<Enchantment>
            {
                // TODO [TB_OG_027] Evolve && Test: Evolve_TB_OG_027
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });
        }

        private static void Warlock(IDictionary<string, List<Enchantment>> cards)
        {
            // --------------------------------------- MINION - WARLOCK
            // [OG_109] Darkshire Librarian - COST:2 [ATK:3/HP:2]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b>
            //       Discard a random card. <b>Deathrattle:</b>
            //       Draw a card.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_109", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.DiscardRandomCard(1),
                },
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new DrawTask()
                },
            });

            // --------------------------------------- MINION - WARLOCK
            // [OG_113] Darkshire Councilman - COST:3 [ATK:1/HP:5]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: After you summon a minion, gain +1 Attack.
            // --------------------------------------------------------
            cards.Add("OG_113", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_113e",
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf)
                        .TriggerEffect(GameTag.SUMMONED, 1)
                        .SingleTask(new BuffTask(Buffs.AttackHealth(1), EntityType.SOURCE))
                        .Build()
                }
            });

            // --------------------------------------- MINION - WARLOCK
            // [OG_121] Cho'gall - COST:7 [ATK:7/HP:7]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> The next spell you cast this turn costs Health instead of Mana.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_121", new List<Enchantment>
            {
                // TODO [OG_121] Cho'gall && Test: Cho'gall_OG_121
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = null,
                },
            });

            // --------------------------------------- MINION - WARLOCK
            // [OG_241] Possessed Villager - COST:1 [ATK:1/HP:1]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Summon a 1/1 Shadowbeast.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_241", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new SummonTask("OG_241a"),
                },
            });

            // --------------------------------------- MINION - WARLOCK
            // [OG_302] Usher of Souls - COST:5 [ATK:5/HP:6]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever a friendly minion dies, give your C'Thun +1/+1
            //       <i>(wherever it is).</i>
            // --------------------------------------------------------
            // GameTag:
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_302", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsNotDead, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TO_BE_DESTROYED, 1)
                        .SingleTask(new RitualTask(Buffs.CthunAttackHealth(1)))
                        .Build()
                }
            });

            // ---------------------------------------- SPELL - WARLOCK
            // [OG_114] Forbidden Ritual - COST:0
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Spend all your Mana. Summon that many 1/1 Tentacles.
            // --------------------------------------------------------
            cards.Add("OG_114", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.SpendAllManaTask(
                        new EnqueueNumberTask(new SummonTask("OG_114a")))
                },
            });

            // ---------------------------------------- SPELL - WARLOCK
            // [OG_116] Spreading Madness - COST:3
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Deal $9 damage randomly split among ALL characters. *spelldmg
            // --------------------------------------------------------
            // GameTag:
            // - ImmuneToSpellpower = 1
            // --------------------------------------------------------
            cards.Add("OG_116", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(9, ComplexTask.DamageRandomTargets(1, EntityType.ALL, 1), true)
                },
            });

            // ---------------------------------------- SPELL - WARLOCK
            // [OG_118] Renounce Darkness - COST:2
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: Replace your Hero Power and Warlock cards with another class's. The cards cost (1) less.
            // --------------------------------------------------------
            cards.Add("OG_118", new List<Enchantment>
            {
                // TODO [OG_118] Renounce Darkness && Test: Renounce Darkness_OG_118
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });

            // ---------------------------------------- SPELL - WARLOCK
            // [OG_239] DOOM! - COST:10
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: Destroy all minions. Draw a card for each.
            // --------------------------------------------------------
            cards.Add("OG_239", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new CountTask(EntityType.ALLMINIONS),
                        new DestroyTask(EntityType.ALLMINIONS),
                        new EnqueueNumberTask(new DrawTask()))
                },
            });
        }

        private static void WarlockNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------- ENCHANTMENT - WARLOCK
            // [OG_113e] Power of the People (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("OG_113e", null);

            // --------------------------------------- MINION - WARLOCK
            // [OG_114a] Icky Tentacle (*) - COST:1 [ATK:1/HP:1]
            // - Set: og,
            // --------------------------------------------------------
            cards.Add("OG_114a", null);

            // --------------------------------------- MINION - WARLOCK
            // [OG_241a] Shadowbeast (*) - COST:1 [ATK:1/HP:1]
            // - Set: og,
            // --------------------------------------------------------
            cards.Add("OG_241a", null);
        }

        private static void Warrior(IDictionary<string, List<Enchantment>> cards)
        {
            // --------------------------------------- MINION - WARRIOR
            // [OG_149] Ravaging Ghoul - COST:3 [ATK:3/HP:3]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal 1 damage to all other minions.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_149", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(1, EntityType.ALLMINIONS_NOSOURCE)
                },
            });

            // --------------------------------------- MINION - WARRIOR
            // [OG_218] Bloodhoof Brave - COST:4 [ATK:2/HP:6]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       <b>Enrage:</b> +3 Attack.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - ENRAGED = 1
            // --------------------------------------------------------
            cards.Add("OG_218", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask =
                        new AuraTask(Auras.SimpleInclSelf(GameTag.ATK, 3, RelaCondition.IsMe(SelfCondition.IsEnraged)),
                            AuraArea.SELF)
                }
            });

            // --------------------------------------- MINION - WARRIOR
            // [OG_220] Malkorok - COST:7 [ATK:6/HP:5]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Equip a random weapon.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_220", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RandomCardTask(CardType.WEAPON, CardClass.INVALID),
                        new WeaponTask()),
                },
            });

            // --------------------------------------- MINION - WARRIOR
            // [OG_301] Ancient Shieldbearer - COST:7 [ATK:6/HP:6]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If your C'Thun has at least 10 Attack, gain 10 Armor.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_301", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RitualTask(),
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsCthunGameTag(GameTag.ATK, 10, RelaSign.GEQ)),
                        new FlagTask(true, new ArmorTask(10)))
                },
            });

            // --------------------------------------- MINION - WARRIOR
            // [OG_312] N'Zoth's First Mate - COST:1 [ATK:1/HP:1]
            // - Race: pirate, Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Equip a 1/3 Rusty Hook.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_312", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new ReplaceWeaponTask("OG_058"),
                },
            });

            // --------------------------------------- MINION - WARRIOR
            // [OG_315] Bloodsail Cultist - COST:3 [ATK:3/HP:4]
            // - Race: pirate, Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If you control another Pirate, give your weapon +1/+1.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_315", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsControllingRace(Race.PIRATE)),
                        new FlagTask(true, ComplexTask.Create(
                            new GetGameTagTask(GameTag.DURABILITY, EntityType.WEAPON),
                            new MathAddTask(1),
                            new SetGameTagNumberTask(GameTag.DURABILITY, EntityType.WEAPON),
                            new BuffTask(Buffs.WeaponAtk(1), EntityType.WEAPON)))),
                },
            });

            // ---------------------------------------- SPELL - WARRIOR
            // [OG_276] Blood Warriors - COST:3
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: Add a copy of each damaged friendly minion to your hand.
            // --------------------------------------------------------
            cards.Add("OG_276", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.MINIONS),
                        new FilterStackTask(SelfCondition.IsDamaged),
                        new CopyTask(EntityType.STACK, 1),
                        new AddStackTo(EntityType.HAND))
                },
            });

            // ---------------------------------------- SPELL - WARRIOR
            // [OG_314] Blood To Ichor - COST:1
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Deal $1 damage to a minion. If it survives, summon a 2/2 Slime. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("OG_314", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(1, EntityType.TARGET, true),
                        new ConditionTask(EntityType.TARGET, SelfCondition.IsNotDead),
                        new FlagTask(true, new SummonTask("OG_314b")))
                },
            });

            // --------------------------------------- WEAPON - WARRIOR
            // [OG_033] Tentacles for Arms - COST:5 [ATK:2/HP:0]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Return this to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 2
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_033", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new AddCardTo("OG_033", EntityType.HAND),
                },
            });
        }

        private static void WarriorNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [OG_312e] Upgraded (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Increased Durability.
            // --------------------------------------------------------
            cards.Add("OG_312e", null);

            // --------------------------------------- MINION - WARRIOR
            // [OG_314b] Slime (*) - COST:2 [ATK:2/HP:2]
            // - Set: og,
            // --------------------------------------------------------
            cards.Add("OG_314b", null);

            // --------------------------------------- WEAPON - WARRIOR
            // [OG_058] Rusty Hook (*) - COST:1 [ATK:1/HP:0]
            // - Set: og,
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 3
            // --------------------------------------------------------
            cards.Add("OG_058", null);
        }

        private static void Neutral(IDictionary<string, List<Enchantment>> cards)
        {
            // --------------------------------------- MINION - NEUTRAL
            // [OG_034] Silithid Swarmer - COST:3 [ATK:3/HP:5]
            // - Race: beast, Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Can only attack if your hero attacked this turn.
            // --------------------------------------------------------
            cards.Add("OG_034", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.SimpleInclSelf(
                            GameTag.CANT_ATTACK, 1, RelaCondition.IsOther(SelfCondition.HasMyHeroNotAttackedThisTurn)),
                        AuraArea.SELF)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_042] Y'Shaarj, Rage Unbound - COST:10 [ATK:10/HP:10]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: At the end of your turn, put a minion from your deck into the battlefield.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("OG_042", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(ComplexTask.Create(
                            new IncludeTask(EntityType.DECK),
                            new FilterStackTask(SelfCondition.IsMinion),
                            new RandomTask(1, EntityType.STACK),
                            new RemoveFromDeck(EntityType.STACK),
                            new SummonTask()))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_082] Evolved Kobold - COST:4 [ATK:2/HP:2]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Spell Damage +2</b>
            // --------------------------------------------------------
            // GameTag:
            // - SPELLPOWER = 2
            // --------------------------------------------------------
            cards.Add("OG_082", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellPowerDamage(2)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_102] Darkspeaker - COST:5 [ATK:3/HP:6]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Swap stats with a friendly minion.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("OG_102", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SwapAttackHealthTask(EntityType.TARGET)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_122] Mukla, Tyrant of the Vale - COST:6 [ATK:5/HP:5]
            // - Race: beast, Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Add 2 Bananas to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_122", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new EnqueueTask(2, new AddCardTo("EX1_014t", EntityType.HAND))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_123] Shifter Zerus - COST:1 [ATK:1/HP:1]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: Each turn this is in your hand, transform it into a random minion.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("OG_123", new List<Enchantment>
            {
                // TODO [OG_123] Shifter Zerus && Test: Shifter Zerus_OG_123
                new Enchantment
                (
                    //Activation = null,
                    //SingleTask = null,
                )
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_131] Twin Emperor Vek'lor - COST:7 [ATK:4/HP:6]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: [x]<b><b>Taunt</b>
            //       Battlecry:</b> If your C'Thun has
            //       at least 10 Attack, summon
            //       another Emperor.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - TAUNT = 1
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_131", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RitualTask(),
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsCthunGameTag(GameTag.ATK, 10, RelaSign.GEQ)),
                        new FlagTask(true, new SummonTask("OG_131")))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_133] N'Zoth, the Corruptor - COST:10 [ATK:5/HP:7]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Summon your <b>Deathrattle</b> minions that died this game.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_133", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.GRAVEYARD),
                        new FilterStackTask(SelfCondition.IsDeathrattleMinion),
                        //new CopyTask(EntityType.STACK, 1),
                        new SummonCopyTask(EntityType.STACK))
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_134] Yogg-Saron, Hope's End - COST:10 [ATK:7/HP:5]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Cast a random spell for each spell you've cast this game <i>(targets chosen randomly)</i>.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_134", new List<Enchantment>
            {
                // TODO [OG_134] Yogg-Saron, Hope's End && Test: Yogg-Saron, Hope's End_OG_134
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = null,
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_138] Nerubian Prophet - COST:6 [ATK:4/HP:4]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: At the start of your turn, reduce this card's
            //       Cost by (1).
            // --------------------------------------------------------
            cards.Add("OG_138", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_138e",
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.HAND,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.HAND))
                        .TriggerEffect(GameTag.TURN_START, 1)
                        .SingleTask(new BuffTask(Buffs.Cost(-1), EntityType.SOURCE))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_141] Faceless Behemoth - COST:10 [ATK:10/HP:10]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            cards.Add("OG_141", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_142] Eldritch Horror - COST:8 [ATK:6/HP:10]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            cards.Add("OG_142", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_145] Psych-o-Tron - COST:5 [ATK:3/HP:4]
            // - Race: mechanical, Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       <b>Divine Shield</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - DIVINE_SHIELD = 1
            // --------------------------------------------------------
            cards.Add("OG_145", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_147] Corrupted Healbot - COST:5 [ATK:6/HP:6]
            // - Race: mechanical, Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Restore 8 Health to the enemy hero.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_147", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new HealTask(8, EntityType.OP_HERO)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_150] Aberrant Berserker - COST:4 [ATK:3/HP:5]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Enrage:</b> +2 Attack.
            // --------------------------------------------------------
            // GameTag:
            // - ENRAGED = 1
            // --------------------------------------------------------
            cards.Add("OG_150", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_150e",
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask =
                        new AuraTask(Auras.SimpleInclSelf(GameTag.ATK, 2, RelaCondition.IsMe(SelfCondition.IsEnraged)),
                            AuraArea.SELF)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_151] Tentacle of N'Zoth - COST:1 [ATK:1/HP:1]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Deal 1 damage to all minions.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_151", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new DamageTask(1, EntityType.ALLMINIONS)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_152] Grotesque Dragonhawk - COST:7 [ATK:5/HP:5]
            // - Race: beast, Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Windfury</b>
            // --------------------------------------------------------
            // GameTag:
            // - WINDFURY = 1
            // --------------------------------------------------------
            cards.Add("OG_152", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_153] Bog Creeper - COST:7 [ATK:6/HP:8]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("OG_153", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_156] Bilefin Tidehunter - COST:2 [ATK:2/HP:1]
            // - Race: murloc, Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Summon a 1/1 Ooze with <b>Taunt</b>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("OG_156", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SummonTask("OG_156a"),
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_158] Zealous Initiate - COST:1 [ATK:1/HP:1]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Give a random friendly minion +1/+1.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_158", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_158e",
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.BuffRandomMinion(
                        EntityType.MINIONS,
                        Buffs.AttackHealth(1),
                        new SelfCondition[] {}),
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_161] Corrupted Seer - COST:6 [ATK:2/HP:3]
            // - Race: murloc, Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal 2 damage to all non-Murloc minions.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_161", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.ALLMINIONS),
                        new FilterStackTask(SelfCondition.IsNotRace(Race.MURLOC)),
                        new DamageTask(2, EntityType.STACK)),
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_162] Disciple of C'Thun - COST:3 [ATK:2/HP:1]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal 2 damage. Give your C'Thun +2/+2 <i>(wherever it is)</i>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NONSELF_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("OG_162", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RitualTask(Buffs.CthunAttackHealth(2)),
                        new DamageTask(2, EntityType.TARGET))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_173] Blood of The Ancient One - COST:9 [ATK:9/HP:9]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: If you control two of these
            //       at the end of your turn, merge them into 'The Ancient One'.
            // --------------------------------------------------------
            cards.Add("OG_173", new List<Enchantment>
            {
                // TODO [OG_173] Blood of The Ancient One && Test: Blood of The Ancient One_OG_173
                new Enchantment
                {
                    //Activation = null,
                    //SingleTask = null,
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_174] Faceless Shambler - COST:4 [ATK:1/HP:1]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       <b>Battlecry:</b> Copy a friendly minion's Attack and Health.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("OG_174", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_174e",
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.ATK, EntityType.TARGET),
                        new SetGameTagNumberTask(GameTag.ATK, EntityType.SOURCE),
                        new GetGameTagTask(GameTag.HEALTH, EntityType.TARGET),
                        new SetGameTagNumberTask(GameTag.HEALTH, EntityType.SOURCE))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_200] Validated Doomsayer - COST:5 [ATK:0/HP:7]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: At the start of your turn, set this minion's Attack to 7.
            // --------------------------------------------------------
            cards.Add("OG_200", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_200e",
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, 1)
                        .SingleTask(new SetAttackTask(7, EntityType.SOURCE))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_247] Twisted Worgen - COST:2 [ATK:3/HP:1]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Stealth</b>
            // --------------------------------------------------------
            // GameTag:
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("OG_247", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_248] Am'gam Rager - COST:3 [ATK:1/HP:5]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            cards.Add("OG_248", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_249] Infested Tauren - COST:4 [ATK:2/HP:3]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       <b>Deathrattle:</b> Summon a 2/2 Slime.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_249", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new SummonTask("OG_249a")
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_254] Eater of Secrets - COST:4 [ATK:2/HP:4]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Destroy all enemy <b>Secrets</b>. Gain +1/+1 for each.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - SECRET_OR_QUEST = 1
            // --------------------------------------------------------
            cards.Add("OG_254", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new CountTask(EntityType.OP_SECRETS),
                        new BuffAttackHealthNumberTask(EntityType.SOURCE),
                        new MoveToGraveYard(EntityType.OP_SECRETS))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_255] Doomcaller - COST:8 [ATK:7/HP:9]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i> If it's dead, shuffle it into your deck.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_255", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RitualTask(Buffs.CthunAttackHealth(2)),
                        new ConditionTask(EntityType.SOURCE, SelfCondition.IsCthunDead),
                        new FlagTask(true, new AddCardTo("OG_280", EntityType.DECK)))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_256] Spawn of N'Zoth - COST:3 [ATK:2/HP:2]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Give your minions +1/+1.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_256", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_256e",
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new BuffTask(Buffs.AttackHealth(1), EntityType.MINIONS)
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_271] Scaled Nightmare - COST:6 [ATK:2/HP:8]
            // - Race: dragon, Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: At the start of your turn, double this minion's Attack.
            // --------------------------------------------------------
            cards.Add("OG_271", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_271e",
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, 1)
                        .SingleTask(ComplexTask.Create(
                            new GetNativeGameTagTask(GameTag.ATK, EntityType.SOURCE, true),
                            new BuffAttackNumberTask(EntityType.SOURCE)))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_272] Twilight Summoner - COST:4 [ATK:1/HP:1]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Summon a 5/5 Faceless Destroyer.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_272", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new SummonTask("OG_272t"),
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_280] C'Thun - COST:10 [ATK:6/HP:6]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal damage equal to this minion's Attack randomly split among all enemies.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_280", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.HAND,
                    SingleTask = new CopyCthun(),
                },
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.ATK, EntityType.SOURCE),
                        new EnqueueNumberTask(ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1)))
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_281] Beckoner of Evil - COST:2 [ATK:2/HP:3]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i>
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_281", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_281e",
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new RitualTask(Buffs.CthunAttackHealth(2))
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_283] C'Thun's Chosen - COST:4 [ATK:4/HP:2]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: [x]<b>Divine Shield</b>
            //       <b>Battlecry:</b> Give your C'Thun
            //       +2/+2 <i>(wherever it is).</i>
            // --------------------------------------------------------
            // GameTag:
            // - DIVINE_SHIELD = 1
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_283", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new RitualTask(Buffs.CthunAttackHealth(2))
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_284] Twilight Geomancer - COST:2 [ATK:1/HP:4]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: [x]<b>Taunt</b>
            //       <b>Battlecry:</b> Give your C'Thun
            //       <b>Taunt</b> <i>(wherever it is).</i>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_284", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_284e",
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new RitualTask(null, true)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_286] Twilight Elder - COST:3 [ATK:3/HP:4]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: At the end of your turn, give your C'Thun +1/+1 <i>(wherever it is).</i>
            // --------------------------------------------------------
            // GameTag:
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_286", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(new RitualTask(Buffs.CthunAttackHealth(1)))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_290] Ancient Harbinger - COST:6 [ATK:4/HP:6]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: At the start of your turn, put a 10-Cost minion from your deck into your hand.
            // --------------------------------------------------------
            cards.Add("OG_290", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_290e",
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, 1)
                        .SingleTask(ComplexTask.SummonRandomMinion(EntityType.DECK,
                            RelaCondition.IsOther(SelfCondition.IsBaseTagValue(GameTag.COST, 10))))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_295] Cult Apothecary - COST:5 [ATK:4/HP:4]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> For each enemy minion, restore 2 Health to your hero.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_295", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new CountTask(EntityType.OP_MINIONS),
                        new MathMultiplyTask(2),
                        new HealNumberTask(EntityType.HERO)),
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_300] The Boogeymonster - COST:8 [ATK:6/HP:7]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: Whenever this attacks and kills a minion, gain +2/+2.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("OG_300", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_300e",
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = Triggers.MinionAttacksAndTarget(
                        new ConditionTask(EntityType.STACK, SelfCondition.IsMinion, SelfCondition.IsDead),
                        new BuffTask(Buffs.AttackHealth(2), EntityType.SOURCE))
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_317] Deathwing, Dragonlord - COST:10 [ATK:12/HP:12]
            // - Race: dragon, Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Put all Dragons from your hand into the battlefield.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_317", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.HAND),
                        new FilterStackTask(SelfCondition.IsRace(Race.DRAGON)),
                        new RemoveFromHand(EntityType.STACK),
                        // TODO this will summon copies instead of the hand minions, fix!!!
                        new SummonCopyTask(EntityType.STACK))
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_318] Hogger, Doom of Elwynn - COST:7 [ATK:6/HP:6]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: Whenever this minion takes damage, summon a 2/2 Gnoll with <b>Taunt</b>.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("OG_318", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.DAMAGE, 1)
                        .SingleTask(new SummonTask("OG_318t"))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_320] Midnight Drake - COST:4 [ATK:1/HP:4]
            // - Race: dragon, Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Gain +1 Attack for each other card
            //       in your hand.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_320", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_320e",
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new CountTask(EntityType.HAND_NOSOURCE),
                        new BuffAttackNumberTask(EntityType.SOURCE))
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_321] Crazed Worshipper - COST:5 [ATK:3/HP:6]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Taunt.</b> Whenever this minion takes damage, give your C'Thun +1/+1 <i>(wherever it is).</i>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_321", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_321e",
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.DAMAGE, 1)
                        .SingleTask(new RitualTask(Buffs.CthunAttackHealth(1)))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_322] Blackwater Pirate - COST:4 [ATK:2/HP:5]
            // - Race: pirate, Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: Your weapons cost (2) less.
            // --------------------------------------------------------
            cards.Add("OG_322", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask =
                        new AuraTask(Auras.Cost(-2, RelaCondition.IsOther(SelfCondition.IsWeapon)), AuraArea.HAND)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_323] Polluted Hoarder - COST:4 [ATK:4/HP:2]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Draw a card.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("OG_323", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new DrawTask()
                },
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_326] Duskboar - COST:2 [ATK:4/HP:1]
            // - Race: beast, Set: og, Rarity: common
            // --------------------------------------------------------
            cards.Add("OG_326", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_327] Squirming Tentacle - COST:3 [ATK:2/HP:4]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("OG_327", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_337] Cyclopian Horror - COST:4 [ATK:3/HP:3]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Taunt</b>. <b>Battlecry:</b> Gain      +1 Health for each enemy minion.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_337", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_337e",
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new CountTask(EntityType.OP_MINIONS),
                        new BuffHealthNumberTask(EntityType.SOURCE))
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_338] Nat, the Darkfisher - COST:2 [ATK:2/HP:4]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: At the start of your opponent's turn, they have a 50% chance to draw an extra card.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("OG_338", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.OP_CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, 1)
                        .SingleTask(ComplexTask.Create(
                            new ChanceTask(),
                            new DrawOpTask()))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_339] Skeram Cultist - COST:6 [ATK:7/HP:6]
            // - Set: og, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i>
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // - RITUAL = 1
            // --------------------------------------------------------
            cards.Add("OG_339", new List<Enchantment>
            {
                new Enchantment
                {
                    InfoCardId = "OG_339e",
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new RitualTask(Buffs.CthunAttackHealth(2))
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [OG_340] Soggoth the Slitherer - COST:9 [ATK:5/HP:9]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       Can't be targeted by spells or Hero Powers.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - TAUNT = 1
            // - CANT_BE_TARGETED_BY_ABILITIES = 1
            // - CANT_BE_TARGETED_BY_HERO_POWERS = 1
            // --------------------------------------------------------
            cards.Add("OG_340", null);
        }

        private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_023t] Primally Infused (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("OG_023t", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_080ae] Bloodthistle (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Costs (2) less.
            // --------------------------------------------------------
            cards.Add("OG_080ae", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_080de] Fadeleaf (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Stealthed until your next turn.
            // --------------------------------------------------------
            cards.Add("OG_080de", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_080ee] Briarthorn (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +3 Attack.
            // --------------------------------------------------------
            cards.Add("OG_080ee", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_102e] Power Transfer (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Swapped stats.
            // --------------------------------------------------------
            cards.Add("OG_102e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_104e] Embracing the Shadow (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Your healing effects are dealing damage.
            // --------------------------------------------------------
            // GameTag:
            // - TAG_ONE_TURN_EFFECT = 1
            // --------------------------------------------------------
            cards.Add("OG_104e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_118e] Renounce Darkness Deck Ench (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            cards.Add("OG_118e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_118f] New Calling (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Cost reduced.
            // --------------------------------------------------------
            cards.Add("OG_118f", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_121e] Dark Power (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Your next spell costs Health instead of Mana.
            // --------------------------------------------------------
            cards.Add("OG_121e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_123e] Shifting (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Transforming into random minions.
            // --------------------------------------------------------
            cards.Add("OG_123e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_138e] Will of the Vizier (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Reduced Cost.
            // --------------------------------------------------------
            cards.Add("OG_138e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_150e] Enraged (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +2 Attack.
            // --------------------------------------------------------
            // GameTag:
            // - ENRAGED = 1
            // --------------------------------------------------------
            cards.Add("OG_150e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_158e] Secrets of the Cult (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_158e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_174e] Faceless (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Copying stats.
            // --------------------------------------------------------
            cards.Add("OG_174e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_188e] Amber Carapace (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +5 Health.
            // --------------------------------------------------------
            cards.Add("OG_188e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_195e] Enormous (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("OG_195e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_200e] Doom Free (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Attack set to 7.
            // --------------------------------------------------------
            cards.Add("OG_200e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_218e] Enraged (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +3 Attack.
            // --------------------------------------------------------
            // GameTag:
            // - ENRAGED = 1
            // --------------------------------------------------------
            cards.Add("OG_218e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_223e] Optimism (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +1/+2.
            // --------------------------------------------------------
            cards.Add("OG_223e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_254e] Secretly Sated (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("OG_254e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_256e] Slimed (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_256e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_271e] Terrifying Visage (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Attack increased.
            // --------------------------------------------------------
            cards.Add("OG_271e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_281e] Fanatic Devotion (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Increased Stats.
            // --------------------------------------------------------
            cards.Add("OG_281e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_282e] Devotion of the Blade (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("OG_282e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_284e] Geomancy (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Has <b>Taunt</b>.
            // --------------------------------------------------------
            cards.Add("OG_284e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_290e] Caller Devotion (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_290e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_291e] Flickering Darkness (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Shadowcaster made this 1/1.
            // --------------------------------------------------------
            cards.Add("OG_291e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_292e] Night's Devotion (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_292e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_293e] Arrakoa Devotion (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +5/+5.
            // --------------------------------------------------------
            cards.Add("OG_293e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_293f] Dark Guardian (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Increased Stats.
            // --------------------------------------------------------
            cards.Add("OG_293f", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_300e] Tasty! (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("OG_300e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_302e] Soul Power (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("OG_302e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_303e] Sorcerous Devotion (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_303e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_311e] Beacon of Hope (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_311e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_313e] Addled (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_313e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_315e] Reforged (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_315e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_316k] Shadowy (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: 1/1.
            // --------------------------------------------------------
            cards.Add("OG_316k", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_320e] Hour of Corruption (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("OG_320e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_321e] Power of Faith (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("OG_321e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_337e] Eve of Destruction (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: Stats increased.
            // --------------------------------------------------------
            cards.Add("OG_337e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [OG_339e] Vassal's Subservience (*) - COST:0
            // - Set: og,
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("OG_339e", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_156a] Ooze (*) - COST:1 [ATK:1/HP:1]
            // - Set: og, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("OG_156a", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_173a] The Ancient One (*) - COST:9 [ATK:30/HP:30]
            // - Set: og, Rarity: epic
            // --------------------------------------------------------
            cards.Add("OG_173a", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_249a] Slime (*) - COST:2 [ATK:2/HP:2]
            // - Set: og,
            // --------------------------------------------------------
            cards.Add("OG_249a", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_270a] Nerubian Soldier (*) - COST:8 [ATK:7/HP:7]
            // - Set: og,
            // --------------------------------------------------------
            cards.Add("OG_270a", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_272t] Faceless Destroyer (*) - COST:4 [ATK:5/HP:5]
            // - Set: og,
            // --------------------------------------------------------
            cards.Add("OG_272t", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_279] C'Thun (*) - COST:10 [ATK:6/HP:6]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal damage equal to this minion's Attack randomly split among all enemies.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("OG_279", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_318t] Gnoll (*) - COST:2 [ATK:2/HP:2]
            // - Set: og,
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("OG_318t", null);

            // --------------------------------------- MINION - NEUTRAL
            // [OG_319] Twin Emperor Vek'nilash (*) - COST:7 [ATK:4/HP:6]
            // - Set: og, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("OG_319", null);
        }

        public static void AddAll(Dictionary<string, List<Enchantment>> cards)
        {
            HeroPowers(cards);
            Druid(cards);
            DruidNonCollect(cards);
            Hunter(cards);
            HunterNonCollect(cards);
            Mage(cards);
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