using SabberStoneCore.Actions;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ReturnHandTask : SimpleTask
    {
        public ReturnHandTask(EntityType entityType)
        {
            Type = entityType;
        }
        public EntityType Type { get; set; }
        public override TaskState Process()
        {
            var success = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).TrueForAll(p =>
            {
                var target = p as Minion;
                if (target == null)
                {
                    return false;
                }
                return Generic.ReturnToHandBlock.Invoke(target.Controller, target);
            });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ReturnHandTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}