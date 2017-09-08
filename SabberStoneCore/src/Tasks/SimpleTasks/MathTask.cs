using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public enum MathOperation
	{
		ADD, SUB, MUL, DIV
	}

	public class MathNumberIndexTask : SimpleTask
	{
		public MathNumberIndexTask(int indexA, int indexB, MathOperation mathOperation)
		{
			IndexA = indexA;
			IndexB = indexB;
			MathOperation = mathOperation;
		}

		public int IndexA { get; set; }
		public int IndexB { get; set; }
		public MathOperation MathOperation { get; set; }

		public override TaskState Process()
		{
			int numberA = GetIndex(IndexA);
			int numberB = GetIndex(IndexB);
			switch (MathOperation)
			{
				case MathOperation.ADD:
					Number += numberA + numberB;
					break;
				case MathOperation.SUB:
					Number -= numberA - numberB;
					break;
				case MathOperation.MUL:
					Number *= numberA * numberB;
					break;
				case MathOperation.DIV:
					Number /= numberA / numberB;
					break;
				default:
					throw new ArgumentOutOfRangeException($"MathNumberIndexTask unknown {MathOperation}");
			}
			return TaskState.COMPLETE;
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

		public override TaskState Process()
		{
			Number = Util.Random.Next(Min, Max + 1);
			return TaskState.COMPLETE;
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
