using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class EnqueueTask : SimpleTask
    {
        public EnqueueTask(int amount, ISimpleTask task, bool spellDmg = false)
        {
            Amount = amount;
            Task = task;
            SpellDmg = spellDmg;
        }

        public int Amount { get; set; }
        public ISimpleTask Task { get; set; }
        public bool SpellDmg { get; set; }

        public override TaskState Process()
        {
            var times = SpellDmg ? Amount + Controller.Hero.SpellPower : Amount;
            var tasks = new StateTaskList<ISimpleTask>();

            tasks.Copy(this);

            for (var i = 0; i < times; i++)
            {
                // clone task here
                var clone = Task.Clone();
                clone.Game = Controller.Game;
                clone.Controller = Controller;
                clone.Source = Source as IPlayable;
                clone.Target = Target as IPlayable;

                Controller.Game.TaskQueue.Enqueue(clone);
            }
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new EnqueueTask(Amount, Task, SpellDmg);
            clone.Copy(this);
            return clone;
        }
    }
}