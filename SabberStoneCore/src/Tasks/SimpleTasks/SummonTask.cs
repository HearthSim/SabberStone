using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public enum SummonSide { DEFAULT, LEFT, RIGHT}
	public class SummonTask : SimpleTask
	{
		private SummonTask(Card card = null, bool removeFromStack = false, bool numberZonePositionFlag = false, SummonSide side = SummonSide.DEFAULT)
		{
			Card = card;
			RemoveFromStack = removeFromStack;
			NumberZonePositionFlag = numberZonePositionFlag;
			Side = side;
		}

		public SummonTask(Card card = null, bool removeFromStack = false, bool numberZonePositionFlag = false)
		{
			Card = card;
			RemoveFromStack = removeFromStack;
			NumberZonePositionFlag = numberZonePositionFlag;
			Side = SummonSide.DEFAULT;
		}

		public SummonTask(string cardId, SummonSide side = SummonSide.DEFAULT)
		{
			Card = Cards.FromId(cardId);
			RemoveFromStack = false;
			NumberZonePositionFlag = false;
			Side = side;
		}

		public Card Card { get; set; }

		public bool RemoveFromStack { get; set; }

		public bool NumberZonePositionFlag { get; set; }

		public SummonSide Side { get; set; }

		public override TaskState Process()
		{
			if (Controller.BoardZone.IsFull)
				return TaskState.STOP;

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

			if (Side != SummonSide.DEFAULT && Source is Minion && Source.Zone.Type == Enums.Zone.PLAY)
			{
				int summonPosition = 0;
				switch(Side)
				{
					case SummonSide.LEFT:
						summonPosition = ((Minion)Source).ZonePosition;
						break;
					case SummonSide.RIGHT:
						summonPosition = ((Minion)Source).ZonePosition + 1;
						break;
				}
				bool success = Generic.SummonBlock.Invoke(Controller, summonEntity, summonPosition);
			} else { 
				bool success = Generic.SummonBlock.Invoke(Controller, summonEntity, NumberZonePositionFlag ? Number - 1 : -1);
				//bool success = Generic.SummonBlock.Invoke(Controller, summonEntity, -1);
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SummonTask(Card, RemoveFromStack, NumberZonePositionFlag, Side);
			clone.Copy(this);
			return clone;
		}
	}
}
