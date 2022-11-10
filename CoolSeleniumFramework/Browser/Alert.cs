using CoolSmFramework.CoolSeleniumFramework.Utils;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace CoolSmFramework.CoolSeleniumFramework.Browser
{
    public static class Alert
    {
        private static string page;
        private static IAlert alert;
        private static IWebDriver Browser => BrowserFactory.Driver();

        public static void Accept()
        {
            Initialize();
            alert.Accept();
            End();
        }

        public static void Dismiss()
        {
            Initialize();
            alert.Dismiss();
            End();
        }

        public static string GetText()
        {
            Initialize();
            string message = alert.Text;
            End();
            return message;
        }

        public static void SendKeys(string text)
        {
            Initialize();
            alert.SendKeys(text);
            End();
        }

        private static void Initialize()
        {
            page = Browser.CurrentWindowHandle;
            WaitFor.AlertIsPresent();
            alert = Browser.SwitchTo().Alert();
            
        }

        private static void End()
        {
            Browser.SwitchTo().Window(page);
        }

        public static bool Exists()
        {
            IAlert alert = ExpectedConditions.AlertIsPresent().Invoke(Browser);
            return (alert != null);
        }

    }
}