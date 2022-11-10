using NUnit.Framework;
using CoolSmFramework.Page;
using CoolSmFramework.Tests;
using CoolSmFramework.CoolSeleniumFramework.Log;
using log4net;

namespace CoolSmFramework.Test
{
    public class FrameTest : BaseTest
    {
        private readonly ILog Log = LogHandler.GetLogger(typeof(FrameTest).Name);
        private readonly FramePage _framePage = new FramePage();
        private readonly MainPage _mainPage = new MainPage();
        [Test(Description = "Check IFrame Page")]
        public void FrameTesting()
        {
            _mainPage.OpenMainPage();
            Assert.IsTrue(_mainPage.IsCorrectPage(), " This is not Main Page");
            Log.Info("1th Test Case is Succesful");

            _mainPage.ClickAlertsFrameWindowButton();
            _framePage.ClickNestedFrames(); 
            Assert.IsTrue(_framePage.IsForm("Nested Frames"), " This is not NestedFrame Form");
            Assert.IsTrue(_framePage.AreMessagesPresentOnPage(), " Messages are not present on page");
            Log.Info("2th Test Case is Succesful");

            _framePage.ClickFrames();
            Assert.IsTrue(_framePage.IsForm("Frames"), " This is not NestedFrame Form");
            Assert.IsTrue(_framePage.AreMessagesEqual(), " Messages are not equal");
            Log.Info("3th Test Case is Succesful");
        }

    }
}
