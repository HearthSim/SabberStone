using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ReplaceHeroTask : SimpleTask
	{
		public Card HeroCard { get; set; }
		public Card WeaponCard { get; set; }
		public Card PowerCard { get; set; }

		public ReplaceHeroTask(Card cardHero, Card cardWeapon, Card cardPower)
		{
			HeroCard = cardHero;
			WeaponCard = cardWeapon;
			PowerCard = cardPower;
		}
		public ReplaceHeroTask(string cardIdHero, string cardIdPower)
		{
			HeroCard = Cards.FromId(cardIdHero);
			PowerCard = Cards.FromId(cardIdPower);
		}
		public ReplaceHeroTask(string cardIdHero, string cardIdWeapon, string cardIdPower)
		{
			HeroCard = Cards.FromId(cardIdHero);
			WeaponCard = Cards.FromId(cardIdWeapon);
			PowerCard = Cards.FromId(cardIdPower);
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null || Controller == null)
			{
				return TaskState.STOP;
			}

			source.Controller.SetasideZone.Add(source.Zone.Remove(source));
			Controller.AddHeroAndPower(HeroCard, PowerCard);
			if (WeaponCard != null)
				Controller.Hero.AddWeapon(Entity.FromCard(Controller, WeaponCard) as Weapon);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new ReplaceHeroTask(HeroCard, WeaponCard, PowerCard);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}

}