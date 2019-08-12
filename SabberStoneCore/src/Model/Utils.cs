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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SabberStoneCore.Model
{
	/// <summary>
	/// Provides helper methods for often used functionality.
	/// </summary>
	public static class Util
	{
		/// <summary>The source of randomness.</summary>
		//public static Random Random => ThreadLocalRandom.Instance;

		/// <summary>Returns a random element from the specified list.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="e">The e.</param>
		/// <returns></returns>
		public static T RandomElement<T>(this IEnumerable<T> e, Random rnd)
		{
			IList<T> arr = e as IList<T> ??
			               e.ToArray();
			return arr[rnd.Next(arr.Count)];
		}

		public static T RandomElement<T>(this IEnumerable<T> e, DeepCloneableRandom rnd)
		{
			IList<T> arr = e as IList<T> ??
			               e.ToArray();
			return arr[rnd.Next(arr.Count)];
		}

		/// <summary>Chooses a random element from the specified list. <seealso cref="RandomElement{T}(IEnumerable{T})"/></summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns></returns>
		//public static T Choose<T>(List<T> list) => list[Random.Next(list.Count)];
		public static T Choose<T>(this IReadOnlyList<T> list, Random rnd) => list[rnd.Next(list.Count)];
		//public static T Choose<T>(this IList<T> list, Random rnd) => list[rnd.Next(list.Count)];
		public static T Choose<T>(this IReadOnlyList<T> list, DeepCloneableRandom rnd) => list[rnd.Next(list.Count)];
		//public static T Choose<T>(this IList<T> list, DeepCloneableRandom rnd) => list[rnd.Next(list.Count)];
		//public static T Choose<T>(T[] array) => array[Random.Next(array.Length)];

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

		/// <summary>
		/// Gets N elements from a list of distinct elements by using the default equality comparer.
		/// The source list must not have any repeated elements.
		/// </summary>
		public static T[] ChooseNElements<T>(this IReadOnlyList<T> list, int amount, Random rnd)
		{
			int c = list.Count;
			if (amount > c)
				amount = c;

			T[] results = new T[amount];

			Span<int> indices = stackalloc int[amount];
			for (int k = 0; k < amount; k++)
			{
				int j;
				bool flag;
				do
				{
					j = rnd.Next(c);

					flag = false;
					for (int i = 0; i < k; i++)
						if (indices[i] == j)
						{
							flag = true;
							break;
						}
				} while (flag);

				results[k] = list[j];
				indices[k] = j;
			}


			return results;
		}
		public static T[] ChooseNElements<T>(this IReadOnlyList<T> list, int amount, DeepCloneableRandom rnd)
		{
			int c = list.Count;
			if (amount > c)
				amount = c;

			T[] results = new T[amount];

			Span<int> indices = stackalloc int[amount];
			for (int k = 0; k < amount; k++)
			{
				int j;
				bool flag;
				do
				{
					j = rnd.Next(c);

					flag = false;
					for (int i = 0; i < k; i++)
						if (indices[i] == j)
						{
							flag = true;
							break;
						}
				} while (flag);

				results[k] = list[j];
				indices[k] = j;
			}


			return results;
		}

		/// <summary>
		/// Randomise the order of elements in the given list.
		/// </summary>
		public static IList<T> Shuffle<T>(this IList<T> list, Random rnd)
		{
			for (int i = 0; i < list.Count; i++)
			{
				int r = rnd.Next(i, list.Count);
				T temp = list[i];
				list[i] = list[r];
				list[r] = temp;
			}
			return list;
		}

		public static IList<T> Shuffle<T>(this IList<T> list, DeepCloneableRandom rnd)
		{
			for (int i = 0; i < list.Count; i++)
			{
				int r = rnd.Next(i, list.Count);
				T temp = list[i];
				list[i] = list[r];
				list[r] = temp;
			}
			return list;
		}

		public static Span<T> Shuffle<T>(this Span<T> list, Random rnd)
		{
			for (int i = 0; i < list.Length; i++)
			{
				int r = rnd.Next(i, list.Length);
				T temp = list[i];
				list[i] = list[r];
				list[r] = temp;
			}
			return list;
		}

		public static Span<T> Shuffle<T>(this Span<T> list, DeepCloneableRandom rnd)
		{
			for (int i = 0; i < list.Length; i++)
			{
				int r = rnd.Next(i, list.Length);
				T temp = list[i];
				list[i] = list[r];
				list[r] = temp;
			}
			return list;
		}

		internal static void InsertionSort<T>(this IList<T> list, Func<T, int> intKeySelector)
		{
			for (int i = 1; i < list.Count; i++)
			{
				T temp = list[i];
				int j = i - 1;
				while (j >= 0 && intKeySelector(list[j]) > intKeySelector(temp))
				{
					list[j + 1] = list[j];
					j--;
				}
				list[j + 1] = temp;
			}
		}

		internal static void InsertionSort<T>(this IList<T> list, IList<int> keys)
		{
			if (list.Count != keys.Count)
				throw new ArgumentException("The key list must have the same number of elements of the given list.",
					nameof(keys));

			for (int i = 0; i < list.Count; i++)
			{
				T temp = list[i];
				int tempKey = keys[i];
				int j = i - 1;
				while (j >= 0 && keys[j] > tempKey)
				{
					list[j + 1] = list[j];
					keys[j + 1] = keys[j];
					j--;
				}
				list[j + 1] = temp;
				keys[j + 1] = tempKey;
			}
		}

		internal class PriorityQueue<TValue> where TValue : struct
		{
			[DebuggerDisplay("{DebuggerDisplay,nq}")]
			private class Node
			{
				public readonly TValue Value;
				public readonly int Key;
				public Node Next { get; set; }

				public Node() { }

				public Node(in TValue value, int key)
				{
					Value = value;
					Key = key;
				}

				private string DebuggerDisplay => $"({Value}, {Key})";
			}

			private readonly Node _head = new Node();

			public int Count { get; set; }

			public void Enqueue(in TValue value, int priority)
			{
				Node cursor = _head;

				while (cursor.Next != null)
				{
					if (cursor.Next.Key <= priority)
						cursor = cursor.Next;
					else
						break;
				}

				Node temp = cursor.Next;
				var newNode = new Node(in value, priority);
				cursor.Next = newNode;
				newNode.Next = temp;

				Count++;
			}

			public TValue Dequeue()
			{
				Node node = _head.Next;

				_head.Next = node.Next;

				Count--;

				return node.Value;
			}

			public void Clear()
			{
				Count = 0;
				_head.Next = null;
			}

			public bool Contains(in TValue value)
			{
				Node cursor = _head.Next;

				while (cursor != null)
				{
					if (cursor.Value.Equals(value))
						return true;

					cursor = cursor.Next;
				}

				return false;
			}

			public bool Contains(in TValue value, IEqualityComparer<TValue> comparer)
			{
				Node cursor = _head.Next;
				while (cursor != null)
				{
					if (comparer.Equals(cursor.Value, value))
						return true;

					cursor = cursor.Next;
				}

				return false;
			}

			public IEnumerator<TValue> GetEnumerator()
			{
				Node cursor = _head;
				while (cursor.Next != null)
				{
					yield return cursor.Next.Value;
					cursor = cursor.Next;
				}
			}
		}

		internal class SmallFastCollection : ICollection<int>
		{
			private const int InitSize = 6;

			private int[] _array;
			private int _index;
			private int _size;

			public int Count { get; private set; }
			public bool IsReadOnly => false;

			public SmallFastCollection()
			{
				_array = new int[InitSize];
				_size = InitSize;
			}

			public SmallFastCollection(int size)
			{
				_array = new int[size];
				_size = size;
			}

			public SmallFastCollection(SmallFastCollection other)
			{
				int s = other._size;
				var array = new int[s];
				Array.Copy(other._array, array, s);

				_size = s;
				_index = other._index;
				_array = array;
				Count = other.Count;
			}

			public void Add(int item)
			{
				int c = Count;
				int i = _index;
				int s = _size;

				if (c == s)
				{
					Resize();
					s = _size;
					i = _index;
				}

				_array[i] = item;
				Count = ++c;

				if (c == s)
					return;

				while (++i < s)
				{
					if (_array[i] == 0)
					{
						_index = i;
						return;
					}
				}
				i = 0;
				do
				{
					if (_array[i] == 0)
					{
						_index = i;
						return;
					}

					i++;
				} while (true);
			}

			public void CopyTo(int[] array, int arrayIndex)
			{
				throw new NotImplementedException();
			}

			public bool Remove(int item)
			{
				int c = Count;
				if (c == 0) return false;
				int i, j = 0;
				int[] array = _array;
				for (i = 0; i < array.Length; i++)
				{
					if (array[i] == 0) continue;

					if (array[i] == item) break;

					if (++j == c) return false;
				}

				_array[i] = 0;
				_index = i;
				Count = c - 1;

				return true;
			}

			public bool Contains(int item)
			{
				return Search(item) >= 0;
			}

			public void Clear()
			{
				_array = new int[_size];
				Count = 0;
				_index = 0;
			}

			public void ForEach(Action<int> action)
			{
				int[] array = _array;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == 0) continue;
					action(array[i]);
				}
			}
			public void ForEach<T>(T arg, Action<int, T> action)
			{
				int[] array = _array;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == 0) continue;
					action(array[i], arg);
				}
			}
			public void ForEach<T1, T2>(T1 arg1, T2 arg2, Action<int, T1, T2> action)
			{
				int[] array = _array;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == 0) continue;
					action(array[i], arg1, arg2);
				}
			}

			private int Search(int item)
			{
				int[] array = _array;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == 0) continue;

					if (array[i] == item)
						return i;
				}
				return -1;
			}

			private void Resize()
			{
				int s = _size;
				int newSize = s * 2;
				var newArray = new int[newSize];
				Array.Copy(_array, newArray, s);
				_array = newArray;
				_size = newSize;
				_index = s;
			}

			public IEnumerator<int> GetEnumerator()
			{
				return new Enumerator(_array);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}

			private class Enumerator : IEnumerator<int>
			{
				private int[] _arr;
				private int _current = -1;

				public Enumerator(int[] arr)
				{
					_arr = arr;
				}

				public bool MoveNext()
				{
					while (true)
					{
						if (++_current == _arr.Length)
							return false;
						if (_arr[_current] == 0)
							continue;
						return true;
					}
				}

				public void Reset()
				{
					_current = 0;
				}

				public int Current => _arr[_current];

				object IEnumerator.Current => Current;

				public void Dispose()
				{
					_arr = null;
				}
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
			private static Random globalRandom = new Random();
			private static readonly object globalLock = new object();

			/// <summary> 
			/// Random number generator 
			/// </summary> 
			private static ThreadLocal<Random> threadRandom = new ThreadLocal<Random>(NewRandom);

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
			public static Random Instance => threadRandom.Value;

			/// <summary>See <see cref="Random.Next()" /></summary> 
			public static int Next()
			{
				return Instance.Next();
			}

			/// <summary>See <see cref="Random.Next(Int32)" /></summary> 
			public static int Next(int maxValue)
			{
				return Instance.Next(maxValue);
			}

			/// <summary>See <see cref="Random.Next(Int32, Int32)" /></summary> 
			public static int Next(int minValue, int maxValue)
			{
				return Instance.Next(minValue, maxValue);
			}

			/// <summary>See <see cref="Random.NextDouble()" /></summary> 
			public static double NextDouble()
			{
				return Instance.NextDouble();
			}

			/// <summary>See <see cref="Random.NextBytes(Byte[])" /></summary> 
			public static void NextBytes(byte[] buffer)
			{
				Instance.NextBytes(buffer);
			}

			public static void SetSeed(int seed)
			{
				threadRandom.Value = new Random(seed);
			}
		}

		/*  Written in 2016 by David Blackman and Sebastiano Vigna (vigna@acm.org)
		To the extent possible under law, the author has dedicated all copyright
		and related and neighboring rights to this software to the public domain
		worldwide. This software is distributed without any warranty.
		See <http://creativecommons.org/publicdomain/zero/1.0/>. */

		/*
		 * A port of Blackman and Vigna's xoroshiro128+ generator to C# for Unity Development.
		 * This is a direct rewrite from the JAVA implementation by SquidPony.
		 * <br>
		 * <a href="https://github.com/SquidPony/SquidLib">SquidLib SquidPony</a>
		 * <br>
		 * <br>
		 * <a href="http://xoroshiro.di.unimi.it/xoroshiro128plus.c">Original version here.</a>
		 * <br>
		 * Written in 2016 by David Blackman and Sebastiano Vigna (vigna@acm.org)
		 *
		 * @author Kaustav Das
		 */

		// Modified by rnilva
		public class DeepCloneableRandom
		{
			private const long DOUBLE_MASK = (1L << 53) - 1;
		    private const double NORM_53 = 1.0 / (1L << 53);
		    private const long FLOAT_MASK = (1L << 24) - 1;
		    private const double NORM_24 = 1.0 / (1L << 24);

		    private long _state0;
		    private long _state1;

		    /// <summary>
		    /// Creates a generator seeded using four calls to System.Random
		    /// </summary>
		    public DeepCloneableRandom()
		    {
		        Random rand = ThreadLocalRandom.Instance;
		        _state0 = (long)((rand.NextDouble() - 0.5) * 4503599627370496) ^ (long)(((rand.NextDouble() - 0.5) * 2.0) * -9223372036854775808);
		        _state1 = (long)((rand.NextDouble() - 0.5) * 4503599627370496) ^ (long)(((rand.NextDouble() - 0.5) * 2.0) * -9223372036854775808);
		        if ((_state0 | _state1) == 0L)
		            _state0 = 1L;
		    }

		    /// <summary>
		    /// Creates a generator seeded using LightRNG for both the states
		    /// </summary>
		    /// <param name="seed">Parameter name expalins it!!!</param>
		    public DeepCloneableRandom(long seed)
		    {
		        SetSeed(seed);
		    }

		    /// <summary>
		    /// Creates a generator seeded using the two given states as parameter. The states are left unchanged unless they both are 0. If both are 0, stateA is changed to 1
		    /// </summary>
		    /// <param name="stateA">State0</param>
		    /// <param name="stateB">State1</param>
		    public DeepCloneableRandom(long stateA, long stateB)
		    {
		        SetSeed(stateA, stateB);
		    }

			// The copy constructor.
		    private DeepCloneableRandom(DeepCloneableRandom other)
		    {
			    _state0 = other._state0;
				_state1 = other._state1;
		    }

		    /// <summary>
		    /// A Random Integer after typecasting the result from NextLong to int
		    /// </summary>
		    /// <returns>Obviously a Random Integer!!!</returns>
		    public int Next()
		    {
		        return (int)NextLong();
		    }

		    /// <summary>
		    /// A Random Integer between inclusive 0 and exclusive bound. The bound can be negative, which will give non-negative integer
		    /// </summary>
		    /// <param name="bound">Exclusive bound; can be negative</param>
		    /// <returns>Random Integer between 0(inclusive) and bound(exclusive)</returns>
		    public int Next(int bound)
		    {
		        return (int)((bound * UnsignedRightShift(NextLong(), 33)) >> 31);
		    }

		    /// <summary>
		    /// A Random Integer between inclusive inner and exclusive bound.
		    /// </summary>
		    /// <param name="inner">Inclusive inner bound; Can be positive or negative</param>
		    /// <param name="outer">Exclusive outer bound; Should be positive and greater or equal to inner bound</param>
		    /// <returns>Random Integer between inner(inclusive) and outer(exclusive)</returns>
		    public int Next(int inner, int outer)
		    {
		        return inner + Next(outer - inner);
		    }

		    /// <summary>
		    /// Returns a Random Long
		    /// </summary>
		    /// <returns>A Random Long, duh!!!</returns>
		    public long NextLong()
		    {
		        long s0 = _state0;
		        long s1 = _state1;
		        long result = s0 + s1;

		        s1 ^= s0;
		        _state0 = (s0 << 55 | UnsignedRightShift(s0, 9)) ^ s1 ^ (s1 << 14);
		        _state1 = (s1 << 36 | UnsignedRightShift(s1, 28));
		        return result;
		    }

		    /// <summary>
		    /// A Random Long between inclusive 0 and exclusive bound. The bound can be negative, which will give non-negative long
		    /// </summary>
		    /// <param name="bound">Exclusive bound; can be negative</param>
		    /// <returns>Random Long between 0(inclusive) and bound(exclusive)</returns>
		    public long NextLong(long bound)
		    {
		        long rand = NextLong();
		        long randLow = rand & 4294967295;
		        long boundLow = bound & 4294967295;
		        rand = UnsignedRightShift(rand, 32);
		        bound >>= 32;
		        long z = (randLow * boundLow >> 32);
		        long t = rand * boundLow + z;
		        long tLow = t & 4294967295;
		        t = UnsignedRightShift(t, 32);
		        return rand * bound + t + (tLow + randLow * bound >> 32) - (z >> 63) - (bound >> 63);
		    }

		    /// <summary>
		    /// A Random Long between inclusive inner and exclusive bound.
		    /// </summary>
		    /// <param name="inner">Inclusive inner bound; Can be positive or negative</param>
		    /// <param name="outer">Exclusive outer bound; Should be positive and greater or equal to inner bound</param>
		    /// <returns></returns>
		    public long NextLong(long inner, long outer)
		    {
		        return inner + NextLong(outer - inner);
		    }

		    public double NextDouble()
		    {
		        return (NextLong() & DOUBLE_MASK) * NORM_53;
		    }

		    public float NextFloat()
		    {
		        return (float)((NextLong() & FLOAT_MASK) * NORM_24);
		    }

		    public bool NextBoolean()
		    {
		        return NextLong() < 0L;
		    }

		    public void NextBytes(sbyte[] bytes)
		    {
		        int i = bytes.Length, n = 0;
		        while (i != 0)
		        {
		            n = Math.Min(i, 8);
		            for (long bits = NextLong(); n-- != 0; bits = UnsignedRightShift(bits, 8))
		            {
		                Console.WriteLine((sbyte)bits);
		                bytes[--i] = (sbyte)bits;
		            }
		        }
		    }

		    /// <summary>
		    /// Generates the two states based on the seed provided by running LightRNG's algorithm
		    /// </summary>
		    /// <param name="seed"></param>
		    public void SetSeed(long seed)
		    {
		        long state = seed + -7046029254386353131,
		                z = state;
		        z = (z ^ UnsignedRightShift(z, 30)) * -4658895280553007687;
		        z = (z ^ UnsignedRightShift(z, 27)) * -7723592293110705685;
		        _state0 = z ^ UnsignedRightShift(z, 31);
		        state += -7046029254386353131;
		        z = state;
		        z = (z ^ UnsignedRightShift(z, 30)) * -4658895280553007687;
		        z = (z ^ UnsignedRightShift(z, 27)) * -7723592293110705685;
		        _state1 = z ^ UnsignedRightShift(z, 31);
		    }

		    public void SetSeed(long stateA, long stateB)
		    {
		        _state0 = stateA;
		        _state1 = stateB;
		        if ((stateA | stateB) == 0L)
		            _state0 = 1L;
		    }

		    /// <summary>
		    /// Produces a copy of this DeepCloneableRandom instance, such that next generated numbers by the returned instance is 
		    /// same as the current instance's next generated numbers. This just copies the states to the new instance 
		    /// and, usually, produce new value with the same exact states.
		    /// </summary>
		    /// <returns></returns>
		    public DeepCloneableRandom Clone()
		    {
			    return new DeepCloneableRandom(this);
		    }

		    public int HashCode()
		    {
		        return (int)(31L * (_state0 ^ UnsignedRightShift(_state0, 32)) + (_state1 ^ UnsignedRightShift(_state1, 32)));
		    }

		    private long UnsignedRightShift(long value, int shiftBits)
		    {
		        return (long)((ulong)value >> shiftBits);
		    }

		    private int UnsignedRightShift(int value, int shiftBits)
		    {
		        return (int)((uint)value >> shiftBits);
		    }
		}
	}
}
