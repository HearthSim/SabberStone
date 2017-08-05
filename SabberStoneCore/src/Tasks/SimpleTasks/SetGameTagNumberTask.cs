using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SetGameTagNumberTask : SimpleTask
    {
        public SetGameTagNumberTask(EGameTag tag, EEntityType entityType, bool ignoreDamage = false)
        {
            Tag = tag;
            Type = entityType;
            IgnoreDamage = ignoreDamage;
        }

        public EGameTag Tag { get; set; }

        public EEntityType Type { get; set; }

        public bool IgnoreDamage { get; set; }

        public override ETaskState Process()
        {

            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                if (IgnoreDamage)
                {
                    p.IsIgnoringDamage = true;
                    p[Tag] = Number;
                    p.IsIgnoringDamage = false;
                }
                else
                {
                    p[Tag] = Number;
                }
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetGameTagNumberTask(Tag, Type, IgnoreDamage);
            clone.Copy(this);
            return clone;
        }
    }
}