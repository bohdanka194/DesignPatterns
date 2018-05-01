using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            Compiler compiler = new Compiler();
            CLR clr = new CLR();

            VisualStudioFacade facade = new VisualStudioFacade(textEditor, compiler, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(facade);

            Console.Read();

        }
    }
}
