using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawNumberTask : SimpleTask
	{
		public override TaskState Process()
		{
			for (int i = 0; i < Number; ++i)
				Generic.Draw(Controller);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			return this;
		}
	}
}
