using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SummonTask : SimpleTask
	{
		public SummonTask(Card card = null, bool removeFromStack = false, bool numberZonePositionFlag = false)
		{
			Card = card;
			RemoveFromStack = removeFromStack;
			NumberZonePositionFlag = numberZonePositionFlag;
		}

		public SummonTask(string cardId)
		{
			Card = Cards.FromId(cardId);
			RemoveFromStack = false;
			NumberZonePositionFlag = false;
		}

		public Card Card { get; set; }

		public bool RemoveFromStack { get; set; }

		public bool NumberZonePositionFlag { get; set; }

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

			bool success = Generic.SummonBlock.Invoke(Controller, summonEntity, NumberZonePositionFlag ? Number - 1 : -1);
			//bool success = Generic.SummonBlock.Invoke(Controller, summonEntity, -1);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SummonTask(Card, RemoveFromStack, NumberZonePositionFlag);
			clone.Copy(this);
			return clone;
		}
	}
}
