using CoolSmFramework.CoolSeleniumFramework.Browser;
using CoolSmFramework.CoolSeleniumFramework.Elements;
using CoolSmFramework.ThirdTask.Pages;
using OpenQA.Selenium;

namespace CoolSmFramework.Page
{
    public class FramePage : BasePage
    {
        private readonly Button NestedFrames = new(By.XPath("(//ul[@class='menu-list'])[3]/child::li[4]"), "NestedFrames button");
        private readonly Button Frames = new(By.XPath("(//ul[@class='menu-list'])[3]/child::li[3]"), "Frames button");
        private readonly static Label UniqueElem = new(By.Id("frame1Wrapper"), "Check Element");
        private readonly static BaseElement[] UniqueElems = { UniqueElem };
        private readonly static By parentFrame = By.XPath("//iframe[@id='frame1']");
        private readonly static By childFrame = By.XPath("//iframe[contains(@srcdoc,'<p>Child Iframe</p>')]");
        private readonly static By firstBodyElement = By.XPath("(//body)[1]");
        protected internal FramePage() : base(UniqueElems)
        {
        }

        public bool AreMessagesPresentOnPage()
        {
            bool isPresent = false;
            Frame.SwitchTo(parentFrame);
            string ParentFrameText = GetElement(firstBodyElement).Text;
            Frame.SwitchTo(childFrame);
            string ChildFrameText = GetElement(firstBodyElement).Text;
            if (ParentFrameText == "Parent frame" && ChildFrameText == "Child Iframe")
            {
                isPresent  =  true;
            }
            else
            {
                isPresent =  false;
            }
            Frame.DefaultContent();
            return isPresent;
        }

        public bool AreMessagesEqual()
        {
            bool isEqual = false;
            Frame.SwitchTo("frame1");
            string FirstFrameText = GetElement(firstBodyElement).Text;
            Frame.DefaultContent();
            Frame.SwitchTo("frame2");
            string SecondFrameText = GetElement(firstBodyElement).Text;

            if (FirstFrameText ==  SecondFrameText )
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
            Frame.DefaultContent();
            return isEqual;
        }

        public void ClickNestedFrames()
        {
            NestedFrames.ClickWithJs();
        }

        public void ClickFrames()
        {
            Frames.ClickWithJs();
        }
    }
}