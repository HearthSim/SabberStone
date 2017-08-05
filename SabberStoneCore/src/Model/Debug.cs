using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using System;
using System.Diagnostics;
using System.Reflection;

namespace SabberStoneCore.Model
{
	internal static class Debugging
	{
		/// <summary>
		/// Report a problem in the code regarding not implemented functionality.
		/// The reported message is built with provided arguments. Parameter value is allowed
		/// to be null, but must be of type Enum otherwise!
		/// </summary>
		/// <typeparam name="T">The type which called this method.</typeparam>
		/// <typeparam name="E">The enum for which certain functionality is not yet implemented</typeparam>
		/// <param name="caller">The object which called this method.</param>
		/// <param name="blockType">The power block where this issue appeared.</param>
		/// <param name="value">The enumeration value which caused the situation, null is allowed.</param>
		/// <param name="level">The severity of this situation. If left at default value, this will throw a debugger exception
		/// when compiled in DEBUG-mode.</param>
		public static void ReportNotImplemented<T, E>(T caller, EBlockType blockType, E value, ELogLevel level = ELogLevel.ERROR) where T : IEntity
		{
			if (value != null && !typeof(E).GetTypeInfo().IsEnum)
			{
				throw new NotSupportedException("Generic argument for E must be an enum!");
			}

			// Build custom message base on provided value.
			string msg = value != null ? $"Functionality for {value.ToString()} not yet implemented!" : "Functionality not yet implemented!";
			// Log the entirety.
			caller.Game.Log(level, blockType, typeof(T).Name, msg);
			if (level == ELogLevel.ERROR)
			{
				// Fail (only) in debug mode if level is severe.
				Debug.Fail(msg);
			}
		}
	}
}
