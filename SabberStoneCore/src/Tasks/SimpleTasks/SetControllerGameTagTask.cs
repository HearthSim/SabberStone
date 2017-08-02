using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SetControllerGameTagTask : SimpleTask
    {
        public SetControllerGameTagTask(EGameTag tag, int amount, bool opFlag = false)
        {
            Tag = tag;
            Amount = amount;
            OpFlag = opFlag;
        }

        public EGameTag Tag { get; set; }

        public int Amount { get; set; }

        public bool OpFlag { get; set; }

        public override ETaskState Process()
        {
            var controller = OpFlag ? Controller.Opponent : Controller;

            controller[Tag] = Amount;

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetControllerGameTagTask(Tag, Amount, OpFlag);
            clone.Copy(this);
            return clone;
        }
    }
}