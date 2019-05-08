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
	/// <summary> Events in Hearthstone. </summary>
	public enum TriggerType
	{
		NONE,

		MULTITRIGGER,

		/// <summary> The effect will be triggered at the end of turn. </summary>
		TURN_END,
		/// <summary> The effect will be triggered at the start of turn. </summary>
		TURN_START,
		/// <summary> The effect will be triggered when a minion dies. </summary>
		DEATH,
		/// <summary> The effect will be triggered after a player uses Hero Power. </summary>
		INSPIRE,
		/// <summary> The effect will be triggered when a character is damaged. </summary>
		DEAL_DAMAGE,
		/// <summary> The effect will be triggered when a spell or a character deals damages. </summary>
		TAKE_DAMAGE,
		/// <summary> 
		/// effect will be triggered when a character gets Predamage. 
		/// This event happens just before the character is actually damaged.
		/// </summary>
		PREDAMAGE,
		/// <summary> The effect will be triggered when characters are healed. </summary>
		HEAL,
		/// <summary> The effect will be triggered when a minion loses its Divine Shield </summary>
		LOSE_DIVINE_SHIELD,
		/// <summary> The effect will be triggered when characters attack. </summary>
		ATTACK,
		/// <summary> The effect will be triggered after an attack action is ended. </summary>
		AFTER_ATTACK,
		/// <summary> The effect will be triggered whenever a minion is summoned </summary>
		SUMMON,
		/// <summary> The effect will be triggered after a minion is summoned. </summary>
		AFTER_SUMMON,
		/// <summary> The effect will be triggered when a player plays a card. </summary>
		PLAY_CARD,
		/// <summary> The effect will be triggered after a player plays a card. </summary>
		AFTER_PLAY_CARD,
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
		/// <summary> The effect will be triggered when an entity enters any types of zone. </summary>
		ZONE,
		/// <summary> The effect will be triggered when a card is discarded from hand. </summary>
		DISCARD,
		/// <summary> The effect will be triggered when a game begins. </summary>
		GAME_START,
		/// <summary> The effect will be triggered when a card is drawed. </summary>
		DRAW,
		/// <summary> The effect will be triggered when a card is targeted by an attacking minion or a played card. </summary>
		TARGET,
		/// <summary> The effect will be triggered when a entity is frozen. </summary>
		FROZEN,
		/// <summary> The effect will be triggered when a hero gains armor. </summary>
		ARMOR,
		/// <summary> The effect will be triggered when a hero equips a weapon. </summary>
		EQUIP_WEAPON,
		/// <summary> The effect will be triggered when a card is shuffled into a deck. </summary>
		SHUFFLE_INTO_DECK,

		OVERLOAD,

		WORGEN_TRANSFORM
	}

	/// <summary>
	/// Types of entity that can invoke an event.
	/// </summary>
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
		ALL_MINIONS_EXCEPT_SELF,
		HERO,
		OP_HERO,
		ENCHANTMENT_TARGET,
		WEAPON,
		HERO_POWER,
		FRIENDLY_SPELL_CASTED_ON_THE_OWNER,
		FRIENDLY_SPELL_CASTED_ON_OWN_MINIONS,
		FRIENDLY_EVENT_SOURCE,
		ADJACENT_TO_THE_OWNER
	}

	/// <summary>
	/// Indicates where this trigger should be activated.
	/// </summary>
	public enum TriggerActivation
	{
		PLAY,
		HAND,
		DECK,
		HAND_OR_PLAY
	}

	/// <summary>
	/// Types of event sequences in Hearthstone.
	/// </summary>
	public enum SequenceType
	{
		None,
		PlayCard,
		PlayMinion,
		PlaySpell,
		Summon,
		DamageDealt,
		Attack,
		Target,
	}
}
