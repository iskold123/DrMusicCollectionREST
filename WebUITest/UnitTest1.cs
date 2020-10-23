using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebUITest
{
    // C:\BrowserDrivers
    [TestClass]
    public class UnitTest1
    {
        private const string DriveFolder = "C:\\BrowserDrivers";

        // http://chromedriver.chromium.org/downloads

        private static IWebDriver _driver;

        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            _driver = new ChromeDriver(DriveFolder);
            //_driver = new FirefoxDriver(DriveFolder);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose(); // close the browser
        }

        [TestMethod]
        public void TitleTest()
        {
            _driver.Navigate().GoToUrl("https://drmusichtml.azurewebsites.net/");
            string title = _driver.Title;

            Assert.AreEqual("DR Records", title);
        }

        [TestMethod]
        public void TestAfArtist()
        {
            _driver.Navigate().GoToUrl("https://drmusichtml.azurewebsites.net/");
            //_driver.Navigate().GoToUrl("http://localhost:3000/");

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1));
            IWebElement records = wait.Until(d => d.FindElement(By.Id("recordsId")));
            Assert.IsTrue(records.Text.Contains("Tessa"));

        }

    }
}
