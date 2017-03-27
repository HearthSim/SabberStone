namespace PowerLogInterpreter
{
    public abstract class PowerHistoryEntry
    {
        public PowerType PowerType { get; set; }

        public abstract void Process(PowerGame powerGame);
    }
}