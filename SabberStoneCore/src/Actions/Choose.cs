using SabberStoneCore.Collections;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCore.Actions
{
	public partial class Generic
    {
        public static Func<Controller, int, bool> ChoicePick
            => delegate(Controller c, int choice)
            {
                if (c.Choice.ChoiceType != EChoiceType.GENERAL)
                {
                    c.Game.Log(ELogLevel.WARNING, EBlockType.ACTION, "ChoicePick", $"Choice failed, trying to pick in a non-pick choice!");
                    return false;
                }

                if (!c.Choice.Choices.Contains(choice))
                {
                    c.Game.Log(ELogLevel.WARNING, EBlockType.ACTION, "ChoicePick", $"Choice failed, trying to pick a card that doesn't exist in this choice!");
                    return false;
                }

                var playable = c.Game.Entities[choice];

                c.Game.Log(ELogLevel.INFO, EBlockType.ACTION, "ChoicePick", $"{c.Name} Picks {playable.Card.Name} as choice!");

                switch (c.Choice.ChoiceAction)
                {
                    case EChoiceAction.HAND:
                        if (RemoveFromZone(c, playable))
                        {
                            c.Game.TaskQueue.Enqueue(new AddCardTo(playable, EEntityType.HAND)
                            {
                                Game = c.Game,
                                Controller = c,
                                Source = playable,
                                Target = playable
                            });
                        }
                        break;

                    case EChoiceAction.SUMMON:
                        if (RemoveFromZone(c, playable))
                        {
                            c.Game.TaskStack.Playables.Add(playable);
                            c.Game.TaskQueue.Enqueue(new SummonTask()
                            {
                                Game = c.Game,
                                Controller = c,
                                Source = playable,
                                Target = playable
                            });
                        }
                        break;

                    case EChoiceAction.ADAPT:
                        c.Choice.TargetIds.ForEach(p =>
                        {
                            var target = c.Game.Entities[p];
                            playable.Enchantments.ForEach(t => t.Activate(c, playable, target));
                        });
                        break;

                    case EChoiceAction.TRACKING:
                        if (RemoveFromZone(c, playable))
                        {
                            c.Game.TaskQueue.Enqueue(new AddCardTo(playable, EEntityType.HAND)
                            {
                                Game = c.Game,
                                Controller = c,
                                Source = playable,
                                Target = playable
                            });
                        }
                        break;

                    case EChoiceAction.HEROPOWER:
                        if (RemoveFromZone(c, playable))
                        {
                            playable[EGameTag.CREATOR] = c.Hero.Id;
                            c.Game.TaskQueue.Enqueue(new ReplaceHeroPower(playable as HeroPower)
                            {
                                Game = c.Game,
                                Controller = c,
                                Source = playable,
                                Target = playable
                            });
                        }
                        break;

                    case EChoiceAction.KAZAKUS:
                        c.Choice.Choices.Where(p => p != choice).ToList().ForEach(p =>
                        {
                            c.Game.Entities[p][EGameTag.TAG_SCRIPT_DATA_NUM_1] = 0;
                        });
                        //c.Setaside.Add(playable);
                        var kazakusPotions =
                            c.Setaside.GetAll.Where(p => p.Card.Id.StartsWith("CFM_621"))
                                .Where(p => p[EGameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
                                .Select(p => p[EGameTag.TAG_SCRIPT_DATA_NUM_1])
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

                // set displayed creator at least for discover
                //playable[GameTag.DISPLAYED_CREATOR] = c.LastCardPlayed;

                // reset choice it's done
                c.Choice = null;

                return true;
            };

        public static Func<Controller, List<int>, bool> ChoiceMulligan
            => delegate(Controller c, List<int> choices)
            {
                if (c.Choice.ChoiceType != EChoiceType.MULLIGAN)
                {
                    c.Game.Log(ELogLevel.WARNING, EBlockType.ACTION, "ChoiceMulligan", $"Choice failed, trying to mulligan in a non-mulligan choice!");
                    return false;
                }

                if (!choices.TrueForAll(p => c.Choice.Choices.Contains(p)))
                {
                    c.Game.Log(ELogLevel.WARNING, EBlockType.ACTION, "ChoiceMulligan", $"Choice failed, trying to mulligan a card that doesn't exist in this choice!");
                    return false;
                }

                switch (c.Choice.ChoiceAction)
                {
                    case EChoiceAction.HAND:
                        c.MulliganState = EMulligan.DEALING;

                        // starting mulligan draw block
                        if (c.Game.HistoryEnabled)
                            c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.TRIGGER, c.Id, "", 6, 0));

                        var mulliganList = c.Hand.GetAll.Where(p => !choices.Contains(p.Id) && !p.Card.Id.Equals("GAME_005")).ToList();
                        mulliganList.ForEach(p =>
                        {
                            // drawing a new one
                            var playable = c.Deck.Remove(c.Deck[0]);

                            if (AddHandPhase.Invoke(c, playable))
                            {
                                c.Hand.Swap(p, playable);
                            }

                            // removing old one
                            RemoveFromZone(c, p);
                            ShuffleIntoDeck.Invoke(c, p);
                        });

                        if (c.Game.HistoryEnabled)
                            c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
                       
                        // reset choice it's done
                        c.Choice = null;

                        break;

                    default:
                        throw new NotImplementedException();
                }



                return true;
            };

        public static Func<Controller, IEntity, EChoiceType, EChoiceAction, IReadOnlyOrderedSet<int>, bool> CreateChoice
            => delegate (Controller c, IEntity source, EChoiceType type, EChoiceAction action, IReadOnlyOrderedSet<int> choices)
            {
                if (c.Choice != null)
                {
                    c.Game.Log(ELogLevel.WARNING, EBlockType.ACTION, "CreateChoice", $"there is an unresolved choice, can't add a new one!");
                    return false;
                }

                c.Choice = new EntityChoice(c)
                {
                    ChoiceType = type,
                    ChoiceAction = action,
                    Choices = choices,
                    SourceId = source.Id
                };
                return true;
            };

        public static Func<Controller, IEntity, List<IEntity>, EChoiceType, EChoiceAction, IReadOnlyOrderedSet<Card>, Enchantment, bool> CreateChoiceCards
            => delegate (Controller c, IEntity source, List<IEntity> targets, EChoiceType type, EChoiceAction action, IReadOnlyOrderedSet<Card> choices, Enchantment enchantment)
            {
                if (c.Choice != null)
                {
                    c.Game.Log(ELogLevel.WARNING, EBlockType.ACTION, "CreateChoice", $"there is an unresolved choice, can't add a new one!");
                    return false;
                }

                var choicesIds = new OrderedHashSet<int>();
				foreach(Card card in choices)
				{
					IPlayable choiceEntity = Entity.FromCard(c, card);
					choiceEntity[EGameTag.CREATOR] = source.Id;
					// add after discover enchantment
					if (enchantment != null)
					{
						choiceEntity.Enchantments.Add(enchantment);
					}
					c.Setaside.Add(choiceEntity);
					choicesIds.Add(choiceEntity.Id);
				}

				c.Choice = new EntityChoice(c)
				{
					ChoiceType = type,
					ChoiceAction = action,
					Choices = choicesIds,
					SourceId = source.Id,
					TargetIds = targets != null ? LightWeightOrderedSet<int>.Build(targets.Select(p => p.Id)) : LightWeightOrderedSet<int>.Empty,
                };

                return true;
            };
    }
}