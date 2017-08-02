using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class FuncNumberTask : SimpleTask
    {
        public FuncNumberTask(Func<IPlayable, int> function)
        {
            Function = function;
        }

        public Func<IPlayable, int> Function { get; set; }

        public override ETaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null)
            {
                return ETaskState.STOP;
            }

            Number = Function(source);
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new FuncNumberTask(Function);
            clone.Copy(this);
            return clone;
        }
    }
}