using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DiscardTask : SimpleTask
	{
		public DiscardTask(EntityType entityType)
		{
			Type = entityType;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			System.Collections.Generic.List<Model.Entities.IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p => Generic.DiscardBlock.Invoke(Controller, p));
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new DiscardTask(Type);
			clone.Copy(this);
			return clone;
		}
	}
}