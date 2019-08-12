#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public enum MathOperation
	{
		ADD,
		SUB,
		MUL,
		DIV
	}

	public class MathNumberIndexTask : SimpleTask
	{
		private readonly int _indexA;
		private readonly int _indexB;
		private readonly MathOperation _mathOperation;
		private readonly int _resultIndex;

		public MathNumberIndexTask(int indexA, int indexB, MathOperation mathOperation, int resultIndex = 0)
		{
			_indexA = indexA;
			_indexB = indexB;
			_resultIndex = resultIndex;
			_mathOperation = mathOperation;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			int numberA = GetNumber(in _indexA, in stack);
			int numberB = GetNumber(in _indexB, in stack);
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
					stack.Number = result;
					break;
				case 1:
					stack.Number1 = result;
					break;
				case 2:
					stack.Number2 = result;
					break;
				case 3:
					stack.Number3 = result;
					break;
				case 4:
					stack.Number4 = result;
					break;
				default:
					throw new ArgumentOutOfRangeException($"MathNumberIndexTask unknown {_resultIndex}");
			}

			return TaskState.COMPLETE;
		}

		private static int GetNumber(in int index, in TaskStack stack)
		{
			switch (index)
			{
				case 0:
					return stack.Number;
				case 1:
					return stack.Number1;
				case 2:
					return stack.Number2;
				case 3:
					return stack.Number3;
				case 4:
					return stack.Number4;
				default:
					throw new ArgumentOutOfRangeException($"MathNumberIndexTask unknown {index}");
			}
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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			stack.Number = game.Random.Next(Min, Max + 1);
			return TaskState.COMPLETE;
		}
	}

	public class MathMultiplyTask : SimpleTask
	{
		public MathMultiplyTask(int amount)
		{
			Amount = amount;
		}

		public int Amount { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			stack.Number *= Amount;
			return TaskState.COMPLETE;
		}
	}

	public class MathAddTask : SimpleTask
	{
		public MathAddTask(int amount)
		{
			Amount = amount;
		}

		public int Amount { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			stack.Number += Amount;
			return TaskState.COMPLETE;
		}
	}

	public class MathSubstractionTask : SimpleTask
	{
		public MathSubstractionTask(int amount)
		{
			Amount = amount;
		}

		public MathSubstractionTask(GameTag tag, EntityType type)
		{
			Tag = tag;
			Type = type;
		}

		public int Amount { get; set; }

		public GameTag Tag { get; set; }

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			if (Amount == 0)
				stack.Number -= IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables)[0][Tag];
			else
				stack.Number -= Amount;

			return TaskState.COMPLETE;
		}
	}
}
