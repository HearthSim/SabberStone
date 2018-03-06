//using System.Collections.Generic;
//using SabberStoneCore.Enums;
//using SabberStoneCore.Model.Entities;

//namespace SabberStoneCore.Model
//{
//    public class TriggerManagerAnother
//    {
//	    public delegate void TriggerHandler(IEntity sender);

//	    private class TriggerHandlerComparer : IEqualityComparer<TriggerHandler>
//	    {
//		    public bool Equals(TriggerHandler x, TriggerHandler y)
//		    {
//			    return x.Target == y.Target;
//		    }

//		    public int GetHashCode(TriggerHandler obj)
//		    {
//			    return obj.Target.GetHashCode();
//		    }
//	    }

//	    private static readonly TriggerHandlerComparer Comparer = new TriggerHandlerComparer();

//	    private readonly HashSet<TriggerHandler> _dealDamageTriggers = new HashSet<TriggerHandler>(Comparer);

//	    public void AddTrigger(TriggerType type, TriggerHandler method)
//	    {
//		    switch (type)
//		    {
//				case TriggerType.DEAL_DAMAGE:
//					_dealDamageTriggers.Add(method);
//					return;
//		    }
//	    }

//	    public void RemoveTrigger(TriggerType type, TriggerHandler method)
//	    {
//		    switch (type)
//		    {
//				case TriggerType.DEAL_DAMAGE:
//					_dealDamageTriggers.Remove(method);
//					return;
//		    }
//	    }

//	    internal void OnDealDamageTrigger(IEntity sender)
//	    {
//		    if (_dealDamageTriggers.Count <= 0) return;
//		    foreach (TriggerHandler trigger in _dealDamageTriggers)
//			    trigger(sender);
//	    }
//    }
//}
