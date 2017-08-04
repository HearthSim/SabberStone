namespace SabberStoneCore.Enums
{
	/// <summary>
	/// Indicates the format of decks, which limits 
	/// the allowed cards that can be put into that deck.
	/// Generally each type has a matching set of cards (wild set
	/// for wild format) which contains all cards that are allowed
	/// to be put into a deck of type WILD.
	/// </summary>
	public enum EFormatType: int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		FT_UNKNOWN = 0,
		FT_WILD = 1,
		FT_STANDARD = 2,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Class of a card.
	/// Cards which have a neutral class are allowed in all decks.
	/// When a deck is bound to a specific class, only cards of the same
	/// class and neutral cards are allowed in that deck.
	/// </summary>
	public enum ECardClass : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		DEATHKNIGHT = 1,
		DRUID = 2,
		HUNTER = 3,
		MAGE = 4,
		PALADIN = 5,
		PRIEST = 6,
		ROGUE = 7,
		SHAMAN = 8,
		WARLOCK = 9,
		WARRIOR = 10,
		DREAM = 11,
		NEUTRAL = 12,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Mutual exclusive sets to which cards can belong.
	/// </summary>
	public enum ECardSet : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		TEST_TEMPORARY = 1,
		CORE = 2,
		EXPERT1 = 3,
		HOF = 4,
		MISSIONS = 5,
		DEMO = 6,
		NONE = 7,
		CHEAT = 8,
		BLANK = 9,
		DEBUG_SP = 10,
		PROMO = 11,
		NAXX = 12,
		GVG = 13,
		BRM = 14,
		TGT = 15,
		CREDITS = 16,
		HERO_SKINS = 17,
		TB = 18,
		SLUSH = 19,
		LOE = 20,
		OG = 21,
		OG_RESERVE = 22,
		KARA = 23,
		KARA_RESERVE = 24,
		GANGS = 25,
		GANGS_RESERVE = 26,
		UNGORO = 27
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Meta information about a card.
	/// 
	/// Cards CAN BE heroes or hero powers or minions or spells..
	/// </summary>
	public enum ECardType : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		GAME = 1,
		PLAYER = 2,
		HERO = 3,
		MINION = 4,
		//ABILITY = 5,
		SPELL = 5,
		ENCHANTMENT = 6,
		WEAPON = 7,
		ITEM = 8,
		TOKEN = 9,
		HERO_POWER = 10,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// A multiclassgroup is a set of cards which spans multiple 
	/// classes.
	/// 
	/// ex; GRIMMY_GOONS contains Paladin+Hunter+Warrior classes.
	/// </summary>
	public enum EMultiClassGroup : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		GRIMY_GOONS = 1,
		JADE_LOTUS = 2,
		KABAL = 3,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Another classification for cards which is mutual exclusive.
	/// The most used value is DRAGON, since a lot of cards interact with
	/// dragons in hand.
	/// </summary>
	public enum ERace : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		BLOODELF = 1,
		DRAENEI = 2,
		DWARF = 3,
		GNOME = 4,
		GOBLIN = 5,
		HUMAN = 6,
		NIGHTELF = 7,
		ORC = 8,
		TAUREN = 9,
		TROLL = 10,
		UNDEAD = 11,
		WORGEN = 12,
		GOBLIN2 = 13,
		MURLOC = 14,
		DEMON = 15,
		SCOURGE = 16,
		MECHANICAL = 17,
		ELEMENTAL = 18,
		OGRE = 19,
		BEAST = 20,
		TOTEM = 21,
		NERUBIAN = 22,
		PIRATE = 23,
		DRAGON = 24,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Rarity of a card. This reflects the drop rate from card packs.
	/// </summary>
	public enum ERarity : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		COMMON = 1,
		FREE = 2,
		RARE = 3,
		EPIC = 4,
		LEGENDARY = 5,
		UNKNOWN_6 = 6,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Another mutual exclusive classification of cards.
	/// </summary>
	public enum EFaction : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		HORDE = 1,
		ALLIANCE = 2,
		NEUTRAL = 3,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
