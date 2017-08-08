using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class TempManaTask : SimpleTask
    {
        public TempManaTask(int amount)
        {
            Amount = amount;
        }
        public int Amount { get; set; }
        public override TaskState Process()
        {
            Generic.AddTempMana.Invoke(Controller, Amount);

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new TempManaTask(Amount);
            clone.Copy(this);
            return clone;
        }
    }
}