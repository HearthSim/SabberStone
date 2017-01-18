using System.Linq;
using System.Reflection;
using log4net;
using SabberStone.Conditions;
using SabberStone.Enchants;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class BuffTask : SimpleTask
    {
        public BuffTask(Enchant buff, EntityType type, SelfCondition condition = null)
        {
            Buff = buff;
            Type = type;
            Condition = condition;
        }

        public Enchant Buff { get; set; }

        public EntityType Type { get; set; }

        public SelfCondition Condition { get; set; }

        public override TaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null || Buff == null)
            {
                return TaskState.STOP;
            }
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

            if (Condition != null)
            {
                entities = entities.Where(p => Condition.Eval(p)).ToList();
            }

            entities.ForEach(p => Buff.Activate(source.Card.Id, p.Enchants, p));

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new BuffTask(Buff, Type, Condition);
            clone.Copy(this);
            return clone;
        }
    }

    public class BuffAttackNumberTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

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

    public class BuffHealthNumberTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public BuffHealthNumberTask(EntityType type)
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