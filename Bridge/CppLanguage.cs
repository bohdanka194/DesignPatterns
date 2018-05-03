using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CppLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("С помощью компилятора C++ компилируем программу в бинарный код");
        }

        public void Execute()
        {
            Console.WriteLine("Запускаем исполняемый файл программы");
        }
    }
}
