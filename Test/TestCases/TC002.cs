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
            Login();
        }

        public void Login()
        {
            HomePageMap homePageMap = new HomePageMap(_driver);
            Helpers helpers = new Helpers(_driver);

            TestContext.WriteLine("App is launched successfully");
            // Call the LoginLink method on the instance
            bool loginResult = homePageMap.LoginLink();
            bool subscription = homePageMap.isSubscription();

            helpers.ScrollDown(_driver, 8500);
            Thread.Sleep(2000);
            Assert.That(subscription, Is.True, "Subscription was visible.");


        }


    }
}
