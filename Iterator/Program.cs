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
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBook(library);

            Console.Read();
        }
    }
}
