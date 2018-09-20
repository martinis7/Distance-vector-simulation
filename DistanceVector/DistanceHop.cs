using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceVector
{
    class DistanceHop
    {
        public int Distance { get; set; }
        public int NextHop { get; set; }

        public DistanceHop(int distance, int nextHop)
        {
            Distance = distance;
            NextHop = nextHop;
        }

        public int GetHopByDistance(int distance)
        {
            if (distance == Distance) return NextHop;
            return -1;
        }
    }
}
