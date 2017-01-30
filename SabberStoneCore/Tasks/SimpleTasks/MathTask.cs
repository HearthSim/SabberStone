using System.Linq;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class MathMultiplyTask : SimpleTask
    {
        public MathMultiplyTask(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public override TaskState Process()
        {
            Number *= Amount;
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new MathMultiplyTask(Amount);
            clone.Copy(this);
            return clone;
        }
    }

    public class MathAddTask : SimpleTask
    {
        public MathAddTask(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public override TaskState Process()
        {
            Number += Amount;
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new MathAddTask(Amount);
            clone.Copy(this);
            return clone;
        }
    }

    public class MathSubstractionTask : SimpleTask
    {

        private MathSubstractionTask(int amount, GameTag tag, EntityType type)
        {
            Amount = amount;
            Tag = tag;
            Type = type;
        }

        public MathSubstractionTask(int amount)
        {
            Amount = amount;
        }

        public MathSubstractionTask(GameTag tag, EntityType type)
        {
            Tag = tag;
            Type = type;
        }

        public int Amount { get; set; } = 0;

        public GameTag Tag { get; set; }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            if (Amount == 0)
            {
                Number -= IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).First()[Tag];
            }
            else
            {
                Number -= Amount;
            }

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new MathSubstractionTask(Amount, Tag, Type);
            clone.Copy(this);
            return clone;
        }
    }
}