using System.Collections.Generic;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ClearStackTask : SimpleTask
	{
		public override TaskState Process()
		{
			Playables = new List<IPlayable>();
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new ClearStackTask();
			clone.Copy(this);
			return clone;
		}
	}
}