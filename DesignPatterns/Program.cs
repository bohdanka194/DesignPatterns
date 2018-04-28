using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IToyFactory toyFactory = new TeddyToysFactory();
            Bear bear = toyFactory.GetBear();
            Cat cat = toyFactory.GetCat();
            Console.WriteLine("I`ve got {0} and {1}", bear.Name, cat.Name);

            IToyFactory toyFactory2 = new WoodenToysFactory();
            Bear bear2 = toyFactory2.GetBear();
            Cat cat2 = toyFactory2.GetCat();
            Console.WriteLine("I've got {0} and {1}", bear2.Name, cat2.Name);

            Console.ReadLine();
        }
    }
}
