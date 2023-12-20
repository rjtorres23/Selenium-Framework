using OpenQA.Selenium;
using SeleniumFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC008
    {
        private IWebDriver _driver;

        public TC008(IWebDriver driver)
        {
            _driver = driver;
            TestCase();
        }
        public void TestCase()
        {
            ContactUsPage contactUsPage = new ContactUsPage(_driver);

            contactUsPage.inputName();
            contactUsPage.inputEmail();
            contactUsPage.inputSubject();
            contactUsPage.inputMessage();
            contactUsPage.clickChooseFile();
            contactUsPage.clickSubmit();


        }
    }
}
