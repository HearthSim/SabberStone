using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{

	public class RemoveFromDeck : SimpleTask
	{
		public RemoveFromDeck(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			Playables = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Where(p => p.Zone.Type == Zone.DECK && Generic.RemoveFromZone.Invoke(p.Controller, p)).ToList();
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RemoveFromDeck(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
