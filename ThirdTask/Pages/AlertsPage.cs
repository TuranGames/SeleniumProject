using CoolSmFramework.CoolSeleniumFramework.Elements;
using CoolSmFramework.ThirdTask.Pages;
using OpenQA.Selenium;

namespace CoolSmFramework.Page
{
    public class AlertsPage : BasePage
    {

        private readonly Button alerts = new(By.XPath("(//ul[@class='menu-list'])[3]/child::li[2]"),"Alerts button");
        private readonly static Label UniqueElem = new(By.Id("javascriptAlertsWrapper"), "Check Element");
        private readonly Button chekingAlertButton = new(By.Id("alertButton"), "Checking Alert button");
        private readonly Button confirmgAlertButton = new(By.Id("confirmButton"), "Confirming Alert button");
        private readonly Label confirmgAlertResult = new(By.Id("confirmResult"), "Confirming Alert Result");
        private readonly Button promptingAlertButton = new(By.Id("promtButton"), "Prompting Alert button");
        private readonly Label promtingAlertResult = new(By.Id("promptResult"), "Prompting Alert Result");
        private readonly static BaseElement[] UniqueElems = { UniqueElem };
        protected internal AlertsPage() : base(UniqueElems)
        {
        }

        public void ClickAlertsButton()
        {
            alerts.ClickWithJs();
        }

        public void ClickChekingAlertButton()
        {
            chekingAlertButton.Click();
        }

        public void ClickConfirmingAlertButton()
        {
            confirmgAlertButton.Click();
        }

        public string GetConfirmingAlertResult()
        {
            return confirmgAlertResult.GetText();
        }

        public void ClickPromptingAlertButton()
        {
            promptingAlertButton.Click();
        }

        public string GetPromptingAlertResult()
        {
            return promtingAlertResult.GetText();
        }
    }
}