namespace SabberStoneCore.Enums
{
	/// <summary>
	/// The history of a game is built from POWER blocks.
	/// These block can be nested and can contain <see cref="EMetaDataType"/> blocks.
	/// Each block can have (different) attributes assigned, like ENTITYID.
	/// </summary>
	public enum EPowerType
	{
		/// <summary>A block which creates a new known (CARDID is known) entity.</summary>
		FULL_ENTITY = 1,
		/// <summary>A certain entity makes its CARDID known.</summary>
		SHOW_ENTITY = 2,
		/// <summary>The CARDID of a certain entity becomes hidden.</summary>
		HIDE_ENTITY = 3,
		/// <summary>Contains one tag change for a certain entity.</summary>
		TAG_CHANGE = 4,
		/// <summary>Used to nest and group other POWER blocks together.</summary>
		BLOCK_START = 5,
		//ACTION_START = 5,		
		/// <summary>Ends a sequence of blocks started by BLOCK_START.</summary>
		BLOCK_END = 6,
		//ACTION_END = 6,		
		/// <summary>First block indicating game creation.
		/// This block contains creation of Game, Player 1 and Player 2 entities.
		/// </summary>
		CREATE_GAME = 7,
		/// <summary>Contains information to visualize history. <seealso cref="EMetaDataType"/></summary>
		META_DATA = 8,
		/// <summary>Used to transform an entity into another CARDID.</summary>
		CHANGE_ENTITY = 9,
	}

	/// <summary>
	/// Used as parameter on <see cref="EPowerType.BLOCK_START"/>. Indicates the 
	/// reason why the following tag changes occur.
	/// 
	/// eg: ATTACK holds tag changes which are the result of one entity attacking
	/// another. The entity that attacks can be found by reading the ENTITYID attribute 
	/// on the POWER BLOCK.
	/// -> The block starts of with marking entities as proposed attacker and
	/// defenders. 
	/// -> The game goes through the phases which belong to the ATTACK process.
	/// .. end of block
	/// </summary>
	public enum EBlockType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		ATTACK = 1,
		JOUST = 2,
		POWER = 3,
		SCRIPT = 4,
		TRIGGER = 5,
		DEATHS = 6,
		PLAY = 7,
		FATIGUE = 8,
		RITUAL = 9,
		ACTION = 99,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// A METADATA block contains information about animations that have to be played
	/// out client side.
	/// METADATA blocks are contained within POWER BLOCKS, explicitly between
	/// <see cref="EPowerType.BLOCK_START"/> and <see cref="EPowerType.BLOCK_END"/>.
	/// Just like <see cref="EBlockType"/> this enumeration indicates the reason for tag changes.
	/// 
	/// eg: TARGET dictates that the subject entity of the parent POWER block has a specific target
	/// for it's effect.
	/// -> The block contains Info objects (OR an int as payload) which are to be used as parameter
	/// of the METADATATYPE.
	/// </summary>
	public enum EMetaDataType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		META_TARGET = 0,
		TARGET = 0,
		META_DAMAGE = 1,
		DAMAGE = 1,
		META_HEALING = 2,
		HEALING = 2,
		JOUST = 3,
		CLIENT_HISTORY = 4,
		SHOW_BIG_CARD = 5,
		EFFECT_TIMING = 6,
		HISTORY_TARGET = 7,
		OVERRIDE_HISTORY = 8,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
