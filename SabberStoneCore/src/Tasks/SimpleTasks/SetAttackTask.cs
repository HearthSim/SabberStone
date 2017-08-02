using SabberStoneCore.Collections;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SetAttackTask : SimpleTask
    {
        /// <summary>
        ///  Changes the attack attribute of the given entity.
        /// </summary>
        public SetAttackTask(int amount, EEntityType entityType)
        {
            Amount = amount;
            Type = entityType;
        }

        public EEntityType Type { get; set; }

        public int Amount { get; set; }

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

                // work around attack buffs
                p.Enchants.ForEach(t =>
                {
                    if (t.Effects.ContainsKey(EGameTag.ATK))
                    {
                        t.Effects.Remove(EGameTag.ATK);
                    }
                });

                target.AttackDamage = Amount;
                return true;
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetAttackTask(Amount, Type);
            clone.Copy(this);
            return clone;
        }
    }
}