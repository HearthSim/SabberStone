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
	public class ReplaceHeroPower : SimpleTask
	{
		private readonly Card _heroPowerCard;

		public ReplaceHeroPower()
		{
		}

		public ReplaceHeroPower(Card heroPowerCard)
		{
			_heroPowerCard = heroPowerCard;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			if (controller == null) return TaskState.STOP;

			HeroPower power;

			if (_heroPowerCard == null)
			{
				if (stack?.Playables.Count != 1 || !(stack.Playables[0] is HeroPower)) return TaskState.STOP;

				power = (HeroPower) stack.Playables[0];
			}
			else
			{
				power = (HeroPower) Entity.FromCard(controller, _heroPowerCard);
			}

			power[GameTag.CREATOR] = controller.Hero.Id;

			game.Log(LogLevel.INFO, BlockType.PLAY, "ReplaceHeroPower",
				!game.Logging ? "" : $"{controller.Hero} power replaced by {power}");

			controller.SetasideZone.Add(controller.Hero.HeroPower);
			controller.Hero.HeroPower = power;

			return TaskState.COMPLETE;
		}
	}
}
