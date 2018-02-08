using System.Collections.Generic;
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
			//System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			//if (entities.Count != 1)
			//{
			//	return TaskState.STOP;
			//}

			//((Entity)entities[0]).SetNativeGameTag(Tag, Value);

			using(IEnumerator<IPlayable> e = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).GetEnumerator())
			{
				if (e.Current != null)
					e.Current[Tag] = Value;
			}

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
