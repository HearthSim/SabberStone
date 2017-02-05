using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RandomCardIdFromListTask : SimpleTask
    {
        public override TaskState Process()
        {
            if (CardIds.Count == 0)
                return TaskState.STOP;

            var randomCard = Entity.FromCard(Controller, Cards.FromId(Util<string>.Choose(CardIds)));
            Playables.Add(randomCard);

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomCardIdFromListTask();
            clone.Copy(this);
            return clone;
        }
    }
}