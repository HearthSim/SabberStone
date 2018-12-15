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
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class EndTurnTask : PlayerTask
	{
		public static EndTurnTask Any(Controller controller)
		{
			return new EndTurnTask(controller);
		}

		private EndTurnTask(Controller controller)
		{
			PlayerTaskType = PlayerTaskType.END_TURN;
			Game = controller.Game;
			Controller = controller;
		}

		public override IEntity Source => null;

		public override TaskState Process()
		{
			Controller.Game.Step = Enums.Step.MAIN_END;
			Controller.Game.MainEnd();
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"EndTurnTask => [{Controller.Name}]";
		}
	}
}
