using System.Linq;
using SabberStone.Conditions;

namespace SabberStone.Tasks.SimpleTasks
{
    public class SelfConditionTask : SimpleTask
    {
        public SelfConditionTask(EntityType entityType, params SelfCondition[] conditions)
        {
            Conditions = conditions;
            Type = entityType;
        }

        public SelfCondition[] Conditions { get; set; }
        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

            if (entities.Count == 0)
            {
                return TaskState.STOP;
            }

            Flag = entities.TrueForAll(p => Conditions.ToList().TrueForAll(c => c.Eval(p)));

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SelfConditionTask(Type, Conditions);
            clone.Copy(this);
            return clone;
        }
    }
}