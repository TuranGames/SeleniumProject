using CoolSmFramework.Page;
using OpenQA.Selenium;

namespace CoolSmFramework.CoolSeleniumFramework.Elements
{
    public  class TextBox : BaseElement
    {
        public TextBox(By locator, string name) : base(locator, name)
        {
        }

        public void ClearAndType(string text)
        {
            GetElement().Clear();
            SendKeys(text);
        }
    }
}
