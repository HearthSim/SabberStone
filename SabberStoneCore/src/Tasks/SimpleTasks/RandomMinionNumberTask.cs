using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RandomMinionNumberTask : SimpleTask
    {
        public RandomMinionNumberTask(EGameTag tag)
        {
            Tag = tag;
        }

        public EGameTag Tag { get; set; }

        public override ETaskState Process()
        {

            var cards = Game.FormatType == EFormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
            var cardsList = cards.Where(p => p.Type == ECardType.MINION && p[Tag] == Number).ToList();
            if (!cardsList.Any())
            {
                return ETaskState.STOP;
            }

            var playable = Entity.FromCard(Controller, Util.Choose(cardsList));
            Playables = new List<IPlayable> { playable };

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomMinionNumberTask(Tag);
            clone.Copy(this);
            return clone;
        }
    }
}