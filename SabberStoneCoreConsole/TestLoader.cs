using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Loader;
using SabberStoneCore.Model;

namespace SabberStoneCoreConsole
{

    public class TestLoader
    {
        public static void GetGameTags()
        {
            var gameTags = new Dictionary<int, string>();
            var cardDefsXml = XDocument.Load(@"C:\Users\admin\Source\Repos\SabberStone\SabberStoneCore\Loader\Data\CardDefs.xml");
            cardDefsXml.Descendants("Entity").ToList().ForEach(p1 => p1.Descendants().Where(t => t.Attribute("enumID") != null).ToList().ForEach(
                p2 =>
                {
                    var enumId = int.Parse(p2.Attribute("enumID").Value);
                    var name = p2.Attribute("name");
                    if (!gameTags.ContainsKey(enumId) && name != null)
                    {
                        gameTags.Add(enumId, name.Value);
                    }
                }));

            gameTags.OrderBy(p => p.Key).ToList().ForEach( p => Console.WriteLine($"{p.Key} => {p.Value}"));
        }


        public static List<Card> Load()
        {
            // Get XML definitions from assembly embedded resource
            var cardDefsXml = XDocument.Load(@"C:\Users\admin\Source\Repos\SabberStone\SabberStoneCore\Loader\Data\CardDefs.xml");
            var cardXml = XDocument.Load(@"C:\Users\admin\Source\Repos\SabberStone\SabberStoneCore\Loader\Data\CARD.xml");
            // Parse XML
            var cardDefs = (from r in cardDefsXml.Descendants("Entity")
                            select new
                            {
                                Id = r.Attribute("CardID").Value,

                                // Unfortunately the file contains some duplicate tags
                                // so we have to make a list first and weed out the unique ones
                                Tags = (from tag in r.Descendants("Tag")
                                        select new Tag(
                                            (GameTag)Enum.Parse(typeof(GameTag), tag.Attribute("enumID").Value),
                                            tag.Attribute("value") != null
                                                ? (TagValue)int.Parse(tag.Attribute("value").Value)
                                                : (tag.Attribute("type").Value == "String"
                                                    ? (TagValue)tag.Value
                                                    : (tag.Attribute("type").Value == "LocString"
                                                        ? (TagValue) tag.Element("enUS").Value
                                                        : (TagValue) 0
                                                    )))).ToList(),
                                Requirements = (from req in r.Descendants("PlayRequirement")
                                                select new
                                                {
                                                    Req = (PlayReq)Enum.Parse(typeof(PlayReq), req.Attribute("reqID").Value),
                                                    Param = (req.Attribute("param").Value != "" ? int.Parse(req.Attribute("param").Value) : 0)
                                                }).ToDictionary(x => x.Req, x => x.Param),
                                Entourage = (from ent in r.Descendants("EntourageCard")
                                             select ent.Attribute("cardID").Value).ToList(),
                                ReferenzTag = (from rtag in r.Descendants("ReferencedTag")
                                               select new Tag(
                                                   gameTag: (GameTag)Enum.Parse(typeof(GameTag), rtag.Attribute("enumID").Value),
                                                   tagValue:
                                                   rtag.Attribute("value") != null
                                                       ? (TagValue)int.Parse(rtag.Attribute("value").Value)
                                                       : (rtag.Attribute("type").Value == "String"
                                                           ? (TagValue)rtag.Value
                                                           : (rtag.Attribute("type").Value == "LocString"
                                                               ? (TagValue)rtag.Element("enUS").Value
                                                               : (TagValue)0
                                                           )))).ToList()
                            }).ToList();

            var dbfCards = (from r in cardXml.Descendants("Record")
                            select new
                            {
                                AssetId =
                                (from field in r.Descendants("Field")
                                 where field.Attribute("column").Value == "ID"
                                 select int.Parse(field.Value))
                                .FirstOrDefault(),
                                CardId =
                                (from field in r.Descendants("Field")
                                 where field.Attribute("column").Value == "NOTE_MINI_GUID"
                                 select field.Value)
                                .FirstOrDefault(),
                                Guid =
                                (from field in r.Descendants("Field")
                                 where field.Attribute("column").Value == "LONG_GUID"
                                 select field.Value)
                                .FirstOrDefault()
                            }).ToDictionary(x => x.CardId, x => x);

            // Build card database
            var cards = new List<Card>();

            foreach (var card in cardDefs)
            {
                // Skip PlaceholderCard etc.
                if (!dbfCards.ContainsKey(card.Id))
                    continue;

                var c = new Card()
                {
                    AssetId = dbfCards[card.Id].AssetId,
                    Id = card.Id,
                    Tags = new Dictionary<GameTag, int>(),
                    Requirements = card.Requirements,
                    Entourage = card.Entourage,
                    RefTags = new Dictionary<GameTag, int>(),
                };

                // Get unique int and bool tags, ignore duplicate and string tags
                foreach (var tag in card.Tags)
                {
                    if (c.Tags.ContainsKey(tag.GameTag))
                        continue;

                    if (tag.TagValue.HasIntValue)
                    {
                        c.Tags.Add(tag.GameTag, tag.TagValue);
                    }
                    else if (tag.TagValue.HasBoolValue)
                    {
                        c.Tags.Add(tag.GameTag, tag.TagValue ? 1 : 0);
                    }
                    else if (tag.TagValue.HasStringValue)
                    {
                        switch (tag.GameTag)
                        {
                            case GameTag.CARDNAME:
                                c.Name = tag.TagValue;
                                break;
                            case GameTag.CARDTEXT_INHAND:
                                c.Text = tag.TagValue;
                                break;
                        }
                    }
                }

                foreach (var tag in card.ReferenzTag)
                {
                    if (c.RefTags.ContainsKey(tag.GameTag))
                        continue;

                    if (tag.TagValue.HasIntValue)
                    {
                        c.RefTags.Add(tag.GameTag, tag.TagValue);
                    }
                    else if (tag.TagValue.HasBoolValue)
                    {
                        c.RefTags.Add(tag.GameTag, tag.TagValue ? 1 : 0);
                    }
                    else if (tag.TagValue.HasStringValue)
                    {
                        switch (tag.GameTag)
                        {
                            case GameTag.CARDNAME:
                                c.Name = tag.TagValue;
                                break;
                            case GameTag.CARDTEXT_INHAND:
                                c.Text = tag.TagValue;
                                break;
                        }
                    }
                }

                // spell damage information add ... 
                if (c.Text != null && (c.Text.Contains("$") || c[GameTag.AFFECTED_BY_SPELL_POWER] == 1))
                {
                    c.Text += " *spelldmg";
                    c.IsAffectedBySpellDamage = true;
                }
                cards.Add(c);
            }

            return cards;
        }
    }
}
