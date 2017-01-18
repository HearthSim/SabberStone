using SabberStone.Actions;

namespace SabberStone.Tasks.SimpleTasks
{
    public class DiscardTask : SimpleTask
    {
        public override TaskState Process()
        {
            var success = Playables.TrueForAll(p => Generic.DiscardBlock.Invoke(Controller, p));
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DiscardTask();
            clone.Copy(this);
            return clone;
        }
    }
}