using CoolSmFramework.Page;
using OpenQA.Selenium;

namespace CoolSmFramework.CoolSeleniumFramework.Elements
{
    public class Button : BaseElement
    {
        public Button(By locator, string name) : base(locator, name)
        {
        }

        public void Submit()
        {
            GetElement(locator).Submit();
        }
    }
}
