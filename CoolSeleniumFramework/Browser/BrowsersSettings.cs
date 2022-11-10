using CoolSmFramework.ThirdTask.Config;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace CoolSmFramework.CoolSeleniumFramework.Browser
{
    public static class BrowsersSettings
    {

        public static IWebDriver GetChrome()
        {
            ChromeOptions options = new();
            if (ConfigManager.Incognito == 1)
            {
                options.AddArguments("--incognito");
            }
            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver(options);
        }

        public static IWebDriver GetFirefox()
        {
            FirefoxOptions options = new();
            if (ConfigManager.Incognito == 1)
            {
                options.AddArgument("-private");
            }
            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver(options);
        }
    }
}
