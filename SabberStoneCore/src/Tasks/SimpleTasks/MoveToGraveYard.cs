using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class MoveToGraveYard : SimpleTask
    {
        public MoveToGraveYard(EEntityType type)
        {
            Type = type;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p => p.Controller.Graveyard.Add(p.Zone.Remove(p)));
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new MoveToGraveYard(Type);
            clone.Copy(this);
            return clone;
        }
    }
}