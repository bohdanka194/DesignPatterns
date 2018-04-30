using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BulgerianPizza : Pizza
    {
        public BulgerianPizza() : base("Bulgerian Pizza")
        {
        }

        public override int GetCost()
        {
            return 8;
        }
    }
}
