using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class AddPermanentEntityTask : SimpleTask
    {
		private readonly Card _card;
		private readonly SummonSide _side;

	    public AddPermanentEntityTask(string cardId, SummonSide side)
	    {
		    _card = Cards.FromId(cardId);
			_side = side;
	    }

	    public AddPermanentEntityTask(Card card)
	    {
		    _card = card;
	    }

	    public override TaskState Process()
	    {
		    Minion permanent = (Minion) Entity.FromCard(Controller, _card);

			
	    }

	    public override ISimpleTask Clone()
	    {
		    throw new NotImplementedException();
	    }
    }
}
