using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Loader
{
	internal interface ICardLoader
	{
		List<Card> Load();
	}

	internal class CardLoader : ICardLoader
	{
		private static Assembly Assembly => typeof(CardLoader).GetTypeInfo().Assembly;

		public List<int> LoadPlayReqOrder()
		{
			var playErr =
				XDocument.Load(Assembly.GetManifestResourceStream("SabberStoneCore.Resources.PlayErrors.xml"));
			var playReqOrder = (from r in playErr.Descendants("PlayErrors")
								select new
								{
									DefaultReqOrder = (from req in r.Descendants("DefaultRequirementOrder")
													   select new
													   {
														   PlayReqOrder = (from reqDesc in r.Descendants("RequirementID")
																		   select new
																		   {
																			   ReqId = reqDesc.Attribute("value").Value
																		   }).ToList()
													   }).ToList()
								}).ToList();
			var result = new List<int>();
			playReqOrder[0].DefaultReqOrder[0].PlayReqOrder.ForEach(p => result.Add(Int32.Parse(p.ReqId)));
			return result;
		}

		public Dictionary<int, PlayerReqDesc> LoadPlayReqDesc()
		{
			var playErr =
				XDocument.Load(Assembly.GetManifestResourceStream("SabberStoneCore.Resources.PlayErrors.xml"));

			var playReqDesc = (from r in playErr.Descendants("PlayErrors")
							   select new
							   {
								   Requirements = (from req in r.Descendants("PlayRequirements")
												   select new
												   {
													   PlayReqDesc = (from reqDesc in r.Descendants("PlayRequirement")
																	  select new PlayerReqDesc()
																	  {
																		  ReqId = Int32.Parse(reqDesc.Attribute("reqID").Value),
																		  Name = reqDesc.Attribute("name").Value,
																		  Description = reqDesc.Attribute("description").Value,
																		  AlwaysReq = Boolean.Parse(reqDesc.Attribute("alwaysRequired").Value),
																		  HasParam = Boolean.Parse(reqDesc.Attribute("hasParam").Value),
																		  IsTargetDetail = Boolean.Parse(reqDesc.Attribute("isTargetDetail").Value)
																	  }
													   ).ToDictionary(x => x.ReqId, x => x)
												   }).ToList()
							   }).ToList();
			var dict = new Dictionary<int, PlayerReqDesc>();
			playReqDesc[0].Requirements[0].PlayReqDesc.Values.ToList().ForEach(p => dict.Add(p.ReqId, p));
			return dict;
		}

		public List<Card> Load()
		{
			// Get XML definitions from assembly embedded resource
			var cardDefsXml =
				XDocument.Load(Assembly.GetManifestResourceStream("SabberStoneCore.Resources.CardDefs.xml"));
			//var cardDefsXml = XDocument.Load(@"C:\Users\admin\Source\Repos\SabberStone\SabberStoneCore\Loader\Data\CardDefs.xml");
			//var cardXml = XDocument.Load(Assembly.GetManifestResourceStream("SabberStoneCore.Loader.Data.CARD.xml"))
			;
			// Parse XML
			var cardDefs = (from r in cardDefsXml.Descendants("Entity")
							select new
							{
								Id = r.Attribute("CardID").Value,
								AssetId = r.Attribute("ID").Value,

								// Unfortunately the file contains some duplicate tags
								// so we have to make a list first and weed out the unique ones
								Tags = (from tag in r.Descendants("Tag")
										select new Tag(
											gameTag: (GameTag)Enum.Parse(typeof(GameTag), tag.Attribute("enumID").Value),
											tagValue:
											tag.Attribute("value") != null
												? (TagValue)Int32.Parse(tag.Attribute("value").Value)
												: (tag.Attribute("type").Value == "String"
													? (TagValue)tag.Value
													: (tag.Attribute("type").Value == "LocString"
														? (TagValue)tag.Element("enUS").Value
														: (TagValue)0
													)))).ToList(),
								Requirements = (from req in r.Descendants("PlayRequirement")
												select new
												{
													Req = (PlayReq)Enum.Parse(typeof(PlayReq), req.Attribute("reqID").Value),
													Param = (req.Attribute("param").Value != "" ? Int32.Parse(req.Attribute("param").Value) : 0)
												}).Distinct() // avoiding duplicate playrequirment unsure if it is intended or not ...
												.ToDictionary(x => x.Req, x => x.Param),
								Entourage = (from ent in r.Descendants("EntourageCard")
											 select ent.Attribute("cardID").Value).ToList(),
								ReferenzTag = (from rtag in r.Descendants("ReferencedTag")
											   select new Tag(
												   gameTag: (GameTag)Enum.Parse(typeof(GameTag), rtag.Attribute("enumID").Value),
												   tagValue:
												   rtag.Attribute("value") != null
													   ? (TagValue)Int32.Parse(rtag.Attribute("value").Value)
													   : (rtag.Attribute("type").Value == "String"
														   ? (TagValue)rtag.Value
														   : (rtag.Attribute("type").Value == "LocString"
															   ? (TagValue)rtag.Element("enUS").Value
															   : (TagValue)0
														   )))).ToList()
							}).ToList();

			// Build card database
			var cards = new List<Card>();

			foreach (var card in cardDefs)
			{
				// Skip PlaceholderCard etc.
				//if (!dbfCards.ContainsKey(card.Id))
				//    continue;

				var c = new Card()
				{
					Id = card.Id,
					AssetId = Int32.Parse(card.AssetId),
					Tags = new Dictionary<GameTag, int>(),
					PlayRequirements = card.Requirements,
					Entourage = card.Entourage,
					RefTags = new Dictionary<GameTag, int>(),
				};

				// Get unique int and bool tags, ignore duplicate and string tags
				foreach (Tag tag in card.Tags)
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

					switch (tag.GameTag)
					{
						case GameTag.SECRET:
							c.IsSecret = true;
							break;
						case GameTag.QUEST:
							c.IsQuest = true;
							break;
						case GameTag.UNTOUCHABLE:
							c.Untouchable = true;
							break;
					}
				}

				foreach (Tag tag in card.ReferenzTag)
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
					c.Text += " @spelldmg";
					c.IsAffectedBySpellDamage = true;
				}
				cards.Add(c);
			}

			return cards;
		}
	}
}
