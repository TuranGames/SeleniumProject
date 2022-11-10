using NUnit.Framework;
using CoolSmFramework.Page;
using CoolSmFramework.Tests;
using CoolSmFramework.CoolSeleniumFramework.Log;
using log4net;

namespace CoolSmFramework.Test
{
    public class HandlesTest : BaseTest
    {
        private readonly ILog Log = LogHandler.GetLogger(typeof(HandlesTest).Name);
        private readonly HandlesPage _handlesPage = new HandlesPage();
        private readonly MainPage _mainPage = new MainPage();
        [Test(Description = "Check Handles page")]
        public void HandlesTesting()
        {
            _mainPage.OpenMainPage();
            Assert.IsTrue(_mainPage.IsCorrectPage(), " This is not Main Page");
            Log.Info("1th Test Case is Succesful");

            _mainPage.ClickAlertsFrameWindowButton();
            _handlesPage.ClickBrowserWindowsButton();
            Assert.IsTrue(_handlesPage.IsForm("Browser Windows"), " This is not Browser Window Form");
            Log.Info("2th Test Case is Succesful");

            _handlesPage.ClickTabButtonn(); 
            Assert.IsTrue(_handlesPage.NewTabOpened(), " New tab wasn't opened");
            Log.Info("3th Test Case is Succesful");

            _handlesPage.CloseCurrentTab();
            Assert.IsTrue(_handlesPage.IsForm("Browser Windows"), " This is not Browser Window Form");
            Log.Info("4th Test Case is Succesful");

            _handlesPage.ClickElementsButtonn();
            _handlesPage.ClickLinksButtonn();
            Assert.IsTrue(_handlesPage.IsForm("Links"), " This is not Links Form");
            Log.Info("5th Test Case is Succesful");

            _handlesPage.ClickHomeButton(); 
            _handlesPage.SwitchActiveTab();
            Assert.IsTrue(_mainPage.IsCorrectPage(), " This is not Main Page");
            Log.Info("6th Test Case is Succesful");

            _handlesPage.SwitchActiveTab();
            Assert.IsTrue(_handlesPage.IsForm("Links"), " This is not Links Form");
            Log.Info("7th Test Case is Succesful");
        }

    }
}
