using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    class OperationSystem
    {
        private static OperationSystem instance;

        public string Name { get; private set; }

        protected OperationSystem(string name)
        {
            this.Name = name;
        }

        public static OperationSystem getInstance(string name)
        {
            if (instance == null)
                instance = new OperationSystem(name);
            return instance;
        }
    }
}
