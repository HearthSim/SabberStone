using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetNativeGameTagTask : SimpleTask
	{
		public GameTag Tag { get; set; }
		public int Value { get; set; }
		public EntityType Type { get; set; }

		public SetNativeGameTagTask(GameTag tag, int value, EntityType entityType)
		{
			Tag = tag;
			Value = value;
			Type = entityType;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			if (entities.Count != 1)
			{
				return TaskState.STOP;
			}

			((Entity)entities[0]).SetNativeGameTag(Tag, Value);

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(SetNativeGameTagTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new SetNativeGameTagTask(Tag, Value, Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}