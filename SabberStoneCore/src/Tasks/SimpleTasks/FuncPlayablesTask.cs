using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class FuncPlayablesTask : SimpleTask
    {
        public FuncPlayablesTask(Func<List<IPlayable>, List<IPlayable>> function)
        {
            Function = function;
        }

        public Func<List<IPlayable>, List<IPlayable>> Function { get; set; }

        public override ETaskState Process()
        {
            Playables = Function(Playables);
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new FuncPlayablesTask(Function);
            clone.Copy(this);
            return clone;
        }
    }
}