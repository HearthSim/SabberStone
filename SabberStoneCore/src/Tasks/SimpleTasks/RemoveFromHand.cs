using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
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

		public override TaskState Process()
		{
			//List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			var list = new List<IPlayable>();
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				if (p.Zone.Type == Zone.HAND && Generic.RemoveFromZone.Invoke(p.Controller, p))
					list.Add(p);
			};
			Playables = list;
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RemoveFromHand(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
