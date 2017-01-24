using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RitualTask : SimpleTask
    {
        public RitualTask(ISimpleTask task)
        {
            Task = task;
        }

        public ISimpleTask Task { get; set; }

        public override TaskState Process()
        {

            if (!Controller.SeenCthun)
            {
                var proxyCthun = Entity.FromCard(Controller, Cards.FromId("OG_279"));
                proxyCthun[GameTag.REVEALED] = 1;
                Controller.Setaside.Add(proxyCthun);
                Controller.ProxyCthun = proxyCthun.Id;
                Controller.SeenCthun = true;
            }

            var clone = Task.Clone();
            clone.Game = Controller.Game;
            clone.Controller = Controller;
            clone.Source = Source as IPlayable;
            clone.Target = Target as IPlayable;

            Controller.Game.TaskQueue.Enqueue(clone);

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RitualTask(Task);
            clone.Copy(this);
            return clone;
        }
    }
}