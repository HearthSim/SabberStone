using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class HealNumberTask : SimpleTask
    {
        public HealNumberTask(EntityType entityType)
        {
            Type = entityType;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            var source = Source as IPlayable;
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                var target = p as ICharacter;
                target?.TakeHeal(source, Number);
            });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HealNumberTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}