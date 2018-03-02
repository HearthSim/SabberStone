using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SilenceTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public SilenceTask(EntityType type)
		{
			Type = type;
		}
		public override TaskState Process()
		{
			//List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);

			//if (entities.Count > 0)
			//{
			//	entities.ForEach(p =>
			//	{
			//		var minion = p as Minion;
			//		minion.Silence();
			//	});
			//}
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				if (!(p is Minion minion))
					continue;
				minion.Silence();
			};
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SilenceTask(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
