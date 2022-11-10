using CoolSmFramework.CoolSeleniumFramework.Elements;
using CoolSmFramework.ThirdTask.Pages;
using OpenQA.Selenium;

namespace CoolSmFramework.Page
{
    public class MainPage : BasePage
    {
        private readonly static Label UniqueElem = new(By.ClassName("home-content"), "Home Content");
        private readonly Button alertsFrameWindow = new(By.XPath("(//div[@class='card mt-4 top-card'])[3]//div"), "Alert,Frame & Cards");
        private readonly static BaseElement[] UniqueElems = { UniqueElem };
        protected internal MainPage() : base(UniqueElems)
        {
        }

        public void ClickAlertsFrameWindowButton()
        {
            alertsFrameWindow.Click();
        }


    }
}