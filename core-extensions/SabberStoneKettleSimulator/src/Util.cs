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
					IPlayable source = Game.EntityContainer[mainOption.EntityId];
					IPlayable target = sendOptionTarget > 0 ? Game.EntityContainer[sendOptionTarget] : null;
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
								task = HeroAttackTask.Any(Game.CurrentPlayer, target);
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
