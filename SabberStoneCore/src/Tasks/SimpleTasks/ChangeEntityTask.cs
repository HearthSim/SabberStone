using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	// Work in process
	// Codes should be cleand up and be merged into Generic.ChangeEntityBlock
    public class ChangeEntityTask : SimpleTask
    {
	    private readonly EntityType _type;
		private readonly CardType _cardType;
		private CardClass _cardClass;
	    private readonly bool _opClass;
	    private readonly bool _useRandomCard;
		private readonly Card _card;



		public ChangeEntityTask(EntityType type, CardType cardType, CardClass cardClass = CardClass.INVALID, bool opClass = false)
	    {
			_type = type;
			_cardType = cardType;
			_cardClass = cardClass;
			_opClass = opClass;
			_useRandomCard = true;
	    }

	    public ChangeEntityTask(string cardId)
	    {
		    _card = Cards.FromId(cardId);
	    }

	    private ChangeEntityTask(EntityType et, CardType ct, CardClass cc, bool oc, Card c)
	    {
			_type = et;
			_cardType = ct;
			_cardClass = cc;
			_opClass = oc;
		    _useRandomCard = ct != CardType.INVALID;
			_card = c;
	    }

	    public override TaskState Process()
	    {
			if (_opClass)
				_cardClass = Controller.Opponent.HeroClass;

		    if (_useRandomCard)
		    {
			    IReadOnlyList<Card> randCards = RandomCardTask.GetCardList(Source, _cardType, _cardClass);
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
			return new ChangeEntityTask(_type, _cardType, _cardClass, _opClass, _card);
		}
    }
}
