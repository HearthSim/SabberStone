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
using System.Collections.Generic;
using SabberStoneCore.Enums;
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
		/// Gets the size of available space of this zone.
		/// </summary>
		int FreeSpace { get; }

		/// <summary>
		/// Gets a value indicating whether this zone is full.
		/// </summary>
		/// <value><c>true</c> if this zone reach the maximum amount of entities; otherwise, <c>false</c>.</value>
		bool IsFull { get; }

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
		/// <returns>The entity</returns>
		void Add(IPlayable entity, int zonePosition = -1);

		/// <summary>
		/// Includes the given entity at the given position 
		/// without causing any other side effects.
		/// Only use this method only when you need to manipulate
		/// entities and tags directly.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="zonePosition"></param>
		void MoveTo(IPlayable entity, int zonePosition);

		/// <summary>
		/// Removes the specified entity from this zone.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <returns>The entity.</returns>
		IPlayable Remove(IPlayable entity);

		/// <summary>
		/// Returns a string which contains a hash unique to this zone object.
		/// </summary>
		/// <param name="ignore">The <see cref="GameTag"/>s to ignore during hash creation.</param>
		/// <returns></returns>
		string Hash(params GameTag[] ignore);
	}
}
