using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class GetGameTagControllerTask : SimpleTask
    {
        public GetGameTagControllerTask(EGameTag tag)
        {
            Tag = tag;
        }

        public EGameTag Tag { get; set; }

        public override ETaskState Process()
        {
            Number = Controller[Tag];
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new GetGameTagControllerTask(Tag);
            clone.Copy(this);
            return clone;
        }
    }
}