using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class TVOnCommand : ICommand
    {
        TV tv;
        public TVOnCommand(TV tv1)
        {
            tv = tv1;
        }
        public void Execute()
        {
            tv.On();
        }
        public void Undo()
        {
            tv.Off();
        }
    }
}
