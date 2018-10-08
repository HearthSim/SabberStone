using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ChangeEntityTask : SimpleTask
	{
		private readonly Card _card;
		private readonly CardType _cardType;
		private readonly bool _opClass;
		private readonly Rarity _rarity;
		private readonly EntityType _type;
		private readonly bool _useRandomCard;
		private CardClass _cardClass;


		public ChangeEntityTask(EntityType type, CardType cardType, CardClass cardClass = CardClass.INVALID,
			Rarity rarity = Rarity.INVALID, bool opClass = false)
		{
			_type = type;
			_cardType = cardType;
			_cardClass = cardClass;
			_opClass = opClass;
			_rarity = rarity;
			_useRandomCard = true;
		}

		public ChangeEntityTask(string cardId)
		{
			_card = Cards.FromId(cardId);
			_type = EntityType.SOURCE;
		}

		private ChangeEntityTask(EntityType et, CardType ct, CardClass cc, Rarity r, bool oc, Card c)
		{
			_type = et;
			_cardType = ct;
			_cardClass = cc;
			_opClass = oc;
			_useRandomCard = ct != CardType.INVALID;
			_card = c;
			_rarity = r;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (_opClass)
				_cardClass = controller.Opponent.HeroClass;

			if (_useRandomCard)
			{
				IReadOnlyList<Card> randCards =
					RandomCardTask.GetCardList(source, _cardType, _cardClass, rarity: _rarity);
				foreach (IPlayable p in IncludeTask.GetEntities(_type, in controller, source, target, stack?.Playables))
				{
					Card pick = Util.Choose(randCards);

					Generic.ChangeEntityBlock.Invoke(controller, p, pick);

					//TODO p[GameTag.DISPLAYED_CREATOR] = source.Id;
				}

				return TaskState.COMPLETE;
			}

			foreach (IPlayable p in IncludeTask.GetEntities(_type, in controller, source, target, stack?.Playables))
				Generic.ChangeEntityBlock.Invoke(controller, p, _card);

			// TODO p[GameTag.DISPLAYED_CREATOR] = source.Id;

			return TaskState.COMPLETE;
		}
	}
}
