using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Actions
{
    public partial class Generic
    {
        public static Func<Controller, int, bool> ChoicePick
            => delegate(Controller c, int choice)
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

                var playable = c.Game.IdEntityDic[choice];

                c.Game.Log(LogLevel.INFO, BlockType.ACTION, "ChoicePick", $"{c.Name} Picks {playable.Card.Name} as choice!");

                if (c.Choice.ChoiceAction == ChoiceAction.HAND)
                {
                    if (RemoveFromZone(c, playable))
                    {
                        c.Game.TaskQueue.Enqueue(new AddCardTo(playable, EntityType.HAND)
                        {
                            Game = c.Game,
                            Controller = c,
                            Source = playable,
                            Target = playable
                        });
                    }
                }
                else if (c.Choice.ChoiceAction == ChoiceAction.TRACKING)
                {
                    if (RemoveFromZone(c, playable))
                    {
                        c.Game.TaskQueue.Enqueue(new AddCardTo(playable, EntityType.HAND)
                        {
                            Game = c.Game,
                            Controller = c,
                            Source = playable,
                            Target = playable
                        });
                    }
                }
                else if (c.Choice.ChoiceAction == ChoiceAction.HEROPOWER)
                {
                    if (RemoveFromZone(c, playable))
                    {
                        playable[GameTag.CREATOR] = c.Hero.Id;
                        c.Game.TaskQueue.Enqueue(new ReplaceHeroPower(playable as HeroPower)
                        {
                            Game = c.Game,
                            Controller = c,
                            Source = playable,
                            Target = playable
                        });
                    }
                }
                else if (c.Choice.ChoiceAction == ChoiceAction.KAZAKUS)
                {
                    c.Choice.Choices.Where(p => p != choice).ToList().ForEach(p =>
                    {
                        c.Game.IdEntityDic[p][GameTag.TAG_SCRIPT_DATA_NUM_1] = 0;
                    });
                    //c.Setaside.Add(playable);
                    var kazakusPotions =
                        c.Setaside.GetAll.Where(p => p.Card.Id.StartsWith("CFM_621"))
                            .Where(p => p[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
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
                }
                else
                {
                    throw new NotImplementedException();
                }

                // reset choice it's done
                c.Choice = null;

                return true;
            };

        public static Func<Controller, List<int>, bool> ChoiceMulligan
            => delegate(Controller c, List<int> choices)
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
                        c.MulliganState = Mulligan.DEALING;

                        // starting mulligan draw block
                        if (c.Game.History)
                            c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, c.Id, "", 6, 0));

                        var mulliganList = c.Hand.GetAll.Where(p => !choices.Contains(p.Id) && !p.Card.Id.Equals("GAME_005")).ToList();
                        mulliganList.ForEach(p =>
                        {
                            RemoveFromZone(c, p);
                            ShuffleIntoDeck.Invoke(c, p);
                        });
                        //choices.ForEach(p =>
                        //{
                        //    var mulliganCard = c.Hand.First(t => t.Id == p);
                        //    RemoveFromZone(c, mulliganCard);
                        //    ShuffleIntoDeck.Invoke(c, mulliganCard);
                        //});
                        if (c.Game.History)
                            c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

                        c.MulliganState = Mulligan.WAITING;
                        for (var i = 0; i < mulliganList.Count; i++)
                        {
                            //c.NumCardsDrawnThisTurn++;
                            Draw(c);
                        }
                        
                        // reset choice it's done
                        c.Choice = null;

                        break;

                    default:
                        throw new NotImplementedException();
                }



                return true;
            };

        public static Func<Controller, IEntity, ChoiceType, ChoiceAction, List<int>, bool> CreateChoice
            => delegate (Controller c, IEntity source, ChoiceType type, ChoiceAction action, List<int> choices)
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
                    Choices = choices,
                    SourceId = source.Id
                };
                return true;
            };

        public static Func<Controller, IEntity, ChoiceType, ChoiceAction, List<Card>, bool> CreateChoiceCards
            => delegate (Controller c, IEntity source, ChoiceType type, ChoiceAction action, List<Card> choices)
            {
                if (c.Choice != null)
                {
                    c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "CreateChoice", $"there is an unresolved choice, can't add a new one!");
                    return false;
                }

                var choicesIds = new List<int>();
                choices.ForEach(p =>
                {
                    var choiceEntity = Entity.FromCard(c, p);
                    c.Setaside.Add(choiceEntity);
                    choicesIds.Add(choiceEntity.Id);
                });

                c.Choice = new Choice(c)
                {
                    ChoiceType = type,
                    ChoiceAction = action,
                    Choices = choicesIds,
                    SourceId = source.Id
                };
                return true;
            };
    }
}