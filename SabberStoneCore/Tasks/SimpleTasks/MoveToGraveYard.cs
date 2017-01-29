namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class MoveToGraveYard : SimpleTask
    {
        public MoveToGraveYard(EntityType type)
        {
            Type = type;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p => p.Controller.Graveyard.Add(p.Zone.Remove(p)));
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new MoveToGraveYard(Type);
            clone.Copy(this);
            return clone;
        }
    }
}