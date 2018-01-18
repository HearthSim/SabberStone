using System;
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
					c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "ChoicePick", !c.Game.Logging? "":$"Choice failed, trying to pick in a non-pick choice!");
					return false;
				}

				if (!c.Choice.Choices.Contains(choice))
				{
					c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "ChoicePick", !c.Game.Logging? "":$"Choice failed, trying to pick a card that doesn't exist in this choice!");
					return false;
				}

				IPlayable playable = c.Game.IdEntityDic[choice];

				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "ChoicePick", !c.Game.Logging? "":$"{c.Name} Picks {playable.Card.Name} as choice!");

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
							PlaySpell.Invoke(c, (Spell)playable, null, 0);
						}
						break;

					case ChoiceAction.SUMMON:
						if (!c.BoardZone.IsFull && RemoveFromZone(c, playable))
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
							playable.Powers.ForEach(t => t.Activate(c, playable, target));
						});
						// Need to move the chosen adaptation to the Graveyard
						c.Game.TaskQueue.Enqueue(new MoveToGraveYard(EntityType.SOURCE)
						{
							Game = c.Game,
							Controller = c,
							Source = playable,
							Target = playable
						});
						// Send metadata to the client to hide the card
						c.Game.PowerHistory.Add(new PowerHistoryMetaData
						{
							Type = MetaDataType.SHOW_BIG_CARD,
							Data = 2,
							Info = new List<int> { choice }
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
							c.SetasideZone.Where(p => p.Card.Id.StartsWith("CFM_621"))
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

					case ChoiceAction.BUILDABEAST:
						if (!c.Choice.ChoiceQueue.Any())
						{
							Card firstCard = c.Game.IdEntityDic[c.Choice.LastChoice].Card.Clone();
							Card secondCard = playable.Card;
							firstCard.Tags[GameTag.ATK] += secondCard[GameTag.ATK];
							firstCard.Tags[GameTag.HEALTH] += secondCard[GameTag.HEALTH];
							firstCard.Tags[GameTag.COST] += secondCard[GameTag.COST];
							if (secondCard.Tags.ContainsKey(GameTag.TAUNT))
								firstCard.Tags[GameTag.TAUNT] = 1;
							if (secondCard.Tags.ContainsKey(GameTag.POISONOUS))
								firstCard.Tags[GameTag.POISONOUS] = 1;
							if (secondCard.Tags.ContainsKey(GameTag.STEALTH))
								firstCard.Tags[GameTag.STEALTH] = 1;
							if (secondCard.Tags.ContainsKey(GameTag.WINDFURY))
								firstCard.Tags[GameTag.WINDFURY] = 1;
							if (secondCard.Tags.ContainsKey(GameTag.CHARGE))
								firstCard.Tags[GameTag.CHARGE] = 1;
							if (secondCard.Tags.ContainsKey(GameTag.LIFESTEAL))
								firstCard.Tags[GameTag.LIFESTEAL] = 1;
							if (secondCard.Tags.ContainsKey(GameTag.CANT_BE_TARGETED_BY_HERO_POWERS))
								firstCard.Tags[GameTag.CANT_BE_TARGETED_BY_HERO_POWERS] = 1;
							if (secondCard.Tags.ContainsKey(GameTag.CANT_BE_TARGETED_BY_SPELLS))
								firstCard.Tags[GameTag.CANT_BE_TARGETED_BY_SPELLS] = 1;
							firstCard.Name = "Zombeast";
							firstCard.Text = secondCard.Text + "\n" + firstCard.Text;

							IPlayable zombeast = Entity.FromCard(c, firstCard);
							((Entity)zombeast).SetNativeGameTag(GameTag.DISPLAYED_CREATOR, ((Entity)playable).GetNativeGameTag(GameTag.DISPLAYED_CREATOR));

							AddHandPhase.Invoke(c, zombeast);
							break;
						}
						else
							break;


					default:
						throw new NotImplementedException();
				}

				// set displayed creator at least for discover
				//playable[GameTag.DISPLAYED_CREATOR] = c.LastCardPlayed;

				//	Start next Choice if any choice is queueing up
				if (c.Choice.ChoiceQueue.Any())
				{
					c.Choice = c.Choice.ChoiceQueue.Dequeue();
					c.Choice.LastChoice = choice;
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

		public static Func<Controller, IEntity, List<IEntity>, ChoiceType, ChoiceAction, List<Card>, Power, bool> CreateChoiceCards
			=> delegate (Controller c, IEntity source, List<IEntity> targets, ChoiceType type, ChoiceAction action, List<Card> choices, Power power)
			{
				//if (c.Choice != null)
				//{
				//	c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "CreateChoice", $"there is an unresolved choice, can't add a new one!");
				//	return false;
				//}

				var choicesIds = new List<int>();
				choices.ForEach(p =>
				{
					IPlayable choiceEntity = Entity.FromCard(c, p,
						new Dictionary<GameTag, int>
						{
							{GameTag.CREATOR, source.Id},
							{GameTag.DISPLAYED_CREATOR, source.Id }
						});
					// add after discover power
					if (power != null)
					{
						if (choiceEntity.Powers == null)
							choiceEntity.Powers = new List<Power> { power };
						else
							choiceEntity.Powers.Add(power);
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
