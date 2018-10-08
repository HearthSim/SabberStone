using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ReplaceHeroTask : SimpleTask
	{
		private readonly Card _heroCard;
		private readonly Card _powerCard;
		private readonly Card _weaponCard;

		public ReplaceHeroTask(Card cardHero, Card cardWeapon, Card cardPower)
		{
			_heroCard = cardHero;
			_weaponCard = cardWeapon;
			_powerCard = cardPower;
		}

		public ReplaceHeroTask(string cardIdHero, string cardIdPower)
		{
			_heroCard = Cards.FromId(cardIdHero);
			_powerCard = Cards.FromId(cardIdPower);
		}

		public ReplaceHeroTask(string cardIdHero, string cardIdWeapon, string cardIdPower)
		{
			_heroCard = Cards.FromId(cardIdHero);
			_weaponCard = Cards.FromId(cardIdWeapon);
			_powerCard = Cards.FromId(cardIdPower);
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var playable = source as IPlayable;
			if (playable == null || controller == null) return TaskState.STOP;

			playable.Controller.SetasideZone.Add(playable.Zone.Remove(playable));
			controller.AddHeroAndPower(_heroCard, _powerCard);
			if (_weaponCard != null)
				controller.Hero.AddWeapon(Entity.FromCard(in controller, in _weaponCard) as Weapon);
			return TaskState.COMPLETE;
		}
	}
}
