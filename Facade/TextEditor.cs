using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("We are writing code.");
        }
        public void Save()
        {
            Console.WriteLine("We are saving code");
        }
    }
}
