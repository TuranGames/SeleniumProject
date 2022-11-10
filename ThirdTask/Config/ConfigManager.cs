using CoolSmFramework.Utils;

namespace CoolSmFramework.ThirdTask.Config
{
    public class ConfigManager
    {
        public static string BaseUrl => ConfigReader.GetValue("BaseUrl");
        public static string Browser => ConfigReader.GetValue("Browser");
        public static string TimeSpan => ConfigReader.GetValue("TimeSpan");
        public static int Incognito => Convert.ToInt32(ConfigReader.GetValue("Incognito"));
        public static int ShowLogOnConsole => Convert.ToInt32(ConfigReader.GetValue("ShowLogOnConsole"));
    }
}
