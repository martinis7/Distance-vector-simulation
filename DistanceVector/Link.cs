using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceVector
{
    public struct Link
    {
        public int nodeOne { get; set; }
        public int nodeTwo { get; set; }
        public int value { get; set; }

        public Link(int nodeOne, int nodeTwo, int value)
        {
            this.nodeOne = nodeOne;
            this.nodeTwo = nodeTwo;
            this.value = value;
        }
    }
}
