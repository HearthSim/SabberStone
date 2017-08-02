using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class FuncCardIdsTask : SimpleTask
    {
        public FuncCardIdsTask(Func<List<string>, List<string>> function)
        {
            Function = function;
        }

        public Func<List<string>, List<string>> Function { get; set; }

        public override ETaskState Process()
        {
            CardIds = Function(CardIds);
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new FuncCardIdsTask(Function);
            clone.Copy(this);
            return clone;
        }
    }
}