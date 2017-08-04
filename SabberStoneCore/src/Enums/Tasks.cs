using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Enums
{
	/// <summary>
	/// Represents the execution state of a task.
	/// <seealso cref="ISimpleTask"/>
	/// </summary>
	public enum ETaskState : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		READY, RUNNING, COMPLETE, STOP
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Represents basic math operations for usage in <see cref="ISimpleTask"/> objects.
	/// </summary>
	public enum EMathOperation : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		ADD, SUB, MUL, DIV
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// All types of actions which can be performed by controllers.
	/// </summary>
	public enum EPlayerTaskType : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		CHOOSE, CONCEDE, END_TURN, HERO_ATTACK, HERO_POWER, MINION_ATTACK, PLAY_CARD
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Area where an enchantment, specifically <see cref="AuraTask"/>, are active.
	/// </summary>
	public enum EAuraArea : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		BOARD, HAND, GAME, HERO, SELF, OP_HAND
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Enumeration of all card categories which can be discovered.
	/// 
	/// eg: <see cref="BASIC_HEROPOWERS"/>: This instructs the simulator to build entities
	/// from cards which belong to the set of heropowers.
	/// </summary>
	public enum EDiscoverType : int
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		BASIC_HEROPOWERS,
		DRAGON,
		OP_DECK,
		BASIC_TOTEM,
		MINION,
		SPELL,
		DEATHRATTLE,
		ONE_COST,
		THREE_COST,
		BEAST,
		MECHANICAL,
		ARTIFACT,
		TRACKING,
		DRUID_ROGUE_SHAMAN,
		MAGE_PRIEST_WARLOCK,
		OVERLOAD,
		TAUNT,
		HUNTER_PALADIN_WARRIOR,
		MURLOC,
		SECRET,
		ELEMENTAL,
		ALL,
		ELEMENTAL_INVOCATION,
		OWN_SPELL,
		COST_8_MORE_SUMMON,
		OP_HERO
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Enumeration of all categories to which entities belong during a game.
	/// 
	/// These values are not mutual exclusive, one entity can belong to multiple
	/// categories and the exact resulting set of entities depends on the context
	/// where tasks run.
	/// </summary>
	public enum EEntityType : int
	{
		/// <summary>
		///  The target
		/// </summary>
		TARGET,
		/// <summary>
		///  The source
		/// </summary>
		SOURCE,
		/// <summary>
		///  Player's hero
		/// </summary>
		HERO,
		/// <summary>
		///  Player's hero power
		/// </summary>
		HERO_POWER,
		/// <summary>
		///  Opponent's hero power
		/// </summary>
		OP_HERO_POWER,
		/// <summary>
		///  All cards in the player's hand
		/// </summary>
		HAND,
		/// <summary>
		///  All cards in the player's hand except the source
		/// </summary>
		HAND_NOSOURCE,
		/// <summary>
		///  All cards in the player's deck
		/// </summary>
		DECK,
		/// <summary>
		///  Player's secrets
		/// </summary>
		SECRETS,
		/// <summary>
		///  Player's minions
		/// </summary>
		MINIONS,
		/// <summary>
		///  Player's minions except the source
		/// </summary>
		MINIONS_NOSOURCE,
		/// <summary>
		///  All friends characters
		/// </summary>
		FRIENDS,
		/// <summary>
		///  Opponent's Hero
		/// </summary>
		OP_HERO,
		/// <summary>
		///  All cards in the opponent's hand
		/// </summary>
		OP_HAND,
		/// <summary>
		///  All cards in the opponent's deck
		/// </summary>
		OP_DECK,
		/// <summary>
		///  All opponent secret
		/// </summary>
		OP_SECRETS,
		/// <summary>
		///  All opponent minion
		/// </summary>
		OP_MINIONS,
		/// <summary>
		///  All opponent character
		/// </summary>
		ENEMIES,
		/// <summary>
		///  All opponent character except the source
		/// </summary>
		ENEMIES_NOTARGET,
		/// <summary>
		///  All characters
		/// </summary>
		ALL,
		/// <summary>
		///  All characters except the source
		/// </summary>
		ALL_NOSOURCE,
		/// <summary>
		///  Player's weapon
		/// </summary>
		WEAPON,
		/// <summary>
		///  Opponent's weapon
		/// </summary>
		OP_WEAPON,
		/// <summary>
		///  All cards on the stack
		/// </summary>
		STACK,
		/// <summary>
		///  All minions
		/// </summary>
		ALLMINIONS,
		/// <summary>
		///  Invalid
		/// </summary>
		INVALID,
		/// <summary>
		///  All minions except the source
		/// </summary>
		ALLMINIONS_NOSOURCE,
		/// <summary>
		///  All cards in the graveyard
		/// </summary>
		GRAVEYARD,
		/// <summary>
		///  All heroes
		/// </summary>
		HEROES
	}
}
