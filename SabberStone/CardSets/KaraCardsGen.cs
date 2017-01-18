using System.Collections.Generic;
using HearthDb.Enums;
using SabberStone.Conditions;
using SabberStone.Enchants;
using SabberStone.Tasks;
using SabberStone.Tasks.SimpleTasks;

namespace SabberStone.CardSets
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
            cards.Add("KAR_075", new List<Enchantment> {
				new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new HealTask(6, EntityType.TARGET),
                        ComplexTask.SummonRandomMinion(GameTag.COST, 6))
                }
            });

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
            cards.Add("KAR_065", new List<Enchantment> {
				new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new CopyTask(EntityType.TARGET, 1),
                        new SummonTask())
                },
            });

            // ----------------------------------------- MINION - DRUID
            // [KAR_300] Enchanted Raven - COST:1 [ATK:2/HP:2] 
            // - Race: beast, Set: kara, Rarity: common
            // --------------------------------------------------------
            cards.Add("KAR_300", null);

        }

        private static void Hunter(IDictionary<string, List<Enchantment>> cards)
        {
            // ----------------------------------------- SPELL - HUNTER
            // [KAR_004] Cat Trick - COST:2 
            // - Set: kara, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Secret:</b> After your opponent casts a spell, summon a 4/2 Panther with <b>Stealth</b>.
            // --------------------------------------------------------
            // GameTag:
            // - SECRET = 1
            // --------------------------------------------------------
            // RefTag:
            // - STEALTH = 1
            // --------------------------------------------------------
            cards.Add("KAR_004", new List<Enchantment> {
				// TODO [KAR_004] Cat Trick && Test: Cat Trick_KAR_004
				new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = null,
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [KAR_005] Kindly Grandmother - COST:2 [ATK:1/HP:1] 
            // - Race: beast, Set: kara, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Summon a 3/2 Big Bad Wolf.
            // --------------------------------------------------------
            // GameTag:
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            cards.Add("KAR_005", new List<Enchantment> {
				// TODO [KAR_005] Kindly Grandmother && Test: Kindly Grandmother_KAR_005
				new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = null,
                },
            });

            // ---------------------------------------- MINION - HUNTER
            // [KAR_006] Cloaked Huntress - COST:3 [ATK:3/HP:4] 
            // - Set: kara, Rarity: common
            // --------------------------------------------------------
            // Text: Your <b>Secrets</b> cost (0).
            // --------------------------------------------------------
            // RefTag:
            // - SECRET = 1
            // --------------------------------------------------------
            cards.Add("KAR_006", new List<Enchantment> {
				new Enchantment
                {
                    Activation = EnchantmentActivation.BOARD,
                    SingleTask = new AuraTask(Auras.Cost(-99, RelaCondition.HasTargetTagValue(GameTag.SECRET, 1)), AuraArea.HAND)
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
            cards.Add("KAR_004a", new List<Enchantment> {
				// TODO [KAR_004a] Cat in a Hat && Test: Cat in a Hat_KAR_004a
				new Enchantment
                (
					//Activation = null,
					//SingleTask = null,
				)
            });

            // ---------------------------------------- MINION - HUNTER
            // [KAR_005a] Big Bad Wolf (*) - COST:2 [ATK:3/HP:2] 
            // - Race: beast, Set: kara, 
            // --------------------------------------------------------
            cards.Add("KAR_005a", new List<Enchantment> {
				// TODO [KAR_005a] Big Bad Wolf && Test: Big Bad Wolf_KAR_005a
				new Enchantment
                (
					//Activation = null,
					//SingleTask = null,
				)
            });

        }

        private static void Mage(IDictionary<string, List<Enchantment>> cards)
		{
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
			cards.Add("KAR_076", new List<Enchantment> {
				// TODO [KAR_076] Firelands Portal && Test: Firelands Portal_KAR_076
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ MINION - MAGE
			// [KAR_009] Babbling Book - COST:1 [ATK:1/HP:1] 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Mage spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_009", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new RandomCardTask(CardType.SPELL, CardClass.MAGE),
                        new CopyToHand())
				},
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
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("KAR_092", new List<Enchantment> {
				// TODO [KAR_092] Medivh's Valet && Test: Medivh's Valet_KAR_092
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
		{

		}

		private static void Paladin(IDictionary<string, List<Enchantment>> cards)
		{
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
			cards.Add("KAR_077", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new BuffTask(Buffs.AttackHealth(2), EntityType.TARGET),
                        ComplexTask.SummonRandomMinion(GameTag.COST, 2)),
				},
			});

			// --------------------------------------- MINION - PALADIN
			// [KAR_010] Nightbane Templar - COST:3 [ATK:2/HP:3] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, summon two 1/1 Whelps.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("KAR_010", new List<Enchantment> {
				// TODO [KAR_010] Nightbane Templar && Test: Nightbane Templar_KAR_010
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
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
			cards.Add("KAR_057", new List<Enchantment> {
				// TODO [KAR_057] Ivory Knight && Test: Ivory Knight_KAR_057
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
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
			cards.Add("KAR_013", new List<Enchantment> {
				// TODO [KAR_013] Purify && Test: Purify_KAR_013
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - PRIEST
			// [KAR_035] Priest of the Feast - COST:4 [ATK:3/HP:6] 
			// - Fac: neutral, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, restore 3 Health to
			//       your hero.
			// --------------------------------------------------------
			cards.Add("KAR_035", new List<Enchantment> {
				// TODO [KAR_035] Priest of the Feast && Test: Priest of the Feast_KAR_035
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("KAR_204", new List<Enchantment> {
				// TODO [KAR_204] Onyx Bishop && Test: Onyx Bishop_KAR_204
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
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
			cards.Add("KAR_069", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new RandomCardTask(EntityType.OP_HERO),
                        new CopyToHand())
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
			cards.Add("KAR_070", new List<Enchantment> {
				// TODO [KAR_070] Ethereal Peddler && Test: Ethereal Peddler_KAR_070
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
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
			cards.Add("KAR_094", new List<Enchantment> {
				// TODO [KAR_094] Deadly Fork && Test: Deadly Fork_KAR_094
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
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
			cards.Add("KAR_094a", new List<Enchantment> {
				// TODO [KAR_094a] Sharp Fork && Test: Sharp Fork_KAR_094a
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void Shaman(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - SHAMAN
			// [KAR_073] Maelstrom Portal - COST:2 
			// - Set: kara, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal_$1_damage to_all_enemy_minions. Summon_a_random
			//       1-Cost minion. *spelldmg
			// --------------------------------------------------------
			cards.Add("KAR_073", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DamageTask(1, EntityType.OP_MINIONS, true),
                        ComplexTask.SummonRandomMinion(GameTag.COST, 1)),
				},
			});

			// ---------------------------------------- MINION - SHAMAN
			// [KAR_021] Wicked Witchdoctor - COST:4 [ATK:3/HP:4] 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a random basic_Totem.
			// --------------------------------------------------------
			cards.Add("KAR_021", new List<Enchantment> {
				// TODO [KAR_021] Wicked Witchdoctor && Test: Wicked Witchdoctor_KAR_021
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("KAR_063", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.SELF,
					Activation = EnchantmentActivation.WEAPON,
					Enchant =  Auras.WeaponAttack(2, RelaCondition.IsSpellDmgOnHero)
				},
			});

		}

		private static void Warlock(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARLOCK
			// [KAR_025] Kara Kazham! - COST:5 
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Summon a 1/1 Candle, 2/2 Broom, and 3/3 Teapot.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KAR_025", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new EnqueueTask(1, new SummonTask("KAR_025a")),
                        new EnqueueTask(1, new SummonTask("KAR_025b")),
                        new EnqueueTask(1, new SummonTask("KAR_025c"))),
				},
			});

			// --------------------------------------- MINION - WARLOCK
			// [KAR_089] Malchezaar's Imp - COST:1 [ATK:1/HP:3] 
			// - Race: demon, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you discard a card, draw a card.
			// --------------------------------------------------------
			cards.Add("KAR_089", new List<Enchantment> {
				// TODO [KAR_089] Malchezaar's Imp && Test: Malchezaar's Imp_KAR_089
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("KAR_205", new List<Enchantment> {
				// TODO [KAR_205] Silverware Golem && Test: Silverware Golem_KAR_205
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("KAR_026", new List<Enchantment> {
				// TODO [KAR_026] Protect the King! && Test: Protect the King!_KAR_026
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
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
			cards.Add("KAR_091", new List<Enchantment> {
				// TODO [KAR_091] Ironforge Portal && Test: Ironforge Portal_KAR_091
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new ArmorTask(4),
                        ComplexTask.SummonRandomMinion(GameTag.COST, 4)),
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
			cards.Add("KAR_028", new List<Enchantment> {
				// TODO [KAR_028] Fool's Bane && Test: Fool's Bane_KAR_028
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
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
			cards.Add("KAR_029", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
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
			cards.Add("KAR_030a", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
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
			cards.Add("KAR_033", new List<Enchantment> {
				// TODO [KAR_033] Book Wyrm && Test: Book Wyrm_KAR_033
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_036] Arcane Anomaly - COST:1 [ATK:2/HP:1] 
			// - Fac: neutral, Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, give this minion
			//       +1 Health.
			// --------------------------------------------------------
			cards.Add("KAR_036", new List<Enchantment> {
				// TODO [KAR_036] Arcane Anomaly && Test: Arcane Anomaly_KAR_036
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("KAR_037", new List<Enchantment> {
				// TODO [KAR_037] Avian Watcher && Test: Avian Watcher_KAR_037
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
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
			cards.Add("KAR_041", new List<Enchantment> {
				// TODO [KAR_041] Moat Lurker && Test: Moat Lurker_KAR_041
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
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
			cards.Add("KAR_044", new List<Enchantment> {
				// TODO [KAR_044] Moroes && Test: Moroes_KAR_044
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("KAR_061", new List<Enchantment> {
				// TODO [KAR_061] The Curator && Test: The Curator_KAR_061
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = null
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
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("KAR_062", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new SelfConditionTask(SelfCondition.IsDragonInHand, EntityType.SOURCE),
                        new FlagTask(true, new DiscoverTask(DiscoverType.DRAGON)))
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
			cards.Add("KAR_095", new List<Enchantment> {
				// TODO [KAR_095] Zoobot && Test: Zoobot_KAR_095
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
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
			cards.Add("KAR_096", new List<Enchantment> {
				// TODO [KAR_096] Prince Malchezaar && Test: Prince Malchezaar_KAR_096
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("KAR_097", new List<Enchantment> {
				// TODO [KAR_097] Medivh, the Guardian && Test: Medivh, the Guardian_KAR_097
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
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
			cards.Add("KAR_114", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                            new IncludeTask(EntityType.DECK),
                            new FilterStackTask(SelfCondition.IsMinion),
                            new RandomTask(1, EntityType.STACK),
                            new SelfConditionTask(SelfCondition.IsNotBoardFull, EntityType.SOURCE),
                            new FlagTask(true, ComplexTask.Create(
                                new RemoveFromDeck(EntityType.STACK),
                                new SetGameTagTask(GameTag.ATK, 1, EntityType.STACK),
                                new SetGameTagTask(GameTag.HEALTH, 1, EntityType.STACK),
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
			cards.Add("KAR_702", new List<Enchantment> {
				// TODO [KAR_702] Menagerie Magician && Test: Menagerie Magician_KAR_702
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
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
			cards.Add("KAR_710", new List<Enchantment> {
				// TODO [KAR_710] Arcanosmith && Test: Arcanosmith_KAR_710
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_711] Arcane Giant - COST:12 [ATK:8/HP:8] 
			// - Set: kara, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Costs (1) less for each spell
			//       you've cast this game.
			// --------------------------------------------------------
			cards.Add("KAR_711", new List<Enchantment> {
				// TODO [KAR_711] Arcane Giant && Test: Arcane Giant_KAR_711
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("KAR_712", new List<Enchantment> {
				// TODO [KAR_712] Violet Illusionist && Test: Violet Illusionist_KAR_712
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_09] Set the Table (*) - COST:4 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Give your Plates +1/+1.
			// --------------------------------------------------------
			cards.Add("KAR_A02_09", new List<Enchantment> {
				// TODO [KAR_A02_09] Set the Table && Test: Set the Table_KAR_A02_09
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_09H] Set the Table (*) - COST:4 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Give your Plates +2/+2.
			// --------------------------------------------------------
			cards.Add("KAR_A02_09H", new List<Enchantment> {
				// TODO [KAR_A02_09H] Set the Table && Test: Set the Table_KAR_A02_09H
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_10] Pour a Round (*) - COST:3 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Draw a card for each of your Plates.
			// --------------------------------------------------------
			cards.Add("KAR_A02_10", new List<Enchantment> {
				// TODO [KAR_A02_10] Pour a Round && Test: Pour a Round_KAR_A02_10
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_11] Tossing Plates (*) - COST:5 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon five 1/1 Plates.
			// --------------------------------------------------------
			cards.Add("KAR_A02_11", new List<Enchantment> {
				// TODO [KAR_A02_11] Tossing Plates && Test: Tossing Plates_KAR_A02_11
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_03] Murloc Escaping! (*) - COST:1 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon a random Murloc.
			// --------------------------------------------------------
			cards.Add("KARA_07_03", new List<Enchantment> {
				// TODO [KARA_07_03] Murloc Escaping! && Test: Murloc Escaping!_KARA_07_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_03heroic] Murlocs Escaping! (*) - COST:1 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon two random Murlocs.
			// --------------------------------------------------------
			cards.Add("KARA_07_03heroic", new List<Enchantment> {
				// TODO [KARA_07_03heroic] Murlocs Escaping! && Test: Murlocs Escaping!_KARA_07_03heroic
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_05] Stampeding Beast! (*) - COST:3 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon a random Beast.
			// --------------------------------------------------------
			cards.Add("KARA_07_05", new List<Enchantment> {
				// TODO [KARA_07_05] Stampeding Beast! && Test: Stampeding Beast!_KARA_07_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_05heroic] Stampeding Beast! (*) - COST:2 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon a random Beast.
			// --------------------------------------------------------
			cards.Add("KARA_07_05heroic", new List<Enchantment> {
				// TODO [KARA_07_05heroic] Stampeding Beast! && Test: Stampeding Beast!_KARA_07_05heroic
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_06] Demons Loose! (*) - COST:4 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon a random Demon.
			// --------------------------------------------------------
			cards.Add("KARA_07_06", new List<Enchantment> {
				// TODO [KARA_07_06] Demons Loose! && Test: Demons Loose!_KARA_07_06
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_06heroic] Demons Loose! (*) - COST:3 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon a random Demon.
			// --------------------------------------------------------
			cards.Add("KARA_07_06heroic", new List<Enchantment> {
				// TODO [KARA_07_06heroic] Demons Loose! && Test: Demons Loose!_KARA_07_06heroic
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_07] Haywire Mech! (*) - COST:3 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon a random Mech.
			// --------------------------------------------------------
			cards.Add("KARA_07_07", new List<Enchantment> {
				// TODO [KARA_07_07] Haywire Mech! && Test: Haywire Mech!_KARA_07_07
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_07heroic] Haywire Mech! (*) - COST:3 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon a random Mech.
			// --------------------------------------------------------
			cards.Add("KARA_07_07heroic", new List<Enchantment> {
				// TODO [KARA_07_07heroic] Haywire Mech! && Test: Haywire Mech!_KARA_07_07heroic
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_08] Dragons Free! (*) - COST:6 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon a random Dragon.
			// --------------------------------------------------------
			cards.Add("KARA_07_08", new List<Enchantment> {
				// TODO [KARA_07_08] Dragons Free! && Test: Dragons Free!_KARA_07_08
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_08heroic] Dragons Free! (*) - COST:5 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon a random Dragon.
			// --------------------------------------------------------
			cards.Add("KARA_07_08heroic", new List<Enchantment> {
				// TODO [KARA_07_08heroic] Dragons Free! && Test: Dragons Free!_KARA_07_08heroic
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_08_03] Nether Breath (*) - COST:4 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: [x]Change the Health of
			//       all enemy minions to 1.
			// --------------------------------------------------------
			cards.Add("KARA_08_03", new List<Enchantment> {
				// TODO [KARA_08_03] Nether Breath && Test: Nether Breath_KARA_08_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_08_03H] Nether Breath (*) - COST:3 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: [x]Change the Health of
			//       all enemy minions to 1.
			// --------------------------------------------------------
			cards.Add("KARA_08_03H", new List<Enchantment> {
				// TODO [KARA_08_03H] Nether Breath && Test: Nether Breath_KARA_08_03H
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_08_04] Empowerment (*) - COST:2 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Give your hero +8 Attack this turn.
			// --------------------------------------------------------
			cards.Add("KARA_08_04", new List<Enchantment> {
				// TODO [KARA_08_04] Empowerment && Test: Empowerment_KARA_08_04
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_08_05] Terrifying Roar (*) - COST:3 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Return an enemy minion to your opponent's hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_05", new List<Enchantment> {
				// TODO [KARA_08_05] Terrifying Roar && Test: Terrifying Roar_KARA_08_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_08_05H] Terrifying Roar (*) - COST:2 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Return an enemy minion to your opponent's hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_05H", new List<Enchantment> {
				// TODO [KARA_08_05H] Terrifying Roar && Test: Terrifying Roar_KARA_08_05H
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_03] Many Imps! (*) - COST:2 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon 2 Icky Imps.
			// --------------------------------------------------------
			cards.Add("KARA_09_03", new List<Enchantment> {
				// TODO [KARA_09_03] Many Imps! && Test: Many Imps!_KARA_09_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_03heroic] Many Imps! (*) - COST:2 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon 2 Icky Imps.
			// --------------------------------------------------------
			cards.Add("KARA_09_03heroic", new List<Enchantment> {
				// TODO [KARA_09_03heroic] Many Imps! && Test: Many Imps!_KARA_09_03heroic
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_05] Summon Kil'rek (*) - COST:4 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon Kil'rek.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_05", new List<Enchantment> {
				// TODO [KARA_09_05] Summon Kil'rek && Test: Summon Kil'rek_KARA_09_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_05heroic] Summon Kil'rek (*) - COST:4 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Summon Kil'rek.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_05heroic", new List<Enchantment> {
				// TODO [KARA_09_05heroic] Summon Kil'rek && Test: Summon Kil'rek_KARA_09_05heroic
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_06] Shadow Volley (*) - COST:6 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Deal $3 damage to all non-Demon minions. *spelldmg
			// --------------------------------------------------------
			cards.Add("KARA_09_06", new List<Enchantment> {
				// TODO [KARA_09_06] Shadow Volley && Test: Shadow Volley_KARA_09_06
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_06heroic] Shadow Volley (*) - COST:4 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Deal $3 damage to all non-Demon minions. *spelldmg
			// --------------------------------------------------------
			cards.Add("KARA_09_06heroic", new List<Enchantment> {
				// TODO [KARA_09_06heroic] Shadow Volley && Test: Shadow Volley_KARA_09_06heroic
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_07] Steal Life (*) - COST:6 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Deal $5 damage. Restore #5 Health to your hero. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("KARA_09_07", new List<Enchantment> {
				// TODO [KARA_09_07] Steal Life && Test: Steal Life_KARA_09_07
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_07heroic] Steal Life (*) - COST:4 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Deal $5 damage. Restore #5 Health to your hero. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("KARA_09_07heroic", new List<Enchantment> {
				// TODO [KARA_09_07heroic] Steal Life && Test: Steal Life_KARA_09_07heroic
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_13_11] Shadow Bolt Volley (*) - COST:3 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Deal $4 damage to three random enemies. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("KARA_13_11", new List<Enchantment> {
				// TODO [KARA_13_11] Shadow Bolt Volley && Test: Shadow Bolt Volley_KARA_13_11
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_13_12] Demonic Presence (*) - COST:3 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Draw 2 cards.
			//       Gain 10 Armor.
			// --------------------------------------------------------
			cards.Add("KARA_13_12", new List<Enchantment> {
				// TODO [KARA_13_12] Demonic Presence && Test: Demonic Presence_KARA_13_12
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_13_12H] Demonic Presence (*) - COST:3 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			//       Gain 10 Armor.
			// --------------------------------------------------------
			cards.Add("KARA_13_12H", new List<Enchantment> {
				// TODO [KARA_13_12H] Demonic Presence && Test: Demonic Presence_KARA_13_12H
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_036e] Eating (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("KAR_036e", new List<Enchantment> {
				// TODO [KAR_036e] Eating && Test: Eating_KAR_036e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_037t] Secrets of Karazhan (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("KAR_037t", new List<Enchantment> {
				// TODO [KAR_037t] Secrets of Karazhan && Test: Secrets of Karazhan_KAR_037t
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_077e] Silver Might (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("KAR_077e", new List<Enchantment> {
				// TODO [KAR_077e] Silver Might && Test: Silver Might_KAR_077e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_095e] Well Fed (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("KAR_095e", new List<Enchantment> {
				// TODO [KAR_095e] Well Fed && Test: Well Fed_KAR_095e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

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
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("KARA_00_05e", null);

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_00_06e] Arcanely Powerful (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +5 Spell Damage.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_06e", new List<Enchantment> {
				// TODO [KARA_00_06e] Arcanely Powerful && Test: Arcanely Powerful_KARA_00_06e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_05_01e] Trembling Before the Wolf (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Shrunk to a 1/1.
			// --------------------------------------------------------
			cards.Add("KARA_05_01e", new List<Enchantment> {
				// TODO [KARA_05_01e] Trembling Before the Wolf && Test: Trembling Before the Wolf_KARA_05_01e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_06_01e] Death-Marked Love (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Julianne is <b>immune</b>.
			// --------------------------------------------------------
			cards.Add("KARA_06_01e", new List<Enchantment> {
				// TODO [KARA_06_01e] Death-Marked Love && Test: Death-Marked Love_KARA_06_01e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_07_02e] Protecting the Gallery (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			cards.Add("KARA_07_02e", new List<Enchantment> {
				// TODO [KARA_07_02e] Protecting the Gallery && Test: Protecting the Gallery_KARA_07_02e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_02e] Nether Rage (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("KARA_08_02e", new List<Enchantment> {
				// TODO [KARA_08_02e] Nether Rage && Test: Nether Rage_KARA_08_02e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_02eH] Nether Rage (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: +8 Attack.
			// --------------------------------------------------------
			cards.Add("KARA_08_02eH", new List<Enchantment> {
				// TODO [KARA_08_02eH] Nether Rage && Test: Nether Rage_KARA_08_02eH
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_03e] Nether Breath (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Health changed to 1.
			// --------------------------------------------------------
			cards.Add("KARA_08_03e", new List<Enchantment> {
				// TODO [KARA_08_03e] Nether Breath && Test: Nether Breath_KARA_08_03e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_06e2] Blue Beam (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Only take 1 damage at a time.
			// --------------------------------------------------------
			cards.Add("KARA_08_06e2", new List<Enchantment> {
				// TODO [KARA_08_06e2] Blue Beam && Test: Blue Beam_KARA_08_06e2
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_08e2] Red Beam (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Has <b>Windfury</b>.
			// --------------------------------------------------------
			cards.Add("KARA_08_08e2", new List<Enchantment> {
				// TODO [KARA_08_08e2] Red Beam && Test: Red Beam_KARA_08_08e2
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_13_11e] Enfeeble (*) - COST:0 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Health changed to 1.
			// --------------------------------------------------------
			cards.Add("KARA_13_11e", new List<Enchantment> {
				// TODO [KARA_13_11e] Enfeeble && Test: Enfeeble_KARA_13_11e
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

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

            // --------------------------------------- MINION - NEUTRAL
            // [KAR_A02_03] Fork (*) - COST:3 [ATK:3/HP:1] 
            // - Set: kara, 
            // --------------------------------------------------------
            // Text: Plates have <b>Charge</b>.
            // --------------------------------------------------------
            // GameTag:
            // - AURA = 1
            // --------------------------------------------------------
            // RefTag:
            // - CHARGE = 1
            // --------------------------------------------------------
            cards.Add("KAR_A02_03", new List<Enchantment> {
				// TODO [KAR_A02_03] Fork && Test: Fork_KAR_A02_03
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_03H] Fork (*) - COST:2 [ATK:3/HP:3] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Plates have <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_03H", new List<Enchantment> {
				// TODO [KAR_A02_03H] Fork && Test: Fork_KAR_A02_03H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_04] Knife (*) - COST:3 [ATK:5/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Plates have <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_04", new List<Enchantment> {
				// TODO [KAR_A02_04] Knife && Test: Knife_KAR_A02_04
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_04H] Knife (*) - COST:3 [ATK:5/HP:5] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Plates have <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_04H", new List<Enchantment> {
				// TODO [KAR_A02_04H] Knife && Test: Knife_KAR_A02_04H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_05] Cup (*) - COST:2 [ATK:2/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Plates have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_05", new List<Enchantment> {
				// TODO [KAR_A02_05] Cup && Test: Cup_KAR_A02_05
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_05H] Cup (*) - COST:2 [ATK:2/HP:2] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Plates have +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_05H", new List<Enchantment> {
				// TODO [KAR_A02_05H] Cup && Test: Cup_KAR_A02_05H
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_06] Pitcher (*) - COST:4 [ATK:3/HP:3] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a minion +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("KAR_A02_06", new List<Enchantment> {
				// TODO [KAR_A02_06] Pitcher && Test: Pitcher_KAR_A02_06
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_06H] Pitcher (*) - COST:4 [ATK:5/HP:5] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a minion +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("KAR_A02_06H", new List<Enchantment> {
				// TODO [KAR_A02_06H] Pitcher && Test: Pitcher_KAR_A02_06H
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_01] Black Pawn (*) - COST:1 [ATK:1/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 1 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_01", new List<Enchantment> {
				// TODO [KAR_A10_01] Black Pawn && Test: Black Pawn_KAR_A10_01
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_02] White Pawn (*) - COST:1 [ATK:1/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 1 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_02", new List<Enchantment> {
				// TODO [KAR_A10_02] White Pawn && Test: White Pawn_KAR_A10_02
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_03] Black Rook (*) - COST:3 [ATK:2/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 2 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_03", new List<Enchantment> {
				// TODO [KAR_A10_03] Black Rook && Test: Black Rook_KAR_A10_03
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_04] White Rook (*) - COST:3 [ATK:2/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 2 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_04", new List<Enchantment> {
				// TODO [KAR_A10_04] White Rook && Test: White Rook_KAR_A10_04
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_05] White Bishop (*) - COST:3 [ATK:0/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Restore 2 Health to adjacent minions.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_05", new List<Enchantment> {
				// TODO [KAR_A10_05] White Bishop && Test: White Bishop_KAR_A10_05
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_06] Black Bishop (*) - COST:3 [ATK:0/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Restore 2 Health to adjacent minions.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_06", new List<Enchantment> {
				// TODO [KAR_A10_06] Black Bishop && Test: Black Bishop_KAR_A10_06
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_07] Black Knight (*) - COST:4 [ATK:4/HP:3] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>.
			//       Can't Attack Heroes.
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_07", new List<Enchantment> {
				// TODO [KAR_A10_07] Black Knight && Test: Black Knight_KAR_A10_07
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_08] White Knight (*) - COST:4 [ATK:4/HP:3] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>.
			//       Can't Attack Heroes.
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_08", new List<Enchantment> {
				// TODO [KAR_A10_08] White Knight && Test: White Knight_KAR_A10_08
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_09] White Queen (*) - COST:7 [ATK:4/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 4 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_09", new List<Enchantment> {
				// TODO [KAR_A10_09] White Queen && Test: White Queen_KAR_A10_09
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_10] Black Queen (*) - COST:7 [ATK:4/HP:6] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 4 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_10", new List<Enchantment> {
				// TODO [KAR_A10_10] Black Queen && Test: Black Queen_KAR_A10_10
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_04_01] Dorothee (*) - COST:4 [ATK:0/HP:10] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Minions to the left have <b>Charge</b>. Minions to the right have <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KARA_04_01", new List<Enchantment> {
				// TODO [KARA_04_01] Dorothee && Test: Dorothee_KARA_04_01
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_04_05] Flying Monkey (*) - COST:3 [ATK:4/HP:2] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KARA_04_05", new List<Enchantment> {
				// TODO [KARA_04_05] Flying Monkey && Test: Flying Monkey_KARA_04_05
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_04_05h] Flying Monkey (*) - COST:3 [ATK:5/HP:2] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KARA_04_05h", new List<Enchantment> {
				// TODO [KARA_04_05h] Flying Monkey && Test: Flying Monkey_KARA_04_05h
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_06_01] Romulo (*) - COST:4 [ATK:4/HP:2] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Julianne is <b>Immune</b>.
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("KARA_06_01", new List<Enchantment> {
				// TODO [KARA_06_01] Romulo && Test: Romulo_KARA_06_01
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_06_01heroic] Romulo (*) - COST:3 [ATK:4/HP:2] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: Julianne is <b>Immune</b>.
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("KARA_06_01heroic", new List<Enchantment> {
				// TODO [KARA_06_01heroic] Romulo && Test: Romulo_KARA_06_01heroic
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_08_06] Blue Portal (*) - COST:1 [ATK:0/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: The character in the blue beam only takes 1 damage at a time.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_06", new List<Enchantment> {
				// TODO [KARA_08_06] Blue Portal && Test: Blue Portal_KARA_08_06
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_08_08] Red Portal (*) - COST:11 [ATK:0/HP:1] 
			// - Set: kara, 
			// --------------------------------------------------------
			// Text: The character in the red beam has <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_08", new List<Enchantment> {
				// TODO [KARA_08_08] Red Portal && Test: Red Portal_KARA_08_08
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_09_03a] Icky Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Resummon this minion and Illhoof loses 2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_03a", new List<Enchantment> {
				// TODO [KARA_09_03a] Icky Imp && Test: Icky Imp_KARA_09_03a
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_09_03a_heroic] Icky Imp (*) - COST:1 [ATK:2/HP:2] 
			// - Race: demon, Set: kara, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Resummon this minion and Illhoof loses 2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_03a_heroic", new List<Enchantment> {
				// TODO [KARA_09_03a_heroic] Icky Imp && Test: Icky Imp_KARA_09_03a_heroic
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

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
			cards.Add("KAR_097t", new List<Enchantment> {
				// TODO [KAR_097t] Atiesh && Test: Atiesh_KAR_097t
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [KAR_A02_02] Spoon (*) - COST:1 [ATK:1/HP:0] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("KAR_A02_02", new List<Enchantment> {
				// TODO [KAR_A02_02] Spoon && Test: Spoon_KAR_A02_02
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [KAR_A02_02H] Spoon (*) - COST:1 [ATK:3/HP:0] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("KAR_A02_02H", new List<Enchantment> {
				// TODO [KAR_A02_02H] Spoon && Test: Spoon_KAR_A02_02H
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [KARA_05_02] Big Bad Claws (*) - COST:3 [ATK:4/HP:0] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("KARA_05_02", new List<Enchantment> {
				// TODO [KARA_05_02] Big Bad Claws && Test: Big Bad Claws_KARA_05_02
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [KARA_05_02heroic] Big Bad Claws (*) - COST:2 [ATK:4/HP:0] 
			// - Set: kara, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("KARA_05_02heroic", new List<Enchantment> {
				// TODO [KARA_05_02heroic] Big Bad Claws && Test: Big Bad Claws_KARA_05_02heroic
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [KARA_13_26] Atiesh (*) - COST:3 [ATK:1/HP:0] 
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
			cards.Add("KARA_13_26", new List<Enchantment> {
				// TODO [KARA_13_26] Atiesh && Test: Atiesh_KARA_13_26
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
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
