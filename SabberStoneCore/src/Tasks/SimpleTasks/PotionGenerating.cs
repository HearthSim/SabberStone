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
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class PotionGenerating : SimpleTask
	{
		//private List<Card> _kazakusPotionSpells;

		public PotionGenerating(List<int> scriptTags = null)
		{
			ScriptTags = scriptTags;
		}

		//private List<Card> KazakusPotionSpells =>
		//	_kazakusPotionSpells ?? (_kazakusPotionSpells = GetKazakusPotionSpells());

		public List<int> ScriptTags { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var minion = source as Minion;
			if (minion != null && ScriptTags == null)
			{
				Generic.CreateChoiceCards.Invoke(controller, source, null, ChoiceType.GENERAL, ChoiceAction.KAZAKUS,
					minion.Card.Entourage.Select(Cards.FromId).ToArray(), null, null);
				return TaskState.COMPLETE;
			}

			game.Log(LogLevel.INFO, BlockType.PLAY, "PotionGenerating",
				!game.Logging ? "" : $"Current scripttags = {String.Join(",", ScriptTags)}");

			if (ScriptTags.Count < 3)
			{
				int cost = KazakusPotionSpells.First(p =>
					p[GameTag.TAG_SCRIPT_DATA_NUM_1] == ScriptTags[0]).Cost;
				Card[] cardIdList = KazakusPotionSpells.Where(p =>
					p[GameTag.TAG_SCRIPT_DATA_NUM_1] < 1000 && p.Cost == cost &&
					(ScriptTags.Count != 2 || p[GameTag.TAG_SCRIPT_DATA_NUM_1] != ScriptTags[1])).ToArray();

				//var cardList = new List<Card>();
				//while (cardList.Count < 3)
				//{
				//	Card card = Util.Choose<Card>(cardIdList);
				//	cardList.Add(card);
				//	cardIdList.RemoveAll(p => p == card);
				//}

				Card[] cardList = cardIdList.ChooseNElements(3);

				Generic.CreateChoiceCards.Invoke(controller, source, null, ChoiceType.GENERAL, ChoiceAction.KAZAKUS,
					cardList, null, null);
				return TaskState.COMPLETE;
			}

			// create card ...
			Card baseCard = KazakusPotionSpells.First(p => p[GameTag.TAG_SCRIPT_DATA_NUM_1] == ScriptTags[0]);
			List<int> ordered = ScriptTags.Skip(1).OrderBy(p => p).ToList();
			Card spell1 = KazakusPotionSpells.First(p =>
				p.Cost == baseCard.Cost && p[GameTag.TAG_SCRIPT_DATA_NUM_1] == ordered[0]);
			Card spell2 = KazakusPotionSpells.First(p =>
				p.Cost == baseCard.Cost && p[GameTag.TAG_SCRIPT_DATA_NUM_1] == ordered[1]);

			Card potionCard = Card.CreateKazakusPotion(in baseCard, in spell1, in spell2, false);

			game.TaskQueue.Enqueue(new AddCardTo(potionCard, EntityType.HAND), in controller, in source, in target);

			// remove tag script from used kazakus entities
			foreach (IPlayable playables in controller.SetasideZone.Where(p => p.Card.Id.StartsWith("CFM_621")))
				playables[GameTag.TAG_SCRIPT_DATA_NUM_1] = 0;

			return TaskState.COMPLETE;
		}

		private static readonly IReadOnlyList<Card> KazakusPotionSpells
		 = new []
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
				Cards.FromId("CFM_621t39").Clone()
		};
		

		//private void ProcessSplit(List<Card>[] cardsToDiscover, ChoiceAction choiceAction)
		//{
		//}
	}
}
