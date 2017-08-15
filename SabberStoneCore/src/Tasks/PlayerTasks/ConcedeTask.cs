using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class ConcedeTask : PlayerTask
	{
		#region CONSTRUCTORS

		public static ConcedeTask Any(Controller controller)
		{
			return new ConcedeTask(controller);
		}

		private ConcedeTask(Controller controller)
		{
			if (controller == null) throw new ArgumentNullException(nameof(controller));

			PlayerTaskType = PlayerTaskType.CONCEDE;
			Game = controller.Game;
			Controller = controller;
		}

		#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Controller.PlayState = PlayState.CONCEDED;
			Controller.Game.NextStep = Step.FINAL_WRAPUP;
			return TaskState.COMPLETE;
		}

		protected override PlayerTask InternalClone(Game newGame)
		{
			return new ConcedeTask(Controller.ClonedFrom(newGame));
		}

		public override string FullPrint()
		{
			return $"ConcedeTask => [{Controller.Name}] concedes the game!";
		}

		#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}