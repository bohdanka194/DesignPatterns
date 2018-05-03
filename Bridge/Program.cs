using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer freelancer = new FreelanceProgrammer(new CppLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();
            // пришел новый заказ, но теперь нужен c#
            freelancer.Language = new CsharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();

            Console.Read();
        }
    }
}
