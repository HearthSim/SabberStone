namespace SabberStoneCore.Enums
{
	/* These enums are unused in the core code! */

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

	public enum EBnetGameType
	{
		BGT_UNKNOWN = 0,
		BGT_FRIENDS = 1,
		BGT_RANKED_STANDARD = 2,
		BGT_ARENA = 3,
		BGT_VS_AI = 4,
		BGT_TUTORIAL = 5,
		BGT_ASYNC = 6,
		BGT_CASUAL_STANDARD = 7,
		BGT_TEST1 = 8,
		BGT_TEST2 = 9,
		BGT_TEST3 = 10,
		BGT_TAVERNBRAWL_PVP = 16,
		BGT_TAVERNBRAWL_1P_VERSUS_AI = 17,
		BGT_TAVERNBRAWL_2P_COOP = 18,
		BGT_RANKED_WILD = 30,
		BGT_CASUAL_WILD = 31,
		BGT_LAST = 32,
	}

	public enum EBnetRegion
	{
		REGION_UNINITIALIZED = -1,
		REGION_UNKNOWN = 0,
		REGION_US = 1,
		REGION_EU = 2,
		REGION_KR = 3,
		REGION_TW = 4,
		REGION_CN = 5,
		REGION_LIVE_VERIFICATION = 40,
		REGION_PTR_LOC = 41,
		REGION_MSCHWEITZER_BN11 = 52,
		REGION_MSCHWEITZER_BN12 = 53,
		REGION_DEV = 60,
		REGION_PTR = 98,
	}

	public enum EBooster
	{
		INVALID = 0,
		CLASSIC = 1,
		GOBLINS_VS_GNOMES = 9,
		THE_GRAND_TOURNAMENT = 10,
		OLD_GODS = 11,
		FIRST_PURCHASE = 17,
	}

	public enum EGoldRewardState
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

	public enum ELocale
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

	public enum EType
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
		STRING = 8,
	}

	public enum EDeckType
	{
		NORMAL_DECK = 1,
		AI_DECK = 2,
		DRAFT_DECK = 4,
		PRECON_DECK = 5,
		TAVERN_BRAWL_DECK = 6,
		HIDDEN_DECK = 1000,
	}

	public enum EGameType
	{
		GT_UNKNOWN = 0,
		GT_VS_AI = 1,
		GT_VS_FRIEND = 2,
		GT_TUTORIAL = 4,
		GT_ARENA = 5,
		GT_TEST = 6,
		GT_RANKED = 7,
		GT_CASUAL = 8,
		GT_TAVERNBRAWL = 16,
		GT_TB_1P_VS_AI = 17,
		GT_TB_2P_COOP = 18,
		GT_LAST = 19,
	}

	public enum EEnchantmentVisual
	{
		INVALID = 0,
		POSITIVE = 1,
		NEGATIVE = 2,
		NEUTRAL = 3,
	}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}