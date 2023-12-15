using SeleniumFramework.TestCases.Base;
using NUnit.Framework;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC002 : BaseTest
    {
        [Test]
        public void Login()
        {

            // Create an instance of HomePageMap
            HomePageMap homePageMap = new HomePageMap(Driver);

            TestContext.WriteLine("App is launched successfully");
            // Call the LoginLink method on the instance
            bool loginResult = homePageMap.LoginLink();

            // Call the method
            bool enterEmailResult = homePageMap.EnterEmail();
            bool enterPasswordResult = homePageMap.EnterPassword();
            bool loginBtnResult = homePageMap.ClickBtnLogin();
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
