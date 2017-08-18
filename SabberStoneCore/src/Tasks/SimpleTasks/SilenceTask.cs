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
			System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				var minion = p as Minion;
				minion?.Silence();
			});

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