using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGrammar.Model
{
    public abstract class PowerLogEntry
    {
        public string PowerLogType { get { return GetType().Name.ToString(); }  }
        public abstract void Process();
    }
}
