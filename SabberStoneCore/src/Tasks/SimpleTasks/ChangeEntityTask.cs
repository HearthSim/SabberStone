﻿using System.Collections.Generic;
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
		private readonly Race _race;
		private readonly EntityType _type;
		private readonly bool _useRandomCard;
		private CardClass _cardClass;


		public ChangeEntityTask(EntityType type, CardType cardType, CardClass cardClass = CardClass.INVALID,
			Rarity rarity = Rarity.INVALID, Race race = Race.INVALID, bool opClass = false)
		{
			_type = type;
			_cardType = cardType;
			_cardClass = cardClass;
			_opClass = opClass;
			_rarity = rarity;
			_race = race;
			_useRandomCard = true;
		}

		public ChangeEntityTask(string cardId)
		{
			_card = Cards.FromId(cardId);
			_type = EntityType.SOURCE;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (_opClass)
				_cardClass = controller.Opponent.HeroClass;

			if (_useRandomCard)
			{
				IReadOnlyList<Card> randCards =
					RandomCardTask.GetCardList(source, _cardType, _cardClass, race: _race, rarity: _rarity);
				foreach (IPlayable p in IncludeTask.GetEntities(_type, in controller, source, target, stack?.Playables))
				{
					Card pick = Util.Choose(randCards);

					Generic.ChangeEntityBlock.Invoke(controller, p, pick, false);

					//TODO p[GameTag.DISPLAYED_CREATOR] = source.Id;
				}

				return TaskState.COMPLETE;
			}

			foreach (IPlayable p in IncludeTask.GetEntities(_type, in controller, source, target, stack?.Playables))
				Generic.ChangeEntityBlock.Invoke(controller, p, _card, false);

			// TODO p[GameTag.DISPLAYED_CREATOR] = source.Id;

			return TaskState.COMPLETE;
		}
	}
}
