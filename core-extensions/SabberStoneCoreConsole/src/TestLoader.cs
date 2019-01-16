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

namespace SabberStoneCoreConsole
{

	//public class TestLoader
	//{
	//	public static void GetGameTags()
	//	{
	//		var gameTags = new Dictionary<int, string>();
	//		var cardDefsXml = XDocument.Load(@"C:\Users\admin\Source\Repos\SabberStone\SabberStoneCore\resources\Data\CardDefs.xml");
	//		cardDefsXml.Descendants("Entity").ToList().ForEach(p1 => p1.Descendants().Where(t => t.Attribute("enumID") != null).ToList().ForEach(
	//			p2 =>
	//			{
	//				int enumId = int.Parse(p2.Attribute("enumID").Value);
	//				XAttribute name = p2.Attribute("name");
	//				if (!gameTags.ContainsKey(enumId) && name != null)
	//				{
	//					gameTags.Add(enumId, name.Value);
	//				}
	//			}));

	//		gameTags.OrderBy(p => p.Key).ToList().ForEach(p => Console.WriteLine($"{p.Key} => {p.Value}"));
	//	}


	//	public static List<Card> Load()
	//	{
	//		// Get XML definitions from assembly embedded resource
	//		var cardDefsXml = XDocument.Load(@"C:\Users\admin\Source\Repos\SabberStone\SabberStoneCore\resources\Data\CardDefs.xml");
	//		// Parse XML
	//		var cardDefs = (from r in cardDefsXml.Descendants("Entity")
	//						select new
	//						{
	//							Id = r.Attribute("CardID").Value,
	//							AssetId = r.Attribute("ID").Value,

	//							// Unfortunately the file contains some duplicate tags
	//							// so we have to make a list first and weed out the unique ones
	//							Tags = (from tag in r.Descendants("Tag")
	//									select new Tag(
	//										gameTag: (GameTag)Enum.Parse(typeof(GameTag), tag.Attribute("enumID").Value),
	//										tagValue:
	//										tag.Attribute("value") != null
	//											? (TagValue)Int32.Parse(tag.Attribute("value").Value)
	//											: (tag.Attribute("type").Value == "String"
	//												? (TagValue)tag.Value
	//												: (tag.Attribute("type").Value == "LocString"
	//													? (TagValue)tag.Element("enUS").Value
	//													: (TagValue)0
	//												)))).ToList(),
	//							Requirements = (from req in r.Descendants("PlayRequirement")
	//											select new
	//											{
	//												Req = (PlayReq)Enum.Parse(typeof(PlayReq), req.Attribute("reqID").Value),
	//												Param = (req.Attribute("param").Value != "" ? Int32.Parse(req.Attribute("param").Value) : 0)
	//											})
	//											.Distinct() // avoiding duplicate playrequirment unsure iff it is intended or not ...
	//											.ToDictionary(x => x.Req, x => x.Param),
	//							Entourage = (from ent in r.Descendants("EntourageCard")
	//										 select ent.Attribute("cardID").Value).ToArray(),
	//							ReferenzTag = (from rtag in r.Descendants("ReferencedTag")
	//										   select new Tag(
	//											   gameTag: (GameTag)Enum.Parse(typeof(GameTag), rtag.Attribute("enumID").Value),
	//											   tagValue:
	//											   rtag.Attribute("value") != null
	//												   ? (TagValue)Int32.Parse(rtag.Attribute("value").Value)
	//												   : (rtag.Attribute("type").Value == "String"
	//													   ? (TagValue)rtag.Value
	//													   : (rtag.Attribute("type").Value == "LocString"
	//														   ? (TagValue)rtag.Element("enUS").Value
	//														   : (TagValue)0
	//													   )))).ToList()
	//						}).ToList();

	//		// Build card database
	//		var cards = new List<Card>();

	//		foreach (var card in cardDefs)
	//		{
	//			// Skip PlaceholderCard etc.
	//			//if (!dbfCards.ContainsKey(card.Id))
	//			//    continue;

	//			var c = new Card()
	//			{
	//				Id = card.Id,
	//				AssetId = int.Parse(card.AssetId),
	//				Tags = new Dictionary<GameTag, int>(),
	//				PlayRequirements = card.Requirements,
	//				Entourage = card.Entourage,
	//				RefTags = new Dictionary<GameTag, int>(),
	//			};

	//			// Get unique int and bool tags, ignore duplicate and string tags
	//			foreach (Tag tag in card.Tags)
	//			{
	//				if (c.Tags.ContainsKey(tag.GameTag))
	//					continue;

	//				if (tag.TagValue.HasIntValue)
	//				{
	//					c.Tags.Add(tag.GameTag, tag.TagValue);
	//				}
	//				else if (tag.TagValue.HasBoolValue)
	//				{
	//					c.Tags.Add(tag.GameTag, tag.TagValue ? 1 : 0);
	//				}
	//				else if (tag.TagValue.HasStringValue)
	//				{
	//					switch (tag.GameTag)
	//					{
	//						case GameTag.CARDNAME:
	//							c.Name = tag.TagValue;
	//							break;
	//						case GameTag.CARDTEXT:
	//							c.Text = tag.TagValue;
	//							break;
	//					}
	//				}
	//			}

	//			foreach (Tag tag in card.ReferenzTag)
	//			{
	//				if (c.RefTags.ContainsKey(tag.GameTag))
	//					continue;

	//				if (tag.TagValue.HasIntValue)
	//				{
	//					c.RefTags.Add(tag.GameTag, tag.TagValue);
	//				}
	//				else if (tag.TagValue.HasBoolValue)
	//				{
	//					c.RefTags.Add(tag.GameTag, tag.TagValue ? 1 : 0);
	//				}
	//				else if (tag.TagValue.HasStringValue)
	//				{
	//					switch (tag.GameTag)
	//					{
	//						case GameTag.CARDNAME:
	//							c.Name = tag.TagValue;
	//							break;
	//						case GameTag.CARDTEXT:
	//							c.Text = tag.TagValue;
	//							break;
	//					}
	//				}
	//			}

	//			// spell damage information add ... 
	//			if (c.Text != null && (c.Text.Contains("$") || c[GameTag.AFFECTED_BY_SPELL_POWER] == 1))
	//			{
	//				c.Text += " *spelldmg";
	//				c.IsAffectedBySpellDamage = true;
	//			}
	//			cards.Add(c);
	//		}

	//		return cards;
	//	}
	//}
}
