using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{

    public class BuffHealthNumberTask : SimpleTask
    {
        public BuffHealthNumberTask(EEntityType type)
        {
            Type = type;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null || Number == 0)
            {
                return ETaskState.STOP;
            }

            var buff = new BuffTask(Buffs.Health(Number), Type, null);
            buff.Copy(this);

            return buff.Process();
        }

        public override ISimpleTask Clone()
        {
            var clone = new BuffHealthNumberTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}