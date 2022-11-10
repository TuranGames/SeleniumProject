using CoolSmFramework.CoolSeleniumFramework.Elements;
using CoolSmFramework.CoolSeleniumFramework.Utils;
using CoolSmFramework.ThirdTask.Pages;
using CoolSmFramework.Utils;
using OpenQA.Selenium;

namespace CoolSmFramework.Page
{
    public class HandlesPage : BasePage
    {
        private readonly Button elemnets = new(By.XPath("(//div[@class='element-group'])[1]//div"), "Elements");
        private readonly Button browserWindows = new(By.XPath("(//ul[@class='menu-list'])[3]/child::li[1]"), "Browser Windows button");
        private readonly Button links = new(By.XPath("(//ul[@class='menu-list'])[1]/child::li[6]"), "Links button");
        private readonly Button tabButton = new (By.Id("tabButton"),"Tab Button");
        private readonly Button homeButton = new(By.Id("simpleLink"), "Home Button");
        private readonly static  Button languages = new(By.Id("languages"), "Langauges");
        private readonly static BaseElement[] UniqueElems = { languages };
        protected internal HandlesPage() : base(UniqueElems)
        {
        }

        public bool NewTabOpened()
        {
            if (BrowserUtils.Tabs().Count <= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public void CloseCurrentTab()
        {
            BrowserUtils.SwitchAndClose();
        }

        public void SwitchActiveTab()
        {
            BrowserUtils.SwitchTwoTabs();
            WaitFor.DocumentReady();
        }

        public void ClickBrowserWindowsButton()
        {
            browserWindows.ClickWithJs();
        }

        public void ClickTabButtonn()
        {
            tabButton.Click();
        }

        public void ClickElementsButtonn()
        {
            elemnets.Click();
        }

        public void ClickLinksButtonn()
        {
            links.ClickWithJs();
        }

        public void ClickHomeButton()
        {
            homeButton.Click();
        }
    }
}