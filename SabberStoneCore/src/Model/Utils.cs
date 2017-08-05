using SabberStoneCore.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCore.Model
{
	/// <summary>
	/// Provides helper methods for often used functionality.
	/// </summary>
	public static class Util
	{
		/// <summary>The source of randomness.</summary>
		public static readonly Random Random = new Random();		

		/// <summary>Returns a random element from the specified list.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="e">The e.</param>
		/// <returns></returns>
		public static T RandomElement<T>(IEnumerable<T> e)
		{
			return e.ElementAt(Random.Next(0, e.Count())); // Inclusive lower bound - Exclusive upper bound.
		}

		/// <summary>Chooses a random element from the specified list. <seealso cref="RandomElement{T}(IEnumerable{T})"/></summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns></returns>
		public static T Choose<T>(IEnumerable<T> list)
		{
			return RandomElement(list);
		}

		/// <summary>Gets the power set, a set of any subset of the provided set.. including the empty set and itself.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The set of elements.</param>
		/// <returns></returns>
		public static IEnumerable<IReadOnlyOrderedSet<T>> GetPowerSet<T>(IReadOnlySet<T> collection)
		{
			int size = collection.Count;
			return Enumerable.Range(0, 1 << size)
								.Select(m => LightWeightOrderedSet<T>.Build(
													(from i in Enumerable.Range(0, size)
													 where (m & (1 << i)) != 0
													 select collection.ElementAt(i)))
											  );
		}

		/// <summary>Returns all possible discover subsets of all cards. The invariant is that each discover subset
		/// contains exactly 3 cards.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The set of elements.</param>
		/// <returns></returns>
		public static IList<IReadOnlyOrderedSet<T>> GetDiscoverSets<T>(IReadOnlyOrderedSet<T> collection)
		{
			var result = new List<IReadOnlyOrderedSet<T>>();
			for (int i = 0; i < collection.Count - 2; i++)
			{
				T eleA = collection.ElementAt(i);
				for (int j = i + 1; j < collection.Count - 1; j++)
				{
					T eleB = collection.ElementAt(j);
					for (int k = j + 1; k < collection.Count; k++)
					{
						result.Add(LightWeightOrderedSet<T>.Build(new T[] { eleA, eleB, collection.ElementAt(k) }));
					}
				}
			}
			return result;
		}
	}
}
