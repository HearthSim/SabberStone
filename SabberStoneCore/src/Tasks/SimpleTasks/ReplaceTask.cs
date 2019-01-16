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

		public EntityType Type { get; set; }

		public Rarity Rarity { get; set; }

		public Card Card { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);

			List<Card> cards = Card == null
				? Cards.All.Where(p => p.Collectible && p.Rarity == Rarity).ToList()
				: new List<Card> {Card};

			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
			{
				IZone zone = p.Zone;
				controller.SetasideZone.Add(zone.Remove(p));
				zone.Add(Entity.FromCard(in controller, cards.Count > 1 ? Util.Choose(cards) : cards.First()));
			}

			return TaskState.COMPLETE;
		}
	}
}
