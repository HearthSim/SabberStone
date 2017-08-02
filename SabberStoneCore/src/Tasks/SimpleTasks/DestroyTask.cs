using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DestroyTask : SimpleTask
    {
        public DestroyTask(EEntityType entityType)
        {
            Type = entityType;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {

            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p => { p?.Destroy(); });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DestroyTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}