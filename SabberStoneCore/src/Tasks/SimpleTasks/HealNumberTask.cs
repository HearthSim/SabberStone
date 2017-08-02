using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class HealNumberTask : SimpleTask
    {
        public HealNumberTask(EEntityType entityType)
        {
            Type = entityType;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var source = Source as IPlayable;
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                var target = p as ICharacter;
                target?.TakeHeal(source, Number);
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HealNumberTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}