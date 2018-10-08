using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
			//if (entities.Count != 1)
			//{
			//	return TaskState.STOP;
			//}

			//((Entity)entities[0]).SetNativeGameTag(Tag, Value);

			using (IEnumerator<IPlayable> e = IncludeTask
				.GetEntities(Type, in controller, source, target, stack?.Playables).GetEnumerator())
			{
				if (e.Current != null)
					e.Current[Tag] = Value;
			}

			return TaskState.COMPLETE;
		}
	}
}
