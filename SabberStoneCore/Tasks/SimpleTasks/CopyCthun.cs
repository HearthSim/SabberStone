using System;
using System.Collections.Generic;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{

    public class CopyCthun : SimpleTask
    {
        public override TaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null)
            {
                return TaskState.STOP;
            }

            Game.IdEntityDic[Controller.ProxyCthun].Enchants.ForEach(p =>
            {
                p.Activate(p.SourceId, source.Enchants, source);
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