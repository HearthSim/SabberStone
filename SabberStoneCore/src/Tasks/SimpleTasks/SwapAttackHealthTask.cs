using SabberStoneCore.Collections;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities.Playables;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SwapAttackHealthTask : SimpleTask
    {
        /// <summary>
        ///  Changes the attack attribute of the given entity.
        /// </summary>
        public SwapAttackHealthTask(EEntityType entityType)
        {
            Type = entityType;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.TrueForAll(p =>
            {
                var target = p as Minion;
                if (target == null)
                {
                    return false;
                }

                int atk = p[EGameTag.ATK];
                int health = p[EGameTag.HEALTH];

                // work around attack buffs
                p.Enchants.ForEach(t =>
                {
                    if (t.Effects.ContainsKey(EGameTag.ATK))
                    {
                        t.Effects.Remove(EGameTag.ATK);
                    }

                    if (t.Effects.ContainsKey(EGameTag.HEALTH))
                    {
                        t.Effects.Remove(EGameTag.HEALTH);
                    }
                });

                target.Health = atk;
                target.AttackDamage = health;
                return true;
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SwapAttackHealthTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}