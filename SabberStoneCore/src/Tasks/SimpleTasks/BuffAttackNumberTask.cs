using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{

    public class BuffAttackNumberTask : SimpleTask
    {
        public BuffAttackNumberTask(EEntityType type)
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

            var buff = new BuffTask(Buffs.Attack(Number), Type, null);
            buff.Copy(this);

            return buff.Process();
        }

        public override ISimpleTask Clone()
        {
            var clone = new BuffAttackNumberTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}