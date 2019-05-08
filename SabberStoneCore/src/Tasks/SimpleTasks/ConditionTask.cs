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
using System.Collections.Generic;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			IList<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
			if (entities.Count == 0)
				return TaskState.STOP;

			var playableSource = (IPlayable) source;

			bool flag = true;
			foreach (IPlayable p in entities)
			{
				int i;
				for (i = 0; i < SelfConditions.Length; i++)
					flag = flag && SelfConditions[i].Eval(p);

				for (i = 0; i < RelaConditions.Length; i++)
					flag = flag && RelaConditions[i].Eval(playableSource, p);
			}

			stack.Flag = flag;

			return TaskState.COMPLETE;
		}
	}

	public class NumberConditionTask : SimpleTask
	{
		private readonly int _reference;
		private readonly RelaSign _sign;

		/// <summary>
		///     Create Task that compares the stored stack.Number and the given reference value.
		/// </summary>
		public NumberConditionTask(int referenceValue, RelaSign sign)
		{
			_sign = sign;
			_reference = referenceValue;
		}

		/// <summary>
		///     Create Task that compares stack.Number and stack.Number1 in the stack.
		/// </summary>
		/// <param name="sign"></param>
		public NumberConditionTask(RelaSign sign)
		{
			_sign = sign;
			_reference = Int32.MinValue;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			if (_reference == Int32.MinValue)
			{
				stack.Flag =
					_sign == RelaSign.GEQ ? stack.Number >= stack.Number1 :
					_sign == RelaSign.LEQ ? stack.Number <= stack.Number1 :
					stack.Number == stack.Number1;

				return TaskState.COMPLETE;
			}

			stack.Flag =
				_sign == RelaSign.GEQ ? stack.Number >= _reference :
				_sign == RelaSign.LEQ ? stack.Number <= _reference :
				stack.Number == _reference;

			return TaskState.COMPLETE;
		}
	}
}
