using System;
using SabberStone.Actions;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public enum WeaponTaskType
    {
        EQUIP,
        DESTROY
    }

    public class WeaponTask : SimpleTask
    {
        public WeaponTask(WeaponTaskType taskType, string cardId = "")
        {
            TaskType = taskType;
            CardId = cardId;
        }

        public WeaponTaskType TaskType { get; set; }
        public string CardId { get; set; }

        public override TaskState Process()
        {
            if (TaskType == WeaponTaskType.EQUIP && CardId != null)
            {
                var card = Cards.FromId(CardId);
                var weapon = Entity.FromCard(Controller, card) as Weapon;
                Generic.PlayWeapon.Invoke(Controller, weapon);

                return TaskState.COMPLETE;
            }
            throw new NotImplementedException();
        }

        public override ISimpleTask Clone()
        {
            var clone = new WeaponTask(TaskType, CardId);
            clone.Copy(this);
            return clone;
        }
    }
}