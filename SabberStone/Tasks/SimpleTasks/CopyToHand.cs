using SabberStone.Actions;

namespace SabberStone.Tasks.SimpleTasks
{
    public class CopyToHand : SimpleTask
    {
        public override TaskState Process()
        {
            var success = Playables.TrueForAll(p => Generic.AddHandPhase.Invoke(Controller, p));
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new CopyToHand();
            clone.Copy(this);
            return clone;
        }
    }
}