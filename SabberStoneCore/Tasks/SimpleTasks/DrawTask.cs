using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class DrawTask : SimpleTask
    {
        public DrawTask(bool toStack = false)
        {
            ToStack = toStack;
        }

        public bool ToStack { get; set; }

        public override TaskState Process()
        {
            if (Game.Splitting)
            {
                ProccessSplit();
            }

            var drawedCard = Generic.Draw(Controller);

            if (drawedCard == null)
            {
                return TaskState.STOP;
            }

            if (ToStack)
            {
                Playables.Add(drawedCard);
            }

            return TaskState.COMPLETE;
        }

        public void ProccessSplit()
        {

            //if (Game.Splits.Count > 0 || Splits != null && Splits.Count > 0)
            //    return;

            //// EndTurnTask off log here if needed :-)
            ////Util.LogOn(true);

            //Splits = new List<Game> { Controller.Game };

            //var result = new List<Game>();

            //Splits.ForEach(game => Controller.Deck.ToList().ForEach(card =>
            //{
            //    var clone = game.Clone();
            //    Log.Info($"Executing Clone Split {clone.CloneIndex} <-- !!!");
            //    var controller = clone.ControllerById(Controller.Id);
            //    var drawedCard = Generic.Draw(controller, card);
            //    result.Add(clone);
            //}));

            //// EndTurnTask off log here if needed :-)
            ////Util.LogOn(true);

            //Log.Info($"[Game-Split] calculated {result.Count} splits");

            //Splits = result;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DrawTask(ToStack);
            clone.Copy(this);
            return clone;
        }
    }
}