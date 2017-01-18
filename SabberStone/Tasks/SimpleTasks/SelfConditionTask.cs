using SabberStone.Conditions;

namespace SabberStone.Tasks.SimpleTasks
{
    public class SelfConditionTask : SimpleTask
    {
        public SelfConditionTask(SelfCondition condition, EntityType entityType)
        {
            Condition = condition;
            Type = entityType;
        }

        public SelfCondition Condition { get; set; }
        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

            if (entities.Count == 0)
            {
                return TaskState.STOP;
            }

            var flag = true;

            entities.ForEach(p => { flag &= Condition.Eval(p); });

            Flag = flag;
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SelfConditionTask(Condition, Type);
            clone.Copy(this);
            return clone;
        }
    }
}