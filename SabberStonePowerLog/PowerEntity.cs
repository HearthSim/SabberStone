using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SabberStonePowerLog
{
    public class PowerEntity
    {
        public Dictionary<String, string> Data;

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

        internal void Change(string tag, string value)
        {
            Data[tag] = value;
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

        public override String ToString()
        {
            var str = new StringBuilder();
            str.AppendLine("[" + Id + "]");
            Data.ToList().ForEach(p =>
            {
                str.AppendLine(" - " + p.Key + " -> " + p.Value);
            });
            return str.ToString();
        }

    }
}
