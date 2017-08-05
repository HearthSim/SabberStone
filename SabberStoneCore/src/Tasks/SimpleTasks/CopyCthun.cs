using SabberStoneCore.Collections;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{

    public class CopyCthun : SimpleTask
    {
        public override ETaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null)
            {
                return ETaskState.STOP;
            }

            if (Controller.ProxyCthun == 0)
            {
                return ETaskState.STOP;
            }

            var proxyCthun = Game.Entities[Controller.ProxyCthun];

            proxyCthun.Enchants.ForEach(p => p.Activate(p.SourceId, source.Enchants, source));

            source[EGameTag.TAUNT] = proxyCthun[EGameTag.TAUNT];

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new CopyCthun();
            clone.Copy(this);
            return clone;
        }
    }
}