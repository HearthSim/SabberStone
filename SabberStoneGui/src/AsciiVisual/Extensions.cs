using SabberStoneCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabberStoneGui.AsciiVisual
{
	internal static class Extensions
	{
		/// <summary>
		/// Returns a substring of the name of this instance.
		/// </summary>
		/// <param name="size">The maximum length of the substring in # characters.</param>
		/// <returns></returns>
		public static string AbbreviatedName(this Card card, int size)
		{
			if (card.Name.Length <= size)
			{
				return card.Name;
			}
			else if (!card.Name.Contains(" "))
			{
				return card.Name.Substring(0, size);
			}
			else
			{
				string[] strArray = card.Name.Split(' ');
				return String.Join("", strArray.Select(p => p.Length > 4 ? p.Substring(0, 4) : p).ToList()).Substring(0, 7);
			}

		}

		/// <summary>
		/// Returns a string containing all information about this instance.
		/// </summary>
		/// <param name="gameTag"></param>
		/// <param name="playReq"></param>
		/// <returns></returns>
		public static string FullPrint(this Card card, bool gameTag = false, bool playReq = false)
		{
			var builder = new StringBuilder();
			builder.Append($"[CARD: {card.Name} - {card.Id} (Col={card.Collectible},Set={card.Set})]");
			if (gameTag)
			{
				builder.Append("\n   GameTags:");
				card.Tags.ToList().ForEach(pair => builder.Append($"\n   - {pair.Key} -> {pair.Value}"));
			}
			if (playReq)
			{
				builder.Append("\n   PlayReq:");
				card.PlayRequirements.ToList().ForEach(pair => builder.Append($"\n   - {pair.Key} -> {pair.Value}"));
			}
			return builder.ToString();
		}

	}
}
