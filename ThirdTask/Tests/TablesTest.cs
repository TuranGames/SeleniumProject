using NUnit.Framework;
using CoolSmFramework.Page;
using CoolSmFramework.Tests;
using CoolSmFramework.CoolSeleniumFramework.Log;
using log4net;

namespace CoolSmFramework.Test
{
    public class TablesTest : BaseTest
    {
        private readonly ILog Log = LogHandler.GetLogger(typeof(TablesTest).Name);
        private readonly TablesPage _tablePage = new TablesPage();
        private readonly MainPage _mainPage = new MainPage();
        [Test(Description = "Check Tables page")]
        public void TablesTesting()
        {
            _mainPage.OpenMainPage();
            Assert.IsTrue(_mainPage.IsCorrectPage(), " This is not Main Page");
            Log.Info("1th Test Case is Succesful");

            _tablePage.ClickElementsButton();
            _tablePage.ClickWebtablesButton();
            Assert.IsTrue(_tablePage.IsForm("Web Tables"), " This is not Browser Window Form");
            Log.Info("2th Test Case is Succesful");

            _tablePage.ClickAddButton();
            Assert.IsTrue(_tablePage.FormExists(), " Registration form wasn't appeared");
            Log.Info("3th Test Case is Succesful");

            _tablePage.EnterData();
            Assert.IsFalse(_tablePage.FormExists(), " Registration form wasn't closed");
            Assert.IsTrue(_tablePage.UserApeared(), " Data wasn't apeared");
            Log.Info("4th Test Case is Succesful");

            _tablePage.DeleteUser();
            Assert.IsFalse(_tablePage.UserApeared(), " Data wasn't deleted");
            Log.Info("5th Test Case is Succesful");
        }

    }
}
