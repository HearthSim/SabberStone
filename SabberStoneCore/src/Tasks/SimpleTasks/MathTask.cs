using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    

    public class MathNumberIndexTask : SimpleTask
    {
        public MathNumberIndexTask(int indexA, int indexB, EMathOperation mathOperation)
        {
            IndexA = indexA;
            IndexB = indexB;
        }

        public int IndexA { get; set; }
        public int IndexB { get; set; }
        public EMathOperation MathOperation { get; set; }

        public override ETaskState Process()
        {
            var numberA = GetIndex(IndexA);
            var numberB = GetIndex(IndexB);
            switch (MathOperation)
            {
                case EMathOperation.ADD:
                    Number += numberA + numberB;
                    break;
                case EMathOperation.SUB:
                    Number -= numberA - numberB;
                    break;
                case EMathOperation.MUL:
                    Number *= numberA * numberB;
                    break;
                case EMathOperation.DIV:
                    Number /= numberA / numberB;
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"MathNumberIndexTask unknown {MathOperation}");
            }
            return ETaskState.COMPLETE;
        }

        private int GetIndex(int index)
        {
            switch (index)
            {
                case 1:
                    return Number1;
                case 2:
                    return Number2;
                case 3:
                    return Number3;
                case 4:
                    return Number4;
                default:
                    throw new ArgumentOutOfRangeException($"MathNumberIndexTask unknown {index}");
            }
        }

        public override ISimpleTask Clone()
        {
            var clone = new MathNumberIndexTask(IndexA, IndexB, MathOperation);
            clone.Copy(this);
            return clone;
        }
    }

    public class MathRandTask : SimpleTask
    {
        public MathRandTask(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public int Min { get; set; }
        public int Max { get; set; }

        public override ETaskState Process()
        {
            Number = Util.Random.Next(Min, Max + 1);
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new MathRandTask(Min, Max);
            clone.Copy(this);
            return clone;
        }
    }

    public class MathMultiplyTask : SimpleTask
    {
        public MathMultiplyTask(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public override ETaskState Process()
        {
            Number *= Amount;
            return ETaskState.COMPLETE;
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

        public override ETaskState Process()
        {
            Number += Amount;
            return ETaskState.COMPLETE;
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

        private MathSubstractionTask(int amount, EGameTag tag, EEntityType type)
        {
            Amount = amount;
            Tag = tag;
            Type = type;
        }

        public MathSubstractionTask(int amount)
        {
            Amount = amount;
        }

        public MathSubstractionTask(EGameTag tag, EEntityType type)
        {
            Tag = tag;
            Type = type;
        }

        public int Amount { get; set; } = 0;

        public EGameTag Tag { get; set; }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            if (Amount == 0)
            {
                Number -= IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).First()[Tag];
            }
            else
            {
                Number -= Amount;
            }

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new MathSubstractionTask(Amount, Tag, Type);
            clone.Copy(this);
            return clone;
        }
    }
}