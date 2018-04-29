using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    interface ILogger
    {
        void LogMessage(string message);
        void LogError(string message);
        void LogVerboseInformation(string message);
    }
}
