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
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Triggers
{
	public class TriggerBuilder
	{
		public class TriggerTaskBuilder
		{
			private readonly TriggerBuilder _triggerBuilder;

			internal TriggerTaskBuilder(TriggerBuilder tBuilder)
			{
				_triggerBuilder = tBuilder;
			}

			public TriggerBuilder SetTask(ISimpleTask task)
			{
				_triggerBuilder._trigger.SingleTask = task;
				return _triggerBuilder;
			}

			public TriggerBuilder SetSecretTasks(params ISimpleTask[] tasks)
			{
				_triggerBuilder._trigger.SingleTask = ComplexTask.Secret(tasks);
				return _triggerBuilder;
			}
		}

		private readonly Trigger _trigger;

		private TriggerBuilder(TriggerType type)
		{
			_trigger = new Trigger(type);
		}

		public static TriggerTaskBuilder Type(TriggerType type)
		{
			return new TriggerTaskBuilder(new TriggerBuilder(type));
		}

		public TriggerBuilder SetActivation(TriggerActivation activation)
		{
			_trigger.TriggerActivation = activation;
			return this;
		}

		public TriggerBuilder SetSource(TriggerSource source)
		{
			_trigger.TriggerSource = source;
			return this;
		}

		public TriggerBuilder SetCondition(SelfCondition condition)
		{
			_trigger.Condition = condition;
			return this;
		}

		public TriggerBuilder SetEitherTurn()
		{
			_trigger.EitherTurn = true;
			return this;
		}

		public TriggerBuilder SetFastExecution()
		{
			_trigger.FastExecution = true;
			return this;
		}

		public TriggerBuilder SetRemoveAfterTriggered()
		{
			_trigger.RemoveAfterTriggered = true;
			return this;
		}

		public Trigger GetTrigger() => _trigger;

		public static implicit operator Trigger(TriggerBuilder builder)
		{
			return builder.GetTrigger();
		}
	}


}
