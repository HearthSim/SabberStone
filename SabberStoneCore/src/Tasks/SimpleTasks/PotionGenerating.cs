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
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class PotionGenerating : SimpleTask
	{
		private List<Card> _kazakusPotionSpells;

		private List<Card> KazakusPotionSpells => _kazakusPotionSpells ?? (_kazakusPotionSpells = GetKazakusPotionSpells());

		public PotionGenerating(List<int> scriptTags = null)
		{
			ScriptTags = scriptTags;
		}

		public List<int> ScriptTags { get; set; }

		public override TaskState Process()
		{

			var minion = Source as Minion;
			if (minion != null && ScriptTags == null)
			{
				Generic.CreateChoiceCards.Invoke(Controller, Source, null, ChoiceType.GENERAL, ChoiceAction.KAZAKUS, minion.Card.Entourage.Select(Cards.FromId).ToArray(), null, null);
				return TaskState.COMPLETE;

			}

			Game.Log(LogLevel.INFO, BlockType.PLAY, "PotionGenerating", !Game.Logging? "":$"Current scripttags = {String.Join(",", ScriptTags)}");

			if (ScriptTags.Count < 3)
			{

				int cost = KazakusPotionSpells.First(p =>
					p[GameTag.TAG_SCRIPT_DATA_NUM_1] == ScriptTags[0]).Cost;
				var cardIdList = KazakusPotionSpells.Where(p =>
					p[GameTag.TAG_SCRIPT_DATA_NUM_1] < 1000 && p.Cost == cost &&
					(ScriptTags.Count != 2 || p[GameTag.TAG_SCRIPT_DATA_NUM_1] != ScriptTags[1])).ToArray();

				//var cardList = new List<Card>();
				//while (cardList.Count < 3)
				//{
				//	Card card = Util.Choose<Card>(cardIdList);
				//	cardList.Add(card);
				//	cardIdList.RemoveAll(p => p == card);
				//}

				Card[] cardList = Util.ChooseNElements(cardIdList, 3);

				Generic.CreateChoiceCards.Invoke(Controller, Source, null, ChoiceType.GENERAL, ChoiceAction.KAZAKUS, cardList, null, null);
				return TaskState.COMPLETE;
			}

			// create card ...
			Card baseCard = KazakusPotionSpells.First(p => p[GameTag.TAG_SCRIPT_DATA_NUM_1] == ScriptTags[0]).Clone();
			var ordered = ScriptTags.Skip(1).OrderBy(p => p).ToList();
			Card spell1 = KazakusPotionSpells.First(p => p.Cost == baseCard.Cost && p[GameTag.TAG_SCRIPT_DATA_NUM_1] == ordered[0]);
			Card spell2 = KazakusPotionSpells.First(p => p.Cost == baseCard.Cost && p[GameTag.TAG_SCRIPT_DATA_NUM_1] == ordered[1]);
			//baseCard.Text = "(1) " + spell1.Text + "(2) " + spell2.Text;
			baseCard.Text = spell1.Text + "\n" + spell2.Text;
			//baseCard.Powers = new List<Power>();
			//baseCard.Powers.AddRange(spell1.Powers);
			//spell1.PlayRequirements.ToList().ForEach(p =>
			//{
			//	if (!baseCard.PlayRequirements.ContainsKey(p.Key))
			//		baseCard.PlayRequirements.Add(p.Key, p.Value);
			//});
			//baseCard.Powers.AddRange(spell2.Powers);
			spell2.PlayRequirements.ToList().ForEach(p =>
			{
				if (!baseCard.PlayRequirements.ContainsKey(p.Key))
					baseCard.PlayRequirements.Add(p.Key, p.Value);
			});

			var task = new AddCardTo(baseCard, EntityType.HAND)
			{
				Game = Controller.Game,
				Controller = Controller,
				Source = Source as IPlayable,
				Target = Target as IPlayable
			};
			Controller.Game.TaskQueue.Enqueue(task);

			// remove tag script from used kazakus entities
			foreach (IPlayable playables in Controller.SetasideZone.Where(p => p.Card.Id.StartsWith("CFM_621")))
			{
				playables[GameTag.TAG_SCRIPT_DATA_NUM_1] = 0;
			}

			return TaskState.COMPLETE;
		}

		private static List<Card> GetKazakusPotionSpells()
		{
			//var list = Cards.All.Where(p => p.Id.StartsWith("CFM_621t")
			//&& !p.Id.Equals("CFM_621t")
			////&& !p.Id.Equals("CFM_621t11")
			////&& !p.Id.Equals("CFM_621t12")
			////&& !p.Id.Equals("CFM_621t13")
			//&& !p.Id.Equals("CFM_621t14")
			//&& !p.Id.Equals("CFM_621t15")
			//).Select(p => p.Clone()).ToList();
			//return list;

			return new List<Card>
			{
				Cards.FromId("CFM_621t2").Clone(),
				Cards.FromId("CFM_621t3").Clone(),
				Cards.FromId("CFM_621t4").Clone(),
				Cards.FromId("CFM_621t5").Clone(),
				Cards.FromId("CFM_621t6").Clone(),
				Cards.FromId("CFM_621t8").Clone(),
				Cards.FromId("CFM_621t9").Clone(),
				Cards.FromId("CFM_621t10").Clone(),
				Cards.FromId("CFM_621t11").Clone(),
				Cards.FromId("CFM_621t12").Clone(),
				Cards.FromId("CFM_621t13").Clone(),
				Cards.FromId("CFM_621t16").Clone(),
				Cards.FromId("CFM_621t17").Clone(),
				Cards.FromId("CFM_621t18").Clone(),
				Cards.FromId("CFM_621t19").Clone(),
				Cards.FromId("CFM_621t20").Clone(),
				Cards.FromId("CFM_621t21").Clone(),
				Cards.FromId("CFM_621t22").Clone(),
				Cards.FromId("CFM_621t23").Clone(),
				Cards.FromId("CFM_621t24").Clone(),
				Cards.FromId("CFM_621t25").Clone(),
				Cards.FromId("CFM_621t26").Clone(),
				Cards.FromId("CFM_621t27").Clone(),
				Cards.FromId("CFM_621t28").Clone(),
				Cards.FromId("CFM_621t29").Clone(),
				Cards.FromId("CFM_621t30").Clone(),
				Cards.FromId("CFM_621t31").Clone(),
				Cards.FromId("CFM_621t32").Clone(),
				Cards.FromId("CFM_621t33").Clone(),
				Cards.FromId("CFM_621t37").Clone(),
				Cards.FromId("CFM_621t38").Clone(),
				Cards.FromId("CFM_621t39").Clone(),
			};
		}

		private void ProcessSplit(List<Card>[] cardsToDiscover, ChoiceAction choiceAction)
		{

		}

		public override ISimpleTask Clone()
		{
			var clone = new PotionGenerating(ScriptTags);
			clone.Copy(this);
			return clone;
		}
	}
}
