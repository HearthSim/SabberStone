using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
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
            PlayerTaskType = EPlayerTaskType.CONCEDE;
            Game = controller.Game;
            Controller = controller;
        }
        public override ETaskState Process()
        {
            Controller.PlayState = EPlayState.CONCEDED;
            Controller.Game.NextStep = EStep.FINAL_WRAPUP;
            return ETaskState.COMPLETE;
        }

        public override string FullPrint()
        {
            return $"ConcedeTask => [{Controller.Name}] concedes the game!";
        }
    }
}