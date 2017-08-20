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
				Console.WriteLine($"Tag created on entity {Id}: {tag} = {value}");
			}
			else
			{
				Console.WriteLine($"Tag changed on entity {Id}: {tag} ({Data[tag]} -> {value})");
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
			get => GetValue("ENTITY_ID");
			set => Add("ENTITY_ID", value);
		}

		public override string ToString()
		{
			var str = new StringBuilder();
			str.AppendLine("[" + Id + "]");
			Data.ToList().ForEach(p =>
			{
				str.AppendLine(" - " + p.Key + " -> " + p.Value);
			});
			return str.ToString();
		}

	}
}
