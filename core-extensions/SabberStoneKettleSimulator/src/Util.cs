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
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.PlayerTasks;
using System;
using System.Collections.Generic;
using SabberStoneCore.Model.Entities;

namespace SabberStoneKettleSimulator
{
	class Util
	{
		public static PlayerTask KettleOptionToPlayerTask(Game Game, int sendOptionId, int sendOptionMainOption, int sendOptionTarget, int sendOptionPosition, int sendOptionSubOption)
		{
			SabberStoneCore.Kettle.PowerAllOptions allOptions = Game.AllOptionsMap[sendOptionId];
			Console.WriteLine(allOptions.Print());

			List<PlayerTask> tasks = allOptions.PlayerTaskList;
			SabberStoneCore.Kettle.PowerOption powerOption = allOptions.PowerOptionList[sendOptionMainOption];
			OptionType optionType = powerOption.OptionType;

			PlayerTask task = null;
			switch (optionType)
			{
				case OptionType.END_TURN:
					task = EndTurnTask.Any(Game.CurrentPlayer);
					break;

				case OptionType.POWER:

					SabberStoneCore.Kettle.PowerSubOption mainOption = powerOption.MainOption;
					IPlayable source = Game.IdEntityDic[mainOption.EntityId];
					ICharacter target = sendOptionTarget > 0 ? (ICharacter) Game.IdEntityDic[sendOptionTarget] : null;
					List<SabberStoneCore.Kettle.PowerSubOption> subObtions = powerOption.SubOptions;

					if (source.Zone?.Type == Zone.PLAY)
					{
						task = MinionAttackTask.Any(Game.CurrentPlayer, source, target);
					}
					else
					{
						switch (source.Card.Type)
						{
							case CardType.HERO:
								if (target != null)
									task = HeroAttackTask.Any(Game.CurrentPlayer, target);
								else
									task = PlayCardTask.Any(Game.CurrentPlayer, source);
								break;
							case CardType.HERO_POWER:
								task = HeroPowerTask.Any(Game.CurrentPlayer, target);
								break;
							default:
								task = PlayCardTask.Any(Game.CurrentPlayer, source, target, sendOptionPosition,
									sendOptionSubOption);
								break;
						}
					}
					break;

				case OptionType.PASS:
					break;
				default:
					throw new NotImplementedException();
			}
			return task;
		}
	}
}
