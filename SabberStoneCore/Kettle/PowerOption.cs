using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Kettle
{
    public class PowerOptions
    {
        public List<PowerOption> PowerOptionList { get; set; } = new List<PowerOption>();
    }

    public class PowerOption
    {
        public OptionType OptionType { get; set; }

        public PowerSubOption MainOption { get; set; }

        public List<PowerSubOption> SubOptions { get; set; }
    }

    public class PowerSubOption
    {
        public int Id { get; set; }
        public List<int> Targets { get; set; }
    }
}
