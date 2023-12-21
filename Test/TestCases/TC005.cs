using SeleniumFramework.TestCases.Base;
using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumFramework.Utility;
using OpenQA.Selenium;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC005
    {
        private IWebDriver _driver;

        public TC005(IWebDriver driver)
        {
            _driver = driver;
            TC005_Verify_sign_up();
        }

        public void TC005_Verify_sign_up()
        {
            Helpers helpers = new Helpers(_driver);

            // Create an instance of HomePageMap
            SignupLoginPage signupLoginPage = new SignupLoginPage(_driver);
            signupLoginPage.LoginLink();
            // Call the method
            signupLoginPage.SignupEnterName();
            helpers.CaptureScreenshot("TC005", "1");
            signupLoginPage.SignupEnterEmail();
            helpers.CaptureScreenshot("TC005", "2");
            signupLoginPage.SignupClick();
            helpers.CaptureScreenshot("TC005", "3");
        }
    }
}