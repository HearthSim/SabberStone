﻿using SabberStoneCore.Enums;
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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables).ForEach(p =>
			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
			{
				if (p.Zone.Type != Zone.PLAY)
					continue; //return;

				if (!Opposite && controller.BoardZone.IsFull || Opposite && controller.Opponent.BoardZone.IsFull)
				{
					p.Destroy();
					continue; //return;
				}

				IPlayable removedEntity = p.Zone.Remove(p);
				game.AuraUpdate();
				removedEntity.Controller = Opposite ? controller.Opponent : controller;
				removedEntity[GameTag.CONTROLLER] = removedEntity.Controller.PlayerId;
				game.Log(LogLevel.INFO, BlockType.PLAY, "ControlTask",
					!game.Logging ? "" : $"{controller.Name} is taking control of {p}.");

				removedEntity.Controller.BoardZone.Add(removedEntity);
				if (removedEntity[GameTag.CHARGE] == 1)
					removedEntity.IsExhausted = false;
			}

			;

			return TaskState.COMPLETE;
		}
	}
}
