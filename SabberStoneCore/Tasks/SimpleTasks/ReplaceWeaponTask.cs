using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ReplaceWeaponTask : SimpleTask
	{
		public ReplaceWeaponTask(Card cardWeapon)
		{
			WeaponCard = cardWeapon;
		}
		public ReplaceWeaponTask(string cardIdWeapon)
		{
			WeaponCard = Cards.FromId(cardIdWeapon);
		}

		public Card WeaponCard { get; set; }

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null || Controller == null)
			{
				return TaskState.STOP;
			}
			Controller.Hero.AddWeapon(Entity.FromCard(Controller, WeaponCard) as Weapon);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new ReplaceWeaponTask(WeaponCard);
			clone.Copy(this);
			return clone;
		}
	}
}