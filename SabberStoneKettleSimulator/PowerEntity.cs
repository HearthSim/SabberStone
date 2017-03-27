using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerLogInterpreter
{
    public class PowerEntity
    {
        private Dictionary<String, string> Data;

        public PowerEntity()
        {
            Data = new Dictionary<string, string>();
        }

        internal void Add(string tag, string value)
        {
            if (!Data.ContainsKey(tag))
            {
                Data.Add(tag, value);
            }
            else if (Data[tag] == value)
            {
                //Console.WriteLine("Unchanged add tag submited: tag[" + tag + "] value[" + value + "]");
            }
            else
            {
                Console.WriteLine("Changed add tag submited: tag[" + tag + "] oldvalue[" + Data[tag] + "] newvalue[" + value + "]");
            }
        }

        internal string GetValue(string v)
        {
            string result = null;
            Data.TryGetValue(v, out result);
            return result;
        }

        public string Id
        {
            get { return GetValue("ENTITY_ID"); }
            set { Add("ENTITY_ID", value); }
        }
    }
}
