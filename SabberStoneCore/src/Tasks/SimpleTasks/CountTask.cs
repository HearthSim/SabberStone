using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CountTask : SimpleTask
	{
		public CountTask(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<Model.Entities.IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			Number = entities.Count;
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new CountTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}