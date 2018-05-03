using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class FreelanceProgrammer:Programmer
    {
        public FreelanceProgrammer(ILanguage lang) : base(lang)
        {
        }
        public override void EarnMoney()
        {
            Console.WriteLine("Получаем оплату за выполненный заказ");
        }
    }
}
