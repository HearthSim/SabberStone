using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class HealNumberTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public HealNumberTask(EntityType entityType)
		{
			Type = entityType;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				var target = p as ICharacter;
				target?.TakeHeal(source, Number);
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new HealNumberTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}