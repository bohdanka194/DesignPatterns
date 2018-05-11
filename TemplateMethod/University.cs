using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class University: Education
    {
        public override void Enter()
        {
            Console.WriteLine("Enter a university");
        }
        public override void Study()
        {
            Console.WriteLine("Visit lectures");
            Console.WriteLine("Practice!");
        }
        public override void GetDocument()
        {
            Console.WriteLine("Get diploma while graduated");
        }
    }
}
