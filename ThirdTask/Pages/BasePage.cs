using CoolSmFramework.CoolSeleniumFramework.Forms;
using CoolSmFramework.Page;
using OpenQA.Selenium;

namespace CoolSmFramework.ThirdTask.Pages
{
    public abstract class BasePage:BaseForm
    {
        protected  BasePage(BaseElement[] UniqueElems) : base(UniqueElems)
        {
        }

        public bool IsForm(string text)
        {
            return GetElement(By.ClassName("main-header")).Text == text;
        }
    }
}
