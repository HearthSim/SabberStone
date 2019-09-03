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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Custom Dictionary class for containing <see cref="GameTag"/>/<see cref="int"/> pairs assigned to an <see cref="Entity"/> instance.
	/// Implements <see cref="IDictionary{TKey, TValue}"/>.
	/// This only contains modified/added tags during runtime, rather than card's original tags.
	/// </summary>
	internal class EntityData : IDictionary<GameTag, int>
	{
		private const int _initSize = 16;

		private int[] _buckets;
		private int _size = _initSize;
		private int _count;

		public EntityData()
		{
			var buckets = new int[_initSize << 1];
			for (int i = 0; i < buckets.Length; i += 2)
				buckets[i] = -1;
			_buckets = buckets;
		}

		/// <summary>
		/// Initialise with a given capacity.
		/// </summary>
		public EntityData(int capacity)
		{
			Initialise(capacity);
		}

		/// <summary>
		/// A copy constructor.
		/// </summary>
		/// <param name="entityData">Data to be copeid.</param>
		public unsafe EntityData(in EntityData entityData)
		{
			int len = entityData._buckets.Length;
			//int len = entityData._size << 1;
			_buckets = new int[len];
			fixed (int* srcPtr = entityData._buckets, dstPtr = _buckets)
			{
				int* srcEndPtr = srcPtr + len;
				long* s = (long*)srcPtr;
				long* d = (long*)dstPtr;

				do
				{
					*d = *s;
					d++;
					s++;
					*d = *s;
					d++;
					s++;
				} while (s + 2 <= srcEndPtr);

				*d ^= *s;
			}

			_size = len >> 1;
			_count = entityData._count;
		}

		/// <summary>
		/// A copy constructor for non-<see cref="EntityData"/> dictionaries.
		/// </summary>
		/// <param name="dictionary"></param>
		public EntityData(in IDictionary<GameTag, int> dictionary)
		{
			Initialise(dictionary.Count);
			foreach (KeyValuePair<GameTag, int> kvp in dictionary)
			{
				Add(kvp);
			}
		}

		public void Clear()
		{
			if (_count == 0)
				return;

			int[] buckets = _buckets;
			for (int i = 0; i < buckets.Length; ++i)
				buckets[i] = -1;
			_count = 0;
		}

		public int Count => _count;
		public bool IsReadOnly => false;

		public int this[GameTag key]
		{
			get
			{
				if (Search((int)key, out int i))
					return _buckets[i + 1];
				throw new KeyNotFoundException();
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => InsertOrOverwrite(key, value);
		}

		public void Add(GameTag key, int value)
		{
			if (_count == _size)
				Resize();
			Insert(key, value);
		}

		public void Add(KeyValuePair<GameTag, int> item)
		{
			if (_count == _size)
				Resize();
			Insert(item.Key, item.Value);
		}

		public bool ContainsKey(GameTag key)
		{
			return SearchIndex(key) >= 0;
		}

		public bool Contains(GameTag key, int value)
		{
			int index = SearchIndex(key);
			return index >= 0 && _buckets[index + 1] == value;
		}

		public bool TryGetValue(GameTag key, out int value)
		{
			if (Search((int)key, out int i))
			{
				value = _buckets[i + 1];
				return true;
			}

			value = 0;
			return false;
		}

		public bool Remove(GameTag key)
		{
			int index = SearchIndex(key);
			if (index < 0)
				return false;
			_buckets[index] = 0;
			--_count;
			return true;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void Initialise(int capacity)
		{
			int pow = 8;
			while (pow < capacity)
				pow *= 2;

			int[] buckets = new int[pow << 1];
			for (int i = 0; i < buckets.Length; i +=2)
				buckets[i] = -1;
			_buckets = buckets;

			_size = pow;
		}

		// TODO: check duplicate
		private void Insert(GameTag t, int value)
		{
			int k = (int)t;
			int h = (k & (_size - 1)) << 1;
			int[] buckets = _buckets;
			for (int i = h; i < buckets.Length; i += 2)
			{
				if (buckets[i] > 0)
				{
					if (buckets[i] == k)
						throw new Exceptions.EntityException($"Tag {t} has already been added.");
					continue;
				}
				buckets[i] = k;
				buckets[i + 1] = value;
				++_count;
				return;
			}

			for (int i = 0; i < h; i += 2)
			{
				if (buckets[i] > 0)
				{
					if (buckets[i] == k)
						throw new Exceptions.EntityException($"Tag {t} has already been added.");
					continue;
				}
				buckets[i] = k;
				buckets[i + 1] = value;
				++_count;
				return;
			}

			throw new ArgumentOutOfRangeException();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InsertOrOverwrite(GameTag t, int value)
		{
			if (Search((int)t, out int i))
			{
				//_buckets[i] = (int)t;
				_buckets[i + 1] = value;
				return;
			}

			if (i >= 0)
			{
				_count++;
				_buckets[i] = (int)t;
				_buckets[i + 1] = value;
				return;
			}

			Resize();
			Insert(t, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int SearchIndex(GameTag t)
		{
			int k = (int)t;
			int h = (k & (_size - 1)) << 1;
			int[] buckets = _buckets;
			//ReadOnlySpan<int> buckets = _buckets;
			for (int i = h; i < buckets.Length; i += 2)
			{
				if (buckets[i] == k)
					return i;
				if (buckets[i] < 0)
					return -1;
			}
			for (int i = 0; i < h; i += 2)
			{
				if (buckets[i] < 0)
					return -1;
				if (buckets[i] == k)
					return i;
			}

			return -1;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool Search(int k, out int index)
		{
			int h = (k & (_size - 1)) << 1;
			int[] buckets = _buckets;

			if (buckets[h] == k)
			{
				index = h;
				return true;
			}

			if (buckets[h] < 0)
			{
				index = h;
				return false;
			}
			int i = h + 2;
			if (i < buckets.Length)
			{
				if (buckets[i] < 0)
				{
					index = i;
					return false;
				}
				if (buckets[i] == k)
				{
					index = i;
					return true;
				}

				for (i += 2; i < buckets.Length; i += 2)
				{
					if (buckets[i] < 0)
					{
						index = i;
						return false;
					}

					if (buckets[i] == k)
					{
						index = i;
						return true;
					}
				}
			}

			if (buckets[0] < 0)
			{
				index = 0;
				return false;
			}
			if (buckets[0] == k)
			{
				index = 0;
				return true;
			}

			for (i = 2; i < h; i += 2)
			{
				if (buckets[i] < 0)
				{
					index = i;
					return false;
				}

				if (buckets[i] == k)
				{
					index = i;
					return true;
				}
			}
			index = -1;
			return false;
		}

		private void Resize()
		{
			int newSize = _size << 1;
			_size = newSize;
			int[] newbuckets = new int[newSize << 1];
			for (int i = 0; i < newbuckets.Length; i += 2)
				newbuckets[i] = -1;

			int[] buckets = _buckets;
			//ReadOnlySpan<int> buckets = _buckets;
			for (int i = 0; i < buckets.Length; i += 2)
			{
				bool flag = false;
				int newHash = (buckets[i] & (newSize - 1)) << 1;

				for (int j = newHash; j < newbuckets.Length; j += 2)
				{
					if (newbuckets[j] > 0) continue;
					newbuckets[j] = buckets[i];
					newbuckets[j + 1] = buckets[i + 1];
					flag = true;
					break;
				}

				if (flag)
					continue;

				for (int j = 0; j < newHash; j += 2)
				{
					if (newbuckets[j] > 0) continue;
					newbuckets[j] = buckets[i];
					newbuckets[j + 1] = buckets[i + 1];
					flag = true;
					break;
				}

				if (!flag)
					throw new ArgumentOutOfRangeException();
			}

			_buckets = newbuckets;
		}

		#region IDictionary
		public ICollection<GameTag> Keys
		{
			get
			{
				var tags = new GameTag[_count];
				int[] buckets = _buckets;
				for (int i = 0, j = 0; i < buckets.Length; i += 2)
				{
					if (buckets[i] <= 0) continue;
					tags[j] = (GameTag)buckets[i];
					++j;
				}

				return tags;
			}
		}

		public ICollection<int> Values
		{
			get
			{
				var values = new int[_count];
				int[] buckets = _buckets;
				for (int i = 0, j = 0; i < buckets.Length; i += 2)
				{
					if (buckets[i] <= 0) continue;
					values[j] = buckets[i + 1];
					++j;
				}

				return values;
			}
		}

		public IEnumerator<KeyValuePair<GameTag, int>> GetEnumerator()
		{
			int[] buckets = _buckets;
			for (int i = 0; i < buckets.Length; i += 2)
			{
				if (buckets[i] > 0)
					yield return new KeyValuePair<GameTag, int>((GameTag)buckets[i], buckets[i + 1]);
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public bool Contains(KeyValuePair<GameTag, int> item)
		{
			int index = SearchIndex(item.Key);
			return index >= 0 && _buckets[index + 1] == item.Value;
		}

		public void CopyTo(KeyValuePair<GameTag, int>[] array, int arrayIndex)
		{
			if (array == null)
				throw new ArgumentNullException();
			if (arrayIndex < 0 || arrayIndex > array.Length)
				throw new ArgumentOutOfRangeException();
			if (array.Length - arrayIndex < _count)
				throw new ArgumentException();
			int j = arrayIndex;
			int[] buckets = _buckets;
			for (int i = 0; i < buckets.Length; i += 2)
			{
				if (buckets[i] > 0)
				{
					array[j] = new KeyValuePair<GameTag, int>((GameTag)buckets[i], buckets[i + 1]);
					j++;
				}
			}
		}

		public bool Remove(KeyValuePair<GameTag, int> item)
		{
			return Remove(item.Key);
		}
		#endregion

		/// <summary>Resets all tags from the container.</summary>
		public void Reset()
		{
			// Remove except entity_id, zone and controller
			int[] buckets = _buckets;
			int k = 0;
			Span<int> buffer = stackalloc int[6];
			for (int i = 0; i < buckets.Length; i += 2)
			{
				GameTag key = (GameTag) buckets[i];
				if (key == GameTag.ENTITY_ID ||
				    key == GameTag.CONTROLLER ||
				    key == GameTag.ZONE)
				{
					buffer[k++] = (int)key;
					buffer[k++] = buckets[i + 1];
				}


				buckets[i] = -1;
			}

			_count = 0;

			for (int i = 0; i < k; i += 2)
				Insert((GameTag) buffer[i], buffer[i + 1]);
		}

		/// <summary>
		/// Replace all elements in this dictionary with
		/// the elements of another EntityData.
		/// </summary>
		/// <param name="other"></param>
		public void CopyFrom(in EntityData other)
		{
			int[] otherBucket = other._buckets;
			int[] bucket = new int[otherBucket.Length];
			Array.Copy(otherBucket, bucket, bucket.Length);
			_buckets = bucket;
			_size = other._size;
			_count = other._count;
		}

		/// <summary>
		/// Returns a string uniquely identifying this object.
		/// </summary>
		/// <param name="ignore">The tags to ignore during hashing.</param>
		/// <returns>The hash string.</returns>
		public string Hash(params GameTag[] ignore)
		{
			var hash = new StringBuilder();
			hash.Append("[Tags:");
			foreach (KeyValuePair<GameTag, int> kvp in this.OrderBy(p => p.Key))
			{
				if (!ignore.Contains(kvp.Key))
				{
					hash.Append($"{{{kvp.Key},{kvp.Value}}}");
				}
			}
			hash.Append("]");
			return hash.ToString();
		}

		public override string ToString()
		{
			return Hash();
		}
	}
}


