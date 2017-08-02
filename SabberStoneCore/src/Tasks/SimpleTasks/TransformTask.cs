using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class TransformTask : SimpleTask
    {
        public TransformTask(Card card, EEntityType type)
        {
            Card = card;
            Type = type;
        }
        public TransformTask(string cardId, EEntityType type)
        {
            Card = Cards.FromId(cardId);
            Type = type;
        }
        public Card Card { get; set; }
        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables)
                .ForEach(p => Generic.TransformBlock.Invoke(p.Controller, Card, p as Minion));

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new TransformTask(Card, Type);
            clone.Copy(this);
            return clone;
        }
    }
}