using SabberStoneCore.Enums;
using System;

namespace SabberStoneCore.Model
{
	/// <summary>
	/// Interface which enforces primitive behaviour on the implementing
	/// classes.
	/// </summary>
	public interface IModel<T> where T : class
	{
		/// <summary>
		/// Returns a deep copy of the implementing class object.
		/// </summary>
		/// <returns>A newly created object which is full duplicate of the 
		/// original.</returns>
		T Clone();

		/// <summary>
		/// Deep copies data from the other object into this one.
		/// </summary>
		/// <param name="other">The object holding data to copy from.</param>
		[Obsolete("Using Clone() is preferred!")]
		void Stamp(T other);

		/// <summary>
		/// Builds and returns a string containing information about the current object.
		/// It's purpose is to validate against other hashes to check state equality.
		/// </summary>
		/// <param name="ignore"><see cref="GameTag"/>s to ignore hashing into the result.</param>
		/// <returns>A state information encoded into a string.</returns>
		string ToHash(params GameTag[] ignore);
	}
}
