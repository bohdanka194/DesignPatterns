using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    class Computer
    {
        public OperationSystem OS { get; set; }
        public void Launch(string osName)
        {
            OS = OperationSystem.getInstance(osName);
        }
    }
}
