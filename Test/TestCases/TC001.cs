using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFramework.Pages;
using SeleniumFramework.Utility;


namespace SeleniumFramework.Test.TestCases
{
    internal class TC001
    {
        private IWebDriver _driver;

        public TC001(IWebDriver driver)
        {
            _driver = driver;
            TestCase();
        }

        public void TestCase()
        {
            HomePageMap homePageMap = new HomePageMap(_driver);
            Helpers helpers = new Helpers(_driver);

            bool homepageTitle = homePageMap.isHomePageLoaded();
            string baseDir = @"C:\Automation\Selenium-Framework\Reports\RunResult_20231222\Screenshots\TC005\sample.png";
            try
            {
                Assert.That(homepageTitle, Is.True, "HomePage was successfully loaded");
                TestContext.WriteLine("Homepage was successfully loaded");
                helpers.CaptureScreenshot("TC001", "1");
                ExtentReporting.LogInfo("HomePage was successfully loaded");
            }
            catch (AssertionException ex)
            {
                // Log failure details in Extent Report
                helpers.CaptureScreenshot("TC001", "1");
                ExtentReporting.LogFail($"Test case failed: {ex.Message} ", baseDir);
           
            }

        }
    }
}
