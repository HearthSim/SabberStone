using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetNativeGameTagTask : SimpleTask
	{
		public GameTag Tag { get; set; }
		public EntityType Type { get; set; }
		public bool SelfBuffs { get; set; }

		public GetNativeGameTagTask(GameTag tag, EntityType entityType, bool selfBuffs)
		{
			Tag = tag;
			Type = entityType;
			SelfBuffs = selfBuffs;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			if (entities.Count != 1)
			{
				return TaskState.STOP;
			}

			Number = ((Entity)entities[0]).GetNativeGameTag(Tag);

			if (SelfBuffs)
			{
				entities[0].Enchants.ForEach(p => Number = p.Apply((Entity)entities[0], Tag, Number));
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new GetNativeGameTagTask(Tag, Type, SelfBuffs);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}