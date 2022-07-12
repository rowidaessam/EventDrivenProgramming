using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
     class Ball
    {
        public int ID { get; set; }

        Location ballLocation;

        internal Location BallLocation
        {
            get => ballLocation;
            set
            {
                if (value != ballLocation)
                {
                    ballLocation = value;
                   
                    BallLocationChanged?.Invoke(ballLocation);
                  
                }
            }
        }

        
        public event Action<Location> BallLocationChanged;



        public override string ToString()
            => $"Ball {ID} to {ballLocation}";
    }
}
