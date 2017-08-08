using System.Collections.Generic;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets
{
	public class HofCardsGen
	{
		private static void Mage(IDictionary<string, List<Enchantment>> cards)
		{
            // ------------------------------------------- SPELL - MAGE
            // [CS2_031] Ice Lance - COST:1 
            // - Fac: neutral, Set: hof, Rarity: common
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
                        new ConditionTask(EntityType.TARGET, SelfCondition.IsFrozen),
                        ComplexTask.True(new DamageTask(4, EntityType.TARGET, true)),
                        ComplexTask.False(ComplexTask.Freeze(EntityType.TARGET)))
                }
            });
        }

		private static void Rogue(IDictionary<string, List<Enchantment>> cards)
		{
            // ------------------------------------------ SPELL - ROGUE
            // [EX1_128] Conceal - COST:1 
            // - Fac: neutral, Set: hof, Rarity: common
            // --------------------------------------------------------
            // Text: Give your minions <b>Stealth</b> until your next_turn.
            // --------------------------------------------------------
            // RefTag:
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("EX1_128", new List<Enchantment> {
                new Enchantment
                {
                    InfoCardId = "EX1_128e",
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffStealthTask(EntityType.MINIONS)
                },
            });
        }

		private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
		}

		private static void Warlock(IDictionary<string, List<Enchantment>> cards)
		{
            // ---------------------------------------- SPELL - WARLOCK
            // [EX1_316] Power Overwhelming - COST:1 
            // - Fac: neutral, Set: hof, Rarity: common
            // --------------------------------------------------------
            // Text: Give a friendly minion +4/+4 until end of turn. Then, it dies. Horribly.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("EX1_316", new List<Enchantment> {
                new Enchantment
                {
                    InfoCardId = "EX1_316e",
                    Area = EnchantmentArea.TARGET,
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new BuffTask(Buffs.AttackHealth(4), EntityType.TARGET),
                    Enchant = new Enchant
                    {
                        TurnsActive = 0,
                        EnableConditions = new List<SelfCondition>
                        {
                            SelfCondition.IsNotSilenced,
                            SelfCondition.IsInZone(Zone.PLAY)
                        },
                        Effects = new Dictionary<GameTag, int>
                        {
                            [GameTag.NUM_TURNS_IN_PLAY] = 0
                        },
                        SingleTask = new DestroyTask(EntityType.TARGET)
                    }
                }
            });
        }

		private static void WarlockNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
		}

		private static void Neutral(IDictionary<string, List<Enchantment>> cards)
		{
            // --------------------------------------- MINION - NEUTRAL
            // [EX1_016] Sylvanas Windrunner - COST:6 [ATK:5/HP:5] 
            // - Set: hof, Rarity: legendary
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
            // [EX1_062] Old Murk-Eye - COST:4 [ATK:2/HP:4] 
            // - Race: murloc, Fac: neutral, Set: hof, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Charge</b>. Has +1 Attack for each other Murloc on the battlefield.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("EX1_062", new List<Enchantment> {
				// TODO [EX1_062] Old Murk-Eye && Test: Old Murk-Eye_EX1_062
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_112] Gelbin Mekkatorque - COST:6 [ATK:6/HP:6] 
			// - Fac: alliance, Set: hof, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon an AWESOME invention.
			// --------------------------------------------------------
			// Entourage: Mekka1, Mekka2, Mekka3, Mekka4
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_112", new List<Enchantment> {
				// TODO [EX1_112] Gelbin Mekkatorque && Test: Gelbin Mekkatorque_EX1_112
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_284] Azure Drake - COST:5 [ATK:4/HP:4] 
            // - Race: dragon, Fac: neutral, Set: hof, Rarity: rare
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
                    Activation = EnchantmentActivation.BOARD_ZONE,
                    Enchant = Auras.SpellPowerDamage(1)
                },
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DrawTask()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [EX1_298] Ragnaros the Firelord - COST:8 [ATK:8/HP:8] 
            // - Race: elemental, Fac: neutral, Set: hof, Rarity: legendary
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
                    Activation = EnchantmentActivation.BOARD_ZONE,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 8))
                        .Build()
                }
            });

            // --------------------------------------- MINION - NEUTRAL
            // [NEW1_016] Captain's Parrot - COST:2 [ATK:1/HP:1] 
            // - Race: beast, Set: hof, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Draw a Pirate from your deck.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("NEW1_016", new List<Enchantment> {
				// TODO [NEW1_016] Captain's Parrot && Test: Captain's Parrot_NEW1_016
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [PRO_001] Elite Tauren Chieftain - COST:5 [ATK:5/HP:5] 
			// - Set: hof, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give both players the power to ROCK! (with a Power Chord card)
			// --------------------------------------------------------
			// Entourage: PRO_001a, PRO_001b, PRO_001c
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("PRO_001", new List<Enchantment> {
				// TODO [PRO_001] Elite Tauren Chieftain && Test: Elite Tauren Chieftain_PRO_001
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [Mekka3e] Emboldened! (*) - COST:0 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Increased Stats.
			// --------------------------------------------------------
			cards.Add("Mekka3e", new List<Enchantment> {
				// TODO [Mekka3e] Emboldened! && Test: Emboldened!_Mekka3e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [Mekka4e] Transformed (*) - COST:0 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Has been transformed into a chicken!
			// --------------------------------------------------------
			// GameTag:
			// - MORPH = 1
			// --------------------------------------------------------
			cards.Add("Mekka4e", new List<Enchantment> {
				// TODO [Mekka4e] Transformed && Test: Transformed_Mekka4e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [Mekka1] Homing Chicken (*) - COST:1 [ATK:0/HP:1] 
			// - Race: mechanical, Fac: alliance, Set: hof, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy this minion and draw 3 cards.
			// --------------------------------------------------------
			cards.Add("Mekka1", new List<Enchantment> {
				// TODO [Mekka1] Homing Chicken && Test: Homing Chicken_Mekka1
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [Mekka2] Repair Bot (*) - COST:1 [ATK:0/HP:3] 
			// - Race: mechanical, Fac: alliance, Set: hof, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 6 Health to a damaged character.
			// --------------------------------------------------------
			cards.Add("Mekka2", new List<Enchantment> {
				// TODO [Mekka2] Repair Bot && Test: Repair Bot_Mekka2
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [Mekka3] Emboldener 3000 (*) - COST:1 [ATK:0/HP:4] 
			// - Race: mechanical, Fac: alliance, Set: hof, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, give a random minion +1/+1.
			// --------------------------------------------------------
			cards.Add("Mekka3", new List<Enchantment> {
				// TODO [Mekka3] Emboldener 3000 && Test: Emboldener 3000_Mekka3
				new Enchantment
				{
					InfoCardId = "Mekka3e",
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [Mekka4] Poultryizer (*) - COST:1 [ATK:0/HP:3] 
			// - Race: mechanical, Fac: alliance, Set: hof, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of your turn, transform a random minion into a 1/1 Chicken.
			// --------------------------------------------------------
			cards.Add("Mekka4", new List<Enchantment> {
				// TODO [Mekka4] Poultryizer && Test: Poultryizer_Mekka4
				new Enchantment
				{
					InfoCardId = "Mekka4e",
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [Mekka4t] Chicken (*) - COST:0 [ATK:1/HP:1] 
			// - Race: beast, Set: hof, 
			// --------------------------------------------------------
			// Text: <i>Hey Chicken!</i>
			// --------------------------------------------------------
			cards.Add("Mekka4t", new List<Enchantment> {
				// TODO [Mekka4t] Chicken && Test: Chicken_Mekka4t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [PRO_001at] Murloc (*) - COST:0 [ATK:1/HP:1] 
			// - Race: murloc, Set: hof, 
			// --------------------------------------------------------
			cards.Add("PRO_001at", new List<Enchantment> {
				// TODO [PRO_001at] Murloc && Test: Murloc_PRO_001at
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PRO_001a] I Am Murloc (*) - COST:4 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Summon three, four, or five 1/1 Murlocs.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("PRO_001a", new List<Enchantment> {
				// TODO [PRO_001a] I Am Murloc && Test: I Am Murloc_PRO_001a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PRO_001b] Rogues Do It... (*) - COST:4 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Deal $4 damage. Draw a card. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("PRO_001b", new List<Enchantment> {
				// TODO [PRO_001b] Rogues Do It... && Test: Rogues Do It..._PRO_001b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PRO_001c] Power of the Horde (*) - COST:4 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Summon a random Horde Warrior.
			// --------------------------------------------------------
			// Entourage: CS2_121, EX1_021, EX1_023, EX1_110, EX1_390, CS2_179
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("PRO_001c", new List<Enchantment> {
				// TODO [PRO_001c] Power of the Horde && Test: Power of the Horde_PRO_001c
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		public static void AddAll(Dictionary<string, List<Enchantment>> cards)
		{
			Mage(cards);
			Rogue(cards);
			RogueNonCollect(cards);
			Warlock(cards);
			WarlockNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
