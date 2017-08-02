using SabberStoneCore.Actions;
using SabberStoneCore.Collections;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System.Linq;

namespace SabberStoneCore.Tasks.SimpleTasks
{

	public class AdaptTask : SimpleTask
    {

        public AdaptTask(EEntityType type)
        {
            Type = type;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var choiceAction = EChoiceAction.ADAPT;
            var targets = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).Select(p => p as IEntity).ToList();
            //var totAdaptCards = new List<Card>()
            //{ 
            //    Cards.FromId("UNG_999t2"),  // [UNG_999t2] Living Spores
            //    Cards.FromId("UNG_999t3"),  // [UNG_999t3] Flaming Claws
            //    Cards.FromId("UNG_999t4"),  // [UNG_999t4] Rocky Carapace
            //    Cards.FromId("UNG_999t5"),  // [UNG_999t5] Liquid Membrane
            //    Cards.FromId("UNG_999t6"),  // [UNG_999t6] Massive
            //    Cards.FromId("UNG_999t7"),  // [UNG_999t7] Lightning Speed
            //    Cards.FromId("UNG_999t8"),  // [UNG_999t8] Crackling Shield
            //    Cards.FromId("UNG_999t10"), // [UNG_999t10] Shrouding Mist
            //    Cards.FromId("UNG_999t13"), // [UNG_999t13] Poison Spit
            //    Cards.FromId("UNG_999t14"), // [UNG_999t14] Volcanic Might
            //};
            var totAdaptCards = Cards.All.Where(p => p.Id.StartsWith("UNG_999t") && p.Type == ECardType.SPELL).ToList();

            var resultCards = new OrderedHashSet<Card>();
            while (resultCards.Count() < 3)
            {
				Card adaptCard = Util.Choose(totAdaptCards);
                resultCards.Add(adaptCard);
                totAdaptCards.Remove(adaptCard);
            }

			bool success = Generic.CreateChoiceCards.Invoke(Controller, Source, targets, EChoiceType.GENERAL, choiceAction, resultCards, null);
            return ETaskState.COMPLETE;
        }


        public override ISimpleTask Clone()
        {
            var clone = new AdaptTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}