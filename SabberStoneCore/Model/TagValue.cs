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