using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class AddCardTo : SimpleTask
    {
        private AddCardTo(IPlayable playable, Card card, EEntityType type)
        {
            Playable = playable;
            Card = card;
            Type = type;
        }
        public AddCardTo(IPlayable playable, EEntityType type)
        {
            Playable = playable;
            Type = type;
        }
        public AddCardTo(Card card, EEntityType type)
        {
            Card = card;
            Type = type;
        }
        public AddCardTo(string cardId, EEntityType type)
        {
            Card = Cards.FromId(cardId);
            Type = type;
        }

        public IPlayable Playable { get; set; }

        public Card Card { get; set; }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            switch (Type)
            {
                case EEntityType.DECK:
                    if (Playable == null)
                        Playable = Entity.FromCard(Controller, Card);
                    Generic.ShuffleIntoDeck.Invoke(Controller, Playable);
                    return ETaskState.COMPLETE;

                case EEntityType.HAND:
                    if (Playable == null)
                        Playable = Entity.FromCard(Controller, Card);
                    Generic.AddHandPhase.Invoke(Controller, Playable);
                    return ETaskState.COMPLETE;

                case EEntityType.OP_HAND:
                    if (Playable == null)
                        Playable = Entity.FromCard(Controller.Opponent, Card);
                    Generic.AddHandPhase.Invoke(Controller.Opponent, Playable);
                    return ETaskState.COMPLETE;

                case EEntityType.OP_DECK:
                    if (Playable == null)
                        Playable = Entity.FromCard(Controller.Opponent, Card);
                    Generic.ShuffleIntoDeck.Invoke(Controller.Opponent, Playable);
                    return ETaskState.COMPLETE;

                default:
                    throw new NotImplementedException();
            }
        }

        public override ISimpleTask Clone()
        {
            var clone = new AddCardTo(Playable, Card, Type); 
            clone.Copy(this);
            return clone;
        }
    }
}