using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RevealTask : SimpleTask
    {
        public RevealTask(ISimpleTask successJoustTask, ISimpleTask failedJoustTask = null)
        {
            SuccessJoustTask = successJoustTask;
            FailedJoustTask = failedJoustTask;
        }

        public ISimpleTask SuccessJoustTask { get; set; }

        public ISimpleTask FailedJoustTask { get; set; }

        public override TaskState Process()
        {
            if (Generic.JoustBlock.Invoke(Controller))
            {
                SuccessJoustTask.Game = Game;
                SuccessJoustTask.Controller = Controller;
                SuccessJoustTask.Source = Source;
                SuccessJoustTask.Target = Target;
                SuccessJoustTask.Playables = Playables;
                SuccessJoustTask.CardIds = CardIds;
                SuccessJoustTask.Flag = Flag;
                SuccessJoustTask.Number = Number;
                return SuccessJoustTask.Process();
            }

            if (FailedJoustTask != null)
            {
                FailedJoustTask.Game = Game;
                FailedJoustTask.Controller = Controller;
                FailedJoustTask.Source = Source;
                FailedJoustTask.Target = Target;
                FailedJoustTask.Playables = Playables;
                FailedJoustTask.CardIds = CardIds;
                FailedJoustTask.Flag = Flag;
                FailedJoustTask.Number = Number;
                return FailedJoustTask.Process();
            }

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RevealTask(SuccessJoustTask, FailedJoustTask);
            clone.Copy(this);
            return clone;
        }
    }
}