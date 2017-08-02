using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SummonCopyTask : SimpleTask
    {
        public SummonCopyTask(EEntityType type)
        {
            Type = type;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            if (Controller.Board.IsFull)
                return ETaskState.STOP;

            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

            if (entities.Count < 1)
            {
                return ETaskState.STOP;
            }

            entities.ForEach(p =>
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

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SummonCopyTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}