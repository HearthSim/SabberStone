using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MoveToDeck : SimpleTask
	{
		private readonly EntityType _type;
		private readonly bool _opponent;

		public MoveToDeck(EntityType type, bool opponent = false)
		{
			_type = type;
			_opponent = opponent;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var c = _opponent ? controller.Opponent : controller;

			foreach (IPlayable p in IncludeTask.GetEntities(in _type, in controller, source, target, stack?.Playables))
			{
				if (p.Zone?.Type == Zone.DECK)
					continue;
				IPlayable removedEntity = p.Zone.Remove(p);
				removedEntity.Reset();
				if (removedEntity.Controller != c)
				{
					removedEntity.Controller = c;
					removedEntity[GameTag.CONTROLLER] = c.PlayerId;
				}

				game.Log(LogLevel.INFO, BlockType.PLAY, "MoveToDeck",
					!game.Logging ? "" : $"{controller.Name} is taking control of {p} and shuffled into his deck.");
				Generic.ShuffleIntoDeck.Invoke(c, p);
			}

			;
			return TaskState.COMPLETE;
		}
	}
}
