﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using System;
using SabberStoneCore.Loader;

namespace SabberStoneCore.Model
{
	/// <summary>
	/// Object representing a known entity.
	///
	/// All properties exposed by these instances are defined by `resources/Data/CardDefs.xml`.
	/// <see cref="CardLoader"/> for extraction procedures.
	/// </summary>
	public class Card
	{
		/// <summary>
		/// Unique asset id of that card nummeric representation.
		/// </summary>
		public int AssetId { get; set; }

		/// <summary>
		/// Unique card ID, as defined in
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Name of the card, localized in the extracted language.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Flavour text of the card, localized in the extracted language.
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// Contains all card ID's which are generated by this specific card.
		///
		/// For example Ysera, the dragon which produces on DREAM card after your turn,
		/// has entourage: DREAM_01, DREAM_02, DREAM_03, DREAM_04, DREAM_05
		/// </summary>
		public string[] Entourage { get; set; }

		/// <summary>
		/// Properties set on this instance.
		/// These properties represent health, attack, # turns in play etc.
		/// <see cref="GameTag"/> for all possibilities.
		/// </summary>
		public Dictionary<GameTag, int> Tags { get; set; }

		/// <summary>
		/// Declares all effects that are triggered by this instance.
		/// Possibilities are SpellPower, DeathRattle, Charge etc.
		/// </summary>
		public Dictionary<GameTag, int> RefTags { get; set; }

		/// <summary>
		/// Requirements that must have been met before this card can be moved into
		/// play zone.
		/// <see cref="PlayReq"/> for all possibilities.
		/// </summary>
		public Dictionary<PlayReq, int> PlayRequirements { get; set; }

		public bool ChooseOne { get; internal set; }

		public bool IsSecret { get; internal set; }

		public bool IsQuest { get; internal set; }

		public bool Untouchable { get; internal set; }

		public bool HideStat { get; internal set; }

		/// <summary>
		/// Provides easy access to the value of a specific Tag set on this instance.
		/// <seealso cref="Tags"/>
		/// </summary>
		/// <param name="t">The <see cref="GameTag"/> which value is queried</param>
		/// <returns></returns>
		public int this[GameTag t]
			=> Tags.TryGetValue(t, out int value) ? value : 0;

		/// <summary>
		/// Indicates if this card occurs in the player's collection. Only collectible
		/// cards can be put together in a deck.
		///
		/// Non-collectible cards are generated during the game, like Ysera's Dream cards.
		/// </summary>
		public bool Collectible => this[GameTag.COLLECTIBLE] == 1;

		/// <summary>
		/// A card can have NO class or AT MOST one.
		/// The cardclass is coupled with the chosen hero to represent the player.
		///
		/// Cards with a specific class can NOT be put into a deck with other classcards.
		/// <seealso cref="CardClass"/>
		/// </summary>
		public CardClass Class => (CardClass)this[GameTag.CLASS];

		/// <summary>
		/// <see cref="Race"/>
		/// </summary>
		public Race Race => (Race)this[GameTag.CARDRACE];

		/// <summary>
		/// <see cref="Faction"/>
		/// </summary>
		public Faction Faction => (Faction)this[GameTag.FACTION];

		/// <summary>
		/// Indicates if this card has a combo effect or not.
		/// </summary>
		public bool HasCombo => this[GameTag.COMBO] == 1;

		/// <summary>
		/// <see cref="Rarity"/>
		/// </summary>
		public Rarity Rarity => (Rarity)this[GameTag.RARITY];

		/// <summary>
		/// The actual type of a card has limitations on it's usage.
		/// A hero card cannot be put into a deck for example.. imagine that!
		/// Knights of the Frozen Throne , is beyond imagination? With
		/// Deathknigth heros in the deck!
		/// <see cref="CardType"/>
		/// </summary>
		public CardType Type => (CardType)this[GameTag.CARDTYPE];

		/// <summary>
		/// <see cref="CardSet"/>
		/// </summary>
		public CardSet Set => (CardSet)this[GameTag.CARD_SET];

		/// <summary>
		/// Original mana-cost of this card.
		/// </summary>
		public int Cost => this[GameTag.COST];

		/// <summary>
		/// True if this card will incur Overload when played.
		/// Overload is an effect that locks mana crystals.
		/// Locked mana crystals can't be spent during one turn.
		/// </summary>
		public bool HasOverload { get; internal set; }

		/// <summary>
		/// The amount of overload incurred by this card when played.
		/// </summary>
		public int Overload { get; internal set; }

		/// <summary>
		/// Returns to which multi class group this card belongs.
		/// <see cref="MultiClassGroup"/>
		/// </summary>
		public bool RequiresTarget => PlayRequirements.ContainsKey(PlayReq.REQ_TARGET_TO_PLAY);

