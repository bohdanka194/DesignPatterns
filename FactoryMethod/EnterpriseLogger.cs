using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FactoryMethod
{
    public class EnterpriseLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine(string.Format("LogError, {0} : {1}", "EnterpriseLogger", message));
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(string.Format("LogMessage, {0} : {1}", "EnterpriseLogger", message));
        }

        public void LogVerboseInformation(string message)
        {
            Console.WriteLine(string.Format("LogVerboseInformation, {0} : {1}", "EnterpriseLogger", message));
        }
    }
}