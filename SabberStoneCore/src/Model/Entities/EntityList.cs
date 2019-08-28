using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// A collection of <see cref="IPlayable"/>/<see cref="int"/> id pairs of a <see cref="Game"/> instance.
	/// Implements <see cref="IDictionary"/>.
	/// </summary>
	[DebuggerDisplay("Count = {_count}")]
	public class EntityList : IDictionary<int, IPlayable>
	{
		private IPlayable[] _list;
		private int _count;

		public IPlayable this[int id]
		{
			get
			{
				if (id >= _list.Length)
					throw new ArgumentOutOfRangeException();
				IPlayable value = _list[id];
				if (value == null)
					throw new KeyNotFoundException();

				return value;
			}
			set
			{
				IPlayable[] list = _list;
				if (id >= list.Length)
				{
					int newLength = list.Length << 1;
					while (id >= newLength)
						newLength <<= 1;

					var newList = new IPlayable[(int)newLength];
					Array.Copy(list, newList, list.Length);
					list = newList;
					_list = newList;
				}

				if (list[id] == null)
					_count++;

				list[id] = value;
			}
		}

		internal EntityList(int length)
		{
			_list = new IPlayable[length];
		}

		public void Add(int key, IPlayable value)
		{
			IPlayable[] list = _list;
			if (list.Length <= key)
			{
				var newlist = new IPlayable[list.Length << 1];
				Array.Copy(list, newlist, list.Length);
				list = newlist;
				_list = newlist;
			}

			if (list[key] != null)
				throw new ArgumentException();
			list[key] = value;
			_count++;
		}

		public ReadOnlySpan<IPlayable> GetSpan()
		{
			return new ReadOnlySpan<IPlayable>(_list, 0, Count + 4);
		}

		#region IDictionary
		public bool ContainsKey(int key)
		{
			return _list.Length > key && _list[key] != null;
		}

		public bool Remove(int key)
		{
			if (_list[key] == null) return false;
			_list[key] = null;
			return true;
		}

		public bool TryGetValue(int key, out IPlayable value)
		{
			value = _list[key];
			return value != null;
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ICollection<int> Keys { get; }

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public ICollection<IPlayable> Values
		{
			get
			{
				var values = new IPlayable[_count];
				int i = 0;
				foreach (IPlayable item in _list)
				{
					if (item == null) continue;

					values[i++] = item;
				}
				return values;
			}
		}

		public IEnumerator<KeyValuePair<int, IPlayable>> GetEnumerator()
		{
			var list = _list;
			for (int i = 0; i < list.Length; i++)
				if (list[i] != null)
					yield return new KeyValuePair<int, IPlayable>(i, list[i]);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(KeyValuePair<int, IPlayable> item)
		{
			Add(item.Key, item.Value);
		}

		public void Clear()
		{
			var list = _list;
			for (int i = 0; i < list.Length; i++)
				list[i] = null;
		}

		public bool Contains(KeyValuePair<int, IPlayable> item)
		{
			return _list[item.Key] != null;
		}

		public void CopyTo(KeyValuePair<int, IPlayable>[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		public bool Remove(KeyValuePair<int, IPlayable> item)
		{
			if (_list[item.Key] == null)
				return false;
			_list[item.Key] = null;
			return true;
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count => _count;
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool IsReadOnly => false;
		#endregion
	}
}
