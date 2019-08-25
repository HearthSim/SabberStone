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
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Kettle
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
{
	//message EntityChoices
	//{
	//    enum PacketID
	//    {
	//        ID_a5d9 = 17;
	//    }
	//    required int32 id = 1;
	//    required int32 choice_type = 2;
	//    required int32 count_min = 4;
	//    required int32 count_max = 5;
	//    repeated int32 entities = 6 [packed=true];
	//    optional int32 source = 7;
	//    required int32 player_id = 8;
	//    required bool hide_chosen = 9;
	//}
	public class PowerEntityChoices
	{

		private static int _index = 1;
		public int Index { get; set; }

		public ChoiceType ChoiceType { get; set; }
		public int CountMin { get; set; }
		public int CountMax { get; set; }
		public List<int> Entities { get; set; }
		public int SourceId { get; set; }
		public int PlayerId { get; set; }
		public bool HideChosen { get; set; }

		public PowerEntityChoices(Game game)
		{
			Index = _index++;
			game.EntityChoicesMap.Add(Index, this);
		}

		public PowerEntityChoices(int index, ChoiceType choiceType, List<int> entities)
		{
			Index = index;
			ChoiceType = choiceType;
			Entities = entities;
		}

		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine($"PowerChoice index={Index} PlayerId={PlayerId} ChoiceType={ChoiceType} CountMin={CountMin} CountMax={CountMax}");
			str.AppendLine($" Source={SourceId}");
			for (int i = 0; i < Entities.Count; i++)
			{
				str.AppendLine($" Entities[{i}]=[{Entities[i]}]");
			}

			return str.ToString();
		}
	}

	public class PowerChoicesBuilder
	{
		public static PowerEntityChoices EntityChoices(Game game, Choice choice)
		{
			if (choice == null)
			{
				return null;
			}

			return new PowerEntityChoices(game)
			{
				ChoiceType = choice.ChoiceType,
				Entities = new List<int>(choice.Choices),
				CountMin = choice.ChoiceType == ChoiceType.GENERAL ? 1 : 0,
				CountMax = choice.ChoiceType == ChoiceType.GENERAL ? 1 : choice.Choices.Count,
				PlayerId = choice.Controller.PlayerId,
				SourceId = choice.SourceId,
				HideChosen = choice.ChoiceType != ChoiceType.GENERAL
			};
		}
	}
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
