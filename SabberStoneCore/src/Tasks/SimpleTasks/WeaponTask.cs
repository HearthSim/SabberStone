using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class WeaponTask : SimpleTask
    {
        public WeaponTask(string cardId = null)
        {
            CardId = cardId;
        }

        public string CardId { get; set; }

        public override ETaskState Process()
        {
            if (CardId == null && Playables.Count != 1)
            {
                return ETaskState.STOP;
            }

            var weapon = CardId != null ? 
                Entity.FromCard(Controller, Cards.FromId(CardId)) as Weapon :
                Playables[0] as Weapon;

            Generic.PlayWeapon.Invoke(Controller, weapon);

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new WeaponTask(CardId);
            clone.Copy(this);
            return clone;
        }
    }
}