using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGrammar.Model
{
    class PowerSendOptions : PowerLogEntry
    {
        public int SelectedOption { get; set; }
        public int SelectedSubOption { get; set; }
        public int SelectedTarget { get; set; }
        public int SelectedPosition { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{GetType().Name}: selectedOption={SelectedOption} selectedSubOption={SelectedSubOption} selectedTarget={SelectedTarget} selectedPosition={SelectedPosition}");
            return str.ToString();
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
