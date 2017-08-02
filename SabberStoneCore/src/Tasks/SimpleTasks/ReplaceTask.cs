using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ReplaceTask : SimpleTask
    {
        private ReplaceTask(EEntityType type, ERarity rarity, Card card)
        {
            Type = type;
            Rarity = rarity;
            Card = card;
        }

        public ReplaceTask(EEntityType type, ERarity rarity)
        {
            Type = type;
            Rarity = rarity;
            Card = null;
        }

        public ReplaceTask(EEntityType type, string cardId)
        {
            Type = type;
            Rarity = ERarity.INVALID;
            Card = Cards.FromId(cardId);
        }

        public EEntityType Type { get; set; }

        public ERarity Rarity { get; set; }

        public Card Card { get; set; }

        public override ETaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

            var cards = Card == null
                ? Cards.All.Where(p => p.Collectible && p.Rarity == Rarity).ToList()
                : new List<Card> {Card};

            entities.ForEach(p =>
            {
                var zone = p.Zone;
                Controller.Setaside.Add(zone.Remove(p));
                zone.Add(Entity.FromCard(Controller, cards.Count > 1 ? Util.RandomElement(cards) : cards.First()));
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ReplaceTask(Type, Rarity, Card);
            clone.Copy(this);
            return clone;
        }
    }

}