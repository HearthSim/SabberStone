using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class DrawCardTask : SimpleTask
    {
        public override ETaskState Process()
        {
            if (Playables.Count != 1)
            {
                return ETaskState.STOP;
            }

            var drawedCard = Generic.Draw(Controller, Playables[0]);

            if (drawedCard == null)
            {
                return ETaskState.STOP;
            }

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DrawCardTask();
            clone.Copy(this);
            return clone;
        }
    }
}