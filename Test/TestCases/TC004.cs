using SeleniumFramework.TestCases.Base;
using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumFramework.Utility;
using OpenQA.Selenium;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC004
    {
        private IWebDriver _driver;

        public TC004(IWebDriver driver)
        {
            _driver = driver;
            TC004_Verify_logging_in();
        }
        public void TC004_Verify_logging_in()
        {
            Helpers helpers = new Helpers(_driver);

            // Create an instance of HomePageMap
            HomePageMap homePageMap = new HomePageMap(_driver);

            TestContext.WriteLine("App is launched successfully");
            // Call the LoginLink method on the instance
             homePageMap.LoginLink();
            List<Data> data = helpers.JsonReader("C:\\automation\\Selenium-Framework\\Resources\\data.json");
            // Call the method
            homePageMap.EnterEmail(data[0].Username);
            helpers.CaptureScreenshot("TC004", "1");
            homePageMap.EnterPassword(data[0].Username);
            helpers.CaptureScreenshot("TC004", "2");
            homePageMap.ClickBtnLogin();
            helpers.CaptureScreenshot("TC004", "3");
        }
    }
}
