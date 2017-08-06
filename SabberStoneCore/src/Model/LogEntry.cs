using System;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{

	/// <summary>
	/// Class holding information about a specific event that has been logged.
	/// All <see cref="LogEntry"/> objects are kept by <see cref="Game"/>.
	/// </summary>
	public sealed class LogEntry
    {
		/// <summary>Gets the time stamp, in UTC format.</summary>
		/// <value><see cref="DateTime"/></value>
		public DateTime TimeStamp { get; } = DateTime.UtcNow;

		/// <summary>Gets or sets the severity level.</summary>
		/// <value><see cref="ELogLevel"/></value>
		public ELogLevel Level { get; set; } = ELogLevel.INFO;

		/// <summary>Gets or sets the type of the block.</summary>
		/// <value><see cref="EBlockType"/></value>
		public EBlockType BlockType { get; set; } = EBlockType.INVALID;

		/// <summary>Gets or sets a rough indication of where the issue occurred,
		/// can be a file name or class name.</summary>
		/// <value>The location string.</value>
		public string Location { get; set; }

		/// <summary>Gets or sets the log message.</summary>
		/// <value>The log message string.</value>
		public string Text { get; set; }

    }
}
