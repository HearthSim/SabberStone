using System.Reflection;
using log4net;
using SabberStone.Actions;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class TransformTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public TransformTask(Card card, EntityType type)
        {
            Card = card;
            Type = type;
        }
        public TransformTask(string cardId, EntityType type)
        {
            Card = Cards.FromId(cardId);
            Type = type;
        }
        public Card Card { get; set; }
        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables)
                .ForEach(p => Generic.TransformBlock.Invoke(p.Controller, Card, p as Minion));

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new TransformTask(Card, Type);
            clone.Copy(this);
            return clone;
        }
    }
}