using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class PanelHouse : House
    {
        public PanelHouse()
        {
            floors = 16;
        }
        public override void Build(double latitude, double longitude)
        {
            Console.WriteLine("Panel house was built with {2} floors; coordinates: {0} latitude и {1} longtitude",
              latitude, longitude,floors);
        }
    }
}
