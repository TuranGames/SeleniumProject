using NUnit.Framework;
using CoolSmFramework.Page;
using CoolSmFramework.Tests;
using CoolSmFramework.CoolSeleniumFramework.Utils;
using CoolSmFramework.CoolSeleniumFramework.Log;
using log4net;
using CoolSmFramework.CoolSeleniumFramework.Browser;

namespace CoolSmFramework.Test
{
    public class AlertsTest : BaseTest
    {
        private readonly ILog Log = LogHandler.GetLogger(typeof(AlertsTest).Name);
        private readonly AlertsPage _alertPage = new AlertsPage();
        private readonly MainPage _mainPage = new MainPage();
        [Test(Description = "Check Alerts page")]
        public void AlertsTesting()
        {

            _mainPage.OpenMainPage();
            Assert.IsTrue(_mainPage.IsCorrectPage(), " This is not Main Page");
            Log.Info("1th Test Case is Succesful");

            _mainPage.ClickAlertsFrameWindowButton();
            _alertPage.ClickAlertsButton();
            Assert.IsTrue(_alertPage.IsForm("Alerts"), " This is not Alert Form");
            Log.Info("2th Test Case is Succesful");

            _alertPage.ClickChekingAlertButton();   
            Assert.IsTrue(Alert.Exists(), " Alert doesn't exist");
            Assert.AreEqual(Alert.GetText(), "You clicked a button", " Alert doesn't exist");
            Log.Info("3th Test Case is Succesful");

            Alert.Accept();
            Assert.IsFalse(Alert.Exists(), " Alert wasn't closed");
            Log.Info("4th Test Case is Succesful");

            _alertPage.ClickConfirmingAlertButton();
            Assert.IsTrue(Alert.Exists(), " Alert doesn't exist");
            Assert.AreEqual(Alert.GetText(), "Do you confirm action?", " Alert doesn't exist");
            Log.Info("5th Test Case is Succesful");

            Alert.Accept();
            Assert.IsFalse(Alert.Exists(), " Alert wasn't closed");
            Assert.AreEqual(_alertPage.GetConfirmingAlertResult(), "You selected Ok", "Incorrect text");
            Log.Info("6th Test Case is Succesful");

            _alertPage.ClickPromptingAlertButton(); 
            Assert.IsTrue(Alert.Exists(), " Alert doesn't exist");
            Assert.AreEqual(Alert.GetText(), "Please enter your name", " Alert doesn't exist");
            Log.Info("7th Test Case is Succesful");

            string randomText = GetRandom.Text();
            Alert.SendKeys(randomText);
            Alert.Accept();
            Assert.IsFalse(Alert.Exists(), " Alert wasn't closed");
            Assert.AreEqual(_alertPage.GetPromptingAlertResult(), "You entered " + randomText, "Incorrect text");
            Log.Info("8th Test Case is Succesful");
        }

    }
}
