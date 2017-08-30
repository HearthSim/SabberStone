using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGrammar.Model
{
    class PowerCreateGame : PowerLogEntry
    {

        public PowerEntity GameEntity { get; set; }

        public PowerEntity Player1 { get; set; }

        public PowerEntity Player2 { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name}: GameEntity={GameEntity} Player1={Player1} Player2={Player2}";
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
