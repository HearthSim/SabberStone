using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

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
		private readonly bool _addToStack;
		private readonly int _amount = 1;

		public SummonTask(SummonSide side = SummonSide.DEFAULT, Card card = null, bool removeFromStack = false, bool addToStack = false, int amount = 1)
		{
			Card = card;
			RemoveFromStack = removeFromStack;
			Side = side;
			_addToStack = addToStack;
			_amount = amount;
		}

		public SummonTask(string cardId, SummonSide side, bool addToStack = false)
		{
			Card = Cards.FromId(cardId);
			RemoveFromStack = false;
			Side = side;
			_addToStack = addToStack;
		}

		public SummonTask(string cardId, int amount)
		{
			Card = Cards.FromId(cardId);
			_amount = amount;
		}

		public Card Card { get; set; }

		public bool RemoveFromStack { get; set; }

		public SummonSide Side { get; set; }

		public override TaskState Process()
		{
			for (int i = 0; i < _amount; ++i)
			{
				if (Controller.BoardZone.IsFull)
				{
					if (Playables.Count > 0)
					{
						var m = Playables[0] as Minion;
						if (m.Zone == null && m.GetNativeGameTag(GameTag.ZONE) != 0)
							Playables[0].Controller.GraveyardZone.Add(Playables[0]);
					}
					return TaskState.STOP;
				}

				Minion summonEntity = null;
				if (Card != null)
				{
					summonEntity = Entity.FromCard(Controller, Card,
						new EntityData.Data
						{
							{GameTag.ZONE, (int)Zone.PLAY},
							{GameTag.DISPLAYED_CREATOR, Source.Id}
						}) as Minion;
					if (_addToStack)
						Playables.Add(summonEntity);
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
			}
			
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SummonTask(Side, Card, RemoveFromStack, _addToStack, _amount);
			clone.Copy(this);
			return clone;
		}
	}
}
