using System;
using System.Collections.Generic;
using SabberStoneCore.Enums;
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

            var proxyCthun = Game.IdEntityDic[Controller.ProxyCthun];

            proxyCthun.Enchants.ForEach(p => p.Activate(p.SourceId, source.Enchants, source));

            source[GameTag.TAUNT] = proxyCthun[GameTag.TAUNT];

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