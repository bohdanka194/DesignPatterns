using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Remote remote = new Remote();
            remote.SetCommand(new TVOnCommand(tv));

            remote.PressButton();
            remote.PressUndo();

            Console.Read();
        }
    }
}
