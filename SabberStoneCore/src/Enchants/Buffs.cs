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
            SelfCondition.IsInZone(EZone.DECK, EZone.HAND, EZone.PLAY),
            SelfCondition.IsNotSilenced,
        };

        public static Enchant Simple(EGameTag tag, int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                EnableConditions = SelfBuffConditions,
                Effects = new Dictionary<EGameTag, int>
                {
                    [tag] = amount,
                }
            };
        }

        public static Enchant SimpleFix(EGameTag tag, int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                EnableConditions = SelfBuffConditions,
                Effects = new Dictionary<EGameTag, int>
                {
                    [tag] = 0
                },
                FixedValueFunc = owner => amount
            };
        }

        public static Enchant AttackHealth(int amount, bool oneTurnActive = false)
        {
            return AttackHealth(amount, amount, oneTurnActive);
        }

        public static Enchant AttackHealth(int atk, int health, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                EnableConditions = SelfBuffConditions,
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.ATK] = atk,
                    [EGameTag.HEALTH] = health
                },
                // Health Retention task ... 
                RemovalTask = new HealthRetentionTask(health, EEntityType.SOURCE)
            };
        }

        public static Enchant AttackHealthFix(int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                EnableConditions = SelfBuffConditions,
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.ATK] = 0,
                    [EGameTag.HEALTH] = 0
                },
                // Health Retention task ... 
                FixedValueFunc = owner => amount,
                RemovalTask = new HealthRetentionTask(amount, EEntityType.SOURCE)
            };
        }

        public static Enchant Attack(int amount)
        {
            return new Enchant
            {
                TurnsActive = -1,
                EnableConditions = SelfBuffConditions,
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.ATK] = amount
                }
            };
        }

        public static Enchant AttackTurn(int amount)
        {
            return new Enchant
            {
                TurnsActive = 0,
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.ATK] = amount
                }
            };
        }

        public static Enchant WindFuryTurn()
        {
            return new Enchant
            {
                TurnsActive = 0,
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.WINDFURY] = 1
                }
            };
        }

        public static Enchant ImmuneTurn()
        {
            return new Enchant
            {
                TurnsActive = 0,
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.IMMUNE] = 1
                }
            };
        }

        public static Enchant Health(int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                EnableConditions = SelfBuffConditions,
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.HEALTH] = amount
                },
                // Health Retention task ... 
                RemovalTask = new HealthRetentionTask(amount, EEntityType.SOURCE)
            };
        }

        public static Enchant WeaponAtk(int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.ATK] = amount
                }
            };
        }

        public static Enchant Cost(int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                EnableConditions = new List<SelfCondition> { SelfCondition.IsInZone(EZone.HAND) },
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.COST] = amount
                }
            };
        }

        public static Enchant CostFix(int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                EnableConditions = new List<SelfCondition> { SelfCondition.IsInZone(EZone.HAND, EZone.DECK)},
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.COST] = 0
                },
                FixedValueFunc = owner => amount
            };
        }

        public static Enchant StealthTurn(int attackedThisTurn)
        {
            return new Enchant
            {
                TurnsActive = 1,
                EnableConditions = new List<SelfCondition>
                {
                    SelfCondition.IsInZone(EZone.PLAY),
                    SelfCondition.IsNotAttackingThisTurn(attackedThisTurn)
                },
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.STEALTH] = 1
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
        public static Enchant CthunAttackHealth(int amount)
        {
            return new Enchant
            {
                TurnsActive = -1,
                EnableConditions = new List<SelfCondition>
                {
                    SelfCondition.IsInZone(EZone.SETASIDE, EZone.HAND, EZone.PLAY),
                    SelfCondition.IsNotSilenced,
                },
                Effects = new Dictionary<EGameTag, int>
                {
                    [EGameTag.ATK] = amount,
                    [EGameTag.HEALTH] = amount
                },
                // Health Retention task ... 
                RemovalTask = new HealthRetentionTask(amount, EEntityType.SOURCE)
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

        public static Enchant OnlyOpponentTurn(EGameTag tag, int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                EnableConditions = SelfBuffConditions,
                ApplyConditions = new List<RelaCondition> { RelaCondition.IsMe(SelfCondition.IsNotCurrentPlayer) },
                Effects = new Dictionary<EGameTag, int>
                {
                    [tag] = amount,
                }
            };
        }

        public static Enchant TillTagChangeActive(EGameTag changeTriggerTag, SelfCondition applyCondiction, EGameTag tag, int value, Func<object, int> func = null, bool oneTurnActive = false, ISimpleTask removalTask = null)
        {
            return new Enchant()
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
                Effects = new Dictionary<EGameTag, int>
                {
                    [tag] = value
                },
                FixedValueFunc = func,
                RemovalTask = removalTask
            };
        }
    }
}