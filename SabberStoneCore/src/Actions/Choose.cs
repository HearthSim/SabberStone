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
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Actions
{
	public static partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static Func<Controller, Game, int, bool> ChoicePick
			=> delegate (Controller c, Game g, int choice)
			{
				if (c.Choice.ChoiceType != ChoiceType.GENERAL)
				{
					g.Log(LogLevel.WARNING, BlockType.ACTION, "ChoicePick", !g.Logging? "":$"Choice failed, trying to pick in a non-pick choice!");
					return false;
				}

				if (!c.Choice.Choices.Contains(choice))
				{
					g.Log(LogLevel.WARNING, BlockType.ACTION, "ChoicePick", !g.Logging? "":$"Choice failed, trying to pick a card that doesn't exist in this choice!");
					return false;
				}

				IPlayable playable = g.IdEntityDic[choice];

				g.Log(LogLevel.INFO, BlockType.ACTION, "ChoicePick", !g.Logging? "":$"{c.Name} Picks {playable.Card.Name} as choice!");

				switch (c.Choice.ChoiceAction)
				{
					case ChoiceAction.HAND:
						if (RemoveFromZone(c, playable))
						{
							AddHandPhase.Invoke(c, playable);
						}
						//if (RemoveFromZone(c, playable))
						//{
						//	g.TaskQueue.Enqueue(new AddCardTo(playable, EntityType.HAND)
						//	{
						//		Game = g,
						//		Controller = c,
						//		Source = playable,
						//		Target = playable
						//	});
						//}
						break;

					case ChoiceAction.CAST:
						RemoveFromZone(c, playable);
						CastSpell.Invoke(c, g, playable as Spell, null, 0);
						break;

					case ChoiceAction.SPELL_RANDOM:
						if (RemoveFromZone(c, playable))
						{
							ICharacter randTarget = ((Playable) playable).GetRandomValidTarget();

							g.TaskQueue.StartEvent();
							CastSpell.Invoke(c, g, (Spell)playable, randTarget, 0);
							g.TaskQueue.EndEvent();
						}
						break;

					case ChoiceAction.SUMMON:
						if (!c.BoardZone.IsFull && RemoveFromZone(c, playable))
						{
							SummonBlock.Invoke(g, (Minion)playable, -1, g.IdEntityDic[c.Choice.SourceId]);
						}
						//if (RemoveFromZone(c, playable))
						//{
						//	g.TaskStack.Playables.Add(playable);
						//	g.TaskQueue.Enqueue(new SummonTask()
						//	{
						//		Game = g,
						//		Controller = c,
						//		Source = playable,
						//		Target = playable
						//	});
						//}
						break;

					case ChoiceAction.ADAPT:
						g.TaskQueue.StartEvent();
						foreach (IPlayable p in c.Choice.EntityStack.Select(id => g.IdEntityDic[id]))
							playable.ActivateTask(PowerActivation.POWER, (ICharacter)p);
						// Need to move the chosen adaptation to the Graveyard
						g.TaskQueue.Enqueue(new MoveToGraveYard(EntityType.SOURCE), in c, playable, null);
						g.ProcessTasks();
						g.TaskQueue.EndEvent();
						if (g.History)
						{
							// Send metadata to the client to hide the card
							g.PowerHistory.Add(new PowerHistoryMetaData
							{
								Type = MetaDataType.SHOW_BIG_CARD,
								Data = 2,
								Info = new List<int> { choice }
							});
						}
						break;

					//case ChoiceAction.TRACKING:
					//	if (RemoveFromZone(c, playable))
					//	{
					//		g.TaskQueue.Enqueue(new AddCardTo(playable, EntityType.HAND)
					//		{
					//			Game = g,
					//			Controller = c,
					//			Source = playable,
					//			Target = playable
					//		});
					//	}
					//	break;

					case ChoiceAction.HEROPOWER:
						if (RemoveFromZone(c, playable))
						{
							playable[GameTag.CREATOR] = c.Hero.Id;
							g.Log(LogLevel.INFO, BlockType.PLAY, "ReplaceHeroPower",
								!g.Logging ? "" : $"{c.Hero} power replaced by {playable}");

							c.SetasideZone.Add(c.Hero.HeroPower);
							c.Hero.HeroPower = (HeroPower) playable;
						}
						break;

					case ChoiceAction.STACK:
						c.Choice.AddToStack(choice);
						break;
					case ChoiceAction.KAZAKUS:
						//c.Choice.Choices.Where(p => p != choice).ToList().ForEach(p =>
						//{
						//	g.IdEntityDic[p][GameTag.TAG_SCRIPT_DATA_NUM_1] = 0;
						//});
						////c.Setaside.Add(playable);
						//var kazakusPotions =
						//	c.SetasideZone.Where(p => p.Card.Id.StartsWith("CFM_621"))
						//		.Where(p => p[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
						//		.Select(p => p[GameTag.TAG_SCRIPT_DATA_NUM_1])
						//		.ToList();
						//if (kazakusPotions.Any())
						//{
						//	g.TaskQueue.Enqueue(new PotionGenerating(kazakusPotions), in c, playable, null);
						//}
						if (playable.Power == null)
							c.Choice.EntityStack = new List<int> {playable.Id};
						else
							c.Choice.AddToStack(playable.Id);

						KazakusPower.Action(in g, in c, c.Choice.EntityStack);
						break;
					case ChoiceAction.GLIMMERROOT:
						if (c.Opponent.DeckCards.Select(p => p.Id).Contains(playable.Card.Id))
						{
							if (RemoveFromZone(c, playable))
								AddHandPhase.Invoke(c, playable);
						}
						break;

					case ChoiceAction.BUILDABEAST:
						//if (c.Choice.ChoiceQueue.Count == 0)
						if (c.Choice.NextChoice == null)
						{
							Card firstCard = g.IdEntityDic[c.Choice.LastChoice].Card.Clone();
							Card secondCard = playable.Card;
							Card zombeastCard = Card.CreateZombeastCard(in firstCard, in secondCard, g.History);

							IPlayable zombeast = Entity.FromCard(in c, in zombeastCard);
							zombeast[GameTag.DISPLAYED_CREATOR] = playable[GameTag.DISPLAYED_CREATOR];

							AddHandPhase.Invoke(c, zombeast);
							break;
						}
						else
							break;


					default:
						throw new NotImplementedException();
				}

				//if (c.Choice.EnchantmentCard != null)
				//	AddEnchantmentBlock.Invoke(c, c.Choice.EnchantmentCard, g.IdEntityDic[c.Choice.SourceId], playable, 0, 0, 0);

				// aftertask here
				if (c.Choice.AfterChooseTask != null)
				{
					// choice creator as Source
					// selected card as Target
					//g.TaskQueue.Enqueue(c.Choice.AfterChooseTask, in c, g.IdEntityDic[playable[GameTag.CREATOR]], playable);
					c.Choice.AfterChooseTask.Process(in g, in c, g.IdEntityDic[c.Choice.SourceId], playable,
						new TaskStack()
						{
							Playables = c.Choice.EntityStack?.Select(id => g.IdEntityDic[id]).ToArray()
						});
				}

				// set displayed creator at least for discover
				//playable[GameTag.DISPLAYED_CREATOR] = c.LastCardPlayed;

				//	Start next Choice if any choice is queueing up
				//if (c.Choice.ChoiceQueue.Any())
				//{
				//	Choice nextChoice = c.Choice.ChoiceQueue.Dequeue();
				//	nextChoice.ChoiceQueue = c.Choice.ChoiceQueue;
				//	c.Choice = nextChoice;
				//	c.Choice.LastChoice = choice;
				//}
				if (c.Choice.TryPopNextChoice(choice, out Choice nextChoice))
				{
					c.Choice = nextChoice;
				}
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
					c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "ChoiceMulligan", !c.Game.Logging? "":$"Choice failed, trying to mulligan in a non-mulligan choice!");
					return false;
				}

				if (!choices.TrueForAll(p => c.Choice.Choices.Contains(p)))
				{
					c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "ChoiceMulligan", !c.Game.Logging? "":$"Choice failed, trying to mulligan a card that doesn't exist in this choice!");
					return false;
				}

				switch (c.Choice.ChoiceAction)
				{
					case ChoiceAction.HAND:
						c.MulliganState = Mulligan.DEALING;

						// starting mulligan draw block
						if (c.Game.History)
							c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, c.Id, "", 6, 0));

						var mulliganList = c.HandZone.Where(p => !choices.Contains(p.Id) && !p.Card.Id.Equals("GAME_005")).ToList();
						mulliganList.ForEach(p =>
						{
							// drawing a new one
							IPlayable playable = c.DeckZone.Remove(c.DeckZone.TopCard);

							if (AddHandPhase.Invoke(c, playable))
							{
								c.HandZone.Swap(p, playable);
							}

							// removing old one
							RemoveFromZone(c, p);
							ShuffleIntoDeck.Invoke(c, null, p);
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
					c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "CreateChoice", !c.Game.Logging? "":$"there is an unresolved choice, can't add a new one!");
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

		public static Func<Controller, IEntity, IList<IPlayable>, ChoiceType, ChoiceAction, Card[], ISimpleTask, bool> CreateChoiceCards
			=> delegate (Controller c, IEntity source, IList<IPlayable> targets, ChoiceType type, ChoiceAction action, Card[] choices, ISimpleTask taskToDo)
			{
				//if (c.Choice != null)
				//{
				//	c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "CreateChoice", $"there is an unresolved choice, can't add a new one!");
				//	return false;
				//}

				var choicesIds = new List<int>();
				foreach (Card p in choices)
				{
					IPlayable choiceEntity = Entity.FromCard(c, p,
						new EntityData
						{
							{GameTag.CREATOR, source.Id},
							{GameTag.DISPLAYED_CREATOR, source.Id }
						}, c.SetasideZone);
					choicesIds.Add(choiceEntity.Id);
				}

				var choice = new Choice(c)
				{
					ChoiceType = type,
					ChoiceAction = action,
					Choices = choicesIds,
					SourceId = source.Id,
					//TargetIds = targets != null ? targets.Select(p => p.Id).ToList() : new List<int>(),
					//EnchantmentCard = enchantmentCard,
					AfterChooseTask = taskToDo,

					EntityStack = targets?.Select(p => p.Id).ToList()
				};


				if (c.Choice != null)
				{
					//c.Choice.ChoiceQueue.Enqueue(choice);

					Choice next = c.Choice;
					while (next.NextChoice != null)
						next = next.NextChoice;

					next.NextChoice = choice;
				}
				else
					c.Choice = choice;

				return true;
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
