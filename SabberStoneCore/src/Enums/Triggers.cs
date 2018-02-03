using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneCore.Enums
{
	/// <summary> Events in Hearthstone. </summary>
	public enum TriggerType
	{
		NONE,

		/// <summary> The effect will be triggered at the end of turn. </summary>
		TURN_END,
		/// <summary> The effect will be triggered at the start of turn. </summary>
		TURN_START,
		/// <summary> The effect will be triggered when a minion dies. </summary>
		DEATH,
		/// <summary> The effect will be triggered when a player uses Hero Power. </summary>
		INSPIRE,
		/// <summary> The effect will be triggered when a character is damaged. </summary>
		DEAL_DAMAGE,
		/// <summary> The effect will be triggered when a spell or a character deals damages. </summary>
		DAMAGE,
		/// <summary> 
		/// effect will be triggered when a character gets Predamage. 
		/// This event happens just before the character is actually damaged.
		/// </summary>
		PREDAMAGE,
		/// <summary> The effect will be triggered when characters are healed. </summary>
		HEAL,
		/// <summary> The effect will be triggered when characters attack. </summary>
		ATTACK,
		/// <summary> The effect will be triggered after an attack action is ended. </summary>
		AFTER_ATTACK,
		/// <summary> The effect will be triggered whenever a minion is summoned </summary>
		PRE_SUMMON,
		/// <summary> The effect will be triggered after a minion is summoned. </summary>
		SUMMON,
		/// <summary> The effect will be triggered when a player plays a card. </summary>
		PLAY_CARD,
		/// <summary> The effect will be triggered when a player plays a Minion card. </summary>
		PLAY_MINION,
		/// <summary> The effect will be triggered after a minion is played. </summary>
		AFTER_PLAY_MINION,
		/// <summary> The effect will be triggered when a player plays a Spell card. </summary>
		CAST_SPELL,
		/// <summary> The effect will be triggered after a spell is played. </summary>
		AFTER_CAST,
		/// <summary> The effect will be triggered when a secret is activated. </summary>
		SECRET_REVEALED,

		ZONE,

		DISCARD,

		GAME_START,

		DRAW
	}

	public enum TriggerSource
	{
		ALL,
		FRIENDLY,
		ENEMY,
		SELF,
		MINIONS,
		MINIONS_EXCEPT_SELF,
		OP_MINIONS,
		ALL_MINIONS,
		HERO,
		OP_HERO,
		ENCHANTMENT_TARGET
	}

	public enum TriggerActivation
	{
		PLAY,
		HAND,
		DECK,
		HAND_OR_PLAY
	}

	public enum SequenceType
	{
		None,
		PlayCard,
		PlayMinion,
		PlaySpell,
		Summon,
		DamageDealt,
		Attack
	}
}
