using System;
using System.Collections.Generic;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncPlayablesTask : SimpleTask
    {
        public FuncPlayablesTask(Func<List<IPlayable>, List<IPlayable>> function)
        {
            Function = function;
        }

        public Func<List<IPlayable>, List<IPlayable>> Function { get; set; }

        public override TaskState Process()
        {
            Playables = Function(Playables);
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new FuncPlayablesTask(Function);
            clone.Copy(this);
            return clone;
        }
    }
}