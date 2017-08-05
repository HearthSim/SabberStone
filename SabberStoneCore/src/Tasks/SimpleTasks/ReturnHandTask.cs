using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities.Playables;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ReturnHandTask : SimpleTask
    {
        public ReturnHandTask(EEntityType type)
        {
            Type = type;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
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

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ReturnHandTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}