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
            SelfCondition.IsInHandOrPlayZone,
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
                EnableConditions = new List<SelfCondition> { SelfCondition.IsInHandZone },
                Effects = new Dictionary<GameTag, int>
                {
                    [GameTag.COST] = amount
                }
            };
        }

        public static Enchant StealthTurn(int attackedThisTurn)
        {
            return new Enchant
            {
                TurnsActive = 1,
                EnableConditions = new List<SelfCondition>
                {
                    SelfCondition.IsInPlayZone,
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
                    SelfCondition.IsInSetasideOrHandOrPlayZone,
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
