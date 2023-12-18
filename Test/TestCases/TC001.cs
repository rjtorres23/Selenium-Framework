using SeleniumFramework.Pages;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;
using OpenQA.Selenium;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC001 : BaseTest
    {
        [Test]
        public void HomePage()
        {
            HomePageMap homePageMap = new HomePageMap(Driver);

            //Helpers.ScrollToBottom();

            bool homepageTitle = homePageMap.isHomePageLoaded();
            Assert.That(homepageTitle, Is.True, "HomePage was successfully Loaded.");
            TestContext.WriteLine("Homepage was successfully loaded");
        }
    }

}
