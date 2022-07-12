using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
     class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString()
            => $"({X},{Y},{Z})";

        public static bool operator ==(Location L, Location R)
            => (L.X == R?.X) && (L.Y == R?.Y) && (L.Z == R?.Z);

        public static bool operator !=(Location L, Location R)
           => (L.X != R?.X) || (L.Y != R?.Y) || (L.Z != R?.Z);
    }
}
