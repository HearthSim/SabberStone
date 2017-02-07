using System.Collections.Generic;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Standard
{
	public class Expert1CardsGen
	{
		private static void Heroes(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- HERO - WARLOCK
			// [EX1_323h] Lord Jaraxxus (*) - COST:0 [ATK:0/HP:15] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1178
			// --------------------------------------------------------
			cards.Add("EX1_323h", null);

		}

		private static void HeroPowers(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------ HERO_POWER - PRIEST
			// [EX1_625t] Mind Spike (*) - COST:2 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_625t", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(2, EntityType.TARGET, false)
                }
            });

			// ------------------------------------ HERO_POWER - PRIEST
			// [EX1_625t2] Mind Shatter (*) - COST:2 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $3 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_625t2", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(3, EntityType.TARGET, false)
                }
            });

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
			cards.Add("EX1_tk33", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new SummonTask("EX1_tk34")
                }
            });

		}

		private static void Druid(IDictionary<string, List<Enchantment>> cards)
		{
            // ------------------------------------------ SPELL - DRUID
            // [EX1_154] Wrath - COST:2 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Choose One -</b> Deal $3 damage to a minion; or $1 damage and draw a card. *spelldmg
            // --------------------------------------------------------
            // GameTag:
            // - CHOOSE_ONE = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("EX1_154", 
                //CHOOSE_ONE
                null);

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
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            // RefTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("EX1_155",
                //CHOOSE_ONE
                null);

            // ------------------------------------------ SPELL - DRUID
            // [EX1_158] Soul of the Forest - COST:4 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: Give your minions "<b>Deathrattle:</b> Summon a 2/2 Treant."
            // --------------------------------------------------------
            // RefTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("EX1_158", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DeathrattleTask(EntityType.MINIONS,
                        new Enchantment
                        {
                            Activation = EnchantmentActivation.DEATHRATTLE,
                            SingleTask = new SummonTask("EX1_158t")
                        })
				}
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_160] Power of the Wild - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Give your minions +1/+1; or Summon a 3/2 Panther.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("EX1_160",
                //CHOOSE_ONE
                null);

            // ------------------------------------------ SPELL - DRUID
            // [EX1_161] Naturalize - COST:1 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: Destroy a minion.
            //       Your opponent draws 2_cards.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("EX1_161", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DestroyTask(EntityType.TARGET),
                        new EnqueueTask(2, new DrawOpTask()))
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_164] Nourish - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Gain 2_Mana Crystals; or Draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("EX1_164",
                //CHOOSE_ONE
                null);

            // ------------------------------------------ SPELL - DRUID
            // [EX1_570] Bite - COST:4 
            // - Fac: neutral, Set: expert1, Rarity: rare
            // --------------------------------------------------------
            // Text: Give your hero +4_Attack this turn and 4 Armor.
            // --------------------------------------------------------
            cards.Add("EX1_570", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new BuffTask(Buffs.AttackTurn(4), EntityType.HERO),
                        new ArmorTask(4))
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_571] Force of Nature - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon three 2/2 Treants.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("EX1_571", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new EnqueueTask(3, new SummonTask("EX1_158t")),
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_578] Savagery - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal damage equal to your hero's Attack to a minion. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_578", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.ATK, EntityType.HERO),
                        new DamageNumberTask(EntityType.TARGET))
                },
			});

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_007] Starfall - COST:5 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Deal $5 damage to a minion; or $2 damage to all enemy minions. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("NEW1_007", 
                // CHOOSE_ONE
                null);

			// ----------------------------------------- MINION - DRUID
			// [EX1_165] Druid of the Claw - COST:5 [ATK:4/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> <b>Charge</b>; or +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_165", 
                //CHOOSE_ONE
                null);

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
			cards.Add("EX1_166",
                //CHOOSE_ONE
                null);

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
            cards.Add("EX1_178", 
                // CHOOSE_ONE
                null);

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
            cards.Add("EX1_573", 
                // CHOOSE_ONE
                null);

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
			cards.Add("NEW1_008",
                // CHOOSE_ONE
                null);

		}

		private static void DruidNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [EX1_154a] Wrath (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal $3 damage to a minion. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_154a", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(3, EntityType.TARGET, true),
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_154b] Wrath (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal $1 damage to a minion. Draw a card. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_154b", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(1, EntityType.TARGET, true),
                        new DrawTask())
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_155a] Mark of Nature (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: +4 Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_155a", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.Attack(4), EntityType.TARGET)
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_155b] Mark of Nature (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: +4 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_155b", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new BuffTask(Buffs.Health(4), EntityType.TARGET),
                        ComplexTask.Taunt(EntityType.TARGET))
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_160a] Summon a Panther (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Summon a 3/2 Panther.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("EX1_160a", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new SummonTask("EX1_160t")
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_160b] Leader of the Pack (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Give your minions +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_160b", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackHealth(1), EntityType.MINIONS)
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_164a] Nourish (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Gain 2 Mana Crystals.
			// --------------------------------------------------------
			cards.Add("EX1_164a", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new ManaCrystalEmptyTask(2)
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_164b] Nourish (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			// --------------------------------------------------------
			cards.Add("EX1_164b", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(3, new DrawTask())
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_165a] Cat Form (*) - COST:0 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			cards.Add("EX1_165a", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new TransformTask("EX1_165t1", EntityType.SOURCE)
                },
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_165b] Bear Form (*) - COST:0 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_165b", new List<Enchantment> {
				new Enchantment
				{
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new TransformTask("EX1_165t2", EntityType.SOURCE)
                },
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_166a] Moonfire (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal 2 damage.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_166a", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(2, EntityType.TARGET)
                }
            });

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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_166b", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SilenceTask(EntityType.TARGET)
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_178a] Rooted (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: +5 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_178a", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new BuffTask(Buffs.Health(5), EntityType.SOURCE),
                        ComplexTask.Taunt(EntityType.SOURCE))
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_178b] Uproot (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: +5 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_178b", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new BuffTask(Buffs.Attack(5), EntityType.SOURCE)
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [EX1_573a] Demigod's Favor (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Give your other minions +2/+2.
			// --------------------------------------------------------
			cards.Add("EX1_573a", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new BuffTask(Buffs.AttackHealth(2), EntityType.MINIONS_NOSOURCE),
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [EX1_573b] Shan'do's Lesson (*) - COST:0 
			// - Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			// Text: Summon two 2/2 Treants with <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_573b", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new EnqueueTask(2, new SummonTask("EX1_573t"))
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_007a] Starfall (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal $2 damage to all enemy minions. *spelldmg
			// --------------------------------------------------------
			cards.Add("NEW1_007a", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(2, EntityType.OP_MINIONS)
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_007b] Starfall (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal $5 damage to a minion. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("NEW1_007b", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(5, EntityType.TARGET)
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_008a] Ancient Teachings (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Draw a card.
			// --------------------------------------------------------
			cards.Add("NEW1_008a", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DrawTask()
                }
            });

			// ------------------------------------------ SPELL - DRUID
			// [NEW1_008b] Ancient Secrets (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Restore 5 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("NEW1_008b", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new HealTask(5, EntityType.TARGET),
                }
            });

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_155ae] Mark of Nature (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion has +4 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_155ae", null);

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_155be] Mark of Nature (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion has +4 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("EX1_155be", null);

			// ------------------------------------ ENCHANTMENT - DRUID
			// [EX1_158e] Soul of the Forest (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Deathrattle: Summon a 2/2 Treant.
			// --------------------------------------------------------
			cards.Add("EX1_158e", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [EX1_160be] Leader of the Pack (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("EX1_160be", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [EX1_178ae] Rooted (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +5 Health and <b>Taunt</b>.
            // --------------------------------------------------------
            cards.Add("EX1_178ae", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [EX1_178be] Uprooted (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +5 Attack.
            // --------------------------------------------------------
            cards.Add("EX1_178be", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [EX1_573ae] Demigod's Favor (*) - COST:0 
            // - Fac: neutral, Set: expert1, 
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("EX1_573ae", null);

            // ----------------------------------------- MINION - DRUID
            // [EX1_158t] Treant (*) - COST:2 [ATK:2/HP:2] 
            // - Fac: neutral, Set: expert1, 
            // --------------------------------------------------------
            cards.Add("EX1_158t", null);

			// ----------------------------------------- MINION - DRUID
			// [EX1_160t] Panther (*) - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_160t", null);

			// ----------------------------------------- MINION - DRUID
			// [EX1_165t1] Druid of the Claw (*) - COST:5 [ATK:4/HP:4] 
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_165t1", null);

			// ----------------------------------------- MINION - DRUID
			// [EX1_165t2] Druid of the Claw (*) - COST:5 [ATK:4/HP:6] 
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_165t2", null);

			// ----------------------------------------- MINION - DRUID
			// [EX1_573t] Treant (*) - COST:2 [ATK:2/HP:2] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_573t", null);

			// ----------------------------------------- MINION - DRUID
			// [EX1_tk9] Treant (*) - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_tk9", null);

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
			cards.Add("OG_044a", null);

		}

		private static void Hunter(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - HUNTER
			// [EX1_533] Misdirection - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy attacks your hero, instead it attacks another random character.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_533", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.OP_BOARD_AND_OP_HERO,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .ApplyConditions(RelaCondition.IsMyHeroAttacked, RelaCondition.IsMe(SelfCondition.IsAnyNotImmune))
                        .TriggerEffect(GameTag.ATTACKING, 1)
                        .FastExecution(true)
                        .SingleTask(ComplexTask.Secret(
                            new IncludeTask(EntityType.ALL, new []{EntityType.TARGET, EntityType.OP_HERO}),
                            new FilterStackTask(SelfCondition.IsNotDead, SelfCondition.IsNotImmune),
                            new RandomTask(1, EntityType.STACK),
                            new ChangeAttackingTargetTask(EntityType.TARGET, EntityType.STACK)))
                        .Build()
                }
            });

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_537] Explosive Shot - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage to a minion and $2 damage to adjacent ones. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_537", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DamageTask(5, EntityType.TARGET, true),
                        new IncludeTask(EntityType.OP_MINIONS),
                        new FilterStackTask(EntityType.TARGET, RelaCondition.IsSideBySide),
                        new DamageTask(2, EntityType.STACK, true))
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_538] Unleash the Hounds - COST:3 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: For each enemy minion, summon a 1/1 Hound with <b>Charge</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_538", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new CountTask(EntityType.OP_MINIONS),
                        new EnqueueNumberTask(new SummonTask("EX1_538t"))),
				},
			});

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
			cards.Add("EX1_544", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new RevealStealthTask(EntityType.OP_MINIONS),
                        new MoveToGraveYard(EntityType.OP_SECRETS),
                        new DrawTask())
                },
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_549] Bestial Wrath - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a friendly Beast +2 Attack and <b>Immune</b> this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_WITH_RACE = 20
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("EX1_549", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new BuffTask(Buffs.AttackTurn(2), EntityType.TARGET),
                        new BuffTask(Buffs.ImmuneTurn(), EntityType.TARGET))
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_554] Snake Trap - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions is attacked, summon three 1/1 Snakes.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_554", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .TriggerEffect(GameTag.DEFENDING, 1)
                        .SingleTask(ComplexTask.Secret(
                            new EnqueueTask(3, new SummonTask("EX1_554t"))))
                        .Build()
				}
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_609] Snipe - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, deal $4 damage to it. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_609", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.OP_BOARD,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .TriggerEffect(GameTag.JUST_PLAYED, -1)
                        .SingleTask(ComplexTask.Secret(
                            new DamageTask(4, EntityType.TARGET, true)))
                        .Build()
                },
			});

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_610] Explosive Trap - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your hero is attacked, deal $2 damage to all enemies. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_610", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .TriggerEffect(GameTag.DEFENDING, 1)
                        .SingleTask(ComplexTask.Secret(
                            new DamageTask(2, EntityType.ENEMIES, true)))
                        .Build()
                },
            });

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_611] Freezing Trap - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy minion attacks, return it to its owner's hand. It costs (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_611", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.OP_BOARD,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                    .EnableConditions(SelfCondition.IsSecretActive)
                    .TriggerEffect(GameTag.ATTACKING, 1)
                    .SingleTask(ComplexTask.Secret(
                        new ReturnHandTask(EntityType.TARGET)))
                        .Build()
                },
            });

			// ----------------------------------------- SPELL - HUNTER
			// [EX1_617] Deadly Shot - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a random enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("EX1_617", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                            new RandomTask(1, EntityType.OP_MINIONS),
                            new DestroyTask(EntityType.STACK)),
				},
			});

			// ---------------------------------------- MINION - HUNTER
			// [EX1_531] Scavenging Hyena - COST:2 [ATK:2/HP:2] 
			// - Race: beast, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever a friendly Beast dies, gain +2/+1.
			// --------------------------------------------------------
			cards.Add("EX1_531", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                                .EnableConditions(SelfCondition.IsNotDead,  SelfCondition.IsNotSilenced)
                                .ApplyConditions(RelaCondition.IsSameRace)
                                .TriggerEffect(GameTag.TO_BE_DESTROYED, 1)
                                .SingleTask(new BuffTask(Buffs.AttackHealth(2, 1), EntityType.SOURCE))
                                .Build()
                }
            });

			// ---------------------------------------- MINION - HUNTER
			// [EX1_534] Savannah Highmane - COST:6 [ATK:6/HP:5] 
			// - Race: beast, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 2/2 Hyenas.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_534", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new EnqueueTask(2, new SummonTask("EX1_534t"))
                }
            });

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
            cards.Add("EX1_543", null);

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
            cards.Add("DS1_188", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = new AuraTask(Auras.Immune(RelaCondition.IsOther(SelfCondition.IsAttacking)), AuraArea.HERO),
				},
			});

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
			cards.Add("EX1_536", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SECRET,
                    Activation = EnchantmentActivation.WEAPON,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsThisWeaponEquiped)
                        .TriggerEffect(GameTag.REVEALED, 1)
                        .SingleTask(ComplexTask.Create(
                            new GetGameTagTask(GameTag.DURABILITY, EntityType.WEAPON),
                            new MathAddTask(1),
                            new SetGameTagNumberTask(GameTag.DURABILITY, EntityType.WEAPON)))
                        .Build()
                },
            });

		}

		private static void HunterNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [DS1_188e] Gladiator's Longbow enchantment (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			cards.Add("DS1_188e", null);

            // ----------------------------------- ENCHANTMENT - HUNTER
            // [EX1_531e] Well Fed (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased Attack and Health.
            // --------------------------------------------------------
            cards.Add("EX1_531e", null);

            // ----------------------------------- ENCHANTMENT - HUNTER
            // [EX1_536e] Upgraded (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased Durability.
            // --------------------------------------------------------
            cards.Add("EX1_536e", null);

            // ----------------------------------- ENCHANTMENT - HUNTER
            // [EX1_549o] Bestial Wrath (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +2 Attack and <b>Immune</b> this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("EX1_549o", null);

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [EX1_611e] Trapped (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Will be <b>Frozen</b> again at the start of the next turn.
			// --------------------------------------------------------
			cards.Add("EX1_611e", null);

            // ---------------------------------------- MINION - HUNTER
            // [EX1_534t] Hyena (*) - COST:2 [ATK:2/HP:2] 
            // - Race: beast, Set: expert1, Rarity: rare
            // --------------------------------------------------------
            cards.Add("EX1_534t", null);

            // ---------------------------------------- MINION - HUNTER
            // [EX1_538t] Hound (*) - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Set: expert1, 
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("EX1_538t", null);

			// ---------------------------------------- MINION - HUNTER
			// [EX1_554t] Snake (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_554t", null);

		}

		private static void Mage(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [CS2_028] Blizzard - COST:6 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to all enemy minions and <b>Freeze</b> them. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CS2_028", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(2, EntityType.OP_MINIONS, true),
                        ComplexTask.Freeze(EntityType.OP_MINIONS))
                }
            });

			// ------------------------------------------- SPELL - MAGE
			// [CS2_031] Ice Lance - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a character. If it was already <b>Frozen</b>, deal $4 damage instead. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_031", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.TARGET, SelfCondition.IsFrozen),
                        ComplexTask.True(new DamageTask(4, EntityType.TARGET, true)),
                        ComplexTask.False(ComplexTask.Freeze(EntityType.TARGET)))
                }
            });

			// ------------------------------------------- SPELL - MAGE
			// [EX1_275] Cone of Cold - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion and the minions next to it, and deal $1 damage to them. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_275", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(1, EntityType.TARGET, true),
                        ComplexTask.Freeze(EntityType.TARGET),
                        new IncludeTask(EntityType.OP_MINIONS),
                        new FilterStackTask(EntityType.TARGET, RelaCondition.IsSideBySide),
                        new DamageTask(1, EntityType.STACK, true),
                        ComplexTask.Freeze(EntityType.STACK))
                },

            });

			// ------------------------------------------- SPELL - MAGE
			// [EX1_279] Pyroblast - COST:10 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $10 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_279", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(10, EntityType.TARGET, true)
                }
            });

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
			cards.Add("EX1_287", new List<Enchantment> {
            new Enchantment
                {
                    Area = EnchantmentArea.OP_HAND,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell))
                        .FastExecution(true)
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(ComplexTask.Secret(
                            new SetGameTagTask(GameTag.COUNTER, 1, EntityType.TARGET)))
                        .Build()
                },
            });

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
			cards.Add("EX1_289", new List<Enchantment> {
				// TODO [EX1_289] Ice Barrier && Test: Ice Barrier_EX1_289
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [EX1_294] Mirror Entity - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, summon a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_294", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.OP_BOARD,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .TriggerEffect(GameTag.JUST_PLAYED, -1)
                        .SingleTask(ComplexTask.Secret(
                            new CopyTask(EntityType.TARGET, 1),
                            new SummonTask()))
                        .Build()
                },
			});

            // ------------------------------------------- SPELL - MAGE
            // [EX1_295] Ice Block - COST:3 
            // - Fac: neutral, Set: expert1, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Secret:</b> When your hero takes fatal damage, prevent it and become <b>Immune</b> this turn.
            // --------------------------------------------------------
            // GameTag:
            // - SECRET = 1
            // --------------------------------------------------------
            // RefTag:
            // - IMMUNE = 1
            // --------------------------------------------------------
            cards.Add("EX1_295", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsHero), RelaCondition.IsOther(SelfCondition.IsLethalPreDamaged))
                        .FastExecution(true)
                        .TriggerEffect(GameTag.PREDAMAGE, 1)
                        .SingleTask(ComplexTask.Secret(
                                ComplexTask.Create(new SetGameTagTask(GameTag.PREDAMAGE, 0, EntityType.HERO),
                                new BuffTask(Buffs.ImmuneTurn(), EntityType.TARGET)))
                        )
                        .Build()
                },
            });

            // ------------------------------------------- SPELL - MAGE
            // [EX1_594] Vaporize - COST:3 
            // - Fac: neutral, Set: expert1, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Secret:</b> When a minion attacks your hero, destroy it.
            // --------------------------------------------------------
            // GameTag:
            // - SECRET = 1
            // --------------------------------------------------------
            cards.Add("EX1_594", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.OP_BOARD,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .ApplyConditions(RelaCondition.IsMyHeroAttacked)
                        .TriggerEffect(GameTag.ATTACKING, 1)
                        .FastExecution(true)
                        .SingleTask(ComplexTask.Secret(
                            new DestroyTask(EntityType.TARGET)))
                        .Build()
				},
            });

            // ------------------------------------------- SPELL - MAGE
            // [tt_010] Spellbender - COST:3 
            // - Fac: neutral, Set: expert1, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Secret:</b> When an enemy casts a spell on a minion, summon a 1/3 as the new target.
            // --------------------------------------------------------
            // GameTag:
            // - SECRET = 1
            // --------------------------------------------------------
            cards.Add("tt_010", new List<Enchantment> {
				// TODO [tt_010] Spellbender && Test: Spellbender_tt_010
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ MINION - MAGE
			// [EX1_274] Ethereal Arcanist - COST:4 [ATK:3/HP:3] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: If you control a <b>Secret</b> at_the end of your turn, gain +2/+2.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_274", new List<Enchantment> {
				// TODO [EX1_274] Ethereal Arcanist && Test: Ethereal Arcanist_EX1_274
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ------------------------------------------ MINION - MAGE
			// [EX1_559] Archmage Antonidas - COST:7 [ATK:5/HP:7] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, add a 'Fireball' spell to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_559", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new AddCardTo("CS2_029", EntityType.HAND))
                        .Build()
                }
            });

			// ------------------------------------------ MINION - MAGE
			// [EX1_608] Sorcerer's Apprentice - COST:2 [ATK:3/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Your spells cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_608", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.Cost(-1, RelaCondition.IsOther(SelfCondition.IsSpell)), AuraArea.HAND)
                }
            });

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
			cards.Add("EX1_612", new List<Enchantment> {
				// TODO [EX1_612] Kirin Tor Mage && Test: Kirin Tor Mage_EX1_612
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ------------------------------------------ MINION - MAGE
			// [NEW1_012] Mana Wyrm - COST:1 [ATK:1/HP:3] 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("NEW1_012", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new BuffTask(Buffs.Attack(1), EntityType.SOURCE))
                        .Build()
                }
            });

		}

		private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [EX1_274e] Raw Power! (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("EX1_274e", null);

            // ------------------------------------- ENCHANTMENT - MAGE
            // [EX1_295o] Ice Block (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Your hero is <b>Immune</b> this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("EX1_295o", null);

            // ------------------------------------- ENCHANTMENT - MAGE
            // [EX1_612o] Power of the Kirin Tor (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Your next Secret costs (0).
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("EX1_612o", null);

            // ------------------------------------- ENCHANTMENT - MAGE
            // [NEW1_012o] Mana Gorged (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased attack.
            // --------------------------------------------------------
            cards.Add("NEW1_012o", null);

            // ------------------------------------------ MINION - MAGE
            // [tt_010a] Spellbender (*) - COST:1 [ATK:1/HP:3] 
            // - Set: expert1, Rarity: epic
            // --------------------------------------------------------
            cards.Add("tt_010a", new List<Enchantment> {
				// TODO [tt_010a] Spellbender && Test: Spellbender_tt_010a
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Paladin(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - PALADIN
			// [EX1_130] Noble Sacrifice - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy attacks, summon a 2/1 Defender as the new target.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_130", new List<Enchantment> {
				// TODO [EX1_130] Noble Sacrifice && Test: Noble Sacrifice_EX1_130
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_132] Eye for an Eye - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your hero takes damage, deal_that much damage to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_132", new List<Enchantment> {
				// TODO [EX1_132] Eye for an Eye && Test: Eye for an Eye_EX1_132
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_136] Redemption - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions dies, return it to life with 1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_136", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                                .EnableConditions(SelfCondition.IsSecretActive)
                                .TriggerEffect(GameTag.TO_BE_DESTROYED, 1)
                                .SingleTask(ComplexTask.Secret(
                                    new CopyTask(EntityType.TARGET, 1),
                                    new FuncTask(list =>
                                    {
                                        var target = list[0] as ICharacter;
                                        if (target == null)
                                            return list;
                                        target.IsIgnoreDamage = true;
                                        target.Damage = target.Health - 1;
                                        target.IsIgnoreDamage = false;
                                        return list;
                                    }),
                                    new SummonTask()))
                                .Build()                          
                }
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_349] Divine Favor - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw cards until you have as many in hand as your opponent.
			// --------------------------------------------------------
			cards.Add("EX1_349", new List<Enchantment> {
				// TODO [EX1_349] Divine Favor && Test: Divine Favor_EX1_349
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_354] Lay on Hands - COST:8 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Restore #8 Health. Draw_3 cards.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_354", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new HealTask(8, EntityType.TARGET),
                        new EnqueueTask(3, new DrawTask()))
                }
            });

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_355] Blessed Champion - COST:5 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Double a minion's Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_355", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                            new GetNativeGameTagTask(GameTag.ATK, EntityType.SOURCE, true),
                            new BuffAttackNumberTask(EntityType.SOURCE))
                },
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_363] Blessing of Wisdom - COST:1 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Choose a minion. Whenever it attacks, draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_363", new List<Enchantment> {
				// TODO [EX1_363] Blessing of Wisdom && Test: Blessing of Wisdom_EX1_363
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_365] Holy Wrath - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw a card and deal_damage equal to_its Cost. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_365", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DrawTask(true),
                        new GetGameTagTask(GameTag.COST, EntityType.STACK),
                        new DamageNumberTask(EntityType.TARGET))
                }
            });

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_379] Repentance - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, reduce its Health to 1.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_379", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.OP_BOARD,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .TriggerEffect(GameTag.JUST_PLAYED, -1)
                        .SingleTask(ComplexTask.Secret(
                            new SetHealthTask(1, EntityType.TARGET)))
                        .Build()
                },
			});

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_384] Avenging Wrath - COST:6 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $8 damage randomly split among all enemies. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("EX1_384", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(8, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1), true)
                }
            });

			// ---------------------------------------- SPELL - PALADIN
			// [EX1_619] Equality - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Change the Health of ALL minions to 1.
			// --------------------------------------------------------
			cards.Add("EX1_619", new List<Enchantment> {
				// TODO [EX1_619] Equality && Test: Equality_EX1_619
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("EX1_362", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.DivineShield(EntityType.TARGET)
                }
            });

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
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_382", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SetAttackTask(1, EntityType.TARGET)
                }
            });

            // --------------------------------------- MINION - PALADIN
            // [EX1_383] Tirion Fordring - COST:8 [ATK:6/HP:6] 
            // - Fac: neutral, Set: expert1, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Divine Shield</b>. <b>Taunt</b>. <b>Deathrattle:</b> Equip a 5/3_Ashbringer.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - TAUNT = 1
            // - DIVINE_SHIELD = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("EX1_383", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new WeaponTask("EX1_383t")
                },
            });

            // --------------------------------------- WEAPON - PALADIN
            // [EX1_366] Sword of Justice - COST:3 [ATK:1/HP:0] 
            // - Fac: neutral, Set: expert1, Rarity: epic
            // --------------------------------------------------------
            // Text: After you summon a minion, give it +1/+1 and this loses 1_Durability.
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 5
            // --------------------------------------------------------
            cards.Add("EX1_366", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.WEAPON,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsThisWeaponEquiped, SelfCondition.IsDurabilityOkay)
                        .TriggerEffect(GameTag.SUMMONED, 1)
                        .SingleTask(
                            ComplexTask.Create(new BuffTask(Buffs.AttackHealth(1), EntityType.TARGET),
                            ComplexTask.RemoveFromGameTag(GameTag.DURABILITY, 1, EntityType.WEAPON)))
                        .Build()
                }
            });

		}

		private static void PaladinNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [EX1_355e] Blessed Champion (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion's Attack has been doubled.
			// --------------------------------------------------------
			cards.Add("EX1_355e", null);

            // ---------------------------------- ENCHANTMENT - PALADIN
            // [EX1_363e] Blessing of Wisdom (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: When this minion attacks, the player who blessed it draws a card.
            // --------------------------------------------------------
            cards.Add("EX1_363e", null);

            // ---------------------------------- ENCHANTMENT - PALADIN
            // [EX1_363e2] Blessing of Wisdom (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: When this minion attacks, the enemy player draws a card.
            // --------------------------------------------------------
            cards.Add("EX1_363e2", null);

            // ---------------------------------- ENCHANTMENT - PALADIN
            // [EX1_366e] Justice Served (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Has +1/+1.
            // --------------------------------------------------------
            cards.Add("EX1_366e", null);

            // ---------------------------------- ENCHANTMENT - PALADIN
            // [EX1_379e] Repentance (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Health reduced to 1.
            // --------------------------------------------------------
            cards.Add("EX1_379e", null);

            // ---------------------------------- ENCHANTMENT - PALADIN
            // [EX1_382e] Stand Down! (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Attack changed to 1.
            // --------------------------------------------------------
            cards.Add("EX1_382e", null);

            // ---------------------------------- ENCHANTMENT - PALADIN
            // [EX1_619e] Equality (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Health changed to 1.
            // --------------------------------------------------------
            cards.Add("EX1_619e", null);

            // --------------------------------------- MINION - PALADIN
            // [EX1_130a] Defender (*) - COST:1 [ATK:2/HP:1] 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            cards.Add("EX1_130a", null);

			// --------------------------------------- WEAPON - PALADIN
			// [EX1_383t] Ashbringer (*) - COST:5 [ATK:5/HP:0] 
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("EX1_383t", new List<Enchantment> {
				// TODO [EX1_383t] Ashbringer && Test: Ashbringer_EX1_383t
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void Priest(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - PRIEST
			// [CS1_129] Inner Fire - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Change a minion's Attack to be equal to its Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS1_129", new List<Enchantment> {
				// TODO [CS1_129] Inner Fire && Test: Inner Fire_CS1_129
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_332", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new SilenceTask(EntityType.TARGET)
                }
            });

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_334] Shadow Madness - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Gain control of an enemy minion with 3 or less Attack until end of turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_TARGET_MAX_ATTACK = 3
			// --------------------------------------------------------
			cards.Add("EX1_334", new List<Enchantment> {
				// TODO [EX1_334] Shadow Madness && Test: Shadow Madness_EX1_334
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_339] Thoughtsteal - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Copy 2 cards in your opponent's deck and add them to your hand.
			// --------------------------------------------------------
			cards.Add("EX1_339", new List<Enchantment> {
				// TODO [EX1_339] Thoughtsteal && Test: Thoughtsteal_EX1_339
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

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
			cards.Add("EX1_345", new List<Enchantment> {
				// TODO [EX1_345] Mindgames && Test: Mindgames_EX1_345
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_621] Circle of Healing - COST:0 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #4 Health to ALL_minions.
			// --------------------------------------------------------
			cards.Add("EX1_621", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new HealTask(4,EntityType.ALLMINIONS)
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_624] Holy Fire - COST:6 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage. Restore #5 Health to your hero. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_624", new List<Enchantment> {
				// TODO [EX1_624] Holy Fire && Test: Holy Fire_EX1_624
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_625] Shadowform - COST:3 
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your Hero Power becomes 'Deal 2 damage'. If already in Shadowform: 3 damage.
			// --------------------------------------------------------
			cards.Add("EX1_625", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsHeroPowerCard("EX1_625t")),
                        ComplexTask.True(new ReplaceHeroPower(Cards.FromId("EX1_625t2"))),
                        ComplexTask.False(new ReplaceHeroPower(Cards.FromId("EX1_625t"))))
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [EX1_626] Mass Dispel - COST:4 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Silence</b> all enemy minions. Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("EX1_626", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new SilenceTask(EntityType.OP_MINIONS),
                        new DrawTask())
				},
			});

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
			// - REQ_TARGET_MAX_ATTACK = 2
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_091", new List<Enchantment> {
				// TODO [EX1_091] Cabal Shadow Priest && Test: Cabal Shadow Priest_EX1_091
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - PRIEST
			// [EX1_335] Lightspawn - COST:4 [ATK:0/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: This minion's Attack is always equal to its Health.
			// --------------------------------------------------------
			cards.Add("EX1_335", new List<Enchantment> {
				// TODO [EX1_335] Lightspawn && Test: Lightspawn_EX1_335
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - PRIEST
			// [EX1_341] Lightwell - COST:2 [ATK:0/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, restore 3 Health to a damaged friendly character.
			// --------------------------------------------------------
			cards.Add("EX1_341", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, 1)
                        .SingleTask(ComplexTask.Create(
                            new IncludeTask(EntityType.FRIENDS),
                            new FilterStackTask(SelfCondition.IsDamaged),
                            new RandomTask(1, EntityType.STACK),
                            new HealTask(3, EntityType.STACK)))
                        .Build()
                }
            });

			// ---------------------------------------- MINION - PRIEST
			// [EX1_350] Prophet Velen - COST:7 [ATK:7/HP:7] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Double the damage and healing of your spells and Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_350", new List<Enchantment> {
				// TODO [EX1_350] Prophet Velen && Test: Prophet Velen_EX1_350
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - PRIEST
			// [EX1_591] Auchenai Soulpriest - COST:4 [ATK:3/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Your cards and powers that restore Health now deal damage instead.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_591", new List<Enchantment> {
				// TODO [EX1_591] Auchenai Soulpriest && Test: Auchenai Soulpriest_EX1_591
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_623", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new BuffTask(Buffs.Health(3), EntityType.TARGET)
				},
			});

		}

		private static void PriestNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CS1_129e] Inner Fire (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion's Attack is equal to its Health.
			// --------------------------------------------------------
			cards.Add("CS1_129e", null);

            // ----------------------------------- ENCHANTMENT - PRIEST
            // [EX1_334e] Shadow Madness (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: This minion has switched controllers this turn.
            // --------------------------------------------------------
            cards.Add("EX1_334e", null);

            // ----------------------------------- ENCHANTMENT - PRIEST
            // [EX1_623e] Infusion (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +3 Health.
            // --------------------------------------------------------
            cards.Add("EX1_623e", null);

            // ----------------------------------- ENCHANTMENT - PRIEST
            // [EX1_tk31] Mind Controlling (*) - COST:0 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // GameTag:
            // - SUMMONED = 1
            // --------------------------------------------------------
            cards.Add("EX1_tk31", null);

            // ---------------------------------------- MINION - PRIEST
            // [EX1_345t] Shadow of Nothing (*) - COST:0 [ATK:0/HP:1] 
            // - Set: expert1, Rarity: epic
            // --------------------------------------------------------
            // Text: Mindgames whiffed! Your opponent had no minions!
            // --------------------------------------------------------
            cards.Add("EX1_345t", new List<Enchantment> {
				// TODO [EX1_345t] Shadow of Nothing && Test: Shadow of Nothing_EX1_345t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Rogue(IDictionary<string, List<Enchantment>> cards)
		{
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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_073", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.Attack(2), EntityType.TARGET)
                },
                // Combo
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.Attack(4), EntityType.TARGET)
                }
            });

			// ------------------------------------------ SPELL - ROGUE
			// [CS2_233] Blade Flurry - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy your weapon and deal its damage to all enemy minions. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			cards.Add("CS2_233", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.ATK, EntityType.WEAPON),
                        new DamageNumberTask(EntityType.OP_MINIONS, true),
                        new DestroyTask(EntityType.WEAPON)),
                }
            });

            // ------------------------------------------ SPELL - ROGUE
            // [EX1_124] Eviscerate - COST:2 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $2 damage. <b>Combo:</b> Deal $4 damage instead. *spelldmg
            // --------------------------------------------------------
            // GameTag:
            // - COMBO = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("EX1_124", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(2, EntityType.TARGET)
                },
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(4, EntityType.TARGET)
                }
            });

            // ------------------------------------------ SPELL - ROGUE
            // [EX1_126] Betrayal - COST:2 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: Force an enemy minion to deal its damage to the minions next to it.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_ENEMY_TARGET = 0
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("EX1_126", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = SpecificTask.Betrayal
                }
            });

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_128] Conceal - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions <b>Stealth</b> until your next_turn.
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("EX1_128", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new BuffStealthTask(EntityType.MINIONS)
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_137] Headcrack - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to the enemy hero. <b>Combo:</b> Return this to your hand next turn. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("EX1_137", new List<Enchantment> {
				// TODO [EX1_137] Headcrack && Test: Headcrack_EX1_137
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_144] Shadowstep - COST:0 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Return a friendly minion to your hand. It_costs (2) less.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_144", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new ReturnHandTask(EntityType.TARGET),
                        new BuffTask(Buffs.Cost(-2), EntityType.TARGET))
                }
            });

			// ------------------------------------------ SPELL - ROGUE
			// [EX1_145] Preparation - COST:0 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (3) less.
			// --------------------------------------------------------
			cards.Add("EX1_145", new List<Enchantment> {
				// TODO [EX1_145] Preparation && Test: Preparation_EX1_145
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- MINION - ROGUE
			// [EX1_131] Defias Ringleader - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Summon a 2/1 Defias Bandit.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("EX1_131", new List<Enchantment> {
                // Combo
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SummonTask("EX1_131t")
                }
            });

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
			cards.Add("EX1_134", new List<Enchantment> {
                // Combo
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(2, EntityType.TARGET)
                }
            });

			// ----------------------------------------- MINION - ROGUE
			// [EX1_522] Patient Assassin - COST:2 [ATK:1/HP:1] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Stealth</b>. Destroy any minion damaged by this_minion.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("EX1_522", null);

			// ----------------------------------------- MINION - ROGUE
			// [EX1_613] Edwin VanCleef - COST:3 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Gain +2/+2 for each card played earlier this turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("EX1_613", new List<Enchantment> {
                // Combo
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = ComplexTask.Create(
                        new GetGameTagControllerTask(GameTag.NUM_CARDS_PLAYED_THIS_TURN),
                        new MathSubstractionTask(1),
                        new MathMultiplyTask(2),
                        new BuffAttackHealthNumberTask(EntityType.SOURCE)
                        )
                }
            });

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
			cards.Add("NEW1_005", new List<Enchantment> {
				// Combo
				new Enchantment
                {
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new ReturnHandTask(EntityType.TARGET)
				}
			});

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
			// - REQ_NONSELF_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("NEW1_014", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new BuffStealthTask(EntityType.TARGET)
				},
			});

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
			cards.Add("EX1_133", new List<Enchantment> {
				// TODO [EX1_133] Perdition's Blade && Test: Perdition's Blade_EX1_133
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(1, EntityType.TARGET)
                },
                // Combo
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(2, EntityType.TARGET)
                }
            });

		}

		private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CS2_073e] Cold Blood (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_073e", null);

            // ------------------------------------ ENCHANTMENT - ROGUE
            // [CS2_073e2] Cold Blood (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +4 Attack.
            // --------------------------------------------------------
            cards.Add("CS2_073e2", null);

            // ------------------------------------ ENCHANTMENT - ROGUE
            // [EX1_128e] Concealed (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Stealthed until your next turn.
            // --------------------------------------------------------
            cards.Add("EX1_128e", null);

            // ------------------------------------ ENCHANTMENT - ROGUE
            // [EX1_145o] Preparation (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: The next spell you cast this turn costs (3) less.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("EX1_145o", null);

            // ------------------------------------ ENCHANTMENT - ROGUE
            // [EX1_613e] VanCleef's Vengeance (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("EX1_613e", null);

            // ------------------------------------ ENCHANTMENT - ROGUE
            // [NEW1_014e] Disguised (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Stealthed until your next turn.
            // --------------------------------------------------------
            cards.Add("NEW1_014e", null);

            // ----------------------------------------- MINION - ROGUE
            // [EX1_131t] Defias Bandit (*) - COST:1 [ATK:2/HP:1] 
            // - Fac: neutral, Set: expert1, 
            // --------------------------------------------------------
            cards.Add("EX1_131t", null);

		}

		private static void Shaman(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_038] Ancestral Spirit - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion "<b>Deathrattle:</b> Resummon this minion."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CS2_038", new List<Enchantment> {
				// TODO [CS2_038] Ancestral Spirit && Test: Ancestral Spirit_CS2_038
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CS2_053] Far Sight - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw a card. That card costs (3) less.
			// --------------------------------------------------------
			cards.Add("CS2_053", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DrawTask(true),
                        new BuffTask(Buffs.Cost(-3), EntityType.STACK))
                }
            });

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_238] Lightning Bolt - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage. <b>Overload:</b> (1) *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_238", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(3, EntityType.TARGET, true)
                }
            });

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_241] Lava Burst - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage. <b>Overload:</b> (2) *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_241", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(5, EntityType.TARGET, true),
                }
            });

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_245] Earth Shock - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Silence</b> a minion, then deal $1 damage to it. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_245", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new SilenceTask(EntityType.TARGET),
                        new DamageTask(1, EntityType.TARGET, true)),
                }
            });

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
			cards.Add("EX1_248", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(2, new SummonTask("EX1_tk11"))
                }
            });

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_251] Forked Lightning - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to 2_random enemy minions. <b>Overload:</b> (2) *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("EX1_251", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.DamageRandomTargets(2, EntityType.OP_MINIONS, 2, true)
                }
            });

			// ----------------------------------------- SPELL - SHAMAN
			// [EX1_259] Lightning Storm - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2-$3 damage to all_enemy minions. <b>Overload:</b> (2) *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			cards.Add("EX1_259", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DamageTask(2, 1, EntityType.OP_MINIONS, true)
				},
			});

            // ---------------------------------------- MINION - SHAMAN
            // [EX1_243] Dust Devil - COST:1 [ATK:3/HP:1] 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Windfury</b>. <b>Overload:</b> (2)
            // --------------------------------------------------------
            // GameTag:
            // - WINDFURY = 1
            // - OVERLOAD = 2
            // - OVERLOAD_OWED = 2
            // --------------------------------------------------------
            cards.Add("EX1_243", null);

            // ---------------------------------------- MINION - SHAMAN
            // [EX1_250] Earth Elemental - COST:5 [ATK:7/HP:8] 
            // - Fac: neutral, Set: expert1, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Taunt</b>. <b>Overload:</b> (3)
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - OVERLOAD = 3
            // - OVERLOAD_OWED = 3
            // --------------------------------------------------------
            cards.Add("EX1_250", null);

            // ---------------------------------------- MINION - SHAMAN
            // [EX1_258] Unbound Elemental - COST:3 [ATK:2/HP:4] 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever you play a card_with <b>Overload</b>, gain_+1/+1.
            // --------------------------------------------------------
            // RefTag:
            // - OVERLOAD = 1
            // --------------------------------------------------------
            cards.Add("EX1_258", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.HAND_AND_BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsTagValue(GameTag.OVERLOAD, 1, RelaSign.GEQ)))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new BuffTask(Buffs.AttackHealth(1), EntityType.SOURCE))
                        .Build()
                }
			});

			// ---------------------------------------- MINION - SHAMAN
			// [EX1_575] Mana Tide Totem - COST:3 [ATK:0/HP:3] 
			// - Race: totem, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, draw a card.
			// --------------------------------------------------------
			cards.Add("EX1_575", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(new DrawTask())
                        .Build()
                }
            });

			// ---------------------------------------- MINION - SHAMAN
			// [NEW1_010] Al'Akir the Windlord - COST:8 [ATK:3/HP:5] 
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Windfury, Charge, Divine Shield, Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - WINDFURY = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("NEW1_010", null);

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
            cards.Add("EX1_247", null);

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
            cards.Add("EX1_567", new List<Enchantment> {
				// TODO [EX1_567] Doomhammer && Test: Doomhammer_EX1_567
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void ShamanNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [CS2_038e] Ancestral Spirit (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Resummon this minion.
			// --------------------------------------------------------
			cards.Add("CS2_038e", null);

            // ----------------------------------- ENCHANTMENT - SHAMAN
            // [CS2_053e] Far Sight (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: One of your cards costs (3) less.
            // --------------------------------------------------------
            cards.Add("CS2_053e", null);

            // ----------------------------------- ENCHANTMENT - SHAMAN
            // [EX1_258e] Overloading (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("EX1_258e", null);

            // ---------------------------------------- MINION - SHAMAN
            // [EX1_tk11] Spirit Wolf (*) - COST:2 [ATK:2/HP:3] 
            // - Fac: neutral, Set: expert1, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("EX1_tk11", null);

        }

		private static void Warlock(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_303] Shadowflame - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a friendly minion and deal its Attack damage to all enemy minions. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_303", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.ATK, EntityType.TARGET),
                        new DestroyTask(EntityType.TARGET),
                        new DamageNumberTask(EntityType.OP_MINIONS))
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_309] Siphon Soul - COST:6 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a minion. Restore #3 Health to_your hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_309", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DestroyTask(EntityType.TARGET),
                        new HealTask(3, EntityType.HERO)),
                }
            });

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_312] Twisting Nether - COST:8 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all minions.
			// --------------------------------------------------------
			cards.Add("EX1_312", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DestroyTask(EntityType.ALLMINIONS),
                }
            });

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_316] Power Overwhelming - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Give a friendly minion +4/+4 until end of turn. Then, it dies. Horribly.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_316", new List<Enchantment> {
				// TODO [EX1_316] Power Overwhelming && Test: Power Overwhelming_EX1_316
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_317] Sense Demons - COST:3 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 Demons
			//       from your deck.
			// --------------------------------------------------------
			cards.Add("EX1_317", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.DECK),
                        new FilterStackTask(SelfCondition.IsRace(Race.DEMON)),
                        new RandomTask(2, EntityType.STACK),
                        new RemoveFromDeck(EntityType.STACK),
                        new AddStackTo(EntityType.HAND))
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_320] Bane of Doom - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to_a character. If that kills it, summon a random Demon. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_320", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DamageTask(2, EntityType.TARGET),
                        new SelfConditionTask(EntityType.TARGET, SelfCondition.IsDead),
                        new FlagTask(true, ComplexTask.SummonRandomMinion(GameTag.CARDRACE, (int) Race.DEMON))),
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_596] Demonfire - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If it's a friendly Demon, give it +2/+2 instead. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_596", new List<Enchantment> {
				// TODO [EX1_596] Demonfire && Test: Demonfire_EX1_596
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

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
			cards.Add("CS2_059", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(ComplexTask.Create(
                            new RandomTask(1, EntityType.MINIONS_NOSOURCE),
                            new BuffTask(Buffs.Health(1), EntityType.STACK)))
                        .Build()
                }
            });

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
			cards.Add("EX1_301", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new ManaCrystalEmptyTask(-1)
				},
			});

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
			cards.Add("EX1_304", new List<Enchantment> {
				// TODO [EX1_304] Void Terror && Test: Void Terror_EX1_304
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_310] Doomguard - COST:5 [ATK:5/HP:7] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Charge</b>. <b>Battlecry:</b> Discard two random cards.
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_310", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.DiscardRandomCard(2),
                }
            });

			// --------------------------------------- MINION - WARLOCK
			// [EX1_313] Pit Lord - COST:4 [ATK:5/HP:6] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 5 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_313", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(5, EntityType.HERO),
                }
            });

			// --------------------------------------- MINION - WARLOCK
			// [EX1_315] Summoning Portal - COST:4 [ATK:0/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Your minions cost (2) less, but not less than (1).
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_315", new List<Enchantment> {
				// TODO [EX1_315] Summoning Portal && Test: Summoning Portal_EX1_315
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_319] Flame Imp - COST:1 [ATK:3/HP:2] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_319", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(3, EntityType.HERO),
                }
            });

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
			cards.Add("EX1_323", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new ReplaceHeroTask("EX1_323h", "EX1_323w", "EX1_tk33"),
				},
			});

		}

		private static void WarlockNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [CS2_059o] Blood Pact (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("CS2_059o", null);

            // ---------------------------------- ENCHANTMENT - WARLOCK
            // [EX1_304e] Consume (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("EX1_304e", null);

            // ---------------------------------- ENCHANTMENT - WARLOCK
            // [EX1_316e] Power Overwhelming (*) - COST:0 
            // - Fac: neutral, Set: expert1, 
            // --------------------------------------------------------
            // Text: This minion has +4/+4, but will die a horrible death at the end of the turn.
            // --------------------------------------------------------
            cards.Add("EX1_316e", null);

            // ---------------------------------- ENCHANTMENT - WARLOCK
            // [EX1_596e] Demonfire (*) - COST:0 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: This Demon has +2/+2.
            // --------------------------------------------------------
            cards.Add("EX1_596e", null);

            // --------------------------------------- MINION - WARLOCK
            // [EX1_317t] Worthless Imp (*) - COST:1 [ATK:1/HP:1] 
            // - Race: demon, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <i>You are out of demons! At least there are always imps...</i>
            // --------------------------------------------------------
            cards.Add("EX1_317t", new List<Enchantment> {
				// TODO [EX1_317t] Worthless Imp && Test: Worthless Imp_EX1_317t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARLOCK
			// [EX1_tk34] Infernal (*) - COST:6 [ATK:6/HP:6] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_tk34", null);

			// --------------------------------------- WEAPON - WARLOCK
			// [EX1_323w] Blood Fury (*) - COST:3 [ATK:3/HP:0] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 8
			// --------------------------------------------------------
			cards.Add("EX1_323w", null);

		}

		private static void Warrior(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [CS2_104] Rampage - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Give a damaged minion +3/+3.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_DAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CS2_104", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackHealth(3), EntityType.TARGET)
                }
            });

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_391] Slam - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If it survives, draw a card. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_391", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(2, EntityType.TARGET, true),
                        new SelfConditionTask(EntityType.TARGET, SelfCondition.IsNotDead),
                        new FlagTask(true, new DrawTask()))
                },
            });

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_392] Battle Rage - COST:2 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Draw a card for each damaged friendly character.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_392", new List<Enchantment> {
				// TODO [EX1_392] Battle Rage && Test: Battle Rage_EX1_392
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_407] Brawl - COST:5 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all minions except one. <i>(chosen randomly)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("EX1_407", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new RandomTask(1, EntityType.ALLMINIONS),
                        new IncludeTask(EntityType.ALLMINIONS, new [] {EntityType.STACK}),
                        new DestroyTask(EntityType.STACK))
                },
            });

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_408] Mortal Strike - COST:4 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $4 damage. If you have 12 or less Health, deal $6 instead. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_408", new List<Enchantment> {
				// TODO [EX1_408] Mortal Strike && Test: Mortal Strike_EX1_408
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_409] Upgrade! - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: If you have a weapon, give it +1/+1. Otherwise equip a 1/3 weapon.
			// --------------------------------------------------------
			cards.Add("EX1_409", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.HERO, SelfCondition.IsAnyWeaponEquiped),
                        new FlagTask(true, ComplexTask.Create(
                                new GetGameTagTask(GameTag.DURABILITY, EntityType.WEAPON),
                                new MathAddTask(1),
                                new SetGameTagNumberTask(GameTag.DURABILITY, EntityType.WEAPON),
                                new BuffTask(Buffs.WeaponAtk(1), EntityType.WEAPON))),
                        new FlagTask(false, new ReplaceWeaponTask("EX1_409t")))
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_410] Shield Slam - COST:1 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal 1 damage to a minion for each Armor you have. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_410", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.ARMOR, EntityType.HERO),
                        new DamageNumberTask(EntityType.TARGET, true))
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [EX1_607] Inner Rage - COST:0 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage to a minion and give it +2_Attack. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_607", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DamageTask(1, EntityType.TARGET),
                        new BuffTask(Buffs.Attack(2), EntityType.TARGET))
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [NEW1_036] Commanding Shout - COST:2 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Your minions can't be reduced below 1 Health this turn. Draw a card.
			// --------------------------------------------------------
			cards.Add("NEW1_036", new List<Enchantment> {
				// TODO [NEW1_036] Commanding Shout && Test: Commanding Shout_NEW1_036
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [EX1_398] Arathi Weaponsmith - COST:4 [ATK:3/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip a 2/2_weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_398", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new WeaponTask("EX1_398t")
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [EX1_402] Armorsmith - COST:2 [ATK:1/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a friendly minion_takes damage, gain 1 Armor.
			// --------------------------------------------------------
			cards.Add("EX1_402", new List<Enchantment> {
				// TODO [EX1_402] Armorsmith && Test: Armorsmith_EX1_402
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

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
			cards.Add("EX1_414", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.SimpleInclSelf(GameTag.ATK, 6, RelaCondition.IsMe(SelfCondition.IsEnraged)), AuraArea.SELF)
                }
            });

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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_603", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new DamageTask(1, EntityType.TARGET),
                        new BuffTask(Buffs.Attack(2), EntityType.TARGET))
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [EX1_604] Frothing Berserker - COST:3 [ATK:2/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a minion takes damage, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_604", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARDS,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.DAMAGE, 1)
                        .SingleTask(new BuffTask(Buffs.Attack(1), EntityType.SOURCE))
                        .Build()
                }
            });

			// --------------------------------------- WEAPON - WARRIOR
			// [EX1_411] Gorehowl - COST:7 [ATK:7/HP:0] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Attacking a minion costs 1 Attack instead of 1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 1
			// --------------------------------------------------------
			cards.Add("EX1_411", new List<Enchantment> {
				// TODO [EX1_411] Gorehowl && Test: Gorehowl_EX1_411
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void WarriorNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CS2_104e] Rampage (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("CS2_104e", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [EX1_409e] Upgraded (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +1 Attack and +1 Durability.
            // --------------------------------------------------------
            cards.Add("EX1_409e", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [EX1_411e] Bloodrage (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: No durability loss.
            // --------------------------------------------------------
            cards.Add("EX1_411e", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [EX1_411e2] Needs Sharpening (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Decreased Attack.
            // --------------------------------------------------------
            cards.Add("EX1_411e2", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [EX1_414e] Enraged (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +6 Attack
            // --------------------------------------------------------
            cards.Add("EX1_414e", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [EX1_603e] Whipped Into Shape (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +2 Attack.
            // --------------------------------------------------------
            cards.Add("EX1_603e", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [EX1_604o] Berserk (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("EX1_604o", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [EX1_607e] Inner Rage (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +2 Attack.
            // --------------------------------------------------------
            cards.Add("EX1_607e", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [NEW1_036e] Commanding Shout (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Can't be reduced below 1 Health this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("NEW1_036e", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [NEW1_036e2] Commanding Shout (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Your minions can't be reduced below 1 Health this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("NEW1_036e2", null);

            // --------------------------------------- WEAPON - WARRIOR
            // [EX1_398t] Battle Axe (*) - COST:1 [ATK:2/HP:0] 
            // - Set: expert1, 
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 2
            // --------------------------------------------------------
            cards.Add("EX1_398t", null);

			// --------------------------------------- WEAPON - WARRIOR
			// [EX1_409t] Heavy Axe (*) - COST:1 [ATK:1/HP:0] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("EX1_409t", null);

		}

		private static void DreamNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - DREAM
			// [DREAM_02] Ysera Awakens (*) - COST:2 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Deal $5 damage to all characters except Ysera. *spelldmg
			// --------------------------------------------------------
			cards.Add("DREAM_02", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DamageTask(5, EntityType.ALL_NOSOURCE, true),
				},
			});

			// ------------------------------------------ SPELL - DREAM
			// [DREAM_04] Dream (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Return a minion to its owner's hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DREAM_04", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new ReturnHandTask(EntityType.TARGET),
				},
			});

			// ------------------------------------------ SPELL - DREAM
			// [DREAM_05] Nightmare (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Give a minion +5/+5. At the start of your next turn, destroy it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DREAM_05", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.TARGET,
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackHealth(5), EntityType.TARGET),
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
                },
			});

			// ----------------------------------------- MINION - DREAM
			// [DREAM_01] Laughing Sister (*) - COST:3 [ATK:3/HP:5] 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_ABILITIES = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("DREAM_01", null);

			// ----------------------------------------- MINION - DREAM
			// [DREAM_03] Emerald Drake (*) - COST:4 [ATK:7/HP:6] 
			// - Race: dragon, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("DREAM_03", null);

		}

		private static void Neutral(IDictionary<string, List<Enchantment>> cards)
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
			cards.Add("CS1_069", null);

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
			cards.Add("CS2_117", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new HealTask(3, EntityType.TARGET)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_146] Southsea Deckhand - COST:1 [ATK:2/HP:1] 
			// - Race: pirate, Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Has <b>Charge</b> while you have a weapon equipped.
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CS2_146", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.SimpleInclSelf(GameTag.CHARGE, 1, RelaCondition.IsMe(SelfCondition.IsWeaponEquiped)), AuraArea.SELF)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_151] Silver Hand Knight - COST:5 [ATK:4/HP:4] 
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/2_Squire.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CS2_151", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SummonTask("CS2_152")
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_161] Ravenholdt Assassin - COST:7 [ATK:7/HP:5] 
            // - Fac: alliance, Set: expert1, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Stealth</b>
            // --------------------------------------------------------
            // GameTag:
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("CS2_161", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_169] Young Dragonhawk - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Fac: horde, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Windfury</b>
            // --------------------------------------------------------
            // GameTag:
            // - WINDFURY = 1
            // --------------------------------------------------------
            cards.Add("CS2_169", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_181] Injured Blademaster - COST:3 [ATK:4/HP:7] 
            // - Fac: horde, Set: expert1, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal 4 damage to HIMSELF.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("CS2_181", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(4, EntityType.SOURCE)
                }
            });

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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CS2_188", new List<Enchantment> {
                new Enchantment
                {
                    InfoCardId = "CS2_188o",
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new BuffTask(Buffs.AttackTurn(2), EntityType.TARGET),
                }
            });

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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("CS2_203", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SilenceTask(EntityType.TARGET)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_221] Spiteful Smith - COST:5 [ATK:4/HP:6] 
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Enrage:</b> Your weapon has +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("CS2_221", new List<Enchantment> {
                new Enchantment
                {
                    InfoCardId = "CS2_221e",
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.Attack(2, RelaCondition.IsMe(SelfCondition.IsEnraged), RelaCondition.IsMyWeapon), AuraArea.GAME)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CS2_227] Venture Co. Mercenary - COST:5 [ATK:7/HP:6] 
			// - Fac: horde, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Your minions cost (3) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("CS2_227", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.Cost(3), AuraArea.HAND)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_231] Wisp - COST:0 [ATK:1/HP:1] 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            cards.Add("CS2_231", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_001] Lightwarden - COST:1 [ATK:1/HP:2] 
            // - Set: expert1, Rarity: rare
            // --------------------------------------------------------
            // Text: Whenever a character is healed, gain +2 Attack.
            // --------------------------------------------------------
            cards.Add("EX1_001", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARDS_HEROES,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(
                            SelfCondition.IsNotDead,
                            SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.DAMAGE, -1)
                        .SingleTask(new BuffTask(Buffs.Attack(2), EntityType.SOURCE))
                        .Build()
                }
            });

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
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MUST_TARGET_TAUNTER = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("EX1_002", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DestroyTask(EntityType.TARGET)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_004] Young Priestess - COST:1 [ATK:2/HP:1] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, give another random friendly minion +1 Health.
			// --------------------------------------------------------
			cards.Add("EX1_004", new List<Enchantment> {
                new Enchantment
                {
                    InfoCardId = "EX1_004e",
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(ComplexTask.Create(
                            new RandomTask(1, EntityType.MINIONS_NOSOURCE),
                            new BuffTask(Buffs.Health(1), EntityType.STACK)))
                        .Build()
                }
            });

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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_MIN_ATTACK = 7
			// --------------------------------------------------------
			cards.Add("EX1_005", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DestroyTask(EntityType.TARGET)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_006] Alarm-o-Bot - COST:3 [ATK:0/HP:3] 
			// - Race: mechanical, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]At the start of your turn,
			//       swap this minion with a
			//          random one in your hand.
			// --------------------------------------------------------
			cards.Add("EX1_006", new List<Enchantment> {
				// TODO [EX1_006] Alarm-o-Bot && Test: Alarm-o-Bot_EX1_006
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_007] Acolyte of Pain - COST:3 [ATK:1/HP:3] 
			// - Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, draw a_card.
			// --------------------------------------------------------
			cards.Add("EX1_007", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.DAMAGE, 1)
                        .SingleTask(new DrawTask())
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_008] Argent Squire - COST:1 [ATK:1/HP:1] 
            // - Fac: alliance, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Divine Shield</b>
            // --------------------------------------------------------
            // GameTag:
            // - DIVINE_SHIELD = 1
            // --------------------------------------------------------
            cards.Add("EX1_008", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_009] Angry Chicken - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Set: expert1, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Enrage:</b> +5 Attack.
            // --------------------------------------------------------
            // GameTag:
            // - ENRAGED = 1
            // --------------------------------------------------------
            cards.Add("EX1_009", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.SimpleInclSelf(GameTag.ATK, 5, RelaCondition.IsMe(SelfCondition.IsEnraged)), AuraArea.SELF)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_010] Worgen Infiltrator - COST:1 [ATK:2/HP:1] 
            // - Fac: alliance, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Stealth</b>
            // --------------------------------------------------------
            // GameTag:
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("EX1_010", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_012] Bloodmage Thalnos - COST:2 [ATK:1/HP:1] 
            // - Fac: neutral, Set: expert1, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Spell Damage +1</b>. <b>Deathrattle:</b> Draw a card.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - SPELLPOWER = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("EX1_012", new List<Enchantment>
            {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(1)
                },
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new DrawTask()
                }
            });

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
            cards.Add("EX1_014", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new EnqueueTask(2, new AddCardTo("EX1_014t", EntityType.OP_HAND))
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_016] Sylvanas Windrunner - COST:6 [ATK:5/HP:5] 
            // - Set: expert1, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Take
            //       control of a random
            //       enemy minion.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("EX1_016", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.Create(
                        new RandomTask(1, EntityType.OP_MINIONS),
                        new ControlTask(EntityType.STACK))
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_017] Jungle Panther - COST:3 [ATK:4/HP:2] 
            // - Race: beast, Fac: horde, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Stealth</b>
            // --------------------------------------------------------
            // GameTag:
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("EX1_017", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_020] Scarlet Crusader - COST:3 [ATK:3/HP:1] 
            // - Fac: alliance, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Divine Shield</b>
            // --------------------------------------------------------
            // GameTag:
            // - DIVINE_SHIELD = 1
            // --------------------------------------------------------
            cards.Add("EX1_020", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_021] Thrallmar Farseer - COST:3 [ATK:2/HP:3] 
            // - Fac: horde, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Windfury</b>
            // --------------------------------------------------------
            // GameTag:
            // - WINDFURY = 1
            // --------------------------------------------------------
            cards.Add("EX1_021", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_023] Silvermoon Guardian - COST:4 [ATK:3/HP:3] 
            // - Fac: horde, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Divine Shield</b>
            // --------------------------------------------------------
            // GameTag:
            // - DIVINE_SHIELD = 1
            // --------------------------------------------------------
            cards.Add("EX1_023", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_028] Stranglethorn Tiger - COST:5 [ATK:5/HP:5] 
            // - Race: beast, Fac: alliance, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Stealth</b>
            // --------------------------------------------------------
            // GameTag:
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("EX1_028", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_029] Leper Gnome - COST:1 [ATK:1/HP:1] 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Deal 2 damage to the enemy_hero.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("EX1_029", new List<Enchantment>
            {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new DamageTask(2, EntityType.OP_HERO)
                }
            });

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
            cards.Add("EX1_032", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_033] Windfury Harpy - COST:6 [ATK:4/HP:5] 
            // - Fac: alliance, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Windfury</b>
            // --------------------------------------------------------
            // GameTag:
            // - WINDFURY = 1
            // --------------------------------------------------------
            cards.Add("EX1_033", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_043] Twilight Drake - COST:4 [ATK:4/HP:1] 
            // - Race: dragon, Fac: neutral, Set: expert1, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Gain +1 Health for each card in your hand.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("EX1_043", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new CountTask(EntityType.HAND_NOSOURCE),
                        new BuffHealthNumberTask(EntityType.SOURCE))
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_044] Questing Adventurer - COST:3 [ATK:2/HP:2] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you play a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("EX1_044", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.HAND_AND_BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf)
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new BuffTask(Buffs.AttackHealth(1),EntityType.SOURCE))
                        .Build()
                }
			});

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_045] Ancient Watcher - COST:2 [ATK:4/HP:5] 
            // - Fac: alliance, Set: expert1, Rarity: rare
            // --------------------------------------------------------
            // Text: Can't attack.
            // --------------------------------------------------------
            // GameTag:
            // - CANT_ATTACK = 1
            // --------------------------------------------------------
            cards.Add("EX1_045", null);

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
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("EX1_046", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new BuffTask(Buffs.Simple(GameTag.ATK, 2, true), EntityType.TARGET)
                }
            });

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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("EX1_048", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new SilenceTask(EntityType.TARGET)
                }
            });

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
			// - REQ_NONSELF_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_049", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new ReturnHandTask(EntityType.TARGET)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_050] Coldlight Oracle - COST:3 [ATK:2/HP:2] 
			// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Each player draws 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_050", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new EnqueueTask(2, new DrawTask()),
                        new EnqueueTask(2, new DrawOpTask()))
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_055] Mana Addict - COST:2 [ATK:1/HP:3] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain +2 Attack this turn.
			// --------------------------------------------------------
			cards.Add("EX1_055", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new BuffTask(Buffs.AttackTurn(2), EntityType.SOURCE))
                        .Build()
                }
            });

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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_057", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new ReturnHandTask(EntityType.TARGET)
				},
			});

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
			cards.Add("EX1_058", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.MINIONS),
                        new FilterStackTask(EntityType.SOURCE, RelaCondition.IsSideBySide),
                        ComplexTask.Taunt(EntityType.STACK))
                },
            });

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
			cards.Add("EX1_059", new List<Enchantment> {
				// TODO [EX1_059] Crazed Alchemist && Test: Crazed Alchemist_EX1_059
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

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
            cards.Add("EX1_067", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_076] Pint-Sized Summoner - COST:2 [ATK:2/HP:2] 
            // - Fac: alliance, Set: expert1, Rarity: rare
            // --------------------------------------------------------
            // Text: The first minion you play each turn costs (1) less.
            // --------------------------------------------------------
            // GameTag:
            // - AURA = 1
            // --------------------------------------------------------
            cards.Add("EX1_076", new List<Enchantment> {
				// TODO [EX1_076] Pint-Sized Summoner && Test: Pint-Sized Summoner_EX1_076
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_080] Secretkeeper - COST:1 [ATK:1/HP:2] 
			// - Fac: alliance, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a <b>Secret</b> is played, gain +1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("EX1_080", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SECRET,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsTagValue(GameTag.SECRET, 1)))
                        .TriggerEffect(GameTag.JUST_PLAYED, -1)
                        .SingleTask(new BuffTask(Buffs.AttackHealth(1), EntityType.SOURCE))
                        .Build()
                },
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_082] Mad Bomber - COST:2 [ATK:3/HP:2] 
			// - Fac: alliance, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage randomly split between all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_082", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new EnqueueTask(3, ComplexTask.DamageRandomTargets(1, EntityType.ALL_NOSOURCE, 1), false)
				},
			});

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
			cards.Add("EX1_083", new List<Enchantment> {
				// TODO [EX1_083] Tinkmaster Overspark && Test: Tinkmaster Overspark_EX1_083
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

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
			cards.Add("EX1_085", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.OP_MINIONS),
                        new FuncTask(p => p.Count > 3 ? p : new List<IPlayable>()),
                        new RandomTask(1, EntityType.STACK),
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsBoardFull),
                        new FlagTask(false, new ControlTask(EntityType.STACK)),
                        new FlagTask(true, new DestroyTask(EntityType.STACK)))
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_089] Arcane Golem - COST:3 [ATK:4/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your opponent a Mana Crystal.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_089", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new ManaCrystalEmptyTask(1, true)
				},
			});

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
			cards.Add("EX1_093", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.MINIONS),
                        new FilterStackTask(EntityType.SOURCE, RelaCondition.IsSideBySide),
                        new BuffTask(Buffs.AttackHealth(1), EntityType.STACK),
                        ComplexTask.Taunt(EntityType.STACK))
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_095] Gadgetzan Auctioneer - COST:6 [ATK:4/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, draw a card.
			// --------------------------------------------------------
			cards.Add("EX1_095", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new DrawTask())
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_096] Loot Hoarder - COST:2 [ATK:2/HP:1] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_096", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new DrawTask()
                }
            });

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
			cards.Add("EX1_097", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new DamageTask(2, EntityType.ALL),
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_100] Lorewalker Cho - COST:2 [ATK:0/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever a player casts a spell, put a copy into the other player's hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_100", new List<Enchantment> {
				// TODO [EX1_100] Lorewalker Cho && Test: Lorewalker Cho_EX1_100
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_102] Demolisher - COST:3 [ATK:1/HP:4] 
			// - Race: mechanical, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 2 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("EX1_102", new List<Enchantment> {
                new Enchantment
                {
                    // TODO [EX1_102] Demolisher ... unit test
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, 1)
                        .SingleTask(ComplexTask.Create(
                            new RandomTask(1, EntityType.ENEMIES),
                            new DamageTask(2, EntityType.STACK)))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_103] Coldlight Seer - COST:3 [ATK:2/HP:3] 
			// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your other Murlocs +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_103", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.MINIONS),
                        new FilterStackTask(SelfCondition.IsRace(Race.MURLOC)),
                        new BuffTask(Buffs.Health(2), EntityType.STACK))
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_105] Mountain Giant - COST:12 [ATK:8/HP:8] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each other card in your hand.
			// --------------------------------------------------------
			cards.Add("EX1_105", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.HAND,
                    Enchant = Auras.CostFunc(
                        owner => -(owner.Controller.Hand.Count - 1))
                }
			});

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
			cards.Add("EX1_110", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new SummonTask("EX1_110t"),
                }
            });

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
			cards.Add("EX1_116", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new EnqueueTask(2, new SummonTask("EX1_116t"))
                }
            });

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
			cards.Add("EX1_162", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.Attack(1, RelaCondition.IsSideBySide)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_170] Emperor Cobra - COST:3 [ATK:2/HP:3] 
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy any minion damaged by this minion.
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("EX1_170", null);

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_249] Baron Geddon - COST:7 [ATK:7/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 2 damage to ALL other characters.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_249", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(new DamageTask(2, EntityType.ALL_NOSOURCE))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_283] Frost Elemental - COST:6 [ATK:5/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: common
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
			cards.Add("EX1_283", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Freeze(EntityType.TARGET),
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_284] Azure Drake - COST:5 [ATK:4/HP:4] 
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>. <b>Battlecry:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_284", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(1)
                },
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DrawTask()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_298] Ragnaros the Firelord - COST:8 [ATK:8/HP:8] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Can't attack. At the end of your turn, deal 8 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("EX1_298", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 8))
                        .Build()
                }
            });

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
			cards.Add("EX1_390", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.SimpleInclSelf(GameTag.ATK, 3, RelaCondition.IsMe(SelfCondition.IsEnraged)), AuraArea.SELF)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_393] Amani Berserker - COST:2 [ATK:2/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Enrage:</b> +3 Attack
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("EX1_393", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.SimpleInclSelf(GameTag.ATK, 3, RelaCondition.IsMe(SelfCondition.IsEnraged)), AuraArea.SELF)
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_396] Mogu'shan Warden - COST:4 [ATK:1/HP:7] 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("EX1_396", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_405] Shieldbearer - COST:1 [ATK:0/HP:4] 
            // - Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("EX1_405", null);

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
            cards.Add("EX1_412", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(
                        Auras.SimpleInclSelf(
                            new Dictionary<GameTag, int>
                            {
                                [GameTag.ATK] = 1,
                                [GameTag.WINDFURY] = 1
                            }, RelaCondition.IsMe(SelfCondition.IsEnraged)), AuraArea.SELF)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_507] Murloc Warleader - COST:3 [ATK:3/HP:3] 
			// - Race: murloc, Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your other Murlocs have +2/+1.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_507", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.AttackHealth(2, 1, RelaCondition.IsSameRace)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_509] Murloc Tidecaller - COST:1 [ATK:1/HP:2] 
			// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you summon a Murloc, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("EX1_509", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsSameRace)
                        .TriggerEffect(GameTag.ZONE, 1)
                        .SingleTask(new BuffTask(Buffs.Attack(1), EntityType.SOURCE))
                        .Build()
                }
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_556] Harvest Golem - COST:3 [ATK:2/HP:3] 
			// - Race: mechanical, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 2/1 Damaged Golem.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_556", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = new SummonTask("skele21")
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_557] Nat Pagle - COST:2 [ATK:0/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the start of your turn, you have a 50% chance to draw an extra card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_557", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, 1)
                        .SingleTask(ComplexTask.Create(
                            new HalfHalfChanceTask(),
                            new DrawTask()))
                        .Build()
                }
            });

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
			cards.Add("EX1_558", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.DURABILITY, EntityType.OP_WEAPON),
                        new DestroyTask(EntityType.OP_WEAPON),
                        new EnqueueNumberTask(new DrawTask()))
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_560] Nozdormu - COST:9 [ATK:8/HP:8] 
			// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Players only have 15 seconds to take their_turns.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_560", new List<Enchantment> {
				// TODO [EX1_560] Nozdormu && Test: Nozdormu_EX1_560
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

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
			// - REQ_HERO_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("EX1_561", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.TARGET),
                        new FuncTask(p =>
                        {
                            var hero = p[0] as Hero;
                            if (hero != null)
                            {
                                hero.IsIgnoreDamage = true;
                                if (hero.BaseHealth < 15)
                                    hero.BaseHealth = 15;
                                hero.Damage = hero.BaseHealth-15;
                                hero.IsIgnoreDamage = false;
                            }
                            return null;
                        }))
				},
			});

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
			cards.Add("EX1_562", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new EnqueueTask(6, new SummonTask("EX1_116t"))
				},
			});

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
			cards.Add("EX1_563", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(5)
                }
            });

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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_564", new List<Enchantment> {
				// TODO [EX1_564] Faceless Manipulator && Test: Faceless Manipulator_EX1_564
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

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
			cards.Add("EX1_572", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(ComplexTask.Create(
                            new RandomEntourageTask(),
                            new AddStackTo(EntityType.HAND)))
                        .Build()
                }
			});

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
			cards.Add("EX1_577", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = new SummonOpTask("EX1_finkle")
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_583] Priestess of Elune - COST:6 [ATK:5/HP:4] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 4 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_583", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new HealTask(4, EntityType.HERO),
                }
            });

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
			cards.Add("EX1_584", new List<Enchantment> {
				// TODO [EX1_584] Ancient Mage && Test: Ancient Mage_EX1_584
				new Enchantment
				{
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.MINIONS),
                        new FilterStackTask(EntityType.SOURCE, RelaCondition.IsSideBySide)
                        //new BuffTask(Auras.SpellDamage(1), EntityType.HERO)
                        )
                },
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_586] Sea Giant - COST:10 [ATK:8/HP:8] 
			// - Fac: neutral, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each other minion on the battlefield.
			// --------------------------------------------------------
			cards.Add("EX1_586", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.HAND,
                    Enchant = Auras.CostFunc(
                        owner => -owner.Controller.Board.Count)
                }
            });

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
			cards.Add("EX1_590", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.ALLMINIONS),
                        new FilterStackTask(SelfCondition.IsTagValue(GameTag.DIVINE_SHIELD, 1)),
                        new SetGameTagTask(GameTag.DIVINE_SHIELD, 0, EntityType.STACK),
                        new CountTask(EntityType.STACK),
                        new MathMultiplyTask(3),
                        new BuffAttackHealthNumberTask(EntityType.SOURCE)),
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_595] Cult Master - COST:4 [ATK:4/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever one of your other minions dies, draw a card.
			// --------------------------------------------------------
			cards.Add("EX1_595", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                                .EnableConditions(SelfCondition.IsNotDead,  SelfCondition.IsNotSilenced)
                                .TriggerEffect(GameTag.TO_BE_DESTROYED, 1)
                                .SingleTask(ComplexTask.Create(
                                    new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsNotDead),
                                    ComplexTask.True(new DrawTask())))
                                .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_597] Imp Master - COST:3 [ATK:1/HP:5] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]At the end of your turn, deal
			//       1 damage to this minion
			//        and summon a 1/1 Imp.
			// --------------------------------------------------------
			cards.Add("EX1_597", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(ComplexTask.Create(
                            new DamageTask(1, EntityType.SOURCE),
                            new SummonTask("EX1_598")))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_614] Illidan Stormrage - COST:6 [ATK:7/HP:5] 
			// - Race: demon, Fac: neutral, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you play a card, summon a 2/1 Flame of_Azzinoth.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("EX1_614", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HAND_AND_BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf)
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new SummonTask("EX1_614t"))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_616] Mana Wraith - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: ALL minions cost (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("EX1_616", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.HANDS,
					Activation = EnchantmentActivation.BOARD,
					Enchant = Auras.Cost(1, RelaCondition.IsOther(SelfCondition.IsMinion))
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_620] Molten Giant - COST:25 [ATK:8/HP:8] 
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each damage your hero has taken.
			// --------------------------------------------------------
			cards.Add("EX1_620", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.HAND,
                    Enchant = Auras.CostFunc(
                        owner => -owner.Controller.Hero.Damage)
                }
			});

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
			// - REQ_TARGET_WITH_RACE = 14
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("NEW1_017", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new DestroyTask(EntityType.TARGET),
                        new BuffTask(Buffs.AttackHealth(2), EntityType.SOURCE))
				},
			});

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
			cards.Add("NEW1_018", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.ATK, EntityType.WEAPON),
                        new BuffAttackNumberTask(EntityType.SOURCE))
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_019] Knife Juggler - COST:2 [ATK:2/HP:2] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]After you summon a
			//       minion, deal 1 damage
			//       to a random enemy.
			// --------------------------------------------------------
			cards.Add("NEW1_019", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf)
                        .TriggerEffect(GameTag.SUMMONED, 1)
                        .SingleTask(ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_020] Wild Pyromancer - COST:2 [ATK:3/HP:2] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: After you cast a spell, deal 1 damage to ALL minions.
			// --------------------------------------------------------
			cards.Add("NEW1_020", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new DamageTask(1, EntityType.ALLMINIONS))
                        .Build()
                }
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_021] Doomsayer - COST:2 [ATK:0/HP:7] 
			// - Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy ALL minions.
			// --------------------------------------------------------
			cards.Add("NEW1_021", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, 1)
                        .SingleTask(new DestroyTask(EntityType.ALLMINIONS))
                        .Build()
                }
			});

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
			cards.Add("NEW1_022", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.SELF,
					Activation = EnchantmentActivation.HAND,
                    Enchant = new Enchant
                    {
                        EnableConditions = new List<SelfCondition>
                        {
                            SelfCondition.IsInHandZone
                        },
                        ApplyConditions = new List<RelaCondition>
                        {
                            RelaCondition.IsMe(SelfCondition.IsWeaponEquiped)
                        },
                        Effects = new Dictionary<GameTag, int>
                        {
                            [GameTag.COST] = 0
                        },
                        ValueFunc = (owner) => -owner.Controller.Hero.Weapon.AttackDamage
                    }
                 }
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_023] Faerie Dragon - COST:2 [ATK:3/HP:2] 
			// - Race: dragon, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_ABILITIES = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("NEW1_023", null);

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
			cards.Add("NEW1_024", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.HERO, SelfCondition.IsAnyWeaponEquiped),
                        new FlagTask(true, ComplexTask.Create(
                                new GetGameTagTask(GameTag.DURABILITY, EntityType.WEAPON),
                                new MathAddTask(1),
                                new SetGameTagNumberTask(GameTag.DURABILITY, EntityType.WEAPON),
                                new BuffTask(Buffs.WeaponAtk(1), EntityType.WEAPON))))
                },
			});

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
			cards.Add("NEW1_025", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask =  ComplexTask.Create(
                                new GetGameTagTask(GameTag.DURABILITY, EntityType.OP_WEAPON),
                                new MathSubstractionTask(1),
                                new SetGameTagNumberTask(GameTag.DURABILITY, EntityType.OP_WEAPON))
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_026] Violet Teacher - COST:4 [ATK:3/HP:5] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a 1/1 Violet Apprentice.
			// --------------------------------------------------------
			cards.Add("NEW1_026", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new SummonTask("NEW1_026t"))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_027] Southsea Captain - COST:3 [ATK:3/HP:3] 
			// - Race: pirate, Set: expert1, Rarity: epic
			// --------------------------------------------------------
			// Text: Your other Pirates have +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("NEW1_027", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.AttackHealth(1, 1, RelaCondition.IsSameRace)
                }
            });

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
			cards.Add("NEW1_029", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new AuraTask(Auras.CostTurn(-99, RelaCondition.IsOther(SelfCondition.IsSpell)), AuraArea.OP_HAND)
                },
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_030] Deathwing - COST:10 [ATK:12/HP:12] 
			// - Race: dragon, Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all other minions and discard your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_030", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new DestroyTask(EntityType.ALL),
                        new DiscardTask(EntityType.HAND)),
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_037] Master Swordsmith - COST:2 [ATK:1/HP:3] 
			// - Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, give another random friendly minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("NEW1_037", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(ComplexTask.Create(
                            new RandomTask(1, EntityType.MINIONS_NOSOURCE),
                            new BuffTask(Buffs.Attack(1), EntityType.STACK)))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_038] Gruul - COST:8 [ATK:7/HP:7] 
			// - Set: expert1, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of each turn, gain +1/+1 .
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("NEW1_038", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(new BuffTask(Buffs.AttackHealth(1), EntityType.SOURCE))
                        .Build()
                }
            });

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
			cards.Add("NEW1_040", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(new SummonTask("NEW1_040t"))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_041] Stampeding Kodo - COST:5 [ATK:3/HP:5] 
			// - Race: beast, Set: expert1, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a random enemy minion with 2 or less Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_041", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.OP_MINIONS),
                        new FilterStackTask(SelfCondition.IsTagValue(GameTag.ATK, 2, RelaSign.LEQ)),
                        new RandomTask(1, EntityType.STACK),
                        new DestroyTask(EntityType.STACK)),
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [tt_004] Flesheating Ghoul - COST:3 [ATK:2/HP:3] 
			// - Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever a minion dies, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("tt_004", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARDS,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                                .EnableConditions(SelfCondition.IsNotDead,  SelfCondition.IsNotSilenced)
                                .TriggerEffect(GameTag.TO_BE_DESTROYED, 1)
                                .SingleTask(new BuffTask(Buffs.Attack(1), EntityType.SOURCE))
                                .Build()
                }
            });

		}

		private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - NEUTRAL
			// [EX1_014t] Bananas (*) - COST:1 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: Give a minion +1/+1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("EX1_014t", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackHealth(1), EntityType.TARGET)
                }
            });

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CS2_181e] Full Strength (*) - COST:0 
			// - Set: expert1, 
			// --------------------------------------------------------
			// Text: This minion has +2 Attack.
			// --------------------------------------------------------
			cards.Add("CS2_181e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [DREAM_05e] Nightmare (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: This minion has +5/+5, but will be destroyed soon.
            // --------------------------------------------------------
            cards.Add("DREAM_05e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_001e] Warded (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("EX1_001e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_009e] Enraged (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +5 Attack.
            // --------------------------------------------------------
            // GameTag:
            // - ENRAGED = 1
            // --------------------------------------------------------
            cards.Add("EX1_009e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_014te] Bananas (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Has +1/+1.
            // --------------------------------------------------------
            cards.Add("EX1_014te", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_043e] Hour of Twilight (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased Health.
            // --------------------------------------------------------
            cards.Add("EX1_043e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_044e] Level Up! (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased Attack and Health.
            // --------------------------------------------------------
            cards.Add("EX1_044e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_046e] Tempered (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +2 Attack this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("EX1_046e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_055o] Empowered (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Mana Addict has increased Attack.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("EX1_055o", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_059e] Experiments! (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Attack and Health have been swapped by Crazed Alchemist.
            // --------------------------------------------------------
            cards.Add("EX1_059e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_080o] Keeping Secrets (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("EX1_080o", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_093e] Hand of Argus (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +1/+1 and <b>Taunt</b>.
            // --------------------------------------------------------
            cards.Add("EX1_093e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_103e] Mrghlglhal (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +2 Health.
            // --------------------------------------------------------
            cards.Add("EX1_103e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_162o] Strength of the Pack (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +1 Attack from Dire Wolf Alpha.
            // --------------------------------------------------------
            cards.Add("EX1_162o", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_390e] Enraged (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +3 Attack.
            // --------------------------------------------------------
            // GameTag:
            // - ENRAGED = 1
            // --------------------------------------------------------
            cards.Add("EX1_390e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_393e] Enraged (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +3 Attack.
            // --------------------------------------------------------
            // GameTag:
            // - ENRAGED = 1
            // --------------------------------------------------------
            cards.Add("EX1_393e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_412e] Enraged (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +1 Attack and <b>Windfury</b>.
            // --------------------------------------------------------
            // GameTag:
            // - ENRAGED = 1
            // --------------------------------------------------------
            cards.Add("EX1_412e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_507e] Mrgglaargl! (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +2/+1 from Murloc Warleader.
            // --------------------------------------------------------
            cards.Add("EX1_507e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_509e] Blarghghl (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("EX1_509e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_561e] Alexstrasza's Fire (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Health set to 15.
            // --------------------------------------------------------
            cards.Add("EX1_561e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_570e] Bite (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +4 Attack this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("EX1_570e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_584e] Teachings of the Kirin Tor (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: <b>Spell Damage +1</b>.
            // --------------------------------------------------------
            cards.Add("EX1_584e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [EX1_590e] Shadows of M'uru (*) - COST:0 
            // - Set: expert1, Rarity: common
            // --------------------------------------------------------
            // Text: This minion has consumed Divine Shields and has increased Attack and Health.
            // --------------------------------------------------------
            cards.Add("EX1_590e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [KARA_08_04e] Empowered (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +8 Attack this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("KARA_08_04e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [NEW1_017e] Full Belly (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +2/+2.  Full of Murloc.
            // --------------------------------------------------------
            cards.Add("NEW1_017e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [NEW1_018e] Treasure Crazed (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("NEW1_018e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [NEW1_024o] Greenskin's Command (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("NEW1_024o", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [NEW1_025e] Bolstered (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased Health.
            // --------------------------------------------------------
            cards.Add("NEW1_025e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [NEW1_027e] Yarrr! (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Southsea Captain is granting +1/+1.
            // --------------------------------------------------------
            cards.Add("NEW1_027e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [NEW1_029t] Kill Millhouse! (*) - COST:0 
            // - Set: expert1, Rarity: legendary
            // --------------------------------------------------------
            // Text: Spells cost (0) this turn!
            // --------------------------------------------------------
            cards.Add("NEW1_029t", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [NEW1_037e] Equipped (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("NEW1_037e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [NEW1_038o] Growth (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Gruul is growing...
            // --------------------------------------------------------
            cards.Add("NEW1_038o", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [tt_004o] Cannibalize (*) - COST:0 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("tt_004o", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CS2_152] Squire (*) - COST:1 [ATK:2/HP:2] 
            // - Fac: alliance, Set: expert1, Rarity: common
            // --------------------------------------------------------
            cards.Add("CS2_152", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_110t] Baine Bloodhoof (*) - COST:4 [ATK:4/HP:5] 
            // - Set: expert1, Rarity: legendary
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("EX1_110t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_116t] Whelp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: dragon, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_116t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_598] Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Fac: neutral, Set: expert1, 
			// --------------------------------------------------------
			cards.Add("EX1_598", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_614t] Flame of Azzinoth (*) - COST:1 [ATK:2/HP:1] 
            // - Set: expert1, 
            // --------------------------------------------------------
            cards.Add("EX1_614t", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_finkle] Finkle Einhorn (*) - COST:3 [ATK:3/HP:3] 
            // - Fac: neutral, Set: expert1, Rarity: legendary
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            cards.Add("EX1_finkle", null);

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_tk28] Squirrel (*) - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            cards.Add("EX1_tk28", null);

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_tk29] Devilsaur (*) - COST:5 [ATK:5/HP:5] 
			// - Race: beast, Fac: neutral, Set: expert1, Rarity: common
			// --------------------------------------------------------
			cards.Add("EX1_tk29", null);

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_026t] Violet Apprentice (*) - COST:1 [ATK:1/HP:1] 
			// - Set: expert1, 
			// --------------------------------------------------------
			cards.Add("NEW1_026t", null);

            // --------------------------------------- MINION - NEUTRAL
            // [NEW1_040t] Gnoll (*) - COST:2 [ATK:2/HP:2] 
            // - Set: expert1, 
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            cards.Add("NEW1_040t", null);

            // --------------------------------------- MINION - NEUTRAL
            // [skele21] Damaged Golem (*) - COST:1 [ATK:2/HP:1] 
            // - Race: mechanical, Fac: neutral, Set: expert1, Rarity: common
            // --------------------------------------------------------
            cards.Add("skele21", null);

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
			DreamNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}

}
