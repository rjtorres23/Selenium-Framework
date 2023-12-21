using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFramework.Pages;
using SeleniumFramework.Utility;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC002
    {
        private IWebDriver _driver;

        public TC002(IWebDriver driver)
        {
            _driver = driver;
            HomePage();
        }

        [Test]
        public void HomePage()
        {
            HomePageMap homePageMap = new HomePageMap(_driver);
            Helpers helpers = new Helpers(_driver);
            try
            {
              
                bool homepageTitle = homePageMap.isHomePageLoaded();
                bool subscription = homePageMap.isSubscription();
           
                helpers.ScrollDown(_driver, 8500);
                Thread.Sleep(2000);
                Assert.That(subscription, Is.True, "Subscription was visible.");
                homePageMap.ClickUp();

            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"Error scrolling down: {ex.Message}");
                throw; // Re-throw the exception to mark the test as failed
            }
        }


    }
}
