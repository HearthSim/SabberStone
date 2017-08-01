using SabberStoneCore.Collections;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SetHealthNumberTask : SimpleTask
    {
        public SetHealthNumberTask(EntityType entityType)
        {
            Type = entityType;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
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
                    if (t.Effects.ContainsKey(GameTag.HEALTH))
                    {
                        t.Effects.Remove(GameTag.HEALTH);
                    }
                });

                target.Health = Number;
                return true;
            });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetHealthNumberTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}