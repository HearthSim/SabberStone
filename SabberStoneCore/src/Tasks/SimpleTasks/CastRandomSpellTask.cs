using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Actions;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class CastRandomSpellTask : SimpleTask
    {
		private readonly Func<Card, bool> _condition;

	    private static ConcurrentDictionary<int, List<Card>> CachedCardLists = new ConcurrentDictionary<int, List<Card>>();

	    public CastRandomSpellTask(Func<Card, bool> condition = null)
	    {
		    _condition = condition;
	    }

	    public override TaskState Process()
	    {
			if (_condition != null && !CachedCardLists.TryGetValue(Source.Card.AssetId, out List<Card> cards))
		    {
			    cards = Cards.FormatTypeCards(Game.FormatType)
				    .Where(c => c.Type == CardType.SPELL && _condition(c)).ToList();

			    CachedCardLists.TryAdd(Source.Card.AssetId, cards);
		    }
			else if (!CachedCardLists.TryGetValue(0, out cards))
			{
				cards = Cards.FormatTypeCards(Game.FormatType).Where(c => c.Type == CardType.SPELL && !c.IsQuest).ToList();
				CachedCardLists.TryAdd(0, cards);
			}

		    Card randCard = cards[Random.Next(cards.Count)];

			Spell spellToCast = (Spell) Target ?? (Spell) Entity.FromCard(Source.Controller, randCard);

			ICharacter randTarget = null;
		    if (randCard.RequiresTarget)
		    {
			    List<ICharacter> targets = (List<ICharacter>)spellToCast.ValidPlayTargets;

				randTarget = targets.Count > 0 ? Util.RandomElement(spellToCast.ValidPlayTargets) : null;

			    spellToCast.CardTarget = randTarget?.Id ?? -1;

				Game.Log(LogLevel.INFO, BlockType.POWER, "CastRandomSpellTask",
					!Game.Logging ? "" : $"{spellToCast}'s target is randomly selected to {randTarget}");
			}

			int randChooseOne = Random.Next(1, 3);

		    Generic.PlaySpell.Invoke(Source.Controller, spellToCast, randTarget, randChooseOne);

		    while (Source.Controller.Choice != null)
		    {
			    Generic.ChoicePick.Invoke(Source.Controller, Util.Choose(Source.Controller.Choice.Choices));
		    }

		    Game.OnRandomHappened(true);

		    return TaskState.COMPLETE;
	    }

	    public override ISimpleTask Clone()
	    {
		    return new CastRandomSpellTask(_condition);
	    }
    }
}
