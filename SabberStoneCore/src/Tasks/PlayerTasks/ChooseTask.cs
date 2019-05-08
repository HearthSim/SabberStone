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
using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class ChooseTask : PlayerTask
	{
		public static ChooseTask Mulligan(Controller controller, List<int> choices)
		{
			return new ChooseTask(controller, choices);
		}

		public static ChooseTask Pick(Controller controller, int choice)
		{
			return new ChooseTask(controller, new List<int> { choice });
		}

		private ChooseTask(Controller controller, List<int> choices)
		{
			PlayerTaskType = PlayerTaskType.CHOOSE;
			Game = controller.Game;
			Controller = controller;
			Choices = choices ?? throw new ArgumentNullException(nameof(choices));
		}

		public List<int> Choices { get; set; }

		public override bool Process()
		{
			Choice choice = Controller.Choice;

			if (choice == null)
				return false;

			switch (choice.ChoiceType)
			{
				case ChoiceType.MULLIGAN:
					Generic.ChoiceMulligan.Invoke(Controller, Choices);
					if (Controller.Game.History)
						Controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, Controller.Id, "", 7, 0));
					Controller.MulliganState = Enums.Mulligan.DONE;
					if (Controller.Game.History)
						Controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
					return true;

				case ChoiceType.GENERAL:
					//Game.CurrentEventData =
					//	new EventMetaData(Game.IdEntityDic[choice.SourceId], Game.IdEntityDic[Choices[0]]);
					if (!Generic.ChoicePick.Invoke(Controller, Game, Choices[0])) return false;
					Controller.NumOptionsPlayedThisTurn++;
					Game.ProcessTasks();
					Game.DeathProcessingAndAuraUpdate();
					//Game.CurrentEventData = null;
					return true;

				case ChoiceType.INVALID:
					throw new NotImplementedException();
			}
			return false;
		}

		public override string FullPrint()
		{
			return $"ChooseTask => [{Controller.Name}] choosed {(Choices.Count > 0 ? String.Join(", ", Choices.Select(p => p.ToString()).ToList()) : "nothing to")} " +
				   $"to {(Controller.Choice?.ChoiceType == ChoiceType.MULLIGAN ? "keep" : "pick")}";
		}
	}
}
