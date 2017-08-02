using SabberStoneCore.Collections;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SetHealthNumberTask : SimpleTask
    {
        public SetHealthNumberTask(EEntityType entityType)
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

                // work around health buffs
                p.Enchants.ForEach(t =>
                {
                    if (t.Effects.ContainsKey(EGameTag.HEALTH))
                    {
                        t.Effects.Remove(EGameTag.HEALTH);
                    }
                });

                target.Health = Number;
                return true;
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetHealthNumberTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}