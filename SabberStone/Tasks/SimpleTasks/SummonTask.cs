using SabberStone.Actions;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
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

            var summonEntity = 
                Card != null ? 
                Entity.FromCard(Controller, Card) as Minion : 
                Playables[0] as Minion;

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

    public class SummonOpTask : SimpleTask
    {
        public SummonOpTask(Card card)
        {
            Card = card;
        }

        public SummonOpTask(string cardId)
        {
            Card = Cards.FromId(cardId);
        }

        public Card Card { get; set; }

        public override TaskState Process()
        {
            if (Controller.Opponent.Board.IsFull)
                return TaskState.STOP;

            var summonEntity = Card != null ?
                Entity.FromCard(Controller.Opponent, Card) as Minion :
                Playables[0] as Minion;

            if (summonEntity == null)
                return TaskState.STOP;

            var success = Generic.SummonBlock.Invoke(Controller.Opponent, summonEntity, -1);

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SummonOpTask(Card);
            clone.Copy(this);
            return clone;
        }
    }
}