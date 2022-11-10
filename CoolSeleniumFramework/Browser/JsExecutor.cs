using OpenQA.Selenium;

namespace CoolSmFramework.CoolSeleniumFramework.Browser
{
    public class JsExecutor
    {
        private static IWebDriver Browser => BrowserFactory.Driver();
        private static IJavaScriptExecutor js => (IJavaScriptExecutor)Browser;

        public static bool IsDocumentLoaded()
        {
            return js.ExecuteScript("return document.readyState").ToString() == "complete";
        }

        public static void ScrollTo(By elem)
        {
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'start'});", Browser.FindElement(elem));
        }

        public static void Click(By elem)
        {
            js.ExecuteScript("arguments[0].click();", Browser.FindElement(elem));
        }
    }
}
