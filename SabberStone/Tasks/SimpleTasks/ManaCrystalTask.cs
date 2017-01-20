using SabberStone.Actions;

namespace SabberStone.Tasks.SimpleTasks
{
    public class ManaCrystalTask : SimpleTask
    {
        public ManaCrystalTask(int amount, bool opponent = false, bool useNumber = false)
        {
            Amount = amount;
            Opponent = opponent;
            UseNumber = useNumber;
        }

        public ManaCrystalTask()
        {
            UseNumber = true;
            Amount = 0;
            Opponent = false;
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

            var success = Generic.ChangeManaCrystal.Invoke(!Opponent ? Controller : Controller.Opponent, Amount);
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ManaCrystalTask(Amount, Opponent, UseNumber);
            clone.Copy(this);
            return clone;
        }
    }

}