﻿using System;
using System.Text;

namespace HSGrammar.Model
{
    class PowerTarget : PowerLogEntry
    {
        public int Id { get; set; }

        public PowerEntity Entitiy { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{GetType().Name}: Id={Id}");
            return str.ToString();
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
