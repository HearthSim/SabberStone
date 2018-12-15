#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
namespace SabberStoneCore.Model
{
	public struct TagValue
	{
		private int _intValue;

		private bool _boolValue;

		private string _stringValue;

		public bool HasValue { get; private set; }

		public bool HasIntValue { get; private set; }

		public bool HasBoolValue { get; private set; }

		public bool HasStringValue { get; private set; }

		public static implicit operator TagValue(int x)
		{
			return new TagValue { HasValue = true, HasIntValue = true, _intValue = x };
		}

		public static implicit operator TagValue(bool x)
		{
			return new TagValue { HasValue = true, HasBoolValue = true, _boolValue = x };
		}

		public static implicit operator TagValue(string x)
		{
			return new TagValue { HasValue = true, HasStringValue = true, _stringValue = x };
		}

		public static implicit operator int(TagValue a)
		{
			return a._intValue;
		}

		public static implicit operator bool(TagValue a)
		{
			return a._boolValue;
		}

		public static implicit operator string(TagValue a)
		{
			return a._stringValue;
		}

		public override string ToString()
		{
			return !HasValue ? "null"
				 : (HasBoolValue ? _boolValue.ToString()
				 : (HasIntValue ? _intValue.ToString()
				 : (HasStringValue ? _stringValue
				 : "unknown")));
		}
	}
}