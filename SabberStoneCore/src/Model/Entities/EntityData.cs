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
	/// Holds original entity data for a specific card.
	/// </summary>
	//internal class EntityData : IEnumerable<KeyValuePair<GameTag, int>>
	//{
	//	internal EntityData(Card card)
	//	{
	//		Card = card;
	//		Tags = new Data();
	//	}

	//	/// <summary>
	//	/// Initializes a new instance of the <see cref="EntityData"/> class.
	//	/// </summary>
	//	/// <param name="card"></param>
	//	/// <param name="tags"></param>
	//	internal EntityData(Card card, IDictionary<GameTag, int> tags)
	//	{
	//		Card = card;
	//		if (tags == null)
	//			Tags = new Data();
	//		else if (tags is Data d)
	//			Tags = d;
	//		else
	//			Tags = new Data(in tags);
	//	}

	//	/// <summary>
	//	/// A copy constructor. This constructor is only used for copying an <see cref="Entity"/>.
	//	/// </summary>
	//	/// <param name="entityData">The source <see cref="EntityData"/>.</param>
	//	internal EntityData(EntityData entityData)
	//	{
	//		Card = entityData.Card;
	//		Tags = new Data(entityData.Tags);
	//	}

	//	/// <summary>
	//	/// Returns a string uniquely identifying this object.
	//	/// </summary>
	//	/// <param name="ignore">The tags to ignore during hashing.</param>
	//	/// <returns>The hash string.</returns>
	//	public string Hash(params GameTag[] ignore)
	//	{
	//		var hash = new StringBuilder();
	//		hash.Append("[");
	//		hash.Append(Card.Id);
	//		hash.Append("][GT:");
	//		foreach (KeyValuePair<GameTag, int> kvp in Tags.OrderBy(p => p.Key))
	//		{
	//			if (!ignore.Contains(kvp.Key))
	//			{
	//				hash.Append($"{{{kvp.Key},{kvp.Value}}}");
	//			}
	//		}
	//		hash.Append("]");
	//		return hash.ToString();
	//	}

	//	/// <summary>
	//	/// The card which was used to create this instance.
	//	/// </summary>
	//	public Card Card { get; set; }

	//	/// <summary>
	//	/// The container with tags used to create this instance.
	//	/// </summary>
	//	/// TODO; This might be made private.
	//	public Data Tags { get; private set; }

	//	/// <summary>Gets or sets the value of a specific GameTag.</summary>
	//	/// <value></value>
	//	/// <param name="t">The GameTag.</param>
	//	/// <returns></returns>
	//	public int this[GameTag t]
	//	{
	//		get
	//		{
	//			if (Tags.TryGetValue(t, out int value))
	//				return value;

	//			Card.Tags.TryGetValue(t, out value);
	//			return value;
	//		}
	//		set => Tags[t] = value;
	//	}

	//	public IEnumerator<KeyValuePair<GameTag, int>> GetEnumerator()
	//	{
	//		// Entity ID
	//		var allTags = new Dictionary<GameTag, int>(Card.Tags);

	//		// Entity tags override card tags
	//		foreach (KeyValuePair<GameTag, int> tag in Tags)
	//		{
	//			allTags[tag.Key] = tag.Value;
	//		}

	//		return allTags.GetEnumerator();
	//	}

	//	IEnumerator IEnumerable.GetEnumerator()
	//	{
	//		return GetEnumerator();
	//	}

	//	public override string ToString()
	//	{
	//		string s = Tags.Aggregate(Card.Name + " - ", (current, tag) => current + new Tag(tag.Key, tag.Value) + ", ");
	//		return s.Substring(0, s.Length - 2);
	//	}

	//	/// <summary>Resets all tags from the container.</summary>
	//	public void Reset(Dictionary<GameTag, int> tags = null)
	//	{
	//		//Tags = tags ?? new Dictionary<GameTag, int>(Enum.GetNames(typeof(GameTag)).Length);
	//		//Tags.Remove(GameTag.DAMAGE);
	//		Tags.Remove(GameTag.PREDAMAGE);
	//		Tags.Remove(GameTag.ZONE_POSITION);
	//		Tags.Remove(GameTag.EXHAUSTED);
	//		//Tags.Remove(GameTag.JUST_PLAYED);
	//		//Tags.Remove(GameTag.SUMMONED);
	//		//Tags.Remove(GameTag.ATTACKING);
	//		//Tags.Remove(GameTag.DEFENDING);
	//		//Tags.Remove(GameTag.ATK);
	//		//Tags.Remove(GameTag.HEALTH);
	//		Tags.Remove(GameTag.COST);
	//		Tags.Remove(GameTag.TAUNT);
	//		Tags.Remove(GameTag.FROZEN);
	//		Tags.Remove(GameTag.ENRAGED);
	//		Tags.Remove(GameTag.CHARGE);
	//		Tags.Remove(GameTag.WINDFURY);
	//		Tags.Remove(GameTag.DIVINE_SHIELD);
	//		Tags.Remove(GameTag.STEALTH);
	//		Tags.Remove(GameTag.DEATHRATTLE);
	//		Tags.Remove(GameTag.BATTLECRY);
	//		Tags.Remove(GameTag.SILENCED);
	//		Tags.Remove(GameTag.NUM_ATTACKS_THIS_TURN);
	//		Tags.Remove(GameTag.NUM_TURNS_IN_PLAY);
	//		Tags.Remove(GameTag.ATTACKABLE_BY_RUSH);
	//		Tags.Remove(GameTag.GHOSTLY);
	//	}
	//}

	internal class EntityData : IDictionary<GameTag, int>
	{
		private const int _initSize = 16;

		private int[] _buckets;
		private int _size = _initSize;
		private int _count;

		public EntityData()
		{
			var buckets = new int[_initSize << 1];
			for (int i = 0; i < buckets.Length; i++)
				buckets[i] = -1;
			_buckets = buckets;
		}

		public EntityData(int capacity)
		{
			Initialise(capacity);
		}

		public unsafe EntityData(in EntityData entityData)
		{
			int len = entityData._buckets.Length;
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
		public bool IsReadOnly { get; }

		public int this[GameTag key]
		{
			get
			{
				if (Search((int)key, out int i))
					return _buckets[i + 1];
				throw new KeyNotFoundException();
			}
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
			_buckets[index] = -1;
			--_count;
			return true;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void Initialise(int capacity)
		{
			int n = 3;
			while (true)
			{
				int pow = 2 << n;
				if (pow >= capacity)
				{
					capacity = pow;
					break;
				}

				++n;
			}

			int[] buckets = new int[capacity << 1];
			for (int i = 0; i < buckets.Length; i++)
				buckets[i] = -1;
			_buckets = buckets;
			_size = capacity;
		}

		// TODO: check duplicate
		private void Insert(GameTag t, int value)
		{
			int k = (int)t;
			int h = (k & (_size - 1)) << 1;
			int[] buckets = _buckets;
			//Span<int> buckets = _buckets;
			for (int i = h; i < buckets.Length; i += 2)
			{
				if (buckets[i] > 0) continue;
				buckets[i] = k;
				buckets[i + 1] = value;
				++_count;
				return;
			}

			for (int i = 0; i < h; i += 2)
			{
				if (buckets[i] > 0) continue;
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
			int i = h;
			int[] buckets = _buckets;
			//ReadOnlySpan<int> buckets = _buckets;
			if (buckets[i] == k)
			{
				index = i;
				return true;
			}

			if (buckets[i] < 0)
			{
				index = i;
				return false;
			}
			i += 2;
			if (i < buckets.Length)
			{
				if (buckets[i] == k)
				{
					index = i;
					return true;
				}

				if (buckets[i] < 0)
				{
					index = i;
					return false;
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
			for (int i = 0; i < newbuckets.Length; ++i)
				newbuckets[i] = -1;

			int[] buckets = _buckets;
			//ReadOnlySpan<int> buckets = _buckets;
			for (int i = 0; i < buckets.Length; i += 2)
			{
				bool flag = false;

				int newIndex = (buckets[i] % newSize) << 1;

				for (int j = newIndex; j < newbuckets.Length; j += 2)
				{
					if (newbuckets[j] >= 0) continue;
					newbuckets[j] = buckets[i];
					newbuckets[j + 1] = buckets[i + 1];
					flag = true;
					break;
				}

				if (flag)
					continue;

				for (int j = 0; j < newIndex; j += 2)
				{
					if (newbuckets[j] >= 0) continue;
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
					if (buckets[i] < 0) continue;
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
					if (buckets[i] < 0) continue;
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
		public void Reset(/*Dictionary<GameTag, int> tags = null*/)
		{
			//Tags = tags ?? new Dictionary<GameTag, int>(Enum.GetNames(typeof(GameTag)).Length);
			//Remove(GameTag.DAMAGE);
			Remove(GameTag.PREDAMAGE);
			Remove(GameTag.ZONE_POSITION);
			Remove(GameTag.EXHAUSTED);
			//Remove(GameTag.JUST_PLAYED);
			//Remove(GameTag.SUMMONED);
			//Remove(GameTag.ATTACKING);
			//Remove(GameTag.DEFENDING);
			//Remove(GameTag.ATK);
			//Remove(GameTag.HEALTH);
			Remove(GameTag.COST);
			Remove(GameTag.TAUNT);
			Remove(GameTag.FROZEN);
			Remove(GameTag.ENRAGED);
			Remove(GameTag.CHARGE);
			Remove(GameTag.WINDFURY);
			Remove(GameTag.DIVINE_SHIELD);
			Remove(GameTag.STEALTH);
			Remove(GameTag.DEATHRATTLE);
			Remove(GameTag.BATTLECRY);
			Remove(GameTag.SILENCED);
			Remove(GameTag.NUM_ATTACKS_THIS_TURN);
			Remove(GameTag.NUM_TURNS_IN_PLAY);
			Remove(GameTag.ATTACKABLE_BY_RUSH);
			Remove(GameTag.GHOSTLY);
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


