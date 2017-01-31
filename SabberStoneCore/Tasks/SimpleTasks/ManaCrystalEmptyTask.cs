using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ManaCrystalEmptyTask : SimpleTask
    {
        public ManaCrystalEmptyTask(int amount, bool opponent = false, bool useNumber = false)
        {
            Amount = amount;
            Opponent = opponent;
            UseNumber = useNumber;
        }

        public int Amount { get; set; }
        public bool Opponent { get; set; }
        public bool UseNumber { get; set; }

        public override TaskState Process()
        {
            if (UseNumber)
            {
                Amount = Number;
            }

            var success = Generic.ChangeManaCrystal.Invoke(!Opponent ? Controller : Controller.Opponent, Amount, false);
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ManaCrystalEmptyTask(Amount, Opponent, UseNumber);
            clone.Copy(this);
            return clone;
        }
    }
}