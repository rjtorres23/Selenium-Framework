using SeleniumFramework.Pages;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;
using OpenQA.Selenium;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC001
    {

        private IWebDriver _driver;

        public TC001(IWebDriver driver)
        {
            _driver = driver;
            HomePage();
        }
        [Test]
        public void HomePage()
        {
            HomePageMap homePageMap = new HomePageMap(_driver);

            //Helpers.ScrollToBottom();

            bool homepageTitle = homePageMap.isHomePageLoaded();
            Assert.That(homepageTitle, Is.True, "HomePage was successfully Loaded.");
            TestContext.WriteLine("Homepage was successfully loaded");
        }
    }

}
