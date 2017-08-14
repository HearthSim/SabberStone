using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class WeaponTask : SimpleTask
	{
		public string CardId { get; set; }

		public WeaponTask(string cardId = null)
		{
			CardId = cardId;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (CardId == null && Playables.Count != 1)
			{
				return TaskState.STOP;
			}

			Weapon weapon = CardId != null ?
				Entity.FromCard(Controller, Cards.FromId(CardId)) as Weapon :
				Playables[0] as Weapon;

			Generic.PlayWeapon.Invoke(Controller, weapon);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new WeaponTask(CardId);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}