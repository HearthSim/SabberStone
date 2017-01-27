using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Actions
{
    public partial class Generic
    {
        public static Func<Controller, Card, bool> ChoicePick
            => delegate(Controller c, Card choice)
            {
                if (c.Choice.ChoiceType != ChoiceType.GENERAL)
                {
                    c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "ChoicePick", $"Choice failed, trying to pick in a non-pick choice!");
                    return false;
                }

                if (!c.Choice.Choices.Contains(choice))
                {
                    c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "ChoicePick", $"Choice failed, trying to pick a card that doesn't exist in this choice!");
                    return false;
                }

                var playable = Entity.FromCard(c, choice);

                c.Game.Log(LogLevel.INFO, BlockType.ACTION, "ChoicePick", $"{c.Name} Picks {playable} as choice!");

                switch (c.Choice.ChoiceAction)
                {
                    case ChoiceAction.HEROPOWER:
                        playable[GameTag.CREATOR] = c.Hero.Id;
                        c.Game.TaskQueue.Enqueue(new ReplaceHeroPower(playable as HeroPower)
                        {
                            Game = c.Game,
                            Controller = c,
                            Source = playable,
                            Target = playable
                        });
                        break;
                    case ChoiceAction.HAND:
                        c.Game.TaskQueue.Enqueue(new AddCardTo(playable, EntityType.HAND)
                        {
                            Game = c.Game,
                            Controller = c,
                            Source = playable,
                            Target = playable
                        });
                        break;
                    case ChoiceAction.KAZAKUS:
                        c.Setaside.Add(playable);
                        var kazakusPotions =
                            c.Setaside.GetAll.Where(p => p.Card.Id.StartsWith("CFM_621"))
                                .Select(p => p[GameTag.TAG_SCRIPT_DATA_NUM_1])
                                .ToList();
                        if (kazakusPotions.Any())
                        {
                            c.Game.TaskQueue.Enqueue(new PotionGenerating(kazakusPotions)
                            {
                                Game = c.Game,
                                Controller = c,
                                Source = playable,
                                Target = playable
                            });
                        }
                        break;

                    default:
                        throw new NotImplementedException();
                }

                // reset choice it's done
                c.Choice = null;

                return true;
            };

        public static Func<Controller, List<Card>, bool> ChoiceMulligan
            => delegate(Controller c, List<Card> choices)
            {
                if (c.Choice.ChoiceType != ChoiceType.MULLIGAN)
                {
                    c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "ChoiceMulligan", $"Choice failed, trying to mulligan in a non-mulligan choice!");
                    return false;
                }

                if (!choices.TrueForAll(p => c.Choice.Choices.Contains(p)))
                {
                    c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "ChoiceMulligan", $"Choice failed, trying to mulligan a card that doesn't exist in this choice!");
                    return false;
                }

                switch (c.Choice.ChoiceAction)
                {
                    case ChoiceAction.HAND:

                        choices.ForEach(p =>
                        {
                            var mulliganCard = c.Hand.First(t => t.Card == p);
                            RemoveFromZone(c, mulliganCard);
                            ShuffleIntoDeck.Invoke(c, mulliganCard);
                        });

                        for (var i = 0; i < choices.Count; i++)
                        {
                           Draw(c);
                        }
                        
                        // reset choice it's done
                        c.Choice = null;

                        c.MulliganState = Mulligan.DONE;
                        break;

                    default:
                        throw new NotImplementedException();
                }



                return true;
            };

        public static Func<Controller, ChoiceType, ChoiceAction, List<Card>, bool> CreateChoice
            => delegate (Controller c, ChoiceType type, ChoiceAction action, List<Card> choices)
            {
                if (c.Choice != null)
                {
                    c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "CreateChoice", $"there is an unresolved choice, can't add a new one!");
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