using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class CountTask : SimpleTask
    {
        public CountTask(EEntityType type)
        {
            Type = type;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            Number = entities.Count;
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new CountTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}