using System;
using System.Collections.Generic;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class FuncTask : SimpleTask
    {
        public FuncTask(Func<List<IPlayable>, List<IPlayable>> function)
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
            var clone = new FuncTask(Function);
            clone.Copy(this);
            return clone;
        }
    }
}