using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public enum SummonSide {
		// summoning on the last position on the right side
		DEFAULT,
		// summoning left of the minion
		LEFT,
		// summoning right of the minion
		RIGHT,
		// summoning at the last position of the source
		DEATHRATTLE,
		// summoning at a given position in the stack number
		NUMBER,
		// summoning by spell, currently like default
		SPELL
	}

	public class SummonTask : SimpleTask
	{
		public SummonTask(SummonSide side = SummonSide.DEFAULT, Card card = null, bool removeFromStack = false)
		{
			Card = card;
			RemoveFromStack = removeFromStack;
			Side = side;
		}

		public SummonTask(string cardId, SummonSide side)
		{
			Card = Cards.FromId(cardId);
			RemoveFromStack = false;
			Side = side;
		}

		public Card Card { get; set; }

		public bool RemoveFromStack { get; set; }

		public SummonSide Side { get; set; }

		public override TaskState Process()
		{
			if (Controller.BoardZone.IsFull)
			{
				if (Playables.Count > 0)
				{
					var m = Playables[0] as Minion;
					if (m.Zone == null && m.GetNativeGameTag(Enums.GameTag.ZONE) != 0)
					Playables[0].Controller.GraveyardZone.Add(Playables[0]);
				}
				return TaskState.STOP;
			}

			Minion summonEntity = null;
			if (Card != null)
			{
				summonEntity = Entity.FromCard(Controller, Card) as Minion;
			}
			else if (Playables.Count > 0)
			{
				summonEntity = Playables[0] as Minion;
				if (RemoveFromStack)
				{
					Playables.Remove(summonEntity);
				}
			}

			if (summonEntity == null)
				return TaskState.STOP;

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
			var clone = new SummonTask(Side, Card, RemoveFromStack);
			clone.Copy(this);
			return clone;
		}
	}
}
