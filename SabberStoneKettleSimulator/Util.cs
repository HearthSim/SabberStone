using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneKettle;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneKettleSimulator
{
    class Util
    {
        public static PlayerTask KettleOptionToPlayerTask(Game Game, int sendOptionId, int sendOptionMainOption, int sendOptionTarget, int sendOptionPosition, int sendOptionSubOption)
        {
            var allOptions = Game.AllOptionsMap[sendOptionId];
            Console.WriteLine(allOptions.Print());

            var tasks = allOptions.PlayerTaskList;
            var powerOption = allOptions.PowerOptionList[sendOptionMainOption];
            var optionType = powerOption.OptionType;

            PlayerTask task = null;
            switch (optionType)
            {
                case OptionType.END_TURN:
                    task = EndTurnTask.Any(Game.CurrentPlayer);
                    break;

                case OptionType.POWER:

                    var mainOption = powerOption.MainOption;
                    IPlayable source = Game.IdEntityDic[mainOption.EntityId];
                    IPlayable target = sendOptionTarget > 0 ? Game.IdEntityDic[sendOptionTarget] : null;
                    var subObtions = powerOption.SubOptions;

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
