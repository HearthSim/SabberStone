using System;
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
		public MathNumberIndexTask(int indexA, int indexB, MathOperation mathOperation, int resultIndex = 0)
		{
			_indexA = indexA;
			_indexB = indexB;
			_resultIndex = resultIndex;
			_mathOperation = mathOperation;
		}

		private readonly int _indexA;
		private readonly int _indexB;
		private readonly int _resultIndex;
		private readonly MathOperation _mathOperation;

		public override TaskState Process()
		{
			int numberA = GetIndex(_indexA);
			int numberB = GetIndex(_indexB);
			int result;
			switch (_mathOperation)
			{
				case MathOperation.ADD:
					result = numberA + numberB;
					break;
				case MathOperation.SUB:
					result = numberA - numberB;
					break;
				case MathOperation.MUL:
					result = numberA * numberB;
					break;
				case MathOperation.DIV:
					result = numberA / numberB;
					break;
				default:
					throw new ArgumentOutOfRangeException($"MathNumberIndexTask unknown {_mathOperation}");
			}

			switch (_resultIndex)
			{
				case 0:
					Number = result;
					break;
				case 1:
					Number1 = result;
					break;
				case 2:
					Number2 = result;
					break;
				case 3:
					Number3 = result;
					break;
				case 4:
					Number4 = result;
					break;
				default:
					throw new ArgumentOutOfRangeException($"MathNumberIndexTask unknown {_resultIndex}");
			}

			return TaskState.COMPLETE;
		}

		private int GetIndex(int index)
		{
			switch (index)
			{
				case 0:
					return Number;
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
			var clone = new MathNumberIndexTask(_indexA, _indexB, _mathOperation, _resultIndex);
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
				Number -= IncludeTask.GetEntities(Type, Controller, Source, Target, Playables)[0][Tag];
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
