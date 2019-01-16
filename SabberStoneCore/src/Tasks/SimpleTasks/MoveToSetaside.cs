using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MoveToSetaside : SimpleTask
	{
		public MoveToSetaside(EntityType type)
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
				IPlayable removedEntity = p.Zone.Remove(p);
				game.Log(LogLevel.INFO, BlockType.PLAY, "MoveToSetaside",
					!game.Logging ? "" : $"{p.Controller.Name}'s {p} is moved to the setaside zone.");
				p.Controller.SetasideZone.Add(removedEntity);
			}
			return TaskState.COMPLETE;
		}
	}
}
