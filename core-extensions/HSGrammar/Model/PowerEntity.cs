using System.Collections.Generic;

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
