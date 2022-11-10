using NUnit.Framework;
using CoolSmFramework.CoolSeleniumFramework.Browser;
using log4net;
using CoolSmFramework.CoolSeleniumFramework.Log;

namespace CoolSmFramework.Tests
{
    [TestFixture]
    public class BaseTest
    {
        private readonly ILog Log = LogHandler.GetLogger(typeof(BaseTest).Name);
        [SetUp]
        public void Before()
        {     
            Log.Info("New Test--------------------------------------------------------------------------------");
        }

        [OneTimeSetUp]
        public void Init()
        {
            Log.Info("Test Initialized");
        }

        [TearDown]
        public void End()
        {
            Log.Info("Test End");
            BrowserFactory.Quit();
        }

    }
}
