using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Standard
{
	/// <summary>
	/// Core cardset.
	/// </summary>
	public class DebugCardsGen
	{
		private static void Heroes(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- HERO - WARRIOR
			// [HERO_01] Garrosh Hellscream - COST:0 [ATK:0/HP:30]
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 725
			// --------------------------------------------------------
			cards.Add("HERO_01", null);

			// ------------------------------------------ HERO - SHAMAN
			// [HERO_02] Thrall - COST:0 [ATK:0/HP:30]
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 687
			// --------------------------------------------------------
			cards.Add("HERO_02", null);

			// ------------------------------------------- HERO - ROGUE
			// [HERO_03] Valeera Sanguinar - COST:0 [ATK:0/HP:30]
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 730
			// --------------------------------------------------------
			cards.Add("HERO_03", null);

			// ----------------------------------------- HERO - PALADIN
			// [HERO_04] Uther Lightbringer - COST:0 [ATK:0/HP:30]
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 472
			// --------------------------------------------------------
			cards.Add("HERO_04", null);

			// ------------------------------------------ HERO - HUNTER
			// [HERO_05] Rexxar - COST:0 [ATK:0/HP:30]
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("HERO_05", null);

			// ------------------------------------------- HERO - DRUID
			// [HERO_06] Malfurion Stormrage - COST:0 [ATK:0/HP:30]
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 1123
			// --------------------------------------------------------
			cards.Add("HERO_06", null);

			// ----------------------------------------- HERO - WARLOCK
			// [HERO_07] Gul'dan - COST:0 [ATK:0/HP:30]
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 300
			// --------------------------------------------------------
			cards.Add("HERO_07", null);

			// -------------------------------------------- HERO - MAGE
			// [HERO_08] Jaina Proudmoore - COST:0 [ATK:0/HP:30]
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 807
			// --------------------------------------------------------
			cards.Add("HERO_08", null);

			// ------------------------------------------ HERO - PRIEST
			// [HERO_09] Anduin Wrynn - COST:0 [ATK:0/HP:30]
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 479
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
			cards.Add("CS1h_001", new List<Enchantment>
			{
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
			cards.Add("CS2_017", new List<Enchantment>
			{
				new Enchantment
				{
					InfoCardId = "CS2_017o",
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
			//       Deal $1 damage.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_034", new List<Enchantment>
			{
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
			cards.Add("CS2_049", new List<Enchantment>
			{
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
			//       Draw a card and take $2 damage.
			// --------------------------------------------------------
			cards.Add("CS2_056", new List<Enchantment>
			{
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
			cards.Add("CS2_083b", new List<Enchantment>
			{
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new WeaponTask("CS2_082")
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
			cards.Add("CS2_101", new List<Enchantment>
			{
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new SummonTask("CS2_101t", SummonSide.DEFAULT)
				}
			});

			// ----------------------------------- HERO_POWER - WARRIOR
			// [CS2_102] Armor Up! (*) - COST:2
			// - Fac: neutral, Set: core, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 2 Armor.
			// --------------------------------------------------------
			cards.Add("CS2_102", new List<Enchantment>
			{
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
			//       Deal $2 damage to the enemy hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_STEADY_SHOT = 0
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("DS1h_292", new List<Enchantment>
			{
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DamageTask(2, EntityType.OP_HERO, false)
				}
			});
		}

		private static void DebugCards(IDictionary<string, List<Enchantment>> cards)
		{
			cards.Add("LOEA04_31b", new List<Enchantment>
			{
				// TODO [LOEA04_31b] No Way! && Test: No Way!_LOEA04_31b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});
		}

	}
}
