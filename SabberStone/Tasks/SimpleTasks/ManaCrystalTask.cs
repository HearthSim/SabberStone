using SabberStone.Actions;

namespace SabberStone.Tasks.SimpleTasks
{
    public class ManaCrystalTask : SimpleTask
    {
        public ManaCrystalTask(int amount, bool opponent = false)
        {
            Amount = amount;
            Opponent = opponent;
        }

        public int Amount { get; set; }
        public bool Opponent { get; set; }

        public override TaskState Process()
        {
            var success = Generic.ChangeManaCrystal.Invoke(!Opponent ? Controller : Controller.Opponent, Amount);
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ManaCrystalTask(Amount, Opponent);
            clone.Copy(this);
            return clone;
        }
    }

}