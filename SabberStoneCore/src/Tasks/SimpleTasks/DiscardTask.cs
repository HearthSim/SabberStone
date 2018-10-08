using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DiscardTask : SimpleTask
	{
		public DiscardTask(EntityType entityType)
		{
			Type = entityType;
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
				Generic.DiscardBlock.Invoke(controller, p);
			return TaskState.COMPLETE;
		}
	}
}
