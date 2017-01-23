using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.SimpleTasks.Tasks
{

    public class BuffAttackNumberTask : SimpleTask
    {
        public BuffAttackNumberTask(EntityType type)
        {
            Type = type;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null || Number == 0)
            {
                return TaskState.STOP;
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