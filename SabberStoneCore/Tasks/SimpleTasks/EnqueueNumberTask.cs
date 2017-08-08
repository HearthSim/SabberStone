using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class EnqueueNumberTask : SimpleTask
    {
        public EnqueueNumberTask(ISimpleTask task, bool spellDmg = false)
        {
            Task = task;
            SpellDmg = spellDmg;
        }

        public int Amount { get; set; }
        public ISimpleTask Task { get; set; }
        public bool SpellDmg { get; set; }

        public override TaskState Process()
        {
            if (Number < 1)
            {
                return TaskState.STOP;
            }

            var times = SpellDmg ? Number + Controller.Hero.SpellPowerDamage : Number;

            for (var i = 0; i < times; i++)
            {
                // clone task here
                var clone = Task.Clone();
                clone.Game = Controller.Game;
                clone.Controller = Controller;
                clone.Source = Source as IPlayable;
                clone.Target = Target as IPlayable;

                Controller.Game.TaskQueue.Enqueue(clone);
                Controller.Game.TaskQueue.Enqueue(
                    new ClearStackTask
                    {
                        Game = Controller.Game,
                        Controller = Controller,
                        Source = Source as IPlayable,
                        Target = Target as IPlayable
                    });
            }
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new EnqueueNumberTask(Task.Clone(), SpellDmg);
            clone.Copy(this);
            return clone;
        }
    }
}