using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using CoolSmFramework.CoolSeleniumFramework.Browser;

namespace CoolSmFramework.CoolSeleniumFramework.Utils
{
    public static class WaitFor
    {
        private static IWebDriver Browser => BrowserFactory.Driver();
        private static WebDriverWait wait => new WebDriverWait(Browser, TimeSpan.FromSeconds(10));
        public static void DocumentReady()
        {
            wait.Until(wd=>JsExecutor.IsDocumentLoaded());
        }

        public static void ElementsIsInvisible(By by)
        {
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }

        public static void AlertIsPresent()
        {
            wait.Until(ExpectedConditions.AlertIsPresent());
        }

        public static void FrameIsLoaded(By element)
        {
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(element));
        }

        public static void FrameIsLoaded(string text)
        {
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(text));
        }

    }
}
