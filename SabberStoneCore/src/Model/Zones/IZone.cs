﻿using System.Collections.Generic;
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
		/// Gets the maximum amount of entities this zone can hold.
		/// </summary>
		/// <value>The maximum size.</value>
		int MaxSize { get; }

		/// <summary>
		/// Gets a value indicating whether this zone is full. <seealso cref="MaxSize"/>
		/// </summary>
		/// <value><c>true</c> if this zone reach the maximum amount of entities; otherwise, <c>false</c>.</value>
		bool IsFull { get; }

		/// <summary>
		/// Gets a value indicating whether this contains entities or not.
		/// </summary>
		/// <value><c>true</c> if this zone is empty; otherwise, <c>false</c>.</value>
		bool IsEmpty { get; }

		/// <summary>
		/// Gets the amount of entities residing in this zone.
		/// </summary>
		/// <value>The count of entities.</value>
		int Count { get; }

		/// <summary>
		/// Gets the owner of the zone.
		/// </summary>
		/// <value>The controller.</value>
		Controller Controller { get; }

		/// <summary>
		/// Gets the kind of zone.
		/// </summary>
		/// <value><see cref="Zone"/></value>
		Zone Type { get; }

		/// <summary>
		/// Gets the <see cref="IPlayable"/> with the specified zone position.
		/// </summary>
		/// <value>The <see cref="IPlayable"/>.</value>
		/// <param name="zonePosition">The position inside the zone.</param>
		/// <returns></returns>
		IPlayable this[int zonePosition] { get; }

		/// <summary>
		/// Gets all entities in this zone.
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
		IPlayable Add(IPlayable entity, int zonePosition = -1, bool applyEnchantments = true);

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
		/// Moves the specified entity to a new position.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="zonePosition">The zone position.</param>
		void MoveTo(IPlayable entity, int zonePosition);

		/// <summary>
		/// Swaps the positions of both entities in this zone.
		/// Both entities must be contained by this zone.
		/// </summary>
		/// <param name="oldEntity">The one entity.</param>
		/// <param name="newEntity">The other entity.</param>
		void Swap(IPlayable oldEntity, IPlayable newEntity);

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
		/// Copy data from the specified zone into this one.
		/// </summary>
		/// <param name="zone">The other zone object.</param>
		void Stamp(IZone zone);

		/// <summary>
		/// Returns a string which contains a hash unique to this zone object.
		/// </summary>
		/// <param name="ignore">The <see cref="GameTag"/>s to ignore during hash creation.</param>
		/// <returns></returns>
		string Hash(params GameTag[] ignore);
	}
}
