using System;
using System.Text;

namespace HSGrammar.Model
{
    class PowerFullEntity : PowerLogEntry
    {
        public PowerEntity Entity { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{GetType().Name}: Id=");
            return str.ToString();
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
