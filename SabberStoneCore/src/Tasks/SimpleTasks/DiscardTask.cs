using SabberStoneCore.Actions;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DiscardTask : SimpleTask
    {
        public DiscardTask(EEntityType entityType)
        {
            Type = entityType;
        }

        public EEntityType Type { get; set; }

    public override ETaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p => Generic.DiscardBlock.Invoke(Controller, p));
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DiscardTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}