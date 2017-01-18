using HearthDb.Enums;
using SabberStone.Conditions;
using SabberStone.Tasks;

namespace SabberStone.Enchants
{
    internal class Triggers
    {
        public static Trigger Inspire(ISimpleTask task)
        {
            return new TriggerBuilder().Create()
                .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                .TriggerEffect(GameTag.HEROPOWER_ACTIVATIONS_THIS_TURN, 1)
                .SingleTask(task)
                .Build();
        }
    }
}
