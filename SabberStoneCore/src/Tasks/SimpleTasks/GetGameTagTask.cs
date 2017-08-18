using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetGameTagTask : SimpleTask
	{
		public GetGameTagTask(GameTag tag, EntityType entityType, int entityIndex = 0, int numberIndex = 0)
		{
			Tag = tag;
			Type = entityType;
			EntityIndex = entityIndex;
			NumberIndex = numberIndex;
		}

		public GameTag Tag { get; set; }
		public EntityType Type { get; set; }
		public int EntityIndex { get; set; }
		public int NumberIndex { get; set; }

		public override TaskState Process()
		{
			System.Collections.Generic.List<Model.Entities.IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			if (entities.Count == 0)
			{
				return TaskState.STOP;
			}
			if (NumberIndex == 0)
			{
				Number = entities[EntityIndex][Tag];
			}
			else if (entities.Count > EntityIndex)
			{
				switch (NumberIndex)
				{
					case 1:
						Number1 = entities[EntityIndex][Tag];
						break;
					case 2:
						Number2 = entities[EntityIndex][Tag];
						break;
					case 3:
						Number3 = entities[EntityIndex][Tag];
						break;
					case 4:
						Number4 = entities[EntityIndex][Tag];
						break;
				}
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new GetGameTagTask(Tag, Type, EntityIndex, NumberIndex);
			clone.Copy(this);
			return clone;
		}
	}
}