using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class HealFullTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public HealFullTask(EntityType entityType)
		{
			Type = entityType;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null)
			{
				return TaskState.STOP;
			}

			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				var target = p as ICharacter;
				target?.TakeFullHeal(source);
			});

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(HealFullTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new HealFullTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}