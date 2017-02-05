using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class WeaponTask : SimpleTask
    {
        public WeaponTask(string cardId = "")
        {
            CardId = cardId;
        }

        public string CardId { get; set; }

        public override TaskState Process()
        {

            if (CardId == null)
            {
                return TaskState.STOP;
            }

            var card = Cards.FromId(CardId);
            var weapon = Entity.FromCard(Controller, card) as Weapon;
            Generic.PlayWeapon.Invoke(Controller, weapon);
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new WeaponTask(CardId);
            clone.Copy(this);
            return clone;
        }
    }
}