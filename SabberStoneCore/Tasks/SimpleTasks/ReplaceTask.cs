using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ReplaceTask : SimpleTask
    {

        public ReplaceTask(EntityType type, Rarity rarity)
        {
            Type = type;
            Rarity = rarity;
        }

        public ReplaceTask(EntityType type, string cardId)
        {
            Type = type;
            Card = Cards.FromId(cardId);
        }

        public EntityType Type { get; set; }

        public Rarity Rarity { get; set; }

        public Card Card { get; set; }

        public override TaskState Process()
        {
            if (Card == null)
            {
                var cards = Cards.All.Where(p => p.Collectible && p.Rarity == Rarity);
                var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
                entities.ForEach(p =>
                {
                    var zone = p.Zone;
                    Generic.RemoveFromZone(Controller, p);
                    Controller.Setaside.Add(p);
                    zone.Add(Entity.FromCard(Controller, Util.RandomElement(cards)));
                });
            }
            else
            {
                var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
                entities.ForEach(p =>
                {
                    var zone = p.Zone;
                    Generic.RemoveFromZone(Controller, p);
                    Controller.Setaside.Add(p);
                    zone.Add(Entity.FromCard(Controller, Card));
                });
            }
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ReplaceTask(Type, Rarity);
            clone.Copy(this);
            return clone;
        }
    }

}