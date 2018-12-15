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
	/// Indicates the event that must happen in order to trigger the effect
	/// of the attached power.
	/// 
	/// eg: <see cref="DEATHRATTLE"/>: The entity has to be destroyed in order
	/// for the effect to execute.
	/// </summary>
	public enum PowerActivation
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		POWER,
		//BATTLECRY,
		DEATHRATTLE,
		//WEAPON,
		//SPELL,
		//SECRET_OR_QUEST,
		COMBO,

		//BOARD_ZONE,
		//HAND_ZONE,
		//DECK_ZONE,
		//SETASIDE_ZONE,
		//NONE
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	/// <summary>
	/// Indicates which (group of) entities the effect will influence.
	/// </summary>
	public enum PowerArea
	{
		/// <summary>
		/// There will be no effect.
		/// </summary>
		NONE,

		/// <summary>
		/// The effect will be triggered by the selected target (target chosen by player).
		/// </summary>
		TARGET,

		/// <summary>
		/// The effect will be triggered by the hero of the controller.
		/// </summary>
		HERO,

		/// <summary>
		/// The effect will be triggered by the hero of the opponent controller.
		/// </summary>
		OP_HERO,

		/// <summary>
		/// The effect will be triggered by the hero of all controllers.
		/// </summary>
		HEROES,

		/// <summary>
		/// The effect will be triggered by the board of the controller.
		/// </summary>
		BOARD,

		/// <summary>
		/// The effect will be triggered by the board of the opponent controller.
		/// </summary>
		OP_BOARD,

		/// <summary>
		/// The effect will be triggered by the board of all controllers.
		/// </summary>
		BOARDS,

		/// <summary>
		/// The effect will be triggered by the hand of the controller.
		/// </summary>
		HAND,

		/// <summary>
		/// The effect will be triggered by the hand of the opponent controller.
		/// </summary>
		OP_HAND,

		/// <summary>
		/// The effect will be triggered by the hand of all controllers.
		/// </summary>
		HANDS,

		/// <summary>
		/// The effect will be triggered by the entity itself.
		/// </summary>
		SELF,

		/// <summary>
		/// The effect will be triggered by the GAME entity.
		/// </summary>
		GAME,

		/// <summary>
		/// The effect will be triggered by the controller entity.
		/// </summary>
		CONTROLLER,

		/// <summary>
		/// The effect will be triggered by the opponent controller entity.
		/// </summary>
		OP_CONTROLLER,

		/// <summary>
		/// The effect will be triggered by all controller entities.
		/// </summary>
		CONTROLLERS,

		/// <summary>
		/// The effect will be triggered by the secrets of the controller.
		/// </summary>
		SECRET,

		///	<summary>
		///	The effect will be triggered by the secrets of all controllers.
		///	</summary>
		SECRETS,

		/// <summary>
		/// The effect will be triggered by the HAND and BOARD of the controller.
		/// </summary>
		HAND_AND_BOARD,

		/// <summary>
		/// The effect will be triggered by the HAND and BOARD of the opponent controller.
		/// </summary>
		OP_BOARD_AND_OP_HERO,

		/// <summary>
		/// The effect will be triggered by the HERO and BOARD of all controllers.
		/// </summary>
		BOARDS_HEROES,

		/// <summary>
		/// This effect will be triggered by the GRAVEYARD of the controller.
		/// </summary>
		GRAVEYARD,

		/// <summary>
		/// This effect will be triggered by the GRAVEYARD and SECRET of the controller.
		/// </summary>
		GRAVEYARD_AND_SECRET,

		/// <summary>
		/// This effect will be triggered by the GRAVEYARD of the opponent controller.
		/// </summary>
		OP_GRAVEYARD,

		/// <summary>
		/// This effect will be triggered by the GRAVEYARD and SECRET of the opponent controller.
		/// </summary>
		OP_GRAVEYARD_AND_OP_SECRET
	}
}
