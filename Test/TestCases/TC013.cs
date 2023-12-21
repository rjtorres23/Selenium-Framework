using OpenQA.Selenium;
using SeleniumFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC013
    {
        private IWebDriver _driver;

        public TC013(IWebDriver driver)
        {
            _driver = driver;
            TestCase();
        }
        public void TestCase()
        {
            CommonPage commonPage = new CommonPage(_driver);

            commonPage.clickHome();
        }
    }
}
