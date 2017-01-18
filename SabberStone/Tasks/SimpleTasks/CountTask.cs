namespace SabberStone.Tasks.SimpleTasks
{
    public class CountTask : SimpleTask
    {
        public CountTask(EntityType type)
        {
            Type = type;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            Number = entities.Count;
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new CountTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}