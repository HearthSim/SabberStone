using System;
using System.Text;

namespace HSGrammar.Model
{
    public class PowerBlockEnd : PowerLogEntry
    {
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{GetType().Name}:");
            return str.ToString();
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
