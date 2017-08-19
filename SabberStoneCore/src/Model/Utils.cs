using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SabberStoneCore.Model
{
	/// <summary>
	/// Provides helper methods for often used functionality.
	/// </summary>
	public class Util
	{
		/// <summary>The source of randomness.</summary>
		public static Random Random => ThreadLocalRandom.Instance;

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
			for (int i = 0; i < list.Count - 2; i++)
			{
				T eleA = list[i];
				for (int j = i + 1; j < list.Count - 1; j++)
				{
					T eleB = list[j];
					for (int k = j + 1; k < list.Count; k++)
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
			bool isCached = false;
			var cachedResult = default(T);

			return () =>
			{
				if (isCached) return cachedResult;
				cachedResult = getValue();
				isCached = true;
				return cachedResult;
			};
		}

	}

	/// <summary>
	/// Provides thread-safe random number generator
	/// </summary>
	public static class ThreadLocalRandom
	{
		/// <summary> 
		/// Random number generator used to generate seeds, 
		/// which are then used to create new random number 
		/// generators on a per-thread basis. 
		/// </summary> 
		private static readonly Random globalRandom = new Random();
		private static readonly object globalLock = new object();

		/// <summary> 
		/// Random number generator 
		/// </summary> 
		private static readonly ThreadLocal<Random> threadRandom = new ThreadLocal<Random>(NewRandom);

		/// <summary> 
		/// Creates a new instance of Random. The seed is derived 
		/// from a global (static) instance of Random, rather 
		/// than time. 
		/// </summary> 
		public static Random NewRandom()
		{
			lock (globalLock)
			{
				return new Random(globalRandom.Next());
			}
		}

		/// <summary> 
		/// Returns an instance of Random which can be used freely 
		/// within the current thread. 
		/// </summary> 
		public static Random Instance { get { return threadRandom.Value; } }

		/// <summary>See <see cref="Random.Next()" /></summary> 
		public static int Next()
		{
			return Instance.Next();
		}

		/// <summary>See <see cref="Random.Next(int)" /></summary> 
		public static int Next(int maxValue)
		{
			return Instance.Next(maxValue);
		}

		/// <summary>See <see cref="Random.Next(int, int)" /></summary> 
		public static int Next(int minValue, int maxValue)
		{
			return Instance.Next(minValue, maxValue);
		}

		/// <summary>See <see cref="Random.NextDouble()" /></summary> 
		public static double NextDouble()
		{
			return Instance.NextDouble();
		}

		/// <summary>See <see cref="Random.NextBytes(byte[])" /></summary> 
		public static void NextBytes(byte[] buffer)
		{
			Instance.NextBytes(buffer);
		}
	}
}
