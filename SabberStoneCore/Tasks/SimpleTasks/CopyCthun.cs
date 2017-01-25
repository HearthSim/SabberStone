using System;
using System.Collections.Generic;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{

    public class CopyCthun : SimpleTask
    {
        public override TaskState Process()
        {
            var target = Target as IPlayable;
            if (target == null)
            {
                return TaskState.STOP;
            }

            Source.Enchants.ForEach(p =>
            {
                p.Activate(p.SourceId, target.Enchants, target);
            });
 
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new CopyCthun();
            clone.Copy(this);
            return clone;
        }
    }
}