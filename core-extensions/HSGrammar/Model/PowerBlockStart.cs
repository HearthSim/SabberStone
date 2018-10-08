﻿using System;
using System.Text;

namespace HSGrammar.Model
{
    public class PowerBlockStart : PowerLogEntry
    {
        public PowerEntity Entity { get; set; }
        public string BlockType { get; internal set; }
        public int EffectIndex { get; internal set; }
        public PowerEntity Target { get; internal set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{GetType().Name}: Id=");
            return str.ToString();
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
