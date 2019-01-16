using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RemoveFromDeck : SimpleTask
	{
		public RemoveFromDeck(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			stack.Playables = IncludeTask.GetEntities(Type, in controller, source, target, stack.Playables)
				.Where(p => p.Zone.Type == Zone.DECK && Generic.RemoveFromZone.Invoke(p.Controller, p)).ToList();
			return TaskState.COMPLETE;
		}
	}
}
