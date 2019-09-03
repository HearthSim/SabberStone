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
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Actions
{
	public static partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static IPlayable DrawCard(Controller c, Card card)
		{
			return DrawCardBlock.Invoke(c, card);
		}

		public static IPlayable Draw(Controller c, IPlayable cardToDraw = null)
		{
			return DrawBlock.Invoke(c, cardToDraw);
		}

		public static Func<Controller, Card, IPlayable> DrawCardBlock
			=> delegate (Controller c, Card card)
			{
				IPlayable playable = Entity.FromCard(c, card);
				//c.NumCardsDrawnThisTurn++;
				AddHandPhase.Invoke(c, playable);
				return playable;
			};

		public static Func<Controller, IPlayable, IPlayable> DrawBlock
			=> delegate (Controller c, IPlayable cardToDraw)
			{
				if (!PreDrawPhase.Invoke(c))
					return null;

				IPlayable playable = DrawPhase.Invoke(c, cardToDraw);
				//c.NumCardsToDraw--; 

				if (AddHandPhase.Invoke(c, playable))
				{
					// DrawTrigger vs TOPDECK ?? not sure which one is first

					Game game = c.Game;

					if (cardToDraw == null)
					{
						game.TaskQueue.StartEvent();
						game.TriggerManager.OnDrawTrigger(playable);
						game.ProcessTasks();
						game.TaskQueue.EndEvent();
					}

					ISimpleTask task = playable.Power?.TopdeckTask;
					if (task != null)
					{
						if (game.History)
						{
							// TODO: triggerkeyword: TOPDECK
							game.PowerHistory.Add(
								PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, playable.Id, "", 0, 0));
						}

						c.SetasideZone.Add(c.HandZone.Remove(playable));

						game.Log(LogLevel.INFO, BlockType.TRIGGER, "TOPDECK",
							!game.Logging ? "" : $"{playable}'s TOPDECK effect is activated.");

						task.Process(game, c, playable, null);

						if (game.History)
							game.PowerHistory.Add(
								PowerHistoryBuilder.BlockEnd());
					}
				}

				return playable;
			};

		private static Func<Controller, bool> PreDrawPhase
			=> delegate (Controller c)
			{
				if (c.DeckZone.IsEmpty)
				{
					int fatigueDamage = c.Hero.Fatigue == 0 ? 1 : c.Hero.Fatigue + 1;
					DamageCharFunc(c.Hero, c.Hero, fatigueDamage, false);
					return false;
				}
				return true;
			};

		private static Func<Controller, IPlayable, IPlayable> DrawPhase
			=> delegate (Controller c, IPlayable cardToDraw)
			{
				IPlayable playable = c.DeckZone.Draw(cardToDraw);

				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "DrawPhase", !c.Game.Logging ? "" : $"{c.Name} draws {playable}");

				c.NumCardsDrawnThisTurn++;
				c.LastCardDrawn = playable.Id;

				return playable;
			};

		public static IPlayable Draw(Controller c, int index)
		{
			IPlayable playable = c.DeckZone.Remove(index);
			c.Game.Log(LogLevel.INFO, BlockType.ACTION, "DrawPhase", !c.Game.Logging ? "" : $"{c.Name} draws {playable}");

			c.NumCardsDrawnThisTurn++;
			c.LastCardDrawn = playable.Id;

			if (AddHandPhase.Invoke(c, playable))
			{
				// DrawTrigger vs TOPDECK ?? not sure which one is first

				Game game = c.Game;

				game.TaskQueue.StartEvent();
				game.TriggerManager.OnDrawTrigger(playable);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();
				
				ISimpleTask task = playable.Power?.TopdeckTask;
				if (task != null)
				{
					if (game.History)
					{
						// TODO: triggerkeyword: TOPDECK
						game.PowerHistory.Add(
							PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, playable.Id, "", 0, 0));
					}

					c.SetasideZone.Add(c.HandZone.Remove(playable));

					game.Log(LogLevel.INFO, BlockType.TRIGGER, "TOPDECK",
						!game.Logging ? "" : $"{playable}'s TOPDECK effect is activated.");

					task.Process(game, c, playable, null);

					if (game.History)
						game.PowerHistory.Add(
							PowerHistoryBuilder.BlockEnd());
				}
			}

			return playable;
		}
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
