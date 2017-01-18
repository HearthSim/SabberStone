using System.Reflection;
using log4net;
using SabberStone.Enchants;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class BuffAttackHealthNumberTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public BuffAttackHealthNumberTask(EntityType type)
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

            var buff = new BuffTask(Buffs.AttackHealth(Number), Type, null);
            buff.Copy(this);

            return buff.Process();
        }

        public override ISimpleTask Clone()
        {
            var clone = new BuffAttackHealthNumberTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}