using System;
using System.Collections.Generic;
using System.Text;

namespace HSGrammar.Model
{
    class PowerOptions : PowerLogEntry
    {
        public int Id { get; set; }

        public List<PowerOption> Options { get; set; } = new List<PowerOption>();

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{GetType().Name}: Id={Id}");
            return str.ToString();
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
