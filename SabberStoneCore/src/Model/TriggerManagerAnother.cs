#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion

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
