using CoolSmFramework.CoolSeleniumFramework.Utils;
using OpenQA.Selenium;

namespace CoolSmFramework.CoolSeleniumFramework.Browser
{
    public static class Frame
    {
        private static IWebDriver Browser => BrowserFactory.Driver();
        public static void SwitchTo(By by)
        {
            WaitFor.FrameIsLoaded(by);
        }
        public static void SwitchTo(string str)
        {
            WaitFor.FrameIsLoaded(str);
        }

        public static void DefaultContent()
        {
            WaitFor.DocumentReady();
            Browser.SwitchTo().DefaultContent();
        }

    }
}
