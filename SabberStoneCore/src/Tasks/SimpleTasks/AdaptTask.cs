using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class AdaptTask : SimpleTask
	{
		//private static readonly List<Card> TotalAdaptCards = Cards.All.Where(p => p.Id.StartsWith("UNG_999t") && p.Type == CardType.SPELL).ToList();
		private static readonly Card[] TotalAdaptCards =
			Cards.All.Where(p => p.Id.StartsWith("UNG_999t") && p.Type == CardType.SPELL).ToArray();

		public AdaptTask(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//ChoiceAction choiceAction = ChoiceAction.ADAPT;
			//IEnumerable<IPlayable> targets = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);

			//if (!targets.Any())
			//	return TaskState.STOP;

			////var totAdaptCards = new List<Card>()
			////{ 
			////    Cards.FromId("UNG_999t2"),  // [UNG_999t2] Living Spores
			////    Cards.FromId("UNG_999t3"),  // [UNG_999t3] Flaming Claws
			////    Cards.FromId("UNG_999t4"),  // [UNG_999t4] Rocky Carapace
			////    Cards.FromId("UNG_999t5"),  // [UNG_999t5] Liquid Membrane
			////    Cards.FromId("UNG_999t6"),  // [UNG_999t6] Massive
			////    Cards.FromId("UNG_999t7"),  // [UNG_999t7] Lightning Speed
			////    Cards.FromId("UNG_999t8"),  // [UNG_999t8] Crackling Shield
			////    Cards.FromId("UNG_999t10"), // [UNG_999t10] Shrouding Mist
			////    Cards.FromId("UNG_999t13"), // [UNG_999t13] Poison Spit
			////    Cards.FromId("UNG_999t14"), // [UNG_999t14] Volcanic Might
			////};
			//var totAdaptCards = new List<Card>(TotalAdaptCards);

			//var resultCards = new List<Card>();
			//while (resultCards.Count < 3)
			//{
			//	Card adaptCard = Util.Choose<Card>(totAdaptCards);
			//	resultCards.Add(adaptCard);
			//	totAdaptCards.Remove(adaptCard);
			//}

			//bool success = Generic.CreateChoiceCards.Invoke(controller, source, targets, ChoiceType.GENERAL, choiceAction, resultCards.ToList(), null, null);
			//if (!success)
			//	return TaskState.STOP;

			IList<IPlayable> targets = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);

			if (targets.Count == 0)
				return TaskState.STOP;

			Card[] results = TotalAdaptCards.ChooseNElements(3);

			Generic.CreateChoiceCards.Invoke(controller, source, targets, ChoiceType.GENERAL, ChoiceAction.ADAPT,
				results, null, null);

			return TaskState.COMPLETE;
		}
	}
}
