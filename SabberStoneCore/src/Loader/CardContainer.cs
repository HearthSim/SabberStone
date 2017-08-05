using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System.Collections;
using System.Collections.Generic;

namespace SabberStoneCore.Loader
{
	internal class CardContainer : IEnumerable<Card>
	{
		/// <summary>The cards list, which contains all known cards.</summary>
		private readonly List<Card> CardsList;

		/// <summary>The cards container, mapped by <see cref="Card.Id"/>.</summary>
		private readonly Dictionary<string, Card> CardsContainer;

		/// <summary>True if this container was setup.</summary>
		private bool Initialised;

		/// <summary>Gets the <see cref="Card"/> with the specified card identifier.
		/// This accessor can return null!
		/// </summary>
		/// <value>The <see cref="Card"/>.</value>
		/// <param name="cardId">The card identifier.</param>
		/// <returns></returns>
		internal Card this[string cardId]
		{
			get
			{
				CardsContainer.TryGetValue(cardId, out Card value);
				return value;
			}
		}

		public CardContainer()
		{
			Initialised = false;
			CardsList = new List<Card>();
			CardsContainer = new Dictionary<string, Card>();
		}

		/// <summary>Setup a new CardContainer instance. This method tries to avoid cyclic construction errors.</summary>
		/// <param name="cards">The cards.</param>
		/// <param name="instance">The variable.</param>
		internal static bool SetupContainer(List<Card> cards, CardContainer instance)
		{
			if (instance.Initialised) return false;

			instance.Initialised = true;
			instance.CardsList.AddRange(cards);
			instance.ProcessCardList(instance.CardsList);

			return true;
		}

		private void ProcessCardList(IList<Card> cards)
		{
			// Do a first pass to map each card by ID.
			for (int i = 0; i < cards.Count; ++i)
			{
				Card card = cards[i];
				CardsContainer[card.Id] = card;
			}

			// Do a second pass to complete card data.
			for (int i = 0; i < cards.Count; ++i)
			{
				Card card = cards[i];
				CollectCardEnchantments(card);
			}
		}

		private void CollectCardEnchantments(Card card)
		{
			Dictionary<string, List<Enchantment>> enchantments = Enchantments.Instance.Get();
			if (enchantments.TryGetValue(card.Id, out List<Enchantment> implementedEnchantments))
			{
				// This card has been implemented, so the instance is updated accordingly.
				card.Enchantments = implementedEnchantments;
				card.Implemented = implementedEnchantments == null ||
					card.Enchantments[0].Activation != EEnchantmentActivation.NONE &&
					(card.Enchantments[0].SingleTask != null || card.Enchantments[0].Enchant != null || card.Enchantments[0].Trigger != null);
			}
		}

		/// <summary>Returns a sequence of all the cards.</summary>
		/// <returns></returns>
		internal IList<Card> AllCards()
		{
			return CardsList;
		}

		public IEnumerator<Card> GetEnumerator()
		{
			return CardsList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return CardsList.GetEnumerator();
		}
	}
}
