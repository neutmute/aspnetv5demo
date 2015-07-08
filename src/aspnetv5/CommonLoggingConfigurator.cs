using Common.Logging.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetv5
{
    public class CommonLoggingConfigurator
    {
        public static void Go()
        {
            var nvc = new NameValueCollection();
            nvc.Add("configType", "INLINE");
            Common.Logging.LogManager.Adapter = new Common.Logging.NLog.NLogLoggerFactoryAdapter(nvc);
        }
    }
}
