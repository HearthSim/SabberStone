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
				private int _current;

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

		/// <summary>The source of randomness.</summary>
		public static Random Random => ThreadLocalRandom.Instance;

		/// <summary>Returns a random element from the specified list.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="e">The e.</param>
		/// <returns></returns>
		public static T RandomElement<T>(IEnumerable<T> e)
		{
			IList<T> arr = e as IList<T> ??
			               e.ToArray();
			return arr[Random.Next(arr.Count)];
		}

		/// <summary>Chooses a random element from the specified list. <seealso cref="RandomElement{T}(IEnumerable{T})"/></summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns></returns>
		public static T Choose<T>(List<T> list) => list[Random.Next(list.Count)];
		public static T Choose<T>(IReadOnlyList<T> readonlyList) => readonlyList[Random.Next(readonlyList.Count)];
		public static T Choose<T>(T[] array) => array[Random.Next(array.Length)];

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
		public static T[] ChooseNElements<T>(this IReadOnlyList<T> list, int amount)
		{
			Random rnd = Random;
			int c = list.Count;
			if (amount > c)
				amount = c;

			int[] indices = Enumerable.Range(0, c).ToArray();

			T[] results = new T[amount];
			for (int i = 0, k = 0; i < amount; i++)
			{
				int j = rnd.Next(i, c);

				int temp = indices[i];
				indices[i] = indices[j];
				indices[j] = temp;

				results[k++] = list[indices[i]];
			}

			return results;
		}

		/// <summary>
		/// Randomise the order of elements in the given list.
		/// </summary>
		public static IList<T> Shuffle<T>(this IList<T> list, Random rnd = null)
		{
			if (rnd == null)
				rnd = Random;
			for (int i = 0; i < list.Count; i++)
			{
				int r = rnd.Next(i, list.Count);
				T temp = list[i];
				list[i] = list[r];
				list[r] = temp;
			}
			return list;
		}

		internal static void InsertionSort<T>(this List<T> list, Func<T, int> intKeySelector)
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
	}
}
