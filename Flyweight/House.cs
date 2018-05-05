using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    abstract class House
    {
        public int floors;
        public abstract void Build(double latitude, double longitude);
    }
}
