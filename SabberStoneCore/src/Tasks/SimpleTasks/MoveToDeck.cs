using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MoveToDeck : SimpleTask
	{
		public MoveToDeck(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				if (p.Zone?.Type == Zone.DECK)
					continue;
				IPlayable removedEntity = p.Zone.Remove(p);
				removedEntity.Reset();
				if (removedEntity.Controller != Controller)
				{
					removedEntity.Controller = Controller;
					removedEntity[GameTag.CONTROLLER] = Controller.PlayerId;
				}
				Game.Log(LogLevel.INFO, BlockType.PLAY, "MoveToDeck", !Game.Logging? "":$"{Controller.Name} is taking control of {p} and shuffled into his deck.");
				Generic.ShuffleIntoDeck.Invoke(Controller, p);
			};
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new MoveToDeck(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