		/// <summary>
		/// Requires a target for combo
		/// </summary>
		public bool RequiresTargetForCombo => PlayRequirements.ContainsKey(PlayReq.REQ_TARGET_FOR_COMBO);

		/// <summary>
		/// Requires a target if available
		/// </summary>
		public bool RequiresTargetIfAvailable => PlayRequirements.ContainsKey(PlayReq.REQ_TARGET_IF_AVAILABLE) ||
		                                         PlayRequirements.ContainsKey(PlayReq.REQ_DRAG_TO_PLAY);

		/// <summary>
		/// Requires a target if available and dragon in hand
		/// </summary>
		public bool RequiresTargetIfAvailableAndDragonInHand
			=> PlayRequirements.ContainsKey(PlayReq.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND);

		/// <summary>
		/// Requires a target if available and element played last turn
		/// </summary>
		public bool RequiresTargetIfAvailableAndElementalPlayedLastTurn
			=> PlayRequirements.ContainsKey(PlayReq.REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN);

		/// <summary>
		/// Requires a target if available and minimum friendly minions
		/// </summary>
		public bool RequiresTargetIfAvailableAndMinimumFriendlyMinions
			=> PlayRequirements.ContainsKey(PlayReq.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS);

		/// <summary>
		/// Requires a target if available and minimum friendly secrets
		/// </summary>
		public bool RequiresTargetIfAvailableAndMinimumFriendlySecrets
			=> PlayRequirements.ContainsKey(PlayReq.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS);

		/// <summary>
		/// Maximum amount of copies that are allowed in one deck.
		/// </summary>
		public int MaxAllowedInDeck => Rarity == Rarity.LEGENDARY ? 1 : 2;

		/// <summary>
		/// True if the effects of this card are implemented.
		/// </summary>
		public bool Implemented { get; set; }

		/// <summary>
		/// Holds a list of Buffs/Debuffs on this card instance.
		/// <seealso cref="Power"/>
		/// </summary>
		//public List<Power> Powers { get; set; } = new List<Power>();
		public Power Power { get; set; }

		/// <summary>
		/// True if this card increases it's owners spell damage.
		/// </summary>
		public bool IsAffectedBySpellDamage { get; set; }

		/// <summary>
		/// Multi class group.
		/// </summary>
		public int MultiClassGroup => this[GameTag.MULTI_CLASS_GROUP];

		/// <summary>
		/// Returns a string representation.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return $"[{Name}]";
		}
		/// <summary>
		/// Returns a substring of the name of this instance.
		/// </summary>
		/// <param name="size">The maximum length of the substring in # characters.</param>
		/// <returns></returns>
		public string AbbreviatedName(int size)
		{
			if (Name.Length <= size)
			{
				return Name;
			}
			else if (!Name.Contains(" "))
			{
				return Name.Substring(0, size);
			}
			else
			{
				string[] strArray = Name.Split(' ');
				return String.Join("", strArray.Select(p => p.Length > 4 ? p.Substring(0, 4) : p).ToList()).Substring(0, 7);
			}

		}

		/// <summary>
		/// Returns a string containing all information about this instance.
		/// </summary>
		/// <param name="gameTag"></param>
		/// <param name="playReq"></param>
		/// <returns></returns>
		public string FullPrint(bool gameTag = false, bool playReq = false)
		{
			var builder = new StringBuilder();
			builder.Append($"[CARD: {Name} - {Id} (Col={Collectible},Set={Set})]");
			if (gameTag)
			{
				builder.Append("\n   GameTags:");
				Tags.ToList().ForEach(pair => builder.Append($"\n   - {pair.Key} -> {pair.Value}"));
			}
			if (playReq)
			{
				builder.Append("\n   PlayReq:");
				PlayRequirements.ToList().ForEach(pair => builder.Append($"\n   - {pair.Key} -> {pair.Value}"));
			}
			return builder.ToString();
		}

		internal static Card CardGame => new Card()
		{
			Id = "Game",
			Name = "Game",
			Tags = new Dictionary<GameTag, int> { [GameTag.CARDTYPE] = (int)CardType.GAME },
			//PlayRequirements = new Dictionary<PlayReq, int>(),
		};

		internal static Card CardPlayer => new Card()
		{
			Id = "Player",
			Name = "Player",
			Tags = new Dictionary<GameTag, int> { [GameTag.CARDTYPE] = (int)CardType.PLAYER },
			//PlayRequirements = new Dictionary<PlayReq, int>(),
		};

		public Card Clone()
		{
			var clone = (Card)MemberwiseClone();
			clone.Tags = new Dictionary<GameTag, int>(Tags);
			clone.RefTags = new Dictionary<GameTag, int>(RefTags);
			clone.PlayRequirements = new Dictionary<PlayReq, int>(PlayRequirements);
			//if (Powers != null)
			//	clone.Powers = new List<Power>(Powers);
			return clone;
		}
	}
}
