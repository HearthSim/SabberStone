// ReSharper disable InconsistentNaming
namespace SabberStoneCore.Auras
{
	/// <summary>
	/// Aura types. Indicates the range of auras. 
	/// </summary>
	public enum AuraType
	{
		/// <summary> This type of aura only affects the source of the aura. </summary>
		SELF,
		/// <summary> This type of aura affects the minions adjacent to the source of the aura. </summary>
		ADJACENT,
		/// <summary> This type of aura affects all friendly minions. </summary>
		BOARD,
		/// <summary> This type of aura affects all friendly minions except the source of the aura. </summary>
		BOARD_EXCEPT_SOURCE,
		/// <summary> This type of aura affects all entities in the hand of the source's controller. </summary>
		HAND,
		/// <summary> This type of aura affects all entities in the hand of the opponent of the source's controller. </summary>
		OP_HAND,
		/// <summary> This type of aura affects all entities in the both player's hand. </summary>
		HANDS,
		/// <summary> This type of aura only affects the controller of the source of the aura. </summary>
		CONTROLLER,
		/// <summary> This type of aura only affects the opponent of the source of the aura. </summary>
		OPPONENT,
		/// <summary> This type of aura affects the both controllers. </summary>
		CONTROLLERS,
		/// <summary> This type of aura affects the weapon of the source's controller. </summary>
		WEAPON,

		ADAPTIVE,

		HERO,

		HEROPOWER,

		OP_HEROPOWER,

		HAND_AND_BOARD,

		SUMMONING_PORTAL,

		MULTIAURA
	}
}
