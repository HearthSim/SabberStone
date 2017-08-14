using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SabberStoneCore.Loader
{
	internal sealed class CardContainer : KeyedCollection<string, Card>
	{
		/// <summary>
		/// Retrieves all wild cards ordered by card class.
		/// </summary>
		internal Dictionary<CardClass, IEnumerable<Card>> Wild { get; }

		/// <summary>
		/// Retrieves all standard cards ordered by card class.
		/// </summary>
		internal Dictionary<CardClass, IEnumerable<Card>> Standard { get; }

		/// <summary>
		/// All cards belonging to the Standard set.
		/// </summary>
		internal IEnumerable<Card> AllStandard => _allStandard;
		private readonly List<Card> _allStandard;

		/// <summary>
		/// All cards belonging to the Wild set.
		/// </summary>
		internal IEnumerable<Card> AllWild => _allWild;
		private readonly List<Card> _allWild;

		/// <summary>
		/// Returns true if this container was fully setup.
		/// If the returned value if false, it's incomplete and SHOULDN'T
		/// be used in production code!
		/// 
		/// This collection will not accept additionall items when locked.
		/// </summary>
		public bool Locked { get; private set; }

		internal CardContainer(int startCapacity) : base(EqualityComparer<string>.Default, 50)
		{
			if (startCapacity < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(startCapacity));
			}

			// Setup containers
			Wild = new Dictionary<CardClass, IEnumerable<Card>>(startCapacity);
			Standard = new Dictionary<CardClass, IEnumerable<Card>>((startCapacity / 2));
			_allStandard = new List<Card>(startCapacity);
			_allWild = new List<Card>(startCapacity);
			// Unlock container.
			Locked = false;
		}

		protected override string GetKeyForItem(Card item)
		{
			return item.Id;
		}

		/// <summary>
		/// Fills all containers held by this class.
		/// </summary>
		internal void LockContainer()
		{
			// Do not setup twice.
			if (Locked) return;
			Locked = true;

			// Load all enchantments, which will be stored within each card element.
			IReadOnlyDictionary<string, List<Enchantment>> allEnchants = Enchantments.FetchAll();

			// This object should have been filled with cards already!
			// We complete the Card objects by attaching their enchantments (if any defined).
			for (int i = 0; i < Count; ++i)
			{
				Card currentCard = this[i];
				List<Enchantment> list;
				if (allEnchants.TryGetValue(currentCard.Id, out list))
				{
					// Link enchantment with subject card.
					currentCard.Enchantments = list;
					currentCard.Implemented = list == null || currentCard.Enchantments[0].Activation != EnchantmentActivation.NONE &&
									(currentCard.Enchantments[0].SingleTask != null || currentCard.Enchantments[0].Enchant != null ||
									 currentCard.Enchantments[0].Trigger != null);
				}
			}

			//Log.Debug("Standard:");
			Enum.GetValues(typeof(CardClass)).Cast<CardClass>().ToList().ForEach(heroClass =>
			{
				Standard.Add(heroClass, this.Where(c =>
				c.Collectible &&
					(c.Class == heroClass ||
					 c.Class == CardClass.NEUTRAL && c.MultiClassGroup == 0 ||
					 c.MultiClassGroup == 1 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.HUNTER || c.Class == CardClass.PALADIN || c.Class == CardClass.WARRIOR) ||
					 c.MultiClassGroup == 2 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.DRUID || c.Class == CardClass.ROGUE || c.Class == CardClass.SHAMAN) ||
					 c.MultiClassGroup == 3 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.MAGE || c.Class == CardClass.PRIEST || c.Class == CardClass.WARLOCK)) &&
					 c.Type != CardType.HERO && Cards.StandardSets.Contains(c.Set)).ToList().AsReadOnly());
				//Log.Debug($"-> [{heroClass}] - {Standard[heroClass].Count} cards.");
			});

			//Log.Debug("AllStandard:");
			_allStandard.AddRange(this.Where(c => c.Collectible && c.Type != CardType.HERO && Cards.StandardSets.Contains(c.Set)));

			//Log.Debug("Wild:");
			Enum.GetValues(typeof(CardClass)).Cast<CardClass>().ToList().ForEach(heroClass =>
			{
				Wild.Add(heroClass, this.Where(c =>
				c.Collectible &&
					(c.Class == heroClass ||
					 c.Class == CardClass.NEUTRAL && c.MultiClassGroup == 0 ||
					 c.MultiClassGroup == 1 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.HUNTER || c.Class == CardClass.PALADIN || c.Class == CardClass.WARRIOR) ||
					 c.MultiClassGroup == 2 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.DRUID || c.Class == CardClass.ROGUE || c.Class == CardClass.SHAMAN) ||
					 c.MultiClassGroup == 3 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.MAGE || c.Class == CardClass.PRIEST || c.Class == CardClass.WARLOCK)) &&
					 c.Type != CardType.HERO).ToList().AsReadOnly());
				//Log.Debug($"-> [{heroClass}] - {Wild[heroClass].Count} cards.");
			});

			//Log.Debug("AllWild:");
			_allWild.AddRange(this.Where(c => c.Collectible && c.Type != CardType.HERO));
		}

		#region COLLECTION_OVERRIDES

		protected override void ClearItems()
		{
			if (Locked) throw new InvalidOperationException("CardContainer is locked!");
			base.ClearItems();
		}

		protected override void InsertItem(int index, Card item)
		{
			if (Locked) throw new InvalidOperationException("CardContainer is locked!");
			base.InsertItem(index, item);
		}

		protected override void RemoveItem(int index)
		{
			if (Locked) throw new InvalidOperationException("CardContainer is locked!");
			base.RemoveItem(index);
		}

		protected override void SetItem(int index, Card item)
		{
			if (Locked) throw new InvalidOperationException("CardContainer is locked!");
			base.SetItem(index, item);
		}

		#endregion

		public override string ToString()
		{
			return String.Format("{0}: Holds {1} cards.", nameof(CardContainer), Count);
		}
	}
}
