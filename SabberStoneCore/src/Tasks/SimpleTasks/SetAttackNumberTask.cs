using SabberStoneCore.Collections;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SetAttackNumberTask : SimpleTask
    {
        /// <summary>
        ///  Changes the attack attribute of the given entity.
        /// </summary>
        public SetAttackNumberTask(EEntityType entityType)
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

                // work around attack buffs
                p.Enchants.ForEach(t =>
                {
                    if (t.Effects.ContainsKey(EGameTag.ATK))
                    {
                        t.Effects.Remove(EGameTag.ATK);
                    }
                });

                target.AttackDamage = Number;
                return true;
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetAttackNumberTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}