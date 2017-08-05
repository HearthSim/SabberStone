using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Entities.Playables;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ReplaceHeroPower : SimpleTask
    {
        private ReplaceHeroPower(HeroPower power, Card cardPower)
        {
            Power = power;
            PowerCard = cardPower;
        }

        public ReplaceHeroPower()
        {
            Power = null;
            PowerCard = null;
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

        public override ETaskState Process()
        {
            if (Controller == null)
            {
                return ETaskState.STOP;
            }

            if (PowerCard == null && Power == null)
            {
                if (Playables.Count != 1 || !(Playables[0] is HeroPower))
                {
                    return ETaskState.STOP;
                }

                Power = (HeroPower) Playables[0];
            }

            if (PowerCard != null)
            {
                Power = Entity.FromCard(Controller, PowerCard) as HeroPower;
            }

            Power[EGameTag.CREATOR] = Controller.Hero.Id;
            Game.Log(ELogLevel.INFO, EBlockType.PLAY, "ReplaceHeroPower", $"{Controller.Hero} power replaced by {Power}");

            Controller.Hero.Power = Power;

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ReplaceHeroPower(Power, PowerCard);
            clone.Copy(this);
            return clone;
        }
    }
}