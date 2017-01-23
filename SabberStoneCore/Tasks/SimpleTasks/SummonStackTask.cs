using SabberStoneCore.Actions;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SummonStackTask : SimpleTask
    {
        public override TaskState Process()
        {
            if (Controller.Board.IsFull)
                return TaskState.STOP;

            if (Playables.Count < 1)
            {
                return TaskState.STOP;
            }

            Playables.ForEach(p =>
            {
                // clone task here
                var task = new SummonTask(p.Card)
                {
                    Game = Controller.Game,
                    Controller = Controller,
                    Source = Source as IPlayable,
                    Target = Target as IPlayable
                };

                Controller.Game.TaskQueue.Enqueue(task);
            });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SummonStackTask();
            clone.Copy(this);
            return clone;
        }
    }
}