using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
     class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }

        public void Run(Location BallNewLocation)
        {
            Console.WriteLine($"Player {Name} is Running Towards {BallNewLocation} ...");
        }


        public override string ToString()
            => $"Player : {Name} , Team : {Team}";
    }
}
