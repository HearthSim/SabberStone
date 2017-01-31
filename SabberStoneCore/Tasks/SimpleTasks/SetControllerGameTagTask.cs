using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SetControllerGameTagTask : SimpleTask
    {
        public SetControllerGameTagTask(GameTag tag, int amount, bool opFlag = false)
        {
            Tag = tag;
            Amount = amount;
            OpFlag = opFlag;
        }

        public GameTag Tag { get; set; }

        public int Amount { get; set; }

        public bool OpFlag { get; set; }

        public override TaskState Process()
        {
            var controller = OpFlag ? Controller.Opponent : Controller;

            controller[Tag] = Amount;

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetControllerGameTagTask(Tag, Amount, OpFlag);
            clone.Copy(this);
            return clone;
        }
    }
}