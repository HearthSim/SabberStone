using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Holds original entity data for a specific card.
	/// </summary>
	internal class EntityData : IEnumerable<KeyValuePair<GameTag, int>>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EntityData"/> class.
		/// </summary>
		/// <param name="card"></param>
		/// <param name="tags"></param>
		internal EntityData(Card card, IDictionary<GameTag, int> tags)
		{
			Card = card;
			//Tags = tags ?? new Dictionary<GameTag, int>(Enum.GetNames(typeof(GameTag)).Length);
			///Tags = tags ?? new Dictionary<GameTag, int>(11);
			Tags = tags ?? new Data();
		}

		/// <summary>
		/// A copy constructor. This constructor is only used for copying an <see cref="Entity"/>.
		/// </summary>
		/// <param name="entityData">The source <see cref="EntityData"/>.</param>
		internal EntityData(EntityData entityData)
		{
			Card = entityData.Card;
			//Tags = new Dictionary<GameTag, int>(entityData.Tags);
			Tags = new Data((Data) entityData.Tags);
		}

		/// <summary>
		/// Copies data from the other object into this one.
		/// </summary>
		/// <param name="data">The data.</param>
		public void Stamp(EntityData data)
		{
			Tags = new Dictionary<GameTag, int>(data.Tags);
		}

		/// <summary>
		/// Returns a string uniquely identifying this object.
		/// </summary>
		/// <param name="ignore">The tags to ignore during hashing.</param>
		/// <returns>The hash string.</returns>
		public string Hash(params GameTag[] ignore)
		{
			var hash = new StringBuilder();
			hash.Append("[");
			hash.Append(Card.Id);
			hash.Append("][GT:");
			foreach (KeyValuePair<GameTag, int> kvp in Tags.OrderBy(p => p.Key))
			{
				if (!ignore.Contains(kvp.Key))
				{
					hash.Append($"{{{kvp.Key},{kvp.Value}}}");
				}
			}
			hash.Append("]");
			return hash.ToString();
		}

		/// <summary>
		/// The card which was used to create this instance.
		/// </summary>
		public Card Card { get; set; }

		/// <summary>
		/// The container with tags used to create this instance.
		/// </summary>
		/// TODO; This might be made private.
		public IDictionary<GameTag, int> Tags { get; private set; }

		/// <summary>Gets or sets the value of a specific GameTag.</summary>
		/// <value></value>
		/// <param name="t">The GameTag.</param>
		/// <returns></returns>
		public int this[GameTag t]
		{
			get
			{
				if (Tags.TryGetValue(t, out int value))
					return value;

				Card.Tags.TryGetValue(t, out value);
				return value;
			}
			set { Tags[t] = value; }
		}

		public IEnumerator<KeyValuePair<GameTag, int>> GetEnumerator()
		{
			// Entity ID
			var allTags = new Dictionary<GameTag, int>(Card.Tags);

			// Entity tags override card tags
			foreach (KeyValuePair<GameTag, int> tag in Tags)
			{
				allTags[tag.Key] = tag.Value;
			}

			return allTags.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public override string ToString()
		{
			string s = Tags.Aggregate(Card.Name + " - ", (current, tag) => current + new Tag(tag.Key, tag.Value) + ", ");
			return s.Substring(0, s.Length - 2);
		}

		/// <summary>Resets all tags from the container.</summary>
		public void Reset(Dictionary<GameTag, int> tags = null)
		{
			//Tags = tags ?? new Dictionary<GameTag, int>(Enum.GetNames(typeof(GameTag)).Length);
			Tags.Remove(GameTag.DAMAGE);
			Tags.Remove(GameTag.PREDAMAGE);
			Tags.Remove(GameTag.ZONE_POSITION);
			Tags.Remove(GameTag.EXHAUSTED);
			Tags.Remove(GameTag.JUST_PLAYED);
			Tags.Remove(GameTag.SUMMONED);
			Tags.Remove(GameTag.ATTACKING);
			Tags.Remove(GameTag.DEFENDING);
			Tags.Remove(GameTag.ATK);
			Tags.Remove(GameTag.HEALTH);
			Tags.Remove(GameTag.COST);
			Tags.Remove(GameTag.TAUNT);
			Tags.Remove(GameTag.FROZEN);
			Tags.Remove(GameTag.ENRAGED);
			Tags.Remove(GameTag.CHARGE);
			Tags.Remove(GameTag.WINDFURY);
			Tags.Remove(GameTag.DIVINE_SHIELD);
			Tags.Remove(GameTag.STEALTH);
			Tags.Remove(GameTag.DEATHRATTLE);
			Tags.Remove(GameTag.BATTLECRY);
			Tags.Remove(GameTag.SILENCED);
			Tags.Remove(GameTag.NUM_ATTACKS_THIS_TURN);
			Tags.Remove(GameTag.NUM_TURNS_IN_PLAY);
		}

		internal class Data : IDictionary<GameTag, int>
		{
			private static readonly int[] Primes =
			{
				7,
				11,
				17,
				23,
				29,
				37,
				47,
				59,
				71,
				89,
				107,
				131,
				163,
				197,
				239,
				293,
				353,
				431,
				521,
				631,
				761,
				919,
				1103,
				1327,
				1597,
				1931,
				2333,
				2801,
				3371,
				4049,
				4861,
				5839,
				7013,
				8419,
				10103,
				12143,
				14591,
				17519,
				21023,
				25229,
				30293,
				36353,
				43627,
				52361,
				62851,
				75431,
				90523,
				108631,
				130363,
				156437,
				187751,
				225307,
				270371,
				324449,
				389357,
				467237,
				560689,
				672827,
				807403,
				968897,
				1162687,
				1395263,
				1674319,
				2009191,
				2411033,
				2893249,
				3471899,
				4166287,
				4999559,
				5999471,
				7199369
			};

			private const int _initSize = 23;

			private int[] _buckets;
			private int _size = _initSize;
			private int _count;

			public Data()
			{
				_buckets = new int[_initSize << 1];
				for (int i = 0; i < _buckets.Length; i++)
					_buckets[i] = -1;
			}

			public Data(int capacity)
			{
				Initialise(capacity);
			}

			public unsafe Data(Data data)
			{
				int len = data._buckets.Length;
				_buckets = new int[len];
				fixed (int* srcPtr = data._buckets, dstPtr = _buckets)
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
				_count = data._count;
			}

			public void Clear()
			{
				if (_count == 0)
					return;
				for (int i = 0; i < _buckets.Length; ++i)
					_buckets[i] = -1;
				_count = 0;
			}

			public int Count => _count;
			public bool IsReadOnly { get; }

			public int this[GameTag key]
			{
				get
				{
					if (Search((int) key, out int i))
						return _buckets[i + 1];
					throw new KeyNotFoundException();
				}
				set => InsertOrOverwrite(key, value);
			}

			public void Add(GameTag key, int value)
			{
				Insert(key, value);
				//InsertOrOverwrite(key, value);
			}

			public void Add(KeyValuePair<GameTag, int> item)
			{
				Insert(item.Key, item.Value);
			}

			public bool ContainsKey(GameTag key)
			{
				return SearchIndex(key) >= 0;
			}

			public bool TryGetValue(GameTag key, out int value)
			{
				if (Search((int) key, out int i))
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

			private void Initialise(int capacity)
			{
				//int prime = GetPrime(capacity);
				_buckets = new int[capacity << 1];
				for (int i = 0; i < _buckets.Length; i++)
					_buckets[i] = -1;
				_size = capacity;
			}

			// TODO: check duplicate
			private void Insert(GameTag t, int value)
			{
				//if (_count > (_size >> 2) * 3)
				//	Resize();
				if (_count == _size)
					Resize();

				int k = (int)t;
				int slotIndex = (k % _size) << 1;
				for (int i = slotIndex; i < _buckets.Length; i += 2)
				{
					if (_buckets[i] > 0) continue;
					_buckets[i] = k;
					_buckets[i + 1] = value;
					++_count;
					return;
				}

				for (int i = 0; i < slotIndex; i += 2)
				{
					if (_buckets[i] > 0) continue;
					_buckets[i] = k;
					_buckets[i + 1] = value;
					++_count;
					return;
				}

				throw new ArgumentOutOfRangeException();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private void InsertOrOverwrite(GameTag t, int value)
			{
				if (Search((int) t, out int i))
				{
					_buckets[i] = (int)t;
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

			private int SearchIndex(GameTag t)
			{
				int k = (int)t;
				int slotIndex = (k % _size) << 1;
				for (int i = slotIndex; i < _buckets.Length; i += 2)
				{
					if (_buckets[i] == k)
						return i;
					if (_buckets[i] < 0)
						return -1;
				}
				for (int i = 0; i < slotIndex; i += 2)
				{
					if (_buckets[i] < 0)
						return -1;
					if (_buckets[i] == k)
						return i;
				}

				return -1;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private bool Search(int k, out int index)
			{
				int h = (k % _size) << 1;
				int i = h;
				if (_buckets[i] == k)
				{
					index = i;
					return true;
				}

				if (_buckets[i] < 0)
				{
					index = i;
					return false;
				}
				i += 2;
				if (i < _buckets.Length)
				{
					if (_buckets[i] == k)
					{
						index = i;
						return true;
					}

					if (_buckets[i] < 0)
					{
						index = i;
						return false;
					}
					for (i += 2; i < _buckets.Length; i += 2)
					{
						if (_buckets[i] < 0)
						{
							index = i;
							return false;
						}

						if (_buckets[i] == k)
						{
							index = i;
							return true;
						}
					}
				}

				if (_buckets[0] < 0)
				{
					index = 0;
					return false;
				}
				if (_buckets[0] == k)
				{
					index = 0;
					return true;
				}

				for (i = 2; i < h; i += 2)
				{
					if (_buckets[i] < 0)
					{
						index = i;
						return false;
					}

					if (_buckets[i] == k)
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
				int newSize = GetPrime(_size << 1);
				_size = newSize;
				int[] newbuckets = new int[newSize << 1];
				for (int i = 0; i < newbuckets.Length; ++i)
					newbuckets[i] = -1;

				for (int i = 0; i < _buckets.Length; i += 2)
				{
					bool flag = false;

					int newIndex = (_buckets[i] % newSize) << 1;

					for (int j = newIndex; j < newbuckets.Length; j += 2)
					{
						if (newbuckets[j] >= 0) continue;
						newbuckets[j] = _buckets[i];
						newbuckets[j + 1] = _buckets[i + 1];
						flag = true;
						break;
					}

					if (flag)
						continue;

					for (int j = 0; j < newIndex; j += 2)
					{
						if (newbuckets[j] >= 0) continue;
						newbuckets[j] = _buckets[i];
						newbuckets[j + 1] = _buckets[i + 1];
						flag = true;
						break;
					}

					if (!flag)
						throw new ArgumentOutOfRangeException();
				}

				_buckets = newbuckets;
			}

			private static int GetPrime(int min)
			{
				for (int index = 0; index < Primes.Length; ++index)
				{
					int prime = Primes[index];
					if (prime >= min)
						return prime;
				}

				throw new IndexOutOfRangeException();
			}

			#region IDictionary

			//	NotImplemented
			public ICollection<GameTag> Keys { get; }
			public ICollection<int> Values { get; }

			public IEnumerator<KeyValuePair<GameTag, int>> GetEnumerator()
			{
				for (int i = 0; i < _buckets.Length; i += 2)
				{
					if (_buckets[i] > 0)
						yield return new KeyValuePair<GameTag, int>((GameTag)_buckets[i], _buckets[i + 1]);
				}
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}

			public bool Contains(KeyValuePair<GameTag, int> item)
			{
				int index = SearchIndex(item.Key);
				return index >= 0 && _buckets[index] == item.Value;
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
				for (int i = 0; i < _buckets.Length; i += 2)
				{
					if (_buckets[i] > 0)
					{
						array[j] = new KeyValuePair<GameTag, int>((GameTag)_buckets[i], _buckets[i + 1]);
						j++;
					}
				}
			}

			public bool Remove(KeyValuePair<GameTag, int> item)
			{
				return Remove(item.Key);
			}
			#endregion
		}
	}
}


