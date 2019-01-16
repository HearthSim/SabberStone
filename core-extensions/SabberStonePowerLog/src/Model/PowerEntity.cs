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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SabberStonePowerLog.Model
{
	public class PowerEntity
	{
		public Dictionary<string, string> Data;

		public PowerEntity()
		{
			Data = new Dictionary<string, string>();
		}

		internal void Add(string tag, string value)
		{
			if (!Data.ContainsKey(tag))
			{
				Data.Add(tag, value);
			}
			else if (Data[tag] == value)
			{
				//Console.WriteLine("Unchanged add tag submited: tag[" + tag + "] value[" + value + "]");
			}
			else
			{
				Console.WriteLine("Changed add tag submited: tag[" + tag + "] oldvalue[" + Data[tag] + "] newvalue[" + value + "]");
			}
		}

		internal void Change(string tag, string value)
		{
			Data[tag] = value;
		}

		internal string GetValue(string v)
		{
			string result = null;
			Data.TryGetValue(v, out result);
			return result;
		}

		public string Id
		{
			get { return GetValue("ENTITY_ID"); }
			set { Add("ENTITY_ID", value); }
		}

		public override string ToString()
		{
			var str = new StringBuilder();
			str.Append($"{GetType().Name}:");
			str.AppendLine("[" + Id + "]");
			Data.ToList().ForEach(p =>
			{
				str.AppendLine(" - " + p.Key + " -> " + p.Value);
			});
			return str.ToString();
		}

	}
}
