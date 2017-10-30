using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	/// <summary>
	/// Interface of an abstract area where <see cref="IEntity"/> objects
	/// reside.
	/// A zone is owned by a controller and isn't shared.
	/// </summary>
	public interface IZone
	{
		/// <summary>
		/// Gets the kind of zone.
		/// </summary>
		/// <value><see cref="Zone"/></value>
		Zone Type { get; }

		/// <summary>
		/// Gets the amount of entities residing in this zone.
		/// </summary>
		/// <value>The count of entities.</value>
		int Count { get; }

		/// <summary>
		/// Gets the list of enchantments attached to this zone.
		/// </summary>
		/// <value>The list of enchantments.</value>
		List<Enchant> Enchants { get; }

		/// <summary>
		/// Gets the list of triggers attacked to this zone.
		/// </summary>
		/// <value>The list of triggers.</value>
		List<Trigger> Triggers { get; }

		/// <summary>
		/// Gets <see cref="List{T}"/> that contains all entities in this zone.
		/// </summary>
		/// <value>The set of <see cref="IPlayable"/>.</value>
		List<IPlayable> GetAll { get; }

		/// <summary>
		/// Adds the specified entity into this zone, at the given position.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="zonePosition">The zone position.</param>
		/// <param name="applyEnchantments"><c>true</c> if all zone changing enchantments have to be
		/// executed, <c>false</c> otherwise.</param>
		/// <returns>The entity</returns>
		void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true);

		/// <summary>
		/// Removes the specified entity from this zone.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <returns>The entity.</returns>
		IPlayable Remove(IPlayable entity);

		/// <summary>
		/// Replaces the specified entity with another one.
		/// </summary>
		/// <param name="oldEntity">The old entity.</param>
		/// <param name="newEntity">The new entity.</param>
		/// <returns>The old entity</returns>
		IPlayable Replace(IPlayable oldEntity, IPlayable newEntity);

		/// <summary>
		/// Returns a string which contains a hash unique to this zone object.
		/// </summary>
		/// <param name="ignore">The <see cref="GameTag"/>s to ignore during hash creation.</param>
		/// <returns></returns>
		string Hash(params GameTag[] ignore);
	}
}
