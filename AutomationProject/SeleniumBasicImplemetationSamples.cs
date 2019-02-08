using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Threading; 

namespace AutomationProject
{
    /// <summary>
    /// Summary description for SeleniumBasicImplemetationSamples
    /// </summary>
    [TestClass]
    [DeploymentItem("IEDriverServer.exe")]
    [DeploymentItem("ChromeDriver.exe")]
    public class SeleniumBasicImplemetationSamples
    {
        public SeleniumBasicImplemetationSamples()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void WebDriverSample()
        {
            // Creates the webdriver for firefox web browser
            IWebDriver webDriver = new FirefoxDriver();
            Thread.Sleep(1000);
            webDriver.Dispose();

            webDriver = new InternetExplorerDriver();
            Thread.Sleep(1000);
            webDriver.Dispose();

            webDriver = new ChromeDriver();
            Thread.Sleep(1000);
            webDriver.Dispose();



        }

        [TestMethod]
        public void WebElementSamples()
        {
            IWebDriver webDriver = new FirefoxDriver();
            webDriver.Navigate().GoToUrl("https://www.lastminutetravel.com/en");
            
            //the following lin works when the page finishes loading
            webDriver.Manage().Window.Maximize();

            IWebElement packagesButton = webDriver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/section/div[2]/div/ul/li[6]/a"));
            packagesButton.Click();

            //was the button actusally selected???
            Assert.AreNotEqual(true, packagesButton.Selected);

            Thread.Sleep(1000);
            webDriver.Dispose();

            
        }
    }
}
