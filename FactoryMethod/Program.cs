using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        { 
            var providerType = GetTypeOfLoggingProviderFromConfigFile();
            ILogger logger = LoggerProviderFactory.GetLoggerProvider(providerType);
            logger.LogMessage("Hello from Factory Method!");
            Console.ReadLine();

        }
        private static LoggingProvider GetTypeOfLoggingProviderFromConfigFile()
        {
            // hardcode
            return LoggingProvider.EnterpriseLogger;
        }
    }
}
