using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RemoveFromHand : SimpleTask
	{
		public RemoveFromHand(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
			var list = new List<IPlayable>();
			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
				if (p.Zone.Type == Zone.HAND && Generic.RemoveFromZone.Invoke(p.Controller, p))
					list.Add(p);

			if (stack != null)
				stack.Playables = list;

			return TaskState.COMPLETE;
		}
	}
}
