using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Auto auto = new Auto();
            driver.Travel(auto);

            Camel camel = new Camel();
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            driver.Travel(camelTransport);

            Console.ReadLine();
        }
    }
}
