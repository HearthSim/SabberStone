using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ClearStackTask : SimpleTask
    {
        public override ETaskState Process()
        {
            Playables = new List<IPlayable>();
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ClearStackTask();
            clone.Copy(this);
            return clone;
        }
    }
}