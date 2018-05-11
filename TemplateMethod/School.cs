using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Enter a school.");
        }
        public override void Study()
        {
            Console.WriteLine("Visit school and do homework");
        }
        public override void GetDocument()
        {
            Console.WriteLine("Get certification from high school");
        }
    }
}
