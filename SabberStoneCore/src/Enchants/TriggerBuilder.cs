using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Enchants
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

		public static void Test()
		{
			Trigger trigger = TriggerBuilder
				.Type(TriggerType.AFTER_ATTACK)
				.SetTask(new DamageTask(1, EntityType.TARGET))
				.SetActivation(TriggerActivation.PLAY)
				.SetSource(TriggerSource.ALL)
				.GetTrigger();

			Trigger t2 = TriggerBuilder
				.Type(TriggerType.AFTER_SUMMON)
				.SetTask(new SummonTask("sd"))
				.SetSource(TriggerSource.OP_HERO)
				.SetCondition(SelfCondition.ElementalPlayedLastTurn)
				.GetTrigger();
		}

		public static implicit operator Trigger(TriggerBuilder builder)
		{
			return builder.GetTrigger();
		}
	}


}
