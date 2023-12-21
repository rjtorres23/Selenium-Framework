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

        [Test]
        public void Login()
        {
            HomePageMap homePageMap = new HomePageMap(_driver);
            Helpers helpers = new Helpers(_driver);

            TestContext.WriteLine("App is launched successfully");
            // Call the LoginLink method on the instance
            bool loginResult = homePageMap.LoginLink();

            List<Data> data = helpers.JsonReader("C:\\automation\\Selenium-Framework\\Resources\\data.json");

            // Call the method
            bool enterEmailResult = homePageMap.EnterEmail(data[0].Username);
            helpers.CaptureScreenshot("TC002","1");
            bool enterPasswordResult = homePageMap.EnterPassword(data[0].Password);
            helpers.CaptureScreenshot("TC002","2");
            bool loginBtnResult = homePageMap.ClickBtnLogin();
            helpers.CaptureScreenshot("TC002","3");
            Assert.Multiple(() =>
            {
                // Add  assertions 
                Assert.That(loginResult, Is.True, "LoginLink was  successful.");
                Assert.That(enterEmailResult, Is.True, "EnterEmail was  successful.");
                Assert.That(enterPasswordResult, Is.True, "EnterPassword was  successful.");
                Assert.That(loginBtnResult, Is.True, "ClickBtnLogin was  successful.");
            });
        }


    }
}
