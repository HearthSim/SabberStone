using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
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

		public override TaskState Process()
		{
			var list = new List<IPlayable>();
			//List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);

			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				if (p.Zone.Type == Zone.DECK && Generic.RemoveFromZone.Invoke(p.Controller, p))
					list.Add(p);
			};
			Playables = list;
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
