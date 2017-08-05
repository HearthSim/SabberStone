using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities.Playables;
using SabberStoneCore.Model.Zones;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Exposes the properties of an entity that can be 'played', which 
	/// means it's moved from the <see cref="HandZone"/> into the <see cref="BoardZone"/>.
	/// 
	/// Deriving entities declare <see cref="Enchantment"/> and/or build <see cref="Character{T}"/>
	/// which manifest at the moment the <see cref="HandZone"/> is left.
	/// </summary>
	/// <seealso cref="ITargeting" />
	public interface IPlayable : ITargeting
	{
		/// <summary>Gets a value indicating whether this entity can be played from hand, given
		/// the current game context.</summary>
		/// <value><c>true</c> if this instance is playable; otherwise, <c>false</c>.</value>
		bool IsPlayable { get; }

		/// <summary>Gets a value indicating whether this entity is playable, given the current
		/// state of the controller.</summary>
		/// <value><c>true</c> if this instance is playable; otherwise, <c>false</c>.</value>
		bool IsPlayableByController { get; }

		/// <summary>Gets a value indicating whether this instance is playable, by validating
		/// the requirements set by the <see cref="Card"/>.</summary>
		/// <value><c>true</c> if this instance is playable; otherwise, <c>false</c>.</value>
		bool IsPlayableByCardReq { get; }

		/// <summary>Gets or sets a value indicating whether this entity is ignoring damage.
		/// This switch controls the behaviour of the entity when <see cref="EGameTag.DAMAGE"/>
		/// and <see cref="EGameTag.PREDAMAGE"/> tags are being processed.
		/// </summary>
		/// <value><c>true</c> if this instance is ignoring damage; otherwise, <c>false</c>.</value>
		bool IsIgnoringDamage { get; set; }

		/// <summary>Gets a value indicating whether this entity has a combo mechanic.
		/// Applicable to any <see cref="Minion"/>, <see cref="Spell"/> and <see cref="Weapon"/>.
		/// </summary>
		/// <value><c>true</c> if combo mechanic; otherwise, <c>false</c>.</value>
		bool Combo { get; }

		/// <summary>Gets or sets the resource cost (MANA) of this entity.
		/// Applicable to any <see cref="IPlayable"/>.
		/// </summary>
		/// <value>The cost.</value>
		int Cost { get; set; }

		/// <summary>Gets or sets the position within the <see cref="Zone{T}"/> this entity is stored.
		/// Applicable to <see cref="Minion"/>s.
		/// </summary>
		/// <value>The zone position.</value>
		int ZonePosition { get; set; }

		/// <summary>Gets or sets the number of turns this entity has been in <see cref="BoardZone"/>.
		/// Applicable to any <see cref="Minion"/>, <see cref="Spell"/> and <see cref="Weapon"/>.
		/// </summary>
		/// <value>The number turns in play.</value>
		int NumTurnsInPlay { get; set; }		

		/// <summary>
		/// Gets a value indicating whether this entity is awaiting to be destroyed.
		/// </summary>
		/// <value><c>true</c> if marked for destruction; otherwise, <c>false</c>.</value>
		bool ToBeDestroyed { get; }

		/// <summary>
		/// Gets or sets a value indicating whether the the game is currently available to process
		/// tasks provided by <see cref="Game.CurrentPlayer"/>.
		/// Applicable to <see cref="Controller"/>. 
		/// 
		/// TODO; Might be better to move this into <see cref="Controller"/>.
		/// </summary>
		/// <value><c>true</c> if the player's turn is active; otherwise, <c>false</c>.</value>
		bool TurnStart { get; set; }

		/// <summary>Applies enchantments registered on this entity by providing a trigger value.</summary>
		/// <param name="activation">The activation requirement for enchantment activation.</param>
		/// <param name="zoneType">Type of the zone requirement for enchantment activation.</param>
		/// <param name="target">The target for the effect, optional.</param>
		void ApplyEnchantments(EEnchantmentActivation activation, EZone zoneType, IPlayable target = null);

		/// <summary>Sets the order of play counter.</summary>
		/// <param name="card">The type of card that is played.</param>
		void SetOrderOfPlay(ECardType card);

		bool IsSummoned { get; set; }

		bool JustPlayed { get; set; }

		int Overload { get; set; }

		int CardTarget { get; set; }

		IPlayable[] ChooseOnePlayables { get; }

		List<Enchantment> Enchantments { get; set; }

		/// <summary>Marks this entity for destruction.
		/// Actual destruction will happen during the next <see cref="Game.DeathProcessingAndAuraUpdate"/>
		/// execution.
		/// </summary>
		/// <returns></returns>
		IPlayable Destroy();
	}
}
