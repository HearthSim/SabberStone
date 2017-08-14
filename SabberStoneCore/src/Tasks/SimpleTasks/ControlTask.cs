using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ControlTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public ControlTask(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
			{
				Game.Log(LogLevel.INFO, BlockType.PLAY, "ControlTask", $"{Controller.Name} is taking control of {p}.");
				IPlayable removedEntity = p.Zone.Remove(p);
				removedEntity.Controller = Controller;
				Controller.BoardZone.Add(removedEntity);
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new ControlTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}