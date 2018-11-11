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
		public override TaskState Process()
		{
			Controller.PlayState = PlayState.CONCEDED;
			Controller.Game.NextStep = Step.FINAL_WRAPUP;
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"ConcedeTask => [{Controller.Name}] concedes the game!";
		}
	}
}
