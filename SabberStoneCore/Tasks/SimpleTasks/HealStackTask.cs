using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class HealStackTask : SimpleTask
    {
        public HealStackTask(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public override TaskState Process()
        {
            var source = Source as IPlayable;
            if ((source == null) || (Amount < 1))
            {
                return TaskState.STOP;
            }

            Playables.ForEach(p =>
            {
                var target = p as ICharacter;
                target?.TakeHeal(source, Amount);
            });
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HealStackTask(Amount);
            clone.Copy(this);
            return clone;
        }
    }
}