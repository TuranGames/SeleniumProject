using CoolSmFramework.CoolSeleniumFramework.Utils;

namespace CoolSmFramework.Utils
{
    internal static class ConfigReader
    {

        public static string GetValue(String propertyName)
        {
            string path = Directories.ConfigDirectory + "config.json";
            string data = File.ReadAllText(path);
            var values = JsonHandler.JsonToObject<Dictionary<string, string>>(data);
            return values[propertyName];
        }
    }
}