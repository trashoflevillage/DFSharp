using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSharp.DiamondFire.DataStructures
{
    abstract class Plot
    {
        public readonly int playerCount;
        public readonly float cpuUsage;
        public readonly float tps;
        public readonly long timestamp;
    }
}