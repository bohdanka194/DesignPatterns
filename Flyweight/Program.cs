using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            double latitude = 62.34;
            double longitude = 37.73;

            HouseFactory houseFactory = new HouseFactory();
            for (int i = 0; i < 5; i++)
            {
                House panelHouse = houseFactory.GetHouse("Panel");
                if (panelHouse != null)
                    panelHouse.Build(latitude, longitude);
                latitude += 0.1;
                longitude += 0.1;
            }

            for (int i = 0; i < 7; i++)
            {
                House brickHouse = houseFactory.GetHouse("Brick");
                if (brickHouse != null)
                    brickHouse.Build(latitude, longitude);
                latitude += 0.1;
                longitude += 0.1;
            }

            Console.ReadKey();
        }
    }
}
