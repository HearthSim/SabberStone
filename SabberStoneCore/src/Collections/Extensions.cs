using System;
using System.Collections.Generic;

namespace SabberStoneCore.Collections
{
	internal static class Extensions
	{
		/// <summary>Builds a readonly collection of elements without duplicates from the provided data.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="data">The data.</param>
		/// <returns></returns>
		public static IReadOnlyCollection<T> ToSet<T>(this IEnumerable<T> data)
		{
			return new HashSet<T>(data);
		}

		/// <summary>Builds a readonly ordered collection of elements without duplicates from the provided data.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="data">The data.</param>
		/// <returns></returns>
		public static IReadOnlyOrderedSet<T> ToOrderedSet<T>(this IEnumerable<T> data)
		{
			return LightWeightOrderedSet<T>.Build(data);
		}

		/// <summary>Executes the lambda function for each element of the provided list.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="data">The list.</param>
		/// <param name="lambda">The lambda function.</param>
		public static void ForEach<T>(this IList<T> data, Action<T> lambda)
		{
			for(int i = 0; i < data.Count; ++i)
			{
				lambda(data[i]);
			}
		}
	}
}
