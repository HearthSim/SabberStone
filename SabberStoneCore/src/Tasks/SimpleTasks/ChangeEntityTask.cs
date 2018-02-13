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
	internal enum ChangeType { RANDOM_SAME_TYPE, OP_CLASS, }

	// Work in process
	// Codes should be cleand up and be merged into Generic.ChangeEntityBlock
    public class ChangeEntityTask : SimpleTask
    {
	    public ChangeEntityTask()
	    {
		    //_type = type;
	    }

	    public override TaskState Process()
	    {
		    if (!(Source is Enchantment e))
		    {
				// Implementation of Lilian Voss
			    IReadOnlyList<Card> randCards = RandomCardTask.GetCardList(Source, CardType.SPELL, Controller.Opponent.HeroClass);
				foreach (IPlayable p in Playables)
			    {
				    if (!(p.Zone is HandZone)) throw new NotImplementedException();

				    Card pick = Util.Choose(randCards);

					p.Card = pick;

					p[GameTag.DISPLAYED_CREATOR] = Source.Id;
			    }

				return TaskState.COMPLETE;
		    }

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
