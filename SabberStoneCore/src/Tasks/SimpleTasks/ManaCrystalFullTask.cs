using SabberStoneCore.Actions;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ManaCrystalFullTask : SimpleTask
    {
        public ManaCrystalFullTask(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public override ETaskState Process()
        {
            var success = Generic.ChangeManaCrystal.Invoke(Controller, Amount, true);
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ManaCrystalFullTask(Amount);
            clone.Copy(this);
            return clone;
        }
    }
}