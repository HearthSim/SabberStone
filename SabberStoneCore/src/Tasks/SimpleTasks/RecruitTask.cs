using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RecruitTask : SimpleTask
	{
		public SummonSide Side { get; set; }
		public bool RemoveFromStack { get; set; }
		public bool RecruitFromStack { get; set; }
		public RecruitTask(bool recruitFromStack = false, SummonSide side = SummonSide.DEFAULT, bool removeFromStack = false)
		{
			Side = side;
			RemoveFromStack = removeFromStack;
			RecruitFromStack = recruitFromStack;
		}

		public override TaskState Process()
		{
			Minion summonEntity = null;
			if (Controller.BoardZone.IsFull)
			{
				return TaskState.STOP;
			}

			if (RecruitFromStack)
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

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RecruitTask(RecruitFromStack, Side, RemoveFromStack);
			clone.Copy(this);
			return clone;
		}
	}
}
