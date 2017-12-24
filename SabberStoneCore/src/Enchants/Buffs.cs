using System;
using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Enchants
{
	internal class Buffs
	{
		public static readonly List<SelfCondition> SelfBuffConditions = new List<SelfCondition>
		{
			SelfCondition.IsInZone(Zone.DECK, Zone.HAND, Zone.PLAY),
			SelfCondition.IsNotSilenced,
		};

		public static OldEnchant Simple(GameTag tag, int amount, bool oneTurnActive = false)
		{
			return new OldEnchant
			{
				TurnsActive = oneTurnActive ? 0 : -1,
				EnableConditions = SelfBuffConditions,
				Effects = new Dictionary<GameTag, int>
				{
					[tag] = amount,
				}
			};
		}

		public static OldEnchant SimpleFix(GameTag tag, int amount, bool oneTurnActive = false)
		{
			return new OldEnchant
			{
				TurnsActive = oneTurnActive ? 0 : -1,
				EnableConditions = SelfBuffConditions,
				Effects = new Dictionary<GameTag, int>
				{
					[tag] = 0
				},
				FixedValueFunc = owner => amount
			};
		}

		public static OldEnchant AttackHealth(int amount, bool oneTurnActive = false)
		{
			return AttackHealth(amount, amount, oneTurnActive);
		}

		public static OldEnchant AttackHealth(int atk, int health, bool oneTurnActive = false)
		{
			return new OldEnchant
			{
				TurnsActive = oneTurnActive ? 0 : -1,
				EnableConditions = SelfBuffConditions,
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.ATK] = atk,
					[GameTag.HEALTH] = health
				},
				// Health Retention task ... 
				RemovalTask = new HealthRetentionTask(health, EntityType.SOURCE)
			};
		}

		public static OldEnchant AttackHealthFix(int amount, bool oneTurnActive = false)
		{
			return new OldEnchant
			{
				TurnsActive = oneTurnActive ? 0 : -1,
				EnableConditions = SelfBuffConditions,
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.ATK] = 0,
					[GameTag.HEALTH] = 0
				},
				// Health Retention task ... 
				FixedValueFunc = owner => amount,
				RemovalTask = new HealthRetentionTask(amount, EntityType.SOURCE)
			};
		}

		public static OldEnchant Attack(int amount)
		{
			return new OldEnchant
			{
				TurnsActive = -1,
				EnableConditions = SelfBuffConditions,
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.ATK] = amount
				}
			};
		}

		public static OldEnchant AttackTurn(int amount)
		{
			return new OldEnchant
			{
				TurnsActive = 0,
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.ATK] = amount
				}
			};
		}

		public static OldEnchant WindFuryTurn()
		{
			return new OldEnchant
			{
				TurnsActive = 0,
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.WINDFURY] = 1
				}
			};
		}

		public static OldEnchant ImmuneTurn()
		{
			return new OldEnchant
			{
				TurnsActive = 0,
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.IMMUNE] = 1
				}
			};
		}

		public static OldEnchant Health(int amount, bool oneTurnActive = false)
		{
			return new OldEnchant
			{
				TurnsActive = oneTurnActive ? 0 : -1,
				EnableConditions = SelfBuffConditions,
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.HEALTH] = amount
				},
				// Health Retention task ... 
				RemovalTask = new HealthRetentionTask(amount, EntityType.SOURCE)
			};
		}

		public static OldEnchant WeaponAtk(int amount, bool oneTurnActive = false)
		{
			return new OldEnchant
			{
				TurnsActive = oneTurnActive ? 0 : -1,
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.ATK] = amount
				}
			};
		}

		public static OldEnchant Cost(int amount, bool oneTurnActive = false)
		{
			return new OldEnchant
			{
				TurnsActive = oneTurnActive ? 0 : -1,
				EnableConditions = new List<SelfCondition> { SelfCondition.IsInZone(Zone.HAND, Zone.DECK) },
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.COST] = amount
				}
			};
		}

		public static OldEnchant CostFix(int amount, bool oneTurnActive = false)
		{
			return new OldEnchant
			{
				TurnsActive = oneTurnActive ? 0 : -1,
				EnableConditions = new List<SelfCondition> { SelfCondition.IsInZone(Zone.HAND, Zone.DECK) },
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.COST] = 0
				},
				FixedValueFunc = owner => amount
			};
		}

		public static OldEnchant StealthTurn(int attackedThisTurn)
		{
			return new OldEnchant
			{
				TurnsActive = 1,
				EnableConditions = new List<SelfCondition>
				{
					SelfCondition.IsInZone(Zone.PLAY),
					SelfCondition.IsNotAttackingThisTurn(attackedThisTurn)
				},
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.STEALTH] = 1
				}
			};
		}

		//public static Enchant Stealth()
		//{
		//    return new Enchant
		//    {
		//        TurnsActive = 1,
		//        EnableConditions = SelfBuffConditions,
		//        Effects = new Dictionary<GameTag, int>
		//        {
		//            [GameTag.STEALTH] = 1
		//        },
		//    };
		//}
		public static OldEnchant CthunAttackHealth(int amount)
		{
			return new OldEnchant
			{
				TurnsActive = -1,
				EnableConditions = new List<SelfCondition>
				{
					SelfCondition.IsInZone(Zone.SETASIDE, Zone.HAND, Zone.PLAY),
					SelfCondition.IsNotSilenced,
				},
				Effects = new Dictionary<GameTag, int>
				{
					[GameTag.ATK] = amount,
					[GameTag.HEALTH] = amount
				},
				// Health Retention task ... 
				RemovalTask = new HealthRetentionTask(amount, EntityType.SOURCE)
			};
		}

		//public static Enchant CthunAttack(int amount)
		//{
		//    return new Enchant
		//    {
		//        TurnsActive = -1,
		//        EnableConditions = new List<SelfCondition>
		//        {
		//            SelfCondition.IsInZone(Zone.SETASIDE, Zone.HAND, Zone.PLAY),
		//            SelfCondition.IsNotSilenced,
		//        },
		//        Effects = new Dictionary<GameTag, int>
		//        {
		//            [GameTag.ATK] = amount,
		//        },
		//    };
		//}

		//public static Enchant CthunHealth(int amount)
		//{
		//    return new Enchant
		//    {
		//        TurnsActive = -1,
		//        EnableConditions = new List<SelfCondition>
		//        {
		//            SelfCondition.IsInZone(Zone.SETASIDE, Zone.HAND, Zone.PLAY),
		//            SelfCondition.IsNotSilenced,
		//        },
		//        Effects = new Dictionary<GameTag, int>
		//        {
		//            [GameTag.HEALTH] = amount
		//        },
		//        // Health Retention task ... 
		//        RemovalTask = new HealthRetentionTask(amount, EntityType.SOURCE)
		//    };
		//}

		public static OldEnchant OnlyOpponentTurn(GameTag tag, int amount, bool oneTurnActive = false)
		{
			return new OldEnchant
			{
				TurnsActive = oneTurnActive ? 0 : -1,
				EnableConditions = SelfBuffConditions,
				ApplyConditions = new List<RelaCondition> { RelaCondition.IsMe(SelfCondition.IsNotCurrentPlayer) },
				Effects = new Dictionary<GameTag, int>
				{
					[tag] = amount,
				}
			};
		}

		public static OldEnchant TillTagChangeActive(GameTag changeTriggerTag, SelfCondition applyCondiction, GameTag tag, int value, Func<object, int> func = null, bool oneTurnActive = false, ISimpleTask removalTask = null)
		{
			return new OldEnchant()
			{
				TurnsActive = oneTurnActive ? 0 : -1,
				RemoveTriggerTags =
				{
					changeTriggerTag
				},
				ApplyConditions =
				{
					RelaCondition.IsOther(applyCondiction)
				},
				Effects = new Dictionary<GameTag, int>
				{
					[tag] = value
				},
				FixedValueFunc = func,
				RemovalTask = removalTask
			};
		}
	}
}
