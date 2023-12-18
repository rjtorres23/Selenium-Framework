using SeleniumFramework.Pages;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC003 : BaseTest
    {

      
        [Test]
        public void Singup()
        {
            Helpers helpers = new Helpers(Driver);

            // Create an instance of SingUp Page
            SignupLoginPage signupLoginPage = new SignupLoginPage(Driver);

            TestContext.WriteLine("App is launched successfully");
            // Call the LoginLink method on the instance
            bool loginLinkt = signupLoginPage.LoginLink();
            bool loginResult = signupLoginPage.isLoginEmail();

            // Call the method
            bool isloginEmail = signupLoginPage.isLoginPassword();
            bool isLoginPassword = signupLoginPage.isLoginPassword();
            bool isLoginButton = signupLoginPage.isLoginButton();
            // helpers.CaptureScreenshot("TC003");
            Assert.Multiple(() =>
            {
                // Add  assertions 
                Assert.That(loginResult, Is.True, "Login Link is visible.");
                Assert.That(isloginEmail, Is.True, "Login email field is visible.");
                Assert.That(isLoginPassword, Is.True, "Login password field is visible.");
                Assert.That(isLoginButton, Is.True, "Log in click button is visble.");
            });
        }
    }
}
