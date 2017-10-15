using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomMinionTask : SimpleTask
	{
		private static ConcurrentDictionary<int, List<Card>> CachedCards = new ConcurrentDictionary<int, List<Card>>();

		private RandomMinionTask(GameTag tag, int value, EntityType type, int amount, RelaSign relaSign, bool classAndMultiOnlyFlag, bool maxInDeckFlag)
		{
			Tag = tag;
			Value = value;
			Amount = amount;
			Type = type;
			RelaSign = relaSign;
			ClassAndMultiOnlyFlag = classAndMultiOnlyFlag;
			MaxInDeckFlag = maxInDeckFlag;
		}

		public RandomMinionTask(GameTag tag, EntityType type, int amount = 1)
		{
			Tag = tag;
			Value = -1;
			Amount = amount;
			Type = type;
			ClassAndMultiOnlyFlag = false;
			MaxInDeckFlag = false;
			RelaSign = RelaSign.EQ;
		}

		public RandomMinionTask(GameTag tag, int value, int amount = 1, RelaSign relaSign = RelaSign.EQ, bool classAndMultiOnlyFlag = false, bool maxInDeckFlag = false)
		{
			Tag = tag;
			Value = value;
			Amount = amount; 
			Type = EntityType.INVALID;
			ClassAndMultiOnlyFlag = classAndMultiOnlyFlag;
			MaxInDeckFlag = maxInDeckFlag;
			RelaSign = relaSign;
		}

		public GameTag Tag { get; set; }
		public int Value { get; set; }
		public EntityType Type { get; set; }
		public int Amount { get; set; }
		public bool ClassAndMultiOnlyFlag { get; set; }
		public bool MaxInDeckFlag { get; set; }
		public RelaSign RelaSign { get; set; }

		public override TaskState Process()
		{
			List<Card> cardsList = null;
			if (Type != EntityType.INVALID)
			{
				if (Type == EntityType.TARGET && Tag == GameTag.COST)
				{
					Value = ((IPlayable)Target).Cost;
					cardsList = Cards.CostMinionCards(Game.FormatType)[Value];
				}
				else
				{
					throw new NotImplementedException();
				}
			}

			if (cardsList == null && Tag == GameTag.COST && RelaSign == RelaSign.EQ)
				cardsList = Cards.CostMinionCards(Game.FormatType)[Value];

			if (cardsList == null && !CachedCards.TryGetValue(Source.Card.AssetId, out cardsList))
			{
				IEnumerable<Card> cards;
				if (Game.FormatType == FormatType.FT_STANDARD)
				{
					cards = ClassAndMultiOnlyFlag ? Controller.Standard : Cards.AllStandard;
				}
				else
				{
					cards = ClassAndMultiOnlyFlag ? Controller.Wild : Cards.AllWild;
				}

				cardsList = cards.Where(p => p.Type == CardType.MINION
				&& (RelaSign == RelaSign.EQ && p[Tag] == Value
				 || RelaSign == RelaSign.GEQ && p[Tag] >= Value
				 || RelaSign == RelaSign.LEQ && p[Tag] <= Value)).ToList();

				CachedCards.TryAdd(Source.Card.AssetId, cardsList);
			}

			if (cardsList.Count == 0)
			{
				return TaskState.STOP;
			}
			var randomMinions = new List<IPlayable>();
			if (Amount > 1)
			{
				var list = new List<Card>(cardsList);
				while (randomMinions.Count < Amount && cardsList.Count > 0)
				{
					Card card = Util.Choose<Card>(cardsList);
					list.Remove(card);

					// check for deck rules
					if (MaxInDeckFlag && Controller.DeckCards.Where(p => p.Id == card.Id).Count() >= card.MaxAllowedInDeck)
						continue;

					randomMinions.Add(Entity.FromCard(Controller, card));
				}

			}
			else
				randomMinions.Add(Entity.FromCard(Controller, Util.Choose(cardsList)));


			Playables = randomMinions;

			Game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RandomMinionTask(Tag, Value, Type, Amount, RelaSign, ClassAndMultiOnlyFlag, MaxInDeckFlag);
			clone.Copy(this);
			return clone;
		}
	}
}
