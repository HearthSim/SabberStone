using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Enchants;

namespace SabberStoneCore.Model
{
    public class TriggerManager
    {
	    public delegate void TriggerHandler(IEntity sender);

	    public event TriggerHandler DamageTrigger;

	    public void OnDamageTriggered(IEntity sender)
	    {
		    DamageTrigger?.Invoke(sender);
	    }
    }
}
