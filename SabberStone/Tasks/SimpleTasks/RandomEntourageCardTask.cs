using System;
using System.Linq;
using System.Reflection;
using HearthDb.Enums;
using log4net;
using SabberStone.Actions;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class RandomEntourageTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public override TaskState Process()
        {

            var source = Source as IPlayable;
            if (source == null || source.Card.Entourage.Count < 1)
            {
                return TaskState.STOP;
            }
          

            var randomCard = Entity.FromCard(Controller, Cards.FromId(Util<string>.Choose(source.Card.Entourage)));
            Playables.Add(randomCard);

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomEntourageTask();
            clone.Copy(this);
            return clone;
        }
    }
}