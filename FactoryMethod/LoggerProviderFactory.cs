using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class LoggerProviderFactory
    {
        public static ILogger GetLoggerProvider(LoggingProvider loggerProviders)
        {
            switch(loggerProviders)
            {
                case LoggingProvider.EnterpriseLogger:
                    return new EnterpriseLogger();
                case LoggingProvider.Log4NetLogger:
                    return new Log4NetLogger();
                default:
                    return new EnterpriseLogger();
            }
        }
    }
}
