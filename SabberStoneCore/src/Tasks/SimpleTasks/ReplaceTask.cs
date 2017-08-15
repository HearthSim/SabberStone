using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ReplaceTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public Rarity Rarity { get; set; }

		public Card Card { get; set; }


		private ReplaceTask(EntityType type, Rarity rarity, Card card)
		{
			Type = type;
			Rarity = rarity;
			Card = card;
		}

		public ReplaceTask(EntityType type, Rarity rarity)
		{
			Type = type;
			Rarity = rarity;
			Card = null;
		}

		public ReplaceTask(EntityType type, string cardId)
		{
			Type = type;
			Rarity = Rarity.INVALID;
			Card = Cards.FromId(cardId);
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			List<Card> cards = Card == null
				? Cards.All.Where(p => p.Collectible && p.Rarity == Rarity).ToList()
				: new List<Card> { Card };

			entities.ForEach(p =>
			{
				IZone zone = p.Zone;
				Controller.SetasideZone.Add(zone.Remove(p));
				zone.Add(Entity.FromCard(Controller, cards.Count > 1 ? Util.RandomElement(cards) : cards.First()));
			});

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(ReplaceTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new ReplaceTask(Type, Rarity, Card);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
