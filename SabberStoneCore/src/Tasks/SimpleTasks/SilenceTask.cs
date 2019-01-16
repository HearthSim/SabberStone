using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SilenceTask : SimpleTask
	{
		public SilenceTask(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);

			//if (entities.Count > 0)
			//{
			//	entities.ForEach(p =>
			//	{
			//		var minion = p as Minion;
			//		minion.Silence();
			//	});
			//}
			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
			{
				if (!(p is Minion minion))
					continue;
				minion.Silence();
			}

			return TaskState.COMPLETE;
		}
	}
}
