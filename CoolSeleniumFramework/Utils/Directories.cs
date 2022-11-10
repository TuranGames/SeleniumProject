
namespace CoolSmFramework.CoolSeleniumFramework.Utils
{
    public static class Directories
    {
        public static string startDirectory { get; } = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public static string LogDirectory { get; } = startDirectory + "/CoolSeleniumFramework/Log/";
        public static string ConfigDirectory { get; } = startDirectory + "/ThirdTask/Config/";
        public static string ResourcesDirectory { get; } = startDirectory + "/CoolSeleniumFramework/Resources/";
    }
}
