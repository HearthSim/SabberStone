using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RandomEntourageTask : SimpleTask
    {
        public override ETaskState Process()
        {

            var source = Source as IPlayable;
            if (source == null || source.Card.Entourage.Count < 1)
            {
                return ETaskState.STOP;
            }
          
            var randomCard = Entity.FromCard(Controller, Cards.FromId(Util.Choose(source.Card.Entourage)));
            Playables.Add(randomCard);

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomEntourageTask();
            clone.Copy(this);
            return clone;
        }
    }
}