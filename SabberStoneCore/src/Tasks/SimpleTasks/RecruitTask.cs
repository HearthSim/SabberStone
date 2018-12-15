#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using SabberStoneCore.Conditions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RecruitTask : SimpleTask
	{
		private readonly SelfCondition[] _conditions;
		public SummonSide Side { get; set; }
		public bool RemoveFromStack { get; set; }
		public bool RecruitFromStack { get; set; }
		public RecruitTask(bool recruitFromStack = false, SummonSide side = SummonSide.DEFAULT, bool removeFromStack = false)
		{
			Side = side;
			RemoveFromStack = removeFromStack;
			RecruitFromStack = recruitFromStack;
		}

		/// <summary>
		/// Recruits a random minion satisfying the given conditions.
		/// </summary>
		/// <param name=""></param>
		public RecruitTask(params SelfCondition[] conditions)
		{
			_conditions = conditions;
		}

		public override TaskState Process()
		{
			Minion summonEntity = null;
			if (Controller.BoardZone.IsFull)
			{
				return TaskState.STOP;
			}

			if (_conditions != null)
			{
				IPlayable[] candidates = Controller.DeckZone.GetAll(p =>
				{
					if (!(p is Minion)) return false;

					bool flag = true;
					for (int i = 0; i < _conditions.Length; i++)
						flag &= _conditions[i].Eval(p);
					return flag;
				});

				if (candidates.Length == 0)
					return TaskState.STOP;

				summonEntity = (Minion)Util.Choose(candidates);
			}
			else if (RecruitFromStack)
			{
				List<Minion> playableMinions = new List<Minion>();
				foreach (var entity in Playables)
				{
					if (entity.Zone.Type == Zone.DECK && entity is Minion)
					{
						playableMinions.Add((Minion)entity);
					}
				}
				if (playableMinions.Count > 0)
				{
					summonEntity = Util.Choose(playableMinions);
					if (RemoveFromStack)
					{
						Playables.Remove(summonEntity);
					}
				}
			}
			else
			{
				List<Minion> playableMinions = new List<Minion>();
				foreach (var entity in Controller.DeckZone)
				{
					if (entity.Zone.Type == Zone.DECK && entity is Minion)
					{
						playableMinions.Add((Minion)entity);
					}
				}
				if (playableMinions.Count > 0)
				{
					summonEntity = Util.Choose(playableMinions);
				}
			}

			if(summonEntity == null)
			{
				return TaskState.STOP;
			}

			Generic.RemoveFromZone.Invoke(summonEntity.Controller, summonEntity);

			int summonPosition = -1;
			switch (Side)
			{
				case SummonSide.LEFT:
					if (Source.Zone.Type == Enums.Zone.PLAY)
						summonPosition = ((Minion)Source).ZonePosition;
					else
						summonPosition = ((Minion)Source).LastBoardPosition;
					break;
				case SummonSide.RIGHT:
					if (Source.Zone.Type == Enums.Zone.PLAY)
						summonPosition = ((Minion)Source).ZonePosition + 1;
					else
						summonPosition = ((Minion)Source).LastBoardPosition;
					break;
				case SummonSide.DEATHRATTLE:
					if (Source.Zone.Type != Zone.GRAVEYARD)
						goto case SummonSide.RIGHT;
					summonPosition = ((Minion)Source).LastBoardPosition;
					break;
				case SummonSide.NUMBER:
					summonPosition = Number - 1;
					break;
				case SummonSide.SPELL:
					summonPosition = -1;
					break;
				case SummonSide.DEFAULT:
					summonPosition = -1;
					break;
			}

			if (summonPosition > Controller.BoardZone.Count)
			{
				summonPosition = Controller.BoardZone.Count;
			}

			bool success = Generic.SummonBlock.Invoke(Controller, summonEntity, summonPosition);

			Game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			RecruitTask clone = _conditions == null
				? new RecruitTask(RecruitFromStack, Side, RemoveFromStack)
				: new RecruitTask(_conditions);
			clone.Copy(this);
			return clone;
		}
	}
}
