using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ControlTask : SimpleTask
	{
		public ControlTask(EntityType type, bool opposite = false)
		{
			Type = type;
			Opposite = opposite;
		}

		public EntityType Type { get; set; }

		public bool Opposite { get; set; }

		public override TaskState Process()
		{
			IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
			{
				if ((!Opposite && Controller.BoardZone.IsFull) || (Opposite && Controller.Opponent.BoardZone.IsFull))
				{
					p.Destroy();
					return;
				}
				IPlayable removedEntity = p.Zone.Remove(p);
				removedEntity.Controller = Opposite ? Controller.Opponent : Controller;
				removedEntity[GameTag.CONTROLLER] = removedEntity.Controller.PlayerId;
				Game.Log(LogLevel.INFO, BlockType.PLAY, "ControlTask", !Game.Logging? "":$"{Controller.Name} is taking control of {p}.");

				removedEntity.Controller.BoardZone.Add(removedEntity);
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new ControlTask(Type, Opposite);
			clone.Copy(this);
			return clone;
		}
	}
}
