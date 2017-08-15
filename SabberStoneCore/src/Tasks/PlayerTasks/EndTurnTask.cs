using System;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class EndTurnTask : PlayerTask
	{
		#region CONSTRUCTORS

		public static EndTurnTask Any(Controller controller)
		{
			return new EndTurnTask(controller);
		}

		private EndTurnTask(Controller controller)
		{
			if (controller == null) throw new ArgumentNullException(nameof(controller));

			PlayerTaskType = PlayerTaskType.END_TURN;
			Game = controller.Game;
			Controller = controller;
		}

		#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Controller.Game.MainEnd();
			return TaskState.COMPLETE;
		}

		protected override PlayerTask InternalClone(Game newGame)
		{
			return new EndTurnTask(Controller.ClonedFrom(newGame));
		}

		public override string FullPrint()
		{
			return $"EndTurnTask => [{Controller.Name}]";
		}

		#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}