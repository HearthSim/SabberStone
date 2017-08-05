using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities.Playables;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Tasks;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Entities {
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
		bool ComboMechanic { get; }

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

		/// <summary>Sets the order of play counter on this entity.
		/// The order of play is important to resolve enchantments in an intuitive manner.
		/// </summary>
		/// <param name="card">The type of card that is played.</param>
		void SetOrderOfPlay(ECardType card);

		/// <summary>Gets or sets a value indicating whether this entity is summoned (into <see cref="BoardZone"/>).
		/// Applicable to <see cref="Minion"/>s.
		/// </summary>
		/// <value><c>true</c> if this entity is summoned; otherwise, <c>false</c>.</value>
		bool IsSummoned { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this entity was recently moved from the <see cref="HandZone"/>.
		/// </summary>
		/// <value><c>true</c> if this entity was recently played; otherwise, <c>false</c>.</value>
		bool JustPlayed { get; set; }

		/// <summary>Gets or sets the amount of overload, lock on resources during the next turn, this entity
		/// inflicts on it's <see cref="Controller"/>.
		/// Applicable to any <see cref="Minion"/>, <see cref="Spell"/> and <see cref="Weapon"/>.
		/// </summary>
		/// <value>The amount of overload.</value>
		int Overload { get; set; }

		/// <summary>Gets or sets the entityID of the target which undergoes the effect of 
		/// <see cref="Enchantment"/> and/or <see cref="Trigger"/> defined on this entity.
		/// Applicable to any <see cref="Minion"/>, <see cref="Spell"/>, <see cref="Weapon"/> and
		/// <see cref="HeroPower"/>.
		/// </summary>
		/// <value>The entityID of the target.</value>
		int CardTarget { get; set; }

		/// <summary>Gets the array of entities generated for the started 'choose one' effect.
		/// The purpose of this array is for the game to select the picked option chosen by the
		/// <see cref="Controller"/>. The <see cref="SimpleTask"/> of the chosen entity will be 
		/// executed.
		/// Applicable to any <see cref="Minion"/> and <see cref="Spell"/>.
		/// </summary>
		/// <value>The set of <see cref="IPlayable"/>.</value>
		IPlayable[] ChooseOnePlayables { get; }

		/// <summary>
		/// Gets or sets the list of enchantments which will be activated, when it's conditions are met,
		/// will be activated by <see cref="Game"/>.
		/// </summary>
		/// <value>The list of <see cref="Enchantment"/>.</value>
		List<Enchantment> Enchantments { get; set; }

		/// <summary>Marks this entity for destruction.
		/// Actual destruction will happen during the next <see cref="Game.DeathProcessingAndAuraUpdate"/>
		/// execution.
		/// </summary>
		/// <returns></returns>
		IPlayable Destroy();
	}
}
