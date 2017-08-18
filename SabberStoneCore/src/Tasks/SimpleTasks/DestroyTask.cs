namespace SabberStoneCore.Tasks.SimpleTasks
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

			System.Collections.Generic.List<Model.Entities.IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
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