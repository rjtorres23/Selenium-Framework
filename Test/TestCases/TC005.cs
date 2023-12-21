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
            TestCase();
        }

        public void TestCase()
        {
            Helpers helpers = new Helpers(_driver);

            // Create an instance of HomePageMap
            SignupLoginPage signupLoginPage = new SignupLoginPage(_driver);
            // signupLoginPage.LoginLink();
            // Call the method
            bool signupName = signupLoginPage.SignupEnterName();
            helpers.CaptureScreenshot("TC005", "1");
            bool signupEmail = signupLoginPage.SignupEnterEmail();
            helpers.CaptureScreenshot("TC005", "2");
            bool signupClick = signupLoginPage.SignupClick();
            helpers.CaptureScreenshot("TC005", "3");

            Assert.Multiple(() =>
            {
                // Add  assertions 
                Assert.That(signupName, Is.True, "Signup Name was  successful.");
                Assert.That(signupEmail, Is.True, "Signup Email was  successful.");
                Assert.That(signupClick, Is.True, "Signup Button was  successful.");
            });
        }
    }
}