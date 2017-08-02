namespace SabberStoneCore.Enums
{
	/// <summary>
	/// Indicates the context in which a player has choose between entities.
	/// eg: Mulligan; The player picks cards to mulligan back into his deck.
	/// 
	/// 
	/// The presented set of entities is distinct.
	/// A 'performed' choice can consist of 0 or more picked entities.
	/// </summary>
	public enum EChoiceType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		MULLIGAN = 1,
		GENERAL = 2,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Specifies the consequences of a made choice.
	/// </summary>
	public enum EChoiceAction
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		ADAPT,
		HAND,
		SUMMON,
		HEROPOWER,
		KAZAKUS,
		TRACKING,
		INVALID,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Indicates the type of choice a player can pick from a set of options.
	/// eg: END_TURN; Indicates to the simulator that the player desires to end his turn.
	/// 
	/// The presented set of options is distinct.
	/// A player MUST always pick EXACTLY ONE of the offered options.
	/// </summary>
	public enum EOptionType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		PASS = 1,
		END_TURN = 2,
		POWER = 3,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// State in which a player resides when the game is in Mulligan phase.
	/// Think of Mulligan itself as a state machine within the game, which 
	/// is also a state machine.
	/// </summary>
	public enum EMulligan
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		INPUT = 1,
		DEALING = 2,
		WAITING = 3,
		DONE = 4,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Requirements which have to be met before a card can be player.
	/// The state of the board is checked to match these requirements.
	/// 
	/// A card can have multiple play requirements.
	/// </summary>
	public enum EPlayReq
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		REQ_MINION_TARGET = 1,
		REQ_FRIENDLY_TARGET = 2,
		REQ_ENEMY_TARGET = 3,
		REQ_DAMAGED_TARGET = 4,
		REQ_MAX_SECRETS = 5,
		REQ_FROZEN_TARGET = 6,
		REQ_CHARGE_TARGET = 7,
		REQ_TARGET_MAX_ATTACK = 8,
		REQ_NONSELF_TARGET = 9,
		REQ_TARGET_WITH_RACE = 10,
		REQ_TARGET_TO_PLAY = 11,
		REQ_NUM_MINION_SLOTS = 12,
		REQ_WEAPON_EQUIPPED = 13,
		REQ_ENOUGH_MANA = 14,
		REQ_YOUR_TURN = 15,
		REQ_NONSTEALTH_ENEMY_TARGET = 16,
		REQ_HERO_TARGET = 17,
		REQ_SECRET_ZONE_CAP = 18,
		REQ_MINION_CAP_IF_TARGET_AVAILABLE = 19,
		REQ_MINION_CAP = 20,
		REQ_TARGET_ATTACKED_THIS_TURN = 21,
		REQ_TARGET_IF_AVAILABLE = 22,
		REQ_MINIMUM_ENEMY_MINIONS = 23,
		REQ_TARGET_FOR_COMBO = 24,
		REQ_NOT_EXHAUSTED_ACTIVATE = 25,
		REQ_UNIQUE_SECRET_OR_QUEST = 26,
		REQ_TARGET_TAUNTER = 27,
		REQ_CAN_BE_ATTACKED = 28,
		REQ_ACTION_PWR_IS_MASTER_PWR = 29,
		REQ_TARGET_MAGNET = 30,
		REQ_ATTACK_GREATER_THAN_0 = 31,
		REQ_ATTACKER_NOT_FROZEN = 32,
		REQ_HERO_OR_MINION_TARGET = 33,
		REQ_CAN_BE_TARGETED_BY_SPELLS = 34,
		REQ_SUBCARD_IS_PLAYABLE = 35,
		REQ_TARGET_FOR_NO_COMBO = 36,
		REQ_NOT_MINION_JUST_PLAYED = 37,
		REQ_NOT_EXHAUSTED_HERO_POWER = 38,
		REQ_CAN_BE_TARGETED_BY_OPPONENTS = 39,
		REQ_ATTACKER_CAN_ATTACK = 40,
		REQ_TARGET_MIN_ATTACK = 41,
		REQ_CAN_BE_TARGETED_BY_HERO_POWERS = 42,
		REQ_ENEMY_TARGET_NOT_IMMUNE = 43,
		REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 44,
		REQ_MINIMUM_TOTAL_MINIONS = 45,
		REQ_MUST_TARGET_TAUNTER = 46,
		REQ_UNDAMAGED_TARGET = 47,
		REQ_CAN_BE_TARGETED_BY_BATTLECRIES = 48,
		REQ_STEADY_SHOT = 49,
		REQ_MINION_OR_ENEMY_HERO = 50,
		REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 51,
		REQ_LEGENDARY_TARGET = 52,
		REQ_FRIENDLY_MINION_DIED_THIS_TURN = 53,
		REQ_FRIENDLY_MINION_DIED_THIS_GAME = 54,
		REQ_ENEMY_WEAPON_EQUIPPED = 55,
		REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS = 56,
		REQ_TARGET_WITH_BATTLECRY = 57,
		REQ_TARGET_WITH_DEATHRATTLE = 58,
		REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS = 59,
		REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 60,
		REQ_TARGET_EXACT_COST = 61,
		REQ_STEALTHED_TARGET = 62,
		REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT = 63,
		REQ_MAX_QUESTS = 64,
		REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN = 65
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// State information about controllers in a game. A controller represents 
	/// one player.
	/// </summary>
	public enum EPlayState
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		PLAYING = 1,
		WINNING = 2,
		LOSING = 3,
		WON = 4,
		LOST = 5,
		TIED = 6,
		DISCONNECTED = 7,
		QUIT = 8,
		CONCEDED = 8,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Indicates the state of the Game entity.
	/// </summary>
	public enum EState
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		LOADING = 1,
		RUNNING = 2,
		COMPLETE = 3,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Indicates in which state the Game's state machine is in.
	/// </summary>
	public enum EStep
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		BEGIN_FIRST = 1,
		BEGIN_SHUFFLE = 2,
		BEGIN_DRAW = 3,
		BEGIN_MULLIGAN = 4,
		MAIN_BEGIN = 5,
		MAIN_READY = 6,
		MAIN_RESOURCE = 7,
		MAIN_DRAW = 8,
		MAIN_START = 9,
		MAIN_ACTION = 10,
		MAIN_COMBAT = 11,
		MAIN_END = 12,
		MAIN_NEXT = 13,
		FINAL_WRAPUP = 14,
		FINAL_GAMEOVER = 15,
		MAIN_CLEANUP = 16,
		MAIN_START_TRIGGERS = 17,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Abstract area where entities reside during the game.
	/// Each controller has it's own set of zones, these are not shared
	/// with other players.
	/// 
	/// eg: <see cref="EZone.PLAY"/>: contains all entities that are on the board.
	/// eg: <see cref="EZone.DECK"/>: contains all entities which are not yet drawn into <see cref="EZone.HAND"/>.
	/// </summary>
	public enum EZone
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		//DISCARD = -2,
		INVALID = 0,
		PLAY = 1,
		DECK = 2,
		HAND = 3,
		GRAVEYARD = 4,
		REMOVEDFROMGAME = 5,
		SETASIDE = 6,
		SECRET = 7,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// These tags represent properties of entities. They must be seen as noncomplex and have
	/// no relation with each other.
	/// 
	/// eg: <see cref="EGameTag.HEALTH"/>: holds the maximum health of this entity, including buffs.
	/// eg: <see cref="EGameTag.DAMAGE"/>: holds the amount of damage inflicted onto this entity.
	/// Both properties have no relation with each other and the available amount of health is calculated
	/// from these properties and others.
	/// </summary>
	public enum EGameTag
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		IGNORE_DAMAGE = 1,
		TAG_SCRIPT_DATA_NUM_1 = 2,
		TAG_SCRIPT_DATA_NUM_2 = 3,
		TAG_SCRIPT_DATA_ENT_1 = 4,
		TAG_SCRIPT_DATA_ENT_2 = 5,
		MISSION_EVENT = 6,
		TIMEOUT = 7,
		TURN_START = 8,
		TURN_TIMER_SLUSH = 9,
		//10 GameTag, seems set to 85 always seconds?
		//11 MinionTag, Controller, ??? used with Potion of Madness  (11 newController,Charge,333 oldController)
		PREMIUM = 12,
		GOLD_REWARD_STATE = 13,
		PLAYSTATE = 17,
		LAST_AFFECTED_BY = 18,
		STEP = 19,
		TURN = 20,
		FATIGUE = 22,
		CURRENT_PLAYER = 23,
		FIRST_PLAYER = 24,
		RESOURCES_USED = 25,
		RESOURCES = 26,
		HERO_ENTITY = 27,
		MAXHANDSIZE = 28,
		STARTHANDSIZE = 29,
		PLAYER_ID = 30,
		TEAM_ID = 31,
		TRIGGER_VISUAL = 32,
		RECENTLY_ARRIVED = 33,
		PROTECTED = 34,
		PROTECTING = 35,
		DEFENDING = 36,
		PROPOSED_DEFENDER = 37,
		ATTACKING = 38,
		PROPOSED_ATTACKER = 39,
		ATTACHED = 40,
		EXHAUSTED = 43,
		DAMAGE = 44,
		HEALTH = 45,
		ATK = 47,
		COST = 48,
		ZONE = 49,
		CONTROLLER = 50,
		OWNER = 51,
		DEFINITION = 52,
		ENTITY_ID = 53,
		HISTORY_PROXY = 54,
		COPY_DEATHRATTLE = 55,
		COPY_DEATHRATTLE_INDEX = 56,
		ELITE = 114,
		MAXRESOURCES = 176,
		CARD_SET = 183,
		CARDTEXT_INHAND = 184,
		CARDNAME = 185,
		CARD_ID = 186,
		DURABILITY = 187,
		SILENCED = 188,
		WINDFURY = 189,
		TAUNT = 190,
		STEALTH = 191,
		SPELLPOWER = 192,
		DIVINE_SHIELD = 194,
		CHARGE = 197,
		NEXT_STEP = 198,
		CLASS = 199,
		CARDRACE = 200,
		FACTION = 201,
		CARDTYPE = 202,
		RARITY = 203,
		STATE = 204,
		SUMMONED = 205,
		FREEZE = 208,
		ENRAGED = 212,
		OVERLOAD = 215,
		LOYALTY = 216,
		DEATHRATTLE = 217,
		BATTLECRY = 218,
		SECRET = 219,
		COMBO = 220,
		CANT_HEAL = 221,
		CANT_DAMAGE = 222,
		CANT_SET_ASIDE = 223,
		CANT_REMOVE_FROM_GAME = 224,
		CANT_READY = 225,
		CANT_EXHAUST = 226,
		CANT_ATTACK = 227,
		CANT_TARGET = 228,
		CANT_DESTROY = 229,
		CANT_DISCARD = 230,
		CANT_PLAY = 231,
		CANT_DRAW = 232,
		INCOMING_HEALING_MULTIPLIER = 233,
		INCOMING_HEALING_ADJUSTMENT = 234,
		INCOMING_HEALING_CAP = 235,
		INCOMING_DAMAGE_MULTIPLIER = 236,
		INCOMING_DAMAGE_ADJUSTMENT = 237,
		INCOMING_DAMAGE_CAP = 238,
		CANT_BE_HEALED = 239,
		IMMUNE = 240,
		CANT_BE_SET_ASIDE = 241,
		CANT_BE_REMOVED_FROM_GAME = 242,
		CANT_BE_READIED = 243,
		CANT_BE_EXHAUSTED = 244,
		CANT_BE_ATTACKED = 245,
		CANT_BE_TARGETED = 246,
		CANT_BE_DESTROYED = 247,
		AttackVisualType = 251,
		CardTextInPlay = 252,
		CANT_BE_SUMMONING_SICK = 253,
		FROZEN = 260,
		JUST_PLAYED = 261,
		LINKED_ENTITY = 262,
		ZONE_POSITION = 263,
		CANT_BE_FROZEN = 264,
		COMBO_ACTIVE = 266,
		CARD_TARGET = 267,
		DevState = 268,
		NUM_CARDS_PLAYED_THIS_TURN = 269,
		CANT_BE_TARGETED_BY_OPPONENTS = 270,
		NUM_TURNS_IN_PLAY = 271,
		NUM_TURNS_LEFT = 272,
		OUTGOING_DAMAGE_CAP = 273,
		OUTGOING_DAMAGE_ADJUSTMENT = 274,
		OUTGOING_DAMAGE_MULTIPLIER = 275,
		OUTGOING_HEALING_CAP = 276,
		OUTGOING_HEALING_ADJUSTMENT = 277,
		OUTGOING_HEALING_MULTIPLIER = 278,
		INCOMING_ABILITY_DAMAGE_ADJUSTMENT = 279,
		INCOMING_COMBAT_DAMAGE_ADJUSTMENT = 280,
		OUTGOING_ABILITY_DAMAGE_ADJUSTMENT = 281,
		OUTGOING_COMBAT_DAMAGE_ADJUSTMENT = 282,
		OUTGOING_ABILITY_DAMAGE_MULTIPLIER = 283,
		OUTGOING_ABILITY_DAMAGE_CAP = 284,
		INCOMING_ABILITY_DAMAGE_MULTIPLIER = 285,
		INCOMING_ABILITY_DAMAGE_CAP = 286,
		OUTGOING_COMBAT_DAMAGE_MULTIPLIER = 287,
		OUTGOING_COMBAT_DAMAGE_CAP = 288,
		INCOMING_COMBAT_DAMAGE_MULTIPLIER = 289,
		INCOMING_COMBAT_DAMAGE_CAP = 290,
		CURRENT_SPELLPOWER = 291,
		ARMOR = 292,
		MORPH = 293,
		IS_MORPHED = 294,
		TEMP_RESOURCES = 295,
		OVERLOAD_OWED = 296,
		NUM_ATTACKS_THIS_TURN = 297,
		NEXT_ALLY_BUFF = 302,
		MAGNET = 303,
		FIRST_CARD_PLAYED_THIS_TURN = 304,
		MULLIGAN_STATE = 305,
		TAUNT_READY = 306,
		STEALTH_READY = 307,
		CHARGE_READY = 308,
		CANT_BE_TARGETED_BY_SPELLS = 311,
		SHOULDEXITCOMBAT = 312,
		CREATOR = 313,
		CANT_BE_SILENCED = 314,
		PARENT_CARD = 316,
		NUM_MINIONS_PLAYED_THIS_TURN = 317,
		PREDAMAGE = 318,
		COLLECTIBLE = 321,
		//323 EnchantmentTag, true ... when weapon equipped
		//324 EnchantmentTag
		TARGETING_ARROW_TEXT = 325,
		ENCHANTMENT_BIRTH_VISUAL = 330,
		ENCHANTMENT_IDLE_VISUAL = 331,
		CANT_BE_TARGETED_BY_HERO_POWERS = 332,
		//333 MinionTag, turns till effect? Or controller change after turn?
		WEAPON = 334,
		InvisibleDeathrattle = 335,
		HEALTH_MINIMUM = 337,
		TAG_ONE_TURN_EFFECT = 338,
		SILENCE = 339,
		COUNTER = 340,
		//341 MinionTag, true/false
		ARTISTNAME = 342,
		LocalizationNotes = 344,
		HAND_REVEALED = 348,
		ImmuneToSpellpower = 349,
		ADJACENT_BUFF = 350,
		FLAVORTEXT = 351,
		FORCED_PLAY = 352,
		LOW_HEALTH_THRESHOLD = 353,
		IGNORE_DAMAGE_OFF = 354,
		GrantCharge = 355,
		SPELLPOWER_DOUBLE = 356,
		HEALING_DOUBLE = 357,
		NUM_OPTIONS_PLAYED_THIS_TURN = 358,
		NUM_OPTIONS = 359,
		TO_BE_DESTROYED = 360,
		HealTarget = 361,
		AURA = 362,
		POISONOUS = 363,
		HOW_TO_EARN = 364,
		HOW_TO_EARN_GOLDEN = 365,
		HERO_POWER_DOUBLE = 366,
		AI_MUST_PLAY = 367,
		NUM_MINIONS_PLAYER_KILLED_THIS_TURN = 368,
		NUM_MINIONS_KILLED_THIS_TURN = 369,
		AFFECTED_BY_SPELL_POWER = 370,
		EXTRA_DEATHRATTLES = 371,
		START_WITH_1_HEALTH = 372,
		IMMUNE_WHILE_ATTACKING = 373,
		MULTIPLY_HERO_DAMAGE = 374,
		MULTIPLY_BUFF_VALUE = 375,
		CUSTOM_KEYWORD_EFFECT = 376,
		TOPDECK = 377,
		CANT_BE_TARGETED_BY_BATTLECRIES = 379,
		HERO_POWER = 380,
		DEATHRATTLE_RETURN_ZONE = 382,
		STEADY_SHOT_CAN_TARGET = 383,
		DISPLAYED_CREATOR = 385,
		POWERED_UP = 386,
		SPARE_PART = 388,
		FORGETFUL = 389,
		CAN_SUMMON_MAXPLUSONE_MINION = 390,
		OBFUSCATED = 391,
		BURNING = 392,
		OVERLOAD_LOCKED = 393,
		NUM_TIMES_HERO_POWER_USED_THIS_GAME = 394,
		CURRENT_HEROPOWER_DAMAGE_BONUS = 395,
		HEROPOWER_DAMAGE = 396,
		LAST_CARD_PLAYED = 397,
		NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_TURN = 398,
		NUM_CARDS_DRAWN_THIS_TURN = 399,
		AI_ONE_SHOT_KILL = 400,
		EVIL_GLOW = 401,
		HIDE_STATS = 402,
		INSPIRE = 403,
		RECEIVES_DOUBLE_SPELLDAMAGE_BONUS = 404,
		HEROPOWER_ADDITIONAL_ACTIVATIONS = 405,
		HEROPOWER_ACTIVATIONS_THIS_TURN = 406,
		REVEALED = 410,
		//411 IMPLEMENTED
		NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_GAME = 412,
		CANNOT_ATTACK_HEROES = 413,
		LOCK_AND_LOAD = 414,
		DISCOVER = 415,
		SHADOWFORM = 416,
		NUM_FRIENDLY_MINIONS_THAT_ATTACKED_THIS_TURN = 417,
		NUM_RESOURCES_SPENT_THIS_GAME = 418,
		CHOOSE_BOTH = 419,
		ELECTRIC_CHARGE_LEVEL = 420,
		HEAVILY_ARMORED = 421,
		DONT_SHOW_IMMUNE = 422,
		RITUAL = 424,
		PREHEALING = 425,
		APPEAR_FUNCTIONALLY_DEAD = 426,
		OVERLOAD_THIS_GAME = 427,
		//430 IMPLEMENTED
		SPELLS_COST_HEALTH = 431,
		HISTORY_PROXY_NO_BIG_CARD = 432,
		PROXY_CTHUN = 434,
		TRANSFORMED_FROM_CARD = 435,
		CTHUN = 436,
		CAST_RANDOM_SPELLS = 437,
		SHIFTING = 438,
		JADE_GOLEM = 441,
		EMBRACE_THE_SHADOW = 442,
		CHOOSE_ONE = 443,
		EXTRA_ATTACKS_THIS_TURN = 444,
		SEEN_CTHUN = 445,
		MINION_TYPE_REFERENCE = 447,
		UNTOUCHABLE = 448,
		RED_MANA_CRYSTALS = 449,
		SCORE_LABELID_1 = 450,
		SCORE_VALUE_1 = 451,
		SCORE_LABELID_2 = 452,
		SCORE_VALUE_2 = 453,
		SCORE_LABELID_3 = 454,
		SCORE_VALUE_3 = 455,
		CANT_BE_FATIGUED = 456,
		AUTOATTACK = 457,
		ARMS_DEALING = 458,
		PENDING_EVOLUTIONS = 461,
		QUEST = 462,
		TAG_LAST_KNOWN_COST_IN_HAND = 466,
		//467 IMPLEMENTED
		//468 IMPLEMENTED
		DEFINING_ENCHANTMENT = 469,
		FINISH_ATTACK_SPELL_ON_DAMAGE = 470,
		KAZAKUS_POTION_POWER_1 = 471,
		KAZAKUS_POTION_POWER_2 = 472,
		MODIFY_DEFINITION_ATTACK = 473,
		MODIFY_DEFINITION_HEALTH = 474,
		MODIFY_DEFINITION_COST = 475,
		MULTIPLE_CLASSES = 476,
		ALL_TARGETS_RANDOM = 477,
		// 478, true on quest cards ???
		//479 IMPLEMENTED
		MULTI_CLASS_GROUP = 480,
		CARD_COSTS_HEALTH = 481,
		GRIMY_GOONS = 482,
		JADE_LOTUS = 483,
		KABAL = 484,
		ADDITIONAL_PLAY_REQS_1 = 515,
		ADDITIONAL_PLAY_REQS_2 = 516,
		ELEMENTAL_POWERED_UP = 532,
		QUEST_PROGRESS = 534,
		QUEST_PROGRESS_TOTAL = 535,
		QUEST_CONTRIBUTOR = 541,
		ADAPT = 546,
		IS_CURRENT_TURN_AN_EXTRA_TURN = 547,
		EXTRA_TURNS_TAKEN_THIS_GAME = 548,
		SHIFTING_MINION = 549,
		SHIFTING_WEAPON = 550,
		BOSS = 556,
		STAMPEDE = 564,
		// 676, true on quests cards ???
		CORRUPTED = 681,

		// more or less guessed gametags
		EXTRA_BATTLECRY = 411, //ControllerTag, true/false Bronzebard Extra Battlecry
		NUM_SPELLS_PLAYED_THIS_TURN = 430, // need to implement it ^^
		NUM_CARDS_TO_DRAW = 467,
		MOAT_LURKER_MINION = 468,
		TAG_LAST_KNOWN_ATK_IN_HAND = 479, // ???

		NUM_SPELLS_PLAYED_THIS_GAME = 1001,
		NUM_SECRETS_PLAYED_THIS_GAME = 1002,
		NUM_WEAPONS_PLAYED_THIS_GAME = 1003,
		LAST_CARD_DRAWN = 1004,
		LAST_CARD_DISCARDED = 1005,
		NUM_ELEMENTAL_PLAYED_THIS_TURN = 1006,
		NUM_ELEMENTAL_PLAYED_LAST_TURN = 1007,
		NUM_MURLOCS_PLAYED_THIS_GAME = 1008,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
