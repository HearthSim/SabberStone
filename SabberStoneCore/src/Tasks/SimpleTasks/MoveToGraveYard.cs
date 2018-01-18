using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MoveToGraveYard : SimpleTask
	{
		public MoveToGraveYard(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				p.Controller.GraveyardZone.Add(p.Zone.Remove(p));
				if (p[GameTag.SECRET] == 1 && p[GameTag.REVEALED] == 1)
					Game.TriggerManager.OnSecretRevealedTrigger(p);
			});
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new MoveToGraveYard(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
