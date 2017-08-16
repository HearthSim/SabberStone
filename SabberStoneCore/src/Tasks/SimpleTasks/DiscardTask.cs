using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DiscardTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public DiscardTask(EntityType entityType)
		{
			Type = entityType;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<Model.Entities.IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p => Generic.DiscardBlock.Invoke(Controller, p));
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new DiscardTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}