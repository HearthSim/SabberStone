#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
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

		public override TaskState Process()
		{
			//IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).ForEach(p =>
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				if (p.Zone.Type != Zone.PLAY)
					continue;//return;

				if ((!Opposite && Controller.BoardZone.IsFull) || (Opposite && Controller.Opponent.BoardZone.IsFull))
				{
					p.Destroy();
					continue;//return;
				}
				IPlayable removedEntity = p.Zone.Remove(p);
				Game.AuraUpdate();
				removedEntity.Controller = Opposite ? Controller.Opponent : Controller;
				removedEntity[GameTag.CONTROLLER] = removedEntity.Controller.PlayerId;
				Game.Log(LogLevel.INFO, BlockType.PLAY, "ControlTask", !Game.Logging? "":$"{Controller.Name} is taking control of {p}.");

				removedEntity.Controller.BoardZone.Add(removedEntity);
			};

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
