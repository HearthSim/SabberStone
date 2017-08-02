using SabberStoneCore.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCore.Collections
{
	/// <summary>
	/// Collection which returns items in the sequence they got stored.
	/// This collection DOES NOT allow duplicate elements!
	/// This collection does NOT provide internal concurrency consistency!
	/// </summary>
	/// <typeparam name="T"></typeparam>
	internal class OrderedHashSet<T> : IOrderedSet<T>, IReadOnlyOrderedSet<T>
	{
		/// <summary>Indicates the amount of elements which have to be inserted before lookups 
		/// are done through a dictionary instead of the backed list.
		/// </summary>
		internal const int DICTIONARY_CREATION_THRESHOLD = 50;

		/// <summary>The comparer function for T objects.</summary>
		private IEqualityComparer<T> _comparer;

		/// <summary>Gets the default comparer function for T objects.</summary>
		/// <returns></returns>
		private static IEqualityComparer<T> GetDefaultComparer()
		{
			return EqualityComparer<T>.Default;
		}

		/// <summary>The internal list, used for keep track of insertion order.</summary>
		private readonly List<T> _internalList;
		/// <summary>The internal lookup table, used for lookups when the amount of items is large.</summary>
		private HashSet<T> _internalLookup;
		/// <summary>If True, the ICollection methods will throw an exception when the unique object constraint is
		/// violated.</summary>
		private readonly bool _throwOnViolation;

		/// <summary>Initializes a new instance of the <see cref="OrderedHashSet{T}"/> class.</summary>
		/// <param name="sequence">The sequence.</param>
		/// <param name="throwOnConstraintViolation">True; this object will throw an exception when a constraint is violated. When False; items are simple not added.</param>
		/// <param name="comparer">The comparer.</param>
		public OrderedHashSet(IEnumerable<T> sequence = null, bool throwOnConstraintViolation = true, IEqualityComparer<T> comparer = null)
		{
			_internalList = new List<T>(DICTIONARY_CREATION_THRESHOLD);
			_internalLookup = null;
			_throwOnViolation = throwOnConstraintViolation;
			_comparer = comparer ?? GetDefaultComparer();

			if (sequence != null) _internalList.AddRange(sequence);
		}

		/// <summary>
		/// Updates the lookup table with the provided argument.
		/// PRECONDITION: The lookup table DOES NOT yet know about the provided item.
		/// </summary>
		/// <param name="item">The item which is UNKNOWN to the lookup table!</param>
		private void AppendToLookupTable(T item)
		{
			if (_internalLookup == null)
			{
				if (_internalList.Count < DICTIONARY_CREATION_THRESHOLD)
				{
					return;
				}

				// Build the lookup table.
				_internalLookup = new HashSet<T>(_internalList, _comparer)
				{
					// The given item might/might not be added to _internalList already.
					item
				};
				return;
			}
			else
			{
				// Update lookuptable with new item.
				_internalLookup.Add(item);
			}
		}

		/// <summary>Removes the provided item from the lookup table.</summary>
		/// <param name="item">The item.</param>
		private void RemoveFromLookupTable(T item)
		{
			if (_internalLookup == null)
			{
				return;
			}
			else
			{
				_internalLookup.Remove(item);
			}
		}

		/// <summary>Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1" />.
		/// This method was added to provided the initializer list functionality on this object.
		/// </summary>
		/// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
		public void Add(T item)
		{
			((ICollection<T>)this).Add(item);
		}

		T IList<T>.this[int index] { get => _internalList[index]; set => ((IList<T>)this).Insert(index, value); }

		int ICollection<T>.Count => _internalList.Count;

		bool ICollection<T>.IsReadOnly => false;

		int IReadOnlyCollection<T>.Count => _internalList.Count;

		T IReadOnlyList<T>.this[int index] => _internalList[index];

		bool ISet<T>.Add(T item)
		{
			if (((ICollection<T>)this).Contains(item))
			{
				return false;
			}
			else
			{
				_internalList.Add(item);
				AppendToLookupTable(item);
				return true;
			}
		}

		void ICollection<T>.Add(T item)
		{
			if (!((ISet<T>)this).Add(item) && _throwOnViolation)
			{
				throw new ConstraintViolationException("Duplicate item detected!");
			}
		}

		void ICollection<T>.Clear()
		{
			_internalList.Clear();
			_internalLookup.Clear();
			_internalLookup = null;
		}

		bool ICollection<T>.Contains(T item)
		{
			if (item == null) throw new ArgumentNullException("item is null!");

			if (_internalLookup == null)
			{
				// Iterate the internal list to find the item.
				return _internalList.Exists(x => _comparer.Equals(x, item));
			}
			else
			{
				// Use the lookuptable to find the item.
				return _internalLookup.Contains(item);
			}
		}

		void ICollection<T>.CopyTo(T[] array, int arrayIndex)
		{
			_internalList.CopyTo(array, arrayIndex);
		}

		void ISet<T>.ExceptWith(IEnumerable<T> other)
		{
			foreach (T item in other)
			{
				((ICollection<T>)this).Remove(item);
			}
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return _internalList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		int IList<T>.IndexOf(T item)
		{
			return _internalList.IndexOf(item);
		}

		void IList<T>.Insert(int index, T item)
		{
			if (((ICollection<T>)this).Contains(item))
			{
				if (_throwOnViolation)
				{
					throw new ConstraintViolationException("Duplicate item detected!");
				}
			}
			else
			{
				_internalList.Insert(index, item);
				AppendToLookupTable(item);
			}
		}

		void ISet<T>.IntersectWith(IEnumerable<T> other)
		{
			foreach (T item in other)
			{
				((ICollection<T>)this).Remove(item);
			}
		}

		#region NOT_IMPLEMENTED

		bool ISet<T>.IsProperSubsetOf(IEnumerable<T> other)
		{
			throw new NotImplementedException();
		}

		bool ISet<T>.IsProperSupersetOf(IEnumerable<T> other)
		{
			throw new NotImplementedException();
		}

		bool ISet<T>.IsSubsetOf(IEnumerable<T> other)
		{
			throw new NotImplementedException();
		}

		bool ISet<T>.IsSupersetOf(IEnumerable<T> other)
		{
			throw new NotImplementedException();
		}

		bool ISet<T>.Overlaps(IEnumerable<T> other)
		{
			throw new NotImplementedException();
		}

		void ISet<T>.SymmetricExceptWith(IEnumerable<T> other)
		{
			throw new NotImplementedException();
		}

		#endregion

		bool ICollection<T>.Remove(T item)
		{
			if (((ICollection<T>)this).Contains(item))
			{
				_internalList.Remove(item);
				RemoveFromLookupTable(item);
				return true;
			}

			return false;
		}

		void IList<T>.RemoveAt(int index)
		{
			if (_internalList.Count == 0 || index < 0 || index > _internalList.Count)
			{
				throw new ArgumentOutOfRangeException("index is not a valid index in the IList`1!");
			}

			T item = _internalList[index];
			_internalList.RemoveAt(index);
			RemoveFromLookupTable(item);
		}

		bool ISet<T>.SetEquals(IEnumerable<T> other)
		{
			if (other == null) throw new ArgumentNullException("other is null!");

			int elementCount = 0;
			foreach (T item in other)
			{
				if (((ICollection<T>)this).Contains(item))
				{
					elementCount++;
				}
				else
				{
					return false;
				}
			}

			return elementCount == _internalList.Count;
		}

		void ISet<T>.UnionWith(IEnumerable<T> other)
		{
			if (other == null) throw new ArgumentNullException("other is null!");

			foreach (T item in other)
			{
				((ISet<T>)this).Add(item);
			}
		}

		bool IReadOnlySet<T>.Contains(T item)
		{
			return ((ICollection<T>)this).Contains(item);
		}

		IReadOnlyOrderedSet<T> IOrderedSet<T>.AsReadOnly()
		{
			return LightWeightOrderedSet<T>.Build(_internalList, _comparer);
		}

		void IOrderedSet<T>.ForEach(Action<T> lambda)
		{
			((IReadOnlyOrderedSet<T>)this).ForEach(lambda);
		}

		void IReadOnlySet<T>.ForEach(Action<T> lambda)
		{
			// List is made to prevent out of bounds by concurrent access.
			var internalCopy = new List<T>(_internalList);
			for (int i = 0; i < internalCopy.Count; ++i)
			{
				lambda(internalCopy[i]);
			}
		}

		bool IOrderedSet<T>.Exists(Func<T, bool> lambda)
		{
			return ((IReadOnlyOrderedSet<T>)this).Exists(lambda);
		}

		bool IReadOnlySet<T>.Exists(Func<T, bool> lambda)
		{
			// List is made to prevent out of bounds by concurrent access.
			var internalCopy = new List<T>(_internalList);
			for (int i = 0; i < internalCopy.Count; ++i)
			{
				if (lambda(internalCopy[i]))
				{
					return true;
				}
			}

			return false;
		}

		IOrderedEnumerable<T> IOrderedEnumerable<T>.CreateOrderedEnumerable<TKey>(Func<T, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			if (descending)
			{
				return _internalList.OrderByDescending(keySelector, comparer);
			}
			else
			{
				return _internalList.OrderBy(keySelector, comparer);
			}
		}

		
	}
}
