using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class BrickHouse : House
    {
        public BrickHouse()
        {
            floors = 5;
        }
        public override void Build(double latitude, double longitude)
        {
            Console.WriteLine("Brick house was built with {2} floors; coordinates: {0} latitude и {1} longitude",
           latitude, longitude, floors);
        }
    }
}
