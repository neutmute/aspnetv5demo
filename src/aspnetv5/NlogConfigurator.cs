using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace aspnetv5
{
    public class NlogConfigurator
    {
        public static void Go()
        {
            var configOld = LogManager.Configuration;

            ConfigByCode();

            //ConfigByFile();
        }

        /// <summary>
        /// hmmm - where is the config file?
        /// </summary>
        private static void ConfigByFile()
        {
            string assemblyFolder = Path.GetDirectoryName(typeof(NlogConfigurator).Assembly.Location);
            LogManager.Configuration = new XmlLoggingConfiguration(assemblyFolder + "\\NLog.config", true);
        }

        private static void ConfigByCode()
        {
            var config = new LoggingConfiguration();

            var target =
                new FileTarget
                {
                    FileName = @"D:\downloads\aspnetv5.code.nlog.log"
                };

            config.AddTarget("logfile", target);

            var rule = new LoggingRule("*", LogLevel.Debug, target);

            config.LoggingRules.Add(rule);
            LogManager.Configuration = config;
        }
    }
}
