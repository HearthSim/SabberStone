using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Entities.Playables;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SummonOpTask : SimpleTask
    {
        public SummonOpTask(Card card = null)
        {
            Card = card;
        }

        public SummonOpTask(string cardId)
        {
            Card = Cards.FromId(cardId);
        }

        public Card Card { get; set; }

        public override ETaskState Process()
        {
            if (Controller.Opponent.Board.IsFull)
                return ETaskState.STOP;

            if (Card == null && Playables.Count < 1)
                return ETaskState.STOP;

            var summonEntity = Card != null ?
                Entity.FromCard(Controller.Opponent, Card) as Minion :
                Playables[0] as Minion;

            if (summonEntity == null)
                return ETaskState.STOP;

            var success = Generic.SummonBlock.Invoke(Controller.Opponent, summonEntity, -1);

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SummonOpTask(Card);
            clone.Copy(this);
            return clone;
        }
    }
}