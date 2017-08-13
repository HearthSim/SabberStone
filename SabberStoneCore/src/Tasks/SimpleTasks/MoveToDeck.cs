using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MoveToDeck : SimpleTask
	{
		public EntityType Type { get; set; }

		public MoveToDeck(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				IPlayable removedEntity = p.Zone.Remove(p);
				removedEntity.Controller = Controller;
				Game.Log(LogLevel.INFO, BlockType.PLAY, "MoveToDeck", $"{Controller.Name} is taking control of {p} and shuffled into his deck.");
				Generic.ShuffleIntoDeck.Invoke(Controller, p);
			});
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new MoveToDeck(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}