#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
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

				Minion removedEntity = (Minion) p.Zone.Remove(p);
				game.AuraUpdate();
				removedEntity.Controller = Opposite ? controller.Opponent : controller;
				removedEntity[GameTag.CONTROLLER] = removedEntity.Controller.PlayerId;
				game.Log(LogLevel.INFO, BlockType.PLAY, "ControlTask",
					!game.Logging ? "" : $"{controller.Name} is taking control of {p}.");

				removedEntity.Controller.BoardZone.Add(removedEntity);
				if (removedEntity.HasCharge)
					removedEntity.IsExhausted = false;
				else if (removedEntity.IsRush)
				{
					removedEntity.IsExhausted = false;
					removedEntity.AttackableByRush = true;
				}
			}


			return TaskState.COMPLETE;
		}
	}
}
