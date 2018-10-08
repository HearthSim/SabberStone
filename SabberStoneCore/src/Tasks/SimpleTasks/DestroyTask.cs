using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DestroyTask : SimpleTask
	{
		private readonly bool _forcedDeathPhase;
		private readonly EntityType _type;

		public DestroyTask(EntityType entityType, bool forcedDeathPhase = false)
		{
			_type = entityType;
			_forcedDeathPhase = forcedDeathPhase;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			foreach (IPlayable p in IncludeTask.GetEntities(_type, in controller, source, target, stack?.Playables))
				p.Destroy();

			if (_forcedDeathPhase) game.DeathProcessingAndAuraUpdate();

			return TaskState.COMPLETE;
		}
	}
}
