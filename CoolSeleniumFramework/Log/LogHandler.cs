using CoolSmFramework.CoolSeleniumFramework.Utils;
using log4net.Appender;
using log4net.Repository.Hierarchy;
using log4net;
using log4net.Config;
using CoolSmFramework.ThirdTask.Config;

namespace CoolSmFramework.CoolSeleniumFramework.Log
{
    public static class LogHandler
    {
        private static ILog Log = null;
        public static ILog GetLogger(string str)
        {
            return makeLogger(str);

        }

        private static ILog makeLogger(string str)
        {
            string configFile;
            if (ConfigManager.ShowLogOnConsole == 1)
            {
                configFile = "/log4net.xml";
            }
            else
            {
                configFile = "/log4netNoConsole.xml";
            }
            Log = LogManager.GetLogger(str);
            XmlConfigurator.Configure(new FileInfo(Directories.LogDirectory + configFile));
            var appender = (LogManager.GetRepository() as Hierarchy).Root.Appenders
            .OfType<FileAppender>()
             .First();

            appender.File = Directories.LogDirectory + "/log.txt";
            appender.ActivateOptions();
            return Log;
        }
    }
}
