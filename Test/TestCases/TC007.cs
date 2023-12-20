using OpenQA.Selenium;
using SeleniumFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC007
    {
        private IWebDriver _driver;

        public TC007(IWebDriver driver)
        {
            _driver = driver;
            TestCase();
        }
        public void TestCase()
        {
            ContactUsPage contactUsPage = new ContactUsPage(_driver);

            Assert.Multiple(() =>
            {
                // Add  assertions 
                Assert.That(contactUsPage.isSubjectVisible(), Is.True, "Subject is visible.");
                Assert.That(contactUsPage.isChooseFileVIsible(), Is.True, "Choose File is visible.");
                Assert.That(contactUsPage.isEmailVisible(), Is.True, "Email is visible.");
                Assert.That(contactUsPage.isMessageVisible(), Is.True, "Message is visible.");
                Assert.That(contactUsPage.isNameVisible(), Is.True, "Name is visible.");
                Assert.That(contactUsPage.isSubmitVIsible(), Is.True, "Submit is visible.");
            });
        }
    }
}
