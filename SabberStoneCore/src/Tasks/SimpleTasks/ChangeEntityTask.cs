using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ChangeEntityTask : SimpleTask
    {
	    //private readonly EntityType _type;

	    public ChangeEntityTask(/*EntityType type*/)
	    {
		    //_type = type;
	    }

	    public override TaskState Process()
	    {
		    //foreach (IPlayable p in IncludeTask.GetEntities(_type, Controller, Source, Target, Playables))
		    //{

		    //}

		    if (!(Source is Enchantment e)) throw new NotImplementedException();

			IEntity target = Target;
			IEntity previous = e.Target;

			if (!(previous.Zone is HandZone hand)) throw new NotImplementedException();

			e.Remove();
		    // PowerHistoryChangeEntity ( ... ) send variations of tags, CardId of the target
		    if (previous.Card.Type == target.Card.Type)
		    {
				previous.Card = target.Card;	// TODO
		    }
		    else
		    {
				IPlayable entity = null;
			    switch (target.Card.Type)
			    {
					case CardType.MINION:
						entity = new Minion(Controller, target.Card, previous.NativeTags);
						break;
					case CardType.SPELL:
						entity = new Spell(Controller, target.Card, previous.NativeTags);
						break;
					case CardType.HERO:
						entity = new Hero(Controller, target.Card, previous.NativeTags);
						break;
					case CardType.WEAPON:
						entity = new Weapon(Controller, target.Card, previous.NativeTags);
						break;
					default:
						throw new ArgumentNullException();
				}

			    hand.ChangeEntity((IPlayable)previous, entity);
			    Game.IdEntityDic[previous.Id] = entity;
				previous = entity;
			}

		    if (previous[GameTag.DISPLAYED_CREATOR] == 0)
			    previous[GameTag.DISPLAYED_CREATOR] = e.Creator.Id;
			Generic.AddEnchantmentBlock(Controller, e.Card, e, previous, 0, 0);

		    // TODO choose ones

		    return TaskState.COMPLETE;
	    }

		public override ISimpleTask Clone()
		{
			return new ChangeEntityTask();
		}
    }
}
