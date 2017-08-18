using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetNativeGameTagTask : SimpleTask
	{
		public SetNativeGameTagTask(GameTag tag, int value, EntityType entityType)
		{
			Tag = tag;
			Value = value;
			Type = entityType;
		}

		public GameTag Tag { get; set; }
		public int Value { get; set; }
		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			if (entities.Count != 1)
			{
				return TaskState.STOP;
			}

			((Entity)entities[0]).SetNativeGameTag(Tag, Value);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SetNativeGameTagTask(Tag, Value, Type);
			clone.Copy(this);
			return clone;
		}
	}
}