using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class DrawTask : SimpleTask
    {
        public DrawTask(bool toStack = false)
        {
            ToStack = toStack;
        }

        public bool ToStack { get; set; }

        public override ETaskState Process()
        {
            var drawedCard = Generic.Draw(Controller);

            if (drawedCard == null)
            {
                return ETaskState.STOP;
            }

            if (ToStack)
            {
                Playables.Add(drawedCard);
            }

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DrawTask(ToStack);
            clone.Copy(this);
            return clone;
        }
    }
}