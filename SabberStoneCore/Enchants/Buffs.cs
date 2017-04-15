using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
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

        public static Enchant Simple(GameTag tag, int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                EnableConditions = SelfBuffConditions,
                Effects = new Dictionary<GameTag, int>
                {
                    [tag] = amount,
                }
            };
        }

        public static Enchant SimpleFix(GameTag tag, int amount, bool oneTurnActive = false)
        {
            return new Enchant
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
                Effects = new Dictionary<GameTag, int>
                {
                    [GameTag.ATK] = atk,
                    [GameTag.HEALTH] = health
                },
                // Health Retention task ... 
                RemovalTask = new HealthRetentionTask(health, EntityType.SOURCE)
            };
        }

        public static Enchant AttackHealthFix(int amount, bool oneTurnActive = false)
        {
            return new Enchant
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

        public static Enchant Attack(int amount)
        {
            return new Enchant
            {
                TurnsActive = -1,
                EnableConditions = SelfBuffConditions,
                Effects = new Dictionary<GameTag, int>
                {
                    [GameTag.ATK] = amount
                }
            };
        }

        public static Enchant AttackTurn(int amount)
        {
            return new Enchant
            {
                TurnsActive = 0,
                Effects = new Dictionary<GameTag, int>
                {
                    [GameTag.ATK] = amount
                }
            };
        }

        public static Enchant WindFuryTurn()
        {
            return new Enchant
            {
                TurnsActive = 0,
                Effects = new Dictionary<GameTag, int>
                {
                    [GameTag.WINDFURY] = 1
                }
            };
        }

        public static Enchant ImmuneTurn()
        {
            return new Enchant
            {
                TurnsActive = 0,
                Effects = new Dictionary<GameTag, int>
                {
                    [GameTag.IMMUNE] = 1
                }
            };
        }

        public static Enchant Health(int amount, bool oneTurnActive = false)
        {
            return new Enchant
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

        public static Enchant WeaponAtk(int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                Effects = new Dictionary<GameTag, int>
                {
                    [GameTag.ATK] = amount
                }
            };
        }

        public static Enchant Cost(int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                EnableConditions = new List<SelfCondition> { SelfCondition.IsInZone(Zone.HAND) },
                Effects = new Dictionary<GameTag, int>
                {
                    [GameTag.COST] = amount
                }
            };
        }

        public static Enchant CostFix(int amount, bool oneTurnActive = false)
        {
            return new Enchant
            {
                TurnsActive = oneTurnActive ? 0 : -1,
                EnableConditions = new List<SelfCondition> { SelfCondition.IsInZone(Zone.HAND, Zone.DECK)},
                Effects = new Dictionary<GameTag, int>
                {
                    [GameTag.COST] = 0
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
        public static Enchant CthunAttackHealth(int amount)
        {
            return new Enchant
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

    }
}