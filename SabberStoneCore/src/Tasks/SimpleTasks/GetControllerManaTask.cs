using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class GetControllerManaTask : SimpleTask
    {
        public override ETaskState Process()
        {
            Number = Controller.RemainingMana;
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new GetControllerManaTask();
            clone.Copy(this);
            return clone;
        }
    }
}