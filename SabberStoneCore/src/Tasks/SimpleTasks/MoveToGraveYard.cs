﻿using SabberStoneCore.Model.Entities;
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
			//List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			//entities.ForEach(p =>
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				p.Controller.GraveyardZone.Add(p.Zone.Remove(p));
				if (p.Card.IsSecret && p[GameTag.REVEALED] == 1)
					Game.TriggerManager.OnSecretRevealedTrigger(p);
			};
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
