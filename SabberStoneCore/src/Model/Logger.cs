#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
using System;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
	public enum LogLevel
	{
		DUMP, ERROR, WARNING, INFO, VERBOSE, DEBUG
	}

	public class LogEntry
	{
		public DateTime TimeStamp { get; set; }
		public LogLevel Level { get; set; }
		public BlockType BlockType { get; set; }
		public string Location { get; set; }
		public string Text { get; set; }

	}
}
