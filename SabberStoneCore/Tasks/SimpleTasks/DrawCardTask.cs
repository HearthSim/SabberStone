using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawCardTask : SimpleTask
    {
        public override TaskState Process()
        {
            if (Playables.Count != 1)
            {
                return TaskState.STOP;
            }

            var drawedCard = Generic.Draw(Controller, Playables[0]);

            if (drawedCard == null)
            {
                return TaskState.STOP;
            }

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DrawCardTask();
            clone.Copy(this);
            return clone;
        }
    }
}