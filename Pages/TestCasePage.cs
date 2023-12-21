using OpenQA.Selenium;
using SeleniumFramework.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class TestCasePage(IWebDriver driver) : BasePage(driver)
    {
        private By testCase = By.XPath("//b[normalize-space()='Test Cases']");

        public bool isTestCaseVisible()
        {
            return Helper.IsElementVisible(testCase);
        }
    }
}
