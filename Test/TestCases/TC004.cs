using SeleniumFramework.TestCases.Base;
using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumFramework.Utility;
using OpenQA.Selenium;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC004 : BaseTest


    {

    
        public void TC004_Verify_logging_in()
        {
            Helpers helpers = new Helpers(Driver);

            // Create an instance of HomePageMap
            HomePageMap homePageMap = new HomePageMap(Driver);

            TestContext.WriteLine("App is launched successfully");
            // Call the LoginLink method on the instance
             homePageMap.LoginLink();

            // Call the method
            homePageMap.EnterEmail();
            helpers.CaptureScreenshot("TC004", "1");
            homePageMap.EnterPassword();
            helpers.CaptureScreenshot("TC004", "2");
            homePageMap.ClickBtnLogin();
            helpers.CaptureScreenshot("TC004", "3");
        }
    }
}
