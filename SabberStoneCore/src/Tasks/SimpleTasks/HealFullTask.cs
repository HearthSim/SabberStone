using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class HealFullTask : SimpleTask
    {
        public HealFullTask(EEntityType entityType)
        {
            Type = entityType;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null)
            {
                return ETaskState.STOP;
            }

            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                var target = p as ICharacter;
                target?.TakeFullHeal(source);
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HealFullTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}