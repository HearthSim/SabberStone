using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetGameTagTask : SimpleTask
	{
		public GameTag Tag { get; set; }
		public EntityType Type { get; set; }
		public int EntityIndex { get; set; }
		public int NumberIndex { get; set; }

		public GetGameTagTask(GameTag tag, EntityType entityType, int entityIndex = 0, int numberIndex = 0)
		{
			Tag = tag;
			Type = entityType;
			EntityIndex = entityIndex;
			NumberIndex = numberIndex;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
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

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(GetGameTagTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new GetGameTagTask(Tag, Type, EntityIndex, NumberIndex);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}