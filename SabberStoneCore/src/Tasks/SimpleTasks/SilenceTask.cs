using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities.Playables;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SilenceTask : SimpleTask
    {
        public EEntityType Type { get; set; }

        public SilenceTask(EEntityType type)
        {
            Type = type;
        }
        public override ETaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                var minion = p as Minion;
                minion?.Silence();
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SilenceTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}