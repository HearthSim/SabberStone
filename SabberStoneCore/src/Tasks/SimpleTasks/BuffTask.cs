using System.Linq;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class BuffTask : SimpleTask
    {
        public BuffTask(Enchant buff, EEntityType type, SelfCondition condition = null)
        {
            Buff = buff;
            Type = type;
            Condition = condition;
        }

        public Enchant Buff { get; set; }

        public EEntityType Type { get; set; }

        public SelfCondition Condition { get; set; }

        public override ETaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null || Buff == null)
            {
                return ETaskState.STOP;
            }
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

            if (Condition != null)
            {
                entities = entities.Where(p => Condition.Eval(p)).ToList();
            }

            entities.ForEach(p => Buff.Activate(source.Card.Id, p.Enchants, p));

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new BuffTask(Buff, Type, Condition);
            clone.Copy(this);
            return clone;
        }
    }
}