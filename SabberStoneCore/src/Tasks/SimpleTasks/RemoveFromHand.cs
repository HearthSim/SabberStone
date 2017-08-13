using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RemoveFromHand : SimpleTask
	{
		public EntityType Type { get; set; }

		public RemoveFromHand(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			var list = new List<IPlayable>();
			entities.ForEach(p =>
			{
				if (p.Zone.Type == Zone.HAND && Generic.RemoveFromZone.Invoke(p.Controller, p))
					list.Add(p);
			});
			Playables = list;
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new RemoveFromHand(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}