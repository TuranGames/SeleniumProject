using OpenQA.Selenium;
using CoolSmFramework.CoolSeleniumFramework.Browser;
using CoolSmFramework.CoolSeleniumFramework.Log;
using log4net;
using CoolSmFramework.ThirdTask.Config;
using CoolSmFramework.CoolSeleniumFramework.Utils;

namespace CoolSmFramework.Page
{
    public abstract class BaseElement
    {
        public readonly By locator;
        protected readonly ILog Log;
        protected readonly string name;
        protected static readonly double time = Convert.ToDouble(ConfigManager.TimeSpan);
        private static IWebDriver Browser => BrowserFactory.Driver();
        protected internal BaseElement(By locator, string name)
        {
            this.Log = LogHandler.GetLogger(name);
            this.name = name;
            this.locator = locator;
        }

        public IWebElement GetElement()
        {
            Log.Info("Getting Element " + locator);
            WaitFor.DocumentReady();
            return Browser.FindElement(locator);

        }
        public IWebElement GetElement(By by)
        {
            Log.Info("Getting Element " + by);
            WaitFor.DocumentReady();
            return Browser.FindElement(by);

        }

        public void Click()
        {
            Log.Info("Clicking");
            GetElement(locator).Click();
        }

        public void ClickWithJs()
        {
            Log.Info("Clicking With Js");
            JsExecutor.Click(locator);
        }

        public void SendKeys(string text)
        {
            Log.Info("Sending Keys " + text);
            GetElement(locator).SendKeys(text);
        }

        public bool Exists()
        {
            if (Browser.FindElements(locator).Count != 0)
            {
                Log.Info("Exists");
                return true;

            }
            Log.Info("Not Exists");
            return false;
        }
        public string GetAttribute(string attribute)
        {
            Log.Info("Getting Attribute " + attribute);
            return GetElement(locator).GetAttribute(attribute);
        }

        public string GetCss(string propertyName)
        {
            Log.Info("Getting Css " + propertyName);
            return GetElement(locator).GetCssValue(propertyName);
        }

        public string GetText()
        {
            Log.Info("Getting Text");
            return GetElement(locator).Text;
        }
    }
}