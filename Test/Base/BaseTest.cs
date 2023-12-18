using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFramework.Pages;
using SeleniumFramework.Base;
using SeleniumFramework.Utility;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework.TestCases.Base
{
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        [SetUp]
        public void TestSetup()
        {
            var factory = new Factory();
            Driver = factory.CreateBrowser(Network.Local, BrowserType.Edge);
            Driver.Navigate().GoToUrl("https://automationexercise.com/");
        }

        [TearDown]
        public void TestEnding()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
