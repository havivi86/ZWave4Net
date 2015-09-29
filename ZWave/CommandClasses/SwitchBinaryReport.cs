﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZWave.Channel;

namespace ZWave.CommandClasses
{
    public class SwitchBinaryReport : NodeReport
    {
        public readonly bool Value;

        internal SwitchBinaryReport(Node node, byte[] payload) : base(node)
        {
            Value = payload[0] == 0xFF;
        }

        public override string ToString()
        {
            return $"Value:{Value}";
        }
    }
}
