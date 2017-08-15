using SabberStoneCore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SabberStoneCore.Model
{
	/// <summary>
	/// Provides helper methods for often used functionality.
	/// </summary>
	public static class Util
	{
		/// <summary>The source of randomness.</summary>
		public static Random Random = new Random();

		/// <summary>Returns a random element from the specified list.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="e">The e.</param>
		/// <returns></returns>
		public static T RandomElement<T>(IEnumerable<T> e)
			=> e.ElementAt(Random.Next(0, e.Count()));

		/// <summary>Chooses a random element from the specified list. <seealso cref="RandomElement{T}(IEnumerable{T})"/></summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns></returns>
		public static T Choose<T>(IReadOnlyList<T> list) => RandomElement(list);

		/// <summary>Gets the power set, a set of any subset of the provided set.. including the empty set and itself.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The set of elements.</param>
		/// <returns></returns>
		public static IEnumerable<IEnumerable<T>> GetPowerSet<T>(List<T> list)
			=> Enumerable.Range(0, 1 << list.Count)
				.Select(m => (from i in Enumerable.Range(0, list.Count)
							  where (m & (1 << i)) != 0
							  select list[i]));

		/// <summary>Returns all possible discover subsets of all cards. The invariant is that each discover subset
		/// contains exactly 3 cards.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The set of elements.</param>
		/// <returns></returns>
		public static IEnumerable<IEnumerable<T>> GetDiscoverSets<T>(List<T> list)
		{
			var result = new List<IEnumerable<T>>();
			for (var i = 0; i < list.Count - 2; i++)
			{
				var eleA = list[i];
				for (var j = i + 1; j < list.Count - 1; j++)
				{
					var eleB = list[j];
					for (var k = j + 1; k < list.Count; k++)
					{
						result.Add(new[] { eleA, eleB, list[k] });
					}
				}
			}
			return result;
		}

		/// <summary>
		/// This can be used for caching values ... ex. scoring
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="getValue"></param>
		/// <returns></returns>
		public static Func<T> Remember<T>(Func<T> getValue)
		{
			var isCached = false;
			var cachedResult = default(T);

			return () =>
			{
				if (isCached) return cachedResult;
				cachedResult = getValue();
				isCached = true;
				return cachedResult;
			};
		}

		/// <summary>
		/// Returns the cloned entity attached to the provided new game.
		/// The cloned entity is equivalent to the current entity through the use
		/// of <see cref="IModel.Clone(Game)"/>.
		/// </summary>
		/// <param name="oldObj"></param>
		/// <param name="newGame"></param>
		/// <returns></returns>
		public static IPlayable ClonedFrom(this IEntity oldObj, Game newGame)
		{
			if (oldObj == null)
			{
				return null;
			}

			// TODO; Whitelist of allowed object types for oldObj!

			if(newGame == null)
			{
				return oldObj as IPlayable;
			}

			int entityID = oldObj.Id;
			IPlayable clonedEntity;
			// If the entity was already cloned, simply return it.
			// Otherwise clone it.
			if (!newGame.EntityContainer.TryGetValue(entityID, out clonedEntity))
			{
				clonedEntity = oldObj.Clone(newGame) as IPlayable;
				newGame.EntityContainer[entityID] = clonedEntity;
			}

			return clonedEntity;
		}

		/// <summary>
		/// Returns the cloned controller attached to the provided new game.
		/// The cloned controller is equivalent to the current controller through
		/// the use of <see cref="IModel.Clone(Game)"/>
		/// </summary>
		/// <param name="oldObj"></param>
		/// <param name="newGame"></param>
		/// <returns></returns>
		public static Controller ClonedFrom(this Controller oldObj, Game newGame)
		{
			if (oldObj == null)
			{
				return null;
			}

			if(newGame == null)
			{
				return oldObj;
			}

			int entityID = oldObj.Id;
			Controller clonedEntity = newGame._players.FirstOrDefault(c => c.Id == entityID);
			// If the entity was already cloned, simply return it.
			// Otherwise clone it.
			if (clonedEntity == null)
			{
				clonedEntity = oldObj.Clone(newGame) as Controller;
				newGame._players[clonedEntity.PlayerId - 1] = clonedEntity;
			}

			return clonedEntity;
		}

	}
}
