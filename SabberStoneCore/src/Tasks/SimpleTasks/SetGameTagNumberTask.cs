using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetGameTagNumberTask : SimpleTask
	{
		public GameTag Tag { get; set; }

		public EntityType Type { get; set; }

		public bool IgnoreDamage { get; set; }

		public SetGameTagNumberTask(GameTag tag, EntityType entityType, bool ignoreDamage = false)
		{
			Tag = tag;
			Type = entityType;
			IgnoreDamage = ignoreDamage;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{

			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				if (IgnoreDamage)
				{
					p.IsIgnoreDamage = true;
					p[Tag] = Number;
					p.IsIgnoreDamage = false;
				}
				else
				{
					p[Tag] = Number;
				}
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new SetGameTagNumberTask(Tag, Type, IgnoreDamage);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}