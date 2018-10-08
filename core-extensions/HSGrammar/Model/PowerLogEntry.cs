namespace HSGrammar.Model
{
    public abstract class PowerLogEntry
    {
        public string PowerLogType { get { return GetType().Name.ToString(); }  }
        public abstract void Process();
    }
}
