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

        [Test]
        public void TestCase()
        {
            HomePageMap homePageMap = new HomePageMap(_driver);
            Helpers helpers = new Helpers(_driver);
         
                  
            bool homepageTitle = homePageMap.isHomePageLoaded();
            Assert.That(homepageTitle, Is.True, "HomePage was successfully loaded.");
            TestContext.WriteLine("Homepage was successfully loaded");
           
        }

       
    }
}
