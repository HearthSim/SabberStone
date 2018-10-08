using System;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks
{
	public interface ISimpleTask
	{
		TaskState State { get; set; }

		TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target, in TaskStack stack = null);

		bool IsTrigger { get; set; }
	}

	public abstract class SimpleTask : ISimpleTask
	{
		internal static Random Random => Util.Random;

		public TaskState State { get; set; } = TaskState.READY;

		public abstract TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target, in TaskStack stack = null);

		public void ResetState()
		{
			State = TaskState.READY;
		}

		public bool IsTrigger { get; set; }

		public override string ToString()
		{
			return GetType().Name;
		}
	}
}
