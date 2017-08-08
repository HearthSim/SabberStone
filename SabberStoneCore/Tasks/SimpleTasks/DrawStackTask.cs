using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawStackTask : SimpleTask
    {
        public override TaskState Process()
        {
            if (Playables.Count == 0)
            {
                return TaskState.STOP;
            }

            var list = new List<IPlayable>();
            Playables.ForEach(p =>
            {
                list.Add(Generic.DrawBlock(Controller, p));
            });
            Playables = list;
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DrawStackTask();
            clone.Copy(this);
            return clone;
        }
    }
}