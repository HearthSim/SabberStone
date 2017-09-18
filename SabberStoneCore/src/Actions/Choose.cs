﻿using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
	public partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static Func<Controller, int, bool> ChoicePick
			=> delegate (Controller c, int choice)
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

				IPlayable playable = c.Game.IdEntityDic[choice];

				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "ChoicePick", $"{c.Name} Picks {playable.Card.Name} as choice!");

				switch (c.Choice.ChoiceAction)
				{
					case ChoiceAction.HAND:

						if (RemoveFromZone(c, playable))
						{
							AddHandPhase.Invoke(c, playable);
						}
						//if (RemoveFromZone(c, playable))
						//{
						//	c.Game.TaskQueue.Enqueue(new AddCardTo(playable, EntityType.HAND)
						//	{
						//		Game = c.Game,
						//		Controller = c,
						//		Source = playable,
						//		Target = playable
						//	});
						//}
						break;

					case ChoiceAction.SPELL:
						if (RemoveFromZone(c, playable))
						{
							PlaySpell.Invoke(c, (Spell)playable, null);
						}
						break;

					case ChoiceAction.SUMMON:
						if (RemoveFromZone(c, playable))
						{
							SummonBlock.Invoke(c, (Minion)playable, -1);
						}
						//if (RemoveFromZone(c, playable))
						//{
						//	c.Game.TaskStack.Playables.Add(playable);
						//	c.Game.TaskQueue.Enqueue(new SummonTask()
						//	{
						//		Game = c.Game,
						//		Controller = c,
						//		Source = playable,
						//		Target = playable
						//	});
						//}
						break;

					case ChoiceAction.ADAPT:
						c.Choice.TargetIds.ForEach(p =>
						{
							IPlayable target = c.Game.IdEntityDic[p];
							playable.Enchantments.ForEach(t => t.Activate(c, playable, target));
						});
						break;

					case ChoiceAction.TRACKING:
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
						break;

					case ChoiceAction.HEROPOWER:
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
						break;

					case ChoiceAction.KAZAKUS:
						c.Choice.Choices.Where(p => p != choice).ToList().ForEach(p =>
						{
							c.Game.IdEntityDic[p][GameTag.TAG_SCRIPT_DATA_NUM_1] = 0;
						});
						//c.Setaside.Add(playable);
						var kazakusPotions =
							c.SetasideZone.GetAll.Where(p => p.Card.Id.StartsWith("CFM_621"))
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
						break;

					case ChoiceAction.GLIMMERROOT:
						if (c.Opponent.DeckCards.Select(p => p.Id).Contains(playable.Card.Id))
						{
							if (RemoveFromZone(c, playable))
								AddHandPhase.Invoke(c, playable);
						}
						break;

					default:
						throw new NotImplementedException();
				}

				// set displayed creator at least for discover
				//playable[GameTag.DISPLAYED_CREATOR] = c.LastCardPlayed;

				//	Start next Choice if any choice is queueing up
				if (c.Choice.ChoiceQueue.Any())
					c.Choice = c.Choice.ChoiceQueue.Dequeue();
				else
				{
					// reset choice it's done
					c.Choice = null;
				}

				return true;
			};

		public static Func<Controller, List<int>, bool> ChoiceMulligan
			=> delegate (Controller c, List<int> choices)
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

						var mulliganList = c.HandZone.GetAll.Where(p => !choices.Contains(p.Id) && !p.Card.Id.Equals("GAME_005")).ToList();
						mulliganList.ForEach(p =>
						{
							// drawing a new one
							IPlayable playable = c.DeckZone.Remove(c.DeckZone[0]);

							if (AddHandPhase.Invoke(c, playable))
							{
								c.HandZone.Swap(p, playable);
							}

							// removing old one
							RemoveFromZone(c, p);
							ShuffleIntoDeck.Invoke(c, p);
						});

						if (c.Game.History)
							c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

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

		public static Func<Controller, IEntity, List<IEntity>, ChoiceType, ChoiceAction, List<Card>, Enchantment, bool> CreateChoiceCards
			=> delegate (Controller c, IEntity source, List<IEntity> targets, ChoiceType type, ChoiceAction action, List<Card> choices, Enchantment enchantment)
			{
				//if (c.Choice != null)
				//{
				//	c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "CreateChoice", $"there is an unresolved choice, can't add a new one!");
				//	return false;
				//}

				var choicesIds = new List<int>();
				choices.ForEach(p =>
				{
					IPlayable choiceEntity = Entity.FromCard(c, p);
					((Entity)choiceEntity).SetNativeGameTag(GameTag.DISPLAYED_CREATOR, source.Id);
					// add after discover enchantment
					if (enchantment != null)
					{
						choiceEntity.Enchantments.Add(enchantment);
					}
					c.SetasideZone.Add(choiceEntity);
					choicesIds.Add(choiceEntity.Id);
				});

				var choice = new Choice(c)
				{
					ChoiceType = type,
					ChoiceAction = action,
					Choices = choicesIds,
					SourceId = source.Id,
					TargetIds = targets != null ? targets.Select(p => p.Id).ToList() : new List<int>()
				};

				if (c.Choice != null)
				{
					c.Choice.ChoiceQueue.Enqueue(choice);
				}
				else
				{
					c.Choice = choice;
				}
				return true;
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
