using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("The car drive on the road");
        }
    }
}
