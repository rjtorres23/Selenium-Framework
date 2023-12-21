using OpenQA.Selenium;
using SeleniumFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC009
    {
        private IWebDriver _driver;

        public TC009(IWebDriver driver)
        {
            _driver = driver;
            TestCase();
        }
        public void TestCase()
        {
            TestCasePage testCasePage = new TestCasePage(_driver);

            Assert.That(testCasePage.isTestCaseVisible(), Is.True, "Test Case is visible");
        }
    }
}
