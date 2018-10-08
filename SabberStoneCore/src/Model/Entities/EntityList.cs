using System;
using System.Collections;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Entities
{
	public class EntityList : IDictionary<int, IPlayable>
	{
		private IPlayable[] _list;
		private int _count;

		public void Add(int key, IPlayable value)
		{
			IPlayable[] list = _list;
			if (list.Length <= key)
			{
				var newlist = new IPlayable[list.Length * 2];
				Array.Copy(list, newlist, list.Length);
				list = newlist;
				_list = newlist;
			}

			if (list.Length <= key) ;
			if (list[key] != null)
				throw new ArgumentException();
			list[key] = value;
			_count++;
		}

		public bool ContainsKey(int key)
		{
			return _list[key] != null;
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
				if (id >= _list.Length)
				{
					var newlist = new IPlayable[list.Length * 2];
					Array.Copy(list, newlist, list.Length);
					list = newlist;
					_list = newlist;
				}

				if (list[id] == null)
					_count++;

				list[id] = value;
			}
		}

		public ICollection<int> Keys { get; }
		public ICollection<IPlayable> Values { get; }

		internal EntityList(int length)
		{
			_list = new IPlayable[length];
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

		public int Count => _count;
		public bool IsReadOnly => false;
	}
}
