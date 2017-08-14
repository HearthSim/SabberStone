using System.Collections.Generic;
using SabberStoneCore.CardSets;
using SabberStoneCore.CardSets.Standard;
using SabberStoneCore.Model;

namespace SabberStoneCore.Enchants
{
	public interface ILazyRemove
	{
		void Remove();
	}

	internal class Enchantments
	{
		/// <summary>
		/// Approximate size of all enchantments/cards. This number can be used
		/// when initializing collections to prevent a lot of reallocations.
		/// </summary>
		internal static readonly int COLLECTION_INIT_SIZE = 512;

		/// <summary>
		/// Contains all defined enchantments.
		/// The index is the CARDID of the card which enchantments are defined.
		/// </summary>
		private readonly Dictionary<string, List<Enchantment>> _enchantmentContainer;

		// Private constructor as per Singleton pattern.
		private Enchantments()
		{
			_enchantmentContainer = new Dictionary<string, List<Enchantment>>(COLLECTION_INIT_SIZE);

			// Standard
			CoreCardsGen.AddAll(_enchantmentContainer);
			Expert1CardsGen.AddAll(_enchantmentContainer);
			GangsCardsGen.AddAll(_enchantmentContainer);
			KaraCardsGen.AddAll(_enchantmentContainer);
			OgCardsGen.AddAll(_enchantmentContainer);
			UngoroCardsGen.AddAll(_enchantmentContainer);
			IcecrownCardsGen.AddAll(_enchantmentContainer);

			// Rest
			HofCardsGen.AddAll(_enchantmentContainer);
			NaxxCardsGen.AddAll(_enchantmentContainer);
			GvgCardsGen.AddAll(_enchantmentContainer);
			BrmCardsGen.AddAll(_enchantmentContainer);
			TgtCardsGen.AddAll(_enchantmentContainer);
			LoeCardsGen.AddAll(_enchantmentContainer);
		}

		private static Enchantments _instance;
		/// <summary>
		/// Use the Singleton pattern to provide the same enchantments to each requester.
		/// </summary>
		public static Enchantments Instance => _instance ?? (_instance = new Enchantments());

		/// <summary>
		/// Returns a dictionary containing all <see cref="Enchantment"/>s, indexed by the 
		/// <see cref="Card.Id"/>.
		/// </summary>
		/// <returns></returns>
		public static IReadOnlyDictionary<string, List<Enchantment>> FetchAll()
		{
			return Instance._enchantmentContainer;
		}
	}
}