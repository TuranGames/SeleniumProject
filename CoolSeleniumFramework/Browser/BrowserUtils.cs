using OpenQA.Selenium;
using CoolSmFramework.ThirdTask.Config;
using CoolSmFramework.CoolSeleniumFramework.Browser;
using System.Collections.ObjectModel;

namespace CoolSmFramework.Utils
{
    public static class BrowserUtils
    {
        private static IWebDriver Browser => BrowserFactory.Driver();
        public static void ScrollToElement(By elem)
        {
            JsExecutor.ScrollTo(elem);       
        }

        public static void CloseAndSwitchPage()
        {
            Browser.Close();
            Browser.SwitchTo().Window(Browser.WindowHandles[0]);
        }

        public static void SwitchAndClose()
        {
            Browser.SwitchTo().Window(Browser.WindowHandles[1]);
            Browser.Close();
            Browser.SwitchTo().Window(Browser.WindowHandles[0]);
        }

        public static void SwitchTwoTabs()
        {
            int index = 0;
            int count = Browser.WindowHandles.Count();
            int curindex = Browser.WindowHandles.IndexOf(Browser.CurrentWindowHandle);
            if (curindex + 1 < count)
            {
                index = curindex + 1;
            }
            else
            {
                index = curindex - 1;
            }
            int nextIndex = curindex + 1;

            Browser.SwitchTo().Window(Browser.WindowHandles[index]);
        }

        public static void Open(string url)
        {
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl(ConfigManager.BaseUrl);
            var s = Browser.WindowHandles;
        }

        public static ReadOnlyCollection<string> Tabs()
        {
            return Browser.WindowHandles;
        }
    }
}
