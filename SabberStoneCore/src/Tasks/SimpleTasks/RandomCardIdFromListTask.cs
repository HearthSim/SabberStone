using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RandomCardIdFromListTask : SimpleTask
    {
        public override ETaskState Process()
        {
            if (CardIds.Count == 0)
                return ETaskState.STOP;

            var randomCard = Entity.FromCard(Controller, Cards.FromId(Util.Choose(CardIds)));
            Playables.Add(randomCard);

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomCardIdFromListTask();
            clone.Copy(this);
            return clone;
        }
    }
}