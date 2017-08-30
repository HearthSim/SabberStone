using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGrammar.Model
{
    class PowerTagChange : PowerLogEntry
    {
        public int Id { get; set; }
        public string Tag { get; internal set; }
        public string Value { get; internal set; }

        public override string ToString()
        {
            return $"{GetType().Name}: ID={Id} Tag={Tag} Value={Value}";
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
