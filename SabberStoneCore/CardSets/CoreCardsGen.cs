using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.SimpleTasks.Tasks;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets
{
	public class CoreCardsGen
	{
        private static void Heroes(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------------- HERO - WARRIOR
            // [HERO_01] Garrosh Hellscream - COST:0 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - OVERKILL = 725
            // --------------------------------------------------------
            cards.Add("HERO_01", null);

            // ------------------------------------------ HERO - SHAMAN
            // [HERO_02] Thrall - COST:0 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - OVERKILL = 687
            // --------------------------------------------------------
            cards.Add("HERO_02", null);

            // ------------------------------------------- HERO - ROGUE
            // [HERO_03] Valeera Sanguinar - COST:0 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - OVERKILL = 730
            // --------------------------------------------------------
            cards.Add("HERO_03", null);

            // ----------------------------------------- HERO - PALADIN
            // [HERO_04] Uther Lightbringer - COST:0 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - OVERKILL = 472
            // --------------------------------------------------------
            cards.Add("HERO_04", null);

            // ------------------------------------------ HERO - HUNTER
            // [HERO_05] Rexxar - COST:0 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - OVERKILL = 229
            // --------------------------------------------------------
            cards.Add("HERO_05", null);

            // ------------------------------------------- HERO - DRUID
            // [HERO_06] Malfurion Stormrage - COST:0 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - OVERKILL = 1123
            // --------------------------------------------------------
            cards.Add("HERO_06", null);

            // ----------------------------------------- HERO - WARLOCK
            // [HERO_07] Gul'dan - COST:0 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - OVERKILL = 300
            // --------------------------------------------------------
            cards.Add("HERO_07", null);

            // -------------------------------------------- HERO - MAGE
            // [HERO_08] Jaina Proudmoore - COST:0 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - OVERKILL = 807
            // --------------------------------------------------------
            cards.Add("HERO_08", null);

            // ------------------------------------------ HERO - PRIEST
            // [HERO_09] Anduin Wrynn - COST:0 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - OVERKILL = 479
            // --------------------------------------------------------
            cards.Add("HERO_09", null);

        }

        private static void HeroPowers(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------ HERO_POWER - PRIEST
            // [CS1h_001] Lesser Heal (*) - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Restore #2 Health.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("CS1h_001", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new HealTask(2, EntityType.TARGET)
                }
            });

            // ------------------------------------- HERO_POWER - DRUID
            // [CS2_017] Shapeshift (*) - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       +1 Attack this turn.    +1 Armor.
            // --------------------------------------------------------
            cards.Add("CS2_017", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new ArmorTask(1),
                        new BuffTask(Buffs.AttackTurn(1), EntityType.HERO))
                }
            });

            // -------------------------------------- HERO_POWER - MAGE
            // [CS2_034] Fireblast (*) - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Deal $1 damage. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("CS2_034", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(1, EntityType.TARGET, false)
                }
            });

            // ------------------------------------ HERO_POWER - SHAMAN
            // [CS2_049] Totemic Call (*) - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Summon a random Totem.
            // --------------------------------------------------------
            // Entourage: CS2_050, CS2_051, CS2_052, NEW1_009
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
            // - REQ_NUM_MINION_SLOTS = 1
            // --------------------------------------------------------
            cards.Add("CS2_049", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = SpecificTask.TotemicCall
                }
            });

            // ----------------------------------- HERO_POWER - WARLOCK
            // [CS2_056] Life Tap (*) - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Draw a card and take $2 damage. *spelldmg
            // --------------------------------------------------------
            cards.Add("CS2_056", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(2, EntityType.HERO, false),
                         new DrawTask())
                }
            });

            // ------------------------------------- HERO_POWER - ROGUE
            // [CS2_083b] Dagger Mastery (*) - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Equip a 1/2 Dagger.
            // --------------------------------------------------------
            cards.Add("CS2_083b", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new WeaponTask(WeaponTaskType.EQUIP, "CS2_082")
                }
            });

            // ----------------------------------- HERO_POWER - PALADIN
            // [CS2_101] Reinforce (*) - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Summon a 1/1 Silver Hand Recruit.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NUM_MINION_SLOTS = 1
            // --------------------------------------------------------
            cards.Add("CS2_101", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new SummonTask("CS2_101t")
                }
            });

            // ----------------------------------- HERO_POWER - WARRIOR
            // [CS2_102] Armor Up! (*) - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Gain 2 Armor.
            // --------------------------------------------------------
            cards.Add("CS2_102", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new ArmorTask(2)
                }
            });

            // ------------------------------------ HERO_POWER - HUNTER
            // [DS1h_292] Steady Shot (*) - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Deal $2 damage to the enemy hero. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_STEADY_SHOT = 0
            // - REQ_MINION_OR_ENEMY_HERO = 0
            // --------------------------------------------------------
            cards.Add("DS1h_292", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(2, EntityType.OP_HERO, false)
                }
            });

        }

        private static void Druid(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------------ SPELL - DRUID
            // [CS2_005] Claw - COST:1 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Give your hero +2_Attack this turn. Gain 2 Armor.
            // --------------------------------------------------------
            cards.Add("CS2_005", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new ArmorTask(2),
                        new BuffTask(Buffs.AttackTurn(2), EntityType.HERO))
                }
            });

            // ------------------------------------------ SPELL - DRUID
            // [CS2_007] Healing Touch - COST:3 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Restore #8 Health.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("CS2_007", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new HealTask(8, EntityType.TARGET)
                }
            });

            // ------------------------------------------ SPELL - DRUID
            // [CS2_008] Moonfire - COST:0 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $1 damage. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("CS2_008", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(1, EntityType.TARGET, true)
                }
            });

            // ------------------------------------------ SPELL - DRUID
            // [CS2_009] Mark of the Wild - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Give a minion <b>Taunt</b> and +2/+2.<i>
            //       (+2 Attack/+2 Health)</i>
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS2_009", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        ComplexTask.Taunt(EntityType.TARGET),
                        new BuffTask(Buffs.AttackHealth(2), EntityType.TARGET))
                }
            });

            // ------------------------------------------ SPELL - DRUID
            // [CS2_011] Savage Roar - COST:3 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Give your characters +2_Attack this turn.
            // --------------------------------------------------------
            cards.Add("CS2_011", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackTurn(2), EntityType.FRIENDS)
                }
            });

            // ------------------------------------------ SPELL - DRUID
            // [CS2_012] Swipe - COST:4 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $4 damage to an enemy and $1 damage to all other enemies. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_ENEMY_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("CS2_012", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(4, EntityType.TARGET, true),
                        new DamageTask(1, EntityType.ENEMIES_NOTARGET, true))
                }
            });

            // ------------------------------------------ SPELL - DRUID
            // [CS2_013] Wild Growth - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Gain an empty Mana Crystal.
            // --------------------------------------------------------
            cards.Add("CS2_013", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        ComplexTask.ExcessManaCheck,
                        new ManaCrystalEmptyTask(1))
                }
            });

            // ------------------------------------------ SPELL - DRUID
            // [EX1_169] Innervate - COST:0 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Gain 2 Mana Crystals this turn only.
            // --------------------------------------------------------
            cards.Add("EX1_169", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new TempManaTask(2)
                }
            });

            // ------------------------------------------ SPELL - DRUID
            // [EX1_173] Starfire - COST:6 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $5 damage.
            //       Draw a card. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("EX1_173", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(5, EntityType.TARGET, true),
                        new DrawTask())
                }
            });

            // ----------------------------------------- MINION - DRUID
            // [CS2_232] Ironbark Protector - COST:8 [ATK:8/HP:8] 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS2_232", null);

        }

        private static void DruidNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------------ SPELL - DRUID
            // [CS2_013t] Excess Mana (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: Draw a card. <i>(You can only have 10 Mana in your tray.)</i>
            // --------------------------------------------------------
            cards.Add("CS2_013t", new List<Enchantment> {
	            new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DrawTask(),
                },
            });

            // ------------------------------------ ENCHANTMENT - DRUID
            // [CS2_005o] Claw (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: +2 Attack this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("CS2_005o", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [CS2_009e] Mark of the Wild (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: +2/+2 and <b>Taunt</b>.
            // --------------------------------------------------------
            cards.Add("CS2_009e", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [CS2_011o] Savage Roar (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: +2 Attack this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("CS2_011o", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [CS2_017o] Claws (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: Your hero has +1 Attack this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("CS2_017o", null);

        }

        private static void Hunter(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------------- SPELL - HUNTER
            // [CS2_084] Hunter's Mark - COST:1 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Change a minion's Health to 1.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("CS2_084", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.SetHealth(1, EntityType.TARGET)
                }
            });

            // ----------------------------------------- SPELL - HUNTER
            // [DS1_183] Multi-Shot - COST:4 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Deal $3 damage to two random enemy minions. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINIMUM_ENEMY_MINIONS = 2
            // --------------------------------------------------------
            cards.Add("DS1_183", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.DamageRandomTargets(2, EntityType.OP_MINIONS, 3, true)
                }
            });

            // ----------------------------------------- SPELL - HUNTER
            // [DS1_184] Tracking - COST:1 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Look at the top 3 cards of your deck. Draw one and discard the_others.
            // --------------------------------------------------------
            cards.Add("DS1_184", new List<Enchantment> {
				// TODO [DS1_184] Tracking && Test: Tracking_DS1_184
				new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });

            // ----------------------------------------- SPELL - HUNTER
            // [DS1_185] Arcane Shot - COST:1 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Deal $2 damage. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("DS1_185", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(2, EntityType.TARGET, true)
                }
            });

            // ----------------------------------------- SPELL - HUNTER
            // [EX1_539] Kill Command - COST:3 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $3 damage. If you control a Beast, deal
            //       $5 damage instead. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("EX1_539", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsControlingBeast),
                        ComplexTask.True(new DamageTask(5, EntityType.TARGET, true)),
                        ComplexTask.False(new DamageTask(3, EntityType.TARGET, true)))
                }
            });

            // ----------------------------------------- SPELL - HUNTER
            // [NEW1_031] Animal Companion - COST:3 
            // - Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Summon a random Beast Companion.
            // --------------------------------------------------------
            // Entourage: NEW1_032, NEW1_033, NEW1_034
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NUM_MINION_SLOTS = 1
            // --------------------------------------------------------
            cards.Add("NEW1_031", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = SpecificTask.AnimalCompanion
                }
            });

            // ---------------------------------------- MINION - HUNTER
            // [CS2_237] Starving Buzzard - COST:5 [ATK:3/HP:2] 
            // - Race: beast, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever you summon a Beast, draw a card.
            // --------------------------------------------------------
            cards.Add("CS2_237", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsNotDead, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsSameRace)
                        .TriggerEffect(GameTag.SUMMONED, 1)
                        .SingleTask(new DrawTask())
                        .Build()
                }
            });

            // ---------------------------------------- MINION - HUNTER
            // [DS1_070] Houndmaster - COST:4 [ATK:4/HP:3] 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Give a friendly Beast +2/+2 and <b>Taunt</b>.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_WITH_RACE = 20
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("DS1_070", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.TARGET,
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Taunt(EntityType.TARGET),
                    Enchant = Buffs.AttackHealth(2)
                }
            });

            // ---------------------------------------- MINION - HUNTER
            // [DS1_175] Timber Wolf - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Your other Beasts have +1_Attack.
            // --------------------------------------------------------
            // GameTag:
            // - AURA = 1
            // --------------------------------------------------------
            cards.Add("DS1_175", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = ComplexTask.Taunt(EntityType.TARGET),
                    Enchant = Auras.Attack(1, RelaCondition.IsSameRace)
                }
            });

            // ---------------------------------------- MINION - HUNTER
            // [DS1_178] Tundra Rhino - COST:5 [ATK:2/HP:5] 
            // - Race: beast, Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Your Beasts have <b>Charge</b>.
            // --------------------------------------------------------
            // RefTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("DS1_178", new List<Enchantment> {
                // TODO check if we need to change charge buff implementation
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SimpleInclSelf(GameTag.CHARGE, 1, RelaCondition.IsSameRace)
                }
            });

        }

        private static void HunterNonCollect(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------- ENCHANTMENT - HUNTER
            // [CS2_084e] Hunter's Mark (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: This minion has 1 Health.
            // --------------------------------------------------------
            cards.Add("CS2_084e", null);

            // ----------------------------------- ENCHANTMENT - HUNTER
            // [DS1_070o] Master's Presence (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: +2/+2 and <b>Taunt</b>.
            // --------------------------------------------------------
            cards.Add("DS1_070o", null);

            // ----------------------------------- ENCHANTMENT - HUNTER
            // [DS1_175o] Furious Howl (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: +1 Attack from Timber Wolf.
            // --------------------------------------------------------
            cards.Add("DS1_175o", null);

            // ----------------------------------- ENCHANTMENT - HUNTER
            // [DS1_178e] Charge (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: Tundra Rhino grants <b>Charge</b>.
            // --------------------------------------------------------
            cards.Add("DS1_178e", null);

            // ----------------------------------- ENCHANTMENT - HUNTER
            // [NEW1_033o] Eye In The Sky (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: Leokk is granting this minion +1 Attack.
            // --------------------------------------------------------
            cards.Add("NEW1_033o", null);

            // ---------------------------------------- MINION - HUNTER
            // [NEW1_032] Misha (*) - COST:3 [ATK:4/HP:4] 
            // - Race: beast, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("NEW1_032", null);

            // ---------------------------------------- MINION - HUNTER
            // [NEW1_033] Leokk (*) - COST:3 [ATK:2/HP:4] 
            // - Race: beast, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Your other minions have +1 Attack.
            // --------------------------------------------------------
            cards.Add("NEW1_033", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.Attack(1, RelaCondition.IsNotSelf), AuraArea.BOARD)
                }
            });

            // ---------------------------------------- MINION - HUNTER
            // [NEW1_034] Huffer (*) - COST:3 [ATK:4/HP:2] 
            // - Race: beast, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("NEW1_034", null);

        }

        private static void Mage(IDictionary<string, List<Enchantment>> cards)
        {
            // ------------------------------------------- SPELL - MAGE
            // [CS2_022] Polymorph - COST:4 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Transform a minion
            //       into a 1/1 Sheep.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("CS2_022", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask =  new TransformTask("CS2_tk1", EntityType.TARGET)
                }
            });

            // ------------------------------------------- SPELL - MAGE
            // [CS2_023] Arcane Intellect - COST:3 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Draw 2 cards.
            // --------------------------------------------------------
            cards.Add("CS2_023", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(2, new DrawTask())
                }
            });

            // ------------------------------------------- SPELL - MAGE
            // [CS2_024] Frostbolt - COST:2 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $3 damage to a_character and <b>Freeze</b> it. *spelldmg
            // --------------------------------------------------------
            // GameTag:
            // - FREEZE = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("CS2_024", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(3, EntityType.TARGET, true),
                        ComplexTask.Freeze(EntityType.TARGET))
                }
            });

            // ------------------------------------------- SPELL - MAGE
            // [CS2_025] Arcane Explosion - COST:2 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Deal $1 damage to all enemy minions. *spelldmg
            // --------------------------------------------------------
            cards.Add("CS2_025", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(1, EntityType.OP_MINIONS, true)
                }
            });

            // ------------------------------------------- SPELL - MAGE
            // [CS2_026] Frost Nova - COST:3 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Freeze</b> all enemy minions.
            // --------------------------------------------------------
            // GameTag:
            // - FREEZE = 1
            // --------------------------------------------------------
            cards.Add("CS2_026", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Freeze(EntityType.OP_MINIONS)
                }
            });

            // ------------------------------------------- SPELL - MAGE
            // [CS2_027] Mirror Image - COST:1 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Summon two 0/2 minions with <b>Taunt</b>.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NUM_MINION_SLOTS = 1
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS2_027", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(2, new SummonTask("CS2_mirror"), false)
                }
            });

            // ------------------------------------------- SPELL - MAGE
            // [CS2_029] Fireball - COST:4 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Deal $6 damage. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("CS2_029", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(6, EntityType.TARGET, true)
                }
            });

            // ------------------------------------------- SPELL - MAGE
            // [CS2_032] Flamestrike - COST:7 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $4 damage to all enemy minions. *spelldmg
            // --------------------------------------------------------
            cards.Add("CS2_032", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(4, EntityType.OP_MINIONS, true)
                }
            });

            // ------------------------------------------- SPELL - MAGE
            // [EX1_277] Arcane Missiles - COST:1 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Deal $3 damage randomly split among all enemies. *spelldmg
            // --------------------------------------------------------
            // GameTag:
            // - ImmuneToSpellpower = 1
            // --------------------------------------------------------
            cards.Add("EX1_277", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(3, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1), true)
                }
            });

            // ------------------------------------------ MINION - MAGE
            // [CS2_033] Water Elemental - COST:4 [ATK:3/HP:6] 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Freeze</b> any character damaged by this minion.
            // --------------------------------------------------------
            // GameTag:
            // - FREEZE = 1
            // --------------------------------------------------------
            cards.Add("CS2_033", null);

        }

        private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
            // ------------------------------------- ENCHANTMENT - MAGE
            // [CS2_022e] Polymorph (*) - COST:0 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: This minion has been transformed into a 1/1 Sheep.
            // --------------------------------------------------------
            // GameTag:
            // - MORPH = 1
            // --------------------------------------------------------
            cards.Add("CS2_022e", null);

            // ------------------------------------------ MINION - MAGE
            // [CS2_mirror] Mirror Image (*) - COST:0 [ATK:0/HP:2] 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS2_mirror", null);

        }

		private static void Paladin(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - PALADIN
			// [CS2_087] Blessing of Might - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a minion +3_Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_087", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.Attack(3), EntityType.TARGET)
                }
            });

			// ---------------------------------------- SPELL - PALADIN
			// [CS2_089] Holy Light - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Restore #6 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_089", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new HealTask(6, EntityType.TARGET)
                }
            });

			// ---------------------------------------- SPELL - PALADIN
			// [CS2_092] Blessing of Kings - COST:4 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +4/+4. <i>(+4 Attack/+4 Health)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_092", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackHealth(4), EntityType.TARGET)
                }
            });

			// ---------------------------------------- SPELL - PALADIN
			// [CS2_093] Consecration - COST:4 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to all_enemies. *spelldmg
			// --------------------------------------------------------
			cards.Add("CS2_093", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(2, EntityType.ENEMIES, true)
                }
            });

			// ---------------------------------------- SPELL - PALADIN
			// [CS2_094] Hammer of Wrath - COST:4 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $3 damage.
			//       Draw a card. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_094", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(3, EntityType.TARGET, true),
                        new DrawTask())
                }
            });

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_360] Humility - COST:1 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Change a minion's Attack to 1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_360", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.SetAttack(1, EntityType.TARGET)
                }
            });

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_371] Hand of Protection - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a minion <b>Divine Shield</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_371", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.DivineShield(EntityType.TARGET)
                }
            });

			// --------------------------------------- MINION - PALADIN
			// [CS2_088] Guardian of Kings - COST:7 [ATK:5/HP:6] 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 6 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_088", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new HealTask(6, EntityType.HERO)
                }
            });

            // --------------------------------------- WEAPON - PALADIN
            // [CS2_091] Light's Justice - COST:1 [ATK:1/HP:0] 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 4
            // --------------------------------------------------------
            cards.Add("CS2_091", null);

            // --------------------------------------- WEAPON - PALADIN
            // [CS2_097] Truesilver Champion - COST:4 [ATK:4/HP:0] 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever your hero attacks, restore 2_Health to it.
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 2
            // --------------------------------------------------------
            cards.Add("CS2_097", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.WEAPON,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsThisWeaponEquiped)
                        .TriggerEffect(GameTag.NUM_ATTACKS_THIS_TURN, 1)
                        .SingleTask(new HealTask(2, EntityType.TARGET))
                        .Build()
                }
            });

		}

		private static void PaladinNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [CS2_087e] Blessing of Might (*) - COST:0 
			// - Fac: neutral, Set: core, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_087e", null);

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [CS2_092e] Blessing of Kings (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			cards.Add("CS2_092e", null);

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_360e] Humility (*) - COST:0 
			// - Fac: neutral, Set: core, 
			// --------------------------------------------------------
			// Text: Attack has been changed to 1.
			// --------------------------------------------------------
			cards.Add("EX1_360e", null);

            // --------------------------------------- MINION - PALADIN
            // [CS2_101t] Silver Hand Recruit (*) - COST:1 [ATK:1/HP:1] 
            // - Set: core, Rarity: free
            // --------------------------------------------------------
            cards.Add("CS2_101t", null);

        }

		private static void Priest(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - PRIEST
			// [CS1_112] Holy Nova - COST:5 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to all enemies. Restore #2_Health to all friendly characters. *spelldmg
			// --------------------------------------------------------
			cards.Add("CS1_112", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(2, EntityType.ENEMIES, true),
                        new HealTask(2, EntityType.FRIENDS))
                }
            });

			// ----------------------------------------- SPELL - PRIEST
			// [CS1_113] Mind Control - COST:10 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Take control of an enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("CS1_113", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new ControlTask(EntityType.TARGET)
                }
            });

			// ----------------------------------------- SPELL - PRIEST
			// [CS1_130] Holy Smite - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $2 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS1_130", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(2, EntityType.TARGET, true)
                }
            });

			// ----------------------------------------- SPELL - PRIEST
			// [CS2_003] Mind Vision - COST:1 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Put a copy of a random card in your opponent's hand into your hand.
			// --------------------------------------------------------
			cards.Add("CS2_003", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.RandomCardCopyToHandFrom(EntityType.OP_HAND)
                }
            });

			// ----------------------------------------- SPELL - PRIEST
			// [CS2_004] Power Word: Shield - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a minion +2_Health.
			//       Draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_004", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DrawTask(),
                        new BuffTask(Buffs.Health(2), EntityType.TARGET))
                }
            });

			// ----------------------------------------- SPELL - PRIEST
			// [CS2_234] Shadow Word: Pain - COST:2 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Destroy a minion with 3_or less Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_MAX_ATTACK = 3
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_234", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DestroyTask(EntityType.TARGET)
                }
            });

			// ----------------------------------------- SPELL - PRIEST
			// [CS2_236] Divine Spirit - COST:2 
			// - Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Double a minion's Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_236", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.HEALTH, EntityType.TARGET),
                        new MathSubstractionTask(GameTag.DAMAGE, EntityType.TARGET),
                        new BuffHealthNumberTask(EntityType.TARGET))
                }
            });

			// ----------------------------------------- SPELL - PRIEST
			// [DS1_233] Mind Blast - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $5 damage to the enemy hero. *spelldmg
			// --------------------------------------------------------
			cards.Add("DS1_233", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(5, EntityType.OP_HERO, true)
                }
            });

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_622] Shadow Word: Death - COST:3 
			// - Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a minion with 5_or more Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_TARGET_MIN_ATTACK = 5
			// --------------------------------------------------------
			cards.Add("EX1_622", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DestroyTask(EntityType.TARGET)
                }
            });

			// ---------------------------------------- MINION - PRIEST
			// [CS2_235] Northshire Cleric - COST:1 [ATK:1/HP:3] 
			// - Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Whenever a minion is healed, draw a card.
			// --------------------------------------------------------
			cards.Add("CS2_235", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARDS,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(
                            SelfCondition.IsNotDead,
                            SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.DAMAGE, -1)
                        .SingleTask(new DrawTask())
                        .Build()
                }
            });

		}

		private static void PriestNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CS2_004e] Power Word: Shield (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("CS2_004e", null);

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CS2_236e] Divine Spirit (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: This minion has double Health.
			// --------------------------------------------------------
			cards.Add("CS2_236e", null);

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [EX1_019e] Cleric's Blessing (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_019e", null);

		}

		private static void Rogue(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [CS2_072] Backstab - COST:0 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $2 damage to an undamaged minion. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_UNDAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_072", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(2, EntityType.TARGET, true)
                }
            });

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_074] Deadly Poison - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give your weapon +2_Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			cards.Add("CS2_074", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.WeaponAtk(2), EntityType.WEAPON)
                }
            });

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_075] Sinister Strike - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $3 damage to the_enemy hero. *spelldmg
			// --------------------------------------------------------
			cards.Add("CS2_075", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(3, EntityType.OP_HERO, true)
                }
            });

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_076] Assassinate - COST:5 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Destroy an enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_076", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DestroyTask(EntityType.TARGET)
                }
            });

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_077] Sprint - COST:7 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 4 cards.
			// --------------------------------------------------------
			cards.Add("CS2_077", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(4, new DrawTask())
                }
            });

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_129] Fan of Knives - COST:3 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage to all enemy minions. Draw_a card. *spelldmg
			// --------------------------------------------------------
			cards.Add("EX1_129", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(1, EntityType.OP_MINIONS, true),
                        new DrawTask())
                }
            });

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_278] Shiv - COST:2 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage.
			//       Draw a card. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_278", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(1, EntityType.TARGET, true),
                        new DrawTask())
                }
            });

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_581] Sap - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Return an enemy minion to your opponent's hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_581", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new ReturnHandTask(EntityType.TARGET)
                }
            });

			// ------------------------------------------ SPELL - ROGUE
			// [NEW1_004] Vanish - COST:6 
			// - Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Return all minions to their owner's hand.
			// --------------------------------------------------------
			cards.Add("NEW1_004", new List<Enchantment> {
				// TODO [NEW1_004] Vanish && Test: Vanish_NEW1_004
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new ReturnHandTask(EntityType.OP_MINIONS),
				},
			});

            // ----------------------------------------- WEAPON - ROGUE
            // [CS2_080] Assassin's Blade - COST:5 [ATK:3/HP:0] 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 4
            // --------------------------------------------------------
            cards.Add("CS2_080", null);

        }

		private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CS2_083e] Sharpened (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +1 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("CS2_083e", null);

            // ----------------------------------------- WEAPON - ROGUE
            // [CS2_082] Wicked Knife (*) - COST:1 [ATK:1/HP:0] 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 2
            // --------------------------------------------------------
            cards.Add("CS2_082", null);

        }

		private static void Shaman(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_037] Frost Shock - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $1 damage to an enemy character and <b>Freeze</b> it. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_037", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(1, EntityType.TARGET, true),
                        ComplexTask.Freeze(EntityType.TARGET))
                }
            });

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_039] Windfury - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a minion <b>Windfury</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("CS2_039", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.WindFury(EntityType.TARGET)
                }
            });

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_041] Ancestral Healing - COST:0 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Restore a minion
			//       to full Health and
			//       give it <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_041", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new HealFullTask(EntityType.TARGET),
                        ComplexTask.Taunt(EntityType.TARGET))
                }
            });

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_045] Rockbiter Weapon - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a friendly character +3 Attack this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_045", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackTurn(3), EntityType.TARGET)
                }
            });

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_046] Bloodlust - COST:5 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions +3_Attack this turn.
			// --------------------------------------------------------
			cards.Add("CS2_046", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackTurn(3), EntityType.MINIONS)
                }
            });

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_244] Totemic Might - COST:0 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Give your Totems +2_Health.
			// --------------------------------------------------------
			cards.Add("EX1_244", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.Health(2),EntityType.MINIONS, SelfCondition.IsTagValue(GameTag.CARDRACE, (int)Race.TOTEM))
                }
            });

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_246] Hex - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Transform a minion into a 0/1 Frog with <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_246", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask =  new TransformTask("hexfrog", EntityType.TARGET)
                }
            });

			// ---------------------------------------- MINION - SHAMAN
			// [CS2_042] Fire Elemental - COST:6 [ATK:6/HP:5] 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CS2_042", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.TARGET,
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(3, EntityType.TARGET)
                }
            });

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_565] Flametongue Totem - COST:2 [ATK:0/HP:3] 
			// - Race: totem, Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Adjacent minions have +2_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ADJACENT_BUFF = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_565", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.Attack(2, RelaCondition.IsSideBySide)
                }
            });

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_587] Windspeaker - COST:4 [ATK:3/HP:3] 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion <b>Windfury</b>.
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
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("EX1_587", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.WindFury(EntityType.TARGET)
                }
            });

		}

		private static void ShamanNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [CS2_041e] Ancestral Infusion (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Taunt.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_041e", null);

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [CS2_045e] Rockbiter Weapon (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: This character has +3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("CS2_045e", null);

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [CS2_046e] Bloodlust (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("CS2_046e", null);

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [EX1_244e] Totemic Might (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("EX1_244e", null);

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [EX1_246e] Hexxed (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: This minion has been transformed!
			// --------------------------------------------------------
			// GameTag:
			// - MORPH = 1
			// --------------------------------------------------------
			cards.Add("EX1_246e", null);

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [EX1_565o] Flametongue (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +2 Attack from Flametongue Totem.
			// --------------------------------------------------------
			cards.Add("EX1_565o", null);

			// ---------------------------------------- MINION - SHAMAN
			// [CS2_050] Searing Totem (*) - COST:1 [ATK:1/HP:1] 
			// - Race: totem, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			cards.Add("CS2_050", null);

            // ---------------------------------------- MINION - SHAMAN
            // [CS2_051] Stoneclaw Totem (*) - COST:1 [ATK:0/HP:2] 
            // - Race: totem, Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS2_051", null);

            // ---------------------------------------- MINION - SHAMAN
            // [CS2_052] Wrath of Air Totem (*) - COST:1 [ATK:0/HP:2] 
            // - Race: totem, Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Spell Damage +1</b>
            // --------------------------------------------------------
            // GameTag:
            // - SPELLPOWER = 1
            // --------------------------------------------------------
            cards.Add("CS2_052", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(1)
                }
            });

			// ---------------------------------------- MINION - SHAMAN
			// [NEW1_009] Healing Totem (*) - COST:1 [ATK:0/HP:2] 
			// - Race: totem, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 1 Health to all friendly minions.
			// --------------------------------------------------------
			cards.Add("NEW1_009", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(new HealTask(1, EntityType.MINIONS))
                        .Build()
                }
            });

		}

		private static void Warlock(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARLOCK
			// [CS2_057] Shadow Bolt - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $4 damage
			//       to a minion. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_057", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(4, EntityType.TARGET, true)
                }
            });

			// ---------------------------------------- SPELL - WARLOCK
			// [CS2_061] Drain Life - COST:3 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $2 damage. Restore #2 Health to your hero. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_061", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(2, EntityType.TARGET, true),
                        new HealTask(2, EntityType.HERO))
                }
            });

			// ---------------------------------------- SPELL - WARLOCK
			// [CS2_062] Hellfire - COST:4 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Deal $3 damage to ALL_characters. *spelldmg
			// --------------------------------------------------------
			cards.Add("CS2_062", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(3, EntityType.ALL, true)
                }
            });

			// ---------------------------------------- SPELL - WARLOCK
			// [CS2_063] Corruption - COST:1 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Choose an enemy minion. At the start of your turn, destroy it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_063", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.TARGET,
                    Activation = EnchantmentActivation.SPELL,
                    Enchant = new Enchant
                    {
                        TurnsActive = 1,
                        EnableConditions = new List<SelfCondition>
                        {
                            SelfCondition.IsNotSilenced,
                            SelfCondition.IsInPlayZone
                        },
                        Effects = new Dictionary<GameTag, int>
                        {
                            [GameTag.NUM_TURNS_IN_PLAY] = 0
                        },
                        SingleTask = new DestroyTask(EntityType.TARGET)
                    }
                }
            });

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_302] Mortal Coil - COST:1 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage to a minion. If that kills it, draw a card. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_302", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(1, EntityType.TARGET, true),
                        new SelfConditionTask(EntityType.TARGET, SelfCondition.IsDead),
                        ComplexTask.True(new DrawTask()))
                }
            });

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_308] Soulfire - COST:1 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Deal $4 damage.
			//       Discard a random card. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_308", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(4, EntityType.TARGET, true),
                        ComplexTask.DiscardRandomCard(1))
                }
            });

			// ---------------------------------------- SPELL - WARLOCK
			// [NEW1_003] Sacrificial Pact - COST:0 
			// - Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a Demon. Restore #5 Health to your hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_WITH_RACE = 15
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("NEW1_003", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DestroyTask(EntityType.TARGET),
                        new HealTask(5, EntityType.HERO))
				}
			});

			// --------------------------------------- MINION - WARLOCK
			// [CS2_064] Dread Infernal - COST:6 [ATK:6/HP:6] 
			// - Race: demon, Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage to ALL other characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_064", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(1, EntityType.ALL_NOSOURCE)
                }
            });

			// --------------------------------------- MINION - WARLOCK
			// [CS2_065] Voidwalker - COST:1 [ATK:1/HP:3] 
			// - Race: demon, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CS2_065", null);

			// --------------------------------------- MINION - WARLOCK
			// [EX1_306] Succubus - COST:2 [ATK:4/HP:3] 
			// - Race: demon, Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Discard a random card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_306", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.DiscardRandomCard(1)
                }
            });

		}

		private static void WarlockNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [CS2_063e] Corruption (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: At the start of the corrupting player's turn, destroy this minion.
			// --------------------------------------------------------
			cards.Add("CS2_063e", null);

		}

		private static void Warrior(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [CS2_103] Charge - COST:1 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give a friendly minion <b>Charge</b>. It can't attack heroes this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CS2_103", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        ComplexTask.Charge(EntityType.TARGET),
                        new BuffTask(Buffs.Simple(GameTag.CANNOT_ATTACK_HEROES, 1, true), EntityType.TARGET))
                }
            });

			// ---------------------------------------- SPELL - WARRIOR
			// [CS2_105] Heroic Strike - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Give your hero +4_Attack this turn.
			// --------------------------------------------------------
			cards.Add("CS2_105", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackTurn(4), EntityType.HERO)
                }
            });

			// ---------------------------------------- SPELL - WARRIOR
			// [CS2_108] Execute - COST:2 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Destroy a damaged enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_DAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_108", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DestroyTask(EntityType.TARGET)
                }
            });

			// ---------------------------------------- SPELL - WARRIOR
			// [CS2_114] Cleave - COST:2 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Deal $2 damage to
			//       two random enemy
			//       minions. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("CS2_114", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.DamageRandomTargets(2, EntityType.OP_MINIONS, 2, true)
                }
            });

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_400] Whirlwind - COST:1 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage to ALL_minions. *spelldmg
			// --------------------------------------------------------
			cards.Add("EX1_400", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(1, EntityType.MINIONS, true)
                }
            });

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_606] Shield Block - COST:3 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Draw a card.
			// --------------------------------------------------------
			cards.Add("EX1_606", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new ArmorTask(5),
                        new DrawTask())
                }
            });

			// --------------------------------------- MINION - WARRIOR
			// [EX1_084] Warsong Commander - COST:3 [ATK:2/HP:3] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: Your <b>Charge</b> minions have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_084", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.Attack(1, RelaCondition.HasTargetTagValue(GameTag.CHARGE, 1)), AuraArea.BOARD)
                }
            });

            // --------------------------------------- MINION - WARRIOR
            // [NEW1_011] Kor'kron Elite - COST:4 [ATK:4/HP:3] 
            // - Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("NEW1_011", null);

            // --------------------------------------- WEAPON - WARRIOR
            // [CS2_106] Fiery War Axe - COST:2 [ATK:3/HP:0] 
            // - Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 2
            // --------------------------------------------------------
            cards.Add("CS2_106", null);

            // --------------------------------------- WEAPON - WARRIOR
            // [CS2_112] Arcanite Reaper - COST:5 [ATK:5/HP:0] 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 2
            // --------------------------------------------------------
            cards.Add("CS2_112", null);

        }

		private static void WarriorNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CS2_103e2] Charge (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Has <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("CS2_103e2", null);

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CS2_105e] Heroic Strike (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: +4 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("CS2_105e", null);

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [EX1_084e] Charge (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Warsong Commander is granting this minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_084e", null);

		}

		private static void Neutral(IDictionary<string, List<Enchantment>> cards)
		{
            // --------------------------------------- MINION - NEUTRAL
            // [CS1_042] Goldshire Footman - COST:1 [ATK:1/HP:2] 
            // - Fac: alliance, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS1_042", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_118] Magma Rager - COST:3 [ATK:5/HP:1] 
            // - Set: core, Rarity: free
            // --------------------------------------------------------
            cards.Add("CS2_118", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_119] Oasis Snapjaw - COST:4 [ATK:2/HP:7] 
            // - Race: beast, Set: core, Rarity: free
            // --------------------------------------------------------
            cards.Add("CS2_119", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_120] River Crocolisk - COST:2 [ATK:2/HP:3] 
            // - Race: beast, Set: core, Rarity: free
            // --------------------------------------------------------
            cards.Add("CS2_120", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_121] Frostwolf Grunt - COST:2 [ATK:2/HP:2] 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS2_121", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_122] Raid Leader - COST:3 [ATK:2/HP:2] 
            // - Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: Your other minions have +1 Attack.
            // --------------------------------------------------------
            // GameTag:
            // - AURA = 1
            // --------------------------------------------------------
            cards.Add("CS2_122", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.Attack(1)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_124] Wolfrider - COST:3 [ATK:3/HP:1] 
            // - Fac: horde, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("CS2_124", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_125] Ironfur Grizzly - COST:3 [ATK:3/HP:3] 
            // - Race: beast, Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS2_125", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_127] Silverback Patriarch - COST:3 [ATK:1/HP:4] 
            // - Race: beast, Fac: horde, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS2_127", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_131] Stormwind Knight - COST:4 [ATK:2/HP:5] 
            // - Fac: alliance, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("CS2_131", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_141] Ironforge Rifleman - COST:3 [ATK:2/HP:2] 
            // - Fac: alliance, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal 1 damage.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NONSELF_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("CS2_141", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(1, EntityType.TARGET)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_142] Kobold Geomancer - COST:2 [ATK:2/HP:2] 
			// - Fac: horde, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("CS2_142", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(1)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_147] Gnomish Inventor - COST:4 [ATK:2/HP:4] 
			// - Fac: alliance, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_147", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DrawTask()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_150] Stormpike Commando - COST:5 [ATK:4/HP:2] 
			// - Fac: alliance, Set: core, Rarity: common
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
			cards.Add("CS2_150", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(2, EntityType.TARGET)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_155] Archmage - COST:6 [ATK:4/HP:7] 
			// - Fac: alliance, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("CS2_155", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(1)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_162] Lord of the Arena - COST:6 [ATK:6/HP:5] 
            // - Fac: alliance, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS2_162", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_168] Murloc Raider - COST:1 [ATK:2/HP:1] 
            // - Race: murloc, Fac: alliance, Set: core, Rarity: free
            // --------------------------------------------------------
            cards.Add("CS2_168", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_171] Stonetusk Boar - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Fac: neutral, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("CS2_171", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_172] Bloodfen Raptor - COST:2 [ATK:3/HP:2] 
            // - Race: beast, Fac: horde, Set: core, Rarity: free
            // --------------------------------------------------------
            cards.Add("CS2_172", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_173] Bluegill Warrior - COST:2 [ATK:2/HP:1] 
            // - Race: murloc, Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("CS2_173", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_179] Sen'jin Shieldmasta - COST:4 [ATK:3/HP:5] 
            // - Fac: horde, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS2_179", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_182] Chillwind Yeti - COST:4 [ATK:4/HP:5] 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            cards.Add("CS2_182", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_186] War Golem - COST:7 [ATK:7/HP:7] 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            cards.Add("CS2_186", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_187] Booty Bay Bodyguard - COST:5 [ATK:5/HP:4] 
            // - Fac: horde, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("CS2_187", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_189] Elven Archer - COST:1 [ATK:1/HP:1] 
            // - Fac: horde, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal 1 damage.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NONSELF_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("CS2_189", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(1, EntityType.TARGET)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_196] Razorfen Hunter - COST:3 [ATK:2/HP:3] 
			// - Fac: horde, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 1/1_Boar.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_196", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SummonTask("CS2_boar")
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_197] Ogre Magi - COST:4 [ATK:4/HP:4] 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("CS2_197", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(1)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_200] Boulderfist Ogre - COST:6 [ATK:6/HP:7] 
            // - Set: core, Rarity: free
            // --------------------------------------------------------
            cards.Add("CS2_200", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_201] Core Hound - COST:7 [ATK:9/HP:5] 
            // - Race: beast, Set: core, Rarity: common
            // --------------------------------------------------------
            cards.Add("CS2_201", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_213] Reckless Rocketeer - COST:6 [ATK:5/HP:2] 
            // - Fac: horde, Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("CS2_213", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_222] Stormwind Champion - COST:7 [ATK:6/HP:6] 
            // - Fac: alliance, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: Your other minions have +1/+1.
            // --------------------------------------------------------
            // GameTag:
            // - AURA = 1
            // --------------------------------------------------------
            cards.Add("CS2_222", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.AttackHealth(1, 1)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_226] Frostwolf Warlord - COST:5 [ATK:4/HP:4] 
            // - Fac: horde, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Gain +1/+1 for each other friendly minion on the battlefield.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("CS2_226", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = SpecificTask.FrostwolfBanner
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [DS1_055] Darkscale Healer - COST:5 [ATK:4/HP:5] 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 2 Health to all friendly characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DS1_055", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new HealTask(2, EntityType.FRIENDS)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_011] Voodoo Doctor - COST:1 [ATK:2/HP:1] 
			// - Fac: horde, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 2_Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_011", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new HealTask(2, EntityType.TARGET)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_015] Novice Engineer - COST:2 [ATK:1/HP:1] 
			// - Fac: alliance, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_015", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DrawTask()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_019] Shattered Sun Cleric - COST:3 [ATK:3/HP:2] 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_019", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.TARGET,
                    Activation = EnchantmentActivation.BATTLECRY,
                    Enchant = Buffs.AttackHealth(1)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_025] Dragonling Mechanic - COST:4 [ATK:2/HP:4] 
			// - Fac: alliance, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/1 Mechanical Dragonling.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_025", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SummonTask("EX1_025t")
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_066] Acidic Swamp Ooze - COST:2 [ATK:3/HP:2] 
			// - Fac: alliance, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_066", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DestroyTask(EntityType.OP_WEAPON)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_399] Gurubashi Berserker - COST:5 [ATK:2/HP:7] 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, gain +3_Attack.
			// --------------------------------------------------------
			cards.Add("EX1_399", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.DAMAGE, 1)
                        .SingleTask(new BuffTask(Buffs.Attack(3), EntityType.SOURCE))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_506] Murloc Tidehunter - COST:2 [ATK:2/HP:1] 
			// - Race: murloc, Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 1/1_Murloc Scout.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_506", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SummonTask("EX1_506a")
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_508] Grimscale Oracle - COST:1 [ATK:1/HP:1] 
			// - Race: murloc, Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: Your other Murlocs have +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_508", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.Attack(1, RelaCondition.IsSameRace)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_582] Dalaran Mage - COST:3 [ATK:1/HP:4] 
			// - Fac: neutral, Set: core, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("EX1_582", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(1)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_593] Nightblade - COST:5 [ATK:4/HP:4] 
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Battlecry: </b>Deal 3 damage to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_593", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(3, EntityType.OP_HERO)
                }
            });

		}

		private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - NEUTRAL
			// [GAME_005] The Coin (*) - COST:0 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			cards.Add("GAME_005", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new TempManaTask(1)
                }
            });

			// ---------------------------------------- SPELL - NEUTRAL
			// [GAME_006] NOOOOOOOOOOOO (*) - COST:2 
			// - Set: core, 
			// --------------------------------------------------------
			// Text: Somehow, the card you USED to have has been deleted.  Here, have this one instead!
			// --------------------------------------------------------
			cards.Add("GAME_006", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CS2_074e] Deadly Poison (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: +2 Attack.
            // --------------------------------------------------------
            cards.Add("CS2_074e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CS2_122e] Enhanced (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: Raid Leader is granting this minion +1 Attack.
            // --------------------------------------------------------
            cards.Add("CS2_122e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CS2_222o] Might of Stormwind (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: Has +1/+1.
            // --------------------------------------------------------
            cards.Add("CS2_222o", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CS2_226e] Frostwolf Banner (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("CS2_226e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_399e] Berserking (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: This minion has increased Attack.
            // --------------------------------------------------------
            cards.Add("EX1_399e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_508o] Mlarggragllabl! (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: This Murloc has +1 Attack.
            // --------------------------------------------------------
            cards.Add("EX1_508o", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [GAME_001] Luck of the Coin (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: Going second grants you increased Health.
            // --------------------------------------------------------
            cards.Add("GAME_001", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [GAME_003] Coin's Vengeance (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: Going second makes your first minion stronger.
            // --------------------------------------------------------
            cards.Add("GAME_003", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [GAME_003e] Coin's Vengence (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: Going second makes your first minion stronger.
            // --------------------------------------------------------
            cards.Add("GAME_003e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [GAME_004] AFK (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            // Text: Your turns are shorter.
            // --------------------------------------------------------
            cards.Add("GAME_004", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [GAME_005e] The Coin (*) - COST:0 
            // - Set: core, 
            // --------------------------------------------------------
            cards.Add("GAME_005e", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_boar] Boar (*) - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            cards.Add("CS2_boar", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_tk1] Sheep (*) - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            cards.Add("CS2_tk1", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_025t] Mechanical Dragonling (*) - COST:1 [ATK:2/HP:1] 
            // - Race: mechanical, Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            cards.Add("EX1_025t", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_506a] Murloc Scout (*) - COST:1 [ATK:1/HP:1] 
            // - Race: murloc, Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            cards.Add("EX1_506a", null);

            // --------------------------------------- MINION - NEUTRAL
            // [GAME_002] Avatar of the Coin (*) - COST:0 [ATK:1/HP:1] 
            // - Set: core, Rarity: free
            // --------------------------------------------------------
            // Text: <i>You lost the coin flip, but gained a friend.</i>
            // --------------------------------------------------------
            cards.Add("GAME_002", null);

            // --------------------------------------- MINION - NEUTRAL
            // [hexfrog] Frog (*) - COST:0 [ATK:0/HP:1] 
            // - Race: beast, Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("hexfrog", null);

            // --------------------------------------- MINION - NEUTRAL
            // [skele11] Skeleton (*) - COST:1 [ATK:1/HP:1] 
            // - Fac: neutral, Set: core, Rarity: common
            // --------------------------------------------------------
            // Text: <b></b>
            // --------------------------------------------------------
            cards.Add("skele11", null);

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
