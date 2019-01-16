using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MoveToGraveYard : SimpleTask
	{
		public MoveToGraveYard(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
			//entities.ForEach(p =>
			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
			{
				p.Controller.GraveyardZone.Add(p.Zone.Remove(p));
				if (p.Card.IsSecret && p[GameTag.REVEALED] == 1)
					game.TriggerManager.OnSecretRevealedTrigger(p);
			}
			return TaskState.COMPLETE;
		}
	}
}
