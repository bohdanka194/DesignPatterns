using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4, "VW Golf 5", new PetrolMove());
            car.Move();
            car.Movable = new ElectricMove();
            car.Move();

            Console.Read();
        }
    }
}
