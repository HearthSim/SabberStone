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
				Game.Log(LogLevel.INFO, BlockType.PLAY, "ControlTask", $"{Controller.Name} is taking control of {p}.");
				IPlayable removedEntity = p.Zone.Remove(p);
				removedEntity.Controller = Opposite ? Controller.Opponent : Controller;
				//removedEntity.Controller.BoardZone.Add(removedEntity);
				removedEntity.Controller.BoardZone.MoveTo(removedEntity, removedEntity.Controller.BoardZone.Count);
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
