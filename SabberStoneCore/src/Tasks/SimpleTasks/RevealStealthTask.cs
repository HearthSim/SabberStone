using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	/// <summary>
	///     Reveals the target(s), effectively removing their stealth attribute.
	/// </summary>
	public class RevealStealthTask : SimpleTask
	{
		public RevealStealthTask(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
			//entities.ForEach(p =>
			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
			{
				if (!(p is Minion minion))
					continue;
				minion.HasStealth = false;
			}

			;

			return TaskState.COMPLETE;
		}
	}
}
