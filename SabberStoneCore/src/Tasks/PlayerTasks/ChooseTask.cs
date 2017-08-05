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
            PlayerTaskType = EPlayerTaskType.CHOOSE;
            Game = controller.Game;
            Controller = controller;
            Choices = choices;
        }

        public List<int> Choices { get; set; }

        public override ETaskState Process()
        {
            switch (Controller.Choice.ChoiceType)
            {
                case EChoiceType.MULLIGAN:
                    Generic.ChoiceMulligan.Invoke(Controller, Choices);
                    if (Controller.Game.HistoryEnabled)
                        Controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.TRIGGER, Controller.Id, "", 7, 0));
                    Controller.MulliganState = Enums.EMulligan.DONE;
                    if (Controller.Game.HistoryEnabled)
                        Controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
                    return ETaskState.COMPLETE;

                case EChoiceType.GENERAL:
                    Generic.ChoicePick.Invoke(Controller, Choices[0]);
                    Controller.Game.NextStep = EStep.MAIN_CLEANUP;
                    return ETaskState.COMPLETE;

                case EChoiceType.INVALID:
                    throw new NotImplementedException();
            }
            return ETaskState.STOP;
        }

        public override string FullPrint()
        {
            return $"ChooseTask => [{Controller.Name}] choosed {(Choices.Count > 0 ? string.Join(", ", Choices.Select(p => p.ToString()).ToList()) : "nothing to")} " +
                   $"to {(Controller.Choice?.ChoiceType == EChoiceType.MULLIGAN ? "keep" : "pick")}";
        }
    }
}