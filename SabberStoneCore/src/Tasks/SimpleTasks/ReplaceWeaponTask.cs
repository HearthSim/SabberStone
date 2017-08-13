using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ReplaceWeaponTask : SimpleTask
	{
		public Card WeaponCard { get; set; }

		public ReplaceWeaponTask(Card cardWeapon)
		{
			WeaponCard = cardWeapon;
		}
		public ReplaceWeaponTask(string cardIdWeapon)
		{
			WeaponCard = Cards.FromId(cardIdWeapon);
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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

		public override ISimpleTask InternalClone()
		{
			return new ReplaceWeaponTask(WeaponCard);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}