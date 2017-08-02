using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawStackTask : SimpleTask
    {
        public override ETaskState Process()
        {
            if (Playables.Count == 0)
            {
                return ETaskState.STOP;
            }

            var list = new List<IPlayable>();
            Playables.ForEach(p =>
            {
                list.Add(Generic.DrawBlock(Controller, p));
            });
            Playables = list;
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DrawStackTask();
            clone.Copy(this);
            return clone;
        }
    }
}