using CoolSmFramework.Page;
using OpenQA.Selenium;

namespace CoolSmFramework.CoolSeleniumFramework.Elements
{
    public  class CheckBox : BaseElement
    {
        public CheckBox(By locator, string name) : base(locator, name)
        {
        }

        public void Check()
        {
            SetState(true);
        }

        public void Uncheck()
        {
            SetState(false);
        }

        public void Toggle()
        {
            SetState(!IsSeleceted());
        }

        private void SetState(bool state)
        {
            if (state != IsSeleceted())
            {
                Click();
            }
        }
        public bool IsSeleceted()
        {
            return GetElement(locator).Selected;
        }
    }
}
