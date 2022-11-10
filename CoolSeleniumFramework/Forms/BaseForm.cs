using CoolSmFramework.CoolSeleniumFramework.Browser;
using CoolSmFramework.CoolSeleniumFramework.Utils;
using CoolSmFramework.Page;
using CoolSmFramework.ThirdTask.Config;
using CoolSmFramework.Utils;
using OpenQA.Selenium;

namespace CoolSmFramework.CoolSeleniumFramework.Forms
{
    public abstract class BaseForm
    {

        protected BaseElement[] CheckElems;
        public BaseForm(BaseElement[] CheckElems)
        {
            this.CheckElems = CheckElems;
        }

        public void OpenMainPage()
        {
            BrowserUtils.Open(ConfigManager.BaseUrl);
        }

        public void ScrolTo(By by)
        {
            BrowserUtils.ScrollToElement(by);
        }

        public void CloseAndSwitchTab()
        {
            BrowserUtils.CloseAndSwitchPage();
        }

        public bool IsCorrectPage()
        {
            bool isCorrect = false;
            foreach (var elem in CheckElems)
            {
                if (elem.Exists())
                {
                    isCorrect = elem.Exists();
                }
                else
                {
                    return false;
                }
            }
            return isCorrect;
        }

        public IWebElement GetElement(By by)
        {
            WaitFor.DocumentReady();
            return BrowserFactory.Driver().FindElement(by);
        }

    }
}
