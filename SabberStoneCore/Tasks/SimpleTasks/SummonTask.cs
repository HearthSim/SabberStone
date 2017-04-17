using SabberStoneCore.Actions;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SummonTask : SimpleTask
    {
        public SummonTask(Card card = null)
        {
            Card = card;
        }

        public SummonTask(string cardId)
        {
            Card = Cards.FromId(cardId);
        }

        public Card Card { get; set; }

        public override TaskState Process()
        {
            if (Controller.Board.IsFull)
                return TaskState.STOP;

            Minion summonEntity = null;
            if (Card != null)
            {
                summonEntity = Entity.FromCard(Controller, Card) as Minion;
            } else if (Playables.Count > 0)
            {
                summonEntity = Playables[0] as Minion;
                //Playables.Remove(summonEntity);
            }

            if (summonEntity == null)
                return TaskState.STOP;

            var success = Generic.SummonBlock.Invoke(Controller, summonEntity, -1);

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SummonTask(Card);
            clone.Copy(this);
            return clone;
        }
    }
}