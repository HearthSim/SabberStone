/**
The MIT License(MIT)

Copyright(c) 2016 HearthSim

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

https://github.com/HearthSim/HearthDb
*/

using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SabberStoneCore.Config
{

	public class Deck
	{
		/// <summary>
		/// DbfId of the hero. Required.
		/// This can be a specific hero for a class, i.e. Medivh over Jaina.
		/// </summary>
		public int HeroDbfId { get; set; }

		/// <summary>
		/// Dictionary of (DbfId, Count) for each card.
		/// Needs to be a total of 30 cards to be accepted by Hearthstone.
		/// </summary>
		public Dictionary<int, int> CardDbfIds { get; set; } = new Dictionary<int, int>();

		/// <summary>
		/// Format of the deck. Required.
		/// </summary>
		public FormatType Format { get; set; }

		/// <summary>
		/// Year of the deck format. Optional.
		/// </summary>
		public ZodiacYear ZodiacYear { get; set; }

		/// <summary>
		/// Name of the deck. Optional.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Hearthstones internal ID of the deck. Optional.
		/// </summary>
		public long DeckId { get; set; }

		/// <summary>
		/// Gets the card object for the given HeroDbfId
		/// </summary>
		public Card GetHero() => Cards.FromAssetId(HeroDbfId);

		/// <summary>
		/// Converts (DbfId, Count) dictionary to (CardObject, Count).
		/// </summary>
		public Dictionary<Card, int> GetCards() => CardDbfIds
			.Select(x => new { Card = Cards.FromAssetId(x.Key), Count = x.Value })
			.Where(x => x.Card != null).ToDictionary(x => x.Card, x => x.Count);
	}

	public class DeckSerializer
	{
		/// <summary>
		/// Serializes given deck to Hearthstone importable deck string.
		/// </summary>
		/// <param name="deck">Deck to be serialized</param>
		/// <param name="includeComments">Adds cards, etc, in human readable form</param>
		/// <exception cref="InvalidDeckException"></exception>
		/// <returns>Deck serialized as a Hearthstone deckstring</returns>
		public static string Serialize(Deck deck, bool includeComments)
		{
			string deckString = Serialize(deck);
			if (!includeComments)
				return deckString;

			string hero = TitleCase(deck.GetHero().Class.ToString());
			var sb = new StringBuilder();
			sb.AppendLine("### " + (String.IsNullOrEmpty(deck.Name) ? hero + " Deck" : deck.Name));
			sb.AppendLine("# Class: " + hero);
			sb.AppendLine("# Format: " + TitleCase(deck.Format.ToString().Substring(3)));
			if (deck.ZodiacYear > 0)
				sb.AppendLine("# Year of the " + TitleCase(deck.ZodiacYear.ToString()));
			sb.AppendLine("#");
			foreach (KeyValuePair<Card, int> card in deck.GetCards().OrderBy(x => x.Key.Cost).ThenBy(x => x.Key.Name))
				sb.AppendLine($"# {card.Value}x ({card.Key.Cost}) {card.Key.Name}");
			sb.AppendLine("#");
			sb.AppendLine(deckString);
			sb.AppendLine("#");
			sb.AppendLine("# To use this deck, copy it to your clipboard and create a new deck in Hearthstone");
			return sb.ToString();
		}

		private static string Serialize(Deck deck)
		{
			if (deck == null)
				throw new Exception("Deck can not be null");
			if (deck.HeroDbfId == 0)
				throw new Exception("HeroDbfId can not be zero");
			if (deck.GetHero()?.Type != CardType.HERO)
				throw new Exception("HeroDbfId does not represent a valid hero");
			if (deck.Format == FormatType.FT_UNKNOWN)
				throw new Exception("Format can not be FT_UNKNOWN");

			using (var ms = new MemoryStream())
			{
				void Write(int value)
				{
					if (value == 0)
						ms.WriteByte(0);
					else
					{
						byte[] bytes = VarInt.GetBytes((ulong)value);
						ms.Write(bytes, 0, bytes.Length);
					}
				}

				ms.WriteByte(0);
				Write(1);
				Write((int)deck.Format);
				Write(1);
				Write(deck.HeroDbfId);

				var cards = deck.CardDbfIds.OrderBy(x => x.Key).ToList();
				var singleCopy = cards.Where(x => x.Value == 1).ToList();
				var doubleCopy = cards.Where(x => x.Value == 2).ToList();
				var nCopy = cards.Where(x => x.Value > 2).ToList();

				Write(singleCopy.Count);
				foreach (KeyValuePair<int, int> card in singleCopy)
					Write(card.Key);

				Write(doubleCopy.Count);
				foreach (KeyValuePair<int, int> card in doubleCopy)
					Write(card.Key);

				Write(nCopy.Count);
				foreach (KeyValuePair<int, int> card in nCopy)
				{
					Write(card.Key);
					Write(card.Value);
				}

				return Convert.ToBase64String(ms.ToArray());
			}
		}

		/// <summary>
		/// Deserializes a given deckstring into a deck object
		/// </summary>
		/// <exception cref="ArgumentException"></exception>
		/// <param name="input">Deckstring to be deserialized</param>
		/// <returns>Deserialized deck object</returns>
		public static Deck Deserialize(string input)
		{
			Deck deck = null;
			IEnumerable<string> lines = input.Split('\n').Select(x => x.Trim());
			string deckName = null;
			string deckId = null;
			foreach (string line in lines)
			{
				if (String.IsNullOrEmpty(line))
					continue;
				if (line.StartsWith("#"))
				{
					if (line.StartsWith("###"))
						deckName = line.Substring(3).Trim();
					if (line.StartsWith("# Deck ID:"))
						deckId = line.Substring(10).Trim();
					continue;
				}
				if (deck == null)
					deck = DeserializeDeckString(line);
			}
			if (deck != null)
			{
				deck.Name = deckName;
				deck.DeckId = Int64.TryParse(deckId, out long id) ? id : 0;
			}
			return deck;
		}

		private static Deck DeserializeDeckString(string deckString)
		{
			var deck = new Deck();
			byte[] bytes;
			try
			{
				bytes = Convert.FromBase64String(deckString);
			}
			catch (Exception e)
			{
				throw new ArgumentException("Input is not a valid deck string.", e);
			}
			int offset = 0;
			ulong Read()
			{
				if (offset > bytes.Length)
					throw new ArgumentException("Input is not a valid deck string.");
				ulong value = VarInt.ReadNext(bytes.Skip(offset).ToArray(), out int length);
				offset += length;
				return value;
			}

			//Zero byte
			offset++;

			//Version - always 1
			Read();

			deck.Format = (FormatType)Read();

			//Num Heroes - always 1
			Read();

			deck.HeroDbfId = (int)Read();

			void AddCard(int? dbfId = null, int count = 1)
			{
				dbfId = dbfId ?? (int)Read();
				deck.CardDbfIds[dbfId.Value] = count;
			}

			int numSingleCards = (int)Read();
			for (int i = 0; i < numSingleCards; i++)
				AddCard();

			int numDoubleCards = (int)Read();
			for (int i = 0; i < numDoubleCards; i++)
				AddCard(count: 2);

			int numMultiCards = (int)Read();
			for (int i = 0; i < numMultiCards; i++)
			{
				int dbfId = (int)Read();
				int count = (int)Read();
				AddCard(dbfId, count);
			}
			return deck;
		}

		private static string TitleCase(string str)
		{
			if (String.IsNullOrEmpty(str))
				return String.Empty;
			if (str.Length == 1)
				return str.ToUpperInvariant();
			return str.Substring(0, 1).ToUpperInvariant() + str.Substring(1, str.Length - 1).ToLowerInvariant();
		}
	}

	internal static class VarInt
	{
		public static byte[] GetBytes(ulong value)
		{
			using (var ms = new MemoryStream())
			{
				while (value != 0)
				{
					ulong b = value & 0x7f;
					value >>= 7;
					if (value != 0)
						b |= 0x80;
					ms.WriteByte((byte)b);
				}
				return ms.ToArray();
			}
		}

		public static ulong ReadNext(byte[] bytes, out int length)
		{
			length = 0;
			ulong result = 0;
			foreach (byte b in bytes)
			{
				ulong value = (ulong)b & 0x7f;
				result |= value << length * 7;
				if ((b & 0x80) != 0x80)
					break;
				length++;
			}
			length++;
			return result;
		}

	}
}

