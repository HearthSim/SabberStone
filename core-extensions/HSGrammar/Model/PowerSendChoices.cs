using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGrammar.Model
{
    class PowerSendChoices : PowerLogEntry
    {
        public int Id { get; set; }

        public string ChoiceType { get; set; }

        public List<PowerEntity> Entities { get; set; } = new List<PowerEntity>();

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{GetType().Name}: Id={Id} ChoiceType={ChoiceType}");
            Entities.ForEach(p => str.AppendLine(p.ToString()));
            return str.ToString();
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
