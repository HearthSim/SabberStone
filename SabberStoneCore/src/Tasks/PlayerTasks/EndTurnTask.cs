using SabberStoneCore.Enums;
using SabberStoneCore.Model;

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
            PlayerTaskType = EPlayerTaskType.END_TURN;
            Game = controller.Game;
            Controller = controller;
        }

        public override ETaskState Process()
        {
            Controller.Game.MainEnd();
            return ETaskState.COMPLETE;
        }

        public override string FullPrint()
        {
            return $"EndTurnTask => [{Controller.Name}]";
        }
    }
}