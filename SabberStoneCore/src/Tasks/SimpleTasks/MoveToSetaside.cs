using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MoveToSetaside : SimpleTask
	{
		public MoveToSetaside(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				IPlayable removedEntity = p.Zone.Remove(p);
				Game.Log(LogLevel.INFO, BlockType.PLAY, "MoveToSetaside", !Game.Logging? "":$"{p.Controller.Name}'s {p} is moved to the setaside zone.");
				p.Controller.SetasideZone.Add(removedEntity);
			});
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new MoveToSetaside(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
