using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets
{
	public class TgtCardsGen
	{
		private static void HeroPowers(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------ HERO_POWER - SHAMAN
			// [AT_050t] Lightning Jolt (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_050t", new List<Enchantment> {
				new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(2, EntityType.TARGET, false)
                }
			});

			// ------------------------------------- HERO_POWER - DRUID
			// [AT_132_DRUID] Dire Shapeshift (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 2 Armor and +2 Attack this turn.
			// --------------------------------------------------------
			cards.Add("AT_132_DRUID", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new ArmorTask(2),
                        new BuffTask(Buffs.AttackTurn(2), EntityType.HERO))
                }
            });

			// ------------------------------------ HERO_POWER - HUNTER
			// [AT_132_HUNTER] Ballista Shot (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $3 damage to the enemy hero. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_STEADY_SHOT = 0
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("AT_132_HUNTER", new List<Enchantment> {
              new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(3, EntityType.OP_HERO, false)
                }
            });

			// -------------------------------------- HERO_POWER - MAGE
			// [AT_132_MAGE] Fireblast Rank 2 (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_132_MAGE", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(2, EntityType.TARGET, false)
                }
            });

			// ----------------------------------- HERO_POWER - PALADIN
			// [AT_132_PALADIN] The Silver Hand (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon two 1/1 Recruits.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("AT_132_PALADIN", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(2, new SummonTask("CS2_101t"))
                }
            });

			// ------------------------------------ HERO_POWER - PRIEST
			// [AT_132_PRIEST] Heal (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Restore #4 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_132_PRIEST", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new HealTask(4, EntityType.TARGET)
                }
            });

			// ------------------------------------- HERO_POWER - ROGUE
			// [AT_132_ROGUE] Poisoned Daggers (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Equip a 2/2 Weapon.
			// --------------------------------------------------------
			cards.Add("AT_132_ROGUE", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new WeaponTask(WeaponTaskType.EQUIP, "AT_132_ROGUEt")
                }
            });

			// ------------------------------------ HERO_POWER - SHAMAN
			// [AT_132_SHAMAN] Totemic Slam (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a Totem of your choice.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("AT_132_SHAMAN", new List<Enchantment> {
				// TODO [AT_132_SHAMAN] Totemic Slam && Test: Totemic Slam_AT_132_SHAMAN
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------- HERO_POWER - WARLOCK
			// [AT_132_WARLOCK] Soul Tap (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw a card.
			// --------------------------------------------------------
			cards.Add("AT_132_WARLOCK", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DrawTask()
                }
            });

			// ----------------------------------- HERO_POWER - WARRIOR
			// [AT_132_WARRIOR] Tank Up! (*) - COST:2 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 4 Armor.
			// --------------------------------------------------------
			cards.Add("AT_132_WARRIOR", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new ArmorTask(4)
                }
            });

		}

		private static void Druid(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [AT_037] Living Roots - COST:1 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Deal $2 damage; or Summon two 1/1 Saplings. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_037",                 
                //CHOOSE_ONE
                null);

            // ------------------------------------------ SPELL - DRUID
            // [AT_043] Astral Communion - COST:4 
            // - Set: tgt, Rarity: epic
            // --------------------------------------------------------
            // Text: Gain 10 Mana Crystals. Discard your hand.
            // --------------------------------------------------------
            cards.Add("AT_043", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DiscardTask(EntityType.HAND),
                        ComplexTask.ExcessManaCheck,
                        new ManaCrystalFullTask(10))
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_044] Mulch - COST:3 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy a minion.
			//       Add a random minion to your opponent's hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_044", new List<Enchantment> {
				// TODO [AT_044] Mulch && Test: Mulch_AT_044
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_038] Darnassus Aspirant - COST:2 [ATK:2/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain an empty Mana Crystal.
			//       <b>Deathrattle:</b> Lose a Mana Crystal.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_038", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new ManaCrystalEmptyTask(1)
				},
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new ManaCrystalEmptyTask(-1)
                },
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_039] Savage Combatant - COST:4 [ATK:5/HP:4] 
			// - Race: beast, Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Give your hero
			//       +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_039", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = Triggers.Inspire(new BuffTask(Buffs.AttackTurn(2), EntityType.HERO))
                }
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_040] Wildwalker - COST:4 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Beast +3 Health.
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
			cards.Add("AT_040", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new BuffTask(Buffs.Health(3), EntityType.TARGET)
				},
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_041] Knight of the Wild - COST:7 [ATK:6/HP:6] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you summon a Beast, reduce the Cost of this card by (1).
			// --------------------------------------------------------
			cards.Add("AT_041", new List<Enchantment> {
				// TODO [AT_041] Knight of the Wild && Test: Knight of the Wild_AT_041
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - DRUID
			// [AT_042] Druid of the Saber - COST:2 [ATK:2/HP:1] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Transform to gain <b>Charge</b>; or +1/+1 and <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_042", null);

			// ----------------------------------------- MINION - DRUID
			// [AT_045] Aviana - COST:9 [ATK:5/HP:5] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your minions cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("AT_045", new List<Enchantment> {
				// TODO [AT_045] Aviana && Test: Aviana_AT_045
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void DruidNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [AT_037a] Living Roots (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Deal $2 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_037a", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DamageTask(2, EntityType.TARGET, true)
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_037b] Living Roots (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Summon two 1/1 Saplings.
			// --------------------------------------------------------
			cards.Add("AT_037b", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new EnqueueTask(2, new SummonTask("AT_037t"), false)
				}
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_042a] Lion Form (*) - COST:0 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			cards.Add("AT_042a", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new TransformTask("AT_042t", EntityType.SOURCE)
				}
			});

			// ------------------------------------------ SPELL - DRUID
			// [AT_042b] Panther Form (*) - COST:0 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Stealth</b>
			// --------------------------------------------------------
			cards.Add("AT_042b", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new TransformTask("AT_042t2", EntityType.SOURCE)
                }
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [AT_039e] Savage (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("AT_039e", null);

			// ------------------------------------ ENCHANTMENT - DRUID
			// [AT_040e] Kindred Spirit (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("AT_040e", null);

            // ------------------------------------ ENCHANTMENT - DRUID
            // [AT_132_DRUIDe] Dire Claws (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +2 Attack this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("AT_132_DRUIDe", null);

            // ----------------------------------------- MINION - DRUID
            // [AT_037t] Sapling (*) - COST:1 [ATK:1/HP:1] 
            // - Set: tgt, 
            // --------------------------------------------------------
            cards.Add("AT_037t", null);

            // ----------------------------------------- MINION - DRUID
            // [AT_042t] Sabertooth Lion (*) - COST:2 [ATK:2/HP:1] 
            // - Race: beast, Set: tgt, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("AT_042t", null);

			// ----------------------------------------- MINION - DRUID
			// [AT_042t2] Sabertooth Panther (*) - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("AT_042t2", null);

			// ----------------------------------------- MINION - DRUID
			// [OG_044c] Sabertooth Tiger (*) - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge, Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("OG_044c", null);

        }

		private static void Hunter(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - HUNTER
			// [AT_056] Powershot - COST:3 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion and the minions next to it. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_056", new List<Enchantment> {
				// TODO [AT_056] Powershot && Test: Powershot_AT_056
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [AT_060] Bear Trap - COST:2 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your hero is attacked, summon a 3/3 Bear with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_060", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .TriggerEffect(GameTag.DEFENDING, 1)
                        .SingleTask(ComplexTask.Secret(
                            new SummonTask("CS2_125")))
                        .Build()
				}
			});

			// ----------------------------------------- SPELL - HUNTER
			// [AT_061] Lock and Load - COST:2 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Each time you cast a spell this turn, add a random Hunter card to your hand.
			// --------------------------------------------------------
			cards.Add("AT_061", new List<Enchantment> {
				// TODO [AT_061] Lock and Load && Test: Lock and Load_AT_061
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [AT_062] Ball of Spiders - COST:6 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon three 1/1 Webspinners.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("AT_062", new List<Enchantment> {
				// TODO [AT_062] Ball of Spiders && Test: Ball of Spiders_AT_062
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - HUNTER
			// [AT_010] Ram Wrangler - COST:5 [ATK:3/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a Beast, summon a
			//       random Beast.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_010", new List<Enchantment> {
				// TODO [AT_010] Ram Wrangler && Test: Ram Wrangler_AT_010
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - HUNTER
			// [AT_057] Stablemaster - COST:3 [ATK:4/HP:2] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Beast <b>Immune</b> this turn.
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
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("AT_057", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new BuffTask(Buffs.ImmuneTurn(), EntityType.TARGET)
				},
			});

			// ---------------------------------------- MINION - HUNTER
			// [AT_058] King's Elekk - COST:2 [ATK:3/HP:2] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, draw it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_058", new List<Enchantment> {
				// TODO [AT_058] King's Elekk && Test: King's Elekk_AT_058
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - HUNTER
			// [AT_059] Brave Archer - COST:1 [ATK:2/HP:1] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> If your hand is empty, deal 2 damage to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_059", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = Triggers.Inspire(ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsHandEmpty),
                        new FlagTask(true, new DamageTask(2, EntityType.OP_HERO))))
                }
			});

			// ---------------------------------------- MINION - HUNTER
			// [AT_063] Acidmaw - COST:7 [ATK:4/HP:2] 
			// - Race: beast, Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever another minion takes damage, destroy it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("AT_063", new List<Enchantment> {
				// TODO [AT_063] Acidmaw && Test: Acidmaw_AT_063
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - HUNTER
			// [AT_063t] Dreadscale - COST:3 [ATK:4/HP:2] 
			// - Race: beast, Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 1 damage to all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("AT_063t", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(new DamageTask(1, EntityType.ALLMINIONS_NOSOURCE))
                        .Build()
                }
            });

		}

		private static void HunterNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [AT_057o] Groomed (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("AT_057o", null);

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [AT_061e] Lock and Load (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("AT_061e", null);

        }

		private static void Mage(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [AT_001] Flame Lance - COST:5 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $8 damage to a minion. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_001", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DamageTask(8, EntityType.TARGET),
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [AT_002] Effigy - COST:3 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a friendly minion dies, summon a random minion with the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("AT_002", new List<Enchantment> {
				// TODO [AT_002] Effigy && Test: Effigy_AT_002
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [AT_004] Arcane Blast - COST:1 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. This spell gets double bonus from <b>Spell Damage</b>. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - RECEIVES_DOUBLE_SPELLDAMAGE_BONUS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("AT_004", new List<Enchantment> {
				// TODO [AT_004] Arcane Blast && Test: Arcane Blast_AT_004
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [AT_005] Polymorph: Boar - COST:3 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Transform a minion into a 4/2 Boar with <b>Charge</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_005", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask =  new TransformTask("AT_005t", EntityType.TARGET)
                }
            });

			// ------------------------------------------ MINION - MAGE
			// [AT_003] Fallen Hero - COST:2 [ATK:3/HP:2] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Your Hero Power deals 1 extra damage.
			// --------------------------------------------------------
			// GameTag:
			// - HEROPOWER_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("AT_003", new List<Enchantment> {
				// TODO [AT_003] Fallen Hero && Test: Fallen Hero_AT_003
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ------------------------------------------ MINION - MAGE
			// [AT_006] Dalaran Aspirant - COST:4 [ATK:3/HP:5] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Gain <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_006", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = Triggers.Inspire(new AuraTask(Auras.SpellDamage(1), AuraArea.HERO))
                }
			});

			// ------------------------------------------ MINION - MAGE
			// [AT_007] Spellslinger - COST:3 [ATK:3/HP:4] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random spell to each player's hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_007", new List<Enchantment> {
				// TODO [AT_007] Spellslinger && Test: Spellslinger_AT_007
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ------------------------------------------ MINION - MAGE
			// [AT_008] Coldarra Drake - COST:6 [ATK:6/HP:6] 
			// - Race: dragon, Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: You can use your Hero Power any number of times.
			// --------------------------------------------------------
			cards.Add("AT_008", new List<Enchantment> {
				// TODO [AT_008] Coldarra Drake && Test: Coldarra Drake_AT_008
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ------------------------------------------ MINION - MAGE
			// [AT_009] Rhonin - COST:8 [ATK:7/HP:7] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add 3 copies of Arcane Missiles to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("AT_009", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = new EnqueueTask(3, new AddCardTo("EX1_277", EntityType.HAND)),
				},
			});

		}

		private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [AT_006e] Power of Dalaran (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Spell Damage.
			// --------------------------------------------------------
			cards.Add("AT_006e", null);

		}

		private static void Paladin(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - PALADIN
			// [AT_073] Competitive Spirit - COST:1 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your turn starts, give your minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("AT_073", new List<Enchantment> {
				// TODO [AT_073] Competitive Spirit && Test: Competitive Spirit_AT_073
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [AT_074] Seal of Champions - COST:3 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion
			//       +3 Attack and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("AT_074", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new BuffTask(Buffs.Attack(3), EntityType.TARGET),
                        ComplexTask.DivineShield(EntityType.TARGET))
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [AT_078] Enter the Coliseum - COST:6 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all minions except each player's highest Attack minion.
			// --------------------------------------------------------
			cards.Add("AT_078", new List<Enchantment> {
				// TODO [AT_078] Enter the Coliseum && Test: Enter the Coliseum_AT_078
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - PALADIN
			// [AT_075] Warhorse Trainer - COST:3 [ATK:2/HP:4] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Your Silver Hand Recruits have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("AT_075", new List<Enchantment> {
				// TODO [AT_075] Warhorse Trainer && Test: Warhorse Trainer_AT_075
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - PALADIN
			// [AT_076] Murloc Knight - COST:4 [ATK:3/HP:4] 
			// - Race: murloc, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Summon a random Murloc.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_076", new List<Enchantment> {
				// TODO [AT_076] Murloc Knight && Test: Murloc Knight_AT_076
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - PALADIN
			// [AT_079] Mysterious Challenger - COST:6 [ATK:6/HP:6] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Put one of each <b>Secret</b> from your deck into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("AT_079", new List<Enchantment> {
				// TODO [AT_079] Mysterious Challenger && Test: Mysterious Challenger_AT_079
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - PALADIN
			// [AT_081] Eadric the Pure - COST:7 [ATK:3/HP:7] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Change all enemy minions'
			//       Attack to 1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_081", new List<Enchantment> {
				// TODO [AT_081] Eadric the Pure && Test: Eadric the Pure_AT_081
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - PALADIN
			// [AT_104] Tuskarr Jouster - COST:5 [ATK:5/HP:5] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, restore 7 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_104", new List<Enchantment> {
				// TODO [AT_104] Tuskarr Jouster && Test: Tuskarr Jouster_AT_104
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - PALADIN
			// [AT_077] Argent Lance - COST:2 [ATK:2/HP:0] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_077", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new RevealTask(new BuffTask(Buffs.WeaponDura(1), EntityType.SOURCE)),
				},
			});

		}

		private static void PaladinNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [AT_074e2] Seal of Champions (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +3 Attack and <b>Divine Shield</b>.
			// --------------------------------------------------------
			cards.Add("AT_074e2", null);

            // ---------------------------------- ENCHANTMENT - PALADIN
            // [AT_075e] Might of the Hostler (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Warhorse Trainer is granting this minion +1 Attack.
            // --------------------------------------------------------
            cards.Add("AT_075e", null);

            // ---------------------------------- ENCHANTMENT - PALADIN
            // [AT_081e] Purified (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Attack changed to 1.
            // --------------------------------------------------------
            cards.Add("AT_081e", null);

        }

		private static void Priest(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - PRIEST
			// [AT_013] Power Word: Glory - COST:1 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Choose a minion. Whenever it attacks, restore 4 Health to
			//       your hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_013", new List<Enchantment> {
				// TODO [AT_013] Power Word: Glory && Test: Power Word: Glory_AT_013
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [AT_015] Convert - COST:2 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Put a copy of an enemy minion into your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_015", new List<Enchantment> {
				// TODO [AT_015] Convert && Test: Convert_AT_015
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [AT_016] Confuse - COST:2 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Swap the Attack and Health of all minions.
			// --------------------------------------------------------
			cards.Add("AT_016", new List<Enchantment> {
				// TODO [AT_016] Confuse && Test: Confuse_AT_016
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [AT_055] Flash Heal - COST:1 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #5 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_055", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new HealTask(5, EntityType.TARGET),
				},
			});

			// ---------------------------------------- MINION - PRIEST
			// [AT_011] Holy Champion - COST:4 [ATK:3/HP:5] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever a character is healed, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("AT_011", new List<Enchantment> {
				// TODO [AT_011] Holy Champion && Test: Holy Champion_AT_011
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - PRIEST
			// [AT_012] Spawn of Shadows - COST:4 [ATK:5/HP:4] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Deal 4 damage to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_012", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = Triggers.Inspire(ComplexTask.Create(
                        new DamageTask(4, EntityType.HERO),
                        new DamageTask(4, EntityType.OP_HERO)))
                }
			});

			// ---------------------------------------- MINION - PRIEST
			// [AT_014] Shadowfiend - COST:3 [ATK:3/HP:3] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you draw a card, reduce its Cost by (1).
			// --------------------------------------------------------
			cards.Add("AT_014", new List<Enchantment> {
				// TODO [AT_014] Shadowfiend && Test: Shadowfiend_AT_014
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - PRIEST
			// [AT_018] Confessor Paletress - COST:7 [ATK:5/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Summon a random <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_018", new List<Enchantment> {
				// TODO [AT_018] Confessor Paletress && Test: Confessor Paletress_AT_018
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,twilight

				)
			});

			// ---------------------------------------- MINION - PRIEST
			// [AT_116] Wyrmrest Agent - COST:2 [ATK:1/HP:4] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_116", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
                        new FlagTask(true, ComplexTask.Create(
                            new BuffTask(Buffs.Attack(1), EntityType.SOURCE),
                            ComplexTask.Taunt(EntityType.SOURCE)))),
                },
			});

		}

		private static void PriestNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [AT_014e] Shadowfiended (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("AT_014e", null);

            // ----------------------------------- ENCHANTMENT - PRIEST
            // [AT_016e] Confused (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Swapped Attack and Health.
            // --------------------------------------------------------
            cards.Add("AT_016e", null);

            // ----------------------------------- ENCHANTMENT - PRIEST
            // [AT_116e] Bring it on! (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +1 Attack and <b>Taunt</b>.
            // --------------------------------------------------------
            cards.Add("AT_116e", null);

        }

		private static void Rogue(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [AT_033] Burgle - COST:3 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Add 2 random class cards to your hand <i>(from your opponent's class)</i>.
			// --------------------------------------------------------
			cards.Add("AT_033", new List<Enchantment> {
				// TODO [AT_033] Burgle && Test: Burgle_AT_033
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [AT_035] Beneath the Grounds - COST:3 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle 3 Ambushes into your opponent's deck. When drawn, you summon a 4/4 Nerubian.
			// --------------------------------------------------------
			cards.Add("AT_035", new List<Enchantment> {
				// TODO [AT_035] Beneath the Grounds && Test: Beneath the Grounds_AT_035
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_028] Shado-Pan Rider - COST:5 [ATK:3/HP:7] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Gain +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("AT_028", new List<Enchantment> {
				// TODO [AT_028] Shado-Pan Rider && Test: Shado-Pan Rider_AT_028
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_029] Buccaneer - COST:1 [ATK:2/HP:1] 
			// - Race: pirate, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you equip a weapon, give it +1 Attack.
			// --------------------------------------------------------
			cards.Add("AT_029", new List<Enchantment> {
				// TODO [AT_029] Buccaneer && Test: Buccaneer_AT_029
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_030] Undercity Valiant - COST:2 [ATK:3/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Deal 1 damage.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_FOR_COMBO = 0
			// --------------------------------------------------------
			cards.Add("AT_030", new List<Enchantment> {
				// TODO [AT_030] Undercity Valiant && Test: Undercity Valiant_AT_030
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_031] Cutpurse - COST:2 [ATK:2/HP:2] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever this minion attacks a hero, add the Coin to your hand.
			// --------------------------------------------------------
			cards.Add("AT_031", new List<Enchantment> {
				// TODO [AT_031] Cutpurse && Test: Cutpurse_AT_031
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_032] Shady Dealer - COST:3 [ATK:4/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a Pirate, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_032", new List<Enchantment> {
				// TODO [AT_032] Shady Dealer && Test: Shady Dealer_AT_032
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ----------------------------------------- MINION - ROGUE
			// [AT_036] Anub'arak - COST:9 [ATK:8/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return this to your hand and summon a 4/4 Nerubian.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("AT_036", new List<Enchantment> {
				// TODO [AT_036] Anub'arak && Test: Anub'arak_AT_036
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [AT_034] Poisoned Blade - COST:4 [ATK:1/HP:0] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Your Hero Power gives this weapon +1 Attack instead of replacing it.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("AT_034", new List<Enchantment> {
				// TODO [AT_034] Poisoned Blade && Test: Poisoned Blade_AT_034
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [AT_035t] Ambush! (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: When you draw this, summon a 4/4 Nerubian for your opponent. Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("AT_035t", new List<Enchantment> {
				// TODO [AT_035t] Ambush! && Test: Ambush!_AT_035t
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [AT_032e] Shady Deals (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_032e", null);

            // ------------------------------------ ENCHANTMENT - ROGUE
            // [AT_034e] Laced (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("AT_034e", null);

            // ----------------------------------------- MINION - ROGUE
            // [AT_036t] Nerubian (*) - COST:4 [ATK:4/HP:4] 
            // - Set: tgt, 
            // --------------------------------------------------------
            cards.Add("AT_036t", null);

            // ----------------------------------------- WEAPON - ROGUE
            // [AT_132_ROGUEt] Poisoned Dagger (*) - COST:1 [ATK:2/HP:0] 
            // - Set: tgt, 
            // --------------------------------------------------------
            // GameTag:
            // - DURABILITY = 2
            // --------------------------------------------------------
            cards.Add("AT_132_ROGUEt", null);

        }

		private static void Shaman(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - SHAMAN
			// [AT_048] Healing Wave - COST:3 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Restore #7 Health. Reveal a minion in each deck. If yours costs more, Restore #14 instead.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_048", new List<Enchantment> {
				// TODO [AT_048] Healing Wave && Test: Healing Wave_AT_048
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [AT_051] Elemental Destruction - COST:3 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $4-$5 damage to all minions. <b>Overload:</b> (5). *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 5
			// - OVERLOAD_OWED = 5
			// --------------------------------------------------------
			cards.Add("AT_051", new List<Enchantment> {
				// TODO [AT_051] Elemental Destruction && Test: Elemental Destruction_AT_051
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [AT_053] Ancestral Knowledge - COST:2 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 cards. <b>Overload:</b> (2)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			cards.Add("AT_053", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new EnqueueTask(2, new DrawTask())
				}
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_046] Tuskarr Totemic - COST:3 [ATK:3/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a random basic Totem.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_046", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                            new IncludeTask(EntityType.SOURCE),
                            new FuncTask(list =>
                            {
                                var controller = list[0].Controller;
                                var basicTotem = new List<string>
                                {
                                    "CS2_050","CS2_051","CS2_052","NEW1_009"
                                };
                                return new List<IPlayable>
                                {
                                    Entity.FromCard(controller, Cards.FromId(Util<string>.Choose(basicTotem)))
                                };
                            }),
                            new SummonTask()
                            )
                }
            });

			// ---------------------------------------- MINION - SHAMAN
			// [AT_047] Draenei Totemcarver - COST:4 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1/+1 for each friendly Totem.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_047", new List<Enchantment> {
				// TODO [AT_047] Draenei Totemcarver && Test: Draenei Totemcarver_AT_047
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_049] Thunder Bluff Valiant - COST:5 [ATK:3/HP:6] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Give your Totems +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_049", new List<Enchantment> {
				// TODO [AT_049] Thunder Bluff Valiant && Test: Thunder Bluff Valiant_AT_049
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_052] Totem Golem - COST:2 [ATK:3/HP:4] 
			// - Race: totem, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			cards.Add("AT_052", null);

			// ---------------------------------------- MINION - SHAMAN
			// [AT_054] The Mistcaller - COST:6 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all minions in your hand and deck +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_054", new List<Enchantment> {
				// TODO [AT_054] The Mistcaller && Test: The Mistcaller_AT_054
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [AT_050] Charged Hammer - COST:4 [ATK:2/HP:0] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Your Hero Power becomes 'Deal 2 damage.'
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("AT_050", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = new ReplaceHeroPower(Cards.FromId("AT_050t"))
				},
			});

		}

		private static void ShamanNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [AT_047e] Experienced (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("AT_047e", null);

            // ----------------------------------- ENCHANTMENT - SHAMAN
            // [AT_049e] Power of the Bluff (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("AT_049e", null);

            // ---------------------------------------- MINION - SHAMAN
            // [AT_132_SHAMANa] Healing Totem (*) - COST:0 [ATK:0/HP:2] 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: At the end of your turn, restore 1 Health to all friendly minions.
            // --------------------------------------------------------
            cards.Add("AT_132_SHAMANa", new List<Enchantment> {
				// TODO [AT_132_SHAMANa] Healing Totem && Test: Healing Totem_AT_132_SHAMANa
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- MINION - SHAMAN
			// [AT_132_SHAMANb] Searing Totem (*) - COST:0 [ATK:1/HP:1] 
			// - Set: tgt, 
			// --------------------------------------------------------
			cards.Add("AT_132_SHAMANb", null);

			// ---------------------------------------- MINION - SHAMAN
			// [AT_132_SHAMANc] Stoneclaw Totem (*) - COST:0 [ATK:0/HP:2] 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			cards.Add("AT_132_SHAMANc", null);

			// ---------------------------------------- MINION - SHAMAN
			// [AT_132_SHAMANd] Wrath of Air Totem (*) - COST:0 [ATK:0/HP:2] 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			cards.Add("AT_132_SHAMANd", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(1)
                },
            });

		}

		private static void Warlock(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARLOCK
			// [AT_022] Fist of Jaraxxus - COST:4 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: When you play or discard this, deal $4 damage to a random enemy. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("AT_022", new List<Enchantment> {
				// TODO [AT_022] Fist of Jaraxxus && Test: Fist of Jaraxxus_AT_022
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [AT_024] Demonfuse - COST:2 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Give a Demon +3/+3. Give your opponent a Mana Crystal.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 15
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_024", new List<Enchantment> {
				// TODO [AT_024] Demonfuse && Test: Demonfuse_AT_024
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [AT_025] Dark Bargain - COST:6 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy 2 random enemy minions. Discard 2 random cards.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("AT_025", new List<Enchantment> {
				// TODO [AT_025] Dark Bargain && Test: Dark Bargain_AT_025
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_019] Dreadsteed - COST:4 [ATK:1/HP:1] 
			// - Race: demon, Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a Dreadsteed.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("AT_019", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = new SummonTask("AT_019"),
				},
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_020] Fearsome Doomguard - COST:7 [ATK:6/HP:8] 
			// - Race: demon, Set: tgt, Rarity: common
			// --------------------------------------------------------
			cards.Add("AT_020", null);

			// --------------------------------------- MINION - WARLOCK
			// [AT_021] Tiny Knight of Evil - COST:2 [ATK:3/HP:2] 
			// - Race: demon, Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you discard a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("AT_021", new List<Enchantment> {
				// TODO [AT_021] Tiny Knight of Evil && Test: Tiny Knight of Evil_AT_021
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_023] Void Crusher - COST:6 [ATK:5/HP:4] 
			// - Race: demon, Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Destroy a random minion for each player.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_023", new List<Enchantment> {
				// TODO [AT_023] Void Crusher && Test: Void Crusher_AT_023
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_026] Wrathguard - COST:2 [ATK:4/HP:3] 
			// - Race: demon, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, also deal that amount to your hero.
			// --------------------------------------------------------
			cards.Add("AT_026", new List<Enchantment> {
				// TODO [AT_026] Wrathguard && Test: Wrathguard_AT_026
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARLOCK
			// [AT_027] Wilfred Fizzlebang - COST:6 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Cards you draw from your Hero Power cost (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("AT_027", new List<Enchantment> {
				// TODO [AT_027] Wilfred Fizzlebang && Test: Wilfred Fizzlebang_AT_027
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void WarlockNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [AT_021e] Felrage (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("AT_021e", null);

            // ---------------------------------- ENCHANTMENT - WARLOCK
            // [AT_027e] Master Summoner (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Costs (0).
            // --------------------------------------------------------
            cards.Add("AT_027e", null);

        }

		private static void Warrior(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [AT_064] Bash - COST:3 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage.
			//       Gain 3 Armor. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("AT_064", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DamageTask(3, EntityType.TARGET),
                        new ArmorTask(3))
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [AT_068] Bolster - COST:2 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Give your <b>Taunt</b> minions +2/+2.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_068", new List<Enchantment> {
				// TODO [AT_068] Bolster && Test: Bolster_AT_068
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [AT_066] Orgrimmar Aspirant - COST:3 [ATK:3/HP:3] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Give your weapon +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_066", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = Triggers.Inspire(new BuffTask(Buffs.WeaponAtk(1), EntityType.WEAPON))
                }
            });

			// --------------------------------------- MINION - WARRIOR
			// [AT_067] Magnataur Alpha - COST:4 [ATK:5/HP:3] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever
			//       he attacks.
			// --------------------------------------------------------
			cards.Add("AT_067", new List<Enchantment> {
				// TODO [AT_067] Magnataur Alpha && Test: Magnataur Alpha_AT_067
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - WARRIOR
			// [AT_069] Sparring Partner - COST:2 [ATK:3/HP:2] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Give a
			//       minion <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("AT_069", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Taunt(EntityType.TARGET),
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [AT_071] Alexstrasza's Champion - COST:2 [ATK:2/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_071", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
                        new FlagTask(true, ComplexTask.Create(
                            new BuffTask(Buffs.Attack(1), EntityType.SOURCE),
                            ComplexTask.Charge(EntityType.SOURCE)))),
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [AT_072] Varian Wrynn - COST:10 [ATK:7/HP:7] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw 3 cards.
			//       Put any minions you drew directly into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_072", new List<Enchantment> {
				// TODO [AT_072] Varian Wrynn && Test: Varian Wrynn_AT_072
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [AT_130] Sea Reaver - COST:6 [ATK:6/HP:7] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: When you draw this, deal 1 damage to your minions.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("AT_130", new List<Enchantment> {
				// TODO [AT_130] Sea Reaver && Test: Sea Reaver_AT_130
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [AT_065] King's Defender - COST:3 [ATK:3/HP:0] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a minion with <b>Taunt</b>,  gain +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_065", new List<Enchantment> {
				// TODO [AT_065] King's Defender && Test: King's Defender_AT_065
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void WarriorNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [AT_066e] Forges of Orgrimmar (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("AT_066e", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [AT_068e] Bolstered (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("AT_068e", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [AT_069e] Training Complete (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            // --------------------------------------------------------
            cards.Add("AT_069e", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [AT_071e] Alexstrasza's Boon (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +1 Attack and <b>Charge</b>.
            // --------------------------------------------------------
            cards.Add("AT_071e", null);

        }

		private static void Neutral(IDictionary<string, List<Enchantment>> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [AT_017] Twilight Guardian - COST:4 [ATK:2/HP:6] 
			// - Race: dragon, Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_017", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
                        new FlagTask(true, ComplexTask.Create(
                            new BuffTask(Buffs.Attack(1), EntityType.SOURCE),
                            ComplexTask.Taunt(EntityType.SOURCE)))),
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_070] Skycap'n Kragg - COST:7 [ATK:4/HP:6] 
			// - Race: pirate, Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charrrrrge</b>
			//       Costs (1) less for each friendly Pirate.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_070", new List<Enchantment> {
				// TODO [AT_070] Skycap'n Kragg && Test: Skycap'n Kragg_AT_070
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_080] Garrison Commander - COST:2 [ATK:2/HP:3] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: You can use your Hero Power twice a turn.
			// --------------------------------------------------------
			cards.Add("AT_080", new List<Enchantment> {
				// TODO [AT_080] Garrison Commander && Test: Garrison Commander_AT_080
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_082] Lowly Squire - COST:1 [ATK:1/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Gain +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_082", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = Triggers.Inspire(new BuffTask(Buffs.Attack(1), EntityType.SOURCE))
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [AT_083] Dragonhawk Rider - COST:3 [ATK:3/HP:3] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Gain <b>Windfury</b>
			//       this turn.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("AT_083", new List<Enchantment> {
				// TODO [AT_083] Dragonhawk Rider && Test: Dragonhawk Rider_AT_083
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_084] Lance Carrier - COST:2 [ATK:1/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("AT_084", new List<Enchantment> {
				// TODO [AT_084] Lance Carrier && Test: Lance Carrier_AT_084
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_085] Maiden of the Lake - COST:4 [ATK:2/HP:6] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: Your Hero Power costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("AT_085", new List<Enchantment> {
				// TODO [AT_085] Maiden of the Lake && Test: Maiden of the Lake_AT_085
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_086] Saboteur - COST:3 [ATK:4/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your opponent's Hero Power costs (5) more next turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_086", new List<Enchantment> {
				// TODO [AT_086] Saboteur && Test: Saboteur_AT_086
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_087] Argent Horserider - COST:3 [ATK:2/HP:1] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_087", null);

			// --------------------------------------- MINION - NEUTRAL
			// [AT_088] Mogor's Champion - COST:6 [ATK:8/HP:5] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: 50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - FORGETFUL = 1
			// --------------------------------------------------------
			cards.Add("AT_088", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.ATTACKING, 1)
                        .FastExecution(true)
                        .SingleTask(ComplexTask.Create(
                            new HalfHalfChanceTask(),
                            new IncludeTask(EntityType.ENEMIES, new [] {EntityType.TARGET}),
                            new RandomTask(1, EntityType.STACK),
                            new ChangeAttackingTargetTask(EntityType.TARGET, EntityType.STACK)))
                        .Build()
                }
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_089] Boneguard Lieutenant - COST:2 [ATK:3/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Gain +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_089", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = Triggers.Inspire(new BuffTask(Buffs.Health(1), EntityType.SOURCE))
                }
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_090] Mukla's Champion - COST:5 [ATK:4/HP:3] 
			// - Race: beast, Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Give your other minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_090", new List<Enchantment> {
				// TODO [AT_090] Mukla's Champion && Test: Mukla's Champion_AT_090
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_091] Tournament Medic - COST:4 [ATK:1/HP:8] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Restore 2 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_091", new List<Enchantment> {
				// TODO [AT_091] Tournament Medic && Test: Tournament Medic_AT_091
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_092] Ice Rager - COST:3 [ATK:5/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			cards.Add("AT_092", null);

            // --------------------------------------- MINION - NEUTRAL
            // [AT_093] Frigid Snobold - COST:4 [ATK:2/HP:6] 
            // - Set: tgt, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Spell Damage +1</b>
            // --------------------------------------------------------
            // GameTag:
            // - SPELLPOWER = 1
            // --------------------------------------------------------
            cards.Add("AT_093", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(1)
                },
            });

			// --------------------------------------- MINION - NEUTRAL
			// [AT_094] Flame Juggler - COST:2 [ATK:2/HP:3] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_094", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 1)
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_095] Silent Knight - COST:3 [ATK:2/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("AT_095", null);

            // --------------------------------------- MINION - NEUTRAL
            // [AT_096] Clockwork Knight - COST:5 [ATK:5/HP:5] 
            // - Race: mechanical, Set: tgt, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Give a friendly Mech +1/+1.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_FRIENDLY_TARGET = 0
            // - REQ_TARGET_WITH_RACE = 17
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("AT_096", new List<Enchantment> {
				// TODO [AT_096] Clockwork Knight && Test: Clockwork Knight_AT_096
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_097] Tournament Attendee - COST:1 [ATK:2/HP:1] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_097", null);

            // --------------------------------------- MINION - NEUTRAL
            // [AT_098] Sideshow Spelleater - COST:6 [ATK:6/HP:5] 
            // - Set: tgt, Rarity: epic
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Copy your opponent's Hero Power.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            cards.Add("AT_098", new List<Enchantment> {
				// TODO [AT_098] Sideshow Spelleater && Test: Sideshow Spelleater_AT_098
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_099] Kodorider - COST:6 [ATK:3/HP:5] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Summon a 3/5 War Kodo.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_099", new List<Enchantment> {
				// TODO [AT_099] Kodorider && Test: Kodorider_AT_099
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_100] Silver Hand Regent - COST:3 [ATK:3/HP:3] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Summon a 1/1 Silver Hand Recruit.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_100", new List<Enchantment> {
				// TODO [AT_100] Silver Hand Regent && Test: Silver Hand Regent_AT_100
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_101] Pit Fighter - COST:5 [ATK:5/HP:6] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			cards.Add("AT_101", null);

            // --------------------------------------- MINION - NEUTRAL
            // [AT_102] Captured Jormungar - COST:7 [ATK:5/HP:9] 
            // - Race: beast, Set: tgt, Rarity: common
            // --------------------------------------------------------
            cards.Add("AT_102", null);

            // --------------------------------------- MINION - NEUTRAL
            // [AT_103] North Sea Kraken - COST:9 [ATK:9/HP:7] 
            // - Set: tgt, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal 4 damage.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("AT_103", new List<Enchantment> {
				// TODO [AT_103] North Sea Kraken && Test: North Sea Kraken_AT_103
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_105] Injured Kvaldir - COST:1 [ATK:2/HP:4] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_105", new List<Enchantment> {
				// TODO [AT_105] Injured Kvaldir && Test: Injured Kvaldir_AT_105
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_106] Light's Champion - COST:3 [ATK:4/HP:3] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b> a Demon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 15
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("AT_106", new List<Enchantment> {
				// TODO [AT_106] Light's Champion && Test: Light's Champion_AT_106
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_108] Armored Warhorse - COST:4 [ATK:5/HP:3] 
			// - Race: beast, Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_108", new List<Enchantment> {
				// TODO [AT_108] Armored Warhorse && Test: Armored Warhorse_AT_108
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_109] Argent Watchman - COST:2 [ATK:2/HP:4] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: Can't attack.
			//       <b>Inspire:</b> Can attack as normal this turn.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_ATTACK = 1
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_109", new List<Enchantment> {
				// TODO [AT_109] Argent Watchman && Test: Argent Watchman_AT_109
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_110] Coliseum Manager - COST:3 [ATK:2/HP:5] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Return this minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_110", new List<Enchantment> {
				// TODO [AT_110] Coliseum Manager && Test: Coliseum Manager_AT_110
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_111] Refreshment Vendor - COST:4 [ATK:3/HP:5] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 4 Health to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_111", new List<Enchantment> {
				// TODO [AT_111] Refreshment Vendor && Test: Refreshment Vendor_AT_111
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_112] Master Jouster - COST:6 [ATK:5/HP:6] 
			// - Set: tgt, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Taunt</b> and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("AT_112", new List<Enchantment> {
				// TODO [AT_112] Master Jouster && Test: Master Jouster_AT_112
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_113] Recruiter - COST:5 [ATK:5/HP:4] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Add a 2/2 Squire to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_113", new List<Enchantment> {
				// TODO [AT_113] Recruiter && Test: Recruiter_AT_113
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_114] Evil Heckler - COST:4 [ATK:5/HP:4] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("AT_114", null);

            // --------------------------------------- MINION - NEUTRAL
            // [AT_115] Fencing Coach - COST:3 [ATK:2/HP:2] 
            // - Set: tgt, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> The next time you use your Hero Power, it costs (2) less.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // --------------------------------------------------------
            cards.Add("AT_115", new List<Enchantment> {
				// TODO [AT_115] Fencing Coach && Test: Fencing Coach_AT_115
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_117] Master of Ceremonies - COST:3 [ATK:4/HP:2] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have a minion with <b>Spell Damage</b>, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_117", new List<Enchantment> {
				// TODO [AT_117] Master of Ceremonies && Test: Master of Ceremonies_AT_117
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_118] Grand Crusader - COST:6 [ATK:5/HP:5] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Paladin card to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_118", new List<Enchantment> {
				// TODO [AT_118] Grand Crusader && Test: Grand Crusader_AT_118
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_119] Kvaldir Raider - COST:5 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Inspire:</b> Gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - INSPIRE = 1
			// --------------------------------------------------------
			cards.Add("AT_119", new List<Enchantment> {
				// TODO [AT_119] Kvaldir Raider && Test: Kvaldir Raider_AT_119
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_120] Frost Giant - COST:10 [ATK:8/HP:8] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each time you used your Hero Power this game.
			// --------------------------------------------------------
			cards.Add("AT_120", new List<Enchantment> {
				// TODO [AT_120] Frost Giant && Test: Frost Giant_AT_120
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_121] Crowd Favorite - COST:4 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you play a card with <b>Battlecry</b>, gain +1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_121", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HAND_AND_BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsNotSelf, RelaCondition.HasTargetTagValue(GameTag.BATTLECRY, 1))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new BuffTask(Buffs.AttackHealth(1), EntityType.SOURCE))
                        .Build()
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [AT_122] Gormok the Impaler - COST:4 [ATK:4/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have at least 4 other minions, deal 4 damage.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS = 4
			// --------------------------------------------------------
			cards.Add("AT_122", new List<Enchantment> {
				// TODO [AT_122] Gormok the Impaler && Test: Gormok the Impaler_AT_122
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_123] Chillmaw - COST:7 [ATK:6/HP:6] 
			// - Race: dragon, Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Deathrattle:</b> If you're holding
			//       a Dragon, deal 3 damage
			//       to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("AT_123", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
                        new FlagTask(true, new DamageTask(3, EntityType.ALLMINIONS)))
                },
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_124] Bolf Ramshield - COST:6 [ATK:3/HP:9] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever your hero takes damage, this minion takes it instead.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("AT_124", new List<Enchantment> {
				// TODO [AT_124] Bolf Ramshield && Test: Bolf Ramshield_AT_124
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_125] Icehowl - COST:9 [ATK:10/HP:10] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       Can't attack heroes.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("AT_125", new List<Enchantment> {
				new Enchantment
                {
                    Area =  EnchantmentArea.SELF,
					Activation = EnchantmentActivation.BOARD,
					Enchant = Buffs.Simple(GameTag.CANNOT_ATTACK_HEROES, 1)
				}
            });

            // --------------------------------------- MINION - NEUTRAL
            // [AT_127] Nexus-Champion Saraad - COST:5 [ATK:4/HP:5] 
            // - Set: tgt, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Inspire:</b> Add a random spell to your hand.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - INSPIRE = 1
            // --------------------------------------------------------
            cards.Add("AT_127", new List<Enchantment> {
				// TODO [AT_127] Nexus-Champion Saraad && Test: Nexus-Champion Saraad_AT_127
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_128] The Skeleton Knight - COST:6 [ATK:7/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Reveal a minion in each deck. If yours costs more, return this to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("AT_128", new List<Enchantment> {
				// TODO [AT_128] The Skeleton Knight && Test: The Skeleton Knight_AT_128
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_129] Fjola Lightbane - COST:3 [ATK:3/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever <b>you</b> target this minion with a spell, gain <b>Divine Shield.</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("AT_129", new List<Enchantment> {
				// TODO [AT_129] Fjola Lightbane && Test: Fjola Lightbane_AT_129
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_131] Eydis Darkbane - COST:3 [ATK:3/HP:4] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever <b>you</b> target this minion with a spell, deal 3 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("AT_131", new List<Enchantment> {
				// TODO [AT_131] Eydis Darkbane && Test: Eydis Darkbane_AT_131
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_132] Justicar Trueheart - COST:6 [ATK:6/HP:3] 
			// - Set: tgt, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Replace your starting Hero Power with a better one.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_132", new List<Enchantment> {
				// TODO [AT_132] Justicar Trueheart && Test: Justicar Trueheart_AT_132
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [AT_133] Gadgetzan Jouster - COST:1 [ATK:1/HP:2] 
			// - Set: tgt, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("AT_133", new List<Enchantment> {
				// TODO [AT_133] Gadgetzan Jouster && Test: Gadgetzan Jouster_AT_133
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
			// [AT_011e] Light's Blessing (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("AT_011e", null);

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_013e] Power Word: Glory (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: When this attacks, restore 4 Health to the hero of the player who buffed it.
			// --------------------------------------------------------
			cards.Add("AT_013e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_017e] Twilight's Embrace (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +1 Attack and <b>Taunt</b>.
            // --------------------------------------------------------
            cards.Add("AT_017e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_024e] Dark Fusion (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +3/+3.
            // --------------------------------------------------------
            cards.Add("AT_024e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_028e] Chi Lance (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +3 Attack.
            // --------------------------------------------------------
            cards.Add("AT_028e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_029e] Extra Stabby (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +1 Attack
            // --------------------------------------------------------
            cards.Add("AT_029e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_041e] Call of the Wild (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Cost reduced.
            // --------------------------------------------------------
            cards.Add("AT_041e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_045e] Empowering Mist (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("AT_045e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_045ee] Mistcaller Deck Ench (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            cards.Add("AT_045ee", null);
            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_065e] King's Defender (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +1 Durability.
            // --------------------------------------------------------
            cards.Add("AT_065e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_073e] Competitive Spirit (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("AT_073e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_077e] Extra Poke (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +1 Durability.
            // --------------------------------------------------------
            cards.Add("AT_077e", null);

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [AT_082e] Training (*) - COST:0 
			// - Set: tgt, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("AT_082e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_083e] Dragonhawkery (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: <b>Windfury</b> this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("AT_083e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_084e] Equipped (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +2 Attack.
            // --------------------------------------------------------
            cards.Add("AT_084e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_086e] Villainy (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Your Hero Power costs (5) more this turn.
            // --------------------------------------------------------
            cards.Add("AT_086e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_089e] Boneguarded (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Increased Health.
            // --------------------------------------------------------
            cards.Add("AT_089e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_090e] Might of the Monkey (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("AT_090e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_096e] Wound Up (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("AT_096e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_109e] Inspired (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Can attack this turn.
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("AT_109e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_115e] Fencing Practice (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Your Hero Power costs (2) less.
            // --------------------------------------------------------
            cards.Add("AT_115e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_117e] Ceremony (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("AT_117e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_119e] Inspired (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("AT_119e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_121e] Huge Ego (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("AT_121e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [AT_133e] Victory! (*) - COST:0 
            // - Set: tgt, 
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("AT_133e", null);
            // --------------------------------------- MINION - NEUTRAL
            // [AT_005t] Boar (*) - COST:3 [ATK:4/HP:2] 
            // - Race: beast, Set: tgt, 
            // --------------------------------------------------------
            // Text: <b>Charge</b>
            // --------------------------------------------------------
            // GameTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("AT_005t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [AT_099t] War Kodo (*) - COST:5 [ATK:3/HP:5] 
			// - Race: beast, Set: tgt, 
			// --------------------------------------------------------
			cards.Add("AT_099t", null);

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
