namespace SabberStone.Tasks.SimpleTasks
{
    public class DestroyTask : SimpleTask
    {
        public DestroyTask(EntityType entityType)
        {
            Type = entityType;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {

            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p => { p?.Destroy(); });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DestroyTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}