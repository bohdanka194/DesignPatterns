using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class VisualStudioFacade
    {
        TextEditor textEditor;
        Compiler compiler;
        CLR clr;
        public VisualStudioFacade(TextEditor textEditor,Compiler compiler, CLR clr)
        {
            this.textEditor = textEditor;
            this.compiler = compiler;
            this.clr = clr;
        }

        public void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            compiler.Compile();
            clr.Execute();
        }
        public void Stop()
        {
            clr.Finish();
        }
    }
}
