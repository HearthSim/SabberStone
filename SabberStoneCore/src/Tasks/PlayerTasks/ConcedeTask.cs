﻿#region copyright
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
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class ConcedeTask : PlayerTask
	{
		public static ConcedeTask Any(Controller controller)
		{
			return new ConcedeTask(controller);
		}
		private ConcedeTask(Controller controller)
		{
			PlayerTaskType = PlayerTaskType.CONCEDE;
			Game = controller.Game;
			Controller = controller;
		}
		public override bool Process()
		{
			Controller.PlayState = PlayState.CONCEDED;
			Controller.Game.NextStep = Step.FINAL_WRAPUP;
			return true;
		}

		public override string FullPrint()
		{
			return $"ConcedeTask => [{Controller.Name}] concedes the game!";
		}
	}
}
