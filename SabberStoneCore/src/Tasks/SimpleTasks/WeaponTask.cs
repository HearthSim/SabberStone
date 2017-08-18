using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class WeaponTask : SimpleTask
	{
		public WeaponTask(string cardId = null)
		{
			CardId = cardId;
		}

		public string CardId { get; set; }

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

		public override ISimpleTask Clone()
		{
			var clone = new WeaponTask(CardId);
			clone.Copy(this);
			return clone;
		}
	}
}