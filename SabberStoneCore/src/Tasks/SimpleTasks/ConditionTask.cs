using System.Linq;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ConditionTask : SimpleTask
    {
        private ConditionTask(EEntityType entityType, 
            SelfCondition[] selfConditions,
            RelaCondition[] relaConditions)
        {
            SelfConditions = selfConditions;
            RelaConditions = relaConditions;
            Type = entityType;
        }

        public ConditionTask(EEntityType entityType, params SelfCondition[] selfConditions)
        {
            SelfConditions = selfConditions;
            RelaConditions = new RelaCondition[] {};
            Type = entityType;
        }

        public ConditionTask(EEntityType entityType, params RelaCondition[] relaConditions)
        {
            SelfConditions = new SelfCondition[] { };
            RelaConditions = relaConditions;
            Type = entityType;
        }

        public SelfCondition[] SelfConditions { get; set; }
        public RelaCondition[] RelaConditions { get; set; }
        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

            if (entities.Count == 0)
            {
                return ETaskState.STOP;
            }

            var source = (IPlayable) Source;

            Flag = entities.TrueForAll(p => 
                SelfConditions.ToList().TrueForAll(c => c.Eval(p)) &&
                RelaConditions.ToList().TrueForAll(c => c.Eval(source, p)));

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ConditionTask(Type, SelfConditions, RelaConditions);
            clone.Copy(this);
            return clone;
        }
    }
}