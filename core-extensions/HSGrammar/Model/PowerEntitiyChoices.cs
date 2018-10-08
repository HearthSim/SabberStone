using System;
using System.Collections.Generic;
using System.Text;

namespace HSGrammar.Model
{
    class PowerEntityChoices : PowerLogEntry
    {

        public int Id { get; set; }

        public string Player { get; set; }

        public int TaskList { get; set; }

        public string ChoiceType { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public string Source { get; set; }

        public List<PowerEntity> Entities { get; set; } = new List<PowerEntity>();

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{GetType().Name}: Id={Id} TaskList={TaskList} ChoiceType={ChoiceType} CountMin={Min} CountMax={Max} Source={Source}");
            Entities.ForEach(p => str.AppendLine(p.ToString()));
            return str.ToString();
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
