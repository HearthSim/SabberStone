#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
namespace SabberStoneCore.Enums
{
	/// <summary>
	/// Enumeration used WITHIN HISTORY data, interpreted by the real HS client;
	/// </summary>
	public enum BlockType
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
		REVEAL_CARD = 10,
		GAME_RESET = 11,
		MOVE_MINION = 12,
		ACTION = 99
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// UNUSED
	/// </summary>
	public enum BnetGameType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		BGT_UNKNOWN = 0,
		BGT_FRIENDS = 1,
		BGT_RANKED_STANDARD = 2,
		BGT_ARENA = 3,
		BGT_VS_AI = 4,
		BGT_TUTORIAL = 5,
		BGT_ASYNC = 6,
		BGT_CASUAL_STANDARD_NEWBIE = 9,
		BGT_CASUAL_STANDARD_NORMAL = 10,
		BGT_TEST1 = 11,
		BGT_TEST2 = 12,
		BGT_TEST3 = 13,
		BGT_TAVERNBRAWL_PVP = 16,
		BGT_TAVERNBRAWL_1P_VERSUS_AI = 17,
		BGT_TAVERNBRAWL_2P_COOP = 18,
		BGT_RANKED_WILD = 30,
		BGT_CASUAL_WILD = 31,
		BGT_FSG_BRAWL_VS_FRIEND = 40,
		BGT_FSG_BRAWL_PVP = 41,
		BGT_FSG_BRAWL_1P_VERSUS_AI = 42,
		BGT_FSG_BRAWL_2P_COOP = 43,
		//BGT_TOURNAMENT = 44
		BGT_RANKED_STANDARD_NEW_PLAYER = 45,
		//BGT_LAST = 46
		BGT_BATTLEGROUNDS = 50
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// UNUSED
	/// </summary>
	public enum BnetRegion
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		REGION_UNINITIALIZED = -1,
		REGION_UNKNOWN = 0,
		REGION_US = 1,
		REGION_EU = 2,
		REGION_KR = 3,
		REGION_TW = 4,
		REGION_CN = 5,
		REGION_LIVE_VERIFICATION = 40,
		REGION_PTR_LOC = 41
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// UNUSED
	/// </summary>
	public enum Booster
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		CLASSIC = 1,
		GOBLINS_VS_GNOMES = 9,
		THE_GRAND_TOURNAMENT = 10,
		OLD_GODS = 11,
		FIRST_PURCHASE_OLD = 17,
		SIGNUP_INCENTIVE = 18,
		MEAN_STREETS = 19,
		UNGORO = 20,
		FROZEN_THRONE = 21,
		GOLDEN_CLASSIC_PACK = 23,
		KOBOLDS_AND_CATACOMBS = 30,
		WITCHWOOD = 31,
		THE_BOOMSDAY_PROJECT = 38,
		RASTAKHANS_RUMBLE = 40,
		MAMMOTH_BUNDLE = 41,
		DALARAN = 49,
		FIRST_PURCHASE = 181
	}
	/// <summary>
	/// UNUSED
	/// </summary>
	public enum BrawlType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		BRAWL_TYPE_UNKNOWN = 0,
		BRAWL_TYPE_TAVERN_BRAWL = 1,
		BRAWL_TYPE_FIRESIDE_GATHERING = 2,
		BRAWL_TYPE_COUNT = 3
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Class of a card.
	/// Cards which have a neutral class are allowed in all decks.
	/// When a deck is bound to a specific class, only cards of the same
	/// class and neutral cards are allowed in that deck.
	/// </summary>
	public enum CardClass
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		// Custom enums for easy syntax.
		ANOTHER_CLASS = -2,
		OP_CLASS = -1,

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
		WHIZBANG = 13
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Mutual exclusive sets to which cards can belong.
	/// </summary>
	public enum CardSet
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
		UNGORO = 27,
		ICECROWN = 1001,
		LOOTAPALOOZA = 1004,
		GILNEAS = 1125,
		BOOMSDAY = 1127,
		TROLL = 1129,
		DALARAN = 1130,
		//TAVERNS_OF_TIME = 1143,
		ULDUM = 1158,
		DRAGONS = 1347,
		WILD_EVENT = 1439,
		BATTLEGROUNDS = 1453
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Meta information about a card.
	///
	/// Cards CAN BE heroes or hero powers or minions or spells..
	/// </summary>
	public enum CardType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		GAME = 1,
		PLAYER = 2,
		HERO = 3,
		MINION = 4,
		SPELL = 5,
		ENCHANTMENT = 6,
		WEAPON = 7,
		ITEM = 8,
		TOKEN = 9,
		HERO_POWER = 10,
		BLANK = 11,
		GAME_MODE_BUTTON = 12,
		MOVE_MINION_HOVER_TARGET = 22
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Indicates the context in which a player has choose between entities.
	/// eg: Mulligan; The player picks cards to mulligan back into his deck.
	///
	///
	/// The presented set of entities is distinct.
	/// A 'performed' choice can consist of 0 or more picked entities.
	/// </summary>
	public enum ChoiceType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		MULLIGAN = 1,
		GENERAL = 2,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// UNUSED
	/// </summary>
	public enum DeckType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		CLIENT_ONLY_DECK = -1,
		UNKNOWN_DECK_TYPE = 0,
		NORMAL_DECK = 1,
		AI_DECK = 2,
		DRAFT_DECK = 4,
		PRECON_DECK = 5,
		TAVERN_BRAWL_DECK = 6,
		FSG_BRAWL_DECK = 7,
		//FRIENDLY_TOURNAMENT_DECK = 8,
		HIDDEN_DECK = 1000
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// UNUSED
	/// </summary>
	public enum DungeonRewardOption
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		LOOT = 1,
		TREASURE = 2,
		SHRINE_TREASURE = 3,
		HERO_POWER = 4,
		DECK = 5
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	/// <summary>
	/// TODO;
	/// </summary>
	public enum EnchantmentVisual
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		POSITIVE = 1,
		NEGATIVE = 2,
		NEUTRAL = 3,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Another mutual exclusive classification of cards.
	/// </summary>
	public enum Faction
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		HORDE = 1,
		ALLIANCE = 2,
		NEUTRAL = 3,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Indicates the format of decks, which limits
	/// the allowed cards that can be put into that deck.
	/// Generally each type has a matching set of cards (wild set
	/// for wild format) which contains all cards that are allowed
	/// to be put into a deck of type WILD.
	/// </summary>
	public enum FormatType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		FT_UNKNOWN = 0,
		FT_WILD = 1,
		FT_STANDARD = 2
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// These tags represent properties of entities. They must be seen as noncomplex and have
	/// no relation with each other.
	///
	/// eg: <see cref="HEALTH"/>: holds the maximum health of this entity, including buffs.
	/// eg: <see cref="DAMAGE"/>: holds the amount of damage inflicted onto this entity.
	/// Both properties have no relation with each other and the available amount of health is calculated
	/// from these properties and others.
	/// </summary>
	public enum GameTag
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
		CARDTEXT = 184,
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
		HEADCRACK_COMBO = 298, // more or less guessed gametags
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
		HEALING_DOES_DAMAGE = 326, // more or less guessed gametags
		DATABASE_ID = 327,
		ENCHANTMENT_BIRTH_VISUAL = 330,
		ENCHANTMENT_IDLE_VISUAL = 331,
		CANT_BE_TARGETED_BY_HERO_POWERS = 332,
		CONTROLLER_CHANGED_THIS_TURN = 333, // more or less guessed gametags: Potion of Madness, Shadow Madness, Embrace Darkness
		WEAPON = 334,
		InvisibleDeathrattle = 335,
		HEALTH_MINIMUM = 337,
		TAG_ONE_TURN_EFFECT = 338,
		SILENCE = 339,
		COUNTER = 340,
		//341 MinionTag, true/false
		ARTISTNAME = 342,
		LocalizationNotes = 344,
		ZONES_REVEALED = 348,
		ImmuneToSpellpower = 349,
		ADJACENT_BUFF = 350,
		FLAVORTEXT = 351,
		FORCED_PLAY = 352,
		LOW_HEALTH_THRESHOLD = 353,
		IGNORE_DAMAGE_OFF = 354,
		GrantCharge = 355,
		SPELLPOWER_DOUBLE = 356,
		SPELL_HEALING_DOUBLE = 357,
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
		EXTRA_MINION_DEATHRATTLES_BASE = 371,
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
		EXTRA_BATTLECRIES_BASE = 411, // more or less guessed gametags: ControllerTag, true/false Bronzebard Extra Battlecry
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
		NUM_SPELLS_PLAYED_THIS_TURN = 430, // more or less guessed gametags: need to implement it ^^
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
		NUM_CARDS_TO_DRAW = 467, // more or less guessed gametags
		MOAT_LURKER_MINION = 468, // more or less guessed gametags
		DEFINING_ENCHANTMENT = 469,
		FINISH_ATTACK_SPELL_ON_DAMAGE = 470,
		MODULAR_ENTITY_PART_1 = 471,
		MODULAR_ENTITY_PART_2 = 472,
		MODIFY_DEFINITION_ATTACK = 473,
		MODIFY_DEFINITION_HEALTH = 474,
		MODIFY_DEFINITION_COST = 475,
		MULTIPLE_CLASSES = 476,
		ALL_TARGETS_RANDOM = 477,
		// 478, true on quest cards ???
		TAG_LAST_KNOWN_ATK_IN_HAND = 479,// more or less guessed gametags: ???
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
		DEATH_KNIGHT = 554,
		BOSS = 556,
		TREASURE = 557,
		TREASURE_DEFINTIONAL_ATTACK = 558,
		TREASURE_DEFINTIONAL_COST = 559,
		TREASURE_DEFINTIONAL_HEALTH = 560,
		ACTS_LIKE_A_SPELL = 561,
		STAMPEDE = 564,
		EMPOWERED_TREASURE = 646,
		ONE_SIDED_GHOSTLY = 648,
		CURRENT_NEGATIVE_SPELLPOWER = 651,
		// 676, true on quests cards ???
		IS_VAMPIRE = 680,
		CORRUPTED = 681,
		HIDE_HEALTH = 682,
		HIDE_ATTACK = 683,
		HIDE_COST = 684,
		LIFESTEAL = 685,
		OVERRIDE_EMOTE_0 = 740,
		OVERRIDE_EMOTE_1 = 741,
		OVERRIDE_EMOTE_2 = 742,
		OVERRIDE_EMOTE_3 = 743,
		OVERRIDE_EMOTE_4 = 744,
		OVERRIDE_EMOTE_5 = 745,
		SCORE_FOOTERID = 751,
		EXTRA_END_TURN_EFFECT = 755, // more or less guessed gametags: ???
		RECRUIT = 763,
		LOOT_CARD_1 = 764,
		LOOT_CARD_2 = 765,
		LOOT_CARD_3 = 766,
		HERO_POWER_DISABLED = 777,
		VALEERASHADOW = 779,
		OVERRIDECARDNAME = 781,
		OVERRIDECARDTEXTBUILDER = 782,
		DUNGEON_PASSIVE_BUFF = 783,
		GHOSTLY = 785,
		DISGUISED_TWIN = 788,
		SECRET_DEATHRATTLE = 789,
		RUSH = 791,
		REVEAL_CHOICES = 792,
		HERO_DECK_ID = 793,
		HIDDEN_CHOICE = 813,
		AMOUNT_HERO_HEALED_THIS_TURN = 821, // more or less guessed gametags
		ZOMBEAST = 823,
		HERO_EMOTE_SILENCED = 832,
		MINION_IN_HAND_BUFF = 845,
		ECHO = 846,
		MODULAR = 849,
		KEEP_ENCHANTMENTS = 851, // more or less guessed gametags
		IGNORE_HIDE_STATS_FOR_BIG_CARD = 857,
		REAL_TIME_TRANSFORM = 859,
		WAIT_FOR_PLAYER_RECONNECT_PERIOD = 860,
		ETHEREAL = 880,
		EXTRA_DEATHRATTLES_BASE = 882,
		PHASED_RESTART = 888,
		DISCARD_CARDS = 890,
		HEALTH_DISPLAY = 917,
		ENABLE_HEALTH_DISPLAY = 920,
		VOODOO_LINK = 921,
		OVERKILL = 923,
		PROPHECY = 924,
		ATTACKABLE_BY_RUSH = 930,
		SHIFTING_SPELL = 936,
		USE_ALTERNATE_CARD_TEXT = 955,
		SUPPRESS_DEATH_SOUND = 959,
		ECHOING_OOZE_SPELL = 963,
		COLLECTIONMANAGER_FILTER_MANA_EVEN = 956,
		COLLECTIONMANAGER_FILTER_MANA_ODD = 957,
		AMOUNT_HEALED_THIS_GAME = 958,
		ZOMBEAST_DEBUG_CURRENT_BEAST_DATABASE_ID = 964,
		ZOMBEAST_DEBUG_CURRENT_ITERATION = 965,
		ZOMBEAST_DEBUG_MAX_ITERATIONS = 966,
		START_OF_GAME = 968,
		ENCHANTMENT_INVISIBLE = 976,
		PUZZLE = 979,
		PUZZLE_PROGRESS = 980,
		PUZZLE_PROGRESS_TOTAL = 981,
		PUZZLE_TYPE = 982,
		PUZZLE_COMPLETED = 984,
		CONCEDE_BUTTON_ALTERNATIVE_TEXT = 985,
		HIDE_RESTART_BUTTON = 990,
		WILD = 991,
		HALL_OF_FAME = 992,
		MARK_OF_EVIL = 994,
		DECK_RULE_MOD_DECK_SIZE = 997,
		FAST_BATTLECRY = 998,
		END_TURN_BUTTON_ALTERNATIVE_APPEARANCE = 1000,
		NUM_SPELLS_PLAYED_THIS_GAME = 1001, // more or less guessed gametags
		WEATHER = 1002,
		NUM_WEAPONS_PLAYED_THIS_GAME = 1003, // more or less guessed gametags
		LAST_CARD_DRAWN = 1004, // more or less guessed gametags
		LAST_CARD_DISCARDED = 1005, // more or less guessed gametags
		NUM_ELEMENTAL_PLAYED_THIS_TURN = 1006, // more or less guessed gametags
		NUM_ELEMENTAL_PLAYED_LAST_TURN = 1007, // more or less guessed gametags
		NUM_MURLOCS_PLAYED_THIS_GAME = 1008, // more or less guessed gametags
		TAG_LAST_KNOWN_POSITION_ON_BOARD = 1009, // more or less guessed gametags: position aren't changed in graveyard and setaside zone ??? obolet?
		NUM_SECRETS_PLAYED_THIS_GAME = 1010, // more or less guessed gametags, moved from previous 1002
		WEATHERSNOWSTORM = 1012,
		WEATHERTHUNDERSTORM = 1013,
		WEATHERFIRESTORM = 1014,
		WAND = 1015,
		TREAT_AS_PLAYED_HERO_CARD = 1016,
		NUM_HERO_POWER_DAMAGE_THIS_GAME = 1025,
		PUZZLE_NAME = 1026,
		TURN_INDICATOR_ALTERNATIVE_APPEARANCE = 1027,
		PREVIOUS_PUZZLE_COMPLETED = 1042,
		GLORIOUSGLOOP = 1044,
		HEALTH_DISPLAY_COLOR = 1046,
		HEALTH_DISPLAY_NEGATIVE = 1047,
		WHIZBANG_DECK_ID = 1048,
		HIDE_OUT_OF_CARDS_WARNING = 1050,
		GEARS = 1052,
		LUNAHIGHLIGHTHINT = 1054,
		SUPPRESS_JOBS_DONE_VO = 1055,
		SHRINE = 1057,
		ALL_HEALING_DOUBLE = 1058,
		BLOCK_ALL_INPUT = 1071,
		PUZZLE_MODE = 1073,
		CARD_DOES_NOTHING = 1075,
		CASTSWHENDRAWN = 1077,
		DISPLAY_CARD_ON_MOUSEOVER = 1078,
		DECK_POWER_UP = 1080,
		SIDEKICK = 1081,
		SIDEKICK_HERO_POWER = 1082,
		REBORN = 1085,
		SQUELCH_NON_GAME_TRIGGERS_AND_MODIFIERS = 1087,
		QUEST_REWARD_DATABASE_ID = 1089,
		DORMANT = 1090,
		CUSTOMTEXT1 = 1093,
		CUSTOMTEXT2 = 1094,
		CUSTOMTEXT3 = 1095,
		FLOOPY = 1097,
		PLAYER_BASE_SHRINE_DECK_ID = 1099,
		HIDE_WATERMARK = 1107,
		EXTRA_MINION_BATTLECRIES_BASE = 1112,
		RUN_PROGRESS = 1113,
		NON_KEYWORD_ECHO = 1114,
		PLAYER_TAG_THRESHOLD_TAG_ID = 1115,
		PLAYER_TAG_THRESHOLD_VALUE = 1116,
		HEALING_DOES_DAMAGE_HINT = 1117,
		AFFECTED_BY_HEALING_DOES_DAMAGE = 1118,
		DECK_LIST_SORT_ORDER = 1125,
		EXTRA_BATTLECRIES_ADDITIONAL = 1126,
		EXTRA_DEATHRATTLES_ADDITIONAL = 1131,
		ALTERNATE_MOUSE_OVER_CARD = 1132,
		ENCHANTMENT_BANNER_TEXT = 1135,
		MOUSE_OVER_CARD_APPEARANCE = 1142,
		IS_ADVENTURE_SCENARIO = 1172,
		TWINSPELL_COPY = 1186,
		PROXY_GALAKROND = 1190,
		SIDEQUEST = 1192,
		TWINSPELL = 1193,
		GALAKROND_IN_PLAY = 1194,
		COIN_MANA_GEM = 1199,
		MEGA_WINDFURY = 1207,
		EMPOWER = 1263,
		EMPOWER_PRIEST = 1264,
		EMPOWER_ROGUE = 1265,
		EMPOWER_SHAMAN = 1266,
		EMPOWER_WARLOCK = 1267,
		EMPOWER_WARRIOR = 1268,
		TWINSPELLPENDING = 1269,
		DRUSTVAR_HORROR_DEBUG_CURRENT_SPELL_DATABASE_ID = 1280,
		DRUSTVAR_HORROR_DEBUG_CURRENT_ITERATION = 1281,
		HEROIC_HERO_POWER = 1282,
		DRUSTVAR_HORROR_DEBUG_MAX_ITERATIONS = 1283,
		CREATOR_DBID = 1284,
		FATIGUEREFERENCE = 1290,
		HERO_FLYING = 1293,
		UI_BUFF_HEALTH_UP = 1294,
		UI_BUFF_SET_COST_ZERO = 1295,
		UI_BUFF_COST_DOWN = 1296,
		UI_BUFF_ATK_UP = 1297,
		UI_BUFF_COST_UP = 1298,
		DEBUG_DISPLAY_TAG_BOTTOM_RIGHT = 1313,
		DEBUG_DISPLAY_TAG_TOP_RIGHT = 1314,
		SMART_DISCOVER_DEBUG_ENTITY_1 = 1318,
		SMART_DISCOVER_DEBUG_ENTITY_2 = 1319,
		SMART_DISCOVER_DEBUG_ENTITY_3 = 1320,
		SMART_DISCOVER_DEBUG_TEST_COMPLETE = 1324,
		SMART_DISCOVER_DEBUG_PASSIVE_EVAL_RESULT_1 = 1328,
		SMART_DISCOVER_DEBUG_PASSIVE_EVAL_RESULT_2 = 1329,
		SMART_DISCOVER_DEBUG_PASSIVE_EVAL_RESULT_3 = 1330,
		COPIED_BY_KHADGAR = 1326,
		ALTERNATE_CHAPTER_VO = 1334,
		AI_MAKES_DECISIONS_FOR_PLAYER = 1335,
		HAS_BEEN_REBORN = 1336,
		USE_DISCOVER_VISUALS = 1342,
		DOUBLE_FATIGUE_DAMAGE = 1346,
		BOARD_VISUAL_STATE = 1347,
		BACON_DUMMY_PLAYER = 1349,
		SQUELCH_LIFETIME_EFFECTS = 1350,
		ALLOW_MOVE_MINION = 1356,
		TAG_TB_RANDOM_DECK_TIME_ID = 1358,
		NEXT_OPPONENT_PLAYER_ID = 1360,
		MAIN_GALAKROND = 1361,
		GOOD_OL_GENERIC_FRIENDLY_DRAGON_DISCOVER_VISUALS = 1364,
		GALAKROND_HERO_CARD = 1365,
		INVOKE_COUNTER = 1366,
		PLAYER_LEADERBOARD_PLACE = 1373,
		PLAYER_TECH_LEVEL = 1377,
		BACON_USE_FAST_ANIMATIONS = 1402,
		DECK_RULE_COUNT_AS_COPY_OF_CARD_ID = 1413,
		BACON_ODD_PLAYER_OUT = 1415,
		BACON_IS_KEL_THUZAD = 1423,
		BACON_HIGHLIGHT_ATTACKING_MINION_DURING_COMBAT = 1424,
		RULEBOOK = 1430,
		FX_DATANUM_1 = 1436,
		BACON_ACTION_CARD = 1437,
		GAME_MODE_BUTTON_SLOT = 1438,
		TECH_LEVEL = 1440,
		TECH_LEVEL_MANA_GEM = 1442,
		UI_BUFF_DURABILITY_UP = 1443,
		PLAYER_TRIPLES = 1447,
		DISABLE_TURN_INDICATORS = 1448,
		COLLECTION_RELATED_CARD_DATABASE_ID = 1452,
		IS_BACON_POOL_MINION = 1456,
		SUPPRESS_ALL_SUMMON_VO = 1458,
		BACON_TRIPLE_CANDIDATE = 1460,
		BATTLEGROUNDS_PREMIUM_EMOTES = 1463,
		MOVE_MINION_HOVER_TARGET_SLOT = 1464,
		BACON_COIN_ON_ENEMY_MINIONS = 1467,
		ALWAYS_USE_FAST_ACTOR_TRIGGERS = 1473,
		BACON_HERO_CAN_BE_DRAFTED = 1491,
		ALLOW_GAME_SPEEDUP = 1526
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// UNUSED
	/// </summary>
	public enum GameType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		GT_UNKNOWN = 0,
		GT_VS_AI = 1,
		GT_VS_FRIEND = 2,
		GT_TUTORIAL = 4,
		GT_ARENA = 5,
		GT_TEST_AI_VS_AI = 6,
		GT_RANKED = 7,
		GT_CASUAL = 8,
		GT_TAVERNBRAWL = 16,
		GT_TB_1P_VS_AI = 17,
		GT_TB_2P_COOP = 18,
		GT_FSG_BRAWL_VS_FRIEND = 19,
		GT_FSG_BRAWL = 20,
		GT_FSG_BRAWL_1P_VS_AI = 21,
		GT_FSG_BRAWL_2P_COOP = 22,
		GT_BATTLEGROUNDS = 23
		// GT_LAST = 24
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// TODO;
	/// </summary>
	public enum GoldRewardState
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		ELIGIBLE = 1,
		WRONG_GAME_TYPE = 2,
		ALREADY_CAPPED = 3,
		BAD_RATING = 4,
		SHORT_GAME = 5,
		SHORT_GAME_BY_TIME = 5,
		OVER_CAIS = 6,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// UNUSED
	/// </summary>
	public enum Locale
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		UNKNOWN = -1,
		enUS = 0,
		enGB = 1,
		frFR = 2,
		deDE = 3,
		koKR = 4,
		esES = 5,
		esMX = 6,
		ruRU = 7,
		zhTW = 8,
		zhCN = 9,
		itIT = 10,
		ptBR = 11,
		plPL = 12,
		ptPT = 13,
		jaJP = 14,
		thTH = 15,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Enumeration used WITHIN HISTORY data, interpreted by the real HS client.
	/// </summary>
	public enum MetaDataType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		TARGET = 0,
		DAMAGE = 1,
		HEALING = 2,
		JOUST = 3,
		CLIENT_HISTORY = 4,
		SHOW_BIG_CARD = 5,
		EFFECT_TIMING = 6,
		HISTORY_TARGET = 7,
		OVERRIDE_HISTORY = 8,
		HISTORY_TARGET_DONT_DUPLICATE_UNTIL_END = 9,
		BEGIN_ARTIFICIAL_HISTORY_TILE = 10,
		BEGIN_ARTIFICIAL_HISTORY_TRIGGER_TILE = 11,
		END_ARTIFICIAL_HISTORY_TILE = 12,
		START_DRAW = 13,
		BURNED_CARD = 14,
		EFFECT_SELECTION = 15,
		BEGIN_LISTENING_FOR_TURN_EVENTS = 16,
		HOLD_DRAWN_CARD = 17,
		CONTROLLER_AND_ZONE_CHANGE = 18,
		ARTIFICIAL_PAUSE = 19
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// State in which a player resides when the game is in Mulligan phase.
	/// Think of Mulligan itself as a state machine within the game, which
	/// is also a state machine.
	/// </summary>
	public enum Mulligan
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
	/// A multiclassgroup is a set of cards which spans multiple
	/// classes.
	///
	/// ex; GRIMMY_GOONS contains Paladin+Hunter+Warrior classes.
	/// </summary>
	public enum MultiClassGroup
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		GRIMY_GOONS = 1,
		JADE_LOTUS = 2,
		KABAL = 3
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Indicates the type of choice a player can pick from a set of options.
	/// eg: END_TURN; Indicates to the simulator that the player desires to end his turn.
	///
	/// The presented set of options is distinct.
	/// A player MUST always pick EXACTLY ONE of the offered options.
	/// </summary>
	public enum OptionType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		PASS = 1,
		END_TURN = 2,
		POWER = 3,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Requirements which have to be met before a card can be player.
	/// The state of the board is checked to match these requirements.
	///
	/// A card can have multiple play requirements.
	/// </summary>
	public enum PlayReq
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
		REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN = 65,
		REQ_TARGET_NOT_VAMPIRE = 66,
		REQ_TARGET_NOT_DAMAGEABLE_ONLY_BY_WEAPONS = 67,
		REQ_NOT_DISABLED_HERO_POWER = 68,
		REQ_MUST_PLAY_OTHER_CARD_FIRST = 69,
		REQ_HAND_NOT_FULL = 70,
		REQ_TARGET_IF_AVAILABLE_AND_NO_3_COST_CARD_IN_DECK = 71,
		REQ_CAN_BE_TARGETED_BY_COMBOS = 72,
		REQ_CANNOT_PLAY_THIS = 73,
		REQ_FRIENDLY_MINIONS_OF_RACE_DIED_THIS_GAME = 74,
		REQ_DRAG_TO_PLAY_PRE29933 = 75,
		REQ_OPPONENT_PLAYED_CARDS_THIS_GAME = 77,
		REQ_LITERALLY_UNPLAYABLE = 78,
		REQ_TARGET_IF_AVAILABLE_AND_HERO_HAS_ATTACK = 79,
		REQ_FRIENDLY_MINION_OF_RACE_DIED_THIS_TURN = 80,
		REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_SPELLS_PLAYED_THIS_TURN = 81,
		REQ_FRIENDLY_MINION_OF_RACE_IN_HAND = 82,
		REQ_DRAG_TO_PLAY_PRE31761 = 83,
		REQ_MANA_CRYSTAL = 84,
		REQ85 = 85,
		REQ_FRIENDLY_DEATHRATTLE_MINION_DIED_THIS_GAME = 86,
		REQ87 = 87,
		REQ88 = 88,
		REQ_FRIENDLY_REBORN_MINION_DIED_THIS_GAME = 89,
		REQ_MINION_DIED_THIS_GAME = 90,
		REQ_BOARD_NOT_COMPLETELY_FULL = 92,
		REQ_TARGET_IF_AVAILABLE_AND_HAS_OVERLOADED_MANA = 93,
		REQ_DRAG_TO_PLAY = 94
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// State information about controllers in a game. A controller represents
	/// one player.
	/// </summary>
	public enum PlayState
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
		CONCEDED = 8,
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Enumeration for building HISTORY which can be interpreted by the real HS client.
	/// </summary>
	public enum PowerType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		FULL_ENTITY = 1,
		SHOW_ENTITY = 2,
		HIDE_ENTITY = 3,
		TAG_CHANGE = 4,
		BLOCK_START = 5,
		BLOCK_END = 6,
		CREATE_GAME = 7,
		META_DATA = 8,
		CHANGE_ENTITY = 9,
		RESET_GAME = 10,
		SUB_SPELL_START = 11,
		SUB_SPELL_END = 12
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Another classification for cards which is mutual exclusive.
	/// The most used value is DRAGON, since a lot of cards interact with
	/// dragons in hand.
	/// </summary>
	public enum Race
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
		BLANK = 25,
		ALL = 26,
		EGG = 38
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Rarity of a card. This reflects the drop rate from card packs.
	/// </summary>
	public enum Rarity
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
	/// Indicates the state of the Game entity.
	/// </summary>
	public enum State
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		LOADING = 1,
		RUNNING = 2,
		COMPLETE = 3
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Indicates in which state the Game's state machine is in.
	/// </summary>
	public enum Step
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
		MAIN_START_TRIGGERS = 17
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// UNUSED
	/// </summary>
	public enum Type
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		LOCSTRING = -2,
		UNKNOWN = 0,
		BOOL = 1,
		NUMBER = 2,
		COUNTER = 3,
		ENTITY = 4,
		PLAYER = 5,
		TEAM = 6,
		ENTITY_DEFINITION = 7,
		STRING = 8
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Abstract area where entities reside during the game.
	/// Each controller has it's own set of zones, these are not shared
	/// with other players.
	///
	/// eg: <see cref="PLAY"/>: contains all entities that are on the board.
	/// eg: <see cref="DECK"/>: contains all entities which are not yet drawn into <see cref="HAND"/>.
	/// </summary>
	public enum Zone
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
	/// </summary>
	public enum PuzzleType
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = 0,
		MIRROR = 1,
		LETHAL = 2,
		SURVIVAL = 3,
		CLEAR = 4
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// </summary>
	public enum ZodiacYear
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		INVALID = -1,
		PRE_STANDARD = 0,
		KRAKEN = 1,
		MAMMOTH = 2,
		RAVEN = 3,
		DRAGON = 4
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
