using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class ChooseTask : PlayerTask
	{

		public List<int> Choices { get; set; }

		#region CONSTRUCTORS

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
			if (controller == null) throw new ArgumentNullException(nameof(controller));
			// There has to be AT LEAST 1 CHOICE.
			if (choices == null) throw new ArgumentNullException(nameof(choices));
			if (choices.Count == 0) throw new ArgumentException(nameof(choices));

			PlayerTaskType = PlayerTaskType.CHOOSE;
			Game = controller.Game;
			Controller = controller;
			Choices = choices;
		}

		#endregion


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			switch (Controller.Choice.ChoiceType)
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
					Generic.ChoicePick.Invoke(Controller, Choices[0]);
					Controller.Game.NextStep = Step.MAIN_CLEANUP;
					return TaskState.COMPLETE;

				case ChoiceType.INVALID:
					throw new NotImplementedException();
			}
			return TaskState.STOP;
		}

		protected override PlayerTask InternalClone(Game newGame)
		{
			return new ChooseTask(Controller.ClonedFrom(newGame),
									Choices.ToList()); // Shallow copy is enough
		}

		public override string FullPrint()
		{
			return $"ChooseTask => [{Controller.Name}] choosed {(Choices.Count > 0 ? String.Join(", ", Choices.Select(p => p.ToString()).ToList()) : "nothing to")} " +
				   $"to {(Controller.Choice?.ChoiceType == ChoiceType.MULLIGAN ? "keep" : "pick")}";
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}