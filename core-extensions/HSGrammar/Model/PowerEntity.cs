using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGrammar.Model
{
    public class PowerEntity : Dictionary<string, string>
    {
        public int EntityId
        {
            get
            {
                return int.Parse(this["ENTITY_ID"]);
            }

            set
            {
                this["ENTITY_ID"] = value.ToString();
            }
        }

    }
}
