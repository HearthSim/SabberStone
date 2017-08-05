using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities.Playables;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Provides targeting behaviour for entities.
	/// Only <see cref="Character{T}" />s are valid targets and certain
	/// conditions make <see cref="Character{T}" />s untargetable.
	/// These conditions are defined within the <see cref="Enchantment" />
	/// of the <see cref="Card" /> from which the entity is derived.
	/// </summary>
	/// <seealso cref="IEntity" />
	public interface ITargeting : IEntity
	{
		/// <summary>
		/// Gets or sets a value indicating whether this entity contains the 'choose one' mechanic.
		/// 
		/// TODO; This value might be better defined on IEntity directly.
		/// </summary>
		/// <value><c>true</c> if the 'choose one' mechanic is defined; otherwise, <c>false</c>.</value>
		bool ChooseOneMechanic { get; set; }

		/// <summary>Gets the valid targets for the <see cref="Enchantment"/> of
		/// this entity.</summary>
		/// <value>The enumerable of valid play targets.</value>
		IEnumerable<ICharacter> ValidPlayTargets { get; }

		/// <summary>
		/// Determines whether the specified target is a valid play target.
		/// </summary>
		/// <param name="target"><see cref="ICharacter"/></param>
		/// <returns>
		///   <c>true</c> if the character is a valid target; otherwise, <c>false</c>.
		/// </returns>
		bool IsValidPlayTarget(ICharacter target);
	}
}
