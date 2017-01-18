using System;
using SabberStone.Model;

namespace SabberStone.Tasks.PlayerTasks
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
            Controller.Game.EndTurnPlayer();
            throw new NotImplementedException();
        }
    }
}