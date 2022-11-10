using OpenQA.Selenium;
using CoolSmFramework.ThirdTask.Config;

namespace CoolSmFramework.CoolSeleniumFramework.Browser
{
    public static class BrowserFactory
    {
        private static IWebDriver? _driver;

        public static IWebDriver Driver()
        {
            if (_driver == null)
            {
                switch (ConfigManager.Browser)
                {
                    case "Chrome":
                        _driver = BrowsersSettings.GetChrome();
                        break;
                    case "FireFox":
                        _driver = BrowsersSettings.GetFirefox();
                        break;
                    default:
                        throw new ArgumentException("Set Correct Browser Name(Chrome,FireFox) in config file");
                        break;
                }
            }
            return _driver;
        }

        public static void Quit()
        {
            _driver.Dispose();
            _driver.Quit();
            _driver = null;
        }
    }
}
