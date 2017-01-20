using System;
using System.Collections.Generic;
using System.Reflection;
using HearthDb.Enums;
using log4net;
using SabberStone.Model;
using SabberStone.Tasks.SimpleTasks;

namespace SabberStone.Actions
{
    public partial class Generic
    {
        public static Func<Controller, Card, bool> ChoicePick
            => delegate(Controller c, Card choice)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

                if (c.Choice.ChoiceType != ChoiceType.GENERAL)
                {
                    log.Info($"Choice failed, trying to pick in a non-pick choice!");
                    c.Game.PlayTaskLog.AppendLine($"Choice failed, trying to pick in a non-pick choice!");
                    return false;
                }

                if (!c.Choice.Choices.Contains(choice))
                {
                    log.Info($"Choice failed, trying to pick a card that doesn't exist in this choice!");
                    c.Game.PlayTaskLog.AppendLine($"Choice failed, trying to pick a card that doesn't exist in this choice!");
                    return false;
                }

                var playable = Entity.FromCard(c, choice);

                if (choice.Type == CardType.HERO_POWER)
                {
                    playable[GameTag.CREATOR] = c.Hero.Id;
                    var task = new ReplaceHeroPower(playable as HeroPower)
                    {
                        Game = c.Game,
                        Controller = c,
                        Source = playable,
                        Target = playable
                    };
                    c.Game.TaskQueue.Enqueue(task);
                }
                else
                {
                    var task = new AddCardTo(playable, EntityType.HAND)
                    {
                        Game = c.Game,
                        Controller = c,
                        Source = playable,
                        Target = playable
                    };
                    c.Game.TaskQueue.Enqueue(task);
                }

                // reset choice it's done
                c.Choice = null;

                return true;
            };

        public static Func<Controller, List<Card>, bool> ChoiceMulligan
            => delegate(Controller c, List<Card> choices)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

                if (c.Choice.ChoiceType != ChoiceType.MULLIGAN)
                {
                    log.Info($"Choice failed, trying to mulligan in a non-mulligan choice!");
                    c.Game.PlayTaskLog.AppendLine($"Choice failed, trying to mulligan in a non-mulligan choice!");
                    return false;
                }

                if (!choices.TrueForAll(p => c.Choice.Choices.Contains(p)))
                {
                    log.Info($"Choice failed, trying to mulligan a card that doesn't exist in this choice!");
                    c.Game.PlayTaskLog.AppendLine($"Choice failed, trying to mulligan a card that doesn't exist in this choice!");
                    return false;
                }

                return true;
            };

        public static Func<Controller, ChoiceType, ChoiceAction, List<Card>, bool> CreateChoice
            => delegate (Controller c, ChoiceType type, ChoiceAction action, List<Card> choices)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                if (c.Choice != null)
                {
                    log.Info($"there is an unresolved choice, can't add a new one!");
                    return false;
                }

                c.Choice = new Choice(c)
                {
                    ChoiceType = type,
                    ChoiceAction = action,
                    Choices = choices
                };
                return true;
            };
    }
}