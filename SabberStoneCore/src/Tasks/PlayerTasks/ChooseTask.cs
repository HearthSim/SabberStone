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
		public static ChooseTask Mulligan(in Controller controller, in List<int> choices)
		{
			return new ChooseTask(in controller, in choices);
		}

		public static ChooseTask Pick(in Controller controller, in int choice)
		{
			return new ChooseTask(in controller, new List<int> { choice });
		}

		private ChooseTask(in Controller controller, in List<int> choices)
		{
			PlayerTaskType = PlayerTaskType.CHOOSE;
			Game = controller.Game;
			Controller = controller;
			Choices = choices ?? throw new ArgumentNullException(nameof(choices));
		}

		public List<int> Choices { get; set; }

		public override TaskState Process()
		{
			Choice choice = Controller.Choice;

			if (choice == null)
				return TaskState.STOP;

			switch (choice.ChoiceType)
			{
				case ChoiceType.MULLIGAN:
					Generic.ChoiceMulligan.Invoke(Controller, Choices);
					if (Controller.Game.History)
						Controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, Controller.Id, "", 7, 0));
					Controller.MulliganState = Enums.Mulligan.DONE;
					if (Controller.Game.History)
						Controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
					return TaskState.COMPLETE;

				case ChoiceType.GENERAL:
					if (!Generic.ChoicePick.Invoke(Controller, Choices[0])) return TaskState.STOP;
					Controller.NumOptionsPlayedThisTurn++;
					Game.ProcessTasks();
					Game.DeathProcessingAndAuraUpdate();
					return TaskState.COMPLETE;

				case ChoiceType.INVALID:
					throw new NotImplementedException();
			}
			return TaskState.STOP;
		}

		public override string FullPrint()
		{
			return $"ChooseTask => [{Controller.Name}] choosed {(Choices.Count > 0 ? String.Join(", ", Choices.Select(p => p.ToString()).ToList()) : "nothing to")} " +
				   $"to {(Controller.Choice?.ChoiceType == ChoiceType.MULLIGAN ? "keep" : "pick")}";
		}
	}
}
