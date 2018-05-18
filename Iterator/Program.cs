using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Library library = new Library();
            //Reader reader = new Reader();
            //reader.SeeBook(library);
            Derived d = new Derived();
            d.Print();
            Base bd = new Derived();
            bd.Print();
            Base b = new Base();
            b.Print();

            var list = new List<int>() { 3, 4, 5, 10 };
            Console.WriteLine(list.FirstOrDefault(i => i>3));
            Console.Read();
        }
    }
    class Base
    {
        public void Print()
        {
            Console.WriteLine($"calling from {this.GetType().Name}");
        }
    }
    class Derived: Base
    {
        public new void Print()
        {
            Console.WriteLine($"calling from {this.GetType().Name}");
        }
    }
}
