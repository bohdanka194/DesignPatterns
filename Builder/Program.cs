using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var tripLaptopBuilder = new TripLaptopBuilder();
            var gamingLaptopBuilder = new GamingLaptopBuilder();
            var shopForYou = new BuyLaptop();

            shopForYou.SetLaptopBuilder(gamingLaptopBuilder);
            shopForYou.ConstructorLaptop();
            Laptop laptop = shopForYou.GetLaptop();
           
            Console.WriteLine(laptop.ToString());

            shopForYou.SetLaptopBuilder(tripLaptopBuilder);
            shopForYou.ConstructorLaptop();
            Laptop laptop2 = shopForYou.GetLaptop();

            Console.WriteLine(laptop2.ToString());

            Console.ReadLine();
        }
    }
}
