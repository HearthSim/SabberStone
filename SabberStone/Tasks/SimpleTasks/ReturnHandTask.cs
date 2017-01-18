using SabberStone.Actions;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class ReturnHandTask : SimpleTask
    {
        public override TaskState Process()
        {
            var target = Target as Minion;

            if (target == null)
                return TaskState.STOP;

            var success = Generic.ReturnToHandBlock.Invoke(target.Controller, target);

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ReturnHandTask();
            clone.Copy(this);
            return clone;
        }
    }
}