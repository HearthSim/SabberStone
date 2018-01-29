using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
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
			var keys = Tags.Keys.ToList();
			keys.Sort();
			keys.ForEach(p =>
			{
				if (!ignore.Contains(p))
				{
					hash.Append("{");
					hash.Append(p.ToString());
					hash.Append(",");
					hash.Append(Tags[p].ToString());
					hash.Append("}");
				}
			});
			hash.Append("]");
			return hash.ToString();
		}

		/// <summary>
		/// The card which was used to create this instance.
		/// </summary>
		public Card Card { get; }

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
			//get { return Tags.ContainsKey(t) ? Tags[t] : (Card.Tags.ContainsKey(t) ? Card[t] : 0); }
			get
			{
				if (Tags.TryGetValue(t, out int value))
					return value;

				Card.Tags.TryGetValue(t, out value);
				return value;
				//return 0;
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
			private const int _initSize = 7;

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

			public Data(Data data)
			{
				_buckets = new int[data._buckets.Length];
				//data._buckets.CopyTo(_buckets, 0);
				Buffer.BlockCopy(data._buckets, 0, _buckets, 0, data._size << 3);
				_size = data._size;
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
					int i = Search(key);
					if (i >= 0)
						return _buckets[i + 1];
					throw new KeyNotFoundException();
				}
				set => InsertOrOverWrite(key, value);
			}

			public void Add(GameTag key, int value)
			{
				Insert(key, value);
			}

			public void Add(KeyValuePair<GameTag, int> item)
			{
				Insert(item.Key, item.Value);
			}

			public bool ContainsKey(GameTag key)
			{
				return Search(key) >= 0;
			}

			public bool TryGetValue(GameTag key, out int value)
			{
				int index = Search(key);
				if (index >= 0)
				{
					value = _buckets[++index];
					return true;
				}

				value = 0;
				return false;
			}

			public bool Remove(GameTag key)
			{
				int index = Search(key);
				if (index < 0)
					return false;
				_buckets[index++] = -1;
				_buckets[index] = -1;
				--_count;
				return true;
			}

			private void Initialise(int capacity)
			{
				int prime = GetPrime(capacity);
				_buckets = new int[prime];
				for (int i = 0; i < _buckets.Length; i++)
					_buckets[i] = -1;
			}

			private void Insert(GameTag t, int value)
			{
				if (_count == _size)
					Resize();

				int k = (int)t;

				int slotIndex = (k % _size) << 1;
				for (int i = slotIndex; i < _buckets.Length; i += 2)
				{
					if (_buckets[i] >= 0) continue;
					_buckets[i] = k;
					_buckets[i + 1] = value;
					++_count;
					return;
				}

				for (int i = 0; i < slotIndex; i += 2)
				{
					if (_buckets[i] >= 0) continue;
					_buckets[i] = k;
					_buckets[i + 1] = value;
					++_count;
					return;
				}

				throw new ArgumentOutOfRangeException();
			}

			private void InsertOrOverWrite(GameTag t, int value)
			{
				int index = Search(t);
				if (index >= 0)
				{
					_buckets[index] = (int)t;
					_buckets[index + 1] = value;
					return;
				}

				Insert(t, value);
			}

			private int Search(GameTag t)
			{
				int k = (int)t;
				int slotIndex = (k % _size) << 1;
				for (int i = slotIndex; i < _buckets.Length; i += 2)
				{
					if (_buckets[i] < 0)
						return -1;
					if (_buckets[i] == k)
						return i;
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
				int index = Search(item.Key);
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
				for (int i = 0; i < _buckets.Length; i++)
				{
					if (_buckets[i] > 0)
						array[arrayIndex++] = new KeyValuePair<GameTag, int>((GameTag)_buckets[i++], _buckets[i]);
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


