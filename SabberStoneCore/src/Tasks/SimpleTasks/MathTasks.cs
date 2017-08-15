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
		public int IndexA { get; set; }
		public int IndexB { get; set; }
		public MathOperation MathOperation { get; set; }

		public MathNumberIndexTask(int indexA, int indexB, MathOperation mathOperation)
		{
			IndexA = indexA;
			IndexB = indexB;
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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(MathNumberIndexTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new MathNumberIndexTask(IndexA, IndexB, MathOperation);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}

	public class MathRandTask : SimpleTask
	{
		public int Min { get; set; }
		public int Max { get; set; }

		public MathRandTask(int min, int max)
		{
			Min = min;
			Max = max;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Number = Util.Random.Next(Min, Max + 1);
			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(MathRandTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new MathRandTask(Min, Max);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}

	public class MathMultiplyTask : SimpleTask
	{
		public int Amount { get; set; }

		public MathMultiplyTask(int amount)
		{
			Amount = amount;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Number *= Amount;
			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(MathMultiplyTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new MathMultiplyTask(Amount);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}

	public class MathAddTask : SimpleTask
	{
		public int Amount { get; set; }

		public MathAddTask(int amount)
		{
			Amount = amount;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Number += Amount;
			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(MathAddTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new MathAddTask(Amount);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}

	public class MathSubstractionTask : SimpleTask
	{
		public int Amount { get; set; } = 0;

		public GameTag Tag { get; set; }

		public EntityType Type { get; set; }

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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(MathSubstractionTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new MathSubstractionTask(Amount, Tag, Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}