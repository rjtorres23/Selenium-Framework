using SeleniumFramework.TestCases.Base;
using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumFramework.Utility;
using OpenQA.Selenium;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC002
    {
        private IWebDriver _driver;

        public TC002(IWebDriver driver)
        {
            _driver = driver;
            TestCase();
        }
        [Test]
        public void TestCase()
        {
            Helpers helpers = new Helpers(_driver);

            // Create an instance of HomePageMap
            HomePageMap homePageMap = new HomePageMap(_driver);

            Assert.That(homePageMap.IsSubscriptionAvailable(), Is.True, "Subscription Visible");
            TestContext.WriteLine("Subscription Visible");
        }
    }
}
