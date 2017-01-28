using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class HalfHalfChanceTask : SimpleTask
    {
        public override TaskState Process()
        {
            return Util.Random.Next(0, 2) == 0 ? TaskState.COMPLETE : TaskState.STOP;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HalfHalfChanceTask();
            clone.Copy(this);
            return clone;
        }
    }
}