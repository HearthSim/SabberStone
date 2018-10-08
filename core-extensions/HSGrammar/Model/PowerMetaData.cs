using System;
using System.Text;

namespace HSGrammar.Model
{
    class PowerMetaData : PowerLogEntry
    {
        public string Meta { get; internal set; }
        public int Data { get; internal set; }
        public int Info { get; internal set; }

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
