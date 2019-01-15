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

		public override bool Process()
		{
			Controller.Game.Step = Enums.Step.MAIN_END;
			Controller.Game.MainEnd();
			return true;
		}

		public override string FullPrint()
		{
			return $"EndTurnTask => [{Controller.Name}]";
		}
	}
}
