using HearthDb.Enums;
using log4net;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class ReplaceHeroPower : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private ReplaceHeroPower(HeroPower power, Card cardPower)
        {
            Power = power;
            PowerCard = cardPower;
        }

        public ReplaceHeroPower(HeroPower power)
        {
            Power = power;
            PowerCard = null;
        }

        public ReplaceHeroPower(Card cardPower)
        {
            Power = null;
            PowerCard = cardPower;
        }

        public HeroPower Power { get; set; }

        public Card PowerCard { get; set; }

        public override TaskState Process()
        {
            if (Controller == null)
            {
                return TaskState.STOP;
            }

            if (PowerCard != null)
            {
                Power = Entity.FromCard(Controller, PowerCard) as HeroPower;
            }

            Power[GameTag.CREATOR] = Controller.Hero.Id;
            Log.Info($"{Controller.Hero} power replaced by {Power}");
            Game.PlayTaskLog.AppendLine($"{Controller.Hero} power replaced by {Power}");

            Controller.Hero.Power = Power;

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ReplaceHeroPower(Power, PowerCard);
            clone.Copy(this);
            return clone;
        }
    }
}