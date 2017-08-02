using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class TransformMinionTask : SimpleTask
    {
        public TransformMinionTask(EEntityType type, int costChange)
        {
            Type = type;
            CostChange = costChange;
        }

        public EEntityType Type { get; set; }
        public int CostChange { get; set; }

        public override ETaskState Process()
        {
            var cards = Game.FormatType == EFormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p => 
            {
                var minions = cards.Where(t => t.Cost == p.Card.Cost + CostChange && t.Type == ECardType.MINION).ToList();
                if (minions.Any())
                {
                    Generic.TransformBlock.Invoke(p.Controller, Util.RandomElement(minions), p as Minion);
                }
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new TransformMinionTask(Type, CostChange);
            clone.Copy(this);
            return clone;
        }
    }
}