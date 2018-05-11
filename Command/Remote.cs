using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Remote
    {
        public ICommand command;
        public Remote() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }
        public void PressButton()
        {
            command.Execute();
        }
        public void PressUndo()
        {
            command.Undo();
        }
    }
}
