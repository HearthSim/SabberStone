using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ReplaceHeroTask : SimpleTask
    {
        public ReplaceHeroTask(Card cardHero, Card cardWeapon, Card cardPower)
        {
            HeroCard = cardHero;
            WeaponCard = cardWeapon;
            PowerCard = cardPower;
        }
        public ReplaceHeroTask(string cardIdHero, string cardIdPower)
        {
            HeroCard = Cards.FromId(cardIdHero);
            PowerCard = Cards.FromId(cardIdPower);
        }
        public ReplaceHeroTask(string cardIdHero, string cardIdWeapon, string cardIdPower)
        {
            HeroCard = Cards.FromId(cardIdHero);
            WeaponCard = Cards.FromId(cardIdWeapon);
            PowerCard = Cards.FromId(cardIdPower);
        }

        public Card HeroCard { get; set; }
        public Card WeaponCard { get; set; }
        public Card PowerCard { get; set; }

        public override TaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null || Controller == null)
            {
                return TaskState.STOP;
            }

            source.Controller.Setaside.Add(source.Zone.Remove(source));
            Controller.AddHeroAndPower(HeroCard, PowerCard);
            if (WeaponCard != null)
                Controller.Hero.AddWeapon(Entity.FromCard(Controller, WeaponCard) as Weapon);
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ReplaceHeroTask(HeroCard, WeaponCard, PowerCard);
            clone.Copy(this);
            return clone;
        }
    }

}