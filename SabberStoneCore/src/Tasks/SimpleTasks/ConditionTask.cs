using System;
using System.Linq;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ConditionTask : SimpleTask
	{
		private ConditionTask(EntityType entityType,
			SelfCondition[] selfConditions,
			RelaCondition[] relaConditions)
		{
			SelfConditions = selfConditions;
			RelaConditions = relaConditions;
			Type = entityType;
		}

		public ConditionTask(EntityType entityType, params SelfCondition[] selfConditions)
		{
			SelfConditions = selfConditions;
			RelaConditions = new RelaCondition[] { };
			Type = entityType;
		}

		public ConditionTask(EntityType entityType, params RelaCondition[] relaConditions)
		{
			SelfConditions = new SelfCondition[] { };
			RelaConditions = relaConditions;
			Type = entityType;
		}

		public SelfCondition[] SelfConditions { get; set; }
		public RelaCondition[] RelaConditions { get; set; }
		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			IEnumerable<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			if (!entities.Any())
				return TaskState.STOP;

			var source = (IPlayable)Source;

			int i;
			Flag = true;
			foreach (IPlayable p in entities)
			{
				for (i = 0; i < SelfConditions.Length; i++)
					Flag = Flag && SelfConditions[i].Eval(p);

				for (i = 0; i < RelaConditions.Length; i++)
					Flag = Flag && RelaConditions[i].Eval(source, p);
			}


			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new ConditionTask(Type, SelfConditions, RelaConditions);
			clone.Copy(this);
			return clone;
		}
	}

	public class NumberConditionTask : SimpleTask
	{
		private readonly RelaSign _sign;
		private readonly int _reference;

		/// <summary>
		/// Create Task that compares the stored Number and the given reference value.
		/// </summary>
		public NumberConditionTask(int referenceValue, RelaSign sign)
		{
			_sign = sign;
			_reference = referenceValue;
		}

		/// <summary>
		/// Create Task that compares Number and Number1 in the stack.
		/// </summary>
		/// <param name="sign"></param>
		public NumberConditionTask(RelaSign sign)
		{
			_sign = sign;
			_reference = Int32.MinValue;
		}

		public override TaskState Process()
		{
			if (_reference == Int32.MinValue)
			{
				Flag =
					_sign == RelaSign.GEQ ? Number >= Number1 :
					_sign == RelaSign.LEQ ? Number <= Number1 :
					Number == Number1;

				return TaskState.COMPLETE;
			}

			Flag =
				_sign == RelaSign.GEQ ? Number >= _reference :
				_sign == RelaSign.LEQ ? Number <= _reference :
				Number == _reference;

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			return new NumberConditionTask(_reference, _sign);
		}
	}
}
