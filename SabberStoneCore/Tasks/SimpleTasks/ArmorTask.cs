using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ArmorTask : SimpleTask
    {
        public ArmorTask(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public override TaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null || Amount < 1)
            {
                return TaskState.STOP;
            }
            Controller.Hero.GainArmor(source, Amount);
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ArmorTask(Amount);
            clone.Copy(this);
            return clone;
        }
    }
}