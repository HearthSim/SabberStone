using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ChangeEntityTask : SimpleTask
    {
	    private readonly EntityType _type;
		private readonly CardType _cardType;
		private readonly Rarity _rarity;
		private CardClass _cardClass;
	    private readonly bool _opClass;
	    private readonly bool _useRandomCard;
		private readonly Card _card;


		public ChangeEntityTask(EntityType type, CardType cardType, CardClass cardClass = CardClass.INVALID, Rarity rarity = Rarity.INVALID, bool opClass = false)
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

	    public override TaskState Process()
	    {
			if (_opClass)
				_cardClass = Controller.Opponent.HeroClass;

		    if (_useRandomCard)
		    {
			    IReadOnlyList<Card> randCards = RandomCardTask.GetCardList(Source, _cardType, _cardClass, rarity: _rarity);
			    foreach (IPlayable p in IncludeTask.GetEntities(_type, Controller, Source, Target, Playables))
			    {
				    Card pick = Util.Choose(randCards);

				    Generic.ChangeEntityBlock.Invoke(Controller, p, pick);

				    //TODO p[GameTag.DISPLAYED_CREATOR] = Source.Id;
			    }

			    return TaskState.COMPLETE;
			}

		    foreach (IPlayable p in IncludeTask.GetEntities(_type, Controller, Source, Target, Playables))
		    {
			    Generic.ChangeEntityBlock.Invoke(Controller, p, _card);

			    // TODO p[GameTag.DISPLAYED_CREATOR] = Source.Id;
		    }

			return TaskState.COMPLETE;
	    }

		public override ISimpleTask Clone()
		{
			return new ChangeEntityTask(_type, _cardType, _cardClass, _rarity, _opClass, _card);
		}
    }
}
