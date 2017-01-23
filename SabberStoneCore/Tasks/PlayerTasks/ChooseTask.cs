using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.PlayerTasks
{
    public class ChooseTask : PlayerTask
    {
        public static ChooseTask Mulligan(Controller controller, List<Card> choices)
        {
            return new ChooseTask(controller, choices);
        }
        public static ChooseTask Pick(Controller controller, Card choice)
        {
            return new ChooseTask(controller, new List<Card> { choice });
        }
        private ChooseTask(Controller controller, List<Card> choices)
        {
            PlayerTaskType = PlayerTaskType.CHOOSE;
            Game = controller.Game;
            Controller = controller;
            Choices = choices;
        }

        public List<Card> Choices { get; set; }

        public override TaskState Process()
        {
            switch (Controller.Choice.ChoiceType)
            {
                case ChoiceType.MULLIGAN:
                    Generic.ChoiceMulligan.Invoke(Controller, Choices);
                    Controller.MulliganState = SabberStoneCore.Enums.Mulligan.WAITING;
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

        public override string FullPrint()
        {
            return $"ChooseTask => [{Controller.Name}] choosed {string.Join(", ", Choices.Select(p => p.ToString()).ToList())}) " +
                   $"to {(Controller.Choice?.ChoiceType == ChoiceType.MULLIGAN ? "mulligan" : "pick")}";
        }
    }
}