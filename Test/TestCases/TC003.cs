﻿using OpenQA.Selenium;
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
    internal class TC003
    {
        private IWebDriver _driver;

        public TC003(IWebDriver driver)
        {
            _driver = driver;
            TestCase();
        }

        public void TestCase()
        {
            Helpers helpers = new Helpers(_driver);

            // Create an instance of SingUp Page
            SignupLoginPage signupLoginPage = new SignupLoginPage(_driver);

            TestContext.WriteLine("App is launched successfully");

            // Call the method
            bool isloginEmail = signupLoginPage.isLoginEmail();
            bool isLoginPassword = signupLoginPage.isLoginPassword();
            bool isLoginButton = signupLoginPage.isLoginButton();
            helpers.CaptureScreenshot("TC003", "step 1");
            Assert.Multiple(() =>
            {
                // Add  assertions 
                Assert.That(isloginEmail, Is.True, "Login email field is visible.");
                Assert.That(isLoginPassword, Is.True, "Login password field is visible.");
                Assert.That(isLoginButton, Is.True, "Log in click button is visble.");
            });
        }
    }
}
