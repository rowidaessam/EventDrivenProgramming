using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
     class Refree
    {
        public string Name { get; set; }

        public void Look(Location location)
        {
            Console.WriteLine($"Refree {Name} is looking At Ball to {location}");
        }


        public override string ToString() => Name;
    }
}
